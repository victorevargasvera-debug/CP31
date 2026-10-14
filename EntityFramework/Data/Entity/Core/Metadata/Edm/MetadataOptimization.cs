using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004DC RID: 1244
	internal class MetadataOptimization
	{
		// Token: 0x06003DEC RID: 15852 RVA: 0x000CC9AA File Offset: 0x000CABAA
		internal MetadataOptimization(global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace workspace)
		{
			this._workspace = workspace;
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06003DED RID: 15853 RVA: 0x000CC9CF File Offset: 0x000CABCF
		internal global::System.Collections.Generic.IDictionary<global::System.Type, global::System.Data.Entity.Internal.EntitySetTypePair> EntitySetMappingCache
		{
			get
			{
				return this._entitySetMappingsCache;
			}
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x000CC9D8 File Offset: 0x000CABD8
		private void UpdateEntitySetMappings()
		{
			global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection objectItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)this._workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType> items = this._workspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
			global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EntityType> stack = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType objectSpaceType in items)
			{
				stack.Clear();
				global::System.Data.Entity.Core.Metadata.Edm.EntityType cspaceType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)this._workspace.GetEdmSpaceType(objectSpaceType);
				do
				{
					stack.Push(cspaceType);
					cspaceType = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)cspaceType.BaseType;
				}
				while (cspaceType != null);
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = null;
				global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, bool> <>9__0;
				while (entitySet == null && stack.Count > 0)
				{
					cspaceType = stack.Pop();
					foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer in this._workspace.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace))
					{
						global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> baseEntitySets = entityContainer.BaseEntitySets;
						global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase, bool> predicate;
						if ((predicate = <>9__0) == null)
						{
							predicate = (<>9__0 = ((global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase s) => s.ElementType == cspaceType));
						}
						global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase> list = baseEntitySets.Where(predicate).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase>();
						int count = list.Count;
						if (count > 1 || (count == 1 && entitySet != null))
						{
							throw global::System.Data.Entity.Resources.Error.DbContext_MESTNotSupported();
						}
						if (count == 1)
						{
							entitySet = (global::System.Data.Entity.Core.Metadata.Edm.EntitySet)list[0];
						}
					}
				}
				if (entitySet != null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntityType objectSpaceType2 = (global::System.Data.Entity.Core.Metadata.Edm.EntityType)this._workspace.GetObjectSpaceType(cspaceType);
					global::System.Type clrType = objectItemCollection.GetClrType(objectSpaceType);
					global::System.Type clrType2 = objectItemCollection.GetClrType(objectSpaceType2);
					this._entitySetMappingsCache[clrType] = new global::System.Data.Entity.Internal.EntitySetTypePair(entitySet, clrType2);
				}
			}
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x000CCBC0 File Offset: 0x000CADC0
		internal bool TryUpdateEntitySetMappingsForType(global::System.Type entityType)
		{
			if (this._entitySetMappingsCache.ContainsKey(entityType))
			{
				return true;
			}
			global::System.Type type = entityType;
			do
			{
				this._workspace.LoadFromAssembly(type.Assembly());
				type = type.BaseType();
			}
			while (type != null && type != typeof(object));
			object entitySetMappingsUpdateLock = this._entitySetMappingsUpdateLock;
			lock (entitySetMappingsUpdateLock)
			{
				if (this._entitySetMappingsCache.ContainsKey(entityType))
				{
					return true;
				}
				this.UpdateEntitySetMappings();
			}
			return this._entitySetMappingsCache.ContainsKey(entityType);
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x000CCC68 File Offset: 0x000CAE68
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType GetCSpaceAssociationType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType osAssociationType)
		{
			return this._csAssociationTypes[osAssociationType.Index];
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x000CCC7C File Offset: 0x000CAE7C
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationSet FindCSpaceAssociationSet(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, string endName, global::System.Data.Entity.Core.Metadata.Edm.EntitySet endEntitySet)
		{
			object[] cspaceAssociationTypeToSetsMap = this.GetCSpaceAssociationTypeToSetsMap();
			int index = associationType.Index;
			object obj = cspaceAssociationTypeToSetsMap[index];
			if (obj == null)
			{
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = obj as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			if (associationSet == null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet[])obj)
				{
					if (associationSet.AssociationSetEnds[endName].EntitySet == endEntitySet)
					{
						return associationSet;
					}
				}
				return null;
			}
			if (associationSet.AssociationSetEnds[endName].EntitySet != endEntitySet)
			{
				return null;
			}
			return associationSet;
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x000CCCF8 File Offset: 0x000CAEF8
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationSet FindCSpaceAssociationSet(global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType, string endName, string entitySetName, string entityContainerName, out global::System.Data.Entity.Core.Metadata.Edm.EntitySet endEntitySet)
		{
			object[] cspaceAssociationTypeToSetsMap = this.GetCSpaceAssociationTypeToSetsMap();
			int index = associationType.Index;
			object obj = cspaceAssociationTypeToSetsMap[index];
			if (obj == null)
			{
				endEntitySet = null;
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = obj as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			if (associationSet == null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet in (global::System.Data.Entity.Core.Metadata.Edm.AssociationSet[])obj)
				{
					global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = associationSet.AssociationSetEnds[endName].EntitySet;
					if (entitySet.Name == entitySetName && entitySet.EntityContainer.Name == entityContainerName)
					{
						endEntitySet = entitySet;
						return associationSet;
					}
				}
				endEntitySet = null;
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2 = associationSet.AssociationSetEnds[endName].EntitySet;
			if (entitySet2.Name == entitySetName && entitySet2.EntityContainer.Name == entityContainerName)
			{
				endEntitySet = entitySet2;
				return associationSet;
			}
			endEntitySet = null;
			return null;
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x000CCDCF File Offset: 0x000CAFCF
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType[] GetCSpaceAssociationTypes()
		{
			if (this._csAssociationTypes == null)
			{
				this._csAssociationTypes = global::System.Data.Entity.Core.Metadata.Edm.MetadataOptimization.IndexCSpaceAssociationTypes(this._workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace));
			}
			return this._csAssociationTypes;
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x000CCDFC File Offset: 0x000CAFFC
		private static global::System.Data.Entity.Core.Metadata.Edm.AssociationType[] IndexCSpaceAssociationTypes(global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>();
			int num = 0;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType in itemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>())
			{
				list.Add(associationType);
				associationType.Index = num++;
			}
			return list.ToArray();
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x000CCE64 File Offset: 0x000CB064
		internal object[] GetCSpaceAssociationTypeToSetsMap()
		{
			if (this._csAssociationTypeToSets == null)
			{
				this._csAssociationTypeToSets = global::System.Data.Entity.Core.Metadata.Edm.MetadataOptimization.MapCSpaceAssociationTypeToSets(this._workspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace), this.GetCSpaceAssociationTypes().Length);
			}
			return this._csAssociationTypeToSets;
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x000CCE9C File Offset: 0x000CB09C
		private static object[] MapCSpaceAssociationTypeToSets(global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection, int associationTypeCount)
		{
			object[] array = new object[associationTypeCount];
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer in itemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>())
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase entitySetBase in entityContainer.BaseEntitySets)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = entitySetBase as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
					if (associationSet != null)
					{
						int index = associationSet.ElementType.Index;
						global::System.Data.Entity.Core.Metadata.Edm.MetadataOptimization.AddItemAtIndex<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>(array, index, associationSet);
					}
				}
			}
			return array;
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x000CCF44 File Offset: 0x000CB144
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType GetOSpaceAssociationType(global::System.Data.Entity.Core.Metadata.Edm.AssociationType cSpaceAssociationType, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.AssociationType> initializer)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType[] ospaceAssociationTypes = this.GetOSpaceAssociationTypes();
			int index = cSpaceAssociationType.Index;
			global::System.Threading.Thread.MemoryBarrier();
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = ospaceAssociationTypes[index];
			if (associationType == null)
			{
				associationType = initializer();
				associationType.Index = index;
				ospaceAssociationTypes[index] = associationType;
				global::System.Threading.Thread.MemoryBarrier();
			}
			return associationType;
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x000CCF87 File Offset: 0x000CB187
		internal global::System.Data.Entity.Core.Metadata.Edm.AssociationType[] GetOSpaceAssociationTypes()
		{
			if (this._osAssociationTypes == null)
			{
				this._osAssociationTypes = new global::System.Data.Entity.Core.Metadata.Edm.AssociationType[this.GetCSpaceAssociationTypes().Length];
			}
			return this._osAssociationTypes;
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x000CCFB0 File Offset: 0x000CB1B0
		private static void AddItemAtIndex<T>(object[] array, int index, T newItem) where T : class
		{
			object obj = array[index];
			if (obj == null)
			{
				array[index] = newItem;
				return;
			}
			T t = obj as T;
			if (t != null)
			{
				array[index] = new T[]
				{
					t,
					newItem
				};
				return;
			}
			T[] array2 = (T[])obj;
			int num = array2.Length;
			global::System.Array.Resize<T>(ref array2, num + 1);
			array2[num] = newItem;
			array[index] = array2;
		}

		// Token: 0x04001514 RID: 5396
		private readonly global::System.Data.Entity.Core.Metadata.Edm.MetadataWorkspace _workspace;

		// Token: 0x04001515 RID: 5397
		private readonly global::System.Collections.Generic.IDictionary<global::System.Type, global::System.Data.Entity.Internal.EntitySetTypePair> _entitySetMappingsCache = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Data.Entity.Internal.EntitySetTypePair>();

		// Token: 0x04001516 RID: 5398
		private object _entitySetMappingsUpdateLock = new object();

		// Token: 0x04001517 RID: 5399
		private volatile global::System.Data.Entity.Core.Metadata.Edm.AssociationType[] _csAssociationTypes;

		// Token: 0x04001518 RID: 5400
		private volatile global::System.Data.Entity.Core.Metadata.Edm.AssociationType[] _osAssociationTypes;

		// Token: 0x04001519 RID: 5401
		private volatile object[] _csAssociationTypeToSets;
	}
}
