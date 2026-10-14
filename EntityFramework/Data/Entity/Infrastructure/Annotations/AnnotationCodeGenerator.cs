using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure.Annotations
{
	// Token: 0x020002C1 RID: 705
	public abstract class AnnotationCodeGenerator
	{
		// Token: 0x0600221A RID: 8730 RVA: 0x0005EF94 File Offset: 0x0005D194
		public virtual global::System.Collections.Generic.IEnumerable<string> GetExtraNamespaces(global::System.Collections.Generic.IEnumerable<string> annotationNames)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<string>>(annotationNames, "annotationNames");
			return global::System.Linq.Enumerable.Empty<string>();
		}

		// Token: 0x0600221B RID: 8731
		public abstract void Generate(string annotationName, object annotation, global::System.Data.Entity.Migrations.Utilities.IndentedTextWriter writer);
	}
}
