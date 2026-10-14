using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Autofac.Util;

namespace Autofac.Builder
{
	// Token: 0x020000BF RID: 191
	public class MetadataConfiguration<TMetadata>
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000C99E File Offset: 0x0000AB9E
		internal global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> Properties
		{
			get
			{
				return this._properties;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		public global::Autofac.Builder.MetadataConfiguration<TMetadata> For<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TMetadata, TProperty>> propertyAccessor, TProperty value)
		{
			if (propertyAccessor == null)
			{
				throw new global::System.ArgumentNullException("propertyAccessor");
			}
			string name = global::Autofac.Util.ReflectionExtensions.GetProperty<TMetadata, TProperty>(propertyAccessor).Name;
			this._properties.Add(name, value);
			return this;
		}

		// Token: 0x04000128 RID: 296
		private readonly global::System.Collections.Generic.IDictionary<string, object> _properties = new global::System.Collections.Generic.Dictionary<string, object>();
	}
}
