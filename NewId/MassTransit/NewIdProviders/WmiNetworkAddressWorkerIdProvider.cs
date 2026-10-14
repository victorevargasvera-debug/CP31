using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management;

namespace MassTransit.NewIdProviders
{
	// Token: 0x02000013 RID: 19
	public class WmiNetworkAddressWorkerIdProvider : global::MassTransit.IWorkerIdProvider
	{
		// Token: 0x06000044 RID: 68 RVA: 0x000030F2 File Offset: 0x000012F2
		public byte[] GetWorkerId(int index)
		{
			return global::MassTransit.NewIdProviders.WmiNetworkAddressWorkerIdProvider.GetNetworkAddress(index);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000030FC File Offset: 0x000012FC
		private static byte[] GetNetworkAddress(int index)
		{
			byte[] array = global::MassTransit.NewIdProviders.WmiNetworkAddressWorkerIdProvider.GetManagementObjects().Skip(index).FirstOrDefault<byte[]>();
			if (array == null)
			{
				throw new global::System.InvalidOperationException("Unable to find usable network adapter for unique address");
			}
			return array;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003129 File Offset: 0x00001329
		private static global::System.Collections.Generic.IEnumerable<byte[]> GetManagementObjects()
		{
			global::System.Management.EnumerationOptions options = new global::System.Management.EnumerationOptions
			{
				Rewindable = false,
				ReturnImmediately = true
			};
			global::System.Management.ManagementScope scope = new global::System.Management.ManagementScope(global::System.Management.ManagementPath.DefaultPath);
			global::System.Management.ObjectQuery query = new global::System.Management.ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
			global::System.Management.ManagementObjectSearcher managementObjectSearcher = new global::System.Management.ManagementObjectSearcher(scope, query, options);
			global::System.Management.ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			foreach (global::System.Management.ManagementBaseObject managementBaseObject in managementObjectCollection)
			{
				byte[] array;
				try
				{
					global::System.Management.PropertyData propertyData = managementBaseObject.Properties["MACAddress"];
					string text = propertyData.Value.ToString();
					array = (from x in text.Split(new char[]
					{
						':'
					})
					select byte.Parse(x, global::System.Globalization.NumberStyles.HexNumber)).ToArray<byte>();
				}
				catch (global::System.Exception)
				{
					continue;
				}
				if (array.Length == 6)
				{
					yield return array;
				}
			}
			global::System.Management.ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = null;
			yield break;
			yield break;
		}
	}
}
