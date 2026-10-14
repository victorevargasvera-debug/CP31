using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B8 RID: 696
	internal class InvariantNameResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x060021F1 RID: 8689 RVA: 0x0005E68F File Offset: 0x0005C88F
		public InvariantNameResolver(global::System.Data.Common.DbProviderFactory providerFactory, string invariantName)
		{
			this._invariantName = new global::System.Data.Entity.Infrastructure.ProviderInvariantName(invariantName);
			this._providerFactoryType = providerFactory.GetType();
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0005E6B0 File Offset: 0x0005C8B0
		public virtual object GetService(global::System.Type type, object key)
		{
			if (type == typeof(global::System.Data.Entity.Infrastructure.IProviderInvariantName))
			{
				if (!(key is global::System.Data.Common.DbProviderFactory))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbDependencyResolver_InvalidKey(typeof(global::System.Data.Common.DbProviderFactory).Name, typeof(global::System.Data.Entity.Infrastructure.IProviderInvariantName)));
				}
				if (key.GetType() == this._providerFactoryType)
				{
					return this._invariantName;
				}
			}
			return null;
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0005E718 File Offset: 0x0005C918
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.InvariantNameResolver invariantNameResolver = obj as global::System.Data.Entity.Infrastructure.DependencyResolution.InvariantNameResolver;
			return invariantNameResolver != null && this._providerFactoryType == invariantNameResolver._providerFactoryType && this._invariantName.Name == invariantNameResolver._invariantName.Name;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0005E761 File Offset: 0x0005C961
		public override int GetHashCode()
		{
			return this._invariantName.Name.GetHashCode();
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0005E773 File Offset: 0x0005C973
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this.GetServiceAsServices(type, key);
		}

		// Token: 0x04000BCC RID: 3020
		private readonly global::System.Data.Entity.Infrastructure.IProviderInvariantName _invariantName;

		// Token: 0x04000BCD RID: 3021
		private readonly global::System.Type _providerFactoryType;
	}
}
