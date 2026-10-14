using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Annotations
{
	// Token: 0x020002C3 RID: 707
	public sealed class CompatibilityResult
	{
		// Token: 0x06002225 RID: 8741 RVA: 0x0005F06A File Offset: 0x0005D26A
		public CompatibilityResult(bool isCompatible, string errorMessage)
		{
			this._isCompatible = isCompatible;
			this._errorMessage = errorMessage;
			if (!isCompatible)
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(errorMessage, "errorMessage");
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x0005F08F File Offset: 0x0005D28F
		public bool IsCompatible
		{
			get
			{
				return this._isCompatible;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002227 RID: 8743 RVA: 0x0005F097 File Offset: 0x0005D297
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x0005F09F File Offset: 0x0005D29F
		public static implicit operator bool(global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult result)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult>(result, "result");
			return result._isCompatible;
		}

		// Token: 0x04000BE0 RID: 3040
		private readonly bool _isCompatible;

		// Token: 0x04000BE1 RID: 3041
		private readonly string _errorMessage;
	}
}
