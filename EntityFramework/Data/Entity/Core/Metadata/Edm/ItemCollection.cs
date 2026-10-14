using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004CD RID: 1229
	public abstract class ItemCollection : global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem>
	{
		// Token: 0x06003CF1 RID: 15601 RVA: 0x000C8DE4 File Offset: 0x000C6FE4
		internal ItemCollection()
		{
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x000C8DEC File Offset: 0x000C6FEC
		internal ItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataspace) : base(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem>())
		{
			this._space = dataspace;
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x000C8E00 File Offset: 0x000C7000
		public global::System.Data.Entity.Core.Metadata.Edm.DataSpace DataSpace
		{
			get
			{
				return this._space;
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06003CF4 RID: 15604 RVA: 0x000C8E08 File Offset: 0x000C7008
		internal global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>> FunctionLookUpTable
		{
			get
			{
				if (this._functionLookUpTable == null)
				{
					global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>> value = global::System.Data.Entity.Core.Metadata.Edm.ItemCollection.PopulateFunctionLookUpTable(this);
					global::System.Threading.Interlocked.CompareExchange<global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>>>(ref this._functionLookUpTable, value, null);
				}
				return this._functionLookUpTable;
			}
		}

		// Token: 0x06003CF5 RID: 15605 RVA: 0x000C8E38 File Offset: 0x000C7038
		internal void AddInternal(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			base.Source.Add(item);
		}

		// Token: 0x06003CF6 RID: 15606 RVA: 0x000C8E46 File Offset: 0x000C7046
		internal void AddRange(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> items)
		{
			base.Source.AddRange(items);
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x000C8E54 File Offset: 0x000C7054
		public T GetItem<T>(string identity) where T : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem
		{
			return this.GetItem<T>(identity, false);
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x000C8E5E File Offset: 0x000C705E
		public bool TryGetItem<T>(string identity, out T item) where T : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem
		{
			return this.TryGetItem<T>(identity, false, out item);
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x000C8E6C File Offset: 0x000C706C
		public bool TryGetItem<T>(string identity, bool ignoreCase, out T item) where T : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem
		{
			global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem = null;
			this.TryGetValue(identity, ignoreCase, out globalItem);
			item = (globalItem as T);
			return item != null;
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x000C8EA8 File Offset: 0x000C70A8
		public T GetItem<T>(string identity, bool ignoreCase) where T : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem
		{
			T result;
			if (this.TryGetItem<T>(identity, ignoreCase, out result))
			{
				return result;
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ItemInvalidIdentity(identity), "identity");
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x000C8ED4 File Offset: 0x000C70D4
		public virtual global::System.Collections.ObjectModel.ReadOnlyCollection<T> GetItems<T>() where T : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem
		{
			global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Collections.ICollection> itemsCache = this._itemsCache;
			if (this._itemsCache == null || this._itemCount != base.Count)
			{
				global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Collections.ICollection> value = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Collections.ICollection>(new global::System.Func<global::System.Type, global::System.Collections.ICollection>(this.InternalGetItems), null);
				global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Collections.ICollection>>(ref this._itemsCache, value, itemsCache);
				this._itemCount = base.Count;
			}
			return this._itemsCache.Evaluate(typeof(T)) as global::System.Collections.ObjectModel.ReadOnlyCollection<T>;
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x000C8F45 File Offset: 0x000C7145
		internal global::System.Collections.ICollection InternalGetItems(global::System.Type type)
		{
			return typeof(global::System.Data.Entity.Core.Metadata.Edm.ItemCollection).GetOnlyDeclaredMethod("GenericGetItems").MakeGenericMethod(new global::System.Type[]
			{
				type
			}).Invoke(null, new object[]
			{
				this
			}) as global::System.Collections.ICollection;
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x000C8F80 File Offset: 0x000C7180
		private static global::System.Collections.ObjectModel.ReadOnlyCollection<TItem> GenericGetItems<TItem>(global::System.Data.Entity.Core.Metadata.Edm.ItemCollection collection) where TItem : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem
		{
			global::System.Collections.Generic.List<TItem> list = new global::System.Collections.Generic.List<TItem>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem in collection)
			{
				TItem titem = globalItem as TItem;
				if (titem != null)
				{
					list.Add(titem);
				}
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<TItem>(list);
		}

		// Token: 0x06003CFE RID: 15614 RVA: 0x000C8FEC File Offset: 0x000C71EC
		public global::System.Data.Entity.Core.Metadata.Edm.EdmType GetType(string name, string namespaceName)
		{
			return this.GetType(name, namespaceName, false);
		}

		// Token: 0x06003CFF RID: 15615 RVA: 0x000C8FF7 File Offset: 0x000C71F7
		public bool TryGetType(string name, string namespaceName, out global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			return this.TryGetType(name, namespaceName, false, out type);
		}

		// Token: 0x06003D00 RID: 15616 RVA: 0x000C9003 File Offset: 0x000C7203
		public global::System.Data.Entity.Core.Metadata.Edm.EdmType GetType(string name, string namespaceName, bool ignoreCase)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(namespaceName, "namespaceName");
			return this.GetItem<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(global::System.Data.Entity.Core.Metadata.Edm.EdmType.CreateEdmTypeIdentity(namespaceName, name), ignoreCase);
		}

		// Token: 0x06003D01 RID: 15617 RVA: 0x000C902C File Offset: 0x000C722C
		public bool TryGetType(string name, string namespaceName, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EdmType type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(namespaceName, "namespaceName");
			global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem = null;
			this.TryGetValue(global::System.Data.Entity.Core.Metadata.Edm.EdmType.CreateEdmTypeIdentity(namespaceName, name), ignoreCase, out globalItem);
			type = (globalItem as global::System.Data.Entity.Core.Metadata.Edm.EdmType);
			return type != null;
		}

		// Token: 0x06003D02 RID: 15618 RVA: 0x000C9073 File Offset: 0x000C7273
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetFunctions(string functionName)
		{
			return this.GetFunctions(functionName, false);
		}

		// Token: 0x06003D03 RID: 15619 RVA: 0x000C907D File Offset: 0x000C727D
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetFunctions(string functionName, bool ignoreCase)
		{
			return global::System.Data.Entity.Core.Metadata.Edm.ItemCollection.GetFunctions(this.FunctionLookUpTable, functionName, ignoreCase);
		}

		// Token: 0x06003D04 RID: 15620 RVA: 0x000C908C File Offset: 0x000C728C
		protected static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetFunctions(global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>> functionCollection, string functionName, bool ignoreCase)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> readOnlyCollection;
			if (!functionCollection.TryGetValue(functionName, out readOnlyCollection))
			{
				return global::System.Data.Entity.Core.Metadata.Edm.Helper.EmptyEdmFunctionReadOnlyCollection;
			}
			if (ignoreCase)
			{
				return readOnlyCollection;
			}
			return global::System.Data.Entity.Core.Metadata.Edm.ItemCollection.GetCaseSensitiveFunctions(readOnlyCollection, functionName);
		}

		// Token: 0x06003D05 RID: 15621 RVA: 0x000C90B8 File Offset: 0x000C72B8
		internal static global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> GetCaseSensitiveFunctions(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functionOverloads, string functionName)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(functionOverloads.Count);
			for (int i = 0; i < functionOverloads.Count; i++)
			{
				if (functionOverloads[i].FullName == functionName)
				{
					list.Add(functionOverloads[i]);
				}
			}
			if (list.Count != functionOverloads.Count)
			{
				functionOverloads = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(list);
			}
			return functionOverloads;
		}

		// Token: 0x06003D06 RID: 15622 RVA: 0x000C911C File Offset: 0x000C731C
		internal bool TryGetFunction(string functionName, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] parameterTypes, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(functionName, "functionName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[]>(parameterTypes, "parameterTypes");
			string identity = global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.BuildIdentity(functionName, parameterTypes);
			global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem = null;
			function = null;
			if (this.TryGetValue(identity, ignoreCase, out globalItem) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEdmFunction(globalItem))
			{
				function = (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction)globalItem;
				return true;
			}
			return false;
		}

		// Token: 0x06003D07 RID: 15623 RVA: 0x000C916F File Offset: 0x000C736F
		public global::System.Data.Entity.Core.Metadata.Edm.EntityContainer GetEntityContainer(string name)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			return this.GetEntityContainer(name, false);
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x000C9185 File Offset: 0x000C7385
		public bool TryGetEntityContainer(string name, out global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			return this.TryGetEntityContainer(name, false, out entityContainer);
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x000C919C File Offset: 0x000C739C
		public global::System.Data.Entity.Core.Metadata.Edm.EntityContainer GetEntityContainer(string name, bool ignoreCase)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer = this.GetValue(name, ignoreCase) as global::System.Data.Entity.Core.Metadata.Edm.EntityContainer;
			if (entityContainer != null)
			{
				return entityContainer;
			}
			throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ItemInvalidIdentity(name), "name");
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x000C91CC File Offset: 0x000C73CC
		public bool TryGetEntityContainer(string name, bool ignoreCase, out global::System.Data.Entity.Core.Metadata.Edm.EntityContainer entityContainer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Core.Metadata.Edm.GlobalItem globalItem = null;
			if (this.TryGetValue(name, ignoreCase, out globalItem) && global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEntityContainer(globalItem))
			{
				entityContainer = (global::System.Data.Entity.Core.Metadata.Edm.EntityContainer)globalItem;
				return true;
			}
			entityContainer = null;
			return false;
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x000C9209 File Offset: 0x000C7409
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType GetMappedPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind)
		{
			throw global::System.Data.Entity.Resources.Error.NotSupported();
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x000C9210 File Offset: 0x000C7410
		internal virtual bool MetadataEquals(global::System.Data.Entity.Core.Metadata.Edm.ItemCollection other)
		{
			return this == other;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x000C9218 File Offset: 0x000C7418
		private static global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>> PopulateFunctionLookUpTable(global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>>(global::System.StringComparer.OrdinalIgnoreCase);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction in itemCollection.GetItems<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>())
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> list;
				if (!dictionary.TryGetValue(edmFunction.FullName, out list))
				{
					list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();
					dictionary[edmFunction.FullName] = list;
				}
				list.Add(edmFunction);
			}
			global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>> dictionary2 = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>>(global::System.StringComparer.OrdinalIgnoreCase);
			foreach (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> list2 in dictionary.Values)
			{
				dictionary2.Add(list2[0].FullName, new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(list2.ToArray()));
			}
			return dictionary2;
		}

		// Token: 0x040014E7 RID: 5351
		private readonly global::System.Data.Entity.Core.Metadata.Edm.DataSpace _space;

		// Token: 0x040014E8 RID: 5352
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>> _functionLookUpTable;

		// Token: 0x040014E9 RID: 5353
		private global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Type, global::System.Collections.ICollection> _itemsCache;

		// Token: 0x040014EA RID: 5354
		private int _itemCount;
	}
}
