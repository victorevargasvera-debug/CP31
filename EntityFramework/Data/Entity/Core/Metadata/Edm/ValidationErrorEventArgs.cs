using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000503 RID: 1283
	internal class ValidationErrorEventArgs : global::System.EventArgs
	{
		// Token: 0x06003FAF RID: 16303 RVA: 0x000D31F5 File Offset: 0x000D13F5
		public ValidationErrorEventArgs(global::System.Data.Entity.Core.Metadata.Edm.EdmItemError validationError)
		{
			this._validationError = validationError;
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x000D3204 File Offset: 0x000D1404
		public global::System.Data.Entity.Core.Metadata.Edm.EdmItemError ValidationError
		{
			get
			{
				return this._validationError;
			}
		}

		// Token: 0x040015A3 RID: 5539
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmItemError _validationError;
	}
}
