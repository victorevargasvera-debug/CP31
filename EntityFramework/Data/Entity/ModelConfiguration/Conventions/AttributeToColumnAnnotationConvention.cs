using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000188 RID: 392
	public class AttributeToColumnAnnotationConvention<TAttribute, TAnnotation> : global::System.Data.Entity.ModelConfiguration.Conventions.Convention where TAttribute : global::System.Attribute
	{
		// Token: 0x0600171F RID: 5919 RVA: 0x0003C89C File Offset: 0x0003AA9C
		public AttributeToColumnAnnotationConvention(string annotationName, global::System.Func<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.IList<TAttribute>, TAnnotation> annotationFactory)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(annotationName, "annotationName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Reflection.PropertyInfo, global::System.Collections.Generic.IList<TAttribute>, TAnnotation>>(annotationFactory, "annotationFactory");
			global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider attributeProvider = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>();
			base.Properties().Having<global::System.Collections.Generic.List<TAttribute>>((global::System.Reflection.PropertyInfo pi) => attributeProvider.GetAttributes(pi).OfType<TAttribute>().ToList<TAttribute>()).Configure(delegate(global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration c, global::System.Collections.Generic.List<TAttribute> a)
			{
				if (a.Any<TAttribute>())
				{
					c.HasColumnAnnotation(annotationName, annotationFactory(c.ClrPropertyInfo, a));
				}
			});
		}
	}
}
