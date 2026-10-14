using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000281 RID: 641
	public class RowBaseCollection : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06001546 RID: 5446 RVA: 0x0004DD34 File Offset: 0x0004BF34
		public RowBaseCollection(global::Infragistics.ICollectionBase actualCollection)
		{
			this._actualCollection = actualCollection;
			this._actualCollection.CollectionChanged += this.ActualCollection_CollectionChanged;
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x0004DD5A File Offset: 0x0004BF5A
		public global::Infragistics.ICollectionBase ActualCollection
		{
			get
			{
				return this._actualCollection;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0004DD62 File Offset: 0x0004BF62
		public int Count
		{
			get
			{
				return this._actualCollection.Count;
			}
		}

		// Token: 0x170006B7 RID: 1719
		public global::Infragistics.Controls.Grids.RowBase this[int index]
		{
			get
			{
				return this._actualCollection[index] as global::Infragistics.Controls.Grids.RowBase;
			}
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x0004DD82 File Offset: 0x0004BF82
		public int IndexOf(global::Infragistics.Controls.Grids.RowBase item)
		{
			return this._actualCollection.IndexOf(item);
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x0004DD90 File Offset: 0x0004BF90
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public virtual void Clear()
		{
			this._actualCollection.Clear();
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x0004DD9D File Offset: 0x0004BF9D
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._actualCollection.GetEnumerator();
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600154D RID: 5453 RVA: 0x0004DDAC File Offset: 0x0004BFAC
		// (remove) Token: 0x0600154E RID: 5454 RVA: 0x0004DDE4 File Offset: 0x0004BFE4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600154F RID: 5455 RVA: 0x0004DE19 File Offset: 0x0004C019
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x0004DE35 File Offset: 0x0004C035
		private void ActualCollection_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.OnPropertyChanged("Count");
		}

		// Token: 0x04000666 RID: 1638
		private global::Infragistics.ICollectionBase _actualCollection;
	}
}
