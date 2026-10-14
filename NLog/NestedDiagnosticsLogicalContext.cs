using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using NLog.Internal;

namespace NLog
{
	// Token: 0x0200001A RID: 26
	public static class NestedDiagnosticsLogicalContext
	{
		// Token: 0x0600044B RID: 1099 RVA: 0x000086B3 File Offset: 0x000068B3
		public static global::System.IDisposable Push<T>(T value)
		{
			global::NLog.NestedDiagnosticsLogicalContext.NestedContext<T> nestedContext = new global::NLog.NestedDiagnosticsLogicalContext.NestedContext<T>(global::NLog.NestedDiagnosticsLogicalContext.GetThreadLocal(), value);
			global::NLog.NestedDiagnosticsLogicalContext.SetThreadLocal(nestedContext);
			return nestedContext;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000086C6 File Offset: 0x000068C6
		public static object Pop()
		{
			return global::NLog.NestedDiagnosticsLogicalContext.PopObject();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000086CD File Offset: 0x000068CD
		public static string Pop(global::System.IFormatProvider formatProvider)
		{
			return global::NLog.Internal.FormatHelper.ConvertToString(global::NLog.NestedDiagnosticsLogicalContext.PopObject() ?? string.Empty, formatProvider);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000086E4 File Offset: 0x000068E4
		public static object PopObject()
		{
			global::NLog.NestedDiagnosticsLogicalContext.INestedContext threadLocal = global::NLog.NestedDiagnosticsLogicalContext.GetThreadLocal();
			if (threadLocal != null)
			{
				global::NLog.NestedDiagnosticsLogicalContext.SetThreadLocal(threadLocal.Parent);
			}
			if (threadLocal == null)
			{
				return null;
			}
			return threadLocal.Value;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00008710 File Offset: 0x00006910
		public static object PeekObject()
		{
			global::NLog.NestedDiagnosticsLogicalContext.INestedContext nestedContext = global::NLog.NestedDiagnosticsLogicalContext.PeekContext(false);
			if (nestedContext == null)
			{
				return null;
			}
			return nestedContext.Value;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00008724 File Offset: 0x00006924
		internal static global::System.DateTime PeekTopScopeBeginTime()
		{
			global::NLog.NestedDiagnosticsLogicalContext.INestedContext nestedContext = global::NLog.NestedDiagnosticsLogicalContext.PeekContext(false);
			return new global::System.DateTime((nestedContext != null) ? nestedContext.CreatedTimeUtcTicks : global::System.DateTime.MinValue.Ticks, global::System.DateTimeKind.Utc);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00008758 File Offset: 0x00006958
		internal static global::System.DateTime PeekBottomScopeBeginTime()
		{
			global::NLog.NestedDiagnosticsLogicalContext.INestedContext nestedContext = global::NLog.NestedDiagnosticsLogicalContext.PeekContext(true);
			return new global::System.DateTime((nestedContext != null) ? nestedContext.CreatedTimeUtcTicks : global::System.DateTime.MinValue.Ticks, global::System.DateTimeKind.Utc);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000878C File Offset: 0x0000698C
		private static global::NLog.NestedDiagnosticsLogicalContext.INestedContext PeekContext(bool bottomScope)
		{
			global::NLog.NestedDiagnosticsLogicalContext.INestedContext nestedContext = global::NLog.NestedDiagnosticsLogicalContext.GetThreadLocal();
			if (nestedContext != null)
			{
				if (bottomScope)
				{
					while (nestedContext.Parent != null)
					{
						nestedContext = nestedContext.Parent;
					}
				}
				return nestedContext;
			}
			return null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000087B9 File Offset: 0x000069B9
		public static void Clear()
		{
			global::NLog.NestedDiagnosticsLogicalContext.SetThreadLocal(null);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000087C1 File Offset: 0x000069C1
		public static string[] GetAllMessages()
		{
			return global::NLog.NestedDiagnosticsLogicalContext.GetAllMessages(null);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000087CC File Offset: 0x000069CC
		public static string[] GetAllMessages(global::System.IFormatProvider formatProvider)
		{
			return (from o in global::NLog.NestedDiagnosticsLogicalContext.GetAllObjects()
			select global::NLog.Internal.FormatHelper.ConvertToString(o, formatProvider)).ToArray<string>();
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00008804 File Offset: 0x00006A04
		public static object[] GetAllObjects()
		{
			global::NLog.NestedDiagnosticsLogicalContext.INestedContext nestedContext = global::NLog.NestedDiagnosticsLogicalContext.GetThreadLocal();
			if (nestedContext == null)
			{
				return global::NLog.Internal.ArrayHelper.Empty<object>();
			}
			int num = 0;
			object[] array = new object[nestedContext.FrameLevel];
			while (nestedContext != null)
			{
				array[num++] = nestedContext.Value;
				nestedContext = nestedContext.Parent;
			}
			return array;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00008848 File Offset: 0x00006A48
		private static void SetThreadLocal(global::NLog.NestedDiagnosticsLogicalContext.INestedContext newValue)
		{
			if (newValue == null)
			{
				global::System.Runtime.Remoting.Messaging.CallContext.FreeNamedDataSlot("NLog.AsyncableNestedDiagnosticsContext");
				return;
			}
			global::System.Runtime.Remoting.Messaging.CallContext.LogicalSetData("NLog.AsyncableNestedDiagnosticsContext", newValue);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00008863 File Offset: 0x00006A63
		private static global::NLog.NestedDiagnosticsLogicalContext.INestedContext GetThreadLocal()
		{
			return global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("NLog.AsyncableNestedDiagnosticsContext") as global::NLog.NestedDiagnosticsLogicalContext.INestedContext;
		}

		// Token: 0x04000046 RID: 70
		private const string NestedDiagnosticsContextKey = "NLog.AsyncableNestedDiagnosticsContext";

		// Token: 0x020001C5 RID: 453
		private interface INestedContext : global::System.IDisposable
		{
			// Token: 0x17000343 RID: 835
			// (get) Token: 0x060011D2 RID: 4562
			global::NLog.NestedDiagnosticsLogicalContext.INestedContext Parent { get; }

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x060011D3 RID: 4563
			int FrameLevel { get; }

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x060011D4 RID: 4564
			object Value { get; }

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x060011D5 RID: 4565
			long CreatedTimeUtcTicks { get; }
		}

		// Token: 0x020001C6 RID: 454
		[global::System.Serializable]
		private class NestedContext<T> : global::NLog.NestedDiagnosticsLogicalContext.INestedContext, global::System.IDisposable
		{
			// Token: 0x17000347 RID: 839
			// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0002EC7B File Offset: 0x0002CE7B
			public global::NLog.NestedDiagnosticsLogicalContext.INestedContext Parent { get; }

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0002EC83 File Offset: 0x0002CE83
			public T Value { get; }

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0002EC8B File Offset: 0x0002CE8B
			object global::NLog.NestedDiagnosticsLogicalContext.INestedContext.Value
			{
				get
				{
					return this.Value;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0002EC98 File Offset: 0x0002CE98
			public long CreatedTimeUtcTicks { get; }

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x060011DA RID: 4570 RVA: 0x0002ECA0 File Offset: 0x0002CEA0
			public int FrameLevel { get; }

			// Token: 0x060011DB RID: 4571 RVA: 0x0002ECA8 File Offset: 0x0002CEA8
			public NestedContext(global::NLog.NestedDiagnosticsLogicalContext.INestedContext parent, T value)
			{
				this.Parent = parent;
				this.Value = value;
				this.CreatedTimeUtcTicks = global::System.DateTime.UtcNow.Ticks;
				this.FrameLevel = ((parent != null) ? (parent.FrameLevel + 1) : 1);
			}

			// Token: 0x060011DC RID: 4572 RVA: 0x0002ECF0 File Offset: 0x0002CEF0
			void global::System.IDisposable.Dispose()
			{
				if (global::System.Threading.Interlocked.Exchange(ref this._disposed, 1) != 1)
				{
					global::NLog.NestedDiagnosticsLogicalContext.PopObject();
				}
			}

			// Token: 0x060011DD RID: 4573 RVA: 0x0002ED07 File Offset: 0x0002CF07
			public override string ToString()
			{
				T t = this.Value;
				return ((t != null) ? t.ToString() : null) ?? "null";
			}

			// Token: 0x04000523 RID: 1315
			private int _disposed;
		}
	}
}
