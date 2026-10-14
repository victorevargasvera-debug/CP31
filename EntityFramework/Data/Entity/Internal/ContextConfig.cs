using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Internal.ConfigFile;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000F0 RID: 240
	internal class ContextConfig
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x0002DEB7 File Offset: 0x0002C0B7
		public ContextConfig()
		{
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0002DECA File Offset: 0x0002C0CA
		public ContextConfig(global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection entityFrameworkSettings)
		{
			this._entityFrameworkSettings = entityFrameworkSettings;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0002DEE4 File Offset: 0x0002C0E4
		public virtual int? TryGetCommandTimeout(global::System.Type contextType)
		{
			global::System.Func<global::System.Data.Entity.Internal.ConfigFile.ContextElement, int?> <>9__2;
			return this._commandTimeouts.GetOrAdd(contextType, delegate(global::System.Type requiredContextType)
			{
				global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Internal.ConfigFile.ContextElement> source = from e in this._entityFrameworkSettings.Contexts.OfType<global::System.Data.Entity.Internal.ConfigFile.ContextElement>()
				where e.CommandTimeout != null
				select e;
				global::System.Func<global::System.Data.Entity.Internal.ConfigFile.ContextElement, int?> selector;
				if ((selector = <>9__2) == null)
				{
					selector = (<>9__2 = ((global::System.Data.Entity.Internal.ConfigFile.ContextElement e) => global::System.Data.Entity.Internal.ContextConfig.TryGetCommandTimeout(contextType, e.ContextTypeName, e.CommandTimeout.Value)));
				}
				return source.Select(selector).FirstOrDefault((int? i) => i != null);
			});
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0002DF24 File Offset: 0x0002C124
		private static int? TryGetCommandTimeout(global::System.Type requiredContextType, string contextTypeName, int commandTimeout)
		{
			try
			{
				if (global::System.Type.GetType(contextTypeName, true) == requiredContextType)
				{
					return new int?(commandTimeout);
				}
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Database_InitializationException, innerException);
			}
			return null;
		}

		// Token: 0x04000902 RID: 2306
		private readonly global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection _entityFrameworkSettings;

		// Token: 0x04000903 RID: 2307
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, int?> _commandTimeouts = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, int?>();
	}
}
