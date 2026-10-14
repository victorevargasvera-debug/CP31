using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Global.Properties;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000007 RID: 7
	public abstract class LocalService : global::Motorola.CommonCPS.RadioManagement.LocalService.GeneralPackageLoaclService, global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService, global::Motorola.CommonCPS.RadioManagement.LocalService.IGeneralPackageLocalService
	{
		// Token: 0x06000047 RID: 71 RVA: 0x0000AC08 File Offset: 0x00008E08
		protected LocalService()
		{
			int a_ = 13;
			this.c = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("並䜨伪䠬圮ἰ嬲䄴娶唸", a_);
			this.i = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("簦ᤨتᐬ丮ᰰ唲琴ᨶ缸昺䘼ܾ㱀ὂ桄᱆祈晊瑌⹎籐㕒ᑔ穖὘ٚ♜歞ᱠ㽢䡤㱦奨䙪呬๮屰ᕲ㑴婶㽸♺ټ䭾ﲀ\udf82ꢄ\udc86릈Ꚋ뒌벐풔몖\udf98욚ꮞ\udca0ﾢ袤ﲦ馨蚪钬캮鲰햲骶ﾸ욼躾뻂", a_));
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>>();
			list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase), new global::System.Action<global::System.Collections.Specialized.StringCollection>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.a)));
			list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile), new global::System.Action<global::System.Collections.Specialized.StringCollection>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.b)));
			list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile), new global::System.Action<global::System.Collections.Specialized.StringCollection>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.c)));
			list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem), new global::System.Action<global::System.Collections.Specialized.StringCollection>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.d)));
			list.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer), new global::System.Action<global::System.Collections.Specialized.StringCollection>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.e)));
			this.j = list;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>>();
			list2.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase), new global::System.Action<string>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.a)));
			list2.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile), new global::System.Action<string>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.b)));
			list2.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile), new global::System.Action<string>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.c)));
			list2.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem), new global::System.Action<string>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.d)));
			list2.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer), new global::System.Action<string>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.e)));
			this.k = list2;
			base..ctor();
			object obj = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.a;
			lock (obj)
			{
				if (!this.b)
				{
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
					instance.ServerEventArrived = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler)global::System.Delegate.Combine(instance.ServerEventArrived, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler(this.a));
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
					instance2.ServerConnectedEventHandler = (global::System.EventHandler)global::System.Delegate.Combine(instance2.ServerConnectedEventHandler, new global::System.EventHandler(this.a));
					this.b = true;
				}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000AF2C File Offset: 0x0000912C
		public void CheckDatabaseSpaceStatus()
		{
			short num = (short)564068352;
			short num2 = num;
			num = (short)1651163530;
			short num3 = num;
			num = (short)245350794;
			switch (num3 == num)
			{
			}
			num = (short)1450049537;
			if (num != 0)
			{
			}
			num = (short)796983296;
			if (num != 0)
			{
			}
			this.a(null, null);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000AFDC File Offset: 0x000091DC
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num;
			try
			{
				num = (short)1368461090;
				short num2 = num;
				num = (short)1774194466;
				switch (num2 == num)
				{
				}
				num = (short)453640192;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel databaseSpaceStatus = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false).GetDatabaseSpaceStatus();
				global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().DatabaseSpaceWarning(databaseSpaceStatus);
			}
			catch
			{
			}
			num = (short)639893505;
			if (num != 0)
			{
			}
			num = (short)23003136;
			short num3 = num;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000B0B0 File Offset: 0x000092B0
		public bool IsConnected
		{
			get
			{
				short num = (short)926285824;
				short num2 = num;
				num = (short)177344976;
				short num3 = num;
				num = (short)62984656;
				switch (num3 == num)
				{
				}
				num = (short)282984449;
				if (num != 0)
				{
				}
				num = (short)845283328;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false).IsConnected;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000B168 File Offset: 0x00009368
		// (set) Token: 0x0600004C RID: 76 RVA: 0x0000B214 File Offset: 0x00009414
		public string HelpRootDir
		{
			get
			{
				short num = (short)1333198848;
				short num2 = num;
				num = (short)1530261888;
				short num3 = num;
				num = (short)2132341120;
				switch (num3 == num)
				{
				}
				num = (short)1428619265;
				if (num != 0)
				{
				}
				num = (short)1790574592;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1752563712;
				short num2 = num;
				num = (short)1068391252;
				short num3 = num;
				num = (short)1317165908;
				switch (num3 == num)
				{
				}
				num = (short)1083375617;
				if (num != 0)
				{
				}
				num = (short)1681457152;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000B2C8 File Offset: 0x000094C8
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000B378 File Offset: 0x00009578
		public global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate DMMigrationEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)251396096;
				short num2 = num;
				num = (short)453582865;
				short num3 = num;
				num = (short)1420304401;
				switch (num3 == num)
				{
				}
				num = (short)767688704;
				if (num != 0)
				{
				}
				num = (short)443154433;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1572582052;
				short num2 = num;
				num = (short)161591972;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1010761728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1157431296;
				if (num != 0)
				{
				}
				num = (short)1743323137;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004F RID: 79 RVA: 0x0000B424 File Offset: 0x00009624
		// (set) Token: 0x06000050 RID: 80 RVA: 0x0000B4D4 File Offset: 0x000096D4
		public bool IsServerEventLocal
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)110034945;
				if (num != 0)
				{
				}
				num = (short)1384185856;
				short num2 = num;
				num = (short)2069329816;
				short num3 = num;
				num = (short)430208920;
				switch (num3 == num)
				{
				}
				num = (short)210632704;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1889537983;
				short num2 = num;
				num = (short)517148607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2057043968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1610350593;
				if (num != 0)
				{
				}
				num = (short)584384512;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000B584 File Offset: 0x00009784
		public virtual void ValidateRRPJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.JobRequest rq)
		{
			short num = (short)1054493905;
			short num2 = num;
			num = (short)1286360273;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1773207552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)604241920;
			if (num != 0)
			{
			}
			num = (short)1690763265;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000B62C File Offset: 0x0000982C
		private global::System.Text.RegularExpressions.Regex ClientIdPattern
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1552678913;
				if (num != 0)
				{
				}
				num = (short)799014912;
				short num2 = num;
				num = (short)1781076039;
				short num3 = num;
				num = (short)497553479;
				switch (num3 == num)
				{
				}
				num = (short)1221656576;
				if (num != 0)
				{
				}
				return this.i;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000B6E0 File Offset: 0x000098E0
		public bool Connect(bool backgroundconnection = false)
		{
			short num = (short)842748228;
			short num2 = num;
			num = (short)952127812;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1689649152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1053360129;
			if (num != 0)
			{
			}
			num = (short)1005453312;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false).Connect(backgroundconnection);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000B798 File Offset: 0x00009998
		public void Disconnect()
		{
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			short num;
			int num3;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance;
			for (;;)
			{
				IL_0A:
				num = (short)1073617795;
				short num2 = num;
				num = (short)590945155;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1840709632;
					if (num != 0)
					{
					}
					num = (short)1495400449;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_FF;
					case 1:
					{
						num = (short)509476864;
						short num4 = num;
						if (instance.IsConnected)
						{
							num = (short)2132279296;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						return;
					}
					goto IL_91;
				}
				IL_FF:
				instance.Disconnect();
				num = (short)651493378;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_91:
			instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(false, false);
			num = (short)1801650177;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		public virtual void InitializeServices()
		{
			short num = (short)142934017;
			if (num != 0)
			{
			}
			num = (short)433782784;
			short num2 = num;
			num = (short)2076254449;
			short num3 = num;
			num = (short)268771569;
			switch (num3 == num)
			{
			}
			num = (short)449773568;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000B974 File Offset: 0x00009B74
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetRadioInfosBySystem(string groupID, string customId)
		{
			short num = (short)21117459;
			short num2 = num;
			num = (short)224868883;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1705181184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)250871809;
			if (num != 0)
			{
			}
			num = (short)700710912;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000BA1C File Offset: 0x00009C1C
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo> GetSystemRadioInfos(string groupID)
		{
			short num = (short)1846607873;
			if (num != 0)
			{
			}
			num = (short)1329004544;
			short num2 = num;
			num = (short)1133024819;
			short num3 = num;
			num = (short)923964979;
			switch (num3 == num)
			{
			}
			num = (short)871694336;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetSystemInfosbyRadio(string radioID)
		{
			short num = (short)1830810064;
			short num2 = num;
			num = (short)1573122512;
			switch (num2 == num)
			{
			default:
			{
				num = (short)354353152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1629814785;
			if (num != 0)
			{
			}
			num = (short)619577344;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000BB70 File Offset: 0x00009D70
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetASTROSystems(string groupID)
		{
			short num = (short)1448149162;
			short num2 = num;
			num = (short)2145517738;
			switch (num2 == num)
			{
			default:
			{
				num = (short)195231744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)951648257;
			if (num != 0)
			{
			}
			num = (short)1324351488;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000BC18 File Offset: 0x00009E18
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo> GetASTROSystemInfos(string groupID)
		{
			short num = (short)1352577911;
			short num2 = num;
			num = (short)256291703;
			switch (num2 == num)
			{
			default:
			{
				num = (short)660471808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2087059457;
			if (num != 0)
			{
			}
			num = (short)91553792;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetASTRODataProfiles(string groupID)
		{
			short num = (short)113864469;
			short num2 = num;
			num = (short)304115477;
			switch (num2 == num)
			{
			default:
			{
				num = (short)332660736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1761935361;
			if (num != 0)
			{
			}
			num = (short)1248067584;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000BD6C File Offset: 0x00009F6C
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetRadiosByProfile(string groupID, string customId, string profileName)
		{
			short num = (short)1265849938;
			short num2 = num;
			num = (short)1128879698;
			switch (num2 == num)
			{
			default:
			{
				num = (short)957743104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)638058496;
			if (num != 0)
			{
			}
			num = (short)191823873;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000BE18 File Offset: 0x0000A018
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetProfileInfosbyRadio(string radioID)
		{
			short num = (short)1838232731;
			short num2 = num;
			num = (short)1920611483;
			switch (num2 == num)
			{
			default:
			{
				num = (short)732954624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2130968576;
			if (num != 0)
			{
			}
			num = (short)896925697;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000BEC4 File Offset: 0x0000A0C4
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo> GetASTROProfileInfos(string groupID)
		{
			short num = (short)715778963;
			short num2 = num;
			num = (short)1653861267;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1516896256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2077491201;
			if (num != 0)
			{
			}
			num = (short)2119303168;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000BF70 File Offset: 0x0000A170
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo> GetProfileRadioInfos(string groupID)
		{
			short num = (short)282132481;
			if (num != 0)
			{
			}
			num = (short)1862467584;
			short num2 = num;
			num = (short)2000908283;
			short num3 = num;
			num = (short)1665560571;
			switch (num3 == num)
			{
			}
			num = (short)649592832;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000C018 File Offset: 0x0000A218
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTROOtarProfiles(string groupID)
		{
			short num = (short)1897017567;
			short num2 = num;
			num = (short)681128159;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1081278464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)117374976;
			if (num != 0)
			{
			}
			num = (short)1546125313;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000C0C4 File Offset: 0x0000A2C4
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTRORadiosByOtarProfile(string groupID, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo otarProfileInfo)
		{
			short num = (short)167225090;
			short num2 = num;
			num = (short)1874568962;
			switch (num2 == num)
			{
			default:
			{
				num = (short)371392512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)307429377;
			if (num != 0)
			{
			}
			num = (short)1425539072;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000C16C File Offset: 0x0000A36C
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTROOtarProfileInfosbyRadio(string radioID)
		{
			short num = (short)355547599;
			short num2 = num;
			num = (short)991705551;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1107492864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1085669377;
			if (num != 0)
			{
			}
			num = (short)1527316480;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000C218 File Offset: 0x0000A418
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo> GetASTROOtarProfileInfos(string groupID)
		{
			short num = (short)1159659521;
			if (num != 0)
			{
			}
			num = (short)261029888;
			short num2 = num;
			num = (short)176425225;
			short num3 = num;
			num = (short)1454246153;
			switch (num3 == num)
			{
			}
			num = (short)1673854976;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo> GetASTROOtarProfileRadioInfos(string groupID)
		{
			short num = (short)1213985396;
			short num2 = num;
			num = (short)1780609652;
			switch (num2 == num)
			{
			default:
			{
				num = (short)670826496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1612840961;
			if (num != 0)
			{
			}
			num = (short)432537600;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000C36C File Offset: 0x0000A56C
		public virtual void RefreshASTROOtarProfilesForFillUpDown(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> selectedItems)
		{
			short num = (short)1281793930;
			short num2 = num;
			num = (short)996908938;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1080098816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)988676096;
			if (num != 0)
			{
			}
			num = (short)362872833;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000C414 File Offset: 0x0000A614
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> GetRadios(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode)
		{
			short num = (short)1035445432;
			short num2 = num;
			num = (short)1433511096;
			switch (num2 == num)
			{
			default:
			{
				num = (short)311230464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1235746816;
			if (num != 0)
			{
			}
			num = (short)1646723073;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioViewCache(group, workMode);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> GetRadiosForConversion(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group)
		{
			short num = (short)1104172155;
			short num2 = num;
			num = (short)70276219;
			switch (num2 == num)
			{
			default:
			{
				num = (short)40370176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1002242049;
			if (num != 0)
			{
			}
			num = (short)866189312;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioConversionViewCache(group, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000C574 File Offset: 0x0000A774
		public void UpdateSession()
		{
			short num = (short)2000190274;
			short num2 = num;
			num = (short)935754562;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1576206336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1255997441;
			if (num != 0)
			{
			}
			num = (short)1024589824;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).UpdateSession();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000C628 File Offset: 0x0000A828
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> GetTemplate()
		{
			short num = (short)168416409;
			short num2 = num;
			num = (short)1095947417;
			switch (num2 == num)
			{
			default:
			{
				num = (short)632487936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1281818625;
			if (num != 0)
			{
			}
			num = (short)784138240;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateViewCache();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack> GetLanguagePackages()
		{
			short num = (short)720848346;
			short num2 = num;
			num = (short)970343898;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1699282944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1110638592;
			if (num != 0)
			{
			}
			num = (short)1263665153;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.LanguagePackViewCache();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000C788 File Offset: 0x0000A988
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement> GetVoiceAnnouncementPackages()
		{
			short num = (short)231053017;
			short num2 = num;
			num = (short)2027656921;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1344929792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1920139265;
			if (num != 0)
			{
			}
			num = (short)1225981952;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.VoiceAnnouncementViewCache(null);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000C838 File Offset: 0x0000AA38
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates> GetCACertificatesPackages()
		{
			short num = (short)1711266327;
			short num2 = num;
			num = (short)1088281111;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1427767296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)451215361;
			if (num != 0)
			{
			}
			num = (short)1594621952;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.CACertificatesViewCache(null);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles> GetDVRSFilesPackages()
		{
			short num = (short)921042945;
			if (num != 0)
			{
			}
			num = (short)1833959424;
			short num2 = num;
			num = (short)1965777674;
			short num3 = num;
			num = (short)1661362954;
			switch (num3 == num)
			{
			}
			num = (short)909705216;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.i(null);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000C998 File Offset: 0x0000AB98
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TextToSpeech> GetTextToSpeechPackages()
		{
			short num = (short)1019087546;
			short num2 = num;
			num = (short)486476474;
			switch (num2 == num)
			{
			default:
			{
				num = (short)145358848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1296039937;
			if (num != 0)
			{
			}
			num = (short)818348032;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.TextToSpeechViewCache(null);
		}

		// Token: 0x0600006F RID: 111
		public abstract global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> GetFirmwarePackages();

		// Token: 0x06000070 RID: 112 RVA: 0x0000CA48 File Offset: 0x0000AC48
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> GetRadiosUsingConfiguration(global::System.Guid configurationUuid)
		{
			short num = (short)160694273;
			if (num != 0)
			{
			}
			num = (short)1394212864;
			short num2 = num;
			num = (short)2128480034;
			short num3 = num;
			num = (short)1821509410;
			switch (num3 == num)
			{
			}
			num = (short)860094464;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.j(configurationUuid);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> GetRadiosUsingConfigurationWithWorkingCodeplug(global::System.Guid configurationUuid, global::System.Guid excludedRadioUuid)
		{
			short num = (short)524453638;
			short num2 = num;
			num = (short)1841071878;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1779040256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1335164928;
			if (num != 0)
			{
			}
			num = (short)201195521;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.g(configurationUuid, excludedRadioUuid);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		public int GetRadiosCountUsingConfig(global::System.Guid configurationUuid)
		{
			short num = (short)631358433;
			short num2 = num;
			num = (short)1685701601;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2062090240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1062731776;
			if (num != 0)
			{
			}
			num = (short)1090584577;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadiosCountUsingConfig(configurationUuid);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000CC64 File Offset: 0x0000AE64
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption> GetReferencedRadioList(global::System.Guid templateUuid, bool returnWorkingRadiosOnly = false)
		{
			short num = (short)1026420080;
			short num2 = num;
			num = (short)1573645680;
			switch (num2 == num)
			{
			default:
			{
				num = (short)122552320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)678494209;
			if (num != 0)
			{
			}
			num = (short)780468224;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateReferencedRadiosViewCache(templateUuid);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000CD14 File Offset: 0x0000AF14
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> GetCompatibleTemplateSummaryList(global::System.Collections.Generic.List<global::System.Guid> radioUuidList)
		{
			short num = (short)628162561;
			if (num != 0)
			{
			}
			num = (short)260308992;
			short num2 = num;
			num = (short)844507007;
			short num3 = num;
			num = (short)37824383;
			switch (num3 == num)
			{
			}
			num = (short)88932352;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.CompatibleTemplatesViewCache(radioUuidList);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000CDC4 File Offset: 0x0000AFC4
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack> GetPCRLanguagePackLatestByFamily(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily languagePackFamily)
		{
			short num = (short)1104412673;
			if (num != 0)
			{
			}
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetPCRLanguagePackLatestByFamily(languagePackFamily).OfType<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>().ToList<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary>().GetEnumerator())
			{
				num = (short)361103364;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 1:
						goto IL_E9;
					case 2:
					{
						num = (short)1769102659;
						short num3 = num;
						num = (short)1505779011;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E9;
						default:
							goto IL_135;
						}
						break;
					}
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1899036673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.PackageSummary packageSummary = enumerator.Current;
						observableCollection.Add(packageSummary.ToUiModel() as global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack);
						num = (short)1203240960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					}
					IL_B6:
					num = (short)898564099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_85:
					goto IL_B6;
					IL_E9:
					num = (short)1423245314;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_135:
				num = (short)970326016;
				if (num != 0)
				{
				}
			}
			num = (short)2122055680;
			short num4 = num;
			return observableCollection;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000CF74 File Offset: 0x0000B174
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails GetRadioDetailsBySerialNumber(string serialNumber)
		{
			global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceID = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioByDeviceID(serialNumber, false);
			if (radioByDeviceID == null)
			{
				short num = (short)1986339893;
				short num2 = num;
				num = (short)673063989;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1414463488;
					short num3 = num;
					num = (short)900268032;
					if (num != 0)
					{
					}
					num = (short)1340276737;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND);
				}
				}
			}
			return this.GetRadioDetails(radioByDeviceID.Uuid, true);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000D04C File Offset: 0x0000B24C
		public virtual global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails GetRadioDetails(global::System.Guid id, bool loadJobsSynchronously = true)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E7;
				case 1:
					radioDetails.HistoricalJobs = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>(this.GetRadioHistoricalJobs(radio.Uuid, 0, int.MaxValue));
					num2 = (short)493944836;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)767885313;
					if (num2 != 0)
					{
					}
					if (loadJobsSynchronously)
					{
						num2 = (short)721158145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					radioDetails.HistoricalJobs = new global::Motorola.CommonCPS.RadioManagement.LocalService.HistoricalJobViewCache(radio.Uuid);
					num2 = (short)188678144;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_158;
				case 4:
					goto IL_A3;
				case 5:
				{
					if (radio == null)
					{
						num2 = (short)787021831;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioSummary(radio.Uuid);
					num2 = (short)1224933382;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
					if (radioSummary != null)
					{
						radioDetails = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.a(radio);
						radioDetails.TemplateName = radioSummary.TemplateName;
						radioDetails.ConfigurationName = radioSummary.ConfigurationName;
						num2 = (short)1926936790;
						short num3 = num2;
						num2 = (short)1262401750;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1840906240;
							if (num2 != 0)
							{
							}
							num2 = (short)1311375362;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
					}
					num2 = (short)1659371523;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_6D;
				}
				goto IL_30;
			}
			IL_6D:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			IL_A3:
			return radioDetails;
			IL_E7:
			num2 = (short)1117257728;
			short num4 = num2;
			return radioDetails;
			IL_158:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			IL_30:
			radio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadio(id, false);
			num2 = (short)243204101;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000D284 File Offset: 0x0000B484
		private static global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0)
		{
			short num = (short)1741227213;
			short num2 = num;
			num = (short)1574307021;
			switch (num2 == num)
			{
			default:
			{
				num = (short)99614720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)480378881;
			if (num != 0)
			{
			}
			num = (short)1646067712;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails(A_0);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000D330 File Offset: 0x0000B530
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> GetRadioHistoricalJobs(global::System.Guid radioId, int startIndex, int count)
		{
			short num = (short)1805582337;
			if (num != 0)
			{
			}
			num = (short)1086455808;
			short num2 = num;
			num = (short)2055707758;
			short num3 = num;
			num = (short)1190698094;
			switch (num3 == num)
			{
			}
			num = (short)577896448;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListJobsByDeviceUuid(radioId, startIndex, count).Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob, global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.a)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000D418 File Offset: 0x0000B618
		public int GetDeviceRWJobsCount(global::System.Guid radioId)
		{
			short num = (short)901466764;
			short num2 = num;
			num = (short)231885452;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1284308992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)998506497;
			if (num != 0)
			{
			}
			num = (short)444203008;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetDeviceRWJobsCount(radioId);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000D4CC File Offset: 0x0000B6CC
		public void SaveLastSelectedItemSetting<T>(T selectedItem) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			short num = (short)1604386823;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Guid? id;
					if (id != null)
					{
						num = (short)1363607560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6D;
				}
				case 1:
					goto IL_F6;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings settings = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings;
					global::System.Guid? id = selectedItem.ID;
					settings.LastGroup = id.ToString();
					num = (short)796983297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (typeof(T).Equals(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Group)))
					{
						num = (short)437518342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				case 4:
					if (typeof(T).Equals(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Group)))
					{
						num = (short)177733634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				case 5:
					goto IL_18F;
				case 6:
					goto IL_16D;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 8:
				{
					num = (short)107871728;
					short num3 = num;
					num = (short)621936112;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16D;
					default:
						num = (short)1131479040;
						if (num != 0)
						{
						}
						num = (short)1064960001;
						if (num != 0)
						{
						}
						num = (short)1689190404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 9:
				{
					global::System.Guid? id = selectedItem.ID;
					num = (short)511115264;
					short num4 = num;
					num = (short)1234108416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4C:
				if (selectedItem != null)
				{
					num = (short)692649993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6D:
				num = (short)276627459;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16D:
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastGroup = null;
				num = (short)1164967941;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			IL_18F:
			IL_258:
			global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000D73C File Offset: 0x0000B93C
		public global::System.Collections.Generic.List<global::System.Guid> GetLastSelected(object item)
		{
			short num = (short)544866306;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::System.Guid> result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EE;
				case 1:
					return result;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CompressionHelper.Decompress(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.b(item)).TryParseIntoGuidsList(out result))
				{
					num = (short)924274063;
					short num3 = num;
					num = (short)952978831;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EE;
					default:
						num = (short)1242628097;
						if (num != 0)
						{
						}
						num = (short)1630666752;
						if (num != 0)
						{
						}
						num = (short)439484417;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)102170624;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return result;
			IL_EE:
			num = (short)1733558272;
			short num4 = num;
			return global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.a(item).Cast<string>().Select(new global::System.Func<string, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.f)).ToList<global::System.Guid>();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000D89C File Offset: 0x0000BA9C
		private static string b(object A_0)
		{
			short num = (short)2071330823;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_16C;
				case 1:
				{
					if (!(A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer))
					{
						goto IL_235;
					}
					num = (short)1011623843;
					short num3 = num;
					num = (short)1627989923;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						num = (short)1636958208;
						if (num != 0)
						{
						}
						num = (short)951779328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_225;
				case 3:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)
					{
						num = (short)1620508678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2014380036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1832976385;
					if (num != 0)
					{
					}
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)
					{
						num = (short)53870594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)813760520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1B3;
				case 6:
					goto IL_BB;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 8:
				{
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)
					{
						num = (short)1347551237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1229520896;
					short num4 = num;
					num = (short)76021761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_69;
				}
				IL_4C:
				if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)
				{
					num = (short)1916272649;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)971767811;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_69:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedRadiosEncrypt;
			IL_BB:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedOtarProfilesEncrypt;
			IL_16C:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedJobContainersEncrypt;
			IL_1B3:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedAstroSystemsEncrypt;
			IL_225:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedDataProfilesEncrypt;
			IL_235:
			return string.Empty;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000DAE4 File Offset: 0x0000BCE4
		private static global::System.Collections.Specialized.StringCollection a(object A_0)
		{
			short num = (short)336003079;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_16D;
				case 1:
				{
					if (!(A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer))
					{
						goto IL_20C;
					}
					num = (short)625285284;
					short num3 = num;
					num = (short)1357387940;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						num = (short)890437632;
						if (num != 0)
						{
						}
						num = (short)294060032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_1FC;
				case 3:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)
					{
						num = (short)1655767046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)561446916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)
					{
						num = (short)1301282818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)562823176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1B4;
				case 6:
					goto IL_BC;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 8:
				{
					if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)
					{
						num = (short)1249247237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)976224256;
					short num4 = num;
					num = (short)355467265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					goto IL_6A;
				}
				IL_4E:
				if (A_0 is global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)
				{
					num = (short)2002124809;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1624571907;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6A:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedRadios;
			IL_BC:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedOtarProfiles;
			IL_16D:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedJobContainers;
			IL_1B4:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedSystems;
			IL_1FC:
			return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.LastSelectedDataProfiles;
			IL_20C:
			num = (short)936509441;
			if (num != 0)
			{
			}
			return new global::System.Collections.Specialized.StringCollection();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000DD28 File Offset: 0x0000BF28
		public void SaveLastSelectedItemSetting<T>(global::System.Collections.Generic.IEnumerable<T> selectedItems) where T : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			short num = (short)2113470464;
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
				global::System.Action<string> value2;
				global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService<T>.a a;
				for (;;)
				{
					IL_27:
					byte[] a_;
					switch (num2)
					{
					case 0:
						goto IL_22A;
					case 1:
						return;
					case 2:
					{
						global::System.Action<global::System.Collections.Specialized.StringCollection> value;
						if (value != null)
						{
							global::System.Collections.Generic.List<global::System.Guid> list = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.a<T>(selectedItems);
							num = (short)60293120;
							short num3 = num;
							num = (short)130416641;
							if (num != 0)
							{
							}
							num = (short)1148387332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)831641929;
						short num4 = num;
						num = (short)515234121;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C9;
						default:
							num = (short)236191744;
							if (num != 0)
							{
							}
							num = (short)1747386369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_EB;
					case 4:
					{
						global::System.Collections.Generic.List<global::System.Guid> list;
						if (list.Any<global::System.Guid>())
						{
							num = (short)114688008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value2(string.Empty);
						global::System.Action<global::System.Collections.Specialized.StringCollection> value;
						value(new global::System.Collections.Specialized.StringCollection());
						num = (short)1957298185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_C9;
					case 6:
					{
						if (value2 == null)
						{
							num = (short)1789591562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Action<global::System.Collections.Specialized.StringCollection> value = this.j.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>, bool>(a.b)).Value;
						num = (short)105250818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Collections.Generic.List<global::System.Guid> list;
						if (list.TryConvertToByteArray(out a_))
						{
							num = (short)33030149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Action<global::System.Collections.Specialized.StringCollection> value;
						global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.a(list, value);
						num = (short)559153152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)717619207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_204;
					case 10:
						return;
					}
					goto IL_5A;
					IL_C9:
					global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.a(a_, value2);
					num = (short)518324227;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_EB:
				IL_204:
				IL_22A:
				global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
				return;
				IL_5A:
				a = new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService<T>.a();
				a.a = typeof(T);
				value2 = this.k.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>, bool>(a.b)).Value;
				num = (short)1207173126;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000E008 File Offset: 0x0000C208
		private static void a(byte[] A_0, global::System.Action<string> A_1)
		{
			short num = (short)295668974;
			short num2 = num;
			num = (short)1870957806;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1500119040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)984219649;
			if (num != 0)
			{
			}
			num = (short)1776549888;
			if (num != 0)
			{
			}
			string obj = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CompressionHelper.Compress(A_0);
			A_1(obj);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		private static void a(global::System.Collections.Generic.IEnumerable<global::System.Guid> A_0, global::System.Action<global::System.Collections.Specialized.StringCollection> A_1)
		{
			short num = (short)1915888526;
			short num2 = num;
			num = (short)175711118;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1876295680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1232928769;
			if (num != 0)
			{
			}
			num = (short)1227161600;
			if (num != 0)
			{
			}
			global::System.Collections.Specialized.StringCollection stringCollection = new global::System.Collections.Specialized.StringCollection();
			stringCollection.AddRange(A_0.Select(new global::System.Func<global::System.Guid, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c.<>9.a)).ToArray<string>());
			A_1(stringCollection);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
		private static global::System.Collections.Generic.List<global::System.Guid> a<a>(global::System.Collections.Generic.IEnumerable<a> A_0) where a : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			short num = (short)1100653013;
			short num2 = num;
			num = (short)1160683989;
			switch (num2 == num)
			{
			default:
			{
				num = (short)217382912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1452343297;
			if (num != 0)
			{
			}
			num = (short)379846656;
			if (num != 0)
			{
			}
			return A_0.Where(new global::System.Func<a, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c__76<a>.<>9.a)).Select(new global::System.Func<a, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.<>c__76<a>.<>9.b)).ToList<global::System.Guid>();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> GetJobContainers()
		{
			short num = (short)1223016609;
			short num2 = num;
			num = (short)1364836513;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1480851456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)253100033;
			if (num != 0)
			{
			}
			num = (short)765657088;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.k(null);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000E368 File Offset: 0x0000C568
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> GetJobContainers(bool isRwJbc)
		{
			short num = (short)1225897042;
			short num2 = num;
			num = (short)462140498;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1053294592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)771031040;
			if (num != 0)
			{
			}
			num = (short)1966211073;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.k(new bool?(isRwJbc));
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000E420 File Offset: 0x0000C620
		public global::Motorola.CommonCPS.Server.EntityModel.Job GetJob(global::System.Guid guid)
		{
			short num = (short)1173487617;
			if (num != 0)
			{
			}
			num = (short)1737687040;
			short num2 = num;
			num = (short)233301569;
			short num3 = num;
			num = (short)7857729;
			switch (num3 == num)
			{
			}
			num = (short)156172288;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetJob(guid);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
		public global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary GetJobContainerSummary(global::System.Guid guid)
		{
			short num = (short)990226843;
			short num2 = num;
			num = (short)1143384475;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1158676480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)772407297;
			if (num != 0)
			{
			}
			num = (short)1140654080;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetJbcSummary(guid);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000E58C File Offset: 0x0000C78C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer GetJobContainers(global::System.Guid guid)
		{
			short num = (short)1631552803;
			short num2 = num;
			num = (short)735806755;
			switch (num2 == num)
			{
			default:
			{
				num = (short)898301952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1664417793;
			if (num != 0)
			{
			}
			num = (short)436469760;
			if (num != 0)
			{
			}
			return this.GetJobContainerSummary(guid).ToUiModel();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000E640 File Offset: 0x0000C840
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer, global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>> GetJobs(global::System.Guid jbcUuid)
		{
			short num = (short)1963421748;
			short num2 = num;
			num = (short)1356951604;
			switch (num2 == num)
			{
			default:
			{
				num = (short)780795904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)894238720;
			if (num != 0)
			{
			}
			num = (short)2020409345;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary jbcSummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetJbcSummary(jbcUuid);
			global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer key = jbcSummary.ToUiModel();
			global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase> value = new global::Motorola.CommonCPS.RadioManagement.LocalService.JobViewCache(jbcSummary);
			return new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer, global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>>(key, value);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000E70C File Offset: 0x0000C90C
		private global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase a(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PackageFileInfo> A_1 = null)
		{
			short num = (short)763428865;
			if (num != 0)
			{
			}
			num = (short)2056388608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_75;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase;
				for (;;)
				{
					IL_52:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>.Enumerator enumerator;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext importLanguagePackContext;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> languagePackInfos;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1973223428;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)675610627;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.Package package = enumerator.Current;
									importLanguagePackContext.LanguagePacks.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack(package));
									num = (short)565772289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									num = (short)239183897;
									short num3 = num;
									num = (short)2124720153;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_155;
									default:
										goto IL_1A3;
									}
									break;
								}
								case 3:
									goto IL_155;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E8;
									}
									continue;
								}
								IL_EA:
								num = (short)108331008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E8:
								goto IL_EA;
								IL_155:
								num = (short)2043936770;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A3:
							num = (short)48824320;
							if (num != 0)
							{
							}
							return uimodelBase;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1CB;
					case 1:
						if (languagePackInfos != null)
						{
							num = (short)432406528;
							short num4 = num;
							num = (short)1457782789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return uimodelBase;
					case 2:
						if (languagePackInfos.Count > 0)
						{
							num = (short)458031107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return uimodelBase;
					case 3:
						goto IL_1CB;
					case 4:
						if (A_0 == global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.LanguagePack)
						{
							num = (short)73859078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return uimodelBase;
					case 5:
						num = (short)1882783746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						languagePackInfos = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.GetLanguagePackInfos();
						num = (short)696844289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
					IL_1CB:
					this.a(languagePackInfos);
					uimodelBase = new global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext
					{
						LanguagePacks = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ImportedLanguagePack>()
					};
					importLanguagePackContext = (uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.ImportLanguagePackContext);
					enumerator = languagePackInfos.GetEnumerator();
					num = (short)986185728;
					num2 = (int)((global::System.IntPtr)num);
				}
				return uimodelBase;
				IL_75:
				uimodelBase = null;
				num = (short)1255145476;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		public virtual global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase GetPackagesFromCPS(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType)
		{
			short num = (short)958249931;
			short num2 = num;
			num = (short)1896594379;
			switch (num2 == num)
			{
			}
			num = (short)1800798209;
			if (num != 0)
			{
			}
			num = (short)52756480;
			short num3 = num;
			num = (short)1018363904;
			if (num != 0)
			{
			}
			return this.a(packageType, null);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		public virtual global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase GetPackagesFromCPS(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.PackageFileInfo> packageFileInfoList)
		{
			short num = (short)646053889;
			if (num != 0)
			{
			}
			num = (short)1364841985;
			short num2 = num;
			num = (short)1151391233;
			switch (num2 == num)
			{
			}
			num = (short)1955004416;
			short num3 = num;
			num = (short)1963196416;
			if (num != 0)
			{
			}
			return this.a(packageType, packageFileInfoList);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000EB60 File Offset: 0x0000CD60
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase EditRadioColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase oldDevice, object newValue, string editedFieldName, bool commit, out string error)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase result;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radioFromServer;
			global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> list;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (!commit)
					{
						num2 = (short)1983905792;
						short num3 = num2;
						num2 = (short)1394606087;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.EditRadioFields(radioFromServer, list).ToUiModel(true);
					num2 = (short)1813118982;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (list.Count > 0)
					{
						num2 = (short)211877897;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)752353284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (list != null)
					{
						goto IL_177;
					}
					return result;
				case 5:
					num2 = (short)500563969;
					if (num2 != 0)
					{
					}
					num2 = (short)472711170;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				case 7:
					result = oldDevice.EditLocalRadio(list);
					num2 = (short)1996029952;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					if (!global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService.ValidateWhenEditRadioColumn(oldDevice, newValue, editedFieldName, out list, out radioFromServer, out error))
					{
						return result;
					}
					num2 = (short)1455376106;
					short num4 = num2;
					num2 = (short)1254115050;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_177;
					default:
						num2 = (short)878903296;
						if (num2 != 0)
						{
						}
						num2 = (short)1590886403;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					num2 = (short)250806273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_177:
				num2 = (short)1318977541;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_38:
			list = null;
			radioFromServer = null;
			result = null;
			num2 = (short)1418330120;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000ED94 File Offset: 0x0000CF94
		public global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase EditTemplateColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase oldTemplate, object newValue, string editedFieldName, out string error)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>> list;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (list != null)
						{
							num2 = (short)416481286;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 1:
					{
						num2 = (short)2088173568;
						short num3 = num2;
						num2 = (short)1509818368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						result = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService.EditTemplateFields(oldTemplate.TemplateID, oldTemplate.TimeStamp, list).ToUiModel(true);
						num2 = (short)1444020227;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return result;
					case 4:
						if (list.Count > 0)
						{
							num2 = (short)1581907970;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 5:
					{
						num2 = (short)617339671;
						short num4 = num2;
						num2 = (short)411491095;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1160839168;
							if (num2 != 0)
							{
							}
							if (global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService.ValidateWhenEditTemplateColumn(oldTemplate, newValue, editedFieldName, out list, out error))
							{
								num2 = (short)1484718081;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						break;
					}
					case 6:
						num2 = (short)1011875844;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_2C:
				num2 = (short)679673857;
				if (num2 != 0)
				{
				}
				result = null;
				list = null;
				num2 = (short)630718469;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000EF68 File Offset: 0x0000D168
		public virtual void CopyRadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioToCopy, out global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> copyRadioIdentityInfo, out global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.Timestamp, radioToCopy.RadioTimestamp))
					{
						num2 = (short)491061259;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_178;
				case 1:
					if (validateRadio.WorkingCodeplug == null)
					{
						num2 = (short)1428619267;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1197998085;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1540358151;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)486408192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (validateRadio == null)
					{
						num2 = (short)1964638218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2114060289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.Timestamp, radioToCopy.RadioTimestamp))
					{
						num2 = (short)1549271042;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EA;
				case 6:
					goto IL_1CD;
				case 7:
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validateRadio.WorkingCodeplug.Timestamp, radioToCopy.CodeplugTimestamp))
					{
						num2 = (short)1484783624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_178;
				case 8:
					goto IL_227;
				case 9:
					if (validateRadio.WorkingCodeplug == null)
					{
						num2 = (short)1057226758;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_294;
				case 10:
					goto IL_E5;
				case 11:
					goto IL_292;
				}
				goto IL_40;
			}
			IL_E5:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			IL_EA:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			IL_178:
			copyRadioIdentityInfo.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>(radioToCopy.DeviceUuid, radioToCopy.RadioTimestamp));
			goto IL_190;
			IL_1CD:
			copyRadioIdentityInfo.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>(global::System.Guid.Empty, null));
			return;
			IL_227:
			goto IL_EA;
			IL_292:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
			IL_294:
			num2 = (short)961544192;
			short num3 = num2;
			num2 = (short)1052508161;
			if (num2 != 0)
			{
			}
			copyRadioIdentityInfo.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>(radioToCopy.WorkingCodeplugUUID.Value, radioToCopy.CodeplugTimestamp));
			return;
			IL_40:
			num2 = (short)1844421433;
			short num4 = num2;
			num2 = (short)326214457;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_190:
				num2 = (short)737738761;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1110310912;
				if (num2 != 0)
				{
				}
				copyRadioIdentityInfo = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>>();
				validateRadio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetRadioRawData(radioToCopy.ID.Value, true);
				num2 = (short)1318191108;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000F27C File Offset: 0x0000D47C
		public bool PasteRadioIdentity(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> copiedRadioIdentityRecords, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioToPaste, out global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> pasteRadioIdentityRecordsForServer, out global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase transferredRadio, out global::Motorola.CommonCPS.Server.EntityModel.Radio validatePasteRadio, out global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo> cannotPasteList)
		{
			short num = (short)1910964224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CE;
				}
				global::Motorola.CommonCPS.Server.EntityModel.Radio radioRawData;
				byte[] value;
				byte[] value2;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
				for (;;)
				{
					IL_27:
					num = (short)1388493851;
					short num3 = num;
					num = (short)134790171;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)388038656;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_1DE;
						case 1:
							if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validatePasteRadio.WorkingCodeplug.Timestamp, radioToPaste.CodeplugTimestamp))
							{
								num = (short)1608777741;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_464;
						case 2:
							if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validatePasteRadio.Timestamp, radioToPaste.RadioTimestamp))
							{
								num = (short)1108279302;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_464;
						case 3:
							if (radioRawData == null)
							{
								num = (short)1804140553;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)965935123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (validatePasteRadio == null)
							{
								num = (short)1046478866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)428474385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)920715265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_389;
						case 7:
							num = (short)2012413964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1377435658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_151;
						case 10:
							if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radioRawData.Timestamp, value))
							{
								num = (short)1522270208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A4;
						case 11:
							goto IL_297;
						case 12:
							if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radioRawData.WorkingCodeplug.Timestamp, value2))
							{
								num = (short)139722763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A4;
						case 13:
							goto IL_42D;
						case 14:
							num = (short)447348737;
							if (num != 0)
							{
							}
							if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(radioRawData.Timestamp, value))
							{
								num = (short)1778974727;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_299;
						case 15:
							if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(validatePasteRadio.Timestamp, radioToPaste.RadioTimestamp))
							{
								num = (short)2031878149;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_459;
						case 16:
							num = (short)1361903618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (validatePasteRadio.WorkingCodeplug == null)
							{
								num = (short)1299972112;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1052114959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_2F4;
						case 19:
							if (radioRawData.WorkingCodeplug == null)
							{
								num = (short)232456200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1268056078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_4B3;
						}
						goto IL_CE;
						IL_2A4:
						validatePasteRadio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetRadioRawData(radioToPaste.DeviceUuid, true);
						num = (short)981204996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_464:
						pasteRadioIdentityRecordsForServer = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>();
						list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a_ = radioRawData.ToUiModel(true);
						radioBase = (global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)radioToPaste.Clone();
						this.a(radioBase, a_, radioRawData, validatePasteRadio, copiedRadioIdentityRecords, pasteRadioIdentityRecordsForServer, list);
						break;
					}
					}
					num = (short)1179668;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_151:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_1DE:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_297:
				IL_299:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_2F4:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DeviceNotExist);
				IL_389:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_42D:
				num = (short)552927232;
				short num4 = num;
				IL_459:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
				IL_4B3:
				bool flag = !this.ValidatePastedRecords(radioBase, validatePasteRadio, list, pasteRadioIdentityRecordsForServer, out cannotPasteList);
				if (flag && (cannotPasteList == null || (cannotPasteList != null && cannotPasteList.Count == 0)) && pasteRadioIdentityRecordsForServer != null && pasteRadioIdentityRecordsForServer.Count > 0)
				{
					transferredRadio = this.SubmitRadioPasteValue(radioToPaste, validatePasteRadio, pasteRadioIdentityRecordsForServer);
				}
				return flag;
				IL_CE:
				transferredRadio = null;
				pasteRadioIdentityRecordsForServer = null;
				global::System.Guid key = copiedRadioIdentityRecords[0].Key;
				value = copiedRadioIdentityRecords[0].Value;
				value2 = copiedRadioIdentityRecords[1].Value;
				radioRawData = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetRadioRawData(key, true);
				num = (short)1175453699;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000F794 File Offset: 0x0000D994
		protected bool CauseInvalidFieldByPaste(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase originalUIModel, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase afterPasteUIModel)
		{
			short num;
			for (;;)
			{
				num = (short)1766785024;
				switch (num)
				{
				default:
				{
					num = (short)849514182;
					short num2 = num;
					num = (short)657100486;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_53;
					}
					break;
				}
				}
			}
			IL_53:
			num = (short)1418592257;
			if (num != 0)
			{
			}
			num = (short)1581056000;
			if (num != 0)
			{
			}
			num = (short)1782251520;
			short num3 = num;
			bool result = false;
			global::System.Collections.Generic.Dictionary<string, string> dictionary = originalUIModel.InvalidFieldErrorInfo();
			using (global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator = afterPasteUIModel.InvalidFieldErrorInfo().GetEnumerator())
			{
				num = (short)1553006600;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						result = true;
						num = (short)543686658;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1409482759;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
						num = (short)1602289668;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
						if (dictionary[keyValuePair.Key] != keyValuePair.Value)
						{
							num = (short)448856064;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
						if (dictionary.ContainsKey(keyValuePair.Key))
						{
							num = (short)503054341;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)1561591814;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1214251011;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1089601545;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_121;
						}
						continue;
					case 9:
						goto IL_252;
					}
					IL_16D:
					num = (short)1271529473;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_121:
					goto IL_16D;
				}
				IL_252:;
			}
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000FA20 File Offset: 0x0000DC20
		protected virtual bool ValidatePastedRecords(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase pastedRadio, global::Motorola.CommonCPS.Server.EntityModel.Radio validatePasteRadio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> needValidateRecords, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> pasteRadioIdentityRecordsForServer, out global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo> cannotPasteList)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator;
				switch (num)
				{
				case 0:
					goto IL_254;
				case 1:
					goto IL_87;
				case 2:
					num2 = (short)53477377;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)1793327107;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase;
								uimodelBase.a();
								num2 = (short)2030829570;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 1:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase;
								if (!uimodelBase.IsValidRecord())
								{
									num2 = (short)842334216;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 2:
								goto IL_160;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_FA;
								}
								continue;
							case 4:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase;
								if (uimodelBase.Validator == null)
								{
									num2 = (short)89849856;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								uimodelBase.Validator.Validate(uimodelBase, null);
								num2 = (short)1724579847;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)913506310;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator.Current;
								num2 = (short)2027683844;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 6:
								num2 = (short)2138767370;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 7:
								goto IL_160;
							case 8:
								result = true;
								num2 = (short)1009123337;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 10:
								goto IL_241;
							}
							goto IL_FA;
							IL_160:
							num2 = (short)1716518913;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_19E:
							num2 = (short)73990149;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_FA:
							goto IL_19E;
						}
						IL_241:
						return result;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_254;
				}
				break;
				IL_254:
				num2 = (short)562364416;
				short num3 = num2;
				enumerator = needValidateRecords.GetEnumerator();
				num2 = (short)1709637634;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C:
			result = false;
			cannotPasteList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo>();
			num2 = (short)195491311;
			short num4 = num2;
			num2 = (short)519763439;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_87:
				if (needValidateRecords != null)
				{
					num2 = (short)866254848;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)701235200;
				if (num2 != 0)
				{
				}
				num2 = (short)56295425;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000FD14 File Offset: 0x0000DF14
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase SubmitRadioPasteValue(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase toPasteRadio, global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> pasteRadioIdentityRecordsForServer)
		{
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> list;
			for (;;)
			{
				IL_00:
				short num = (short)1097138176;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					for (;;)
					{
						IL_28:
						num = (short)632553472;
						short num3 = num;
						num = (short)1618717781;
						short num4 = num;
						num = (short)1216785493;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1266089984;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator;
							switch (num2)
							{
							case 0:
								goto IL_201;
							case 1:
								if (pasteRadioIdentityRecordsForServer != null)
								{
									num = (short)1829044224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_23D;
							case 2:
								try
								{
									num = (short)1354563587;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)403701764;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1850736640;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> keyValuePair = enumerator.Current;
											global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item = new global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>(keyValuePair.Key.ID.Value, keyValuePair.Value);
											list.Add(item);
											num = (short)1336737794;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											switch (0)
											{
											case 0:
												goto IL_155;
											}
											continue;
										case 4:
											goto IL_1F1;
										}
										IL_1A0:
										num = (short)290979841;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_155:
										goto IL_1A0;
									}
									IL_1F1:
									goto IL_225;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_201;
							}
							goto IL_AF;
							IL_201:
							enumerator = pasteRadioIdentityRecordsForServer.GetEnumerator();
							num = (short)1216872450;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_AF:
					num = (short)211812353;
					if (num != 0)
					{
					}
					list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>();
					num = (short)1653800961;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
			}
			IL_225:
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.SubmitTransferRadioIdentity(validateRadio, list).ToUiModel(true);
			IL_23D:
			return null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000FF70 File Offset: 0x0000E170
		public global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> ListTemplateSummaries()
		{
			short num = (short)1258416142;
			short num2 = num;
			num = (short)669181966;
			switch (num2 == num)
			{
			}
			num = (short)1430781953;
			if (num != 0)
			{
			}
			num = (short)1461059584;
			if (num != 0)
			{
			}
			num = (short)1652948992;
			short num3 = num;
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateViewCache();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0001001C File Offset: 0x0000E21C
		public virtual object GetPCRKeys(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType type)
		{
			short num = (short)1643380737;
			if (num != 0)
			{
			}
			num = (short)2098041457;
			short num2 = num;
			num = (short)11440753;
			switch (num2 == num)
			{
			}
			num = (short)1818558464;
			if (num != 0)
			{
			}
			num = (short)521273344;
			short num3 = num;
			return null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000100C8 File Offset: 0x0000E2C8
		public virtual global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext GenerateSelectFirmwareContext(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios)
		{
			short num = (short)1278494507;
			short num2 = num;
			num = (short)1427457835;
			switch (num2 == num)
			{
			}
			num = (short)691142657;
			if (num != 0)
			{
			}
			num = (short)427032576;
			if (num != 0)
			{
			}
			num = (short)332791808;
			short num3 = num;
			return null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00010174 File Offset: 0x0000E374
		public virtual global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext GenerateSelectRecoverFirmwareContext(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList)
		{
			short num = (short)1255719956;
			short num2 = num;
			num = (short)1412416532;
			switch (num2 == num)
			{
			}
			num = (short)1323499521;
			if (num != 0)
			{
			}
			num = (short)891813888;
			if (num != 0)
			{
			}
			num = (short)966590464;
			short num3 = num;
			return null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00010220 File Offset: 0x0000E420
		public virtual bool CheckFirmwareAfterReadRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext)
		{
			short num = (short)782434305;
			if (num != 0)
			{
			}
			num = (short)663622327;
			short num2 = num;
			num = (short)657003191;
			switch (num2 == num)
			{
			}
			num = (short)1267466240;
			if (num != 0)
			{
			}
			num = (short)1502085120;
			short num3 = num;
			return true;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000102CC File Offset: 0x0000E4CC
		public void GetAvailableDevices(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> availableDevices, global::System.Guid? groupUUID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails, int featureType = 0)
		{
			short num = (short)1825636352;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num4;
				int num5;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IManageRadioLicenseService manageRadioLicenseService;
				int num6;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)301337769;
						short num3 = num;
						num = (short)2121796777;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C8;
						default:
							goto IL_164;
						}
						break;
					}
					case 1:
						goto IL_FA;
					case 2:
						try
						{
							num = (short)646184961;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_237;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1B9;
									}
									continue;
								case 2:
									num = (short)1847132160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)711262210;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary rawData = enumerator.Current;
									availableDevices.Add(rawData.ToUiModel(true));
									num = (short)1650262019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1BB:
								num = (short)1580728324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B9:
								goto IL_1BB;
							}
							IL_237:
							goto IL_A9;
						}
						finally
						{
							num = (short)651296768;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_26F;
									}
									continue;
								case 1:
									goto IL_2A6;
								case 2:
									enumerator.Dispose();
									num = (short)1029505025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_26F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)463798274;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A6:;
						}
						goto IL_2A9;
						IL_A9:
						num4++;
						num = (short)798228484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num4 >= num5)
						{
							num = (short)208601088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8;
					case 4:
						goto IL_FA;
					}
					goto IL_42;
					IL_C8:
					enumerator = manageRadioLicenseService.GetAvailableDevices(groupUUID, selectedEIDDetails, num4 * num6, num6, featureType).GetEnumerator();
					num = (short)258932738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA:
					num = (short)2076966915;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_164:
				num = (short)1109721088;
				if (num != 0)
				{
				}
				IL_2A9:
				num = (short)1413808128;
				short num7 = num;
				return;
				IL_42:
				num = (short)1249116161;
				if (num != 0)
				{
				}
				availableDevices.Clear();
				manageRadioLicenseService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService;
				num5 = manageRadioLicenseService.GetAvailableDevicesCount(groupUUID, selectedEIDDetails, null, featureType) / 100 + 1;
				num6 = 100;
				num4 = 0;
				num = (short)1543241729;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000105BC File Offset: 0x0000E7BC
		public bool IsRadioSupportSelectedEID(string serialNumber, global::System.Guid? groupUUID, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails, int featureType = 0)
		{
			short num = (short)1669262891;
			short num2 = num;
			num = (short)1387851307;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1002831873;
				if (num != 0)
				{
				}
				num = (short)1070792704;
				short num3 = num;
				num = (short)44498944;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				list.Add(serialNumber);
				if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.ManageRadioLicenseService.GetAvailableDevicesCount(groupUUID, selectedEIDDetails, list, featureType) == 1)
				{
					return true;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00010690 File Offset: 0x0000E890
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> GetRadioFeatures(string groupID, int featureType = 0)
		{
			short num = (short)1884291074;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid? guid;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)619446276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)801243139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					goto IL_133;
				case 4:
					goto IL_157;
				case 5:
					goto IL_118;
				}
				IL_3D:
				num = (short)877461504;
				short num3 = num;
				num = (short)1511798017;
				short num4 = num;
				num = (short)325661953;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_157:
					if (!(groupID == global::System.Guid.Empty.ToString()))
					{
						num = (short)971505665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				default:
					num = (short)1711013889;
					if (num != 0)
					{
					}
					num = (short)434110464;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)1841823744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				guid = null;
				num = (short)338755589;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_118:
			global::System.Guid? groupUuid = guid;
			goto IL_18B;
			IL_133:
			groupUuid = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_18B:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseAllViewCache(groupUuid, featureType);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00010830 File Offset: 0x0000EA30
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> GetRadioFeatureDetailsByFeature(string groupID, int featureID, int featureType = 0)
		{
			short num = (short)1552416770;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid? guid;
			for (;;)
			{
				num = (short)667090944;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1220608004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)507510787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1777336321;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8C;
					}
					continue;
				case 3:
					goto IL_134;
				case 4:
					goto IL_158;
				case 5:
					goto IL_119;
				}
				IL_8C:
				num = (short)938699931;
				short num4 = num;
				num = (short)109407387;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_158:
					if (!(groupID == global::System.Guid.Empty.ToString()))
					{
						num = (short)1506607105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				default:
					num = (short)1061158912;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)1603731456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				guid = null;
				num = (short)364118021;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_119:
			global::System.Guid? groupID2 = guid;
			goto IL_18C;
			IL_134:
			groupID2 = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_18C:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseFeatureSubViewCache(groupID2, featureID, featureType);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000109D0 File Offset: 0x0000EBD0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase> ListRadioFeatureSummaryByFeature(string groupID, int featureType = 0)
		{
			short num = (short)1513160706;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid? guid;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)877330436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1734344707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
					goto IL_112;
				case 4:
					goto IL_136;
				case 5:
					goto IL_F3;
				}
				IL_3C:
				num = (short)1437466624;
				short num3 = num;
				num = (short)1618454504;
				short num4 = num;
				num = (short)521644008;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_136:
					if (!(groupID == global::System.Guid.Empty.ToString()))
					{
						num = (short)1418657793;
						if (num != 0)
						{
						}
						num = (short)554434561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				default:
					num = (short)1874788352;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)1347616768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				guid = null;
				num = (short)395051013;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F3:
			global::System.Guid? groupUuid = guid;
			goto IL_195;
			IL_112:
			groupUuid = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_195:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseFeatureViewCache(groupUuid, featureType);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00010B78 File Offset: 0x0000ED78
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> GetRadioFeatureDetailsByRadio(global::System.Guid radioUuid, int featureType = 0)
		{
			short num = (short)474653082;
			short num2 = num;
			num = (short)1007133082;
			switch (num2 == num)
			{
			}
			num = (short)77266944;
			if (num != 0)
			{
			}
			num = (short)1269497857;
			if (num != 0)
			{
			}
			num = (short)1269039104;
			short num3 = num;
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseRadioSubViewCache(radioUuid, featureType);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00010C28 File Offset: 0x0000EE28
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase> ListRadioFeatureSummaryByRadio(string groupID, int featureType = 0)
		{
			short num = (short)1737752578;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid? guid;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)995885060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)952238083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					goto IL_133;
				case 4:
					goto IL_159;
				case 5:
					goto IL_119;
				}
				IL_3D:
				num = (short)634060800;
				short num3 = num;
				num = (short)1534023464;
				short num4 = num;
				num = (short)1240356648;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_159:
					if (!(groupID == global::System.Guid.Empty.ToString()))
					{
						num = (short)422707201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				default:
					num = (short)459735040;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)1151074304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				guid = null;
				num = (short)2048131073;
				if (num != 0)
				{
				}
				num = (short)1616838661;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_119:
			global::System.Guid? groupUuid = guid;
			goto IL_191;
			IL_133:
			groupUuid = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_191:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseRadioViewCache(groupUuid, featureType);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00010DCC File Offset: 0x0000EFCC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> ListAppFeatures()
		{
			short num = (short)443559128;
			short num2 = num;
			num = (short)1955146968;
			switch (num2 == num)
			{
			}
			num = (short)254738433;
			if (num != 0)
			{
			}
			num = (short)1757937664;
			if (num != 0)
			{
			}
			num = (short)398589952;
			short num3 = num;
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.AppLicenseViewCache();
		}

		// Token: 0x060000A0 RID: 160
		public abstract void TrimCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp);

		// Token: 0x060000A1 RID: 161 RVA: 0x00010E7C File Offset: 0x0000F07C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> GetRadioLanguagesDetailInfo(global::System.Guid radioUUID)
		{
			short num = (short)944898048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> radioLanguagesDetailInfo;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> observableCollection;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo>.Enumerator enumerator;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_28D;
					case 1:
						num = (short)883228673;
						if (num != 0)
						{
						}
						if (radioLanguagesDetailInfo != null)
						{
							num = (short)180158468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 2:
						try
						{
							num = (short)1284898817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_21A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F1;
									}
									continue;
								case 2:
								{
									num = (short)292184734;
									short num3 = num;
									num = (short)436495006;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_108;
									default:
										num = (short)24313856;
										if (num != 0)
										{
										}
										num = (short)1717043200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_108;
								}
								IL_F3:
								num = (short)1548746756;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F1:
								goto IL_F3;
								IL_108:
								if (!enumerator.MoveNext())
								{
									num = (short)1686241282;
									num2 = (int)((global::System.IntPtr)num);
								}
								else
								{
									global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo languageDetailInfo = enumerator.Current;
									observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo
									{
										ID = num4++,
										PackageID = languageDetailInfo.PackageID,
										PackageName = languageDetailInfo.PackageName,
										PackageSize = ((languageDetailInfo.PackageSize + 1023) / 1024).ToString(global::System.Globalization.CultureInfo.CurrentCulture),
										PackageVersion = languageDetailInfo.PackageVersion
									});
									num = (short)1055260675;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_21A:
							return observableCollection;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_22D;
					case 3:
						if (radioLanguagesDetailInfo.Count == 0)
						{
							num = (short)1356988416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					case 4:
						num = (short)1069350915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43;
					IL_22D:
					num4 = 1;
					enumerator = radioLanguagesDetailInfo.GetEnumerator();
					num = (short)783482882;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_28D:
				IL_28F:
				num = (short)1584070656;
				short num5 = num;
				return observableCollection;
				IL_43:
				radioLanguagesDetailInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioLanguagesDetailInfo(radioUUID);
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>();
				num = (short)767295489;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00011160 File Offset: 0x0000F360
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo> GetRadioPCRDeviceCertificateDetailInfo(global::System.Guid radioUUID)
		{
			short num = (short)862453760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo> observableCollection;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo> radioPCRDeviceCertificateDetailInfo;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						return observableCollection;
					case 1:
					{
						num = (short)170459136;
						short num3 = num;
						if (radioPCRDeviceCertificateDetailInfo != null)
						{
							num = (short)1654587396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return observableCollection;
					}
					case 2:
						try
						{
							num = (short)1098579969;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_16D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F4;
									}
									continue;
								case 2:
									num = (short)1729757184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1866727426;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo item = enumerator.Current;
									observableCollection.Add(item);
									num = (short)1969553411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_F6:
								num = (short)2020868100;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F4:
								goto IL_F6;
							}
							IL_16D:
							return observableCollection;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_180;
					case 3:
						if (radioPCRDeviceCertificateDetailInfo.Count == 0)
						{
							num = (short)1764294656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180;
					case 4:
					{
						num = (short)495188815;
						short num4 = num;
						num = (short)640285519;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return observableCollection;
						default:
							num = (short)1970274305;
							if (num != 0)
							{
							}
							num = (short)1514733568;
							if (num != 0)
							{
							}
							num = (short)713293827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_42;
					IL_180:
					enumerator = radioPCRDeviceCertificateDetailInfo.GetEnumerator();
					num = (short)1310916610;
					num2 = (int)((global::System.IntPtr)num);
				}
				return observableCollection;
				IL_42:
				radioPCRDeviceCertificateDetailInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioPCRDeviceCertificateDetailInfo(radioUUID);
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo>();
				num = (short)1313210369;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000113D8 File Offset: 0x0000F5D8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase EditPCRDeviceCertificate(global::System.Guid radioUuid, global::System.Guid deviceCertUuid, global::System.Collections.Generic.Dictionary<string, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			short num = (short)1132378348;
			short num2 = num;
			num = (short)220772588;
			switch (num2 == num)
			{
			}
			num = (short)457834497;
			if (num != 0)
			{
			}
			num = (short)1212088320;
			if (num != 0)
			{
			}
			num = (short)926220288;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).EditPCRDeviceCertificate(radioUuid, deviceCertUuid, fieldValues, set).ToUiModel(true);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00011498 File Offset: 0x0000F698
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> GetRadioVADetailInfo(global::System.Guid radioUUID)
		{
			short num = (short)978518016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)194576385;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> observableCollection;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> radioVADetailInfo;
				for (;;)
				{
					IL_4F:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						return observableCollection;
					case 1:
						if (radioVADetailInfo != null)
						{
							num = (short)211091459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return observableCollection;
					case 2:
						try
						{
							num = (short)1517551617;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1CE;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11A;
									}
									continue;
								case 2:
									num = (short)843972608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2095054850;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo vadetailInfo = enumerator.Current;
									observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo
									{
										PackageName = vadetailInfo.PackageName,
										PackageSize = ((vadetailInfo.PackageSize + 1023) / 1024).ToString(global::System.Globalization.CultureInfo.CurrentCulture)
									});
									num = (short)142934020;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_11C:
								num = (short)1223426051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11A:
								goto IL_11C;
							}
							IL_1CE:
							return observableCollection;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1E1;
					case 3:
					{
						num = (short)1061778251;
						short num3 = num;
						num = (short)2109764427;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return observableCollection;
						default:
							num = (short)1226964992;
							if (num != 0)
							{
							}
							num = (short)721551364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (radioVADetailInfo.Count == 0)
						{
							num = (short)399900672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E1;
					}
					goto IL_6A;
					IL_1E1:
					enumerator = radioVADetailInfo.GetEnumerator();
					num = (short)1385824258;
					num2 = (int)((global::System.IntPtr)num);
				}
				return observableCollection;
				IL_6A:
				radioVADetailInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioVADetailInfo(radioUUID);
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>();
				num = (short)447741952;
				short num4 = num;
				num = (short)923795457;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0001174C File Offset: 0x0000F94C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> GetTemplateVADetailInfo(global::System.Guid templateUUID)
		{
			short num = (short)525336576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> observableCollection;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> templateVADetailInfo;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						return observableCollection;
					case 1:
					{
						num = (short)1569456128;
						short num3 = num;
						if (templateVADetailInfo != null)
						{
							num = (short)1049034755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return observableCollection;
					}
					case 2:
						num = (short)1778319361;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1275133953;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1A8;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F5;
									}
									continue;
								case 2:
									num = (short)943128576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1931739138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo vadetailInfo = enumerator.Current;
									observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo
									{
										PackageName = vadetailInfo.PackageName,
										PackageSize = ((vadetailInfo.PackageSize + 1023) / 1024).ToString(global::System.Globalization.CultureInfo.CurrentCulture)
									});
									num = (short)112918532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_F7:
								num = (short)1091895299;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F5:
								goto IL_F7;
							}
							IL_1A8:
							return observableCollection;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1BB;
					case 3:
					{
						num = (short)61814850;
						short num4 = num;
						num = (short)729626690;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return observableCollection;
						default:
							num = (short)225509376;
							if (num != 0)
							{
							}
							num = (short)1284571140;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (templateVADetailInfo.Count == 0)
						{
							num = (short)86835200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					}
					goto IL_42;
					IL_1BB:
					enumerator = templateVADetailInfo.GetEnumerator();
					num = (short)1488388098;
					num2 = (int)((global::System.IntPtr)num);
				}
				return observableCollection;
				IL_42:
				templateVADetailInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplateVADetailInfo(templateUUID);
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>();
				num = (short)11993089;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000119FC File Offset: 0x0000FBFC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> GetTemplateLanguagesDetailInfo(global::System.Guid templateUUID)
		{
			short num = (short)1790050304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> observableCollection;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> templateLPDetailInfo;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo>.Enumerator enumerator;
					int num4;
					switch (num2)
					{
					case 0:
						return observableCollection;
					case 1:
					{
						num = (short)384565248;
						short num3 = num;
						if (templateLPDetailInfo != null)
						{
							num = (short)754188291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return observableCollection;
					}
					case 2:
						try
						{
							num = (short)1505034241;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1D4;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F5;
									}
									continue;
								case 2:
									num = (short)1869348864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1617428482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo languageDetailInfo = enumerator.Current;
									observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo
									{
										ID = num4++,
										PackageID = languageDetailInfo.PackageID,
										PackageName = languageDetailInfo.PackageName,
										PackageSize = ((languageDetailInfo.PackageSize + 1023) / 1024).ToString(global::System.Globalization.CultureInfo.CurrentCulture),
										PackageVersion = languageDetailInfo.PackageVersion
									});
									num = (short)1004339204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_F7:
								num = (short)618463235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F5:
								goto IL_F7;
							}
							IL_1D4:
							return observableCollection;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1E7;
					case 3:
					{
						num = (short)450339433;
						short num5 = num;
						num = (short)1539613289;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return observableCollection;
						default:
							num = (short)131661824;
							if (num != 0)
							{
							}
							num = (short)277610497;
							if (num != 0)
							{
							}
							num = (short)492371972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (templateLPDetailInfo.Count == 0)
						{
							num = (short)284295168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E7;
					}
					goto IL_43;
					IL_1E7:
					num4 = 1;
					enumerator = templateLPDetailInfo.GetEnumerator();
					num = (short)2097545218;
					num2 = (int)((global::System.IntPtr)num);
				}
				return observableCollection;
				IL_43:
				templateLPDetailInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplateLPDetailInfo(templateUUID);
				observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>();
				num = (short)937164801;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> ListAppLicenses()
		{
			short num = (short)964646503;
			short num2 = num;
			num = (short)1350719079;
			switch (num2 == num)
			{
			}
			num = (short)1526071297;
			if (num != 0)
			{
			}
			num = (short)1636106240;
			if (num != 0)
			{
			}
			num = (short)33751040;
			short num3 = num;
			return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00011D94 File Offset: 0x0000FF94
		public virtual int GetAppLicenseCount()
		{
			short num = (short)1356669152;
			short num2 = num;
			num = (short)1358242016;
			switch (num2 == num)
			{
			}
			num = (short)2142568448;
			if (num != 0)
			{
			}
			num = (short)360054785;
			if (num != 0)
			{
			}
			num = (short)1996226560;
			short num3 = num;
			return 1;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00011E40 File Offset: 0x00010040
		public virtual global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource> LoadRMResources()
		{
			short num = (short)1989598571;
			short num2 = num;
			num = (short)1407835499;
			switch (num2 == num)
			{
			}
			num = (short)845479937;
			if (num != 0)
			{
			}
			num = (short)1495072768;
			if (num != 0)
			{
			}
			num = (short)623575040;
			short num3 = num;
			return new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00011EEC File Offset: 0x000100EC
		public string GetHelpFilePath(string fieldPath = null)
		{
			int a_ = 7;
			short num = (short)275775488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				string text3;
				string currentCulture;
				for (;;)
				{
					IL_31:
					string key;
					int num3;
					string str;
					string text2;
					switch (num2)
					{
					case 0:
						goto IL_355;
					case 1:
					{
						num = (short)46268417;
						if (num != 0)
						{
						}
						string text;
						if (global::System.IO.File.Exists(text))
						{
							num = (short)2136014870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_443;
					}
					case 2:
						goto IL_2F7;
					case 3:
						goto IL_1F5;
					case 4:
						if (this.d.ContainsKey(key))
						{
							num = (short)1006174219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BF;
					case 5:
						num = (short)277807133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num3 >= 0)
						{
							num = (short)1952710661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						str = fieldPath;
						num = (short)1912995849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_3B9;
					case 8:
					{
						string str2 = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("縠瀢䀤匦", a_);
						key = str + str2;
						num = (short)1312555011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_5B2;
					case 10:
						if (string.IsNullOrEmpty(text2))
						{
							num = (short)438239240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						key = text2;
						num = (short)255524882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						string url = this.d[key].Url;
						text3 = global::System.IO.Path.Combine(this.e, url);
						num = (short)846856194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (this.d == null)
						{
							num = (short)660537368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35A;
					case 13:
						str = fieldPath.Substring(0, num3);
						num = (short)1680146449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!global::System.IO.File.Exists(text3))
						{
							num = (short)1044906000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text3;
					case 15:
						goto IL_5B2;
					case 16:
						text3 = string.Empty;
						num = (short)264437760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_2A6;
					case 18:
						goto IL_1F5;
					case 19:
						if (this.e == null)
						{
							num = (short)730071047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_523;
					case 20:
						goto IL_35A;
					case 21:
						if (string.IsNullOrEmpty(fieldPath))
						{
							num = (short)1730281499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1578827788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						string text;
						this.d = this.b(text);
						num = (short)1062141972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_523;
					case 24:
					{
						string text = global::System.IO.Path.Combine(this.e, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䐠嬢儤符䐨䨪崬Į䤰帲头", a_));
						num = (short)71106561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_2F7;
					case 26:
						if (!string.IsNullOrEmpty(text3))
						{
							num = (short)601292828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text3;
					case 27:
					{
						num = (short)1507212990;
						short num4 = num;
						num = (short)1291927230;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B9;
						default:
							num = (short)46399488;
							if (num != 0)
							{
							}
							text3 = global::System.IO.Path.Combine(this.e, this.c);
							num = (short)1664811033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 28:
					{
						num = (short)2053373952;
						short num5 = num;
						num = (short)1202913294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (num3 != 0)
						{
							num = (short)1090060301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A6;
					}
					goto IL_B0;
					IL_1F5:
					num = (short)812253188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A6:
					text2 = fieldPath.Substring(num3 + 1);
					num = (short)229179407;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F7:
					num = (short)17432602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35A:
					str = string.Empty;
					text2 = string.Empty;
					key = string.Empty;
					num3 = fieldPath.IndexOf('/');
					num = (short)1639055366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B9:
					string displayNameOfPAC = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetDisplayNameOfPAC();
					string path = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("猠渢洤䈦䔨嬪", a_);
					this.e = global::System.IO.Path.Combine(global::System.AppDomain.CurrentDomain.BaseDirectory, path, displayNameOfPAC, currentCulture);
					num = (short)1249837079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_523:
					num = (short)2000551957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B2:
					num = (short)1333526538;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1BF:
				return string.Empty;
				IL_355:
				return text3;
				IL_443:
				return string.Empty;
				IL_B0:
				currentCulture = this.GetCurrentCulture();
				text3 = null;
				num = (short)1532035091;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000124F0 File Offset: 0x000106F0
		public virtual string GetHelpFilePathForTemplate()
		{
			short num = (short)1632468283;
			short num2 = num;
			num = (short)1538489659;
			switch (num2 == num)
			{
			}
			num = (short)579076097;
			if (num != 0)
			{
			}
			num = (short)1940193280;
			if (num != 0)
			{
			}
			num = (short)734068736;
			short num3 = num;
			return string.Empty;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0001259C File Offset: 0x0001079C
		public string ParseFieldPath(string[] pathArray)
		{
			int a_ = 1;
			short num = (short)26214405;
			int num2 = (int)((global::System.IntPtr)num);
			string result;
			for (;;)
			{
				string text2;
				switch (num2)
				{
				case 0:
					if (pathArray.Count<string>() == 1)
					{
						num = (short)1855651853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)498532361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_219;
				case 2:
				{
					string text = pathArray[0].Split(new char[]
					{
						':'
					})[0];
					text2 = pathArray[pathArray.Length - 1].Split(new char[]
					{
						':'
					})[0];
					num = (short)1058144267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					num = (short)1917255692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					string text;
					result = text;
					num = (short)488505350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 6:
					goto IL_25B;
				case 7:
				{
					num = (short)1159692133;
					short num3 = num;
					num = (short)907247461;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_219;
					default:
					{
						num = (short)1697120256;
						if (num != 0)
						{
						}
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1549533188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_312;
					}
					}
					break;
				}
				case 8:
					goto IL_E5;
				case 9:
					if (pathArray.Count<string>() > 1)
					{
						num = (short)1727856642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_201;
				case 10:
				{
					string text;
					result = text + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("㐚", a_) + text2;
					num = (short)489226248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					goto IL_201;
				case 12:
				{
					if (pathArray.Length == 0)
					{
						num = (short)271777806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					string text = null;
					text2 = null;
					result = null;
					num = (short)424083456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
				{
					string text = pathArray[0].Split(new char[]
					{
						':'
					})[0];
					num = (short)423428111;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					goto IL_1FC;
				case 15:
					goto IL_201;
				}
				IL_6D:
				num = (short)540344321;
				if (num != 0)
				{
				}
				if (pathArray != null)
				{
					num = (short)1780678659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_136;
				IL_219:
				if (!string.IsNullOrEmpty(text2))
				{
					num = (short)1842741258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)513802247;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_201:
				num = (short)1007878145;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			goto IL_312;
			IL_136:
			return string.Empty;
			IL_1FC:
			goto IL_136;
			IL_25B:
			IL_312:
			num = (short)1998192640;
			short num4 = num;
			return result;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000128E4 File Offset: 0x00010AE4
		public void RegisterMigrationProgressEvent(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate method)
		{
			short num = (short)1147773304;
			short num2 = num;
			num = (short)601071992;
			switch (num2 == num)
			{
			}
			num = (short)656080897;
			if (num != 0)
			{
			}
			num = (short)374538240;
			if (num != 0)
			{
			}
			num = (short)1191378944;
			short num3 = num;
			this.DMMigrationEvent = (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate)global::System.Delegate.Combine(this.DMMigrationEvent, method);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000129A0 File Offset: 0x00010BA0
		public void UnRegisterMigrationProgressEvent(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate method)
		{
			short num = (short)187911731;
			short num2 = num;
			num = (short)1384664627;
			switch (num2 == num)
			{
			}
			num = (short)1324351489;
			if (num != 0)
			{
			}
			num = (short)1174929408;
			if (num != 0)
			{
			}
			num = (short)1968701440;
			short num3 = num;
			this.DMMigrationEvent = (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate)global::System.Delegate.Remove(this.DMMigrationEvent, method);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00012A64 File Offset: 0x00010C64
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> ListMigrationTemplateList()
		{
			short num = (short)952238080;
			short num2 = num;
			num = (short)179437569;
			if (num != 0)
			{
			}
			num = (short)470512108;
			short num3 = num;
			num = (short)2002874860;
			switch (num3 == num)
			{
			}
			num = (short)1420165120;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListMigrationTemplateList();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00012B18 File Offset: 0x00010D18
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigurationAndWiFi GetMigrationPBBFusionCfgWifi()
		{
			short num = (short)194641920;
			short num2 = num;
			num = (short)675621302;
			short num3 = num;
			num = (short)810363318;
			switch (num3 == num)
			{
			}
			num = (short)635568129;
			if (num != 0)
			{
			}
			num = (short)184549376;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetMigrationPBBFusionCfgWifi();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00012BD0 File Offset: 0x00010DD0
		public int ScheduleMigrationJob()
		{
			short num = (short)540344320;
			short num2 = num;
			num = (short)1199833089;
			if (num != 0)
			{
			}
			num = (short)1852635444;
			short num3 = num;
			num = (short)29620532;
			switch (num3 == num)
			{
			}
			num = (short)1406992384;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ScheduleMigrationJob();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00012C84 File Offset: 0x00010E84
		public void TurnOffMigration(string rmVersion)
		{
			short num = (short)1038417920;
			short num2 = num;
			num = (short)1662488176;
			short num3 = num;
			num = (short)73961072;
			switch (num3 == num)
			{
			}
			num = (short)1348075521;
			if (num != 0)
			{
			}
			num = (short)1017577472;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).TurnOffMigration(rmVersion);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00012D3C File Offset: 0x00010F3C
		public global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport GetClearDataProgressReport()
		{
			short num = (short)776404992;
			short num2 = num;
			num = (short)1498640169;
			short num3 = num;
			num = (short)1952739113;
			switch (num3 == num)
			{
			}
			num = (short)1071316993;
			if (num != 0)
			{
			}
			num = (short)1885863936;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetClearDataProgressReport();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00012DF0 File Offset: 0x00010FF0
		public void ClearLegacyData()
		{
			short num = (short)482410496;
			short num2 = num;
			num = (short)735401888;
			short num3 = num;
			num = (short)1063933856;
			switch (num3 == num)
			{
			}
			num = (short)2124742657;
			if (num != 0)
			{
			}
			num = (short)2019753984;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ClearLegacyData();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00012EA4 File Offset: 0x000110A4
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationEstimatedData CalculateMigrationTimeAndSize()
		{
			short num = (short)1277624320;
			short num2 = num;
			num = (short)1172536142;
			short num3 = num;
			num = (short)578779982;
			switch (num3 == num)
			{
			}
			num = (short)496762881;
			if (num != 0)
			{
			}
			num = (short)1003421696;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).CalculateMigrationTimeAndSize();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00012F5C File Offset: 0x0001115C
		public void SwapRadioWorkingCodeplug(string serialNumber)
		{
			short num = (short)2014117888;
			short num2 = num;
			num = (short)1297952918;
			short num3 = num;
			num = (short)870658198;
			switch (num3 == num)
			{
			}
			num = (short)1516568577;
			if (num != 0)
			{
			}
			num = (short)1558642688;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).SwapRadioWorkingCodeplug(serialNumber);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00013014 File Offset: 0x00011214
		public global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus AbortMigration()
		{
			short num = (short)429981696;
			short num2 = num;
			num = (short)704988888;
			short num3 = num;
			num = (short)369641176;
			switch (num3 == num)
			{
			}
			num = (short)1647640576;
			if (num != 0)
			{
			}
			num = (short)2064646145;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).AbortMigration();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000130CC File Offset: 0x000112CC
		protected string GetCurrentCulture()
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_31;
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
					goto IL_13A;
				case 1:
					if (text.Contains(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("簜洞", a_)))
					{
						num2 = (short)1477902336;
						short num3 = num2;
						num2 = (short)1889402883;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1092091909;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_13A;
				case 3:
					goto IL_118;
				case 4:
					text = text.Substring(0, 2);
					num2 = (short)750977026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (text.Contains(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("砜氞", a_)))
					{
						num2 = (short)2125856772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13A;
				}
				goto IL_31;
				IL_118:
				text = text.Substring(0, 2);
				num2 = (short)1322385408;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13A:
				num2 = (short)8013250;
				short num4 = num2;
				num2 = (short)814958018;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_118;
				default:
					goto IL_16F;
				}
			}
			IL_16F:
			num2 = (short)995033089;
			if (num2 != 0)
			{
			}
			num2 = (short)769327104;
			if (num2 != 0)
			{
			}
			return text;
			IL_31:
			text = global::System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
			num2 = (short)91029505;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00013288 File Offset: 0x00011488
		protected global::System.Reflection.PropertyInfo[] GetUIModelProperty(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel)
		{
			short num = (short)909770752;
			short num2 = num;
			num = (short)2122014585;
			short num3 = num;
			num = (short)232021881;
			switch (num3 == num)
			{
			}
			num = (short)2023882752;
			if (num != 0)
			{
			}
			num = (short)1543503873;
			if (num != 0)
			{
			}
			return uiModel.GetType().GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00013340 File Offset: 0x00011540
		protected global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<int?, object>> GetAllowCopyAndPasteProperty(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel)
		{
			short num = (short)619839488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				int num3;
				global::System.Reflection.PropertyInfo[] array2;
				global::System.Reflection.PropertyInfo[] uimodelProperty;
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<int?, object>> dictionary;
				global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.KeyValuePair<string, int?>> dictionary2;
				for (;;)
				{
					IL_27:
					global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentifyAttribute[] array;
					global::System.Reflection.PropertyInfo propertyInfo;
					switch (num2)
					{
					case 0:
						if (array[0].SupportCopyPaste)
						{
							num = (short)1086062600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104;
					case 1:
						if (array != null)
						{
							num = (short)1598619659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104;
					case 2:
					{
						if (num3 < array2.Length)
						{
							goto IL_2F5;
						}
						num = (short)2121371421;
						short num4 = num;
						num = (short)1998556957;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2F5;
						default:
							num = (short)1645740032;
							if (num != 0)
							{
							}
							num = (short)1579745286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						try
						{
							num = (short)1610940418;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2E2;
								case 1:
								{
									global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.KeyValuePair<string, int?>>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1077084164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.KeyValuePair<string, int?>> a = enumerator.Current;
									num = (short)1199243267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1AC;
									}
									continue;
								case 3:
									if (global::System.Convert.ToBoolean(uimodelProperty.Where(new global::System.Func<global::System.Reflection.PropertyInfo, bool>(b.b)).FirstOrDefault<global::System.Reflection.PropertyInfo>().GetValue(uiModel), global::System.Globalization.CultureInfo.InvariantCulture))
									{
										num = (short)823590917;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									num = (short)1116209152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.Generic.KeyValuePair<int?, object> value = new global::System.Collections.Generic.KeyValuePair<int?, object>(b.a.Value.Value, b.a.Key.GetValue(uiModel));
									dictionary.Add(b.a.Key.Name, value);
									num = (short)1846804486;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1B1:
								num = (short)2101018625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AC:
								goto IL_1B1;
							}
							IL_2E2:
							return dictionary;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.KeyValuePair<string, int?>>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2F5;
					case 4:
						if (array.Count<global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentifyAttribute>() > 0)
						{
							num = (short)507969545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104;
					case 5:
						goto IL_351;
					case 6:
					{
						global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.KeyValuePair<string, int?>>.Enumerator enumerator = dictionary2.GetEnumerator();
						num = (short)382861315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)463273985;
						if (num != 0)
						{
						}
						num = (short)1177157632;
						short num5 = num;
						goto IL_351;
					}
					case 8:
					{
						string editableConstrainPropertyName = array[0].EditableConstrainPropertyName;
						int? mappedServerField = array[0].MappedServerField;
						global::System.Collections.Generic.KeyValuePair<string, int?> value2 = new global::System.Collections.Generic.KeyValuePair<string, int?>(editableConstrainPropertyName, mappedServerField);
						dictionary2.Add(propertyInfo, value2);
						num = (short)678035466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1290272768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_104;
					case 11:
						num = (short)794624004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5E;
					IL_104:
					num3++;
					num = (short)788332549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F5:
					propertyInfo = array2[num3];
					array = (propertyInfo.GetCustomAttributes(typeof(global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentifyAttribute), false) as global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentifyAttribute[]);
					num = (short)223084545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_351:
					num = (short)1614413826;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_5E:
				uimodelProperty = this.GetUIModelProperty(uiModel);
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<int?, object>>();
				dictionary2 = new global::System.Collections.Generic.Dictionary<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.KeyValuePair<string, int?>>();
				array2 = uimodelProperty;
				num3 = 0;
				num = (short)1844576263;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000137D0 File Offset: 0x000119D0
		protected global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? PasteRecordCommon(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModelPaste, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModelCopy, ref global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> needValidateRecords)
		{
			short num = (short)1555234816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::System.Collections.Generic.List<string> list2;
				global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_2DC;
					case 1:
						try
						{
							num = (short)1153761280;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D1;
									}
									continue;
								case 1:
									goto IL_2C9;
								case 2:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)950206468;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.c c = new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.c();
									c.a = enumerator.Current;
									global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<int?, object>> allowCopyAndPasteProperty;
									int? key = allowCopyAndPasteProperty.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<int?, object>>, bool>(c.b)).First<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<int?, object>>>().Value.Key;
									global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<int?, object>> allowCopyAndPasteProperty2;
									object value = allowCopyAndPasteProperty2.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<int?, object>>, bool>(c.c)).First<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<int?, object>>>().Value.Value;
									global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> list;
									this.PasteField(radio, uiModelPaste, c.a, key, value, list);
									num = (short)781713411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)997392385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1D6:
								num = (short)1571094530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D1:
								goto IL_1D6;
							}
							IL_2C9:
							goto IL_154;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2DC;
						IL_154:
						num = (short)636682245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, object>>();
						global::System.Collections.Generic.List<string>.Enumerator enumerator = list2.GetEnumerator();
						num = (short)2053308417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_130;
					case 4:
					{
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> list;
						result = new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>?(new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>(uiModelPaste, list));
						needValidateRecords.Add(uiModelPaste);
						num = (short)1115553798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> list;
						if (list.Count > 0)
						{
							num = (short)347602948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 6:
						return result;
					case 7:
						if (list2.Count > 0)
						{
							num = (short)679804930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_4F;
					IL_2DC:
					num = (short)218431495;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_130:
				if (list2 != null)
				{
					goto IL_136;
				}
				return result;
				IL_4F:
				num = (short)1689695223;
				short num3 = num;
				num = (short)1331737591;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_136:
					num = (short)1530396672;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
				{
					num = (short)1180762113;
					if (num != 0)
					{
					}
					num = (short)1885863936;
					short num4 = num;
					num = (short)1679491072;
					if (num != 0)
					{
					}
					result = null;
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<int?, object>> allowCopyAndPasteProperty2 = this.GetAllowCopyAndPasteProperty(uiModelCopy);
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<int?, object>> allowCopyAndPasteProperty = this.GetAllowCopyAndPasteProperty(uiModelPaste);
					list2 = allowCopyAndPasteProperty2.Keys.Intersect(allowCopyAndPasteProperty.Keys).ToList<string>();
					num = (short)1230635011;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00013B74 File Offset: 0x00011D74
		protected virtual void PasteField(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModelPaste, string fieldName, int? fieldTypeMappedToServer, object fieldNewValue, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> fieldValueListForServer)
		{
			int a_ = 7;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_5D;
				}
				int num;
				object value;
				global::System.Reflection.PropertyInfo property;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (value == null)
						{
							num2 = (short)1278017552;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_292;
					case 1:
						if (fieldTypeMappedToServer != null)
						{
							num2 = (short)1585119236;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F9;
					case 2:
						num2 = (short)523173895;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)1036124160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						fieldValueListForServer.Add(new global::System.Collections.Generic.KeyValuePair<int, object>(fieldTypeMappedToServer.Value, fieldNewValue));
						property.SetValue(uiModelPaste, fieldNewValue, null);
						num2 = (short)562036745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (!fieldNewValue.Equals(value))
						{
							goto IL_1DB;
						}
						goto IL_2CC;
					case 6:
						goto IL_E9;
					case 7:
					{
						if (value != null)
						{
							goto IL_AC;
						}
						num2 = (short)1830798886;
						short num3 = num2;
						num2 = (short)1317193254;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DB;
						default:
							num2 = (short)667942912;
							if (num2 != 0)
							{
							}
							num2 = (short)985595910;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 8:
						if (fieldNewValue != null)
						{
							num2 = (short)281542666;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2CC;
					case 9:
						goto IL_2CC;
					case 10:
						num2 = (short)370081797;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						goto IL_AC;
					case 12:
						if (fieldNewValue == null)
						{
							num2 = (short)654442499;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_292;
					case 13:
						goto IL_2E5;
					case 14:
						goto IL_13B;
					case 15:
						if (fieldNewValue == null)
						{
							num2 = (short)1028915202;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E9;
					case 16:
						num2 = (short)53936142;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5D;
					IL_AC:
					num2 = (short)491520001;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_E9:
					num2 = (short)581894152;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1DB:
					num2 = (short)865206283;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_292:
					num2 = (short)2090467343;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_2CC:
					num2 = (short)1598750733;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_13B:
				goto IL_2EA;
				IL_1F9:
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("甠䬢䀤ܦ娨个弬央吰䄲ᔴ娶堸䬺䴼娾╀捂⍄⹆ⱈ❊⥌㭎⡐⍒ご睖じ⡚絜ㅞᑠར।䭦䥨ժ࡬੮ᕰ卲ٴݶᱸ᡺ᑼṾꎂ꾎ﲒ떔ﾖ列쒠", a_));
				IL_2E5:
				goto IL_2EA;
				IL_5D:
				property = uiModelPaste.GetType().GetProperty(fieldName);
				value = property.GetValue(uiModelPaste);
				num2 = (short)347996172;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch
			{
			}
			IL_2EA:
			num2 = (short)1156972544;
			short num4 = num2;
			num2 = (short)644612097;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060000BD RID: 189
		protected abstract global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> PasteRadioRelatedRecords(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase copiedRadio, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioToPaste, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> copiedRadioIdentityRecords, global::Motorola.CommonCPS.Server.EntityModel.Radio validateCopyRadio, global::Motorola.CommonCPS.Server.EntityModel.Radio validatePasteRadio, ref global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> needValidateRecords);

		// Token: 0x060000BE RID: 190 RVA: 0x00013ED8 File Offset: 0x000120D8
		private void a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> A_0)
		{
			short num = (short)1393360896;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					try
					{
						num = (short)1447559171;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.CommonCPS.Server.EntityModel.Package package;
							int? length;
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)1663434757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								package = enumerator.Current;
								num = (short)1759969284;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1B3;
							case 2:
								if (length == null)
								{
									num = (short)494272518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_95;
								}
								continue;
							case 4:
								if (package.RMFile != null)
								{
									num = (short)1428750343;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 5:
								num = (short)471007233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								try
								{
									package.RMFile.Length = new int?((int)new global::System.IO.FileInfo(package.RMFile.Url).Length);
									break;
								}
								catch
								{
									package.RMFile.Length = new int?(0);
									break;
								}
								goto IL_150;
							case 7:
								goto IL_150;
							}
							IL_97:
							num = (short)1488584704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_95:
							goto IL_97;
							IL_150:
							length = package.RMFile.Length;
							num = (short)345636866;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1B3:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1C6;
				case 2:
					goto IL_1C6;
				}
				IL_30:
				if (A_0 != null)
				{
					num = (short)1356529666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1C6:
				num = (short)1566769153;
				if (num != 0)
				{
				}
				enumerator = A_0.GetEnumerator();
				num = (short)947499328;
				short num3 = num;
				num = (short)1136898368;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1001455616;
					short num4 = num;
					num = (short)2046689280;
					if (num != 0)
					{
					}
					num = (short)70713345;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000141A4 File Offset: 0x000123A4
		private void a(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventInfo A_0)
		{
			int a_ = 13;
			short num = (short)433717248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::Motorola.CommonCPS.Server.EntityModel.RMCInfo rmcinfo;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_AE;
					case 1:
						goto IL_D94;
					case 2:
						num = (short)1172570122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_AE;
					case 4:
						try
						{
							num = (short)1141309464;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> list;
								switch (num2)
								{
								case 1:
									goto IL_D81;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry;
									global::System.Guid? guid = clientEventEntry.EventArgs as global::System.Guid?;
									num = (short)1281097761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
									global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = radioSummary.ToUiModel(true);
									global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
									{
										radioBase
									});
									global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
									stringBuilder.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("渦洨ᄪ", a_) + radioBase.ID.ToString());
									stringBuilder.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("椦䠨䘪䠬ᔮ", a_) + radioBase.SerialNumber);
									stringBuilder.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("洦䘨䤪縬嬮倰䜲䀴䐶̸", a_) + radioBase.JobStatus.ToString());
									stringBuilder.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搦嬨帪䌬䰮夰嘲䜴搶䴸娺䤼䨾㉀祂", a_) + radioBase.CruncherStatus.ToString());
									stringBuilder.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ദ̨ĪܬԮᬰᤲἴᴶጸᄺ᜼ᔾ歀楂潄浆捈慊杌敎筐祒罔絖獘煚睜畞", a_));
									num = (short)944963592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Guid? guid2;
									global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::System.Guid>
									{
										guid2.Value
									});
									global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).EventInfo(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("甦䰨䠪䠬䘮䜰嘲儴᜶欸娺夼嘾⹀݂⁄⭆ⱈ㽊⡌⭎煐㙒⍔㉖㝘⽚", a_));
									num = (short)533594127;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									this.DMMigrationEvent(list);
									num = (short)210108447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.Common.LogUtility.ILog logger = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
									string str = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("甦䰨䠪䠬䘮䜰嘲儴᜶欸娺夼嘾⹀၂い⩆⑈⩊㽌㙎ቐ㭒㑔㥖㹘㹚㥜罞Ѡᕢd०ᵨ䭪౬Ůᕰ卲ݴቶὸॺ᡼౾ꎂꎎ놐", a_);
									global::System.Text.StringBuilder stringBuilder;
									global::System.Text.StringBuilder stringBuilder2 = stringBuilder;
									logger.EventInfo(str + ((stringBuilder2 != null) ? stringBuilder2.ToString() : null));
									num = (short)1502412820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_973;
								case 11:
									if (this.DMMigrationEvent != null)
									{
										num = (short)1993539591;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D49;
								case 12:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1871773726;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry = enumerator.Current;
									global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType eventType = clientEventEntry.EventType;
									num = (short)705560603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate dmmigrationEvent = this.DMMigrationEvent;
									if (dmmigrationEvent == null)
									{
										num = (short)436273161;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs dbmigrationEventArgs;
									dmmigrationEvent(dbmigrationEventArgs);
									num = (short)185204738;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs dbmigrationEventArgs;
									if (dbmigrationEventArgs != null)
									{
										num = (short)2017394709;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 17:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_AD2;
										}
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>.Enumerator enumerator2;
										global::System.Text.StringBuilder stringBuilder3;
										for (;;)
										{
											IL_ABF:
											global::Motorola.Common.LogUtility.ILog logger2;
											string str2;
											string str3;
											switch (num2)
											{
											case 0:
												try
												{
													num = (short)1523384321;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
															num = (short)703725572;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_B7B;
															}
															continue;
														case 3:
														{
															if (!enumerator2.MoveNext())
															{
																num = (short)246808576;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer = enumerator2.Current;
															stringBuilder3.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("渦洨ᄪ", a_) + jobContainer.ID.ToString());
															stringBuilder3.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("椦䠨䘪䠬ᔮ", a_) + jobContainer.ContainerName);
															stringBuilder3.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("琦崨䨪夬娮䈰ल", a_) + jobContainer.Status.ToString());
															stringBuilder3.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ദ̨ĪܬԮᬰᤲἴᴶጸᄺ᜼ᔾ歀楂潄浆捈慊杌敎筐祒罔絖獘煚睜畞", a_));
															num = (short)337772546;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 4:
															goto IL_C96;
														}
														IL_C3D:
														num = (short)1791623171;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_B7B:
														goto IL_C3D;
													}
													IL_C96:
													goto IL_AFB;
												}
												finally
												{
													((global::System.IDisposable)enumerator2).Dispose();
												}
												goto IL_CA9;
												IL_AFB:
												num = (short)46137345;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												logger2 = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
												str2 = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("甦䰨䠪䠬䘮䜰嘲儴᜶猸吺弼簾⹀ⵂㅄ♆⁈╊⡌㵎ቐ㭒㑔㥖㹘㹚㥜罞Ѡᕢd०ᵨ䝪䵬", a_);
												global::System.Text.StringBuilder stringBuilder4 = stringBuilder3;
												str3 = ((stringBuilder4 != null) ? stringBuilder4.ToString() : null);
												goto IL_CA9;
											}
											case 2:
												goto IL_CCB;
											}
											goto IL_AD2;
											IL_CA9:
											logger2.EventInfo(str2 + str3);
											num = (short)1933377538;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_CCB:
										break;
										IL_AD2:
										stringBuilder3 = new global::System.Text.StringBuilder();
										enumerator2 = list.GetEnumerator();
										num = (short)1367080960;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_ABF;
									}
									catch
									{
										break;
									}
									goto IL_CD6;
								case 18:
									if (this.DMMigrationEvent != null)
									{
										num = (short)1058144266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CD6;
								case 19:
								{
									global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
									if (radioSummary != null)
									{
										num = (short)990576645;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 21:
								{
									num = (short)1438072064;
									short num3 = num;
									num = (short)798178560;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5D2;
									default:
										num = (short)460849152;
										if (num != 0)
										{
										}
										num = (short)789643277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 22:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_7AF;
										}
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>.Enumerator enumerator2;
										global::System.Text.StringBuilder stringBuilder5;
										for (;;)
										{
											IL_79C:
											switch (num2)
											{
											case 0:
												try
												{
													num = (short)423297025;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 1:
															switch (0)
															{
															case 0:
																goto IL_810;
															}
															continue;
														case 2:
														{
															if (!enumerator2.MoveNext())
															{
																num = (short)1373569027;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer jobContainer2 = enumerator2.Current;
															stringBuilder5.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("渦洨ᄪ", a_) + jobContainer2.ID.ToString());
															stringBuilder5.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("椦䠨䘪䠬ᔮ", a_) + jobContainer2.ContainerName);
															stringBuilder5.AppendLine(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ദ̨ĪܬԮᬰᤲἴᴶጸᄺ᜼ᔾ歀楂潄浆捈慊杌敎筐祒罔絖獘煚睜畞", a_));
															num = (short)1684275200;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 3:
															num = (short)554369028;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 4:
															goto IL_8F2;
														}
														IL_812:
														num = (short)1116667906;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_810:
														goto IL_812;
													}
													IL_8F2:;
												}
												finally
												{
													((global::System.IDisposable)enumerator2).Dispose();
												}
												num = (short)1915355137;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												global::Motorola.Common.LogUtility.ILog logger3 = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
												string str4 = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("甦䰨䠪䠬䘮䜰嘲儴᜶猸吺弼簾⹀ⵂㅄ♆⁈╊⡌㵎ቐ⅒ご㙖ⵘ㹚㥜罞Ѡᕢd०ᵨ䝪䵬", a_);
												global::System.Text.StringBuilder stringBuilder6 = stringBuilder5;
												logger3.EventInfo(str4 + ((stringBuilder6 != null) ? stringBuilder6.ToString() : null));
												num = (short)675282946;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_968;
											}
											goto IL_7AF;
										}
										IL_968:
										break;
										IL_7AF:
										stringBuilder5 = new global::System.Text.StringBuilder();
										enumerator2 = list.GetEnumerator();
										num = (short)1651834880;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_79C;
									}
									catch
									{
										break;
									}
									goto IL_973;
								case 23:
								{
									global::System.Guid? guid;
									global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::System.Guid>
									{
										guid.Value
									});
									num = (short)1139998745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
									switch (0)
									{
									case 0:
										goto IL_264;
									}
									continue;
								case 26:
									goto IL_CD6;
								case 27:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType eventType;
									switch (eventType)
									{
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.APXRadioSummaryChanged:
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.MatrixRadioSummaryChanged:
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.PBBRadioSummaryChanged:
									{
										global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry;
										global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary = clientEventEntry.EventArgs as global::Motorola.CommonCPS.Server.EntityModel.RadioSummary;
										num = (short)381485075;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.APXRadioSummaryDeleted:
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.MatrixRadioSummaryDeleted:
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.PBBRadioSummaryDeleted:
									{
										global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry;
										global::System.Guid? guid2 = clientEventEntry.EventArgs as global::System.Guid?;
										num = (short)2094268445;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.BatchOpJobViewSummaryChanged:
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.PropertyChanged:
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.OTAPKeyChanged:
										break;
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.JobContainerSummaryCreated:
									{
										global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry;
										global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary jobContainerSummarie = (global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary)clientEventEntry.EventArgs;
										list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>
										{
											jobContainerSummarie.ToUiModel()
										};
										global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(list);
										num = (short)2014838802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.JobContainerSummaryChanged:
									{
										global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry;
										global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary jobContainerSummarie = (global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary)clientEventEntry.EventArgs;
										list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>
										{
											jobContainerSummarie.ToUiModel()
										};
										global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(list);
										num = (short)306577419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.JobContainerSummaryDeleted:
									{
										global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry;
										global::System.Collections.Generic.List<global::System.Guid> idList = new global::System.Collections.Generic.List<global::System.Guid>
										{
											(global::System.Guid)clientEventEntry.EventArgs
										};
										global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheDeleteItems<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>(idList);
										num = (short)2005008387;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.DBMigrationEvent:
									{
										global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry;
										global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs dbmigrationEventArgs = clientEventEntry.EventArgs as global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationEventArgs;
										num = (short)1604452366;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.ConversionEvent:
										num = (short)1695154204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case global::Motorola.CommonCPS.Server.CommonDBConstants.ClientEventType.DBSizeChangedEvent:
									{
										global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventEntry clientEventEntry;
										global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel databaseSpaceWarning = (global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel)((int)clientEventEntry.EventArgs);
										global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().DatabaseSpaceWarning(databaseSpaceWarning);
										goto IL_5D2;
									}
									default:
										num = (short)355205152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 28:
									if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
									{
										num = (short)1859977220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 29:
								{
									global::System.Guid? guid2;
									if (guid2 != null)
									{
										num = (short)1165164550;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 30:
									num = (short)65732609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									goto IL_D49;
								case 32:
									num = (short)1621688336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
								{
									global::System.Guid? guid;
									if (guid != null)
									{
										num = (short)984809495;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_399:
								num = (short)371523596;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_264:
								goto IL_399;
								IL_5D2:
								num = (short)1406468096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_973:
								this.DMMigrationEvent(list);
								num = (short)1580269594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CD6:
								num = (short)1892941846;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D49:
								num = (short)198901777;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D81:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_D94;
					case 5:
						num = (short)1174208520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!string.IsNullOrEmpty(A_0.SenderId))
						{
							num = (short)1939144706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					case 7:
						num = (short)287571977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.ClientIdPattern.IsMatch(A_0.SenderId))
						{
							num = (short)467992583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					case 9:
						if (this.ClientIdPattern.IsMatch(rmcinfo.ClientId))
						{
							num = (short)1055653889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7;
					case 10:
						if (!string.IsNullOrEmpty(rmcinfo.ClientId))
						{
							num = (short)1538195461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					}
					goto IL_63;
					IL_AE:
					enumerator = A_0.EventEntries.GetEnumerator();
					num = (short)167116804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D7:
					num = (short)320208896;
					short num4 = num;
					this.IsServerEventLocal = this.f;
					num = (short)757792771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D94:
					num = (short)1421541377;
					if (num != 0)
					{
					}
					this.IsServerEventLocal = (A_0.SenderId == rmcinfo.ClientId);
					this.f = this.IsServerEventLocal;
					num = (short)1065615360;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_63:
				rmcinfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).RMCInfo;
				num = (short)1616248838;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00015078 File Offset: 0x00013278
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData> b(string A_0)
		{
			int a_ = 1;
			short num = (short)133160250;
			short num2 = num;
			num = (short)102423866;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)627572737;
				if (num != 0)
				{
				}
				num = (short)388759552;
				short num3 = num;
				num = (short)314245120;
				if (num != 0)
				{
				}
				num = (short)935854080;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::System.Collections.Generic.IList<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData>();
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			xmlDocument.Load(A_0);
			global::System.Collections.IEnumerator enumerator = xmlDocument.LastChild.ChildNodes.GetEnumerator();
			try
			{
				num = (short)348979207;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
					{
						global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
						string text = xmlNode.Attributes[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("爚礜", a_)].Value;
						if (text.Contains(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("㔚甜欞䰠伢", a_)))
						{
							text = text.Substring(0, text.Length - 5);
						}
						string value = xmlNode.Attributes[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("渚漜猞", a_)].Value;
						string value2 = xmlNode.Attributes[global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漚琜欞䴠䘢", a_)].Value;
						global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData helpMapData = new global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData
						{
							Id = text,
							Url = value,
							Title = value2
						};
						num = (short)1222639621;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData helpMapData;
						list.Add(helpMapData.Id);
						num = (short)842792960;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)593035274;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)1913651203;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1662124033;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData helpMapData;
						if (dictionary.ContainsKey(helpMapData.Id))
						{
							num = (short)313917448;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text;
						dictionary.Add(text, helpMapData);
						num = (short)1048969222;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_140;
						}
						continue;
					case 8:
						num = (short)1264582665;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData helpMapData;
						if (!list.Contains(helpMapData.Id))
						{
							num = (short)1379467266;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_342;
					}
					IL_189:
					num = (short)913178628;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_140:
					goto IL_189;
				}
				IL_342:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_361;
				}
				int num4;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_34E:
					switch (num4)
					{
					case 0:
						if (disposable != null)
						{
							num = (short)614989825;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BA;
					case 1:
						disposable.Dispose();
						num = (short)1561198594;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3B8;
					}
					goto IL_361;
				}
				IL_3B8:
				IL_3BA:
				goto EndFinally_8;
				IL_361:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)455671808;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_34E;
				EndFinally_8:;
			}
			return dictionary;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00015460 File Offset: 0x00013660
		private string a(string A_0)
		{
			short num = (short)770625178;
			short num2 = num;
			num = (short)205704858;
			switch (num2 == num)
			{
			default:
			{
				num = (short)735903744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)268107777;
			if (num != 0)
			{
			}
			num = (short)2107899904;
			if (num != 0)
			{
			}
			int num4 = A_0.LastIndexOf('\\');
			return A_0.Substring(num4 + 1);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0001551C File Offset: 0x0001371C
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_1, global::Motorola.CommonCPS.Server.EntityModel.Radio A_2, global::Motorola.CommonCPS.Server.EntityModel.Radio A_3, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> A_4, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> A_5, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> A_6)
		{
			short num = (short)1498808320;
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
				bool flag;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> list;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> a_;
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> list2;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair;
						if (keyValuePair != null)
						{
							num = (short)1936719873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_274;
					}
					case 1:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair;
						list.Add(keyValuePair.Value);
						num = (short)1142423559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair;
						if (keyValuePair != null)
						{
							num = (short)516161544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_274;
					}
					case 3:
						return;
					case 4:
					{
						num = (short)393171185;
						short num3 = num;
						num = (short)2044154097;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B4;
						default:
						{
							num = (short)1344667648;
							if (num != 0)
							{
							}
							if (!flag)
							{
								num = (short)2099118083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							A_0.Validator = null;
							list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>();
							a_ = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>();
							global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair = this.PasteRecordCommon(A_0, A_0, A_1, ref a_);
							num = (short)823001090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 5:
						if (list2 != null)
						{
							num = (short)909574156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23B;
					case 6:
						if (list2.Count > 0)
						{
							num = (short)473366538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23B;
					case 7:
						num = (short)923074561;
						if (num != 0)
						{
						}
						goto IL_274;
					case 8:
						num = (short)1814167552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)1615593472;
						short num4 = num;
						goto IL_156;
					}
					case 10:
						list.AddRange(list2);
						goto IL_B4;
					case 11:
						goto IL_23B;
					case 12:
						num = (short)882835462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_156;
					}
					goto IL_67;
					IL_B4:
					num = (short)50659339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_156:
					num = (short)1426653188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23B:
					flag = this.a(A_5, list);
					this.a(A_5, list, A_6, a_);
					A_0.a();
					num = (short)568000525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_274:
					list2 = null;
					list2 = this.PasteRadioRelatedRecords(A_1, A_0, A_4, A_2, A_3, ref a_);
					num = (short)262602757;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_67:
				flag = true;
				num = (short)1342898185;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00015840 File Offset: 0x00013A40
		private bool a(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> A_0, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> A_1)
		{
			short num = (short)701366272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_4CA;
					case 1:
						if (A_1.Count != 0)
						{
							num = (short)29163524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 2:
						if (A_1 != null)
						{
							num = (short)604700672;
							short num3 = num;
							num = (short)1099825152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 3:
						try
						{
							num = (short)1675296775;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)902168582;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_391;
											case 1:
											{
												global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
												if (enumerable != null)
												{
													num = (short)1811677187;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
											{
												global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
												if (enumerable.Count<global::System.Collections.Generic.KeyValuePair<int, object>>() == 0)
												{
													num = (short)1066008581;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												num = (short)1543897090;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_3ED;
											case 5:
												goto IL_374;
											case 6:
												switch (0)
												{
												case 0:
													goto IL_29B;
												}
												continue;
											case 7:
												num = (short)1274937345;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
											{
												global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
												if (enumerable != null)
												{
													num = (short)1009778695;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_374;
											}
											case 9:
												num = (short)1191575556;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
											{
												global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, object>> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)281346057;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.e e = new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.e();
												e.a = enumerator.Current;
												global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> value;
												global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable = value.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<int, object>, bool>(e.b));
												num = (short)700710920;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											goto IL_29B;
											IL_374:
											flag = true;
											result = flag;
											num = (short)730529792;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_396:
											num = (short)1534066698;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_29B:
											goto IL_396;
										}
										IL_391:
										return result;
										IL_3ED:
										break;
									}
									finally
									{
										num = (short)1754005504;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, object>> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_425;
												}
												continue;
											case 1:
												enumerator.Dispose();
												num = (short)1663893506;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_45D;
											}
											IL_425:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1456209921;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_45D:;
									}
									goto IL_460;
								case 1:
									goto IL_243;
								case 2:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2;
									if (enumerable2 == null)
									{
										goto IL_226;
									}
									num = (short)1563397874;
									short num4 = num;
									num = (short)1138724594;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_BC;
									default:
										num = (short)2033844224;
										if (num != 0)
										{
										}
										num = (short)912850948;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)576585734;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.d d = new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.d();
									d.a = enumerator2.Current;
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2 = A_0.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>, bool>(d.b));
									num = (short)689700866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_460;
								case 5:
									goto IL_4BA;
								case 6:
									num = (short)1957888005;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_BC;
								case 8:
								{
									global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.d d;
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> value2 = d.a.Value;
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2;
									global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> value = enumerable2.First<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>().Value;
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, object>> enumerator = value2.GetEnumerator();
									num = (short)1460207616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2;
									if (enumerable2.Count<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>() > 0)
									{
										num = (short)377683976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_226;
								}
								}
								goto IL_F5;
								IL_BC:
								switch (0)
								{
								case 0:
									IL_F5:
									goto IL_FA;
								}
								continue;
								IL_FA:
								num = (short)958070787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_226:
								flag = true;
								result = flag;
								num = (short)1867448321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_460:
								num = (short)479330313;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_243:
							return result;
							IL_4BA:
							return flag;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_4CA;
					case 4:
					{
						num = (short)1848377345;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator2 = A_1.GetEnumerator();
						num = (short)1431896067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_42;
					IL_4CA:
					num = (short)1585250305;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_42:
				flag = false;
				num = (short)1625751554;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00015DD8 File Offset: 0x00013FD8
		private void a(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> A_0, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> A_1, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> A_2, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> A_3)
		{
			short num = (short)626393088;
			switch (num)
			{
			default:
				num = (short)212992001;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>.Enumerator enumerator = A_1.GetEnumerator())
				{
					num = (short)605945863;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.f f;
						switch (num2)
						{
						case 1:
							num = (short)2053308425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)617807879;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.g g;
									global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> value;
									switch (num2)
									{
									case 1:
									{
										global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
										if (enumerable != null)
										{
											num = (short)871694345;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_46B;
									}
									case 2:
									{
										global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
										if (enumerable.Count<global::System.Collections.Generic.KeyValuePair<int, object>>() > 0)
										{
											num = (short)542638084;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_46B;
									}
									case 3:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, object>> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1504772102;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										g = new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.g();
										g.a = enumerator2.Current;
										global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable = value.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<int, object>, bool>(g.b));
										num = (short)624754689;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
										value.Remove(enumerable.First<global::System.Collections.Generic.KeyValuePair<int, object>>());
										value.Add(g.a);
										num = (short)833814536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_592;
									case 6:
										num = (short)1347092485;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										switch (0)
										{
										case 0:
											goto IL_42B;
										}
										continue;
									case 9:
										num = (short)582942722;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_42D:
									num = (short)1239941123;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_42B:
									goto IL_42D;
									IL_46B:
									value.Add(g.a);
									num = (short)1532493824;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_592:
								break;
							}
							finally
							{
								num = (short)1878196224;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, object>> enumerator2;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_5C9;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)1117388802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_602;
									}
									IL_5C9:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)30081025;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_602:;
							}
							goto IL_605;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)328335366;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							f = new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.f();
							f.a = enumerator.Current;
							global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2 = A_0.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>, bool>(f.b));
							num = (short)1723203588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2;
							if (enumerable2 != null)
							{
								num = (short)1053556737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D5;
						}
						case 5:
							goto IL_61F;
						case 6:
							goto IL_605;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_291;
							}
							continue;
						case 8:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> value2 = f.a.Value;
							global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2;
							global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> value = enumerable2.First<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>().Value;
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<int, object>> enumerator2 = value2.GetEnumerator();
							num = (short)1941504002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2;
							if (enumerable2.Count<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>() > 0)
							{
								num = (short)1050083336;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D5;
						}
						}
						IL_296:
						num = (short)1932263427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_291:
						goto IL_296;
						IL_2D5:
						A_0.Add(f.a);
						num = (short)9175040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_605:
						num = (short)1849032709;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_61F:
					goto IL_20C;
				}
				return;
				for (;;)
				{
					IL_20C:
					num = (short)370475008;
					short num3 = num;
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator3 = A_3.GetEnumerator())
					{
						num = (short)277872645;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
							{
								if (!enumerator3.MoveNext())
								{
									num = (short)9306114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.h h = new global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.h();
								h.a = enumerator3.Current;
								global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = A_2.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, bool>(h.b));
								num = (short)1467547655;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								num = (short)46429027;
								short num4 = num;
								num = (short)925397859;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_66;
								default:
									num = (short)379453440;
									if (num != 0)
									{
									}
									num = (short)559611907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_1F9;
							case 5:
								goto IL_66;
							case 6:
							{
								global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.h h;
								A_2.Add(h.a);
								num = (short)80478208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase;
								if (uimodelBase == null)
								{
									num = (short)309526534;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								A_2.Remove(uimodelBase);
								global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.h h;
								A_2.Add(h.a);
								num = (short)990642180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_97;
							IL_66:
							switch (0)
							{
							case 0:
								IL_97:
								goto IL_C6;
							}
							continue;
							IL_C6:
							num = (short)1976958977;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1F9:
						break;
					}
				}
				return;
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00016464 File Offset: 0x00014664
		// Note: this type is marked as 'beforefieldinit'.
		static LocalService()
		{
			short num = (short)1618365338;
			short num2 = num;
			num = (short)1579174810;
			switch (num2 == num)
			{
			}
			num = (short)269615105;
			if (num != 0)
			{
			}
			num = (short)1213333504;
			short num3 = num;
			num = (short)1131085824;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.a = new object();
		}

		// Token: 0x04000007 RID: 7
		private static readonly object a;

		// Token: 0x04000008 RID: 8
		private readonly bool b;

		// Token: 0x04000009 RID: 9
		private string c;

		// Token: 0x0400000A RID: 10
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.LocalService.HelpMapData> d;

		// Token: 0x0400000B RID: 11
		private string e;

		// Token: 0x0400000C RID: 12
		private bool f;

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService.DBMigrationEventDelegate g;

		// Token: 0x0400000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h;

		// Token: 0x0400000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::System.Text.RegularExpressions.Regex i;

		// Token: 0x04000010 RID: 16
		private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>>> j;

		// Token: 0x04000011 RID: 17
		private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>>> k;

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x060001E5 RID: 485
		public delegate void DBMigrationEventDelegate(object eventArgs);

		// Token: 0x0200002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a<a> where a : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			// Token: 0x060001F8 RID: 504 RVA: 0x00023854 File Offset: 0x00021A54
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<string>> A_0)
			{
				short num = (short)1828549478;
				short num2 = num;
				num = (short)73560934;
				switch (num2 == num)
				{
				}
				num = (short)1577189377;
				if (num != 0)
				{
				}
				num = (short)875233280;
				short num3 = num;
				num = (short)266403840;
				if (num != 0)
				{
				}
				return A_0.Key == this.a;
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x00023910 File Offset: 0x00021B10
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Action<global::System.Collections.Specialized.StringCollection>> A_0)
			{
				short num = (short)539040119;
				short num2 = num;
				num = (short)383129975;
				switch (num2 == num)
				{
				}
				num = (short)998506497;
				if (num != 0)
				{
				}
				num = (short)1819344896;
				short num3 = num;
				num = (short)731840512;
				if (num != 0)
				{
				}
				return A_0.Key == this.a;
			}

			// Token: 0x04000058 RID: 88
			public global::System.Type a;
		}

		// Token: 0x0200002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060001FF RID: 511 RVA: 0x00023C24 File Offset: 0x00021E24
			internal bool b(global::System.Reflection.PropertyInfo A_0)
			{
				short num = (short)347419143;
				short num2 = num;
				num = (short)2071278087;
				switch (num2 == num)
				{
				}
				num = (short)633470976;
				if (num != 0)
				{
				}
				num = (short)675676160;
				short num3 = num;
				num = (short)293601281;
				if (num != 0)
				{
				}
				return A_0.Name == this.a.Value.Key;
			}

			// Token: 0x0400005C RID: 92
			public global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.KeyValuePair<string, int?>> a;
		}

		// Token: 0x02000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x06000201 RID: 513 RVA: 0x00023D00 File Offset: 0x00021F00
			internal bool b(global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<int?, object>> A_0)
			{
				short num = (short)843297910;
				short num2 = num;
				num = (short)466728054;
				switch (num2 == num)
				{
				}
				num = (short)289669121;
				if (num != 0)
				{
				}
				num = (short)1697644544;
				short num3 = num;
				num = (short)1814888448;
				if (num != 0)
				{
				}
				return A_0.Key == this.a;
			}

			// Token: 0x06000202 RID: 514 RVA: 0x00023DBC File Offset: 0x00021FBC
			internal bool c(global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.KeyValuePair<int?, object>> A_0)
			{
				short num = (short)1440350209;
				if (num != 0)
				{
				}
				num = (short)1919972137;
				short num2 = num;
				num = (short)1062957865;
				switch (num2 == num)
				{
				}
				num = (short)1736245248;
				short num3 = num;
				num = (short)290455552;
				if (num != 0)
				{
				}
				return A_0.Key == this.a;
			}

			// Token: 0x0400005D RID: 93
			public string a;
		}

		// Token: 0x02000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x06000204 RID: 516 RVA: 0x00023E90 File Offset: 0x00022090
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::System.Guid? id;
				short num2;
				global::System.Guid? id2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_78;
					case 1:
						return true;
					case 2:
					{
						if (id != null)
						{
							goto IL_156;
						}
						num2 = (short)1458050001;
						short num3 = num2;
						num2 = (short)1790776273;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num2 = (short)1931149312;
							if (num2 != 0)
							{
							}
							num2 = (short)575275009;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
					{
						if (id != null != (id2 != null))
						{
							num2 = (short)389087232;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2003566592;
						short num4 = num2;
						num2 = (short)533725186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_20;
				}
				IL_78:
				num2 = (short)1025572865;
				if (num2 != 0)
				{
				}
				return false;
				IL_156:
				return id.GetValueOrDefault() == id2.GetValueOrDefault();
				IL_20:
				id = A_0.Key.ID;
				id2 = this.a.Key.ID;
				num2 = (short)408485891;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x0400005E RID: 94
			public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> a;
		}

		// Token: 0x02000032 RID: 50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x06000206 RID: 518 RVA: 0x0002401C File Offset: 0x0002221C
			internal bool b(global::System.Collections.Generic.KeyValuePair<int, object> A_0)
			{
				short num = (short)1274587429;
				short num2 = num;
				num = (short)627419429;
				switch (num2 == num)
				{
				}
				num = (short)1080885249;
				if (num != 0)
				{
				}
				num = (short)836435968;
				short num3 = num;
				num = (short)50724864;
				if (num != 0)
				{
				}
				return A_0.Key == this.a.Key;
			}

			// Token: 0x0400005F RID: 95
			public global::System.Collections.Generic.KeyValuePair<int, object> a;
		}

		// Token: 0x02000033 RID: 51
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class f
		{
			// Token: 0x06000208 RID: 520 RVA: 0x000240E8 File Offset: 0x000222E8
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				global::System.Guid? id;
				global::System.Guid? id2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return false;
					case 1:
						return true;
					case 2:
					{
						num2 = (short)1567293440;
						short num3 = num2;
						if (id != null)
						{
							goto IL_158;
						}
						num2 = (short)743960177;
						short num4 = num2;
						num2 = (short)2094853745;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num2 = (short)1374748672;
							if (num2 != 0)
							{
							}
							num2 = (short)1710948353;
							if (num2 != 0)
							{
							}
							num2 = (short)65273857;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						if (id != null != (id2 != null))
						{
							num2 = (short)356253696;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2070544386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				return false;
				IL_158:
				return id.GetValueOrDefault() == id2.GetValueOrDefault();
				IL_20:
				id = A_0.Key.ID;
				id2 = this.a.Key.ID;
				num2 = (short)1858535427;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x04000060 RID: 96
			public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> a;
		}

		// Token: 0x02000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class g
		{
			// Token: 0x0600020A RID: 522 RVA: 0x00024274 File Offset: 0x00022474
			internal bool b(global::System.Collections.Generic.KeyValuePair<int, object> A_0)
			{
				short num = (short)1579352065;
				if (num != 0)
				{
				}
				num = (short)485855297;
				short num2 = num;
				num = (short)1382780993;
				switch (num2 == num)
				{
				}
				num = (short)1705639936;
				short num3 = num;
				num = (short)840105984;
				if (num != 0)
				{
				}
				return A_0.Key == this.a.Key;
			}

			// Token: 0x04000061 RID: 97
			public global::System.Collections.Generic.KeyValuePair<int, object> a;
		}

		// Token: 0x02000035 RID: 53
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class h
		{
			// Token: 0x0600020C RID: 524 RVA: 0x00024348 File Offset: 0x00022548
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase A_0)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				global::System.Guid? id;
				global::System.Guid? id2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return false;
					case 1:
						return true;
					case 2:
					{
						num2 = (short)634060800;
						short num3 = num2;
						if (id != null)
						{
							goto IL_150;
						}
						num2 = (short)1396731808;
						short num4 = num2;
						num2 = (short)1846243232;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num2 = (short)1728446464;
							if (num2 != 0)
							{
							}
							num2 = (short)986644481;
							if (num2 != 0)
							{
							}
							num2 = (short)1724907521;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						if (id != null != (id2 != null))
						{
							num2 = (short)821297152;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1271070722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				return false;
				IL_150:
				return id.GetValueOrDefault() == id2.GetValueOrDefault();
				IL_20:
				id = A_0.ID;
				id2 = this.a.ID;
				num2 = (short)648413187;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}

			// Token: 0x04000062 RID: 98
			public global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase a;
		}
	}
}
