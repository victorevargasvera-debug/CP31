using System;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000247 RID: 583
	internal static class IDbAsyncEnumeratorExtensions
	{
		// Token: 0x06001EAB RID: 7851 RVA: 0x00054965 File Offset: 0x00052B65
		public static global::System.Threading.Tasks.Task<bool> MoveNextAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator enumerator)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator>(enumerator, "enumerator");
			return enumerator.MoveNextAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0005497E File Offset: 0x00052B7E
		internal static global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TResult> Cast<TResult>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator source)
		{
			return new global::System.Data.Entity.Infrastructure.IDbAsyncEnumeratorExtensions.CastDbAsyncEnumerator<TResult>(source);
		}

		// Token: 0x02000974 RID: 2420
		private class CastDbAsyncEnumerator<TResult> : global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TResult>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator, global::System.IDisposable
		{
			// Token: 0x06005E30 RID: 24112 RVA: 0x00145016 File Offset: 0x00143216
			public CastDbAsyncEnumerator(global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator sourceEnumerator)
			{
				this._underlyingEnumerator = sourceEnumerator;
			}

			// Token: 0x06005E31 RID: 24113 RVA: 0x00145025 File Offset: 0x00143225
			public global::System.Threading.Tasks.Task<bool> MoveNextAsync(global::System.Threading.CancellationToken cancellationToken)
			{
				return this._underlyingEnumerator.MoveNextAsync(cancellationToken);
			}

			// Token: 0x17001078 RID: 4216
			// (get) Token: 0x06005E32 RID: 24114 RVA: 0x00145033 File Offset: 0x00143233
			public TResult Current
			{
				get
				{
					return (TResult)((object)this._underlyingEnumerator.Current);
				}
			}

			// Token: 0x17001079 RID: 4217
			// (get) Token: 0x06005E33 RID: 24115 RVA: 0x00145045 File Offset: 0x00143245
			object global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
			{
				get
				{
					return this._underlyingEnumerator.Current;
				}
			}

			// Token: 0x06005E34 RID: 24116 RVA: 0x00145052 File Offset: 0x00143252
			public void Dispose()
			{
				this._underlyingEnumerator.Dispose();
			}

			// Token: 0x040026EF RID: 9967
			private readonly global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator _underlyingEnumerator;
		}
	}
}
