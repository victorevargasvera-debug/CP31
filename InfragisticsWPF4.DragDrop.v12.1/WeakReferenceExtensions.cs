using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Infragistics.DragDrop
{
	// Token: 0x02000010 RID: 16
	internal static class WeakReferenceExtensions
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00005DC0 File Offset: 0x00003FC0
		public static void Add(this global::System.Collections.Generic.IList<global::System.WeakReference> list, global::System.Windows.DependencyObject item)
		{
			list.Add(new global::System.WeakReference(item));
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005DD0 File Offset: 0x00003FD0
		public static bool Contains(this global::System.Collections.Generic.IList<global::System.WeakReference> list, global::System.Windows.DependencyObject item)
		{
			for (int i = list.Count - 1; i > -1; i--)
			{
				if (list[i].Target == null)
				{
					list.RemoveAt(i);
				}
				else if (list[i].Target == item)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00005E1C File Offset: 0x0000401C
		public static void Remove(this global::System.Collections.Generic.IList<global::System.WeakReference> list, global::System.Windows.DependencyObject item)
		{
			for (int i = list.Count - 1; i > -1; i--)
			{
				if (list[i].Target == null || list[i].Target == item)
				{
					list.RemoveAt(i);
				}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005E60 File Offset: 0x00004060
		public static global::System.Collections.Generic.IList<T> GetTargets<T>(this global::System.Collections.Generic.IList<global::System.WeakReference> list)
		{
			global::System.Collections.Generic.IList<T> list2 = new global::System.Collections.Generic.List<T>();
			for (int i = list.Count - 1; i > -1; i--)
			{
				object target = list[i].Target;
				if (target == null)
				{
					list.RemoveAt(i);
				}
				else
				{
					list2.Add((T)((object)target));
				}
			}
			return list2;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005EAC File Offset: 0x000040AC
		public static void Add(this global::System.Collections.Generic.Dictionary<global::System.WeakReference, global::System.Collections.Generic.IList<global::System.WeakReference>> list, global::System.Windows.DependencyObject key, global::System.Collections.Generic.IList<global::System.Windows.DependencyObject> value)
		{
			global::System.Collections.Generic.List<global::System.WeakReference> list2 = new global::System.Collections.Generic.List<global::System.WeakReference>();
			foreach (global::System.Windows.DependencyObject target in value)
			{
				list2.Add(new global::System.WeakReference(target));
			}
			list.Add(new global::System.WeakReference(key), list2);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005F0C File Offset: 0x0000410C
		public static void Remove(this global::System.Collections.Generic.Dictionary<global::System.WeakReference, global::System.Collections.Generic.IList<global::System.WeakReference>> list, global::System.Windows.DependencyObject key)
		{
			global::System.Collections.Generic.IList<global::System.WeakReference> list2 = list.Keys.ToList<global::System.WeakReference>();
			for (int i = list2.Count - 1; i > -1; i--)
			{
				if (list2[i].Target == null || list2[i].Target == key)
				{
					list.Remove(list2[i]);
				}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005F64 File Offset: 0x00004164
		public static bool ContainsKey(this global::System.Collections.Generic.Dictionary<global::System.WeakReference, global::System.Collections.Generic.IList<global::System.WeakReference>> list, global::System.Windows.DependencyObject key)
		{
			global::System.Collections.Generic.IList<global::System.WeakReference> list2 = list.Keys.ToList<global::System.WeakReference>();
			for (int i = list2.Count - 1; i > -1; i--)
			{
				if (list2[i].Target == null)
				{
					list.Remove(list2[i]);
				}
				else if (list2[i].Target == key)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005FC0 File Offset: 0x000041C0
		public static bool TryGetValue(this global::System.Collections.Generic.Dictionary<global::System.WeakReference, global::System.Collections.Generic.IList<global::System.WeakReference>> list, global::System.Windows.DependencyObject key, out global::System.Collections.Generic.IList<global::System.WeakReference> items)
		{
			items = null;
			global::System.Collections.Generic.IList<global::System.WeakReference> list2 = list.Keys.ToList<global::System.WeakReference>();
			for (int i = list2.Count - 1; i > -1; i--)
			{
				if (list2[i].Target == null)
				{
					list.Remove(list2[i]);
				}
				else if (list2[i].Target == key)
				{
					items = list[list2[i]];
					if (items != null)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
