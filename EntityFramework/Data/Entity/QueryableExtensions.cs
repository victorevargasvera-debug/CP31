using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.Internal.Linq;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity
{
	// Token: 0x0200006C RID: 108
	public static class QueryableExtensions
	{
		// Token: 0x06000370 RID: 880 RVA: 0x0000B214 File Offset: 0x00009414
		public static global::System.Linq.IQueryable<T> Include<T>(this global::System.Linq.IQueryable<T> source, string path)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<T>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotEmpty(path, "path");
			global::System.Data.Entity.Infrastructure.DbQuery<T> dbQuery = source as global::System.Data.Entity.Infrastructure.DbQuery<T>;
			if (dbQuery != null)
			{
				return dbQuery.Include(path);
			}
			global::System.Data.Entity.Core.Objects.ObjectQuery<T> objectQuery = source as global::System.Data.Entity.Core.Objects.ObjectQuery<T>;
			if (objectQuery != null)
			{
				return objectQuery.Include(path);
			}
			return global::System.Data.Entity.QueryableExtensions.CommonInclude<global::System.Linq.IQueryable<T>>(source, path);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000B264 File Offset: 0x00009464
		public static global::System.Linq.IQueryable Include(this global::System.Linq.IQueryable source, string path)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotEmpty(path, "path");
			global::System.Data.Entity.Infrastructure.DbQuery dbQuery = source as global::System.Data.Entity.Infrastructure.DbQuery;
			if (dbQuery == null)
			{
				return global::System.Data.Entity.QueryableExtensions.CommonInclude<global::System.Linq.IQueryable>(source, path);
			}
			return dbQuery.Include(path);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000B2A4 File Offset: 0x000094A4
		private static T CommonInclude<T>(T source, string path)
		{
			global::System.Reflection.MethodInfo runtimeMethod = source.GetType().GetRuntimeMethod("Include", (global::System.Reflection.MethodInfo p) => p.IsPublic && !p.IsStatic, new global::System.Type[][]
			{
				new global::System.Type[]
				{
					typeof(string)
				},
				new global::System.Type[]
				{
					typeof(global::System.IComparable)
				},
				new global::System.Type[]
				{
					typeof(global::System.ICloneable)
				},
				new global::System.Type[]
				{
					typeof(global::System.IComparable<string>)
				},
				new global::System.Type[]
				{
					typeof(global::System.Collections.Generic.IEnumerable<char>)
				},
				new global::System.Type[]
				{
					typeof(global::System.Collections.IEnumerable)
				},
				new global::System.Type[]
				{
					typeof(global::System.IEquatable<string>)
				},
				new global::System.Type[]
				{
					typeof(object)
				}
			});
			if (runtimeMethod != null && typeof(T).IsAssignableFrom(runtimeMethod.ReturnType))
			{
				return (T)((object)runtimeMethod.Invoke(source, new object[]
				{
					path
				}));
			}
			return source;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000B3DC File Offset: 0x000095DC
		public static global::System.Linq.IQueryable<T> Include<T, TProperty>(this global::System.Linq.IQueryable<T> source, global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>> path)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<T>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>>>(path, "path");
			string text;
			if (!global::System.Data.Entity.Internal.DbHelpers.TryParsePath(path.Body, out text) || text == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbExtensions_InvalidIncludePathExpression, "path");
			}
			return source.Include(text);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000B42C File Offset: 0x0000962C
		public static global::System.Linq.IQueryable<T> AsNoTracking<T>(this global::System.Linq.IQueryable<T> source) where T : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<T>>(source, "source");
			global::System.Data.Entity.Infrastructure.DbQuery<T> dbQuery = source as global::System.Data.Entity.Infrastructure.DbQuery<T>;
			if (dbQuery == null)
			{
				return global::System.Data.Entity.QueryableExtensions.CommonAsNoTracking<global::System.Linq.IQueryable<T>>(source);
			}
			return dbQuery.AsNoTracking();
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000B460 File Offset: 0x00009660
		public static global::System.Linq.IQueryable AsNoTracking(this global::System.Linq.IQueryable source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			global::System.Data.Entity.Infrastructure.DbQuery dbQuery = source as global::System.Data.Entity.Infrastructure.DbQuery;
			if (dbQuery == null)
			{
				return global::System.Data.Entity.QueryableExtensions.CommonAsNoTracking<global::System.Linq.IQueryable>(source);
			}
			return dbQuery.AsNoTracking();
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000B494 File Offset: 0x00009694
		private static T CommonAsNoTracking<T>(T source) where T : class
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = source as global::System.Data.Entity.Core.Objects.ObjectQuery;
			if (objectQuery != null)
			{
				return (T)((object)global::System.Data.Entity.Internal.DbHelpers.CreateNoTrackingQuery(objectQuery));
			}
			global::System.Reflection.MethodInfo publicInstanceMethod = source.GetType().GetPublicInstanceMethod("AsNoTracking", new global::System.Type[0]);
			if (publicInstanceMethod != null && typeof(T).IsAssignableFrom(publicInstanceMethod.ReturnType))
			{
				return (T)((object)publicInstanceMethod.Invoke(source, null));
			}
			return source;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000B50C File Offset: 0x0000970C
		[global::System.Obsolete("LINQ queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public static global::System.Linq.IQueryable<T> AsStreaming<T>(this global::System.Linq.IQueryable<T> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<T>>(source, "source");
			global::System.Data.Entity.Infrastructure.DbQuery<T> dbQuery = source as global::System.Data.Entity.Infrastructure.DbQuery<T>;
			if (dbQuery == null)
			{
				return global::System.Data.Entity.QueryableExtensions.CommonAsStreaming<global::System.Linq.IQueryable<T>>(source);
			}
			return dbQuery.AsStreaming();
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000B540 File Offset: 0x00009740
		[global::System.Obsolete("LINQ queries are now streaming by default unless a retrying ExecutionStrategy is used. Calling this method will have no effect.")]
		public static global::System.Linq.IQueryable AsStreaming(this global::System.Linq.IQueryable source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			global::System.Data.Entity.Infrastructure.DbQuery dbQuery = source as global::System.Data.Entity.Infrastructure.DbQuery;
			if (dbQuery == null)
			{
				return global::System.Data.Entity.QueryableExtensions.CommonAsStreaming<global::System.Linq.IQueryable>(source);
			}
			return dbQuery.AsStreaming();
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000B574 File Offset: 0x00009774
		private static T CommonAsStreaming<T>(T source) where T : class
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = source as global::System.Data.Entity.Core.Objects.ObjectQuery;
			if (objectQuery != null)
			{
				return (T)((object)global::System.Data.Entity.Internal.DbHelpers.CreateStreamingQuery(objectQuery));
			}
			global::System.Reflection.MethodInfo publicInstanceMethod = source.GetType().GetPublicInstanceMethod("AsStreaming", new global::System.Type[0]);
			if (publicInstanceMethod != null && typeof(T).IsAssignableFrom(publicInstanceMethod.ReturnType))
			{
				return (T)((object)publicInstanceMethod.Invoke(source, null));
			}
			return source;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000B5EC File Offset: 0x000097EC
		internal static global::System.Linq.IQueryable<T> WithExecutionStrategy<T>(this global::System.Linq.IQueryable<T> source, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<T>>(source, "source");
			global::System.Data.Entity.Infrastructure.DbQuery<T> dbQuery = source as global::System.Data.Entity.Infrastructure.DbQuery<T>;
			if (dbQuery == null)
			{
				return global::System.Data.Entity.QueryableExtensions.CommonWithExecutionStrategy<global::System.Linq.IQueryable<T>>(source, executionStrategy);
			}
			return dbQuery.WithExecutionStrategy(executionStrategy);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000B620 File Offset: 0x00009820
		internal static global::System.Linq.IQueryable WithExecutionStrategy(this global::System.Linq.IQueryable source, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			global::System.Data.Entity.Infrastructure.DbQuery dbQuery = source as global::System.Data.Entity.Infrastructure.DbQuery;
			if (dbQuery == null)
			{
				return global::System.Data.Entity.QueryableExtensions.CommonWithExecutionStrategy<global::System.Linq.IQueryable>(source, executionStrategy);
			}
			return dbQuery.WithExecutionStrategy(executionStrategy);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000B654 File Offset: 0x00009854
		private static T CommonWithExecutionStrategy<T>(T source, global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy) where T : class
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = source as global::System.Data.Entity.Core.Objects.ObjectQuery;
			if (objectQuery != null)
			{
				return (T)((object)global::System.Data.Entity.Internal.DbHelpers.CreateQueryWithExecutionStrategy(objectQuery, executionStrategy));
			}
			global::System.Reflection.MethodInfo publicInstanceMethod = source.GetType().GetPublicInstanceMethod("WithExecutionStrategy", new global::System.Type[0]);
			if (publicInstanceMethod != null && typeof(T).IsAssignableFrom(publicInstanceMethod.ReturnType))
			{
				return (T)((object)publicInstanceMethod.Invoke(source, new object[]
				{
					executionStrategy
				}));
			}
			return source;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000B6D8 File Offset: 0x000098D8
		public static void Load(this global::System.Linq.IQueryable source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			using (global::System.Collections.IEnumerator enumerator = source.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
				}
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000B724 File Offset: 0x00009924
		public static global::System.Threading.Tasks.Task LoadAsync(this global::System.Linq.IQueryable source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			return source.LoadAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000B73D File Offset: 0x0000993D
		public static global::System.Threading.Tasks.Task LoadAsync(this global::System.Linq.IQueryable source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			return source.ForEachAsync(delegate(object e)
			{
			}, cancellationToken);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000B771 File Offset: 0x00009971
		public static global::System.Threading.Tasks.Task ForEachAsync(this global::System.Linq.IQueryable source, global::System.Action<object> action)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<object>>(action, "action");
			return source.AsDbAsyncEnumerable().ForEachAsync(action, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000B79C File Offset: 0x0000999C
		public static global::System.Threading.Tasks.Task ForEachAsync(this global::System.Linq.IQueryable source, global::System.Action<object> action, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<object>>(action, "action");
			return source.AsDbAsyncEnumerable().ForEachAsync(action, cancellationToken);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000B7C3 File Offset: 0x000099C3
		public static global::System.Threading.Tasks.Task ForEachAsync<T>(this global::System.Linq.IQueryable<T> source, global::System.Action<T> action)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<T>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<T>>(action, "action");
			return source.AsDbAsyncEnumerable<T>().ForEachAsync(action, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000B7EE File Offset: 0x000099EE
		public static global::System.Threading.Tasks.Task ForEachAsync<T>(this global::System.Linq.IQueryable<T> source, global::System.Action<T> action, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<T>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<T>>(action, "action");
			return source.AsDbAsyncEnumerable<T>().ForEachAsync(action, cancellationToken);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000B815 File Offset: 0x00009A15
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<object>> ToListAsync(this global::System.Linq.IQueryable source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			return source.AsDbAsyncEnumerable().ToListAsync<object>();
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000B82E File Offset: 0x00009A2E
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<object>> ToListAsync(this global::System.Linq.IQueryable source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable>(source, "source");
			return source.AsDbAsyncEnumerable().ToListAsync(cancellationToken);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000B848 File Offset: 0x00009A48
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<TSource>> ToListAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.AsDbAsyncEnumerable<TSource>().ToListAsync<TSource>();
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000B861 File Offset: 0x00009A61
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<TSource>> ToListAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.AsDbAsyncEnumerable<TSource>().ToListAsync(cancellationToken);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000B87B File Offset: 0x00009A7B
		public static global::System.Threading.Tasks.Task<TSource[]> ToArrayAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.AsDbAsyncEnumerable<TSource>().ToArrayAsync<TSource>();
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000B894 File Offset: 0x00009A94
		public static global::System.Threading.Tasks.Task<TSource[]> ToArrayAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.AsDbAsyncEnumerable<TSource>().ToArrayAsync(cancellationToken);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000B8AE File Offset: 0x00009AAE
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this global::System.Linq.IQueryable<TSource> source, global::System.Func<TSource, TKey> keySelector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TKey>>(keySelector, "keySelector");
			return source.AsDbAsyncEnumerable<TSource>().ToDictionaryAsync(keySelector);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000B8D4 File Offset: 0x00009AD4
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this global::System.Linq.IQueryable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TKey>>(keySelector, "keySelector");
			return source.AsDbAsyncEnumerable<TSource>().ToDictionaryAsync(keySelector, cancellationToken);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000B8FB File Offset: 0x00009AFB
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this global::System.Linq.IQueryable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TKey>>(keySelector, "keySelector");
			return source.AsDbAsyncEnumerable<TSource>().ToDictionaryAsync(keySelector, comparer);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000B922 File Offset: 0x00009B22
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this global::System.Linq.IQueryable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TKey>>(keySelector, "keySelector");
			return source.AsDbAsyncEnumerable<TSource>().ToDictionaryAsync(keySelector, comparer, cancellationToken);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000B94A File Offset: 0x00009B4A
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this global::System.Linq.IQueryable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Func<TSource, TElement> elementSelector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TKey>>(keySelector, "keySelector");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TElement>>(elementSelector, "elementSelector");
			return source.AsDbAsyncEnumerable<TSource>().ToDictionaryAsync(keySelector, elementSelector);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000B97D File Offset: 0x00009B7D
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this global::System.Linq.IQueryable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Func<TSource, TElement> elementSelector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TKey>>(keySelector, "keySelector");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TElement>>(elementSelector, "elementSelector");
			return source.AsDbAsyncEnumerable<TSource>().ToDictionaryAsync(keySelector, elementSelector, cancellationToken);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000B9B1 File Offset: 0x00009BB1
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this global::System.Linq.IQueryable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Func<TSource, TElement> elementSelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TKey>>(keySelector, "keySelector");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TElement>>(elementSelector, "elementSelector");
			return source.AsDbAsyncEnumerable<TSource>().ToDictionaryAsync(keySelector, elementSelector, comparer);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000B9E5 File Offset: 0x00009BE5
		public static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this global::System.Linq.IQueryable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Func<TSource, TElement> elementSelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TKey>>(keySelector, "keySelector");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<TSource, TElement>>(elementSelector, "elementSelector");
			return source.AsDbAsyncEnumerable<TSource>().ToDictionaryAsync(keySelector, elementSelector, comparer, cancellationToken);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000BA1B File Offset: 0x00009C1B
		public static global::System.Threading.Tasks.Task<TSource> FirstAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.FirstAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000BA34 File Offset: 0x00009C34
		public static global::System.Threading.Tasks.Task<TSource> FirstAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._first.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000BAA2 File Offset: 0x00009CA2
		public static global::System.Threading.Tasks.Task<TSource> FirstAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			return source.FirstAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		public static global::System.Threading.Tasks.Task<TSource> FirstAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._first_Predicate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(predicate)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000BB4B File Offset: 0x00009D4B
		public static global::System.Threading.Tasks.Task<TSource> FirstOrDefaultAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.FirstOrDefaultAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000BB64 File Offset: 0x00009D64
		public static global::System.Threading.Tasks.Task<TSource> FirstOrDefaultAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._firstOrDefault.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000BBD2 File Offset: 0x00009DD2
		public static global::System.Threading.Tasks.Task<TSource> FirstOrDefaultAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			return source.FirstOrDefaultAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		public static global::System.Threading.Tasks.Task<TSource> FirstOrDefaultAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._firstOrDefault_Predicate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(predicate)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000BC7B File Offset: 0x00009E7B
		public static global::System.Threading.Tasks.Task<TSource> SingleAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.SingleAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000BC94 File Offset: 0x00009E94
		public static global::System.Threading.Tasks.Task<TSource> SingleAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._single.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000BD02 File Offset: 0x00009F02
		public static global::System.Threading.Tasks.Task<TSource> SingleAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			return source.SingleAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000BD28 File Offset: 0x00009F28
		public static global::System.Threading.Tasks.Task<TSource> SingleAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._single_Predicate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(predicate)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000BDAB File Offset: 0x00009FAB
		public static global::System.Threading.Tasks.Task<TSource> SingleOrDefaultAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.SingleOrDefaultAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000BDC4 File Offset: 0x00009FC4
		public static global::System.Threading.Tasks.Task<TSource> SingleOrDefaultAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._singleOrDefault.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000BE32 File Offset: 0x0000A032
		public static global::System.Threading.Tasks.Task<TSource> SingleOrDefaultAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			return source.SingleOrDefaultAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000BE58 File Offset: 0x0000A058
		public static global::System.Threading.Tasks.Task<TSource> SingleOrDefaultAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._singleOrDefault_Predicate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(predicate)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000BEDB File Offset: 0x0000A0DB
		public static global::System.Threading.Tasks.Task<bool> ContainsAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, TSource item)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.ContainsAsync(item, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		public static global::System.Threading.Tasks.Task<bool> ContainsAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, TSource item, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<bool>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._contains.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Constant(item, typeof(TSource))
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000BF7E File Offset: 0x0000A17E
		public static global::System.Threading.Tasks.Task<bool> AnyAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.AnyAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000BF98 File Offset: 0x0000A198
		public static global::System.Threading.Tasks.Task<bool> AnyAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<bool>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._any.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000C006 File Offset: 0x0000A206
		public static global::System.Threading.Tasks.Task<bool> AnyAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			return source.AnyAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000C02C File Offset: 0x0000A22C
		public static global::System.Threading.Tasks.Task<bool> AnyAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<bool>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._any_Predicate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(predicate)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000C0AF File Offset: 0x0000A2AF
		public static global::System.Threading.Tasks.Task<bool> AllAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			return source.AllAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		public static global::System.Threading.Tasks.Task<bool> AllAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<bool>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._all_Predicate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(predicate)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000C15B File Offset: 0x0000A35B
		public static global::System.Threading.Tasks.Task<int> CountAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.CountAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000C174 File Offset: 0x0000A374
		public static global::System.Threading.Tasks.Task<int> CountAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<int>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._count.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000C1E2 File Offset: 0x0000A3E2
		public static global::System.Threading.Tasks.Task<int> CountAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			return source.CountAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000C208 File Offset: 0x0000A408
		public static global::System.Threading.Tasks.Task<int> CountAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<int>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._count_Predicate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(predicate)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000C28B File Offset: 0x0000A48B
		public static global::System.Threading.Tasks.Task<long> LongCountAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.LongCountAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000C2A4 File Offset: 0x0000A4A4
		public static global::System.Threading.Tasks.Task<long> LongCountAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<long>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._longCount.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000C312 File Offset: 0x0000A512
		public static global::System.Threading.Tasks.Task<long> LongCountAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			return source.LongCountAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000C338 File Offset: 0x0000A538
		public static global::System.Threading.Tasks.Task<long> LongCountAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, bool>>>(predicate, "predicate");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<long>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._longCount_Predicate.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(predicate)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000C3BB File Offset: 0x0000A5BB
		public static global::System.Threading.Tasks.Task<TSource> MinAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.MinAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		public static global::System.Threading.Tasks.Task<TSource> MinAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._min.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000C442 File Offset: 0x0000A642
		public static global::System.Threading.Tasks.Task<TResult> MinAsync<TSource, TResult>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, TResult>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, TResult>>>(selector, "selector");
			return source.MinAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000C468 File Offset: 0x0000A668
		public static global::System.Threading.Tasks.Task<TResult> MinAsync<TSource, TResult>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, TResult>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, TResult>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TResult>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._min_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource),
					typeof(TResult)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		public static global::System.Threading.Tasks.Task<TSource> MaxAsync<TSource>(this global::System.Linq.IQueryable<TSource> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			return source.MaxAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000C514 File Offset: 0x0000A714
		public static global::System.Threading.Tasks.Task<TSource> MaxAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._max.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000C582 File Offset: 0x0000A782
		public static global::System.Threading.Tasks.Task<TResult> MaxAsync<TSource, TResult>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, TResult>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, TResult>>>(selector, "selector");
			return source.MaxAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		public static global::System.Threading.Tasks.Task<TResult> MaxAsync<TSource, TResult>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, TResult>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, TResult>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<TResult>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._max_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource),
					typeof(TResult)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000C638 File Offset: 0x0000A838
		public static global::System.Threading.Tasks.Task<int> SumAsync(this global::System.Linq.IQueryable<int> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<int>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000C654 File Offset: 0x0000A854
		public static global::System.Threading.Tasks.Task<int> SumAsync(this global::System.Linq.IQueryable<int> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<int>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<int>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Int, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000C6AA File Offset: 0x0000A8AA
		public static global::System.Threading.Tasks.Task<int?> SumAsync(this global::System.Linq.IQueryable<int?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<int?>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000C6C4 File Offset: 0x0000A8C4
		public static global::System.Threading.Tasks.Task<int?> SumAsync(this global::System.Linq.IQueryable<int?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<int?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<int?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_IntNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000C71A File Offset: 0x0000A91A
		public static global::System.Threading.Tasks.Task<long> SumAsync(this global::System.Linq.IQueryable<long> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<long>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000C734 File Offset: 0x0000A934
		public static global::System.Threading.Tasks.Task<long> SumAsync(this global::System.Linq.IQueryable<long> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<long>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<long>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Long, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000C78A File Offset: 0x0000A98A
		public static global::System.Threading.Tasks.Task<long?> SumAsync(this global::System.Linq.IQueryable<long?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<long?>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		public static global::System.Threading.Tasks.Task<long?> SumAsync(this global::System.Linq.IQueryable<long?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<long?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<long?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_LongNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000C7FA File Offset: 0x0000A9FA
		public static global::System.Threading.Tasks.Task<float> SumAsync(this global::System.Linq.IQueryable<float> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<float>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000C814 File Offset: 0x0000AA14
		public static global::System.Threading.Tasks.Task<float> SumAsync(this global::System.Linq.IQueryable<float> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<float>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<float>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Float, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000C86A File Offset: 0x0000AA6A
		public static global::System.Threading.Tasks.Task<float?> SumAsync(this global::System.Linq.IQueryable<float?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<float?>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000C884 File Offset: 0x0000AA84
		public static global::System.Threading.Tasks.Task<float?> SumAsync(this global::System.Linq.IQueryable<float?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<float?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<float?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_FloatNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000C8DA File Offset: 0x0000AADA
		public static global::System.Threading.Tasks.Task<double> SumAsync(this global::System.Linq.IQueryable<double> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<double>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000C8F4 File Offset: 0x0000AAF4
		public static global::System.Threading.Tasks.Task<double> SumAsync(this global::System.Linq.IQueryable<double> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<double>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Double, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000C94A File Offset: 0x0000AB4A
		public static global::System.Threading.Tasks.Task<double?> SumAsync(this global::System.Linq.IQueryable<double?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<double?>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000C964 File Offset: 0x0000AB64
		public static global::System.Threading.Tasks.Task<double?> SumAsync(this global::System.Linq.IQueryable<double?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<double?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_DoubleNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000C9BA File Offset: 0x0000ABBA
		public static global::System.Threading.Tasks.Task<decimal> SumAsync(this global::System.Linq.IQueryable<decimal> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<decimal>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
		public static global::System.Threading.Tasks.Task<decimal> SumAsync(this global::System.Linq.IQueryable<decimal> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<decimal>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<decimal>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Decimal, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000CA2A File Offset: 0x0000AC2A
		public static global::System.Threading.Tasks.Task<decimal?> SumAsync(this global::System.Linq.IQueryable<decimal?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<decimal?>>(source, "source");
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000CA44 File Offset: 0x0000AC44
		public static global::System.Threading.Tasks.Task<decimal?> SumAsync(this global::System.Linq.IQueryable<decimal?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<decimal?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<decimal?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_DecimalNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000CA9A File Offset: 0x0000AC9A
		public static global::System.Threading.Tasks.Task<int> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, int>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, int>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000CAC0 File Offset: 0x0000ACC0
		public static global::System.Threading.Tasks.Task<int> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, int>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, int>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<int>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Int_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000CB43 File Offset: 0x0000AD43
		public static global::System.Threading.Tasks.Task<int?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, int?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, int?>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		public static global::System.Threading.Tasks.Task<int?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, int?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, int?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<int?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_IntNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000CBEF File Offset: 0x0000ADEF
		public static global::System.Threading.Tasks.Task<long> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, long>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, long>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000CC18 File Offset: 0x0000AE18
		public static global::System.Threading.Tasks.Task<long> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, long>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, long>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<long>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Long_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000CC9B File Offset: 0x0000AE9B
		public static global::System.Threading.Tasks.Task<long?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, long?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, long?>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000CCC4 File Offset: 0x0000AEC4
		public static global::System.Threading.Tasks.Task<long?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, long?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, long?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<long?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_LongNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000CD47 File Offset: 0x0000AF47
		public static global::System.Threading.Tasks.Task<float> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, float>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, float>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000CD70 File Offset: 0x0000AF70
		public static global::System.Threading.Tasks.Task<float> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, float>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, float>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<float>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Float_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000CDF3 File Offset: 0x0000AFF3
		public static global::System.Threading.Tasks.Task<float?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, float?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, float?>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000CE1C File Offset: 0x0000B01C
		public static global::System.Threading.Tasks.Task<float?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, float?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, float?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<float?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_FloatNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000CE9F File Offset: 0x0000B09F
		public static global::System.Threading.Tasks.Task<double> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, double>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, double>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000CEC8 File Offset: 0x0000B0C8
		public static global::System.Threading.Tasks.Task<double> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, double>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, double>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Double_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000CF4B File Offset: 0x0000B14B
		public static global::System.Threading.Tasks.Task<double?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, double?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, double?>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000CF74 File Offset: 0x0000B174
		public static global::System.Threading.Tasks.Task<double?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, double?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, double?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_DoubleNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000CFF7 File Offset: 0x0000B1F7
		public static global::System.Threading.Tasks.Task<decimal> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000D020 File Offset: 0x0000B220
		public static global::System.Threading.Tasks.Task<decimal> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<decimal>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_Decimal_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000D0A3 File Offset: 0x0000B2A3
		public static global::System.Threading.Tasks.Task<decimal?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal?>>>(selector, "selector");
			return source.SumAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000D0CC File Offset: 0x0000B2CC
		public static global::System.Threading.Tasks.Task<decimal?> SumAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<decimal?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._sum_DecimalNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000D14F File Offset: 0x0000B34F
		public static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Linq.IQueryable<int> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<int>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000D168 File Offset: 0x0000B368
		public static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Linq.IQueryable<int> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<int>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Int, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000D1BE File Offset: 0x0000B3BE
		public static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Linq.IQueryable<int?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<int?>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000D1D8 File Offset: 0x0000B3D8
		public static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Linq.IQueryable<int?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<int?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_IntNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000D22E File Offset: 0x0000B42E
		public static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Linq.IQueryable<long> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<long>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000D248 File Offset: 0x0000B448
		public static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Linq.IQueryable<long> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<long>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Long, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000D29E File Offset: 0x0000B49E
		public static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Linq.IQueryable<long?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<long?>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		public static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Linq.IQueryable<long?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<long?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_LongNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000D30E File Offset: 0x0000B50E
		public static global::System.Threading.Tasks.Task<float> AverageAsync(this global::System.Linq.IQueryable<float> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<float>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000D328 File Offset: 0x0000B528
		public static global::System.Threading.Tasks.Task<float> AverageAsync(this global::System.Linq.IQueryable<float> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<float>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<float>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Float, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000D37E File Offset: 0x0000B57E
		public static global::System.Threading.Tasks.Task<float?> AverageAsync(this global::System.Linq.IQueryable<float?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<float?>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000D398 File Offset: 0x0000B598
		public static global::System.Threading.Tasks.Task<float?> AverageAsync(this global::System.Linq.IQueryable<float?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<float?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<float?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_FloatNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000D3EE File Offset: 0x0000B5EE
		public static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Linq.IQueryable<double> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<double>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000D408 File Offset: 0x0000B608
		public static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Linq.IQueryable<double> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<double>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Double, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000D45E File Offset: 0x0000B65E
		public static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Linq.IQueryable<double?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<double?>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000D478 File Offset: 0x0000B678
		public static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Linq.IQueryable<double?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<double?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_DoubleNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000D4CE File Offset: 0x0000B6CE
		public static global::System.Threading.Tasks.Task<decimal> AverageAsync(this global::System.Linq.IQueryable<decimal> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<decimal>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		public static global::System.Threading.Tasks.Task<decimal> AverageAsync(this global::System.Linq.IQueryable<decimal> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<decimal>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<decimal>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Decimal, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000D53E File Offset: 0x0000B73E
		public static global::System.Threading.Tasks.Task<decimal?> AverageAsync(this global::System.Linq.IQueryable<decimal?> source)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<decimal?>>(source, "source");
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000D558 File Offset: 0x0000B758
		public static global::System.Threading.Tasks.Task<decimal?> AverageAsync(this global::System.Linq.IQueryable<decimal?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<decimal?>>(source, "source");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<decimal?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_DecimalNullable, new global::System.Linq.Expressions.Expression[]
				{
					source.Expression
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000D5AE File Offset: 0x0000B7AE
		public static global::System.Threading.Tasks.Task<double> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, int>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, int>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		public static global::System.Threading.Tasks.Task<double> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, int>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, int>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Int_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000D657 File Offset: 0x0000B857
		public static global::System.Threading.Tasks.Task<double?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, int?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, int?>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000D680 File Offset: 0x0000B880
		public static global::System.Threading.Tasks.Task<double?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, int?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, int?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_IntNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000D703 File Offset: 0x0000B903
		public static global::System.Threading.Tasks.Task<double> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, long>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, long>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000D72C File Offset: 0x0000B92C
		public static global::System.Threading.Tasks.Task<double> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, long>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, long>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Long_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000D7AF File Offset: 0x0000B9AF
		public static global::System.Threading.Tasks.Task<double?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, long?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, long?>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000D7D8 File Offset: 0x0000B9D8
		public static global::System.Threading.Tasks.Task<double?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, long?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, long?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_LongNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000D85B File Offset: 0x0000BA5B
		public static global::System.Threading.Tasks.Task<float> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, float>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, float>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000D884 File Offset: 0x0000BA84
		public static global::System.Threading.Tasks.Task<float> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, float>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, float>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<float>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Float_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000D907 File Offset: 0x0000BB07
		public static global::System.Threading.Tasks.Task<float?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, float?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, float?>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000D930 File Offset: 0x0000BB30
		public static global::System.Threading.Tasks.Task<float?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, float?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, float?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<float?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_FloatNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000D9B3 File Offset: 0x0000BBB3
		public static global::System.Threading.Tasks.Task<double> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, double>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, double>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		public static global::System.Threading.Tasks.Task<double> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, double>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, double>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Double_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000DA5F File Offset: 0x0000BC5F
		public static global::System.Threading.Tasks.Task<double?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, double?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, double?>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000DA88 File Offset: 0x0000BC88
		public static global::System.Threading.Tasks.Task<double?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, double?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, double?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<double?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_DoubleNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000DB0B File Offset: 0x0000BD0B
		public static global::System.Threading.Tasks.Task<decimal> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000DB34 File Offset: 0x0000BD34
		public static global::System.Threading.Tasks.Task<decimal> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<decimal>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_Decimal_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000DBB7 File Offset: 0x0000BDB7
		public static global::System.Threading.Tasks.Task<decimal?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal?>> selector)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal?>>>(selector, "selector");
			return source.AverageAsync(selector, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		public static global::System.Threading.Tasks.Task<decimal?> AverageAsync<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal?>> selector, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TSource, decimal?>>>(selector, "selector");
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider dbAsyncQueryProvider = source.Provider as global::System.Data.Entity.Infrastructure.IDbAsyncQueryProvider;
			if (dbAsyncQueryProvider != null)
			{
				return dbAsyncQueryProvider.ExecuteAsync<decimal?>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._average_DecimalNullable_Selector.MakeGenericMethod(new global::System.Type[]
				{
					typeof(TSource)
				}), new global::System.Linq.Expressions.Expression[]
				{
					source.Expression,
					global::System.Linq.Expressions.Expression.Quote(selector)
				}), cancellationToken);
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Provider_Not_Async();
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000DC64 File Offset: 0x0000BE64
		public static global::System.Linq.IQueryable<TSource> Skip<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<int>> countAccessor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<int>>>(countAccessor, "countAccessor");
			return source.Provider.CreateQuery<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._skip.MakeGenericMethod(new global::System.Type[]
			{
				typeof(TSource)
			}), new global::System.Linq.Expressions.Expression[]
			{
				source.Expression,
				countAccessor.Body
			}));
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		public static global::System.Linq.IQueryable<TSource> Take<TSource>(this global::System.Linq.IQueryable<TSource> source, global::System.Linq.Expressions.Expression<global::System.Func<int>> countAccessor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.IQueryable<TSource>>(source, "source");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<int>>>(countAccessor, "countAccessor");
			return source.Provider.CreateQuery<TSource>(global::System.Linq.Expressions.Expression.Call(null, global::System.Data.Entity.QueryableExtensions._take.MakeGenericMethod(new global::System.Type[]
			{
				typeof(TSource)
			}), new global::System.Linq.Expressions.Expression[]
			{
				source.Expression,
				countAccessor.Body
			}));
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000DD3C File Offset: 0x0000BF3C
		internal static global::System.Data.Entity.Core.Objects.ObjectQuery TryGetObjectQuery(this global::System.Linq.IQueryable source)
		{
			if (source == null)
			{
				return null;
			}
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = source as global::System.Data.Entity.Core.Objects.ObjectQuery;
			if (objectQuery != null)
			{
				return objectQuery;
			}
			global::System.Data.Entity.Internal.Linq.IInternalQueryAdapter internalQueryAdapter = source as global::System.Data.Entity.Internal.Linq.IInternalQueryAdapter;
			if (internalQueryAdapter != null)
			{
				return internalQueryAdapter.InternalQuery.ObjectQuery;
			}
			return null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000DD74 File Offset: 0x0000BF74
		private static global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable AsDbAsyncEnumerable(this global::System.Linq.IQueryable source)
		{
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable dbAsyncEnumerable = source as global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable;
			if (dbAsyncEnumerable != null)
			{
				return dbAsyncEnumerable;
			}
			throw global::System.Data.Entity.Resources.Error.IQueryable_Not_Async(string.Empty);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000DD98 File Offset: 0x0000BF98
		private static global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T> AsDbAsyncEnumerable<T>(this global::System.Linq.IQueryable<T> source)
		{
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T> dbAsyncEnumerable = source as global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>;
			if (dbAsyncEnumerable != null)
			{
				return dbAsyncEnumerable;
			}
			string str = "<";
			global::System.Type typeFromHandle = typeof(T);
			throw global::System.Data.Entity.Resources.Error.IQueryable_Not_Async(str + ((typeFromHandle != null) ? typeFromHandle.ToString() : null) + ">");
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000DDDB File Offset: 0x0000BFDB
		private static global::System.Reflection.MethodInfo GetMethod(string methodName, global::System.Func<global::System.Type[]> getParameterTypes)
		{
			return global::System.Data.Entity.QueryableExtensions.GetMethod(methodName, getParameterTypes, 0);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000DDE5 File Offset: 0x0000BFE5
		private static global::System.Reflection.MethodInfo GetMethod(string methodName, global::System.Func<global::System.Type, global::System.Type, global::System.Type[]> getParameterTypes)
		{
			return global::System.Data.Entity.QueryableExtensions.GetMethod(methodName, getParameterTypes, 2);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000DDEF File Offset: 0x0000BFEF
		private static global::System.Reflection.MethodInfo GetMethod(string methodName, global::System.Func<global::System.Type, global::System.Type[]> getParameterTypes)
		{
			return global::System.Data.Entity.QueryableExtensions.GetMethod(methodName, getParameterTypes, 1);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		private static global::System.Reflection.MethodInfo GetMethod(string methodName, global::System.Delegate getParameterTypesDelegate, int genericArgumentsCount)
		{
			foreach (global::System.Reflection.MethodInfo methodInfo in typeof(global::System.Linq.Queryable).GetDeclaredMethods(methodName))
			{
				global::System.Type[] genericArguments = methodInfo.GetGenericArguments();
				if (genericArguments.Length == genericArgumentsCount)
				{
					global::System.Reflection.MethodInfo methodInfo2 = methodInfo;
					object[] args = genericArguments;
					if (global::System.Data.Entity.QueryableExtensions.Matches(methodInfo2, (global::System.Type[])getParameterTypesDelegate.DynamicInvoke(args)))
					{
						return methodInfo;
					}
				}
			}
			return null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000DE78 File Offset: 0x0000C078
		private static bool Matches(global::System.Reflection.MethodInfo methodInfo, global::System.Type[] parameterTypes)
		{
			return (from p in methodInfo.GetParameters()
			select p.ParameterType).SequenceEqual(parameterTypes);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000DEAC File Offset: 0x0000C0AC
		private static string PrettyPrint(global::System.Reflection.MethodInfo getParameterTypesMethod, int genericArgumentsCount)
		{
			global::System.Type[] array = new global::System.Type[genericArgumentsCount];
			for (int i = 0; i < genericArgumentsCount; i++)
			{
				array[i] = typeof(object);
			}
			object obj = null;
			object[] parameters = array;
			global::System.Type[] array2 = (global::System.Type[])getParameterTypesMethod.Invoke(obj, parameters);
			string[] array3 = new string[array2.Length];
			for (int j = 0; j < array2.Length; j++)
			{
				array3[j] = array2[j].ToString();
			}
			return "(" + string.Join(", ", array3) + ")";
		}

		// Token: 0x040000CC RID: 204
		private static readonly global::System.Reflection.MethodInfo _first = global::System.Data.Entity.QueryableExtensions.GetMethod("First", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000CD RID: 205
		private static readonly global::System.Reflection.MethodInfo _first_Predicate = global::System.Data.Entity.QueryableExtensions.GetMethod("First", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(bool)
				})
			})
		});

		// Token: 0x040000CE RID: 206
		private static readonly global::System.Reflection.MethodInfo _firstOrDefault = global::System.Data.Entity.QueryableExtensions.GetMethod("FirstOrDefault", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000CF RID: 207
		private static readonly global::System.Reflection.MethodInfo _firstOrDefault_Predicate = global::System.Data.Entity.QueryableExtensions.GetMethod("FirstOrDefault", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(bool)
				})
			})
		});

		// Token: 0x040000D0 RID: 208
		private static readonly global::System.Reflection.MethodInfo _single = global::System.Data.Entity.QueryableExtensions.GetMethod("Single", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000D1 RID: 209
		private static readonly global::System.Reflection.MethodInfo _single_Predicate = global::System.Data.Entity.QueryableExtensions.GetMethod("Single", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(bool)
				})
			})
		});

		// Token: 0x040000D2 RID: 210
		private static readonly global::System.Reflection.MethodInfo _singleOrDefault = global::System.Data.Entity.QueryableExtensions.GetMethod("SingleOrDefault", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000D3 RID: 211
		private static readonly global::System.Reflection.MethodInfo _singleOrDefault_Predicate = global::System.Data.Entity.QueryableExtensions.GetMethod("SingleOrDefault", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(bool)
				})
			})
		});

		// Token: 0x040000D4 RID: 212
		private static readonly global::System.Reflection.MethodInfo _contains = global::System.Data.Entity.QueryableExtensions.GetMethod("Contains", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			T
		});

		// Token: 0x040000D5 RID: 213
		private static readonly global::System.Reflection.MethodInfo _any = global::System.Data.Entity.QueryableExtensions.GetMethod("Any", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000D6 RID: 214
		private static readonly global::System.Reflection.MethodInfo _any_Predicate = global::System.Data.Entity.QueryableExtensions.GetMethod("Any", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(bool)
				})
			})
		});

		// Token: 0x040000D7 RID: 215
		private static readonly global::System.Reflection.MethodInfo _all_Predicate = global::System.Data.Entity.QueryableExtensions.GetMethod("All", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(bool)
				})
			})
		});

		// Token: 0x040000D8 RID: 216
		private static readonly global::System.Reflection.MethodInfo _count = global::System.Data.Entity.QueryableExtensions.GetMethod("Count", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000D9 RID: 217
		private static readonly global::System.Reflection.MethodInfo _count_Predicate = global::System.Data.Entity.QueryableExtensions.GetMethod("Count", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(bool)
				})
			})
		});

		// Token: 0x040000DA RID: 218
		private static readonly global::System.Reflection.MethodInfo _longCount = global::System.Data.Entity.QueryableExtensions.GetMethod("LongCount", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000DB RID: 219
		private static readonly global::System.Reflection.MethodInfo _longCount_Predicate = global::System.Data.Entity.QueryableExtensions.GetMethod("LongCount", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(bool)
				})
			})
		});

		// Token: 0x040000DC RID: 220
		private static readonly global::System.Reflection.MethodInfo _min = global::System.Data.Entity.QueryableExtensions.GetMethod("Min", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000DD RID: 221
		private static readonly global::System.Reflection.MethodInfo _min_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Min", (global::System.Type T, global::System.Type U) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					U
				})
			})
		});

		// Token: 0x040000DE RID: 222
		private static readonly global::System.Reflection.MethodInfo _max = global::System.Data.Entity.QueryableExtensions.GetMethod("Max", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			})
		});

		// Token: 0x040000DF RID: 223
		private static readonly global::System.Reflection.MethodInfo _max_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Max", (global::System.Type T, global::System.Type U) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					U
				})
			})
		});

		// Token: 0x040000E0 RID: 224
		private static readonly global::System.Reflection.MethodInfo _sum_Int = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<int>)
		});

		// Token: 0x040000E1 RID: 225
		private static readonly global::System.Reflection.MethodInfo _sum_IntNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<int?>)
		});

		// Token: 0x040000E2 RID: 226
		private static readonly global::System.Reflection.MethodInfo _sum_Long = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<long>)
		});

		// Token: 0x040000E3 RID: 227
		private static readonly global::System.Reflection.MethodInfo _sum_LongNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<long?>)
		});

		// Token: 0x040000E4 RID: 228
		private static readonly global::System.Reflection.MethodInfo _sum_Float = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<float>)
		});

		// Token: 0x040000E5 RID: 229
		private static readonly global::System.Reflection.MethodInfo _sum_FloatNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<float?>)
		});

		// Token: 0x040000E6 RID: 230
		private static readonly global::System.Reflection.MethodInfo _sum_Double = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<double>)
		});

		// Token: 0x040000E7 RID: 231
		private static readonly global::System.Reflection.MethodInfo _sum_DoubleNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<double?>)
		});

		// Token: 0x040000E8 RID: 232
		private static readonly global::System.Reflection.MethodInfo _sum_Decimal = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<decimal>)
		});

		// Token: 0x040000E9 RID: 233
		private static readonly global::System.Reflection.MethodInfo _sum_DecimalNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<decimal?>)
		});

		// Token: 0x040000EA RID: 234
		private static readonly global::System.Reflection.MethodInfo _sum_Int_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(int)
				})
			})
		});

		// Token: 0x040000EB RID: 235
		private static readonly global::System.Reflection.MethodInfo _sum_IntNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(int?)
				})
			})
		});

		// Token: 0x040000EC RID: 236
		private static readonly global::System.Reflection.MethodInfo _sum_Long_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(long)
				})
			})
		});

		// Token: 0x040000ED RID: 237
		private static readonly global::System.Reflection.MethodInfo _sum_LongNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(long?)
				})
			})
		});

		// Token: 0x040000EE RID: 238
		private static readonly global::System.Reflection.MethodInfo _sum_Float_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(float)
				})
			})
		});

		// Token: 0x040000EF RID: 239
		private static readonly global::System.Reflection.MethodInfo _sum_FloatNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(float?)
				})
			})
		});

		// Token: 0x040000F0 RID: 240
		private static readonly global::System.Reflection.MethodInfo _sum_Double_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(double)
				})
			})
		});

		// Token: 0x040000F1 RID: 241
		private static readonly global::System.Reflection.MethodInfo _sum_DoubleNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(double?)
				})
			})
		});

		// Token: 0x040000F2 RID: 242
		private static readonly global::System.Reflection.MethodInfo _sum_Decimal_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(decimal)
				})
			})
		});

		// Token: 0x040000F3 RID: 243
		private static readonly global::System.Reflection.MethodInfo _sum_DecimalNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Sum", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(decimal?)
				})
			})
		});

		// Token: 0x040000F4 RID: 244
		private static readonly global::System.Reflection.MethodInfo _average_Int = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<int>)
		});

		// Token: 0x040000F5 RID: 245
		private static readonly global::System.Reflection.MethodInfo _average_IntNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<int?>)
		});

		// Token: 0x040000F6 RID: 246
		private static readonly global::System.Reflection.MethodInfo _average_Long = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<long>)
		});

		// Token: 0x040000F7 RID: 247
		private static readonly global::System.Reflection.MethodInfo _average_LongNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<long?>)
		});

		// Token: 0x040000F8 RID: 248
		private static readonly global::System.Reflection.MethodInfo _average_Float = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<float>)
		});

		// Token: 0x040000F9 RID: 249
		private static readonly global::System.Reflection.MethodInfo _average_FloatNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<float?>)
		});

		// Token: 0x040000FA RID: 250
		private static readonly global::System.Reflection.MethodInfo _average_Double = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<double>)
		});

		// Token: 0x040000FB RID: 251
		private static readonly global::System.Reflection.MethodInfo _average_DoubleNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<double?>)
		});

		// Token: 0x040000FC RID: 252
		private static readonly global::System.Reflection.MethodInfo _average_Decimal = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<decimal>)
		});

		// Token: 0x040000FD RID: 253
		private static readonly global::System.Reflection.MethodInfo _average_DecimalNullable = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", () => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<decimal?>)
		});

		// Token: 0x040000FE RID: 254
		private static readonly global::System.Reflection.MethodInfo _average_Int_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(int)
				})
			})
		});

		// Token: 0x040000FF RID: 255
		private static readonly global::System.Reflection.MethodInfo _average_IntNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(int?)
				})
			})
		});

		// Token: 0x04000100 RID: 256
		private static readonly global::System.Reflection.MethodInfo _average_Long_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(long)
				})
			})
		});

		// Token: 0x04000101 RID: 257
		private static readonly global::System.Reflection.MethodInfo _average_LongNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(long?)
				})
			})
		});

		// Token: 0x04000102 RID: 258
		private static readonly global::System.Reflection.MethodInfo _average_Float_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(float)
				})
			})
		});

		// Token: 0x04000103 RID: 259
		private static readonly global::System.Reflection.MethodInfo _average_FloatNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(float?)
				})
			})
		});

		// Token: 0x04000104 RID: 260
		private static readonly global::System.Reflection.MethodInfo _average_Double_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(double)
				})
			})
		});

		// Token: 0x04000105 RID: 261
		private static readonly global::System.Reflection.MethodInfo _average_DoubleNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(double?)
				})
			})
		});

		// Token: 0x04000106 RID: 262
		private static readonly global::System.Reflection.MethodInfo _average_Decimal_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(decimal)
				})
			})
		});

		// Token: 0x04000107 RID: 263
		private static readonly global::System.Reflection.MethodInfo _average_DecimalNullable_Selector = global::System.Data.Entity.QueryableExtensions.GetMethod("Average", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(global::System.Linq.Expressions.Expression<>).MakeGenericType(new global::System.Type[]
			{
				typeof(global::System.Func<, >).MakeGenericType(new global::System.Type[]
				{
					T,
					typeof(decimal?)
				})
			})
		});

		// Token: 0x04000108 RID: 264
		private static readonly global::System.Reflection.MethodInfo _skip = global::System.Data.Entity.QueryableExtensions.GetMethod("Skip", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(int)
		});

		// Token: 0x04000109 RID: 265
		private static readonly global::System.Reflection.MethodInfo _take = global::System.Data.Entity.QueryableExtensions.GetMethod("Take", (global::System.Type T) => new global::System.Type[]
		{
			typeof(global::System.Linq.IQueryable<>).MakeGenericType(new global::System.Type[]
			{
				T
			}),
			typeof(int)
		});
	}
}
