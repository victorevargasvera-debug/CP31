using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A0 RID: 416
	public class ColumnOrderingConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IStoreModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntityType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x0600175C RID: 5980 RVA: 0x0003D9B0 File Offset: 0x0003BBB0
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntityType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			this.ValidateColumns(item, model.StoreModel.GetEntitySet(item).Table);
			global::System.Data.Entity.ModelConfiguration.Conventions.ColumnOrderingConvention.OrderColumns(item.Properties).Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c)
			{
				bool isPrimaryKeyColumn = c.IsPrimaryKeyColumn;
				item.RemoveMember(c);
				item.AddMember(c);
				if (isPrimaryKeyColumn)
				{
					item.AddKeyMember(c);
				}
			});
			item.ForeignKeyBuilders.Each((global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder fk) => fk.DependentColumns = global::System.Data.Entity.ModelConfiguration.Conventions.ColumnOrderingConvention.OrderColumns(fk.DependentColumns));
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0003DA59 File Offset: 0x0003BC59
		protected virtual void ValidateColumns(global::System.Data.Entity.Core.Metadata.Edm.EntityType table, string tableName)
		{
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x0003DA5C File Offset: 0x0003BC5C
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> OrderColumns(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> columns)
		{
			return (from c in columns
			select new
			{
				Column = c,
				Order = (c.GetOrder() ?? int.MaxValue)
			} into c
			orderby c.Order
			select c.Column).ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
		}
	}
}
