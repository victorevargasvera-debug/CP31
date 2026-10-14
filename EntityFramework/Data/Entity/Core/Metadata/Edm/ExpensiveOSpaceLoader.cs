using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004C0 RID: 1216
	internal class ExpensiveOSpaceLoader
	{
		// Token: 0x06003C3B RID: 15419 RVA: 0x000C6AF8 File Offset: 0x000C4CF8
		public virtual global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> LoadTypesExpensiveWay(global::System.Reflection.Assembly assembly)
		{
			global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet knownAssemblies = new global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet();
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> result;
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmItemError> list;
			global::System.Data.Entity.Core.Metadata.Edm.AssemblyCache.LoadAssembly(assembly, false, knownAssemblies, out result, out list);
			if (list.Count != 0)
			{
				throw global::System.Data.Entity.Core.EntityUtil.InvalidSchemaEncountered(global::System.Data.Entity.Core.Metadata.Edm.Helper.CombineErrorMessage(list));
			}
			return result;
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x000C6B2C File Offset: 0x000C4D2C
		public virtual global::System.Data.Entity.Core.Metadata.Edm.AssociationType GetRelationshipTypeExpensiveWay(global::System.Type entityClrType, string relationshipName)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> dictionary = this.LoadTypesExpensiveWay(entityClrType.Assembly());
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType;
			if (dictionary != null && dictionary.TryGetValue(relationshipName, out edmType) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipType(edmType))
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)edmType;
			}
			return null;
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x000C6B64 File Offset: 0x000C4D64
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> GetAllRelationshipTypesExpensiveWay(global::System.Reflection.Assembly assembly)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType> dictionary = this.LoadTypesExpensiveWay(assembly);
			if (dictionary != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in dictionary.Values)
				{
					if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsAssociationType(edmType))
					{
						yield return (global::System.Data.Entity.Core.Metadata.Edm.AssociationType)edmType;
					}
				}
				global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType>.ValueCollection.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Metadata.Edm.EdmType>.ValueCollection.Enumerator);
			}
			yield break;
			yield break;
		}
	}
}
