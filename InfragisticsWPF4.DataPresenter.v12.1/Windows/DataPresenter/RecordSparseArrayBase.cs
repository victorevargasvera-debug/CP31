using System;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000307 RID: 775
	internal abstract class RecordSparseArrayBase : global::Infragistics.Collections.SparseArray, global::Infragistics.Collections.ICreateItemCallback
	{
		// Token: 0x060024C1 RID: 9409 RVA: 0x0009F8AE File Offset: 0x0009DAAE
		protected RecordSparseArrayBase(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ownerCollection, bool manageScrollCounts, int factor, float growthFactor) : base(manageScrollCounts, factor, growthFactor)
		{
			if (ownerCollection == null)
			{
				throw new global::System.ArgumentNullException("ownerCollection");
			}
			this._ownerCollection = ownerCollection;
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0009F8CF File Offset: 0x0009DACF
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._ownerCollection.DataPresenter;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0009F8DC File Offset: 0x0009DADC
		internal global::Infragistics.Windows.DataPresenter.RecordCollectionBase OwnerCollection
		{
			get
			{
				return this._ownerCollection;
			}
		}

		// Token: 0x060024C4 RID: 9412
		internal abstract void EnsureAllItemsCreated();

		// Token: 0x060024C5 RID: 9413
		internal abstract global::Infragistics.Windows.DataPresenter.Record GetItem(int index, bool create);

		// Token: 0x060024C6 RID: 9414 RVA: 0x0009F8E4 File Offset: 0x0009DAE4
		internal new void NotifyItemScrollCountChanged(global::Infragistics.Collections.ISparseArrayMultiItem item)
		{
			base.NotifyItemScrollCountChanged(item);
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0009F8ED File Offset: 0x0009DAED
		internal global::Infragistics.Windows.DataPresenter.Record[] ToArray(bool create)
		{
			return this.ToArray(create, typeof(global::Infragistics.Windows.DataPresenter.Record));
		}

		// Token: 0x060024C8 RID: 9416
		internal abstract global::Infragistics.Windows.DataPresenter.Record[] ToArray(bool create, global::System.Type arrayElementType);

		// Token: 0x060024C9 RID: 9417
		public abstract object CreateItem(global::Infragistics.Collections.SparseArray array, int relativeIndex);

		// Token: 0x040011BD RID: 4541
		internal const int DefaultFactor = 40;

		// Token: 0x040011BE RID: 4542
		internal const float DefaultGrowthFactor = 0.2f;

		// Token: 0x040011BF RID: 4543
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _ownerCollection;
	}
}
