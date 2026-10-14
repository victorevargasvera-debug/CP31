using System;
using Autofac.Core;

namespace Autofac.Features.Indexed
{
	// Token: 0x0200004A RID: 74
	internal class KeyedServiceIndex<TKey, TValue> : global::Autofac.Features.Indexed.IIndex<TKey, TValue>
	{
		// Token: 0x060001EB RID: 491 RVA: 0x0000780E File Offset: 0x00005A0E
		public KeyedServiceIndex(global::Autofac.IComponentContext context)
		{
			if (context == null)
			{
				throw new global::System.ArgumentNullException("context");
			}
			this._context = context;
		}

		// Token: 0x17000079 RID: 121
		public TValue this[TKey key]
		{
			get
			{
				return (TValue)((object)this._context.ResolveService(global::Autofac.Features.Indexed.KeyedServiceIndex<TKey, TValue>.GetService(key)));
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00007844 File Offset: 0x00005A44
		public bool TryGetValue(TKey key, out TValue value)
		{
			object obj;
			if (this._context.TryResolveService(global::Autofac.Features.Indexed.KeyedServiceIndex<TKey, TValue>.GetService(key), out obj))
			{
				value = (TValue)((object)obj);
				return true;
			}
			value = default(TValue);
			return false;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000787C File Offset: 0x00005A7C
		private static global::Autofac.Core.KeyedService GetService(TKey key)
		{
			return new global::Autofac.Core.KeyedService(key, typeof(TValue));
		}

		// Token: 0x0400005E RID: 94
		private readonly global::Autofac.IComponentContext _context;
	}
}
