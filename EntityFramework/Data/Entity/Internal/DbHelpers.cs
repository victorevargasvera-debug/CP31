using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000F6 RID: 246
	internal static class DbHelpers
	{
		// Token: 0x06001225 RID: 4645 RVA: 0x0002E298 File Offset: 0x0002C498
		public static bool KeyValuesEqual(object x, object y)
		{
			if (x is global::System.DBNull)
			{
				x = null;
			}
			if (y is global::System.DBNull)
			{
				y = null;
			}
			if (object.Equals(x, y))
			{
				return true;
			}
			byte[] array = x as byte[];
			byte[] array2 = y as byte[];
			if (array == null || array2 == null || array.Length != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != array2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0002E300 File Offset: 0x0002C500
		public static bool PropertyValuesEqual(object x, object y)
		{
			if (x is global::System.DBNull)
			{
				x = null;
			}
			if (y is global::System.DBNull)
			{
				y = null;
			}
			if (x == null)
			{
				return y == null;
			}
			if (x.GetType().IsValueType() && object.Equals(x, y))
			{
				return true;
			}
			string text = x as string;
			if (text != null)
			{
				return text.Equals(y as string, global::System.StringComparison.Ordinal);
			}
			byte[] array = x as byte[];
			if (array == null)
			{
				return x == y;
			}
			byte[] array2 = y as byte[];
			if (array2 == null || array.Length != array2.Length)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != array2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0002E397 File Offset: 0x0002C597
		public static string QuoteIdentifier(string identifier)
		{
			return "[" + identifier.Replace("]", "]]") + "]";
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0002E3B8 File Offset: 0x0002C5B8
		public static bool TreatAsConnectionString(string nameOrConnectionString)
		{
			return nameOrConnectionString.IndexOf('=') >= 0;
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0002E3C8 File Offset: 0x0002C5C8
		public static bool TryGetConnectionName(string nameOrConnectionString, out string name)
		{
			int num = nameOrConnectionString.IndexOf('=');
			if (num < 0)
			{
				name = nameOrConnectionString;
				return true;
			}
			if (nameOrConnectionString.IndexOf('=', num + 1) >= 0)
			{
				name = null;
				return false;
			}
			if (nameOrConnectionString.Substring(0, num).Trim().Equals("name", global::System.StringComparison.OrdinalIgnoreCase))
			{
				name = nameOrConnectionString.Substring(num + 1).Trim();
				return true;
			}
			name = null;
			return false;
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0002E42C File Offset: 0x0002C62C
		public static bool IsFullEFConnectionString(string nameOrConnectionString)
		{
			global::System.Collections.Generic.IEnumerable<string> source = from t in nameOrConnectionString.ToUpperInvariant().Split(new char[]
			{
				'=',
				';'
			})
			select t.Trim();
			return source.Contains("PROVIDER") && source.Contains("PROVIDER CONNECTION STRING") && source.Contains("METADATA");
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0002E4A0 File Offset: 0x0002C6A0
		public static string ParsePropertySelector<TEntity, TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntity, TProperty>> property, string methodName, string paramName)
		{
			string text;
			if (!global::System.Data.Entity.Internal.DbHelpers.TryParsePath(property.Body, out text) || text == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbEntityEntry_BadPropertyExpression(methodName, typeof(TEntity).Name), paramName);
			}
			return text;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0002E4DC File Offset: 0x0002C6DC
		public static bool TryParsePath(global::System.Linq.Expressions.Expression expression, out string path)
		{
			path = null;
			global::System.Linq.Expressions.Expression expression2 = expression.RemoveConvert();
			global::System.Linq.Expressions.MemberExpression memberExpression = expression2 as global::System.Linq.Expressions.MemberExpression;
			global::System.Linq.Expressions.MethodCallExpression methodCallExpression = expression2 as global::System.Linq.Expressions.MethodCallExpression;
			if (memberExpression != null)
			{
				string name = memberExpression.Member.Name;
				string text;
				if (!global::System.Data.Entity.Internal.DbHelpers.TryParsePath(memberExpression.Expression, out text))
				{
					return false;
				}
				path = ((text == null) ? name : (text + "." + name));
			}
			else if (methodCallExpression != null)
			{
				if (methodCallExpression.Method.Name == "Select" && methodCallExpression.Arguments.Count == 2)
				{
					string text2;
					if (!global::System.Data.Entity.Internal.DbHelpers.TryParsePath(methodCallExpression.Arguments[0], out text2))
					{
						return false;
					}
					if (text2 != null)
					{
						global::System.Linq.Expressions.LambdaExpression lambdaExpression = methodCallExpression.Arguments[1] as global::System.Linq.Expressions.LambdaExpression;
						if (lambdaExpression != null)
						{
							string text3;
							if (!global::System.Data.Entity.Internal.DbHelpers.TryParsePath(lambdaExpression.Body, out text3))
							{
								return false;
							}
							if (text3 != null)
							{
								path = text2 + "." + text3;
								return true;
							}
						}
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0002E5C0 File Offset: 0x0002C7C0
		public static global::System.Collections.Generic.IDictionary<string, global::System.Type> GetPropertyTypes(global::System.Type type)
		{
			global::System.Collections.Generic.IDictionary<string, global::System.Type> dictionary;
			if (!global::System.Data.Entity.Internal.DbHelpers._propertyTypes.TryGetValue(type, out dictionary))
			{
				global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> enumerable = from p in type.GetInstanceProperties()
				where p.GetIndexParameters().Length == 0
				select p;
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Type>(enumerable.Count<global::System.Reflection.PropertyInfo>());
				foreach (global::System.Reflection.PropertyInfo propertyInfo in enumerable)
				{
					dictionary[propertyInfo.Name] = propertyInfo.PropertyType;
				}
				global::System.Data.Entity.Internal.DbHelpers._propertyTypes.TryAdd(type, dictionary);
			}
			return dictionary;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0002E668 File Offset: 0x0002C868
		public static global::System.Collections.Generic.IDictionary<string, global::System.Action<object, object>> GetPropertySetters(global::System.Type type)
		{
			global::System.Collections.Generic.IDictionary<string, global::System.Action<object, object>> dictionary;
			if (!global::System.Data.Entity.Internal.DbHelpers._propertySetters.TryGetValue(type, out dictionary))
			{
				global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> source = from p in type.GetInstanceProperties()
				where p.GetIndexParameters().Length == 0
				select p;
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Action<object, object>>(source.Count<global::System.Reflection.PropertyInfo>());
				foreach (global::System.Reflection.PropertyInfo propertyInfo in from p in source
				select p.GetPropertyInfoForSet())
				{
					global::System.Reflection.MethodInfo methodInfo = propertyInfo.Setter();
					if (methodInfo != null)
					{
						global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "value");
						global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "instance");
						global::System.Linq.Expressions.MethodCallExpression body = global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Convert(parameterExpression2, type), methodInfo, new global::System.Linq.Expressions.Expression[]
						{
							global::System.Linq.Expressions.Expression.Convert(parameterExpression, propertyInfo.PropertyType)
						});
						global::System.Action<object, object> setter = global::System.Linq.Expressions.Expression.Lambda<global::System.Action<object, object>>(body, new global::System.Linq.Expressions.ParameterExpression[]
						{
							parameterExpression2,
							parameterExpression
						}).Compile();
						global::System.Reflection.MethodInfo method = global::System.Data.Entity.Internal.DbHelpers.ConvertAndSetMethod.MakeGenericMethod(new global::System.Type[]
						{
							propertyInfo.PropertyType
						});
						global::System.Action<object, object, global::System.Action<object, object>, string, string> convertAndSet = (global::System.Action<object, object, global::System.Action<object, object>, string, string>)global::System.Delegate.CreateDelegate(typeof(global::System.Action<object, object, global::System.Action<object, object>, string, string>), method);
						string propertyName = propertyInfo.Name;
						dictionary[propertyInfo.Name] = delegate(object i, object v)
						{
							convertAndSet(i, v, setter, propertyName, type.Name);
						};
					}
				}
				global::System.Data.Entity.Internal.DbHelpers._propertySetters.TryAdd(type, dictionary);
			}
			return dictionary;
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0002E854 File Offset: 0x0002CA54
		private static void ConvertAndSet<T>(object instance, object value, global::System.Action<object, object> setter, string propertyName, string typeName)
		{
			if (value == null && typeof(T).IsValueType() && global::System.Nullable.GetUnderlyingType(typeof(T)) == null)
			{
				throw global::System.Data.Entity.Resources.Error.DbPropertyValues_CannotSetNullValue(propertyName, typeof(T).Name, typeName);
			}
			setter(instance, (T)((object)value));
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0002E8B8 File Offset: 0x0002CAB8
		public static global::System.Collections.Generic.IDictionary<string, global::System.Func<object, object>> GetPropertyGetters(global::System.Type type)
		{
			global::System.Collections.Generic.IDictionary<string, global::System.Func<object, object>> dictionary;
			if (!global::System.Data.Entity.Internal.DbHelpers._propertyGetters.TryGetValue(type, out dictionary))
			{
				global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> enumerable = from p in type.GetInstanceProperties()
				where p.GetIndexParameters().Length == 0
				select p;
				dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Func<object, object>>(enumerable.Count<global::System.Reflection.PropertyInfo>());
				foreach (global::System.Reflection.PropertyInfo propertyInfo in enumerable)
				{
					global::System.Reflection.MethodInfo methodInfo = propertyInfo.Getter();
					if (methodInfo != null)
					{
						global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "instance");
						global::System.Linq.Expressions.UnaryExpression body = global::System.Linq.Expressions.Expression.Convert(global::System.Linq.Expressions.Expression.Call(global::System.Linq.Expressions.Expression.Convert(parameterExpression, type), methodInfo), typeof(object));
						dictionary[propertyInfo.Name] = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object, object>>(body, new global::System.Linq.Expressions.ParameterExpression[]
						{
							parameterExpression
						}).Compile();
					}
				}
				global::System.Data.Entity.Internal.DbHelpers._propertyGetters.TryAdd(type, dictionary);
			}
			return dictionary;
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0002E9B8 File Offset: 0x0002CBB8
		public static global::System.Linq.IQueryable CreateNoTrackingQuery(global::System.Data.Entity.Core.Objects.ObjectQuery query)
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = (global::System.Data.Entity.Core.Objects.ObjectQuery)((global::System.Linq.IQueryable)query).Provider.CreateQuery(((global::System.Linq.IQueryable)query).Expression);
			objectQuery.ExecutionStrategy = query.ExecutionStrategy;
			objectQuery.MergeOption = global::System.Data.Entity.Core.Objects.MergeOption.NoTracking;
			objectQuery.Streaming = query.Streaming;
			return objectQuery;
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0002E9FC File Offset: 0x0002CBFC
		public static global::System.Linq.IQueryable CreateStreamingQuery(global::System.Data.Entity.Core.Objects.ObjectQuery query)
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = (global::System.Data.Entity.Core.Objects.ObjectQuery)((global::System.Linq.IQueryable)query).Provider.CreateQuery(((global::System.Linq.IQueryable)query).Expression);
			objectQuery.ExecutionStrategy = query.ExecutionStrategy;
			objectQuery.Streaming = true;
			objectQuery.MergeOption = query.MergeOption;
			return objectQuery;
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0002EA40 File Offset: 0x0002CC40
		public static global::System.Linq.IQueryable CreateQueryWithExecutionStrategy(global::System.Data.Entity.Core.Objects.ObjectQuery query, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = (global::System.Data.Entity.Core.Objects.ObjectQuery)((global::System.Linq.IQueryable)query).Provider.CreateQuery(((global::System.Linq.IQueryable)query).Expression);
			objectQuery.ExecutionStrategy = executionStrategy;
			objectQuery.MergeOption = query.MergeOption;
			objectQuery.Streaming = query.Streaming;
			return objectQuery;
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0002EA84 File Offset: 0x0002CC84
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbValidationError> SplitValidationResults(string propertyName, global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.ValidationResult> validationResults)
		{
			foreach (global::System.ComponentModel.DataAnnotations.ValidationResult validationResult in validationResults)
			{
				if (validationResult != null)
				{
					global::System.Collections.Generic.IEnumerable<string> enumerable;
					if (validationResult.MemberNames != null && validationResult.MemberNames.Any<string>())
					{
						enumerable = validationResult.MemberNames;
					}
					else
					{
						global::System.Collections.Generic.IEnumerable<string> enumerable2 = new string[1];
						enumerable = enumerable2;
					}
					global::System.Collections.Generic.IEnumerable<string> enumerable3 = enumerable;
					foreach (string text in enumerable3)
					{
						yield return new global::System.Data.Entity.Validation.DbValidationError(text ?? propertyName, validationResult.ErrorMessage);
					}
					global::System.Collections.Generic.IEnumerator<string> enumerator2 = null;
					validationResult = null;
				}
			}
			global::System.Collections.Generic.IEnumerator<global::System.ComponentModel.DataAnnotations.ValidationResult> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0002EA9B File Offset: 0x0002CC9B
		public static string GetPropertyPath(global::System.Data.Entity.Internal.InternalMemberEntry property)
		{
			return string.Join(".", global::System.Data.Entity.Internal.DbHelpers.GetPropertyPathSegments(property).Reverse<string>());
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0002EAB2 File Offset: 0x0002CCB2
		private static global::System.Collections.Generic.IEnumerable<string> GetPropertyPathSegments(global::System.Data.Entity.Internal.InternalMemberEntry property)
		{
			do
			{
				yield return property.Name;
				property = ((property is global::System.Data.Entity.Internal.InternalNestedPropertyEntry) ? ((global::System.Data.Entity.Internal.InternalNestedPropertyEntry)property).ParentPropertyEntry : null);
			}
			while (property != null);
			yield break;
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0002EAC2 File Offset: 0x0002CCC2
		public static global::System.Type CollectionType(global::System.Type elementType)
		{
			return global::System.Data.Entity.Internal.DbHelpers._collectionTypes.GetOrAdd(elementType, (global::System.Type t) => typeof(global::System.Collections.Generic.ICollection<>).MakeGenericType(new global::System.Type[]
			{
				t
			}));
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0002EAEE File Offset: 0x0002CCEE
		public static string DatabaseName(this global::System.Type contextType)
		{
			return contextType.ToString();
		}

		// Token: 0x0400090A RID: 2314
		public static readonly global::System.Reflection.MethodInfo ConvertAndSetMethod = typeof(global::System.Data.Entity.Internal.DbHelpers).GetOnlyDeclaredMethod("ConvertAndSet");

		// Token: 0x0400090B RID: 2315
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<string, global::System.Type>> _propertyTypes = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<string, global::System.Type>>();

		// Token: 0x0400090C RID: 2316
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<string, global::System.Action<object, object>>> _propertySetters = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<string, global::System.Action<object, object>>>();

		// Token: 0x0400090D RID: 2317
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<string, global::System.Func<object, object>>> _propertyGetters = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Collections.Generic.IDictionary<string, global::System.Func<object, object>>>();

		// Token: 0x0400090E RID: 2318
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Type> _collectionTypes = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Type>();
	}
}
