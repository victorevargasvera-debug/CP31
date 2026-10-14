using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000122 RID: 290
	internal class LazyEnumerator<T> : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		// Token: 0x0600143D RID: 5181 RVA: 0x0003385D File Offset: 0x00031A5D
		public LazyEnumerator(global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<T>> getObjectResult)
		{
			this._getObjectResult = getObjectResult;
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x0003386C File Offset: 0x00031A6C
		public T Current
		{
			get
			{
				if (this._objectResultEnumerator != null)
				{
					return this._objectResultEnumerator.Current;
				}
				return default(T);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600143F RID: 5183 RVA: 0x00033896 File Offset: 0x00031A96
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				return this.Current;
			}
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x000338A3 File Offset: 0x00031AA3
		public void Dispose()
		{
			if (this._objectResultEnumerator != null)
			{
				this._objectResultEnumerator.Dispose();
			}
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x000338B8 File Offset: 0x00031AB8
		public bool MoveNext()
		{
			if (this._objectResultEnumerator == null)
			{
				global::System.Data.Entity.Core.Objects.ObjectResult<T> objectResult = this._getObjectResult();
				try
				{
					this._objectResultEnumerator = objectResult.GetEnumerator();
				}
				catch
				{
					objectResult.Dispose();
					throw;
				}
			}
			return this._objectResultEnumerator.MoveNext();
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0003390C File Offset: 0x00031B0C
		public void Reset()
		{
			if (this._objectResultEnumerator != null)
			{
				this._objectResultEnumerator.Reset();
			}
		}

		// Token: 0x04000986 RID: 2438
		private readonly global::System.Func<global::System.Data.Entity.Core.Objects.ObjectResult<T>> _getObjectResult;

		// Token: 0x04000987 RID: 2439
		private global::System.Collections.Generic.IEnumerator<T> _objectResultEnumerator;
	}
}
