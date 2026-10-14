using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Extensions;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002E RID: 46
	public static class DeviceInfoHelper
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00026A10 File Offset: 0x00024C10
		public static void MapFromDeviceInventoryResponse(this global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.AmpDeviceInventory deviceInventory)
		{
			short num = (short)229715447;
			short num2 = num;
			num = (short)905653751;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1526923264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)708968449;
			if (num != 0)
			{
			}
			num = (short)1695612928;
			if (num != 0)
			{
			}
			deviceInfo.ModelNumber = deviceInventory.Model;
			deviceInfo.TanapaNumber = deviceInventory.Fanapa;
			deviceInfo.SoftwareVersion = deviceInventory.ApFwVersion;
			deviceInfo.CodeplugVersion = deviceInventory.CodeplugVersion;
			deviceInfo.Family = deviceInventory.ProductFamily;
			deviceInfo.SerialNumber = deviceInventory.Lsn.ToEncodedBase64();
			deviceInfo.IMEI = deviceInventory.Imei;
			deviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00026B1C File Offset: 0x00024D1C
		public static void MapFromDeviceInventoryResponse(this global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo deviceInfo, global::Motorola.Common.Communication.AmpDeviceInventory deviceInventory)
		{
			short num = (short)370039916;
			short num2 = num;
			num = (short)1833524332;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1968832512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1187512321;
			if (num != 0)
			{
			}
			num = (short)2064908288;
			if (num != 0)
			{
			}
			deviceInfo.RadioOobState = deviceInventory.RadioOobState;
			global::System.Guid lastSetJobUuid;
			global::System.Guid.TryParse(deviceInventory.LastSetJobUuid, out lastSetJobUuid);
			deviceInfo.LastSetJobUuid = lastSetJobUuid;
			deviceInfo.ModelNumber = deviceInventory.Model;
			deviceInfo.TanapaNumber = deviceInventory.Fanapa;
			deviceInfo.SoftwareVersion = deviceInventory.ApFwVersion;
			deviceInfo.BpFirmwareVersion = deviceInventory.BpFwVersion;
			deviceInfo.RadioBBFSuiteVersion = deviceInventory.BpFwVersion;
			deviceInfo.CodeplugVersion = deviceInventory.CodeplugVersion;
			deviceInfo.Family = deviceInventory.ProductFamily;
			deviceInfo.SerialNumber = deviceInventory.Lsn.ToEncodedBase64();
			deviceInfo.PhysicalSerialNumber = deviceInventory.Psn;
			deviceInfo.ElectronicSerialNumber = deviceInventory.BpEsn;
			deviceInfo.Region = 0;
			deviceInfo.IMEI = deviceInventory.Imei;
			deviceInfo.IMEI2 = deviceInventory.Imei2;
			deviceInfo.BluetoothMacAddress = deviceInventory.BtMacAddress;
			deviceInfo.ApWifiMacAddress = deviceInventory.WifiMacAddress;
			deviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
		}
	}
}
