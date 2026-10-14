using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x0200020F RID: 527
	internal static class TablePrimitiveOperations
	{
		// Token: 0x06001C07 RID: 7175 RVA: 0x0004DDFC File Offset: 0x0004BFFC
		public static void AddColumn(global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			if (!table.Properties.Contains(column))
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration primitivePropertyConfiguration = column.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration;
				if (primitivePropertyConfiguration == null || string.IsNullOrWhiteSpace(primitivePropertyConfiguration.ColumnName))
				{
					string name = column.GetPreferredName() ?? column.Name;
					column.SetUnpreferredUniqueName(column.Name);
					column.Name = table.Properties.UniquifyName(name);
				}
				table.AddMember(column);
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0004DE69 File Offset: 0x0004C069
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty RemoveColumn(global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			if (!column.IsPrimaryKeyColumn)
			{
				table.RemoveMember(column);
			}
			return column;
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0004DE7C File Offset: 0x0004C07C
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty IncludeColumn(global::System.Data.Entity.Core.Metadata.Edm.EntityType table, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty templateColumn, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> isCompatible, bool useExisting)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = table.Properties.FirstOrDefault(isCompatible);
			if (edmProperty == null)
			{
				templateColumn = templateColumn.Clone();
			}
			else if (!useExisting && !edmProperty.IsPrimaryKeyColumn)
			{
				templateColumn = templateColumn.Clone();
			}
			else
			{
				templateColumn = edmProperty;
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.AddColumn(table, templateColumn);
			return templateColumn;
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0004DEC3 File Offset: 0x0004C0C3
		public static global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> GetNameMatcher(string name)
		{
			return (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c) => string.Equals(c.Name, name, global::System.StringComparison.Ordinal);
		}
	}
}
