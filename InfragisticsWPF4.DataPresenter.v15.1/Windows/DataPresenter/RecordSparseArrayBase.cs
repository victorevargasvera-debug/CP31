using System;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000348 RID: 840
	internal abstract class RecordSparseArrayBase : global::Infragistics.Collections.SparseArray, global::Infragistics.Collections.ICreateItemCallback
	{
		// Token: 0x06002872 RID: 10354 RVA: 0x000B367A File Offset: 0x000B187A
		protected RecordSparseArrayBase(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection, bool manageScrollCounts, int factor, float growthFactor) : base(manageScrollCounts, factor, growthFactor)
		{
			if (ownerCollection == null)
			{
				throw new global::System.ArgumentNullException("ownerCollection");
			}
			this._ownerCollection = ownerCollection;
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002873 RID: 10355 RVA: 0x000B369B File Offset: 0x000B189B
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._ownerCollection.DataPresenter;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x000B36A8 File Offset: 0x000B18A8
		internal global::Infragistics.Windows.DataPresenter.RecordCollectionBase OwnerCollection
		{
			get
			{
				return this._ownerCollection;
			}
		}

		// Token: 0x06002875 RID: 10357
		internal abstract void EnsureAllItemsCreated();

		// Token: 0x06002876 RID: 10358
		internal abstract global::Infragistics.Windows.DataPresenter.Record GetItem(int index, bool create);

		// Token: 0x06002877 RID: 10359 RVA: 0x000B36B0 File Offset: 0x000B18B0
		internal new void NotifyItemScrollCountChanged(global::Infragistics.Collections.ISparseArrayMultiItem item)
		{
			base.NotifyItemScrollCountChanged(item);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x000B36B9 File Offset: 0x000B18B9
		internal global::Infragistics.Windows.DataPresenter.Record[] ToArray(bool create)
		{
			return this.ToArray(create, typeof(global::Infragistics.Windows.DataPresenter.Record));
		}

		// Token: 0x06002879 RID: 10361
		internal abstract global::Infragistics.Windows.DataPresenter.Record[] ToArray(bool create, global::System.Type arrayElementType);

		// Token: 0x0600287A RID: 10362
		public abstract object CreateItem(global::Infragistics.Collections.SparseArray array, int relativeIndex);

		// Token: 0x040013DD RID: 5085
		internal const int DefaultFactor = 40;

		// Token: 0x040013DE RID: 5086
		internal const float DefaultGrowthFactor = 0.2f;

		// Token: 0x040013DF RID: 5087
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _ownerCollection;
	}
}
