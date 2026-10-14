using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200002F RID: 47
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JsonTextWriter : global::Newtonsoft.Json.JsonWriter
	{
		// Token: 0x0600025F RID: 607 RVA: 0x0000A05A File Offset: 0x0000825A
		public override global::System.Threading.Tasks.Task FlushAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.FlushAsync(cancellationToken);
			}
			return this.DoFlushAsync(cancellationToken);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000A073 File Offset: 0x00008273
		internal global::System.Threading.Tasks.Task DoFlushAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return cancellationToken.CancelIfRequestedAsync() ?? this._writer.FlushAsync();
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000A08A File Offset: 0x0000828A
		protected override global::System.Threading.Tasks.Task WriteValueDelimiterAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			if (!this._safeAsync)
			{
				return base.WriteValueDelimiterAsync(cancellationToken);
			}
			return this.DoWriteValueDelimiterAsync(cancellationToken);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000A0A3 File Offset: 0x000082A3
		internal global::System.Threading.Tasks.Task DoWriteValueDelimiterAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this._writer.WriteAsync(',', cancellationToken);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000A0B3 File Offset: 0x000082B3
		protected override global::System.Threading.Tasks.Task WriteEndAsync(global::Newtonsoft.Json.JsonToken token, global::System.Threading.CancellationToken cancellationToken)
		{
			if (!this._safeAsync)
			{
				return base.WriteEndAsync(token, cancellationToken);
			}
			return this.DoWriteEndAsync(token, cancellationToken);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000A0D0 File Offset: 0x000082D0
		internal global::System.Threading.Tasks.Task DoWriteEndAsync(global::Newtonsoft.Json.JsonToken token, global::System.Threading.CancellationToken cancellationToken)
		{
			switch (token)
			{
			case global::Newtonsoft.Json.JsonToken.EndObject:
				return this._writer.WriteAsync('}', cancellationToken);
			case global::Newtonsoft.Json.JsonToken.EndArray:
				return this._writer.WriteAsync(']', cancellationToken);
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				return this._writer.WriteAsync(')', cancellationToken);
			default:
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Invalid JsonToken: " + token.ToString(), null);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0000A13F File Offset: 0x0000833F
		public override global::System.Threading.Tasks.Task CloseAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.CloseAsync(cancellationToken);
			}
			return this.DoCloseAsync(cancellationToken);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0000A158 File Offset: 0x00008358
		internal global::System.Threading.Tasks.Task DoCloseAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoCloseAsync>d__8 <DoCloseAsync>d__;
			<DoCloseAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoCloseAsync>d__.<>4__this = this;
			<DoCloseAsync>d__.cancellationToken = cancellationToken;
			<DoCloseAsync>d__.<>1__state = -1;
			<DoCloseAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoCloseAsync>d__8>(ref <DoCloseAsync>d__);
			return <DoCloseAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000A1A3 File Offset: 0x000083A3
		public override global::System.Threading.Tasks.Task WriteEndAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteEndAsync(cancellationToken);
			}
			return base.WriteEndInternalAsync(cancellationToken);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000A1BC File Offset: 0x000083BC
		protected override global::System.Threading.Tasks.Task WriteIndentAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			if (!this._safeAsync)
			{
				return base.WriteIndentAsync(cancellationToken);
			}
			return this.DoWriteIndentAsync(cancellationToken);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000A1D8 File Offset: 0x000083D8
		internal global::System.Threading.Tasks.Task DoWriteIndentAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			int num = base.Top * this._indentation;
			int num2 = this.SetIndentChars();
			if (num <= 12)
			{
				return this._writer.WriteAsync(this._indentChars, 0, num2 + num, cancellationToken);
			}
			return this.WriteIndentAsync(num, num2, cancellationToken);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000A220 File Offset: 0x00008420
		private global::System.Threading.Tasks.Task WriteIndentAsync(int currentIndentCount, int newLineLen, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<WriteIndentAsync>d__12 <WriteIndentAsync>d__;
			<WriteIndentAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteIndentAsync>d__.<>4__this = this;
			<WriteIndentAsync>d__.currentIndentCount = currentIndentCount;
			<WriteIndentAsync>d__.newLineLen = newLineLen;
			<WriteIndentAsync>d__.cancellationToken = cancellationToken;
			<WriteIndentAsync>d__.<>1__state = -1;
			<WriteIndentAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<WriteIndentAsync>d__12>(ref <WriteIndentAsync>d__);
			return <WriteIndentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000A27C File Offset: 0x0000847C
		private global::System.Threading.Tasks.Task WriteValueInternalAsync(global::Newtonsoft.Json.JsonToken token, string value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = base.InternalWriteValueAsync(token, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this._writer.WriteAsync(value, cancellationToken);
			}
			return this.WriteValueInternalAsync(task, value, cancellationToken);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000A2B4 File Offset: 0x000084B4
		private global::System.Threading.Tasks.Task WriteValueInternalAsync(global::System.Threading.Tasks.Task task, string value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<WriteValueInternalAsync>d__14 <WriteValueInternalAsync>d__;
			<WriteValueInternalAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteValueInternalAsync>d__.<>4__this = this;
			<WriteValueInternalAsync>d__.task = task;
			<WriteValueInternalAsync>d__.value = value;
			<WriteValueInternalAsync>d__.cancellationToken = cancellationToken;
			<WriteValueInternalAsync>d__.<>1__state = -1;
			<WriteValueInternalAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<WriteValueInternalAsync>d__14>(ref <WriteValueInternalAsync>d__);
			return <WriteValueInternalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000A30F File Offset: 0x0000850F
		protected override global::System.Threading.Tasks.Task WriteIndentSpaceAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			if (!this._safeAsync)
			{
				return base.WriteIndentSpaceAsync(cancellationToken);
			}
			return this.DoWriteIndentSpaceAsync(cancellationToken);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000A328 File Offset: 0x00008528
		internal global::System.Threading.Tasks.Task DoWriteIndentSpaceAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this._writer.WriteAsync(' ', cancellationToken);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000A338 File Offset: 0x00008538
		public override global::System.Threading.Tasks.Task WriteRawAsync([global::System.Runtime.CompilerServices.Nullable(2)] string json, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteRawAsync(json, cancellationToken);
			}
			return this.DoWriteRawAsync(json, cancellationToken);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x0000A353 File Offset: 0x00008553
		internal global::System.Threading.Tasks.Task DoWriteRawAsync([global::System.Runtime.CompilerServices.Nullable(2)] string json, global::System.Threading.CancellationToken cancellationToken)
		{
			return this._writer.WriteAsync(json, cancellationToken);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000A362 File Offset: 0x00008562
		public override global::System.Threading.Tasks.Task WriteNullAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteNullAsync(cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000A37B File Offset: 0x0000857B
		internal global::System.Threading.Tasks.Task DoWriteNullAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.WriteValueInternalAsync(global::Newtonsoft.Json.JsonToken.Null, global::Newtonsoft.Json.JsonConvert.Null, cancellationToken);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000A38C File Offset: 0x0000858C
		private global::System.Threading.Tasks.Task WriteDigitsAsync(ulong uvalue, bool negative, global::System.Threading.CancellationToken cancellationToken)
		{
			if (uvalue <= 9UL & !negative)
			{
				return this._writer.WriteAsync((char)(48UL + uvalue), cancellationToken);
			}
			int count = this.WriteNumberToBuffer(uvalue, negative);
			return this._writer.WriteAsync(this._writeBuffer, 0, count, cancellationToken);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000A3DC File Offset: 0x000085DC
		private global::System.Threading.Tasks.Task WriteIntegerValueAsync(ulong uvalue, bool negative, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = base.InternalWriteValueAsync(global::Newtonsoft.Json.JsonToken.Integer, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this.WriteDigitsAsync(uvalue, negative, cancellationToken);
			}
			return this.WriteIntegerValueAsync(task, uvalue, negative, cancellationToken);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000A410 File Offset: 0x00008610
		private global::System.Threading.Tasks.Task WriteIntegerValueAsync(global::System.Threading.Tasks.Task task, ulong uvalue, bool negative, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<WriteIntegerValueAsync>d__23 <WriteIntegerValueAsync>d__;
			<WriteIntegerValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteIntegerValueAsync>d__.<>4__this = this;
			<WriteIntegerValueAsync>d__.task = task;
			<WriteIntegerValueAsync>d__.uvalue = uvalue;
			<WriteIntegerValueAsync>d__.negative = negative;
			<WriteIntegerValueAsync>d__.cancellationToken = cancellationToken;
			<WriteIntegerValueAsync>d__.<>1__state = -1;
			<WriteIntegerValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<WriteIntegerValueAsync>d__23>(ref <WriteIntegerValueAsync>d__);
			return <WriteIntegerValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000A474 File Offset: 0x00008674
		internal global::System.Threading.Tasks.Task WriteIntegerValueAsync(long value, global::System.Threading.CancellationToken cancellationToken)
		{
			bool flag = value < 0L;
			if (flag)
			{
				value = -value;
			}
			return this.WriteIntegerValueAsync((ulong)value, flag, cancellationToken);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0000A497 File Offset: 0x00008697
		internal global::System.Threading.Tasks.Task WriteIntegerValueAsync(ulong uvalue, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.WriteIntegerValueAsync(uvalue, false, cancellationToken);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000A4A4 File Offset: 0x000086A4
		private global::System.Threading.Tasks.Task WriteEscapedStringAsync(string value, bool quote, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteEscapedJavaScriptStringAsync(this._writer, value, this._quoteChar, quote, this._charEscapeFlags, base.StringEscapeHandling, this, this._writeBuffer, cancellationToken);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000A4D8 File Offset: 0x000086D8
		public override global::System.Threading.Tasks.Task WritePropertyNameAsync(string name, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WritePropertyNameAsync(name, cancellationToken);
			}
			return this.DoWritePropertyNameAsync(name, cancellationToken);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000A4F4 File Offset: 0x000086F4
		internal global::System.Threading.Tasks.Task DoWritePropertyNameAsync(string name, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = base.InternalWritePropertyNameAsync(name, cancellationToken);
			if (!task.IsCompletedSucessfully())
			{
				return this.DoWritePropertyNameAsync(task, name, cancellationToken);
			}
			task = this.WriteEscapedStringAsync(name, this._quoteName, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this._writer.WriteAsync(':', cancellationToken);
			}
			return global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteCharAsync(task, this._writer, ':', cancellationToken);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0000A554 File Offset: 0x00008754
		private global::System.Threading.Tasks.Task DoWritePropertyNameAsync(global::System.Threading.Tasks.Task task, string name, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWritePropertyNameAsync>d__29 <DoWritePropertyNameAsync>d__;
			<DoWritePropertyNameAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWritePropertyNameAsync>d__.<>4__this = this;
			<DoWritePropertyNameAsync>d__.task = task;
			<DoWritePropertyNameAsync>d__.name = name;
			<DoWritePropertyNameAsync>d__.cancellationToken = cancellationToken;
			<DoWritePropertyNameAsync>d__.<>1__state = -1;
			<DoWritePropertyNameAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWritePropertyNameAsync>d__29>(ref <DoWritePropertyNameAsync>d__);
			return <DoWritePropertyNameAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000A5AF File Offset: 0x000087AF
		public override global::System.Threading.Tasks.Task WritePropertyNameAsync(string name, bool escape, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WritePropertyNameAsync(name, escape, cancellationToken);
			}
			return this.DoWritePropertyNameAsync(name, escape, cancellationToken);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000A5CC File Offset: 0x000087CC
		internal global::System.Threading.Tasks.Task DoWritePropertyNameAsync(string name, bool escape, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWritePropertyNameAsync>d__31 <DoWritePropertyNameAsync>d__;
			<DoWritePropertyNameAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWritePropertyNameAsync>d__.<>4__this = this;
			<DoWritePropertyNameAsync>d__.name = name;
			<DoWritePropertyNameAsync>d__.escape = escape;
			<DoWritePropertyNameAsync>d__.cancellationToken = cancellationToken;
			<DoWritePropertyNameAsync>d__.<>1__state = -1;
			<DoWritePropertyNameAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWritePropertyNameAsync>d__31>(ref <DoWritePropertyNameAsync>d__);
			return <DoWritePropertyNameAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000A627 File Offset: 0x00008827
		public override global::System.Threading.Tasks.Task WriteStartArrayAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteStartArrayAsync(cancellationToken);
			}
			return this.DoWriteStartArrayAsync(cancellationToken);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000A640 File Offset: 0x00008840
		internal global::System.Threading.Tasks.Task DoWriteStartArrayAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = base.InternalWriteStartAsync(global::Newtonsoft.Json.JsonToken.StartArray, global::Newtonsoft.Json.JsonContainerType.Array, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this._writer.WriteAsync('[', cancellationToken);
			}
			return this.DoWriteStartArrayAsync(task, cancellationToken);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000A678 File Offset: 0x00008878
		internal global::System.Threading.Tasks.Task DoWriteStartArrayAsync(global::System.Threading.Tasks.Task task, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteStartArrayAsync>d__34 <DoWriteStartArrayAsync>d__;
			<DoWriteStartArrayAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteStartArrayAsync>d__.<>4__this = this;
			<DoWriteStartArrayAsync>d__.task = task;
			<DoWriteStartArrayAsync>d__.cancellationToken = cancellationToken;
			<DoWriteStartArrayAsync>d__.<>1__state = -1;
			<DoWriteStartArrayAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteStartArrayAsync>d__34>(ref <DoWriteStartArrayAsync>d__);
			return <DoWriteStartArrayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000A6CB File Offset: 0x000088CB
		public override global::System.Threading.Tasks.Task WriteStartObjectAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteStartObjectAsync(cancellationToken);
			}
			return this.DoWriteStartObjectAsync(cancellationToken);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000A6E4 File Offset: 0x000088E4
		internal global::System.Threading.Tasks.Task DoWriteStartObjectAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = base.InternalWriteStartAsync(global::Newtonsoft.Json.JsonToken.StartObject, global::Newtonsoft.Json.JsonContainerType.Object, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this._writer.WriteAsync('{', cancellationToken);
			}
			return this.DoWriteStartObjectAsync(task, cancellationToken);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000A71C File Offset: 0x0000891C
		internal global::System.Threading.Tasks.Task DoWriteStartObjectAsync(global::System.Threading.Tasks.Task task, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteStartObjectAsync>d__37 <DoWriteStartObjectAsync>d__;
			<DoWriteStartObjectAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteStartObjectAsync>d__.<>4__this = this;
			<DoWriteStartObjectAsync>d__.task = task;
			<DoWriteStartObjectAsync>d__.cancellationToken = cancellationToken;
			<DoWriteStartObjectAsync>d__.<>1__state = -1;
			<DoWriteStartObjectAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteStartObjectAsync>d__37>(ref <DoWriteStartObjectAsync>d__);
			return <DoWriteStartObjectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000A76F File Offset: 0x0000896F
		public override global::System.Threading.Tasks.Task WriteStartConstructorAsync(string name, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteStartConstructorAsync(name, cancellationToken);
			}
			return this.DoWriteStartConstructorAsync(name, cancellationToken);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000A78C File Offset: 0x0000898C
		internal global::System.Threading.Tasks.Task DoWriteStartConstructorAsync(string name, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteStartConstructorAsync>d__39 <DoWriteStartConstructorAsync>d__;
			<DoWriteStartConstructorAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteStartConstructorAsync>d__.<>4__this = this;
			<DoWriteStartConstructorAsync>d__.name = name;
			<DoWriteStartConstructorAsync>d__.cancellationToken = cancellationToken;
			<DoWriteStartConstructorAsync>d__.<>1__state = -1;
			<DoWriteStartConstructorAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteStartConstructorAsync>d__39>(ref <DoWriteStartConstructorAsync>d__);
			return <DoWriteStartConstructorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000A7DF File Offset: 0x000089DF
		public override global::System.Threading.Tasks.Task WriteUndefinedAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteUndefinedAsync(cancellationToken);
			}
			return this.DoWriteUndefinedAsync(cancellationToken);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000A7F8 File Offset: 0x000089F8
		internal global::System.Threading.Tasks.Task DoWriteUndefinedAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = base.InternalWriteValueAsync(global::Newtonsoft.Json.JsonToken.Undefined, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this._writer.WriteAsync(global::Newtonsoft.Json.JsonConvert.Undefined, cancellationToken);
			}
			return this.DoWriteUndefinedAsync(task, cancellationToken);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000A834 File Offset: 0x00008A34
		private global::System.Threading.Tasks.Task DoWriteUndefinedAsync(global::System.Threading.Tasks.Task task, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteUndefinedAsync>d__42 <DoWriteUndefinedAsync>d__;
			<DoWriteUndefinedAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteUndefinedAsync>d__.<>4__this = this;
			<DoWriteUndefinedAsync>d__.task = task;
			<DoWriteUndefinedAsync>d__.cancellationToken = cancellationToken;
			<DoWriteUndefinedAsync>d__.<>1__state = -1;
			<DoWriteUndefinedAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteUndefinedAsync>d__42>(ref <DoWriteUndefinedAsync>d__);
			return <DoWriteUndefinedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000A887 File Offset: 0x00008A87
		public override global::System.Threading.Tasks.Task WriteWhitespaceAsync(string ws, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteWhitespaceAsync(ws, cancellationToken);
			}
			return this.DoWriteWhitespaceAsync(ws, cancellationToken);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000A8A2 File Offset: 0x00008AA2
		internal global::System.Threading.Tasks.Task DoWriteWhitespaceAsync(string ws, global::System.Threading.CancellationToken cancellationToken)
		{
			base.InternalWriteWhitespace(ws);
			return this._writer.WriteAsync(ws, cancellationToken);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		public override global::System.Threading.Tasks.Task WriteValueAsync(bool value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000A8D3 File Offset: 0x00008AD3
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(bool value, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.WriteValueInternalAsync(global::Newtonsoft.Json.JsonToken.Boolean, global::Newtonsoft.Json.JsonConvert.ToString(value), cancellationToken);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		public override global::System.Threading.Tasks.Task WriteValueAsync(bool? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000A8FF File Offset: 0x00008AFF
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(bool? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.DoWriteValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000A920 File Offset: 0x00008B20
		public override global::System.Threading.Tasks.Task WriteValueAsync(byte value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteIntegerValueAsync((long)((ulong)value), cancellationToken);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000A93C File Offset: 0x00008B3C
		public override global::System.Threading.Tasks.Task WriteValueAsync(byte? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000A957 File Offset: 0x00008B57
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(byte? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.WriteIntegerValueAsync((long)((ulong)value.GetValueOrDefault()), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000A979 File Offset: 0x00008B79
		public override global::System.Threading.Tasks.Task WriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] byte[] value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			if (value != null)
			{
				return this.WriteValueNonNullAsync(value, cancellationToken);
			}
			return this.WriteNullAsync(cancellationToken);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		internal global::System.Threading.Tasks.Task WriteValueNonNullAsync(byte[] value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<WriteValueNonNullAsync>d__53 <WriteValueNonNullAsync>d__;
			<WriteValueNonNullAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteValueNonNullAsync>d__.<>4__this = this;
			<WriteValueNonNullAsync>d__.value = value;
			<WriteValueNonNullAsync>d__.cancellationToken = cancellationToken;
			<WriteValueNonNullAsync>d__.<>1__state = -1;
			<WriteValueNonNullAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<WriteValueNonNullAsync>d__53>(ref <WriteValueNonNullAsync>d__);
			return <WriteValueNonNullAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000A9F3 File Offset: 0x00008BF3
		public override global::System.Threading.Tasks.Task WriteValueAsync(char value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000AA0E File Offset: 0x00008C0E
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(char value, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.WriteValueInternalAsync(global::Newtonsoft.Json.JsonToken.String, global::Newtonsoft.Json.JsonConvert.ToString(value), cancellationToken);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000AA1F File Offset: 0x00008C1F
		public override global::System.Threading.Tasks.Task WriteValueAsync(char? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000AA3A File Offset: 0x00008C3A
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(char? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.DoWriteValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000AA5B File Offset: 0x00008C5B
		public override global::System.Threading.Tasks.Task WriteValueAsync(global::System.DateTime value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000AA78 File Offset: 0x00008C78
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.DateTime value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__59 <DoWriteValueAsync>d__;
			<DoWriteValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteValueAsync>d__.<>4__this = this;
			<DoWriteValueAsync>d__.value = value;
			<DoWriteValueAsync>d__.cancellationToken = cancellationToken;
			<DoWriteValueAsync>d__.<>1__state = -1;
			<DoWriteValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__59>(ref <DoWriteValueAsync>d__);
			return <DoWriteValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000AACB File Offset: 0x00008CCB
		public override global::System.Threading.Tasks.Task WriteValueAsync(global::System.DateTime? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000AAE6 File Offset: 0x00008CE6
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.DateTime? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.DoWriteValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000AB07 File Offset: 0x00008D07
		public override global::System.Threading.Tasks.Task WriteValueAsync(global::System.DateTimeOffset value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000AB24 File Offset: 0x00008D24
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.DateTimeOffset value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__63 <DoWriteValueAsync>d__;
			<DoWriteValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteValueAsync>d__.<>4__this = this;
			<DoWriteValueAsync>d__.value = value;
			<DoWriteValueAsync>d__.cancellationToken = cancellationToken;
			<DoWriteValueAsync>d__.<>1__state = -1;
			<DoWriteValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__63>(ref <DoWriteValueAsync>d__);
			return <DoWriteValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000AB77 File Offset: 0x00008D77
		public override global::System.Threading.Tasks.Task WriteValueAsync(global::System.DateTimeOffset? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000AB92 File Offset: 0x00008D92
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.DateTimeOffset? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.DoWriteValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000ABB3 File Offset: 0x00008DB3
		public override global::System.Threading.Tasks.Task WriteValueAsync(decimal value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000ABCE File Offset: 0x00008DCE
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(decimal value, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.WriteValueInternalAsync(global::Newtonsoft.Json.JsonToken.Float, global::Newtonsoft.Json.JsonConvert.ToString(value), cancellationToken);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000ABDE File Offset: 0x00008DDE
		public override global::System.Threading.Tasks.Task WriteValueAsync(decimal? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000ABF9 File Offset: 0x00008DF9
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(decimal? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.DoWriteValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000AC1A File Offset: 0x00008E1A
		public override global::System.Threading.Tasks.Task WriteValueAsync(double value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteValueAsync(value, false, cancellationToken);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000AC36 File Offset: 0x00008E36
		internal global::System.Threading.Tasks.Task WriteValueAsync(double value, bool nullable, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.WriteValueInternalAsync(global::Newtonsoft.Json.JsonToken.Float, global::Newtonsoft.Json.JsonConvert.ToString(value, base.FloatFormatHandling, this.QuoteChar, nullable), cancellationToken);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000AC53 File Offset: 0x00008E53
		public override global::System.Threading.Tasks.Task WriteValueAsync(double? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			if (value == null)
			{
				return this.WriteNullAsync(cancellationToken);
			}
			return this.WriteValueAsync(value.GetValueOrDefault(), true, cancellationToken);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000AC86 File Offset: 0x00008E86
		public override global::System.Threading.Tasks.Task WriteValueAsync(float value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteValueAsync(value, false, cancellationToken);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000ACA2 File Offset: 0x00008EA2
		internal global::System.Threading.Tasks.Task WriteValueAsync(float value, bool nullable, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.WriteValueInternalAsync(global::Newtonsoft.Json.JsonToken.Float, global::Newtonsoft.Json.JsonConvert.ToString(value, base.FloatFormatHandling, this.QuoteChar, nullable), cancellationToken);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000ACBF File Offset: 0x00008EBF
		public override global::System.Threading.Tasks.Task WriteValueAsync(float? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			if (value == null)
			{
				return this.WriteNullAsync(cancellationToken);
			}
			return this.WriteValueAsync(value.GetValueOrDefault(), true, cancellationToken);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000ACF2 File Offset: 0x00008EF2
		public override global::System.Threading.Tasks.Task WriteValueAsync(global::System.Guid value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000AD10 File Offset: 0x00008F10
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.Guid value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__77 <DoWriteValueAsync>d__;
			<DoWriteValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteValueAsync>d__.<>4__this = this;
			<DoWriteValueAsync>d__.value = value;
			<DoWriteValueAsync>d__.cancellationToken = cancellationToken;
			<DoWriteValueAsync>d__.<>1__state = -1;
			<DoWriteValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__77>(ref <DoWriteValueAsync>d__);
			return <DoWriteValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000AD63 File Offset: 0x00008F63
		public override global::System.Threading.Tasks.Task WriteValueAsync(global::System.Guid? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000AD7E File Offset: 0x00008F7E
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.Guid? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.DoWriteValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000AD9F File Offset: 0x00008F9F
		public override global::System.Threading.Tasks.Task WriteValueAsync(int value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteIntegerValueAsync((long)value, cancellationToken);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000ADBB File Offset: 0x00008FBB
		public override global::System.Threading.Tasks.Task WriteValueAsync(int? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000ADD6 File Offset: 0x00008FD6
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(int? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.WriteIntegerValueAsync((long)value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000ADF8 File Offset: 0x00008FF8
		public override global::System.Threading.Tasks.Task WriteValueAsync(long value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteIntegerValueAsync(value, cancellationToken);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000AE13 File Offset: 0x00009013
		public override global::System.Threading.Tasks.Task WriteValueAsync(long? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000AE2E File Offset: 0x0000902E
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(long? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.WriteIntegerValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000AE4F File Offset: 0x0000904F
		internal global::System.Threading.Tasks.Task WriteValueAsync(global::System.Numerics.BigInteger value, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.WriteValueInternalAsync(global::Newtonsoft.Json.JsonToken.Integer, value.ToString(global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000AE68 File Offset: 0x00009068
		public override global::System.Threading.Tasks.Task WriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] object value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			if (value == null)
			{
				return this.WriteNullAsync(cancellationToken);
			}
			if (value is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger value2 = (global::System.Numerics.BigInteger)value;
				return this.WriteValueAsync(value2, cancellationToken);
			}
			return global::Newtonsoft.Json.JsonWriter.WriteValueAsync(this, global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(value.GetType()), value, cancellationToken);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000AEBC File Offset: 0x000090BC
		[global::System.CLSCompliant(false)]
		public override global::System.Threading.Tasks.Task WriteValueAsync(sbyte value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteIntegerValueAsync((long)value, cancellationToken);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000AED8 File Offset: 0x000090D8
		[global::System.CLSCompliant(false)]
		public override global::System.Threading.Tasks.Task WriteValueAsync(sbyte? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000AEF3 File Offset: 0x000090F3
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(sbyte? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.WriteIntegerValueAsync((long)value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000AF15 File Offset: 0x00009115
		public override global::System.Threading.Tasks.Task WriteValueAsync(short value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteIntegerValueAsync((long)value, cancellationToken);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000AF31 File Offset: 0x00009131
		public override global::System.Threading.Tasks.Task WriteValueAsync(short? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000AF4C File Offset: 0x0000914C
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(short? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.WriteIntegerValueAsync((long)value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000AF6E File Offset: 0x0000916E
		public override global::System.Threading.Tasks.Task WriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] string value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000AF8C File Offset: 0x0000918C
		internal global::System.Threading.Tasks.Task DoWriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] string value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = base.InternalWriteValueAsync(global::Newtonsoft.Json.JsonToken.String, cancellationToken);
			if (!task.IsCompletedSucessfully())
			{
				return this.DoWriteValueAsync(task, value, cancellationToken);
			}
			if (value != null)
			{
				return this.WriteEscapedStringAsync(value, true, cancellationToken);
			}
			return this._writer.WriteAsync(global::Newtonsoft.Json.JsonConvert.Null, cancellationToken);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000AFD4 File Offset: 0x000091D4
		private global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.Threading.Tasks.Task task, [global::System.Runtime.CompilerServices.Nullable(2)] string value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__96 <DoWriteValueAsync>d__;
			<DoWriteValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteValueAsync>d__.<>4__this = this;
			<DoWriteValueAsync>d__.task = task;
			<DoWriteValueAsync>d__.value = value;
			<DoWriteValueAsync>d__.cancellationToken = cancellationToken;
			<DoWriteValueAsync>d__.<>1__state = -1;
			<DoWriteValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__96>(ref <DoWriteValueAsync>d__);
			return <DoWriteValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000B02F File Offset: 0x0000922F
		public override global::System.Threading.Tasks.Task WriteValueAsync(global::System.TimeSpan value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000B04C File Offset: 0x0000924C
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.TimeSpan value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__98 <DoWriteValueAsync>d__;
			<DoWriteValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteValueAsync>d__.<>4__this = this;
			<DoWriteValueAsync>d__.value = value;
			<DoWriteValueAsync>d__.cancellationToken = cancellationToken;
			<DoWriteValueAsync>d__.<>1__state = -1;
			<DoWriteValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteValueAsync>d__98>(ref <DoWriteValueAsync>d__);
			return <DoWriteValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000B09F File Offset: 0x0000929F
		public override global::System.Threading.Tasks.Task WriteValueAsync(global::System.TimeSpan? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000B0BA File Offset: 0x000092BA
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(global::System.TimeSpan? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.DoWriteValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000B0DB File Offset: 0x000092DB
		[global::System.CLSCompliant(false)]
		public override global::System.Threading.Tasks.Task WriteValueAsync(uint value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteIntegerValueAsync((long)((ulong)value), cancellationToken);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000B0F7 File Offset: 0x000092F7
		[global::System.CLSCompliant(false)]
		public override global::System.Threading.Tasks.Task WriteValueAsync(uint? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000B112 File Offset: 0x00009312
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(uint? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.WriteIntegerValueAsync((long)((ulong)value.GetValueOrDefault()), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000B134 File Offset: 0x00009334
		[global::System.CLSCompliant(false)]
		public override global::System.Threading.Tasks.Task WriteValueAsync(ulong value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteIntegerValueAsync(value, cancellationToken);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000B14F File Offset: 0x0000934F
		[global::System.CLSCompliant(false)]
		public override global::System.Threading.Tasks.Task WriteValueAsync(ulong? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000B16A File Offset: 0x0000936A
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(ulong? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.WriteIntegerValueAsync(value.GetValueOrDefault(), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000B18B File Offset: 0x0000938B
		public override global::System.Threading.Tasks.Task WriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Uri value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			if (!(value == null))
			{
				return this.WriteValueNotNullAsync(value, cancellationToken);
			}
			return this.WriteNullAsync(cancellationToken);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000B1B8 File Offset: 0x000093B8
		internal global::System.Threading.Tasks.Task WriteValueNotNullAsync(global::System.Uri value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Threading.Tasks.Task task = base.InternalWriteValueAsync(global::Newtonsoft.Json.JsonToken.String, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this.WriteEscapedStringAsync(value.OriginalString, true, cancellationToken);
			}
			return this.WriteValueNotNullAsync(task, value, cancellationToken);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000B1F0 File Offset: 0x000093F0
		internal global::System.Threading.Tasks.Task WriteValueNotNullAsync(global::System.Threading.Tasks.Task task, global::System.Uri value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<WriteValueNotNullAsync>d__109 <WriteValueNotNullAsync>d__;
			<WriteValueNotNullAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteValueNotNullAsync>d__.<>4__this = this;
			<WriteValueNotNullAsync>d__.task = task;
			<WriteValueNotNullAsync>d__.value = value;
			<WriteValueNotNullAsync>d__.cancellationToken = cancellationToken;
			<WriteValueNotNullAsync>d__.<>1__state = -1;
			<WriteValueNotNullAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<WriteValueNotNullAsync>d__109>(ref <WriteValueNotNullAsync>d__);
			return <WriteValueNotNullAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000B24B File Offset: 0x0000944B
		[global::System.CLSCompliant(false)]
		public override global::System.Threading.Tasks.Task WriteValueAsync(ushort value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.WriteIntegerValueAsync((long)((ulong)value), cancellationToken);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000B267 File Offset: 0x00009467
		[global::System.CLSCompliant(false)]
		public override global::System.Threading.Tasks.Task WriteValueAsync(ushort? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteValueAsync(value, cancellationToken);
			}
			return this.DoWriteValueAsync(value, cancellationToken);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000B282 File Offset: 0x00009482
		internal global::System.Threading.Tasks.Task DoWriteValueAsync(ushort? value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (value != null)
			{
				return this.WriteIntegerValueAsync((long)((ulong)value.GetValueOrDefault()), cancellationToken);
			}
			return this.DoWriteNullAsync(cancellationToken);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000B2A4 File Offset: 0x000094A4
		public override global::System.Threading.Tasks.Task WriteCommentAsync([global::System.Runtime.CompilerServices.Nullable(2)] string text, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteCommentAsync(text, cancellationToken);
			}
			return this.DoWriteCommentAsync(text, cancellationToken);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000B2C0 File Offset: 0x000094C0
		internal global::System.Threading.Tasks.Task DoWriteCommentAsync([global::System.Runtime.CompilerServices.Nullable(2)] string text, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteCommentAsync>d__114 <DoWriteCommentAsync>d__;
			<DoWriteCommentAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteCommentAsync>d__.<>4__this = this;
			<DoWriteCommentAsync>d__.text = text;
			<DoWriteCommentAsync>d__.cancellationToken = cancellationToken;
			<DoWriteCommentAsync>d__.<>1__state = -1;
			<DoWriteCommentAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteCommentAsync>d__114>(ref <DoWriteCommentAsync>d__);
			return <DoWriteCommentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000B313 File Offset: 0x00009513
		public override global::System.Threading.Tasks.Task WriteEndArrayAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteEndArrayAsync(cancellationToken);
			}
			return base.InternalWriteEndAsync(global::Newtonsoft.Json.JsonContainerType.Array, cancellationToken);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000B32D File Offset: 0x0000952D
		public override global::System.Threading.Tasks.Task WriteEndConstructorAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteEndConstructorAsync(cancellationToken);
			}
			return base.InternalWriteEndAsync(global::Newtonsoft.Json.JsonContainerType.Constructor, cancellationToken);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000B347 File Offset: 0x00009547
		public override global::System.Threading.Tasks.Task WriteEndObjectAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteEndObjectAsync(cancellationToken);
			}
			return base.InternalWriteEndAsync(global::Newtonsoft.Json.JsonContainerType.Object, cancellationToken);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000B361 File Offset: 0x00009561
		public override global::System.Threading.Tasks.Task WriteRawValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] string json, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.WriteRawValueAsync(json, cancellationToken);
			}
			return this.DoWriteRawValueAsync(json, cancellationToken);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000B37C File Offset: 0x0000957C
		internal global::System.Threading.Tasks.Task DoWriteRawValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] string json, global::System.Threading.CancellationToken cancellationToken)
		{
			base.UpdateScopeWithFinishedValue();
			global::System.Threading.Tasks.Task task = base.AutoCompleteAsync(global::Newtonsoft.Json.JsonToken.Undefined, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				return this.WriteRawAsync(json, cancellationToken);
			}
			return this.DoWriteRawValueAsync(task, json, cancellationToken);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000B3B4 File Offset: 0x000095B4
		private global::System.Threading.Tasks.Task DoWriteRawValueAsync(global::System.Threading.Tasks.Task task, [global::System.Runtime.CompilerServices.Nullable(2)] string json, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextWriter.<DoWriteRawValueAsync>d__120 <DoWriteRawValueAsync>d__;
			<DoWriteRawValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<DoWriteRawValueAsync>d__.<>4__this = this;
			<DoWriteRawValueAsync>d__.task = task;
			<DoWriteRawValueAsync>d__.json = json;
			<DoWriteRawValueAsync>d__.cancellationToken = cancellationToken;
			<DoWriteRawValueAsync>d__.<>1__state = -1;
			<DoWriteRawValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextWriter.<DoWriteRawValueAsync>d__120>(ref <DoWriteRawValueAsync>d__);
			return <DoWriteRawValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000B410 File Offset: 0x00009610
		internal char[] EnsureWriteBuffer(int length, int copyTo)
		{
			if (length < 35)
			{
				length = 35;
			}
			char[] writeBuffer = this._writeBuffer;
			if (writeBuffer == null)
			{
				return this._writeBuffer = global::Newtonsoft.Json.Utilities.BufferUtils.RentBuffer(this._arrayPool, length);
			}
			if (writeBuffer.Length >= length)
			{
				return writeBuffer;
			}
			char[] array = global::Newtonsoft.Json.Utilities.BufferUtils.RentBuffer(this._arrayPool, length);
			if (copyTo != 0)
			{
				global::System.Array.Copy(writeBuffer, array, copyTo);
			}
			global::Newtonsoft.Json.Utilities.BufferUtils.ReturnBuffer(this._arrayPool, writeBuffer);
			this._writeBuffer = array;
			return array;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x0000B47A File Offset: 0x0000967A
		private global::Newtonsoft.Json.Utilities.Base64Encoder Base64Encoder
		{
			get
			{
				if (this._base64Encoder == null)
				{
					this._base64Encoder = new global::Newtonsoft.Json.Utilities.Base64Encoder(this._writer);
				}
				return this._base64Encoder;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000B49B File Offset: 0x0000969B
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0000B4A3 File Offset: 0x000096A3
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.IArrayPool<char> ArrayPool
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this._arrayPool;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this._arrayPool = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002DB RID: 731 RVA: 0x0000B4BA File Offset: 0x000096BA
		// (set) Token: 0x060002DC RID: 732 RVA: 0x0000B4C2 File Offset: 0x000096C2
		public int Indentation
		{
			get
			{
				return this._indentation;
			}
			set
			{
				if (value < 0)
				{
					throw new global::System.ArgumentException("Indentation value must be greater than 0.");
				}
				this._indentation = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002DD RID: 733 RVA: 0x0000B4DA File Offset: 0x000096DA
		// (set) Token: 0x060002DE RID: 734 RVA: 0x0000B4E2 File Offset: 0x000096E2
		public char QuoteChar
		{
			get
			{
				return this._quoteChar;
			}
			set
			{
				if (value != '"' && value != '\'')
				{
					throw new global::System.ArgumentException("Invalid JavaScript string quote character. Valid quote characters are ' and \".");
				}
				this._quoteChar = value;
				this.UpdateCharEscapeFlags();
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000B506 File Offset: 0x00009706
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0000B50E File Offset: 0x0000970E
		public char IndentChar
		{
			get
			{
				return this._indentChar;
			}
			set
			{
				if (value != this._indentChar)
				{
					this._indentChar = value;
					this._indentChars = null;
				}
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000B527 File Offset: 0x00009727
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000B52F File Offset: 0x0000972F
		public bool QuoteName
		{
			get
			{
				return this._quoteName;
			}
			set
			{
				this._quoteName = value;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000B538 File Offset: 0x00009738
		public JsonTextWriter(global::System.IO.TextWriter textWriter)
		{
			if (textWriter == null)
			{
				throw new global::System.ArgumentNullException("textWriter");
			}
			this._writer = textWriter;
			this._quoteChar = '"';
			this._quoteName = true;
			this._indentChar = ' ';
			this._indentation = 2;
			this.UpdateCharEscapeFlags();
			this._safeAsync = (base.GetType() == typeof(global::Newtonsoft.Json.JsonTextWriter));
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000B59F File Offset: 0x0000979F
		public override void Flush()
		{
			this._writer.Flush();
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000B5AC File Offset: 0x000097AC
		public override void Close()
		{
			base.Close();
			this.CloseBufferAndWriter();
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000B5BA File Offset: 0x000097BA
		private void CloseBufferAndWriter()
		{
			if (this._writeBuffer != null)
			{
				global::Newtonsoft.Json.Utilities.BufferUtils.ReturnBuffer(this._arrayPool, this._writeBuffer);
				this._writeBuffer = null;
			}
			if (base.CloseOutput)
			{
				global::System.IO.TextWriter writer = this._writer;
				if (writer == null)
				{
					return;
				}
				writer.Close();
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000B5F4 File Offset: 0x000097F4
		public override void WriteStartObject()
		{
			base.InternalWriteStart(global::Newtonsoft.Json.JsonToken.StartObject, global::Newtonsoft.Json.JsonContainerType.Object);
			this._writer.Write('{');
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000B60B File Offset: 0x0000980B
		public override void WriteStartArray()
		{
			base.InternalWriteStart(global::Newtonsoft.Json.JsonToken.StartArray, global::Newtonsoft.Json.JsonContainerType.Array);
			this._writer.Write('[');
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000B622 File Offset: 0x00009822
		public override void WriteStartConstructor(string name)
		{
			base.InternalWriteStart(global::Newtonsoft.Json.JsonToken.StartConstructor, global::Newtonsoft.Json.JsonContainerType.Constructor);
			this._writer.Write("new ");
			this._writer.Write(name);
			this._writer.Write('(');
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000B658 File Offset: 0x00009858
		protected override void WriteEnd(global::Newtonsoft.Json.JsonToken token)
		{
			switch (token)
			{
			case global::Newtonsoft.Json.JsonToken.EndObject:
				this._writer.Write('}');
				return;
			case global::Newtonsoft.Json.JsonToken.EndArray:
				this._writer.Write(']');
				return;
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				this._writer.Write(')');
				return;
			default:
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Invalid JsonToken: " + token.ToString(), null);
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000B6C4 File Offset: 0x000098C4
		public override void WritePropertyName(string name)
		{
			base.InternalWritePropertyName(name);
			this.WriteEscapedString(name, this._quoteName);
			this._writer.Write(':');
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000B6E8 File Offset: 0x000098E8
		public override void WritePropertyName(string name, bool escape)
		{
			base.InternalWritePropertyName(name);
			if (escape)
			{
				this.WriteEscapedString(name, this._quoteName);
			}
			else
			{
				if (this._quoteName)
				{
					this._writer.Write(this._quoteChar);
				}
				this._writer.Write(name);
				if (this._quoteName)
				{
					this._writer.Write(this._quoteChar);
				}
			}
			this._writer.Write(':');
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000B759 File Offset: 0x00009959
		internal override void OnStringEscapeHandlingChanged()
		{
			this.UpdateCharEscapeFlags();
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000B761 File Offset: 0x00009961
		private void UpdateCharEscapeFlags()
		{
			this._charEscapeFlags = global::Newtonsoft.Json.Utilities.JavaScriptUtils.GetCharEscapeFlags(base.StringEscapeHandling, this._quoteChar);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000B77C File Offset: 0x0000997C
		protected override void WriteIndent()
		{
			int num = base.Top * this._indentation;
			int num2 = this.SetIndentChars();
			this._writer.Write(this._indentChars, 0, num2 + global::System.Math.Min(num, 12));
			while ((num -= 12) > 0)
			{
				this._writer.Write(this._indentChars, num2, global::System.Math.Min(num, 12));
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000B7E0 File Offset: 0x000099E0
		private int SetIndentChars()
		{
			string newLine = this._writer.NewLine;
			int length = newLine.Length;
			bool flag = this._indentChars != null && this._indentChars.Length == 12 + length;
			if (flag)
			{
				for (int num = 0; num != length; num++)
				{
					if (newLine[num] != this._indentChars[num])
					{
						flag = false;
						break;
					}
				}
			}
			if (!flag)
			{
				this._indentChars = (newLine + new string(this._indentChar, 12)).ToCharArray();
			}
			return length;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000B860 File Offset: 0x00009A60
		protected override void WriteValueDelimiter()
		{
			this._writer.Write(',');
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000B86F File Offset: 0x00009A6F
		protected override void WriteIndentSpace()
		{
			this._writer.Write(' ');
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000B87E File Offset: 0x00009A7E
		private void WriteValueInternal(string value, global::Newtonsoft.Json.JsonToken token)
		{
			this._writer.Write(value);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000B88C File Offset: 0x00009A8C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override void WriteValue(object value)
		{
			if (value is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger bigInteger = (global::System.Numerics.BigInteger)value;
				base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
				this.WriteValueInternal(bigInteger.ToString(global::System.Globalization.CultureInfo.InvariantCulture), global::Newtonsoft.Json.JsonToken.String);
				return;
			}
			base.WriteValue(value);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000B8CB File Offset: 0x00009ACB
		public override void WriteNull()
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Null);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.Null, global::Newtonsoft.Json.JsonToken.Null);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000B8E2 File Offset: 0x00009AE2
		public override void WriteUndefined()
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Undefined);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.Undefined, global::Newtonsoft.Json.JsonToken.Undefined);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000B8F9 File Offset: 0x00009AF9
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override void WriteRaw(string json)
		{
			base.InternalWriteRaw();
			this._writer.Write(json);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000B90D File Offset: 0x00009B0D
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override void WriteValue(string value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
			if (value == null)
			{
				this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.Null, global::Newtonsoft.Json.JsonToken.Null);
				return;
			}
			this.WriteEscapedString(value, true);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000B930 File Offset: 0x00009B30
		private void WriteEscapedString(string value, bool quote)
		{
			this.EnsureWriteBuffer();
			global::Newtonsoft.Json.Utilities.JavaScriptUtils.WriteEscapedJavaScriptString(this._writer, value, this._quoteChar, quote, this._charEscapeFlags, base.StringEscapeHandling, this._arrayPool, ref this._writeBuffer);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000B963 File Offset: 0x00009B63
		public override void WriteValue(int value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
			this.WriteIntegerValue(value);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000B973 File Offset: 0x00009B73
		[global::System.CLSCompliant(false)]
		public override void WriteValue(uint value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
			this.WriteIntegerValue((long)((ulong)value));
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000B984 File Offset: 0x00009B84
		public override void WriteValue(long value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
			this.WriteIntegerValue(value);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000B994 File Offset: 0x00009B94
		[global::System.CLSCompliant(false)]
		public override void WriteValue(ulong value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
			this.WriteIntegerValue(value, false);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000B9A5 File Offset: 0x00009BA5
		public override void WriteValue(float value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Float);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.ToString(value, base.FloatFormatHandling, this.QuoteChar, false), global::Newtonsoft.Json.JsonToken.Float);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		public override void WriteValue(float? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Float);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.ToString(value.GetValueOrDefault(), base.FloatFormatHandling, this.QuoteChar, true), global::Newtonsoft.Json.JsonToken.Float);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000BA01 File Offset: 0x00009C01
		public override void WriteValue(double value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Float);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.ToString(value, base.FloatFormatHandling, this.QuoteChar, false), global::Newtonsoft.Json.JsonToken.Float);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000BA24 File Offset: 0x00009C24
		public override void WriteValue(double? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Float);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.ToString(value.GetValueOrDefault(), base.FloatFormatHandling, this.QuoteChar, true), global::Newtonsoft.Json.JsonToken.Float);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000BA5D File Offset: 0x00009C5D
		public override void WriteValue(bool value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Boolean);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.ToString(value), global::Newtonsoft.Json.JsonToken.Boolean);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000BA75 File Offset: 0x00009C75
		public override void WriteValue(short value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
			this.WriteIntegerValue((int)value);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000BA85 File Offset: 0x00009C85
		[global::System.CLSCompliant(false)]
		public override void WriteValue(ushort value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
			this.WriteIntegerValue((int)value);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000BA95 File Offset: 0x00009C95
		public override void WriteValue(char value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.ToString(value), global::Newtonsoft.Json.JsonToken.String);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000BAAD File Offset: 0x00009CAD
		public override void WriteValue(byte value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
			this.WriteIntegerValue((int)value);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000BABD File Offset: 0x00009CBD
		[global::System.CLSCompliant(false)]
		public override void WriteValue(sbyte value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
			this.WriteIntegerValue((int)value);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000BACD File Offset: 0x00009CCD
		public override void WriteValue(decimal value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Float);
			this.WriteValueInternal(global::Newtonsoft.Json.JsonConvert.ToString(value), global::Newtonsoft.Json.JsonToken.Float);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		public override void WriteValue(global::System.DateTime value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Date);
			value = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(value, base.DateTimeZoneHandling);
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(base.DateFormatString))
			{
				int count = this.WriteValueToBuffer(value);
				this._writer.Write(this._writeBuffer, 0, count);
				return;
			}
			this._writer.Write(this._quoteChar);
			this._writer.Write(value.ToString(base.DateFormatString, base.Culture));
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000BB70 File Offset: 0x00009D70
		private int WriteValueToBuffer(global::System.DateTime value)
		{
			this.EnsureWriteBuffer();
			int num = 0;
			this._writeBuffer[num++] = this._quoteChar;
			num = global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeString(this._writeBuffer, num, value, null, value.Kind, base.DateFormatHandling);
			this._writeBuffer[num++] = this._quoteChar;
			return num;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override void WriteValue(byte[] value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Bytes);
			this._writer.Write(this._quoteChar);
			this.Base64Encoder.Encode(value, 0, value.Length);
			this.Base64Encoder.Flush();
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000BC2C File Offset: 0x00009E2C
		public override void WriteValue(global::System.DateTimeOffset value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Date);
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(base.DateFormatString))
			{
				int count = this.WriteValueToBuffer(value);
				this._writer.Write(this._writeBuffer, 0, count);
				return;
			}
			this._writer.Write(this._quoteChar);
			this._writer.Write(value.ToString(base.DateFormatString, base.Culture));
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000BCAC File Offset: 0x00009EAC
		private int WriteValueToBuffer(global::System.DateTimeOffset value)
		{
			this.EnsureWriteBuffer();
			int num = 0;
			this._writeBuffer[num++] = this._quoteChar;
			num = global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeString(this._writeBuffer, num, (base.DateFormatHandling == global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat) ? value.DateTime : value.UtcDateTime, new global::System.TimeSpan?(value.Offset), global::System.DateTimeKind.Local, base.DateFormatHandling);
			this._writeBuffer[num++] = this._quoteChar;
			return num;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000BD20 File Offset: 0x00009F20
		public override void WriteValue(global::System.Guid value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
			string value2 = value.ToString("D", global::System.Globalization.CultureInfo.InvariantCulture);
			this._writer.Write(this._quoteChar);
			this._writer.Write(value2);
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000BD78 File Offset: 0x00009F78
		public override void WriteValue(global::System.TimeSpan value)
		{
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
			string value2 = value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
			this._writer.Write(this._quoteChar);
			this._writer.Write(value2);
			this._writer.Write(this._quoteChar);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000BDC9 File Offset: 0x00009FC9
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override void WriteValue(global::System.Uri value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			base.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
			this.WriteEscapedString(value.OriginalString, true);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override void WriteComment(string text)
		{
			base.InternalWriteComment();
			this._writer.Write("/*");
			this._writer.Write(text);
			this._writer.Write("*/");
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000BE24 File Offset: 0x0000A024
		public override void WriteWhitespace(string ws)
		{
			base.InternalWriteWhitespace(ws);
			this._writer.Write(ws);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000BE39 File Offset: 0x0000A039
		private void EnsureWriteBuffer()
		{
			if (this._writeBuffer == null)
			{
				this._writeBuffer = global::Newtonsoft.Json.Utilities.BufferUtils.RentBuffer(this._arrayPool, 35);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000BE58 File Offset: 0x0000A058
		private void WriteIntegerValue(long value)
		{
			if (value >= 0L && value <= 9L)
			{
				this._writer.Write((char)(48L + value));
				return;
			}
			bool flag = value < 0L;
			this.WriteIntegerValue((ulong)(flag ? (-(ulong)value) : value), flag);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000BE98 File Offset: 0x0000A098
		private void WriteIntegerValue(ulong value, bool negative)
		{
			if (!negative & value <= 9UL)
			{
				this._writer.Write((char)(48UL + value));
				return;
			}
			int count = this.WriteNumberToBuffer(value, negative);
			this._writer.Write(this._writeBuffer, 0, count);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		private int WriteNumberToBuffer(ulong value, bool negative)
		{
			if (value <= (ulong)-1)
			{
				return this.WriteNumberToBuffer((uint)value, negative);
			}
			this.EnsureWriteBuffer();
			int num = global::Newtonsoft.Json.Utilities.MathUtils.IntLength(value);
			if (negative)
			{
				num++;
				this._writeBuffer[0] = '-';
			}
			int num2 = num;
			do
			{
				ulong num3 = value / 10UL;
				ulong num4 = value - num3 * 10UL;
				this._writeBuffer[--num2] = (char)(48UL + num4);
				value = num3;
			}
			while (value != 0UL);
			return num;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000BF48 File Offset: 0x0000A148
		private void WriteIntegerValue(int value)
		{
			if (value >= 0 && value <= 9)
			{
				this._writer.Write((char)(48 + value));
				return;
			}
			bool flag = value < 0;
			this.WriteIntegerValue((uint)(flag ? (-(uint)value) : value), flag);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000BF84 File Offset: 0x0000A184
		private void WriteIntegerValue(uint value, bool negative)
		{
			if (!negative & value <= 9U)
			{
				this._writer.Write((char)(48U + value));
				return;
			}
			int count = this.WriteNumberToBuffer(value, negative);
			this._writer.Write(this._writeBuffer, 0, count);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		private int WriteNumberToBuffer(uint value, bool negative)
		{
			this.EnsureWriteBuffer();
			int num = global::Newtonsoft.Json.Utilities.MathUtils.IntLength((ulong)value);
			if (negative)
			{
				num++;
				this._writeBuffer[0] = '-';
			}
			int num2 = num;
			do
			{
				uint num3 = value / 10U;
				uint num4 = value - num3 * 10U;
				this._writeBuffer[--num2] = (char)(48U + num4);
				value = num3;
			}
			while (value != 0U);
			return num;
		}

		// Token: 0x040000E1 RID: 225
		private readonly bool _safeAsync;

		// Token: 0x040000E2 RID: 226
		private const int IndentCharBufferSize = 12;

		// Token: 0x040000E3 RID: 227
		private readonly global::System.IO.TextWriter _writer;

		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Utilities.Base64Encoder _base64Encoder;

		// Token: 0x040000E5 RID: 229
		private char _indentChar;

		// Token: 0x040000E6 RID: 230
		private int _indentation;

		// Token: 0x040000E7 RID: 231
		private char _quoteChar;

		// Token: 0x040000E8 RID: 232
		private bool _quoteName;

		// Token: 0x040000E9 RID: 233
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private bool[] _charEscapeFlags;

		// Token: 0x040000EA RID: 234
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private char[] _writeBuffer;

		// Token: 0x040000EB RID: 235
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.IArrayPool<char> _arrayPool;

		// Token: 0x040000EC RID: 236
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private char[] _indentChars;
	}
}
