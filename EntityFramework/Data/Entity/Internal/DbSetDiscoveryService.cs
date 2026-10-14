using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000F8 RID: 248
	internal class DbSetDiscoveryService
	{
		// Token: 0x0600124A RID: 4682 RVA: 0x0002EEEE File Offset: 0x0002D0EE
		public DbSetDiscoveryService(global::System.Data.Entity.DbContext context)
		{
			this._context = context;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0002EF00 File Offset: 0x0002D100
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<string>> GetSets()
		{
			global::System.Data.Entity.Internal.DbContextTypesInitializersPair dbContextTypesInitializersPair;
			if (!global::System.Data.Entity.Internal.DbSetDiscoveryService._objectSetInitializers.TryGetValue(this._context.GetType(), out dbContextTypesInitializersPair))
			{
				global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(global::System.Data.Entity.DbContext), "dbContext");
				global::System.Collections.Generic.List<global::System.Action<global::System.Data.Entity.DbContext>> initDelegates = new global::System.Collections.Generic.List<global::System.Action<global::System.Data.Entity.DbContext>>();
				global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<string>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<string>>();
				foreach (global::System.Reflection.PropertyInfo propertyInfo in from p in this._context.GetType().GetInstanceProperties()
				where p.GetIndexParameters().Length == 0 && p.DeclaringType != typeof(global::System.Data.Entity.DbContext)
				select p)
				{
					global::System.Type setType = global::System.Data.Entity.Internal.DbSetDiscoveryService.GetSetType(propertyInfo.PropertyType);
					if (setType != null)
					{
						if (!setType.IsValidStructuralType())
						{
							throw global::System.Data.Entity.Resources.Error.InvalidEntityType(setType);
						}
						global::System.Collections.Generic.List<string> list;
						if (!dictionary.TryGetValue(setType, out list))
						{
							list = new global::System.Collections.Generic.List<string>();
							dictionary[setType] = list;
						}
						list.Add(propertyInfo.Name);
						if (global::System.Data.Entity.Internal.DbSetDiscoveryService.DbSetPropertyShouldBeInitialized(propertyInfo))
						{
							global::System.Reflection.MethodInfo methodInfo = propertyInfo.Setter();
							if (methodInfo != null && methodInfo.IsPublic)
							{
								global::System.Reflection.MethodInfo method = global::System.Data.Entity.Internal.DbSetDiscoveryService.SetMethod.MakeGenericMethod(new global::System.Type[]
								{
									setType
								});
								global::System.Linq.Expressions.MethodCallExpression methodCallExpression = global::System.Linq.Expressions.Expression.Call(parameterExpression, method);
								global::System.Linq.Expressions.MethodCallExpression body = global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Convert(parameterExpression, this._context.GetType()), methodInfo, new global::System.Linq.Expressions.Expression[]
								{
									methodCallExpression
								});
								initDelegates.Add(global::System.Linq.Expressions.Expression.Lambda<global::System.Action<global::System.Data.Entity.DbContext>>(body, new global::System.Linq.Expressions.ParameterExpression[]
								{
									parameterExpression
								}).Compile());
							}
						}
					}
				}
				global::System.Action<global::System.Data.Entity.DbContext> setsInitializer = delegate(global::System.Data.Entity.DbContext dbContext)
				{
					foreach (global::System.Action<global::System.Data.Entity.DbContext> action in initDelegates)
					{
						action(dbContext);
					}
				};
				dbContextTypesInitializersPair = new global::System.Data.Entity.Internal.DbContextTypesInitializersPair(dictionary, setsInitializer);
				global::System.Data.Entity.Internal.DbSetDiscoveryService._objectSetInitializers.TryAdd(this._context.GetType(), dbContextTypesInitializersPair);
			}
			return dbContextTypesInitializersPair.EntityTypeToPropertyNameMap;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0002F0F0 File Offset: 0x0002D2F0
		public void InitializeSets()
		{
			this.GetSets();
			global::System.Data.Entity.Internal.DbSetDiscoveryService._objectSetInitializers[this._context.GetType()].SetsInitializer(this._context);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0002F120 File Offset: 0x0002D320
		public void RegisterSets(global::System.Data.Entity.DbModelBuilder modelBuilder)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Collections.Generic.List<string>>> enumerable = this.GetSets();
			if (modelBuilder.Version.IsEF6OrHigher())
			{
				enumerable = from s in enumerable
				orderby s.Value[0]
				select s;
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Collections.Generic.List<string>> keyValuePair in enumerable)
			{
				if (keyValuePair.Value.Count > 1)
				{
					throw global::System.Data.Entity.Resources.Error.Mapping_MESTNotSupported(keyValuePair.Value[0], keyValuePair.Value[1], keyValuePair.Key);
				}
				modelBuilder.Entity(keyValuePair.Key).EntitySetName = keyValuePair.Value[0];
			}
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		private static bool DbSetPropertyShouldBeInitialized(global::System.Reflection.PropertyInfo propertyInfo)
		{
			return !propertyInfo.GetCustomAttributes(false).Any<global::System.Data.Entity.Infrastructure.SuppressDbSetInitializationAttribute>() && !propertyInfo.DeclaringType.GetCustomAttributes(false).Any<global::System.Data.Entity.Infrastructure.SuppressDbSetInitializationAttribute>();
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0002F218 File Offset: 0x0002D418
		private static global::System.Type GetSetType(global::System.Type declaredType)
		{
			if (!declaredType.IsArray)
			{
				global::System.Type setElementType = global::System.Data.Entity.Internal.DbSetDiscoveryService.GetSetElementType(declaredType);
				if (setElementType != null)
				{
					global::System.Type c = typeof(global::System.Data.Entity.DbSet<>).MakeGenericType(new global::System.Type[]
					{
						setElementType
					});
					if (declaredType.IsAssignableFrom(c))
					{
						return setElementType;
					}
				}
			}
			return null;
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0002F264 File Offset: 0x0002D464
		private static global::System.Type GetSetElementType(global::System.Type setType)
		{
			try
			{
				global::System.Type type = (setType.IsGenericType() && typeof(global::System.Data.Entity.IDbSet<>).IsAssignableFrom(setType.GetGenericTypeDefinition())) ? setType : setType.GetInterface(typeof(global::System.Data.Entity.IDbSet<>).FullName);
				if (type != null && !type.ContainsGenericParameters())
				{
					return type.GetGenericArguments()[0];
				}
			}
			catch (global::System.Reflection.AmbiguousMatchException)
			{
			}
			return null;
		}

		// Token: 0x04000912 RID: 2322
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Data.Entity.Internal.DbContextTypesInitializersPair> _objectSetInitializers = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Data.Entity.Internal.DbContextTypesInitializersPair>();

		// Token: 0x04000913 RID: 2323
		public static readonly global::System.Reflection.MethodInfo SetMethod = typeof(global::System.Data.Entity.DbContext).GetDeclaredMethod("Set", new global::System.Type[0]);

		// Token: 0x04000914 RID: 2324
		private readonly global::System.Data.Entity.DbContext _context;
	}
}
