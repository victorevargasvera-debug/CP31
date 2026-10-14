using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gibraltar
{
	// Token: 0x02000165 RID: 357
	internal class ListChangeBuffer<T>
	{
		// Token: 0x06000ED7 RID: 3799 RVA: 0x000262FC File Offset: 0x000244FC
		public ListChangeBuffer(global::Gibraltar.FilteredBindingList<T> input, global::Gibraltar.FilteredBindingList<T> output, bool queueingEnabled = true)
		{
			this.m_Input = input;
			this.m_Output = output;
			this.QueueingEnabled = queueingEnabled;
			this.m_EventQueue = new global::System.Collections.Generic.Queue<global::System.ComponentModel.ListChangedEventArgs>();
			this.m_Input.ListChanged += this.InputChangeHandler;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x0002633C File Offset: 0x0002453C
		// (set) Token: 0x06000ED9 RID: 3801 RVA: 0x00026344 File Offset: 0x00024544
		public bool QueueingEnabled { get; set; }

		// Token: 0x06000EDA RID: 3802 RVA: 0x00026350 File Offset: 0x00024550
		public void ProcessEvents()
		{
			if (this.m_NeedsReset || this.m_EventQueue.Count > 0)
			{
				try
				{
					if (this.m_NeedsReset || this.m_AddCount + this.m_ChangeCount + this.m_DeleteCount >= 50)
					{
						this.ProcessResetEvent();
					}
					else
					{
						this.ProcessPendingEvents();
					}
				}
				catch (global::System.Exception obj)
				{
					global::System.GC.KeepAlive(obj);
				}
				finally
				{
					this.m_NeedsReset = false;
					this.m_AddCount = 0;
					this.m_ChangeCount = 0;
					this.m_DeleteCount = 0;
				}
			}
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000263FC File Offset: 0x000245FC
		private void InputChangeHandler(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			if (!this.QueueingEnabled)
			{
				this.m_Output.SendListChanged(e);
				return;
			}
			if (this.m_NeedsReset)
			{
				return;
			}
			switch (e.ListChangedType)
			{
			case global::System.ComponentModel.ListChangedType.Reset:
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorAdded:
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorDeleted:
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorChanged:
				this.m_NeedsReset = true;
				this.m_EventQueue.Clear();
				return;
			case global::System.ComponentModel.ListChangedType.ItemAdded:
				this.m_EventQueue.Enqueue(new global::Gibraltar.ListChangedEventArgsItemAdded<T>(this.m_Input[e.NewIndex], e.NewIndex));
				this.m_AddCount++;
				break;
			case global::System.ComponentModel.ListChangedType.ItemDeleted:
				if (e is global::Gibraltar.ListChangedEventArgsItemDeleted<T>)
				{
					this.m_EventQueue.Enqueue(e);
					this.m_DeleteCount++;
				}
				break;
			case global::System.ComponentModel.ListChangedType.ItemMoved:
				throw new global::System.NotImplementedException("ListChangedType.ItemMoved is not supported");
			case global::System.ComponentModel.ListChangedType.ItemChanged:
				this.m_EventQueue.Enqueue(e);
				this.m_ChangeCount++;
				break;
			}
			if (this.m_EventQueue.Count > 50)
			{
				this.m_NeedsReset = true;
				this.m_EventQueue.Clear();
			}
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00026528 File Offset: 0x00024728
		private void ProcessResetEvent()
		{
			bool flag = false;
			if (this.m_Input.Count == this.m_Output.Count && this.m_ChangeCount == 0)
			{
				for (int i = 0; i < this.m_Input.Count; i++)
				{
					if (this.m_Input[i] != this.m_Output[i])
					{
						flag = true;
						break;
					}
				}
			}
			else
			{
				flag = true;
			}
			if (flag)
			{
				this.m_Output.RaiseListChangedEvents = false;
				try
				{
					this.m_Output.Clear();
					foreach (T item in this.m_Input)
					{
						this.m_Output.Add(item);
					}
				}
				finally
				{
					this.m_Output.RaiseListChangedEvents = true;
					this.m_Output.ResetBindings();
				}
			}
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0002663C File Offset: 0x0002483C
		private void ProcessPendingEvents()
		{
			foreach (global::System.ComponentModel.ListChangedEventArgs listChangedEventArgs in this.m_EventQueue)
			{
				switch (listChangedEventArgs.ListChangedType)
				{
				case global::System.ComponentModel.ListChangedType.ItemAdded:
					this.m_Output.Add(((global::Gibraltar.ListChangedEventArgsItemAdded<T>)listChangedEventArgs).Item);
					break;
				case global::System.ComponentModel.ListChangedType.ItemDeleted:
				{
					T item = ((global::Gibraltar.ListChangedEventArgsItemDeleted<T>)listChangedEventArgs).Item;
					int num = this.m_Output.IndexOf(item);
					if (num >= 0)
					{
						this.m_Output.RemoveAt(num);
					}
					break;
				}
				case global::System.ComponentModel.ListChangedType.ItemChanged:
					this.m_Output.ResetItem(listChangedEventArgs.NewIndex);
					break;
				}
			}
			this.m_EventQueue.Clear();
		}

		// Token: 0x040004EF RID: 1263
		private readonly global::Gibraltar.FilteredBindingList<T> m_Input;

		// Token: 0x040004F0 RID: 1264
		private readonly global::Gibraltar.FilteredBindingList<T> m_Output;

		// Token: 0x040004F1 RID: 1265
		private readonly global::System.Collections.Generic.Queue<global::System.ComponentModel.ListChangedEventArgs> m_EventQueue;

		// Token: 0x040004F2 RID: 1266
		private bool m_NeedsReset;

		// Token: 0x040004F3 RID: 1267
		private int m_AddCount;

		// Token: 0x040004F4 RID: 1268
		private int m_ChangeCount;

		// Token: 0x040004F5 RID: 1269
		private int m_DeleteCount;

		// Token: 0x040004F6 RID: 1270
		private const int ResetEventThreshold = 50;
	}
}
