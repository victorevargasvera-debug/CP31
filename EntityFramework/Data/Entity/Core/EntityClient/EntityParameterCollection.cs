using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005DB RID: 1499
	public sealed class EntityParameterCollection : global::System.Data.Common.DbParameterCollection
	{
		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x0600488F RID: 18575 RVA: 0x001016A7 File Offset: 0x000FF8A7
		public override int Count
		{
			get
			{
				if (this._items == null)
				{
					return 0;
				}
				return this._items.Count;
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06004890 RID: 18576 RVA: 0x001016C0 File Offset: 0x000FF8C0
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter> InnerList
		{
			get
			{
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter> list = this._items;
				if (list == null)
				{
					list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter>();
					this._items = list;
				}
				return list;
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06004891 RID: 18577 RVA: 0x001016E5 File Offset: 0x000FF8E5
		public override bool IsFixedSize
		{
			get
			{
				return ((global::System.Collections.IList)this.InnerList).IsFixedSize;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06004892 RID: 18578 RVA: 0x001016F2 File Offset: 0x000FF8F2
		public override bool IsReadOnly
		{
			get
			{
				return ((global::System.Collections.IList)this.InnerList).IsReadOnly;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06004893 RID: 18579 RVA: 0x001016FF File Offset: 0x000FF8FF
		public override bool IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this.InnerList).IsSynchronized;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06004894 RID: 18580 RVA: 0x0010170C File Offset: 0x000FF90C
		public override object SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this.InnerList).SyncRoot;
			}
		}

		// Token: 0x06004895 RID: 18581 RVA: 0x00101719 File Offset: 0x000FF919
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int Add(object value)
		{
			this.OnChange();
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			global::System.Data.Entity.Core.EntityClient.EntityParameterCollection.ValidateType(value);
			this.Validate(-1, value);
			this.InnerList.Add((global::System.Data.Entity.Core.EntityClient.EntityParameter)value);
			return this.Count - 1;
		}

		// Token: 0x06004896 RID: 18582 RVA: 0x00101754 File Offset: 0x000FF954
		public override void AddRange(global::System.Array values)
		{
			this.OnChange();
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Array>(values, "values");
			foreach (object value in values)
			{
				global::System.Data.Entity.Core.EntityClient.EntityParameterCollection.ValidateType(value);
			}
			foreach (object obj in values)
			{
				global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = (global::System.Data.Entity.Core.EntityClient.EntityParameter)obj;
				this.Validate(-1, entityParameter);
				this.InnerList.Add(entityParameter);
			}
		}

		// Token: 0x06004897 RID: 18583 RVA: 0x00101804 File Offset: 0x000FFA04
		private int CheckName(string parameterName)
		{
			int num = this.IndexOf(parameterName);
			if (num < 0)
			{
				throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.EntityParameterCollectionInvalidParameterName(parameterName));
			}
			return num;
		}

		// Token: 0x06004898 RID: 18584 RVA: 0x00101820 File Offset: 0x000FFA20
		public override void Clear()
		{
			this.OnChange();
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter> innerList = this.InnerList;
			if (innerList != null)
			{
				foreach (global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter in innerList)
				{
					entityParameter.ResetParent();
				}
				innerList.Clear();
			}
		}

		// Token: 0x06004899 RID: 18585 RVA: 0x00101884 File Offset: 0x000FFA84
		public override bool Contains(object value)
		{
			return -1 != this.IndexOf(value);
		}

		// Token: 0x0600489A RID: 18586 RVA: 0x00101893 File Offset: 0x000FFA93
		public override void CopyTo(global::System.Array array, int index)
		{
			((global::System.Collections.ICollection)this.InnerList).CopyTo(array, index);
		}

		// Token: 0x0600489B RID: 18587 RVA: 0x001018A2 File Offset: 0x000FFAA2
		public override global::System.Collections.IEnumerator GetEnumerator()
		{
			return ((global::System.Collections.IEnumerable)this.InnerList).GetEnumerator();
		}

		// Token: 0x0600489C RID: 18588 RVA: 0x001018AF File Offset: 0x000FFAAF
		protected override global::System.Data.Common.DbParameter GetParameter(int index)
		{
			this.RangeCheck(index);
			return this.InnerList[index];
		}

		// Token: 0x0600489D RID: 18589 RVA: 0x001018C4 File Offset: 0x000FFAC4
		protected override global::System.Data.Common.DbParameter GetParameter(string parameterName)
		{
			int num = this.IndexOf(parameterName);
			if (num < 0)
			{
				throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.EntityParameterCollectionInvalidParameterName(parameterName));
			}
			return this.InnerList[num];
		}

		// Token: 0x0600489E RID: 18590 RVA: 0x001018F8 File Offset: 0x000FFAF8
		private static int IndexOf(global::System.Collections.IEnumerable items, string parameterName)
		{
			if (items != null)
			{
				int num = 0;
				foreach (object obj in items)
				{
					global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = (global::System.Data.Entity.Core.EntityClient.EntityParameter)obj;
					if (global::System.Data.Entity.Core.EntityUtil.SrcCompare(parameterName, entityParameter.ParameterName) == 0)
					{
						return num;
					}
					num++;
				}
				num = 0;
				foreach (object obj2 in items)
				{
					global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter2 = (global::System.Data.Entity.Core.EntityClient.EntityParameter)obj2;
					if (global::System.Data.Entity.Core.EntityUtil.DstCompare(parameterName, entityParameter2.ParameterName) == 0)
					{
						return num;
					}
					num++;
				}
				return -1;
			}
			return -1;
		}

		// Token: 0x0600489F RID: 18591 RVA: 0x001019C4 File Offset: 0x000FFBC4
		public override int IndexOf(string parameterName)
		{
			return global::System.Data.Entity.Core.EntityClient.EntityParameterCollection.IndexOf(this.InnerList, parameterName);
		}

		// Token: 0x060048A0 RID: 18592 RVA: 0x001019D4 File Offset: 0x000FFBD4
		public override int IndexOf(object value)
		{
			if (value != null)
			{
				global::System.Data.Entity.Core.EntityClient.EntityParameterCollection.ValidateType(value);
				global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter> innerList = this.InnerList;
				if (innerList != null)
				{
					int count = innerList.Count;
					for (int i = 0; i < count; i++)
					{
						if (value == innerList[i])
						{
							return i;
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x060048A1 RID: 18593 RVA: 0x00101A14 File Offset: 0x000FFC14
		public override void Insert(int index, object value)
		{
			this.OnChange();
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			global::System.Data.Entity.Core.EntityClient.EntityParameterCollection.ValidateType(value);
			this.Validate(-1, value);
			this.InnerList.Insert(index, (global::System.Data.Entity.Core.EntityClient.EntityParameter)value);
		}

		// Token: 0x060048A2 RID: 18594 RVA: 0x00101A48 File Offset: 0x000FFC48
		private void RangeCheck(int index)
		{
			if (index < 0 || this.Count <= index)
			{
				throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.EntityParameterCollectionInvalidIndex(index.ToString(global::System.Globalization.CultureInfo.InvariantCulture), this.Count.ToString(global::System.Globalization.CultureInfo.InvariantCulture)));
			}
		}

		// Token: 0x060048A3 RID: 18595 RVA: 0x00101A8C File Offset: 0x000FFC8C
		public override void Remove(object value)
		{
			this.OnChange();
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			global::System.Data.Entity.Core.EntityClient.EntityParameterCollection.ValidateType(value);
			int num = this.IndexOf(value);
			if (-1 != num)
			{
				this.RemoveIndex(num);
				return;
			}
			if (this != ((global::System.Data.Entity.Core.EntityClient.EntityParameter)value).CompareExchangeParent(null, this))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityParameterCollectionRemoveInvalidObject);
			}
		}

		// Token: 0x060048A4 RID: 18596 RVA: 0x00101AE0 File Offset: 0x000FFCE0
		public override void RemoveAt(int index)
		{
			this.OnChange();
			this.RangeCheck(index);
			this.RemoveIndex(index);
		}

		// Token: 0x060048A5 RID: 18597 RVA: 0x00101AF8 File Offset: 0x000FFCF8
		public override void RemoveAt(string parameterName)
		{
			this.OnChange();
			int index = this.CheckName(parameterName);
			this.RemoveIndex(index);
		}

		// Token: 0x060048A6 RID: 18598 RVA: 0x00101B1C File Offset: 0x000FFD1C
		private void RemoveIndex(int index)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter> innerList = this.InnerList;
			global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = innerList[index];
			innerList.RemoveAt(index);
			entityParameter.ResetParent();
		}

		// Token: 0x060048A7 RID: 18599 RVA: 0x00101B44 File Offset: 0x000FFD44
		private void Replace(int index, object newValue)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter> innerList = this.InnerList;
			global::System.Data.Entity.Core.EntityClient.EntityParameterCollection.ValidateType(newValue);
			this.Validate(index, newValue);
			global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = innerList[index];
			innerList[index] = (global::System.Data.Entity.Core.EntityClient.EntityParameter)newValue;
			entityParameter.ResetParent();
		}

		// Token: 0x060048A8 RID: 18600 RVA: 0x00101B7F File Offset: 0x000FFD7F
		protected override void SetParameter(int index, global::System.Data.Common.DbParameter value)
		{
			this.OnChange();
			this.RangeCheck(index);
			this.Replace(index, value);
		}

		// Token: 0x060048A9 RID: 18601 RVA: 0x00101B98 File Offset: 0x000FFD98
		protected override void SetParameter(string parameterName, global::System.Data.Common.DbParameter value)
		{
			this.OnChange();
			int num = this.IndexOf(parameterName);
			if (num < 0)
			{
				throw new global::System.IndexOutOfRangeException(global::System.Data.Entity.Resources.Strings.EntityParameterCollectionInvalidParameterName(parameterName));
			}
			this.Replace(num, value);
		}

		// Token: 0x060048AA RID: 18602 RVA: 0x00101BCC File Offset: 0x000FFDCC
		private void Validate(int index, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			global::System.Data.Entity.Core.EntityClient.EntityParameter entityParameter = (global::System.Data.Entity.Core.EntityClient.EntityParameter)value;
			object obj = entityParameter.CompareExchangeParent(this, null);
			if (obj != null)
			{
				if (this != obj)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityParameterContainedByAnotherCollection);
				}
				if (index != this.IndexOf(value))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityParameterContainedByAnotherCollection);
				}
			}
			string text = entityParameter.ParameterName;
			if (text.Length == 0)
			{
				index = 1;
				do
				{
					text = "Parameter" + index.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					index++;
				}
				while (-1 != this.IndexOf(text));
				entityParameter.ParameterName = text;
			}
		}

		// Token: 0x060048AB RID: 18603 RVA: 0x00101C5B File Offset: 0x000FFE5B
		private static void ValidateType(object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			if (!global::System.Data.Entity.Core.EntityClient.EntityParameterCollection._itemType.IsInstanceOfType(value))
			{
				throw new global::System.InvalidCastException(global::System.Data.Entity.Resources.Strings.InvalidEntityParameterType(value.GetType().Name));
			}
		}

		// Token: 0x060048AC RID: 18604 RVA: 0x00101C8C File Offset: 0x000FFE8C
		internal EntityParameterCollection()
		{
		}

		// Token: 0x17000E4F RID: 3663
		public global::System.Data.Entity.Core.EntityClient.EntityParameter this[int index]
		{
			get
			{
				return (global::System.Data.Entity.Core.EntityClient.EntityParameter)this.GetParameter(index);
			}
			set
			{
				this.SetParameter(index, value);
			}
		}

		// Token: 0x17000E50 RID: 3664
		public global::System.Data.Entity.Core.EntityClient.EntityParameter this[string parameterName]
		{
			get
			{
				return (global::System.Data.Entity.Core.EntityClient.EntityParameter)this.GetParameter(parameterName);
			}
			set
			{
				this.SetParameter(parameterName, value);
			}
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x060048B1 RID: 18609 RVA: 0x00101CC4 File Offset: 0x000FFEC4
		internal bool IsDirty
		{
			get
			{
				if (this._isDirty)
				{
					return true;
				}
				using (global::System.Collections.IEnumerator enumerator = this.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((global::System.Data.Entity.Core.EntityClient.EntityParameter)enumerator.Current).IsDirty)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x060048B2 RID: 18610 RVA: 0x00101D28 File Offset: 0x000FFF28
		public global::System.Data.Entity.Core.EntityClient.EntityParameter Add(global::System.Data.Entity.Core.EntityClient.EntityParameter value)
		{
			this.Add(value);
			return value;
		}

		// Token: 0x060048B3 RID: 18611 RVA: 0x00101D34 File Offset: 0x000FFF34
		public global::System.Data.Entity.Core.EntityClient.EntityParameter AddWithValue(string parameterName, object value)
		{
			return this.Add(new global::System.Data.Entity.Core.EntityClient.EntityParameter
			{
				ParameterName = parameterName,
				Value = value
			});
		}

		// Token: 0x060048B4 RID: 18612 RVA: 0x00101D5C File Offset: 0x000FFF5C
		public global::System.Data.Entity.Core.EntityClient.EntityParameter Add(string parameterName, global::System.Data.DbType dbType)
		{
			return this.Add(new global::System.Data.Entity.Core.EntityClient.EntityParameter(parameterName, dbType));
		}

		// Token: 0x060048B5 RID: 18613 RVA: 0x00101D6B File Offset: 0x000FFF6B
		public global::System.Data.Entity.Core.EntityClient.EntityParameter Add(string parameterName, global::System.Data.DbType dbType, int size)
		{
			return this.Add(new global::System.Data.Entity.Core.EntityClient.EntityParameter(parameterName, dbType, size));
		}

		// Token: 0x060048B6 RID: 18614 RVA: 0x00101D7B File Offset: 0x000FFF7B
		public void AddRange(global::System.Data.Entity.Core.EntityClient.EntityParameter[] values)
		{
			this.AddRange(values);
		}

		// Token: 0x060048B7 RID: 18615 RVA: 0x00101D84 File Offset: 0x000FFF84
		public override bool Contains(string parameterName)
		{
			return this.IndexOf(parameterName) != -1;
		}

		// Token: 0x060048B8 RID: 18616 RVA: 0x00101D93 File Offset: 0x000FFF93
		public void CopyTo(global::System.Data.Entity.Core.EntityClient.EntityParameter[] array, int index)
		{
			this.CopyTo(array, index);
		}

		// Token: 0x060048B9 RID: 18617 RVA: 0x00101D9D File Offset: 0x000FFF9D
		public int IndexOf(global::System.Data.Entity.Core.EntityClient.EntityParameter value)
		{
			return this.IndexOf(value);
		}

		// Token: 0x060048BA RID: 18618 RVA: 0x00101DA6 File Offset: 0x000FFFA6
		public void Insert(int index, global::System.Data.Entity.Core.EntityClient.EntityParameter value)
		{
			this.Insert(index, value);
		}

		// Token: 0x060048BB RID: 18619 RVA: 0x00101DB0 File Offset: 0x000FFFB0
		private void OnChange()
		{
			this._isDirty = true;
		}

		// Token: 0x060048BC RID: 18620 RVA: 0x00101DB9 File Offset: 0x000FFFB9
		public void Remove(global::System.Data.Entity.Core.EntityClient.EntityParameter value)
		{
			this.Remove(value);
		}

		// Token: 0x060048BD RID: 18621 RVA: 0x00101DC4 File Offset: 0x000FFFC4
		internal void ResetIsDirty()
		{
			this._isDirty = false;
			foreach (object obj in this)
			{
				((global::System.Data.Entity.Core.EntityClient.EntityParameter)obj).ResetIsDirty();
			}
		}

		// Token: 0x040019BE RID: 6590
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.EntityClient.EntityParameter> _items;

		// Token: 0x040019BF RID: 6591
		private static readonly global::System.Type _itemType = typeof(global::System.Data.Entity.Core.EntityClient.EntityParameter);

		// Token: 0x040019C0 RID: 6592
		private bool _isDirty;
	}
}
