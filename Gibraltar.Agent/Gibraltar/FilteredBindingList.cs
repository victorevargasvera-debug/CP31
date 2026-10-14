using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace Gibraltar
{
	// Token: 0x02000161 RID: 353
	internal abstract class FilteredBindingList<T> : global::Gibraltar.BindingListEx<T>, global::System.IDisposable
	{
		// Token: 0x06000EB9 RID: 3769 RVA: 0x00025BF8 File Offset: 0x00023DF8
		protected FilteredBindingList(global::Gibraltar.BindingListEx<T> dataSource, global::System.Predicate<T> filter, bool getUpdates, params object[] args)
		{
			this.Filter = filter;
			this.m_DataSource = dataSource;
			this.m_Args = args;
			base.AllowNew = false;
			base.AllowEdit = (this.m_DataSource == null || this.m_DataSource.AllowEdit);
			base.AllowRemove = (this.m_DataSource == null || this.m_DataSource.AllowRemove);
			if (this.m_DataSource != null)
			{
				this.Reset();
				if (getUpdates)
				{
					this.m_DataSource.BeginUpdate += this.SourceBeginUpdate;
					this.m_DataSource.ListChanged += this.SourceListChanged;
					this.m_DataSource.EndUpdate += this.SourceEndUpdate;
				}
			}
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x00025CD8 File Offset: 0x00023ED8
		public global::Gibraltar.FilteredBindingList<T> Clone(global::System.Predicate<T> filter = null)
		{
			return this.CreateChildList(filter, true);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00025CE4 File Offset: 0x00023EE4
		public global::Gibraltar.FilteredBindingList<T> Find(global::System.Predicate<T> filter)
		{
			return this.CreateChildList(filter, false);
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00025CF0 File Offset: 0x00023EF0
		private global::Gibraltar.FilteredBindingList<T> CreateChildList(global::System.Predicate<T> filter, bool getUpdates)
		{
			global::System.Type[] types = new global::System.Type[]
			{
				base.GetType(),
				typeof(global::System.Predicate<T>),
				typeof(bool),
				this.m_Args.GetType()
			};
			object[] parameters = new object[]
			{
				this,
				filter,
				getUpdates,
				this.m_Args
			};
			return (global::Gibraltar.FilteredBindingList<T>)base.GetType().GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, types, null).Invoke(parameters);
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00025D78 File Offset: 0x00023F78
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x00025D80 File Offset: 0x00023F80
		public global::System.Predicate<T> Filter
		{
			get
			{
				return this.m_Filter;
			}
			set
			{
				if (value == null)
				{
					value = ((T item) => true);
				}
				this.m_Filter = value;
				if (this.m_DataSource == null)
				{
					return;
				}
				this.Reset();
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00025DD4 File Offset: 0x00023FD4
		public void Register(global::Gibraltar.IBindingListListener<T> listener)
		{
			this.m_Listeners.Add(listener);
			this.ResetOne(listener);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00025DEC File Offset: 0x00023FEC
		public void UnRegister(global::Gibraltar.IBindingListListener<T> listener)
		{
			this.m_Listeners.Remove(listener);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00025DFC File Offset: 0x00023FFC
		public void SendListChanged(global::System.ComponentModel.ListChangedEventArgs e)
		{
			base.OnListChanged(e);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00025E08 File Offset: 0x00024008
		public void Dispose()
		{
			if (this.m_DataSource != null)
			{
				this.m_DataSource.BeginUpdate -= this.SourceBeginUpdate;
				this.m_DataSource.ListChanged -= this.SourceListChanged;
				this.m_DataSource.EndUpdate -= this.SourceEndUpdate;
			}
			this.m_Filter = null;
			this.m_Listeners.Clear();
			base.RaiseListChangedEvents = false;
			base.Clear();
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00025E88 File Offset: 0x00024088
		private void SourceBeginUpdate(object sender, global::System.EventArgs e)
		{
			this.OnBeginUpdate(e);
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00025E94 File Offset: 0x00024094
		private void SourceEndUpdate(object sender, global::System.EventArgs e)
		{
			this.OnEndUpdate(e);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00025EA0 File Offset: 0x000240A0
		private void SourceListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			if (!base.RaiseListChangedEvents)
			{
				return;
			}
			switch (e.ListChangedType)
			{
			case global::System.ComponentModel.ListChangedType.Reset:
				this.Reset();
				return;
			case global::System.ComponentModel.ListChangedType.ItemAdded:
				this.AddItem(e);
				return;
			case global::System.ComponentModel.ListChangedType.ItemDeleted:
				this.DeleteItem(e);
				return;
			case global::System.ComponentModel.ListChangedType.ItemMoved:
				this.MoveItem(e.OldIndex, e.NewIndex);
				return;
			case global::System.ComponentModel.ListChangedType.ItemChanged:
				this.ChangeItem(e.NewIndex);
				return;
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorAdded:
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorDeleted:
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorChanged:
				this.OnListChanged(e);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00025F2C File Offset: 0x0002412C
		private void Reset()
		{
			bool raiseListChangedEvents = base.RaiseListChangedEvents;
			base.RaiseListChangedEvents = false;
			this.OnBeginUpdate(new global::System.EventArgs());
			try
			{
				base.Clear();
				global::Gibraltar.IBindingListListener<T>[] array = this.m_Listeners.ToArray();
				foreach (global::Gibraltar.IBindingListListener<T> bindingListListener in array)
				{
					bindingListListener.BeginUpdate();
					bindingListListener.Reset();
				}
				global::Gibraltar.IBindingListListener<T>[] array2;
				foreach (T t in this.m_DataSource)
				{
					if (this.m_Filter(t))
					{
						array2 = array;
						for (int i = 0; i < array2.Length; i++)
						{
							array2[i].Add(t);
						}
						base.Add(t);
					}
				}
				array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].EndUpdate();
				}
			}
			finally
			{
				base.RaiseListChangedEvents = raiseListChangedEvents;
				base.ResetBindings();
				this.OnEndUpdate(new global::System.EventArgs());
			}
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00026058 File Offset: 0x00024258
		private void ResetOne(global::Gibraltar.IBindingListListener<T> listener)
		{
			listener.BeginUpdate();
			listener.Reset();
			foreach (T item in this)
			{
				listener.Add(item);
			}
			listener.EndUpdate();
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x000260BC File Offset: 0x000242BC
		private void AddItem(global::System.ComponentModel.ListChangedEventArgs e)
		{
			T t = this.m_DataSource[e.NewIndex];
			if (this.m_Filter(t))
			{
				foreach (global::Gibraltar.IBindingListListener<T> bindingListListener in this.m_Listeners)
				{
					bindingListListener.BeginUpdate();
					bindingListListener.Add(t);
					bindingListListener.EndUpdate();
				}
				base.Add(t);
			}
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x0002614C File Offset: 0x0002434C
		private void ChangeItem(int upstreamIndex)
		{
			T t = this.m_DataSource[upstreamIndex];
			int num = base.IndexOf(t);
			bool flag = num >= 0;
			if (this.m_Filter(t))
			{
				foreach (global::Gibraltar.IBindingListListener<T> bindingListListener in this.m_Listeners)
				{
					bindingListListener.BeginUpdate();
					bindingListListener.Change(t);
					bindingListListener.EndUpdate();
				}
				if (flag)
				{
					global::System.ComponentModel.ListChangedEventArgs e = new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemChanged, num);
					this.OnListChanged(e);
					return;
				}
				base.Add(t);
				return;
			}
			else
			{
				if (flag)
				{
					foreach (global::Gibraltar.IBindingListListener<T> bindingListListener2 in this.m_Listeners)
					{
						bindingListListener2.BeginUpdate();
						bindingListListener2.Remove(t);
						bindingListListener2.EndUpdate();
					}
					base.RemoveAt(num);
					return;
				}
				return;
			}
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00026260 File Offset: 0x00024460
		private void DeleteItem(global::System.ComponentModel.ListChangedEventArgs e)
		{
			if (e is global::Gibraltar.ListChangedEventArgsItemDeleted<T>)
			{
				T item = ((global::Gibraltar.ListChangedEventArgsItemDeleted<T>)e).Item;
				int num = base.IndexOf(item);
				if (num >= 0)
				{
					foreach (global::Gibraltar.IBindingListListener<T> bindingListListener in this.m_Listeners)
					{
						bindingListListener.BeginUpdate();
						bindingListListener.Remove(item);
						bindingListListener.EndUpdate();
					}
					this.RemoveItem(num);
				}
			}
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000262F0 File Offset: 0x000244F0
		private void MoveItem(int oldIndex, int newIndex)
		{
			throw new global::System.NotImplementedException("ItemMoved event is not supported by FilteredBindingList");
		}

		// Token: 0x040004EB RID: 1259
		private readonly global::System.Collections.Generic.List<global::Gibraltar.IBindingListListener<T>> m_Listeners = new global::System.Collections.Generic.List<global::Gibraltar.IBindingListListener<T>>();

		// Token: 0x040004EC RID: 1260
		private readonly global::Gibraltar.BindingListEx<T> m_DataSource;

		// Token: 0x040004ED RID: 1261
		private readonly object[] m_Args;

		// Token: 0x040004EE RID: 1262
		private global::System.Predicate<T> m_Filter;
	}
}
