using System;
using System.IO;
using Common.Communication.Simulator;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommonUtility;
using Motorola.Common.Communication.CommunicationManager;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000049 RID: 73
	public class DeviceServiceManager : global::System.IDisposable
	{
		// Token: 0x06000293 RID: 659 RVA: 0x000188F4 File Offset: 0x00016AF4
		public DeviceServiceManager(global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager)
		{
			this.f = communicationManager;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00018910 File Offset: 0x00016B10
		public global::Motorola.Common.Communication.Service.IDeviceDiscovery GetDeviceDiscoveryService(global::Motorola.Common.Communication.CommonUtil.ProductFamily deviceFamilySet, global::Motorola.Common.Communication.CommonUtil.WorkMode workMode, global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent discoveryServiceEventCallback)
		{
			short num = (short)598016008;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)54474975;
					short num3 = num;
					num = (short)1053833439;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BE;
					default:
						num = (short)1734410240;
						if (num != 0)
						{
						}
						num = (short)531431425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (this.c == workMode)
					{
						num = (short)1784020995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E2;
				case 2:
					if (this.b == deviceFamilySet)
					{
						num = (short)1642397696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E2;
				case 3:
					num = (short)568459269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1245970434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.d != discoveryServiceEventCallback)
					{
						num = (short)1234436103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DA;
				case 6:
					goto IL_D5;
				case 7:
					goto IL_226;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				IL_49:
				num = (short)380698625;
				if (num != 0)
				{
				}
				num = (short)564854784;
				short num4 = num;
				if (this.a != null)
				{
					num = (short)521207812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BE:
				num = (short)1677918214;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D5:
			try
			{
				this.a = new global::Motorola.Common.Communication.Service.DeviceDiscovery(deviceFamilySet, workMode, discoveryServiceEventCallback, this.f, global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance);
				this.b = deviceFamilySet;
				this.c = workMode;
				this.d = discoveryServiceEventCallback;
				goto IL_228;
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceNotAvailabe, systemException);
			}
			goto IL_1E2;
			IL_228:
			return this.a;
			IL_DA:
			return this.a;
			IL_1E2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceDeviceDiscoveryParametersMismatched);
			IL_226:
			goto IL_1E2;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00018B5C File Offset: 0x00016D5C
		public global::Motorola.Common.Communication.Service.IDeviceDiscovery GetDeviceDiscoveryService(global::Motorola.Common.Communication.Service.InitializedParameters parameters, global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent discoveryServiceEventCallback)
		{
			short num = (short)693829644;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1857683456;
					short num3 = num;
					global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder = parameters.VRFolder;
					num = (short)2056519683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.LogFilePath = parameters.LogFolder;
					num = (short)248640983;
					short num4 = num;
					num = (short)621868503;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F2;
					default:
						num = (short)351469568;
						if (num != 0)
						{
						}
						num = (short)859242504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_1D5;
				case 3:
					goto IL_266;
				case 4:
					if (!string.IsNullOrEmpty(parameters.LogFolder))
					{
						num = (short)11534347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				case 5:
					goto IL_1F2;
				case 6:
					if (!global::System.IO.Directory.Exists(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.StorageFolder))
					{
						num = (short)1241579527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A8;
				case 7:
					global::System.IO.Directory.CreateDirectory(global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.StorageFolder);
					num = (short)1972764674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_21C;
				case 9:
					num = (short)448331781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (global::System.IO.Directory.Exists(parameters.LogFolder))
					{
						num = (short)1225785345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				case 11:
					num = (short)885653514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)1724579841;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_82;
					}
					continue;
				}
				IL_82:
				if (!string.IsNullOrEmpty(parameters.VRFolder))
				{
					num = (short)943259657;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_266;
				IL_1F2:
				if (global::System.IO.Directory.Exists(parameters.VRFolder))
				{
					num = (short)361234432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_266;
				IL_21C:
				global::Motorola.Common.Communication.CommonUtility.GlobalConstansts.ProductFamily = parameters.deviceFamilySet;
				num = (short)486342662;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_266:
				num = (short)1533214724;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1D5:
			IL_2A8:
			return this.GetDeviceDiscoveryService(parameters.deviceFamilySet, parameters.workMode, discoveryServiceEventCallback);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00018E24 File Offset: 0x00017024
		public global::Motorola.Common.Communication.Service.IDeviceDiscovery GetDeviceDiscoveryService()
		{
			short num = (short)2027552769;
			if (num != 0)
			{
			}
			if (this.a == null)
			{
				num = (short)1104740352;
				short num2 = num;
				num = (short)1744537599;
				short num3 = num;
				num = (short)302483455;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)947585024;
					if (num != 0)
					{
					}
					break;
				}
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceNotAvailabe);
			}
			return this.a;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00018EE8 File Offset: 0x000170E8
		public global::Motorola.Common.Communication.Service.IDeviceOperation GetDeviceOperationService(global::Motorola.Common.Communication.Service.IOperationServiceEvent deviceOperationCallback)
		{
			short num = (short)907674392;
			short num2 = num;
			num = (short)635503384;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_8F;
			case 1:
				break;
			default:
			{
				num = (short)203685888;
				short num3 = num;
				break;
			}
			}
			num = (short)2006646784;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.IDeviceOperation result = null;
			try
			{
				result = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation(deviceOperationCallback, this.f);
			}
			catch (global::System.Exception systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceNotAvailabe, systemException);
			}
			IL_8F:
			num = (short)1250820097;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00018FBC File Offset: 0x000171BC
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1639645187;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1995702272;
					short num3 = num;
					goto IL_67;
				}
				case 1:
					return;
				case 2:
				{
					num = (short)1396032167;
					short num4 = num;
					num = (short)1115800231;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12F;
					default:
						num = (short)208404480;
						if (num != 0)
						{
						}
						num = (short)114753542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 4:
					num = (short)1305214981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (disposing)
					{
						num = (short)1191116802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67;
				case 6:
				{
					global::Motorola.Common.Communication.Service.IDeviceDiscovery deviceDiscovery = this.a;
					if (deviceDiscovery == null)
					{
						goto IL_12F;
					}
					deviceDiscovery.Dispose();
					num = (short)274857991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num = (short)1311768577;
					if (num != 0)
					{
					}
					goto IL_67;
				}
				IL_46:
				if (!this.e)
				{
					num = (short)1279328260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_67:
				this.e = true;
				num = (short)1792212993;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_12F:
				num = (short)771883008;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00019188 File Offset: 0x00017388
		public void Dispose()
		{
			short num = (short)1244266497;
			if (num != 0)
			{
			}
			num = (short)1019147462;
			short num2 = num;
			num = (short)77067462;
			switch (num2 == num)
			{
			}
			num = (short)1628962816;
			short num3 = num;
			num = (short)1103429632;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001923C File Offset: 0x0001743C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1258983524 + A_1) + (global::System.IntPtr)79 + (global::System.IntPtr)35 + (global::System.IntPtr)65 + (global::System.IntPtr)41 + (global::System.IntPtr)65);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x040000E2 RID: 226
		private global::Motorola.Common.Communication.Service.IDeviceDiscovery a;

		// Token: 0x040000E3 RID: 227
		private global::Motorola.Common.Communication.CommonUtil.ProductFamily b;

		// Token: 0x040000E4 RID: 228
		private global::Motorola.Common.Communication.CommonUtil.WorkMode c;

		// Token: 0x040000E5 RID: 229
		private global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent d;

		// Token: 0x040000E6 RID: 230
		private bool e;

		// Token: 0x040000E7 RID: 231
		private readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager f;
	}
}
