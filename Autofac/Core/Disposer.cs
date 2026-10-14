using System;
using System.Collections.Generic;
using Autofac.Util;

namespace Autofac.Core
{
	// Token: 0x02000064 RID: 100
	internal class Disposer : global::Autofac.Util.Disposable, global::Autofac.Core.IDisposer, global::System.IDisposable
	{
		// Token: 0x0600025E RID: 606 RVA: 0x00008834 File Offset: 0x00006A34
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				object synchRoot = this._synchRoot;
				lock (synchRoot)
				{
					while (this._items.Count > 0)
					{
						this._items.Pop().Dispose();
					}
					this._items = null;
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000088A0 File Offset: 0x00006AA0
		public void AddInstanceForDisposal(global::System.IDisposable instance)
		{
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			object synchRoot = this._synchRoot;
			lock (synchRoot)
			{
				this._items.Push(instance);
			}
		}

		// Token: 0x04000087 RID: 135
		private global::System.Collections.Generic.Stack<global::System.IDisposable> _items = new global::System.Collections.Generic.Stack<global::System.IDisposable>();

		// Token: 0x04000088 RID: 136
		private readonly object _synchRoot = new object();
	}
}
