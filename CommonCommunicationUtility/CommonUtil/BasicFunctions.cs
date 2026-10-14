using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200000F RID: 15
	public static class BasicFunctions
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00006CBC File Offset: 0x00004EBC
		public static bool IsWiredDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			short num;
			while (device.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter)
			{
				num = (short)1745370704;
				short num2 = num;
				num = (short)1061764688;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1402142721;
					if (num != 0)
					{
					}
					num = (short)614531072;
					if (num != 0)
					{
					}
					return true;
				}
			}
			num = (short)171180032;
			short num3 = num;
			return false;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006D78 File Offset: 0x00004F78
		public static bool IsRRPDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			short num = (short)1314127873;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1239285760;
					short num3 = num;
					if (device.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network)
					{
						num = (short)317652995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10C;
				}
				case 1:
				{
					num = (short)419447136;
					short num4 = num;
					num = (short)261636448;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)1808007168;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					break;
				}
				case 2:
					num = (short)1608450048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_10A;
				}
				IL_7D:
				if (device.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork)
				{
					break;
				}
				num = (short)1777270786;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_10A:
			return true;
			IL_10C:
			num = (short)545259521;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006EB8 File Offset: 0x000050B8
		public static bool IsOtapDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device)
		{
			short num;
			while (device.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
			{
				num = (short)937868094;
				short num2 = num;
				num = (short)2068364094;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1733558273;
					if (num != 0)
					{
					}
					num = (short)1718878208;
					if (num != 0)
					{
					}
					return true;
				}
			}
			num = (short)1987969024;
			short num3 = num;
			return false;
		}
	}
}
