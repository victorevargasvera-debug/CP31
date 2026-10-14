using System;
using System.Collections.Generic;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows
{
	// Token: 0x02000091 RID: 145
	internal class UndoManager : global::Infragistics.Windows.Helpers.ActionHistory
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x0001BBAC File Offset: 0x00019DAC
		public UndoManager() : this(0)
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001BBB5 File Offset: 0x00019DB5
		public UndoManager(int undoLimit)
		{
			this._undoLimit = undoLimit;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x0001BBC4 File Offset: 0x00019DC4
		protected sealed override object RedoContext
		{
			get
			{
				return global::Infragistics.Windows.UndoManager.RedoContextId;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x0001BBCB File Offset: 0x00019DCB
		protected sealed override object UndoContext
		{
			get
			{
				return global::Infragistics.Windows.UndoManager.UndoContextId;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0001BBD2 File Offset: 0x00019DD2
		protected override int MaxUndoDepth
		{
			get
			{
				return this.UndoLimit;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0001BBDA File Offset: 0x00019DDA
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0001BBE2 File Offset: 0x00019DE2
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

		// Token: 0x06000702 RID: 1794 RVA: 0x0001BBF1 File Offset: 0x00019DF1
		public void AddToUndo(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(action, "action");
			base.AddUndoAction(action);
			base.ClearRedo();
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001BC0C File Offset: 0x00019E0C
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

		// Token: 0x06000704 RID: 1796 RVA: 0x0001BCC8 File Offset: 0x00019EC8
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

		// Token: 0x06000705 RID: 1797 RVA: 0x0001BCFF File Offset: 0x00019EFF
		public void ForEach(global::System.Action<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> action)
		{
			this.ForEach(action, true, true);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0001BD0C File Offset: 0x00019F0C
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

		// Token: 0x06000707 RID: 1799 RVA: 0x0001BD69 File Offset: 0x00019F69
		public static bool IsUndoRedoContext(object context)
		{
			return context == global::Infragistics.Windows.UndoManager.UndoContextId || context == global::Infragistics.Windows.UndoManager.RedoContextId;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001BD7D File Offset: 0x00019F7D
		public static bool IsUndoContext(object context)
		{
			return context == global::Infragistics.Windows.UndoManager.UndoContextId;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0001BD87 File Offset: 0x00019F87
		public static bool IsRedoContext(object context)
		{
			return context == global::Infragistics.Windows.UndoManager.RedoContextId;
		}

		// Token: 0x04000207 RID: 519
		private static object UndoContextId = new object();

		// Token: 0x04000208 RID: 520
		private static object RedoContextId = new object();

		// Token: 0x04000209 RID: 521
		private int _undoLimit;

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x0600070C RID: 1804
		public delegate global::Infragistics.Windows.Helpers.ActionHistory.ActionBase ActionFilter(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action);
	}
}
