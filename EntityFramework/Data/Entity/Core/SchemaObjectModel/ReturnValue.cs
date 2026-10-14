using System;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200030C RID: 780
	internal sealed class ReturnValue<T>
	{
		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060024FD RID: 9469 RVA: 0x00068107 File Offset: 0x00066307
		internal bool Succeeded
		{
			get
			{
				return this._succeeded;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060024FE RID: 9470 RVA: 0x0006810F File Offset: 0x0006630F
		// (set) Token: 0x060024FF RID: 9471 RVA: 0x00068117 File Offset: 0x00066317
		internal T Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
				this._succeeded = true;
			}
		}

		// Token: 0x04000D13 RID: 3347
		private bool _succeeded;

		// Token: 0x04000D14 RID: 3348
		private T _value;
	}
}
