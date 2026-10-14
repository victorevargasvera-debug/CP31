using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using ASK.Interface;
using ASKLib;
using AutoUpdate;
using EntityModel.GenericModel;
using Motorola.Common.Cryptography;
using Motorola.Common.Cryptography.Exceptions;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;
using Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.HomeSetArgs;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses;
using Motorola.CommonCPS.Server.GenericModel;
using Motorola.CommonCPS.Server.RMDiscoveryServiceInterface;
using Motorola.CommonCPS.Server.RMServerContract;
using Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects;
using Motorola.Security.SamlCommonUtility;
using Motorola.Security.SamlTokenComponent;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200001D RID: 29
	[global::System.ComponentModel.Composition.Export(typeof(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor))]
	public class RmServerAccessor : global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor
	{
		// Token: 0x0600013B RID: 315 RVA: 0x0000B0D8 File Offset: 0x000092D8
		internal RmServerAccessor(bool needConnect = true)
		{
			int a_ = 5;
			this.c = global::System.Guid.NewGuid().ToString();
			this.j = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캛펝ﶡ쎥욧쾩\udeab잭펯쒵쪷햹캻", a_), null);
			base..ctor();
			if (needConnect)
			{
				this.Connect(false);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000B138 File Offset: 0x00009338
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000B1E8 File Offset: 0x000093E8
		public bool IsConnected
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)127410883;
				short num2 = num;
				num = (short)1145709251;
				switch (num2 == num)
				{
				}
				num = (short)1519190017;
				if (num != 0)
				{
				}
				num = (short)275054592;
				short num3 = num;
				num = (short)121765888;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)202874424;
				short num2 = num;
				num = (short)1504747064;
				switch (num2 == num)
				{
				}
				num = (short)1357709313;
				if (num != 0)
				{
				}
				num = (short)315228160;
				short num3 = num;
				num = (short)532283392;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000B29C File Offset: 0x0000949C
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000B34C File Offset: 0x0000954C
		public global::Motorola.Common.CustomException.CommonErrorCode CompatibilityErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)672330145;
				short num2 = num;
				num = (short)1684468129;
				switch (num2 == num)
				{
				}
				num = (short)2117140481;
				if (num != 0)
				{
				}
				num = (short)1796538368;
				short num3 = num;
				num = (short)1588002816;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1318322177;
				if (num != 0)
				{
				}
				num = (short)616105605;
				short num2 = num;
				num = (short)808846981;
				switch (num2 == num)
				{
				}
				num = (short)442761216;
				short num3 = num;
				num = (short)1545076736;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000B3FC File Offset: 0x000095FC
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0000B4AC File Offset: 0x000096AC
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler ServerEventArrived
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)49905446;
				short num2 = num;
				num = (short)340098854;
				switch (num2 == num)
				{
				}
				num = (short)606994433;
				if (num != 0)
				{
				}
				num = (short)1310654464;
				short num3 = num;
				num = (short)232914944;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)367104409;
				short num2 = num;
				num = (short)829329817;
				switch (num2 == num)
				{
				}
				num = (short)1349976065;
				if (num != 0)
				{
				}
				num = (short)996212736;
				short num3 = num;
				num = (short)545521664;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000142 RID: 322 RVA: 0x0000B560 File Offset: 0x00009760
		// (set) Token: 0x06000143 RID: 323 RVA: 0x0000B610 File Offset: 0x00009810
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IncompatibilityHandler IncompatiblityDetected
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1089048088;
				short num2 = num;
				num = (short)1708625432;
				switch (num2 == num)
				{
				}
				num = (short)2142437377;
				if (num != 0)
				{
				}
				num = (short)600375296;
				short num3 = num;
				num = (short)193462272;
				if (num != 0)
				{
				}
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1980619729;
				short num2 = num;
				num = (short)1764547537;
				switch (num2 == num)
				{
				}
				num = (short)1337851905;
				if (num != 0)
				{
				}
				num = (short)869072896;
				short num3 = num;
				num = (short)887291904;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000144 RID: 324 RVA: 0x0000B6C4 File Offset: 0x000098C4
		// (set) Token: 0x06000145 RID: 325 RVA: 0x0000B774 File Offset: 0x00009974
		public global::System.EventHandler InvalidJwtTokenDetected
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)381675163;
				short num2 = num;
				num = (short)1110107803;
				switch (num2 == num)
				{
				}
				num = (short)1614675969;
				if (num != 0)
				{
				}
				num = (short)753205248;
				short num3 = num;
				num = (short)1105199104;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)529095856;
				short num2 = num;
				num = (short)2122865840;
				switch (num2 == num)
				{
				}
				num = (short)591134720;
				if (num != 0)
				{
				}
				num = (short)206176256;
				short num3 = num;
				num = (short)342097921;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000146 RID: 326 RVA: 0x0000B820 File Offset: 0x00009A20
		// (set) Token: 0x06000147 RID: 327 RVA: 0x0000B8D0 File Offset: 0x00009AD0
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted ConnectionClosedFaulted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2053046273;
				if (num != 0)
				{
				}
				num = (short)810226778;
				short num2 = num;
				num = (short)1422005338;
				switch (num2 == num)
				{
				}
				num = (short)1350303744;
				short num3 = num;
				num = (short)1335164928;
				if (num != 0)
				{
				}
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1332251995;
				short num2 = num;
				num = (short)734498139;
				switch (num2 == num)
				{
				}
				num = (short)109182977;
				if (num != 0)
				{
				}
				num = (short)1149304832;
				short num3 = num;
				num = (short)289865728;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000148 RID: 328 RVA: 0x0000B980 File Offset: 0x00009B80
		private global::Motorola.CommonCPS.Server.RMServerContract.IRMServer RMServer
		{
			get
			{
				short num = (short)898236426;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_139;
					case 1:
						num = (short)2081816587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_100;
					case 3:
						goto IL_177;
					case 4:
						goto IL_224;
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IncompatibilityHandler incompatiblityDetected = this.IncompatiblityDetected;
						if (incompatiblityDetected != null)
						{
							incompatiblityDetected(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CommunicationServerNotAvailabe);
							num = (short)779091976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1272996647;
						short num3 = num;
						num = (short)1889362727;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1BA;
						default:
							num = (short)1701969920;
							if (num != 0)
							{
							}
							num = (short)1556938756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason == global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.ServiceNotCompatibleWithClientVersion)
						{
							num = (short)142802953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1305935877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IncompatibilityHandler incompatiblityDetected2 = this.IncompatiblityDetected;
						if (incompatiblityDetected2 == null)
						{
							num = (short)1212743682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						incompatiblityDetected2(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_CLIENT_RM_VERSION_INCOMPATIBLE);
						num = (short)1417281536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_24A;
					case 9:
						goto IL_1BA;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_54;
						}
						continue;
					case 11:
						if (this.Connect(true))
						{
							num = (short)2047868931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)395378694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_54:
					if (!this.IsConnected)
					{
						num = (short)504692737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25F;
					IL_1BA:
					num = (short)1435566081;
					if (num != 0)
					{
					}
					num = (short)1662255111;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_100:
				goto IL_24F;
				IL_105:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CommunicationServerNotAvailabe, this.j);
				IL_139:
				goto IL_24F;
				IL_177:
				return this.d;
				IL_224:
				IL_24A:
				goto IL_105;
				IL_24F:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_CLIENT_RM_VERSION_INCOMPATIBLE, global::Motorola.CommonCPS.ResourceRepository.Resources.SERVER_CLIENT_VERSION_INCOMPATIBLE);
				IL_25F:
				num = (short)406519808;
				short num4 = num;
				return this.d;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000BC1C File Offset: 0x00009E1C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000BCCC File Offset: 0x00009ECC
		public global::Motorola.CommonCPS.Server.EntityModel.RMCInfo RMCInfo
		{
			get
			{
				short num = (short)922423959;
				short num2 = num;
				num = (short)2134381207;
				switch (num2 == num)
				{
				}
				num = (short)1070333953;
				if (num != 0)
				{
				}
				num = (short)353042432;
				short num3 = num;
				num = (short)484245504;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1850100021;
				short num2 = num;
				num = (short)1557023029;
				switch (num2 == num)
				{
				}
				num = (short)179372033;
				if (num != 0)
				{
				}
				num = (short)181665792;
				short num3 = num;
				num = (short)1285357568;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000BD7C File Offset: 0x00009F7C
		public global::System.Collections.Generic.IList<string> GetSystemKeyPermissions()
		{
			int a_ = 11;
			short num;
			global::System.Collections.Generic.IList<string> systemKeyPermissions;
			try
			{
				num = (short)2034723915;
				short num2 = num;
				num = (short)928738379;
				switch (num2 == num)
				{
				}
				num = (short)2128740352;
				if (num != 0)
				{
				}
				num = (short)1996161025;
				if (num != 0)
				{
				}
				systemKeyPermissions = this.RMServer.GetSystemKeyPermissions();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳솷즹좻\udbbd궿见ꇃ뿅飇꿉뻋ꏍ맏ꇑꟓ뿕럗듙꿛", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1479016448;
			short num3 = num;
			return systemKeyPermissions;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000BE7C File Offset: 0x0000A07C
		public bool Connect(bool backgroundconnection = false)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			global::System.Threading.SynchronizationContext synchronizationContext;
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_D6;
				case 1:
					goto IL_1DD;
				case 2:
					goto IL_373;
				case 3:
					goto IL_3CD;
				case 4:
					if (!backgroundconnection)
					{
						num2 = (short)363986956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1553530885;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnecting)
					{
						num2 = (short)407306241;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfLocalHost(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress))
					{
						num2 = (short)115212296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_373;
				case 7:
					goto IL_39E;
				case 8:
					num2 = (short)1943928842;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (!global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.SettingUpgraded)
					{
						num2 = (short)197459983;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_167;
				case 10:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfActiveDirectory())
					{
						num2 = (short)155910145;
						if (num2 != 0)
						{
						}
						num2 = (short)1914699778;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udaa8캪\udfac킰\udeb2킴", a_);
					num2 = (short)1684602880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udea8\udfaa怜삮\udab0횲\udbb4", a_);
					num2 = (short)390922243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)624427022;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_2F1;
				case 14:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
					{
						num2 = (short)1029570571;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1220411398;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					num2 = (short)1815289532;
					short num3 = num2;
					num2 = (short)1781604028;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DD;
					default:
					{
						num2 = (short)1714356224;
						if (num2 != 0)
						{
						}
						int serverPort = global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Upgrade();
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.SettingUpgraded = true;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort = serverPort;
						global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
						num2 = (short)296943632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 16:
					goto IL_167;
				}
				goto IL_5D;
				IL_167:
				num2 = (short)1152385028;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1DD:
				synchronizationContext = global::System.Threading.SynchronizationContext.Current;
				global::System.Threading.Tasks.Task.Run<bool>(delegate()
				{
					short num5 = (short)310538826;
					short num6 = num5;
					num5 = (short)1575383626;
					switch (num6 == num5)
					{
					}
					num5 = (short)1960181760;
					short num7 = num5;
					num5 = (short)6225921;
					if (num5 != 0)
					{
					}
					num5 = (short)1309278208;
					if (num5 != 0)
					{
					}
					return this.Connect(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType, synchronizationContext, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingUserName, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingSecurePassword, true, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingJwtToken);
				});
				num2 = (short)1717567501;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_373:
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삨얪즬삮우삲", a_);
				num2 = (short)120324103;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D6:
			num2 = (short)1107296256;
			short num4 = num2;
			IL_27E:
			return this.Connect(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType, global::System.Threading.SynchronizationContext.Current, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingUserName, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingSecurePassword, backgroundconnection, global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingJwtToken);
			IL_2F1:
			return false;
			IL_39E:
			IL_3CD:
			goto IL_27E;
			IL_5D:
			num2 = (short)694681609;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000C25C File Offset: 0x0000A45C
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object[])")]
		public bool Connect(string address, int port, string authAddress, string authMethod, global::System.Threading.SynchronizationContext synchronizationContext, string userName = "", global::System.Security.SecureString password = null, bool backgroundconnection = false, string jwtToken = null)
		{
			int a_ = 6;
			short num = (short)1523056641;
			if (num != 0)
			{
			}
			num = (short)1800339456;
			switch (num)
			{
			default:
			{
				num = (short)843710465;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					bool flag;
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							for (;;)
							{
								IL_D9:
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)1521025038;
										num2 = (int)((global::System.IntPtr)num);
										bool result;
										for (;;)
										{
											global::Motorola.Common.LogUtility.ILog logger;
											global::Motorola.CommonCPS.Server.EntityModel.ServerInfo serverInfo;
											switch (num2)
											{
											case 0:
												goto IL_72D;
											case 1:
												goto IL_792;
											case 2:
												logger.Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톜삠잢\udea6\udaa8\udfaa좬슮練횲체쒶", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf9c爵욠쪢쮤螦鎨讪삮킰ힲ캶쪸쾺\ud8bc튾諀ꛂ별듆", a_));
												this.LoadSystemKeys();
												logger.Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톜삠잢\udea6\udaa8\udfaa좬슮練횲체쒶", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud89c얠莢龤螦쒪첬쮮쪲운쎶\udcb8횺\udabe룀냂", a_));
												num = (short)617938964;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
												{
													num = (short)1254883330;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_771;
											case 4:
												this.a();
												num = (short)70320134;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_667;
											case 6:
												goto IL_265;
											case 7:
												goto IL_6BF;
											case 8:
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBMigrationInfo = new global::Motorola.CommonCPS.RadioManagement.Global.DBMigrationInfo();
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBMigrationInfo.LegacyDBVersion = serverInfo.MigrationRecord.Version;
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBMigrationInfo.CurrentProgress = (global::Motorola.CommonCPS.RadioManagement.Global.MigrationProgress)serverInfo.MigrationRecord.MigrationStatus;
												num = (short)881197063;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												this.Disconnect();
												num = (short)394985482;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
												goto IL_5A0;
											case 11:
												authMethod = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.GetDefaultAuthenticationMethod(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("Ꞟ閠鞢鞤钬芮薲蒴螶钸辺﮼諭菀ﷄﻈﳊ﷎铖黜ꗠꛢퟤ髦", a_));
												num = (short)1509490693;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 12:
												if (this.d != null)
												{
													num = (short)634257417;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5A0;
											case 13:
												if (backgroundconnection)
												{
													num = (short)200278037;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected = true;
												num = (short)1159790592;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 14:
												switch (0)
												{
												case 0:
													goto IL_1E0;
												}
												continue;
											case 15:
												if (authMethod == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud99c爵잠슢키쮦\udda8", a_))
												{
													num = (short)804978699;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_667;
											case 16:
												if (serverInfo.MigrationRecord != null)
												{
													num = (short)1032323080;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBMigrationInfo = null;
												num = (short)475398161;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 17:
												goto IL_6BF;
											case 18:
												if (authMethod == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString())
												{
													num = (short)1701969924;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_265;
											case 19:
												goto IL_72D;
											case 20:
												goto IL_771;
											case 21:
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected = true;
												num = (short)1900675091;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1E0:
											this.h = new global::Motorola.CommonCPS.Server.EntityModel.RMCInfo
											{
												ClientType = global::Motorola.CommonCPS.Server.CommonDBConstants.ClientType.RadioManagementControl,
												WorkMode = ((global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration) ? global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration : global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template),
												ClientVersion = global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.RMClientVersion,
												ClientId = this.c
											};
											this.h.productFamily = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily;
											this.h.Pac = global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier.ASTRO;
											global::Motorola.CommonCPS.RadioManagement.SharedServices.RMServerCallback rmserverCallback = new global::Motorola.CommonCPS.RadioManagement.SharedServices.RMServerCallback(synchronizationContext);
											rmserverCallback.ServerEventArrived = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler)global::System.Delegate.Combine(rmserverCallback.ServerEventArrived, new global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler(this.a));
											global::System.ServiceModel.InstanceContext context = new global::System.ServiceModel.InstanceContext(rmserverCallback);
											num = (short)1254162447;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_265:
											logger = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾜튞ﲢ슦\udba8춪슬\uddae\udcb0튲\udbb4풶\udcb8킾ꛀ꓂ꃄ뗆", a_));
											logger.Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud99c튠삢쪤톦첨\ud9aa趬ﲮ풰솲쎴\udeb6\udab8\udeba", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf9c爵욠쪢쮤螦쒪쎬솮풰킲솴趶馸ﾺ풼첾ꋀ곂도ꋆ믈", a_));
											string message = string.Format(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲜ햠쮢슦\udda8쎪슬쮮记鎲캴螶쒸鮺鶼\udebeꗀꟂ럄ꋆ뫈룊듎껒꧘듚꿜ꯞ\udbe0飢ퟤ髦짨뻪黬諮菰뷲铴髶鳸쇺蛼쳾簀", a_), new object[]
											{
												authMethod,
												address,
												port,
												userName
											});
											logger.Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ude9c쾠춢삤쒦\udda8", a_), message);
											this.e = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.CreateClientChannelEx<global::Motorola.CommonCPS.Server.RMServerContract.IRMServer>(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("Ꞟ閠鞢鞤钬芮薲蒴螶钸辺﮼諭菀ﷄﻈﳊ﷎铖黜ꗠꛢퟤ髦", a_), authMethod, context, address, port, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾜튞욢힤톦첨\ud9aa", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9c첞", a_), userName, password, false, 5, 2000, null, jwtToken);
											logger.Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud99c튠삢쪤톦첨\ud9aa趬ﲮ풰솲쎴\udeb6\udab8\udeba", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud89c얠莢좦잨얪좬첮얰覲閴킸좺\udebc킾럀ꛂ럄", a_));
											logger.Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풜춞삤햦\udfa8캪\udfac", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf9c爵욠쪢쮤螦쒪쎬솮풰킲솴趶馸鋀ꛂ럄뇆곈맊", a_));
											global::Motorola.CommonCPS.Server.RMServerContract.IRMServer irmserver = this.e.CreateChannel();
											serverInfo = irmserver.OpenSession(this.h.ClientId, this.h, true);
											this.i = new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(serverInfo.ServerVersion.RMVersion);
											logger.Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풜춞삤햦\udfa8캪\udfac", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud89c얠莢좦잨얪좬첮얰覲閴ﺶ\udabe돀뗂ꃄ뗆", a_));
											num = (short)1046216716;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_5A0:
											this.d = irmserver;
											global::System.ServiceModel.ICommunicationObject communicationObject = this.d as global::System.ServiceModel.ICommunicationObject;
											communicationObject.Closed += this.b;
											communicationObject.Faulted += this.b;
											this.IsConnected = true;
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerHostID = string.Empty;
											num = (short)976093197;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_667:
											num = (short)465633298;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_6BF:
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.DBUpgradeVersionInfo = serverInfo.DBUpgradeVersionInfo;
											num = (short)1521614851;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_72D:
											num = (short)1317273616;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_771:
											this.d();
											result = true;
											num = (short)1639448577;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_792:
										return result;
									}
									catch (global::Motorola.Common.CustomException.CommonException ex)
									{
										global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(ex, ex.Message);
										if (ex.InnerException != null)
										{
											global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex.InnerException, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
											if (ex.InnerException.InnerException != null)
											{
												global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex.InnerException.InnerException, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
											}
										}
										if (backgroundconnection)
										{
											if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.ID_TOKEN_IS_INVALID && !global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsJwtTokenRefreshing)
											{
												global::System.EventHandler invalidJwtTokenDetected = this.InvalidJwtTokenDetected;
												if (invalidJwtTokenDetected != null)
												{
													invalidJwtTokenDetected.BeginInvoke(this, null, null, null);
												}
											}
											return false;
										}
										this.CompatibilityErrorCode = ex.ErrorCode;
										if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERY_LOGIN_FAILED)
										{
											if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString())
											{
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameLoginFailed;
											}
											else if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString())
											{
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.WindowsCredentialLoginFailed;
											}
											else
											{
												if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString()))
												{
													throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펜햠莢횤튦\ud9a8\udbaa슬\uddae얰횲톴", a_));
												}
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialLoginFailed;
											}
										}
										else if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.USER_NOT_ACTIVATED)
										{
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNotActived;
										}
										else if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.ServiceNotCompatibleWithClientVersion)
										{
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.ServiceNotCompatibleWithClientVersion;
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AutoUpdate = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.GetUpgradePathInfo(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("Ꞟ閠鞢鞤钬芮薲蒴螶钸辺﮼諭菀ﷄﻈﳊ﷎铖黜ꗠꛢퟤ髦", a_), authMethod, address, port, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9c첞", a_), userName, password, false, "", jwtToken).AutoUpdate;
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.ServiceNotCompatibleWithClientVersion;
										}
										else
										{
											if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.DISCOVERYCLIENT_SETTING_IS_INCORRECT)
											{
												if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.TARGET_DISCOVERYSERVER_NOT_AVAILABLE)
												{
													if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.ConfiguredCertificateTypeNotFound)
													{
														global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.ConfiguredCertificateTypeNotFound;
														goto IL_B06;
													}
													if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.InvalidAppConfigCertificatesSection)
													{
														global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.InvalidAppConfigCertificatesSection;
														goto IL_B06;
													}
													if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.AmbiguousCertificatesFound)
													{
														global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AmbiguousCertificatesFound;
														goto IL_B06;
													}
													if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.ID_TOKEN_IS_INVALID)
													{
														global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialInvalid;
														goto IL_B06;
													}
													if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.TARGET_SERVER_NOT_AVAILABLE)
													{
														global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.CannotConnectToTargetServer;
														goto IL_B06;
													}
													if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString()))
													{
														global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameLoginFailed;
														goto IL_B06;
													}
													if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString()))
													{
														global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.WindowsCredentialLoginFailed;
														goto IL_B06;
													}
													if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString())
													{
														global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialLoginFailed;
														goto IL_B06;
													}
													throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펜햠莢횤튦\ud9a8\udbaa슬\uddae얰횲톴", a_));
												}
											}
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.CannotConnectToDiscoveryServer;
										}
										IL_B06:
										return false;
									}
									catch (global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData> faultException)
									{
										global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(faultException, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
										global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(faultException, faultException.Message);
										if (backgroundconnection)
										{
											return false;
										}
										if (faultException.Detail != null && faultException.Detail.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.DBMIGRATION_PROCESSING)
										{
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AnotherRMCDoingDBMigration;
										}
										else if (faultException.Detail != null && faultException.Detail.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.DBUPGRADE_PROCESSING)
										{
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.AnotherRMCDoingDBUpgrade;
										}
										else
										{
											global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.CannotConnectToTargetServer;
										}
										return false;
									}
									catch (global::System.Exception ex2)
									{
										global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex2, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
										global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(ex2, ex2.Message);
										if (!backgroundconnection)
										{
											num = (short)807153019;
											short num3 = num;
											num = (short)964242811;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)1167654912;
												if (num != 0)
												{
												}
												global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.CannotConnectToTargetServer;
												return false;
											}
										}
										return false;
									}
									finally
									{
										global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnecting = false;
									}
									goto IL_C44;
								case 1:
									global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected = false;
									num = (short)681574404;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_C44;
								case 3:
									if (backgroundconnection)
									{
										num = (short)145555457;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected = false;
									num = (short)751960066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_C44;
								}
								break;
								IL_C44:
								global::AutoUpdate.AutoUpdateHelper.DeleteAutoUpdateOutdatedFiles(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.OffsetHoursToDelete);
								num = (short)562102272;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F4:
							global::System.Threading.Monitor.Enter(obj, ref flag);
							this.CompatibilityErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
							global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.None;
							num = (short)1306787843;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_D9;
						}
						finally
						{
							num = (short)1678835713;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_CFB;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_CC3;
									}
									continue;
								case 2:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)1510408192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_CC3:
								if (!flag)
								{
									break;
								}
								num = (short)1167458306;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CFB:;
						}
						goto IL_CFE;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 2:
						return false;
					}
					IL_81:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnecting)
					{
						num = (short)1313865728;
						short num4 = num;
						num = (short)347865090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CFE:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnecting = true;
					obj = global::Motorola.CommonCPS.RadioManagement.SharedServices.RmServerAccessor.b;
					flag = false;
					num = (short)1485701120;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
			}
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000D014 File Offset: 0x0000B214
		public void UpdateSession()
		{
			int a_ = 10;
			this.h.ClientId = global::System.Guid.NewGuid().ToString();
			this.h.Pac = global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier.PCR;
			short num;
			try
			{
				this.d.CloseSession();
				this.d.OpenSession(this.h.ClientId, this.h, true);
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.InnerException != null)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex.InnerException, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
					if (ex.InnerException.InnerException != null)
					{
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex.InnerException.InnerException, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
					}
				}
				this.CompatibilityErrorCode = ex.ErrorCode;
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_TARGET_SERVER && ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.CANNOT_CONNECT_TO_DISCOVERYSERVER)
				{
					if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.TARGET_SERVER_NOT_AVAILABLE)
					{
						num = (short)888936481;
						short num2 = num;
						num = (short)2035488801;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1224212480;
							if (num != 0)
							{
							}
							if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.USER_NOT_ACTIVATED)
							{
								global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNotActived;
								goto IL_2A2;
							}
							if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString()))
							{
								global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameLoginFailed;
								goto IL_2A2;
							}
							if (!global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString()))
							{
								if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString())
								{
									global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialLoginFailed;
									goto IL_2A2;
								}
								throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첢톤螦\udaa8\udeaa\uddac\udfae\udeb0솲솴튶\uddb8", a_));
							}
							break;
						}
						global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.WindowsCredentialLoginFailed;
						goto IL_2A2;
					}
				}
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString())
				{
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.UserNameLoginFailed;
				}
				else if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString())
				{
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.WindowsCredentialLoginFailed;
				}
				else
				{
					if (!(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString()))
					{
						throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첢톤螦\udaa8\udeaa\uddac\udfae\udeb0솲솴튶\uddb8", a_));
					}
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.JwtTokenCredentialLoginFailed;
				}
				IL_2A2:;
			}
			catch (global::System.ServiceModel.FaultException ex2)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex2, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.CannotConnectToTargetServer;
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).WriteEventEntry(ex3, global::Motorola.Common.LogUtility.LoggingLevel.EventError);
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionFailureReason = global::Motorola.CommonCPS.RadioManagement.Global.ConnectionFailureReasonID.CannotConnectToTargetServer;
			}
			finally
			{
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnecting = false;
			}
			num = (short)1772093441;
			if (num != 0)
			{
			}
			num = (short)16646144;
			short num3 = num;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000D3B8 File Offset: 0x0000B5B8
		public void LoadSystemKeys()
		{
			short num = (short)1527119872;
			short num2 = num;
			num = (short)442107817;
			short num3 = num;
			num = (short)1491994537;
			switch (num3 == num)
			{
			}
			num = (short)1905721345;
			if (num != 0)
			{
			}
			num = (short)1853947904;
			if (num != 0)
			{
			}
			this.c();
			this.b();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000D46C File Offset: 0x0000B66C
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.Common.CustomException.CommonErrorCode> UpdateLanguagePackOnRadios(global::System.Collections.Generic.List<global::System.Guid> radioUuids)
		{
			short num = (short)1048707072;
			short num2 = num;
			num = (short)507919436;
			short num3 = num;
			num = (short)1893547084;
			switch (num3 == num)
			{
			}
			num = (short)1380712449;
			if (num != 0)
			{
			}
			num = (short)2111700992;
			if (num != 0)
			{
			}
			return this.d.UpdateLanguagePackOnRadios(radioUuids);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000D520 File Offset: 0x0000B720
		public int ChangePassword(string oldPassword, string newPassword, string currentUserType, string authType, string discoveryHost, int discoveryPort, string svcType, string userName = null, global::System.Security.SecureString pswd = null, bool activating = false)
		{
			int a_ = 13;
			int result;
			short num;
			for (;;)
			{
				result = -1;
				global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement irmserviceManagement = null;
				try
				{
					this.f = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.CreateClientChannelEx2<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement>(currentUserType, authType, discoveryHost, discoveryPort, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎩\udfab춭\udfaf쒱톳쒵솷\ud9bb첽뚿ꟁ뛃", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲧ", a_), userName, pswd, activating, 5, 2000, "", "");
					irmserviceManagement = this.f.CreateChannel();
					goto IL_26;
				}
				catch
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ChangeRMUserPassword_ConnectionToDiscoveryFailed);
				}
				goto IL_87;
				for (;;)
				{
					IL_26:
					try
					{
						result = irmserviceManagement.ChangePassword(oldPassword, newPassword);
						break;
					}
					catch
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ChangeRMUserPassword_ChangePasswordFailed);
					}
				}
				IL_87:
				num = (short)794497225;
				short num2 = num;
				num = (short)436474057;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_BC;
				}
			}
			IL_BC:
			num = (short)1806499841;
			if (num != 0)
			{
			}
			num = (short)1991376896;
			short num3 = num;
			num = (short)1985282048;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000D66C File Offset: 0x0000B86C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.SystemKeyOperationResult> UploadSystemKeys(global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> syskeyPermissions, string currentUserType, string authType, string discoveryHost, int discoveryPort, string svcType, string pac, string userName = null, global::System.Security.SecureString pswd = null, string jwtToken = null)
		{
			int a_ = 18;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.SystemKeyOperationResult> result;
			try
			{
				num = (short)1670578177;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_121;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 2:
						try
						{
							this.g = this.a(currentUserType, authType, discoveryHost, discoveryPort, svcType, pac, userName, pswd, false, jwtToken);
							global::System.ServiceModel.ICommunicationObject communicationObject = this.g as global::System.ServiceModel.ICommunicationObject;
							communicationObject.Closed += this.a;
							communicationObject.Faulted += this.a;
						}
						catch
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Create_DiscoveryChannel_Failed);
						}
						goto IL_B0;
					}
					goto IL_39;
					IL_41:
					num = (short)853999618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B0:
					num = (short)738739962;
					short num3 = num;
					num = (short)80365306;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_41;
					default:
						num = (short)1572339712;
						if (num != 0)
						{
						}
						result = this.g.UpLoadSystemKeys(syskeyPermissions);
						num = (short)1206517760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_39:
					if (this.g == null)
					{
						goto IL_41;
					}
					goto IL_B0;
				}
				IL_121:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴즸ힺ튼\udebeꗀ郂별듆뷈껊ꃌ蓎듐꫒ꛔ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)144179201;
			if (num != 0)
			{
			}
			num = (short)2027159552;
			short num4 = num;
			return result;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000D850 File Offset: 0x0000BA50
		private void a(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventInfo A_0)
		{
			short num = (short)1649278977;
			if (num != 0)
			{
			}
			num = (short)2081106884;
			short num2 = num;
			num = (short)383265732;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1914175488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1380057088;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler serverEventArrived = this.ServerEventArrived;
			if (serverEventArrived == null)
			{
				return;
			}
			serverEventArrived(A_0);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000D90C File Offset: 0x0000BB0C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel GetDatabaseSpaceStatus()
		{
			int a_ = 14;
			short num;
			global::Motorola.CommonCPS.Server.CommonDBConstants.DatabaseSpaceLevel databaseSpaceLevel;
			try
			{
				num = (short)1688316345;
				short num2 = num;
				num = (short)1808771513;
				switch (num2 == num)
				{
				}
				num = (short)556728320;
				if (num != 0)
				{
				}
				databaseSpaceLevel = this.d.GetDatabaseSpaceLevel();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶ﶸ\udaba즼\udebeꏀꋂ뛄ꋆ髈믊곌곎듐胒ꇔ뛖귘껚껜", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1446248448;
			short num3 = num;
			num = (short)2142437377;
			if (num != 0)
			{
			}
			return databaseSpaceLevel;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000DA0C File Offset: 0x0000BC0C
		public void CheckCompatibility()
		{
			int a_ = 2;
			short num;
			try
			{
				num = (short)1401287359;
				short num2 = num;
				num = (short)1986589375;
				switch (num2 == num)
				{
				}
				num = (short)831913984;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.ClientInfo clientInfo = new global::Motorola.CommonCPS.Server.EntityModel.ClientInfo();
				clientInfo.ClientType = global::Motorola.CommonCPS.Server.CommonDBConstants.ClientType.RadioManagementControl;
				clientInfo.ClientVersion = global::Motorola.CommonCPS.RadioManagement.CommonBase.Global.RMClientVersion;
				clientInfo.ClientId = global::System.Environment.MachineName;
				clientInfo.Pac = global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier.ASTRO;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤솨캪캬쒮\udcb2\ud8b4잶\ud8b8쾺풼\uddbeꣀ꿂계돆냈", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1518272512;
			short num3 = num;
			num = (short)1509490689;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000DB28 File Offset: 0x0000BD28
		public global::Motorola.CommonCPS.Server.EntityModel.BLVersion GetServerVersion()
		{
			int a_ = 11;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.BLVersion result;
			try
			{
				num = (short)1615945800;
				short num2 = num;
				num = (short)552034376;
				switch (num2 == num)
				{
				}
				num = (short)1931149312;
				if (num != 0)
				{
				}
				result = this.i;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳\uddb7좹쪻\udbbd늿铁ꇃ듅믇ꏉꏋꃍ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)916848640;
			short num3 = num;
			num = (short)3997697;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0000DC20 File Offset: 0x0000BE20
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		public global::System.EventHandler ServerConnectedEventHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1358395320;
				short num2 = num;
				num = (short)1624471480;
				switch (num2 == num)
				{
				}
				num = (short)1271136256;
				short num3 = num;
				num = (short)1592197121;
				if (num != 0)
				{
				}
				num = (short)1806434304;
				if (num != 0)
				{
				}
				return this.q;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1605387175;
				short num2 = num;
				num = (short)435110823;
				switch (num2 == num)
				{
				}
				num = (short)8978432;
				short num3 = num;
				num = (short)902889472;
				if (num != 0)
				{
				}
				num = (short)559349761;
				if (num != 0)
				{
				}
				this.q = value;
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000DD84 File Offset: 0x0000BF84
		private void d()
		{
			short num = (short)251748363;
			short num2 = num;
			num = (short)1337810955;
			switch (num2 == num)
			{
			}
			num = (short)1846214656;
			short num3 = num;
			num = (short)2131230721;
			if (num != 0)
			{
			}
			num = (short)889716736;
			if (num != 0)
			{
			}
			global::System.EventHandler serverConnectedEventHandler = this.ServerConnectedEventHandler;
			if (serverConnectedEventHandler == null)
			{
				return;
			}
			serverConnectedEventHandler(this, null);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000DE44 File Offset: 0x0000C044
		public void Disconnect()
		{
			short num2;
			try
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_20;
					}
					int num;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_121;
						case 1:
						{
							num2 = (short)567800699;
							short num3 = num2;
							num2 = (short)1042609019;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)2004942848;
								if (num2 != 0)
								{
								}
								this.d.CloseSession();
								(this.d as global::System.ServiceModel.ICommunicationObject).Abort();
								num2 = (short)1436090371;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 2:
							if (this.d != null)
							{
								num2 = (short)842006529;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_109;
						case 3:
							goto IL_109;
						}
						break;
						IL_109:
						num2 = (short)217251840;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_20:
					num2 = (short)765329409;
					if (num2 != 0)
					{
					}
					this.IsConnected = false;
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected = false;
					num2 = (short)1820327938;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_121:;
			}
			catch
			{
			}
			num2 = (short)1694171136;
			short num4 = num2;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000DFC0 File Offset: 0x0000C1C0
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetRadioSummaries(int startIndex, int length, global::System.Guid? groupId, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode)
		{
			int a_ = 9;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> result;
			try
			{
				num = (short)32988158;
				short num2 = num;
				num = (short)1556241406;
				switch (num2 == num)
				{
				}
				num = (short)411369472;
				if (num != 0)
				{
				}
				result = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.DeserializeAndUnzip<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>>(this.d.ListRadioSummary(startIndex, length, groupId, workMode, false));
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫햯욱ힵ\udcb7펹펻떿꿁꧃Ʂ뫇ꏉ꧋뷍", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)630194176;
			short num3 = num;
			num = (short)1762590721;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000E0CC File Offset: 0x0000C2CC
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListRadioSummaryByIds(global::System.Collections.Generic.List<global::System.Guid> radioSummaryIds)
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> result;
			try
			{
				num = (short)1220310696;
				short num2 = num;
				num = (short)883193512;
				switch (num2 == num)
				{
				}
				num = (short)1991376896;
				if (num != 0)
				{
				}
				result = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.DeserializeAndUnzip<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>>(this.RMServer.ListRadioSummaryByIds(radioSummaryIds));
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱\udfb5쮷캹\udfbd꒿ꯁꯃ闅뷇Ꟊꇋ꿍ꋏꯑ雓꿕釗뻙꿛", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)101974016;
			short num3 = num;
			num = (short)1897201665;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary GetRadioSummary(global::System.Guid radioId)
		{
			int a_ = 4;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSumary;
			try
			{
				num = (short)1813647737;
				short num2 = num;
				num = (short)1436553593;
				switch (num2 == num)
				{
				}
				num = (short)1262092288;
				if (num != 0)
				{
				}
				radioSumary = this.RMServer.GetRadioSumary(radioId);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9acﶮ킰ힲ\udcb4\ud8b6캺킼튾ꃀ뇂별", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1406468096;
			short num3 = num;
			num = (short)1391525889;
			if (num != 0)
			{
			}
			return radioSumary;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioByDeviceUuid(global::System.Guid radioID, bool deepLoad = true)
		{
			int a_ = 8;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Radio result;
			try
			{
				num = (short)413215466;
				short num2 = num;
				num = (short)1248013034;
				switch (num2 == num)
				{
				}
				num = (short)540082176;
				if (num != 0)
				{
				}
				num = (short)132775937;
				if (num != 0)
				{
				}
				result = this.RMServer.GetRadioList(new global::System.Collections.Generic.List<global::System.Guid>
				{
					radioID
				}, deepLoad).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.Radio>();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰풴펶킸풺ﾼ욾藀ꛂ도껆꫈껊飌뫎룐럒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)973078528;
			short num3 = num;
			return result;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioByDeviceID(string deviceID, bool isDeep = false)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radioByDeviceId;
			try
			{
				num = (short)136639544;
				short num2 = num;
				num = (short)1286599736;
				switch (num2 == num)
				{
				}
				num = (short)238616577;
				if (num != 0)
				{
				}
				num = (short)1168244736;
				if (num != 0)
				{
				}
				radioByDeviceId = this.RMServer.GetRadioByDeviceId(deviceID, isDeep);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯햳튵톷햹ﺻ잽鎿ꟁ뛃꿅꧇ꛉ苋믍뷏냑뇓ꓕ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)917438464;
			short num3 = num;
			return radioByDeviceId;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		public int GetRadioCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode, bool includeSubGroups)
		{
			int a_ = 19;
			short num;
			int radioCount;
			try
			{
				num = (short)1518148782;
				short num2 = num;
				num = (short)1185946798;
				switch (num2 == num)
				{
				}
				num = (short)1519255552;
				if (num != 0)
				{
				}
				radioCount = this.RMServer.GetRadioCount(groupUuid, workMode, includeSubGroups);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻ꆿꛁ귃꧅诇ꗉ맋ꃍ꓏", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2099052544;
			short num3 = num;
			num = (short)1976303617;
			if (num != 0)
			{
			}
			return radioCount;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetRadioListUsingConfig(global::System.Guid configUuid, int startIndex, int count)
		{
			int a_ = 3;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> radioListUsingConfig;
			try
			{
				num = (short)975645476;
				short num2 = num;
				num = (short)809904932;
				switch (num2 == num)
				{
				}
				num = (short)1028194304;
				if (num != 0)
				{
				}
				radioListUsingConfig = this.RMServer.GetRadioListUsingConfig(configUuid, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쾩\ud8abﲭ톯횱\uddb3\ud9b5펹쾻쪽閿뇁귃ꣅ꿇觉ꏋꃍ뛏믑돓", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1384972288;
			short num3 = num;
			num = (short)1851719681;
			if (num != 0)
			{
			}
			return radioListUsingConfig;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000E6DC File Offset: 0x0000C8DC
		public int GetRadiosCountUsingConfig(global::System.Guid configUuid)
		{
			int a_ = 12;
			short num;
			int radiosCountUsingConfig;
			try
			{
				num = (short)1716634348;
				short num2 = num;
				num = (short)1919140588;
				switch (num2 == num)
				{
				}
				num = (short)1904803840;
				if (num != 0)
				{
				}
				radiosCountUsingConfig = this.RMServer.GetRadiosCountUsingConfig(configUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴\ud8b8\udfba풼킾닀胂꫄닆ꟈ뿊飌볎룐뷒닔铖뛘뗚믜뛞蛠", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)131661824;
			short num3 = num;
			num = (short)1381761025;
			if (num != 0)
			{
			}
			return radiosCountUsingConfig;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetRadioListUsingConfigWithWorkingCodeplug(global::System.Guid configUuid, int startIndex, int count)
		{
			int a_ = 19;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> radioListUsingConfigByWrkCp;
			try
			{
				num = (short)452676633;
				short num2 = num;
				num = (short)11160601;
				switch (num2 == num)
				{
				}
				num = (short)835780608;
				if (num != 0)
				{
				}
				radioListUsingConfigByWrkCp = this.RMServer.GetRadioListUsingConfigByWrkCp(configUuid, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻ꆿꛁ귃꧅蓇ꏉ뿋뫍藏ꇑ뷓룕뿗駙돛냝蛟诡菣", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1704394752;
			short num3 = num;
			num = (short)1744175105;
			if (num != 0)
			{
			}
			return radioListUsingConfigByWrkCp;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		public int GetRadiosCountUsingConfigWithWorkingCodeplug(global::System.Guid configUuid)
		{
			int a_ = 5;
			short num;
			int radiosCountUsingConfigByWrkCp;
			try
			{
				num = (short)53799589;
				short num2 = num;
				num = (short)2073750181;
				switch (num2 == num)
				{
				}
				num = (short)1429536768;
				if (num != 0)
				{
				}
				radiosCountUsingConfigByWrkCp = this.RMServer.GetRadiosCountUsingConfigByWrkCp(configUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad펱킳\udfb5ힷ즹ﾻ톽떿곁냃鏅믇ꏉꋋ꧍鏏뷑뫓냕뇗뷙", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1228931072;
			short num3 = num;
			num = (short)1683554305;
			if (num != 0)
			{
			}
			return radiosCountUsingConfigByWrkCp;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000E9D8 File Offset: 0x0000CBD8
		public bool IsFirmwareVersionModified(global::System.Collections.Generic.List<string> radioSerialNumbers)
		{
			int a_ = 6;
			short num;
			bool result;
			try
			{
				num = (short)266151617;
				short num2 = num;
				num = (short)914499265;
				switch (num2 == num)
				{
				}
				num = (short)1377107968;
				if (num != 0)
				{
				}
				num = (short)1532297217;
				if (num != 0)
				{
				}
				result = this.RMServer.IsFirmwareVersionModified(radioSerialNumbers);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨\udeac\ud8b0솲\ud8b4삶\ud8b8즺\ud8bc꓀뇂뛄껆ꛈꗊ背ꃎ뗐뫒돔뻖볘뿚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Generic_Error);
			}
			num = (short)1487863808;
			short num3 = num;
			return result;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Group> GetGroups()
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Group> result;
			try
			{
				num = (short)1051722623;
				short num2 = num;
				num = (short)557843327;
				switch (num2 == num)
				{
				}
				num = (short)597622784;
				if (num != 0)
				{
				}
				result = this.RMServer.ListGroups();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵첷ﶹ캻톽떿닁럃", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)340000768;
			short num3 = num;
			num = (short)1145765889;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
		public global::Motorola.CommonCPS.Server.EntityModel.Group AddGroup(global::System.Guid? parentGroupUuid = null)
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Group result;
			try
			{
				num = (short)1897775699;
				short num2 = num;
				num = (short)1194443347;
				switch (num2 == num)
				{
				}
				num = (short)1993015297;
				if (num != 0)
				{
				}
				num = (short)80150528;
				if (num != 0)
				{
				}
				result = this.RMServer.AddGroup(parentGroupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫풯횱쒵ힷ쾹첻", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)378404864;
			short num3 = num;
			return result;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000ECD0 File Offset: 0x0000CED0
		public void DeleteGroup(global::System.Guid groupUuid)
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)1988562479;
				short num2 = num;
				num = (short)1370689071;
				switch (num2 == num)
				{
				}
				num = (short)1015939072;
				if (num != 0)
				{
				}
				this.RMServer.DeleteGroup(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭\udcafힱ삳펵ﾷ좹펻쮽낿", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1906114560;
			short num3 = num;
			num = (short)1435435009;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000EDD0 File Offset: 0x0000CFD0
		public byte[] UpdateGroup(global::Motorola.CommonCPS.Server.EntityModel.Group group)
		{
			int a_ = 18;
			short num;
			byte[] result;
			try
			{
				num = (short)175657914;
				short num2 = num;
				num = (short)1911051194;
				switch (num2 == num)
				{
				}
				num = (short)1142620160;
				if (num != 0)
				{
				}
				result = this.RMServer.UpdateGroup(group);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴즸\udfba\udcbc쮾꓀蓂럄꣆볈믊", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)725352448;
			short num3 = num;
			num = (short)1585381377;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000EED0 File Offset: 0x0000D0D0
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDeviceFromGroup(global::System.Guid? groupUuidTo, global::System.Guid deviceUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)616220206;
				short num2 = num;
				num = (short)390645294;
				switch (num2 == num)
				{
				}
				num = (short)1242955776;
				if (num != 0)
				{
				}
				result = this.RMServer.MoveDevice(groupUuidTo, deviceUuid, entitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴襁횸춺\ud8bc﮾꓀뗂계꓆곈跊뿌ꃎ볐铒꟔룖곘ꯚ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1570832384;
			short num3 = num;
			num = (short)714866689;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary MoveDevicesBatchOp(global::System.Guid batchJobContainerUuid, global::System.Guid? groupUuidTo, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet)
		{
			int a_ = 10;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)97685402;
				short num2 = num;
				num = (short)1824952218;
				switch (num2 == num)
				{
				}
				num = (short)31916032;
				if (num != 0)
				{
				}
				result = this.RMServer.MoveDevicesBatchOp(batchJobContainerUuid, groupUuidTo, radioUuid, entitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬\udeb0얲킴\udcb8춺풼\udcbe꓀藂럄꣆꓈賊뿌ꃎꓐꏒ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)565968896;
			short num3 = num;
			num = (short)484442113;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		public int GetQueryCount(global::System.Guid? querygGroupUuid)
		{
			int a_ = 13;
			short num;
			int queryCount;
			try
			{
				num = (short)1007198717;
				short num2 = num;
				num = (short)762290685;
				switch (num2 == num)
				{
				}
				num = (short)658112512;
				if (num != 0)
				{
				}
				queryCount = this.RMServer.GetQueryCount(querygGroupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯톳습쾹\ud9bb첽릿臁ꯃ독ꛇ뻉", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2146959360;
			short num3 = num;
			num = (short)1609629697;
			if (num != 0)
			{
			}
			return queryCount;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.QuerySummary> GetQuerySummaries(int startIndex, int length, global::System.Guid? queryGroupId)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.QuerySummary> querySummaries;
			try
			{
				num = (short)295514532;
				short num2 = num;
				num = (short)1279734180;
				switch (num2 == num)
				{
				}
				num = (short)1019936769;
				if (num != 0)
				{
				}
				num = (short)2050555904;
				if (num != 0)
				{
				}
				querySummaries = this.RMServer.GetQuerySummaries(startIndex, length, queryGroupId);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad잱톳쒵솷즻펽궿ꏁ뛃꿅귇막", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)994246656;
			short num3 = num;
			return querySummaries;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		public bool DeleteQueryBatchOp(global::System.Guid batchJobContainerId, global::System.Guid queryUuid, string jobName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			short num = (short)510158285;
			short num2 = num;
			num = (short)939419085;
			switch (num2 == num)
			{
			}
			num = (short)1229389824;
			short num3 = num;
			num = (short)1637744640;
			if (num != 0)
			{
			}
			num = (short)1902247937;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter.DeleteQueryBatchJobParameter deleteQueryBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter.DeleteQueryBatchJobParameter(batchJobContainerId);
			deleteQueryBatchJobParameter.queryId = queryUuid;
			deleteQueryBatchJobParameter.EntitySet = set;
			deleteQueryBatchJobParameter.JobDescription = jobName;
			return this.RMServer.DeleteDataMiningQueryBatchOp(deleteQueryBatchJobParameter);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000F3A0 File Offset: 0x0000D5A0
		public global::Motorola.CommonCPS.Server.EntityModel.QuerySummary MoveQuerysBatchOp(global::System.Guid batchJobContainerUuid, global::System.Guid? queryGroupUuidTo, global::System.Guid queryUuid, string jobName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.QuerySummary result;
			try
			{
				num = (short)2128068654;
				short num2 = num;
				num = (short)2114895918;
				switch (num2 == num)
				{
				}
				num = (short)1861943296;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter.MoveQuerysBatchJobParameter moveQuerysBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.BatchOperationJobParameter.MoveQuerysBatchJobParameter(batchJobContainerUuid);
				moveQuerysBatchJobParameter.QueryGroupUuidTo = queryGroupUuidTo;
				moveQuerysBatchJobParameter.QueryUuid = queryUuid;
				moveQuerysBatchJobParameter.EntitySet = entitySet;
				moveQuerysBatchJobParameter.JobDescription = jobName;
				result = this.RMServer.MoveQuerysBatchOp(moveQuerysBatchJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢좦\udfa8캪ﲬ\udaae풰솲체쒶﮸\udaba즼\udcbe꧀賂뗄", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1216610304;
			short num3 = num;
			num = (short)2118451201;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000F4C4 File Offset: 0x0000D6C4
		public global::Motorola.CommonCPS.Server.EntityModel.QuerySummary MoveQueryFromGroup(global::System.Guid? groupUuidTo, global::System.Guid queryUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet)
		{
			int a_ = 14;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.QuerySummary result;
			try
			{
				num = (short)814623668;
				short num2 = num;
				num = (short)1416178612;
				switch (num2 == num)
				{
				}
				num = (short)2081554432;
				if (num != 0)
				{
				}
				result = this.RMServer.MoveDataminingQuery(queryUuid, groupUuidTo, entitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记ﺲ\udab4솶\udcb8좼\udabe돀뫂菄뗆ꛈꛊ諌뷎뻐ꛒꗔ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)746127360;
			short num3 = num;
			num = (short)1593966593;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		public global::Motorola.CommonCPS.Server.EntityModel.QuerySummary AddQuery(global::Motorola.CommonCPS.Server.EntityModel.QuerySummary queryRawData, global::Motorola.CommonCPS.Server.EntityModel.QueryNode queryConditionRawData, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.QuerySummary result;
			try
			{
				num = (short)1953870831;
				short num2 = num;
				num = (short)954905583;
				switch (num2 == num)
				{
				}
				num = (short)254672897;
				if (num != 0)
				{
				}
				num = (short)1532559360;
				if (num != 0)
				{
				}
				byte[] queryNodeData = queryConditionRawData.Serialize();
				queryRawData.QueryNodeData = queryNodeData;
				result = this.RMServer.AddDataMiningQuery(queryRawData);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢욦\udfa8캪ﲬ\udaae풰솲체", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1661599744;
			short num3 = num;
			return result;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
		public bool IsQueryNameDuplicate(string querySummaryName)
		{
			short num = (short)1303921396;
			short num2 = num;
			num = (short)1208369908;
			switch (num2 == num)
			{
			}
			num = (short)1129119744;
			short num3 = num;
			num = (short)1303969792;
			if (num != 0)
			{
			}
			num = (short)446955521;
			if (num != 0)
			{
			}
			return this.RMServer.IsDataMiningNameDuplicate(querySummaryName, null);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000F78C File Offset: 0x0000D98C
		public global::Motorola.CommonCPS.Server.EntityModel.QuerySummary EditQuery(global::System.Guid queryID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DatamingQuerySummaryFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet)
		{
			int a_ = 8;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.QuerySummary result;
			try
			{
				num = (short)397152762;
				short num2 = num;
				num = (short)1991709178;
				switch (num2 == num)
				{
				}
				num = (short)611778560;
				if (num != 0)
				{
				}
				result = this.RMServer.EditDataMiningQuery(queryID, fieldValues, entitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쮮\ud8b0잲슶\udcb8즺쒼", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1126563840;
			short num3 = num;
			num = (short)566099969;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000F88C File Offset: 0x0000DA8C
		public string GenerateDefaultQueryName()
		{
			int a_ = 8;
			short num;
			string result;
			try
			{
				num = (short)421003264;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<string>>> list;
					switch (0)
					{
					case 0:
						break;
					default:
						for (;;)
						{
							IL_30:
							switch (num2)
							{
							case 0:
								if (list.Count > 0)
								{
									num = (short)1302986757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_170;
							case 1:
								goto IL_18E;
							case 2:
								num = (short)1310588928;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_129;
							case 4:
								if (list != null)
								{
									num = (short)796917762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_170;
							case 5:
							{
								num = (short)551835454;
								short num3 = num;
								num = (short)1749374782;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_78;
								default:
									num = (short)314179584;
									if (num != 0)
									{
									}
									result = list[0].Value.ToList<string>().First<string>();
									num = (short)471859203;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							goto IL_4F;
							IL_170:
							result = string.Empty;
							num = (short)1606746113;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_129:
						IL_18E:
						goto IL_1C0;
					}
					IL_4F:
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<string, int>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.KeyValuePair<string, int>>();
					dictionary.Add(global::Motorola.CommonCPS.ResourceRepository.Resources.QueryDefaultPrefix, new global::System.Collections.Generic.KeyValuePair<string, int>(global::Motorola.CommonCPS.ResourceRepository.Resources.QueryDefaultPrefix, 1));
					list = this.RMServer.GenerateDefaultEntityName(dictionary);
					IL_78:
					num = (short)583794692;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮\udfb0횲잴횶춸\udeba寮\udabeꟀꋂ냄ꯆ뷈髊료꫎ꏐ꫒鯔뛖듘뻚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			IL_1C0:
			num = (short)1296695296;
			short num4 = num;
			num = (short)2015952897;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		public global::Motorola.CommonCPS.Server.EntityModel.QueryNode GetQueryNode(global::System.Guid? queryId, out global::Motorola.CommonCPS.Server.EntityModel.QuerySummary outSummary)
		{
			int a_ = 0;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.QueryNode result;
			try
			{
				int num;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_13:
						switch (num)
						{
						case 0:
							goto IL_FD;
						case 1:
						{
							num2 = (short)2003944925;
							short num3 = num2;
							num2 = (short)1031849437;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3D;
							default:
								num2 = (short)595984384;
								if (num2 != 0)
								{
								}
								if (outSummary != null)
								{
									num2 = (short)80805890;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								result = null;
								num2 = (short)468254720;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 2:
							result = global::Motorola.CommonCPS.Server.EntityModel.QueryNodeExtentions.Deserialize(outSummary.QueryNodeData);
							num2 = (short)677380099;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 3:
							goto IL_E0;
						}
						goto IL_29;
					}
					IL_E0:
					IL_FD:
					goto IL_12C;
				}
				IL_29:
				outSummary = this.RMServer.GetDataMiningQuery(queryId.Value);
				IL_3D:
				num2 = (short)1995571201;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢슦\udda8着\ud8ac쪮쎰쪲﮴\ud8b6\uddb8\udeba", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			IL_12C:
			num2 = (short)648151040;
			short num4 = num2;
			num2 = (short)1869873153;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000FC60 File Offset: 0x0000DE60
		public global::System.Collections.Generic.List<global::System.Guid> QueryConfigurations(global::Motorola.CommonCPS.Server.EntityModel.QuerySummary query, global::Motorola.CommonCPS.Server.EntityModel.QueryNode node)
		{
			int a_ = 8;
			short num;
			global::System.Collections.Generic.List<global::System.Guid> result;
			try
			{
				num = (short)339804161;
				if (num != 0)
				{
				}
				num = (short)1864129740;
				short num2 = num;
				num = (short)343301324;
				switch (num2 == num)
				{
				}
				num = (short)813629440;
				if (num != 0)
				{
				}
				byte[] queryNodeData = node.Serialize();
				query.QueryNodeData = queryNodeData;
				result = this.RMServer.DataMiningQuery(query);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪ﲬ\udaae풰솲체횸햺\udbbc횾ꛀ뛂럄ꛆ뷈ꋊꋌꇎꋐ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)646774784;
			short num3 = num;
			return result;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.QueryGroup> GetQueryGroups()
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.QueryGroup> result;
			try
			{
				num = (short)997326849;
				if (num != 0)
				{
				}
				num = (short)1839959142;
				short num2 = num;
				num = (short)1433832550;
				switch (num2 == num)
				{
				}
				num = (short)1912471552;
				if (num != 0)
				{
				}
				result = this.RMServer.ListQueryGroups();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲튶춸좼\udabe돀뫂苄뗆ꛈ뻊뷌볎", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)537526272;
			short num3 = num;
			return result;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000FE6C File Offset: 0x0000E06C
		public global::Motorola.CommonCPS.Server.EntityModel.QueryGroup AddQueryGroup()
		{
			int a_ = 12;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.QueryGroup result;
			try
			{
				num = (short)1588867408;
				short num2 = num;
				num = (short)707408208;
				switch (num2 == num)
				{
				}
				num = (short)1131085824;
				if (num != 0)
				{
				}
				result = this.RMServer.AddQueryGroup();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮ힲ톴욶첸\udeba쾼욾蛀뇂꫄닆마", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)557842432;
			short num3 = num;
			num = (short)1503199233;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000FF6C File Offset: 0x0000E16C
		public global::Motorola.CommonCPS.Server.EntityModel.QueryGroup GetQueryGroup(global::System.Guid queryGroupUuid)
		{
			int a_ = 4;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.QueryGroup queryGroup;
			try
			{
				num = (short)1323308640;
				short num2 = num;
				num = (short)1751193184;
				switch (num2 == num)
				{
				}
				num = (short)636747777;
				if (num != 0)
				{
				}
				num = (short)1769865216;
				if (num != 0)
				{
				}
				queryGroup = this.RMServer.GetQueryGroup(queryGroupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9acﺮ쒰횲잴캶ﺸ즺튼쪾뇀", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)327876608;
			short num3 = num;
			return queryGroup;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001006C File Offset: 0x0000E26C
		public void DeleteQueryGroup(global::Motorola.CommonCPS.Server.EntityModel.QueryGroup queryGroup)
		{
			int a_ = 18;
			short num;
			try
			{
				num = (short)520001577;
				short num2 = num;
				num = (short)936941609;
				switch (num2 == num)
				{
				}
				num = (short)683147264;
				if (num != 0)
				{
				}
				this.RMServer.DeleteQueryGroup(queryGroup, true);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\udcb8ힺ\ud8bc쮾꓀鋂냄ꋆ믈닊諌뷎뻐ꛒꗔ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)269221888;
			short num3 = num;
			num = (short)157220865;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0001016C File Offset: 0x0000E36C
		public global::Motorola.CommonCPS.Server.EntityModel.QueryGroup UpdateQueryGroup(global::Motorola.CommonCPS.Server.EntityModel.QueryGroup queryGroup)
		{
			int a_ = 1;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.QueryGroup result;
			try
			{
				num = (short)1599833744;
				short num2 = num;
				num = (short)1894024848;
				switch (num2 == num)
				{
				}
				num = (short)2102001664;
				if (num != 0)
				{
				}
				result = this.RMServer.UpdateQueryGroup(queryGroup);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣\ud8a7캩춫\udaad햯솳펵쪷쎹﮻첽꾿럁듃", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)205520896;
			short num3 = num;
			num = (short)1533870081;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00010270 File Offset: 0x0000E470
		public int GetAllDataProfilesCount(global::System.Guid? groupUuid)
		{
			int a_ = 6;
			short num;
			int apxdataProfilesCount;
			try
			{
				num = (short)2114677044;
				short num2 = num;
				num = (short)665807156;
				switch (num2 == num)
				{
				}
				num = (short)833290240;
				if (num != 0)
				{
				}
				apxdataProfilesCount = this.RMServer.GetAPXDataProfilesCount(groupUuid, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbae\udfb2\ud9b4\ud8b8쾺\udcbc돀곂ꏄ껆ꗈ껊뻌賎뻐ꛒ믔ꏖ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1064173568;
			short num3 = num;
			num = (short)2123890689;
			if (num != 0)
			{
			}
			return apxdataProfilesCount;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00010370 File Offset: 0x0000E570
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> GetASTRODataProfiles(global::System.Guid? groupUUID, int startIndex, int count)
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> result;
			try
			{
				num = (short)868137052;
				short num2 = num;
				num = (short)809810012;
				switch (num2 == num)
				{
				}
				num = (short)222822400;
				if (num != 0)
				{
				}
				result = this.RMServer.ListAPXDataProfiles(groupUUID, startIndex, count, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴藀ꋂ뇄ꛆ駈맊ꋌ꧎룐뿒냔ꓖ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1301282816;
			short num3 = num;
			num = (short)1449459713;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00010474 File Offset: 0x0000E674
		public int GetRadioCountByProfile(global::System.Guid? groupUuid, string profileName, int systemType)
		{
			int a_ = 10;
			short num;
			int radioCountByProfile;
			try
			{
				num = (short)1376851634;
				short num2 = num;
				num = (short)266475186;
				switch (num2 == num)
				{
				}
				num = (short)1699020800;
				if (num != 0)
				{
				}
				radioCountByProfile = this.RMServer.GetRadioCountByProfile(groupUuid, profileName, systemType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲횶\uddb8튺튼ﲾ껀뛂ꯄ돆诈닊鷌뷎뻐뗒볔믖볘", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1168769024;
			short num3 = num;
			num = (short)1673658369;
			if (num != 0)
			{
			}
			return radioCountByProfile;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00010574 File Offset: 0x0000E774
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> ListRadiosByProfile(global::System.Guid? groupUUID, string profileName, int systemType, int startIndex, int count)
		{
			int a_ = 6;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> result;
			try
			{
				num = (short)1725780398;
				short num2 = num;
				num = (short)232673710;
				switch (num2 == num)
				{
				}
				num = (short)1367867392;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadiosByProfile(groupUUID, profileName, systemType, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨쒬\udcae얰풴펶킸풺캼ﶾ룀鏂럄꣆꿈ꋊꇌ꫎", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)371523584;
			short num3 = num;
			num = (short)1655701505;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001067C File Offset: 0x0000E87C
		public int GetDataProfileInfoCount(global::System.Guid? groupUuid)
		{
			int a_ = 17;
			short num;
			int dataProfileInfoCount;
			try
			{
				num = (short)377677741;
				short num2 = num;
				num = (short)1171449773;
				switch (num2 == num)
				{
				}
				num = (short)1437794304;
				if (num != 0)
				{
				}
				dataProfileInfoCount = this.RMServer.GetDataProfileInfoCount(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹\udfbd뒿ꏁ铃듅Ꟈ곉ꗋꋍ뗏鯑뫓냕럗駙돛ꯝ軟雡", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)260898816;
			short num3 = num;
			num = (short)2043478017;
			if (num != 0)
			{
			}
			return dataProfileInfoCount;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0001077C File Offset: 0x0000E97C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo> ListDataProfileInfo(global::System.Guid? groupUUID, int startIndex, int count)
		{
			int a_ = 1;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo> result;
			try
			{
				num = (short)1973507324;
				short num2 = num;
				num = (short)1422349564;
				switch (num2 == num)
				{
				}
				num = (short)334561280;
				if (num != 0)
				{
				}
				result = this.RMServer.ListDataProfileInfo(groupUUID, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣솧\ud9a9\ud8ab톯욱햳쪷햹\udabbힽ겿ꟁ跃ꣅ껇ꗉ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)796000256;
			short num3 = num;
			num = (short)373751809;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00010880 File Offset: 0x0000EA80
		public int GetProfileRadioInfoCount(global::System.Guid? groupUuid)
		{
			int a_ = 18;
			short num;
			int profileRadioInfoCount;
			try
			{
				num = (short)720850844;
				short num2 = num;
				num = (short)524177308;
				switch (num2 == num)
				{
				}
				num = (short)963969025;
				if (num != 0)
				{
				}
				num = (short)506134528;
				if (num != 0)
				{
				}
				profileRadioInfoCount = this.RMServer.GetProfileRadioInfoCount(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\udcb8쾺춾껀ꗂ계ꯆ곈駊곌ꯎ룐볒鳔맖뿘듚黜냞铠跢釤", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)110493696;
			short num3 = num;
			return profileRadioInfoCount;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001097C File Offset: 0x0000EB7C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary> ListProfileRadioInfo(global::System.Guid? groupUUID, int startIndex, int count)
		{
			int a_ = 19;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ProfileRadioInfoSummary> result;
			try
			{
				num = (short)1329066904;
				short num2 = num;
				num = (short)1657992088;
				switch (num2 == num)
				{
				}
				num = (short)1463353344;
				if (num != 0)
				{
				}
				result = this.RMServer.ListProfileRadioInfo(groupUUID, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵펹쾻쪽邿냁ꯃꃅꇇꛉ꧋鳍뇏뛑뷓맕釗듙뫛뇝", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)426901504;
			short num3 = num;
			num = (short)951123969;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00010A80 File Offset: 0x0000EC80
		public int GetProfileCountByRadio(global::System.Guid radioId)
		{
			int a_ = 19;
			short num;
			int profileCountByRadio;
			try
			{
				num = (short)139815566;
				short num2 = num;
				num = (short)1430940302;
				switch (num2 == num)
				{
				}
				num = (short)1129578496;
				if (num != 0)
				{
				}
				profileCountByRadio = this.RMServer.GetProfileCountByRadio(radioId);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻늿귁ꋃ꿅꓇꿉黋꿍듏믑믓鿕뛗볙돛鷝迟韡諣鋥", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1787559936;
			short num3 = num;
			num = (short)1257308161;
			if (num != 0)
			{
			}
			return profileCountByRadio;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00010B80 File Offset: 0x0000ED80
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> ListProfilesByRadio(global::System.Guid radioId)
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> result;
			try
			{
				num = (short)1137495048;
				short num2 = num;
				num = (short)1133104136;
				switch (num2 == num)
				{
				}
				num = (short)1383333888;
				if (num != 0)
				{
				}
				result = this.RMServer.ListProfilesByRadio(radioId);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱\udfb5쮷캹첽꾿꓁귃꫅귇막軋럍苏돑냓뿕럗", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)665190400;
			short num3 = num;
			num = (short)1142685697;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00010C80 File Offset: 0x0000EE80
		public int GetAPXOtarProfilesCount(global::System.Guid? groupUuid)
		{
			int a_ = 13;
			short num;
			int apxotarProfilesCount;
			try
			{
				num = (short)556276995;
				short num2 = num;
				num = (short)1072766211;
				switch (num2 == num)
				{
				}
				num = (short)1900216321;
				if (num != 0)
				{
				}
				num = (short)759169024;
				if (num != 0)
				{
				}
				apxotarProfilesCount = this.RMServer.GetAPXOtarProfilesCount(groupUuid, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯톳습醴뒿ꏁ뛃雅뫇ꗉ꫋ꟍ볏럑ꟓ闕럗꿙닛ꫝ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)814022656;
			short num3 = num;
			return apxotarProfilesCount;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00010D80 File Offset: 0x0000EF80
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetAPXOtarProfiles(global::System.Guid? groupUUID, int startIndex, int count)
		{
			int a_ = 14;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> apxotarProfiles;
			try
			{
				num = (short)101520778;
				short num2 = num;
				num = (short)1312626058;
				switch (num2 == num)
				{
				}
				num = (short)22806528;
				if (num != 0)
				{
				}
				apxotarProfiles = this.RMServer.GetAPXOtarProfiles(groupUUID, startIndex, count, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶뗀ꋂ럄韆믈꓊ꯌꛎ뷐뛒ꛔ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)58327040;
			short num3 = num;
			num = (short)109248513;
			if (num != 0)
			{
			}
			return apxotarProfiles;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00010E84 File Offset: 0x0000F084
		public int GetAPXOtarProfilesInfoCount(global::System.Guid? groupUuid)
		{
			int a_ = 2;
			short num;
			int apxotarProfilesInfoCount;
			try
			{
				num = (short)1872039241;
				short num2 = num;
				num = (short)144379209;
				switch (num2 == num)
				{
				}
				num = (short)85590016;
				if (num != 0)
				{
				}
				apxotarProfilesInfoCount = this.RMServer.GetAPXOtarProfilesInfoCount(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaaﾮﲲ솴횶쮸쾼킾Ꟁꫂ꧄ꋆ뫈苊ꏌ꧎뻐郒뫔ꋖ럘꿚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1166475264;
			short num3 = num;
			num = (short)1703149569;
			if (num != 0)
			{
			}
			return apxotarProfilesInfoCount;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00010F84 File Offset: 0x0000F184
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO> GetAPXOtarProfilesInfo(global::System.Guid? groupUUID, int startIndex, int count)
		{
			int a_ = 14;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO> apxotarProfilesInfo;
			try
			{
				num = (short)1092584615;
				short num2 = num;
				num = (short)1413579943;
				switch (num2 == num)
				{
				}
				num = (short)1463025664;
				if (num != 0)
				{
				}
				apxotarProfilesInfo = this.RMServer.GetAPXOtarProfilesInfo(groupUUID, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶뗀ꋂ럄韆믈꓊ꯌꛎ뷐뛒ꛔ黖럘뷚닜", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1722875904;
			short num3 = num;
			num = (short)381747201;
			if (num != 0)
			{
			}
			return apxotarProfilesInfo;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00011084 File Offset: 0x0000F284
		public int GetRadiosByAPXOtarProfileCount(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO otarProfileDto)
		{
			int a_ = 9;
			short num;
			int radiosByAPXOtarProfileCount;
			try
			{
				num = (short)1623596437;
				short num2 = num;
				num = (short)1571364245;
				switch (num2 == num)
				{
				}
				num = (short)1524039681;
				if (num != 0)
				{
				}
				num = (short)1847656448;
				if (num != 0)
				{
				}
				radiosByAPXOtarProfileCount = this.RMServer.GetRadiosByAPXOtarProfileCount(groupUuid, otarProfileDto);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫햯욱ힵ\udcb7펹펻춽芿믁藃雅郇藉룋꿍ꋏ苑ꛓ맕뻗동냛믝ꏟ跡釣裥鳧", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1795948544;
			short num3 = num;
			return radiosByAPXOtarProfileCount;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00011184 File Offset: 0x0000F384
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetRadiosByAPXOtarProfile(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO otarProfileDto, int startIndex, int count)
		{
			int a_ = 1;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> radiosByAPXOtarProfile;
			try
			{
				num = (short)208164350;
				short num2 = num;
				num = (short)897078782;
				switch (num2 == num)
				{
				}
				num = (short)1387659264;
				if (num != 0)
				{
				}
				radiosByAPXOtarProfile = this.RMServer.GetRadiosByAPXOtarProfile(groupUUID, otarProfileDto, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣춧\udea9ﺫ쾭풯\udbb1\udbb3억覆쎹ﶻ颿跁냃Ʂ뫇髉뻋ꇍ뛏믑룓돕", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1707933696;
			short num3 = num;
			num = (short)1269432321;
			if (num != 0)
			{
			}
			return radiosByAPXOtarProfile;
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00011284 File Offset: 0x0000F484
		public int GetAPXOtarProfileRadiosInfoCount(global::System.Guid? groupUuid)
		{
			int a_ = 8;
			short num;
			int apxotarProfileRadioInfoCount;
			try
			{
				num = (short)1883516049;
				short num2 = num;
				num = (short)1679043729;
				switch (num2 == num)
				{
				}
				num = (short)1490550784;
				if (num != 0)
				{
				}
				apxotarProfileRadioInfoCount = this.RMServer.GetAPXOtarProfileRadioInfoCount(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰쾺\udcbc춾釀뇂꫄ꇆꃈꟊ꣌鷎냐럒볔룖꫘鋚돜맞軠ꃢ諤鋦蟨鿪", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1200619520;
			short num3 = num;
			num = (short)1326841857;
			if (num != 0)
			{
			}
			return apxotarProfileRadioInfoCount;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00011388 File Offset: 0x0000F588
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO> GetAPXOtarProfileRadiosInfo(global::System.Guid? groupUUID, int startIndex, int count)
		{
			int a_ = 7;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO> apxotarProfileRadiosInfo;
			try
			{
				num = (short)1300877485;
				short num2 = num;
				num = (short)1166397613;
				switch (num2 == num)
				{
				}
				num = (short)306249728;
				if (num != 0)
				{
				}
				apxotarProfileRadiosInfo = this.RMServer.GetAPXOtarProfileRadiosInfo(groupUUID, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯캹\uddbb첽邿냁ꯃꃅꇇꛉ꧋鳍뇏뛑뷓맕ꯗ鏙닛룝迟", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1460862976;
			short num3 = num;
			num = (short)1406074881;
			if (num != 0)
			{
			}
			return apxotarProfileRadiosInfo;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001148C File Offset: 0x0000F68C
		public int GetAPXOtarProfilesByRadioCount(global::System.Guid radioId)
		{
			int a_ = 12;
			short num;
			int apxotarProfilesByRadioCount;
			try
			{
				num = (short)1017107898;
				short num2 = num;
				num = (short)1652086202;
				switch (num2 == num)
				{
				}
				num = (short)1427111936;
				if (num != 0)
				{
				}
				apxotarProfilesByRadioCount = this.RMServer.GetAPXOtarProfilesByRadioCount(radioId);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴쮾ꃀ뇂闄뗆ꛈ귊꓌ꏎ듐ꃒ韔껖诘뫚맜뛞軠ꃢ諤鋦蟨鿪", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1322188800;
			short num3 = num;
			num = (short)29753345;
			if (num != 0)
			{
			}
			return apxotarProfilesByRadioCount;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00011590 File Offset: 0x0000F790
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> GetAPXOtarProfilesByRadio(global::System.Guid radioId)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> apxotarProfilesByRadio;
			try
			{
				num = (short)1038422530;
				short num2 = num;
				num = (short)1503859202;
				switch (num2 == num)
				{
				}
				num = (short)703463425;
				if (num != 0)
				{
				}
				num = (short)1143144448;
				if (num != 0)
				{
				}
				apxotarProfilesByRadio = this.RMServer.GetAPXOtarProfilesByRadio(radioId);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaaﾮﲲ솴횶쮸쾼킾Ꟁꫂ꧄ꋆ뫈觊듌鷎냐럒볔룖", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)499122176;
			short num3 = num;
			return apxotarProfilesByRadio;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00011690 File Offset: 0x0000F890
		public int GetAllRadioSystemSummariesCount(global::System.Guid? groupUuid)
		{
			int a_ = 4;
			short num;
			int radioSystemSummariesCount;
			try
			{
				num = (short)126220861;
				short num2 = num;
				num = (short)1867446845;
				switch (num2 == num)
				{
				}
				num = (short)1914568704;
				if (num != 0)
				{
				}
				radioSystemSummariesCount = this.RMServer.GetRadioSystemSummariesCount(groupUuid, false, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9ac횶\uddb8튺튼룀냂뇄ꋆ꓈裊ꋌ뫎뿐꟒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)847380480;
			short num3 = num;
			num = (short)1055653889;
			if (num != 0)
			{
			}
			return radioSystemSummariesCount;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00011794 File Offset: 0x0000F994
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListAllRadioSystems(global::System.Guid? groupUUID, int startIndex, int count)
		{
			int a_ = 8;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> result;
			try
			{
				num = (short)501822285;
				short num2 = num;
				num = (short)118895437;
				switch (num2 == num)
				{
				}
				num = (short)973144065;
				if (num != 0)
				{
				}
				num = (short)1425408000;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadioSystemSummaries(groupUUID, startIndex, count, false, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪욮슰잲\udcbc\udbbeꣀ곂雄뻆뫈뿊꣌ꋎꋐ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1409875968;
			short num3 = num;
			return result;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00011898 File Offset: 0x0000FA98
		public int GetAPXRadioSystemsCount(global::System.Guid? groupUuid)
		{
			int a_ = 2;
			short num;
			int apxradioSystemsCount;
			try
			{
				num = (short)601763914;
				short num2 = num;
				num = (short)494481482;
				switch (num2 == num)
				{
				}
				num = (short)745144320;
				if (num != 0)
				{
				}
				num = (short)1710948353;
				if (num != 0)
				{
				}
				apxradioSystemsCount = this.RMServer.GetAPXRadioSystemsCount(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaaﾮ풴펶킸풺욾닀럂ꃄ꫆諈꓊료ꇎꗐ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1887305728;
			short num3 = num;
			return apxradioSystemsCount;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00011998 File Offset: 0x0000FB98
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary> ListAPXRadioSystems(global::System.Guid? groupUUID, int startIndex, int count)
		{
			int a_ = 17;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary> result;
			try
			{
				num = (short)577946297;
				short num2 = num;
				num = (short)42975929;
				switch (num2 == num)
				{
				}
				num = (short)620691456;
				if (num != 0)
				{
				}
				result = this.RMServer.ListAPXRadioSystems(groupUUID, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳蝹톷즹좻ﾽ邿髁雃Ʂ곇ꏉꏋ鷍ꧏꇑꃓ돕뗗꧙", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)314834944;
			short num3 = num;
			num = (short)2023424001;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00011A98 File Offset: 0x0000FC98
		public int GetRadioCountBySystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary apxRadioSystem)
		{
			int a_ = 8;
			short num;
			int radioCountBySystem;
			try
			{
				num = (short)768593540;
				short num2 = num;
				num = (short)1266536068;
				switch (num2 == num)
				{
				}
				num = (short)1446707201;
				if (num != 0)
				{
				}
				num = (short)1722482688;
				if (num != 0)
				{
				}
				radioCountBySystem = this.RMServer.GetRadioCountBySystem(groupUuid, apxRadioSystem, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰\udaba\ud9bc횾껀郂별듆뷈껊ꃌ賎뻐ꛒ믔ꏖ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)577896448;
			short num3 = num;
			return radioCountBySystem;
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00011B98 File Offset: 0x0000FD98
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListRadiosByRadioSystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary apxRadioSystem, int startIndex, int count, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			int a_ = 6;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> result;
			try
			{
				num = (short)1172969712;
				short num2 = num;
				num = (short)1880103152;
				switch (num2 == num)
				{
				}
				num = (short)950140928;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadiosByRadioSystem(groupUuid, apxRadioSystem, startIndex, count, false, productFamily);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨쒬\udcae얰풴펶킸풺캼ﶾ룀苂闄鿆鯈꫊꧌ꛎ뻐胒곔ꓖ귘뻚냜", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)554827776;
			short num3 = num;
			num = (short)382926849;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00011C9C File Offset: 0x0000FE9C
		public int GetSystemRadioInfosCount(global::System.Guid? groupUuid)
		{
			int a_ = 16;
			short num;
			int systemRadioInfosCount;
			try
			{
				num = (short)1721539834;
				short num2 = num;
				num = (short)1987681530;
				switch (num2 == num)
				{
				}
				num = (short)988610561;
				if (num != 0)
				{
				}
				num = (short)1358168064;
				if (num != 0)
				{
				}
				systemRadioInfosCount = this.RMServer.GetSystemRadioInfosCount(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲튶춸쒼첾뗀ꛂ꣄闆꣈꿊꓌ꃎ飐뷒돔룖꫘飚닜꫞迠韢", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1773666304;
			short num3 = num;
			return systemRadioInfosCount;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00011D9C File Offset: 0x0000FF9C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary> ListSystemRadioInfos(global::System.Guid? groupUuid, int startIndex, int count)
		{
			int a_ = 8;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXSystemRadioInfoSummary> result;
			try
			{
				num = (short)1680955089;
				short num2 = num;
				num = (short)1703761617;
				switch (num2 == num)
				{
				}
				num = (short)317718528;
				if (num != 0)
				{
				}
				result = this.RMServer.ListSystemRadioInfos(groupUuid, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪욮슰잲캶쪸쾺\ud8bc튾닀臂별闆꣈꿊꓌ꃎ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)916652032;
			short num3 = num;
			num = (short)2077032449;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00011E9C File Offset: 0x0001009C
		public int GetSystemCountByRadio(global::System.Guid radioUuid)
		{
			int a_ = 19;
			short num;
			int systemCountByRadio;
			try
			{
				num = (short)884657751;
				short num2 = num;
				num = (short)1901842007;
				switch (num2 == num)
				{
				}
				num = (short)2117337088;
				if (num != 0)
				{
				}
				num = (short)1685716993;
				if (num != 0)
				{
				}
				systemCountByRadio = this.RMServer.GetSystemCountByRadio(radioUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻릿뇁냃ꏅꗇ觉ꏋ믍뻏ꛑ雓꿕諗믙룛럝迟", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)166068224;
			short num3 = num;
			return systemCountByRadio;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00011F9C File Offset: 0x0001019C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> ListSystemsByRadio(global::System.Guid radioUuid)
		{
			int a_ = 3;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> result;
			try
			{
				num = (short)1776039558;
				short num2 = num;
				num = (short)1287403142;
				switch (num2 == num)
				{
				}
				num = (short)154730496;
				if (num != 0)
				{
				}
				result = this.RMServer.ListSystemsByRadio(radioUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쎩\udfab\udaad쮱잳습\uddb7ힹ쾻ﲽ릿郁ꗃꋅꇇꗉ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1625948161;
			if (num != 0)
			{
			}
			num = (short)451674112;
			short num3 = num;
			return result;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000120A0 File Offset: 0x000102A0
		public global::Motorola.CommonCPS.Server.EntityModel.Codeplug GetCodeplug(global::System.Guid codePlugID)
		{
			int a_ = 11;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug;
			try
			{
				num = (short)1967783937;
				if (num != 0)
				{
				}
				num = (short)1035344584;
				short num2 = num;
				num = (short)2119375560;
				switch (num2 == num)
				{
				}
				num = (short)2083127296;
				if (num != 0)
				{
				}
				codeplug = this.RMServer.GetCodeplug(codePlugID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳ힷ\udeb9\ud9bb캽겿럁ꏃ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)682622976;
			short num3 = num;
			return codeplug;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000121A4 File Offset: 0x000103A4
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary> ListJbcSummarys(bool? isRwJob, int pageNumber, int pageSize)
		{
			int a_ = 8;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary> result;
			try
			{
				num = (short)641324100;
				short num2 = num;
				num = (short)1741280324;
				switch (num2 == num)
				{
				}
				num = (short)2005729280;
				if (num != 0)
				{
				}
				num = (short)1037828097;
				if (num != 0)
				{
				}
				result = this.RMServer.ListJbcSummarys(isRwJob, pageNumber, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪욮슰잲ﾴ햶\udab8좼튾곀ꋂ럄뻆뫈", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1611071488;
			short num3 = num;
			return result;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000122A8 File Offset: 0x000104A8
		public global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary GetLastJbcSummary(bool? isRwJob)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary lastJbcSummary;
			try
			{
				num = (short)1953533591;
				short num2 = num;
				num = (short)286953111;
				switch (num2 == num)
				{
				}
				num = (short)2047868928;
				if (num != 0)
				{
				}
				lastJbcSummary = this.RMServer.GetLastJbcSummary(isRwJob);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢슦\udda8첬\udcae얰零ힴ풶캺킼튾ꃀ뇂별", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)515244033;
			if (num != 0)
			{
			}
			num = (short)928382976;
			short num3 = num;
			return lastJbcSummary;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000123A8 File Offset: 0x000105A8
		public global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary GetJbcSummary(global::System.Guid guid)
		{
			int a_ = 4;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary jbcSummary;
			try
			{
				num = (short)1928887534;
				short num2 = num;
				num = (short)1463778542;
				switch (num2 == num)
				{
				}
				num = (short)1044512768;
				if (num != 0)
				{
				}
				jbcSummary = this.RMServer.GetJbcSummary(guid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9ac펰킲슶풸횺\udcbc춾룀", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)157614081;
			if (num != 0)
			{
			}
			num = (short)470286336;
			short num3 = num;
			return jbcSummary;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000124AC File Offset: 0x000106AC
		public int GetJbcCount(bool? isRwJob)
		{
			int a_ = 19;
			short num;
			int jbcCount;
			try
			{
				num = (short)905402654;
				short num2 = num;
				num = (short)836851998;
				switch (num2 == num)
				{
				}
				num = (short)1730150400;
				if (num != 0)
				{
				}
				jbcCount = this.RMServer.GetJbcCount(isRwJob);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻ꊿꇁ蟃꧅뷇꓉룋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)636878849;
			if (num != 0)
			{
			}
			num = (short)1200816128;
			short num3 = num;
			return jbcCount;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000125AC File Offset: 0x000107AC
		public int GetJobCount(global::System.Guid jbcUuid)
		{
			int a_ = 3;
			short num;
			int jobCount;
			try
			{
				num = (short)1367299539;
				short num2 = num;
				num = (short)2143966675;
				switch (num2 == num)
				{
				}
				num = (short)2078212096;
				if (num != 0)
				{
				}
				jobCount = this.RMServer.GetJobCount(jbcUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쾩\ud8ab\udfaf킱\ud9b5춷풹좻", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1525153793;
			if (num != 0)
			{
			}
			num = (short)1103364096;
			short num3 = num;
			return jobCount;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000126AC File Offset: 0x000108AC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity> ListJobSummary(global::System.Guid jbcUuid, int pageNumber, int pageSize)
		{
			int a_ = 18;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity> result;
			try
			{
				num = (short)1643330823;
				short num2 = num;
				num = (short)9649415;
				switch (num2 == num)
				{
				}
				num = (short)1124139009;
				if (num != 0)
				{
				}
				num = (short)1065418752;
				if (num != 0)
				{
				}
				result = this.RMServer.ListJobSummarys(jbcUuid, pageNumber, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴﮶킸좺즼껀ꇂ雄닆꓈ꛊ곌뷎꣐ꃒ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)505217024;
			short num3 = num;
			return result;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x000127B0 File Offset: 0x000109B0
		public global::Motorola.CommonCPS.Server.EntityModel.Job GetJob(global::System.Guid jobUuid)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Job job;
			try
			{
				num = (short)1076130944;
				short num2 = num;
				num = (short)1839756416;
				switch (num2 == num)
				{
				}
				num = (short)216793088;
				if (num != 0)
				{
				}
				num = (short)1785724929;
				if (num != 0)
				{
				}
				job = this.RMServer.GetJob(jobUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢슦\udda8슬춮", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1087045632;
			short num3 = num;
			return job;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000128B0 File Offset: 0x00010AB0
		public global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetJobSummary(global::System.Guid jobUuid)
		{
			int a_ = 1;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity jobSummary;
			try
			{
				num = (short)785229805;
				short num2 = num;
				num = (short)1268426733;
				switch (num2 == num)
				{
				}
				num = (short)309133312;
				if (num != 0)
				{
				}
				num = (short)884146177;
				if (num != 0)
				{
				}
				jobSummary = this.RMServer.GetJobSummary(jobUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣춧\udea9솭튯솳\udbb5햷\udbb9캻잽", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1352204288;
			short num3 = num;
			return jobSummary;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000129B0 File Offset: 0x00010BB0
		public global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetLastJobSummaryInJbc(global::System.Guid jbcUuid)
		{
			int a_ = 16;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity lastJobSummaryInJbc;
			try
			{
				num = (short)989809920;
				short num2 = num;
				num = (short)1501842688;
				switch (num2 == num)
				{
				}
				num = (short)211550208;
				if (num != 0)
				{
				}
				lastJobSummaryInJbc = this.RMServer.GetLastJobSummaryInJbc(jbcUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲튶춸\udcbc첾뗀观꫄ꗆ髈뻊ꃌꋎ냐ꇒ곔黖럘釚뿜볞", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2069495809;
			if (num != 0)
			{
			}
			num = (short)390070272;
			short num3 = num;
			return lastJobSummaryInJbc;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00012AB0 File Offset: 0x00010CB0
		public bool HasJobFailed(global::System.Guid jobContainerUuid)
		{
			int a_ = 12;
			short num;
			bool result;
			try
			{
				num = (short)1791025672;
				short num2 = num;
				num = (short)385016328;
				switch (num2 == num)
				{
				}
				num = (short)1177944064;
				if (num != 0)
				{
				}
				result = this.RMServer.HasJobFailed(jobContainerUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮聆튲운ﶶ횸\ud9ba﮼\udebeꣀ꿂ꃄꏆ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1720451073;
			if (num != 0)
			{
			}
			num = (short)1194721280;
			short num3 = num;
			return result;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00012BB0 File Offset: 0x00010DB0
		public global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity GetLastJobSummary(bool? isRwJob)
		{
			int a_ = 14;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.JobSummaryViewEntity lastJobSummary;
			try
			{
				num = (short)1671655989;
				short num2 = num;
				num = (short)565735989;
				switch (num2 == num)
				{
				}
				num = (short)1699348480;
				if (num != 0)
				{
				}
				lastJobSummary = this.RMServer.GetLastJobSummary(isRwJob);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶\udaba캼쮾诀곂Ꞔ铆볈ꛊꃌ껎ꏐ꫒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2062352385;
			if (num != 0)
			{
			}
			num = (short)714801152;
			short num3 = num;
			return lastJobSummary;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00012CB0 File Offset: 0x00010EB0
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob> ListJobsByDeviceUuid(global::System.Guid deviceID, int startIndex, int count)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob> result;
			try
			{
				num = (short)872764831;
				short num2 = num;
				num = (short)731927967;
				switch (num2 == num)
				{
				}
				num = (short)861995008;
				if (num != 0)
				{
				}
				result = this.RMServer.ListJobsByDeviceUuid(deviceID, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧얫\uddad쒯\udbb3풵쮷얻諾ꖿ듁귃ꗅ귇鿉맋ꟍ듏", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)675545089;
			if (num != 0)
			{
			}
			num = (short)843382784;
			short num3 = num;
			return result;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00012DB4 File Offset: 0x00010FB4
		public int GetDeviceRWJobsCount(global::System.Guid deviceUuid)
		{
			int a_ = 4;
			short num;
			int deviceRWJobsCount;
			try
			{
				num = (short)242048939;
				short num2 = num;
				num = (short)1320247211;
				switch (num2 == num)
				{
				}
				num = (short)103940096;
				if (num != 0)
				{
				}
				deviceRWJobsCount = this.RMServer.GetDeviceRWJobsCount(deviceUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9ac풰얲\udcb4풶\udcb8껀ꇂ뛄蓆ꛈ뻊ꏌ믎", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)639107073;
			if (num != 0)
			{
			}
			num = (short)1195376640;
			short num3 = num;
			return deviceRWJobsCount;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00012EB0 File Offset: 0x000110B0
		public void DeleteJobContainer(global::System.Guid batchJobContainerUuid, global::System.Guid deletingJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet, string jobContainerName)
		{
			int a_ = 1;
			short num;
			try
			{
				num = (short)612734699;
				short num2 = num;
				num = (short)541693675;
				switch (num2 == num)
				{
				}
				num = (short)919076864;
				if (num != 0)
				{
				}
				num = (short)1007812609;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.DeleteJobContainerBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.DeleteJobContainerBatchJobParameter(batchJobContainerUuid, deletingJobContainerUuid, validateEntitySet)
				{
					JobDescription = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc97ﾙﮝ풟잡蒣", a_) + jobContainerName
				};
				this.RMServer.DeleteJobContainer(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣춧용즫\udaad햯\udbb3풵﮷햹튻쪽ꆿꯁ꫃ꏅ뫇", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)32112640;
			short num3 = num;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00012FD0 File Offset: 0x000111D0
		public global::Motorola.CommonCPS.Server.EntityModel.Template GetTemplate(global::System.Guid templateUuid, bool isDeep = false)
		{
			int a_ = 5;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Template template;
			try
			{
				num = (short)1400778090;
				short num2 = num;
				num = (short)1661676906;
				switch (num2 == num)
				{
				}
				num = (short)211746816;
				if (num != 0)
				{
				}
				template = this.RMServer.GetTemplate(templateUuid, isDeep);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaadힱ\ud9b3욵풷\udbb9좻\udbbd", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1361575937;
			if (num != 0)
			{
			}
			num = (short)1449525248;
			short num3 = num;
			return template;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000130D4 File Offset: 0x000112D4
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary ImportTemplate(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Template temp)
		{
			int a_ = 5;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary result;
			try
			{
				num = (short)488572080;
				short num2 = num;
				num = (short)1172505776;
				switch (num2 == num)
				{
				}
				num = (short)502530049;
				if (num != 0)
				{
				}
				num = (short)1097072640;
				if (num != 0)
				{
				}
				result = this.RMServer.ImportTemplate(batchJobContainerUuid, temp);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧좫쪭ힱ\ud9b3욵풷\udbb9좻\udbbd", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1280573440;
			short num3 = num;
			return result;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000131D4 File Offset: 0x000113D4
		public global::Motorola.CommonCPS.Server.EntityModel.Template ImportTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template temp, string currentFWVersion, bool? isPortable, string lpIDUpgradeTo = null)
		{
			int a_ = 13;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Template result;
			try
			{
				num = (short)638898839;
				short num2 = num;
				num = (short)1129108119;
				switch (num2 == num)
				{
				}
				num = (short)677838848;
				if (num != 0)
				{
				}
				num = (short)1622278145;
				if (num != 0)
				{
				}
				result = this.RMServer.ImportTemplateAndUpdateLP(temp, lpIDUpgradeTo, currentFWVersion, isPortable);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯ﮱ\ud9b3욵ힷ좹좻ꖿ꿁듃꫅꧇뻉꧋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1877278720;
			short num3 = num;
			return result;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000132D8 File Offset: 0x000114D8
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ListTemplateSummaries(int startIndex, int pageSize)
		{
			int a_ = 10;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> result;
			try
			{
				num = (short)1210187777;
				if (num != 0)
				{
				}
				num = (short)1137616967;
				short num2 = num;
				num = (short)478521415;
				switch (num2 == num)
				{
				}
				num = (short)846659584;
				if (num != 0)
				{
				}
				result = this.RMServer.ListTemplateSummaries(startIndex, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬\ud8b0삲솴\udcb8횺춼펾ꃀ럂ꃄ듆", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)744488960;
			short num3 = num;
			return result;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000133DC File Offset: 0x000115DC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> GetTemplateLPDetailInfo(global::System.Guid TemplateUuid)
		{
			int a_ = 6;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> templateLPDetailInfo;
			try
			{
				num = (short)1602488013;
				short num2 = num;
				num = (short)1140786893;
				switch (num2 == num)
				{
				}
				num = (short)1448738816;
				if (num != 0)
				{
				}
				num = (short)2141782017;
				if (num != 0)
				{
				}
				templateLPDetailInfo = this.RMServer.GetTemplateLPDetailInfo(TemplateUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbae횲\ud8b4잶햸\udaba즼\udabe跀鏂臄ꋆ뷈꫊꓌ꏎ飐뷒돔룖", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)765001728;
			short num3 = num;
			return templateLPDetailInfo;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000134DC File Offset: 0x000116DC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> GetTemplateVADetailInfo(global::System.Guid TemplateUuid)
		{
			int a_ = 7;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> templateVADetailInfo;
			try
			{
				num = (short)362110932;
				short num2 = num;
				num = (short)1845911508;
				switch (num2 == num)
				{
				}
				num = (short)716505088;
				if (num != 0)
				{
				}
				templateVADetailInfo = this.RMServer.GetTemplateVADetailInfo(TemplateUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯톳\udbb5좷횹\uddbb쪽ꖿ铁藃苅귇뻉귋ꟍ볏鯑뫓냕럗", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)531890177;
			if (num != 0)
			{
			}
			num = (short)1428291584;
			short num3 = num;
			return templateVADetailInfo;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000135DC File Offset: 0x000117DC
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary GetTemplateSummary(global::System.Guid templateUuid)
		{
			int a_ = 4;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary templateSummary;
			try
			{
				num = (short)254042275;
				short num2 = num;
				num = (short)359162019;
				switch (num2 == num)
				{
				}
				num = (short)1230241792;
				if (num != 0)
				{
				}
				templateSummary = this.RMServer.GetTemplateSummary(templateUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9acﮮ풰\udeb2어\udbb6\ud8b8쾺\ud8bc듀껂꣄ꛆ믈닊", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1140195329;
			if (num != 0)
			{
			}
			num = (short)781516800;
			short num3 = num;
			return templateSummary;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000136DC File Offset: 0x000118DC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetReferencedRadioList(global::System.Guid templateUuid, int startIndex, int count, bool returnWorkingRadiosOnly = false)
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> referencedRadios;
			try
			{
				num = (short)2005287078;
				short num2 = num;
				num = (short)1586118822;
				switch (num2 == num)
				{
				}
				num = (short)693764096;
				if (num != 0)
				{
				}
				referencedRadios = this.RMServer.GetReferencedRadios(templateUuid, startIndex, count, returnWorkingRadiosOnly);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮\udbb2킴풶트\ud8bc튾뇀꿂꓄돆곈藊곌ꋎ듐韒ꃔꟖ뗘닚뻜뻞闠蛢", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)813957121;
			if (num != 0)
			{
			}
			num = (short)613875712;
			short num3 = num;
			return referencedRadios;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000137DC File Offset: 0x000119DC
		public int GetReferencedRadiosCount(global::System.Collections.Generic.List<global::System.Guid> templateUuidList, bool isWorkingOnly = false, bool isFilterJob = true)
		{
			short num;
			int result;
			try
			{
				num = (short)551716390;
				short num2 = num;
				num = (short)971933222;
				switch (num2 == num)
				{
				}
				num = (short)1093730304;
				if (num != 0)
				{
				}
				result = this.RMServer.GetReferencedRadiosCount(templateUuidList, isWorkingOnly, isFilterJob);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				result = 0;
			}
			num = (short)113442817;
			if (num != 0)
			{
			}
			num = (short)995164160;
			short num3 = num;
			return result;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000138B4 File Offset: 0x00011AB4
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> GetReferencedRadiosbyTemplateList(global::System.Collections.Generic.List<global::System.Guid> templateUuidList, int startIndex, int count)
		{
			short num;
			global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> result;
			try
			{
				num = (short)1886489683;
				short num2 = num;
				num = (short)1338543187;
				switch (num2 == num)
				{
				}
				num = (short)1802698752;
				if (num != 0)
				{
				}
				result = this.RMServer.GetReferencedRadiosbyWorkingTemplateList(templateUuidList, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				result = null;
			}
			num = (short)759103489;
			if (num != 0)
			{
			}
			num = (short)545521664;
			short num3 = num;
			return result;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00013988 File Offset: 0x00011B88
		public bool CheckTemplateNameDuplicate(string templateName)
		{
			int a_ = 15;
			short num;
			bool result;
			try
			{
				num = (short)1984706023;
				short num2 = num;
				num = (short)596194791;
				switch (num2 == num)
				{
				}
				num = (short)1376714752;
				if (num != 0)
				{
				}
				result = (this.RMServer.TemplateExist(templateName) != null);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱\udeb5\uddb7\ud9b9ힻꖿ꿁듃꫅꧇뻉꧋胍뇏뿑뇓鋕귗꫙냛럝菟菡郣菥", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1950810113;
			if (num != 0)
			{
			}
			num = (short)1679884288;
			short num3 = num;
			return result;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00013A8C File Offset: 0x00011C8C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> ListMatrixKeys(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType, int startIndex, int count)
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> result;
			try
			{
				num = (short)406620178;
				short num2 = num;
				num = (short)640190482;
				switch (num2 == num)
				{
				}
				num = (short)623575040;
				if (num != 0)
				{
				}
				num = (short)1535049729;
				if (num != 0)
				{
				}
				result = this.RMServer.ListMatrixKeys(keyType, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲領\udeb6쪸쾺ﲾ鏀裂ꃄ뻆诈꫊뻌꫎ꋐ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2093875200;
			short num3 = num;
			return result;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00013B8C File Offset: 0x00011D8C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> ListMatrixKeys(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType)
		{
			int a_ = 17;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> result;
			try
			{
				num = (short)1728992249;
				short num2 = num;
				num = (short)38032377;
				switch (num2 == num)
				{
				}
				num = (short)369033216;
				if (num != 0)
				{
				}
				result = this.RMServer.ListMatrixKeys(keyType, 0, int.MaxValue);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳蝹톷즹좻莿郁迃ꏅ뇇裉귋뷍뗏ꇑ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1097269249;
			if (num != 0)
			{
			}
			num = (short)1692598272;
			short num3 = num;
			return result;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00013C94 File Offset: 0x00011E94
		public global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> GetMatrixKeysByIdentifiers(global::System.Collections.Generic.List<string> identifiers, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType)
		{
			int a_ = 10;
			global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey> result;
			short num;
			for (;;)
			{
				result = null;
				try
				{
					result = this.RMServer.GetMatrixKeysByIdentifiers(identifiers, keyType);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲횶춸즺풼잾諀ꛂ별듆诈닊蓌ꯎ듐뷒ꇔ뻖뿘닚룜귞鋠", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
				}
				num = (short)839418665;
				short num2 = num;
				num = (short)946242345;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7E;
				}
			}
			IL_7E:
			num = (short)98107393;
			if (num != 0)
			{
			}
			num = (short)2037645312;
			if (num != 0)
			{
			}
			num = (short)1652293632;
			short num3 = num;
			return result;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00013D94 File Offset: 0x00011F94
		public int GetMatrixKeysCount(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType)
		{
			int a_ = 13;
			short num;
			int matrixKeysCount;
			try
			{
				num = (short)1510330044;
				short num2 = num;
				num = (short)1160367804;
				switch (num2 == num)
				{
				}
				num = (short)1361903616;
				if (num != 0)
				{
				}
				matrixKeysCount = this.RMServer.GetMatrixKeysCount(keyType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯톳습\udbb9좻첽ꦿ뫁迃ꏅ뇇막迋ꇍꗏ병ꃓ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)308215809;
			if (num != 0)
			{
			}
			num = (short)491126784;
			short num3 = num;
			return matrixKeysCount;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00013E94 File Offset: 0x00012094
		public global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData FillPcrKeyData(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData keyDataOnlyHasKeyId)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData result;
			try
			{
				num = (short)792967170;
				short num2 = num;
				num = (short)2057549826;
				switch (num2 == num)
				{
				}
				num = (short)2010841088;
				if (num != 0)
				{
				}
				num = (short)1063256065;
				if (num != 0)
				{
				}
				result = this.RMServer.FillPcrKeyData(keyDataOnlyHasKeyId);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴킸ힺ톼ꋀ뇂軄ꋆ냈迊곌믎냐", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1869938688;
			short num3 = num;
			return result;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00013F94 File Offset: 0x00012194
		public global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData GetPCRKeyIDsByConfigurationId(global::System.Guid configurationUuid)
		{
			int a_ = 10;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData pcrkeyIDsByConfigurationId;
			try
			{
				num = (short)1530263754;
				short num2 = num;
				num = (short)1823275210;
				switch (num2 == num)
				{
				}
				num = (short)1469251584;
				if (num != 0)
				{
				}
				pcrkeyIDsByConfigurationId = this.RMServer.GetPCRKeyIDsByConfigurationId(configurationUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲\ud8bc욾裀蟂뛄藆냈裊ꋌꇎ럐뫒닔ꋖꯘ뫚꧜뛞軠跢곤菦", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1365114881;
			if (num != 0)
			{
			}
			num = (short)1542782976;
			short num3 = num;
			return pcrkeyIDsByConfigurationId;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00014094 File Offset: 0x00012294
		public string GenerateHostID()
		{
			int a_ = 5;
			short num;
			string result;
			try
			{
				num = (short)684598592;
				short num2 = num;
				num = (short)1033119040;
				switch (num2 == num)
				{
				}
				num = (short)693436417;
				if (num != 0)
				{
				}
				num = (short)492044288;
				if (num != 0)
				{
				}
				result = this.RMServer.GenerateHostID();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫삭햯삱햳습\uddb7펻춽뒿证胃", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1239744512;
			short num3 = num;
			return result;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00014194 File Offset: 0x00012394
		public void EnableFeature(global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject referenceReq, byte[] capabilityResponse)
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)1085092872;
				short num2 = num;
				num = (short)904672264;
				switch (num2 == num)
				{
				}
				num = (short)1807286272;
				if (num != 0)
				{
				}
				this.RMServer.EnableFeature(referenceReq, capabilityResponse);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬\udfb0튲ힴ\udbb6\udcb8ﶺ\ud8bc\udebe뗀뛂럄ꋆ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1824718849;
			if (num != 0)
			{
			}
			num = (short)2108948480;
			short num3 = num;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00014294 File Offset: 0x00012494
		public global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject GenerateFeatureRequest(string AID, int count)
		{
			int a_ = 19;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject result;
			try
			{
				num = (short)1614197055;
				short num2 = num;
				num = (short)651735359;
				switch (num2 == num)
				{
				}
				num = (short)1818230784;
				if (num != 0)
				{
				}
				result = this.RMServer.GenerateFeatureRequest(AID, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9튻\udbbd늿ꏁ냃ꏅ軇꿉귋뫍ꗏꃑ뇓蓕뷗ꯙ꧛믝鏟雡", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)645529601;
			if (num != 0)
			{
			}
			num = (short)29032448;
			short num3 = num;
			return result;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00014394 File Offset: 0x00012594
		public void CancelFeatureRequest(global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject referenceRequest)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)682117311;
				short num2 = num;
				num = (short)1584154815;
				switch (num2 == num)
				{
				}
				num = (short)725614592;
				if (num != 0)
				{
				}
				this.RMServer.CancelFeatureRequest(referenceRequest);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲횶ힸ\ud8ba\ud8bc펾蟀ꛂ꓄돆볈맊꣌鷎듐ꋒꃔ닖꫘꿚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)679870465;
			if (num != 0)
			{
			}
			num = (short)1701052416;
			short num3 = num;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00014490 File Offset: 0x00012690
		public global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject GenerateRecoverRequest()
		{
			int a_ = 4;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.FeatureRequestObject result;
			try
			{
				num = (short)849118963;
				short num2 = num;
				num = (short)917735155;
				switch (num2 == num)
				{
				}
				num = (short)2100035584;
				if (num != 0)
				{
				}
				num = (short)1233387521;
				if (num != 0)
				{
				}
				result = this.RMServer.GenerateRecoverRequest();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪쎬쪮쎰튲솴튶\udeba\udebc킾럀ꛂ럄闆곈뫊료꫎ꋐ꟒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)137953280;
			short num3 = num;
			return result;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00014590 File Offset: 0x00012790
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatures(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0)
		{
			int a_ = 4;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> result;
			try
			{
				num = (short)533041242;
				short num2 = num;
				num = (short)183013466;
				switch (num2 == num)
				{
				}
				num = (short)942669825;
				if (num != 0)
				{
				}
				num = (short)1982660608;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadioFeatureSummary(groupUuid, startIndex, count, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9acﶮ킰ힲ\udcb4\ud8b6튺\udebc\udabe꿀냂ꃄ듆", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1156382720;
			short num3 = num;
			return result;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00014694 File Offset: 0x00012894
		public byte[] GetRadioFeatures(string radioSerialNumber)
		{
			short num = (short)411303937;
			if (num != 0)
			{
			}
			num = (short)1356999560;
			short num2 = num;
			num = (short)2125933448;
			switch (num2 == num)
			{
			default:
			{
				num = (short)178454528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1169293312;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00014744 File Offset: 0x00012944
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetCMSCFeatures(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0)
		{
			int a_ = 13;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> result;
			try
			{
				num = (short)1443874753;
				short num2 = num;
				num = (short)70043585;
				switch (num2 == num)
				{
				}
				num = (short)535822336;
				if (num != 0)
				{
				}
				result = this.RMServer.ListCMSCRadioFeatureSummary(groupUuid, startIndex, count, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯톳습﮷ﶽ蚿ꟁꗃ닅뷇룉꧋뷍", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)244842497;
			if (num != 0)
			{
			}
			num = (short)2079391744;
			short num3 = num;
			return result;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00014848 File Offset: 0x00012A48
		public int GetRadioFeatureCount(global::System.Guid? groupUuid, int featureType = 0)
		{
			int a_ = 17;
			short num;
			int radioFeatureCount;
			try
			{
				num = (short)239016183;
				short num2 = num;
				num = (short)1252202743;
				switch (num2 == num)
				{
				}
				num = (short)284622848;
				if (num != 0)
				{
				}
				radioFeatureCount = this.RMServer.GetRadioFeatureCount(groupUuid, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹\udfbd꒿ꯁꯃ胅귇ꯉ룋믍ꋏ럑韓맕귗듙꣛", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1710424065;
			if (num != 0)
			{
			}
			num = (short)1417281536;
			short num3 = num;
			return radioFeatureCount;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00014948 File Offset: 0x00012B48
		public int GetCMSCRadioFeatureCount(global::System.Guid? groupUuid, int featureType = 0)
		{
			int a_ = 14;
			short num;
			int cmscradioFeatureCount;
			try
			{
				num = (short)35764241;
				short num2 = num;
				num = (short)1767553041;
				switch (num2 == num)
				{
				}
				num = (short)1571749888;
				if (num != 0)
				{
				}
				cmscradioFeatureCount = this.RMServer.GetCMSCRadioFeatureCount(groupUuid, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶\udaba\ud9bc횾껀藂ꃄꛆ뷈뻊뿌꫎鋐黒蛔铖高듚꣜뇞闠", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)104792065;
			if (num != 0)
			{
			}
			num = (short)703266816;
			short num3 = num;
			return cmscradioFeatureCount;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00014A48 File Offset: 0x00012C48
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatureDetailsByCMSCFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureName, int featureType = 0)
		{
			int a_ = 6;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> radioFeatureDetailsByFeature;
			try
			{
				num = (short)864364735;
				short num2 = num;
				num = (short)1679632575;
				switch (num2 == num)
				{
				}
				num = (short)981925888;
				if (num != 0)
				{
				}
				radioFeatureDetailsByFeature = this.RMServer.GetRadioFeatureDetailsByFeature(groupUuid, startIndex, count, featureName, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbae튲톴\udeb6횸ﶺ\ud8bc\udebe뗀뛂럄ꋆ跈껊만껎룐뿒ꛔ闖ꃘ飚郜賞ꋠꗢ胤蛦鷨黪鿬諮", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)751304705;
			if (num != 0)
			{
			}
			num = (short)759562240;
			short num3 = num;
			return radioFeatureDetailsByFeature;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00014B4C File Offset: 0x00012D4C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatureDetailsByFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureName, int featureType = 0)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> radioFeatureDetailsByFeature;
			try
			{
				num = (short)179210426;
				short num2 = num;
				num = (short)851282106;
				switch (num2 == num)
				{
				}
				num = (short)1041694720;
				if (num != 0)
				{
				}
				radioFeatureDetailsByFeature = this.RMServer.GetRadioFeatureDetailsByFeature(groupUuid, startIndex, count, featureName, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaaﾬ캮햰\udab2\udab4﮶킸\ud8ba\ud8bc톾닀ꛂ뛄", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2065432577;
			if (num != 0)
			{
			}
			num = (short)1585119232;
			short num3 = num;
			return radioFeatureDetailsByFeature;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00014C50 File Offset: 0x00012E50
		public int GetRadioFeatureDetailsByFeatureCount(global::System.Guid? groupUuid, int featureName, int featureType = 0)
		{
			int a_ = 8;
			short num;
			int radioFeatureDetailsByFeatureCount;
			try
			{
				num = (short)878522362;
				short num2 = num;
				num = (short)1399336954;
				switch (num2 == num)
				{
				}
				num = (short)2114846720;
				if (num != 0)
				{
				}
				radioFeatureDetailsByFeatureCount = this.RMServer.GetRadioFeatureDetailsByFeatureCount(groupUuid, featureName, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰풴펶킸풺횾ꋀꛂꯄ듆곈룊", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1318191105;
			if (num != 0)
			{
			}
			num = (short)286064640;
			short num3 = num;
			return radioFeatureDetailsByFeatureCount;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00014D50 File Offset: 0x00012F50
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0)
		{
			int a_ = 6;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> result;
			try
			{
				num = (short)949716999;
				short num2 = num;
				num = (short)295536647;
				switch (num2 == num)
				{
				}
				num = (short)1294532609;
				if (num != 0)
				{
				}
				num = (short)37289984;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadioFeatureSummaryByFeature(groupUuid, startIndex, count, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbae튲톴\udeb6횸풼\udcbe꓀귂뛄ꋆ뫈", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)595460096;
			short num3 = num;
			return result;
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00014E54 File Offset: 0x00013054
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByCMSCFeature(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0)
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> result;
			try
			{
				num = (short)1421794733;
				short num2 = num;
				num = (short)700505517;
				switch (num2 == num)
				{
				}
				num = (short)701235200;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadioFeatureSummaryByCMSCFeature(groupUuid, startIndex, count, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲領\udeb6쪸쾺\udebeꗀꫂ꫄臆곈꫊만뫎ꏐ뛒蛔ꋖ듘뛚볜귞飠ꇢ鳤ꓦꓨ룪껬ꧮ铰鋲致苶诸黺", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)671678465;
			if (num != 0)
			{
			}
			num = (short)583925760;
			short num3 = num;
			return result;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00014F58 File Offset: 0x00013158
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> GetRadioFeatureDetailsByRadio(global::System.Guid radioUuid, int featureType = 0)
		{
			int a_ = 10;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> radioFeatureDetailsByRadio;
			try
			{
				num = (short)1088802974;
				short num2 = num;
				num = (short)940495006;
				switch (num2 == num)
				{
				}
				num = (short)1936785408;
				if (num != 0)
				{
				}
				radioFeatureDetailsByRadio = this.RMServer.GetRadioFeatureDetailsByRadio(radioUuid, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲횶\uddb8튺튼ꣀꃂꃄ꧆뫈껊뻌", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)793051137;
			if (num != 0)
			{
			}
			num = (short)1394016256;
			short num3 = num;
			return radioFeatureDetailsByRadio;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00015058 File Offset: 0x00013258
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByRadio(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0)
		{
			int a_ = 10;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> result;
			try
			{
				num = (short)1754541005;
				short num2 = num;
				num = (short)110570445;
				switch (num2 == num)
				{
				}
				num = (short)1725562880;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadioFeatureSummaryByRadio(groupUuid, startIndex, count, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲횶\uddb8튺튼ꣀꃂꃄ꧆뫈껊뻌", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)131268609;
			if (num != 0)
			{
			}
			num = (short)155516928;
			short num3 = num;
			return result;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001515C File Offset: 0x0001335C
		public int GetRadioFeatureSummaryByRadioCount(global::System.Guid? groupUuid, int featureType = 0)
		{
			int a_ = 3;
			short num;
			int radioFeatureSummaryByRadioCount;
			try
			{
				num = (short)780116250;
				short num2 = num;
				num = (short)373727514;
				switch (num2 == num)
				{
				}
				num = (short)799277056;
				if (num != 0)
				{
				}
				radioFeatureSummaryByRadioCount = this.RMServer.GetRadioFeatureSummaryByRadioCount(groupUuid, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쾩\ud8abﲭ톯횱\uddb3\ud9b5ﺷ\udfb9\uddbb쪽떿냁ꇃ闅뷇Ꟊꇋ꿍ꋏꯑ雓꿕諗믙룛럝迟ꇡ诣鏥蛧黩", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2071724033;
			if (num != 0)
			{
			}
			num = (short)401932288;
			short num3 = num;
			return radioFeatureSummaryByRadioCount;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00015260 File Offset: 0x00013460
		public int GetRadioFeatureSummaryByCMSCCount(global::System.Guid? groupUuid, int featureType = 0)
		{
			int a_ = 17;
			short num;
			int radioFeatureSummaryByCMSCCount;
			try
			{
				num = (short)1981617215;
				short num2 = num;
				num = (short)1536627775;
				switch (num2 == num)
				{
				}
				num = (short)963510273;
				if (num != 0)
				{
				}
				num = (short)1062469632;
				if (num != 0)
				{
				}
				radioFeatureSummaryByCMSCCount = this.RMServer.GetRadioFeatureSummaryByCMSCCount(groupUuid, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹\udfbd꒿ꯁꯃ胅귇ꯉ룋믍ꋏ럑蟓ꏕ뗗럙뷛곝駟ꃡ鷣ꗥꗧ맩꿫귭鿯蟱髳苵", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)145293312;
			short num3 = num;
			return radioFeatureSummaryByCMSCCount;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00015368 File Offset: 0x00013568
		public int ListRadioFeatureSummaryByRadio(global::System.Guid? groupUuid, int featureType = 0)
		{
			int a_ = 16;
			short num;
			int radioFeatureSummaryByFeatureCount;
			try
			{
				num = (short)261212771;
				short num2 = num;
				num = (short)255838819;
				switch (num2 == num)
				{
				}
				num = (short)1966407681;
				if (num != 0)
				{
				}
				num = (short)1050214400;
				if (num != 0)
				{
				}
				radioFeatureSummaryByFeatureCount = this.RMServer.GetRadioFeatureSummaryByFeatureCount(groupUuid, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲領\udeb6쪸쾺\udebeꗀꫂ꫄臆곈꫊만뫎ꏐ뛒蛔ꋖ듘뛚볜귞飠ꇢ鳤뗦裨迪蓬胮", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1513160704;
			short num3 = num;
			return radioFeatureSummaryByFeatureCount;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00015468 File Offset: 0x00013668
		public int GetRadioFeatureSummaryByCMSCFeatureCount(global::System.Guid? groupUuid, int featureType = 0)
		{
			int a_ = 2;
			short num;
			int radioFeatureSummaryByCMSCFeatureCount;
			try
			{
				num = (short)695447177;
				short num2 = num;
				num = (short)1684450953;
				switch (num2 == num)
				{
				}
				num = (short)1861812224;
				if (num != 0)
				{
				}
				radioFeatureSummaryByCMSCFeatureCount = this.RMServer.GetRadioFeatureSummaryByCMSCFeatureCount(groupUuid, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaaﾬ캮햰\udab2\udab4\udcb8\udaba즼쪾돀ꛂ雄닆꓈ꛊ곌뷎꣐釒곔铖铘裚黜駞蓠苢釤鋦鯨軪껬胮蓰鷲致", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)248250369;
			if (num != 0)
			{
			}
			num = (short)930021376;
			short num3 = num;
			return radioFeatureSummaryByCMSCFeatureCount;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00015568 File Offset: 0x00013768
		public int GetRadioFeaturesCount(global::System.Guid? groupUUID, int featureType = 0)
		{
			int a_ = 1;
			short num;
			int radioFeatureCount;
			try
			{
				num = (short)1990182793;
				short num2 = num;
				num = (short)282314633;
				switch (num2 == num)
				{
				}
				num = (short)1011613696;
				if (num != 0)
				{
				}
				radioFeatureCount = this.RMServer.GetRadioFeatureCount(groupUUID, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣춧\udea9ﺫ쾭풯\udbb1\udbb3蝹톷\ud9b9\ud9bb킽뎿ꟁ럃藅Ꟈ뿉ꋋ뫍", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1012137985;
			if (num != 0)
			{
			}
			num = (short)1958871040;
			short num3 = num;
			return radioFeatureCount;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00015668 File Offset: 0x00013868
		public int GetRadioFeatureIndex(global::System.Guid? groupUUID, global::System.Guid RadioLicenseUuid, string searchString, global::Motorola.CommonCPS.Server.EntityModel.OrderByOption[] orderByOptions)
		{
			int a_ = 2;
			short num;
			int result;
			try
			{
				num = (short)1230755505;
				short num2 = num;
				num = (short)739825329;
				switch (num2 == num)
				{
				}
				num = (short)131137536;
				if (num != 0)
				{
				}
				result = (int)this.RMServer.GetRadioFeatureSummaryRowIndex(groupUUID, RadioLicenseUuid, searchString, orderByOptions.ToList<global::Motorola.CommonCPS.Server.EntityModel.OrderByOption>());
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaaﾬ캮햰\udab2\udab4﮶킸\ud8ba\ud8bc톾닀ꛂ賄꧆귈껊뗌", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1357512705;
			if (num != 0)
			{
			}
			num = (short)764411904;
			short num3 = num;
			return result;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00015774 File Offset: 0x00013974
		public void UpdateRadioFeatureComments(global::System.Guid radioFeatureUuid, string comments)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)198752805;
				short num2 = num;
				num = (short)898087461;
				switch (num2 == num)
				{
				}
				num = (short)1985216512;
				if (num != 0)
				{
				}
				this.RMServer.UpdateRadioFeatureComments(radioFeatureUuid, comments);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹\udfbd꒿ꯁꯃ諅ꇇ꧉꧋ꃍꏏ럑鷓룕볗뿙ꓛ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1205534721;
			if (num != 0)
			{
			}
			num = (short)571867136;
			short num3 = num;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00015878 File Offset: 0x00013A78
		public void UpdateAppFeatureComments(string comments)
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)1670943646;
				short num2 = num;
				num = (short)1183159198;
				switch (num2 == num)
				{
				}
				num = (short)1059061760;
				if (num != 0)
				{
				}
				this.RMServer.UpdateAppLicenseComments(comments);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴\ud8b8\udfba풼킾跀ꫂꛄꋆꟈ룊꣌蛎뿐럒냔꿖", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)891092993;
			if (num != 0)
			{
			}
			num = (short)1324548096;
			short num3 = num;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00015974 File Offset: 0x00013B74
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> ListRadioFeatureSummaryByCMSC(global::System.Guid? groupUuid, int startIndex, int count, int featureType = 0)
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> result;
			try
			{
				num = (short)696584304;
				short num2 = num;
				num = (short)119146608;
				switch (num2 == num)
				{
				}
				num = (short)550830081;
				if (num != 0)
				{
				}
				num = (short)909115392;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadioFeatureSummaryByCMSC(groupUuid, startIndex, count, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲領\udeb6쪸쾺\udebeꗀꫂ꫄臆곈꫊만뫎ꏐ뛒蛔ꋖ듘뛚볜귞飠ꇢ鳤ꓦꓨ룪껬", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1533411328;
			short num3 = num;
			return result;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00015A78 File Offset: 0x00013C78
		public void ResetRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, bool toOverride)
		{
			short num = (short)1787232257;
			if (num != 0)
			{
			}
			num = (short)1389031579;
			short num2 = num;
			num = (short)1319366811;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2001600512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2113208320;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00015B20 File Offset: 0x00013D20
		public void UpgradeRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features)
		{
			short num = (short)2026513207;
			short num2 = num;
			num = (short)584327991;
			switch (num2 == num)
			{
			}
			num = (short)113115136;
			short num3 = num;
			num = (short)822738945;
			if (num != 0)
			{
			}
			num = (short)298516480;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00015BC8 File Offset: 0x00013DC8
		public global::EntityModel.GenericModel.CFSUpdateResult RecoverRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, byte[] targetFlashCode, byte[] capacityResponse)
		{
			int a_ = 6;
			short num;
			global::EntityModel.GenericModel.CFSUpdateResult result;
			try
			{
				num = (short)1541328321;
				short num2 = num;
				num = (short)650104257;
				switch (num2 == num)
				{
				}
				num = (short)1626996737;
				if (num != 0)
				{
				}
				num = (short)664338432;
				if (num != 0)
				{
				}
				result = this.RMServer.RecoverRadioFeatures(radioId, features, targetFlashCode, capacityResponse);
			}
			catch (global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData> faultException)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨寧좬첮\udeb0얲킴얶\udaba\ud9bc횾껀藂ꃄꛆ뷈뻊뿌꫎ꋐ", a_), faultException, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(faultException);
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨寧좬첮\udeb0얲킴얶\udaba\ud9bc횾껀藂ꃄꛆ뷈뻊뿌꫎ꋐ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j, ex);
			}
			num = (short)466550784;
			short num3 = num;
			return result;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00015CF4 File Offset: 0x00013EF4
		public void RestoreRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)882764045;
				short num2 = num;
				num = (short)1466755341;
				switch (num2 == num)
				{
				}
				num = (short)137166849;
				if (num != 0)
				{
				}
				num = (short)1538785280;
				if (num != 0)
				{
				}
				this.RMServer.RestoreRadioFeatures(radioId, features);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲튶쪸쾺튼춾꓀釂꓄ꏆꃈ꓊诌꫎냐꟒ꃔꗖ볘꣚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1592524800;
			short num3 = num;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00015DF4 File Offset: 0x00013FF4
		public global::EntityModel.GenericModel.CFSUpdateResult RestoreCMSCFeatures(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid)
		{
			int a_ = 5;
			short num;
			global::EntityModel.GenericModel.CFSUpdateResult result;
			try
			{
				num = (short)2113073494;
				short num2 = num;
				num = (short)1540288854;
				switch (num2 == num)
				{
				}
				num = (short)556138496;
				if (num != 0)
				{
				}
				result = this.RMServer.RestoreLicenseToCMSC(radioUuid, featureList, isSubmit, response, batchJobContainerUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\uddad쒯\uddb1욳펵\udbb9\ud8bbힽ꾿蓁ꇃꟅ볇뿉뻋ꯍꏏ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1073938432;
			short num3 = num;
			num = (short)496041985;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00015EF8 File Offset: 0x000140F8
		public void SubmitRadioFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, byte[] targetFlashCode, global::Motorola.CommonCPS.Server.CommonDBConstants.LicenseFrom licenseFrom)
		{
			short num = (short)701693952;
			short num2 = num;
			num = (short)1794048001;
			if (num != 0)
			{
			}
			num = (short)683399472;
			short num3 = num;
			num = (short)949541168;
			switch (num3 == num)
			{
			}
			num = (short)1515978752;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00015FA0 File Offset: 0x000141A0
		[global::System.Obsolete]
		public int GetASTRODataProfileCount(global::System.Guid? groupUUID, string searchString)
		{
			int a_ = 8;
			short num;
			int result;
			try
			{
				num = (short)1944556798;
				short num2 = num;
				num = (short)976000254;
				switch (num2 == num)
				{
				}
				num = (short)1588461569;
				if (num != 0)
				{
				}
				num = (short)915996672;
				if (num != 0)
				{
				}
				result = (int)this.RMServer.GetAPXDataProfileCount(groupUUID, searchString);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰寮\udebe뗀ꋂ闄뗆ꛈ귊꓌ꏎ듐郒뫔ꋖ럘꿚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)675020800;
			short num3 = num;
			return result;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000160A4 File Offset: 0x000142A4
		[global::System.Obsolete]
		public int GetTemplateCount()
		{
			int a_ = 2;
			short num;
			int templateCount;
			try
			{
				num = (short)1752688958;
				short num2 = num;
				num = (short)1421732158;
				switch (num2 == num)
				{
				}
				num = (short)618528768;
				if (num != 0)
				{
				}
				templateCount = this.RMServer.GetTemplateCount();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaa怜쪮\udcb0쎲\ud9b4횶춸\udebaﺼ킾듀귂뇄", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1563623424;
			short num3 = num;
			num = (short)1291386881;
			if (num != 0)
			{
			}
			return templateCount;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000161A0 File Offset: 0x000143A0
		[global::System.Obsolete]
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> GetCompatibleTemplateSummaryList(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList, int startIndex, int count)
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> result;
			try
			{
				num = (short)1323912437;
				short num2 = num;
				num = (short)1233210613;
				switch (num2 == num)
				{
				}
				num = (short)1481244672;
				if (num != 0)
				{
				}
				num = (short)461963265;
				if (num != 0)
				{
				}
				result = this.d.ListMatchedTemplate(radioUUIDList, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴횸횺춼\udebe뗀ꫂꟄꯆ곈鿊꣌ꋎꇐ뿒듔ꏖ볘裚꣜닞賠苢韤黦ꗨ苪黬鯮", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1479016448;
			short num3 = num;
			return result;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000162A0 File Offset: 0x000144A0
		[global::System.Obsolete]
		public long GetCompatibleTemplateCount(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList)
		{
			int a_ = 5;
			short num;
			long matchedTemplateCount;
			try
			{
				num = (short)326050199;
				short num2 = num;
				num = (short)985407895;
				switch (num2 == num)
				{
				}
				num = (short)1957756928;
				if (num != 0)
				{
				}
				matchedTemplateCount = this.d.GetMatchedTemplateCount(radioUUIDList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad\uddb1\ud9b3욵\ud9b7캹햻\udcbd겿ꟁ郃ꏅꗇ뫉ꃋ꿍꓏럑蟓ꏕ뗗럙뷛곝駟껡跣闥鳧", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1640562688;
			short num3 = num;
			num = (short)86966273;
			if (num != 0)
			{
			}
			return matchedTemplateCount;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000163A0 File Offset: 0x000145A0
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> GetPackageSummaries(int startIndex, int length, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, int? region)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> result;
			try
			{
				num = (short)448114284;
				short num2 = num;
				num = (short)1427484268;
				switch (num2 == num)
				{
				}
				num = (short)1309343744;
				if (num != 0)
				{
				}
				num = (short)1755316225;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPackageSummary(startIndex, length, type, region, null);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaaﶬ캮튰\ud8b2풴킶\udcb8좼튾곀ꋂ럄껆곈룊", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)71958528;
			short num3 = num;
			return result;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000164A4 File Offset: 0x000146A4
		public int GetPackagesCount(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, int? pairGroupRegion)
		{
			int a_ = 10;
			short num;
			int packagesCount;
			try
			{
				num = (short)366693932;
				short num2 = num;
				num = (short)718229036;
				switch (num2 == num)
				{
				}
				num = (short)1897332736;
				if (num != 0)
				{
				}
				packagesCount = this.RMServer.GetPackagesCount(packageType, pairGroupRegion);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲횶\udab8킺\udcbc\ud8be꓀냂蛄꣆볈ꗊ만", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)469958656;
			short num3 = num;
			num = (short)2132803585;
			if (num != 0)
			{
			}
			return packagesCount;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000165A4 File Offset: 0x000147A4
		public global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFile(string filePath, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType = global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.Default)
		{
			int a_ = 10;
			short num = (short)789774336;
			short num2 = num;
			num = (short)967550583;
			short num3 = num;
			num = (short)1946265207;
			global::Motorola.CommonCPS.Server.EntityModel.RMFile result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)873398272;
				if (num != 0)
				{
				}
				num = (short)1113522177;
				if (num != 0)
				{
				}
				num = (short)1577910272;
				switch (num)
				{
				default:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("令캪\udfac즮\udeb0솲\ud8b4횶ힸ\ud8ba\ud8bc跀곂ꋄꃆ곈맊", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캢햤좦\udba8\udfaa\uddae튰\udbb2\udcb4솶\udcb8了\udcbc쮾ꋀꯂ諄럆", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톢삤쒨\udbaa슬\uddae얰킴\udab6즸ힺ\udcbc쮾꓀韂꫄铆곈맊믌꫎ꏐ﯒ﳔ淪飘뿚맜駞裠迢胤쿦샨쯪뻬鯮郰臲致", a_));
					try
					{
						string name = new global::System.IO.FileInfo(filePath).Name;
						global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = null;
						global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
						try
						{
							num = (short)1193869312;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								byte[] array;
								int num6;
								global::System.Guid fileUuid;
								int num7;
								string sha256HashCode;
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_155;
									}
									continue;
								case 1:
									goto IL_172;
								case 2:
								{
									int num5;
									if ((num5 = fileStream.Read(array, 0, num6)) <= 0)
									{
										num = (short)1001652228;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									rmfile = this.a(fileType, fileUuid, (long)num7, array, num5, fileStream.Length, sha256HashCode);
									num7 += num5;
									num = (short)489684995;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_177;
								case 4:
									global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("令캪\udfac즮\udeb0솲\ud8b4횶ힸ\ud8ba\ud8bc跀곂ꋄꃆ곈맊", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캢햤좦\udba8\udfaa\uddae튰\udbb2\udcb4솶\udcb8了\udcbc쮾ꋀꯂ諄럆", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잢솤삨잪좬螮颰鶲펶\uddb8ﶺ풼펾꓀蛂ꯄ꿆꣈ꗊ껌꫎볐뛒믔ꏖ﷜髞迠蟢", a_));
									num = (short)631963653;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_2CD;
								case 6:
									goto IL_177;
								}
								IL_155:
								if (fileStream.Length == 0L)
								{
									num = (short)1861091329;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num6 = 3145728;
								array = new byte[num6];
								sha256HashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetSha256HashCode(fileStream);
								fileUuid = global::System.Guid.NewGuid();
								fileStream.Position = 0L;
								num7 = 0;
								global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("令캪\udfac즮\udeb0솲\ud8b4횶ힸ\ud8ba\ud8bc跀곂ꋄꃆ곈맊", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캢햤좦\udba8\udfaa\uddae튰\udbb2\udcb4솶\udcb8了\udcbc쮾ꋀꯂ諄럆", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잢솤삨잪좬螮颰鶲펶\uddb8ﶺ풼펾꓀蛂ꯄ꿆꣈ꗊ껌꫎볐뛒믔ꏖ﷜賞闠苢韤鏦", a_));
								num = (short)1434058758;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_177:
								num = (short)1093664770;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_172:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PM_CannotUploadEmptyFile);
							IL_2CD:;
						}
						finally
						{
							num = (short)1517879296;
							int num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_303;
									}
									continue;
								case 1:
									goto IL_33B;
								case 2:
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)1875705857;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_303:
								if (fileStream == null)
								{
									break;
								}
								num = (short)838008834;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_33B:;
						}
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("令캪\udfac즮\udeb0솲\ud8b4횶ힸ\ud8ba\ud8bc跀곂ꋄꃆ곈맊", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캢햤좦\udba8\udfaa\uddae튰\udbb2\udcb4솶\udcb8了\udcbc쮾ꋀꯂ諄럆", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톢삤쒨\udbaa슬\uddae얰킴\udab6즸ힺ\udcbc쮾꓀韂꫄铆곈맊믌꫎ꏐ﯒ﳔ淪飘뿚맜駞裠迢胤쿦샨쯪꣬臮闰", a_));
						result = rmfile;
					}
					catch (global::System.UnauthorizedAccessException ex)
					{
						throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_CannotAccessTheFile0, filePath), ex);
					}
					catch (global::Motorola.Common.CustomException.CommonException)
					{
						throw;
					}
					catch (global::System.Exception ex2)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PM_AddFileToServer_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_AddFileToServer_Error, ex2);
					}
					break;
				}
				break;
			}
			return result;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000169C0 File Offset: 0x00014BC0
		public global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFile(byte[] fileData, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType = global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.Default)
		{
			int a_ = 2;
			short num = (short)14811136;
			short num2 = num;
			num = (short)927757398;
			short num3 = num;
			num = (short)988902486;
			global::Motorola.CommonCPS.Server.EntityModel.RMFile result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1036845057;
				if (num != 0)
				{
				}
				num = (short)586678272;
				if (num != 0)
				{
				}
				num = (short)1877475328;
				switch (num)
				{
				default:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮘횚\ude9c삞욢힤솦욨\ud9aa사캮\udfb0킲킴풺\udabc\ud8be꓀뇂", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda98ﺞ햠욢薤펦\udda8\ud8aa趬즮\ud8b0\udfb2킴", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda98ﺞ햠욢펦\udaa8ﶪ슬욮튰횲\ud9b6ힸ풺좼톾ꋀꛂ菄껆ꗈ껊诌ꃎꏐ闒꟔뻖볘뗚맜돞飠귢蓤諦賨귪蓬諮鷰韲\uddf4\udef6", a_));
					try
					{
						num = (short)1607467008;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_12B;
								}
								continue;
							case 1:
								goto IL_1F5;
							case 2:
								goto IL_145;
							}
							IL_12B:
							if (fileData.Length == 0)
							{
								num = (short)1594425346;
								num4 = (int)((global::System.IntPtr)num);
							}
							else
							{
								string sha256HashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetSha256HashCode(fileData);
								global::System.Guid fileUuid = global::System.Guid.NewGuid();
								int num5 = 0;
								global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮘횚\ude9c삞욢힤솦욨\ud9aa사캮\udfb0킲킴풺\udabc\ud8be꓀뇂", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda98ﺞ햠욢펦\udaa8ﶪ슬욮튰횲\ud9b6ힸ풺좼톾ꋀꛂ菄껆ꗈ껊诌ꃎꏐ闒꟔뻖볘뗚맜돞飠귢蓤諦賨귪蓬諮鷰韲", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud898ﾚ列\ud99e좠쾢삤辦肨薪쮮햰\udcb4\udbb6\udcb8ﺺ펼ힾꃀ귂ꛄꋆ꓈껊ꏌ믎類㮝蓖귘뫚꿜ꯞ", a_));
								global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = this.a(fileType, fileUuid, (long)num5, fileData, fileData.Length, (long)fileData.Length, sha256HashCode);
								global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쮘횚\ude9c삞욢힤솦욨\ud9aa사캮\udfb0킲킴풺\udabc\ud8be꓀뇂", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda98ﺞ햠욢펦\udaa8ﶪ슬욮튰횲\ud9b6ힸ풺좼톾ꋀꛂ菄껆ꗈ껊诌ꃎꏐ闒꟔뻖볘뗚맜돞飠귢蓤諦賨귪蓬諮鷰韲", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud898ﾚ列\ud99e좠쾢삤辦肨薪쮮햰\udcb4\udbb6\udcb8ﺺ펼ힾꃀ귂ꛄꋆ꓈껊ꏌ믎類㮝鋖럘뿚", a_));
								result = rmfile;
								num = (short)112918529;
								num4 = (int)((global::System.IntPtr)num);
							}
						}
						IL_145:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PM_CannotUploadEmptyFile);
						IL_1F5:;
					}
					catch (global::Motorola.Common.CustomException.CommonException)
					{
						throw;
					}
					catch (global::System.Exception ex)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PM_AddFileToServer_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_AddFileToServer_Error, ex);
					}
					break;
				}
				break;
			}
			return result;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00016BF8 File Offset: 0x00014DF8
		public byte[] GetFileContent(global::System.Guid fileUuid)
		{
			int a_ = 14;
			short num;
			byte[] result;
			try
			{
				num = (short)1340057358;
				short num2 = num;
				num = (short)510699278;
				byte[] array;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)324993024;
					if (num != 0)
					{
					}
					num = (short)1783758848;
					int num3 = (int)num;
					switch (num3)
					{
					default:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RMFile file = this.RMServer.GetFile(fileUuid);
						array = new byte[file.Length.Value];
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
						try
						{
							switch (0)
							{
							case 0:
								goto IL_BF;
							}
							int num5;
							for (;;)
							{
								IL_A4:
								switch (num3)
								{
								case 0:
									goto IL_11F;
								case 1:
									goto IL_11F;
								case 2:
								{
									int num4 = num5;
									int? length = file.Length;
									if (!(num4 < length.GetValueOrDefault() & length != null))
									{
										num = (short)1109655556;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									byte[] fileContentEnhancement = this.RMServer.GetFileContentEnhancement(file, (long)num5, 307200);
									memoryStream.Write(fileContentEnhancement, 0, fileContentEnhancement.Length);
									num5 += fileContentEnhancement.Length;
									num = (short)1497759745;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1A1;
								case 4:
									memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
									memoryStream.Read(array, 0, num5);
									memoryStream.Close();
									num = (short)1174077443;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BF;
								IL_11F:
								num = (short)2122776578;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1A1:
							break;
							IL_BF:
							num5 = 0;
							num = (short)2009464832;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_A4;
						}
						finally
						{
							num = (short)1796538368;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D5;
									}
									continue;
								case 1:
									goto IL_20B;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)459407361;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1D5:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)609222658;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_20B:;
						}
						break;
					}
					}
					break;
				}
				}
				result = array;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶ﾸ튺톼\udabe苀곂ꯄ돆곈ꗊ만", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)270598144;
			short num6 = num;
			num = (short)1870594049;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00016ED4 File Offset: 0x000150D4
		public global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFileContent(byte[] data)
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RMFile result;
			try
			{
				num = (short)307814534;
				short num2 = num;
				num = (short)1544740998;
				global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2019360768;
					if (num != 0)
					{
					}
					num = (short)359268352;
					int num3 = (int)num;
					switch (num3)
					{
					default:
					{
						rmfile = null;
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data);
						try
						{
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							byte[] array;
							global::System.Guid fileUuid;
							int num5;
							long length;
							string sha256HashCode;
							for (;;)
							{
								IL_86:
								switch (num3)
								{
								case 0:
									goto IL_117;
								case 1:
									goto IL_117;
								case 2:
								{
									int num4;
									if ((num4 = memoryStream.Read(array, 0, 307200)) <= 0)
									{
										num = (short)1387462660;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									rmfile = this.RMServer.AddFileEnhancement(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.Default, fileUuid, (long)num5, array, num4, length, sha256HashCode);
									num5 += num4;
									num = (short)402849793;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_17C;
								case 4:
									memoryStream.Close();
									num = (short)8454147;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A1;
								IL_117:
								num = (short)471138306;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_17C:
							break;
							IL_A1:
							fileUuid = global::System.Guid.NewGuid();
							num5 = 0;
							array = new byte[307200];
							length = memoryStream.Length;
							sha256HashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetSha256HashCode(data);
							num = (short)811597824;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_86;
						}
						finally
						{
							num = (short)1162936320;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B1;
									}
									continue;
								case 1:
									goto IL_1E8;
								case 2:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)1457586177;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1B1:
								if (memoryStream == null)
								{
									break;
								}
								num = (short)1315962882;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1E8:;
						}
						break;
					}
					}
					break;
				}
				}
				result = rmfile;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫풯횱\udfb5풷\udfb9ﾻ톽꺿뛁ꇃꣅ볇", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1936064512;
			short num6 = num;
			num = (short)1834418177;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0001718C File Offset: 0x0001538C
		public global::Motorola.CommonCPS.Server.EntityModel.RMFile GetFile(global::System.Guid fileUuid)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RMFile file;
			try
			{
				num = (short)1545596373;
				short num2 = num;
				num = (short)1219030485;
				switch (num2 == num)
				{
				}
				num = (short)511311872;
				if (num != 0)
				{
				}
				file = this.RMServer.GetFile(fileUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢슦\udda8쒬쎮풰", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1113587712;
			short num3 = num;
			num = (short)223150081;
			if (num != 0)
			{
			}
			return file;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001728C File Offset: 0x0001548C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> GetASTROPackagesByTargetModelVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string targetModel, string packageVersion, bool isFreon, bool isEqual = true)
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> result;
			try
			{
				num = (short)1590405059;
				short num2 = num;
				num = (short)994617283;
				switch (num2 == num)
				{
				}
				num = (short)1845493760;
				if (num != 0)
				{
				}
				result = this.RMServer.ListASTROPackagesByTargetModelVersion(packageType, targetModel, packageVersion, isFreon, isEqual);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲튶춸諸鏀賂闄ꛆ꫈ꃊ곌꣎듐ꃒ韔껖跘뫚꿜룞蓠韢꣤裦跨軪臬맮铰臲蛴黶雸闺", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)243793920;
			short num3 = num;
			num = (short)1936130049;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00017390 File Offset: 0x00015590
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> GetAstroAmpFirmwares(global::Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects.AstroAmpFirmwareQuery query)
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> astroAmpFirmwares;
			try
			{
				num = (short)1841838051;
				short num2 = num;
				num = (short)1737308131;
				switch (num2 == num)
				{
				}
				num = (short)890503168;
				if (num != 0)
				{
				}
				astroAmpFirmwares = this.RMServer.GetAstroAmpFirmwares(query);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴쪸쾺쾼킾胀껂뗄臆ꃈ맊ꃌ룎냐ꇒ냔ꓖ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)963510272;
			short num3 = num;
			num = (short)926351361;
			if (num != 0)
			{
			}
			return astroAmpFirmwares;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00017490 File Offset: 0x00015690
		public global::Motorola.CommonCPS.Server.EntityModel.PCRPackage GetPCRPackageByNameVersion(global::Motorola.CommonCPS.Server.EntityModel.PCRPackageRequest packageReq)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PCRPackage pcrpackageByNameVersion;
			try
			{
				num = (short)1151776747;
				short num2 = num;
				num = (short)634238955;
				switch (num2 == num)
				{
				}
				num = (short)892403712;
				if (num != 0)
				{
				}
				pcrpackageByNameVersion = this.RMServer.GetPCRPackageByNameVersion(packageReq);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯\udbb9\udfbb햽ꆿꗁꇃ蓅뇇蓉귋ꏍ뗏蓑뇓ꓕꯗ동돛냝", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1557463040;
			short num3 = num;
			num = (short)1966014465;
			if (num != 0)
			{
			}
			return pcrpackageByNameVersion;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00017590 File Offset: 0x00015790
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary> GetPCRLanguagePackLatestByFamily(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily languagePackFamily)
		{
			int a_ = 19;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRLanguagePackSummary> result;
			try
			{
				num = (short)1166300716;
				short num2 = num;
				num = (short)1798788652;
				switch (num2 == num)
				{
				}
				num = (short)1673068544;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPCRLanguagePackLatestByFamily(languagePackFamily);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻莿郁裃Ʂꛇ귉맋꿍럏럑蓓럕믗뇙郛뿝铟蟡韣鋥ꫧ鏩ꫫ迭鷯鯱飳迵", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)91881472;
			short num3 = num;
			num = (short)1751646209;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00017690 File Offset: 0x00015890
		public global::System.Collections.Generic.List<string> ListLanguagePackNames(global::Motorola.CommonCPS.Server.CommonDBConstants.LanguagePackFamily? languagePackFamily)
		{
			int a_ = 4;
			short num;
			global::System.Collections.Generic.List<string> result;
			try
			{
				num = (short)149423179;
				short num2 = num;
				num = (short)1080951883;
				switch (num2 == num)
				{
				}
				num = (short)1844183040;
				if (num != 0)
				{
				}
				result = this.RMServer.ListLanguagePackNames(languagePackFamily);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦슪\udeac\udbaeﶰ튲\udbb4킶첸\udaba\udabc\udabe釀ꋂꛄ곆蟈꫊ꃌ꫎ꋐ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1471938560;
			short num3 = num;
			num = (short)504954881;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00017790 File Offset: 0x00015990
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> ListPackage(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string modelFilter = null)
		{
			int a_ = 4;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> result;
			try
			{
				num = (short)1584748602;
				short num2 = num;
				num = (short)1267750970;
				switch (num2 == num)
				{
				}
				num = (short)510590976;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPackageSummary(0, int.MaxValue, packageType, null, modelFilter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦슪\udeac\udbae튲횴\udcb6\ud8b8\udcba\ud8bc", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1378418688;
			short num3 = num;
			num = (short)600834049;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000178A4 File Offset: 0x00015AA4
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBPackage> ListPBBPackages(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType)
		{
			int a_ = 18;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBPackage> result;
			try
			{
				num = (short)1031583603;
				short num2 = num;
				num = (short)1450293107;
				switch (num2 == num)
				{
				}
				num = (short)584843264;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPBBPackages(packageType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴﮶킸좺즼菀臂闄ꛆ꫈ꃊ곌꣎듐ꃒ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1253834752;
			short num3 = num;
			num = (short)1638268929;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000179A4 File Offset: 0x00015BA4
		public global::Motorola.CommonCPS.Server.EntityModel.Package AddPBBPackage(global::Motorola.CommonCPS.Server.EntityModel.PBBPackage pbbPackage)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Package result;
			try
			{
				num = (short)1656105004;
				short num2 = num;
				num = (short)1265379372;
				switch (num2 == num)
				{
				}
				num = (short)1479147521;
				if (num != 0)
				{
				}
				num = (short)811401216;
				if (num != 0)
				{
				}
				result = this.RMServer.ImportPackage(pbbPackage);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\uddb8\udfbaﶾ菀鏂꓄꓆ꋈ꫊꫌꫎", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)482213888;
			short num3 = num;
			return result;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00017AA8 File Offset: 0x00015CA8
		public global::System.Collections.Generic.List<global::System.Guid> GetReferencedRadioUuidListByPackageUuid(global::System.Guid packageUuid)
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.List<global::System.Guid> result;
			try
			{
				num = (short)2040390159;
				short num2 = num;
				num = (short)1613029903;
				switch (num2 == num)
				{
				}
				num = (short)40894464;
				if (num != 0)
				{
				}
				num = (short)815333377;
				if (num != 0)
				{
				}
				result = null;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲튶춸\ud8bc\ud9be꓀뇂ꃄ꧆꫈껊꧌鷎냐럒볔룖賘껚드믞균諢雤鏦ꯨ鋪뷬軮鋰飲铴郶鳸껺裼雾攀", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)328204288;
			short num3 = num;
			return result;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00017B9C File Offset: 0x00015D9C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> ListASTROPackagesByCompatibleVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType packageType, string compatibleVersion)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage> result;
			try
			{
				num = (short)1691859581;
				short num2 = num;
				num = (short)275954301;
				switch (num2 == num)
				{
				}
				num = (short)1388511233;
				if (num != 0)
				{
				}
				num = (short)752484352;
				if (num != 0)
				{
				}
				result = this.RMServer.ListASTROPackagesByCompatibleVersion(compatibleVersion);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧얫\uddad쒯\udfbdꎿ꧁ꗃꇅ귇막軋럍鏏뷑맓ꛕ맗껙뗛볝賟蟡닣菥髧駩藫臭黯", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)755105792;
			short num3 = num;
			return result;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00017C9C File Offset: 0x00015E9C
		public global::Motorola.CommonCPS.Server.EntityModel.Package GetPackage(global::System.Guid packageUuid)
		{
			int a_ = 5;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Package package;
			try
			{
				num = (short)99085726;
				short num2 = num;
				num = (short)1454566814;
				switch (num2 == num)
				{
				}
				num = (short)1553334272;
				if (num != 0)
				{
				}
				num = (short)1013710849;
				if (num != 0)
				{
				}
				package = this.RMServer.GetPackage(packageUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad솱삳쒵ힷ\uddbb\uddbdꮿꏁꏃꏅ談돉駋믍맏뛑", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)290586624;
			short num3 = num;
			return package;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00017D9C File Offset: 0x00015F9C
		public global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationShortcut GetPBBAppShortcutByPackageNameClassName(global::Motorola.CommonCPS.Server.EntityModel.PackageRequest packageReq)
		{
			int a_ = 14;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationShortcut pbbappShortcutByPackageNameClassName;
			try
			{
				num = (short)703285824;
				short num2 = num;
				num = (short)1543981632;
				switch (num2 == num)
				{
				}
				num = (short)1442578433;
				if (num != 0)
				{
				}
				num = (short)1410793472;
				if (num != 0)
				{
				}
				pbbappShortcutByPackageNameClassName = this.RMServer.GetPBBAppShortcutByPackageNameClassName(packageReq);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶了ﾼﺾ뇀돂雄꿆ꛈ맊만곎ꓐ꟒韔껖觘뫚뻜듞胠蓢胤ꧦ裨蛪裬곮鷰鋲蛴蓶럸髺郼髾", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1910505472;
			short num3 = num;
			return pbbappShortcutByPackageNameClassName;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00017EA0 File Offset: 0x000160A0
		public string DownLoadAstroPackage(global::System.Guid packageUuids)
		{
			int a_ = 13;
			short num;
			for (;;)
			{
				num = (short)1780088832;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)698351617;
					if (num != 0)
					{
					}
					num = (short)1352621494;
					short num3 = num;
					num = (short)1627217334;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_AC;
					}
					goto Block_1;
				}
				}
			}
			Block_1:
			num = (short)1650262016;
			short num4 = num;
			IL_AC:
			num = (short)356777984;
			if (num != 0)
			{
			}
			string result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_ED;
				}
				int num2;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage astropackage;
				string a_2;
				for (;;)
				{
					IL_CE:
					switch (num2)
					{
					case 0:
						goto IL_1B8;
					case 1:
					{
						global::System.Guid? fileUuid = astropackage.FileUuid;
						num = (short)708182020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (astropackage != null)
						{
							num = (short)556793857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BA;
					case 3:
					{
						global::System.Guid? fileUuid = astropackage.FileUuid;
						byte[] fileContent = this.GetFileContent(fileUuid.Value);
						result = this.a(fileContent, global::System.IO.Path.GetTempFileName(), a_2);
						num = (short)1453916160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Guid? fileUuid;
						if (fileUuid != null)
						{
							num = (short)399769603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BA;
					}
					case 5:
						goto IL_1D9;
					}
					goto IL_ED;
					IL_1BA:
					result = string.Empty;
					num = (short)1592393733;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B8:
				IL_1D9:
				return result;
				IL_ED:
				astropackage = (this.RMServer.GetPackage(packageUuids) as global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage);
				a_2 = this.a(astropackage);
				num = (short)1916600322;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_CE;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯\udbb3솵횷펻\udfbd꒿菁럃닅뫇ꗉ鳋꿍돏맑뗓뇕뷗", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			return result;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000180D8 File Offset: 0x000162D8
		public global::System.Collections.Generic.List<string> DownLoadPcrPackage(global::System.Collections.Generic.List<global::System.Guid> packageUuids)
		{
			int a_ = 17;
			short num;
			global::System.Collections.Generic.List<string> result;
			try
			{
				for (;;)
				{
					num = (short)1209597952;
					switch (num)
					{
					default:
					{
						num = (short)1466785110;
						short num2 = num;
						num = (short)93543766;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_5A;
						}
						break;
					}
					}
				}
				IL_5A:
				num = (short)1274675200;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				using (global::System.Collections.Generic.List<global::System.Guid>.Enumerator enumerator = packageUuids.GetEnumerator())
				{
					num = (short)1022885889;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_CC;
							}
							continue;
						case 2:
						{
							string a_2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udca7잩\udcab풯\uddb1쎳\ud8b5풷햹\uddbb\udabd龿", a_) + global::System.Guid.NewGuid().ToString().Replace(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("薧", a_), "");
							global::Motorola.CommonCPS.Server.EntityModel.PCRPackage pcrpackage;
							global::System.Guid? fileUuid = pcrpackage.FileUuid;
							byte[] fileContent = this.GetFileContent(fileUuid.Value);
							string tempFileName = global::System.IO.Path.GetTempFileName();
							string item = this.a(fileContent, tempFileName, a_2);
							list.Add(item);
							num = (short)162594816;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.CommonCPS.Server.EntityModel.PCRPackage pcrpackage;
							global::System.Guid? fileUuid = pcrpackage.FileUuid;
							num = (short)796786694;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2046230536;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Guid packageUuid = enumerator.Current;
							global::Motorola.CommonCPS.Server.EntityModel.PCRPackage pcrpackage = this.RMServer.GetPackage(packageUuid) as global::Motorola.CommonCPS.Server.EntityModel.PCRPackage;
							num = (short)1761345541;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.PCRPackage pcrpackage;
							if (pcrpackage != null)
							{
								num = (short)493551619;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1AA;
						}
						case 6:
						{
							global::System.Guid? fileUuid;
							if (fileUuid != null)
							{
								num = (short)819462146;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1AA;
						}
						case 8:
							num = (short)354615305;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_27D;
						}
						IL_114:
						num = (short)914817028;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CC:
						goto IL_114;
						IL_1AA:
						list.Add(string.Empty);
						num = (short)354091015;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_27D:;
				}
				result = list;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳ힷ춹튻꾿ꏁꃃ雅ꯇ룉鳋꿍돏맑뗓뇕뷗", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)686620672;
			short num4 = num;
			num = (short)83165185;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00018430 File Offset: 0x00016630
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRPackageSummary> GetPCRUpgradePackages(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ListPCRUpgradePackageFilter> filters)
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRPackageSummary> result;
			try
			{
				num = (short)2103441178;
				short num2 = num;
				num = (short)1601435418;
				switch (num2 == num)
				{
				}
				num = (short)340721664;
				if (num != 0)
				{
				}
				result = this.d.ListPCRUpgradeFirmwarePackages(filters);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵첷ﾻ閿닁ꏃ듅꧇껉꧋黍뇏뇑뿓럕뿗뿙꿛", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1028915200;
			short num3 = num;
			num = (short)348979201;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00018530 File Offset: 0x00016730
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> GetMatchedReferenceRadiosForUpgrade(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid PCRFirmwareCodeplugGroupUuid, bool isAllowDowngrade, int startIndex, int count)
		{
			int a_ = 9;
			short num;
			global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> upgradeMatchedMatrixRadios;
			try
			{
				num = (short)2082799617;
				if (num != 0)
				{
				}
				num = (short)753972512;
				short num2 = num;
				num = (short)1146336544;
				switch (num2 == num)
				{
				}
				num = (short)1238433792;
				if (num != 0)
				{
				}
				upgradeMatchedMatrixRadios = this.d.GetUpgradeMatchedMatrixRadios(matrixTemplateUuidList, PCRFirmwareCodeplugGroupUuid, isAllowDowngrade, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫햯욱욵\udfb7좹\uddbb\udabdꖿ迁ꗃ닅ꯇꋉ꧋꫍鷏돑ꃓꓕ뇗ꋙ軛뿝蓟诡诣闥", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2111766528;
			short num3 = num;
			return upgradeMatchedMatrixRadios;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00018634 File Offset: 0x00016834
		public int GetUpgradeMatchedMatrixRadiosCount(global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList, global::System.Guid pcrFWGroupUuid, bool isAllowDowngrade)
		{
			int a_ = 3;
			short num;
			int upgradeMatchedMatrixRadiosCount;
			try
			{
				num = (short)1041137282;
				short num2 = num;
				num = (short)18972290;
				switch (num2 == num)
				{
				}
				num = (short)1164181504;
				if (num != 0)
				{
				}
				upgradeMatchedMatrixRadiosCount = this.d.GetUpgradeMatchedMatrixRadiosCount(matrixTemplateUuidList, pcrFWGroupUuid, isAllowDowngrade);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쾩\ud8abﮭ삯햱욳ힵ\udcb7\udfb9\udfbd뒿ꇁ곃ꏅ곇蟉귋뫍ꋏ믑곓蓕맗뻙뗛뇝鏟ꇡ诣鏥蛧黩", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)950599680;
			short num3 = num;
			num = (short)274268161;
			if (num != 0)
			{
			}
			return upgradeMatchedMatrixRadiosCount;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00018738 File Offset: 0x00016938
		public global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair GetMatchedPCRFirmwareCodeplugPair(global::System.Guid pairGroupUuid, string modelNo, string tanapaNo)
		{
			int a_ = 12;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair matchedPCRFirmwareCodeplugPair;
			try
			{
				num = (short)1918869438;
				short num2 = num;
				num = (short)311926718;
				switch (num2 == num)
				{
				}
				num = (short)406978560;
				if (num != 0)
				{
				}
				matchedPCRFirmwareCodeplugPair = this.d.GetMatchedPCRFirmwareCodeplugPair(pairGroupUuid, modelNo, tanapaNo);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴襁\ud8b8쾺\udebcힾ꓀Ꟃ闄蓆鯈跊꓌뷎볐ꓒ듔ꗖ볘飚닜믞蓠鏢觤鋦軨믪賬蛮菰", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1988427776;
			short num3 = num;
			num = (short)1126170625;
			if (num != 0)
			{
			}
			return matchedPCRFirmwareCodeplugPair;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001883C File Offset: 0x00016A3C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair> FindPCRUpgradePackagesForVersion(string codeplugVersion, string firmwareVersion, string modelNumber, string tanapaNo, int region)
		{
			int a_ = 7;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair> result;
			try
			{
				num = (short)1491470417;
				short num2 = num;
				num = (short)234358865;
				switch (num2 == num)
				{
				}
				num = (short)823853056;
				if (num != 0)
				{
				}
				result = this.d.FindPCRUpgradePackagesForVersion(codeplugVersion, firmwareVersion, modelNumber, tanapaNo, region);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩잭\udeaf횱첻\ud9bd늿ꏁꃃꏅ飇ꯉ꿋ꗍ뇏뗑뇓ꗕ黗뗙껛裝藟郡韣迥蟧蓩", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1232994304;
			short num3 = num;
			num = (short)1345126401;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00018940 File Offset: 0x00016B40
		public global::System.Guid SaveNewTemplateForUpgrade(global::Motorola.CommonCPS.Server.EntityModel.Template temp)
		{
			int a_ = 19;
			short num;
			global::System.Guid result;
			try
			{
				num = (short)516291071;
				short num2 = num;
				num = (short)857864703;
				switch (num2 == num)
				{
				}
				num = (short)1751252992;
				if (num != 0)
				{
				}
				result = this.d.SaveNewTemplateForUpgrade(temp);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﺷ펹튻\udabd邿臁雃鏅룇귉뻋꿍듏럑蓓럕믗뇙뷛망藟釡ꋣ觥髧볩觫鳭華鯱鯳飵", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)992673792;
			short num3 = num;
			num = (short)512557057;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00018A44 File Offset: 0x00016C44
		public global::EntityModel.GenericModel.CFSUpdateResult ApplyUpdatedTemplateToRadio(global::System.Guid radioUuid, global::System.Guid templateGuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, byte[] response, global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, global::System.Collections.Generic.Dictionary<string, object> syncData = null)
		{
			int a_ = 18;
			short num;
			global::EntityModel.GenericModel.CFSUpdateResult result;
			try
			{
				num = (short)1375743978;
				short num2 = num;
				num = (short)685387754;
				switch (num2 == num)
				{
				}
				num = (short)1954742273;
				if (num != 0)
				{
				}
				num = (short)1957494784;
				if (num != 0)
				{
				}
				result = this.d.ApplyUpdatedTemplateToRadio(radioUuid, templateGuid, featureList, response, batchJobContainerUuid, entitySet, syncData);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴킸햺\ud9bc苀釂郄럆껈맊곌ꯎ듐菒듔듖님뫚뫜뫞鋠ꗢ諤闦뿨軪鿬鳮飰鳲鯴", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)513081344;
			short num3 = num;
			return result;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00018B50 File Offset: 0x00016D50
		public global::EntityModel.GenericModel.CFSUpdateResult RegisterLicenseToRadio(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid)
		{
			int a_ = 8;
			short num;
			global::EntityModel.GenericModel.CFSUpdateResult result;
			try
			{
				num = (short)904119995;
				short num2 = num;
				num = (short)1028441787;
				switch (num2 == num)
				{
				}
				num = (short)51576832;
				if (num != 0)
				{
				}
				result = this.d.RegisterLicenseToRadio(radioUuid, featureList, isSubmit, response, batchJobContainerUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪욮\udfb0ힲ춼\ud8be돀ꋂꇄꋆ駈꫊껌꓎냐듒냔ꓖ鿘듚꿜觞蓠釢雤軦蛨藪", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)317194240;
			short num3 = num;
			num = (short)1234632705;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00018C54 File Offset: 0x00016E54
		public global::EntityModel.GenericModel.CFSUpdateResult RegisterLicenseToCMSC(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> featureList, bool isSubmit, byte[] response, global::System.Guid batchJobContainerUuid)
		{
			int a_ = 8;
			short num;
			global::EntityModel.GenericModel.CFSUpdateResult result;
			try
			{
				num = (short)1166430094;
				short num2 = num;
				num = (short)1144999822;
				switch (num2 == num)
				{
				}
				num = (short)2107768832;
				if (num != 0)
				{
				}
				result = this.d.RegisterLicenseToCMSC(radioUuid, featureList, isSubmit, response, batchJobContainerUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪욮\udfb0ힲ춼\ud8be돀ꋂꇄꋆ駈꫊껌꓎냐듒냔ꓖ鿘듚꿜觞蓠釢雤軦蛨藪", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1328087040;
			short num3 = num;
			num = (short)1670381569;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00018D5C File Offset: 0x00016F5C
		public global::EntityModel.GenericModel.CFSUpdateResult RecoverCMSCFeatures(global::System.Guid radioId, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> features, string hostID, byte[] targetFlashCode, byte[] capacityResponse)
		{
			int a_ = 9;
			short num;
			global::EntityModel.GenericModel.CFSUpdateResult result;
			try
			{
				num = (short)262206395;
				short num2 = num;
				num = (short)236712891;
				switch (num2 == num)
				{
				}
				num = (short)826146816;
				if (num != 0)
				{
				}
				result = this.RMServer.RecoverCMSCFeatures(radioId, features, hostID, targetFlashCode, capacityResponse);
			}
			catch (global::System.ServiceModel.FaultException<global::Motorola.Common.CustomException.CommonExceptionData> faultException)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫ﲭ햯톱\udbb3삵\uddb7좹\udfbd꒿ꯁꯃ胅귇ꯉ룋믍ꋏ럑ꟓ", a_), faultException, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(faultException);
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫ﲭ햯톱\udbb3삵\uddb7좹\udfbd꒿ꯁꯃ胅귇ꯉ룋믍ꋏ럑ꟓ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j, ex);
			}
			num = (short)1418788864;
			short num3 = num;
			num = (short)1658585089;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00018E8C File Offset: 0x0001708C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListAvailableRadioForPurchase(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, int startIndex, int count, int featureType = 0)
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> result;
			try
			{
				num = (short)1972913851;
				short num2 = num;
				num = (short)149046971;
				switch (num2 == num)
				{
				}
				num = (short)1259143168;
				if (num != 0)
				{
				}
				result = this.d.ListAvailableRadioForPurchase(groupUUID, filter, startIndex, count, null, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮ﶰ\udab2운쎶춺\udcbc횾귀ꋂꟄꯆ곈駊곌ꯎ룐볒鏔룖ꯘ诚꣜귞苠询蓤铦賨", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1141833728;
			short num3 = num;
			num = (short)926744577;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00018F94 File Offset: 0x00017194
		public int GetAvailableRadioForPurchaseCount(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, int startIndex, int count, int featureType = 0)
		{
			int a_ = 13;
			short num;
			int availableRadioForPurchaseCount;
			try
			{
				num = (short)986987282;
				short num2 = num;
				num = (short)825441042;
				switch (num2 == num)
				{
				}
				num = (short)1143799809;
				if (num != 0)
				{
				}
				num = (short)1233453056;
				if (num != 0)
				{
				}
				availableRadioForPurchaseCount = this.d.GetAvailableRadioForPurchaseCount(groupUUID, filter, null, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯ﺱ\uddb3억첷﮹쪻\udfbdꦿ껁ꗃ꓅꓇꿉黋꿍듏믑믓郕럗꣙賛ꯝ鋟臡賣蟥鯧迩", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)917962752;
			short num3 = num;
			return availableRadioForPurchaseCount;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00019098 File Offset: 0x00017298
		public int GetAvailableRadioForPurchaseCount(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0)
		{
			int a_ = 17;
			short num;
			int availableRadioForPurchaseCount;
			try
			{
				num = (short)1756871701;
				short num2 = num;
				num = (short)666287125;
				switch (num2 == num)
				{
				}
				num = (short)981598208;
				if (num != 0)
				{
				}
				availableRadioForPurchaseCount = this.d.GetAvailableRadioForPurchaseCount(groupUUID, filter, selectedSerialNumbers, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹ﶻ좽ꆿꯁꣃꟅ꫇ꛉ꧋鳍뇏뛑뷓맕黗뗙껛軝闟郡蟣軥觧駩觫귭鿯蟱髳苵", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2042888192;
			short num3 = num;
			num = (short)1284505601;
			if (num != 0)
			{
			}
			return availableRadioForPurchaseCount;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001919C File Offset: 0x0001739C
		public global::System.Collections.Generic.List<string> ListFeatureMatchedRadios(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, global::System.Collections.Generic.List<string> selectedSerialNumbers, string searchString)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.List<string> result;
			try
			{
				num = (short)145760817;
				short num2 = num;
				num = (short)1491411505;
				switch (num2 == num)
				{
				}
				num = (short)840761344;
				if (num != 0)
				{
				}
				result = this.d.ListFeatureMatchedRadios(groupUUID, filter, string.Empty, selectedSerialNumbers);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧얫\uddad쒯톳ힵ첷쾹캻\udbbd趿ꏁ냃ꗅꃇ꿉꣋鳍뇏뛑뷓맕ꯗ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)527499264;
			short num3 = num;
			num = (short)232849409;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000192A0 File Offset: 0x000174A0
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListAvailableCMSCForPurchase(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, int startIndex, int count, int featureType = 0)
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> result;
			try
			{
				num = (short)273866145;
				short num2 = num;
				num = (short)742972833;
				switch (num2 == num)
				{
				}
				num = (short)1185153024;
				if (num != 0)
				{
				}
				result = this.d.ListAvailableCMSCForPurchase(groupUUID, filter, startIndex, count, null, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲領\udeb6쪸쾺ﲼ즾ꃀꫂ꧄ꛆꯈꟊ꣌賎鳐胒雔釖뛘꧚跜꫞鏠胢跤蛦髨軪", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)921108480;
			short num3 = num;
			num = (short)1559429121;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x000193A8 File Offset: 0x000175A8
		public int GetAvailableCMSCForPurchaseCount(global::System.Guid? groupUUID, global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter filter, global::System.Collections.Generic.List<string> selectedSerialNumbers, int featureType = 0)
		{
			int a_ = 5;
			short num;
			int availableCMSCForPurchaseCount;
			try
			{
				num = (short)1088748195;
				short num2 = num;
				num = (short)1151466147;
				switch (num2 == num)
				{
				}
				num = (short)423362561;
				if (num != 0)
				{
				}
				num = (short)1649934336;
				if (num != 0)
				{
				}
				availableCMSCForPurchaseCount = this.d.GetAvailableCMSCForPurchaseCount(groupUUID, filter, null, featureType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧얫\uddad쒯슳ힵ톷횹\uddbb\udcbd겿ꟁ蟃诅鯇觉請ꇍꋏ苑ꇓꓕ믗닙뷛귝藟ꇡ诣鏥蛧黩", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)502071296;
			short num3 = num;
			return availableCMSCForPurchaseCount;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x000194AC File Offset: 0x000176AC
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ApplyTemplateToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid templateUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate radioInfo, string batchOpName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, bool returnTemplate = true, bool returnRadioBase = true)
		{
			int a_ = 8;
			short num;
			global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> result;
			try
			{
				num = (short)1730322409;
				short num2 = num;
				num = (short)1338744809;
				switch (num2 == num)
				{
				}
				num = (short)427163648;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.ApplyTemplateBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.ApplyTemplateBatchJobParameter(batchJobContainerUuid, templateUuid, radioInfo, batchOpName, entitySet, returnTemplate, returnRadioBase);
				result = this.RMServer.ApplyTemplateToRadio(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪\udfae솰\udfb2체\udcb8횺춼펾ꃀ럂ꃄ鏆ꛈ駊곌ꯎ룐볒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)303104000;
			short num3 = num;
			num = (short)5439489;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000195BC File Offset: 0x000177BC
		public global::Motorola.CommonCPS.Server.EntityModel.Radio CreateTempRadioForCompare(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			int a_ = 15;
			short num = (short)1499070464;
			short num2 = num;
			num = (short)456794964;
			short num3 = num;
			num = (short)139928404;
			global::Motorola.CommonCPS.Server.EntityModel.Radio result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1698496512;
				if (num != 0)
				{
				}
				num = (short)831455233;
				if (num != 0)
				{
				}
				result = radio;
				try
				{
					result = this.RMServer.CreateTempRadioForCompare(radio);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱쒵\uddb7\udbb9좻\udbbd钿ꟁ꧃뛅髇ꯉ꣋ꟍ뿏铑믓ꓕ鯗뗙뇛껝臟郡臣", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
				}
				break;
			}
			return result;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000196C0 File Offset: 0x000178C0
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadio(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioBatchJobParameter para)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_5D;
			}
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummary;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)719585292;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)224788481;
					if (num2 != 0)
					{
					}
					num2 = (short)569376781;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (radio != null)
					{
						num2 = (short)249036805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EB;
				case 3:
					goto IL_1A8;
				case 4:
					if (radio != null)
					{
						num2 = (short)757399562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A8;
				case 5:
					num2 = (short)1142161416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (radioSummary != null)
					{
						num2 = (short)1400832016;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				case 7:
					goto IL_254;
				case 8:
					if (radio.WorkingCodeplug != null)
					{
						num2 = (short)1184563201;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EB;
				case 9:
					try
					{
						radioSummary = this.RMServer.ImportBatchRadio(para);
						goto IL_304;
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记者\ud8b4잶횸즺즼ꃀꟂ계꣆", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
					}
					goto IL_220;
					IL_304:
					num2 = (short)488964102;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힤욦춨슪슬辮솰튲잴횶馸튺캼龾꿀곂뇄ꟈ뻊ꇌꏎ", a_));
					num2 = (short)106692611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욤좦잨춪쒬좮醰튲\udbb4펶馸ﾺﾼ껀Ꟃꃄꃈ룊ꇎ뻐꟒맖곘럚뇜", a_));
					num2 = (short)410976271;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (radio.WorkingCodeplug.Configuration.DBNode != null)
					{
						num2 = (short)1447755787;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EB;
				case 13:
					if (radio.WorkingCodeplug.Configuration != null)
					{
						num2 = (short)357105664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EB;
				case 14:
					goto IL_1A3;
				case 15:
					goto IL_EB;
				case 16:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힤슦\udda8\udeaa\udfac솮醰솲풴펶킸풺鶼횾닀ꯄ꣆뷈ꏌ뫎뷐뿒", a_));
					num2 = (short)598802446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_5D;
				IL_EB:
				radioSummary = null;
				num2 = (short)1513357321;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1A8:
				num2 = (short)27197442;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_220:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힤슦\udda8\udeaa\udfac솮醰솲풴펶킸풺鶼횾닀ꯄ닆ꗈꟊ", a_));
				num2 = (short)1159725063;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1A3:
			return radioSummary;
			IL_254:
			num2 = (short)144965632;
			short num3 = num2;
			return radioSummary;
			IL_5D:
			radio = para.Radio;
			num2 = (short)1784532483;
			short num4 = num2;
			num2 = (short)1905118723;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_13;
			default:
			{
				num2 = (short)1179910144;
				if (num2 != 0)
				{
				}
				num2 = (short)649396228;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00019A98 File Offset: 0x00017C98
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpdateCodeplugPassword(global::Motorola.CommonCPS.Server.EntityModel.PasswordInfo pwdInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)2006112692;
				short num2 = num;
				num = (short)1226496436;
				switch (num2 == num)
				{
				}
				num = (short)1171128320;
				if (num != 0)
				{
				}
				result = this.RMServer.UpdateCodeplugPassword(pwdInfo, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱钳좷\udeb9\uddbb쪽ꖿ臁ꯃꋅ귇뫉ꃋ믍럏苑뗓ꗕꯗ귙돛곝蓟", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1306984448;
			short num3 = num;
			num = (short)1247936513;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00019B98 File Offset: 0x00017D98
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary AddRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio newRadio)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)1814376174;
				short num2 = num;
				num = (short)587607790;
				switch (num2 == num)
				{
				}
				num = (short)1276182528;
				if (num != 0)
				{
				}
				result = this.RMServer.AddRadio(newRadio);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢쎦춨寧첬쮮\ud8b0\udcb2", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)322699264;
			short num3 = num;
			num = (short)2021588993;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00019C98 File Offset: 0x00017E98
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary UpgradeAPXTemplateLanguagePack(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary templateInfo, global::System.Guid LPGuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary> entitySummaryList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList)
		{
			int a_ = 10;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary result;
			try
			{
				num = (short)1989706305;
				short num2 = num;
				num = (short)1937146433;
				switch (num2 == num)
				{
				}
				num = (short)2000158720;
				if (num != 0)
				{
				}
				result = this.RMServer.UpgradeAPXTemplateLanguagePack(batchJobContainerUuid, templateInfo, LPGuid, entitySummaryList, validateSetList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬类솰풲잴횶\uddb8\udebaﲼ駀韂ꃄ꫆마ꟊ곌믎듐鿒듔맖뻘껚볜룞蓠돢蓤蓦苨", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1469972480;
			short num3 = num;
			num = (short)1439301633;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00019D9C File Offset: 0x00017F9C
		public global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack GetLatestASTROLPPackagesByFirmwareVersion(string firmwareVersion, string LPID)
		{
			int a_ = 13;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack latestASTROLPPackagesByFirmwareVersion;
			try
			{
				num = (short)811785138;
				short num2 = num;
				num = (short)1985010610;
				switch (num2 == num)
				{
				}
				num = (short)608108545;
				if (num != 0)
				{
				}
				num = (short)851509248;
				if (num != 0)
				{
				}
				latestASTROLPPackagesByFirmwareVersion = this.RMServer.GetLatestASTROLPPackagesByFirmwareVersion(firmwareVersion, LPID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯톳습\udbb9좻\udbbd뎿뛁藃闅鳇飉菋苍胏苑뗓뗕돗믙믛믝鏟ꃡ鷣ꃥ臧飩臫駭釯胱釳ꃵ鷷裹迻韽濿氁", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1446182912;
			short num3 = num;
			return latestASTROLPPackagesByFirmwareVersion;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00019E9C File Offset: 0x0001809C
		public bool DeletePackage(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary packageUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySetList)
		{
			int a_ = 2;
			short num;
			bool result;
			try
			{
				num = (short)173670401;
				if (num != 0)
				{
				}
				num = (short)1174385220;
				short num2 = num;
				num = (short)580891204;
				switch (num2 == num)
				{
				}
				num = (short)741343232;
				if (num != 0)
				{
				}
				result = this.RMServer.DeleteBatchPackage(batchJobContainerUuid, packageUuid, entitySetList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨잪좬\udbae풰풴풶트\udaba\udabc\udabe", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1397358592;
			short num3 = num;
			return result;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00019F9C File Offset: 0x0001819C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary CancelJob(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			int a_ = 13;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)230222927;
				short num2 = num;
				num = (short)1466756175;
				switch (num2 == num)
				{
				}
				num = (short)1569783808;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.CancelJobBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.CancelJobBatchJobParameter(batchJobContainerUuid, entitySummary, validateSet);
				result = this.RMServer.CancelJob(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯햳\ud8b5\udbb7\udfb9킻꾿ꃁ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1616969728;
			short num3 = num;
			num = (short)107544577;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0001A0A4 File Offset: 0x000182A4
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary CompleteJob(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary entitySummary, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			int a_ = 8;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)1475267324;
				short num2 = num;
				num = (short)1685048060;
				switch (num2 == num)
				{
				}
				num = (short)61997057;
				if (num != 0)
				{
				}
				num = (short)1236992000;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.CompleteJobBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.CompleteJobBatchJobParameter(batchJobContainerUuid, entitySummary, validateSet);
				result = this.RMServer.CompleteJob(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪삮\udcb0쎲\ud9b4튶춸\udeba킾ꏀ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)662437888;
			short num3 = num;
			return result;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0001A1AC File Offset: 0x000183AC
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadioList(global::System.Collections.Generic.IList<global::System.Guid> radioIdList, bool isDeep = false)
		{
			int a_ = 17;
			short num = (short)1899036672;
			switch (num)
			{
			default:
			{
				num = (short)1576861696;
				short num2 = num;
				int num3 = 1000;
				int num4 = 0;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio>();
				try
				{
					num = (short)273809410;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>> list2;
						int num9;
						switch (num5)
						{
						case 0:
							num4++;
							num = (short)1385562124;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							try
							{
								num = (short)849018881;
								num5 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)898963021;
									short num6 = num;
									num = (short)576329293;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1810366464;
										if (num != 0)
										{
										}
										switch (num5)
										{
										case 0:
										{
											global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>>.Enumerator enumerator;
											if (!enumerator.MoveNext())
											{
												goto IL_2D2;
											}
											global::System.Collections.Generic.List<global::System.Guid> radioUuidList = enumerator.Current;
											global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> radioList = this.RMServer.GetRadioList(radioUuidList, isDeep);
											list.AddRange(radioList);
											num = (short)1204224002;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											switch (0)
											{
											case 0:
												goto IL_274;
											}
											continue;
										case 3:
											num = (short)1742536708;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_306;
										}
										IL_2B1:
										num = (short)1533280256;
										num5 = (int)((global::System.IntPtr)num);
										continue;
										IL_274:
										goto IL_2B1;
									}
									IL_2D2:
									num = (short)483000323;
									num5 = (int)((global::System.IntPtr)num);
								}
								IL_306:
								goto IL_5F9;
							}
							finally
							{
								global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_319;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C3;
							}
							continue;
						case 3:
						{
							if (num4 == 0)
							{
								num = (short)1187119109;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>>.Enumerator enumerator = list2.GetEnumerator();
							num = (short)1292959745;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_5BC;
						case 5:
							goto IL_319;
						case 6:
							goto IL_5BC;
						case 7:
							goto IL_5F9;
						case 8:
							goto IL_571;
						case 9:
							if (radioIdList.Count % num3 != 0)
							{
								num = (short)1837105152;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E6;
						case 10:
						{
							global::System.Collections.Generic.List<global::System.Guid> list3;
							try
							{
								num = (short)838008837;
								num5 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num5)
									{
									case 0:
									{
										int num7;
										int num8;
										if (num7 < num8 + num3)
										{
											num = (short)779288585;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_425;
									}
									case 1:
									{
										int num7;
										int num8;
										if (num7 >= num8)
										{
											num = (short)1883504642;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_425;
									}
									case 2:
										num = (short)539361280;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_425;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_3A4;
										}
										continue;
									case 6:
									{
										int num7;
										num7++;
										num = (short)1381498884;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										int num7;
										int num8;
										if (num7 <= num8 + num3)
										{
											num = (short)518389766;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4E7;
									}
									case 8:
										goto IL_4E7;
									case 9:
									{
										global::System.Guid item;
										list3.Add(item);
										num = (short)1725038595;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										goto IL_4FF;
									case 11:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Guid> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1584594952;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Guid item = enumerator2.Current;
										num = (short)1158610945;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_3A4;
									IL_425:
									num = (short)324993031;
									num5 = (int)((global::System.IntPtr)num);
									continue;
									IL_4AB:
									num = (short)14417931;
									num5 = (int)((global::System.IntPtr)num);
									continue;
									IL_3A4:
									goto IL_4AB;
									IL_4E7:
									num = (short)285212682;
									num5 = (int)((global::System.IntPtr)num);
								}
								IL_4FF:
								goto IL_18C;
							}
							finally
							{
								num = (short)425066496;
								num5 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Guid> enumerator2;
									switch (num5)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_537;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)1090322434;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_56E;
									}
									IL_537:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)99483649;
									num5 = (int)((global::System.IntPtr)num);
								}
								IL_56E:;
							}
							goto IL_571;
							IL_18C:
							list2.Add(list3);
							num9++;
							num = (short)991559684;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							num = (short)1946288131;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_E6;
						case 13:
							goto IL_612;
						case 14:
						{
							if (num9 >= num4)
							{
								num = (short)1728905227;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num8 = num9 * num3;
							global::System.Collections.Generic.List<global::System.Guid> list3 = new global::System.Collections.Generic.List<global::System.Guid>();
							int num7 = 0;
							global::System.Collections.Generic.IEnumerator<global::System.Guid> enumerator2 = radioIdList.GetEnumerator();
							num = (short)1056440330;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_C3:
						if (radioIdList.Count > num3)
						{
							num = (short)1929314312;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E6:
						list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>>();
						num9 = 0;
						num = (short)2056585222;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_319:
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> radioList2 = this.RMServer.GetRadioList(radioIdList, isDeep);
						list.AddRange(radioList2);
						num = (short)1846870023;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_571:
						num4 = radioIdList.Count / num3;
						num = (short)228524041;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_5BC:
						num = (short)1855127566;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_5F9:
						num = (short)1092288525;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_612:;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹\udfbd꒿ꯁꯃ諅ꇇ막룋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
				}
				num = (short)904396801;
				if (num != 0)
				{
				}
				return list;
			}
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001A874 File Offset: 0x00018A74
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadiosForOtarProfileValidation(global::System.Collections.Generic.IList<global::System.Guid> radioIdList, int pageSize = 50)
		{
			int a_ = 7;
			short num = (short)338821120;
			switch (num)
			{
			default:
			{
				num = (short)23920641;
				if (num != 0)
				{
				}
				int num2 = 0;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio>();
				try
				{
					num = (short)621674500;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_E1;
						case 1:
							num2++;
							num = (short)1432748032;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_3B0;
						case 3:
							try
							{
								num = (short)137822212;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_4F6;
									case 1:
										num = (short)1836908544;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_4A2;
									case 3:
									{
										global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)277676033;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.List<global::System.Guid> radioUuidList = enumerator.Current;
										global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> radiosForOtarProfileValidation = this.RMServer.GetRadiosForOtarProfileValidation(radioUuidList);
										list.AddRange(radiosForOtarProfileValidation);
										num = (short)93257730;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_41C;
										}
										continue;
									}
									goto IL_41C;
									IL_4A2:
									num = (short)1391460355;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_41C:
									num = (short)965787873;
									short num4 = num;
									num = (short)887013601;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_4A2;
									default:
										num = (short)581173248;
										if (num != 0)
										{
										}
										goto IL_4A2;
									}
								}
								IL_4F6:
								goto IL_5EC;
							}
							finally
							{
								global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_509;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_BC;
							}
							continue;
						case 5:
							goto IL_509;
						case 6:
							if (radioIdList.Count % pageSize != 0)
							{
								num = (short)573374465;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E1;
						case 7:
							num2 = radioIdList.Count / pageSize;
							num = (short)927399942;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_605;
						case 9:
						{
							global::System.Collections.Generic.List<global::System.Guid> list2;
							try
							{
								num = (short)701759489;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::System.Guid item;
										list2.Add(item);
										num = (short)996409354;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1E2;
										}
										continue;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Guid> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1673592835;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Guid item = enumerator2.Current;
										num = (short)2017591304;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_323;
									case 4:
									{
										int num5;
										int num6;
										if (num5 <= num6 + pageSize)
										{
											num = (short)1290469382;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_323;
									}
									case 5:
										goto IL_33C;
									case 6:
									{
										int num5;
										num5++;
										num = (short)445644809;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										num = (short)586809355;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										int num5;
										int num6;
										if (num5 >= num6)
										{
											num = (short)1169752071;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2E4;
									}
									case 10:
										goto IL_2E4;
									case 11:
									{
										int num5;
										int num6;
										if (num5 < num6 + pageSize)
										{
											num = (short)858521600;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2E4;
									}
									}
									IL_21B:
									num = (short)155451394;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1E2:
									goto IL_21B;
									IL_2E4:
									num = (short)1284177924;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_323:
									num = (short)895942661;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_33C:
								goto IL_160;
							}
							finally
							{
								num = (short)1193017346;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::System.Guid> enumerator2;
									switch (num3)
									{
									case 0:
										goto IL_3AD;
									case 1:
										enumerator2.Dispose();
										num = (short)1035337728;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_374;
										}
										continue;
									}
									IL_374:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)2100756481;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_3AD:;
							}
							goto IL_3B0;
							IL_160:
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>> list3;
							list3.Add(list2);
							int num7;
							num7++;
							num = (short)548732933;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_509;
						case 11:
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>> list3;
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>>.Enumerator enumerator = list3.GetEnumerator();
							num = (short)1596653571;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							goto IL_5EC;
						case 13:
						{
							int num7;
							if (num7 >= num2)
							{
								num = (short)1491009547;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::System.Guid> list2 = new global::System.Collections.Generic.List<global::System.Guid>();
							int num6 = num7 * pageSize;
							int num5 = 0;
							global::System.Collections.Generic.IEnumerator<global::System.Guid> enumerator2 = radioIdList.GetEnumerator();
							num = (short)1588133897;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
						{
							if (num2 == 0)
							{
								num = (short)1547829250;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>> list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Guid>>();
							int num7 = 0;
							num = (short)233832458;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_BC:
						if (radioIdList.Count > pageSize)
						{
							num = (short)1756037127;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E1:
						num = (short)153288718;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B0:
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> radiosForOtarProfileValidation2 = this.RMServer.GetRadiosForOtarProfileValidation(radioIdList);
						list.AddRange(radiosForOtarProfileValidation2);
						num = (short)1623785484;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_509:
						num = (short)1208156173;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_5EC:
						num = (short)1347420168;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_605:;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯햳튵톷햹쾻꾿냁诃닅꧇룉鳋볍뿏듑뷓뫕뷗賙뷛닝觟蛡藣鋥臧藩苫", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
				}
				num = (short)1515716608;
				short num8 = num;
				return list;
			}
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0001AF30 File Offset: 0x00019130
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadio(global::System.Guid radioId, bool isDeep = false)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
			try
			{
				num = (short)917241857;
				if (num != 0)
				{
				}
				num = (short)1165233990;
				short num2 = num;
				num = (short)1167068998;
				switch (num2 == num)
				{
				}
				num = (short)752287744;
				if (num != 0)
				{
				}
				radio = this.RMServer.GetRadio(radioId, isDeep);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢슦\udda8寧첬쮮\ud8b0\udcb2", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1513816064;
			short num3 = num;
			return radio;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001B034 File Offset: 0x00019234
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SelectLanguagePacksForPCR(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.EntitySummary templateInfo, global::System.Collections.Generic.List<global::System.Guid> selectedLanguagePacks, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary> entitySummaryList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList)
		{
			int a_ = 19;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary result;
			try
			{
				num = (short)1130897075;
				short num2 = num;
				num = (short)1885281971;
				switch (num2 == num)
				{
				}
				num = (short)1463877632;
				if (num != 0)
				{
				}
				result = this.RMServer.SelectLanguagePacksForPCR(batchJobContainerUuid, templateInfo, selectedLanguagePacks, entitySummaryList, validateSetList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵\udfb9킻\udbbdꎿ뛁裃Ʂꛇ귉맋꿍럏럑蓓럕믗뇙꿛飝迟郡듣ꗥ뫧", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)718340097;
			if (num != 0)
			{
			}
			num = (short)162332672;
			short num3 = num;
			return result;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0001B13C File Offset: 0x0001933C
		public global::Motorola.CommonCPS.Server.EntityModel.Package ImportPackage(global::Motorola.CommonCPS.Server.EntityModel.Package packageReq)
		{
			int a_ = 2;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Package result;
			try
			{
				num = (short)926590815;
				short num2 = num;
				num = (short)500410207;
				switch (num2 == num)
				{
				}
				num = (short)509607937;
				if (num != 0)
				{
				}
				num = (short)1028456448;
				if (num != 0)
				{
				}
				result = this.RMServer.ImportPackage(packageReq);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤쒨\udbaa슬\uddae얰풴풶트\udaba\udabc\udabe", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2142175232;
			short num3 = num;
			return result;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001B23C File Offset: 0x0001943C
		public global::Motorola.CommonCPS.Server.EntityModel.PackageSummary ImportBatchPackage(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Package package, string jobDescription)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PackageSummary result;
			try
			{
				num = (short)1033477886;
				short num2 = num;
				num = (short)1974836990;
				switch (num2 == num)
				{
				}
				num = (short)1383399425;
				if (num != 0)
				{
				}
				num = (short)1372454912;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.ImportPackageBatchJobParameter importPackageBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.ImportPackageBatchJobParameter(batchJobContainerUuid, package);
				importPackageBatchJobParameter.JobDescription = jobDescription;
				result = this.RMServer.ImportBatchPackage(importPackageBatchJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쎭삯\uddb1욳습覆\udbb9좻\uddbdꢿ鋁ꗃꗅꏇꯉꯋꯍ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)777977856;
			short num3 = num;
			return result;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001B34C File Offset: 0x0001954C
		public global::Motorola.CommonCPS.Server.EntityModel.PackageSummary ImportBatchAstroFirmware(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware> packages, string jobDescription)
		{
			int a_ = 19;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PackageSummary result;
			try
			{
				num = (short)717221694;
				short num2 = num;
				num = (short)930869054;
				switch (num2 == num)
				{
				}
				num = (short)573636608;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.ImportPackageBatchJobParameter importPackageBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.ImportPackageBatchJobParameter(batchJobContainerUuid, packages);
				importPackageBatchJobParameter.JobDescription = jobDescription;
				result = this.RMServer.ImportBatchAstroFirmware(importPackageBatchJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ힹ첻톽늿뛁蛃Ʂ볇꧉꓋黍뇏뇑뿓럕뿗뿙", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)754515969;
			if (num != 0)
			{
			}
			num = (short)1556021248;
			short num3 = num;
			return result;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001B458 File Offset: 0x00019658
		public global::Motorola.CommonCPS.Server.EntityModel.Package PackageExist(global::Motorola.CommonCPS.Server.EntityModel.Package software)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Package result;
			try
			{
				num = (short)2005779521;
				short num2 = num;
				num = (short)1247265857;
				switch (num2 == num)
				{
				}
				num = (short)1842544640;
				if (num != 0)
				{
				}
				result = this.RMServer.PackageExist(software);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩ﲫ쾭펯\ud9b1햳통\uddb7ﾹ쒻ힽ뎿뛁", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1243938817;
			if (num != 0)
			{
			}
			num = (short)2131689472;
			short num3 = num;
			return result;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001B558 File Offset: 0x00019758
		public global::Motorola.CommonCPS.Server.EntityModel.PackageSummary UpdatePackage(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageColumns column)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PackageSummary result;
			try
			{
				num = (short)684373841;
				short num2 = num;
				num = (short)1527101265;
				switch (num2 == num)
				{
				}
				num = (short)1979449344;
				if (num != 0)
				{
				}
				result = this.RMServer.UpdatePackage(summary, column);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩嶺\udead풯펱삳펵\udbb9\udfbb햽ꆿꗁꇃ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1209925633;
			if (num != 0)
			{
			}
			num = (short)1845231616;
			short num3 = num;
			return result;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001B65C File Offset: 0x0001985C
		public global::Motorola.CommonCPS.Server.EntityModel.PackageSummary UpdatePBBPackage(global::Motorola.CommonCPS.Server.EntityModel.PackageSummary summary, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageColumns column)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PackageSummary result;
			try
			{
				num = (short)1458215179;
				short num2 = num;
				num = (short)1192139019;
				switch (num2 == num)
				{
				}
				num = (short)624361472;
				if (num != 0)
				{
				}
				result = this.RMServer.UpdatePBBPackage(summary, column);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢힦춨쪪\ud9ac쪮ﾶ횸횺\ud8bc꓀럂", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1715339265;
			if (num != 0)
			{
			}
			num = (short)926941184;
			short num3 = num;
			return result;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001B75C File Offset: 0x0001995C
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary EditTemplate(global::System.Guid templateUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet)
		{
			int a_ = 6;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary result;
			try
			{
				num = (short)1496786932;
				short num2 = num;
				num = (short)1820993524;
				switch (num2 == num)
				{
				}
				num = (short)548864001;
				if (num != 0)
				{
				}
				num = (short)192413696;
				if (num != 0)
				{
				}
				result = this.RMServer.EditTemplateFields(templateUuid, fieldValues, entitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨즬욮얰킴\udab6즸ힺ\udcbc쮾꓀", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1243742208;
			short num3 = num;
			return result;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001B860 File Offset: 0x00019A60
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SaveTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template temp, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet)
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary result;
			try
			{
				num = (short)1611650199;
				short num2 = num;
				num = (short)226677911;
				switch (num2 == num)
				{
				}
				num = (short)2078015488;
				if (num != 0)
				{
				}
				result = this.RMServer.SaveTemplate(temp, entitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫ﶭ톯쒱톳\uddb7ힹ첻튽ꆿ뛁ꇃ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)890175489;
			if (num != 0)
			{
			}
			num = (short)249233408;
			short num3 = num;
			return result;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001B960 File Offset: 0x00019B60
		public bool DeleteDevice(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 7;
			short num;
			bool result;
			try
			{
				num = (short)344497853;
				short num2 = num;
				num = (short)618307261;
				switch (num2 == num)
				{
				}
				num = (short)238026753;
				if (num != 0)
				{
				}
				num = (short)425197568;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.DeleteRadioBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.DeleteRadioBatchJobParameter(batchJobContainerUuid, radio.Uuid, validateEntitySet)
				{
					JobDescription = radio.SerialNumber
				};
				result = this.RMServer.DeleteRadio(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭\udcafힱ삳펵ﲷ\udfb9쪻ힽꎿꟁ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1180893184;
			short num3 = num;
			return result;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0001BA7C File Offset: 0x00019C7C
		public global::Motorola.CommonCPS.Server.EntityModel.MatrixKey AddMatrixKey(global::Motorola.CommonCPS.Server.EntityModel.MatrixKey key)
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.MatrixKey result;
			try
			{
				num = (short)1547363974;
				short num2 = num;
				num = (short)366601862;
				switch (num2 == num)
				{
				}
				num = (short)847314944;
				if (num != 0)
				{
				}
				result = this.RMServer.AddMatrixKey(key);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫풯횱靈ힵ첷좹햻욽访ꟁ뷃", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1109590017;
			if (num != 0)
			{
			}
			num = (short)923074560;
			short num3 = num;
			return result;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0001BB7C File Offset: 0x00019D7C
		public bool DeleteMatrixKey(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.MatrixKey key)
		{
			int a_ = 2;
			short num;
			bool result;
			try
			{
				num = (short)1701101035;
				short num2 = num;
				num = (short)1973665259;
				switch (num2 == num)
				{
				}
				num = (short)762707969;
				if (num != 0)
				{
				}
				num = (short)1211105280;
				if (num != 0)
				{
				}
				result = this.RMServer.DeleteMatrixKey(batchJobContainerUuid, key);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨잪좬\udbae풰ﺲ풴쎶쮸튺얼꓀뫂", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1400111104;
			short num3 = num;
			return result;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0001BC7C File Offset: 0x00019E7C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary DiscardCodeplugAndRadioFeatureChanges(global::System.Guid? batchJobContainerUuid, global::System.Guid radioUuid, string serialNumber, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> originalRadioFeature)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				for (;;)
				{
					IL_09:
					num = (short)2117009412;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)508879112;
						short num3 = num;
						num = (short)311353608;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)1173815296;
							if (num != 0)
							{
							}
							global::System.Guid batchJobContainerUuid2;
							switch (num2)
							{
							case 0:
								goto IL_129;
							case 1:
								batchJobContainerUuid2 = batchJobContainerUuid.Value;
								goto IL_F1;
							case 2:
								num = (short)202899457;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								batchJobContainerUuid2 = global::System.Guid.Empty;
								goto IL_F1;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_8F;
								}
								continue;
							}
							IL_8F:
							if (batchJobContainerUuid != null)
							{
								num = (short)67698690;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							num = (short)801112067;
							num2 = (int)((global::System.IntPtr)num);
							break;
							IL_F1:
							global::Motorola.CommonCPS.Server.EntityModel.DiscardCPRFChangesBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.DiscardCPRFChangesBatchJobParameter(batchJobContainerUuid2, radioUuid, set, originalRadioFeature)
							{
								JobDescription = serialNumber
							};
							result = this.RMServer.DiscardCodeplugAndRadioFeatureChanges(parameter);
							num = (short)1279983616;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
				IL_129:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩잭쎯톱햳쒵\udcb7惡펻\udabdꖿ닁ꣃ독꿇诉ꋋ꫍苏돑냓뿕럗鳙맛뿝铟韡難菥ꯧ苩跫胭韯韱蟳", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1733951489;
			if (num != 0)
			{
			}
			num = (short)781713408;
			short num4 = num;
			return result;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0001BE50 File Offset: 0x0001A050
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary DiscardCodeplugChanges(global::System.Guid? batchJobContainerUuid, global::System.Guid radioUuid, string serialNumber, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 3;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				for (;;)
				{
					IL_09:
					num = (short)1804140548;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1736042580;
						short num3 = num;
						num = (short)837740628;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
						{
							num = (short)1642790912;
							if (num != 0)
							{
							}
							num = (short)1061158913;
							if (num != 0)
							{
							}
							global::System.Guid batchJobContainerUuid2;
							switch (num2)
							{
							case 0:
								goto IL_14B;
							case 1:
								batchJobContainerUuid2 = batchJobContainerUuid.Value;
								goto IL_117;
							case 2:
								num = (short)1956118529;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								batchJobContainerUuid2 = global::System.Guid.Empty;
								goto IL_117;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_B5;
								}
								continue;
							}
							IL_B5:
							if (batchJobContainerUuid != null)
							{
								num = (short)1396441090;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							num = (short)434503683;
							num2 = (int)((global::System.IntPtr)num);
							break;
							IL_117:
							global::Motorola.CommonCPS.Server.EntityModel.DiscardCPChangesBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.DiscardCPChangesBatchJobParameter(batchJobContainerUuid2, radioUuid, set)
							{
								JobDescription = serialNumber
							};
							result = this.RMServer.DiscardCodeplugChanges(parameter);
							num = (short)363200512;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
				IL_14B:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쎩\udfab춭톯삱킳ힷ\udeb9\ud9bb캽겿럁ꏃ藅ꃇꯉꋋ꧍뗏ꇑ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)742850560;
			short num4 = num;
			return result;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0001C020 File Offset: 0x0001A220
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary Reset(global::System.Guid radioUuid, int? RadioID, int? CAI, string password, global::Motorola.CommonCPS.Server.EntityModel.LinkType? linkType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)273400879;
				short num2 = num;
				num = (short)1040172079;
				switch (num2 == num)
				{
				}
				num = (short)1731067904;
				if (num != 0)
				{
				}
				result = this.RMServer.Reset(radioUuid, RadioID, CAI, password, linkType, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\udcb8좺\ud8bc쮾", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)169213953;
			if (num != 0)
			{
			}
			num = (short)439615488;
			short num3 = num;
			return result;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001C12C File Offset: 0x0001A32C
		public global::Motorola.CommonCPS.Server.EntityModel.MatrixKey EditMatrixKey(global::System.Guid keyUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType keyType, object changedField, global::Motorola.CommonCPS.Server.CommonDBConstants.KeyFieldType fieldType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.MatrixKey result;
			try
			{
				num = (short)1710296945;
				short num2 = num;
				num = (short)939986801;
				switch (num2 == num)
				{
				}
				num = (short)965410816;
				if (num != 0)
				{
				}
				result = this.RMServer.EditKey(keyUuid, keyType, changedField, fieldType, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쪭\ud9af욱靈ힵ첷좹햻욽访ꟁ뷃", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1457192961;
			if (num != 0)
			{
			}
			num = (short)747634688;
			short num3 = num;
			return result;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0001C230 File Offset: 0x0001A430
		public global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary EditConfiguration(global::System.Guid configUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ConfigurationFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 10;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary result;
			try
			{
				num = (short)174704953;
				short num2 = num;
				num = (short)1934805305;
				switch (num2 == num)
				{
				}
				num = (short)329318400;
				if (num != 0)
				{
				}
				num = (short)1032126465;
				if (num != 0)
				{
				}
				result = this.RMServer.EditConfigurationSmmary(configUuid, fieldValues, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬햰\udab2솴횸햺\udbbc횾ꛀ뛂럄ꛆ뷈ꋊꋌꇎ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1135476736;
			short num3 = num;
			return result;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0001C334 File Offset: 0x0001A534
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditRadio(global::System.Guid radioUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 6;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)1739103269;
				short num2 = num;
				num = (short)520395813;
				switch (num2 == num)
				{
				}
				num = (short)124780545;
				if (num != 0)
				{
				}
				num = (short)1014235136;
				if (num != 0)
				{
				}
				result = this.RMServer.EditRadio(radioUuid, fieldValues, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨즬욮얰\udab4\ud9b6\udfb8튺\udabc쪾돀ꋂ뇄껆ꛈꗊ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)203030528;
			short num3 = num;
			return result;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0001C434 File Offset: 0x0001A634
		public global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary EditAPXRadioProfile(global::System.Guid radioUuid, global::System.Guid profileUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 12;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary result;
			try
			{
				num = (short)868193602;
				short num2 = num;
				num = (short)1076204866;
				switch (num2 == num)
				{
				}
				num = (short)630456320;
				if (num != 0)
				{
				}
				result = this.RMServer.EditAPXRadioProfile(radioUuid, profileUuid, fieldValues, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮ힲ\udcb4쎶ꃀꟂ계꣆駈맊ꋌ꧎룐뿒냔", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)535756801;
			if (num != 0)
			{
			}
			num = (short)130023424;
			short num3 = num;
			return result;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0001C538 File Offset: 0x0001A738
		public global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary EditAPXRadioSystem(global::System.Guid radioUuid, global::System.Guid systemUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 2;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary result;
			try
			{
				num = (short)1334921866;
				short num2 = num;
				num = (short)836913802;
				switch (num2 == num)
				{
				}
				num = (short)399704064;
				if (num != 0)
				{
				}
				result = this.RMServer.EditAPXRadioSystem(radioUuid, systemUuid, fieldValues, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤춨슪\ud9ac횶\uddb8튺튼룀냂뇄ꋆ꓈", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1603731457;
			if (num != 0)
			{
			}
			num = (short)2023227392;
			short num3 = num;
			return result;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0001C63C File Offset: 0x0001A83C
		public global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO EditASTROOTARProfile(global::System.Guid radioUuid, global::System.Guid otarUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 10;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO result;
			try
			{
				num = (short)9365356;
				short num2 = num;
				num = (short)1239476076;
				switch (num2 == num)
				{
				}
				num = (short)1439825920;
				if (num != 0)
				{
				}
				result = this.RMServer.EditAPXOtarProfiles(radioUuid, otarUuid, fieldValues, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬햰\udab2솴軀韂蓄闆駈맊ꋌ꧎룐뿒냔", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)633339905;
			if (num != 0)
			{
			}
			num = (short)2098724864;
			short num3 = num;
			return result;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0001C73C File Offset: 0x0001A93C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary RadioIdentityTransfer(global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> transferRadioIdentityRecords, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet)
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)702349313;
				if (num != 0)
				{
				}
				num = (short)779426451;
				short num2 = num;
				num = (short)1453464211;
				switch (num2 == num)
				{
				}
				num = (short)1139212288;
				if (num != 0)
				{
				}
				result = this.RMServer.RadioIdentityTransfer(radioUuid, transferRadioIdentityRecords, entitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\udcb7펹좻ﾽ邿髁雃Ʂ곇ꏉꏋ鷍ꧏꇑꃓ돕뗗", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1878392832;
			short num3 = num;
			return result;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0001C838 File Offset: 0x0001AA38
		public bool DeleteTemplate(global::System.Guid? batchJobContainerUuid, global::System.Guid templateUuid, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set, string templateName = null)
		{
			int a_ = 10;
			short num;
			bool result;
			try
			{
				num = (short)2005977674;
				short num2 = num;
				num = (short)400083530;
				switch (num2 == num)
				{
				}
				num = (short)2009071616;
				if (num != 0)
				{
				}
				result = this.RMServer.DeleteTemplate(batchJobContainerUuid, templateUuid, set, templateName);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰\udfb2킴쎶\udcb8\ud8bc튾뇀꿂꓄돆곈", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)786104321;
			if (num != 0)
			{
			}
			num = (short)1922236416;
			short num3 = num;
			return result;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0001C93C File Offset: 0x0001AB3C
		public void UpdateCodeplugAndLicense(string operationGuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> radioList, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>> radioFeatureRequestList, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList)
		{
			short num = (short)1963686972;
			short num2 = num;
			num = (short)1657109564;
			switch (num2 == num)
			{
			default:
			{
				num = (short)714014720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)609681409;
			if (num != 0)
			{
			}
			num = (short)813957120;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		public void SubmitRadioFeaturesForRadios(global::System.Guid operationGuid, global::System.Collections.Generic.IList<global::System.Guid> templateUuids, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> sets)
		{
			short num = (short)188711938;
			short num2 = num;
			num = (short)1811514370;
			switch (num2 == num)
			{
			default:
			{
				num = (short)759234560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1013776385;
			if (num != 0)
			{
			}
			num = (short)1985019904;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0001CA94 File Offset: 0x0001AC94
		public void RecoverCodeplugAndLicense(string operationGuid, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> radioList, global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>> radioFeatureRequestList, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet> validateSetList)
		{
			short num = (short)1811230312;
			short num2 = num;
			num = (short)211299944;
			switch (num2 == num)
			{
			default:
			{
				num = (short)307625984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1969684481;
			if (num != 0)
			{
			}
			num = (short)525336576;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0001CB3C File Offset: 0x0001AD3C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template> GetTemplateListByNameList(global::System.Collections.Generic.List<string> templateNameList)
		{
			int a_ = 19;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template> result;
			try
			{
				num = (short)1846637785;
				short num2 = num;
				num = (short)2023912665;
				switch (num2 == num)
				{
				}
				num = (short)1889796096;
				if (num != 0)
				{
				}
				result = this.RMServer.ListTemplateByName(templateNameList, true);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻ꖿ꿁듃꫅꧇뻉꧋苍맏ꇑꃓ铕ꇗ铙뷛돝藟껡跣闥鳧", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1669791745;
			if (num != 0)
			{
			}
			num = (short)1945174016;
			short num3 = num;
			return result;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0001CC40 File Offset: 0x0001AE40
		public void DeleteFile(global::System.Guid fileUuid)
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)1828247917;
				short num2 = num;
				num = (short)430627181;
				switch (num2 == num)
				{
				}
				num = (short)735444992;
				if (num != 0)
				{
				}
				this.RMServer.DeleteFile(fileUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵풷\udfb9좻\udbbd蚿ꯁꣃꏅ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1878261761;
			if (num != 0)
			{
			}
			num = (short)635633664;
			short num3 = num;
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0001CD40 File Offset: 0x0001AF40
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob AddBatchJob(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job)
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob result;
			try
			{
				num = (short)1637534782;
				short num2 = num;
				num = (short)2060700734;
				switch (num2 == num)
				{
				}
				num = (short)452722688;
				if (num != 0)
				{
				}
				result = this.RMServer.AddBatchJob(job);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\udcb7\udeb9ﺻ\udfbd뒿ꇁ곃賅Ꟈ꣉", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1952514049;
			if (num != 0)
			{
			}
			num = (short)1218838528;
			short num3 = num;
			return result;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0001CE3C File Offset: 0x0001B03C
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer AddBatchJobContainer(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer job)
		{
			int a_ = 4;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer result;
			try
			{
				num = (short)620016495;
				short num2 = num;
				num = (short)103854959;
				switch (num2 == num)
				{
				}
				num = (short)627507200;
				if (num != 0)
				{
				}
				result = this.RMServer.AddBatchJobContainer(job);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦쾪즬킰잲횴\udfb6풺\udfbcﲾ껀귂뇄ꛆꃈꗊ꣌뷎", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1806172161;
			if (num != 0)
			{
			}
			num = (short)1002504192;
			short num3 = num;
			return result;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0001CF3C File Offset: 0x0001B13C
		public void CancelBatchJobContainerByUser(global::System.Guid batchJobContainerUuid)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)1968258388;
				short num2 = num;
				num = (short)1292189012;
				switch (num2 == num)
				{
				}
				num = (short)539492353;
				if (num != 0)
				{
				}
				num = (short)1389756416;
				if (num != 0)
				{
				}
				this.RMServer.CancelBatchJobContainerByUser(batchJobContainerUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲횶ힸ\ud8ba\ud8bc펾菀ꋂ뇄꓆ꇈ臊ꋌ귎鋐볒믔ꏖ룘닚돜뫞鏠ꇢ鳤닦髨軪鿬", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)474677248;
			short num3 = num;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0001D03C File Offset: 0x0001B23C
		public bool DeleteConfiguration(global::System.Guid batchJobContainerUuid, global::System.Guid configUuid, string configName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet, global::System.Collections.Generic.List<string> SharedSets)
		{
			int a_ = 0;
			short num;
			bool result;
			try
			{
				num = (short)765191090;
				short num2 = num;
				num = (short)191161266;
				switch (num2 == num)
				{
				}
				num = (short)1871577088;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.DeleteConfigurationBatchJobParameter deleteConfigurationBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.DeleteConfigurationBatchJobParameter(batchJobContainerUuid, configUuid, validateEntitySet);
				deleteConfigurationBatchJobParameter.SharedSets = SharedSets;
				deleteConfigurationBatchJobParameter.JobDescription = configName;
				result = this.RMServer.DeleteConfiguationInJob(deleteConfigurationBatchJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢슦얨캪\ud9ac쪮\udcb2\udbb4톶킸\udcba좼\udebe뗀ꫂ꫄꧆", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)294322177;
			if (num != 0)
			{
			}
			num = (short)710410240;
			short num3 = num;
			return result;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0001D154 File Offset: 0x0001B354
		public bool DeleteConfiguration(global::System.Guid configUuid, string configName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet, global::System.Collections.Generic.List<string> SharedSets)
		{
			int a_ = 19;
			short num;
			bool result;
			try
			{
				num = (short)1548971784;
				short num2 = num;
				num = (short)1928968;
				switch (num2 == num)
				{
				}
				num = (short)1565261824;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.DeleteConfigurationBatchJobParameter deleteConfigurationBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.DeleteConfigurationBatchJobParameter(global::System.Guid.Empty, configUuid, validateEntitySet);
				deleteConfigurationBatchJobParameter.SharedSets = SharedSets;
				deleteConfigurationBatchJobParameter.JobDescription = configName;
				result = this.RMServer.DeleteConfiguation(deleteConfigurationBatchJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﲷ\udfb9킻\udbbd뒿ꟁ蟃꧅ꛇ곉ꗋ꧍ꗏ돑ꃓ뿕럗듙", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1965228033;
			if (num != 0)
			{
			}
			num = (short)30343168;
			short num3 = num;
			return result;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0001D270 File Offset: 0x0001B470
		public global::Motorola.CommonCPS.Server.EntityModel.Configuration AddConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Configuration configration)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Configuration result;
			try
			{
				num = (short)952285044;
				short num2 = num;
				num = (short)386578292;
				switch (num2 == num)
				{
				}
				num = (short)1313210368;
				if (num != 0)
				{
				}
				result = this.RMServer.AddConfiguration(configration);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\uddb8\udfbaﺼ킾꿀ꗂ계ꃆ볈맊곌믎룐볒믔", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)189136897;
			if (num != 0)
			{
			}
			num = (short)1687158784;
			short num3 = num;
			return result;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0001D370 File Offset: 0x0001B570
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Configuration, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>> AddConfiguration(global::Motorola.CommonCPS.Server.EntityModel.Configuration configration, global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData)
		{
			int a_ = 1;
			short num;
			global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Configuration, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>> result;
			try
			{
				num = (short)931868890;
				short num2 = num;
				num = (short)672018650;
				switch (num2 == num)
				{
				}
				num = (short)868941824;
				if (num != 0)
				{
				}
				result = this.RMServer.AddDefConfiguration(configration, saveData);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣첧캩솭\udeaf풱\uddb3통춷좹\uddbb쪽ꦿ귁꫃", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1751580673;
			if (num != 0)
			{
			}
			num = (short)249102336;
			short num3 = num;
			return result;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001D470 File Offset: 0x0001B670
		public global::System.Collections.Generic.IDictionary<string, int> GetSetCount(global::System.Collections.Generic.List<string> setTypeList)
		{
			int a_ = 10;
			short num;
			global::System.Collections.Generic.IDictionary<string, int> setCountOfSetType;
			try
			{
				num = (short)1165970524;
				short num2 = num;
				num = (short)1634290780;
				switch (num2 == num)
				{
				}
				num = (short)525533184;
				if (num != 0)
				{
				}
				setCountOfSetType = this.RMServer.GetSetCountOfSetType(setTypeList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲\ud8b6춸ힺ\udcbcﲾ껀뛂ꯄ돆诈닊黌꫎ꗐ蟒곔Ꟗ볘", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)376373249;
			if (num != 0)
			{
			}
			num = (short)406519808;
			short num3 = num;
			return setCountOfSetType;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001D570 File Offset: 0x0001B770
		public global::System.Collections.Generic.IDictionary<string, int> GetSetCount(global::System.Collections.Generic.List<string> setTypeList, global::System.Guid parentId)
		{
			int a_ = 8;
			short num;
			global::System.Collections.Generic.IDictionary<string, int> setCountOfSetTypeAndParentId;
			try
			{
				num = (short)783067069;
				short num2 = num;
				num = (short)323397565;
				switch (num2 == num)
				{
				}
				num = (short)2120286208;
				if (num != 0)
				{
				}
				setCountOfSetTypeAndParentId = this.RMServer.GetSetCountOfSetTypeAndParentId(parentId, setTypeList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰\udab4쎶햸\udabaﺼ킾듀귂뇄藆냈飊꣌믎藐꫒ꗔ닖", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1130823681;
			if (num != 0)
			{
			}
			num = (short)941686784;
			short num3 = num;
			return setCountOfSetTypeAndParentId;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0001D670 File Offset: 0x0001B870
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> GetConfigurations(int startIndex, int pageSize)
		{
			int a_ = 9;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> result;
			try
			{
				num = (short)2079345619;
				short num2 = num;
				num = (short)1428245459;
				switch (num2 == num)
				{
				}
				num = (short)331546624;
				if (num != 0)
				{
				}
				num = (short)247660545;
				if (num != 0)
				{
				}
				result = this.RMServer.ListConfigurations(startIndex, pageSize, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫햯욱\ud9b5횷\udcb9햻\ud9bd떿냁ꗃ닅ꇇꗉꋋ뷍", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)772014080;
			short num3 = num;
			return result;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001D774 File Offset: 0x0001B974
		public bool IsConfiguationReadOnly(global::System.Guid guid)
		{
			int a_ = 7;
			short num;
			bool result;
			try
			{
				num = (short)350812115;
				short num2 = num;
				num = (short)1938487251;
				switch (num2 == num)
				{
				}
				num = (short)1764491264;
				if (num != 0)
				{
				}
				result = this.RMServer.IsConfiguationReadOnly(guid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯\udbb3\ud8b5\udeb7펹\udbbb쮽늿ꏁ냃꿅Ꟈ꓉뿋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1800470529;
			if (num != 0)
			{
			}
			num = (short)1078067200;
			short num3 = num;
			return result;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001D874 File Offset: 0x0001BA74
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ListMatchedConfigurations(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? fm, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses.FilterParameter_OfListCompatibleConfiguration filterParameter, int startIndex, int pageSize)
		{
			int a_ = 4;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> result;
			try
			{
				num = (short)1290534913;
				if (num != 0)
				{
				}
				num = (short)2014931680;
				short num2 = num;
				num = (short)1250257632;
				switch (num2 == num)
				{
				}
				num = (short)2032795648;
				if (num != 0)
				{
				}
				result = this.RMServer.ListMatchedConfigurations(fm, filterParameter, startIndex, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9ac\udeb0\uddb2펴\udeb6\udeb8캺쾼\udebe뗀ꫂ꫄꧆뫈", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)933888000;
			short num3 = num;
			return result;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001D978 File Offset: 0x0001BB78
		public int GetMatchedConfigurationCount(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? fm, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ParameterClasses.FilterParameter_OfListCompatibleConfiguration filterParameter)
		{
			int a_ = 14;
			short num;
			int matchedConfigurationCount;
			try
			{
				num = (short)1269318805;
				short num2 = num;
				num = (short)2041201813;
				switch (num2 == num)
				{
				}
				num = (short)761200641;
				if (num != 0)
				{
				}
				num = (short)890699776;
				if (num != 0)
				{
				}
				matchedConfigurationCount = this.RMServer.GetMatchedConfigurationCount(fm, filterParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶視풺펼\ud9beꣀ꓂냄뗆꣈뿊꓌ꃎ뿐ꃒ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1017315328;
			short num3 = num;
			return matchedConfigurationCount;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001DA78 File Offset: 0x0001BC78
		public global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary GetConfigurationSummaryById(global::System.Guid configUuid)
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary configurationSummaryById;
			try
			{
				num = (short)278057646;
				short num2 = num;
				num = (short)1014157998;
				switch (num2 == num)
				{
				}
				num = (short)2068119552;
				if (num != 0)
				{
				}
				configurationSummaryById = this.RMServer.GetConfigurationSummaryById(configUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫햯욱\ud9b5횷\udcb9햻\ud9bd떿냁ꗃ닅ꇇꗉꋋ뷍", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2069495809;
			if (num != 0)
			{
			}
			num = (short)2072903680;
			short num3 = num;
			return configurationSummaryById;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0001DB78 File Offset: 0x0001BD78
		public global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary GetConfigurationSummaryByName(string configName)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary configurationSummaryByName;
			try
			{
				num = (short)1979501394;
				short num2 = num;
				num = (short)960940882;
				switch (num2 == num)
				{
				}
				num = (short)1953431552;
				if (num != 0)
				{
				}
				configurationSummaryByName = this.RMServer.GetConfigurationSummaryByName(configName);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\udcb8쾺ﺼ킾꿀ꗂ계ꃆ볈맊곌믎룐볒믔ꓖ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1672806401;
			if (num != 0)
			{
			}
			num = (short)1743847424;
			short num3 = num;
			return configurationSummaryByName;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001DC78 File Offset: 0x0001BE78
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ListConfigurationsSetAssignedTo(global::System.Guid topSetUuid, int startIndex, int pageSize)
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> result;
			try
			{
				num = (short)1546028182;
				short num2 = num;
				num = (short)1101563030;
				switch (num2 == num)
				{
				}
				num = (short)1446182912;
				if (num != 0)
				{
				}
				result = this.RMServer.ListConfigurationsSetAssignedTo(topSetUuid, startIndex, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱\udfb5쮷캹ﾻ톽꺿꓁귃ꇅ뷇룉귋뫍맏뷑뫓ꗕ诗뿙꣛鿝鏟釡跣臥蛧迩裫뫭鿯", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2024144897;
			if (num != 0)
			{
			}
			num = (short)1589116928;
			short num3 = num;
			return result;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001DD7C File Offset: 0x0001BF7C
		public int GetConfigurationsSetAssignedToCount(global::System.Guid topSetUuid)
		{
			int a_ = 18;
			short num;
			int configurationsSetAssignedTo;
			try
			{
				num = (short)132638588;
				short num2 = num;
				num = (short)1177741180;
				switch (num2 == num)
				{
				}
				num = (short)1132593152;
				if (num != 0)
				{
				}
				configurationsSetAssignedTo = this.RMServer.GetConfigurationsSetAssignedTo(topSetUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\udcb8쾺ﺼ킾꿀ꗂ계ꃆ볈맊곌믎룐볒믔ꓖ諘뻚꧜點鋠郢賤胦蟨軪觬믮黰냲髴苶韸迺", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)419692545;
			if (num != 0)
			{
			}
			num = (short)1705771008;
			short num3 = num;
			return configurationsSetAssignedTo;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001DE7C File Offset: 0x0001C07C
		public global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetSetSummary(global::System.Guid setUuid)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RecordSummary dbrecordSummaryByUuid;
			try
			{
				num = (short)436345800;
				short num2 = num;
				num = (short)614079432;
				switch (num2 == num)
				{
				}
				num = (short)1251540992;
				if (num != 0)
				{
				}
				dbrecordSummaryByUuid = this.RMServer.GetDBRecordSummaryByUuid(setUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\udcb8쾺寮ﶾ鏀ꛂꛄ꣆믈꿊黌뫎볐뻒듔ꗖꃘ駚ꓜ諞铠諢臤", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)82837505;
			if (num != 0)
			{
			}
			num = (short)927793152;
			short num3 = num;
			return dbrecordSummaryByUuid;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001DF7C File Offset: 0x0001C17C
		public global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetSetSummary(string setType, string setName)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RecordSummary dbrecordSummaryByTypeAndName;
			try
			{
				num = (short)109530598;
				short num2 = num;
				num = (short)295521766;
				switch (num2 == num)
				{
				}
				num = (short)999751680;
				if (num != 0)
				{
				}
				dbrecordSummaryByTypeAndName = this.RMServer.GetDBRecordSummaryByTypeAndName(setType, setName);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯톳습쾹톻펽ꆿ냁뷃", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)964624385;
			if (num != 0)
			{
			}
			num = (short)1901658112;
			short num3 = num;
			return dbrecordSummaryByTypeAndName;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001E07C File Offset: 0x0001C27C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> GetSetSummaries(global::System.Collections.Generic.List<global::System.Guid> setUuids)
		{
			int a_ = 4;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> result;
			try
			{
				num = (short)712835072;
				switch (num)
				{
				default:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>();
					using (global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>>.Enumerator enumerator = this.RMServer.GetDBRecordFieldsByUuids(setUuids, null).GetEnumerator())
					{
						num = (short)1150550020;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)272275948;
							short num3 = num;
							num = (short)644520428;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)274202624;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)360054787;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>> keyValuePair = enumerator.Current;
									list.Add(keyValuePair.Key);
									num = (short)78184448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_150;
								case 3:
									num = (short)1332740098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_57;
								}
								goto IL_C9;
							}
							IL_57:
							switch (0)
							{
							case 0:
								IL_C9:
								goto IL_FC;
							}
							continue;
							IL_FC:
							num = (short)1896022017;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_150:;
					}
					result = list;
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9acﲮ풰잲슶풸횺\udcbc춾ꣀꛂ뛄", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)480772097;
			if (num != 0)
			{
			}
			num = (short)1360658432;
			short num4 = num;
			return result;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001E2A4 File Offset: 0x0001C4A4
		public global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetParantSetSummary(global::System.Guid setUuid)
		{
			int a_ = 14;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RecordSummary result;
			try
			{
				num = (short)798955394;
				short num2 = num;
				num = (short)1060050818;
				switch (num2 == num)
				{
				}
				num = (short)784728064;
				if (num != 0)
				{
				}
				result = this.RMServer.ListDBRecordParentById(setUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.RelationType.Contain).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶\udaba쾼\udebe꿀럂雄ꋆ뷈飊료ꋎ볐닒꟔껖", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)741998593;
			if (num != 0)
			{
			}
			num = (short)1903099904;
			short num3 = num;
			return result;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001E3AC File Offset: 0x0001C5AC
		public global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetTopSetSummary(string topSetType, global::System.Guid setUuid)
		{
			int a_ = 12;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.RecordSummary result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				int num;
				global::Motorola.CommonCPS.Server.EntityModel.RecordSummary recordSummary;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1777312466;
						short num3 = num2;
						num2 = (short)908894930;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_54;
						default:
							num2 = (short)1301348352;
							if (num2 != 0)
							{
							}
							result = recordSummary;
							num2 = (short)382074882;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_FB;
					case 2:
						goto IL_CD;
					case 3:
						if (recordSummary.RecordType == topSetType)
						{
							goto IL_54;
						}
						recordSummary = this.GetTopSetSummary(topSetType, new global::System.Guid(recordSummary.UUID));
						result = recordSummary;
						num2 = (short)119603201;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_29;
					IL_54:
					num2 = (short)2120351744;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_CD:
				IL_FB:
				goto IL_12A;
				IL_29:
				recordSummary = this.GetParantSetSummary(setUuid);
				num2 = (short)1825505283;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴횸쮺\udabe뗀郂냄꫆꓈꫊뿌뛎", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			IL_12A:
			num2 = (short)1582497793;
			if (num2 != 0)
			{
			}
			num2 = (short)1475346432;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0001E544 File Offset: 0x0001C744
		public string GetSetInfo(string setType)
		{
			short num = (short)494927872;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num3;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SetInfo setInfo;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					goto IL_135;
				case 1:
					if (setInfo != null)
					{
						goto IL_6F;
					}
					return setType;
				case 2:
					if (string.IsNullOrEmpty(setInfo.SetAlias))
					{
						num = (short)252968960;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 3:
				{
					num = (short)2092826625;
					if (num != 0)
					{
					}
					num = (short)1758733078;
					short num4 = num;
					num = (short)1145905942;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num = (short)1010958336;
						if (num != 0)
						{
						}
						num = (short)1042939906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_49;
				IL_6F:
				num = (short)721944579;
				num3 = (int)((global::System.IntPtr)num);
			}
			return setType;
			IL_135:
			return setType;
			IL_137:
			return setInfo.SetAlias;
			IL_49:
			setInfo = global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.NameMappingManager.Instance.GetSetInfo(setType);
			num = (short)523960321;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0001E690 File Offset: 0x0001C890
		public global::System.Collections.Generic.Dictionary<int, int> GetUsedOptionsOfConfiguration(global::System.Guid guid)
		{
			int a_ = 7;
			short num;
			global::System.Collections.Generic.Dictionary<int, int> usedOptionsOfConfiguration;
			try
			{
				num = (short)1068445399;
				short num2 = num;
				num = (short)795160279;
				switch (num2 == num)
				{
				}
				num = (short)432537600;
				if (num != 0)
				{
				}
				usedOptionsOfConfiguration = this.RMServer.GetUsedOptionsOfConfiguration(guid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯잳펵\udcb7첻쪽ꦿ귁꫃뗅蟇곉迋ꇍ뻏듑뷓뇕귗꣙뷛ꫝ觟跡諣", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1907359745;
			if (num != 0)
			{
			}
			num = (short)554827776;
			short num3 = num;
			return usedOptionsOfConfiguration;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0001E790 File Offset: 0x0001C990
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.List<int>>> GetUsedOptionsOfTopRecords(global::System.Collections.Generic.List<global::System.Guid> uuids, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily)
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::System.Collections.Generic.List<int>>> usedOptionsOfTopRecords;
			try
			{
				num = (short)1657504011;
				short num2 = num;
				num = (short)250839307;
				switch (num2 == num)
				{
				}
				num = (short)1776877568;
				if (num != 0)
				{
				}
				usedOptionsOfTopRecords = this.RMServer.GetUsedOptionsOfTopRecords(uuids, productFamily);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵첷쾻\udbbd꒿跁듃닅ꇇꗉꋋ뷍鿏듑胓맕꣗裙맛뷝迟郡胣闥", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1445003265;
			if (num != 0)
			{
			}
			num = (short)826408960;
			short num3 = num;
			return usedOptionsOfTopRecords;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001E894 File Offset: 0x0001CA94
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> GetDBRecordsTimeStamp(global::System.Collections.Generic.List<global::System.Guid> TopRecords_Uuids)
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> dbrecordsTimeStamp;
			try
			{
				num = (short)2136700502;
				short num2 = num;
				num = (short)2140239446;
				switch (num2 == num)
				{
				}
				num = (short)191692800;
				if (num != 0)
				{
				}
				dbrecordsTimeStamp = this.RMServer.GetDBRecordsTimeStamp(TopRecords_Uuids);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵첷ﺹﺻꖿꇁꯃ듅곇막飋ꟍ뷏럑蟓ꋕ맗럙곛", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1518600193;
			if (num != 0)
			{
			}
			num = (short)105971712;
			short num3 = num;
			return dbrecordsTimeStamp;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001E994 File Offset: 0x0001CB94
		public global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<string>>> GenerateDefaultSetName(global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, int>> setTypeList, bool generateForPreSharedKeys = false)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<string>>> result;
			try
			{
				num = (short)1268131801;
				short num2 = num;
				num = (short)361048025;
				switch (num2 == num)
				{
				}
				num = (short)245760000;
				if (num != 0)
				{
				}
				result = this.RMServer.GenerateDefaultSetName(setTypeList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨얪좬\uddae킰잲킴\udcb8\uddba\udcbc쪾귀럂雄ꋆ뷈藊곌ꋎ듐", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)63569921;
			if (num != 0)
			{
			}
			num = (short)166854656;
			short num3 = num;
			return result;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001EA94 File Offset: 0x0001CC94
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> GetSetSummaries(global::System.Guid? parentId, global::System.Collections.Generic.List<string> setTypeList, int startIndex, int pageSize)
		{
			int a_ = 1;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> result;
			try
			{
				num = (short)788005920;
				short num2 = num;
				num = (short)1063650336;
				switch (num2 == num)
				{
				}
				num = (short)1058734080;
				if (num != 0)
				{
				}
				result = this.RMServer.ListDBRecordSummaries(parentId, setTypeList, startIndex, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣솧\ud9a9\ud8ab톳햵ힷ좹\ud8bb떿꿁꧃Ʂ뫇ꏉ꧋뷍", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1792868353;
			if (num != 0)
			{
			}
			num = (short)159973376;
			short num3 = num;
			return result;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001EB9C File Offset: 0x0001CD9C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ListRelatedSetById(global::System.Guid setId, bool isRecursive = true)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> result;
			try
			{
				num = (short)423877908;
				short num2 = num;
				num = (short)1841618196;
				switch (num2 == num)
				{
				}
				num = (short)982908929;
				if (num != 0)
				{
				}
				num = (short)1196032000;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRelatedRecordById(setId, isRecursive);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧얫\uddad쒯톳\udab5\ud9b7캹\ud9bb\udabd鎿ꟁ냃蓅뇇菉꣋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1723006976;
			short num3 = num;
			return result;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> GetReferingSetSummaries(global::System.Guid setId, global::Motorola.CommonCPS.Server.CommonDBConstants.RelationType relationType)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> result;
			try
			{
				num = (short)2022187713;
				short num2 = num;
				num = (short)432612033;
				switch (num2 == num)
				{
				}
				num = (short)285409280;
				if (num != 0)
				{
				}
				result = this.RMServer.ListDBRecordParentById(setId, relationType);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧얫\uddad쒯\uddb7\ud9b9펻첽꒿釁뇃ꯅꗇꯉ뻋ꟍ뗏ꇑ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)490012673;
			if (num != 0)
			{
			}
			num = (short)1504575488;
			short num3 = num;
			return result;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001ED9C File Offset: 0x0001CF9C
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> ListDBRecordFields(global::System.Guid? parentUuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>>>> setTypesAndFieldName, int startIndex, int pageSize)
		{
			int a_ = 9;
			short num;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> result;
			try
			{
				num = (short)1097362236;
				short num2 = num;
				num = (short)674523964;
				switch (num2 == num)
				{
				}
				num = (short)922746880;
				if (num != 0)
				{
				}
				result = this.RMServer.ListDBRecordFields(parentUuid, setTypesAndFieldName, startIndex, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫\ud9af솱삳覆\ud9bb\uddbd꾿냁ꃃ胅ꇇ꿉ꃋ꫍ꏏ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)3342337;
			if (num != 0)
			{
			}
			num = (short)910622720;
			short num3 = num;
			return result;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001EE9C File Offset: 0x0001D09C
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>> GetDBRecordFieldsByUuid(global::System.Guid setUuid, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> fieldNameList)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>> result;
			try
			{
				num = (short)1587975641;
				short num2 = num;
				num = (short)886085081;
				switch (num2 == num)
				{
				}
				num = (short)1698037760;
				if (num != 0)
				{
				}
				result = this.RMServer.GetDBRecordFieldsByUuids(new global::System.Collections.Generic.List<global::System.Guid>
				{
					setUuid
				}, fieldNameList)[0];
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaa횲횴\ud8b6쮸\udfba﮼횾꓀꿂ꇄ듆诈닊飌뫎룐럒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1838022657;
			if (num != 0)
			{
			}
			num = (short)5111808;
			short num3 = num;
			return result;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		public global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> GetDBRecordsFieldsByUuids(global::System.Collections.Generic.List<global::System.Guid> setUuids, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, bool>> fieldNameList)
		{
			int a_ = 11;
			short num;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Field>>> dbrecordFieldsByUuids;
			try
			{
				num = (short)2111586936;
				short num2 = num;
				num = (short)475873912;
				switch (num2 == num)
				{
				}
				num = (short)553975808;
				if (num != 0)
				{
				}
				dbrecordFieldsByUuids = this.RMServer.GetDBRecordFieldsByUuids(setUuids, fieldNameList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳覆\ud9bb\uddbd꾿냁ꃃ胅ꇇ꿉ꃋ꫍ꏏ郑귓菕귗동룛귝", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1574109185;
			if (num != 0)
			{
			}
			num = (short)2094923776;
			short num3 = num;
			return dbrecordFieldsByUuids;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		public bool DeleteTelePortSet(global::System.Guid jbcUuid, global::System.Guid setUuid, string setName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 7;
			short num;
			bool result;
			try
			{
				num = (short)1854717853;
				short num2 = num;
				num = (short)184008605;
				switch (num2 == num)
				{
				}
				num = (short)1432682496;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.DeleteRecordBatchJobParameter deleteRecordBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.DeleteRecordBatchJobParameter(jbcUuid, setUuid, validateEntitySet);
				deleteRecordBatchJobParameter.JobDescription = setName;
				result = this.RMServer.DeleteDBRecordEx(deleteRecordBatchJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭\udcafힱ삳펵ﲷ\udbbdꎿ귁뛃ꋅ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1158807553;
			if (num != 0)
			{
			}
			num = (short)2115239936;
			short num3 = num;
			return result;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001F1C4 File Offset: 0x0001D3C4
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DatabaseSizeSummary GetDatabaseSizeSummary()
		{
			int a_ = 3;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DatabaseSizeSummary databaseSizeSummary;
			try
			{
				num = (short)2020236214;
				short num2 = num;
				num = (short)1769888694;
				switch (num2 == num)
				{
				}
				num = (short)524288;
				if (num != 0)
				{
				}
				databaseSizeSummary = this.RMServer.GetDatabaseSizeSummary();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쾩\ud8ab톯욱햳풵\ud9b7즹\ud9bbꦿ룁ꇃ闅뷇Ꟊꇋ꿍ꋏꯑ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)19333121;
			if (num != 0)
			{
			}
			num = (short)1313669120;
			short num3 = num;
			return databaseSizeSummary;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001F2C0 File Offset: 0x0001D4C0
		public global::Motorola.CommonCPS.Server.EntityModel.RecordSummary AddTelePortSet(global::Motorola.CommonCPS.Server.EntityModel.DBNode dbNode)
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RecordSummary result;
			try
			{
				num = (short)2017993000;
				short num2 = num;
				num = (short)654516520;
				switch (num2 == num)
				{
				}
				num = (short)1133903872;
				if (num != 0)
				{
				}
				result = this.RMServer.AddDBRecord(dbNode);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫풯횱\udfb9\udfbb톽늿ꛁ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1618935809;
			if (num != 0)
			{
			}
			num = (short)1827667968;
			short num3 = num;
			return result;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001F3BC File Offset: 0x0001D5BC
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ModifyDBRecords(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> result;
			try
			{
				num = (short)534274409;
				short num2 = num;
				num = (short)1129210217;
				switch (num2 == num)
				{
				}
				num = (short)1978269696;
				if (num != 0)
				{
				}
				byte[] compressedSaveData = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.SerializeAndZip<global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg>(saveData);
				result = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.DeserializeAndUnzip<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>>(this.RMServer.ModifyDBRecordsCmp(compressedSaveData));
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤욨쾪쒬즮좰\udcb8\ud8ba튼춾ꗀ냂", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1061093377;
			if (num != 0)
			{
			}
			num = (short)1626734592;
			short num3 = num;
			return result;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
		public global::Motorola.CommonCPS.Server.EntityModel.Configuration LoadConfiguration(string id)
		{
			int a_ = 4;
			global::Motorola.CommonCPS.Server.EntityModel.Configuration result;
			short num;
			for (;;)
			{
				result = null;
				try
				{
					result = this.RMServer.GetConfiguration(new global::System.Guid(id));
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦캪\ud9ac\udeb0\uddb2펴\udeb6\udeb8캺쾼\udebe뗀ꫂ꫄꧆", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
				}
				num = (short)226230996;
				short num2 = num;
				num = (short)79299284;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_82;
				}
			}
			IL_82:
			num = (short)1939668993;
			if (num != 0)
			{
			}
			num = (short)1254227968;
			short num3 = num;
			num = (short)1787166720;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001F5D4 File Offset: 0x0001D7D4
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode GetDBNodeContainedByConfiguration(global::System.Guid ConfigurationUuid, string TopSetType)
		{
			int a_ = 6;
			global::Motorola.CommonCPS.Server.EntityModel.DBNode result;
			short num;
			for (;;)
			{
				result = null;
				try
				{
					result = this.RMServer.GetDBNodeContainedByConfiguration(ConfigurationUuid, TopSetType);
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbae﮴\ud8b6\uddb8\udebaﺼ킾꿀럂꓄껆ꟈ껊꧌跎꣐郒뫔맖뿘닚뫜꫞鏠苢釤軦蛨藪", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
				}
				num = (short)484986594;
				short num2 = num;
				num = (short)400576226;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7E;
				}
			}
			IL_7E:
			num = (short)193593345;
			if (num != 0)
			{
			}
			num = (short)755105792;
			short num3 = num;
			num = (short)1763639296;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001F6D8 File Offset: 0x0001D8D8
		public global::System.Guid? GetWorkingConfigurationId(global::System.Guid radioId)
		{
			int a_ = 10;
			short num;
			global::System.Guid? workingConfigurationId;
			try
			{
				num = (short)377760147;
				short num2 = num;
				num = (short)1919560083;
				switch (num2 == num)
				{
				}
				num = (short)140181504;
				if (num != 0)
				{
				}
				workingConfigurationId = this.RMServer.GetWorkingConfigurationId(radioId);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲\ud8b6ힸ\uddba풼\ud8be듀뇂꓄돆ꃈ꓊ꏌ蛎뗐", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)502333441;
			if (num != 0)
			{
			}
			num = (short)1416429568;
			short num3 = num;
			return workingConfigurationId;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode GetDBRecord(global::System.Guid? uuid, bool recursive)
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.DBNode dbrecords;
			try
			{
				num = (short)1920055162;
				short num2 = num;
				num = (short)620017530;
				switch (num2 == num)
				{
				}
				num = (short)1992949760;
				if (num != 0)
				{
				}
				dbrecords = this.RMServer.GetDBRecords(new global::System.Collections.Generic.List<global::System.Guid>
				{
					uuid.Value
				}, recursive);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫햯욱\udfb9\udfbb톽늿ꛁ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1439367169;
			if (num != 0)
			{
			}
			num = (short)80805888;
			short num3 = num;
			return dbrecords;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001F8EC File Offset: 0x0001DAEC
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode GetDBRecords(global::System.Collections.Generic.List<global::System.Guid> uuidList, bool recursive)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.DBNode dbrecords;
			try
			{
				num = (short)1217689555;
				short num2 = num;
				num = (short)672757715;
				switch (num2 == num)
				{
				}
				num = (short)1402470401;
				if (num != 0)
				{
				}
				num = (short)1385889792;
				if (num != 0)
				{
				}
				dbrecords = this.RMServer.GetDBRecords(uuidList, recursive);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯\uddb7\ud9b9펻첽꒿뇁", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1224474624;
			short num3 = num;
			return dbrecords;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> GetDBRecordsSummaryListByParentAndChildFieldName(global::System.Collections.Generic.List<global::System.Guid> parent, string navigationFieldName, int startIndex, int pageSize)
		{
			int a_ = 11;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> result;
			try
			{
				num = (short)744646579;
				short num2 = num;
				num = (short)679700403;
				switch (num2 == num)
				{
				}
				num = (short)595263488;
				if (num != 0)
				{
				}
				result = this.RMServer.ListDBRecordSummaryByParentAndChildType(parent, navigationFieldName, startIndex, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳覆\ud9bb\uddbd꾿냁ꃃ뗅鯇뿉ꇋꏍ뇏ꃑ귓髕뇗꧙꣛鳝駟닡藣铥跧蓩飫꿭黯雱럳黵釷雹飻룽槿朁栃戅䘇欉愋欍", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1749221377;
			if (num != 0)
			{
			}
			num = (short)899612672;
			short num3 = num;
			return result;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0001FAF0 File Offset: 0x0001DCF0
		public global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetDBRecordSummaryListByParentAndChildFieldName(global::System.Guid parent, string navigationFieldName)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RecordSummary result;
			try
			{
				num = (short)545422693;
				short num2 = num;
				num = (short)1500872037;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> list;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AE:
					if (list == null)
					{
						goto IL_C7;
					}
					num = (short)2131951618;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1627521024;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					break;
				}
				for (;;)
				{
					IL_5D:
					switch (num3)
					{
					case 0:
						goto IL_11A;
					case 1:
						goto IL_13C;
					case 2:
						num = (short)1984233476;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_AE;
					case 4:
						if (list.Count == 0)
						{
							num = (short)1940127744;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = list[0];
						num = (short)1585905665;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_DD;
					}
					goto IL_7B;
				}
				IL_DD:
				goto IL_16B;
				IL_11A:
				goto IL_C7;
				IL_13C:
				goto IL_16B;
				IL_7B:
				list = this.RMServer.ListDBRecordSummaryByParentAndChildType(new global::System.Collections.Generic.List<global::System.Guid>
				{
					parent
				}, navigationFieldName, 0, int.MaxValue);
				num = (short)1273167875;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5D;
				IL_C7:
				result = null;
				num = (short)2076639237;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5D;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\udcb8쾺寮ﶾ鏀ꛂꛄ꣆믈꿊黌뫎볐뻒듔ꗖꃘ韚드곞闠ꇢ鳤럦裨駪裬臮藰닲鯴鏶뫸鏺铼鏾攀䔂氄戆攈漊䌌渎簐瘒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			IL_16B:
			num = (short)1771831297;
			if (num != 0)
			{
			}
			num = (short)1015349248;
			short num4 = num;
			return result;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001FCD8 File Offset: 0x0001DED8
		public global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary CopyConfiguration(global::System.Guid jobContainerUuid, global::System.Guid configUuid, string proposedConfigName, bool isDeep, string setSuffix, global::System.Collections.Generic.HashSet<string> sharableSetTypes)
		{
			int a_ = 14;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary result;
			try
			{
				num = (short)1504027729;
				short num2 = num;
				num = (short)1752278097;
				switch (num2 == num)
				{
				}
				num = (short)1966669825;
				if (num != 0)
				{
				}
				num = (short)853737472;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.CopyConfigurationArg arg = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.CopyConfigurationArg
				{
					ConfigurationUuid = configUuid,
					ProposedConfigName = proposedConfigName,
					ProposedSetSuffix = setSuffix,
					IsDeep = isDeep,
					SharableSetTypes = sharableSetTypes
				};
				global::Motorola.CommonCPS.Server.EntityModel.CopyConfigurationBatchJobParameter copyJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.CopyConfigurationBatchJobParameter(jobContainerUuid, proposedConfigName)
				{
					Arg = arg
				};
				result = this.RMServer.CopyConfiguration(copyJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记\udab4잶삸튼톾Ꟁꫂꋄ닆믈꫊만ꛎ뻐뷒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)620691456;
			short num3 = num;
			return result;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001FE14 File Offset: 0x0001E014
		public global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ImportConfiguration(global::System.Guid jobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Configuration config, global::Motorola.CommonCPS.Server.EntityModel.SyncData syncData, string setSuffix)
		{
			int a_ = 10;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary result;
			try
			{
				num = (short)1485570049;
				if (num != 0)
				{
				}
				num = (short)2091919969;
				short num2 = num;
				num = (short)1225730657;
				switch (num2 == num)
				{
				}
				num = (short)1807876096;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.ImportConfigurationBatchJobParameter importConfigurationBatchJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.ImportConfigurationBatchJobParameter(jobContainerUuid, config, syncData, setSuffix);
				importConfigurationBatchJobParameter.JobDescription = config.ConfigurationBaseName;
				result = this.RMServer.ImportBatchConfiguration(importConfigurationBatchJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬\udcb0쎲\udab4얶춸튼톾Ꟁꫂꋄ닆믈꫊만ꛎ뻐뷒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1040449536;
			short num3 = num;
			return result;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001FF28 File Offset: 0x0001E128
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> ApplyConfiguration(global::System.Guid opGuid, global::System.Guid ConfigurationUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyConfiguration radioInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			int a_ = 3;
			short num;
			global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> result;
			try
			{
				num = (short)903153141;
				short num2 = num;
				num = (short)2120877557;
				switch (num2 == num)
				{
				}
				num = (short)744292352;
				if (num != 0)
				{
				}
				result = this.RMServer.ApplyConfigurationToRadio(opGuid, ConfigurationUuid, radioInfo, validateSet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥\udaa9\udcab슭즯\udbb3\ud8b5\udeb7펹\udbbb쮽늿ꏁ냃꿅Ꟈ꓉", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1416822784;
			short num3 = num;
			num = (short)1189675009;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0002002C File Offset: 0x0001E22C
		public void AddandApplyCompareConfigurationToRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)735843518;
				short num2 = num;
				num = (short)1822889150;
				switch (num2 == num)
				{
				}
				num = (short)153550849;
				if (num != 0)
				{
				}
				num = (short)1931542528;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet = global::Motorola.CommonCPS.RadioManagement.SharedServices.ValidateEntityBuilder.CreateValidateEntityForSaveAndApplyTempConfiguration(radio);
				this.RMServer.AddandApplyCompareConfigurationToRadio(radio.Uuid, configuration, validateSet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲펶\uddb8\udaba펼\udbbe胀돂뗄ꯆ냈裊ꋌꋎꇐ닒꟔닖高듚돜맞裠蓢郤闦裨鿪蓬胮鿰ꟲ髴ꗶ飸鿺铼郾", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1011679232;
			short num3 = num;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00020138 File Offset: 0x0001E338
		public global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob AddReadWriteJob(global::System.Guid batchJobContainerUuid, global::System.Guid? readWriteJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.JobRequest jr, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validSet)
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJob result;
			try
			{
				num = (short)1224757057;
				short num2 = num;
				num = (short)650858305;
				switch (num2 == num)
				{
				}
				num = (short)2133852160;
				if (num != 0)
				{
				}
				result = this.RMServer.AddReadWriteJob(batchJobContainerUuid, readWriteJobContainerUuid, jr, validSet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\udcb7\udeb9\udbbdꆿꛁ鏃듅ꇇ뻉꧋蓍뿏냑", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1278541824;
			short num3 = num;
			num = (short)1205338113;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0002023C File Offset: 0x0001E43C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyMVO(global::Motorola.CommonCPS.Server.EntityModel.ApplyMVOBatchJobParameter parameter)
		{
			int a_ = 14;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)1222395316;
				short num2 = num;
				num = (short)1483425204;
				switch (num2 == num)
				{
				}
				num = (short)895221760;
				if (num != 0)
				{
				}
				num = (short)1424883713;
				if (num != 0)
				{
				}
				result = this.RMServer.ApplyMVO(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记어잶햸슺軀", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1372061696;
			short num3 = num;
			return result;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00020338 File Offset: 0x0001E538
		public int GetCandidateMVORadioSummaryCount()
		{
			int a_ = 7;
			short num;
			int candidateMVORadioSummaryCount;
			try
			{
				num = (short)1697223872;
				short num2 = num;
				num = (short)1343132864;
				switch (num2 == num)
				{
				}
				num = (short)173277185;
				if (num != 0)
				{
				}
				num = (short)2061762560;
				if (num != 0)
				{
				}
				candidateMVORadioSummaryCount = this.RMServer.GetCandidateMVORadioSummaryCount(null);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯햳\ud8b5\udcb7펹\ud8bb\udfbd뒿ꟁ觃郅蟇飉귋꫍맏뷑蟓ꏕ뗗럙뷛곝駟ꇡ诣鏥蛧黩", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)920649728;
			short num3 = num;
			return candidateMVORadioSummaryCount;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00020440 File Offset: 0x0001E640
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> ListCandidateMVORadioSummary(int startIndex, int length)
		{
			int a_ = 11;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> result;
			try
			{
				num = (short)1943758906;
				short num2 = num;
				num = (short)1212180538;
				switch (num2 == num)
				{
				}
				num = (short)1097859072;
				if (num != 0)
				{
				}
				result = this.RMServer.ListCandidateMVORadioSummary(startIndex, length, null);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ﲯ\udbb1잳습﮷\udbb9튻\udabdꦿꛁꗃ닅귇蟉髋臍苏돑냓뿕럗觙꧛돝跟菡難鿥", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1154744320;
			short num3 = num;
			num = (short)1478492161;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0002054C File Offset: 0x0001E74C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeRadio(global::System.Guid? batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioUpgradeRequest request, string jobName)
		{
			int a_ = 18;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)276226177;
				short num2 = num;
				num = (short)534438017;
				switch (num2 == num)
				{
				}
				num = (short)1560346624;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.UpgradeRadioBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.UpgradeRadioBatchJobParameter(batchJobContainerUuid.Value, request)
				{
					JobDescription = jobName
				};
				result = this.RMServer.UpgradeRadio(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴즸\udcba쾼\udebeꗀꛂ韄ꛆ귈ꋊꋌ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)674955264;
			short num3 = num;
			num = (short)905838593;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00020664 File Offset: 0x0001E864
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ImportRadioFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest csvRequest, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 3;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)312269548;
				short num2 = num;
				num = (short)482466540;
				switch (num2 == num)
				{
				}
				num = (short)1665466368;
				if (num != 0)
				{
				}
				result = this.RMServer.ImportRadioFromCSV(batchJobContainerUuid, csvRequest, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥잩\udcab솭슯욱ힵ\udcb7펹펻늿귁꧃藅鯇鳉", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1196556288;
			short num3 = num;
			num = (short)117702657;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00020764 File Offset: 0x0001E964
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveConfirmResult GetSaveConfirmResult(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData)
		{
			int a_ = 15;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveConfirmResult saveConfirmResultCmp;
			try
			{
				num = (short)781631979;
				short num2 = num;
				num = (short)487506411;
				switch (num2 == num)
				{
				}
				num = (short)435355648;
				if (num != 0)
				{
				}
				byte[] compressedSaveData = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.SerializeAndZip<global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg>(saveData);
				saveConfirmResultCmp = this.RMServer.GetSaveConfirmResultCmp(compressedSaveData);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵첷\uddbb좽ꖿ臁ꯃꣅ껇ꏉ뻋ꏍ苏럑ꟓꏕ듗껙", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)328400896;
			short num3 = num;
			num = (short)331284481;
			if (num != 0)
			{
			}
			return saveConfirmResultCmp;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0002086C File Offset: 0x0001EA6C
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.HomeSetArgs.SaveHomeSetConfirmResult GetSaveHomeSetConfirmResult(global::System.Guid ChangeImpactedHomeSetUuid)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.HomeSetArgs.SaveHomeSetConfirmResult saveHomeSetConfirmResult;
			try
			{
				num = (short)2032085355;
				short num2 = num;
				num = (short)1714235755;
				switch (num2 == num)
				{
				}
				num = (short)807796737;
				if (num != 0)
				{
				}
				num = (short)252182528;
				if (num != 0)
				{
				}
				saveHomeSetConfirmResult = this.RMServer.GetSaveHomeSetConfirmResult(ChangeImpactedHomeSetUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢슦\udda8첬\ud9ae풰﮲\udab4\udab6\udcb8\ud8bc쮾苀곂ꯄꇆꃈ맊ꃌ鷎듐ꃒꃔ믖귘", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)985989120;
			short num3 = num;
			return saveHomeSetConfirmResult;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0002096C File Offset: 0x0001EB6C
		public bool UpdatePBBCodeplugForceWriteHomeset(global::System.Guid codeplugUuid, bool IsForceWriteHomeSet)
		{
			int a_ = 4;
			short num;
			bool result;
			try
			{
				num = (short)1544327256;
				short num2 = num;
				num = (short)337088600;
				switch (num2 == num)
				{
				}
				num = (short)1126367233;
				if (num != 0)
				{
				}
				num = (short)1566048256;
				if (num != 0)
				{
				}
				result = this.RMServer.UpdatePBBCodeplugForceWriteHomeset(codeplugUuid, IsForceWriteHomeSet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦ﲨ\udbaa즬캮얰횲﮸튼\udbbe꓀돂꧄닆껈跊ꋌ뷎닐뛒苔ꗖ냘꿚룜韞軠転胤铦賨鿪", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1289289728;
			short num3 = num;
			return result;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00020A6C File Offset: 0x0001EC6C
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> GetSetAssginToAllConfigsConfirmResult(global::System.Guid setUuid, int pageNumber, int pageSize)
		{
			int a_ = 17;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> result;
			try
			{
				num = (short)923733628;
				short num2 = num;
				num = (short)1978076796;
				switch (num2 == num)
				{
				}
				num = (short)530382849;
				if (num != 0)
				{
				}
				num = (short)1185415168;
				if (num != 0)
				{
				}
				result = this.RMServer.ListConfigurationsSetAssignedTo(setUuid, pageNumber, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹\udfbd뚿ꟁ蟃꧅ꛇ곉ꗋ볍뷏胑뇓ꗕ귗뛙꣛", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)765067264;
			short num3 = num;
			return result;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00020B6C File Offset: 0x0001ED6C
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsResult CopySet(global::System.Guid setUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.CopySetOptions option, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, int>> maxNumberList, global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg saveData, bool isNeedSync, global::Motorola.CommonCPS.Server.EntityModel.RecordSummary currentConfig, string newSetName, global::System.Collections.Generic.HashSet<string> forceCopyTypes)
		{
			int a_ = 0;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsResult result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_31;
				}
				int num;
				global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsArgs saveAsArgs;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (!string.IsNullOrEmpty(currentConfig.UUID))
						{
							num2 = (short)1666449412;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_12C;
					case 1:
						goto IL_E9;
					case 2:
					{
						num2 = (short)2146919078;
						short num3 = num2;
						num2 = (short)1653105318;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E9;
						default:
							goto IL_18E;
						}
						break;
					}
					case 3:
						if (currentConfig != null)
						{
							num2 = (short)1590296577;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_12C;
					case 4:
						saveAsArgs.CurrentConfigGuid = new global::System.Guid?(new global::System.Guid(currentConfig.UUID));
						currentConfig.RecordType = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풖ﮜ욠킢", a_);
						num2 = (short)2016215045;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_12C;
					}
					goto IL_31;
					IL_E9:
					num2 = (short)781975552;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_12C:
					saveAsArgs.CurrentConfigurationSummary = currentConfig;
					result = this.RMServer.SaveSetAs(saveAsArgs);
					num2 = (short)97583106;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_18E:
				num2 = (short)1775632385;
				if (num2 != 0)
				{
				}
				num2 = (short)2112487424;
				if (num2 != 0)
				{
				}
				goto IL_1FA;
				IL_31:
				saveAsArgs = new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsArgs();
				saveAsArgs.TopSetUuid = setUuid;
				saveAsArgs.Option = option;
				saveAsArgs.NewSetName = newSetName;
				saveAsArgs.MaxSetCountList = maxNumberList;
				saveAsArgs.SaveData = saveData;
				saveAsArgs.IsNeedToSyncData = isNeedSync;
				saveAsArgs.SharableSetTypes = forceCopyTypes;
				num2 = (short)793116675;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢좦\ud9a8튪ﺬ쪮얰", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			IL_1FA:
			num2 = (short)451674112;
			short num4 = num2;
			return result;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00020DBC File Offset: 0x0001EFBC
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> GetConfigurationsSetsNumberReachMax(string setName, int maxNumber)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary> result;
			try
			{
				num = (short)398129330;
				short num2 = num;
				num = (short)1628043442;
				switch (num2 == num)
				{
				}
				num = (short)1777991680;
				if (num != 0)
				{
				}
				result = this.RMServer.ListConfigurationsSetsNumberReachMax(setName, maxNumber);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad\uddb1\udab3킵톷\uddb9즻첽ꆿ뛁귃꧅ꛇ막鿋ꯍ꓏ꇑ髓ꏕ뗗룙맛곝닟蟡藣藥胧꟩跫雭", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1213530113;
			if (num != 0)
			{
			}
			num = (short)1084096512;
			short num3 = num;
			return result;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00020EBC File Offset: 0x0001F0BC
		public void ForceToSyncRadioData(global::System.Guid RadioUuid)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)1909624730;
				short num2 = num;
				num = (short)1681690522;
				switch (num2 == num)
				{
				}
				num = (short)101908480;
				if (num != 0)
				{
				}
				this.RMServer.ForceToSyncRadioData(RadioUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲\ud8b6쮸\ud8ba\ud8bc껀郂별꧆꫈駊곌ꯎ룐볒釔뛖귘뫚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1936588801;
			if (num != 0)
			{
			}
			num = (short)618397696;
			short num3 = num;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveResultForPerConfiguration SaveForPerConfiguration(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveDataForPerConfiguration saveData)
		{
			int a_ = 16;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveResultForPerConfiguration result;
			try
			{
				num = (short)171191482;
				short num2 = num;
				num = (short)394144954;
				switch (num2 == num)
				{
				}
				num = (short)752943104;
				if (num != 0)
				{
				}
				result = this.RMServer.SaveForPerConfiguration(saveData);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲횶쾸\udeba﮼킾돀鏂ꃄ뗆諈꓊ꏌ꧎룐듒ꃔꗖ룘꿚드냞迠", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1274413057;
			if (num != 0)
			{
			}
			num = (short)189530112;
			short num3 = num;
			return result;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000210B8 File Offset: 0x0001F2B8
		public void EnableFeature_CLL(global::Motorola.CommonCPS.Server.EntityModel.FeatureResponseObject referenceReq, string hostID, byte[] capabilityResponse)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)320302919;
				short num2 = num;
				num = (short)1005285191;
				switch (num2 == num)
				{
				}
				num = (short)1342177280;
				if (num != 0)
				{
				}
				this.RMServer.EnableFeature_CLL(referenceReq, hostID, capabilityResponse);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲\ud9b6\ud8b8\ud9ba톼\udabe蟀ꛂ꓄돆볈맊꣌郎鋐鿒駔", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1767505921;
			if (num != 0)
			{
			}
			num = (short)341245952;
			short num3 = num;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000211BC File Offset: 0x0001F3BC
		public void EnableFeature_Radio(string radioID, byte[] capabilityResponse)
		{
			short num = (short)96075777;
			if (num != 0)
			{
			}
			num = (short)1015645435;
			short num2 = num;
			num = (short)165315835;
			switch (num2 == num)
			{
			default:
			{
				num = (short)92864512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)857079808;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00021268 File Offset: 0x0001F468
		public global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateRadioActivationRequest_CLL(string hostID, string computerName, string AID, int count)
		{
			int a_ = 5;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest result;
			try
			{
				num = (short)2031157249;
				if (num != 0)
				{
				}
				num = (short)1432281239;
				short num2 = num;
				num = (short)920641687;
				switch (num2 == num)
				{
				}
				num = (short)280821760;
				if (num != 0)
				{
				}
				result = this.RMServer.CreateRadioActivationRequest_CLL(hostID, computerName, AID, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧\udeab쮭톯욱톳\ud9b7\udeb9햻톽膿ꇁ냃꿅뻇ꯉ룋ꟍ뿏병蛓돕꧗꿙맛귝铟뷡꟣ꫥꓧ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)949092352;
			short num3 = num;
			return result;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0002136C File Offset: 0x0001F56C
		public global::EntityModel.GenericModel.CFSUpdateResult CfsUpgradeRadio(global::Motorola.CommonCPS.Server.EntityModel.CfsUpgradeRadioBatchJobParameter cfsUpgradeRadioBatchJobParameter)
		{
			int a_ = 19;
			short num;
			global::EntityModel.GenericModel.CFSUpdateResult result;
			try
			{
				num = (short)2145411578;
				short num2 = num;
				num = (short)1354916346;
				switch (num2 == num)
				{
				}
				num = (short)706281472;
				if (num != 0)
				{
				}
				result = this.RMServer.CfsUpgradeRadio(cfsUpgradeRadioBatchJobParameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵﮷\udcb9쾻낿ꗁ뛃Ʂ곇꿉黋꿍듏믑믓", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1043267585;
			if (num != 0)
			{
			}
			num = (short)437780480;
			short num3 = num;
			return result;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0002146C File Offset: 0x0001F66C
		public global::Motorola.CommonCPS.Server.EntityModel.LESystemLinkInfo GetPCRLESystemLinkInfo(string serialNum)
		{
			int a_ = 6;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.LESystemLinkInfo pcrlesystemLinkInfo;
			try
			{
				num = (short)2008885352;
				short num2 = num;
				num = (short)1705125992;
				switch (num2 == num)
				{
				}
				num = (short)1257635840;
				if (num != 0)
				{
				}
				pcrlesystemLinkInfo = this.RMServer.GetPCRLESystemLinkInfo(serialNum);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbae﮶ﲸ쒼첾뗀ꛂ꣄识ꃈꗊꛌ蛎뿐뗒뫔", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1540489217;
			if (num != 0)
			{
			}
			num = (short)1661075456;
			short num3 = num;
			return pcrlesystemLinkInfo;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00021568 File Offset: 0x0001F768
		public global::Motorola.CommonCPS.Server.EntityModel.SystemInfo GetPCRDMR3SystemInfo(string serialNum)
		{
			int a_ = 16;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.SystemInfo pcrdmr3SystemInfo;
			try
			{
				num = (short)143523841;
				if (num != 0)
				{
				}
				num = (short)799114488;
				short num2 = num;
				num = (short)1718519032;
				switch (num2 == num)
				{
				}
				num = (short)1617821696;
				if (num != 0)
				{
				}
				pcrdmr3SystemInfo = this.RMServer.GetPCRDMR3SystemInfo(serialNum);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲튶춸ﺼ藀軂韄髈닊뻌믎듐뻒鳔맖뿘듚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)854327296;
			short num3 = num;
			return pcrdmr3SystemInfo;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00021668 File Offset: 0x0001F868
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ResetIdentifiers(global::System.Guid radioID, int? RadioID, int? CAI, string password, global::Motorola.CommonCPS.Server.EntityModel.LinkType? linkType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 16;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)1746302711;
				short num2 = num;
				num = (short)1154447095;
				switch (num2 == num)
				{
				}
				num = (short)350945281;
				if (num != 0)
				{
				}
				num = (short)2054422528;
				if (num != 0)
				{
				}
				result = this.RMServer.Reset(radioID, RadioID, CAI, password, linkType, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲얶\udcb8\udaba즼\udabe胀ꃂ뇄껆뿈꫊만ꛎ뻐뷒蟔닖꣘껚룜곞闠볢ꛤꯦꗨ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1906442240;
			short num3 = num;
			return result;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00021770 File Offset: 0x0001F970
		public global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary EditPCRRadioSystem(global::System.Guid radioUuid, global::System.Guid systemUuid, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.PCRRadioSystemFieldType, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 10;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary result;
			try
			{
				num = (short)1612818986;
				short num2 = num;
				num = (short)2091231786;
				switch (num2 == num)
				{
				}
				num = (short)1030225920;
				if (num != 0)
				{
				}
				result = this.RMServer.EditPCRRadioSystem(radioUuid, systemUuid, fieldValues, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬햰\udab2솴視\udebeꗀꫂ꫄铆냈룊만꫎볐", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1979252737;
			if (num != 0)
			{
			}
			num = (short)1923416064;
			short num3 = num;
			return result;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00021874 File Offset: 0x0001FA74
		public int GetPCRRadioSystemSummariesCount(global::System.Guid? groupUuid)
		{
			int a_ = 19;
			short num;
			int pcrradioSystemSummariesCount;
			try
			{
				num = (short)749085485;
				short num2 = num;
				num = (short)1197417261;
				switch (num2 == num)
				{
				}
				num = (short)1308098560;
				if (num != 0)
				{
				}
				pcrradioSystemSummariesCount = this.RMServer.GetPCRRadioSystemSummariesCount(groupUuid, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻莿郁雃Ʂ곇ꏉꏋ鷍ꧏꇑꃓ돕뗗觙꧛돝跟菡難迥跧駩꿫臭藯鳱胳", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1413152769;
			if (num != 0)
			{
			}
			num = (short)648085504;
			short num3 = num;
			return pcrradioSystemSummariesCount;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00021974 File Offset: 0x0001FB74
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListPCRRadioSystemSummaries(global::System.Guid? groupUuid, int startIndex, int count)
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> result;
			try
			{
				num = (short)1521411239;
				short num2 = num;
				num = (short)1930290343;
				switch (num2 == num)
				{
				}
				num = (short)1990131712;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPCRRadioSystemSummaries(groupUuid, startIndex, count, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲領\udeb6쪸쾺ﲾ鏀釂꓄ꏆꃈ꓊黌뛎ꋐ꟒냔뫖諘껚냜닞胠釢賤苦髨", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1772617729;
			if (num != 0)
			{
			}
			num = (short)631832576;
			short num3 = num;
			return result;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00021A78 File Offset: 0x0001FC78
		public int GetPCRSystemRadioInfosCount(global::System.Guid? groupUuid)
		{
			int a_ = 11;
			short num;
			int pcrsystemRadioInfosCount;
			try
			{
				num = (short)110808293;
				short num2 = num;
				num = (short)974965989;
				switch (num2 == num)
				{
				}
				num = (short)1007747072;
				if (num != 0)
				{
				}
				num = (short)562626561;
				if (num != 0)
				{
				}
				pcrsystemRadioInfosCount = this.RMServer.GetPCRSystemRadioInfosCount(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳﮷잽뎿뛁ꇃꯅ髇ꯉ꣋ꟍ뿏鯑뫓냕럗꧙鿛뇝闟賡郣", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2118254592;
			short num3 = num;
			return pcrsystemRadioInfosCount;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00021B78 File Offset: 0x0001FD78
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSystemRadioInfoSummary> ListPCRSystemRadioInfos(global::System.Guid? groupUuid, int startIndex, int count)
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSystemRadioInfoSummary> result;
			try
			{
				num = (short)1029448786;
				short num2 = num;
				num = (short)1901077586;
				switch (num2 == num)
				{
				}
				num = (short)1665531904;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPCRSystemRadioInfos(groupUuid, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮ﶰ\udab2운쎶룀냂뇄ꋆ꓈駊곌ꯎ룐볒鳔맖뿘듚껜", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1806041089;
			if (num != 0)
			{
			}
			num = (short)387842048;
			short num3 = num;
			return result;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00021C78 File Offset: 0x0001FE78
		public int GetPCRSystemCountByRadio(global::System.Guid radioUuid)
		{
			int a_ = 8;
			short num;
			int pcrsystemCountByRadio;
			try
			{
				num = (short)1095303169;
				if (num != 0)
				{
				}
				num = (short)1037820530;
				short num2 = num;
				num = (short)1896211058;
				switch (num2 == num)
				{
				}
				num = (short)1049624576;
				if (num != 0)
				{
				}
				pcrsystemCountByRadio = this.RMServer.GetPCRSystemCountByRadio(radioUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰슺캼쮾꓀껂蛄꣆볈ꗊ만跎꣐臒듔돖냘듚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)895090688;
			short num3 = num;
			return pcrsystemCountByRadio;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00021D74 File Offset: 0x0001FF74
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListPCRSystemsByRadio(global::System.Guid radioUuid)
		{
			int a_ = 18;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> result;
			try
			{
				num = (short)371851265;
				if (num != 0)
				{
				}
				num = (short)626565039;
				short num2 = num;
				num = (short)334077871;
				switch (num2 == num)
				{
				}
				num = (short)324403200;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPCRSystemsByRadio(radioUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴﮶킸좺즼苀釂雄뻆뫈뿊꣌ꋎꋐ釒곔藖룘뿚드냞", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)547553280;
			short num3 = num;
			return result;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00021E74 File Offset: 0x00020074
		public int GetPCRRadioSystemsCount(global::System.Guid? groupUuid)
		{
			int a_ = 17;
			short num;
			int pcrradioSystemsCount;
			try
			{
				num = (short)1445935903;
				short num2 = num;
				num = (short)1226259231;
				switch (num2 == num)
				{
				}
				num = (short)222298112;
				if (num != 0)
				{
				}
				num = (short)1659633665;
				if (num != 0)
				{
				}
				pcrradioSystemsCount = this.RMServer.GetPCRRadioSystemsCount(groupUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹ﶽ銿郁ꗃꋅꇇꗉ鿋럍ꏏꛑ뇓믕ꯗ駙돛ꯝ軟雡", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)336199680;
			short num3 = num;
			return pcrradioSystemsCount;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00021F78 File Offset: 0x00020178
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary> ListPCRRadioSystems(global::System.Guid? groupUuid, int startIndex, int count)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary> result;
			try
			{
				num = (short)1378657712;
				short num2 = num;
				num = (short)789030320;
				switch (num2 == num)
				{
				}
				num = (short)1454309376;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPCRRadioSystems(groupUuid, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤삨\ud8aa\ud9acﾮ횶\uddb8튺튼룀냂뇄ꋆ꓈룊", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)319946753;
			if (num != 0)
			{
			}
			num = (short)863895552;
			short num3 = num;
			return result;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0002207C File Offset: 0x0002027C
		public int GetPCRRadioCountBySystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary pcrRadioSystem)
		{
			int a_ = 14;
			short num;
			int pcrradioCountBySystem;
			try
			{
				num = (short)1063160454;
				short num2 = num;
				num = (short)645237382;
				switch (num2 == num)
				{
				}
				num = (short)1687486464;
				if (num != 0)
				{
				}
				pcrradioCountBySystem = this.RMServer.GetPCRRadioCountBySystem(groupUuid, pcrRadioSystem, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶ꃀꟂ계꣆諈꓊료ꇎꗐ釒곔蓖ꃘ꣚꧜뫞賠", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1314193409;
			if (num != 0)
			{
			}
			num = (short)44236800;
			short num3 = num;
			return pcrradioCountBySystem;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0002217C File Offset: 0x0002037C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> ListRadiosByPCRRadioSystem(global::System.Guid? groupUuid, global::Motorola.CommonCPS.Server.EntityModel.PCRSystemInfoSummary pcrRadioSystem, int startIndex, int count)
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> result;
			try
			{
				num = (short)574576297;
				short num2 = num;
				num = (short)1696814761;
				switch (num2 == num)
				{
				}
				num = (short)614924289;
				if (num != 0)
				{
				}
				num = (short)207028224;
				if (num != 0)
				{
				}
				result = this.RMServer.ListRadiosByPCRRadioSystem(groupUuid, pcrRadioSystem, startIndex, count, false);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮ﶰ\udab2운쎶\udaba\ud9bc횾껀냂蟄뻆駈裊鿌鷎냐럒볔룖諘ꋚ껜ꯞ蓠転", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1999044608;
			short num3 = num;
			return result;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00022280 File Offset: 0x00020480
		public global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem GetPCRRadioSystem(global::System.Guid id)
		{
			int a_ = 5;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystem pcrradioSystem;
			try
			{
				num = (short)678457441;
				short num2 = num;
				num = (short)98791521;
				switch (num2 == num)
				{
				}
				num = (short)582090752;
				if (num != 0)
				{
				}
				pcrradioSystem = this.RMServer.GetPCRRadioSystem(id);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad\ud9b7\udeb9햻톽鎿믁럃닅귇Ꟊ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1755840513;
			if (num != 0)
			{
			}
			num = (short)560267264;
			short num3 = num;
			return pcrradioSystem;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00022380 File Offset: 0x00020580
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> GetPCRRadioSystemByDMR3System(global::System.Guid id)
		{
			int a_ = 11;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRRadioSystemSummary> pcrradioSystemByDMR3System;
			try
			{
				num = (short)517149467;
				short num2 = num;
				num = (short)1433539355;
				switch (num2 == num)
				{
				}
				num = (short)1621032961;
				if (num != 0)
				{
				}
				num = (short)1772093440;
				if (num != 0)
				{
				}
				pcrradioSystemByDMR3System = this.RMServer.GetPCRRadioSystemByDMR3System(id);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳﮷\udfbd꒿ꯁꯃ闅뇇막룋ꯍ뷏郑귓鋕闗裙距駟釡郣菥藧", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1810890752;
			short num3 = num;
			return pcrradioSystemByDMR3System;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00022484 File Offset: 0x00020684
		public global::Motorola.CommonCPS.Server.EntityModel.PBBPassword AddPBBPassword(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password)
		{
			int a_ = 6;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PBBPassword result;
			try
			{
				num = (short)1066448094;
				short num2 = num;
				num = (short)1095677150;
				switch (num2 == num)
				{
				}
				num = (short)1617035264;
				if (num != 0)
				{
				}
				result = this.RMServer.AddPBBPassword(password);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨즬쮮\ud8b8좺캼좾껀뇂ꇄ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1567883265;
			if (num != 0)
			{
			}
			num = (short)1378942976;
			short num3 = num;
			return result;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00022584 File Offset: 0x00020784
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBPassword> ListPBBPasswords()
		{
			int a_ = 4;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBPassword> result;
			try
			{
				num = (short)181573472;
				short num2 = num;
				num = (short)1969198944;
				switch (num2 == num)
				{
				}
				num = (short)1891827712;
				if (num != 0)
				{
				}
				result = this.RMServer.ListPBBPasswords();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦슪\udeac\udbae\ud8b8좺캼좾껀뇂ꇄ듆", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1154875392;
			short num3 = num;
			num = (short)1609039873;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00022684 File Offset: 0x00020884
		public global::Motorola.CommonCPS.Server.EntityModel.PBBPassword GetPBBPassword(global::System.Guid passwordUuid)
		{
			int a_ = 11;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PBBPassword pbbpassword;
			try
			{
				num = (short)1644858881;
				short num2 = num;
				num = (short)1017548289;
				switch (num2 == num)
				{
				}
				num = (short)26738688;
				if (num != 0)
				{
				}
				pbbpassword = this.RMServer.GetPBBPassword(passwordUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳覆\udfbd뎿뇁돃꧅뫇껉", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)542572544;
			short num3 = num;
			num = (short)1698693121;
			if (num != 0)
			{
			}
			return pbbpassword;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00022780 File Offset: 0x00020980
		public global::Motorola.CommonCPS.Server.EntityModel.PBBPassword GetPBBPasswordById(string id)
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.PBBPassword pbbpasswordById;
			try
			{
				num = (short)554566402;
				short num2 = num;
				num = (short)1109066498;
				switch (num2 == num)
				{
				}
				num = (short)926941184;
				if (num != 0)
				{
				}
				pbbpasswordById = this.RMServer.GetPBBPasswordById(id);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹ﲽ芿鋁ꗃ뗅믇뷉ꏋ볍듏郑귓鿕볗", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1478361088;
			short num3 = num;
			num = (short)16908289;
			if (num != 0)
			{
			}
			return pbbpasswordById;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00022880 File Offset: 0x00020A80
		public void UpdatePBBPassword(global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)1439891457;
				if (num != 0)
				{
				}
				num = (short)127513943;
				short num2 = num;
				num = (short)2105783639;
				switch (num2 == num)
				{
				}
				num = (short)563412992;
				if (num != 0)
				{
				}
				this.RMServer.UpdatePBBPassword(password);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳좷\udeb9\uddbb쪽ꖿ鋁蛃蓅飇ꯉ뿋뷍꟏뷑ꛓ닕", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)598867968;
			short num3 = num;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00022980 File Offset: 0x00020B80
		public bool DeletePBBPassword(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.PBBPassword password)
		{
			int a_ = 3;
			short num;
			bool result;
			try
			{
				num = (short)1450272651;
				short num2 = num;
				num = (short)838821771;
				switch (num2 == num)
				{
				}
				num = (short)2099838977;
				if (num != 0)
				{
				}
				num = (short)44105728;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.DeletePBBPasswordBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.DeletePBBPasswordBatchJobParameter(batchJobContainerUuid, password.Uuid, password.Id);
				result = this.RMServer.DeletePBBPassword(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쾩삫쮭쒯ힱ覆\uddbb춽뎿뗁ꯃ듅곇", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1071448064;
			short num3 = num;
			return result;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00022A90 File Offset: 0x00020C90
		public global::System.Collections.Generic.List<string> GetUserPermissions()
		{
			int a_ = 8;
			short num = (short)107085234;
			short num2 = num;
			num = (short)1081343410;
			global::System.Collections.Generic.List<string> userPermissions;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1673068545;
				if (num != 0)
				{
				}
				num = (short)1668677632;
				if (num != 0)
				{
				}
				new global::System.Collections.Generic.List<string>();
				try
				{
					userPermissions = this.RMServer.GetUserPermissions();
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰운튶쮸\ud8bc춾곀ꫂ뛄듆ꃈ꓊ꏌ볎", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
				}
				break;
			}
			num = (short)1823670272;
			short num3 = num;
			return userPermissions;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00022B98 File Offset: 0x00020D98
		public void EnableJobStatistic()
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)108999243;
				short num2 = num;
				num = (short)1896100427;
				switch (num2 == num)
				{
				}
				num = (short)1344471040;
				if (num != 0)
				{
				}
				this.RMServer.EnableJobStatistic();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮\uddb2풴햶햸\udeba킾ꏀ郂뇄ꛆ뷈ꋊ뻌믎룐냒", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)271319040;
			short num3 = num;
			num = (short)2040791041;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00022C98 File Offset: 0x00020E98
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobStatistic> GetJobStatistics(global::System.Collections.Generic.List<global::System.Guid> jobUuid)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.JobStatistic> jobStatistics;
			try
			{
				num = (short)216174799;
				short num2 = num;
				num = (short)2041286863;
				switch (num2 == num)
				{
				}
				num = (short)2058354689;
				if (num != 0)
				{
				}
				num = (short)1404960768;
				if (num != 0)
				{
				}
				jobStatistics = this.RMServer.GetJobStatistics(jobUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaa삮펰솴횶춸튺캼쮾ꣀꃂ뛄", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1459486720;
			short num3 = num;
			return jobStatistics;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00022D98 File Offset: 0x00020F98
		public global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection> ListOptionDataById(global::System.Collections.Generic.List<global::System.Guid> uuids)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection> result;
			try
			{
				num = (short)1416319724;
				short num2 = num;
				num = (short)2139312876;
				switch (num2 == num)
				{
				}
				num = (short)607518721;
				if (num != 0)
				{
				}
				num = (short)1835466752;
				if (num != 0)
				{
				}
				result = this.RMServer.ListOptionDataById(uuids);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧얫\uddad쒯ﶱ쒳습톷햹튻諾ꆿ뛁ꗃ蓅뇇菉꣋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1552744448;
			short num3 = num;
			return result;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00022E98 File Offset: 0x00021098
		public global::Motorola.CommonCPS.Server.EntityModel.RMFile PrepareProvisioningTable(global::System.Guid radioUuid)
		{
			int a_ = 5;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RMFile result;
			try
			{
				num = (short)1513791533;
				short num2 = num;
				num = (short)1029611565;
				switch (num2 == num)
				{
				}
				num = (short)1081081856;
				if (num != 0)
				{
				}
				result = this.RMServer.PrepareProvisioningTable(radioUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧睊\udeab쮭삯펱욳펵좹펻좽ꦿ뇁귃꧅ꛇꏉꋋ꧍蓏돑뛓뫕뷗", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1719730176;
			short num3 = num;
			num = (short)2028601345;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00022F98 File Offset: 0x00021198
		public bool IsSessionOutOfTime(string templateID)
		{
			short num;
			bool result;
			try
			{
				num = (short)1911903792;
				short num2 = num;
				num = (short)1101092400;
				switch (num2 == num)
				{
				}
				num = (short)1232338944;
				if (num != 0)
				{
				}
				result = this.RMServer.IsSessionOutOfTime(templateID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)738787328;
			short num3 = num;
			num = (short)466092033;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00023078 File Offset: 0x00021278
		public void RefreshSessionTimer(string templateID)
		{
			short num;
			try
			{
				num = (short)88014849;
				if (num != 0)
				{
				}
				num = (short)1540397560;
				short num2 = num;
				num = (short)907123192;
				switch (num2 == num)
				{
				}
				num = (short)1362493440;
				if (num != 0)
				{
				}
				this.RMServer.RefreshSessionTimer(templateID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)184811520;
			short num3 = num;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00023154 File Offset: 0x00021354
		public int GetWaitCount(string templateID)
		{
			short num;
			int waitCount;
			try
			{
				num = (short)613649087;
				short num2 = num;
				num = (short)1326615231;
				switch (num2 == num)
				{
				}
				num = (short)1687289857;
				if (num != 0)
				{
				}
				num = (short)1757741056;
				if (num != 0)
				{
				}
				waitCount = this.RMServer.GetWaitCount(templateID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1522728960;
			short num3 = num;
			return waitCount;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00023234 File Offset: 0x00021434
		public void SetWaitCount(string templateID, int newValue)
		{
			short num;
			try
			{
				num = (short)810223755;
				short num2 = num;
				num = (short)1017710731;
				switch (num2 == num)
				{
				}
				num = (short)428081152;
				if (num != 0)
				{
				}
				this.RMServer.SetWaitCount(templateID, newValue);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)964952064;
			short num3 = num;
			num = (short)1601437697;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00023310 File Offset: 0x00021510
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo GetMigrationInfo()
		{
			int a_ = 3;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.MigrationInfo migrationInfo;
			try
			{
				num = (short)1656480439;
				short num2 = num;
				num = (short)1444274871;
				switch (num2 == num)
				{
				}
				num = (short)557973504;
				if (num != 0)
				{
				}
				migrationInfo = this.RMServer.GetMigrationInfo();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥쾩\ud8abﾱ\uddb3통쪷\udbb9좻ힽ꾿곁雃ꏅꯇꗉ뻋꫍", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1016463360;
			short num3 = num;
			num = (short)538574849;
			if (num != 0)
			{
			}
			return migrationInfo;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00023410 File Offset: 0x00021610
		public void MigrateRadioAndCommonResource(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName, bool migrateHistoryPBAs = false)
		{
			int a_ = 0;
			short num;
			try
			{
				num = (short)476421326;
				short num2 = num;
				num = (short)2061999310;
				switch (num2 == num)
				{
				}
				num = (short)233308160;
				if (num != 0)
				{
				}
				this.RMServer.MigrateRadioAndCommonResource(regionName, migrateHistoryPBAs);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢캦캨\ud9aa첬\udbae풰풴펶킸풺ﲼ톾ꗀ胂꫄꫆꓈꓊ꏌ鷎듐ꃒ뫔ꋖꯘ룚룜", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)116195328;
			short num3 = num;
			num = (short)1291190273;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00023510 File Offset: 0x00021710
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigurationAndWiFi GetMigrationPBBFusionCfgWifi()
		{
			int a_ = 13;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigurationAndWiFi migrationPBBFusionCfgWifi;
			try
			{
				num = (short)536887895;
				short num2 = num;
				num = (short)159859287;
				switch (num2 == num)
				{
				}
				num = (short)968097792;
				if (num != 0)
				{
				}
				num = (short)1896218625;
				if (num != 0)
				{
				}
				migrationPBBFusionCfgWifi = this.RMServer.GetMigrationPBBFusionCfgWifi();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯톳습펹\udbbb첽ꆿ뛁귃꧅ꛇ髉軋賍雏ꟑꟓ뿕럗듙鿛룝蟟뗡跣胥臧", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)389218304;
			short num3 = num;
			return migrationPBBFusionCfgWifi;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00023610 File Offset: 0x00021810
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> ListMigrationTemplateList()
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationTemplateInfo> result;
			try
			{
				num = (short)2073625081;
				short num2 = num;
				num = (short)133628409;
				switch (num2 == num)
				{
				}
				num = (short)754581505;
				if (num != 0)
				{
				}
				num = (short)1362558976;
				if (num != 0)
				{
				}
				result = this.RMServer.ListMigrationTemplateList();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮ﶰ\udab2운쎶튺\udabc춾ꃀ럂계꣆ꟈ鿊꣌ꋎꇐ뿒듔ꏖ볘韚드곞闠", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1789329408;
			short num3 = num;
			return result;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00023710 File Offset: 0x00021910
		public void SaveMigrationTemplateSelctions(global::System.Collections.Generic.List<global::System.Guid> abandonedTemplateUuidList)
		{
			int a_ = 10;
			short num;
			try
			{
				num = (short)492732669;
				short num2 = num;
				num = (short)2102886653;
				switch (num2 == num)
				{
				}
				num = (short)1468334080;
				if (num != 0)
				{
				}
				num = (short)2084634625;
				if (num != 0)
				{
				}
				this.RMServer.SaveMigrationTemplateSelctions(abandonedTemplateUuidList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬ﲮ킰얲킴襁킸\udcba쾼\udebe뗀ꫂ꫄꧆鷈껊ꃌ뿎뷐닒ꇔ닖諘뻚뇜볞闠諢諤触髨", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)568918016;
			short num3 = num;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0002380C File Offset: 0x00021A0C
		public global::Motorola.CommonCPS.Server.EntityModel.Template MigrateTemplate(global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateParameter parameter)
		{
			int a_ = 6;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Template result;
			try
			{
				num = (short)2006162886;
				short num2 = num;
				num = (short)1205706182;
				switch (num2 == num)
				{
				}
				num = (short)992935936;
				if (num != 0)
				{
				}
				result = this.RMServer.MigrateTemplate(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨쒬좮쎰튲솴튶\udeba킼쾾귀ꋂ뇄ꋆ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1558446080;
			short num3 = num;
			num = (short)639565825;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0002390C File Offset: 0x00021B0C
		public global::Motorola.CommonCPS.Server.EntityModel.Radio MigrateTemplateDataToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Guid templateUuid, string batchOpJobName, bool applyToCurrentCP = false)
		{
			int a_ = 19;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Radio result;
			try
			{
				num = (short)1142793495;
				short num2 = num;
				num = (short)1054254359;
				switch (num2 == num)
				{
				}
				num = (short)21364736;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateDataToRadioParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.MigrateTemplateDataToRadioParameter(batchJobContainerUuid, radioUuid, templateUuid, batchOpJobName, applyToCurrentCP);
				result = this.RMServer.MigrateTemplateDataToRadio(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵펹\udbbb첽ꆿ뛁ꇃ鋅귇Ꟊ볋ꋍ뇏ꛑ뇓鋕맗껙뷛諝迟냡藣若臧藩", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1805778944;
			short num3 = num;
			num = (short)1083244545;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00023A1C File Offset: 0x00021C1C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus MigrateTemplateAndApplyTemplateDone()
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus result;
			try
			{
				num = (short)2106139270;
				short num2 = num;
				num = (short)282337926;
				switch (num2 == num)
				{
				}
				num = (short)203685888;
				if (num != 0)
				{
				}
				result = this.RMServer.MigrateTemplateAndApplyTemplateDone();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩잭힯삱햳습\uddb7\ud9bb펽낿껁ꗃ닅귇诉ꋋ꫍量ꋑꓓ뫕ꇗ軙맛돝郟軡藣鋥跧껩菫胭闯", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1839464448;
			short num3 = num;
			num = (short)1289420801;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00023B1C File Offset: 0x00021D1C
		public int ScheduleMigrationJob()
		{
			int a_ = 14;
			short num;
			int result;
			try
			{
				num = (short)2098245656;
				short num2 = num;
				num = (short)1573957656;
				switch (num2 == num)
				{
				}
				num = (short)1860370433;
				if (num != 0)
				{
				}
				num = (short)218890240;
				if (num != 0)
				{
				}
				result = this.RMServer.ScheduleMigrationJob();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记횴\udfb6\udcb8\udfba좼펾꓀軂계ꃆ믈꫊만ꛎ뻐뷒鿔룖믘", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1426194432;
			short num3 = num;
			return result;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00023C1C File Offset: 0x00021E1C
		public void TurnOffMigration(string rmVersion)
		{
			int a_ = 6;
			short num;
			try
			{
				num = (short)175807316;
				short num2 = num;
				num = (short)952539988;
				switch (num2 == num)
				{
				}
				num = (short)848560128;
				if (num != 0)
				{
				}
				num = (short)1806237697;
				if (num != 0)
				{
				}
				this.RMServer.TurnOffMigration(rmVersion);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨ﾪ\ud8ac\uddae\udfb0ﲲ펴톶튺\udabc춾ꃀ럂계꣆ꟈ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1611792384;
			short num3 = num;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00023D1C File Offset: 0x00021F1C
		public void TransferArchiveFileById(global::System.Guid achiveUuid)
		{
			int a_ = 5;
			short num;
			try
			{
				num = (short)184335407;
				short num2 = num;
				num = (short)1524481071;
				switch (num2 == num)
				{
				}
				num = (short)1180237825;
				if (num != 0)
				{
				}
				num = (short)112590848;
				if (num != 0)
				{
				}
				this.RMServer.TransferArchiveFileById(achiveUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧ﺩ\udeab쾭\udeaf솱튳펵쪷﮹캻\uddbdꢿꯁ닃ꏅ軇ꏉꃋꯍ鋏ꯑ鷓닕", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)484311040;
			short num3 = num;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00023E1C File Offset: 0x0002201C
		public global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport GetClearDataProgressReport()
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ClearDataProgressReport clearDataProgressReport;
			try
			{
				num = (short)1444804730;
				short num2 = num;
				num = (short)1595996282;
				switch (num2 == num)
				{
				}
				num = (short)453836800;
				if (num != 0)
				{
				}
				clearDataProgressReport = this.RMServer.GetClearDataProgressReport();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\uddb7캹ﾻ튽ꖿꏁ뛃苅꧇뻉귋黍ꋏ뷑돓ꓕ뷗꧙꿛賝藟鋡诣铥鳧", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)123666432;
			short num3 = num;
			num = (short)624820225;
			if (num != 0)
			{
			}
			return clearDataProgressReport;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00023F1C File Offset: 0x0002211C
		public void ClearLegacyData()
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)2093228603;
				short num2 = num;
				num = (short)928719419;
				switch (num2 == num)
				{
				}
				num = (short)1878392833;
				if (num != 0)
				{
				}
				num = (short)741998592;
				if (num != 0)
				{
				}
				this.RMServer.ClearLegacyData();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳풷\udfb9\uddbb첽貿ꟁꏃꟅꯇ돉裋꿍꓏돑", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)299040768;
			short num3 = num;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00024018 File Offset: 0x00022218
		public void SwapRadioWorkingCodeplug(string serialNumber)
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)543813196;
				short num2 = num;
				num = (short)866381388;
				switch (num2 == num)
				{
				}
				num = (short)2041511936;
				if (num != 0)
				{
				}
				num = (short)2107703297;
				if (num != 0)
				{
				}
				this.RMServer.SwapRadioWorkingCodeplug(serialNumber);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱솵\ud9b7쪹\udfbd꒿ꯁꯃ釅Ꟈ룉Ɤꟍ뻏뗑韓맕볗뿙곛닝闟藡", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1153826816;
			short num3 = num;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00024118 File Offset: 0x00022318
		public void UpdateMigrationStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus status)
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)1849879208;
				short num2 = num;
				num = (short)250473128;
				switch (num2 == num)
				{
				}
				num = (short)8716288;
				if (num != 0)
				{
				}
				this.RMServer.UpdateMigrationStatus(status);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵쪹\ud8bb\udfbd뒿ꟁ觃꿅꿇룉귋뫍맏뷑뫓藕곗믙꣛ꯝ鏟", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)238026752;
			short num3 = num;
			num = (short)731250689;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00024214 File Offset: 0x00022414
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationEstimatedData CalculateMigrationTimeAndSize()
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.MigrationEstimatedData result;
			try
			{
				num = (short)815367158;
				short num2 = num;
				num = (short)417694710;
				switch (num2 == num)
				{
				}
				num = (short)1051262976;
				if (num != 0)
				{
				}
				result = this.RMServer.CalculateMigrationTimeAndSize();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫톯\udeb1ힳ쎵풷\udbb9좻\udbbd趿ꯁꏃ듅꧇뻉ꗋꇍ뻏蛑뷓믕뷗鯙닛뫝돟诡黣菥", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)782303232;
			short num3 = num;
			num = (short)1476329473;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00024314 File Offset: 0x00022514
		public global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus AbortMigration()
		{
			int a_ = 5;
			short num;
			global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus result;
			try
			{
				num = (short)1830620156;
				short num2 = num;
				num = (short)320932860;
				switch (num2 == num)
				{
				}
				num = (short)310247425;
				if (num != 0)
				{
				}
				num = (short)1454047232;
				if (num != 0)
				{
				}
				result = this.RMServer.AbortMigration();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧캫솭슯욱靈\udfb5\udfb7좹\uddbb쪽ꦿ귁꫃", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)277872640;
			short num3 = num;
			return result;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00024414 File Offset: 0x00022614
		public global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult ConvertRadioFromTModeToCMode(global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionOpJobParameter parameter)
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult result;
			try
			{
				num = (short)2043119697;
				short num2 = num;
				num = (short)1612482641;
				switch (num2 == num)
				{
				}
				num = (short)983760896;
				if (num != 0)
				{
				}
				num = (short)305594369;
				if (num != 0)
				{
				}
				result = this.RMServer.ConvertRadioFromTModeToCMode(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳ힷ풹쪻\udbbd늿뛁雃Ʂ곇ꏉꏋ裍ꋏ뷑맓苕闗뗙룛믝듟跡꟣ꯥ蟧軩觫", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)464715776;
			short num3 = num;
			return result;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00024514 File Offset: 0x00022714
		public global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ImportCFGFromTemplate(global::Motorola.CommonCPS.Server.EntityModel.ImportCFGFromTemplateOpJobParameter parameter)
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary result;
			try
			{
				num = (short)1016364159;
				short num2 = num;
				num = (short)1608219775;
				switch (num2 == num)
				{
				}
				num = (short)1466433536;
				if (num != 0)
				{
				}
				result = this.RMServer.ImportCFGFromTemplate(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳ﾵ햷쪹펻첽뒿臁苃臅軇룉ꏋꏍ蓏럑맓ꛕ듗믙꣛믝", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)429129728;
			short num3 = num;
			num = (short)2029977601;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00024610 File Offset: 0x00022810
		public global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo GetConvertTRadioFileInfo(global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter parameter)
		{
			int a_ = 10;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo convertTRadioFileInfo;
			try
			{
				num = (short)73299931;
				short num2 = num;
				num = (short)231831515;
				switch (num2 == num)
				{
				}
				num = (short)1594621952;
				if (num != 0)
				{
				}
				convertTRadioFileInfo = this.RMServer.GetConvertTRadioFileInfo(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲\ud8b6ힸ춺\ud8bc춾뗀韂韄ꛆ귈ꋊꋌ觎룐뿒냔ꓖ郘뗚믜냞", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1457848320;
			short num3 = num;
			num = (short)78381057;
			if (num != 0)
			{
			}
			return convertTRadioFileInfo;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00024710 File Offset: 0x00022910
		public global::Motorola.CommonCPS.Server.EntityModel.ConvertRadioFromCModeToTModeResult ConvertRadioFromCModeToTMode(global::Motorola.CommonCPS.Server.EntityModel.ConvertRadioFromCModeToTModeOpJobParameter parameter)
		{
			int a_ = 4;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ConvertRadioFromCModeToTModeResult result;
			try
			{
				num = (short)1816254438;
				short num2 = num;
				num = (short)1451612134;
				switch (num2 == num)
				{
				}
				num = (short)1808072704;
				if (num != 0)
				{
				}
				num = (short)228982785;
				if (num != 0)
				{
				}
				result = this.RMServer.ConvertRadioFromCModeToTMode(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦쒪쎬\ud9ae풰솲솴\ud8b8\udfba풼킾蟀뇂꫄꫆鷈蛊ꋌꯎ듐蟒뫔铖铘듚맜뫞", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2085093376;
			short num3 = num;
			return result;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00024810 File Offset: 0x00022A10
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListAllIPProgramSystems()
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> result;
			try
			{
				num = (short)1167718138;
				short num2 = num;
				num = (short)1908602618;
				switch (num2 == num)
				{
				}
				num = (short)2069757953;
				if (num != 0)
				{
				}
				num = (short)1371930624;
				if (num != 0)
				{
				}
				result = this.RMServer.ListAllIPProgramSystems();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱\udfb5쮷캹邿냁ꯃꇅ뫇ꯉꇋ鷍ꧏꇑꃓ돕뗗꧙", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)622526464;
			short num3 = num;
			return result;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00024914 File Offset: 0x00022B14
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListIPProgramSystems(int startIndex, int length)
		{
			int a_ = 13;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> result;
			try
			{
				num = (short)765451669;
				short num2 = num;
				num = (short)1681251733;
				switch (num2 == num)
				{
				}
				num = (short)1186070528;
				if (num != 0)
				{
				}
				result = this.RMServer.ListIPProgramSystems(startIndex, length);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯ﺱ\uddb3억첷늿귁ꏃ듅꧇Ꟊ鿋럍ꏏꛑ뇓믕ꯗ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)949026816;
			short num3 = num;
			num = (short)1973026817;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00024A14 File Offset: 0x00022C14
		public global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem GetIPProgramSystem(global::System.Guid sysUuid)
		{
			int a_ = 9;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem ipprogramSystem;
			try
			{
				num = (short)1956162722;
				short num2 = num;
				num = (short)643017890;
				switch (num2 == num)
				{
				}
				num = (short)1478492160;
				if (num != 0)
				{
				}
				ipprogramSystem = this.RMServer.GetIPProgramSystem(sysUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("잡킣캥잧캩隫햯욱ﶳ좹펻\ud9bd늿ꏁ꧃闅뇇막룋ꯍ뷏", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1493827584;
			short num3 = num;
			num = (short)739573761;
			if (num != 0)
			{
			}
			return ipprogramSystem;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00024B14 File Offset: 0x00022D14
		public global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem GetIPProgramSystemByAlias(string sysAlias)
		{
			int a_ = 12;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem ipprogramSystemByAlias;
			try
			{
				num = (short)261275868;
				short num2 = num;
				num = (short)766230748;
				switch (num2 == num)
				{
				}
				num = (short)1646526465;
				if (num != 0)
				{
				}
				num = (short)549584896;
				if (num != 0)
				{
				}
				ipprogramSystemByAlias = this.RMServer.GetIPProgramSystemByAlias(sysAlias);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴ﺶ쾼킾ꛀ뇂꓄꫆髈닊뻌믎듐뻒韔껖飘럚드뻞鋠", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1841758208;
			short num3 = num;
			return ipprogramSystemByAlias;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00024C18 File Offset: 0x00022E18
		public int GetIPProgramSystemsCount()
		{
			int a_ = 5;
			short num;
			int ipprogramSystemsCount;
			try
			{
				num = (short)400066373;
				short num2 = num;
				num = (short)396068677;
				switch (num2 == num)
				{
				}
				num = (short)463011840;
				if (num != 0)
				{
				}
				ipprogramSystemsCount = this.RMServer.GetIPProgramSystemsCount();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad羚쒵ힷ\uddb9캻\udfbd궿釁뷃뗅볇꿉ꇋ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1817313280;
			short num3 = num;
			num = (short)674365441;
			if (num != 0)
			{
			}
			return ipprogramSystemsCount;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00024D18 File Offset: 0x00022F18
		public global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem AddIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem result;
			try
			{
				num = (short)1296385196;
				short num2 = num;
				num = (short)1643070636;
				switch (num2 == num)
				{
				}
				num = (short)1755774976;
				if (num != 0)
				{
				}
				result = this.RMServer.AddIPProgramSystem(sys);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쪭풯ﮱ쪷햹\udbbb첽ꆿ꿁韃뿅믇뻉꧋ꏍ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)200736768;
			short num3 = num;
			num = (short)1334640641;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00024E18 File Offset: 0x00023018
		public void UpdateIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys)
		{
			int a_ = 1;
			short num;
			try
			{
				num = (short)663034202;
				short num2 = num;
				num = (short)1806768474;
				switch (num2 == num)
				{
				}
				num = (short)1082195969;
				if (num != 0)
				{
				}
				num = (short)1506017280;
				if (num != 0)
				{
				}
				this.RMServer.UpdateIPProgramSystem(sys);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣\ud8a7캩춫\udaad햯ﮱ쪷햹\udbbb첽ꆿ꿁韃뿅믇뻉꧋ꏍ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1416888320;
			short num3 = num;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00024F18 File Offset: 0x00023118
		public bool DeleteIPProgramSystem(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem sys)
		{
			int a_ = 2;
			short num;
			bool result;
			try
			{
				num = (short)655097857;
				if (num != 0)
				{
				}
				num = (short)1945620544;
				short num2 = num;
				num = (short)923914304;
				switch (num2 == num)
				{
				}
				num = (short)551944192;
				if (num != 0)
				{
				}
				result = this.RMServer.DeleteIPProgramSystem(batchJobContainerUuid, sys);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨잪좬\udbae풰者쮸풺\udabc춾ꃀ껂雄뻆뫈뿊꣌ꋎ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1873739776;
			short num3 = num;
			return result;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0002501C File Offset: 0x0002321C
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ApplyIPProgramSystem(global::System.Guid batchOpGuid, global::System.Guid sysUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyIPProgramSystem radioInfo, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateSet)
		{
			int a_ = 8;
			short num;
			global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> result;
			try
			{
				num = (short)991756289;
				if (num != 0)
				{
				}
				num = (short)2001880186;
				short num2 = num;
				num = (short)475546746;
				switch (num2 == num)
				{
				}
				num = (short)2054488064;
				if (num != 0)
				{
				}
				result = this.RMServer.ApplyIPProgramSystemToRadio(batchOpGuid, sysUuid, radioInfo, validateSet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪\udfae솰\udfb2체횸햺\udbbc횾ꛀ뛂럄ꛆ뷈ꋊꋌꇎ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)51838976;
			short num3 = num;
			return result;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00025120 File Offset: 0x00023320
		public global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem EditIPProgramSystem(global::System.Guid sysUuid, object changedField, global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemFieldType fieldType, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 3;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem result;
			try
			{
				num = (short)1387951796;
				short num2 = num;
				num = (short)1330738868;
				switch (num2 == num)
				{
				}
				num = (short)400490496;
				if (num != 0)
				{
				}
				num = (short)1534197761;
				if (num != 0)
				{
				}
				result = this.RMServer.EditIPProgramSystem(sysUuid, changedField, fieldType, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥캩얫\udaad羚쒵ힷ\uddb9캻\udfbd궿釁뷃뗅볇꿉ꇋ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)163446784;
			short num3 = num;
			return result;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00025228 File Offset: 0x00023428
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> ListMatchedIPProgramSystems(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList, int startIndex, int pageSize)
		{
			int a_ = 7;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem> result;
			try
			{
				num = (short)2027588186;
				short num2 = num;
				num = (short)1646758490;
				switch (num2 == num)
				{
				}
				num = (short)874774528;
				if (num != 0)
				{
				}
				result = this.RMServer.ListMatchedIPProgramSystems(radioUUIDList, startIndex, pageSize);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩잭쎯욱靈ힵ첷\ud9b9풻\udbbd꒿证铃雅뫇ꗉꯋ볍뇏뿑蟓꿕ꯗ껙맛돝鏟", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)184811520;
			short num3 = num;
			num = (short)679084033;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0002532C File Offset: 0x0002352C
		public int GetMatchedIPProgramSystemCount(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList)
		{
			int a_ = 14;
			short num;
			int matchedIPProgramSystemCount;
			try
			{
				num = (short)1835423667;
				short num2 = num;
				num = (short)892819379;
				switch (num2 == num)
				{
				}
				num = (short)686555137;
				if (num != 0)
				{
				}
				num = (short)2030567424;
				if (num != 0)
				{
				}
				matchedIPProgramSystemCount = this.RMServer.GetMatchedIPProgramSystemCount(radioUUIDList);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶\udaba즼\udcbe꧀ꛂꇄ軆駈鯊뿌ꃎ뛐ꇒ듔뫖諘ꋚ껜ꯞ蓠転ꛤ裦鳨藪駬", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1401421824;
			short num3 = num;
			return matchedIPProgramSystemCount;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00025428 File Offset: 0x00023628
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3System> GetAllDMR3Systems()
		{
			int a_ = 11;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3System> allDMR3Systems;
			try
			{
				num = (short)760977187;
				short num2 = num;
				num = (short)782276387;
				switch (num2 == num)
				{
				}
				num = (short)239337473;
				if (num != 0)
				{
				}
				num = (short)945160192;
				if (num != 0)
				{
				}
				allDMR3Systems = this.RMServer.GetAllDMR3Systems();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳풷횹銿韃뿅믇뻉꧋ꏍꏏ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1465057280;
			short num3 = num;
			return allDMR3Systems;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00025524 File Offset: 0x00023724
		public int GetALLSACRecordsCount(global::System.Guid systemUUID)
		{
			int a_ = 7;
			short num;
			int allsacrecordsCount;
			try
			{
				num = (short)1155749991;
				short num2 = num;
				num = (short)926505063;
				switch (num2 == num)
				{
				}
				num = (short)957612032;
				if (num != 0)
				{
				}
				num = (short)1325531137;
				if (num != 0)
				{
				}
				allsacrecordsCount = this.RMServer.GetALLSACRecordsCount(systemUUID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쮭쒯蝹﮹ﾻꖿꇁꯃ듅곇막迋ꇍꗏ병ꃓ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)235012096;
			short num3 = num;
			return allsacrecordsCount;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00025624 File Offset: 0x00023824
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetALLSACRecords(global::System.Guid systemUUID, int startIndex, int length)
		{
			int a_ = 12;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> allsacrecords;
			try
			{
				num = (short)1333004513;
				short num2 = num;
				num = (short)336857313;
				switch (num2 == num)
				{
				}
				num = (short)1322713088;
				if (num != 0)
				{
				}
				num = (short)1250230273;
				if (num != 0)
				{
				}
				allsacrecords = this.RMServer.GetALLSACRecords(systemUUID, startIndex, length);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삤펦솨쒪즬閮횲솴ﺾ苀釂ꃄ꓆ꛈ맊꧌볎", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)268107776;
			short num3 = num;
			return allsacrecords;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00025728 File Offset: 0x00023928
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetALLSACRecordsBySerial(global::System.Guid systemUUID, string serialNumber)
		{
			int a_ = 14;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> allsacrecordsBySerial;
			try
			{
				num = (short)1278953519;
				short num2 = num;
				num = (short)1007503407;
				switch (num2 == num)
				{
				}
				num = (short)613679104;
				if (num != 0)
				{
				}
				allsacrecordsBySerial = this.RMServer.GetALLSACRecordsBySerial(systemUUID, serialNumber);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶胀胂韄ꋆ꫈꓊뿌ꯎꋐ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1531052032;
			short num3 = num;
			num = (short)219283457;
			if (num != 0)
			{
			}
			return allsacrecordsBySerial;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00025828 File Offset: 0x00023A28
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetSACRecordsBySerial(string serial)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> sacrecordsBySerial;
			try
			{
				num = (short)1414681776;
				short num2 = num;
				num = (short)1417827504;
				switch (num2 == num)
				{
				}
				num = (short)1498677248;
				if (num != 0)
				{
				}
				sacrecordsBySerial = this.RMServer.GetSACRecordsBySerial(serial);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad\uddb7\ud9b9펻첽꒿뇁蛃뿅鯇꿉뻋ꟍ뇏뻑", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)3538944;
			short num3 = num;
			num = (short)1219624961;
			if (num != 0)
			{
			}
			return sacrecordsBySerial;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00025928 File Offset: 0x00023B28
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> GetSACRecordsByDeviceID(global::System.Guid systemUUID, int deviceID)
		{
			int a_ = 6;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary> sacrecordsByDeviceID;
			try
			{
				num = (short)826273636;
				short num2 = num;
				num = (short)641396580;
				switch (num2 == num)
				{
				}
				num = (short)849084416;
				if (num != 0)
				{
				}
				sacrecordsByDeviceID = this.RMServer.GetSACRecordsByDeviceID(systemUUID, deviceID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨좬\udbae\udcb8\ud8ba튼춾ꗀ냂蟄뻆跈껊믌ꛎ닐뛒鳔鏖", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1755250688;
			short num3 = num;
			num = (short)2001403905;
			if (num != 0)
			{
			}
			return sacrecordsByDeviceID;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00025A28 File Offset: 0x00023C28
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection> GetAllSACSiteSelection(global::System.Guid systemUUID)
		{
			int a_ = 16;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection> allSACSiteSelection;
			try
			{
				num = (short)1747285332;
				short num2 = num;
				num = (short)486241620;
				switch (num2 == num)
				{
				}
				num = (short)857079808;
				if (num != 0)
				{
				}
				allSACSiteSelection = this.RMServer.GetAllSACSiteSelection(systemUUID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("첨\udfaa얬삮햰覲튶춸諸톼펾鋀苂蛄铆ꃈ뿊꣌鳎듐뿒냔듖귘닚닜뇞", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)502333440;
			short num3 = num;
			num = (short)1454637057;
			if (num != 0)
			{
			}
			return allSACSiteSelection;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00025B24 File Offset: 0x00023D24
		public global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection GetSACSiteSelection(global::System.Guid systemUUID, global::System.Guid siteSelUuid)
		{
			int a_ = 15;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection sacsiteSelection;
			try
			{
				num = (short)1631064007;
				short num2 = num;
				num = (short)151719879;
				switch (num2 == num)
				{
				}
				num = (short)243400704;
				if (num != 0)
				{
				}
				sacsiteSelection = this.RMServer.GetSACSiteSelection(systemUUID, siteSelUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵첷ﶻﶽ鎿ꯁ냃ꏅ鯇꿉ꃋꯍ돏ꛑ뷓맕뛗", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1467023360;
			short num3 = num;
			num = (short)1468006401;
			if (num != 0)
			{
			}
			return sacsiteSelection;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00025C24 File Offset: 0x00023E24
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3Site> GetDMR3SitesBySystem(global::System.Guid systemUUID)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3Site> dmr3SitesBySystem;
			try
			{
				num = (short)2145058817;
				if (num != 0)
				{
				}
				num = (short)30045402;
				short num2 = num;
				num = (short)1623618778;
				switch (num2 == num)
				{
				}
				num = (short)1648033792;
				if (num != 0)
				{
				}
				dmr3SitesBySystem = this.RMServer.GetDMR3SitesBySystem(systemUUID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaadﾱ薵펹좻\udbbd뎿胁뷃闅뇇막룋ꯍ뷏", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)855834624;
			short num3 = num;
			return dmr3SitesBySystem;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00025D24 File Offset: 0x00023F24
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3Site> GetSelDMR3Sites(global::System.Guid siteSelUuid)
		{
			int a_ = 10;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DMR3Site> selDMR3Sites;
			try
			{
				num = (short)1833098728;
				short num2 = num;
				num = (short)146398696;
				switch (num2 == num)
				{
				}
				num = (short)1840054273;
				if (num != 0)
				{
				}
				num = (short)1881341952;
				if (num != 0)
				{
				}
				selDMR3Sites = this.RMServer.GetSelDMR3Sites(siteSelUuid);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("욢톤쾦욨쾪鞬풰잲튶햸ﾺ郂계돆곈룊", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)333053952;
			short num3 = num;
			return selDMR3Sites;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00025E24 File Offset: 0x00024024
		public bool DeleteSACRecord(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary record)
		{
			int a_ = 5;
			short num;
			bool result;
			try
			{
				num = (short)1387423661;
				short num2 = num;
				num = (short)770860973;
				switch (num2 == num)
				{
				}
				num = (short)1764687872;
				if (num != 0)
				{
				}
				result = this.RMServer.DeleteSACRecord(batchJobContainerUuid, record);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫슭햯욱톳醴惡\udbbdꎿ귁뛃ꋅ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1742667776;
			short num3 = num;
			num = (short)15269889;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00025F24 File Offset: 0x00024124
		public global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary AddSACRecord(global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacRecord)
		{
			int a_ = 1;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary result;
			try
			{
				num = (short)86571304;
				short num2 = num;
				num = (short)726268200;
				switch (num2 == num)
				{
				}
				num = (short)678887424;
				if (num != 0)
				{
				}
				result = this.RMServer.AddSACRecord(sacRecord);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣첧캩ﾫ톳햵ힷ좹\ud8bb", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1508311040;
			short num3 = num;
			num = (short)1604190209;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00026024 File Offset: 0x00024224
		public global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary EditSACRecord(global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacRecord, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.SACRecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary result;
			try
			{
				num = (short)508456721;
				short num2 = num;
				num = (short)990801681;
				switch (num2 == num)
				{
				}
				num = (short)1958150144;
				if (num != 0)
				{
				}
				result = this.RMServer.EditSACRecord(sacRecord, changedFieldValePair, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쪭\ud9af욱﮷\ud9bb\uddbd꾿냁ꃃ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)64290816;
			short num3 = num;
			num = (short)1955725313;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00026124 File Offset: 0x00024324
		public global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary EditSACRecordBat(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.SACRecord sacRecord, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.SACRecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 13;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary result;
			try
			{
				num = (short)780917622;
				short num2 = num;
				num = (short)1682561910;
				switch (num2 == num)
				{
				}
				num = (short)1142226944;
				if (num != 0)
				{
				}
				result = this.RMServer.EditSACRecordBat(batchJobContainerUuid, sacRecord, changedFieldValePair, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎥\udca7슩쎫쪭誯킳\udfb5첷ﶻﶽ銿ꟁꟃ꧅뫇껉", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)89391104;
			short num3 = num;
			num = (short)614924289;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00026228 File Offset: 0x00024428
		public global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary ImportSACFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportSACFromCSVRequest request, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 2;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.SACRecordSummary result;
			try
			{
				num = (short)1890010111;
				short num2 = num;
				num = (short)1789346815;
				switch (num2 == num)
				{
				}
				num = (short)2045444096;
				if (num != 0)
				{
				}
				num = (short)1384906753;
				if (num != 0)
				{
				}
				result = this.RMServer.ImportSACFromCSV(batchJobContainerUuid, request, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤쒨\udbaa슬\uddae얰ﾸ즺튼튾苀郂鏄", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)225050624;
			short num3 = num;
			return result;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00026328 File Offset: 0x00024528
		public int GetALLTGSARecordsCount(global::System.Guid systemUUID)
		{
			int a_ = 18;
			short num;
			int alltgsarecordsCount;
			try
			{
				num = (short)1298507302;
				short num2 = num;
				num = (short)972989990;
				switch (num2 == num)
				{
				}
				num = (short)130154497;
				if (num != 0)
				{
				}
				num = (short)645136384;
				if (num != 0)
				{
				}
				alltgsarecordsCount = this.RMServer.GetALLTGSARecordsCount(systemUUID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캪\ud9ac잮\udeb0ힲ辴\udcb8쾺ﲼ跀韂苄铆裈駊꣌곎뻐ꇒ뇔ꓖ高듚꣜뇞闠", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)264568832;
			short num3 = num;
			return alltgsarecordsCount;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00026428 File Offset: 0x00024628
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> GetALLTGSARecords(global::System.Guid systemUUID, int startIndex, int count)
		{
			int a_ = 14;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> alltgsarecords;
			try
			{
				num = (short)1741868790;
				short num2 = num;
				num = (short)265539318;
				switch (num2 == num)
				{
				}
				num = (short)2109145088;
				if (num != 0)
				{
				}
				num = (short)1870856193;
				if (num != 0)
				{
				}
				alltgsarecords = this.RMServer.GetALLTGSARecords(systemUUID, startIndex, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶蛀郂蓄闆곈꣊ꋌ뷎뗐ꃒ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)981663744;
			short num3 = num;
			return alltgsarecords;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0002652C File Offset: 0x0002472C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> GetTGSARecordsByTalkGroupID(global::System.Guid systemUUID, int talkGroupID)
		{
			int a_ = 2;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> tgsarecordsByTalkGroupID;
			try
			{
				num = (short)1281097729;
				if (num != 0)
				{
				}
				num = (short)1777767473;
				short num2 = num;
				num = (short)1053791281;
				switch (num2 == num)
				{
				}
				num = (short)666173440;
				if (num != 0)
				{
				}
				tgsarecordsByTalkGroupID = this.RMServer.GetTGSARecordsByTalkGroupID(systemUUID, talkGroupID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤첨\udfaa怜튶\udab8풺쾼\udbbe닀臂별鏆꣈ꟊꛌ裎ꏐ볒ꃔꟖ郘鿚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1957953536;
			short num3 = num;
			return tgsarecordsByTalkGroupID;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0002662C File Offset: 0x0002482C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASiteSelection> GetAllTGSASiteSelection(global::System.Guid systemUUID)
		{
			int a_ = 14;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASiteSelection> allTGSASiteSelection;
			try
			{
				num = (short)2144718303;
				short num2 = num;
				num = (short)1054264799;
				switch (num2 == num)
				{
				}
				num = (short)1788739584;
				if (num != 0)
				{
				}
				num = (short)2043871233;
				if (num != 0)
				{
				}
				allTGSASiteSelection = this.RMServer.GetAllTGSASiteSelection(systemUUID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记킴쎶ힺ톼蛀郂蓄铆ꃈ뿊꣌鳎듐뿒냔듖귘닚닜뇞", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)505348096;
			short num3 = num;
			return allTGSASiteSelection;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0002672C File Offset: 0x0002492C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> DeleteTGSARecords(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> records)
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> result;
			try
			{
				num = (short)1452481912;
				short num2 = num;
				num = (short)1677663608;
				switch (num2 == num)
				{
				}
				num = (short)1467482112;
				if (num != 0)
				{
				}
				result = this.RMServer.DeleteTGSARecords(batchJobContainerUuid, records);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫슭햯욱톳ﾷﶻꖿꇁꯃ듅곇막", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1885208576;
			short num3 = num;
			num = (short)2122317825;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0002682C File Offset: 0x00024A2C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> AddTGSARecords(global::System.Guid batchJobContainerUuid, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> records, global::System.Guid sysUUID)
		{
			int a_ = 14;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSARecord> result;
			try
			{
				num = (short)611390179;
				short num2 = num;
				num = (short)1269175011;
				switch (num2 == num)
				{
				}
				num = (short)1849294848;
				if (num != 0)
				{
				}
				num = (short)1676869633;
				if (num != 0)
				{
				}
				result = this.RMServer.AddTGSARecords(batchJobContainerUuid, records, sysUUID);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("슦\udda8쎪슬쮮记톴펶ﲺﺾ鏀ꛂꛄ꣆믈꿊뻌", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)310247424;
			short num3 = num;
			return result;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x00026930 File Offset: 0x00024B30
		public global::Motorola.CommonCPS.Server.EntityModel.TGSARecord EditTGSARecord(global::System.Guid tgsaRecordUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TGSARecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 0;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TGSARecord result;
			try
			{
				num = (short)1607872677;
				short num2 = num;
				num = (short)462958757;
				switch (num2 == num)
				{
				}
				num = (short)839843840;
				if (num != 0)
				{
				}
				result = this.RMServer.EditTGSARecord(tgsaRecordUuid, changedFieldValePair, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢쎦삨\udfaa怜튶\udab8풺쾼\udbbe", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)327548928;
			short num3 = num;
			num = (short)1234173953;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00026A34 File Offset: 0x00024C34
		public global::Motorola.CommonCPS.Server.EntityModel.TGSARecord EditTGSARecordBat(global::System.Guid batchJobContainerUuid, global::System.Guid tgsaRecordUuid, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TGSARecordFieldType, object>> changedFieldValePair, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 7;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TGSARecord result;
			try
			{
				num = (short)1220996029;
				short num2 = num;
				num = (short)1383459773;
				switch (num2 == num)
				{
				}
				num = (short)2138701825;
				if (num != 0)
				{
				}
				num = (short)1806368768;
				if (num != 0)
				{
				}
				result = this.RMServer.EditTGSARecordBat(batchJobContainerUuid, tgsaRecordUuid, changedFieldValePair, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩쪭\ud9af욱﮹\udbbdꎿ귁뛃ꋅ談ꯉ룋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)796459008;
			short num3 = num;
			return result;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00026B3C File Offset: 0x00024D3C
		public global::Motorola.CommonCPS.Server.EntityModel.TGSARecord ImportTGSAFromCSV(global::System.Guid batchJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.ImportTGSAFromCSVRequest request, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 6;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.TGSARecord result;
			try
			{
				num = (short)1898299193;
				short num2 = num;
				num = (short)956546873;
				switch (num2 == num)
				{
				}
				num = (short)931921920;
				if (num != 0)
				{
				}
				num = (short)313917441;
				if (num != 0)
				{
				}
				result = this.RMServer.ImportTGSAFromCSV(batchJobContainerUuid, request, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨사\udfae\udeb0솲솴ﺸﲼ料돀곂꣄蓆髈鷊", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)994508800;
			short num3 = num;
			return result;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00026C3C File Offset: 0x00024E3C
		public bool UpdateSACSiteSelectionBatch(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SACSiteSelection> sacSiteSelections)
		{
			int a_ = 4;
			short num;
			bool result;
			try
			{
				num = (short)970298804;
				short num2 = num;
				num = (short)308712884;
				switch (num2 == num)
				{
				}
				num = (short)97189889;
				if (num != 0)
				{
				}
				num = (short)135004160;
				if (num != 0)
				{
				}
				result = this.RMServer.EditSACSiteSelectionBatch(sacSiteSelections);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦ﲨ\udbaa즬캮얰횲視풼쮾꓀郂ꃄꯆ곈꣊만ꛎ뻐뷒韔뛖귘룚뗜", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1949892608;
			short num3 = num;
			return result;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00026D38 File Offset: 0x00024F38
		public bool UpdateTGSASiteSelectionBatch(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.TGSASiteSelection> tgsaSiteSelections)
		{
			int a_ = 0;
			short num;
			bool result;
			try
			{
				num = (short)117588253;
				short num2 = num;
				num = (short)768557341;
				switch (num2 == num)
				{
				}
				num = (short)830210049;
				if (num != 0)
				{
				}
				num = (short)415236096;
				if (num != 0)
				{
				}
				result = this.RMServer.EditTGSASiteSelectionBatch(tgsaSiteSelections);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda96ﲘ얠馢힦춨쪪\ud9ac쪮튺즼\udabe鋀ꛂ꧄ꋆ꫈뿊꓌ꃎ뿐釒듔ꏖ뫘돚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1280573440;
			short num3 = num;
			return result;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00026E38 File Offset: 0x00025038
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioManagementLicenseInfo> GetRadioManagementFeature()
		{
			int a_ = 5;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioManagementLicenseInfo> radioManagementFeaure;
			try
			{
				num = (short)1482946999;
				short num2 = num;
				num = (short)988019127;
				switch (num2 == num)
				{
				}
				num = (short)946995200;
				if (num != 0)
				{
				}
				radioManagementFeaure = this.RMServer.GetRadioManagementFeaure();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧즫\udaad펱킳\udfb5ힷ\uddbb킽ꆿꗁꇃꯅ귇꓉룋裍뗏돑ꃓꏕ꫗뿙", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)208797696;
			short num3 = num;
			num = (short)224854017;
			if (num != 0)
			{
			}
			return radioManagementFeaure;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00026F38 File Offset: 0x00025138
		public byte[] GetAppLicenses()
		{
			int a_ = 19;
			short num;
			byte[] license;
			try
			{
				num = (short)1765234970;
				short num2 = num;
				num = (short)1873303834;
				switch (num2 == num)
				{
				}
				num = (short)496959488;
				if (num != 0)
				{
				}
				num = (short)2015887361;
				if (num != 0)
				{
				}
				license = this.RMServer.GetLicense();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵ﾷ\udfb9좻ꖿꗁ귃뗅볇꿉뻋ꯍ듏鏑ꓓꛕ铗동뿛믝軟釡臣闥", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)168296448;
			short num3 = num;
			return license;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00027038 File Offset: 0x00025238
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary> ListApplicationFeatureSummaries()
		{
			int a_ = 17;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary> result;
			try
			{
				num = (short)1335790524;
				short num2 = num;
				num = (short)1901956028;
				switch (num2 == num)
				{
				}
				num = (short)97583104;
				if (num != 0)
				{
				}
				result = this.RMServer.ListApplicationFeatureSummaries();
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳蝹톷즹좻ﾽ낿닁ꣃ꿅ꯇꯉ룋ꟍ뿏병鋓돕맗껙꧛곝藟뇡釣该藧诩黫蟭闯臱", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1030225920;
			short num3 = num;
			num = (short)2003828737;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00027138 File Offset: 0x00025338
		public global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary UpdateApplicationFeatureComments(string featureName, string comments, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 4;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary result;
			try
			{
				num = (short)1195004485;
				short num2 = num;
				num = (short)1577472581;
				switch (num2 == num)
				{
				}
				num = (short)319619072;
				if (num != 0)
				{
				}
				result = this.RMServer.UpdateApplicationFeatureComments(featureName, comments, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦ﲨ\udbaa즬캮얰횲잶즸ힺ풼\udcbeꃀ럂계꣆ꟈ跊꣌껎ꗐꛒ꟔닖高듚냜닞蓠跢釤铦", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1679818752;
			short num3 = num;
			num = (short)580517889;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00027238 File Offset: 0x00025438
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary QueryAndUpdateRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, int? keyType, int? systemOwnerKeyId, bool? writeProtected, bool? askRequired, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet)
		{
			int a_ = 6;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)824601502;
				short num2 = num;
				num = (short)1179741086;
				switch (num2 == num)
				{
				}
				num = (short)718077952;
				if (num != 0)
				{
				}
				result = this.RMServer.QueryAndUpdateRadio(batchJobContainerUuid, radioUuid, keyType, systemOwnerKeyId, writeProtected, askRequired, validateEntitySet);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨\udfac쪮킰잲킴\udab8쾺풼즾ꃀ럂계꣆ꟈ駊꣌뻎ꓐ뛒ꛔꏖ蛘飚釜鏞", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)151584768;
			short num3 = num;
			num = (short)695664641;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00027340 File Offset: 0x00025540
		public global::Motorola.CommonCPS.Server.EntityModel.RecordSummary GetConfigRecordByName(string configName)
		{
			int a_ = 3;
			short num = (short)1595080704;
			short num2 = num;
			num = (short)495133856;
			short num3 = num;
			num = (short)825762976;
			switch (num3 == num)
			{
			}
			num = (short)379781121;
			if (num != 0)
			{
			}
			num = (short)344719360;
			if (num != 0)
			{
			}
			return this.GetSetSummary(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud999욟쮡쎣향", a_), configName);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00027408 File Offset: 0x00025608
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.LanguageDetailInfo> GetRadioLanguagesDetailInfo(global::System.Guid radioUUID)
		{
			short num = (short)1802240000;
			short num2 = num;
			num = (short)548811220;
			short num3 = num;
			num = (short)1669673428;
			switch (num3 == num)
			{
			}
			num = (short)390004736;
			if (num != 0)
			{
			}
			num = (short)1341784065;
			if (num != 0)
			{
			}
			return this.RMServer.GetLPDetailInfo(radioUUID);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000274C0 File Offset: 0x000256C0
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRDeviceCertificateDetailInfo> GetRadioPCRDeviceCertificateDetailInfo(global::System.Guid radioUUID)
		{
			short num = (short)386334720;
			short num2 = num;
			num = (short)1421189319;
			short num3 = num;
			num = (short)1180934343;
			switch (num3 == num)
			{
			}
			num = (short)2027290625;
			if (num != 0)
			{
			}
			num = (short)111214592;
			if (num != 0)
			{
			}
			return this.RMServer.GetPCRDeviceCertificatesDetailInfo(radioUUID);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00027578 File Offset: 0x00025778
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary EditPCRDeviceCertificate(global::System.Guid radioUuid, global::System.Guid deviceCertUuid, global::System.Collections.Generic.Dictionary<string, object> fieldValues, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 17;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)1517062936;
				short num2 = num;
				num = (short)94931736;
				switch (num2 == num)
				{
				}
				num = (short)819396608;
				if (num != 0)
				{
				}
				result = this.RMServer.EditPCRDeviceCertificate(radioUuid, deviceCertUuid, fieldValues, set);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쾩\ud8ab욭\udfaf횱躳\udcb7펹좻莿郁胃ꏅ뻇ꏉ꿋ꯍ鏏럑ꛓꋕ뇗볙뗛뷝臟雡臣", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)470876160;
			short num3 = num;
			num = (short)854327297;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00027680 File Offset: 0x00025880
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.VADetailInfo> GetRadioVADetailInfo(global::System.Guid radioUUID)
		{
			short num = (short)1071316992;
			short num2 = num;
			num = (short)139826660;
			short num3 = num;
			num = (short)942249444;
			switch (num3 == num)
			{
			}
			num = (short)213188609;
			if (num != 0)
			{
			}
			num = (short)205651968;
			if (num != 0)
			{
			}
			return this.RMServer.GetVADetailInfo(radioUUID);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00027734 File Offset: 0x00025934
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApkApplicationDesc> GetRadioApkAppDetailInfo(global::System.Guid radioUUID)
		{
			short num = (short)301727744;
			short num2 = num;
			num = (short)284025286;
			short num3 = num;
			num = (short)677503430;
			switch (num3 == num)
			{
			}
			num = (short)1365835777;
			if (num != 0)
			{
			}
			num = (short)1241120768;
			if (num != 0)
			{
			}
			return this.RMServer.GetApkAppDetailInfo(radioUUID);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000277E8 File Offset: 0x000259E8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.CertificatesDesc> GetRadioCertificateDetailInfo(global::System.Guid radioUUID)
		{
			short num = (short)1643315200;
			short num2 = num;
			num = (short)1960459206;
			short num3 = num;
			num = (short)1736588230;
			switch (num3 == num)
			{
			}
			num = (short)332201985;
			if (num != 0)
			{
			}
			num = (short)2091384832;
			if (num != 0)
			{
			}
			return this.RMServer.GetCertificateDetailInfo(radioUUID);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000278A0 File Offset: 0x00025AA0
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyGeneralPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets)
		{
			int a_ = 2;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)1032435532;
				short num2 = num;
				num = (short)1815459660;
				switch (num2 == num)
				{
				}
				num = (short)381812736;
				if (num != 0)
				{
				}
				result = this.RMServer.ApplyGeneralPackagesToRadio(batchJobContainerUuid, radioUuid, packageUuids, type, packageVersion, validateEntitySets);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풘ﺚ캠잢龤\ud9a8\udbaa솬횮횲\udbb4튶쮸\udaba톼ꃀꃂ껄ꛆ껈껊뻌鯎뻐臒듔돖냘듚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)193921024;
			short num3 = num;
			num = (short)756219905;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000279A8 File Offset: 0x00025BA8
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary ApplyPBBPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets)
		{
			int a_ = 6;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)1199151341;
				short num2 = num;
				num = (short)757897453;
				switch (num2 == num)
				{
				}
				num = (short)1896284160;
				if (num != 0)
				{
				}
				result = this.RMServer.ApplyPBBPackagesToRadio(batchJobContainerUuid, radioUuid, packageUuids, type, packageVersion, validateEntitySets);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킜爵햠쮢쪤쎦鎨\uddac\udfae\uddb0쪲﮸\udcbc\udcbeꫀꋂꋄꋆ뫈鿊ꋌ鷎냐럒볔룖", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1658322944;
			short num3 = num;
			num = (short)614072321;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00027AB0 File Offset: 0x00025CB0
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpdatePBBPackagesToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::System.Collections.Generic.List<global::System.Guid> packageUuids, global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, string packageVersion, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySets)
		{
			int a_ = 8;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)804325162;
				short num2 = num;
				num = (short)1308624682;
				switch (num2 == num)
				{
				}
				num = (short)645922816;
				if (num != 0)
				{
				}
				num = (short)203620353;
				if (num != 0)
				{
				}
				result = this.RMServer.UpdatePBBPackagesToRadio(batchJobContainerUuid, radioUuid, packageUuids, type, packageVersion, validateEntitySets);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪\udfae햰튲솴튶了ﾼꃀꃂ껄ꛆ껈껊뻌鯎뻐臒듔돖냘듚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1747189760;
			short num3 = num;
			return result;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00027BB8 File Offset: 0x00025DB8
		public int InitialDBUpradeProcess(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeInfo upgradeInfo)
		{
			int a_ = 7;
			short num;
			int result;
			try
			{
				num = (short)1042966547;
				short num2 = num;
				num = (short)824141843;
				switch (num2 == num)
				{
				}
				num = (short)486735872;
				if (num != 0)
				{
				}
				num = (short)1702363137;
				if (num != 0)
				{
				}
				result = this.RMServer.InitialDBUpradeProcess(upgradeInfo);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩삭\ud9af욱\uddb3ힵ풷ﺹﺻ낿냁ꗃꋅ귇髉뻋ꇍ돏럑ꟓꗕ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1214447616;
			short num3 = num;
			return result;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00027CBC File Offset: 0x00025EBC
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DBNode> GetNextInitDNodes(int exceptCount)
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DBNode> nextInitDNodes;
			try
			{
				num = (short)1803117324;
				short num2 = num;
				num = (short)2126078732;
				switch (num2 == num)
				{
				}
				num = (short)1847853057;
				if (num != 0)
				{
				}
				num = (short)1187250176;
				if (num != 0)
				{
				}
				nextInitDNodes = this.RMServer.GetNextInitDNodes(exceptCount);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵첷\ud9bb욽뒿证꫃꿅볇軉苋ꇍ듏럑ꟓ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)441647104;
			short num3 = num;
			return nextInitDNodes;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00027DC0 File Offset: 0x00025FC0
		public void SaveDBNodeInitStructure(global::Motorola.CommonCPS.Server.EntityModel.DBNode node)
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)2119899409;
				short num2 = num;
				num = (short)70523153;
				switch (num2 == num)
				{
				}
				num = (short)2131558400;
				if (num != 0)
				{
				}
				this.RMServer.SaveDBNodeInitStructure(node);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵\udbb9쪻\udbbd蒿胁諃꧅곇꿉藋ꃍ맏ꛑ蟓ꋕ꫗꿙뿛ꫝ闟郡臣", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)603652096;
			short num3 = num;
			num = (short)120127489;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00027EC4 File Offset: 0x000260C4
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeSet GetNextResolvingDBNodes(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeResolverSetRequest request)
		{
			int a_ = 11;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeSet nextResolvingDBNodes;
			try
			{
				num = (short)1884845544;
				short num2 = num;
				num = (short)688616936;
				switch (num2 == num)
				{
				}
				num = (short)148701184;
				if (num != 0)
				{
				}
				nextResolvingDBNodes = this.RMServer.GetNextResolvingDBNodes(request);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("솣튥삧얩좫钭ힱ삳\uddb7승좻ꖿ뇁ꯃ꫅뻇ꏉꋋ꧍铏郑髓맕볗뿙꿛", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1698693120;
			short num3 = num;
			num = (short)70713345;
			if (num != 0)
			{
			}
			return nextResolvingDBNodes;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00027FC8 File Offset: 0x000261C8
		public void SaveDBResolverResult(global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBResolverSaveData result)
		{
			int a_ = 1;
			short num;
			try
			{
				num = (short)836940666;
				short num2 = num;
				num = (short)1361490810;
				switch (num2 == num)
				{
				}
				num = (short)72089600;
				if (num != 0)
				{
				}
				num = (short)327681;
				if (num != 0)
				{
				}
				this.RMServer.SaveDBResolverResult(result);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햗ﾙ쾟욡麣즧\udca9즫톳억ힷ횹쪻\udbbd늿郁ꇃ뗅뷇ꛉ룋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)66125824;
			short num3 = num;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000280C8 File Offset: 0x000262C8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> GetNextDBUpgradeFinalizingSets(string setType, int count)
		{
			int a_ = 15;
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> nextDBUpgradeFinalizingSets;
			try
			{
				num = (short)1494176203;
				short num2 = num;
				num = (short)1599951307;
				switch (num2 == num)
				{
				}
				num = (short)1259405312;
				if (num != 0)
				{
				}
				nextDBUpgradeFinalizingSets = this.RMServer.GetNextDBUpgradeFinalizingSets(setType, count);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춧\udea9쒫솭풯袱펵첷\ud9bb욽뒿蛁蛃鏅룇귉뻋꿍듏럑鋓뿕뛗믙냛럝髟诡諣臥믧迩飫鷭", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)140771328;
			short num3 = num;
			num = (short)1790705665;
			if (num != 0)
			{
			}
			return nextDBUpgradeFinalizingSets;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000281C8 File Offset: 0x000263C8
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> SaveUpgradeFinalizeSet(global::Motorola.CommonCPS.Server.EntityModel.BLEditSaveDataArg bllSaveData)
		{
			int a_ = 19;
			short num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> result;
			try
			{
				num = (short)2016259022;
				short num2 = num;
				num = (short)547204046;
				switch (num2 == num)
				{
				}
				num = (short)101449728;
				if (num != 0)
				{
				}
				result = this.RMServer.SaveUpgradeFinalizeSet(bllSaveData);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즫\udaad\ud8af\uddb1킳貵\udbb9쪻\udbbd閿닁ꏃ듅꧇껉꧋裍맏병뗓뫕뇗ꃙ맛距藟雡", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1007812608;
			short num3 = num;
			num = (short)1098055681;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000282C8 File Offset: 0x000264C8
		public void SetCurrentDataModelVersion(global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion)
		{
			int a_ = 4;
			short num;
			try
			{
				num = (short)1873543341;
				short num2 = num;
				num = (short)888012973;
				switch (num2 == num)
				{
				}
				num = (short)867893249;
				if (num != 0)
				{
				}
				num = (short)2081095680;
				if (num != 0)
				{
				}
				this.RMServer.SetCurrentDataModelVersion(currentDataModelVersion);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦直캪\ud9ac쒰솲잴튶ힸ쾺寮\udebe뗀ꋂ裄꣆귈껊ꇌ駎듐ꇒꛔ뻖뛘뗚", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1723138048;
			short num3 = num;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000283C4 File Offset: 0x000265C4
		public global::System.Collections.Generic.IList<string> GetUpgradeHandlerParameterRequest(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac, global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion)
		{
			int a_ = 8;
			short num;
			global::System.Collections.Generic.IList<string> upgradeHandlerParameterRequest;
			try
			{
				num = (short)985035571;
				short num2 = num;
				num = (short)1862103859;
				switch (num2 == num)
				{
				}
				num = (short)1306198016;
				if (num != 0)
				{
				}
				upgradeHandlerParameterRequest = this.RMServer.GetUpgradeHandlerParameterRequest(pac, currentDataModelVersion);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("튞쒠힢춤좦춨醪쪮얰어킶쮸\udaba\ud9bc\udabe觀ꋂꯄꏆꗈ껊뿌鿎냐ꇒ듔뫖볘꿚룜귞돠蛢铤鋦賨飪駬", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1945370624;
			short num3 = num;
			num = (short)687013889;
			if (num != 0)
			{
			}
			return upgradeHandlerParameterRequest;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000284C4 File Offset: 0x000266C4
		public void RunDBUpgradeHandler(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac, global::Motorola.CommonCPS.Server.EntityModel.BLVersion currentDataModelVersion, global::System.Collections.Generic.Dictionary<string, object> parameters)
		{
			int a_ = 7;
			short num;
			try
			{
				num = (short)1483931649;
				if (num != 0)
				{
				}
				num = (short)1328873802;
				short num2 = num;
				num = (short)235471178;
				switch (num2 == num)
				{
				}
				num = (short)564527104;
				if (num != 0)
				{
				}
				this.RMServer.RunDBUpgradeHandler(pac, currentDataModelVersion, parameters);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("펝얟횡첣즥첧邩ﺫ\udbad\udeaf좷\uddb9캻\udfbd꒿ꟁ賃Ʂꛇ껉ꃋꯍꋏ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2129133568;
			short num3 = num;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000285C4 File Offset: 0x000267C4
		private void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)2144317513;
			short num2 = num;
			num = (short)169717833;
			switch (num2 == num)
			{
			}
			num = (short)294977536;
			short num3 = num;
			num = (short)1818230784;
			if (num != 0)
			{
			}
			num = (short)119668737;
			if (num != 0)
			{
			}
			this.IsConnected = false;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected = false;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted connectionClosedFaulted = this.ConnectionClosedFaulted;
			if (connectionClosedFaulted == null)
			{
				return;
			}
			connectionClosedFaulted();
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0002868C File Offset: 0x0002688C
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)291350741;
			short num2 = num;
			num = (short)1398450389;
			switch (num2 == num)
			{
			}
			num = (short)1289355264;
			short num3 = num;
			num = (short)1619787777;
			if (num != 0)
			{
			}
			num = (short)674430976;
			if (num != 0)
			{
			}
			this.g = null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0002873C File Offset: 0x0002693C
		private void c()
		{
			short num = (short)861498593;
			short num2 = num;
			num = (short)700345569;
			switch (num2 == num)
			{
			}
			num = (short)936771584;
			short num3 = num;
			num = (short)1985806336;
			if (num != 0)
			{
			}
			num = (short)564658177;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000287E4 File Offset: 0x000269E4
		private void b()
		{
			int a_ = 4;
			short num;
			try
			{
				num = (short)1365245952;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					global::System.Collections.Generic.IList<string> systemKeyPermissions;
					global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData> list;
					global::ASK.Interface.ISystemKeyManager instance;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							if (systemKeyPermissions.Count > 0)
							{
								num = (short)126025734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B0;
						case 1:
							goto IL_2B0;
						case 2:
							num = (short)2107834368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_2C8;
						case 4:
							try
							{
								num = (short)2008154115;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator;
									switch (num2)
									{
									case 0:
										num = (short)635961345;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_23F;
									case 2:
										if (!enumerator.MoveNext())
										{
											num = (short)7208960;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_19D;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_163;
										}
										continue;
									case 4:
									{
										num = (short)1942701263;
										short num3 = num;
										num = (short)1796490447;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_19D;
										default:
											num = (short)2078081024;
											if (num != 0)
											{
											}
											break;
										}
										break;
									}
									}
									IL_165:
									num = (short)1250689026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_163:
									goto IL_165;
									IL_19D:
									global::ASK.Interface.SystemKeyPermissionData item = global::Motorola.Security.SamlCommonUtility.Serializers.BinaryDeserialize<global::ASK.Interface.SystemKeyPermissionData>(global::Motorola.Security.SamlCommonUtility.GZipUtilty.Decompress(global::System.Convert.FromBase64String(enumerator.Current)));
									list.Add(item);
									num = (short)186974212;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_23F:
								goto IL_C0;
							}
							finally
							{
								num = (short)1925382145;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<string> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)105644034;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_278;
										}
										continue;
									case 2:
										goto IL_2AD;
									}
									IL_278:
									if (enumerator == null)
									{
										break;
									}
									num = (short)453705728;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2AD:;
							}
							goto IL_2B0;
							IL_C0:
							instance.LoadUserKeys(list);
							num = (short)1991311361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (systemKeyPermissions != null)
							{
								num = (short)687603714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B0;
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<string> enumerator = systemKeyPermissions.GetEnumerator();
							num = (short)2019688452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_53;
						IL_2B0:
						num = (short)928120835;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C8:
					break;
					IL_53:
					instance = global::ASKLib.SystemKeyManager.GetInstance();
					instance.ClearNonDefaultUserKeys();
					list = new global::System.Collections.Generic.List<global::ASK.Interface.SystemKeyPermissionData>();
					systemKeyPermissions = this.GetSystemKeyPermissions();
					num = (short)265224197;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("횚즠첢솤鶦쒪첬쮮쪲운쎶\udcb8횺\udabe룀냂", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2144075776;
			short num4 = num;
			num = (short)1457389569;
			if (num != 0)
			{
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00028B90 File Offset: 0x00026D90
		private global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement a(string A_0, string A_1, string A_2, int A_3, string A_4, string A_5 = "", string A_6 = null, global::System.Security.SecureString A_7 = null, bool A_8 = false, string A_9 = null)
		{
			int a_ = 12;
			short num = (short)167470718;
			short num2 = num;
			num = (short)1450796670;
			switch (num2 == num)
			{
			}
			num = (short)335020032;
			short num3 = num;
			num = (short)1087766529;
			if (num != 0)
			{
			}
			num = (short)1661927424;
			if (num != 0)
			{
			}
			string svcType = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("삨\ud8aa캬삮잰횲잴캶\udeba쾼즾꓀뇂", a_);
			this.f = global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.CreateClientChannelEx2<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement>(A_0, A_1, A_2, A_3, svcType, A_5, A_6, A_7, A_8, 5, 2000, "", A_9);
			return this.f.CreateChannel();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00028C80 File Offset: 0x00026E80
		private global::Motorola.CommonCPS.Server.EntityModel.RMFile a(global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType, global::System.Guid fileUuid, long offset, byte[] data, int dataLen, long fileLen, string sha256Hash)
		{
			int a_ = 5;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RMFile result;
			try
			{
				num = (short)1968467114;
				short num2 = num;
				num = (short)1262775466;
				switch (num2 == num)
				{
				}
				num = (short)1807286272;
				if (num != 0)
				{
				}
				result = this.RMServer.AddFileEnhancement(fileType, fileUuid, offset, data, dataLen, fileLen, sha256Hash);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("톛ﮝ풟쪡쮣슥銧좫쪭\udbb1\ud8b3펵ﶷ풹풻\udfbd꺿ꇁꇃꯅ귇꓉룋", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)2056126464;
			short num3 = num;
			num = (short)6553601;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00028D88 File Offset: 0x00026F88
		private string a(global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage A_0)
		{
			short num = (short)2010054664;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_69;
				case 1:
					if (A_0 is global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack)
					{
						num = (short)1850736647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1570242566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_198;
				case 3:
				{
					num = (short)405424552;
					short num3 = num;
					num = (short)1466386856;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					default:
						num = (short)1780940801;
						if (num != 0)
						{
						}
						num = (short)1690370048;
						if (num != 0)
						{
						}
						if (A_0 is global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles)
						{
							num = (short)1152122882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_238;
					}
					break;
				}
				case 4:
					if (A_0 is global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates)
					{
						num = (short)759431177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1014759427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_227;
				case 6:
					if (A_0 is global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement)
					{
						num = (short)1434845189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2124742660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_BC;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 9:
					goto IL_1E0;
				}
				goto IL_4C;
				IL_54:
				num = (short)329252864;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C:
				if (A_0 is global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware)
				{
					goto IL_54;
				}
				num = (short)1138163713;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_69:
			return (A_0 as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware).PackageName;
			IL_BC:
			num = (short)308871168;
			short num4 = num;
			return (A_0 as global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack).PackageName;
			IL_198:
			return (A_0 as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles).PackageName;
			IL_1E0:
			return (A_0 as global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates).PackageName;
			IL_227:
			return (A_0 as global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement).PackageName;
			IL_238:
			return string.Empty;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00028FD4 File Offset: 0x000271D4
		private string a(byte[] A_0, string A_1, string A_2)
		{
			short num;
			for (;;)
			{
				num = (short)2142896128;
				switch (num)
				{
				default:
				{
					num = (short)1230438401;
					if (num != 0)
					{
					}
					num = (short)1592701563;
					short num2 = num;
					num = (short)410104443;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7A;
					}
					break;
				}
				}
			}
			IL_7A:
			num = (short)1759772672;
			short num3 = num;
			num = (short)809697280;
			if (num != 0)
			{
			}
			string tempPath = global::System.IO.Path.GetTempPath();
			int num4 = A_1.LastIndexOf('.');
			string str;
			if (num4 >= 0)
			{
				str = A_1.Substring(num4);
				goto IL_16E;
			}
			IL_15C:
			str = string.Empty;
			IL_16E:
			string text = global::System.IO.Path.Combine(tempPath, A_2 + str);
			global::System.IO.FileStream fileStream = new global::System.IO.FileStream(text, global::System.IO.FileMode.OpenOrCreate);
			try
			{
				fileStream.Write(A_0, 0, A_0.Length);
				fileStream.Flush();
				fileStream.Close();
				return text;
			}
			finally
			{
				num = (short)1674051585;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num5)
					{
					case 0:
						((global::System.IDisposable)fileStream).Dispose();
						num = (short)1124859906;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_123;
						}
						continue;
					case 2:
						goto IL_159;
					}
					IL_123:
					if (fileStream == null)
					{
						break;
					}
					num = (short)542113792;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_159:;
			}
			goto IL_15C;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0002917C File Offset: 0x0002737C
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.ConfigurationArgs.SaveAsResult CopyTopSet(global::Motorola.CommonCPS.Server.EntityModel.CopyTopSetParameter para)
		{
			short num = (short)190452626;
			short num2 = num;
			num = (short)328930194;
			switch (num2 == num)
			{
			}
			num = (short)1905524736;
			short num3 = num;
			num = (short)689831937;
			if (num != 0)
			{
			}
			num = (short)1105395712;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0002922C File Offset: 0x0002742C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary UpgradeRadioCodeplugVersion(global::System.Guid batchJobContainerUuid, global::System.Guid radioUuid, global::Motorola.CommonCPS.Server.GenericModel.ResultOfUpgradeCPVersion _ResultOfUpgradeCPVersion, string jobName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set)
		{
			int a_ = 3;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.RadioSummary result;
			try
			{
				num = (short)76477868;
				short num2 = num;
				num = (short)1858467244;
				switch (num2 == num)
				{
				}
				num = (short)2077360129;
				if (num != 0)
				{
				}
				num = (short)175570944;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.UpgradeCodeplugVersionBatchJobParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.UpgradeCodeplugVersionBatchJobParameter(batchJobContainerUuid, radioUuid, _ResultOfUpgradeCPVersion, set);
				result = this.RMServer.UpgradeRadioCodeplugVersion(parameter);
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Logger.Log(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힙鍊좟춡삣鲥캩얫\udaad\uddb1\udab3킵톷\uddb9즻첽ꆿ뛁귃꧅ꛇ", a_), ex, global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.LogLevel.Error);
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_GeneralFaultException, this.j);
			}
			num = (short)1480327168;
			short num3 = num;
			return result;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00029334 File Offset: 0x00027534
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary TurnOffMNISCPIndicatior(string deviceID)
		{
			short num = (short)861346874;
			short num2 = num;
			num = (short)1628314682;
			switch (num2 == num)
			{
			}
			num = (short)381026304;
			short num3 = num;
			num = (short)415694849;
			if (num != 0)
			{
			}
			num = (short)456458240;
			if (num != 0)
			{
			}
			return this.RMServer.TurnOffMNISCPIndicatior(deviceID);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000293EC File Offset: 0x000275EC
		private void a()
		{
			int a_ = 8;
			short num;
			try
			{
				num = (short)839778305;
				if (num != 0)
				{
				}
				global::System.Security.Cryptography.X509Certificates.X509Certificate2 selectedCertificate = global::Motorola.Common.Cryptography.CryptographyFacade.GetProvider(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﲞ춠쪢삤즦\udda8", a_)).SelectedCertificate;
			}
			catch (global::System.Exception ex)
			{
				if (ex is global::Motorola.Common.Cryptography.Exceptions.NoCertificatesFoundException)
				{
					global::Motorola.Common.Cryptography.CertificateType.Sha256Rsa.ToString();
					global::Motorola.Security.SamlTokenComponent.SamlTokenHelper.ImportClientCertificate(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udc9e캠캢좤좦잨\uddac\udcae莰蚲莴햸튺\ud8bc톾뗀", a_), true);
				}
				else
				{
					num = (short)1020625931;
					short num2 = num;
					num = (short)642417675;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1657208832;
						if (num != 0)
						{
						}
						throw;
					}
				}
			}
			num = (short)539230208;
			short num3 = num;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00029504 File Offset: 0x00027704
		// Note: this type is marked as 'beforefieldinit'.
		static RmServerAccessor()
		{
			short num = (short)191767188;
			short num2 = num;
			num = (short)686563988;
			switch (num2 == num)
			{
			}
			num = (short)1265500160;
			short num3 = num;
			num = (short)1104216064;
			if (num != 0)
			{
			}
			num = (short)2126249985;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RmServerAccessor.b = new object();
		}

		// Token: 0x04000020 RID: 32
		private const string a = "{8442AEE9-C610-4FEB-8577-2977C98C6DE2}";

		// Token: 0x04000021 RID: 33
		private static readonly object b;

		// Token: 0x04000022 RID: 34
		private string c;

		// Token: 0x04000023 RID: 35
		private global::Motorola.CommonCPS.Server.RMServerContract.IRMServer d;

		// Token: 0x04000024 RID: 36
		private global::System.ServiceModel.DuplexChannelFactory<global::Motorola.CommonCPS.Server.RMServerContract.IRMServer> e;

		// Token: 0x04000025 RID: 37
		private global::System.ServiceModel.ChannelFactory<global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement> f;

		// Token: 0x04000026 RID: 38
		private global::Motorola.CommonCPS.Server.RMDiscoveryServiceInterface.IRMServiceManagement g;

		// Token: 0x04000027 RID: 39
		private global::Motorola.CommonCPS.Server.EntityModel.RMCInfo h;

		// Token: 0x04000028 RID: 40
		private global::Motorola.CommonCPS.Server.EntityModel.BLVersion i;

		// Token: 0x04000029 RID: 41
		private string j;

		// Token: 0x0400002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x0400002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.CustomException.CommonErrorCode l;

		// Token: 0x0400002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerEventHandler m;

		// Token: 0x0400002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IncompatibilityHandler n;

		// Token: 0x0400002E RID: 46
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler o;

		// Token: 0x0400002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.ConnectionClosedFaulted p;

		// Token: 0x04000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler q;
	}
}
