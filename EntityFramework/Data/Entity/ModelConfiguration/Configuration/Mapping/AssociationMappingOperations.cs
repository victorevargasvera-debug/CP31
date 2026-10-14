using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000213 RID: 531
	internal static class AssociationMappingOperations
	{
		// Token: 0x06001C23 RID: 7203 RVA: 0x0004EB1C File Offset: 0x0004CD1C
		private static void MoveAssociationSetMappingDependents(global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping, global::System.Data.Entity.Core.Mapping.EndPropertyMapping dependentMapping, global::System.Data.Entity.Core.Metadata.Edm.EntitySet toSet, bool useExistingColumns)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable = toSet.ElementType;
			dependentMapping.PropertyMappings.Each(delegate(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping pm)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty oldColumn = pm.Column;
				pm.Column = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TableOperations.MoveColumnAndAnyConstraints(associationSetMapping.Table, toTable, oldColumn, useExistingColumns);
				(from cc in associationSetMapping.Conditions
				where cc.Column == oldColumn
				select cc).Each((global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping cc) => cc.Column = pm.Column);
			});
			associationSetMapping.StoreEntitySet = toSet;
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0004EB6C File Offset: 0x0004CD6C
		public static void MoveAllDeclaredAssociationSetMappings(global::System.Data.Entity.Core.Metadata.Edm.DbDatabaseMapping databaseMapping, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, bool useExistingColumns)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.AssociationSetMapping> source = databaseMapping.EntityContainerMappings.SelectMany((global::System.Data.Entity.Core.Mapping.EntityContainerMapping asm) => asm.AssociationSetMappings);
			global::System.Func<global::System.Data.Entity.Core.Mapping.AssociationSetMapping, bool> <>9__1;
			global::System.Func<global::System.Data.Entity.Core.Mapping.AssociationSetMapping, bool> predicate;
			if ((predicate = <>9__1) == null)
			{
				predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.AssociationSetMapping a) => a.Table == fromTable && (a.AssociationSet.ElementType.SourceEnd.GetEntityType() == entityType || a.AssociationSet.ElementType.TargetEnd.GetEntityType() == entityType)));
			}
			global::System.Action<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> <>9__2;
			foreach (global::System.Data.Entity.Core.Mapping.AssociationSetMapping associationSetMapping in source.Where(predicate).ToArray<global::System.Data.Entity.Core.Mapping.AssociationSetMapping>())
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember targetEnd;
				if (!associationSetMapping.AssociationSet.ElementType.TryGuessPrincipalAndDependentEnds(out associationEndMember, out targetEnd))
				{
					targetEnd = associationSetMapping.AssociationSet.ElementType.TargetEnd;
				}
				if (targetEnd.GetEntityType() == entityType)
				{
					global::System.Data.Entity.Core.Mapping.EndPropertyMapping endPropertyMapping = (targetEnd == associationSetMapping.TargetEndMapping.AssociationEnd) ? associationSetMapping.SourceEndMapping : associationSetMapping.TargetEndMapping;
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.AssociationMappingOperations.MoveAssociationSetMappingDependents(associationSetMapping, endPropertyMapping, databaseMapping.Database.GetEntitySet(toTable), useExistingColumns);
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> propertyMappings = ((endPropertyMapping == associationSetMapping.TargetEndMapping) ? associationSetMapping.SourceEndMapping : associationSetMapping.TargetEndMapping).PropertyMappings;
					global::System.Action<global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping> action;
					if ((action = <>9__2) == null)
					{
						action = (<>9__2 = delegate(global::System.Data.Entity.Core.Mapping.ScalarPropertyMapping pm)
						{
							if (pm.Column.DeclaringType != toTable)
							{
								pm.Column = toTable.Properties.Single((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => string.Equals(p.GetPreferredName(), pm.Column.GetPreferredName(), global::System.StringComparison.Ordinal));
							}
						});
					}
					propertyMappings.Each(action);
				}
			}
		}
	}
}
