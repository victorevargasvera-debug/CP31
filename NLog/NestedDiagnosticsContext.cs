using System;
using System.Collections.Generic;
using System.Linq;
using NLog.Internal;

namespace NLog
{
	// Token: 0x02000019 RID: 25
	public static class NestedDiagnosticsContext
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00008560 File Offset: 0x00006760
		public static string TopMessage
		{
			get
			{
				return global::NLog.Internal.FormatHelper.ConvertToString(global::NLog.NestedDiagnosticsContext.TopObject, null);
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0000856D File Offset: 0x0000676D
		public static object TopObject
		{
			get
			{
				return global::NLog.NestedDiagnosticsContext.PeekObject();
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00008574 File Offset: 0x00006774
		private static global::System.Collections.Generic.Stack<object> GetThreadStack(bool create = true)
		{
			return global::NLog.Internal.ThreadLocalStorageHelper.GetDataForSlot<global::System.Collections.Generic.Stack<object>>(global::NLog.NestedDiagnosticsContext.dataSlot, create);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00008581 File Offset: 0x00006781
		public static global::System.IDisposable Push(string text)
		{
			return global::NLog.NestedDiagnosticsContext.Push(text);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000858C File Offset: 0x0000678C
		public static global::System.IDisposable Push(object value)
		{
			global::System.Collections.Generic.Stack<object> threadStack = global::NLog.NestedDiagnosticsContext.GetThreadStack(true);
			int count = threadStack.Count;
			threadStack.Push(value);
			return new global::NLog.NestedDiagnosticsContext.StackPopper(threadStack, count);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000085B3 File Offset: 0x000067B3
		public static string Pop()
		{
			return global::NLog.NestedDiagnosticsContext.Pop(null);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000085BB File Offset: 0x000067BB
		public static string Pop(global::System.IFormatProvider formatProvider)
		{
			return global::NLog.Internal.FormatHelper.ConvertToString(global::NLog.NestedDiagnosticsContext.PopObject() ?? string.Empty, formatProvider);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000085D4 File Offset: 0x000067D4
		public static object PopObject()
		{
			global::System.Collections.Generic.Stack<object> threadStack = global::NLog.NestedDiagnosticsContext.GetThreadStack(true);
			if (threadStack.Count <= 0)
			{
				return null;
			}
			return threadStack.Pop();
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000085FC File Offset: 0x000067FC
		public static object PeekObject()
		{
			global::System.Collections.Generic.Stack<object> threadStack = global::NLog.NestedDiagnosticsContext.GetThreadStack(false);
			if (threadStack == null || threadStack.Count <= 0)
			{
				return null;
			}
			return threadStack.Peek();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00008624 File Offset: 0x00006824
		public static void Clear()
		{
			global::System.Collections.Generic.Stack<object> threadStack = global::NLog.NestedDiagnosticsContext.GetThreadStack(false);
			if (threadStack == null)
			{
				return;
			}
			threadStack.Clear();
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00008636 File Offset: 0x00006836
		public static string[] GetAllMessages()
		{
			return global::NLog.NestedDiagnosticsContext.GetAllMessages(null);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00008640 File Offset: 0x00006840
		public static string[] GetAllMessages(global::System.IFormatProvider formatProvider)
		{
			global::System.Collections.Generic.Stack<object> threadStack = global::NLog.NestedDiagnosticsContext.GetThreadStack(false);
			if (threadStack == null)
			{
				return global::NLog.Internal.ArrayHelper.Empty<string>();
			}
			return (from o in threadStack
			select global::NLog.Internal.FormatHelper.ConvertToString(o, formatProvider)).ToArray<string>();
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00008684 File Offset: 0x00006884
		public static object[] GetAllObjects()
		{
			global::System.Collections.Generic.Stack<object> threadStack = global::NLog.NestedDiagnosticsContext.GetThreadStack(false);
			if (threadStack == null)
			{
				return global::NLog.Internal.ArrayHelper.Empty<object>();
			}
			return threadStack.ToArray();
		}

		// Token: 0x04000045 RID: 69
		private static readonly object dataSlot = global::NLog.Internal.ThreadLocalStorageHelper.AllocateDataSlot();

		// Token: 0x020001C3 RID: 451
		private class StackPopper : global::System.IDisposable
		{
			// Token: 0x060011CE RID: 4558 RVA: 0x0002EC2C File Offset: 0x0002CE2C
			public StackPopper(global::System.Collections.Generic.Stack<object> stack, int previousCount)
			{
				this._stack = stack;
				this._previousCount = previousCount;
			}

			// Token: 0x060011CF RID: 4559 RVA: 0x0002EC42 File Offset: 0x0002CE42
			void global::System.IDisposable.Dispose()
			{
				while (this._stack.Count > this._previousCount)
				{
					this._stack.Pop();
				}
			}

			// Token: 0x0400051C RID: 1308
			private readonly global::System.Collections.Generic.Stack<object> _stack;

			// Token: 0x0400051D RID: 1309
			private readonly int _previousCount;
		}
	}
}
