using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.ModelConfiguration.Mappers;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A8 RID: 424
	public class DeclaredPropertyOrderingConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntityType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001771 RID: 6001 RVA: 0x0003E164 File Offset: 0x0003C364
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntityType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.BaseType == null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member in item.KeyProperties)
				{
					item.RemoveMember(member);
					item.AddKeyMember(member);
				}
				using (global::System.Collections.Generic.IEnumerator<global::System.Reflection.PropertyInfo> enumerator2 = new global::System.Data.Entity.ModelConfiguration.Mappers.PropertyFilter(global::System.Data.Entity.DbModelBuilderVersion.Latest).GetProperties(item.GetClrType(), false, null, null, true).GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::System.Reflection.PropertyInfo p = enumerator2.Current;
						global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = item.DeclaredProperties.SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty ep) => ep.Name == p.Name);
						if (edmProperty != null && !item.KeyProperties.Contains(edmProperty))
						{
							item.RemoveMember(edmProperty);
							item.AddMember(edmProperty);
						}
					}
				}
			}
		}
	}
}
