using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Utilities;
using System.Reflection;
using System.Xml.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200012C RID: 300
	internal class SortableBindingList<T> : global::System.ComponentModel.BindingList<T>
	{
		// Token: 0x0600149D RID: 5277 RVA: 0x00034F3C File Offset: 0x0003313C
		public SortableBindingList(global::System.Collections.Generic.List<T> list) : base(list)
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00034F48 File Offset: 0x00033148
		protected override void ApplySortCore(global::System.ComponentModel.PropertyDescriptor prop, global::System.ComponentModel.ListSortDirection direction)
		{
			if (global::System.Data.Entity.Internal.SortableBindingList<T>.PropertyComparer.CanSort(prop.PropertyType))
			{
				((global::System.Collections.Generic.List<T>)base.Items).Sort(new global::System.Data.Entity.Internal.SortableBindingList<T>.PropertyComparer(prop, direction));
				this._sortDirection = direction;
				this._sortProperty = prop;
				this._isSorted = true;
				this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.Reset, -1));
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00034F9B File Offset: 0x0003319B
		protected override void RemoveSortCore()
		{
			this._isSorted = false;
			this._sortProperty = null;
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060014A0 RID: 5280 RVA: 0x00034FAB File Offset: 0x000331AB
		protected override bool IsSortedCore
		{
			get
			{
				return this._isSorted;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00034FB3 File Offset: 0x000331B3
		protected override global::System.ComponentModel.ListSortDirection SortDirectionCore
		{
			get
			{
				return this._sortDirection;
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x00034FBB File Offset: 0x000331BB
		protected override global::System.ComponentModel.PropertyDescriptor SortPropertyCore
		{
			get
			{
				return this._sortProperty;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00034FC3 File Offset: 0x000331C3
		protected override bool SupportsSortingCore
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040009B2 RID: 2482
		private bool _isSorted;

		// Token: 0x040009B3 RID: 2483
		private global::System.ComponentModel.ListSortDirection _sortDirection;

		// Token: 0x040009B4 RID: 2484
		private global::System.ComponentModel.PropertyDescriptor _sortProperty;

		// Token: 0x0200080E RID: 2062
		internal class PropertyComparer : global::System.Collections.Generic.Comparer<T>
		{
			// Token: 0x0600599D RID: 22941 RVA: 0x0013A204 File Offset: 0x00138404
			public PropertyComparer(global::System.ComponentModel.PropertyDescriptor prop, global::System.ComponentModel.ListSortDirection direction)
			{
				if (!prop.ComponentType.IsAssignableFrom(typeof(T)))
				{
					throw new global::System.MissingMemberException(typeof(T).Name, prop.Name);
				}
				this._prop = prop;
				this._direction = direction;
				if (global::System.Data.Entity.Internal.SortableBindingList<T>.PropertyComparer.CanSortWithIComparable(prop.PropertyType))
				{
					global::System.Reflection.PropertyInfo declaredProperty = typeof(global::System.Collections.Generic.Comparer<>).MakeGenericType(new global::System.Type[]
					{
						prop.PropertyType
					}).GetDeclaredProperty("Default");
					this._comparer = (global::System.Collections.IComparer)declaredProperty.GetValue(null, null);
					this._useToString = false;
					return;
				}
				this._comparer = global::System.StringComparer.CurrentCultureIgnoreCase;
				this._useToString = true;
			}

			// Token: 0x0600599E RID: 22942 RVA: 0x0013A2BC File Offset: 0x001384BC
			public override int Compare(T left, T right)
			{
				object obj = this._prop.GetValue(left);
				object obj2 = this._prop.GetValue(right);
				if (this._useToString)
				{
					obj = ((obj != null) ? obj.ToString() : null);
					obj2 = ((obj2 != null) ? obj2.ToString() : null);
				}
				if (this._direction != global::System.ComponentModel.ListSortDirection.Ascending)
				{
					return this._comparer.Compare(obj2, obj);
				}
				return this._comparer.Compare(obj, obj2);
			}

			// Token: 0x0600599F RID: 22943 RVA: 0x0013A332 File Offset: 0x00138532
			public static bool CanSort(global::System.Type type)
			{
				return global::System.Data.Entity.Internal.SortableBindingList<T>.PropertyComparer.CanSortWithToString(type) || global::System.Data.Entity.Internal.SortableBindingList<T>.PropertyComparer.CanSortWithIComparable(type);
			}

			// Token: 0x060059A0 RID: 22944 RVA: 0x0013A344 File Offset: 0x00138544
			private static bool CanSortWithIComparable(global::System.Type type)
			{
				return type.GetInterface("IComparable") != null || (type.IsGenericType() && type.GetGenericTypeDefinition() == typeof(global::System.Nullable<>));
			}

			// Token: 0x060059A1 RID: 22945 RVA: 0x0013A37A File Offset: 0x0013857A
			private static bool CanSortWithToString(global::System.Type type)
			{
				return type.Equals(typeof(global::System.Xml.Linq.XNode)) || type.IsSubclassOf(typeof(global::System.Xml.Linq.XNode));
			}

			// Token: 0x04002227 RID: 8743
			private readonly global::System.Collections.IComparer _comparer;

			// Token: 0x04002228 RID: 8744
			private readonly global::System.ComponentModel.ListSortDirection _direction;

			// Token: 0x04002229 RID: 8745
			private readonly global::System.ComponentModel.PropertyDescriptor _prop;

			// Token: 0x0400222A RID: 8746
			private readonly bool _useToString;
		}
	}
}
