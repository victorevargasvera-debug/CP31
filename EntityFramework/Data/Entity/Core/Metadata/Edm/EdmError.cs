using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004A3 RID: 1187
	[global::System.Serializable]
	public abstract class EdmError
	{
		// Token: 0x06003A58 RID: 14936 RVA: 0x000BFF72 File Offset: 0x000BE172
		internal EdmError(string message)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(message, "message");
			this._message = message;
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x000BFF8D File Offset: 0x000BE18D
		public string Message
		{
			get
			{
				return this._message;
			}
		}

		// Token: 0x04001410 RID: 5136
		private readonly string _message;
	}
}
