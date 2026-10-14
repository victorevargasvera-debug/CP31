using System;
using System.Text;

namespace NLog.Internal
{
	// Token: 0x020000F6 RID: 246
	internal struct AppendBuilderCreator : global::System.IDisposable
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0001ED2D File Offset: 0x0001CF2D
		public global::System.Text.StringBuilder Builder
		{
			get
			{
				return this._builder.Item;
			}
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x0001ED3A File Offset: 0x0001CF3A
		public AppendBuilderCreator(global::System.Text.StringBuilder appendTarget, bool mustBeEmpty)
		{
			this._appendTarget = appendTarget;
			if (this._appendTarget.Length > 0 && mustBeEmpty)
			{
				this._builder = global::NLog.Internal.AppendBuilderCreator._builderPool.Acquire();
				return;
			}
			this._builder = new global::NLog.Internal.StringBuilderPool.ItemHolder(this._appendTarget, null, 0);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x0001ED7C File Offset: 0x0001CF7C
		public void Dispose()
		{
			if (this._builder.Item != this._appendTarget)
			{
				this._builder.Item.CopyTo(this._appendTarget);
				this._builder.Dispose();
			}
		}

		// Token: 0x0400037A RID: 890
		private static readonly global::NLog.Internal.StringBuilderPool _builderPool = new global::NLog.Internal.StringBuilderPool(global::System.Environment.ProcessorCount * 2, 16384, 524288);

		// Token: 0x0400037B RID: 891
		private readonly global::System.Text.StringBuilder _appendTarget;

		// Token: 0x0400037C RID: 892
		private readonly global::NLog.Internal.StringBuilderPool.ItemHolder _builder;
	}
}
