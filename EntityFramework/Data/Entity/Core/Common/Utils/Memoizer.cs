using System;
using System.Collections.Generic;
using System.Threading;

namespace System.Data.Entity.Core.Common.Utils
{
	// Token: 0x020005F9 RID: 1529
	internal sealed class Memoizer<TArg, TResult>
	{
		// Token: 0x06004ACC RID: 19148 RVA: 0x001081B4 File Offset: 0x001063B4
		internal Memoizer(global::System.Func<TArg, TResult> function, global::System.Collections.Generic.IEqualityComparer<TArg> argComparer)
		{
			this._function = function;
			this._resultCache = new global::System.Collections.Generic.Dictionary<TArg, global::System.Data.Entity.Core.Common.Utils.Memoizer<TArg, TResult>.Result>(argComparer);
			this._lock = new global::System.Threading.ReaderWriterLockSlim();
		}

		// Token: 0x06004ACD RID: 19149 RVA: 0x001081DC File Offset: 0x001063DC
		internal TResult Evaluate(TArg arg)
		{
			global::System.Data.Entity.Core.Common.Utils.Memoizer<TArg, TResult>.Result result;
			if (!this.TryGetResult(arg, out result))
			{
				this._lock.EnterWriteLock();
				try
				{
					if (!this._resultCache.TryGetValue(arg, out result))
					{
						result = new global::System.Data.Entity.Core.Common.Utils.Memoizer<TArg, TResult>.Result(() => this._function(arg));
						this._resultCache.Add(arg, result);
					}
				}
				finally
				{
					this._lock.ExitWriteLock();
				}
			}
			return result.GetValue();
		}

		// Token: 0x06004ACE RID: 19150 RVA: 0x00108278 File Offset: 0x00106478
		internal bool TryGetValue(TArg arg, out TResult value)
		{
			global::System.Data.Entity.Core.Common.Utils.Memoizer<TArg, TResult>.Result result;
			if (this.TryGetResult(arg, out result))
			{
				value = result.GetValue();
				return true;
			}
			value = default(TResult);
			return false;
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x001082A8 File Offset: 0x001064A8
		private bool TryGetResult(TArg arg, out global::System.Data.Entity.Core.Common.Utils.Memoizer<TArg, TResult>.Result result)
		{
			this._lock.EnterReadLock();
			bool result2;
			try
			{
				result2 = this._resultCache.TryGetValue(arg, out result);
			}
			finally
			{
				this._lock.ExitReadLock();
			}
			return result2;
		}

		// Token: 0x04001A47 RID: 6727
		private readonly global::System.Func<TArg, TResult> _function;

		// Token: 0x04001A48 RID: 6728
		private readonly global::System.Collections.Generic.Dictionary<TArg, global::System.Data.Entity.Core.Common.Utils.Memoizer<TArg, TResult>.Result> _resultCache;

		// Token: 0x04001A49 RID: 6729
		private readonly global::System.Threading.ReaderWriterLockSlim _lock;

		// Token: 0x02000C3C RID: 3132
		private class Result
		{
			// Token: 0x06006A39 RID: 27193 RVA: 0x0016AB3B File Offset: 0x00168D3B
			internal Result(global::System.Func<TResult> createValueDelegate)
			{
				this._delegate = createValueDelegate;
			}

			// Token: 0x06006A3A RID: 27194 RVA: 0x0016AB4C File Offset: 0x00168D4C
			internal TResult GetValue()
			{
				if (this._delegate == null)
				{
					return this._value;
				}
				TResult value;
				lock (this)
				{
					if (this._delegate == null)
					{
						value = this._value;
					}
					else
					{
						this._value = this._delegate();
						this._delegate = null;
						value = this._value;
					}
				}
				return value;
			}

			// Token: 0x0400308A RID: 12426
			private TResult _value;

			// Token: 0x0400308B RID: 12427
			private global::System.Func<TResult> _delegate;
		}
	}
}
