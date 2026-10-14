using System;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000517 RID: 1303
	internal class ObjectItemNoOpAssemblyLoader : global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader
	{
		// Token: 0x0600403E RID: 16446 RVA: 0x000D5754 File Offset: 0x000D3954
		internal ObjectItemNoOpAssemblyLoader(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData) : base(assembly, new global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry(), sessionData)
		{
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x000D5763 File Offset: 0x000D3963
		internal override void Load()
		{
			if (!base.SessionData.KnownAssemblies.Contains(base.SourceAssembly, base.SessionData.ObjectItemAssemblyLoaderFactory, base.SessionData.EdmItemCollection))
			{
				this.AddToKnownAssemblies();
			}
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x000D5799 File Offset: 0x000D3999
		protected override void AddToAssembliesLoaded()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x000D57A0 File Offset: 0x000D39A0
		protected override void LoadTypesFromAssembly()
		{
			throw new global::System.NotImplementedException();
		}
	}
}
