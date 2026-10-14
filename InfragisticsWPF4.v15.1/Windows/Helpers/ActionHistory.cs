using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000189 RID: 393
	public abstract class ActionHistory
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0002B899 File Offset: 0x00029A99
		public bool IsPerformingAction
		{
			get
			{
				return this.isPerformingAction;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x0002B8A1 File Offset: 0x00029AA1
		private bool HasRedoActions
		{
			get
			{
				return this.redoActions != null && this.redoActions.Count > 0;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0002B8BB File Offset: 0x00029ABB
		private bool HasUndoActions
		{
			get
			{
				return this.undoActions != null && this.undoActions.Count > 0;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0002B8D5 File Offset: 0x00029AD5
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

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0002B8EC File Offset: 0x00029AEC
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

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0002B90D File Offset: 0x00029B0D
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

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0002B92E File Offset: 0x00029B2E
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

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x0002B945 File Offset: 0x00029B45
		protected virtual object UndoContext
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0002B948 File Offset: 0x00029B48
		protected virtual object RedoContext
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0002B94B File Offset: 0x00029B4B
		protected virtual int MaxUndoDepth
		{
			get
			{
				return 100;
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0002B94F File Offset: 0x00029B4F
		public bool CanRedo()
		{
			return this.CanPerform(this.redoActions, this.RedoContext);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0002B963 File Offset: 0x00029B63
		public bool CanUndo()
		{
			return this.CanPerform(this.undoActions, this.UndoContext);
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0002B977 File Offset: 0x00029B77
		public void Clear()
		{
			this.ClearUndo();
			this.ClearRedo();
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0002B985 File Offset: 0x00029B85
		public void ClearRedo()
		{
			if (this.HasRedoActions)
			{
				this.RedoActions.Clear();
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0002B99A File Offset: 0x00029B9A
		internal void ClearUndo()
		{
			if (this.HasUndoActions)
			{
				this.UndoActions.Clear();
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0002B9AF File Offset: 0x00029BAF
		public bool PerformAction(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action, object actionContext)
		{
			return this.PerformActionHelper(actionContext, action, this.UndoActions);
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0002B9BF File Offset: 0x00029BBF
		public bool Redo()
		{
			return this.HasRedoActions && this.UndoRedoHelper(this.RedoContext, this.RedoActions, this.UndoActions);
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0002B9E3 File Offset: 0x00029BE3
		public bool Undo()
		{
			return this.HasUndoActions && this.UndoRedoHelper(this.UndoContext, this.UndoActions, this.RedoActions);
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0002BA07 File Offset: 0x00029C07
		protected void AddUndoAction(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
		{
			if (!(action is global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction))
			{
				this.UndoActions.Push(action);
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0002BA1D File Offset: 0x00029C1D
		protected void AddRedoAction(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
		{
			if (!(action is global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction))
			{
				this.RedoActions.Push(action);
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x0002BA33 File Offset: 0x00029C33
		protected global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> GetRedoEnumerator()
		{
			return this.RedoActions.GetEnumerator();
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0002BA40 File Offset: 0x00029C40
		protected global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> GetUndoEnumerator()
		{
			return this.UndoActions.GetEnumerator();
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0002BA4D File Offset: 0x00029C4D
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

		// Token: 0x06000D35 RID: 3381 RVA: 0x0002BA81 File Offset: 0x00029C81
		protected global::Infragistics.Windows.Helpers.ActionHistory.ActionBase PeekRedo()
		{
			return this.RedoActionOnQueue;
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0002BA89 File Offset: 0x00029C89
		protected global::Infragistics.Windows.Helpers.ActionHistory.ActionBase PeekUndo()
		{
			return this.UndoActionOnQueue;
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0002BA94 File Offset: 0x00029C94
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

		// Token: 0x06000D38 RID: 3384 RVA: 0x0002BAEC File Offset: 0x00029CEC
		[global::System.Diagnostics.Conditional("DEBUG_HISTORY")]
		private static void Output(string message, string category)
		{
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0002BAF0 File Offset: 0x00029CF0
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

		// Token: 0x06000D3A RID: 3386 RVA: 0x0002BB80 File Offset: 0x00029D80
		private bool UndoRedoHelper(object actionContext, global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection xxStack, global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection yyStack)
		{
			global::Infragistics.Windows.Helpers.ActionHistory.ActionBase actionBase = xxStack.Pop();
			while (!actionBase.CanPerform(actionContext) && xxStack.Count > 0)
			{
				actionBase = xxStack.Pop();
			}
			return this.PerformActionHelper(actionContext, actionBase, yyStack);
		}

		// Token: 0x0400065D RID: 1629
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection undoActions;

		// Token: 0x0400065E RID: 1630
		private global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection redoActions;

		// Token: 0x0400065F RID: 1631
		private bool isPerformingAction;

		// Token: 0x04000660 RID: 1632
		public static readonly global::Infragistics.Windows.Helpers.ActionHistory.ActionBase NoUndoAction = global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction.Instance;

		// Token: 0x0200018A RID: 394
		public abstract class ActionBase
		{
			// Token: 0x06000D3D RID: 3389
			protected internal abstract bool CanPerform(object context);

			// Token: 0x06000D3E RID: 3390
			protected internal abstract global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context);
		}

		// Token: 0x0200018B RID: 395
		internal class NoOpAction : global::Infragistics.Windows.Helpers.ActionHistory.ActionBase
		{
			// Token: 0x06000D3F RID: 3391 RVA: 0x0002BBCC File Offset: 0x00029DCC
			private NoOpAction()
			{
			}

			// Token: 0x06000D40 RID: 3392 RVA: 0x0002BBD4 File Offset: 0x00029DD4
			protected internal override bool CanPerform(object context)
			{
				return false;
			}

			// Token: 0x06000D41 RID: 3393 RVA: 0x0002BBD7 File Offset: 0x00029DD7
			protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
			{
				return this;
			}

			// Token: 0x04000661 RID: 1633
			internal static readonly global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Instance = new global::Infragistics.Windows.Helpers.ActionHistory.NoOpAction();
		}

		// Token: 0x0200018C RID: 396
		private class ActionsCollection : global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000D43 RID: 3395 RVA: 0x0002BBE6 File Offset: 0x00029DE6
			internal ActionsCollection(int maxItems)
			{
				this.SetMaxItems(maxItems);
				this.stack = new global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase>();
			}

			// Token: 0x17000276 RID: 630
			// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0002BC00 File Offset: 0x00029E00
			internal int Count
			{
				get
				{
					return this.stack.Count;
				}
			}

			// Token: 0x06000D45 RID: 3397 RVA: 0x0002BC0D File Offset: 0x00029E0D
			internal void Clear()
			{
				this.stack.Clear();
				this._version++;
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x0002BC28 File Offset: 0x00029E28
			public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> GetEnumerator()
			{
				return new global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection.Enumerator(this);
			}

			// Token: 0x06000D47 RID: 3399 RVA: 0x0002BC30 File Offset: 0x00029E30
			internal global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Peek()
			{
				return this.stack[this.Count - 1];
			}

			// Token: 0x06000D48 RID: 3400 RVA: 0x0002BC48 File Offset: 0x00029E48
			internal global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Pop()
			{
				global::Infragistics.Windows.Helpers.ActionHistory.ActionBase result = this.Peek();
				this.stack.RemoveAt(this.Count - 1);
				this._version++;
				return result;
			}

			// Token: 0x06000D49 RID: 3401 RVA: 0x0002BC7E File Offset: 0x00029E7E
			internal void Push(global::Infragistics.Windows.Helpers.ActionHistory.ActionBase action)
			{
				this.stack.Add(action);
				if (this.Count > this._maxItems)
				{
					this.stack.RemoveAt(0);
				}
				this._version++;
			}

			// Token: 0x06000D4A RID: 3402 RVA: 0x0002BCB4 File Offset: 0x00029EB4
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

			// Token: 0x06000D4B RID: 3403 RVA: 0x0002BD24 File Offset: 0x00029F24
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000662 RID: 1634
			private int _maxItems;

			// Token: 0x04000663 RID: 1635
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase> stack;

			// Token: 0x04000664 RID: 1636
			private int _version;

			// Token: 0x0200018D RID: 397
			private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Helpers.ActionHistory.ActionBase>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000D4C RID: 3404 RVA: 0x0002BD2C File Offset: 0x00029F2C
				internal Enumerator(global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection actions)
				{
					this._actions = actions;
					this.Reset();
				}

				// Token: 0x06000D4D RID: 3405 RVA: 0x0002BD44 File Offset: 0x00029F44
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

				// Token: 0x17000277 RID: 631
				// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0002BDCD File Offset: 0x00029FCD
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

				// Token: 0x06000D4F RID: 3407 RVA: 0x0002BE08 File Offset: 0x0002A008
				public void Reset()
				{
					this._version = this._actions._version;
					this._index = -2;
					this._current = null;
				}

				// Token: 0x06000D50 RID: 3408 RVA: 0x0002BE2A File Offset: 0x0002A02A
				void global::System.IDisposable.Dispose()
				{
				}

				// Token: 0x17000278 RID: 632
				// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0002BE2C File Offset: 0x0002A02C
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x04000665 RID: 1637
				private global::Infragistics.Windows.Helpers.ActionHistory.ActionsCollection _actions;

				// Token: 0x04000666 RID: 1638
				private int _version;

				// Token: 0x04000667 RID: 1639
				private int _index;

				// Token: 0x04000668 RID: 1640
				private global::Infragistics.Windows.Helpers.ActionHistory.ActionBase _current;
			}
		}
	}
}
