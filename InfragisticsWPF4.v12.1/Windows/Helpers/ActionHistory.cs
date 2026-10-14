using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000167 RID: 359
	public abstract class ActionHistory
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000C09 RID: 3081 RVA: 0x00027711 File Offset: 0x00025911
		public bool IsPerformingAction
		{
			get
			{
				return this.isPerformingAction;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x00027719 File Offset: 0x00025919
		private bool HasRedoActions
		{
			get
			{
				return this.redoActions != null && this.redoActions.Count > 0;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000C0B RID: 3083 RVA: 0x00027733 File Offset: 0x00025933
		private bool HasUndoActions
		{
			get
			{
				return this.undoActions != null && this.undoActions.Count > 0;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0002774D File Offset: 0x0002594D
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionBase RedoActionOnQueue
		{
			get
			{
				if (!this.HasRedoActions)
				{
					return null;
				}
				return this.RedoActions.Peek();
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x00027764 File Offset: 0x00025964
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection RedoActions
		{
			get
			{
				if (this.redoActions == null)
				{
					this.redoActions = new global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection(this.MaxUndoDepth);
				}
				return this.redoActions;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00027785 File Offset: 0x00025985
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection UndoActions
		{
			get
			{
				if (this.undoActions == null)
				{
					this.undoActions = new global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection(this.MaxUndoDepth);
				}
				return this.undoActions;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x000277A6 File Offset: 0x000259A6
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionBase UndoActionOnQueue
		{
			get
			{
				if (!this.HasUndoActions)
				{
					return null;
				}
				return this.UndoActions.Peek();
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x000277BD File Offset: 0x000259BD
		protected virtual object UndoContext
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x000277C0 File Offset: 0x000259C0
		protected virtual object RedoContext
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x000277C3 File Offset: 0x000259C3
		protected virtual int MaxUndoDepth
		{
			get
			{
				return 100;
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000277C7 File Offset: 0x000259C7
		public bool CanRedo()
		{
			return this.CanPerform(this.redoActions, this.RedoContext);
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000277DB File Offset: 0x000259DB
		public bool CanUndo()
		{
			return this.CanPerform(this.undoActions, this.UndoContext);
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000277EF File Offset: 0x000259EF
		public void Clear()
		{
			this.ClearUndo();
			this.ClearRedo();
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000277FD File Offset: 0x000259FD
		public void ClearRedo()
		{
			if (this.HasRedoActions)
			{
				this.RedoActions.Clear();
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00027812 File Offset: 0x00025A12
		internal void ClearUndo()
		{
			if (this.HasUndoActions)
			{
				this.UndoActions.Clear();
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00027827 File Offset: 0x00025A27
		public bool PerformAction(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action, object actionContext)
		{
			return this.PerformActionHelper(actionContext, action, this.UndoActions);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00027837 File Offset: 0x00025A37
		public bool Redo()
		{
			return this.HasRedoActions && this.UndoRedoHelper(this.RedoContext, this.RedoActions, this.UndoActions);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0002785B File Offset: 0x00025A5B
		public bool Undo()
		{
			return this.HasUndoActions && this.UndoRedoHelper(this.UndoContext, this.UndoActions, this.RedoActions);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0002787F File Offset: 0x00025A7F
		protected void AddUndoAction(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
		{
			if (!(action is global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction))
			{
				this.UndoActions.Push(action);
			}
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00027895 File Offset: 0x00025A95
		protected void AddRedoAction(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
		{
			if (!(action is global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction))
			{
				this.RedoActions.Push(action);
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000278AB File Offset: 0x00025AAB
		protected global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> GetRedoEnumerator()
		{
			return this.RedoActions.GetEnumerator();
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000278B8 File Offset: 0x00025AB8
		protected global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> GetUndoEnumerator()
		{
			return this.UndoActions.GetEnumerator();
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000278C5 File Offset: 0x00025AC5
		protected void OnMaxUndoDepthChanged()
		{
			if (this.undoActions != null)
			{
				this.undoActions.SetMaxItems(this.MaxUndoDepth);
			}
			if (this.redoActions != null)
			{
				this.redoActions.SetMaxItems(this.MaxUndoDepth);
			}
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000278F9 File Offset: 0x00025AF9
		protected global::Infragistics.Windows.Helpers.ActionHistory.ActionBase PeekRedo()
		{
			return this.RedoActionOnQueue;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00027901 File Offset: 0x00025B01
		protected global::Infragistics.Windows.Helpers.ActionHistory.ActionBase PeekUndo()
		{
			return this.UndoActionOnQueue;
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0002790C File Offset: 0x00025B0C
		private bool CanPerform(global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection stack, object context)
		{
			if (stack == null)
			{
				return false;
			}
			foreach (global::Infragistics.Windows.Helpers.ActionHistory.ActionBase actionBase in stack)
			{
				if (actionBase.CanPerform(context))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x00027964 File Offset: 0x00025B64
		[global::System.Diagnostics.Conditional("DEBUG_HISTORY")]
		private static void Output(string message, string category)
		{
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00027968 File Offset: 0x00025B68
		private bool PerformActionHelper(object actionContext, global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action, global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection undoList)
		{
			bool flag = this.isPerformingAction;
			this.isPerformingAction = true;
			bool result;
			try
			{
				global::Infragistics.Windows.Helpers.ActionHistory.ActionBase actionBase = action.Perform(actionContext);
				bool flag2 = actionBase != null;
				if (flag2)
				{
					if (actionBase is global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction)
					{
						this.Clear();
					}
					else
					{
						if (!object.Equals(actionContext, this.UndoContext) && !object.Equals(actionContext, this.RedoContext) && undoList == this.undoActions)
						{
							this.ClearRedo();
						}
						undoList.Push(actionBase);
					}
				}
				result = flag2;
			}
			finally
			{
				this.isPerformingAction = flag;
			}
			return result;
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000279F8 File Offset: 0x00025BF8
		private bool UndoRedoHelper(object actionContext, global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection xxStack, global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection yyStack)
		{
			global::Infragistics.Windows.Helpers.ActionHistory.ActionBase actionBase = xxStack.Pop();
			while (!actionBase.CanPerform(actionContext) && xxStack.Count > 0)
			{
				actionBase = xxStack.Pop();
			}
			return this.PerformActionHelper(actionContext, actionBase, yyStack);
		}

		// Token: 0x04000598 RID: 1432
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection undoActions;

		// Token: 0x04000599 RID: 1433
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection redoActions;

		// Token: 0x0400059A RID: 1434
		private bool isPerformingAction;

		// Token: 0x0400059B RID: 1435
		public static readonly global::Infragistics.Windows.Helpers.ActionHistory.ActionBase NoUndoAction = global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction.Instance;

		// Token: 0x02000168 RID: 360
		public abstract class ActionBase
		{
			// Token: 0x06000C28 RID: 3112
			protected internal abstract bool CanPerform(object context);

			// Token: 0x06000C29 RID: 3113
			protected internal abstract global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context);
		}

		// Token: 0x02000169 RID: 361
		internal class NoOpAction : global::Infragistics.Windows.Helpers.ActionHistory.ActionBase
		{
			// Token: 0x06000C2A RID: 3114 RVA: 0x00027A44 File Offset: 0x00025C44
			private NoOpAction()
			{
			}

			// Token: 0x06000C2B RID: 3115 RVA: 0x00027A4C File Offset: 0x00025C4C
			protected internal override bool CanPerform(object context)
			{
				return false;
			}

			// Token: 0x06000C2C RID: 3116 RVA: 0x00027A4F File Offset: 0x00025C4F
			protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
			{
				return this;
			}

			// Token: 0x0400059C RID: 1436
			internal static readonly global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Instance = new global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction();
		}

		// Token: 0x0200016A RID: 362
		private class ActionsCollection : global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000C2E RID: 3118 RVA: 0x00027A5E File Offset: 0x00025C5E
			internal ActionsCollection(int maxItems)
			{
				this.SetMaxItems(maxItems);
				this.stack = new global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase>();
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x06000C2F RID: 3119 RVA: 0x00027A78 File Offset: 0x00025C78
			internal int Count
			{
				get
				{
					return this.stack.Count;
				}
			}

			// Token: 0x06000C30 RID: 3120 RVA: 0x00027A85 File Offset: 0x00025C85
			internal void Clear()
			{
				this.stack.Clear();
				this._version++;
			}

			// Token: 0x06000C31 RID: 3121 RVA: 0x00027AA0 File Offset: 0x00025CA0
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> GetEnumerator()
			{
				return new global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection.Enumerator(this);
			}

			// Token: 0x06000C32 RID: 3122 RVA: 0x00027AA8 File Offset: 0x00025CA8
			internal global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Peek()
			{
				return this.stack[this.Count - 1];
			}

			// Token: 0x06000C33 RID: 3123 RVA: 0x00027AC0 File Offset: 0x00025CC0
			internal global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Pop()
			{
				global::Infragistics.Windows.Helpers.ActionHistory.ActionBase result = this.Peek();
				this.stack.RemoveAt(this.Count - 1);
				this._version++;
				return result;
			}

			// Token: 0x06000C34 RID: 3124 RVA: 0x00027AF6 File Offset: 0x00025CF6
			internal void Push(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
			{
				this.stack.Add(action);
				if (this.Count > this._maxItems)
				{
					this.stack.RemoveAt(0);
				}
				this._version++;
			}

			// Token: 0x06000C35 RID: 3125 RVA: 0x00027B2C File Offset: 0x00025D2C
			internal void SetMaxItems(int maxItems)
			{
				if (maxItems < 0)
				{
					throw new global::System.ArgumentOutOfRangeException();
				}
				this._maxItems = ((maxItems > 0) ? maxItems : int.MaxValue);
				if (this.stack != null && this.stack.Count > this._maxItems)
				{
					this.stack.RemoveRange(0, this.stack.Count - this._maxItems);
					this._version++;
				}
			}

			// Token: 0x06000C36 RID: 3126 RVA: 0x00027B9C File Offset: 0x00025D9C
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400059D RID: 1437
			private int _maxItems;

			// Token: 0x0400059E RID: 1438
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> stack;

			// Token: 0x0400059F RID: 1439
			private int _version;

			// Token: 0x0200016B RID: 363
			private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000C37 RID: 3127 RVA: 0x00027BA4 File Offset: 0x00025DA4
				internal Enumerator(global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection actions)
				{
					this._actions = actions;
					this.Reset();
				}

				// Token: 0x06000C38 RID: 3128 RVA: 0x00027BBC File Offset: 0x00025DBC
				public bool MoveNext()
				{
					if (this._version != this._actions._version)
					{
						throw new global::System.InvalidOperationException();
					}
					if (this._index == -1)
					{
						return false;
					}
					if (this._index == -2)
					{
						this._index = this._actions.Count;
					}
					this._index--;
					if (this._index >= 0)
					{
						this._current = this._actions.stack[this._index];
						return true;
					}
					this._current = null;
					return false;
				}

				// Token: 0x1700025B RID: 603
				// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00027C45 File Offset: 0x00025E45
				public global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Current
				{
					get
					{
						if (this._index == -2)
						{
							throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_3"));
						}
						if (this._index == -1)
						{
							throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_4"));
						}
						return this._current;
					}
				}

				// Token: 0x06000C3A RID: 3130 RVA: 0x00027C80 File Offset: 0x00025E80
				public void Reset()
				{
					this._version = this._actions._version;
					this._index = -2;
					this._current = null;
				}

				// Token: 0x06000C3B RID: 3131 RVA: 0x00027CA2 File Offset: 0x00025EA2
				void global::System.IDisposable.Dispose()
				{
				}

				// Token: 0x1700025C RID: 604
				// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00027CA4 File Offset: 0x00025EA4
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x040005A0 RID: 1440
				private global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection _actions;

				// Token: 0x040005A1 RID: 1441
				private int _version;

				// Token: 0x040005A2 RID: 1442
				private int _index;

				// Token: 0x040005A3 RID: 1443
				private global::Infragistics.Windows.Helpers.ActionHistory.ActionBase _current;
			}
		}
	}
}
