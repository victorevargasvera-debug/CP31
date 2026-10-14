using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using NLog.Internal;

namespace NLog
{
	// Token: 0x02000015 RID: 21
	public static class MappedDiagnosticsLogicalContext
	{
		// Token: 0x0600041D RID: 1053 RVA: 0x00008398 File Offset: 0x00006598
		private static global::System.Collections.Generic.IDictionary<string, object> GetLogicalThreadDictionary(bool clone = false)
		{
			global::System.Collections.Generic.IDictionary<string, object> dictionary = global::NLog.MappedDiagnosticsLogicalContext.GetThreadLocal();
			if (dictionary == null)
			{
				if (!clone)
				{
					return global::NLog.MappedDiagnosticsLogicalContext.EmptyDefaultDictionary;
				}
				dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				global::NLog.MappedDiagnosticsLogicalContext.SetThreadLocal(dictionary);
			}
			else if (clone)
			{
				dictionary = new global::System.Collections.Generic.Dictionary<string, object>(dictionary);
				global::NLog.MappedDiagnosticsLogicalContext.SetThreadLocal(dictionary);
			}
			return dictionary;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000083D6 File Offset: 0x000065D6
		public static string Get(string item)
		{
			return global::NLog.MappedDiagnosticsLogicalContext.Get(item, null);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000083DF File Offset: 0x000065DF
		public static string Get(string item, global::System.IFormatProvider formatProvider)
		{
			return global::NLog.Internal.FormatHelper.ConvertToString(global::NLog.MappedDiagnosticsLogicalContext.GetObject(item), formatProvider);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x000083F0 File Offset: 0x000065F0
		public static object GetObject(string item)
		{
			object result;
			global::NLog.MappedDiagnosticsLogicalContext.GetLogicalThreadDictionary(false).TryGetValue(item, out result);
			return result;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000840D File Offset: 0x0000660D
		public static global::System.IDisposable SetScoped(string item, string value)
		{
			global::NLog.MappedDiagnosticsLogicalContext.Set(item, value);
			return new global::NLog.MappedDiagnosticsLogicalContext.ItemRemover(item);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000841C File Offset: 0x0000661C
		public static global::System.IDisposable SetScoped(string item, object value)
		{
			global::NLog.MappedDiagnosticsLogicalContext.Set(item, value);
			return new global::NLog.MappedDiagnosticsLogicalContext.ItemRemover(item);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000842B File Offset: 0x0000662B
		public static void Set(string item, string value)
		{
			global::NLog.MappedDiagnosticsLogicalContext.GetLogicalThreadDictionary(true)[item] = value;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000843A File Offset: 0x0000663A
		public static void Set(string item, object value)
		{
			global::NLog.MappedDiagnosticsLogicalContext.GetLogicalThreadDictionary(true)[item] = value;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00008449 File Offset: 0x00006649
		public static global::System.Collections.Generic.ICollection<string> GetNames()
		{
			return global::NLog.MappedDiagnosticsLogicalContext.GetLogicalThreadDictionary(false).Keys;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00008456 File Offset: 0x00006656
		public static bool Contains(string item)
		{
			return global::NLog.MappedDiagnosticsLogicalContext.GetLogicalThreadDictionary(false).ContainsKey(item);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00008464 File Offset: 0x00006664
		public static void Remove(string item)
		{
			global::NLog.MappedDiagnosticsLogicalContext.GetLogicalThreadDictionary(true).Remove(item);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00008473 File Offset: 0x00006673
		public static void Clear()
		{
			global::NLog.MappedDiagnosticsLogicalContext.Clear(false);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000847B File Offset: 0x0000667B
		public static void Clear(bool free)
		{
			if (free)
			{
				global::NLog.MappedDiagnosticsLogicalContext.SetThreadLocal(null);
				return;
			}
			global::NLog.MappedDiagnosticsLogicalContext.GetLogicalThreadDictionary(true).Clear();
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00008492 File Offset: 0x00006692
		private static void SetThreadLocal(global::System.Collections.Generic.IDictionary<string, object> newValue)
		{
			if (newValue == null)
			{
				global::System.Runtime.Remoting.Messaging.CallContext.FreeNamedDataSlot("NLog.AsyncableMappedDiagnosticsContext");
				return;
			}
			global::System.Runtime.Remoting.Messaging.CallContext.LogicalSetData("NLog.AsyncableMappedDiagnosticsContext", newValue);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x000084AD File Offset: 0x000066AD
		private static global::System.Collections.Generic.IDictionary<string, object> GetThreadLocal()
		{
			return global::System.Runtime.Remoting.Messaging.CallContext.LogicalGetData("NLog.AsyncableMappedDiagnosticsContext") as global::System.Collections.Generic.Dictionary<string, object>;
		}

		// Token: 0x04000042 RID: 66
		private const string LogicalThreadDictionaryKey = "NLog.AsyncableMappedDiagnosticsContext";

		// Token: 0x04000043 RID: 67
		private static readonly global::System.Collections.Generic.IDictionary<string, object> EmptyDefaultDictionary = default(global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<string, object>);

		// Token: 0x020001C2 RID: 450
		private class ItemRemover : global::System.IDisposable
		{
			// Token: 0x060011CC RID: 4556 RVA: 0x0002EC02 File Offset: 0x0002CE02
			public ItemRemover(string item)
			{
				this._item = item;
			}

			// Token: 0x060011CD RID: 4557 RVA: 0x0002EC11 File Offset: 0x0002CE11
			public void Dispose()
			{
				if (global::System.Threading.Interlocked.Exchange(ref this._disposed, 1) == 0)
				{
					global::NLog.MappedDiagnosticsLogicalContext.Remove(this._item);
				}
			}

			// Token: 0x0400051A RID: 1306
			private readonly string _item;

			// Token: 0x0400051B RID: 1307
			private int _disposed;
		}
	}
}
