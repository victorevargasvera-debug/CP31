using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Newtonsoft.Json.Linq;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000021 RID: 33
	public abstract class ServiceBase : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000491 RID: 1169 RVA: 0x000299CC File Offset: 0x00027BCC
		public ServiceBase(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase validationServiceBase)
		{
			this.ServerAccessor = serverAccessor;
			this.ValidationService = validationServiceBase;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000299F0 File Offset: 0x00027BF0
		public ServiceBase(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor)
		{
			this.ServerAccessor = serverAccessor;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00029A0C File Offset: 0x00027C0C
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00029ABC File Offset: 0x00027CBC
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor ServerAccessor
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)621991950;
				short num2 = num;
				num = (short)1910953998;
				switch (num2 == num)
				{
				default:
				{
					num = (short)854261760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)386138112;
				if (num != 0)
				{
				}
				num = (short)232390657;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)732646558;
				short num2 = num;
				num = (short)2092977310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)577830912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2067857409;
				if (num != 0)
				{
				}
				num = (short)802357248;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00029B6C File Offset: 0x00027D6C
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00029C1C File Offset: 0x00027E1C
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase ValidationService
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)615178588;
				short num2 = num;
				num = (short)836886876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1494089728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1847001088;
				if (num != 0)
				{
				}
				num = (short)751501313;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1781977699;
				short num2 = num;
				num = (short)625922659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)495452160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505151489;
				if (num != 0)
				{
				}
				num = (short)1386020864;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00029CD0 File Offset: 0x00027ED0
		public global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob AddBatchOperationJob(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJob job)
		{
			short num = (short)796274088;
			short num2 = num;
			num = (short)1427975592;
			switch (num2 == num)
			{
			default:
			{
				num = (short)544931840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1578696705;
			if (num != 0)
			{
			}
			num = (short)76546048;
			if (num != 0)
			{
			}
			return this.ServerAccessor.AddBatchJob(job);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00029D88 File Offset: 0x00027F88
		public global::Motorola.CommonCPS.Server.EntityModel.Codeplug GetWorkingCodeplugRawData(global::System.Guid deviceID)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.Codeplug result;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radioRawData;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1674313728;
					short num3 = num2;
					num2 = (short)767076375;
					short num4 = num2;
					num2 = (short)1305716759;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)233242625;
						if (num2 != 0)
						{
						}
						num2 = (short)2084372480;
						if (num2 != 0)
						{
						}
						if (radioRawData != null)
						{
							num2 = (short)1408434177;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					result = radioRawData.WorkingCodeplug;
					num2 = (short)62586882;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = null;
			radioRawData = this.GetRadioRawData(deviceID, true);
			num2 = (short)471072768;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00029EA8 File Offset: 0x000280A8
		public global::Motorola.CommonCPS.Server.EntityModel.Template GetWorkingTemplateRawData(global::System.Guid deviceID)
		{
			short num = (short)430768129;
			if (num != 0)
			{
			}
			num = (short)1180151784;
			short num2 = num;
			num = (short)1690021864;
			global::Motorola.CommonCPS.Server.EntityModel.Template template;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)115081216;
				if (num != 0)
				{
				}
				template = null;
				global::Motorola.CommonCPS.Server.EntityModel.Template result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_99;
					}
					int num3;
					global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplugRawData;
					for (;;)
					{
						IL_83:
						switch (num3)
						{
						case 0:
							goto IL_101;
						case 1:
							if (workingCodeplugRawData != null)
							{
								num = (short)1092222978;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_EC;
						case 2:
							template = workingCodeplugRawData.Template;
							num = (short)900136963;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_EC;
						}
						goto IL_99;
						IL_EC:
						num = (short)1174667264;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_101:
					break;
					IL_99:
					workingCodeplugRawData = this.GetWorkingCodeplugRawData(deviceID);
					num = (short)1679425537;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_83;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					result = template;
					goto IL_10F;
				}
				catch (global::System.Exception)
				{
					result = template;
					goto IL_10F;
				}
				break;
				IL_10F:
				num = (short)405012480;
				short num4 = num;
				return result;
			}
			}
			return template;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0002A00C File Offset: 0x0002820C
		public global::Motorola.CommonCPS.Server.EntityModel.Radio GetRadioRawData(global::System.Guid deviceId, bool deepLoad = true)
		{
			short num = (short)67348973;
			short num2 = num;
			num = (short)335653357;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1260912640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1984626688;
			if (num != 0)
			{
			}
			num = (short)693501953;
			if (num != 0)
			{
			}
			return this.ServerAccessor.GetRadioByDeviceUuid(deviceId, deepLoad);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0002A0C4 File Offset: 0x000282C4
		public global::Motorola.CommonCPS.Server.EntityModel.Template GetTemplateRawData(global::System.Guid templateUuid, bool isDeep = false)
		{
			short num = (short)2041779283;
			short num2 = num;
			num = (short)1872368723;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1020395520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1947402241;
			if (num != 0)
			{
			}
			num = (short)872349696;
			if (num != 0)
			{
			}
			return this.ServerAccessor.GetTemplate(templateUuid, isDeep);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0002A17C File Offset: 0x0002837C
		public bool DoesDeviceAlreadyExist(string sn)
		{
			int a_ = 4;
			short num;
			bool result;
			try
			{
				num = (short)1066663937;
				if (num != 0)
				{
				}
				num = (short)1155785559;
				short num2 = num;
				num = (short)1723720535;
				switch (num2 == num)
				{
				}
				num = (short)1602748416;
				if (num != 0)
				{
				}
				result = (this.ServerAccessor.GetRadioByDeviceID(sn, false) != null);
			}
			catch (global::System.Exception)
			{
				global::System.Console.WriteLine(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﺚﲞ쒠펢톤캦욨얪趬삮튰킲살얶쮸\udeba\ud9bc龾뛀ꫂ뇄꿆곊꣌믎闐뛒ꏔ뻖뫘뻚鿜ꛞ꣠꟢", a_));
				result = false;
			}
			num = (short)150208512;
			short num3 = num;
			return result;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0002A268 File Offset: 0x00028468
		public bool IsRadioCanSelectATemplate(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary device)
		{
			string empty = string.Empty;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus param = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus(device);
			bool result;
			try
			{
				this.CanRaplaceRadioWorkingCodeplug(param);
				goto IL_12;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				result = false;
			}
			return result;
			IL_12:
			short num = (short)1342111745;
			if (num != 0)
			{
			}
			num = (short)16315727;
			short num2 = num;
			num = (short)499381583;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num = (short)1289420800;
				short num3 = num;
				num = (short)677511168;
				if (num != 0)
				{
				}
				return true;
			}
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0002A348 File Offset: 0x00028548
		public bool CanRadioSelectAnIPProgramSystem(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary device)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			int? productFamily;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)710737920;
					short num3 = num2;
					num2 = (short)1973092357;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_1BA;
				case 2:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily value;
					if (value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
					{
						num2 = (short)338755594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25C;
				}
				case 3:
					num2 = (short)1178664969;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily value;
					if (value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.None)
					{
						num2 = (short)1660747776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25C;
				}
				case 5:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily value;
					if (value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater)
					{
						num2 = (short)1058078723;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25C;
				}
				case 6:
				{
					productFamily = device.ProductFamily;
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily value = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)productFamily.Value;
					num2 = (short)1206190081;
					if (num2 != 0)
					{
					}
					num2 = (short)2117402632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					num2 = (short)723451906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily value;
					if (value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
					{
						num2 = (short)1514668033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25C;
				}
				case 9:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily value;
					if (value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater)
					{
						num2 = (short)1211105287;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25C;
				}
				case 10:
					return false;
				case 11:
					if (productFamily != null)
					{
						num2 = (short)1037172742;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25C;
				}
				goto IL_40;
			}
			return false;
			IL_25C:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus a_ = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus(device);
			return !this.a(a_);
			IL_40:
			productFamily = device.ProductFamily;
			num2 = (short)166863610;
			short num4 = num2;
			num2 = (short)1939809018;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1BA:
				num2 = (short)1345650692;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1071448064;
				if (num2 != 0)
				{
				}
				num2 = (short)1963196427;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0002A5C4 File Offset: 0x000287C4
		public bool IsRadioCanSelectAConfiguration(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary device)
		{
			short num = (short)1016690639;
			short num2 = num;
			num = (short)329742287;
			switch (num2 == num)
			{
			}
			num = (short)872742912;
			short num3 = num;
			num = (short)723255296;
			if (num != 0)
			{
			}
			num = (short)2130116609;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus a_ = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus(device);
			return !this.a(a_);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0002A67C File Offset: 0x0002887C
		public bool IsRadioCanSelectATemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio device, out string error)
		{
			error = string.Empty;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus param = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus(device);
			bool result;
			try
			{
				this.CanRaplaceRadioWorkingCodeplug(param);
				goto IL_10;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				result = false;
			}
			goto IL_94;
			IL_10:
			short num = (short)1242304240;
			short num2 = num;
			num = (short)699731696;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_94:
				num = (short)1575288833;
				if (num != 0)
				{
				}
				return result;
			default:
			{
				num = (short)1014366208;
				if (num != 0)
				{
				}
				num = (short)767295488;
				short num3 = num;
				return true;
			}
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0002A758 File Offset: 0x00028958
		public void CheckRadioWorkingCodeplugCanBeOverwrite(global::Motorola.CommonCPS.Server.EntityModel.Radio device)
		{
			short num = (short)59485191;
			short num2 = num;
			num = (short)63810567;
			switch (num2 == num)
			{
			}
			num = (short)118030336;
			short num3 = num;
			num = (short)916193280;
			if (num != 0)
			{
			}
			num = (short)1981349889;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus param = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus(device);
			this.CanRaplaceRadioWorkingCodeplug(param);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0002A810 File Offset: 0x00028A10
		protected void CanRaplaceRadioWorkingCodeplug(global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus param)
		{
			if (this.a(param))
			{
				short num = (short)211484673;
				if (num != 0)
				{
				}
				num = (short)866687362;
				short num2 = num;
				num = (short)1255119234;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1497825280;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)1635909632;
				short num3 = num;
				throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ImportCodeplug_Warning_State, new string[]
				{
					param.SerialNumber
				}));
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0002A8E8 File Offset: 0x00028AE8
		private bool a(global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus;
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_2C3;
				case 1:
				{
					num2 = (short)1591869440;
					short num3 = num2;
					jobStatus = A_0.jobStatus;
					jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PENDING;
					num2 = (short)1981218823;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					jobStatus = A_0.jobStatus;
					jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CODEPLUG_DOWNLOADED;
					num2 = (short)1102905352;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)862846977;
					if (num2 != 0)
					{
					}
					jobStatus = A_0.jobStatus;
					jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_SCHEDULED;
					num2 = (short)42860548;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
					{
						num2 = (short)422379526;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
					{
						num2 = (short)1413808128;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					jobStatus = A_0.jobStatus;
					jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED;
					num2 = (short)1673068556;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
					{
						num2 = (short)46792707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
					if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
					{
						num2 = (short)109576203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 9:
					goto IL_66;
				case 10:
					if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
					{
						num2 = (short)1876819969;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 11:
				{
					jobStatus = A_0.jobStatus;
					jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PACKAGE_DOWNLOADED;
					num2 = (short)1341141976;
					short num4 = num2;
					num2 = (short)572208088;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_66;
					default:
						num2 = (short)1014890496;
						if (num2 != 0)
						{
						}
						num2 = (short)591331333;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 12:
					if (!(jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null))
					{
						num2 = (short)1658191874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 13:
					jobStatus = A_0.jobStatus;
					jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CREATED;
					num2 = (short)725483530;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_48;
				IL_66:
				if (jobStatus.GetValueOrDefault() == jobStatus2 & jobStatus != null)
				{
					return true;
				}
				num2 = (short)2074542093;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_2C3:
			return this.IsRadioSwitchoverRequired(A_0.jobStatus, A_0.cruncherStatus);
			IL_48:
			jobStatus = A_0.jobStatus;
			jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_RUNNING;
			num2 = (short)449183753;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0002AC38 File Offset: 0x00028E38
		public bool IsRadioSwitchoverRequired(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus, global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus)
		{
			short num = (short)1252130816;
			switch (num)
			{
			default:
			{
				num = (short)968949767;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)866844673;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						if (cruncherStatus == null)
						{
							num = (short)1271463939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus2 = jobStatus;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED;
						num = (short)1961426946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus2 = jobStatus;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CANCELED;
						num = (short)1726218246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus3;
						if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
						{
							num = (short)1099825153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18C;
					}
					case 3:
						goto IL_18A;
					case 4:
						goto IL_FC;
					case 5:
						goto IL_14F;
					case 6:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus3;
						if (jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null)
						{
							num = (short)1651048452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1047160122;
						short num3 = num;
						num = (short)1871537466;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14F;
						case 1:
							goto IL_202;
						}
						goto Block_5;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					}
					IL_8B:
					if (jobStatus != null)
					{
						num = (short)204210181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_14F:
					num = (short)1039728640;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FC:
				goto IL_18C;
				IL_18A:
				return false;
				IL_18C:
				global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus2 = cruncherStatus;
				global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.AWAITING_SWITCH_OVER;
				return cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null;
				Block_5:
				num = (short)1448083456;
				short num4 = num;
				IL_202:
				num = (short)1153761280;
				if (num != 0)
				{
				}
				return false;
			}
			}
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0002AE60 File Offset: 0x00029060
		public bool IsJobNotRunning(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus)
		{
			short num = (short)1898905601;
			if (num != 0)
			{
			}
			num = (short)45219849;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2AE;
				case 1:
					num = (short)296615943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1963720712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)403243012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus2 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_EXPIRED;
					jobStatus3 = jobStatus;
					if (!(jobStatus2 == jobStatus3.GetValueOrDefault() & jobStatus3 != null))
					{
						num = (short)1540096006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 5:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus4 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PENDING;
					jobStatus3 = jobStatus;
					if (jobStatus4 == jobStatus3.GetValueOrDefault() & jobStatus3 != null)
					{
						return true;
					}
					num = (short)263413986;
					short num3 = num;
					num = (short)1857511650;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_124;
					default:
					{
						num = (short)1583087616;
						short num4 = num;
						num = (short)390725632;
						if (num != 0)
						{
						}
						num = (short)1499791360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					num = (short)1134493708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus5 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED;
					jobStatus3 = jobStatus;
					if (!(jobStatus5 == jobStatus3.GetValueOrDefault() & jobStatus3 != null))
					{
						num = (short)1948909571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 8:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus6 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_SCHEDULED;
					jobStatus3 = jobStatus;
					if (!(jobStatus6 == jobStatus3.GetValueOrDefault() & jobStatus3 != null))
					{
						num = (short)870973451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 9:
					switch (0)
					{
					case 0:
						goto IL_83;
					}
					continue;
				case 10:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus7 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED;
					jobStatus3 = jobStatus;
					if (!(jobStatus7 == jobStatus3.GetValueOrDefault() & jobStatus3 != null))
					{
						num = (short)931856385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 11:
					num = (short)573505541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus8 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CANCELED;
					jobStatus3 = jobStatus;
					if (!(jobStatus8 == jobStatus3.GetValueOrDefault() & jobStatus3 != null))
					{
						goto IL_124;
					}
					return true;
				}
				case 13:
					num = (short)1846673418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_83:
				if (jobStatus != null)
				{
					num = (short)1146945549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_124:
				num = (short)2147090434;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2AE:
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus9 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CREATED;
			jobStatus3 = jobStatus;
			return jobStatus9 == jobStatus3.GetValueOrDefault() & jobStatus3 != null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0002B16C File Offset: 0x0002936C
		public bool CanCreateJob(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus)
		{
			short num = (short)83230751;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus jobStatus3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1190264833;
					if (num != 0)
					{
					}
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1392967701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_90;
					num = (short)15663132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_56A;
				case 3:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1666449438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1363345424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1843134477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					num = (short)733937690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1983447054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED;
					num = (short)4849696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)528678914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 10:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_40;
					num = (short)1625948165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)2087845900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 12:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_60;
					num = (short)2029584391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_50;
					num = (short)147390475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_70;
					num = (short)1825439762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_99;
					num = (short)1825964055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_20;
					num = (short)1624506368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_10;
					num = (short)1975386116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1151402003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 19:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_80;
					num = (short)115081251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1330970632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 21:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_30;
					num = (short)1933639713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)438501400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 23:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1551892505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 24:
					goto IL_40F;
				case 25:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CODEPLUG_DOWNLOADED;
					num = (short)1523712022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					if (jobStatus != null)
					{
						num = (short)1737818141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 27:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1053818914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 28:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)1357840399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 29:
				{
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PENDING;
					num = (short)416219136;
					short num3 = num;
					num = (short)2056388617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 30:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CREATED;
					num = (short)1920335892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					switch (0)
					{
					case 0:
						goto IL_B6;
					}
					continue;
				case 32:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)144048145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 33:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)679084042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 34:
					jobStatus2 = jobStatus;
					jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_SCHEDULED;
					num = (short)1274871811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					if (!(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null))
					{
						num = (short)282656769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_B6:
				if (jobStatus == null)
				{
					return true;
				}
				num = (short)1717807327;
				short num4 = num;
				num = (short)1236510943;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1246429184;
					if (num != 0)
					{
					}
					num = (short)1366884358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56A:
				jobStatus2 = jobStatus;
				jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_RUNNING;
				num = (short)1898643483;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_40F:
			jobStatus2 = jobStatus;
			jobStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PACKAGE_DOWNLOADED;
			return !(jobStatus2.GetValueOrDefault() == jobStatus3 & jobStatus2 != null);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0002B854 File Offset: 0x00029A54
		public bool IsJobProcessingState(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num;
			if (radio.LastJob != null)
			{
				num = (short)2075450721;
				short num2 = num;
				num = (short)1788337505;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1953366017;
					if (num != 0)
					{
					}
					num = (short)1119027200;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus a_ = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus(radio);
					return this.a(a_);
				}
				}
			}
			num = (short)1726349312;
			short num3 = num;
			return false;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0002B918 File Offset: 0x00029B18
		public bool IsJobProcessingState(global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radio)
		{
			short num = (short)1403149368;
			short num2 = num;
			num = (short)578444344;
			switch (num2 == num)
			{
			}
			num = (short)411762689;
			if (num != 0)
			{
			}
			num = (short)1168506880;
			if (num != 0)
			{
			}
			num = (short)2047737856;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus a_ = new global::Motorola.CommonCPS.RadioManagement.SharedServices.PackingParameter_CheckRadioOrJobStatus(radio);
			return this.a(a_);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0002B9CC File Offset: 0x00029BCC
		public global::Motorola.CommonCPS.Server.EntityModel.Package CheckAndUploadOnePackage(string filePath, global::Motorola.CommonCPS.Server.EntityModel.Package software)
		{
			int a_ = 0;
			short num = (short)765526016;
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
				global::Motorola.CommonCPS.Server.EntityModel.Package package;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)1931804673;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(filePath))
						{
							goto IL_44E;
						}
						num = (short)543045151;
						short num3 = num;
						num = (short)71513631;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return package;
						default:
							num = (short)1148059648;
							if (num != 0)
							{
							}
							num = (short)1132199940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)1750532104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if ((package = this.ServerAccessor.PackageExist(software)) == null)
						{
							num = (short)480116746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)200146950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2EA;
					case 4:
						goto IL_3CF;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = this.AddFileToServer(filePath);
						software.FileUuid = new global::System.Guid?(rmfile.Uuid);
						software.RMFile = rmfile;
						software.ModifiedDate = new global::System.DateTime?(global::System.DateTime.UtcNow);
						software = this.ServerAccessor.ImportPackage(software);
						num = (short)1141506051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (package.RMFile != null)
						{
							num = (short)1495728129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1224015881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_10C;
					case 8:
						if (package.RMFile != null)
						{
							num = (short)1926692875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return package;
					case 9:
						if (!string.IsNullOrEmpty(filePath))
						{
							num = (short)1316225029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return package;
					case 10:
						global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("얖풘\ud89a슜쾞쒠톢쎤좦\udba8욪첬솮튰횲﮶횸\udcba\udabc\udabe돀", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ude96햠힤쒦솨슪\udbac쪮튲솴풶톸춼", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풖ﺚﺜ춢솤\ud9a8잪슬캮햰ﲲ\udbb4튶\udaba\udebc풾ꃀ꓂ꃄ鷌껎닐룒듔냖볘黚ꗜ뛞鋠韢췤컦짨껪菬诮", a_));
						num = (short)9502720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::System.Guid uuid = package.RMFile.Uuid;
						num = (short)126812167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_68;
				}
				IL_10C:
				num = (short)892469248;
				short num4 = num;
				IL_2EA:
				return package;
				IL_3CF:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("얖풘\ud89a슜쾞쒠톢쎤좦\udba8욪첬솮튰횲﮶횸\udcba\udabc\udabe돀", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ude96햠힤쒦솨슪\udbac쪮튲솴풶톸춼", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풖ﺚﺜ춢솤\ud9a8잪슬캮햰ﲲ\udbb4튶\udaba\udebc풾ꃀ꓂ꃄ賌ꯎ뗐闒볔믖볘迚닜賞蓠釢鏤苦鯨쏪쓬쿮ꋰ蟲铴藶跸", a_));
				global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile2 = this.AddFileToServer(filePath);
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("얖풘\ud89a슜쾞쒠톢쎤좦\udba8욪첬솮튰횲﮶횸\udcba\udabc\udabe돀", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ude96햠힤쒦솨슪\udbac쪮튲솴풶톸춼", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풖ﺚﺜ춢솤\ud9a8잪슬캮햰ﲲ\udbb4튶\udaba\udebc풾ꃀ꓂ꃄ賌ꯎ뗐闒볔믖볘迚닜賞蓠釢鏤苦鯨쏪쓬쿮듰鷲釴", a_));
				software.FileUuid = new global::System.Guid?(rmfile2.Uuid);
				software.RMFile = rmfile2;
				global::Motorola.CommonCPS.Server.EntityModel.Package package2 = software;
				global::Motorola.CommonCPS.Server.EntityModel.Package package3 = software;
				global::System.DateTime? dateTime = new global::System.DateTime?(global::System.DateTime.UtcNow);
				package3.ModifiedDate = dateTime;
				package2.CreatedDate = dateTime;
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("얖풘\ud89a슜쾞쒠톢쎤좦\udba8욪첬솮튰횲﮶횸\udcba\udabc\udabe돀", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ude96햠힤쒦솨슪\udbac쪮튲솴풶톸춼", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풖ﺚﺜ춢솤\ud9a8잪슬캮햰ﲲ\udbb4튶\udaba\udebc풾ꃀ꓂ꃄ蓌ꋎꇐ볒꟔ꏖ觘뫚뻜듞胠蓢胤쿦샨쯪뻬鯮郰臲致", a_));
				global::Motorola.CommonCPS.Server.EntityModel.Package result = this.ServerAccessor.ImportPackage(software);
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("얖풘\ud89a슜쾞쒠톢쎤좦\udba8욪첬솮튰횲﮶횸\udcba\udabc\udabe돀", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ude96햠힤쒦솨슪\udbac쪮튲솴풶톸춼", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풖ﺚﺜ춢솤\ud9a8잪슬캮햰ﲲ\udbb4튶\udaba\udebc풾ꃀ꓂ꃄ蓌ꋎꇐ볒꟔ꏖ觘뫚뻜듞胠蓢胤쿦샨쯪꣬臮闰", a_));
				return result;
				IL_44E:
				return this.ServerAccessor.ImportPackage(software);
				IL_68:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("얖풘\ud89a슜쾞쒠톢쎤좦\udba8욪첬솮튰횲﮶횸\udcba\udabc\udabe돀", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ude96햠힤쒦솨슪\udbac쪮튲솴풶톸춼", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풖ﺚﺜ춢솤\ud9a8잪슬캮햰ﲲ\udbb4튶\udaba\udebc풾ꃀ꓂ꃄ鷌껎닐룒듔냖볘黚ꗜ뛞鋠韢췤컦짨룪駬軮菰蟲", a_));
				num = (short)394264578;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0002BE38 File Offset: 0x0002A038
		public global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFileToServer(string filePath)
		{
			short num = (short)1107168704;
			short num2 = num;
			num = (short)637144512;
			switch (num2 == num)
			{
			}
			num = (short)1434976257;
			if (num != 0)
			{
			}
			num = (short)92274688;
			if (num != 0)
			{
			}
			num = (short)1137967104;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.RMFile result = this.ServerAccessor.AddFile(filePath, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType.Default);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase.fileCount++;
			return result;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0002BEFC File Offset: 0x0002A0FC
		public global::Motorola.CommonCPS.Server.EntityModel.RMFile AddFileContentToServer(byte[] data)
		{
			short num = (short)512819201;
			if (num != 0)
			{
			}
			num = (short)114532736;
			short num2 = num;
			num = (short)183476608;
			switch (num2 == num)
			{
			}
			num = (short)1275396096;
			if (num != 0)
			{
			}
			num = (short)1120862208;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.RMFile result = this.ServerAccessor.AddFileContent(data);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase.fileCount++;
			return result;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0002BFBC File Offset: 0x0002A1BC
		protected void UploadVAPackages(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> vaPackages)
		{
			int a_ = 5;
			short num = (short)128778241;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
				{
					num = (short)1258881024;
					short num3 = num;
					try
					{
						num = (short)704643075;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_15C;
							case 1:
								num = (short)574947328;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)930545665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.Package package = enumerator.Current;
								this.UploadVAPackage(package);
								goto IL_A3;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_91;
								}
								continue;
							}
							goto IL_91;
							IL_A3:
							num = (short)643497988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BB:
							num = (short)1335189258;
							short num4 = num;
							num = (short)1663590154;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A3;
							default:
								num = (short)1142423552;
								if (num != 0)
								{
								}
								num = (short)1974272002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_91:
							goto IL_BB;
						}
						IL_15C:
						goto IL_21A;
					}
					finally
					{
						num = (short)2033713153;
						if (num != 0)
						{
						}
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_197;
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
				if (vaPackages == null)
				{
					num = (short)451608578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_197:
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캛펝ﶡ쎥\udaa7첩쎫\udcad\uddaf펱\udab3햵\uddb7톽ꞿꗁꇃ듅", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햛킟춡횣튥\ud8a9쾫욭\ud9af쒱톳\ud9b7캹\udfbb횽辿닁", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즛첟춡얣슥ﺧ蒫螭麯쒳\udab5ힷ\udbb9\ud8bb膿鋁ꗃꗅꏇꯉꯋꯍꏏ𣏕﷓诗껙뷛곝铟", a_));
				enumerator = vaPackages.GetEnumerator();
				num = (short)1166082048;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_21A:
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("캛펝ﶡ쎥\udaa7첩쎫\udcad\uddaf펱\udab3햵\uddb7톽ꞿꗁꇃ듅", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햛킟춡횣튥\ud8a9쾫욭\ud9af쒱톳\ud9b7캹\udfbb횽辿닁", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즛첟춡얣슥ﺧ蒫螭麯쒳\udab5ힷ\udbb9\ud8bb膿鋁ꗃꗅꏇꯉꯋꯍꏏ𣏕﷓鷗듙룛", a_));
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0002C234 File Offset: 0x0002A434
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadVAPackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)1409810432;
			switch (num)
			{
			default:
			{
				num = (short)345309185;
				if (num != 0)
				{
				}
				num = (short)1192493057;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2114715653;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.CommonCPS.Server.EntityModel.Package result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									text = package.RMFile.Url;
									num = (short)2111700994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1C0;
								case 2:
									goto IL_19C;
								case 3:
									num = (short)1152909318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_19C;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_101;
									}
									continue;
								case 6:
									if (package.RMFile.Url != null)
									{
										num = (short)1327890432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_159;
								}
								IL_101:
								if (package.RMFile != null)
								{
									num = (short)1958346755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_159:
								text = null;
								num = (short)923271172;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19C:
								package = this.CheckAndUploadOnePackage(text, package);
								result = package;
								num = (short)1379401729;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C0:
							return result;
						}
						catch (global::System.Exception ex)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null), ex);
						}
						finally
						{
							for (;;)
							{
								try
								{
									num = (short)321716226;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_261;
										case 1:
											goto IL_277;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_224;
											}
											continue;
										case 3:
											global::System.IO.File.Delete(text);
											num = (short)1308295168;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_224:
										if (!string.IsNullOrEmpty(text))
										{
											num = (short)1606156291;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_261:
										num = (short)2027749377;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_277:;
								}
								catch
								{
								}
								num = (short)1865634448;
								short num3 = num;
								num = (short)1770082960;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_2B1;
								}
							}
							IL_2B1:
							num = (short)848756736;
							if (num != 0)
							{
							}
						}
						goto IL_2C8;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_76;
						}
						continue;
					case 2:
						goto IL_91;
					}
					IL_76:
					if (package == null)
					{
						num = (short)37879810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2C8:
					text = null;
					num = (short)131334144;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_91:
				num = (short)938147840;
				short num4 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Package_NotExist_Error);
			}
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0002C584 File Offset: 0x0002A784
		protected void UploadCACertificatePackages(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> caCertificatePackages)
		{
			int a_ = 11;
			short num = (short)1440808961;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					try
					{
						num = (short)2057568259;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_15D;
							case 1:
								num = (short)695074816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1314586625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.Package package = enumerator.Current;
								this.UploadCACertificatePackage(package);
								goto IL_A4;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_92;
								}
								continue;
							}
							goto IL_92;
							IL_A4:
							num = (short)2037448708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BC:
							num = (short)1872667728;
							short num3 = num;
							num = (short)749708368;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_A4;
							default:
								num = (short)84803584;
								if (num != 0)
								{
								}
								num = (short)1247281154;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_92:
							goto IL_BC;
						}
						IL_15D:
						goto IL_1F2;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_170;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3B;
					}
					continue;
				case 2:
					return;
				}
				IL_3B:
				if (caCertificatePackages == null)
				{
					num = (short)788201474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_170:
				num = (short)246218752;
				short num4 = num;
				global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("睊즫\udcad횯\uddb1욳\udbb5\ud9b7풹\udfbb\udbbd龿軁ꯃꇅ꿇꿉뻋", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즣횥잧\ud8a9\ud8ab슯톱\udcb3\udfb5캷\udfb9ﺻ\udfbd뒿ꇁ곃觅룇", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풣쪥잧쮩좫톳쒵첷펹\udabbힽꎿꏁ냃ꏅ믇藏ꋑ룓맕맗뻙鿛鿝ꏟ蟡難鋥臧賩藫跭釯蛱釳꛵駷駹韻鿽柿朁眃⸅ℇ⨉弋稍焏怑怓", a_));
				enumerator = caCertificatePackages.GetEnumerator();
				num = (short)770113536;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_1F2:
			num = (short)1757151233;
			if (num != 0)
			{
			}
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("睊즫\udcad횯\uddb1욳\udbb5\ud9b7풹\udfbb\udbbd龿軁ꯃꇅ꿇꿉뻋", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("즣횥잧\ud8a9\ud8ab슯톱\udcb3\udfb5캷\udfb9ﺻ\udfbd뒿ꇁ곃觅룇", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("풣쪥잧쮩좫톳쒵첷펹\udabbힽꎿꏁ냃ꏅ믇藏ꋑ룓맕맗뻙鿛鿝ꏟ蟡難鋥臧賩藫跭釯蛱釳꛵駷駹韻鿽柿朁眃⸅ℇ⨉䤋怍琏", a_));
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0002C7FC File Offset: 0x0002A9FC
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadCACertificatePackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)403963904;
			switch (num)
			{
			default:
			{
				num = (short)1455947776;
				short num2 = num;
				num = (short)1290010624;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_78;
						}
						continue;
					case 1:
						goto IL_108;
					case 2:
						try
						{
							num = (short)924712961;
							num3 = (int)((global::System.IntPtr)num);
							global::Motorola.CommonCPS.Server.EntityModel.Package result;
							for (;;)
							{
								switch (num3)
								{
								case 0:
									if (package.RMFile.Url != null)
									{
										num = (short)505479171;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1AB;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_150;
									}
									continue;
								case 2:
									num = (short)866582528;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									text = package.RMFile.Url;
									num = (short)100139012;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1EF;
								case 5:
									goto IL_214;
								case 6:
									goto IL_1EF;
								}
								IL_150:
								if (package.RMFile != null)
								{
									num = (short)483262466;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1AB:
								text = null;
								num = (short)1371930630;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_1EF:
								package = this.CheckAndUploadOnePackage(text, package);
								result = package;
								num = (short)1597177861;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_214:
							return result;
						}
						catch (global::System.Exception ex)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null), ex);
						}
						finally
						{
							try
							{
								num = (short)1113784320;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_27A;
										}
										continue;
									case 1:
										global::System.IO.File.Delete(text);
										num = (short)1542193155;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_2CD;
									case 3:
										goto IL_2B6;
									}
									IL_27A:
									if (!string.IsNullOrEmpty(text))
									{
										num = (short)137822209;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2B6:
									num = (short)2132410370;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2CD:;
							}
							catch
							{
							}
						}
						goto IL_2D3;
					}
					IL_78:
					if (package == null)
					{
						num = (short)1925755008;
						short num4 = num;
						num = (short)40743040;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_108;
						default:
							num = (short)15990785;
							if (num != 0)
							{
							}
							num = (short)47710208;
							if (num != 0)
							{
							}
							num = (short)1781923841;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
					}
					IL_2D3:
					text = null;
					num = (short)1679949826;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_108:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Package_NotExist_Error);
			}
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0002CB54 File Offset: 0x0002AD54
		protected void UploadDVRSFilePackages(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> dVRSFilePackages)
		{
			int a_ = 12;
			short num;
			for (;;)
			{
				num = (short)182452224;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1118437376;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_63;
						}
						continue;
					}
					case 1:
						goto IL_A5;
					case 2:
						try
						{
							num = (short)1096613888;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_12D;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)864419844;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.Package package = enumerator.Current;
									this.UploadDVRSFilePackage(package);
									num = (short)2126643201;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1A0;
								case 4:
									num = (short)1274085379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_155:
								num = (short)1867186178;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12D:
								goto IL_155;
							}
							IL_1A0:
							goto IL_209;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1B0;
					}
					IL_63:
					num = (short)1222049793;
					if (num != 0)
					{
					}
					if (dVRSFilePackages == null)
					{
						num = (short)802553857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1B0:
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﮪ좬\uddaeힰ\udcb2잴\udab6\ud8b8햺\udebc\udabe黀迂꫄ꃆ껈껊뿌", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좤힦욨\ud9aa\ud9ac쎰킲\uddb4\udeb6쾸\udebaﾼ\udebe뗀ꃂ귄裆마", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햤쮦욨쪪즬킸ힺ\ud8bcꃀꃂ껄ꛆ껈껊￐蛒ꗔ믖뛘뫚맜鯞럠뇢뛤ꇦ胨蟪裬뿮郰郲黴零黸黺軼퟾⠀⌂嘄猆栈礊礌", a_));
					enumerator = dVRSFilePackages.GetEnumerator();
					num = (short)278462466;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A5:
				num = (short)797434045;
				short num4 = num;
				num = (short)1955127485;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_D9;
				}
			}
			IL_D9:
			num = (short)347406336;
			if (num != 0)
			{
			}
			return;
			IL_209:
			global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﮪ좬\uddaeힰ\udcb2잴\udab6\ud8b8햺\udebc\udabe黀迂꫄ꃆ껈껊뿌", a_)).Performance(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("좤힦욨\ud9aa\ud9ac쎰킲\uddb4\udeb6쾸\udebaﾼ\udebe뗀ꃂ귄裆마", a_), global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("햤쮦욨쪪즬킸ힺ\ud8bcꃀꃂ껄ꛆ껈껊￐蛒ꗔ믖뛘뫚맜鯞럠뇢뛤ꇦ胨蟪裬뿮郰郲黴零黸黺軼퟾⠀⌂䀄椆洈", a_));
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0002CDB0 File Offset: 0x0002AFB0
		public global::Motorola.CommonCPS.Server.EntityModel.Package UploadDVRSFilePackage(global::Motorola.CommonCPS.Server.EntityModel.Package package)
		{
			short num = (short)1338114048;
			switch (num)
			{
			default:
			{
				num = (short)1934426112;
				short num2 = num;
				num = (short)341311488;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string text;
					switch (num3)
					{
					case 0:
						num = (short)1435697153;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 1:
						goto IL_10C;
					case 2:
						try
						{
							num = (short)2111832065;
							num3 = (int)((global::System.IntPtr)num);
							global::Motorola.CommonCPS.Server.EntityModel.Package result;
							for (;;)
							{
								switch (num3)
								{
								case 0:
									if (package.RMFile.Url != null)
									{
										num = (short)1028259843;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1AC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_154;
									}
									continue;
								case 2:
									num = (short)318111744;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									text = package.RMFile.Url;
									num = (short)1841037316;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1EE;
								case 5:
									goto IL_212;
								case 6:
									goto IL_1EE;
								}
								IL_154:
								if (package.RMFile != null)
								{
									num = (short)1509687298;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1AC:
								text = null;
								num = (short)1493696518;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_1EE:
								package = this.CheckAndUploadOnePackage(text, package);
								result = package;
								num = (short)317259781;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_212:
							return result;
						}
						catch (global::System.Exception ex)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error.ToString(), null), ex);
						}
						finally
						{
							try
							{
								num = (short)1538654208;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_276;
										}
										continue;
									case 1:
										global::System.IO.File.Delete(text);
										num = (short)872218627;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_2C9;
									case 3:
										goto IL_2B2;
									}
									IL_276:
									if (!string.IsNullOrEmpty(text))
									{
										num = (short)1144061953;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2B2:
									num = (short)1939603458;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2C9:;
							}
							catch
							{
							}
						}
						goto IL_2CF;
					}
					IL_A5:
					if (package == null)
					{
						num = (short)463022534;
						short num4 = num;
						num = (short)1493051846;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10C;
						default:
							num = (short)2139881472;
							if (num != 0)
							{
							}
							num = (short)1971781633;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
					}
					IL_2CF:
					text = null;
					num = (short)1648164866;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_10C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Package_NotExist_Error);
			}
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0002D104 File Offset: 0x0002B304
		private int a(global::Newtonsoft.Json.Linq.JObject A_0)
		{
			int a_ = 10;
			short num = (short)1784697790;
			short num2 = num;
			num = (short)1446532030;
			switch (num2 == num)
			{
			default:
			{
				num = (short)136380416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1690959873;
			if (num != 0)
			{
			}
			num = (short)81330176;
			if (num != 0)
			{
			}
			return (int)A_0.SelectToken(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("", a_));
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0002D1D0 File Offset: 0x0002B3D0
		private static bool a(string licenseName)
		{
			int a_ = 1;
			string text = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf97횙펛\udc9dﮣﶭ", a_);
			string text2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf97횙펛\udc9dﮣﲭ", a_);
			if (!(licenseName == text2))
			{
				short num = (short)475332609;
				if (num != 0)
				{
				}
				num = (short)479779619;
				short num2 = num;
				num = (short)1276369699;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)236584960;
					if (num != 0)
					{
					}
					num = (short)768344064;
					short num3 = num;
					return licenseName == text;
				}
				}
			}
			return true;
		}

		// Token: 0x04000033 RID: 51
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor a;

		// Token: 0x04000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase b;

		// Token: 0x04000035 RID: 53
		public static int fileCount;
	}
}
