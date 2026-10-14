using System;
using System.ComponentModel;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000075 RID: 117
	public class NullableConverter<T> : global::System.ComponentModel.NullableConverter where T : struct
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x00012A13 File Offset: 0x00010C13
		public NullableConverter() : base(global::Infragistics.Windows.Helpers.NullableConverter<T>._nullableType)
		{
		}

		// Token: 0x040001B4 RID: 436
		private static readonly global::System.Type _nullableType = (global::System.Nullable.GetUnderlyingType(typeof(T)) == null) ? typeof(T?) : typeof(T);
	}
}
