using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200042A RID: 1066
	internal sealed class ObjectViewQueryResultData<TElement> : global::System.Data.Entity.Core.Objects.IObjectViewData<TElement>
	{
		// Token: 0x060033F1 RID: 13297 RVA: 0x000A6EA4 File Offset: 0x000A50A4
		internal ObjectViewQueryResultData(global::System.Collections.IEnumerable queryResults, global::System.Data.Entity.Core.Objects.ObjectContext objectContext, bool forceReadOnlyList, global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet)
		{
			bool flag = global::System.Data.Entity.Core.Objects.ObjectViewQueryResultData<TElement>.IsEditable(typeof(TElement));
			this._objectContext = objectContext;
			this._entitySet = entitySet;
			this._canEditItems = flag;
			this._canModifyList = (!forceReadOnlyList && flag && this._objectContext != null);
			this._bindingList = new global::System.Collections.Generic.List<TElement>();
			foreach (object obj in queryResults)
			{
				TElement item = (TElement)((object)obj);
				this._bindingList.Add(item);
			}
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000A6F50 File Offset: 0x000A5150
		private static bool IsEditable(global::System.Type elementType)
		{
			return !(elementType == typeof(global::System.Data.Common.DbDataRecord)) && (!(elementType != typeof(global::System.Data.Common.DbDataRecord)) || !elementType.IsSubclassOf(typeof(global::System.Data.Common.DbDataRecord)));
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000A6F8D File Offset: 0x000A518D
		private void EnsureEntitySet()
		{
			if (this._entitySet == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectView_CannotResolveTheEntitySet(typeof(TElement).FullName));
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060033F4 RID: 13300 RVA: 0x000A6FB1 File Offset: 0x000A51B1
		public global::System.Collections.Generic.IList<TElement> List
		{
			get
			{
				return this._bindingList;
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x000A6FB9 File Offset: 0x000A51B9
		public bool AllowNew
		{
			get
			{
				return this._canModifyList && this._entitySet != null;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060033F6 RID: 13302 RVA: 0x000A6FCE File Offset: 0x000A51CE
		public bool AllowEdit
		{
			get
			{
				return this._canEditItems;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x000A6FD6 File Offset: 0x000A51D6
		public bool AllowRemove
		{
			get
			{
				return this._canModifyList;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060033F8 RID: 13304 RVA: 0x000A6FDE File Offset: 0x000A51DE
		public bool FiresEventOnAdd
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060033F9 RID: 13305 RVA: 0x000A6FE1 File Offset: 0x000A51E1
		public bool FiresEventOnRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060033FA RID: 13306 RVA: 0x000A6FE4 File Offset: 0x000A51E4
		public bool FiresEventOnClear
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x000A6FE7 File Offset: 0x000A51E7
		public void EnsureCanAddNew()
		{
			this.EnsureEntitySet();
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x000A6FF0 File Offset: 0x000A51F0
		public int Add(TElement item, bool isAddNew)
		{
			this.EnsureEntitySet();
			if (!isAddNew)
			{
				this._objectContext.AddObject(global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(this._entitySet.EntityContainer.Name, this._entitySet.Name), item);
			}
			this._bindingList.Add(item);
			return this._bindingList.Count - 1;
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x000A7050 File Offset: 0x000A5250
		public void CommitItemAt(int index)
		{
			this.EnsureEntitySet();
			TElement telement = this._bindingList[index];
			this._objectContext.AddObject(global::System.Data.Entity.Core.Common.TypeHelpers.GetFullName(this._entitySet.EntityContainer.Name, this._entitySet.Name), telement);
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x000A70A4 File Offset: 0x000A52A4
		public void Clear()
		{
			while (0 < this._bindingList.Count)
			{
				TElement item = this._bindingList[this._bindingList.Count - 1];
				this.Remove(item, false);
			}
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000A70E4 File Offset: 0x000A52E4
		public bool Remove(TElement item, bool isCancelNew)
		{
			bool result;
			if (isCancelNew)
			{
				result = this._bindingList.Remove(item);
			}
			else
			{
				global::System.Data.Entity.Core.Objects.EntityEntry entityEntry = this._objectContext.ObjectStateManager.FindEntityEntry(item);
				if (entityEntry != null)
				{
					entityEntry.Delete();
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x000A712C File Offset: 0x000A532C
		public global::System.ComponentModel.ListChangedEventArgs OnCollectionChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e, global::System.Data.Entity.Core.Objects.ObjectViewListener listener)
		{
			global::System.ComponentModel.ListChangedEventArgs result = null;
			if (e.Element.GetType().IsAssignableFrom(typeof(TElement)) && this._bindingList.Contains((TElement)((object)e.Element)))
			{
				TElement telement = (TElement)((object)e.Element);
				int num = this._bindingList.IndexOf(telement);
				if (num >= 0 && e.Action == global::System.ComponentModel.CollectionChangeAction.Remove)
				{
					this._bindingList.Remove(telement);
					listener.UnregisterEntityEvents(telement);
					result = new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemDeleted, num, -1);
				}
			}
			return result;
		}

		// Token: 0x040010CB RID: 4299
		private readonly global::System.Collections.Generic.List<TElement> _bindingList;

		// Token: 0x040010CC RID: 4300
		private readonly global::System.Data.Entity.Core.Objects.ObjectContext _objectContext;

		// Token: 0x040010CD RID: 4301
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet _entitySet;

		// Token: 0x040010CE RID: 4302
		private readonly bool _canEditItems;

		// Token: 0x040010CF RID: 4303
		private readonly bool _canModifyList;
	}
}
