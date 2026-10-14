using System;
using System.ComponentModel;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x0200005E RID: 94
	public class NullableConverter<T> : global::System.ComponentModel.NullableConverter where T : struct
	{
		// Token: 0x060003B3 RID: 947 RVA: 0x000103DB File Offset: 0x0000E5DB
		public NullableConverter() : base(global::Infragistics.Windows.Helpers.NullableConverter<T>._nullableType)
		{
		}

		// Token: 0x04000146 RID: 326
		private static readonly global::System.Type _nullableType = (global::System.Nullable.GetUnderlyingType(typeof(T)) == null) ? typeof(T?) : typeof(T);
	}
}
