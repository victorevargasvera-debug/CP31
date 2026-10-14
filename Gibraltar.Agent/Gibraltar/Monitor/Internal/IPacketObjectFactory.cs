using System;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000202 RID: 514
	internal interface IPacketObjectFactory<DataObjectType, ParentObjectType>
	{
		// Token: 0x06001982 RID: 6530
		DataObjectType GetDataObject(ParentObjectType optionalParent);
	}
}
