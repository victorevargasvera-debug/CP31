using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;

namespace System.Data.Entity.Internal.ConfigFile
{
	// Token: 0x0200014F RID: 335
	internal class InterceptorsCollection : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x060015A4 RID: 5540 RVA: 0x00037634 File Offset: 0x00035834
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			int nextKey = this._nextKey;
			this._nextKey = nextKey + 1;
			return new global::System.Data.Entity.Internal.ConfigFile.InterceptorElement(nextKey);
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x00037657 File Offset: 0x00035857
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			return ((global::System.Data.Entity.Internal.ConfigFile.InterceptorElement)element).Key;
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00037669 File Offset: 0x00035869
		public override global::System.Configuration.ConfigurationElementCollectionType CollectionType
		{
			get
			{
				return global::System.Configuration.ConfigurationElementCollectionType.BasicMap;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x0003766C File Offset: 0x0003586C
		protected override string ElementName
		{
			get
			{
				return "interceptor";
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00037673 File Offset: 0x00035873
		public void AddElement(global::System.Data.Entity.Internal.ConfigFile.InterceptorElement element)
		{
			base.BaseAdd(element);
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x0003767C File Offset: 0x0003587C
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor> Interceptors
		{
			get
			{
				return (from e in this.OfType<global::System.Data.Entity.Internal.ConfigFile.InterceptorElement>()
				select e.CreateInterceptor()).ToList<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>();
			}
		}

		// Token: 0x040009E7 RID: 2535
		private const string ElementKey = "interceptor";

		// Token: 0x040009E8 RID: 2536
		private int _nextKey;
	}
}
