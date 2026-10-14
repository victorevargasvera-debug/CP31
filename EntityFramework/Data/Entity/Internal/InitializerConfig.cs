using System;
using System.Configuration;
using System.Data.Entity.Internal.ConfigFile;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000119 RID: 281
	internal class InitializerConfig
	{
		// Token: 0x06001371 RID: 4977 RVA: 0x000319B6 File Offset: 0x0002FBB6
		public InitializerConfig()
		{
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x000319BE File Offset: 0x0002FBBE
		public InitializerConfig(global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection entityFrameworkSettings, global::System.Configuration.KeyValueConfigurationCollection appSettings)
		{
			this._entityFrameworkSettings = entityFrameworkSettings;
			this._appSettings = appSettings;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x000319D4 File Offset: 0x0002FBD4
		private static object TryGetInitializer(global::System.Type requiredContextType, string contextTypeName, string initializerTypeName, bool isDisabled, global::System.Func<object[]> initializerArgs, global::System.Func<object, object, string> exceptionMessage)
		{
			try
			{
				if (global::System.Type.GetType(contextTypeName, true) == requiredContextType)
				{
					if (isDisabled)
					{
						return global::System.Activator.CreateInstance(typeof(global::System.Data.Entity.NullDatabaseInitializer<>).MakeGenericType(new global::System.Type[]
						{
							requiredContextType
						}));
					}
					return global::System.Activator.CreateInstance(global::System.Type.GetType(initializerTypeName, true), initializerArgs());
				}
			}
			catch (global::System.Exception innerException)
			{
				string arg = isDisabled ? "Disabled" : initializerTypeName;
				throw new global::System.InvalidOperationException(exceptionMessage(arg, contextTypeName), innerException);
			}
			return null;
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00031A5C File Offset: 0x0002FC5C
		public virtual object TryGetInitializer(global::System.Type contextType)
		{
			return this.TryGetInitializerFromEntityFrameworkSection(contextType) ?? this.TryGetInitializerFromLegacyConfig(contextType);
		}

		// Token: 0x06001375 RID: 4981 RVA: 0x00031A70 File Offset: 0x0002FC70
		private object TryGetInitializerFromEntityFrameworkSection(global::System.Type contextType)
		{
			return (from e in this._entityFrameworkSettings.Contexts.OfType<global::System.Data.Entity.Internal.ConfigFile.ContextElement>()
			where e.IsDatabaseInitializationDisabled || !string.IsNullOrWhiteSpace(e.DatabaseInitializer.InitializerTypeName)
			select global::System.Data.Entity.Internal.InitializerConfig.TryGetInitializer(contextType, e.ContextTypeName, e.DatabaseInitializer.InitializerTypeName ?? string.Empty, e.IsDatabaseInitializationDisabled, () => e.DatabaseInitializer.Parameters.GetTypedParameterValues(), new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Database_InitializeFromConfigFailed))).FirstOrDefault((object i) => i != null);
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00031AF4 File Offset: 0x0002FCF4
		private object TryGetInitializerFromLegacyConfig(global::System.Type contextType)
		{
			foreach (string text in from k in this._appSettings.AllKeys
			where k.StartsWith("DatabaseInitializerForType", global::System.StringComparison.OrdinalIgnoreCase)
			select k)
			{
				string text2 = text.Remove(0, "DatabaseInitializerForType".Length).Trim();
				string text3 = (this._appSettings[text].Value ?? string.Empty).Trim();
				if (string.IsNullOrWhiteSpace(text2))
				{
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.Database_BadLegacyInitializerEntry(text, text3));
				}
				object obj = global::System.Data.Entity.Internal.InitializerConfig.TryGetInitializer(contextType, text2, text3, text3.Length == 0 || text3.Equals("Disabled", global::System.StringComparison.OrdinalIgnoreCase), () => new object[0], new global::System.Func<object, object, string>(global::System.Data.Entity.Resources.Strings.Database_InitializeFromLegacyConfigFailed));
				if (obj != null)
				{
					return obj;
				}
			}
			return null;
		}

		// Token: 0x04000951 RID: 2385
		private const string ConfigKeyKey = "DatabaseInitializerForType";

		// Token: 0x04000952 RID: 2386
		private const string DisabledSpecialValue = "Disabled";

		// Token: 0x04000953 RID: 2387
		private readonly global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection _entityFrameworkSettings;

		// Token: 0x04000954 RID: 2388
		private readonly global::System.Configuration.KeyValueConfigurationCollection _appSettings;
	}
}
