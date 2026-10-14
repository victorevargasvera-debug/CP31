using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Infragistics.Collections;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x0200016F RID: 367
	public class FocusWithinManager : global::System.Windows.DependencyObject
	{
		// Token: 0x06000C4F RID: 3151 RVA: 0x00027EBA File Offset: 0x000260BA
		private FocusWithinManager()
		{
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00027EC4 File Offset: 0x000260C4
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

		// Token: 0x06000C51 RID: 3153 RVA: 0x00027EEC File Offset: 0x000260EC
		public static bool IsAncestorOf(global::System.Windows.DependencyObject ancestor, global::System.Windows.DependencyObject elem)
		{
			return global::Infragistics.Windows.Helpers.FocusWithinManager.IsAncestorOfHelper(ancestor, elem);
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00027EF5 File Offset: 0x000260F5
		public static void RegisterType(global::System.Type classType)
		{
			global::Infragistics.Windows.Helpers.FocusWithinManager.RegisterType(classType, null);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x00027F00 File Offset: 0x00026100
		public static void RegisterType(global::System.Type classType, global::System.Windows.PropertyChangedCallback callback)
		{
			global::System.Windows.EventManager.RegisterClassHandler(classType, global::System.Windows.UIElement.GotFocusEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Helpers.FocusWithinManager.OnGotFocusClassHandler), true);
			global::System.Windows.EventManager.RegisterClassHandler(classType, global::System.Windows.UIElement.LostFocusEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.Helpers.FocusWithinManager.OnLostFocusClassHandler), true);
			if (callback != null)
			{
				global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinPropertyKey.OverrideMetadata(classType, new global::System.Windows.FrameworkPropertyMetadata(callback));
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x00027F51 File Offset: 0x00026151
		private static void GetFocusedElem(global::System.Windows.DependencyObject elem, out global::System.Windows.DependencyObject focusedElem, out global::System.Windows.DependencyObject focusScope)
		{
			focusScope = ((elem != null) ? global::System.Windows.Input.FocusManager.GetFocusScope(elem) : null);
			focusedElem = ((focusScope != null) ? (focusScope.GetValue(global::System.Windows.Input.FocusManager.FocusedElementProperty) as global::System.Windows.DependencyObject) : null);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x00027F7C File Offset: 0x0002617C
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

		// Token: 0x06000C56 RID: 3158 RVA: 0x00028044 File Offset: 0x00026244
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

		// Token: 0x06000C57 RID: 3159 RVA: 0x00028086 File Offset: 0x00026286
		private static void OnGotFocusClassHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Helpers.FocusWithinManager.OnGotLostFocusHelper(true, sender, e);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x00028090 File Offset: 0x00026290
		private static void OnGotLostFocusHelper(bool gotFocus, object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = sender as global::System.Windows.DependencyObject;
			if (dependencyObject == null)
			{
				return;
			}
			global::Infragistics.Windows.Helpers.FocusWithinManager.VerifyFocusWithin(dependencyObject, gotFocus);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x000280AF File Offset: 0x000262AF
		private static void OnLostFocusClassHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.Helpers.FocusWithinManager.OnGotLostFocusHelper(false, sender, e);
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x000280BC File Offset: 0x000262BC
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

		// Token: 0x06000C5B RID: 3163 RVA: 0x000280EC File Offset: 0x000262EC
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

		// Token: 0x06000C5C RID: 3164 RVA: 0x00028154 File Offset: 0x00026354
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

		// Token: 0x06000C5D RID: 3165 RVA: 0x00028194 File Offset: 0x00026394
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

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x0002829C File Offset: 0x0002649C
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

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x000282B6 File Offset: 0x000264B6
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

		// Token: 0x040005A6 RID: 1446
		[global::System.ThreadStatic]
		private static long time_stamp;

		// Token: 0x040005A7 RID: 1447
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, long> _focusedElems;

		// Token: 0x040005A8 RID: 1448
		[global::System.ThreadStatic]
		private static global::Infragistics.Collections.WeakDictionary<global::System.Windows.DependencyObject, object> _hookedInElems;

		// Token: 0x040005A9 RID: 1449
		private static readonly global::System.Windows.DependencyPropertyKey IsFocusWithinPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFocusWithin", typeof(bool), typeof(global::Infragistics.Windows.Helpers.FocusWithinManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040005AA RID: 1450
		public static readonly global::System.Windows.DependencyProperty IsFocusWithinProperty = global::Infragistics.Windows.Helpers.FocusWithinManager.IsFocusWithinPropertyKey.DependencyProperty;

		// Token: 0x02000170 RID: 368
		private class DictionaryValueComparer<TKey, TValue> : global::System.Collections.Generic.IComparer<TKey>
		{
			// Token: 0x06000C60 RID: 3168 RVA: 0x000282D0 File Offset: 0x000264D0
			public DictionaryValueComparer(global::System.Collections.Generic.IDictionary<TKey, TValue> table, bool reverseOrder)
			{
				this._table = table;
				this._reverseOrder = reverseOrder;
			}

			// Token: 0x06000C61 RID: 3169 RVA: 0x000282E8 File Offset: 0x000264E8
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

			// Token: 0x040005AB RID: 1451
			private global::System.Collections.Generic.IDictionary<TKey, TValue> _table;

			// Token: 0x040005AC RID: 1452
			private bool _reverseOrder;
		}
	}
}
