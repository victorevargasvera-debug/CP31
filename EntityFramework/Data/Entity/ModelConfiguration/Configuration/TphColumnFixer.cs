using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001F9 RID: 505
	internal class TphColumnFixer
	{
		// Token: 0x06001A81 RID: 6785 RVA: 0x00046930 File Offset: 0x00044B30
		public TphColumnFixer(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> columnMappings, global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EdmModel storeModel)
		{
			this._columnMappings = (from m in columnMappings
			orderby m.ColumnProperty.Name
			select m).ToList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder>();
			this._table = table;
			this._storeModel = storeModel;
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00046984 File Offset: 0x00044B84
		public void RemoveDuplicateTphColumns()
		{
			int num;
			for (int i = 0; i < this._columnMappings.Count - 1; i = num)
			{
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType declaringType = this._columnMappings[i].PropertyPath[0].DeclaringType;
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column = this._columnMappings[i].ColumnProperty;
				num = i + 1;
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
				while (num < this._columnMappings.Count && column.Name == this._columnMappings[num].ColumnProperty.Name && declaringType != this._columnMappings[num].PropertyPath[0].DeclaringType && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.TryGetCommonBaseType(declaringType, this._columnMappings[num].PropertyPath[0].DeclaringType, out edmType))
				{
					num++;
				}
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration = column.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration;
				for (int j = i + 1; j < num; j++)
				{
					global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder toFixup = this._columnMappings[j];
					global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration2 = toFixup.ColumnProperty.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration;
					string p2;
					if (primitivePropertyConfiguration != null && !primitivePropertyConfiguration.IsCompatible(primitivePropertyConfiguration2, false, out p2))
					{
						throw new global::System.Data.Entity.Core.MappingException(global::System.Data.Entity.Resources.Strings.BadTphMappingToSharedColumn(string.Join(".", from p in this._columnMappings[i].PropertyPath
						select p.Name), declaringType.Name, string.Join(".", from p in toFixup.PropertyPath
						select p.Name), toFixup.PropertyPath[0].DeclaringType.Name, column.Name, column.DeclaringType.Name, p2));
					}
					if (primitivePropertyConfiguration2 != null)
					{
						primitivePropertyConfiguration2.Configure(column, this._table, this._storeModel.ProviderManifest, false, false);
					}
					column.Nullable = true;
					foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in (from a in this._storeModel.AssociationTypes
					where a.Constraint != null
					let p = a.Constraint.ToProperties
					where p.Contains(column) || p.Contains(toFixup.ColumnProperty)
					select a).ToArray<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>())
					{
						this._storeModel.RemoveAssociationType(associationType);
					}
					if (toFixup.ColumnProperty.DeclaringType.HasMember(toFixup.ColumnProperty))
					{
						toFixup.ColumnProperty.DeclaringType.RemoveMember(toFixup.ColumnProperty);
					}
					toFixup.ColumnProperty = column;
				}
			}
		}

		// Token: 0x04000A98 RID: 2712
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> _columnMappings;

		// Token: 0x04000A99 RID: 2713
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityType _table;

		// Token: 0x04000A9A RID: 2714
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmModel _storeModel;
	}
}
