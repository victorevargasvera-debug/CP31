using System;
using System.Collections.Generic;
using System.Threading;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x020000F9 RID: 249
	internal class AsyncOperationCounter
	{
		// Token: 0x06000C92 RID: 3218 RVA: 0x0001EE23 File Offset: 0x0001D023
		public void BeginOperation()
		{
			global::System.Threading.Interlocked.Increment(ref this._pendingOperationCounter);
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x0001EE34 File Offset: 0x0001D034
		public void CompleteOperation(global::System.Exception exception)
		{
			if (this._pendingCompletionList.Count > 0)
			{
				global::System.Collections.Generic.LinkedList<global::NLog.Common.AsyncContinuation> pendingCompletionList = this._pendingCompletionList;
				lock (pendingCompletionList)
				{
					global::System.Threading.Interlocked.Decrement(ref this._pendingOperationCounter);
					global::System.Collections.Generic.LinkedListNode<global::NLog.Common.AsyncContinuation> linkedListNode = this._pendingCompletionList.First;
					while (linkedListNode != null)
					{
						global::NLog.Common.AsyncContinuation value = linkedListNode.Value;
						linkedListNode = linkedListNode.Next;
						value(exception);
					}
					return;
				}
			}
			global::System.Threading.Interlocked.Decrement(ref this._pendingOperationCounter);
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x0001EEBC File Offset: 0x0001D0BC
		public global::NLog.Common.AsyncContinuation RegisterCompletionNotification(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			if (this._pendingOperationCounter == 0)
			{
				return asyncContinuation;
			}
			global::System.Collections.Generic.LinkedList<global::NLog.Common.AsyncContinuation> pendingCompletionList = this._pendingCompletionList;
			bool flag = false;
			global::NLog.Common.AsyncContinuation result;
			try
			{
				global::System.Threading.Monitor.Enter(pendingCompletionList, ref flag);
				global::System.Collections.Generic.LinkedListNode<global::NLog.Common.AsyncContinuation> pendingCompletion = new global::System.Collections.Generic.LinkedListNode<global::NLog.Common.AsyncContinuation>(null);
				this._pendingCompletionList.AddLast(pendingCompletion);
				int remainingCompletionCounter = global::System.Threading.Interlocked.Increment(ref this._pendingOperationCounter);
				if (remainingCompletionCounter <= 0)
				{
					global::System.Threading.Interlocked.Exchange(ref this._pendingOperationCounter, 0);
					this._pendingCompletionList.Remove(pendingCompletion);
					result = asyncContinuation;
				}
				else
				{
					pendingCompletion.Value = delegate(global::System.Exception ex)
					{
						if (global::System.Threading.Interlocked.Decrement(ref remainingCompletionCounter) == 0)
						{
							global::System.Collections.Generic.LinkedList<global::NLog.Common.AsyncContinuation> pendingCompletionList2 = this._pendingCompletionList;
							lock (pendingCompletionList2)
							{
								global::System.Threading.Interlocked.Decrement(ref this._pendingOperationCounter);
								this._pendingCompletionList.Remove(pendingCompletion);
								global::System.Collections.Generic.LinkedListNode<global::NLog.Common.AsyncContinuation> linkedListNode = this._pendingCompletionList.First;
								while (linkedListNode != null)
								{
									global::NLog.Common.AsyncContinuation value = linkedListNode.Value;
									linkedListNode = linkedListNode.Next;
									value(ex);
								}
							}
							asyncContinuation(ex);
						}
					};
					result = pendingCompletion.Value;
				}
			}
			finally
			{
				if (flag)
				{
					global::System.Threading.Monitor.Exit(pendingCompletionList);
				}
			}
			return result;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		public void Clear()
		{
			this._pendingCompletionList.Clear();
		}

		// Token: 0x0400037D RID: 893
		private int _pendingOperationCounter;

		// Token: 0x0400037E RID: 894
		private readonly global::System.Collections.Generic.LinkedList<global::NLog.Common.AsyncContinuation> _pendingCompletionList = new global::System.Collections.Generic.LinkedList<global::NLog.Common.AsyncContinuation>();
	}
}
