using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000244 RID: 580
	internal static class IDbAsyncEnumerableExtensions
	{
		// Token: 0x06001E4A RID: 7754 RVA: 0x000538A8 File Offset: 0x00051AA8
		internal static async global::System.Threading.Tasks.Task ForEachAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable source, global::System.Action<object> action, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator enumerator = source.GetAsyncEnumerator())
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = enumerator.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (cultureAwaiter.GetResult())
				{
					do
					{
						cancellationToken.ThrowIfCancellationRequested();
						object obj = enumerator.Current;
						global::System.Threading.Tasks.Task<bool> task = enumerator.MoveNextAsync(cancellationToken);
						action(obj);
						cultureAwaiter = task.WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
					}
					while (cultureAwaiter.GetResult());
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator enumerator = null;
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000538FD File Offset: 0x00051AFD
		internal static global::System.Threading.Tasks.Task ForEachAsync<T>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T> source, global::System.Action<T> action, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Data.Entity.Infrastructure.IDbAsyncEnumerableExtensions.ForEachAsync<T>(source.GetAsyncEnumerator(), action, cancellationToken);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x0005390C File Offset: 0x00051B0C
		private static async global::System.Threading.Tasks.Task ForEachAsync<T>(global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> enumerator, global::System.Action<T> action, global::System.Threading.CancellationToken cancellationToken)
		{
			using (enumerator)
			{
				cancellationToken.ThrowIfCancellationRequested();
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = enumerator.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (cultureAwaiter.GetResult())
				{
					do
					{
						cancellationToken.ThrowIfCancellationRequested();
						T obj = enumerator.Current;
						global::System.Threading.Tasks.Task<bool> task = enumerator.MoveNextAsync(cancellationToken);
						action(obj);
						cultureAwaiter = task.WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
					}
					while (cultureAwaiter.GetResult());
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> dbAsyncEnumerator = null;
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00053961 File Offset: 0x00051B61
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<T>> ToListAsync<T>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable source)
		{
			return source.ToListAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00053970 File Offset: 0x00051B70
		internal static async global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<T>> ToListAsync<T>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			await source.ForEachAsync(delegate(object e)
			{
				list.Add((T)((object)e));
			}, cancellationToken).WithCurrentCulture();
			return list;
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x000539BD File Offset: 0x00051BBD
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<T>> ToListAsync<T>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T> source)
		{
			return source.ToListAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x000539CC File Offset: 0x00051BCC
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<T>> ToListAsync<T>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T> source, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.TaskCompletionSource<global::System.Collections.Generic.List<T>> tcs = new global::System.Threading.Tasks.TaskCompletionSource<global::System.Collections.Generic.List<T>>();
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			source.ForEachAsync(new global::System.Action<T>(list.Add), cancellationToken).ContinueWith(delegate(global::System.Threading.Tasks.Task t)
			{
				if (t.IsFaulted)
				{
					tcs.TrySetException(t.Exception.InnerExceptions);
					return;
				}
				if (t.IsCanceled)
				{
					tcs.TrySetCanceled();
					return;
				}
				tcs.TrySetResult(list);
			}, global::System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously);
			return tcs.Task;
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00053A30 File Offset: 0x00051C30
		internal static global::System.Threading.Tasks.Task<T[]> ToArrayAsync<T>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T> source)
		{
			return source.ToArrayAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00053A40 File Offset: 0x00051C40
		internal static async global::System.Threading.Tasks.Task<T[]> ToArrayAsync<T>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T> source, global::System.Threading.CancellationToken cancellationToken)
		{
			return (await source.ToListAsync(cancellationToken).WithCurrentCulture<global::System.Collections.Generic.List<T>>()).ToArray();
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00053A8D File Offset: 0x00051C8D
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, TKey> keySelector)
		{
			return source.ToDictionaryAsync(keySelector, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerableExtensions.IdentityFunction<TSource>.Instance, null, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00053AA1 File Offset: 0x00051CA1
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Threading.CancellationToken cancellationToken)
		{
			return source.ToDictionaryAsync(keySelector, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerableExtensions.IdentityFunction<TSource>.Instance, null, cancellationToken);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00053AB1 File Offset: 0x00051CB1
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			return source.ToDictionaryAsync(keySelector, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerableExtensions.IdentityFunction<TSource>.Instance, comparer, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00053AC5 File Offset: 0x00051CC5
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer, global::System.Threading.CancellationToken cancellationToken)
		{
			return source.ToDictionaryAsync(keySelector, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerableExtensions.IdentityFunction<TSource>.Instance, comparer, cancellationToken);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00053AD5 File Offset: 0x00051CD5
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Func<TSource, TElement> elementSelector)
		{
			return source.ToDictionaryAsync(keySelector, elementSelector, null, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00053AE5 File Offset: 0x00051CE5
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Func<TSource, TElement> elementSelector, global::System.Threading.CancellationToken cancellationToken)
		{
			return source.ToDictionaryAsync(keySelector, elementSelector, null, cancellationToken);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00053AF1 File Offset: 0x00051CF1
		internal static global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Func<TSource, TElement> elementSelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer)
		{
			return source.ToDictionaryAsync(keySelector, elementSelector, comparer, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00053B04 File Offset: 0x00051D04
		internal static async global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, TKey> keySelector, global::System.Func<TSource, TElement> elementSelector, global::System.Collections.Generic.IEqualityComparer<TKey> comparer, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Collections.Generic.Dictionary<TKey, TElement> d = new global::System.Collections.Generic.Dictionary<TKey, TElement>(comparer);
			await source.ForEachAsync(delegate(TSource element)
			{
				d.Add(keySelector(element), elementSelector(element));
			}, cancellationToken).WithCurrentCulture();
			return d;
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00053B6A File Offset: 0x00051D6A
		internal static global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TResult> Cast<TResult>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable source)
		{
			return new global::System.Data.Entity.Infrastructure.IDbAsyncEnumerableExtensions.CastDbAsyncEnumerable<TResult>(source);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00053B72 File Offset: 0x00051D72
		internal static global::System.Threading.Tasks.Task<TSource> FirstAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.FirstAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00053B7F File Offset: 0x00051D7F
		internal static global::System.Threading.Tasks.Task<TSource> FirstAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate)
		{
			return source.FirstAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00053B90 File Offset: 0x00051D90
		internal static async global::System.Threading.Tasks.Task<TSource> FirstAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (cultureAwaiter.GetResult())
				{
					return e.Current;
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			throw global::System.Data.Entity.Resources.Error.EmptySequence();
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00053BE0 File Offset: 0x00051DE0
		internal static async global::System.Threading.Tasks.Task<TSource> FirstAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (cultureAwaiter.GetResult() && predicate(e.Current))
				{
					return e.Current;
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			throw global::System.Data.Entity.Resources.Error.NoMatch();
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00053C35 File Offset: 0x00051E35
		internal static global::System.Threading.Tasks.Task<TSource> FirstOrDefaultAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.FirstOrDefaultAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00053C42 File Offset: 0x00051E42
		internal static global::System.Threading.Tasks.Task<TSource> FirstOrDefaultAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate)
		{
			return source.FirstOrDefaultAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00053C50 File Offset: 0x00051E50
		internal static async global::System.Threading.Tasks.Task<TSource> FirstOrDefaultAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (cultureAwaiter.GetResult())
				{
					return e.Current;
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return default(TSource);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00053CA0 File Offset: 0x00051EA0
		internal static async global::System.Threading.Tasks.Task<TSource> FirstOrDefaultAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (cultureAwaiter.GetResult() && predicate(e.Current))
				{
					return e.Current;
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return default(TSource);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00053CF5 File Offset: 0x00051EF5
		internal static global::System.Threading.Tasks.Task<TSource> SingleAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.SingleAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00053D04 File Offset: 0x00051F04
		internal static async global::System.Threading.Tasks.Task<TSource> SingleAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (!cultureAwaiter.GetResult())
				{
					throw global::System.Data.Entity.Resources.Error.EmptySequence();
				}
				cancellationToken.ThrowIfCancellationRequested();
				TSource result = e.Current;
				cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (!cultureAwaiter.GetResult())
				{
					return result;
				}
				result = default(TSource);
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			throw global::System.Data.Entity.Resources.Error.MoreThanOneElement();
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00053D51 File Offset: 0x00051F51
		internal static global::System.Threading.Tasks.Task<TSource> SingleAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate)
		{
			return source.SingleAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00053D60 File Offset: 0x00051F60
		internal static async global::System.Threading.Tasks.Task<TSource> SingleAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			TSource result = default(TSource);
			long count = 0L;
			long num;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					if (predicate(e.Current))
					{
						result = e.Current;
						num = count;
						count = checked(num + 1L);
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			num = count;
			if (num == 0L)
			{
				throw global::System.Data.Entity.Resources.Error.NoMatch();
			}
			if (num != 1L)
			{
				throw global::System.Data.Entity.Resources.Error.MoreThanOneMatch();
			}
			return result;
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00053DB5 File Offset: 0x00051FB5
		internal static global::System.Threading.Tasks.Task<TSource> SingleOrDefaultAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.SingleOrDefaultAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x00053DC4 File Offset: 0x00051FC4
		internal static async global::System.Threading.Tasks.Task<TSource> SingleOrDefaultAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (!cultureAwaiter.GetResult())
				{
					return default(TSource);
				}
				cancellationToken.ThrowIfCancellationRequested();
				TSource result = e.Current;
				cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (!cultureAwaiter.GetResult())
				{
					return result;
				}
				result = default(TSource);
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			throw global::System.Data.Entity.Resources.Error.MoreThanOneElement();
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00053E11 File Offset: 0x00052011
		internal static global::System.Threading.Tasks.Task<TSource> SingleOrDefaultAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate)
		{
			return source.SingleOrDefaultAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00053E20 File Offset: 0x00052020
		internal static async global::System.Threading.Tasks.Task<TSource> SingleOrDefaultAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			TSource result = default(TSource);
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					if (predicate(e.Current))
					{
						result = e.Current;
						long num = count;
						count = checked(num + 1L);
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			if (count < 2L)
			{
				return result;
			}
			throw global::System.Data.Entity.Resources.Error.MoreThanOneMatch();
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00053E75 File Offset: 0x00052075
		internal static global::System.Threading.Tasks.Task<bool> ContainsAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, TSource value)
		{
			return source.ContainsAsync(value, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00053E84 File Offset: 0x00052084
		internal static async global::System.Threading.Tasks.Task<bool> ContainsAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, TSource value, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						goto Block_5;
					}
					if (global::System.Collections.Generic.EqualityComparer<TSource>.Default.Equals(e.Current, value))
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
				}
				return true;
				Block_5:;
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return false;
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00053ED9 File Offset: 0x000520D9
		internal static global::System.Threading.Tasks.Task<bool> AnyAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.AnyAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00053EE8 File Offset: 0x000520E8
		internal static async global::System.Threading.Tasks.Task<bool> AnyAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
				if (!cultureAwaiter.IsCompleted)
				{
					await cultureAwaiter;
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
					cultureAwaiter = cultureAwaiter2;
					cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
				}
				if (cultureAwaiter.GetResult())
				{
					return true;
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return false;
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00053F35 File Offset: 0x00052135
		internal static global::System.Threading.Tasks.Task<bool> AnyAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate)
		{
			return source.AnyAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00053F44 File Offset: 0x00052144
		internal static async global::System.Threading.Tasks.Task<bool> AnyAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						goto Block_5;
					}
					if (predicate(e.Current))
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
				}
				return true;
				Block_5:;
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return false;
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00053F99 File Offset: 0x00052199
		internal static global::System.Threading.Tasks.Task<bool> AllAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate)
		{
			return source.AllAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00053FA8 File Offset: 0x000521A8
		internal static async global::System.Threading.Tasks.Task<bool> AllAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						goto Block_5;
					}
					if (!predicate(e.Current))
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
				}
				return false;
				Block_5:;
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return true;
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00053FFD File Offset: 0x000521FD
		internal static global::System.Threading.Tasks.Task<int> CountAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.CountAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0005400C File Offset: 0x0005220C
		internal static async global::System.Threading.Tasks.Task<int> CountAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			int count = 0;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					int num = count;
					count = checked(num + 1);
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return count;
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00054059 File Offset: 0x00052259
		internal static global::System.Threading.Tasks.Task<int> CountAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate)
		{
			return source.CountAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00054068 File Offset: 0x00052268
		internal static async global::System.Threading.Tasks.Task<int> CountAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			int count = 0;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					if (predicate(e.Current))
					{
						int num = count;
						count = checked(num + 1);
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return count;
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x000540BD File Offset: 0x000522BD
		internal static global::System.Threading.Tasks.Task<long> LongCountAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.LongCountAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x000540CC File Offset: 0x000522CC
		internal static async global::System.Threading.Tasks.Task<long> LongCountAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					long num = count;
					count = checked(num + 1L);
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return count;
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x00054119 File Offset: 0x00052319
		internal static global::System.Threading.Tasks.Task<long> LongCountAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate)
		{
			return source.LongCountAsync(predicate, global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x00054128 File Offset: 0x00052328
		internal static async global::System.Threading.Tasks.Task<long> LongCountAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Func<TSource, bool> predicate, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					if (predicate(e.Current))
					{
						long num = count;
						count = checked(num + 1L);
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
			return count;
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0005417D File Offset: 0x0005237D
		internal static global::System.Threading.Tasks.Task<TSource> MinAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.MinAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0005418C File Offset: 0x0005238C
		internal static async global::System.Threading.Tasks.Task<TSource> MinAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Collections.Generic.Comparer<TSource> comparer = global::System.Collections.Generic.Comparer<TSource>.Default;
			TSource value = default(TSource);
			TSource result;
			if (value == null)
			{
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						if (e.Current != null && (value == null || comparer.Compare(e.Current, value) < 0))
						{
							value = e.Current;
						}
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
				result = value;
			}
			else
			{
				bool hasValue = false;
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						if (hasValue)
						{
							if (comparer.Compare(e.Current, value) < 0)
							{
								value = e.Current;
							}
						}
						else
						{
							value = e.Current;
							hasValue = true;
						}
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
				if (!hasValue)
				{
					throw global::System.Data.Entity.Resources.Error.EmptySequence();
				}
				result = value;
			}
			return result;
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x000541D9 File Offset: 0x000523D9
		internal static global::System.Threading.Tasks.Task<TSource> MaxAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source)
		{
			return source.MaxAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x000541E8 File Offset: 0x000523E8
		internal static async global::System.Threading.Tasks.Task<TSource> MaxAsync<TSource>(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TSource> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			global::System.Collections.Generic.Comparer<TSource> comparer = global::System.Collections.Generic.Comparer<TSource>.Default;
			TSource value = default(TSource);
			TSource result;
			if (value == null)
			{
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						if (e.Current != null && (value == null || comparer.Compare(e.Current, value) > 0))
						{
							value = e.Current;
						}
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
				result = value;
			}
			else
			{
				bool hasValue = false;
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						if (hasValue)
						{
							if (comparer.Compare(e.Current, value) > 0)
							{
								value = e.Current;
							}
						}
						else
						{
							value = e.Current;
							hasValue = true;
						}
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TSource> e = null;
				if (!hasValue)
				{
					throw global::System.Data.Entity.Resources.Error.EmptySequence();
				}
				result = value;
			}
			return result;
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x00054235 File Offset: 0x00052435
		internal static global::System.Threading.Tasks.Task<int> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<int> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00054244 File Offset: 0x00052444
		internal static async global::System.Threading.Tasks.Task<int> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<int> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long sum = 0L;
			checked
			{
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<int> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						sum += unchecked((long)e.Current);
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<int> e = null;
			}
			return (int)sum;
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x00054291 File Offset: 0x00052491
		internal static global::System.Threading.Tasks.Task<int?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<int?> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x000542A0 File Offset: 0x000524A0
		internal static async global::System.Threading.Tasks.Task<int?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<int?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long sum = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<int?> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					int? num = e.Current;
					if (num != null)
					{
						long num2 = sum;
						num = e.Current;
						sum = checked(num2 + unchecked((long)num.GetValueOrDefault()));
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<int?> e = null;
			return new int?((int)sum);
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x000542ED File Offset: 0x000524ED
		internal static global::System.Threading.Tasks.Task<long> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<long> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x000542FC File Offset: 0x000524FC
		internal static async global::System.Threading.Tasks.Task<long> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<long> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long sum = 0L;
			checked
			{
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<long> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						sum += e.Current;
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<long> e = null;
				return sum;
			}
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00054349 File Offset: 0x00052549
		internal static global::System.Threading.Tasks.Task<long?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<long?> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00054358 File Offset: 0x00052558
		internal static async global::System.Threading.Tasks.Task<long?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<long?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long sum = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<long?> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					long? num = e.Current;
					if (num != null)
					{
						long num2 = sum;
						num = e.Current;
						sum = checked(num2 + num.GetValueOrDefault());
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<long?> e = null;
			return new long?(sum);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000543A5 File Offset: 0x000525A5
		internal static global::System.Threading.Tasks.Task<float> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<float> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000543B4 File Offset: 0x000525B4
		internal static async global::System.Threading.Tasks.Task<float> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<float> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			double sum = 0.0;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<float> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					sum += (double)e.Current;
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<float> e = null;
			return (float)sum;
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x00054401 File Offset: 0x00052601
		internal static global::System.Threading.Tasks.Task<float?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<float?> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00054410 File Offset: 0x00052610
		internal static async global::System.Threading.Tasks.Task<float?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<float?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			double sum = 0.0;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<float?> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					float? num = e.Current;
					if (num != null)
					{
						double num2 = sum;
						num = e.Current;
						sum = num2 + (double)num.GetValueOrDefault();
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<float?> e = null;
			return new float?((float)sum);
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0005445D File Offset: 0x0005265D
		internal static global::System.Threading.Tasks.Task<double> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<double> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0005446C File Offset: 0x0005266C
		internal static async global::System.Threading.Tasks.Task<double> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<double> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			double sum = 0.0;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<double> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					sum += e.Current;
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<double> e = null;
			return sum;
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x000544B9 File Offset: 0x000526B9
		internal static global::System.Threading.Tasks.Task<double?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<double?> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000544C8 File Offset: 0x000526C8
		internal static async global::System.Threading.Tasks.Task<double?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<double?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			double sum = 0.0;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<double?> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					double? num = e.Current;
					if (num != null)
					{
						double num2 = sum;
						num = e.Current;
						sum = num2 + num.GetValueOrDefault();
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<double?> e = null;
			return new double?(sum);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00054515 File Offset: 0x00052715
		internal static global::System.Threading.Tasks.Task<decimal> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<decimal> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00054524 File Offset: 0x00052724
		internal static async global::System.Threading.Tasks.Task<decimal> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<decimal> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			decimal sum = 0m;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<decimal> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					sum += e.Current;
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<decimal> e = null;
			return sum;
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00054571 File Offset: 0x00052771
		internal static global::System.Threading.Tasks.Task<decimal?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<decimal?> source)
		{
			return source.SumAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00054580 File Offset: 0x00052780
		internal static async global::System.Threading.Tasks.Task<decimal?> SumAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<decimal?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			decimal sum = 0m;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<decimal?> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					decimal? num = e.Current;
					if (num != null)
					{
						decimal d = sum;
						num = e.Current;
						sum = d + num.GetValueOrDefault();
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<decimal?> e = null;
			return new decimal?(sum);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000545CD File Offset: 0x000527CD
		internal static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<int> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x000545DC File Offset: 0x000527DC
		internal static async global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<int> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long sum = 0L;
			long count = 0L;
			checked
			{
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<int> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						sum += unchecked((long)e.Current);
						long num = count;
						count = num + 1L;
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<int> e = null;
				if (count > 0L)
				{
					return (double)sum / (double)count;
				}
				throw global::System.Data.Entity.Resources.Error.EmptySequence();
			}
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00054629 File Offset: 0x00052829
		internal static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<int?> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00054638 File Offset: 0x00052838
		internal static async global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<int?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long sum = 0L;
			long count = 0L;
			checked
			{
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<int?> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						int? num = e.Current;
						if (num != null)
						{
							long num2 = sum;
							num = e.Current;
							sum = num2 + unchecked((long)num.GetValueOrDefault());
							long num3 = count;
							count = num3 + 1L;
						}
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<int?> e = null;
				if (count > 0L)
				{
					return new double?((double)sum / (double)count);
				}
				throw global::System.Data.Entity.Resources.Error.EmptySequence();
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00054685 File Offset: 0x00052885
		internal static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<long> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00054694 File Offset: 0x00052894
		internal static async global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<long> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long sum = 0L;
			long count = 0L;
			checked
			{
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<long> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						sum += e.Current;
						long num = count;
						count = num + 1L;
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<long> e = null;
				if (count > 0L)
				{
					return (double)sum / (double)count;
				}
				throw global::System.Data.Entity.Resources.Error.EmptySequence();
			}
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x000546E1 File Offset: 0x000528E1
		internal static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<long?> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x000546F0 File Offset: 0x000528F0
		internal static async global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<long?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			long sum = 0L;
			long count = 0L;
			checked
			{
				using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<long?> e = source.GetAsyncEnumerator())
				{
					for (;;)
					{
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
						if (!cultureAwaiter.IsCompleted)
						{
							await cultureAwaiter;
							global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
							cultureAwaiter = cultureAwaiter2;
							cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
						}
						if (!cultureAwaiter.GetResult())
						{
							break;
						}
						cancellationToken.ThrowIfCancellationRequested();
						long? num = e.Current;
						if (num != null)
						{
							long num2 = sum;
							num = e.Current;
							sum = num2 + num.GetValueOrDefault();
							long num3 = count;
							count = num3 + 1L;
						}
					}
				}
				global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<long?> e = null;
				if (count > 0L)
				{
					return new double?((double)sum / (double)count);
				}
				throw global::System.Data.Entity.Resources.Error.EmptySequence();
			}
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x0005473D File Offset: 0x0005293D
		internal static global::System.Threading.Tasks.Task<float> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<float> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x0005474C File Offset: 0x0005294C
		internal static async global::System.Threading.Tasks.Task<float> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<float> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			double sum = 0.0;
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<float> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					sum += (double)e.Current;
					long num = count;
					count = checked(num + 1L);
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<float> e = null;
			if (count > 0L)
			{
				return (float)(sum / (double)count);
			}
			throw global::System.Data.Entity.Resources.Error.EmptySequence();
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00054799 File Offset: 0x00052999
		internal static global::System.Threading.Tasks.Task<float?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<float?> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x000547A8 File Offset: 0x000529A8
		internal static async global::System.Threading.Tasks.Task<float?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<float?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			double sum = 0.0;
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<float?> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					float? num = e.Current;
					if (num != null)
					{
						double num2 = sum;
						num = e.Current;
						sum = num2 + (double)num.GetValueOrDefault();
						long num3 = count;
						count = checked(num3 + 1L);
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<float?> e = null;
			if (count > 0L)
			{
				return new float?((float)(sum / (double)count));
			}
			throw global::System.Data.Entity.Resources.Error.EmptySequence();
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000547F5 File Offset: 0x000529F5
		internal static global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<double> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00054804 File Offset: 0x00052A04
		internal static async global::System.Threading.Tasks.Task<double> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<double> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			double sum = 0.0;
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<double> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					sum += e.Current;
					long num = count;
					count = checked(num + 1L);
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<double> e = null;
			if (count > 0L)
			{
				return (double)((float)(sum / (double)count));
			}
			throw global::System.Data.Entity.Resources.Error.EmptySequence();
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00054851 File Offset: 0x00052A51
		internal static global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<double?> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00054860 File Offset: 0x00052A60
		internal static async global::System.Threading.Tasks.Task<double?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<double?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			double sum = 0.0;
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<double?> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					double? num = e.Current;
					if (num != null)
					{
						double num2 = sum;
						num = e.Current;
						sum = num2 + num.GetValueOrDefault();
						long num3 = count;
						count = checked(num3 + 1L);
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<double?> e = null;
			if (count > 0L)
			{
				return new double?((double)((float)(sum / (double)count)));
			}
			throw global::System.Data.Entity.Resources.Error.EmptySequence();
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x000548AD File Offset: 0x00052AAD
		internal static global::System.Threading.Tasks.Task<decimal> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<decimal> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x000548BC File Offset: 0x00052ABC
		internal static async global::System.Threading.Tasks.Task<decimal> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<decimal> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			decimal sum = 0m;
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<decimal> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					sum += e.Current;
					long num = count;
					count = checked(num + 1L);
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<decimal> e = null;
			if (count > 0L)
			{
				return sum / count;
			}
			throw global::System.Data.Entity.Resources.Error.EmptySequence();
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00054909 File Offset: 0x00052B09
		internal static global::System.Threading.Tasks.Task<decimal?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<decimal?> source)
		{
			return source.AverageAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00054918 File Offset: 0x00052B18
		internal static async global::System.Threading.Tasks.Task<decimal?> AverageAsync(this global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<decimal?> source, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			decimal sum = 0m;
			long count = 0L;
			using (global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<decimal?> e = source.GetAsyncEnumerator())
			{
				for (;;)
				{
					global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter = e.MoveNextAsync(cancellationToken).WithCurrentCulture<bool>().GetAwaiter();
					if (!cultureAwaiter.IsCompleted)
					{
						await cultureAwaiter;
						global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool> cultureAwaiter2;
						cultureAwaiter = cultureAwaiter2;
						cultureAwaiter2 = default(global::System.Data.Entity.Utilities.TaskExtensions.CultureAwaiter<bool>);
					}
					if (!cultureAwaiter.GetResult())
					{
						break;
					}
					cancellationToken.ThrowIfCancellationRequested();
					decimal? num = e.Current;
					if (num != null)
					{
						decimal d = sum;
						num = e.Current;
						sum = d + num.GetValueOrDefault();
						long num2 = count;
						count = checked(num2 + 1L);
					}
				}
			}
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<decimal?> e = null;
			if (count > 0L)
			{
				return new decimal?(sum / count);
			}
			throw global::System.Data.Entity.Resources.Error.EmptySequence();
		}

		// Token: 0x02000944 RID: 2372
		private class CastDbAsyncEnumerable<TResult> : global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable<!0>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
		{
			// Token: 0x06005DD0 RID: 24016 RVA: 0x00140A86 File Offset: 0x0013EC86
			public CastDbAsyncEnumerable(global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable sourceEnumerable)
			{
				this._underlyingEnumerable = sourceEnumerable;
			}

			// Token: 0x06005DD1 RID: 24017 RVA: 0x00140A95 File Offset: 0x0013EC95
			public global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TResult> GetAsyncEnumerator()
			{
				return this._underlyingEnumerable.GetAsyncEnumerator().Cast<TResult>();
			}

			// Token: 0x06005DD2 RID: 24018 RVA: 0x00140AA7 File Offset: 0x0013ECA7
			global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
			{
				return this._underlyingEnumerable.GetAsyncEnumerator();
			}

			// Token: 0x040025AB RID: 9643
			private readonly global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable _underlyingEnumerable;
		}

		// Token: 0x02000945 RID: 2373
		private static class IdentityFunction<TElement>
		{
			// Token: 0x17001077 RID: 4215
			// (get) Token: 0x06005DD3 RID: 24019 RVA: 0x00140AB4 File Offset: 0x0013ECB4
			internal static global::System.Func<TElement, TElement> Instance
			{
				get
				{
					return (TElement x) => x;
				}
			}
		}
	}
}
