using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics
{
	// Token: 0x02000067 RID: 103
	internal class ListenerList : global::System.Collections.Generic.List<object>
	{
		// Token: 0x060003EF RID: 1007 RVA: 0x00011100 File Offset: 0x0000F300
		private ListenerList(int capacity) : base(capacity)
		{
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0001110C File Offset: 0x0000F30C
		private static object CreateWeakRefHelper(object obj)
		{
			global::System.WeakReference weakReference = obj as global::System.WeakReference;
			if (weakReference == null)
			{
				weakReference = new global::System.WeakReference(obj);
			}
			return weakReference;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001112C File Offset: 0x0000F32C
		internal static object GetItemHelper(object obj)
		{
			global::System.WeakReference weakReference = obj as global::System.WeakReference;
			if (weakReference != null)
			{
				return global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(weakReference);
			}
			return obj;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001114C File Offset: 0x0000F34C
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

		// Token: 0x060003F3 RID: 1011 RVA: 0x0001119C File Offset: 0x0000F39C
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

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001121C File Offset: 0x0000F41C
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

		// Token: 0x060003F5 RID: 1013 RVA: 0x00011250 File Offset: 0x0000F450
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

		// Token: 0x060003F6 RID: 1014 RVA: 0x00011284 File Offset: 0x0000F484
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

		// Token: 0x060003F7 RID: 1015 RVA: 0x0001131C File Offset: 0x0000F51C
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

		// Token: 0x04000174 RID: 372
		private int _isTraversingList;

		// Token: 0x02000068 RID: 104
		private class Enumerable : global::System.Collections.Generic.IEnumerable<object>, global::System.Collections.IEnumerable
		{
			// Token: 0x060003F8 RID: 1016 RVA: 0x000113B0 File Offset: 0x0000F5B0
			internal Enumerable(global::System.Collections.IList l)
			{
				this._l = l;
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x000113BF File Offset: 0x0000F5BF
			public global::System.Collections.Generic.IEnumerator<object> GetEnumerator()
			{
				return new global::Infragistics.ListenerList.Enumerable.Enumerator(this._l);
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x000113CC File Offset: 0x0000F5CC
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000175 RID: 373
			private global::System.Collections.IList _l;

			// Token: 0x02000069 RID: 105
			private class Enumerator : global::System.Collections.Generic.IEnumerator<object>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x060003FB RID: 1019 RVA: 0x000113D4 File Offset: 0x0000F5D4
				internal Enumerator(global::System.Collections.IList l)
				{
					this._l = l;
					this.Reset();
				}

				// Token: 0x17000092 RID: 146
				// (get) Token: 0x060003FC RID: 1020 RVA: 0x000113E9 File Offset: 0x0000F5E9
				public object Current
				{
					get
					{
						return this._current;
					}
				}

				// Token: 0x060003FD RID: 1021 RVA: 0x000113F1 File Offset: 0x0000F5F1
				public void Dispose()
				{
				}

				// Token: 0x17000093 RID: 147
				// (get) Token: 0x060003FE RID: 1022 RVA: 0x000113F3 File Offset: 0x0000F5F3
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x060003FF RID: 1023 RVA: 0x000113FC File Offset: 0x0000F5FC
				public bool MoveNext()
				{
					this._current = null;
					while (this._current == null && ++this._index < this._l.Count)
					{
						this._current = global::Infragistics.ListenerList.GetItemHelper(this._l[this._index]);
					}
					return null != this._current;
				}

				// Token: 0x06000400 RID: 1024 RVA: 0x00011460 File Offset: 0x0000F660
				public void Reset()
				{
					this._index = -1;
					this._current = null;
				}

				// Token: 0x04000176 RID: 374
				private global::System.Collections.IList _l;

				// Token: 0x04000177 RID: 375
				private int _index;

				// Token: 0x04000178 RID: 376
				private object _current;
			}
		}
	}
}
