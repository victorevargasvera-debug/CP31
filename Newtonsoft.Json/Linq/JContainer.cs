using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000BB RID: 187
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public abstract class JContainer : global::Newtonsoft.Json.Linq.JToken, global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>, global::System.Collections.IEnumerable, global::System.ComponentModel.ITypedList, global::System.ComponentModel.IBindingList, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x0002855C File Offset: 0x0002675C
		internal global::System.Threading.Tasks.Task ReadTokenFromAsync(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings options, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Linq.JContainer.<ReadTokenFromAsync>d__0 <ReadTokenFromAsync>d__;
			<ReadTokenFromAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ReadTokenFromAsync>d__.<>4__this = this;
			<ReadTokenFromAsync>d__.reader = reader;
			<ReadTokenFromAsync>d__.options = options;
			<ReadTokenFromAsync>d__.cancellationToken = cancellationToken;
			<ReadTokenFromAsync>d__.<>1__state = -1;
			<ReadTokenFromAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JContainer.<ReadTokenFromAsync>d__0>(ref <ReadTokenFromAsync>d__);
			return <ReadTokenFromAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000285B8 File Offset: 0x000267B8
		private global::System.Threading.Tasks.Task ReadContentFromAsync(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Linq.JContainer.<ReadContentFromAsync>d__1 <ReadContentFromAsync>d__;
			<ReadContentFromAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ReadContentFromAsync>d__.<>4__this = this;
			<ReadContentFromAsync>d__.reader = reader;
			<ReadContentFromAsync>d__.settings = settings;
			<ReadContentFromAsync>d__.cancellationToken = cancellationToken;
			<ReadContentFromAsync>d__.<>1__state = -1;
			<ReadContentFromAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JContainer.<ReadContentFromAsync>d__1>(ref <ReadContentFromAsync>d__);
			return <ReadContentFromAsync>d__.<>t__builder.Task;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060009BE RID: 2494 RVA: 0x00028613 File Offset: 0x00026813
		// (remove) Token: 0x060009BF RID: 2495 RVA: 0x0002862C File Offset: 0x0002682C
		public event global::System.ComponentModel.ListChangedEventHandler ListChanged
		{
			add
			{
				this._listChanged = (global::System.ComponentModel.ListChangedEventHandler)global::System.Delegate.Combine(this._listChanged, value);
			}
			remove
			{
				this._listChanged = (global::System.ComponentModel.ListChangedEventHandler)global::System.Delegate.Remove(this._listChanged, value);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060009C0 RID: 2496 RVA: 0x00028645 File Offset: 0x00026845
		// (remove) Token: 0x060009C1 RID: 2497 RVA: 0x0002865E File Offset: 0x0002685E
		public event global::System.ComponentModel.AddingNewEventHandler AddingNew
		{
			add
			{
				this._addingNew = (global::System.ComponentModel.AddingNewEventHandler)global::System.Delegate.Combine(this._addingNew, value);
			}
			remove
			{
				this._addingNew = (global::System.ComponentModel.AddingNewEventHandler)global::System.Delegate.Remove(this._addingNew, value);
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060009C2 RID: 2498 RVA: 0x00028677 File Offset: 0x00026877
		// (remove) Token: 0x060009C3 RID: 2499 RVA: 0x00028690 File Offset: 0x00026890
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			add
			{
				this._collectionChanged = (global::System.Collections.Specialized.NotifyCollectionChangedEventHandler)global::System.Delegate.Combine(this._collectionChanged, value);
			}
			remove
			{
				this._collectionChanged = (global::System.Collections.Specialized.NotifyCollectionChangedEventHandler)global::System.Delegate.Remove(this._collectionChanged, value);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060009C4 RID: 2500
		protected abstract global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> ChildrenTokens { get; }

		// Token: 0x060009C5 RID: 2501 RVA: 0x000286A9 File Offset: 0x000268A9
		internal JContainer()
		{
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000286B4 File Offset: 0x000268B4
		internal JContainer(global::Newtonsoft.Json.Linq.JContainer other) : this()
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(other, "other");
			int num = 0;
			foreach (global::Newtonsoft.Json.Linq.JToken content in ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)other))
			{
				this.TryAddInternal(num, content, false);
				num++;
			}
			base.CopyAnnotations(this, other);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00028720 File Offset: 0x00026920
		internal void CheckReentrancy()
		{
			if (this._busy)
			{
				throw new global::System.InvalidOperationException("Cannot change {0} during a collection change event.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType()));
			}
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x00028745 File Offset: 0x00026945
		internal virtual global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> CreateChildrenCollection()
		{
			return new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken>();
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0002874C File Offset: 0x0002694C
		protected virtual void OnAddingNew(global::System.ComponentModel.AddingNewEventArgs e)
		{
			global::System.ComponentModel.AddingNewEventHandler addingNew = this._addingNew;
			if (addingNew == null)
			{
				return;
			}
			addingNew(this, e);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x00028760 File Offset: 0x00026960
		protected virtual void OnListChanged(global::System.ComponentModel.ListChangedEventArgs e)
		{
			global::System.ComponentModel.ListChangedEventHandler listChanged = this._listChanged;
			if (listChanged != null)
			{
				this._busy = true;
				try
				{
					listChanged(this, e);
				}
				finally
				{
					this._busy = false;
				}
			}
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000287A0 File Offset: 0x000269A0
		protected virtual void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventHandler collectionChanged = this._collectionChanged;
			if (collectionChanged != null)
			{
				this._busy = true;
				try
				{
					collectionChanged(this, e);
				}
				finally
				{
					this._busy = false;
				}
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x000287E0 File Offset: 0x000269E0
		public override bool HasValues
		{
			get
			{
				return this.ChildrenTokens.Count > 0;
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x000287F0 File Offset: 0x000269F0
		internal bool ContentsEqual(global::Newtonsoft.Json.Linq.JContainer container)
		{
			if (container == this)
			{
				return true;
			}
			global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> childrenTokens = this.ChildrenTokens;
			global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> childrenTokens2 = container.ChildrenTokens;
			if (childrenTokens.Count != childrenTokens2.Count)
			{
				return false;
			}
			for (int i = 0; i < childrenTokens.Count; i++)
			{
				if (!childrenTokens[i].DeepEquals(childrenTokens2[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0002884C File Offset: 0x00026A4C
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override global::Newtonsoft.Json.Linq.JToken First
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> childrenTokens = this.ChildrenTokens;
				if (childrenTokens.Count <= 0)
				{
					return null;
				}
				return childrenTokens[0];
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x00028874 File Offset: 0x00026A74
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public override global::Newtonsoft.Json.Linq.JToken Last
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> childrenTokens = this.ChildrenTokens;
				int count = childrenTokens.Count;
				if (count <= 0)
				{
					return null;
				}
				return childrenTokens[count - 1];
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0002889E File Offset: 0x00026A9E
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1
		})]
		public override global::Newtonsoft.Json.Linq.JEnumerable<global::Newtonsoft.Json.Linq.JToken> Children()
		{
			return new global::Newtonsoft.Json.Linq.JEnumerable<global::Newtonsoft.Json.Linq.JToken>(this.ChildrenTokens);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000288AB File Offset: 0x00026AAB
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public override global::System.Collections.Generic.IEnumerable<T> Values<T>()
		{
			return this.ChildrenTokens.Convert<global::Newtonsoft.Json.Linq.JToken, T>();
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000288B8 File Offset: 0x00026AB8
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> Descendants()
		{
			return this.GetDescendants(false);
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000288C1 File Offset: 0x00026AC1
		public global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> DescendantsAndSelf()
		{
			return this.GetDescendants(true);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x000288CA File Offset: 0x00026ACA
		internal global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> GetDescendants(bool self)
		{
			if (self)
			{
				yield return this;
			}
			foreach (global::Newtonsoft.Json.Linq.JToken o in this.ChildrenTokens)
			{
				yield return o;
				global::Newtonsoft.Json.Linq.JContainer jcontainer = o as global::Newtonsoft.Json.Linq.JContainer;
				if (jcontainer != null)
				{
					foreach (global::Newtonsoft.Json.Linq.JToken jtoken in jcontainer.Descendants())
					{
						yield return jtoken;
					}
					global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator2 = null;
				}
				o = null;
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x000288E1 File Offset: 0x00026AE1
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal bool IsMultiContent([global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] object content)
		{
			return content is global::System.Collections.IEnumerable && !(content is string) && !(content is global::Newtonsoft.Json.Linq.JToken) && !(content is byte[]);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00028909 File Offset: 0x00026B09
		internal global::Newtonsoft.Json.Linq.JToken EnsureParentToken([global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JToken item, bool skipParentCheck)
		{
			if (item == null)
			{
				return global::Newtonsoft.Json.Linq.JValue.CreateNull();
			}
			if (skipParentCheck)
			{
				return item;
			}
			if (item.Parent != null || item == this || (item.HasValues && base.Root == item))
			{
				item = item.CloneToken();
			}
			return item;
		}

		// Token: 0x060009D7 RID: 2519
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal abstract int IndexOfItem(global::Newtonsoft.Json.Linq.JToken item);

		// Token: 0x060009D8 RID: 2520 RVA: 0x00028940 File Offset: 0x00026B40
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal virtual bool InsertItem(int index, global::Newtonsoft.Json.Linq.JToken item, bool skipParentCheck)
		{
			global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> childrenTokens = this.ChildrenTokens;
			if (index > childrenTokens.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("index", "Index must be within the bounds of the List.");
			}
			this.CheckReentrancy();
			item = this.EnsureParentToken(item, skipParentCheck);
			global::Newtonsoft.Json.Linq.JToken jtoken = (index == 0) ? null : childrenTokens[index - 1];
			global::Newtonsoft.Json.Linq.JToken jtoken2 = (index == childrenTokens.Count) ? null : childrenTokens[index];
			this.ValidateToken(item, null);
			item.Parent = this;
			item.Previous = jtoken;
			if (jtoken != null)
			{
				jtoken.Next = item;
			}
			item.Next = jtoken2;
			if (jtoken2 != null)
			{
				jtoken2.Previous = item;
			}
			childrenTokens.Insert(index, item);
			if (this._listChanged != null)
			{
				this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemAdded, index));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
			}
			return true;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00028A08 File Offset: 0x00026C08
		internal virtual void RemoveItemAt(int index)
		{
			global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> childrenTokens = this.ChildrenTokens;
			if (index < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (index >= childrenTokens.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			this.CheckReentrancy();
			global::Newtonsoft.Json.Linq.JToken jtoken = childrenTokens[index];
			global::Newtonsoft.Json.Linq.JToken jtoken2 = (index == 0) ? null : childrenTokens[index - 1];
			global::Newtonsoft.Json.Linq.JToken jtoken3 = (index == childrenTokens.Count - 1) ? null : childrenTokens[index + 1];
			if (jtoken2 != null)
			{
				jtoken2.Next = jtoken3;
			}
			if (jtoken3 != null)
			{
				jtoken3.Previous = jtoken2;
			}
			jtoken.Parent = null;
			jtoken.Previous = null;
			jtoken.Next = null;
			childrenTokens.RemoveAt(index);
			if (this._listChanged != null)
			{
				this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemDeleted, index));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, jtoken, index));
			}
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00028ADC File Offset: 0x00026CDC
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal virtual bool RemoveItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			if (item != null)
			{
				int num = this.IndexOfItem(item);
				if (num >= 0)
				{
					this.RemoveItemAt(num);
					return true;
				}
			}
			return false;
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00028B02 File Offset: 0x00026D02
		internal virtual global::Newtonsoft.Json.Linq.JToken GetItem(int index)
		{
			return this.ChildrenTokens[index];
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00028B10 File Offset: 0x00026D10
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal virtual void SetItem(int index, global::Newtonsoft.Json.Linq.JToken item)
		{
			global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> childrenTokens = this.ChildrenTokens;
			if (index < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("index", "Index is less than 0.");
			}
			if (index >= childrenTokens.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("index", "Index is equal to or greater than Count.");
			}
			global::Newtonsoft.Json.Linq.JToken jtoken = childrenTokens[index];
			if (global::Newtonsoft.Json.Linq.JContainer.IsTokenUnchanged(jtoken, item))
			{
				return;
			}
			this.CheckReentrancy();
			item = this.EnsureParentToken(item, false);
			this.ValidateToken(item, jtoken);
			global::Newtonsoft.Json.Linq.JToken jtoken2 = (index == 0) ? null : childrenTokens[index - 1];
			global::Newtonsoft.Json.Linq.JToken jtoken3 = (index == childrenTokens.Count - 1) ? null : childrenTokens[index + 1];
			item.Parent = this;
			item.Previous = jtoken2;
			if (jtoken2 != null)
			{
				jtoken2.Next = item;
			}
			item.Next = jtoken3;
			if (jtoken3 != null)
			{
				jtoken3.Previous = item;
			}
			childrenTokens[index] = item;
			jtoken.Parent = null;
			jtoken.Previous = null;
			jtoken.Next = null;
			if (this._listChanged != null)
			{
				this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemChanged, index));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace, item, jtoken, index));
			}
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00028C18 File Offset: 0x00026E18
		internal virtual void ClearItems()
		{
			this.CheckReentrancy();
			global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> childrenTokens = this.ChildrenTokens;
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in childrenTokens)
			{
				jtoken.Parent = null;
				jtoken.Previous = null;
				jtoken.Next = null;
			}
			childrenTokens.Clear();
			if (this._listChanged != null)
			{
				this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.Reset, -1));
			}
			if (this._collectionChanged != null)
			{
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x00028CA8 File Offset: 0x00026EA8
		internal virtual void ReplaceItem(global::Newtonsoft.Json.Linq.JToken existing, global::Newtonsoft.Json.Linq.JToken replacement)
		{
			if (existing == null || existing.Parent != this)
			{
				return;
			}
			int index = this.IndexOfItem(existing);
			this.SetItem(index, replacement);
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00028CD2 File Offset: 0x00026ED2
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal virtual bool ContainsItem(global::Newtonsoft.Json.Linq.JToken item)
		{
			return this.IndexOfItem(item) != -1;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00028CE4 File Offset: 0x00026EE4
		internal virtual void CopyItemsTo(global::System.Array array, int arrayIndex)
		{
			if (array == null)
			{
				throw new global::System.ArgumentNullException("array");
			}
			if (arrayIndex < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("arrayIndex", "arrayIndex is less than 0.");
			}
			if (arrayIndex >= array.Length && arrayIndex != 0)
			{
				throw new global::System.ArgumentException("arrayIndex is equal to or greater than the length of array.");
			}
			if (this.Count > array.Length - arrayIndex)
			{
				throw new global::System.ArgumentException("The number of elements in the source JObject is greater than the available space from arrayIndex to the end of the destination array.");
			}
			int num = 0;
			foreach (global::Newtonsoft.Json.Linq.JToken value in this.ChildrenTokens)
			{
				array.SetValue(value, arrayIndex + num);
				num++;
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00028D90 File Offset: 0x00026F90
		internal static bool IsTokenUnchanged(global::Newtonsoft.Json.Linq.JToken currentValue, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JToken newValue)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = currentValue as global::Newtonsoft.Json.Linq.JValue;
			if (jvalue == null)
			{
				return false;
			}
			if (newValue == null)
			{
				return jvalue.Type == global::Newtonsoft.Json.Linq.JTokenType.Null;
			}
			return jvalue.Equals(newValue);
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00028DBE File Offset: 0x00026FBE
		internal virtual void ValidateToken(global::Newtonsoft.Json.Linq.JToken o, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JToken existing)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(o, "o");
			if (o.Type == global::Newtonsoft.Json.Linq.JTokenType.Property)
			{
				throw new global::System.ArgumentException("Can not add {0} to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, o.GetType(), base.GetType()));
			}
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00028DF5 File Offset: 0x00026FF5
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual void Add(object content)
		{
			this.TryAddInternal(this.ChildrenTokens.Count, content, false);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00028E0B File Offset: 0x0002700B
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal bool TryAdd(object content)
		{
			return this.TryAddInternal(this.ChildrenTokens.Count, content, false);
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00028E20 File Offset: 0x00027020
		internal void AddAndSkipParentCheck(global::Newtonsoft.Json.Linq.JToken token)
		{
			this.TryAddInternal(this.ChildrenTokens.Count, token, true);
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00028E36 File Offset: 0x00027036
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public void AddFirst(object content)
		{
			this.TryAddInternal(0, content, false);
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x00028E44 File Offset: 0x00027044
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		internal bool TryAddInternal(int index, object content, bool skipParentCheck)
		{
			if (this.IsMultiContent(content))
			{
				global::System.Collections.IEnumerable enumerable = (global::System.Collections.IEnumerable)content;
				int num = index;
				foreach (object content2 in enumerable)
				{
					this.TryAddInternal(num, content2, skipParentCheck);
					num++;
				}
				return true;
			}
			global::Newtonsoft.Json.Linq.JToken item = global::Newtonsoft.Json.Linq.JContainer.CreateFromContent(content);
			return this.InsertItem(index, item, skipParentCheck);
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00028EC0 File Offset: 0x000270C0
		internal static global::Newtonsoft.Json.Linq.JToken CreateFromContent([global::System.Runtime.CompilerServices.Nullable(2)] object content)
		{
			global::Newtonsoft.Json.Linq.JToken jtoken = content as global::Newtonsoft.Json.Linq.JToken;
			if (jtoken != null)
			{
				return jtoken;
			}
			return new global::Newtonsoft.Json.Linq.JValue(content);
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x00028EDF File Offset: 0x000270DF
		public global::Newtonsoft.Json.JsonWriter CreateWriter()
		{
			return new global::Newtonsoft.Json.Linq.JTokenWriter(this);
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00028EE7 File Offset: 0x000270E7
		public void ReplaceAll(object content)
		{
			this.ClearItems();
			this.Add(content);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00028EF6 File Offset: 0x000270F6
		public void RemoveAll()
		{
			this.ClearItems();
		}

		// Token: 0x060009EC RID: 2540
		internal abstract void MergeItem(object content, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonMergeSettings settings);

		// Token: 0x060009ED RID: 2541 RVA: 0x00028EFE File Offset: 0x000270FE
		public void Merge(object content)
		{
			this.MergeItem(content, null);
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00028F08 File Offset: 0x00027108
		public void Merge(object content, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonMergeSettings settings)
		{
			this.MergeItem(content, settings);
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00028F14 File Offset: 0x00027114
		internal void ReadTokenFrom(global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings options)
		{
			int depth = reader.Depth;
			if (!reader.Read())
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Error reading {0} from JsonReader.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType().Name));
			}
			this.ReadContentFrom(reader, options);
			if (reader.Depth > depth)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(reader, "Unexpected end of content while loading {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType().Name));
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00028F84 File Offset: 0x00027184
		internal void ReadContentFrom(global::Newtonsoft.Json.JsonReader r, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonLoadSettings settings)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(r, "r");
			global::Newtonsoft.Json.IJsonLineInfo lineInfo = r as global::Newtonsoft.Json.IJsonLineInfo;
			global::Newtonsoft.Json.Linq.JContainer jcontainer = this;
			for (;;)
			{
				global::Newtonsoft.Json.Linq.JProperty jproperty = jcontainer as global::Newtonsoft.Json.Linq.JProperty;
				if (jproperty != null && jproperty.Value != null)
				{
					if (jcontainer == this)
					{
						break;
					}
					jcontainer = jcontainer.Parent;
				}
				switch (r.TokenType)
				{
				case global::Newtonsoft.Json.JsonToken.None:
					goto IL_1F2;
				case global::Newtonsoft.Json.JsonToken.StartObject:
				{
					global::Newtonsoft.Json.Linq.JObject jobject = new global::Newtonsoft.Json.Linq.JObject();
					jobject.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jobject);
					jcontainer = jobject;
					goto IL_1F2;
				}
				case global::Newtonsoft.Json.JsonToken.StartArray:
				{
					global::Newtonsoft.Json.Linq.JArray jarray = new global::Newtonsoft.Json.Linq.JArray();
					jarray.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jarray);
					jcontainer = jarray;
					goto IL_1F2;
				}
				case global::Newtonsoft.Json.JsonToken.StartConstructor:
				{
					global::Newtonsoft.Json.Linq.JConstructor jconstructor = new global::Newtonsoft.Json.Linq.JConstructor(r.Value.ToString());
					jconstructor.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jconstructor);
					jcontainer = jconstructor;
					goto IL_1F2;
				}
				case global::Newtonsoft.Json.JsonToken.PropertyName:
				{
					global::Newtonsoft.Json.Linq.JProperty jproperty2 = global::Newtonsoft.Json.Linq.JContainer.ReadProperty(r, settings, lineInfo, jcontainer);
					if (jproperty2 != null)
					{
						jcontainer = jproperty2;
						goto IL_1F2;
					}
					r.Skip();
					goto IL_1F2;
				}
				case global::Newtonsoft.Json.JsonToken.Comment:
					if (settings != null && settings.CommentHandling == global::Newtonsoft.Json.Linq.CommentHandling.Load)
					{
						global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JValue.CreateComment(r.Value.ToString());
						jvalue.SetLineInfo(lineInfo, settings);
						jcontainer.Add(jvalue);
						goto IL_1F2;
					}
					goto IL_1F2;
				case global::Newtonsoft.Json.JsonToken.Integer:
				case global::Newtonsoft.Json.JsonToken.Float:
				case global::Newtonsoft.Json.JsonToken.String:
				case global::Newtonsoft.Json.JsonToken.Boolean:
				case global::Newtonsoft.Json.JsonToken.Date:
				case global::Newtonsoft.Json.JsonToken.Bytes:
				{
					global::Newtonsoft.Json.Linq.JValue jvalue = new global::Newtonsoft.Json.Linq.JValue(r.Value);
					jvalue.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jvalue);
					goto IL_1F2;
				}
				case global::Newtonsoft.Json.JsonToken.Null:
				{
					global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JValue.CreateNull();
					jvalue.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jvalue);
					goto IL_1F2;
				}
				case global::Newtonsoft.Json.JsonToken.Undefined:
				{
					global::Newtonsoft.Json.Linq.JValue jvalue = global::Newtonsoft.Json.Linq.JValue.CreateUndefined();
					jvalue.SetLineInfo(lineInfo, settings);
					jcontainer.Add(jvalue);
					goto IL_1F2;
				}
				case global::Newtonsoft.Json.JsonToken.EndObject:
					if (jcontainer == this)
					{
						return;
					}
					jcontainer = jcontainer.Parent;
					goto IL_1F2;
				case global::Newtonsoft.Json.JsonToken.EndArray:
					if (jcontainer == this)
					{
						return;
					}
					jcontainer = jcontainer.Parent;
					goto IL_1F2;
				case global::Newtonsoft.Json.JsonToken.EndConstructor:
					if (jcontainer == this)
					{
						return;
					}
					jcontainer = jcontainer.Parent;
					goto IL_1F2;
				}
				goto Block_4;
				IL_1F2:
				if (!r.Read())
				{
					return;
				}
			}
			return;
			Block_4:
			throw new global::System.InvalidOperationException("The JsonReader should not be on a token of type {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, r.TokenType));
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00029190 File Offset: 0x00027390
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private static global::Newtonsoft.Json.Linq.JProperty ReadProperty([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader r, global::Newtonsoft.Json.Linq.JsonLoadSettings settings, global::Newtonsoft.Json.IJsonLineInfo lineInfo, [global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Linq.JContainer parent)
		{
			global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling duplicatePropertyNameHandling = (settings != null) ? settings.DuplicatePropertyNameHandling : global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling.Replace;
			global::Newtonsoft.Json.Linq.JObject jobject = (global::Newtonsoft.Json.Linq.JObject)parent;
			string text = r.Value.ToString();
			global::Newtonsoft.Json.Linq.JProperty jproperty = jobject.Property(text, global::System.StringComparison.Ordinal);
			if (jproperty != null)
			{
				if (duplicatePropertyNameHandling == global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling.Ignore)
				{
					return null;
				}
				if (duplicatePropertyNameHandling == global::Newtonsoft.Json.Linq.DuplicatePropertyNameHandling.Error)
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(r, "Property with the name '{0}' already exists in the current JSON object.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text));
				}
			}
			global::Newtonsoft.Json.Linq.JProperty jproperty2 = new global::Newtonsoft.Json.Linq.JProperty(text);
			jproperty2.SetLineInfo(lineInfo, settings);
			if (jproperty == null)
			{
				parent.Add(jproperty2);
			}
			else
			{
				jproperty.Replace(jproperty2);
			}
			return jproperty2;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002920C File Offset: 0x0002740C
		internal int ContentsHashCode()
		{
			int num = 0;
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in this.ChildrenTokens)
			{
				num ^= jtoken.GetDeepHashCode();
			}
			return num;
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x00029260 File Offset: 0x00027460
		string global::System.ComponentModel.ITypedList.GetListName(global::System.ComponentModel.PropertyDescriptor[] listAccessors)
		{
			return string.Empty;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00029267 File Offset: 0x00027467
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		global::System.ComponentModel.PropertyDescriptorCollection global::System.ComponentModel.ITypedList.GetItemProperties(global::System.ComponentModel.PropertyDescriptor[] listAccessors)
		{
			global::System.ComponentModel.ICustomTypeDescriptor customTypeDescriptor = this.First as global::System.ComponentModel.ICustomTypeDescriptor;
			if (customTypeDescriptor == null)
			{
				return null;
			}
			return customTypeDescriptor.GetProperties();
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002927F File Offset: 0x0002747F
		int global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken>.IndexOf(global::Newtonsoft.Json.Linq.JToken item)
		{
			return this.IndexOfItem(item);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00029288 File Offset: 0x00027488
		void global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken>.Insert(int index, global::Newtonsoft.Json.Linq.JToken item)
		{
			this.InsertItem(index, item, false);
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00029294 File Offset: 0x00027494
		void global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken>.RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x170001C8 RID: 456
		global::Newtonsoft.Json.Linq.JToken global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken>.this[int index]
		{
			get
			{
				return this.GetItem(index);
			}
			set
			{
				this.SetItem(index, value);
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000292B0 File Offset: 0x000274B0
		void global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>.Add(global::Newtonsoft.Json.Linq.JToken item)
		{
			this.Add(item);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000292B9 File Offset: 0x000274B9
		void global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000292C1 File Offset: 0x000274C1
		bool global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>.Contains(global::Newtonsoft.Json.Linq.JToken item)
		{
			return this.ContainsItem(item);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x000292CA File Offset: 0x000274CA
		void global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>.CopyTo(global::Newtonsoft.Json.Linq.JToken[] array, int arrayIndex)
		{
			this.CopyItemsTo(array, arrayIndex);
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x000292D4 File Offset: 0x000274D4
		bool global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x000292D7 File Offset: 0x000274D7
		bool global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>.Remove(global::Newtonsoft.Json.Linq.JToken item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x000292E0 File Offset: 0x000274E0
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Linq.JToken EnsureValue(object value)
		{
			if (value == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Linq.JToken jtoken = value as global::Newtonsoft.Json.Linq.JToken;
			if (jtoken != null)
			{
				return jtoken;
			}
			throw new global::System.ArgumentException("Argument is not a JToken.");
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00029308 File Offset: 0x00027508
		int global::System.Collections.IList.Add(object value)
		{
			this.Add(this.EnsureValue(value));
			return this.Count - 1;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0002931F File Offset: 0x0002751F
		void global::System.Collections.IList.Clear()
		{
			this.ClearItems();
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00029327 File Offset: 0x00027527
		bool global::System.Collections.IList.Contains(object value)
		{
			return this.ContainsItem(this.EnsureValue(value));
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00029336 File Offset: 0x00027536
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this.IndexOfItem(this.EnsureValue(value));
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00029345 File Offset: 0x00027545
		void global::System.Collections.IList.Insert(int index, object value)
		{
			this.InsertItem(index, this.EnsureValue(value), false);
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00029357 File Offset: 0x00027557
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A07 RID: 2567 RVA: 0x0002935A File Offset: 0x0002755A
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002935D File Offset: 0x0002755D
		void global::System.Collections.IList.Remove(object value)
		{
			this.RemoveItem(this.EnsureValue(value));
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002936D File Offset: 0x0002756D
		void global::System.Collections.IList.RemoveAt(int index)
		{
			this.RemoveItemAt(index);
		}

		// Token: 0x170001CC RID: 460
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this.GetItem(index);
			}
			set
			{
				this.SetItem(index, this.EnsureValue(value));
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002938F File Offset: 0x0002758F
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.CopyItemsTo(array, index);
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A0D RID: 2573 RVA: 0x00029399 File Offset: 0x00027599
		public int Count
		{
			get
			{
				return this.ChildrenTokens.Count;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x000293A6 File Offset: 0x000275A6
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x000293A9 File Offset: 0x000275A9
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				if (this._syncRoot == null)
				{
					global::System.Threading.Interlocked.CompareExchange(ref this._syncRoot, new object(), null);
				}
				return this._syncRoot;
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x000293CB File Offset: 0x000275CB
		void global::System.ComponentModel.IBindingList.AddIndex(global::System.ComponentModel.PropertyDescriptor property)
		{
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x000293D0 File Offset: 0x000275D0
		object global::System.ComponentModel.IBindingList.AddNew()
		{
			global::System.ComponentModel.AddingNewEventArgs addingNewEventArgs = new global::System.ComponentModel.AddingNewEventArgs();
			this.OnAddingNew(addingNewEventArgs);
			if (addingNewEventArgs.NewObject == null)
			{
				throw new global::Newtonsoft.Json.JsonException("Could not determine new value to add to '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.GetType()));
			}
			global::Newtonsoft.Json.Linq.JToken jtoken = addingNewEventArgs.NewObject as global::Newtonsoft.Json.Linq.JToken;
			if (jtoken == null)
			{
				throw new global::Newtonsoft.Json.JsonException("New item to be added to collection must be compatible with {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeof(global::Newtonsoft.Json.Linq.JToken)));
			}
			this.Add(jtoken);
			return jtoken;
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00029443 File Offset: 0x00027643
		bool global::System.ComponentModel.IBindingList.AllowEdit
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00029446 File Offset: 0x00027646
		bool global::System.ComponentModel.IBindingList.AllowNew
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00029449 File Offset: 0x00027649
		bool global::System.ComponentModel.IBindingList.AllowRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002944C File Offset: 0x0002764C
		void global::System.ComponentModel.IBindingList.ApplySort(global::System.ComponentModel.PropertyDescriptor property, global::System.ComponentModel.ListSortDirection direction)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00029453 File Offset: 0x00027653
		int global::System.ComponentModel.IBindingList.Find(global::System.ComponentModel.PropertyDescriptor property, object key)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0002945A File Offset: 0x0002765A
		bool global::System.ComponentModel.IBindingList.IsSorted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002945D File Offset: 0x0002765D
		void global::System.ComponentModel.IBindingList.RemoveIndex(global::System.ComponentModel.PropertyDescriptor property)
		{
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0002945F File Offset: 0x0002765F
		void global::System.ComponentModel.IBindingList.RemoveSort()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00029466 File Offset: 0x00027666
		global::System.ComponentModel.ListSortDirection global::System.ComponentModel.IBindingList.SortDirection
		{
			get
			{
				return global::System.ComponentModel.ListSortDirection.Ascending;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00029469 File Offset: 0x00027669
		[global::System.Runtime.CompilerServices.Nullable(2)]
		global::System.ComponentModel.PropertyDescriptor global::System.ComponentModel.IBindingList.SortProperty
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0002946C File Offset: 0x0002766C
		bool global::System.ComponentModel.IBindingList.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x0002946F File Offset: 0x0002766F
		bool global::System.ComponentModel.IBindingList.SupportsSearching
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00029472 File Offset: 0x00027672
		bool global::System.ComponentModel.IBindingList.SupportsSorting
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x00029478 File Offset: 0x00027678
		internal static void MergeEnumerableContent(global::Newtonsoft.Json.Linq.JContainer target, global::System.Collections.IEnumerable content, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonMergeSettings settings)
		{
			switch ((settings != null) ? settings.MergeArrayHandling : global::Newtonsoft.Json.Linq.MergeArrayHandling.Concat)
			{
			case global::Newtonsoft.Json.Linq.MergeArrayHandling.Concat:
				using (global::System.Collections.IEnumerator enumerator = content.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Newtonsoft.Json.Linq.JToken content2 = (global::Newtonsoft.Json.Linq.JToken)obj;
						target.Add(content2);
					}
					return;
				}
				break;
			case global::Newtonsoft.Json.Linq.MergeArrayHandling.Union:
				break;
			case global::Newtonsoft.Json.Linq.MergeArrayHandling.Replace:
				goto IL_BC;
			case global::Newtonsoft.Json.Linq.MergeArrayHandling.Merge:
				goto IL_108;
			default:
				goto IL_199;
			}
			global::System.Collections.Generic.HashSet<global::Newtonsoft.Json.Linq.JToken> hashSet = new global::System.Collections.Generic.HashSet<global::Newtonsoft.Json.Linq.JToken>(target, global::Newtonsoft.Json.Linq.JToken.EqualityComparer);
			using (global::System.Collections.IEnumerator enumerator = content.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj2 = enumerator.Current;
					global::Newtonsoft.Json.Linq.JToken jtoken = (global::Newtonsoft.Json.Linq.JToken)obj2;
					if (hashSet.Add(jtoken))
					{
						target.Add(jtoken);
					}
				}
				return;
			}
			IL_BC:
			if (target == content)
			{
				return;
			}
			target.ClearItems();
			using (global::System.Collections.IEnumerator enumerator = content.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj3 = enumerator.Current;
					global::Newtonsoft.Json.Linq.JToken content3 = (global::Newtonsoft.Json.Linq.JToken)obj3;
					target.Add(content3);
				}
				return;
			}
			IL_108:
			int num = 0;
			using (global::System.Collections.IEnumerator enumerator = content.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					object obj4 = enumerator.Current;
					if (num < target.Count)
					{
						global::Newtonsoft.Json.Linq.JContainer jcontainer = target[num] as global::Newtonsoft.Json.Linq.JContainer;
						if (jcontainer != null)
						{
							jcontainer.Merge(obj4, settings);
						}
						else if (obj4 != null)
						{
							global::Newtonsoft.Json.Linq.JToken jtoken2 = global::Newtonsoft.Json.Linq.JContainer.CreateFromContent(obj4);
							if (jtoken2.Type != global::Newtonsoft.Json.Linq.JTokenType.Null)
							{
								target[num] = jtoken2;
							}
						}
					}
					else
					{
						target.Add(obj4);
					}
					num++;
				}
				return;
			}
			IL_199:
			throw new global::System.ArgumentOutOfRangeException("settings", "Unexpected merge array handling when merging JSON.");
		}

		// Token: 0x04000361 RID: 865
		[global::System.Runtime.CompilerServices.Nullable(2)]
		internal global::System.ComponentModel.ListChangedEventHandler _listChanged;

		// Token: 0x04000362 RID: 866
		[global::System.Runtime.CompilerServices.Nullable(2)]
		internal global::System.ComponentModel.AddingNewEventHandler _addingNew;

		// Token: 0x04000363 RID: 867
		[global::System.Runtime.CompilerServices.Nullable(2)]
		internal global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChanged;

		// Token: 0x04000364 RID: 868
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private object _syncRoot;

		// Token: 0x04000365 RID: 869
		private bool _busy;
	}
}
