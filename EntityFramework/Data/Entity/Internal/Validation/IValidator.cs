using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace System.Data.Entity.Internal.Validation
{
	// Token: 0x02000134 RID: 308
	internal interface IValidator
	{
		// Token: 0x060014C3 RID: 5315
		global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> Validate(global::System.Data.Entity.Internal.Validation.EntityValidationContext entityValidationContext, global::System.Data.Entity.Internal.InternalMemberEntry property);
	}
}
