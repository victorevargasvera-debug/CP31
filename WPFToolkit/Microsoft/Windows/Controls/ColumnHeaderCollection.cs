using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000085 RID: 133
	internal class ColumnHeaderCollection : global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.IDisposable
	{
		// Token: 0x06000983 RID: 2435 RVA: 0x0002A1B6 File Offset: 0x000283B6
		public ColumnHeaderCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn> columns)
		{
			this._columns = columns;
			if (this._columns != null)
			{
				this._columns.CollectionChanged += this.OnColumnsChanged;
			}
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x0002A1E4 File Offset: 0x000283E4
		public global::Microsoft.Windows.Controls.DataGridColumn ColumnFromIndex(int index)
		{
			if (index >= 0 && index < this._columns.Count)
			{
				return this._columns[index];
			}
			return null;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0002A208 File Offset: 0x00028408
		internal void NotifyHeaderPropertyChanged(global::Microsoft.Windows.Controls.DataGridColumn column, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace, e.NewValue, e.OldValue, this._columns.IndexOf(column));
			this.FireCollectionChanged(args);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0002A23D File Offset: 0x0002843D
		public void Dispose()
		{
			global::System.GC.SuppressFinalize(this);
			if (this._columns != null)
			{
				this._columns.CollectionChanged -= this.OnColumnsChanged;
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0002A264 File Offset: 0x00028464
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::Microsoft.Windows.Controls.ColumnHeaderCollection.ColumnHeaderCollectionEnumerator(this._columns);
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06000988 RID: 2440 RVA: 0x0002A271 File Offset: 0x00028471
		// (remove) Token: 0x06000989 RID: 2441 RVA: 0x0002A28A File Offset: 0x0002848A
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x0600098A RID: 2442 RVA: 0x0002A2A4 File Offset: 0x000284A4
		private void OnColumnsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args;
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				args = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, global::Microsoft.Windows.Controls.ColumnHeaderCollection.HeadersFromColumns(e.NewItems), e.NewStartingIndex);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				args = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, global::Microsoft.Windows.Controls.ColumnHeaderCollection.HeadersFromColumns(e.OldItems), e.OldStartingIndex);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				args = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, global::Microsoft.Windows.Controls.ColumnHeaderCollection.HeadersFromColumns(e.NewItems), global::Microsoft.Windows.Controls.ColumnHeaderCollection.HeadersFromColumns(e.OldItems), e.OldStartingIndex);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				args = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, global::Microsoft.Windows.Controls.ColumnHeaderCollection.HeadersFromColumns(e.OldItems), e.NewStartingIndex, e.OldStartingIndex);
				break;
			default:
				args = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
				break;
			}
			this.FireCollectionChanged(args);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0002A36E File Offset: 0x0002856E
		private void FireCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, args);
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0002A388 File Offset: 0x00028588
		private static object[] HeadersFromColumns(global::System.Collections.IList columns)
		{
			object[] array = new object[columns.Count];
			for (int i = 0; i < columns.Count; i++)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = columns[i] as global::Microsoft.Windows.Controls.DataGridColumn;
				if (dataGridColumn != null)
				{
					array[i] = dataGridColumn.Header;
				}
				else
				{
					array[i] = null;
				}
			}
			return array;
		}

		// Token: 0x040002E5 RID: 741
		private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn> _columns;

		// Token: 0x02000086 RID: 134
		private class ColumnHeaderCollectionEnumerator : global::System.Collections.IEnumerator, global::System.IDisposable
		{
			// Token: 0x0600098D RID: 2445 RVA: 0x0002A3D2 File Offset: 0x000285D2
			public ColumnHeaderCollectionEnumerator(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn> columns)
			{
				if (columns != null)
				{
					this._columns = columns;
					this._columns.CollectionChanged += this.OnColumnsChanged;
				}
				this._current = -1;
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x0600098E RID: 2446 RVA: 0x0002A404 File Offset: 0x00028604
			public object Current
			{
				get
				{
					if (!this.IsValid)
					{
						throw new global::System.InvalidOperationException();
					}
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this._columns[this._current];
					if (dataGridColumn != null)
					{
						return dataGridColumn.Header;
					}
					return null;
				}
			}

			// Token: 0x0600098F RID: 2447 RVA: 0x0002A43C File Offset: 0x0002863C
			public bool MoveNext()
			{
				if (this.HasChanged)
				{
					throw new global::System.InvalidOperationException();
				}
				if (this._columns != null && this._current < this._columns.Count - 1)
				{
					this._current++;
					return true;
				}
				return false;
			}

			// Token: 0x06000990 RID: 2448 RVA: 0x0002A47A File Offset: 0x0002867A
			public void Reset()
			{
				if (this.HasChanged)
				{
					throw new global::System.InvalidOperationException();
				}
				this._current = -1;
			}

			// Token: 0x06000991 RID: 2449 RVA: 0x0002A491 File Offset: 0x00028691
			public void Dispose()
			{
				global::System.GC.SuppressFinalize(this);
				if (this._columns != null)
				{
					this._columns.CollectionChanged -= this.OnColumnsChanged;
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x06000992 RID: 2450 RVA: 0x0002A4B8 File Offset: 0x000286B8
			private bool HasChanged
			{
				get
				{
					return this._columnsChanged;
				}
			}

			// Token: 0x1700023D RID: 573
			// (get) Token: 0x06000993 RID: 2451 RVA: 0x0002A4C0 File Offset: 0x000286C0
			private bool IsValid
			{
				get
				{
					return this._columns != null && this._current >= 0 && this._current < this._columns.Count && !this.HasChanged;
				}
			}

			// Token: 0x06000994 RID: 2452 RVA: 0x0002A4F1 File Offset: 0x000286F1
			private void OnColumnsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				this._columnsChanged = true;
			}

			// Token: 0x040002E6 RID: 742
			private int _current;

			// Token: 0x040002E7 RID: 743
			private bool _columnsChanged;

			// Token: 0x040002E8 RID: 744
			private global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn> _columns;
		}
	}
}
