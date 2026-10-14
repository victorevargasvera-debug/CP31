using System;
using System.Collections.Generic;
using NLog.Internal;

namespace NLog
{
	// Token: 0x02000014 RID: 20
	public static class MappedDiagnosticsContext
	{
		// Token: 0x06000410 RID: 1040 RVA: 0x00008298 File Offset: 0x00006498
		private static global::System.Collections.Generic.IDictionary<string, object> GetThreadDictionary(bool create = true)
		{
			global::System.Collections.Generic.Dictionary<string, object> dataForSlot = global::NLog.Internal.ThreadLocalStorageHelper.GetDataForSlot<global::System.Collections.Generic.Dictionary<string, object>>(global::NLog.MappedDiagnosticsContext.dataSlot, create);
			if (dataForSlot == null && !create)
			{
				return global::NLog.MappedDiagnosticsContext.EmptyDefaultDictionary;
			}
			return dataForSlot;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000082BE File Offset: 0x000064BE
		public static global::System.IDisposable SetScoped(string item, string value)
		{
			global::NLog.MappedDiagnosticsContext.Set(item, value);
			return new global::NLog.MappedDiagnosticsContext.ItemRemover(item);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x000082CD File Offset: 0x000064CD
		public static global::System.IDisposable SetScoped(string item, object value)
		{
			global::NLog.MappedDiagnosticsContext.Set(item, value);
			return new global::NLog.MappedDiagnosticsContext.ItemRemover(item);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x000082DC File Offset: 0x000064DC
		public static void Set(string item, string value)
		{
			global::NLog.MappedDiagnosticsContext.GetThreadDictionary(true)[item] = value;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000082EB File Offset: 0x000064EB
		public static void Set(string item, object value)
		{
			global::NLog.MappedDiagnosticsContext.GetThreadDictionary(true)[item] = value;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000082FA File Offset: 0x000064FA
		public static string Get(string item)
		{
			return global::NLog.MappedDiagnosticsContext.Get(item, null);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00008303 File Offset: 0x00006503
		public static string Get(string item, global::System.IFormatProvider formatProvider)
		{
			return global::NLog.Internal.FormatHelper.ConvertToString(global::NLog.MappedDiagnosticsContext.GetObject(item), formatProvider);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00008314 File Offset: 0x00006514
		public static object GetObject(string item)
		{
			object result;
			if (!global::NLog.MappedDiagnosticsContext.GetThreadDictionary(false).TryGetValue(item, out result))
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00008334 File Offset: 0x00006534
		public static global::System.Collections.Generic.ICollection<string> GetNames()
		{
			return global::NLog.MappedDiagnosticsContext.GetThreadDictionary(false).Keys;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00008341 File Offset: 0x00006541
		public static bool Contains(string item)
		{
			return global::NLog.MappedDiagnosticsContext.GetThreadDictionary(false).ContainsKey(item);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000834F File Offset: 0x0000654F
		public static void Remove(string item)
		{
			global::NLog.MappedDiagnosticsContext.GetThreadDictionary(true).Remove(item);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000835E File Offset: 0x0000655E
		public static void Clear()
		{
			global::NLog.MappedDiagnosticsContext.GetThreadDictionary(true).Clear();
		}

		// Token: 0x04000040 RID: 64
		private static readonly object dataSlot = global::NLog.Internal.ThreadLocalStorageHelper.AllocateDataSlot();

		// Token: 0x04000041 RID: 65
		private static readonly global::System.Collections.Generic.IDictionary<string, object> EmptyDefaultDictionary = default(global::NLog.Internal.SortHelpers.ReadOnlySingleBucketDictionary<string, object>);

		// Token: 0x020001C1 RID: 449
		private class ItemRemover : global::System.IDisposable
		{
			// Token: 0x060011CA RID: 4554 RVA: 0x0002EBD7 File Offset: 0x0002CDD7
			public ItemRemover(string item)
			{
				this._item = item;
			}

			// Token: 0x060011CB RID: 4555 RVA: 0x0002EBE6 File Offset: 0x0002CDE6
			public void Dispose()
			{
				if (!this._disposed)
				{
					this._disposed = true;
					global::NLog.MappedDiagnosticsContext.Remove(this._item);
				}
			}

			// Token: 0x04000518 RID: 1304
			private readonly string _item;

			// Token: 0x04000519 RID: 1305
			private bool _disposed;
		}
	}
}
