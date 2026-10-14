using System;
using System.Diagnostics;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200012A RID: 298
	internal class RetryAction<TInput>
	{
		// Token: 0x06001499 RID: 5273 RVA: 0x00034E0F File Offset: 0x0003300F
		public RetryAction(global::System.Action<TInput> action)
		{
			this._action = action;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00034E2C File Offset: 0x0003302C
		[global::System.Diagnostics.DebuggerStepThrough]
		public void PerformAction(TInput input)
		{
			object @lock = this._lock;
			lock (@lock)
			{
				if (this._action != null)
				{
					global::System.Action<TInput> action = this._action;
					this._action = null;
					try
					{
						action(input);
					}
					catch (global::System.Exception)
					{
						this._action = action;
						throw;
					}
				}
			}
		}

		// Token: 0x040009AD RID: 2477
		private readonly object _lock = new object();

		// Token: 0x040009AE RID: 2478
		private global::System.Action<TInput> _action;
	}
}
