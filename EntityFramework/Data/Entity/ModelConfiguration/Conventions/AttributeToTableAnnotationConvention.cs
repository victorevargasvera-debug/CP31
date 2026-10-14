using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000189 RID: 393
	public class AttributeToTableAnnotationConvention<TAttribute, TAnnotation> : global::System.Data.Entity.ModelConfiguration.Conventions.Convention where TAttribute : global::System.Attribute
	{
		// Token: 0x06001720 RID: 5920 RVA: 0x0003C924 File Offset: 0x0003AB24
		public AttributeToTableAnnotationConvention(string annotationName, global::System.Func<global::System.Type, global::System.Collections.Generic.IList<TAttribute>, TAnnotation> annotationFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(annotationName, "annotationName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Type, global::System.Collections.Generic.IList<TAttribute>, TAnnotation>>(annotationFactory, "annotationFactory");
			global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider attributeProvider = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>();
			base.Types().Having<global::System.Collections.Generic.List<TAttribute>>((global::System.Type t) => attributeProvider.GetAttributes(t).OfType<TAttribute>().ToList<TAttribute>()).Configure(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration c, global::System.Collections.Generic.List<TAttribute> a)
			{
				if (a.Any<TAttribute>())
				{
					c.HasTableAnnotation(annotationName, annotationFactory(c.ClrType, a));
				}
			});
		}
	}
}
