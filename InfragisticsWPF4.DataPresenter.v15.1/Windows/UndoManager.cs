using System;
using System.Collections.Generic;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows
{
	// Token: 0x02000097 RID: 151
	internal class UndoManager : global::Infragistics.Windows.Helpers.ActionHistory
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x0001E897 File Offset: 0x0001CA97
		public UndoManager() : this(0)
		{
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001E8A0 File Offset: 0x0001CAA0
		public UndoManager(int undoLimit)
		{
			this._undoLimit = undoLimit;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x0001E8AF File Offset: 0x0001CAAF
		protected sealed override object RedoContext
		{
			get
			{
				return global::Infragistics.Windows.UndoManager.RedoContextId;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0001E8B6 File Offset: 0x0001CAB6
		protected sealed override object UndoContext
		{
			get
			{
				return global::Infragistics.Windows.UndoManager.UndoContextId;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x0001E8BD File Offset: 0x0001CABD
		protected override int MaxUndoDepth
		{
			get
			{
				return this.UndoLimit;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0001E8C5 File Offset: 0x0001CAC5
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x0001E8CD File Offset: 0x0001CACD
		public int UndoLimit
		{
			get
			{
				return this._undoLimit;
			}
			set
			{
				this._undoLimit = value;
				base.OnMaxUndoDepthChanged();
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0001E8DC File Offset: 0x0001CADC
		public void AddToUndo(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(action, "action");
			base.AddUndoAction(action);
			base.ClearRedo();
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0001E8F8 File Offset: 0x0001CAF8
		public void Filter(global::Infragistics.Windows.UndoManager.ActionFilter filter)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(filter, "filter");
			global::System.Collections.Generic.Stack<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> stack = this.Filter(base.GetUndoEnumerator(), filter);
			global::System.Collections.Generic.Stack<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> stack2 = this.Filter(base.GetRedoEnumerator(), filter);
			base.Clear();
			foreach (global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action in stack)
			{
				base.AddUndoAction(action);
			}
			foreach (global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action2 in stack2)
			{
				base.AddRedoAction(action2);
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0001E9B4 File Offset: 0x0001CBB4
		private global::System.Collections.Generic.Stack<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> Filter(global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> actionEnumerator, global::Infragistics.Windows.UndoManager.ActionFilter filter)
		{
			global::System.Collections.Generic.Stack<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> stack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase>();
			while (actionEnumerator.MoveNext())
			{
				global::Infragistics.Windows.Helpers.ActionHistory.ActionBase actionBase = actionEnumerator.Current;
				actionBase = filter(actionBase);
				if (actionBase != null)
				{
					stack.Push(actionBase);
				}
			}
			return stack;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001E9EB File Offset: 0x0001CBEB
		public void ForEach(global::System.Action<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> action)
		{
			this.ForEach(action, true, true);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
		public void ForEach(global::System.Action<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> action, bool includeUndo, bool includeRedo)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(action, "action");
			for (int i = 0; i < 2; i++)
			{
				bool flag = i == 0;
				if ((!flag || includeUndo) && (flag || includeRedo))
				{
					global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> enumerator = flag ? base.GetUndoEnumerator() : base.GetRedoEnumerator();
					while (enumerator.MoveNext())
					{
						global::Infragistics.Windows.Helpers.ActionHistory.ActionBase obj = enumerator.Current;
						action(obj);
					}
				}
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001EA55 File Offset: 0x0001CC55
		public static bool IsUndoRedoContext(object context)
		{
			return context == global::Infragistics.Windows.UndoManager.UndoContextId || context == global::Infragistics.Windows.UndoManager.RedoContextId;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001EA69 File Offset: 0x0001CC69
		public static bool IsUndoContext(object context)
		{
			return context == global::Infragistics.Windows.UndoManager.UndoContextId;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001EA73 File Offset: 0x0001CC73
		public static bool IsRedoContext(object context)
		{
			return context == global::Infragistics.Windows.UndoManager.RedoContextId;
		}

		// Token: 0x0400024B RID: 587
		private static object UndoContextId = new object();

		// Token: 0x0400024C RID: 588
		private static object RedoContextId = new object();

		// Token: 0x0400024D RID: 589
		private int _undoLimit;

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000792 RID: 1938
		public delegate global::Infragistics.Windows.Helpers.ActionHistory.ActionBase ActionFilter(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action);
	}
}
