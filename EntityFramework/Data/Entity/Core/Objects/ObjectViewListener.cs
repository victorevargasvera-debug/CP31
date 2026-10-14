using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000429 RID: 1065
	internal sealed class ObjectViewListener
	{
		// Token: 0x060033E7 RID: 13287 RVA: 0x000A6C25 File Offset: 0x000A4E25
		internal ObjectViewListener(global::System.Data.Entity.Core.Objects.IObjectView view, global::System.Collections.IList list, object dataSource)
		{
			this._viewWeak = new global::System.WeakReference(view);
			this._dataSource = dataSource;
			this._list = list;
			this.RegisterCollectionEvents();
			this.RegisterEntityEvents();
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x000A6C53 File Offset: 0x000A4E53
		private void CleanUpListener()
		{
			this.UnregisterCollectionEvents();
			this.UnregisterEntityEvents();
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x000A6C64 File Offset: 0x000A4E64
		private void RegisterCollectionEvents()
		{
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this._dataSource as global::System.Data.Entity.Core.Objects.ObjectStateManager;
			if (objectStateManager != null)
			{
				objectStateManager.EntityDeleted += this.CollectionChanged;
				return;
			}
			if (this._dataSource != null)
			{
				((global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd)this._dataSource).AssociationChangedForObjectView += this.CollectionChanged;
			}
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x000A6CB8 File Offset: 0x000A4EB8
		private void UnregisterCollectionEvents()
		{
			global::System.Data.Entity.Core.Objects.ObjectStateManager objectStateManager = this._dataSource as global::System.Data.Entity.Core.Objects.ObjectStateManager;
			if (objectStateManager != null)
			{
				objectStateManager.EntityDeleted -= this.CollectionChanged;
				return;
			}
			if (this._dataSource != null)
			{
				((global::System.Data.Entity.Core.Objects.DataClasses.RelatedEnd)this._dataSource).AssociationChangedForObjectView -= this.CollectionChanged;
			}
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x000A6D0C File Offset: 0x000A4F0C
		internal void RegisterEntityEvents(object entity)
		{
			global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = entity as global::System.ComponentModel.INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
			{
				notifyPropertyChanged.PropertyChanged += this.EntityPropertyChanged;
			}
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x000A6D38 File Offset: 0x000A4F38
		private void RegisterEntityEvents()
		{
			if (this._list != null)
			{
				foreach (object obj in this._list)
				{
					global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = obj as global::System.ComponentModel.INotifyPropertyChanged;
					if (notifyPropertyChanged != null)
					{
						notifyPropertyChanged.PropertyChanged += this.EntityPropertyChanged;
					}
				}
			}
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000A6DA8 File Offset: 0x000A4FA8
		internal void UnregisterEntityEvents(object entity)
		{
			global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = entity as global::System.ComponentModel.INotifyPropertyChanged;
			if (notifyPropertyChanged != null)
			{
				notifyPropertyChanged.PropertyChanged -= this.EntityPropertyChanged;
			}
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x000A6DD4 File Offset: 0x000A4FD4
		private void UnregisterEntityEvents()
		{
			if (this._list != null)
			{
				foreach (object obj in this._list)
				{
					global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = obj as global::System.ComponentModel.INotifyPropertyChanged;
					if (notifyPropertyChanged != null)
					{
						notifyPropertyChanged.PropertyChanged -= this.EntityPropertyChanged;
					}
				}
			}
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000A6E44 File Offset: 0x000A5044
		private void EntityPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::System.Data.Entity.Core.Objects.IObjectView objectView = (global::System.Data.Entity.Core.Objects.IObjectView)this._viewWeak.Target;
			if (objectView != null)
			{
				objectView.EntityPropertyChanged(sender, e);
				return;
			}
			this.CleanUpListener();
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x000A6E74 File Offset: 0x000A5074
		private void CollectionChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e)
		{
			global::System.Data.Entity.Core.Objects.IObjectView objectView = (global::System.Data.Entity.Core.Objects.IObjectView)this._viewWeak.Target;
			if (objectView != null)
			{
				objectView.CollectionChanged(sender, e);
				return;
			}
			this.CleanUpListener();
		}

		// Token: 0x040010C8 RID: 4296
		private readonly global::System.WeakReference _viewWeak;

		// Token: 0x040010C9 RID: 4297
		private readonly object _dataSource;

		// Token: 0x040010CA RID: 4298
		private readonly global::System.Collections.IList _list;
	}
}
