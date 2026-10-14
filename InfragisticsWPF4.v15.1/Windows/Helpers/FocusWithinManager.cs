using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Infragistics.Collections;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000191 RID: 401
	public class FocusWithinManager : global::System.Windows.DependencyObject
	{
		// Token: 0x06000D64 RID: 3428 RVA: 0x0002C042 File Offset: 0x0002A242
		private FocusWithinManager()
		{
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x0002C04C File Offset: 0x0002A24C
		public static bool CheckFocusWithinHelper(global::System.Windows.DependencyObject elem)
		{
			if (elem == null)
			{
				return false;
			}
			global::System.Windows.DependencyObject dependencyObject;
			global::System.Windows.DependencyObject dependencyObject2;
			global::Infragistics.Windows.Helpers.FocusWithinManager.GetFocusedElem(elem, out dependencyObject, out dependencyObject2);
			return dependencyObject != null && global::Infragistics.Windows.Helpers.FocusWithinManager.IsAncestorOf(elem, dependencyObject);
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x0002C074 File Offset: 0x0002A274
		public static bool IsAncestorOf(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject elem)
		{
			return global::Infragistics.Windows.Helpers.FocusWithinManager.IsAncestorOfHelper(ancestor, elem);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x0002C07D File Offset: 0x0002A27D
		public static void RegisterType(global::System.Type classType)
		{
			global::Infragistics.Windows.Helpers.FocusWithinManager.RegisterType(classType, null);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x0002C088 File Offset: 0x0002A288
		public static void RegisterType(global::System.Type classType, global::System.Windows.PropertyChangedCallback callback)
		{
			global::System.Windows.EventManager.RegisterClassHandler(classType, global::System.Windows.UIElement.GotFocusEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Helpers.FocusWithinManager.OnGotFocusClassHandler), true);
			global::System.Windows.EventManager.RegisterClassHandler(classType, global::System.Windows.UIElement.LostFocusEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Helpers.FocusWithinManager.OnLostFocusClassHandler), true);
			if (callback != null)
			{
				global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinPropertyKey.OverrideMetadata(classType, new global::System.Windows.FrameworkPropertyMetadata(callback));
			}
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x0002C0D9 File Offset: 0x0002A2D9
		private static void GetFocusedElem(global::System.Windows.DependencyObject elem, out global::System.Windows.DependencyObject focusedElem, out global::System.Windows.DependencyObject focusScope)
		{
			focusScope = ((elem != null) ? global::System.Windows.Input.FocusManager.GetFocusScope(elem) : null);
			focusedElem = ((focusScope != null) ? (focusScope.GetValue(global::System.Windows.Input.FocusManager.FocusedElementProperty) as global::System.Windows.DependencyObject) : null);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x0002C104 File Offset: 0x0002A304
		private static void HookOrUnhookLostFocus(global::System.Windows.DependencyObject obj, bool hook)
		{
			if (obj == null)
			{
				return;
			}
			if (hook)
			{
				if (!global::Infragistics.Windows.Helpers.FocusWithinManager.HookedInElems.ContainsKey(obj))
				{
					bool flag = true;
					if (obj is global::System.Windows.UIElement)
					{
						((global::System.Windows.UIElement)obj).LostFocus += global::Infragistics.Windows.Helpers.FocusWithinManager.OnLostFocusHandler;
					}
					else if (obj is global::System.Windows.ContentElement)
					{
						((global::System.Windows.ContentElement)obj).LostFocus += global::Infragistics.Windows.Helpers.FocusWithinManager.OnLostFocusHandler;
					}
					else
					{
						flag = false;
					}
					if (flag)
					{
						global::Infragistics.Windows.Helpers.FocusWithinManager.HookedInElems.Add(obj, null);
						return;
					}
				}
			}
			else
			{
				if (obj is global::System.Windows.UIElement)
				{
					((global::System.Windows.UIElement)obj).LostFocus -= global::Infragistics.Windows.Helpers.FocusWithinManager.OnLostFocusHandler;
				}
				else if (obj is global::System.Windows.ContentElement)
				{
					((global::System.Windows.ContentElement)obj).LostFocus -= global::Infragistics.Windows.Helpers.FocusWithinManager.OnLostFocusHandler;
				}
				global::Infragistics.Windows.Helpers.FocusWithinManager.HookedInElems.Remove(obj);
			}
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x0002C1CC File Offset: 0x0002A3CC
		private static bool IsAncestorOfHelper(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject elem)
		{
			if (ancestor == elem)
			{
				return true;
			}
			global::System.Windows.DependencyObject dependencyObject = null;
			if (elem is global::System.Windows.Media.Visual || elem is global::System.Windows.Media.Media3D.Visual3D)
			{
				dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(elem);
			}
			if (dependencyObject == null)
			{
				dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(elem);
			}
			return dependencyObject != null && global::Infragistics.Windows.Helpers.FocusWithinManager.IsAncestorOfHelper(ancestor, dependencyObject);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x0002C20E File Offset: 0x0002A40E
		private static void OnGotFocusClassHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Helpers.FocusWithinManager.OnGotLostFocusHelper(true, sender, e);
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x0002C218 File Offset: 0x0002A418
		private static void OnGotLostFocusHelper(bool gotFocus, object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			if (dependencyObject == null)
			{
				return;
			}
			global::Infragistics.Windows.Helpers.FocusWithinManager.VerifyFocusWithin(dependencyObject, gotFocus);
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0002C237 File Offset: 0x0002A437
		private static void OnLostFocusClassHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Helpers.FocusWithinManager.OnGotLostFocusHelper(false, sender, e);
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x0002C244 File Offset: 0x0002A444
		private static void OnLostFocusHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			if (dependencyObject == null)
			{
				return;
			}
			global::Infragistics.Windows.Helpers.FocusWithinManager.HookOrUnhookLostFocus(dependencyObject, false);
			global::System.Windows.DependencyObject focusedElem;
			global::System.Windows.DependencyObject focusScope;
			global::Infragistics.Windows.Helpers.FocusWithinManager.GetFocusedElem(dependencyObject, out focusedElem, out focusScope);
			global::Infragistics.Windows.Helpers.FocusWithinManager.VerifyFocusWithin(focusedElem, focusScope);
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x0002C274 File Offset: 0x0002A474
		private static void SetFocusWithin(global::System.Windows.DependencyObject elem, bool value, global::System.Windows.DependencyObject focusedElem)
		{
			if (value)
			{
				elem.SetValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				global::Infragistics.Windows.Helpers.FocusWithinManager.HookOrUnhookLostFocus(focusedElem, true);
				if (!global::Infragistics.Windows.Helpers.FocusWithinManager.FocusedElems.ContainsKey(elem))
				{
					global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, long> focusedElems = global::Infragistics.Windows.Helpers.FocusWithinManager.FocusedElems;
					long num = global::Infragistics.Windows.Helpers.FocusWithinManager.time_stamp;
					global::Infragistics.Windows.Helpers.FocusWithinManager.time_stamp = num + 1L;
					focusedElems[elem] = num;
					return;
				}
			}
			else
			{
				elem.ClearValue(global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinPropertyKey);
				global::Infragistics.Windows.Helpers.FocusWithinManager.FocusedElems.Remove(elem);
			}
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x0002C2DC File Offset: 0x0002A4DC
		private static void VerifyFocusWithin(global::System.Windows.DependencyObject elem, bool fromGotFocusHandler)
		{
			if (elem == null)
			{
				return;
			}
			global::System.Windows.DependencyObject dependencyObject;
			global::System.Windows.DependencyObject focusScope;
			global::Infragistics.Windows.Helpers.FocusWithinManager.GetFocusedElem(elem, out dependencyObject, out focusScope);
			if (fromGotFocusHandler)
			{
				global::Infragistics.Windows.Helpers.FocusWithinManager.VerifyFocusWithin(dependencyObject, focusScope);
			}
			bool flag = fromGotFocusHandler;
			if (!flag && dependencyObject != null && global::Infragistics.Windows.Helpers.FocusWithinManager.IsAncestorOf(elem, dependencyObject))
			{
				flag = true;
			}
			global::Infragistics.Windows.Helpers.FocusWithinManager.SetFocusWithin(elem, flag, dependencyObject);
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x0002C31C File Offset: 0x0002A51C
		private static void VerifyFocusWithin(global::System.Windows.DependencyObject focusedElem, global::System.Windows.DependencyObject focusScope)
		{
			global::System.Collections.Generic.List<global::System.Windows.DependencyObject> list = new global::System.Collections.Generic.List<global::System.Windows.DependencyObject>();
			foreach (global::System.Windows.DependencyObject dependencyObject in global::Infragistics.Windows.Helpers.FocusWithinManager.FocusedElems.Keys)
			{
				global::System.Windows.DependencyObject focusScope2 = global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject);
				if (focusScope == focusScope2 && (focusedElem == null || !global::Infragistics.Windows.Helpers.FocusWithinManager.IsAncestorOf(dependencyObject, focusedElem)))
				{
					list.Add(dependencyObject);
				}
			}
			list.Sort(new global::Infragistics.Windows.Helpers.FocusWithinManager.DictionaryValueComparer<global::System.Windows.DependencyObject, long>(global::Infragistics.Windows.Helpers.FocusWithinManager.FocusedElems, true));
			foreach (global::System.Windows.DependencyObject key in list)
			{
				global::Infragistics.Windows.Helpers.FocusWithinManager.FocusedElems.Remove(key);
			}
			foreach (global::System.Windows.DependencyObject elem in list)
			{
				global::Infragistics.Windows.Helpers.FocusWithinManager.SetFocusWithin(elem, false, focusedElem);
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x0002C424 File Offset: 0x0002A624
		private static global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, long> FocusedElems
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.FocusWithinManager._focusedElems == null)
				{
					global::Infragistics.Windows.Helpers.FocusWithinManager._focusedElems = new global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, long>(true, false);
				}
				return global::Infragistics.Windows.Helpers.FocusWithinManager._focusedElems;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0002C43E File Offset: 0x0002A63E
		private static global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, object> HookedInElems
		{
			get
			{
				if (global::Infragistics.Windows.Helpers.FocusWithinManager._hookedInElems == null)
				{
					global::Infragistics.Windows.Helpers.FocusWithinManager._hookedInElems = new global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, object>(true, false);
				}
				return global::Infragistics.Windows.Helpers.FocusWithinManager._hookedInElems;
			}
		}

		// Token: 0x0400066B RID: 1643
		[global::System.ThreadStatic]
		private static long time_stamp;

		// Token: 0x0400066C RID: 1644
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, long> _focusedElems;

		// Token: 0x0400066D RID: 1645
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, object> _hookedInElems;

		// Token: 0x0400066E RID: 1646
		private static readonly global::System.Windows.DependencyPropertyKey IsFocusWithinPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFocusWithin", typeof(bool), typeof(global::Infragistics.Windows.Helpers.FocusWithinManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400066F RID: 1647
		public static readonly global::System.Windows.DependencyProperty IsFocusWithinProperty = global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinPropertyKey.DependencyProperty;

		// Token: 0x02000192 RID: 402
		private class DictionaryValueComparer<TKey, TValue> : global::System.Collections.Generic.IComparer<TKey>
		{
			// Token: 0x06000D75 RID: 3445 RVA: 0x0002C458 File Offset: 0x0002A658
			public DictionaryValueComparer(global::System.Collections.Generic.IDictionary<TKey, TValue> table, bool reverseOrder)
			{
				this._table = table;
				this._reverseOrder = reverseOrder;
			}

			// Token: 0x06000D76 RID: 3446 RVA: 0x0002C470 File Offset: 0x0002A670
			public int Compare(TKey xxObj, TKey yyObj)
			{
				TValue tvalue = this._table[xxObj];
				TValue tvalue2 = this._table[yyObj];
				int num = ((global::System.IComparable)((object)tvalue)).CompareTo(tvalue2);
				if (this._reverseOrder)
				{
					num *= -1;
				}
				return num;
			}

			// Token: 0x04000670 RID: 1648
			private global::System.Collections.Generic.IDictionary<TKey, TValue> _table;

			// Token: 0x04000671 RID: 1649
			private bool _reverseOrder;
		}
	}
}
