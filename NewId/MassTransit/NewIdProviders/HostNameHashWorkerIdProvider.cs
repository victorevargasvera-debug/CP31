using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace MassTransit.NewIdProviders
{
	// Token: 0x0200000F RID: 15
	public class HostNameHashWorkerIdProvider : global::MassTransit.IWorkerIdProvider
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002ED2 File Offset: 0x000010D2
		public byte[] GetWorkerId(int index)
		{
			return global::MassTransit.NewIdProviders.HostNameHashWorkerIdProvider.GetNetworkAddress();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002EDC File Offset: 0x000010DC
		private static byte[] GetNetworkAddress()
		{
			byte[] result;
			try
			{
				string hostName = global::System.Net.Dns.GetHostName();
				byte[] src;
				using (global::System.Security.Cryptography.SHA1 sha = global::System.Security.Cryptography.SHA1.Create())
				{
					src = sha.ComputeHash(global::System.Text.Encoding.UTF8.GetBytes(hostName));
				}
				byte[] array = new byte[6];
				global::System.Buffer.BlockCopy(src, 12, array, 0, 6);
				byte[] array2 = array;
				int num = 0;
				array2[num] |= 128;
				result = array;
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.InvalidOperationException("Unable to retrieve hostname", innerException);
			}
			return result;
		}
	}
}
