using System;

namespace System.Data.Entity.Validation
{
	// Token: 0x02000071 RID: 113
	[global::System.Serializable]
	public class DbValidationError
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x0000E82E File Offset: 0x0000CA2E
		public DbValidationError(string propertyName, string errorMessage)
		{
			this._propertyName = propertyName;
			this._errorMessage = errorMessage;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0000E844 File Offset: 0x0000CA44
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0000E84C File Offset: 0x0000CA4C
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
		}

		// Token: 0x04000110 RID: 272
		private readonly string _propertyName;

		// Token: 0x04000111 RID: 273
		private readonly string _errorMessage;
	}
}
