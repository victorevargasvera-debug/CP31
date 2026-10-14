using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000040 RID: 64
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class AsyncUtils
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x000100E4 File Offset: 0x0000E2E4
		internal static global::System.Threading.Tasks.Task<bool> ToAsync(this bool value)
		{
			if (!value)
			{
				return global::Newtonsoft.Json.Utilities.AsyncUtils.False;
			}
			return global::Newtonsoft.Json.Utilities.AsyncUtils.True;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000100F4 File Offset: 0x0000E2F4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static global::System.Threading.Tasks.Task CancelIfRequestedAsync(this global::System.Threading.CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return null;
			}
			return cancellationToken.FromCanceled();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00010107 File Offset: 0x0000E307
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		public static global::System.Threading.Tasks.Task<T> CancelIfRequestedAsync<T>(this global::System.Threading.CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return null;
			}
			return cancellationToken.FromCanceled<T>();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0001011A File Offset: 0x0000E31A
		public static global::System.Threading.Tasks.Task FromCanceled(this global::System.Threading.CancellationToken cancellationToken)
		{
			return new global::System.Threading.Tasks.Task(delegate()
			{
			}, cancellationToken);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00010144 File Offset: 0x0000E344
		public static global::System.Threading.Tasks.Task<T> FromCanceled<[global::System.Runtime.CompilerServices.Nullable(2)] T>(this global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Func<T> function;
			if ((function = global::Newtonsoft.Json.Utilities.AsyncUtils.<>c__6<T>.<>9__6_0) == null)
			{
				global::System.Func<T> func = global::Newtonsoft.Json.Utilities.AsyncUtils.<>c__6<T>.<>9__6_0 = (() => default(T));
				function = func;
			}
			return new global::System.Threading.Tasks.Task<T>(function, cancellationToken);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00010178 File Offset: 0x0000E378
		public static global::System.Threading.Tasks.Task WriteAsync(this global::System.IO.TextWriter writer, char value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return writer.WriteAsync(value);
			}
			return cancellationToken.FromCanceled();
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00010191 File Offset: 0x0000E391
		public static global::System.Threading.Tasks.Task WriteAsync(this global::System.IO.TextWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] string value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return writer.WriteAsync(value);
			}
			return cancellationToken.FromCanceled();
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000101AA File Offset: 0x0000E3AA
		public static global::System.Threading.Tasks.Task WriteAsync(this global::System.IO.TextWriter writer, char[] value, int start, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return writer.WriteAsync(value, start, count);
			}
			return cancellationToken.FromCanceled();
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000101C6 File Offset: 0x0000E3C6
		public static global::System.Threading.Tasks.Task<int> ReadAsync(this global::System.IO.TextReader reader, char[] buffer, int index, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				return reader.ReadAsync(buffer, index, count);
			}
			return cancellationToken.FromCanceled<int>();
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000101E2 File Offset: 0x0000E3E2
		public static bool IsCompletedSucessfully(this global::System.Threading.Tasks.Task task)
		{
			return task.Status == global::System.Threading.Tasks.TaskStatus.RanToCompletion;
		}

		// Token: 0x0400014B RID: 331
		public static readonly global::System.Threading.Tasks.Task<bool> False = global::System.Threading.Tasks.Task.FromResult<bool>(false);

		// Token: 0x0400014C RID: 332
		public static readonly global::System.Threading.Tasks.Task<bool> True = global::System.Threading.Tasks.Task.FromResult<bool>(true);

		// Token: 0x0400014D RID: 333
		internal static readonly global::System.Threading.Tasks.Task CompletedTask = global::System.Threading.Tasks.Task.Delay(0);
	}
}
