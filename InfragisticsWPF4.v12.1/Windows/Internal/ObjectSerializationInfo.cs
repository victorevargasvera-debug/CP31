using System;
using System.Collections.Generic;

namespace Infragistics.Windows.Internal
{
	// Token: 0x0200013C RID: 316
	public abstract class ObjectSerializationInfo
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000AB1 RID: 2737
		public abstract global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties { get; }

		// Token: 0x06000AB2 RID: 2738
		public abstract global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj);

		// Token: 0x06000AB3 RID: 2739
		public abstract object Deserialize(global::System.Collections.Generic.Dictionary<string, object> obj);

		// Token: 0x040004D3 RID: 1235
		public const string COLLECTION_ELEMENT_DESIGNATOR_KEY = "[]";
	}
}
