using System;

namespace Gibraltar.Data
{
	// Token: 0x020000EA RID: 234
	internal abstract class LogicNode
	{
		// Token: 0x02000495 RID: 1173
		// (Invoke) Token: 0x06003314 RID: 13076
		public delegate R GetDataValueDelegate<K, R>(K key);

		// Token: 0x02000496 RID: 1174
		// (Invoke) Token: 0x06003318 RID: 13080
		public delegate int ComparisonDelegate<T>(T data, T fieldValue);
	}
}
