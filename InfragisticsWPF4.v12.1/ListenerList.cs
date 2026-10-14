using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x02000053 RID: 83
	internal class ListenerList : global::System.Collections.Generic.List<object>
	{
		// Token: 0x0600035B RID: 859 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		private ListenerList(int capacity) : base(capacity)
		{
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		private static object CreateWeakRefHelper(object obj)
		{
			global::System.WeakReference weakReference = obj as global::System.WeakReference;
			if (weakReference == null)
			{
				weakReference = new global::System.WeakReference(obj);
			}
			return weakReference;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000F4D0 File Offset: 0x0000D6D0
		internal static object GetItemHelper(object obj)
		{
			global::System.WeakReference weakReference = obj as global::System.WeakReference;
			if (weakReference != null)
			{
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference);
			}
			return obj;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		public static object Add(object currentListener, object listener, bool useWeakReference)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(listener);
			object obj = useWeakReference ? global::Infragistics.ListenerList.CreateWeakRefHelper(listener) : listener;
			if (currentListener == null)
			{
				return obj;
			}
			global::Infragistics.ListenerList listenerList = currentListener as global::Infragistics.ListenerList;
			if (listenerList != null)
			{
				listenerList.Add(obj);
			}
			else
			{
				listenerList = new global::Infragistics.ListenerList(2);
				listenerList.Add(currentListener);
				listenerList.Add(obj);
			}
			return listenerList;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000F540 File Offset: 0x0000D740
		public static object Remove(object currentListener, object listener)
		{
			global::Infragistics.ListenerList listenerList = currentListener as global::Infragistics.ListenerList;
			if (listenerList != null)
			{
				for (int i = listenerList.Count - 1; i >= 0; i--)
				{
					if (listener == global::Infragistics.ListenerList.GetItemHelper(listenerList[i]))
					{
						if (listenerList._isTraversingList != 0)
						{
							global::Infragistics.ListenerList listenerList2 = new global::Infragistics.ListenerList(listenerList.Count);
							listenerList2.AddRange(listenerList);
							listenerList = listenerList2;
						}
						listenerList.RemoveAt(i);
						break;
					}
				}
				if (1 != listenerList.Count)
				{
					return listenerList;
				}
				return listenerList[0];
			}
			else
			{
				if (global::Infragistics.ListenerList.GetItemHelper(currentListener) == listener)
				{
					return null;
				}
				return currentListener;
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000F5C0 File Offset: 0x0000D7C0
		public static global::System.Collections.Generic.IEnumerable<object> GetListeners(object currentListener)
		{
			global::Infragistics.ListenerList listenerList = currentListener as global::Infragistics.ListenerList;
			if (listenerList != null)
			{
				return new global::Infragistics.ListenerList.Enumerable(listenerList);
			}
			if (currentListener != null)
			{
				return new object[]
				{
					currentListener
				};
			}
			return new object[0];
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		public static void GetListeners(object currentListener, out global::System.Collections.Generic.IEnumerable<object> multiListeners, out object singleListener)
		{
			singleListener = null;
			multiListeners = null;
			global::Infragistics.ListenerList listenerList = currentListener as global::Infragistics.ListenerList;
			if (listenerList != null)
			{
				multiListeners = new global::Infragistics.ListenerList.Enumerable(listenerList);
				return;
			}
			object itemHelper = global::Infragistics.ListenerList.GetItemHelper(currentListener);
			if (itemHelper != null)
			{
				singleListener = itemHelper;
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000F628 File Offset: 0x0000D828
		internal static void RaisePropertyChanged<TItem, TProperty>(object listeners, TItem sender, TProperty property, object extraInfo)
		{
			global::Infragistics.ListenerList listenerList = listeners as global::Infragistics.ListenerList;
			if (listenerList != null)
			{
				listenerList._isTraversingList++;
				try
				{
					int i = 0;
					int count = listenerList.Count;
					while (i < count)
					{
						global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty> typedPropertyChangeListener = (global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty>)global::Infragistics.ListenerList.GetItemHelper(listenerList[i]);
						if (typedPropertyChangeListener != null)
						{
							typedPropertyChangeListener.OnPropertyValueChanged(sender, property, extraInfo);
						}
						i++;
					}
					return;
				}
				finally
				{
					listenerList._isTraversingList--;
				}
			}
			if (listeners != null)
			{
				global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty> typedPropertyChangeListener2 = (global::Infragistics.ITypedPropertyChangeListener<TItem, TProperty>)global::Infragistics.ListenerList.GetItemHelper(listeners);
				if (typedPropertyChangeListener2 != null)
				{
					typedPropertyChangeListener2.OnPropertyValueChanged(sender, property, extraInfo);
				}
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		internal static void RaiseValueChanged<TItem>(object listeners, TItem item)
		{
			global::Infragistics.ListenerList listenerList = listeners as global::Infragistics.ListenerList;
			if (listenerList != null)
			{
				listenerList._isTraversingList++;
				try
				{
					int i = 0;
					int count = listenerList.Count;
					while (i < count)
					{
						global::Infragistics.IValueChangeListener<TItem> valueChangeListener = (global::Infragistics.IValueChangeListener<TItem>)global::Infragistics.ListenerList.GetItemHelper(listenerList[i]);
						if (valueChangeListener != null)
						{
							valueChangeListener.OnValueChanged(item);
						}
						i++;
					}
					return;
				}
				finally
				{
					listenerList._isTraversingList--;
				}
			}
			if (listeners != null)
			{
				global::Infragistics.IValueChangeListener<TItem> valueChangeListener2 = (global::Infragistics.IValueChangeListener<TItem>)global::Infragistics.ListenerList.GetItemHelper(listeners);
				if (valueChangeListener2 != null)
				{
					valueChangeListener2.OnValueChanged(item);
				}
			}
		}

		// Token: 0x04000119 RID: 281
		private int _isTraversingList;

		// Token: 0x02000054 RID: 84
		private class Enumerable : global::System.Collections.Generic.IEnumerable<object>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000364 RID: 868 RVA: 0x0000F754 File Offset: 0x0000D954
			internal Enumerable(global::System.Collections.IList l)
			{
				this._l = l;
			}

			// Token: 0x06000365 RID: 869 RVA: 0x0000F763 File Offset: 0x0000D963
			public global::System.Collections.Generic.IEnumerator<object> GetEnumerator()
			{
				return new global::Infragistics.ListenerList.Enumerable.Enumerator(this._l);
			}

			// Token: 0x06000366 RID: 870 RVA: 0x0000F770 File Offset: 0x0000D970
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400011A RID: 282
			private global::System.Collections.IList _l;

			// Token: 0x02000055 RID: 85
			private class Enumerator : global::System.Collections.Generic.IEnumerator<object>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000367 RID: 871 RVA: 0x0000F778 File Offset: 0x0000D978
				internal Enumerator(global::System.Collections.IList l)
				{
					this._l = l;
					this.Reset();
				}

				// Token: 0x17000083 RID: 131
				// (get) Token: 0x06000368 RID: 872 RVA: 0x0000F78D File Offset: 0x0000D98D
				public object Current
				{
					get
					{
						return this._current;
					}
				}

				// Token: 0x06000369 RID: 873 RVA: 0x0000F795 File Offset: 0x0000D995
				public void Dispose()
				{
				}

				// Token: 0x17000084 RID: 132
				// (get) Token: 0x0600036A RID: 874 RVA: 0x0000F797 File Offset: 0x0000D997
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x0600036B RID: 875 RVA: 0x0000F7A0 File Offset: 0x0000D9A0
				public bool MoveNext()
				{
					this._current = null;
					while (this._current == null && ++this._index < this._l.Count)
					{
						this._current = global::Infragistics.ListenerList.GetItemHelper(this._l[this._index]);
					}
					return null != this._current;
				}

				// Token: 0x0600036C RID: 876 RVA: 0x0000F804 File Offset: 0x0000DA04
				public void Reset()
				{
					this._index = -1;
					this._current = null;
				}

				// Token: 0x0400011B RID: 283
				private global::System.Collections.IList _l;

				// Token: 0x0400011C RID: 284
				private int _index;

				// Token: 0x0400011D RID: 285
				private object _current;
			}
		}
	}
}
