using System;
using System.Text;
using System.Threading;

namespace NLog.Internal
{
	// Token: 0x02000128 RID: 296
	internal class StringBuilderPool
	{
		// Token: 0x06000DBB RID: 3515 RVA: 0x00022D44 File Offset: 0x00020F44
		public StringBuilderPool(int poolCapacity, int initialBuilderCapacity = 16384, int maxBuilderCapacity = 524288)
		{
			this._fastPool = new global::System.Text.StringBuilder(global::System.Math.Max(initialBuilderCapacity, 16384));
			this._slowPool = new global::System.Text.StringBuilder[poolCapacity];
			for (int i = 0; i < this._slowPool.Length; i++)
			{
				this._slowPool[i] = new global::System.Text.StringBuilder(initialBuilderCapacity);
			}
			this._maxBuilderCapacity = maxBuilderCapacity;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00022DA4 File Offset: 0x00020FA4
		public global::NLog.Internal.StringBuilderPool.ItemHolder Acquire()
		{
			global::System.Text.StringBuilder stringBuilder = this._fastPool;
			if (stringBuilder == null || stringBuilder != global::System.Threading.Interlocked.CompareExchange<global::System.Text.StringBuilder>(ref this._fastPool, null, stringBuilder))
			{
				for (int i = 0; i < this._slowPool.Length; i++)
				{
					stringBuilder = this._slowPool[i];
					if (stringBuilder != null && stringBuilder == global::System.Threading.Interlocked.CompareExchange<global::System.Text.StringBuilder>(ref this._slowPool[i], null, stringBuilder))
					{
						return new global::NLog.Internal.StringBuilderPool.ItemHolder(stringBuilder, this, i);
					}
				}
				return new global::NLog.Internal.StringBuilderPool.ItemHolder(new global::System.Text.StringBuilder(), null, 0);
			}
			return new global::NLog.Internal.StringBuilderPool.ItemHolder(stringBuilder, this, -1);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00022E1E File Offset: 0x0002101E
		private void Release(global::System.Text.StringBuilder stringBuilder, int poolIndex)
		{
			if (stringBuilder.Length > this._maxBuilderCapacity)
			{
				stringBuilder = new global::System.Text.StringBuilder(this._maxBuilderCapacity / 2);
			}
			else
			{
				stringBuilder.Length = 0;
			}
			if (poolIndex == -1)
			{
				this._fastPool = stringBuilder;
				return;
			}
			this._slowPool[poolIndex] = stringBuilder;
		}

		// Token: 0x040003C5 RID: 965
		private global::System.Text.StringBuilder _fastPool;

		// Token: 0x040003C6 RID: 966
		private readonly global::System.Text.StringBuilder[] _slowPool;

		// Token: 0x040003C7 RID: 967
		private readonly int _maxBuilderCapacity;

		// Token: 0x0200021A RID: 538
		public struct ItemHolder : global::System.IDisposable
		{
			// Token: 0x06001323 RID: 4899 RVA: 0x0003185F File Offset: 0x0002FA5F
			public ItemHolder(global::System.Text.StringBuilder stringBuilder, global::NLog.Internal.StringBuilderPool owner, int poolIndex)
			{
				this.Item = stringBuilder;
				this._owner = owner;
				this._poolIndex = poolIndex;
			}

			// Token: 0x06001324 RID: 4900 RVA: 0x00031876 File Offset: 0x0002FA76
			public void Dispose()
			{
				if (this._owner != null)
				{
					this._owner.Release(this.Item, this._poolIndex);
				}
			}

			// Token: 0x040005EF RID: 1519
			public readonly global::System.Text.StringBuilder Item;

			// Token: 0x040005F0 RID: 1520
			private readonly global::NLog.Internal.StringBuilderPool _owner;

			// Token: 0x040005F1 RID: 1521
			private readonly int _poolIndex;
		}
	}
}
