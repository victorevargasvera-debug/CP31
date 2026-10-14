using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Reflection;

namespace System.Data.Entity.Internal.MockingProxies
{
	// Token: 0x0200013B RID: 315
	internal class ObjectContextProxy : global::System.IDisposable
	{
		// Token: 0x060014DE RID: 5342 RVA: 0x00035CF0 File Offset: 0x00033EF0
		protected ObjectContextProxy()
		{
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00035CF8 File Offset: 0x00033EF8
		public ObjectContextProxy(global::System.Data.Entity.Core.Objects.ObjectContext objectContext)
		{
			this._objectContext = objectContext;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00035D07 File Offset: 0x00033F07
		public static implicit operator global::System.Data.Entity.Core.Objects.ObjectContext(global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy proxy)
		{
			if (proxy != null)
			{
				return proxy._objectContext;
			}
			return null;
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060014E1 RID: 5345 RVA: 0x00035D14 File Offset: 0x00033F14
		public virtual global::System.Data.Entity.Internal.MockingProxies.EntityConnectionProxy Connection
		{
			get
			{
				return new global::System.Data.Entity.Internal.MockingProxies.EntityConnectionProxy((global::System.Data.Entity.Core.EntityClient.EntityConnection)this._objectContext.Connection);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x060014E2 RID: 5346 RVA: 0x00035D2B File Offset: 0x00033F2B
		// (set) Token: 0x060014E3 RID: 5347 RVA: 0x00035D38 File Offset: 0x00033F38
		public virtual string DefaultContainerName
		{
			get
			{
				return this._objectContext.DefaultContainerName;
			}
			set
			{
				this._objectContext.DefaultContainerName = value;
			}
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00035D46 File Offset: 0x00033F46
		public virtual void Dispose()
		{
			this._objectContext.Dispose();
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00035D54 File Offset: 0x00033F54
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> GetObjectItemCollection()
		{
			return this._objectItemCollection = (global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection)this._objectContext.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00035D80 File Offset: 0x00033F80
		public virtual global::System.Type GetClrType(global::System.Data.Entity.Core.Metadata.Edm.StructuralType item)
		{
			return this._objectItemCollection.GetClrType(item);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00035D8E File Offset: 0x00033F8E
		public virtual global::System.Type GetClrType(global::System.Data.Entity.Core.Metadata.Edm.EnumType item)
		{
			return this._objectItemCollection.GetClrType(item);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00035D9C File Offset: 0x00033F9C
		public virtual void LoadFromAssembly(global::System.Reflection.Assembly assembly)
		{
			this._objectContext.MetadataWorkspace.LoadFromAssembly(assembly);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00035DAF File Offset: 0x00033FAF
		public virtual global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy CreateNew(global::System.Data.Entity.Internal.MockingProxies.EntityConnectionProxy entityConnection)
		{
			return new global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy(new global::System.Data.Entity.Core.Objects.ObjectContext(entityConnection));
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00035DC4 File Offset: 0x00033FC4
		public virtual void CopyContextOptions(global::System.Data.Entity.Internal.MockingProxies.ObjectContextProxy source)
		{
			this._objectContext.ContextOptions.LazyLoadingEnabled = source._objectContext.ContextOptions.LazyLoadingEnabled;
			this._objectContext.ContextOptions.ProxyCreationEnabled = source._objectContext.ContextOptions.ProxyCreationEnabled;
			this._objectContext.ContextOptions.UseCSharpNullComparisonBehavior = source._objectContext.ContextOptions.UseCSharpNullComparisonBehavior;
			this._objectContext.ContextOptions.UseConsistentNullReferenceBehavior = source._objectContext.ContextOptions.UseConsistentNullReferenceBehavior;
			this._objectContext.ContextOptions.UseLegacyPreserveChangesBehavior = source._objectContext.ContextOptions.UseLegacyPreserveChangesBehavior;
			this._objectContext.CommandTimeout = source._objectContext.CommandTimeout;
			this._objectContext.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions = source._objectContext.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions;
			this._objectContext.InterceptionContext = source._objectContext.InterceptionContext.WithObjectContext(this._objectContext);
		}

		// Token: 0x040009C6 RID: 2502
		private readonly global::System.Data.Entity.Core.Objects.ObjectContext _objectContext;

		// Token: 0x040009C7 RID: 2503
		private global::System.Data.Entity.Core.Metadata.Edm.ObjectItemCollection _objectItemCollection;
	}
}
