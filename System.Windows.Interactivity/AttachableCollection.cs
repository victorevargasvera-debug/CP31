using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;

namespace System.Windows.Interactivity
{
	// Token: 0x02000003 RID: 3
	public abstract class AttachableCollection<T> : global::System.Windows.FreezableCollection<T>, global::System.Windows.Interactivity.IAttachedObject where T : global::System.Windows.DependencyObject, global::System.Windows.Interactivity.IAttachedObject
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000020D0 File Offset: 0x000002D0
		protected global::System.Windows.DependencyObject AssociatedObject
		{
			get
			{
				base.ReadPreamble();
				return this.associatedObject;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020E0 File Offset: 0x000002E0
		internal AttachableCollection()
		{
			((global::System.Collections.Specialized.INotifyCollectionChanged)this).CollectionChanged += this.OnCollectionChanged;
			this.snapshot = new global::System.Collections.ObjectModel.Collection<T>();
		}

		// Token: 0x06000006 RID: 6
		protected abstract void OnAttached();

		// Token: 0x06000007 RID: 7
		protected abstract void OnDetaching();

		// Token: 0x06000008 RID: 8
		internal abstract void ItemAdded(T item);

		// Token: 0x06000009 RID: 9
		internal abstract void ItemRemoved(T item);

		// Token: 0x0600000A RID: 10 RVA: 0x00002114 File Offset: 0x00000314
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void VerifySnapshotIntegrity()
		{
			bool flag = base.Count == this.snapshot.Count;
			if (flag)
			{
				for (int i = 0; i < base.Count; i++)
				{
					if (base[i] != this.snapshot[i])
					{
						return;
					}
				}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000216C File Offset: 0x0000036C
		private void VerifyAdd(T item)
		{
			if (this.snapshot.Contains(item))
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::ExceptionStringTable.DuplicateItemInCollectionExceptionMessage, new object[]
				{
					typeof(T).Name,
					base.GetType().Name
				}));
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021C4 File Offset: 0x000003C4
		private void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						T t = (T)((object)obj);
						try
						{
							this.VerifyAdd(t);
							this.ItemAdded(t);
						}
						finally
						{
							this.snapshot.Insert(base.IndexOf(t), t);
						}
					}
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				goto IL_13A;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				goto IL_18D;
			default:
				return;
			}
			foreach (object obj2 in e.OldItems)
			{
				T item = (T)((object)obj2);
				this.ItemRemoved(item);
				this.snapshot.Remove(item);
			}
			using (global::System.Collections.IEnumerator enumerator3 = e.NewItems.GetEnumerator())
			{
				while (enumerator3.MoveNext())
				{
					object obj3 = enumerator3.Current;
					T t2 = (T)((object)obj3);
					try
					{
						this.VerifyAdd(t2);
						this.ItemAdded(t2);
					}
					finally
					{
						this.snapshot.Insert(base.IndexOf(t2), t2);
					}
				}
				return;
			}
			IL_13A:
			using (global::System.Collections.IEnumerator enumerator4 = e.OldItems.GetEnumerator())
			{
				while (enumerator4.MoveNext())
				{
					object obj4 = enumerator4.Current;
					T item2 = (T)((object)obj4);
					this.ItemRemoved(item2);
					this.snapshot.Remove(item2);
				}
				return;
			}
			IL_18D:
			foreach (T item3 in this.snapshot)
			{
				this.ItemRemoved(item3);
			}
			this.snapshot = new global::System.Collections.ObjectModel.Collection<T>();
			foreach (T item4 in this)
			{
				this.VerifyAdd(item4);
				this.ItemAdded(item4);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002440 File Offset: 0x00000640
		global::System.Windows.DependencyObject global::System.Windows.Interactivity.IAttachedObject.AssociatedObject
		{
			get
			{
				return this.AssociatedObject;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002448 File Offset: 0x00000648
		public void Attach(global::System.Windows.DependencyObject dependencyObject)
		{
			if (dependencyObject != this.AssociatedObject)
			{
				if (this.AssociatedObject != null)
				{
					throw new global::System.InvalidOperationException();
				}
				if (global::System.Windows.Interactivity.Interaction.ShouldRunInDesignMode || !(bool)base.GetValue(global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty))
				{
					base.WritePreamble();
					this.associatedObject = dependencyObject;
					base.WritePostscript();
				}
				this.OnAttached();
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000249E File Offset: 0x0000069E
		public void Detach()
		{
			this.OnDetaching();
			base.WritePreamble();
			this.associatedObject = null;
			base.WritePostscript();
		}

		// Token: 0x04000001 RID: 1
		private global::System.Collections.ObjectModel.Collection<T> snapshot;

		// Token: 0x04000002 RID: 2
		private global::System.Windows.DependencyObject associatedObject;
	}
}
