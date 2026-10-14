using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200007B RID: 123
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class ErrorEventArgs : global::System.EventArgs
	{
		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001BB5B File Offset: 0x00019D5B
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public object CurrentObject { [global::System.Runtime.CompilerServices.NullableContext(2)] get; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001BB63 File Offset: 0x00019D63
		public global::Newtonsoft.Json.Serialization.ErrorContext ErrorContext { get; }

		// Token: 0x06000674 RID: 1652 RVA: 0x0001BB6B File Offset: 0x00019D6B
		public ErrorEventArgs([global::System.Runtime.CompilerServices.Nullable(2)] object currentObject, global::Newtonsoft.Json.Serialization.ErrorContext errorContext)
		{
			this.CurrentObject = currentObject;
			this.ErrorContext = errorContext;
		}
	}
}
