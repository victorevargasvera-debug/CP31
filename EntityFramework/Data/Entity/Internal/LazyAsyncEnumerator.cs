using System;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000121 RID: 289
	internal class LazyAsyncEnumerator<T> : global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator, global::System.IDisposable
	{
		// Token: 0x06001437 RID: 5175 RVA: 0x0003378C File Offset: 0x0003198C
		public LazyAsyncEnumerator(global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<T>>> getObjectResultAsync)
		{
			this._getObjectResultAsync = getObjectResultAsync;
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x0003379C File Offset: 0x0003199C
		public T Current
		{
			get
			{
				if (this._objectResultAsyncEnumerator != null)
				{
					return this._objectResultAsyncEnumerator.Current;
				}
				return default(T);
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x000337C6 File Offset: 0x000319C6
		object global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x000337D3 File Offset: 0x000319D3
		public void Dispose()
		{
			if (this._objectResultAsyncEnumerator != null)
			{
				this._objectResultAsyncEnumerator.Dispose();
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000337E8 File Offset: 0x000319E8
		public global::System.Threading.Tasks.Task<bool> MoveNextAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (this._objectResultAsyncEnumerator != null)
			{
				return this._objectResultAsyncEnumerator.MoveNextAsync(cancellationToken);
			}
			return this.FirstMoveNextAsync(cancellationToken);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00033810 File Offset: 0x00031A10
		private async global::System.Threading.Tasks.Task<bool> FirstMoveNextAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Core.Objects.ObjectResult<T> objectResult = await this._getObjectResultAsync(cancellationToken).WithCurrentCulture<global::System.Data.Entity.Core.Objects.ObjectResult<T>>();
			try
			{
				this._objectResultAsyncEnumerator = ((global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>)objectResult).GetAsyncEnumerator();
			}
			catch
			{
				objectResult.Dispose();
				throw;
			}
			return await this._objectResultAsyncEnumerator.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>();
		}

		// Token: 0x04000984 RID: 2436
		private readonly global::System.Func<global::System.Threading.CancellationToken, global::System.Threading.Tasks.Task<global::System.Data.Entity.Core.Objects.ObjectResult<T>>> _getObjectResultAsync;

		// Token: 0x04000985 RID: 2437
		private global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> _objectResultAsyncEnumerator;
	}
}
