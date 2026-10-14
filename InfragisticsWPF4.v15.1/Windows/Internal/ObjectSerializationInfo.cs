using System;
using System.Collections.Generic;

namespace Infragistics.Windows.Internal
{
	// Token: 0x0200015B RID: 347
	public abstract class ObjectSerializationInfo
	{
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000BB3 RID: 2995
		public abstract global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties { get; }

		// Token: 0x06000BB4 RID: 2996
		public abstract global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj);

		// Token: 0x06000BB5 RID: 2997
		public abstract object Deserialize(global::System.Collections.Generic.Dictionary<string, object> obj);

		// Token: 0x0400058A RID: 1418
		public const string COLLECTION_ELEMENT_DESIGNATOR_KEY = "[]";
	}
}
