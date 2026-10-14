using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x02000180 RID: 384
	internal abstract class PropertyConventionBase : global::System.Data.Entity.ModelConfiguration.Conventions.IConfigurationConvention<global::System.Reflection.PropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x060016F1 RID: 5873 RVA: 0x0003C4D5 File Offset: 0x0003A6D5
		public PropertyConventionBase(global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> predicates)
		{
			this._predicates = predicates;
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0003C4E4 File Offset: 0x0003A6E4
		internal global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> Predicates
		{
			get
			{
				return this._predicates;
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0003C4EC File Offset: 0x0003A6EC
		public void Apply(global::System.Reflection.PropertyInfo memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			if (this._predicates.All((global::System.Func<global::System.Reflection.PropertyInfo, bool> p) => p(memberInfo)))
			{
				this.ApplyCore(memberInfo, configuration, modelConfiguration);
			}
		}

		// Token: 0x060016F4 RID: 5876
		protected abstract void ApplyCore(global::System.Reflection.PropertyInfo memberInfo, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration> configuration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration);

		// Token: 0x04000A21 RID: 2593
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Func<global::System.Reflection.PropertyInfo, bool>> _predicates;
	}
}
