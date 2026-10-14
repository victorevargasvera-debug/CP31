using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Linq.Expressions.Internal
{
	// Token: 0x02000056 RID: 86
	internal static class ReadOnlyCollectionExtensions
	{
		// Token: 0x0600021D RID: 541 RVA: 0x00008138 File Offset: 0x00006338
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<T> ToReadOnlyCollection<T>(this global::System.Collections.Generic.IEnumerable<T> sequence)
		{
			if (sequence == null)
			{
				return global::System.Linq.Expressions.Internal.ReadOnlyCollectionExtensions.DefaultReadOnlyCollection<T>.Empty;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<T> readOnlyCollection = sequence as global::System.Collections.ObjectModel.ReadOnlyCollection<T>;
			if (readOnlyCollection != null)
			{
				return readOnlyCollection;
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<T>(sequence.ToArray<T>());
		}

		// Token: 0x02000700 RID: 1792
		private static class DefaultReadOnlyCollection<T>
		{
			// Token: 0x17001013 RID: 4115
			// (get) Token: 0x0600549F RID: 21663 RVA: 0x0012F5D4 File Offset: 0x0012D7D4
			internal static global::System.Collections.ObjectModel.ReadOnlyCollection<T> Empty
			{
				get
				{
					if (global::System.Linq.Expressions.Internal.ReadOnlyCollectionExtensions.DefaultReadOnlyCollection<T>._defaultCollection == null)
					{
						global::System.Linq.Expressions.Internal.ReadOnlyCollectionExtensions.DefaultReadOnlyCollection<T>._defaultCollection = new global::System.Collections.ObjectModel.ReadOnlyCollection<T>(new T[0]);
					}
					return global::System.Linq.Expressions.Internal.ReadOnlyCollectionExtensions.DefaultReadOnlyCollection<T>._defaultCollection;
				}
			}

			// Token: 0x04001E40 RID: 7744
			private static global::System.Collections.ObjectModel.ReadOnlyCollection<T> _defaultCollection;
		}
	}
}
