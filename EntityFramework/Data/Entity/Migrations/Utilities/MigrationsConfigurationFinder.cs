using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace System.Data.Entity.Migrations.Utilities
{
	// Token: 0x020000A6 RID: 166
	internal class MigrationsConfigurationFinder
	{
		// Token: 0x06000EEC RID: 3820 RVA: 0x0001E91B File Offset: 0x0001CB1B
		public MigrationsConfigurationFinder()
		{
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0001E923 File Offset: 0x0001CB23
		public MigrationsConfigurationFinder(global::System.Data.Entity.Utilities.TypeFinder typeFinder)
		{
			this._typeFinder = typeFinder;
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0001E934 File Offset: 0x0001CB34
		public virtual global::System.Data.Entity.Migrations.DbMigrationsConfiguration FindMigrationsConfiguration(global::System.Type contextType, string configurationTypeName, global::System.Func<string, global::System.Exception> noType = null, global::System.Func<string, global::System.Collections.Generic.IEnumerable<global::System.Type>, global::System.Exception> multipleTypes = null, global::System.Func<string, string, global::System.Exception> noTypeWithName = null, global::System.Func<string, string, global::System.Exception> multipleTypesWithName = null)
		{
			global::System.Type type = this._typeFinder.FindType((contextType == null) ? typeof(global::System.Data.Entity.Migrations.DbMigrationsConfiguration) : typeof(global::System.Data.Entity.Migrations.DbMigrationsConfiguration<>).MakeGenericType(new global::System.Type[]
			{
				contextType
			}), configurationTypeName, (global::System.Collections.Generic.IEnumerable<global::System.Type> types) => (from t in types
			where t.GetPublicConstructor(new global::System.Type[0]) != null && !t.IsAbstract() && !t.IsGenericType()
			select t).ToList<global::System.Type>(), noType, multipleTypes, noTypeWithName, multipleTypesWithName);
			global::System.Data.Entity.Migrations.DbMigrationsConfiguration result;
			try
			{
				global::System.Data.Entity.Migrations.DbMigrationsConfiguration dbMigrationsConfiguration;
				if (!(type == null))
				{
					dbMigrationsConfiguration = type.CreateInstance(new global::System.Func<string, string, string>(global::System.Data.Entity.Resources.Strings.CreateInstance_BadMigrationsConfigurationType), (string s) => new global::System.Data.Entity.Migrations.Infrastructure.MigrationsException(s));
				}
				else
				{
					dbMigrationsConfiguration = null;
				}
				result = dbMigrationsConfiguration;
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				global::System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
				throw ex.InnerException;
			}
			return result;
		}

		// Token: 0x0400083B RID: 2107
		private readonly global::System.Data.Entity.Utilities.TypeFinder _typeFinder;
	}
}
