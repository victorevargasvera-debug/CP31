using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200007D RID: 125
	internal class ObservableSplitElementCollection<T> : global::Infragistics.Collections.ObservableCollectionExtended<T> where T : global::System.Windows.FrameworkElement
	{
		// Token: 0x0600044E RID: 1102 RVA: 0x00018221 File Offset: 0x00016421
		internal ObservableSplitElementCollection(global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner owner, global::Infragistics.Windows.DockManager.PaneSplitterMode splitterMode)
		{
			this._owner = owner;
			this._splitterMode = splitterMode;
			this._elements = new global::System.Collections.Generic.List<T>();
			this._splitters = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.PaneSplitter>();
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0001824D File Offset: 0x0001644D
		public global::Infragistics.Windows.DockManager.PaneSplitterMode SplitterMode
		{
			get
			{
				return this._splitterMode;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00018255 File Offset: 0x00016455
		public int VisualChildrenCount
		{
			get
			{
				return this._elements.Count + this._splitters.Count;
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001826E File Offset: 0x0001646E
		internal global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DockManager.PaneSplitter> GetSplitterEnumerator()
		{
			return this._splitters.GetEnumerator();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0001827B File Offset: 0x0001647B
		public global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index < this._elements.Count)
			{
				return this._elements[index];
			}
			index -= this._elements.Count;
			return this._splitters[index];
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000182B8 File Offset: 0x000164B8
		internal void RefreshSplitterVisibility()
		{
			if (this._splitterMode == global::Infragistics.Windows.DockManager.PaneSplitterMode.BetweenPanes)
			{
				T t = default(T);
				for (int i = base.Count - 1; i >= 0; i--)
				{
					T t2 = base[i];
					global::Infragistics.Windows.DockManager.PaneSplitter splitter = global::Infragistics.Windows.DockManager.PaneSplitter.GetSplitter(t2);
					if (t2.Visibility == global::System.Windows.Visibility.Collapsed)
					{
						if (splitter != null)
						{
							splitter.Visibility = global::System.Windows.Visibility.Collapsed;
						}
					}
					else if (t == null)
					{
						t = t2;
						if (splitter != null)
						{
							splitter.Visibility = global::System.Windows.Visibility.Collapsed;
						}
					}
					else if (splitter != null)
					{
						splitter.Visibility = global::System.Windows.Visibility.Visible;
					}
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00018339 File Offset: 0x00016539
		protected override bool NotifyItemsChanged
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001833C File Offset: 0x0001653C
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.Collections.Generic.Dictionary<T, global::Infragistics.Windows.DockManager.PaneSplitter> dictionary = new global::System.Collections.Generic.Dictionary<T, global::Infragistics.Windows.DockManager.PaneSplitter>();
			int i = 0;
			int count = this._elements.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DockManager.PaneSplitter splitter = global::Infragistics.Windows.DockManager.PaneSplitter.GetSplitter(this._elements[i]);
				dictionary.Add(this._elements[i], splitter);
				i++;
			}
			bool flag = this._splitterMode == global::Infragistics.Windows.DockManager.PaneSplitterMode.SinglePane;
			int j = 0;
			int num = base.Count - 1;
			while (j <= num)
			{
				T t = base[j];
				global::Infragistics.Windows.DockManager.PaneSplitter paneSplitter;
				if (dictionary.TryGetValue(t, out paneSplitter))
				{
					dictionary.Remove(t);
					if (this._elements[j] != t)
					{
						this._elements.Remove(t);
						this._elements.Insert(j, t);
					}
				}
				else
				{
					this._elements.Insert(j, t);
					this._owner.OnElementAdded(t);
				}
				if (flag || j < num)
				{
					if (paneSplitter == null)
					{
						paneSplitter = this._owner.CreateSplitter();
						paneSplitter.ElementBeforeSplitter = t;
						t.SetValue(global::Infragistics.Windows.DockManager.PaneSplitter.SplitterPropertyKey, paneSplitter);
						this._splitters.Insert(j, paneSplitter);
						this._owner.OnSplitterAdded(paneSplitter);
					}
					else if (this._splitters[j] != paneSplitter)
					{
						this._splitters.Remove(paneSplitter);
						this._splitters.Insert(j, paneSplitter);
					}
				}
				else if (paneSplitter != null)
				{
					this._splitters.Remove(paneSplitter);
					this._owner.OnSplitterRemoved(paneSplitter);
					t.ClearValue(global::Infragistics.Windows.DockManager.PaneSplitter.SplitterPropertyKey);
					paneSplitter.ElementBeforeSplitter = null;
				}
				j++;
			}
			if (dictionary.Count > 0)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<T, global::Infragistics.Windows.DockManager.PaneSplitter> keyValuePair in dictionary)
				{
					this._elements.Remove(keyValuePair.Key);
					this._owner.OnElementRemoved(keyValuePair.Key);
					T key = keyValuePair.Key;
					key.ClearValue(global::Infragistics.Windows.DockManager.PaneSplitter.SplitterPropertyKey);
					global::Infragistics.Windows.DockManager.PaneSplitter value = keyValuePair.Value;
					if (value != null)
					{
						this._splitters.Remove(value);
						this._owner.OnSplitterRemoved(value);
						value.ElementBeforeSplitter = null;
					}
				}
			}
			this.RefreshSplitterVisibility();
			base.OnCollectionChanged(e);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000185CC File Offset: 0x000167CC
		protected override void OnItemAdding(T itemAdded)
		{
			this._owner.OnElementAdding(itemAdded);
			base.OnItemAdding(itemAdded);
		}

		// Token: 0x040002DD RID: 733
		private global::Infragistics.Windows.DockManager.PaneSplitterMode _splitterMode;

		// Token: 0x040002DE RID: 734
		private global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner _owner;

		// Token: 0x040002DF RID: 735
		private global::System.Collections.Generic.IList<T> _elements;

		// Token: 0x040002E0 RID: 736
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.PaneSplitter> _splitters;
	}
}
