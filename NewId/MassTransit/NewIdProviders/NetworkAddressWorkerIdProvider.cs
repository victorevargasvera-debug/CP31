using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace MassTransit.NewIdProviders
{
	// Token: 0x02000010 RID: 16
	public class NetworkAddressWorkerIdProvider : global::MassTransit.IWorkerIdProvider
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002F70 File Offset: 0x00001170
		public byte[] GetWorkerId(int index)
		{
			return global::MassTransit.NewIdProviders.NetworkAddressWorkerIdProvider.GetNetworkAddress(index);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002F78 File Offset: 0x00001178
		private static byte[] GetNetworkAddress(int index)
		{
			byte[] array = (from x in global::System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
			where x.NetworkInterfaceType == global::System.Net.NetworkInformation.NetworkInterfaceType.Ethernet || x.NetworkInterfaceType == global::System.Net.NetworkInformation.NetworkInterfaceType.GigabitEthernet || x.NetworkInterfaceType == global::System.Net.NetworkInformation.NetworkInterfaceType.Wireless80211 || x.NetworkInterfaceType == global::System.Net.NetworkInformation.NetworkInterfaceType.FastEthernetFx || x.NetworkInterfaceType == global::System.Net.NetworkInformation.NetworkInterfaceType.FastEthernetT
			select x.GetPhysicalAddress() into x
			where x != null
			select x.GetAddressBytes() into x
			where x.Length == 6
			select x).Skip(index).FirstOrDefault<byte[]>();
			if (array == null)
			{
				throw new global::System.InvalidOperationException("Unable to find usable network adapter for unique address");
			}
			return array;
		}
	}
}
