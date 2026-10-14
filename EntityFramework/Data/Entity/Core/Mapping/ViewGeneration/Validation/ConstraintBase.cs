using System;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Validation
{
	// Token: 0x0200057B RID: 1403
	internal abstract class ConstraintBase : global::System.Data.Entity.Core.Common.Utils.InternalBase
	{
		// Token: 0x0600440A RID: 17418
		internal abstract global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record GetErrorRecord();
	}
}
