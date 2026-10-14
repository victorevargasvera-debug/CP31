using System;
using System.Collections.Generic;

namespace MassTransit.NewIdProviders
{
	// Token: 0x0200000D RID: 13
	public class BestPossibleWorkerIdProvider : global::MassTransit.IWorkerIdProvider
	{
		// Token: 0x06000036 RID: 54 RVA: 0x00002E18 File Offset: 0x00001018
		public byte[] GetWorkerId(int index)
		{
			global::System.Collections.Generic.List<global::System.Exception> list = new global::System.Collections.Generic.List<global::System.Exception>();
			try
			{
				return new global::MassTransit.NewIdProviders.NetworkAddressWorkerIdProvider().GetWorkerId(index);
			}
			catch (global::System.Exception item)
			{
				list.Add(item);
			}
			try
			{
				return new global::MassTransit.NewIdProviders.WmiNetworkAddressWorkerIdProvider().GetWorkerId(index);
			}
			catch (global::System.Exception item2)
			{
				list.Add(item2);
			}
			try
			{
				return new global::MassTransit.NewIdProviders.HostNameHashWorkerIdProvider().GetWorkerId(index);
			}
			catch (global::System.Exception item3)
			{
				list.Add(item3);
			}
			throw new global::System.AggregateException(list);
		}
	}
}
