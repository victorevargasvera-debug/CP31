using System;
using System.Diagnostics;

namespace MassTransit.NewIdProviders
{
	// Token: 0x02000011 RID: 17
	public class CurrentProcessIdProvider : global::MassTransit.IProcessIdProvider
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00003064 File Offset: 0x00001264
		public byte[] GetProcessId()
		{
			byte[] bytes = global::System.BitConverter.GetBytes(global::System.Diagnostics.Process.GetCurrentProcess().Id);
			if (bytes.Length < 2)
			{
				throw new global::System.InvalidOperationException("Current Process Id is of insufficient length");
			}
			return bytes;
		}
	}
}
