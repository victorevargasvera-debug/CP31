using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace NLog.LogReceiverService
{
	// Token: 0x02000092 RID: 146
	[global::System.Runtime.Serialization.CollectionDataContract(ItemName = "l", Namespace = "http://nlog-project.org/ws/")]
	public class StringCollection : global::System.Collections.ObjectModel.Collection<string>
	{
	}
}
