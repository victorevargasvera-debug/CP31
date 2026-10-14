using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200018E RID: 398
	public class IndexAttributeConvention : global::System.Data.Entity.ModelConfiguration.Conventions.AttributeToColumnAnnotationConvention<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute, global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation>
	{
		// Token: 0x06001729 RID: 5929 RVA: 0x0003CB4F File Offset: 0x0003AD4F
		public IndexAttributeConvention() : base("Index", (global::System.Reflection.PropertyInfo p, global::System.Collections.Generic.IList<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> a) => new global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation(p, from i in a
		orderby i.ToString()
		select i))
		{
		}
	}
}
