using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A2 RID: 418
	public class ForeignKeyIndexConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IStoreModelConvention<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001762 RID: 5986 RVA: 0x0003DB98 File Offset: 0x0003BD98
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, "item");
			if (item.Constraint == null)
			{
				return;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.ConsolidatedIndex> source = global::System.Data.Entity.Infrastructure.ConsolidatedIndex.BuildIndexes(item.Name, from p in item.Constraint.ToProperties
			select global::System.Tuple.Create<string, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(p.Name, p));
			global::System.Collections.Generic.IEnumerable<string> dependentColumnNames = from p in item.Constraint.ToProperties
			select p.Name;
			if (!source.Any((global::System.Data.Entity.Infrastructure.ConsolidatedIndex c) => c.Columns.SequenceEqual(dependentColumnNames)))
			{
				string name = global::System.Data.Entity.Migrations.Model.IndexOperation.BuildDefaultName(dependentColumnNames);
				int num = 0;
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in item.Constraint.ToProperties)
				{
					global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation indexAnnotation = new global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation(new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute(name, num++));
					object annotation = edmProperty.Annotations.GetAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:Index");
					if (annotation != null)
					{
						indexAnnotation = (global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation)((global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation)annotation).MergeWith(indexAnnotation);
					}
					edmProperty.AddAnnotation("http://schemas.microsoft.com/ado/2013/11/edm/customannotation:Index", indexAnnotation);
				}
			}
		}
	}
}
