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
	// Token: 0x0200002D RID: 45
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JsonTextReader : global::Newtonsoft.Json.JsonReader, global::Newtonsoft.Json.IJsonLineInfo
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x00006168 File Offset: 0x00004368
		public override global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsync(cancellationToken);
			}
			return this.DoReadAsync(cancellationToken);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00006184 File Offset: 0x00004384
		internal global::System.Threading.Tasks.Task<bool> DoReadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			this.EnsureBuffer();
			global::System.Threading.Tasks.Task<bool> task;
			for (;;)
			{
				switch (this._currentState)
				{
				case global::Newtonsoft.Json.JsonReader.State.Start:
				case global::Newtonsoft.Json.JsonReader.State.Property:
				case global::Newtonsoft.Json.JsonReader.State.ArrayStart:
				case global::Newtonsoft.Json.JsonReader.State.Array:
				case global::Newtonsoft.Json.JsonReader.State.ConstructorStart:
				case global::Newtonsoft.Json.JsonReader.State.Constructor:
					goto IL_49;
				case global::Newtonsoft.Json.JsonReader.State.ObjectStart:
				case global::Newtonsoft.Json.JsonReader.State.Object:
					goto IL_51;
				case global::Newtonsoft.Json.JsonReader.State.PostValue:
					task = this.ParsePostValueAsync(false, cancellationToken);
					if (!task.IsCompletedSucessfully())
					{
						goto IL_78;
					}
					if (task.Result)
					{
						goto Block_3;
					}
					continue;
				case global::Newtonsoft.Json.JsonReader.State.Finished:
					goto IL_81;
				}
				break;
			}
			goto IL_89;
			IL_49:
			return this.ParseValueAsync(cancellationToken);
			IL_51:
			return this.ParseObjectAsync(cancellationToken);
			Block_3:
			return global::Newtonsoft.Json.Utilities.AsyncUtils.True;
			IL_78:
			return this.DoReadAsync(task, cancellationToken);
			IL_81:
			return this.ReadFromFinishedAsync(cancellationToken);
			IL_89:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.CurrentState));
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000623C File Offset: 0x0000443C
		private global::System.Threading.Tasks.Task<bool> DoReadAsync(global::System.Threading.Tasks.Task<bool> task, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsync>d__3 <DoReadAsync>d__;
			<DoReadAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<DoReadAsync>d__.<>4__this = this;
			<DoReadAsync>d__.task = task;
			<DoReadAsync>d__.cancellationToken = cancellationToken;
			<DoReadAsync>d__.<>1__state = -1;
			<DoReadAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsync>d__3>(ref <DoReadAsync>d__);
			return <DoReadAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00006290 File Offset: 0x00004490
		private global::System.Threading.Tasks.Task<bool> ParsePostValueAsync(bool ignoreComments, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParsePostValueAsync>d__4 <ParsePostValueAsync>d__;
			<ParsePostValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<ParsePostValueAsync>d__.<>4__this = this;
			<ParsePostValueAsync>d__.ignoreComments = ignoreComments;
			<ParsePostValueAsync>d__.cancellationToken = cancellationToken;
			<ParsePostValueAsync>d__.<>1__state = -1;
			<ParsePostValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParsePostValueAsync>d__4>(ref <ParsePostValueAsync>d__);
			return <ParsePostValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000062E4 File Offset: 0x000044E4
		private global::System.Threading.Tasks.Task<bool> ReadFromFinishedAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadFromFinishedAsync>d__5 <ReadFromFinishedAsync>d__;
			<ReadFromFinishedAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<ReadFromFinishedAsync>d__.<>4__this = this;
			<ReadFromFinishedAsync>d__.cancellationToken = cancellationToken;
			<ReadFromFinishedAsync>d__.<>1__state = -1;
			<ReadFromFinishedAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadFromFinishedAsync>d__5>(ref <ReadFromFinishedAsync>d__);
			return <ReadFromFinishedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000632F File Offset: 0x0000452F
		private global::System.Threading.Tasks.Task<int> ReadDataAsync(bool append, global::System.Threading.CancellationToken cancellationToken)
		{
			return this.ReadDataAsync(append, 0, cancellationToken);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000633C File Offset: 0x0000453C
		private global::System.Threading.Tasks.Task<int> ReadDataAsync(bool append, int charsRequired, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadDataAsync>d__7 <ReadDataAsync>d__;
			<ReadDataAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int>.Create();
			<ReadDataAsync>d__.<>4__this = this;
			<ReadDataAsync>d__.append = append;
			<ReadDataAsync>d__.charsRequired = charsRequired;
			<ReadDataAsync>d__.cancellationToken = cancellationToken;
			<ReadDataAsync>d__.<>1__state = -1;
			<ReadDataAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadDataAsync>d__7>(ref <ReadDataAsync>d__);
			return <ReadDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00006398 File Offset: 0x00004598
		private global::System.Threading.Tasks.Task<bool> ParseValueAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseValueAsync>d__8 <ParseValueAsync>d__;
			<ParseValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<ParseValueAsync>d__.<>4__this = this;
			<ParseValueAsync>d__.cancellationToken = cancellationToken;
			<ParseValueAsync>d__.<>1__state = -1;
			<ParseValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseValueAsync>d__8>(ref <ParseValueAsync>d__);
			return <ParseValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000063E4 File Offset: 0x000045E4
		private global::System.Threading.Tasks.Task ReadStringIntoBufferAsync(char quote, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadStringIntoBufferAsync>d__9 <ReadStringIntoBufferAsync>d__;
			<ReadStringIntoBufferAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ReadStringIntoBufferAsync>d__.<>4__this = this;
			<ReadStringIntoBufferAsync>d__.quote = quote;
			<ReadStringIntoBufferAsync>d__.cancellationToken = cancellationToken;
			<ReadStringIntoBufferAsync>d__.<>1__state = -1;
			<ReadStringIntoBufferAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadStringIntoBufferAsync>d__9>(ref <ReadStringIntoBufferAsync>d__);
			return <ReadStringIntoBufferAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00006438 File Offset: 0x00004638
		private global::System.Threading.Tasks.Task ProcessCarriageReturnAsync(bool append, global::System.Threading.CancellationToken cancellationToken)
		{
			this._charPos++;
			global::System.Threading.Tasks.Task<bool> task = this.EnsureCharsAsync(1, append, cancellationToken);
			if (task.IsCompletedSucessfully())
			{
				this.SetNewLine(task.Result);
				return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
			}
			return this.ProcessCarriageReturnAsync(task);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00006480 File Offset: 0x00004680
		private global::System.Threading.Tasks.Task ProcessCarriageReturnAsync(global::System.Threading.Tasks.Task<bool> task)
		{
			global::Newtonsoft.Json.JsonTextReader.<ProcessCarriageReturnAsync>d__11 <ProcessCarriageReturnAsync>d__;
			<ProcessCarriageReturnAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ProcessCarriageReturnAsync>d__.<>4__this = this;
			<ProcessCarriageReturnAsync>d__.task = task;
			<ProcessCarriageReturnAsync>d__.<>1__state = -1;
			<ProcessCarriageReturnAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ProcessCarriageReturnAsync>d__11>(ref <ProcessCarriageReturnAsync>d__);
			return <ProcessCarriageReturnAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000064CC File Offset: 0x000046CC
		private global::System.Threading.Tasks.Task<char> ParseUnicodeAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseUnicodeAsync>d__12 <ParseUnicodeAsync>d__;
			<ParseUnicodeAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<char>.Create();
			<ParseUnicodeAsync>d__.<>4__this = this;
			<ParseUnicodeAsync>d__.cancellationToken = cancellationToken;
			<ParseUnicodeAsync>d__.<>1__state = -1;
			<ParseUnicodeAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseUnicodeAsync>d__12>(ref <ParseUnicodeAsync>d__);
			return <ParseUnicodeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00006517 File Offset: 0x00004717
		private global::System.Threading.Tasks.Task<bool> EnsureCharsAsync(int relativePosition, bool append, global::System.Threading.CancellationToken cancellationToken)
		{
			if (this._charPos + relativePosition < this._charsUsed)
			{
				return global::Newtonsoft.Json.Utilities.AsyncUtils.True;
			}
			if (this._isEndOfFile)
			{
				return global::Newtonsoft.Json.Utilities.AsyncUtils.False;
			}
			return this.ReadCharsAsync(relativePosition, append, cancellationToken);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00006548 File Offset: 0x00004748
		private global::System.Threading.Tasks.Task<bool> ReadCharsAsync(int relativePosition, bool append, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadCharsAsync>d__14 <ReadCharsAsync>d__;
			<ReadCharsAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<ReadCharsAsync>d__.<>4__this = this;
			<ReadCharsAsync>d__.relativePosition = relativePosition;
			<ReadCharsAsync>d__.append = append;
			<ReadCharsAsync>d__.cancellationToken = cancellationToken;
			<ReadCharsAsync>d__.<>1__state = -1;
			<ReadCharsAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadCharsAsync>d__14>(ref <ReadCharsAsync>d__);
			return <ReadCharsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000065A4 File Offset: 0x000047A4
		private global::System.Threading.Tasks.Task<bool> ParseObjectAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseObjectAsync>d__15 <ParseObjectAsync>d__;
			<ParseObjectAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<ParseObjectAsync>d__.<>4__this = this;
			<ParseObjectAsync>d__.cancellationToken = cancellationToken;
			<ParseObjectAsync>d__.<>1__state = -1;
			<ParseObjectAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseObjectAsync>d__15>(ref <ParseObjectAsync>d__);
			return <ParseObjectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000065F0 File Offset: 0x000047F0
		private global::System.Threading.Tasks.Task ParseCommentAsync(bool setToken, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseCommentAsync>d__16 <ParseCommentAsync>d__;
			<ParseCommentAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ParseCommentAsync>d__.<>4__this = this;
			<ParseCommentAsync>d__.setToken = setToken;
			<ParseCommentAsync>d__.cancellationToken = cancellationToken;
			<ParseCommentAsync>d__.<>1__state = -1;
			<ParseCommentAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseCommentAsync>d__16>(ref <ParseCommentAsync>d__);
			return <ParseCommentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00006644 File Offset: 0x00004844
		private global::System.Threading.Tasks.Task EatWhitespaceAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<EatWhitespaceAsync>d__17 <EatWhitespaceAsync>d__;
			<EatWhitespaceAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<EatWhitespaceAsync>d__.<>4__this = this;
			<EatWhitespaceAsync>d__.cancellationToken = cancellationToken;
			<EatWhitespaceAsync>d__.<>1__state = -1;
			<EatWhitespaceAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<EatWhitespaceAsync>d__17>(ref <EatWhitespaceAsync>d__);
			return <EatWhitespaceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00006690 File Offset: 0x00004890
		private global::System.Threading.Tasks.Task ParseStringAsync(char quote, global::Newtonsoft.Json.ReadType readType, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseStringAsync>d__18 <ParseStringAsync>d__;
			<ParseStringAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ParseStringAsync>d__.<>4__this = this;
			<ParseStringAsync>d__.quote = quote;
			<ParseStringAsync>d__.readType = readType;
			<ParseStringAsync>d__.cancellationToken = cancellationToken;
			<ParseStringAsync>d__.<>1__state = -1;
			<ParseStringAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseStringAsync>d__18>(ref <ParseStringAsync>d__);
			return <ParseStringAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000066EC File Offset: 0x000048EC
		private global::System.Threading.Tasks.Task<bool> MatchValueAsync(string value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<MatchValueAsync>d__19 <MatchValueAsync>d__;
			<MatchValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<MatchValueAsync>d__.<>4__this = this;
			<MatchValueAsync>d__.value = value;
			<MatchValueAsync>d__.cancellationToken = cancellationToken;
			<MatchValueAsync>d__.<>1__state = -1;
			<MatchValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<MatchValueAsync>d__19>(ref <MatchValueAsync>d__);
			return <MatchValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00006740 File Offset: 0x00004940
		private global::System.Threading.Tasks.Task<bool> MatchValueWithTrailingSeparatorAsync(string value, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20 <MatchValueWithTrailingSeparatorAsync>d__;
			<MatchValueWithTrailingSeparatorAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<MatchValueWithTrailingSeparatorAsync>d__.<>4__this = this;
			<MatchValueWithTrailingSeparatorAsync>d__.value = value;
			<MatchValueWithTrailingSeparatorAsync>d__.cancellationToken = cancellationToken;
			<MatchValueWithTrailingSeparatorAsync>d__.<>1__state = -1;
			<MatchValueWithTrailingSeparatorAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<MatchValueWithTrailingSeparatorAsync>d__20>(ref <MatchValueWithTrailingSeparatorAsync>d__);
			return <MatchValueWithTrailingSeparatorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00006794 File Offset: 0x00004994
		private global::System.Threading.Tasks.Task MatchAndSetAsync(string value, global::Newtonsoft.Json.JsonToken newToken, [global::System.Runtime.CompilerServices.Nullable(2)] object tokenValue, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<MatchAndSetAsync>d__21 <MatchAndSetAsync>d__;
			<MatchAndSetAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<MatchAndSetAsync>d__.<>4__this = this;
			<MatchAndSetAsync>d__.value = value;
			<MatchAndSetAsync>d__.newToken = newToken;
			<MatchAndSetAsync>d__.tokenValue = tokenValue;
			<MatchAndSetAsync>d__.cancellationToken = cancellationToken;
			<MatchAndSetAsync>d__.<>1__state = -1;
			<MatchAndSetAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<MatchAndSetAsync>d__21>(ref <MatchAndSetAsync>d__);
			return <MatchAndSetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000067F8 File Offset: 0x000049F8
		private global::System.Threading.Tasks.Task ParseTrueAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.MatchAndSetAsync(global::Newtonsoft.Json.JsonConvert.True, global::Newtonsoft.Json.JsonToken.Boolean, true, cancellationToken);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000680E File Offset: 0x00004A0E
		private global::System.Threading.Tasks.Task ParseFalseAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.MatchAndSetAsync(global::Newtonsoft.Json.JsonConvert.False, global::Newtonsoft.Json.JsonToken.Boolean, false, cancellationToken);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00006824 File Offset: 0x00004A24
		private global::System.Threading.Tasks.Task ParseNullAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.MatchAndSetAsync(global::Newtonsoft.Json.JsonConvert.Null, global::Newtonsoft.Json.JsonToken.Null, null, cancellationToken);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00006838 File Offset: 0x00004A38
		private global::System.Threading.Tasks.Task ParseConstructorAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseConstructorAsync>d__25 <ParseConstructorAsync>d__;
			<ParseConstructorAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ParseConstructorAsync>d__.<>4__this = this;
			<ParseConstructorAsync>d__.cancellationToken = cancellationToken;
			<ParseConstructorAsync>d__.<>1__state = -1;
			<ParseConstructorAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseConstructorAsync>d__25>(ref <ParseConstructorAsync>d__);
			return <ParseConstructorAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00006884 File Offset: 0x00004A84
		private global::System.Threading.Tasks.Task<object> ParseNumberNaNAsync(global::Newtonsoft.Json.ReadType readType, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseNumberNaNAsync>d__26 <ParseNumberNaNAsync>d__;
			<ParseNumberNaNAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Create();
			<ParseNumberNaNAsync>d__.<>4__this = this;
			<ParseNumberNaNAsync>d__.readType = readType;
			<ParseNumberNaNAsync>d__.cancellationToken = cancellationToken;
			<ParseNumberNaNAsync>d__.<>1__state = -1;
			<ParseNumberNaNAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseNumberNaNAsync>d__26>(ref <ParseNumberNaNAsync>d__);
			return <ParseNumberNaNAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000068D8 File Offset: 0x00004AD8
		private global::System.Threading.Tasks.Task<object> ParseNumberPositiveInfinityAsync(global::Newtonsoft.Json.ReadType readType, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27 <ParseNumberPositiveInfinityAsync>d__;
			<ParseNumberPositiveInfinityAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Create();
			<ParseNumberPositiveInfinityAsync>d__.<>4__this = this;
			<ParseNumberPositiveInfinityAsync>d__.readType = readType;
			<ParseNumberPositiveInfinityAsync>d__.cancellationToken = cancellationToken;
			<ParseNumberPositiveInfinityAsync>d__.<>1__state = -1;
			<ParseNumberPositiveInfinityAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseNumberPositiveInfinityAsync>d__27>(ref <ParseNumberPositiveInfinityAsync>d__);
			return <ParseNumberPositiveInfinityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000692C File Offset: 0x00004B2C
		private global::System.Threading.Tasks.Task<object> ParseNumberNegativeInfinityAsync(global::Newtonsoft.Json.ReadType readType, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28 <ParseNumberNegativeInfinityAsync>d__;
			<ParseNumberNegativeInfinityAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Create();
			<ParseNumberNegativeInfinityAsync>d__.<>4__this = this;
			<ParseNumberNegativeInfinityAsync>d__.readType = readType;
			<ParseNumberNegativeInfinityAsync>d__.cancellationToken = cancellationToken;
			<ParseNumberNegativeInfinityAsync>d__.<>1__state = -1;
			<ParseNumberNegativeInfinityAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseNumberNegativeInfinityAsync>d__28>(ref <ParseNumberNegativeInfinityAsync>d__);
			return <ParseNumberNegativeInfinityAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00006980 File Offset: 0x00004B80
		private global::System.Threading.Tasks.Task ParseNumberAsync(global::Newtonsoft.Json.ReadType readType, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseNumberAsync>d__29 <ParseNumberAsync>d__;
			<ParseNumberAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ParseNumberAsync>d__.<>4__this = this;
			<ParseNumberAsync>d__.readType = readType;
			<ParseNumberAsync>d__.cancellationToken = cancellationToken;
			<ParseNumberAsync>d__.<>1__state = -1;
			<ParseNumberAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseNumberAsync>d__29>(ref <ParseNumberAsync>d__);
			return <ParseNumberAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000069D3 File Offset: 0x00004BD3
		private global::System.Threading.Tasks.Task ParseUndefinedAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.MatchAndSetAsync(global::Newtonsoft.Json.JsonConvert.Undefined, global::Newtonsoft.Json.JsonToken.Undefined, null, cancellationToken);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000069E4 File Offset: 0x00004BE4
		private global::System.Threading.Tasks.Task<bool> ParsePropertyAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParsePropertyAsync>d__31 <ParsePropertyAsync>d__;
			<ParsePropertyAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<ParsePropertyAsync>d__.<>4__this = this;
			<ParsePropertyAsync>d__.cancellationToken = cancellationToken;
			<ParsePropertyAsync>d__.<>1__state = -1;
			<ParsePropertyAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParsePropertyAsync>d__31>(ref <ParsePropertyAsync>d__);
			return <ParsePropertyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00006A30 File Offset: 0x00004C30
		private global::System.Threading.Tasks.Task ReadNumberIntoBufferAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadNumberIntoBufferAsync>d__32 <ReadNumberIntoBufferAsync>d__;
			<ReadNumberIntoBufferAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ReadNumberIntoBufferAsync>d__.<>4__this = this;
			<ReadNumberIntoBufferAsync>d__.cancellationToken = cancellationToken;
			<ReadNumberIntoBufferAsync>d__.<>1__state = -1;
			<ReadNumberIntoBufferAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadNumberIntoBufferAsync>d__32>(ref <ReadNumberIntoBufferAsync>d__);
			return <ReadNumberIntoBufferAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00006A7C File Offset: 0x00004C7C
		private global::System.Threading.Tasks.Task ParseUnquotedPropertyAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ParseUnquotedPropertyAsync>d__33 <ParseUnquotedPropertyAsync>d__;
			<ParseUnquotedPropertyAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ParseUnquotedPropertyAsync>d__.<>4__this = this;
			<ParseUnquotedPropertyAsync>d__.cancellationToken = cancellationToken;
			<ParseUnquotedPropertyAsync>d__.<>1__state = -1;
			<ParseUnquotedPropertyAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ParseUnquotedPropertyAsync>d__33>(ref <ParseUnquotedPropertyAsync>d__);
			return <ParseUnquotedPropertyAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00006AC8 File Offset: 0x00004CC8
		private global::System.Threading.Tasks.Task<bool> ReadNullCharAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadNullCharAsync>d__34 <ReadNullCharAsync>d__;
			<ReadNullCharAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<ReadNullCharAsync>d__.<>4__this = this;
			<ReadNullCharAsync>d__.cancellationToken = cancellationToken;
			<ReadNullCharAsync>d__.<>1__state = -1;
			<ReadNullCharAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadNullCharAsync>d__34>(ref <ReadNullCharAsync>d__);
			return <ReadNullCharAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00006B14 File Offset: 0x00004D14
		private global::System.Threading.Tasks.Task HandleNullAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<HandleNullAsync>d__35 <HandleNullAsync>d__;
			<HandleNullAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<HandleNullAsync>d__.<>4__this = this;
			<HandleNullAsync>d__.cancellationToken = cancellationToken;
			<HandleNullAsync>d__.<>1__state = -1;
			<HandleNullAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<HandleNullAsync>d__35>(ref <HandleNullAsync>d__);
			return <HandleNullAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00006B60 File Offset: 0x00004D60
		private global::System.Threading.Tasks.Task ReadFinishedAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadFinishedAsync>d__36 <ReadFinishedAsync>d__;
			<ReadFinishedAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ReadFinishedAsync>d__.<>4__this = this;
			<ReadFinishedAsync>d__.cancellationToken = cancellationToken;
			<ReadFinishedAsync>d__.<>1__state = -1;
			<ReadFinishedAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadFinishedAsync>d__36>(ref <ReadFinishedAsync>d__);
			return <ReadFinishedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00006BAC File Offset: 0x00004DAC
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		private global::System.Threading.Tasks.Task<object> ReadStringValueAsync(global::Newtonsoft.Json.ReadType readType, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadStringValueAsync>d__37 <ReadStringValueAsync>d__;
			<ReadStringValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Create();
			<ReadStringValueAsync>d__.<>4__this = this;
			<ReadStringValueAsync>d__.readType = readType;
			<ReadStringValueAsync>d__.cancellationToken = cancellationToken;
			<ReadStringValueAsync>d__.<>1__state = -1;
			<ReadStringValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadStringValueAsync>d__37>(ref <ReadStringValueAsync>d__);
			return <ReadStringValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00006C00 File Offset: 0x00004E00
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		private global::System.Threading.Tasks.Task<object> ReadNumberValueAsync(global::Newtonsoft.Json.ReadType readType, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadNumberValueAsync>d__38 <ReadNumberValueAsync>d__;
			<ReadNumberValueAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>.Create();
			<ReadNumberValueAsync>d__.<>4__this = this;
			<ReadNumberValueAsync>d__.readType = readType;
			<ReadNumberValueAsync>d__.cancellationToken = cancellationToken;
			<ReadNumberValueAsync>d__.<>1__state = -1;
			<ReadNumberValueAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadNumberValueAsync>d__38>(ref <ReadNumberValueAsync>d__);
			return <ReadNumberValueAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00006C53 File Offset: 0x00004E53
		public override global::System.Threading.Tasks.Task<bool?> ReadAsBooleanAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsBooleanAsync(cancellationToken);
			}
			return this.DoReadAsBooleanAsync(cancellationToken);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00006C6C File Offset: 0x00004E6C
		internal global::System.Threading.Tasks.Task<bool?> DoReadAsBooleanAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsBooleanAsync>d__40 <DoReadAsBooleanAsync>d__;
			<DoReadAsBooleanAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool?>.Create();
			<DoReadAsBooleanAsync>d__.<>4__this = this;
			<DoReadAsBooleanAsync>d__.cancellationToken = cancellationToken;
			<DoReadAsBooleanAsync>d__.<>1__state = -1;
			<DoReadAsBooleanAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsBooleanAsync>d__40>(ref <DoReadAsBooleanAsync>d__);
			return <DoReadAsBooleanAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00006CB7 File Offset: 0x00004EB7
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public override global::System.Threading.Tasks.Task<byte[]> ReadAsBytesAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsBytesAsync(cancellationToken);
			}
			return this.DoReadAsBytesAsync(cancellationToken);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00006CD0 File Offset: 0x00004ED0
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		internal global::System.Threading.Tasks.Task<byte[]> DoReadAsBytesAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsBytesAsync>d__42 <DoReadAsBytesAsync>d__;
			<DoReadAsBytesAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<byte[]>.Create();
			<DoReadAsBytesAsync>d__.<>4__this = this;
			<DoReadAsBytesAsync>d__.cancellationToken = cancellationToken;
			<DoReadAsBytesAsync>d__.<>1__state = -1;
			<DoReadAsBytesAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsBytesAsync>d__42>(ref <DoReadAsBytesAsync>d__);
			return <DoReadAsBytesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00006D1C File Offset: 0x00004F1C
		private global::System.Threading.Tasks.Task ReadIntoWrappedTypeObjectAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43 <ReadIntoWrappedTypeObjectAsync>d__;
			<ReadIntoWrappedTypeObjectAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ReadIntoWrappedTypeObjectAsync>d__.<>4__this = this;
			<ReadIntoWrappedTypeObjectAsync>d__.cancellationToken = cancellationToken;
			<ReadIntoWrappedTypeObjectAsync>d__.<>1__state = -1;
			<ReadIntoWrappedTypeObjectAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<ReadIntoWrappedTypeObjectAsync>d__43>(ref <ReadIntoWrappedTypeObjectAsync>d__);
			return <ReadIntoWrappedTypeObjectAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00006D67 File Offset: 0x00004F67
		public override global::System.Threading.Tasks.Task<global::System.DateTime?> ReadAsDateTimeAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsDateTimeAsync(cancellationToken);
			}
			return this.DoReadAsDateTimeAsync(cancellationToken);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00006D80 File Offset: 0x00004F80
		internal global::System.Threading.Tasks.Task<global::System.DateTime?> DoReadAsDateTimeAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsDateTimeAsync>d__45 <DoReadAsDateTimeAsync>d__;
			<DoReadAsDateTimeAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.DateTime?>.Create();
			<DoReadAsDateTimeAsync>d__.<>4__this = this;
			<DoReadAsDateTimeAsync>d__.cancellationToken = cancellationToken;
			<DoReadAsDateTimeAsync>d__.<>1__state = -1;
			<DoReadAsDateTimeAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsDateTimeAsync>d__45>(ref <DoReadAsDateTimeAsync>d__);
			return <DoReadAsDateTimeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00006DCB File Offset: 0x00004FCB
		public override global::System.Threading.Tasks.Task<global::System.DateTimeOffset?> ReadAsDateTimeOffsetAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsDateTimeOffsetAsync(cancellationToken);
			}
			return this.DoReadAsDateTimeOffsetAsync(cancellationToken);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00006DE4 File Offset: 0x00004FE4
		internal global::System.Threading.Tasks.Task<global::System.DateTimeOffset?> DoReadAsDateTimeOffsetAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsDateTimeOffsetAsync>d__47 <DoReadAsDateTimeOffsetAsync>d__;
			<DoReadAsDateTimeOffsetAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.DateTimeOffset?>.Create();
			<DoReadAsDateTimeOffsetAsync>d__.<>4__this = this;
			<DoReadAsDateTimeOffsetAsync>d__.cancellationToken = cancellationToken;
			<DoReadAsDateTimeOffsetAsync>d__.<>1__state = -1;
			<DoReadAsDateTimeOffsetAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsDateTimeOffsetAsync>d__47>(ref <DoReadAsDateTimeOffsetAsync>d__);
			return <DoReadAsDateTimeOffsetAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00006E2F File Offset: 0x0000502F
		public override global::System.Threading.Tasks.Task<decimal?> ReadAsDecimalAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsDecimalAsync(cancellationToken);
			}
			return this.DoReadAsDecimalAsync(cancellationToken);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00006E48 File Offset: 0x00005048
		internal global::System.Threading.Tasks.Task<decimal?> DoReadAsDecimalAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsDecimalAsync>d__49 <DoReadAsDecimalAsync>d__;
			<DoReadAsDecimalAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<decimal?>.Create();
			<DoReadAsDecimalAsync>d__.<>4__this = this;
			<DoReadAsDecimalAsync>d__.cancellationToken = cancellationToken;
			<DoReadAsDecimalAsync>d__.<>1__state = -1;
			<DoReadAsDecimalAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsDecimalAsync>d__49>(ref <DoReadAsDecimalAsync>d__);
			return <DoReadAsDecimalAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00006E93 File Offset: 0x00005093
		public override global::System.Threading.Tasks.Task<double?> ReadAsDoubleAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsDoubleAsync(cancellationToken);
			}
			return this.DoReadAsDoubleAsync(cancellationToken);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00006EAC File Offset: 0x000050AC
		internal global::System.Threading.Tasks.Task<double?> DoReadAsDoubleAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsDoubleAsync>d__51 <DoReadAsDoubleAsync>d__;
			<DoReadAsDoubleAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<double?>.Create();
			<DoReadAsDoubleAsync>d__.<>4__this = this;
			<DoReadAsDoubleAsync>d__.cancellationToken = cancellationToken;
			<DoReadAsDoubleAsync>d__.<>1__state = -1;
			<DoReadAsDoubleAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsDoubleAsync>d__51>(ref <DoReadAsDoubleAsync>d__);
			return <DoReadAsDoubleAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00006EF7 File Offset: 0x000050F7
		public override global::System.Threading.Tasks.Task<int?> ReadAsInt32Async(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsInt32Async(cancellationToken);
			}
			return this.DoReadAsInt32Async(cancellationToken);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00006F10 File Offset: 0x00005110
		internal global::System.Threading.Tasks.Task<int?> DoReadAsInt32Async(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsInt32Async>d__53 <DoReadAsInt32Async>d__;
			<DoReadAsInt32Async>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<int?>.Create();
			<DoReadAsInt32Async>d__.<>4__this = this;
			<DoReadAsInt32Async>d__.cancellationToken = cancellationToken;
			<DoReadAsInt32Async>d__.<>1__state = -1;
			<DoReadAsInt32Async>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsInt32Async>d__53>(ref <DoReadAsInt32Async>d__);
			return <DoReadAsInt32Async>d__.<>t__builder.Task;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00006F5B File Offset: 0x0000515B
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public override global::System.Threading.Tasks.Task<string> ReadAsStringAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (!this._safeAsync)
			{
				return base.ReadAsStringAsync(cancellationToken);
			}
			return this.DoReadAsStringAsync(cancellationToken);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00006F74 File Offset: 0x00005174
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		internal global::System.Threading.Tasks.Task<string> DoReadAsStringAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonTextReader.<DoReadAsStringAsync>d__55 <DoReadAsStringAsync>d__;
			<DoReadAsStringAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			<DoReadAsStringAsync>d__.<>4__this = this;
			<DoReadAsStringAsync>d__.cancellationToken = cancellationToken;
			<DoReadAsStringAsync>d__.<>1__state = -1;
			<DoReadAsStringAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonTextReader.<DoReadAsStringAsync>d__55>(ref <DoReadAsStringAsync>d__);
			return <DoReadAsStringAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00006FBF File Offset: 0x000051BF
		public JsonTextReader(global::System.IO.TextReader reader)
		{
			if (reader == null)
			{
				throw new global::System.ArgumentNullException("reader");
			}
			this._reader = reader;
			this._lineNumber = 1;
			this._safeAsync = (base.GetType() == typeof(global::Newtonsoft.Json.JsonTextReader));
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00006FFE File Offset: 0x000051FE
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00007006 File Offset: 0x00005206
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.JsonNameTable PropertyNameTable { [global::System.Runtime.CompilerServices.NullableContext(2)] get; [global::System.Runtime.CompilerServices.NullableContext(2)] set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0000700F File Offset: 0x0000520F
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00007017 File Offset: 0x00005217
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

		// Token: 0x06000215 RID: 533 RVA: 0x0000702E File Offset: 0x0000522E
		private void EnsureBufferNotEmpty()
		{
			if (this._stringBuffer.IsEmpty)
			{
				this._stringBuffer = new global::Newtonsoft.Json.Utilities.StringBuffer(this._arrayPool, 1024);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00007053 File Offset: 0x00005253
		private void SetNewLine(bool hasNextChar)
		{
			if (hasNextChar && this._chars[this._charPos] == '\n')
			{
				this._charPos++;
			}
			this.OnNewLine(this._charPos);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00007083 File Offset: 0x00005283
		private void OnNewLine(int pos)
		{
			this._lineNumber++;
			this._lineStartPos = pos;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000709A File Offset: 0x0000529A
		private void ParseString(char quote, global::Newtonsoft.Json.ReadType readType)
		{
			this._charPos++;
			this.ShiftBufferIfNeeded();
			this.ReadStringIntoBuffer(quote);
			this.ParseReadString(quote, readType);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000070C0 File Offset: 0x000052C0
		private void ParseReadString(char quote, global::Newtonsoft.Json.ReadType readType)
		{
			base.SetPostValueState(true);
			switch (readType)
			{
			case global::Newtonsoft.Json.ReadType.ReadAsInt32:
			case global::Newtonsoft.Json.ReadType.ReadAsDecimal:
			case global::Newtonsoft.Json.ReadType.ReadAsBoolean:
				return;
			case global::Newtonsoft.Json.ReadType.ReadAsBytes:
			{
				byte[] value;
				global::System.Guid guid;
				if (this._stringReference.Length == 0)
				{
					value = global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<byte>();
				}
				else if (this._stringReference.Length == 36 && global::Newtonsoft.Json.Utilities.ConvertUtils.TryConvertGuid(this._stringReference.ToString(), out guid))
				{
					value = guid.ToByteArray();
				}
				else
				{
					value = global::System.Convert.FromBase64CharArray(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length);
				}
				base.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, value, false);
				return;
			}
			case global::Newtonsoft.Json.ReadType.ReadAsString:
			{
				string value2 = this._stringReference.ToString();
				base.SetToken(global::Newtonsoft.Json.JsonToken.String, value2, false);
				this._quoteChar = quote;
				return;
			}
			}
			if (this._dateParseHandling != global::Newtonsoft.Json.DateParseHandling.None)
			{
				global::Newtonsoft.Json.DateParseHandling dateParseHandling;
				if (readType == global::Newtonsoft.Json.ReadType.ReadAsDateTime)
				{
					dateParseHandling = global::Newtonsoft.Json.DateParseHandling.DateTime;
				}
				else if (readType == global::Newtonsoft.Json.ReadType.ReadAsDateTimeOffset)
				{
					dateParseHandling = global::Newtonsoft.Json.DateParseHandling.DateTimeOffset;
				}
				else
				{
					dateParseHandling = this._dateParseHandling;
				}
				global::System.DateTimeOffset dateTimeOffset;
				if (dateParseHandling == global::Newtonsoft.Json.DateParseHandling.DateTime)
				{
					global::System.DateTime dateTime;
					if (global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTime(this._stringReference, base.DateTimeZoneHandling, base.DateFormatString, base.Culture, out dateTime))
					{
						base.SetToken(global::Newtonsoft.Json.JsonToken.Date, dateTime, false);
						return;
					}
				}
				else if (global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffset(this._stringReference, base.DateFormatString, base.Culture, out dateTimeOffset))
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.Date, dateTimeOffset, false);
					return;
				}
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.String, this._stringReference.ToString(), false);
			this._quoteChar = quote;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00007245 File Offset: 0x00005445
		private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
			global::System.Buffer.BlockCopy(src, srcOffset * 2, dst, dstOffset * 2, count * 2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00007258 File Offset: 0x00005458
		private void ShiftBufferIfNeeded()
		{
			int num = this._chars.Length;
			if ((double)(num - this._charPos) <= (double)num * 0.1 || num >= 1073741823)
			{
				int num2 = this._charsUsed - this._charPos;
				if (num2 > 0)
				{
					global::Newtonsoft.Json.JsonTextReader.BlockCopyChars(this._chars, this._charPos, this._chars, 0, num2);
				}
				this._lineStartPos -= this._charPos;
				this._charPos = 0;
				this._charsUsed = num2;
				this._chars[this._charsUsed] = '\0';
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x000072E7 File Offset: 0x000054E7
		private int ReadData(bool append)
		{
			return this.ReadData(append, 0);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000072F4 File Offset: 0x000054F4
		private void PrepareBufferForReadData(bool append, int charsRequired)
		{
			if (this._charsUsed + charsRequired >= this._chars.Length - 1)
			{
				if (append)
				{
					int num = this._chars.Length * 2;
					int minSize = global::System.Math.Max((num < 0) ? int.MaxValue : num, this._charsUsed + charsRequired + 1);
					char[] array = global::Newtonsoft.Json.Utilities.BufferUtils.RentBuffer(this._arrayPool, minSize);
					global::Newtonsoft.Json.JsonTextReader.BlockCopyChars(this._chars, 0, array, 0, this._chars.Length);
					global::Newtonsoft.Json.Utilities.BufferUtils.ReturnBuffer(this._arrayPool, this._chars);
					this._chars = array;
					return;
				}
				int num2 = this._charsUsed - this._charPos;
				if (num2 + charsRequired + 1 >= this._chars.Length)
				{
					char[] array2 = global::Newtonsoft.Json.Utilities.BufferUtils.RentBuffer(this._arrayPool, num2 + charsRequired + 1);
					if (num2 > 0)
					{
						global::Newtonsoft.Json.JsonTextReader.BlockCopyChars(this._chars, this._charPos, array2, 0, num2);
					}
					global::Newtonsoft.Json.Utilities.BufferUtils.ReturnBuffer(this._arrayPool, this._chars);
					this._chars = array2;
				}
				else if (num2 > 0)
				{
					global::Newtonsoft.Json.JsonTextReader.BlockCopyChars(this._chars, this._charPos, this._chars, 0, num2);
				}
				this._lineStartPos -= this._charPos;
				this._charPos = 0;
				this._charsUsed = num2;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00007420 File Offset: 0x00005620
		private int ReadData(bool append, int charsRequired)
		{
			if (this._isEndOfFile)
			{
				return 0;
			}
			this.PrepareBufferForReadData(append, charsRequired);
			int count = this._chars.Length - this._charsUsed - 1;
			int num = this._reader.Read(this._chars, this._charsUsed, count);
			this._charsUsed += num;
			if (num == 0)
			{
				this._isEndOfFile = true;
			}
			this._chars[this._charsUsed] = '\0';
			return num;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007491 File Offset: 0x00005691
		private bool EnsureChars(int relativePosition, bool append)
		{
			return this._charPos + relativePosition < this._charsUsed || this.ReadChars(relativePosition, append);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000074B0 File Offset: 0x000056B0
		private bool ReadChars(int relativePosition, bool append)
		{
			if (this._isEndOfFile)
			{
				return false;
			}
			int num = this._charPos + relativePosition - this._charsUsed + 1;
			int num2 = 0;
			do
			{
				int num3 = this.ReadData(append, num - num2);
				if (num3 == 0)
				{
					break;
				}
				num2 += num3;
			}
			while (num2 < num);
			return num2 >= num;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000074F8 File Offset: 0x000056F8
		public override bool Read()
		{
			this.EnsureBuffer();
			for (;;)
			{
				switch (this._currentState)
				{
				case global::Newtonsoft.Json.JsonReader.State.Start:
				case global::Newtonsoft.Json.JsonReader.State.Property:
				case global::Newtonsoft.Json.JsonReader.State.ArrayStart:
				case global::Newtonsoft.Json.JsonReader.State.Array:
				case global::Newtonsoft.Json.JsonReader.State.ConstructorStart:
				case global::Newtonsoft.Json.JsonReader.State.Constructor:
					goto IL_4C;
				case global::Newtonsoft.Json.JsonReader.State.ObjectStart:
				case global::Newtonsoft.Json.JsonReader.State.Object:
					goto IL_53;
				case global::Newtonsoft.Json.JsonReader.State.PostValue:
					if (this.ParsePostValue(false))
					{
						return true;
					}
					continue;
				case global::Newtonsoft.Json.JsonReader.State.Finished:
					goto IL_65;
				}
				break;
			}
			goto IL_D1;
			IL_4C:
			return this.ParseValue();
			IL_53:
			return this.ParseObject();
			IL_65:
			if (!this.EnsureChars(0, false))
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.None);
				return false;
			}
			this.EatWhitespace();
			if (this._isEndOfFile)
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.None);
				return false;
			}
			if (this._chars[this._charPos] == '/')
			{
				this.ParseComment(true);
				return true;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Additional text encountered after finished reading JSON content: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._chars[this._charPos]));
			IL_D1:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.CurrentState));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000075F6 File Offset: 0x000057F6
		public override int? ReadAsInt32()
		{
			return (int?)this.ReadNumberValue(global::Newtonsoft.Json.ReadType.ReadAsInt32);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00007604 File Offset: 0x00005804
		public override global::System.DateTime? ReadAsDateTime()
		{
			return (global::System.DateTime?)this.ReadStringValue(global::Newtonsoft.Json.ReadType.ReadAsDateTime);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00007612 File Offset: 0x00005812
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override string ReadAsString()
		{
			return (string)this.ReadStringValue(global::Newtonsoft.Json.ReadType.ReadAsString);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00007620 File Offset: 0x00005820
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public override byte[] ReadAsBytes()
		{
			this.EnsureBuffer();
			bool flag = false;
			switch (this._currentState)
			{
			case global::Newtonsoft.Json.JsonReader.State.Start:
			case global::Newtonsoft.Json.JsonReader.State.Property:
			case global::Newtonsoft.Json.JsonReader.State.ArrayStart:
			case global::Newtonsoft.Json.JsonReader.State.Array:
			case global::Newtonsoft.Json.JsonReader.State.ConstructorStart:
			case global::Newtonsoft.Json.JsonReader.State.Constructor:
				break;
			case global::Newtonsoft.Json.JsonReader.State.Complete:
			case global::Newtonsoft.Json.JsonReader.State.ObjectStart:
			case global::Newtonsoft.Json.JsonReader.State.Object:
			case global::Newtonsoft.Json.JsonReader.State.Closed:
			case global::Newtonsoft.Json.JsonReader.State.Error:
				goto IL_23E;
			case global::Newtonsoft.Json.JsonReader.State.PostValue:
				if (this.ParsePostValue(true))
				{
					return null;
				}
				break;
			case global::Newtonsoft.Json.JsonReader.State.Finished:
				this.ReadFinished();
				return null;
			default:
				goto IL_23E;
			}
			char c;
			for (;;)
			{
				c = this._chars[this._charPos];
				if (c <= '\'')
				{
					if (c <= '\r')
					{
						if (c != '\0')
						{
							switch (c)
							{
							case '\t':
								break;
							case '\n':
								this.ProcessLineFeed();
								continue;
							case '\v':
							case '\f':
								goto IL_215;
							case '\r':
								this.ProcessCarriageReturn(false);
								continue;
							default:
								goto IL_215;
							}
						}
						else
						{
							if (this.ReadNullChar())
							{
								break;
							}
							continue;
						}
					}
					else if (c != ' ')
					{
						if (c != '"' && c != '\'')
						{
							goto IL_215;
						}
						goto IL_FF;
					}
					this._charPos++;
					continue;
				}
				if (c <= '[')
				{
					if (c == ',')
					{
						this.ProcessValueComma();
						continue;
					}
					if (c == '/')
					{
						this.ParseComment(false);
						continue;
					}
					if (c == '[')
					{
						goto IL_175;
					}
				}
				else
				{
					if (c == ']')
					{
						goto IL_1B0;
					}
					if (c == 'n')
					{
						goto IL_191;
					}
					if (c == '{')
					{
						this._charPos++;
						base.SetToken(global::Newtonsoft.Json.JsonToken.StartObject);
						base.ReadIntoWrappedTypeObject();
						flag = true;
						continue;
					}
				}
				IL_215:
				this._charPos++;
				if (!char.IsWhiteSpace(c))
				{
					goto Block_22;
				}
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.None, null, false);
			return null;
			IL_FF:
			this.ParseString(c, global::Newtonsoft.Json.ReadType.ReadAsBytes);
			byte[] array = (byte[])this.Value;
			if (flag)
			{
				base.ReaderReadAndAssert();
				if (this.TokenType != global::Newtonsoft.Json.JsonToken.EndObject)
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading bytes. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this.TokenType));
				}
				base.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, array, false);
			}
			return array;
			IL_175:
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.StartArray);
			return base.ReadArrayIntoByteArray();
			IL_191:
			this.HandleNull();
			return null;
			IL_1B0:
			this._charPos++;
			if (this._currentState == global::Newtonsoft.Json.JsonReader.State.Array || this._currentState == global::Newtonsoft.Json.JsonReader.State.ArrayStart || this._currentState == global::Newtonsoft.Json.JsonReader.State.PostValue)
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.EndArray);
				return null;
			}
			throw this.CreateUnexpectedCharacterException(c);
			Block_22:
			throw this.CreateUnexpectedCharacterException(c);
			IL_23E:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.CurrentState));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000788C File Offset: 0x00005A8C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private object ReadStringValue(global::Newtonsoft.Json.ReadType readType)
		{
			this.EnsureBuffer();
			switch (this._currentState)
			{
			case global::Newtonsoft.Json.JsonReader.State.Start:
			case global::Newtonsoft.Json.JsonReader.State.Property:
			case global::Newtonsoft.Json.JsonReader.State.ArrayStart:
			case global::Newtonsoft.Json.JsonReader.State.Array:
			case global::Newtonsoft.Json.JsonReader.State.ConstructorStart:
			case global::Newtonsoft.Json.JsonReader.State.Constructor:
				break;
			case global::Newtonsoft.Json.JsonReader.State.Complete:
			case global::Newtonsoft.Json.JsonReader.State.ObjectStart:
			case global::Newtonsoft.Json.JsonReader.State.Object:
			case global::Newtonsoft.Json.JsonReader.State.Closed:
			case global::Newtonsoft.Json.JsonReader.State.Error:
				goto IL_2E1;
			case global::Newtonsoft.Json.JsonReader.State.PostValue:
				if (this.ParsePostValue(true))
				{
					return null;
				}
				break;
			case global::Newtonsoft.Json.JsonReader.State.Finished:
				this.ReadFinished();
				return null;
			default:
				goto IL_2E1;
			}
			char c;
			for (;;)
			{
				c = this._chars[this._charPos];
				if (c <= 'I')
				{
					if (c <= '\r')
					{
						if (c != '\0')
						{
							switch (c)
							{
							case '\t':
								break;
							case '\n':
								this.ProcessLineFeed();
								continue;
							case '\v':
							case '\f':
								goto IL_2B8;
							case '\r':
								this.ProcessCarriageReturn(false);
								continue;
							default:
								goto IL_2B8;
							}
						}
						else
						{
							if (this.ReadNullChar())
							{
								break;
							}
							continue;
						}
					}
					else
					{
						switch (c)
						{
						case ' ':
							break;
						case '!':
						case '#':
						case '$':
						case '%':
						case '&':
						case '(':
						case ')':
						case '*':
						case '+':
							goto IL_2B8;
						case '"':
						case '\'':
							goto IL_165;
						case ',':
							this.ProcessValueComma();
							continue;
						case '-':
							goto IL_175;
						case '.':
						case '0':
						case '1':
						case '2':
						case '3':
						case '4':
						case '5':
						case '6':
						case '7':
						case '8':
						case '9':
							goto IL_1A8;
						case '/':
							this.ParseComment(false);
							continue;
						default:
							if (c != 'I')
							{
								goto IL_2B8;
							}
							goto IL_224;
						}
					}
					this._charPos++;
					continue;
				}
				if (c <= ']')
				{
					if (c == 'N')
					{
						goto IL_22C;
					}
					if (c == ']')
					{
						goto IL_253;
					}
				}
				else
				{
					if (c == 'f')
					{
						goto IL_1D0;
					}
					if (c == 'n')
					{
						goto IL_234;
					}
					if (c == 't')
					{
						goto IL_1D0;
					}
				}
				IL_2B8:
				this._charPos++;
				if (!char.IsWhiteSpace(c))
				{
					goto Block_24;
				}
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.None, null, false);
			return null;
			IL_165:
			this.ParseString(c, readType);
			return this.FinishReadQuotedStringValue(readType);
			IL_175:
			if (this.EnsureChars(1, true) && this._chars[this._charPos + 1] == 'I')
			{
				return this.ParseNumberNegativeInfinity(readType);
			}
			this.ParseNumber(readType);
			return this.Value;
			IL_1A8:
			if (readType != global::Newtonsoft.Json.ReadType.ReadAsString)
			{
				this._charPos++;
				throw this.CreateUnexpectedCharacterException(c);
			}
			this.ParseNumber(global::Newtonsoft.Json.ReadType.ReadAsString);
			return this.Value;
			IL_1D0:
			if (readType != global::Newtonsoft.Json.ReadType.ReadAsString)
			{
				this._charPos++;
				throw this.CreateUnexpectedCharacterException(c);
			}
			string text = (c == 't') ? global::Newtonsoft.Json.JsonConvert.True : global::Newtonsoft.Json.JsonConvert.False;
			if (!this.MatchValueWithTrailingSeparator(text))
			{
				throw this.CreateUnexpectedCharacterException(this._chars[this._charPos]);
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.String, text);
			return text;
			IL_224:
			return this.ParseNumberPositiveInfinity(readType);
			IL_22C:
			return this.ParseNumberNaN(readType);
			IL_234:
			this.HandleNull();
			return null;
			IL_253:
			this._charPos++;
			if (this._currentState == global::Newtonsoft.Json.JsonReader.State.Array || this._currentState == global::Newtonsoft.Json.JsonReader.State.ArrayStart || this._currentState == global::Newtonsoft.Json.JsonReader.State.PostValue)
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.EndArray);
				return null;
			}
			throw this.CreateUnexpectedCharacterException(c);
			Block_24:
			throw this.CreateUnexpectedCharacterException(c);
			IL_2E1:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.CurrentState));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00007B9C File Offset: 0x00005D9C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private object FinishReadQuotedStringValue(global::Newtonsoft.Json.ReadType readType)
		{
			switch (readType)
			{
			case global::Newtonsoft.Json.ReadType.ReadAsBytes:
			case global::Newtonsoft.Json.ReadType.ReadAsString:
				return this.Value;
			case global::Newtonsoft.Json.ReadType.ReadAsDateTime:
			{
				object value = this.Value;
				if (value is global::System.DateTime)
				{
					global::System.DateTime dateTime = (global::System.DateTime)value;
					return dateTime;
				}
				return base.ReadDateTimeString((string)this.Value);
			}
			case global::Newtonsoft.Json.ReadType.ReadAsDateTimeOffset:
			{
				object value = this.Value;
				if (value is global::System.DateTimeOffset)
				{
					global::System.DateTimeOffset dateTimeOffset = (global::System.DateTimeOffset)value;
					return dateTimeOffset;
				}
				return base.ReadDateTimeOffsetString((string)this.Value);
			}
			}
			throw new global::System.ArgumentOutOfRangeException("readType");
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00007C40 File Offset: 0x00005E40
		private global::Newtonsoft.Json.JsonReaderException CreateUnexpectedCharacterException(char c)
		{
			return global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected character encountered while parsing value: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, c));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00007C60 File Offset: 0x00005E60
		public override bool? ReadAsBoolean()
		{
			this.EnsureBuffer();
			switch (this._currentState)
			{
			case global::Newtonsoft.Json.JsonReader.State.Start:
			case global::Newtonsoft.Json.JsonReader.State.Property:
			case global::Newtonsoft.Json.JsonReader.State.ArrayStart:
			case global::Newtonsoft.Json.JsonReader.State.Array:
			case global::Newtonsoft.Json.JsonReader.State.ConstructorStart:
			case global::Newtonsoft.Json.JsonReader.State.Constructor:
				break;
			case global::Newtonsoft.Json.JsonReader.State.Complete:
			case global::Newtonsoft.Json.JsonReader.State.ObjectStart:
			case global::Newtonsoft.Json.JsonReader.State.Object:
			case global::Newtonsoft.Json.JsonReader.State.Closed:
			case global::Newtonsoft.Json.JsonReader.State.Error:
				goto IL_2DF;
			case global::Newtonsoft.Json.JsonReader.State.PostValue:
				if (this.ParsePostValue(true))
				{
					return null;
				}
				break;
			case global::Newtonsoft.Json.JsonReader.State.Finished:
				this.ReadFinished();
				return null;
			default:
				goto IL_2DF;
			}
			char c;
			for (;;)
			{
				c = this._chars[this._charPos];
				if (c <= '9')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '\t':
							break;
						case '\n':
							this.ProcessLineFeed();
							continue;
						case '\v':
						case '\f':
							goto IL_2AE;
						case '\r':
							this.ProcessCarriageReturn(false);
							continue;
						default:
							switch (c)
							{
							case ' ':
								break;
							case '!':
							case '#':
							case '$':
							case '%':
							case '&':
							case '(':
							case ')':
							case '*':
							case '+':
								goto IL_2AE;
							case '"':
							case '\'':
								goto IL_158;
							case ',':
								this.ProcessValueComma();
								continue;
							case '-':
							case '.':
							case '0':
							case '1':
							case '2':
							case '3':
							case '4':
							case '5':
							case '6':
							case '7':
							case '8':
							case '9':
								goto IL_188;
							case '/':
								this.ParseComment(false);
								continue;
							default:
								goto IL_2AE;
							}
							break;
						}
						this._charPos++;
						continue;
					}
					if (this.ReadNullChar())
					{
						break;
					}
					continue;
				}
				else if (c <= 'f')
				{
					if (c == ']')
					{
						goto IL_241;
					}
					if (c == 'f')
					{
						goto IL_1DC;
					}
				}
				else
				{
					if (c == 'n')
					{
						goto IL_178;
					}
					if (c == 't')
					{
						goto IL_1DC;
					}
				}
				IL_2AE:
				this._charPos++;
				if (!char.IsWhiteSpace(c))
				{
					goto Block_18;
				}
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.None, null, false);
			return null;
			IL_158:
			this.ParseString(c, global::Newtonsoft.Json.ReadType.Read);
			return base.ReadBooleanString(this._stringReference.ToString());
			IL_178:
			this.HandleNull();
			return null;
			IL_188:
			this.ParseNumber(global::Newtonsoft.Json.ReadType.Read);
			object value = this.Value;
			bool flag;
			if (value is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger left = (global::System.Numerics.BigInteger)value;
				flag = (left != 0L);
			}
			else
			{
				flag = global::System.Convert.ToBoolean(this.Value, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.Boolean, flag, false);
			return new bool?(flag);
			IL_1DC:
			bool flag2 = c == 't';
			string value2 = flag2 ? global::Newtonsoft.Json.JsonConvert.True : global::Newtonsoft.Json.JsonConvert.False;
			if (!this.MatchValueWithTrailingSeparator(value2))
			{
				throw this.CreateUnexpectedCharacterException(this._chars[this._charPos]);
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.Boolean, flag2);
			return new bool?(flag2);
			IL_241:
			this._charPos++;
			if (this._currentState == global::Newtonsoft.Json.JsonReader.State.Array || this._currentState == global::Newtonsoft.Json.JsonReader.State.ArrayStart || this._currentState == global::Newtonsoft.Json.JsonReader.State.PostValue)
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.EndArray);
				return null;
			}
			throw this.CreateUnexpectedCharacterException(c);
			Block_18:
			throw this.CreateUnexpectedCharacterException(c);
			IL_2DF:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.CurrentState));
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00007F6C File Offset: 0x0000616C
		private void ProcessValueComma()
		{
			this._charPos++;
			if (this._currentState != global::Newtonsoft.Json.JsonReader.State.PostValue)
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.Undefined);
				global::Newtonsoft.Json.JsonReaderException ex = this.CreateUnexpectedCharacterException(',');
				this._charPos--;
				throw ex;
			}
			base.SetStateBasedOnCurrent();
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00007FAC File Offset: 0x000061AC
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private object ReadNumberValue(global::Newtonsoft.Json.ReadType readType)
		{
			this.EnsureBuffer();
			switch (this._currentState)
			{
			case global::Newtonsoft.Json.JsonReader.State.Start:
			case global::Newtonsoft.Json.JsonReader.State.Property:
			case global::Newtonsoft.Json.JsonReader.State.ArrayStart:
			case global::Newtonsoft.Json.JsonReader.State.Array:
			case global::Newtonsoft.Json.JsonReader.State.ConstructorStart:
			case global::Newtonsoft.Json.JsonReader.State.Constructor:
				break;
			case global::Newtonsoft.Json.JsonReader.State.Complete:
			case global::Newtonsoft.Json.JsonReader.State.ObjectStart:
			case global::Newtonsoft.Json.JsonReader.State.Object:
			case global::Newtonsoft.Json.JsonReader.State.Closed:
			case global::Newtonsoft.Json.JsonReader.State.Error:
				goto IL_250;
			case global::Newtonsoft.Json.JsonReader.State.PostValue:
				if (this.ParsePostValue(true))
				{
					return null;
				}
				break;
			case global::Newtonsoft.Json.JsonReader.State.Finished:
				this.ReadFinished();
				return null;
			default:
				goto IL_250;
			}
			char c;
			for (;;)
			{
				c = this._chars[this._charPos];
				if (c <= '9')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '\t':
							break;
						case '\n':
							this.ProcessLineFeed();
							continue;
						case '\v':
						case '\f':
							goto IL_227;
						case '\r':
							this.ProcessCarriageReturn(false);
							continue;
						default:
							switch (c)
							{
							case ' ':
								break;
							case '!':
							case '#':
							case '$':
							case '%':
							case '&':
							case '(':
							case ')':
							case '*':
							case '+':
								goto IL_227;
							case '"':
							case '\'':
								goto IL_142;
							case ',':
								this.ProcessValueComma();
								continue;
							case '-':
								goto IL_16A;
							case '.':
							case '0':
							case '1':
							case '2':
							case '3':
							case '4':
							case '5':
							case '6':
							case '7':
							case '8':
							case '9':
								goto IL_19D;
							case '/':
								this.ParseComment(false);
								continue;
							default:
								goto IL_227;
							}
							break;
						}
						this._charPos++;
						continue;
					}
					if (this.ReadNullChar())
					{
						break;
					}
					continue;
				}
				else if (c <= 'N')
				{
					if (c == 'I')
					{
						goto IL_162;
					}
					if (c == 'N')
					{
						goto IL_15A;
					}
				}
				else
				{
					if (c == ']')
					{
						goto IL_1C2;
					}
					if (c == 'n')
					{
						goto IL_152;
					}
				}
				IL_227:
				this._charPos++;
				if (!char.IsWhiteSpace(c))
				{
					goto Block_17;
				}
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.None, null, false);
			return null;
			IL_142:
			this.ParseString(c, readType);
			return this.FinishReadQuotedNumber(readType);
			IL_152:
			this.HandleNull();
			return null;
			IL_15A:
			return this.ParseNumberNaN(readType);
			IL_162:
			return this.ParseNumberPositiveInfinity(readType);
			IL_16A:
			if (this.EnsureChars(1, true) && this._chars[this._charPos + 1] == 'I')
			{
				return this.ParseNumberNegativeInfinity(readType);
			}
			this.ParseNumber(readType);
			return this.Value;
			IL_19D:
			this.ParseNumber(readType);
			return this.Value;
			IL_1C2:
			this._charPos++;
			if (this._currentState == global::Newtonsoft.Json.JsonReader.State.Array || this._currentState == global::Newtonsoft.Json.JsonReader.State.ArrayStart || this._currentState == global::Newtonsoft.Json.JsonReader.State.PostValue)
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.EndArray);
				return null;
			}
			throw this.CreateUnexpectedCharacterException(c);
			Block_17:
			throw this.CreateUnexpectedCharacterException(c);
			IL_250:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected state: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, base.CurrentState));
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000822C File Offset: 0x0000642C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private object FinishReadQuotedNumber(global::Newtonsoft.Json.ReadType readType)
		{
			if (readType == global::Newtonsoft.Json.ReadType.ReadAsInt32)
			{
				return base.ReadInt32String(this._stringReference.ToString());
			}
			if (readType == global::Newtonsoft.Json.ReadType.ReadAsDecimal)
			{
				return base.ReadDecimalString(this._stringReference.ToString());
			}
			if (readType != global::Newtonsoft.Json.ReadType.ReadAsDouble)
			{
				throw new global::System.ArgumentOutOfRangeException("readType");
			}
			return base.ReadDoubleString(this._stringReference.ToString());
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000082A8 File Offset: 0x000064A8
		public override global::System.DateTimeOffset? ReadAsDateTimeOffset()
		{
			return (global::System.DateTimeOffset?)this.ReadStringValue(global::Newtonsoft.Json.ReadType.ReadAsDateTimeOffset);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000082B6 File Offset: 0x000064B6
		public override decimal? ReadAsDecimal()
		{
			return (decimal?)this.ReadNumberValue(global::Newtonsoft.Json.ReadType.ReadAsDecimal);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000082C4 File Offset: 0x000064C4
		public override double? ReadAsDouble()
		{
			return (double?)this.ReadNumberValue(global::Newtonsoft.Json.ReadType.ReadAsDouble);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000082D4 File Offset: 0x000064D4
		private void HandleNull()
		{
			if (!this.EnsureChars(1, true))
			{
				this._charPos = this._charsUsed;
				throw base.CreateUnexpectedEndException();
			}
			if (this._chars[this._charPos + 1] == 'u')
			{
				this.ParseNull();
				return;
			}
			this._charPos += 2;
			throw this.CreateUnexpectedCharacterException(this._chars[this._charPos - 1]);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000833C File Offset: 0x0000653C
		private void ReadFinished()
		{
			if (this.EnsureChars(0, false))
			{
				this.EatWhitespace();
				if (this._isEndOfFile)
				{
					return;
				}
				if (this._chars[this._charPos] != '/')
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Additional text encountered after finished reading JSON content: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._chars[this._charPos]));
				}
				this.ParseComment(false);
			}
			base.SetToken(global::Newtonsoft.Json.JsonToken.None);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000083AB File Offset: 0x000065AB
		private bool ReadNullChar()
		{
			if (this._charsUsed == this._charPos)
			{
				if (this.ReadData(false) == 0)
				{
					this._isEndOfFile = true;
					return true;
				}
			}
			else
			{
				this._charPos++;
			}
			return false;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000083DC File Offset: 0x000065DC
		private void EnsureBuffer()
		{
			if (this._chars == null)
			{
				this._chars = global::Newtonsoft.Json.Utilities.BufferUtils.RentBuffer(this._arrayPool, 1024);
				this._chars[0] = '\0';
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00008408 File Offset: 0x00006608
		private void ReadStringIntoBuffer(char quote)
		{
			int num = this._charPos;
			int charPos = this._charPos;
			int lastWritePosition = this._charPos;
			this._stringBuffer.Position = 0;
			char c2;
			for (;;)
			{
				char c = this._chars[num++];
				if (c <= '\r')
				{
					if (c != '\0')
					{
						if (c != '\n')
						{
							if (c == '\r')
							{
								this._charPos = num - 1;
								this.ProcessCarriageReturn(true);
								num = this._charPos;
							}
						}
						else
						{
							this._charPos = num - 1;
							this.ProcessLineFeed();
							num = this._charPos;
						}
					}
					else if (this._charsUsed == num - 1)
					{
						num--;
						if (this.ReadData(true) == 0)
						{
							break;
						}
					}
				}
				else if (c != '"' && c != '\'')
				{
					if (c == '\\')
					{
						this._charPos = num;
						if (!this.EnsureChars(0, true))
						{
							goto Block_10;
						}
						int writeToPosition = num - 1;
						c2 = this._chars[num];
						num++;
						char c3;
						if (c2 <= '\\')
						{
							if (c2 <= '\'')
							{
								if (c2 != '"' && c2 != '\'')
								{
									goto Block_14;
								}
							}
							else if (c2 != '/')
							{
								if (c2 != '\\')
								{
									goto Block_16;
								}
								c3 = '\\';
								goto IL_28D;
							}
							c3 = c2;
						}
						else if (c2 <= 'f')
						{
							if (c2 != 'b')
							{
								if (c2 != 'f')
								{
									goto Block_19;
								}
								c3 = '\f';
							}
							else
							{
								c3 = '\b';
							}
						}
						else
						{
							if (c2 != 'n')
							{
								switch (c2)
								{
								case 'r':
									c3 = '\r';
									goto IL_28D;
								case 't':
									c3 = '\t';
									goto IL_28D;
								case 'u':
									this._charPos = num;
									c3 = this.ParseUnicode();
									if (global::Newtonsoft.Json.Utilities.StringUtils.IsLowSurrogate(c3))
									{
										c3 = '�';
									}
									else if (global::Newtonsoft.Json.Utilities.StringUtils.IsHighSurrogate(c3))
									{
										bool flag;
										do
										{
											flag = false;
											if (this.EnsureChars(2, true) && this._chars[this._charPos] == '\\' && this._chars[this._charPos + 1] == 'u')
											{
												char writeChar = c3;
												this._charPos += 2;
												c3 = this.ParseUnicode();
												if (!global::Newtonsoft.Json.Utilities.StringUtils.IsLowSurrogate(c3))
												{
													if (global::Newtonsoft.Json.Utilities.StringUtils.IsHighSurrogate(c3))
													{
														writeChar = '�';
														flag = true;
													}
													else
													{
														writeChar = '�';
													}
												}
												this.EnsureBufferNotEmpty();
												this.WriteCharToBuffer(writeChar, lastWritePosition, writeToPosition);
												lastWritePosition = this._charPos;
											}
											else
											{
												c3 = '�';
											}
										}
										while (flag);
									}
									num = this._charPos;
									goto IL_28D;
								}
								goto Block_21;
							}
							c3 = '\n';
						}
						IL_28D:
						this.EnsureBufferNotEmpty();
						this.WriteCharToBuffer(c3, lastWritePosition, writeToPosition);
						lastWritePosition = num;
					}
				}
				else if (this._chars[num - 1] == quote)
				{
					goto Block_28;
				}
			}
			this._charPos = num;
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unterminated string. Expected delimiter: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, quote));
			Block_10:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unterminated string. Expected delimiter: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, quote));
			Block_14:
			Block_16:
			Block_19:
			Block_21:
			this._charPos = num;
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Bad JSON escape sequence: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, "\\" + c2.ToString()));
			Block_28:
			this.FinishReadStringIntoBuffer(num - 1, charPos, lastWritePosition);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000870C File Offset: 0x0000690C
		private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition)
		{
			if (initialPosition == lastWritePosition)
			{
				this._stringReference = new global::Newtonsoft.Json.Utilities.StringReference(this._chars, initialPosition, charPos - initialPosition);
			}
			else
			{
				this.EnsureBufferNotEmpty();
				if (charPos > lastWritePosition)
				{
					this._stringBuffer.Append(this._arrayPool, this._chars, lastWritePosition, charPos - lastWritePosition);
				}
				this._stringReference = new global::Newtonsoft.Json.Utilities.StringReference(this._stringBuffer.InternalBuffer, 0, this._stringBuffer.Position);
			}
			this._charPos = charPos + 1;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00008784 File Offset: 0x00006984
		private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition)
		{
			if (writeToPosition > lastWritePosition)
			{
				this._stringBuffer.Append(this._arrayPool, this._chars, lastWritePosition, writeToPosition - lastWritePosition);
			}
			this._stringBuffer.Append(this._arrayPool, writeChar);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000087B8 File Offset: 0x000069B8
		private char ConvertUnicode(bool enoughChars)
		{
			if (!enoughChars)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected end while parsing Unicode escape sequence.");
			}
			int value;
			if (global::Newtonsoft.Json.Utilities.ConvertUtils.TryHexTextToInt(this._chars, this._charPos, this._charPos + 4, out value))
			{
				char result = global::System.Convert.ToChar(value);
				this._charPos += 4;
				return result;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Invalid Unicode escape sequence: \\u{0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, new string(this._chars, this._charPos, 4)));
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000882D File Offset: 0x00006A2D
		private char ParseUnicode()
		{
			return this.ConvertUnicode(this.EnsureChars(4, true));
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00008840 File Offset: 0x00006A40
		private void ReadNumberIntoBuffer()
		{
			int num = this._charPos;
			for (;;)
			{
				char c = this._chars[num];
				if (c == '\0')
				{
					this._charPos = num;
					if (this._charsUsed != num)
					{
						return;
					}
					if (this.ReadData(true) == 0)
					{
						break;
					}
				}
				else
				{
					if (this.ReadNumberCharIntoBuffer(c, num))
					{
						return;
					}
					num++;
				}
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000888C File Offset: 0x00006A8C
		private bool ReadNumberCharIntoBuffer(char currentChar, int charPos)
		{
			if (currentChar <= 'X')
			{
				switch (currentChar)
				{
				case '+':
				case '-':
				case '.':
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
				case 'A':
				case 'B':
				case 'C':
				case 'D':
				case 'E':
				case 'F':
					break;
				case ',':
				case '/':
				case ':':
				case ';':
				case '<':
				case '=':
				case '>':
				case '?':
				case '@':
					goto IL_B0;
				default:
					if (currentChar != 'X')
					{
						goto IL_B0;
					}
					break;
				}
			}
			else
			{
				switch (currentChar)
				{
				case 'a':
				case 'b':
				case 'c':
				case 'd':
				case 'e':
				case 'f':
					break;
				default:
					if (currentChar != 'x')
					{
						goto IL_B0;
					}
					break;
				}
			}
			return false;
			IL_B0:
			this._charPos = charPos;
			if (char.IsWhiteSpace(currentChar) || currentChar == ',' || currentChar == '}' || currentChar == ']' || currentChar == ')' || currentChar == '/')
			{
				return true;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected character encountered while parsing number: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, currentChar));
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000898E File Offset: 0x00006B8E
		private void ClearRecentString()
		{
			this._stringBuffer.Position = 0;
			this._stringReference = default(global::Newtonsoft.Json.Utilities.StringReference);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x000089A8 File Offset: 0x00006BA8
		private bool ParsePostValue(bool ignoreComments)
		{
			char c;
			for (;;)
			{
				c = this._chars[this._charPos];
				if (c <= ')')
				{
					if (c <= '\r')
					{
						if (c != '\0')
						{
							switch (c)
							{
							case '\t':
								break;
							case '\n':
								this.ProcessLineFeed();
								continue;
							case '\v':
							case '\f':
								goto IL_14C;
							case '\r':
								this.ProcessCarriageReturn(false);
								continue;
							default:
								goto IL_14C;
							}
						}
						else
						{
							if (this._charsUsed != this._charPos)
							{
								this._charPos++;
								continue;
							}
							if (this.ReadData(false) == 0)
							{
								break;
							}
							continue;
						}
					}
					else if (c != ' ')
					{
						if (c != ')')
						{
							goto IL_14C;
						}
						goto IL_E2;
					}
					this._charPos++;
					continue;
				}
				if (c <= '/')
				{
					if (c == ',')
					{
						goto IL_10C;
					}
					if (c == '/')
					{
						this.ParseComment(!ignoreComments);
						if (!ignoreComments)
						{
							return true;
						}
						continue;
					}
				}
				else
				{
					if (c == ']')
					{
						goto IL_CA;
					}
					if (c == '}')
					{
						goto IL_B2;
					}
				}
				IL_14C:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_167;
				}
				this._charPos++;
			}
			this._currentState = global::Newtonsoft.Json.JsonReader.State.Finished;
			return false;
			IL_B2:
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.EndObject);
			return true;
			IL_CA:
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.EndArray);
			return true;
			IL_E2:
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.EndConstructor);
			return true;
			IL_10C:
			this._charPos++;
			base.SetStateBasedOnCurrent();
			return false;
			IL_167:
			if (base.SupportMultipleContent && this.Depth == 0)
			{
				base.SetStateBasedOnCurrent();
				return false;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "After parsing a value an unexpected character was encountered: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, c));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00008B50 File Offset: 0x00006D50
		private bool ParseObject()
		{
			for (;;)
			{
				char c = this._chars[this._charPos];
				if (c <= '\r')
				{
					if (c != '\0')
					{
						switch (c)
						{
						case '\t':
							break;
						case '\n':
							this.ProcessLineFeed();
							continue;
						case '\v':
						case '\f':
							goto IL_BD;
						case '\r':
							this.ProcessCarriageReturn(false);
							continue;
						default:
							goto IL_BD;
						}
					}
					else
					{
						if (this._charsUsed != this._charPos)
						{
							this._charPos++;
							continue;
						}
						if (this.ReadData(false) == 0)
						{
							break;
						}
						continue;
					}
				}
				else if (c != ' ')
				{
					if (c == '/')
					{
						goto IL_8A;
					}
					if (c != '}')
					{
						goto IL_BD;
					}
					goto IL_72;
				}
				this._charPos++;
				continue;
				IL_BD:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_D8;
				}
				this._charPos++;
			}
			return false;
			IL_72:
			base.SetToken(global::Newtonsoft.Json.JsonToken.EndObject);
			this._charPos++;
			return true;
			IL_8A:
			this.ParseComment(true);
			return true;
			IL_D8:
			return this.ParseProperty();
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00008C3C File Offset: 0x00006E3C
		private bool ParseProperty()
		{
			char c = this._chars[this._charPos];
			char c2;
			if (c == '"' || c == '\'')
			{
				this._charPos++;
				c2 = c;
				this.ShiftBufferIfNeeded();
				this.ReadStringIntoBuffer(c2);
			}
			else
			{
				if (!this.ValidIdentifierChar(c))
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Invalid property identifier character: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._chars[this._charPos]));
				}
				c2 = '\0';
				this.ShiftBufferIfNeeded();
				this.ParseUnquotedProperty();
			}
			string text;
			if (this.PropertyNameTable != null)
			{
				text = this.PropertyNameTable.Get(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length);
				if (text == null)
				{
					text = this._stringReference.ToString();
				}
			}
			else
			{
				text = this._stringReference.ToString();
			}
			this.EatWhitespace();
			if (this._chars[this._charPos] != ':')
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Invalid character after parsing property name. Expected ':' but got: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._chars[this._charPos]));
			}
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.PropertyName, text);
			this._quoteChar = c2;
			this.ClearRecentString();
			return true;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00008D82 File Offset: 0x00006F82
		private bool ValidIdentifierChar(char value)
		{
			return char.IsLetterOrDigit(value) || value == '_' || value == '$';
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00008D98 File Offset: 0x00006F98
		private void ParseUnquotedProperty()
		{
			int charPos = this._charPos;
			for (;;)
			{
				char c = this._chars[this._charPos];
				if (c == '\0')
				{
					if (this._charsUsed != this._charPos)
					{
						goto IL_3B;
					}
					if (this.ReadData(true) == 0)
					{
						break;
					}
				}
				else if (this.ReadUnquotedPropertyReportIfDone(c, charPos))
				{
					return;
				}
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected end while parsing unquoted property name.");
			IL_3B:
			this._stringReference = new global::Newtonsoft.Json.Utilities.StringReference(this._chars, charPos, this._charPos - charPos);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00008E08 File Offset: 0x00007008
		private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition)
		{
			if (this.ValidIdentifierChar(currentChar))
			{
				this._charPos++;
				return false;
			}
			if (char.IsWhiteSpace(currentChar) || currentChar == ':')
			{
				this._stringReference = new global::Newtonsoft.Json.Utilities.StringReference(this._chars, initialPosition, this._charPos - initialPosition);
				return true;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Invalid JavaScript property identifier character: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, currentChar));
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00008E74 File Offset: 0x00007074
		private bool ParseValue()
		{
			char c;
			for (;;)
			{
				c = this._chars[this._charPos];
				if (c <= 'N')
				{
					if (c <= ' ')
					{
						if (c != '\0')
						{
							switch (c)
							{
							case '\t':
								break;
							case '\n':
								this.ProcessLineFeed();
								continue;
							case '\v':
							case '\f':
								goto IL_276;
							case '\r':
								this.ProcessCarriageReturn(false);
								continue;
							default:
								if (c != ' ')
								{
									goto IL_276;
								}
								break;
							}
							this._charPos++;
							continue;
						}
						if (this._charsUsed != this._charPos)
						{
							this._charPos++;
							continue;
						}
						if (this.ReadData(false) == 0)
						{
							break;
						}
						continue;
					}
					else if (c <= '/')
					{
						if (c == '"')
						{
							goto IL_116;
						}
						switch (c)
						{
						case '\'':
							goto IL_116;
						case ')':
							goto IL_234;
						case ',':
							goto IL_22A;
						case '-':
							goto IL_1A3;
						case '/':
							goto IL_1D3;
						}
					}
					else
					{
						if (c == 'I')
						{
							goto IL_199;
						}
						if (c == 'N')
						{
							goto IL_18F;
						}
					}
				}
				else if (c <= 'f')
				{
					if (c == '[')
					{
						goto IL_1FB;
					}
					if (c == ']')
					{
						goto IL_212;
					}
					if (c == 'f')
					{
						goto IL_128;
					}
				}
				else if (c <= 't')
				{
					if (c == 'n')
					{
						goto IL_130;
					}
					if (c == 't')
					{
						goto IL_120;
					}
				}
				else
				{
					if (c == 'u')
					{
						goto IL_1DC;
					}
					if (c == '{')
					{
						goto IL_1E4;
					}
				}
				IL_276:
				if (!char.IsWhiteSpace(c))
				{
					goto IL_291;
				}
				this._charPos++;
			}
			return false;
			IL_116:
			this.ParseString(c, global::Newtonsoft.Json.ReadType.Read);
			return true;
			IL_120:
			this.ParseTrue();
			return true;
			IL_128:
			this.ParseFalse();
			return true;
			IL_130:
			if (this.EnsureChars(1, true))
			{
				char c2 = this._chars[this._charPos + 1];
				if (c2 == 'u')
				{
					this.ParseNull();
				}
				else
				{
					if (c2 != 'e')
					{
						throw this.CreateUnexpectedCharacterException(this._chars[this._charPos]);
					}
					this.ParseConstructor();
				}
				return true;
			}
			this._charPos++;
			throw base.CreateUnexpectedEndException();
			IL_18F:
			this.ParseNumberNaN(global::Newtonsoft.Json.ReadType.Read);
			return true;
			IL_199:
			this.ParseNumberPositiveInfinity(global::Newtonsoft.Json.ReadType.Read);
			return true;
			IL_1A3:
			if (this.EnsureChars(1, true) && this._chars[this._charPos + 1] == 'I')
			{
				this.ParseNumberNegativeInfinity(global::Newtonsoft.Json.ReadType.Read);
			}
			else
			{
				this.ParseNumber(global::Newtonsoft.Json.ReadType.Read);
			}
			return true;
			IL_1D3:
			this.ParseComment(true);
			return true;
			IL_1DC:
			this.ParseUndefined();
			return true;
			IL_1E4:
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.StartObject);
			return true;
			IL_1FB:
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.StartArray);
			return true;
			IL_212:
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.EndArray);
			return true;
			IL_22A:
			base.SetToken(global::Newtonsoft.Json.JsonToken.Undefined);
			return true;
			IL_234:
			this._charPos++;
			base.SetToken(global::Newtonsoft.Json.JsonToken.EndConstructor);
			return true;
			IL_291:
			if (char.IsNumber(c) || c == '-' || c == '.')
			{
				this.ParseNumber(global::Newtonsoft.Json.ReadType.Read);
				return true;
			}
			throw this.CreateUnexpectedCharacterException(c);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00009134 File Offset: 0x00007334
		private void ProcessLineFeed()
		{
			this._charPos++;
			this.OnNewLine(this._charPos);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00009150 File Offset: 0x00007350
		private void ProcessCarriageReturn(bool append)
		{
			this._charPos++;
			this.SetNewLine(this.EnsureChars(1, append));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00009170 File Offset: 0x00007370
		private void EatWhitespace()
		{
			for (;;)
			{
				char c = this._chars[this._charPos];
				if (c != '\0')
				{
					if (c != '\n')
					{
						if (c != '\r')
						{
							if (c != ' ' && !char.IsWhiteSpace(c))
							{
								return;
							}
							this._charPos++;
						}
						else
						{
							this.ProcessCarriageReturn(false);
						}
					}
					else
					{
						this.ProcessLineFeed();
					}
				}
				else if (this._charsUsed == this._charPos)
				{
					if (this.ReadData(false) == 0)
					{
						break;
					}
				}
				else
				{
					this._charPos++;
				}
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000091F0 File Offset: 0x000073F0
		private void ParseConstructor()
		{
			if (!this.MatchValueWithTrailingSeparator("new"))
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected content while parsing JSON.");
			}
			this.EatWhitespace();
			int charPos = this._charPos;
			char c;
			for (;;)
			{
				c = this._chars[this._charPos];
				if (c == '\0')
				{
					if (this._charsUsed != this._charPos)
					{
						goto IL_51;
					}
					if (this.ReadData(true) == 0)
					{
						break;
					}
				}
				else
				{
					if (!char.IsLetterOrDigit(c))
					{
						goto IL_83;
					}
					this._charPos++;
				}
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected end while parsing constructor.");
			IL_51:
			int charPos2 = this._charPos;
			this._charPos++;
			goto IL_F5;
			IL_83:
			if (c == '\r')
			{
				charPos2 = this._charPos;
				this.ProcessCarriageReturn(true);
			}
			else if (c == '\n')
			{
				charPos2 = this._charPos;
				this.ProcessLineFeed();
			}
			else if (char.IsWhiteSpace(c))
			{
				charPos2 = this._charPos;
				this._charPos++;
			}
			else
			{
				if (c != '(')
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected character while parsing constructor: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, c));
				}
				charPos2 = this._charPos;
			}
			IL_F5:
			this._stringReference = new global::Newtonsoft.Json.Utilities.StringReference(this._chars, charPos, charPos2 - charPos);
			string value = this._stringReference.ToString();
			this.EatWhitespace();
			if (this._chars[this._charPos] != '(')
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected character while parsing constructor: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._chars[this._charPos]));
			}
			this._charPos++;
			this.ClearRecentString();
			base.SetToken(global::Newtonsoft.Json.JsonToken.StartConstructor, value);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00009380 File Offset: 0x00007580
		private void ParseNumber(global::Newtonsoft.Json.ReadType readType)
		{
			this.ShiftBufferIfNeeded();
			char firstChar = this._chars[this._charPos];
			int charPos = this._charPos;
			this.ReadNumberIntoBuffer();
			this.ParseReadNumber(readType, firstChar, charPos);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000093B8 File Offset: 0x000075B8
		private void ParseReadNumber(global::Newtonsoft.Json.ReadType readType, char firstChar, int initialPosition)
		{
			base.SetPostValueState(true);
			this._stringReference = new global::Newtonsoft.Json.Utilities.StringReference(this._chars, initialPosition, this._charPos - initialPosition);
			bool flag = char.IsDigit(firstChar) && this._stringReference.Length == 1;
			bool flag2 = firstChar == '0' && this._stringReference.Length > 1 && this._stringReference.Chars[this._stringReference.StartIndex + 1] != '.' && this._stringReference.Chars[this._stringReference.StartIndex + 1] != 'e' && this._stringReference.Chars[this._stringReference.StartIndex + 1] != 'E';
			object value;
			global::Newtonsoft.Json.JsonToken newToken;
			switch (readType)
			{
			case global::Newtonsoft.Json.ReadType.Read:
			case global::Newtonsoft.Json.ReadType.ReadAsInt64:
			{
				if (flag)
				{
					value = (long)((ulong)firstChar - 48UL);
					newToken = global::Newtonsoft.Json.JsonToken.Integer;
					goto IL_622;
				}
				if (flag2)
				{
					string text = this._stringReference.ToString();
					try
					{
						value = (text.StartsWith("0x", global::System.StringComparison.OrdinalIgnoreCase) ? global::System.Convert.ToInt64(text, 16) : global::System.Convert.ToInt64(text, 8));
					}
					catch (global::System.Exception ex)
					{
						throw this.ThrowReaderError("Input string '{0}' is not a valid number.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text), ex);
					}
					newToken = global::Newtonsoft.Json.JsonToken.Integer;
					goto IL_622;
				}
				long num;
				global::Newtonsoft.Json.Utilities.ParseResult parseResult = global::Newtonsoft.Json.Utilities.ConvertUtils.Int64TryParse(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length, out num);
				if (parseResult == global::Newtonsoft.Json.Utilities.ParseResult.Success)
				{
					value = num;
					newToken = global::Newtonsoft.Json.JsonToken.Integer;
					goto IL_622;
				}
				if (parseResult != global::Newtonsoft.Json.Utilities.ParseResult.Overflow)
				{
					if (this._floatParseHandling == global::Newtonsoft.Json.FloatParseHandling.Decimal)
					{
						decimal num2;
						parseResult = global::Newtonsoft.Json.Utilities.ConvertUtils.DecimalTryParse(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length, out num2);
						if (parseResult != global::Newtonsoft.Json.Utilities.ParseResult.Success)
						{
							throw this.ThrowReaderError("Input string '{0}' is not a valid decimal.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._stringReference.ToString()), null);
						}
						value = num2;
					}
					else
					{
						double num3;
						if (!double.TryParse(this._stringReference.ToString(), global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num3))
						{
							throw this.ThrowReaderError("Input string '{0}' is not a valid number.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._stringReference.ToString()), null);
						}
						value = num3;
					}
					newToken = global::Newtonsoft.Json.JsonToken.Float;
					goto IL_622;
				}
				string text2 = this._stringReference.ToString();
				if (text2.Length > 380)
				{
					throw this.ThrowReaderError("JSON integer {0} is too large to parse.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._stringReference.ToString()), null);
				}
				value = global::Newtonsoft.Json.JsonTextReader.BigIntegerParse(text2, global::System.Globalization.CultureInfo.InvariantCulture);
				newToken = global::Newtonsoft.Json.JsonToken.Integer;
				goto IL_622;
			}
			case global::Newtonsoft.Json.ReadType.ReadAsInt32:
				if (flag)
				{
					value = (int)(firstChar - '0');
				}
				else
				{
					if (flag2)
					{
						string text3 = this._stringReference.ToString();
						try
						{
							value = (text3.StartsWith("0x", global::System.StringComparison.OrdinalIgnoreCase) ? global::System.Convert.ToInt32(text3, 16) : global::System.Convert.ToInt32(text3, 8));
							goto IL_27A;
						}
						catch (global::System.Exception ex2)
						{
							throw this.ThrowReaderError("Input string '{0}' is not a valid integer.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text3), ex2);
						}
					}
					int num4;
					global::Newtonsoft.Json.Utilities.ParseResult parseResult2 = global::Newtonsoft.Json.Utilities.ConvertUtils.Int32TryParse(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length, out num4);
					if (parseResult2 == global::Newtonsoft.Json.Utilities.ParseResult.Success)
					{
						value = num4;
					}
					else
					{
						if (parseResult2 == global::Newtonsoft.Json.Utilities.ParseResult.Overflow)
						{
							throw this.ThrowReaderError("JSON integer {0} is too large or small for an Int32.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._stringReference.ToString()), null);
						}
						throw this.ThrowReaderError("Input string '{0}' is not a valid integer.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._stringReference.ToString()), null);
					}
				}
				IL_27A:
				newToken = global::Newtonsoft.Json.JsonToken.Integer;
				goto IL_622;
			case global::Newtonsoft.Json.ReadType.ReadAsString:
			{
				string text4 = this._stringReference.ToString();
				if (flag2)
				{
					try
					{
						if (text4.StartsWith("0x", global::System.StringComparison.OrdinalIgnoreCase))
						{
							global::System.Convert.ToInt64(text4, 16);
						}
						else
						{
							global::System.Convert.ToInt64(text4, 8);
						}
						goto IL_170;
					}
					catch (global::System.Exception ex3)
					{
						throw this.ThrowReaderError("Input string '{0}' is not a valid number.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text4), ex3);
					}
				}
				double num5;
				if (!double.TryParse(text4, global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num5))
				{
					throw this.ThrowReaderError("Input string '{0}' is not a valid number.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._stringReference.ToString()), null);
				}
				IL_170:
				newToken = global::Newtonsoft.Json.JsonToken.String;
				value = text4;
				goto IL_622;
			}
			case global::Newtonsoft.Json.ReadType.ReadAsDecimal:
				if (flag)
				{
					value = firstChar - 48m;
				}
				else
				{
					if (flag2)
					{
						string text5 = this._stringReference.ToString();
						try
						{
							value = global::System.Convert.ToDecimal(text5.StartsWith("0x", global::System.StringComparison.OrdinalIgnoreCase) ? global::System.Convert.ToInt64(text5, 16) : global::System.Convert.ToInt64(text5, 8));
							goto IL_35F;
						}
						catch (global::System.Exception ex4)
						{
							throw this.ThrowReaderError("Input string '{0}' is not a valid decimal.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text5), ex4);
						}
					}
					decimal num6;
					if (global::Newtonsoft.Json.Utilities.ConvertUtils.DecimalTryParse(this._stringReference.Chars, this._stringReference.StartIndex, this._stringReference.Length, out num6) != global::Newtonsoft.Json.Utilities.ParseResult.Success)
					{
						throw this.ThrowReaderError("Input string '{0}' is not a valid decimal.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._stringReference.ToString()), null);
					}
					value = num6;
				}
				IL_35F:
				newToken = global::Newtonsoft.Json.JsonToken.Float;
				goto IL_622;
			case global::Newtonsoft.Json.ReadType.ReadAsDouble:
				if (flag)
				{
					value = (double)firstChar - 48.0;
				}
				else
				{
					if (flag2)
					{
						string text6 = this._stringReference.ToString();
						try
						{
							value = global::System.Convert.ToDouble(text6.StartsWith("0x", global::System.StringComparison.OrdinalIgnoreCase) ? global::System.Convert.ToInt64(text6, 16) : global::System.Convert.ToInt64(text6, 8));
							goto IL_437;
						}
						catch (global::System.Exception ex5)
						{
							throw this.ThrowReaderError("Input string '{0}' is not a valid double.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text6), ex5);
						}
					}
					double num7;
					if (!double.TryParse(this._stringReference.ToString(), global::System.Globalization.NumberStyles.Float, global::System.Globalization.CultureInfo.InvariantCulture, out num7))
					{
						throw this.ThrowReaderError("Input string '{0}' is not a valid double.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._stringReference.ToString()), null);
					}
					value = num7;
				}
				IL_437:
				newToken = global::Newtonsoft.Json.JsonToken.Float;
				goto IL_622;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Cannot read number value as type.");
			IL_622:
			this.ClearRecentString();
			base.SetToken(newToken, value, false);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00009A38 File Offset: 0x00007C38
		private global::Newtonsoft.Json.JsonReaderException ThrowReaderError(string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex = null)
		{
			base.SetToken(global::Newtonsoft.Json.JsonToken.Undefined, null, false);
			return global::Newtonsoft.Json.JsonReaderException.Create(this, message, ex);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00009A4C File Offset: 0x00007C4C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static object BigIntegerParse(string number, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Numerics.BigInteger.Parse(number, culture);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00009A5C File Offset: 0x00007C5C
		private void ParseComment(bool setToken)
		{
			this._charPos++;
			if (!this.EnsureChars(1, false))
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected end while parsing comment.");
			}
			bool flag;
			if (this._chars[this._charPos] == '*')
			{
				flag = false;
			}
			else
			{
				if (this._chars[this._charPos] != '/')
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error parsing comment. Expected: *, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._chars[this._charPos]));
				}
				flag = true;
			}
			this._charPos++;
			int charPos = this._charPos;
			for (;;)
			{
				char c = this._chars[this._charPos];
				if (c <= '\n')
				{
					if (c != '\0')
					{
						if (c == '\n')
						{
							if (flag)
							{
								goto Block_16;
							}
							this.ProcessLineFeed();
							continue;
						}
					}
					else
					{
						if (this._charsUsed != this._charPos)
						{
							this._charPos++;
							continue;
						}
						if (this.ReadData(true) == 0)
						{
							break;
						}
						continue;
					}
				}
				else if (c != '\r')
				{
					if (c == '*')
					{
						this._charPos++;
						if (!flag && this.EnsureChars(0, true) && this._chars[this._charPos] == '/')
						{
							goto Block_14;
						}
						continue;
					}
				}
				else
				{
					if (flag)
					{
						goto Block_15;
					}
					this.ProcessCarriageReturn(true);
					continue;
				}
				this._charPos++;
			}
			if (!flag)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected end while parsing comment.");
			}
			this.EndComment(setToken, charPos, this._charPos);
			return;
			Block_14:
			this.EndComment(setToken, charPos, this._charPos - 1);
			this._charPos++;
			return;
			Block_15:
			this.EndComment(setToken, charPos, this._charPos);
			return;
			Block_16:
			this.EndComment(setToken, charPos, this._charPos);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00009C0F File Offset: 0x00007E0F
		private void EndComment(bool setToken, int initialPosition, int endPosition)
		{
			if (setToken)
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.Comment, new string(this._chars, initialPosition, endPosition - initialPosition));
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00009C2A File Offset: 0x00007E2A
		private bool MatchValue(string value)
		{
			return this.MatchValue(this.EnsureChars(value.Length - 1, true), value);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00009C44 File Offset: 0x00007E44
		private bool MatchValue(bool enoughChars, string value)
		{
			if (!enoughChars)
			{
				this._charPos = this._charsUsed;
				throw base.CreateUnexpectedEndException();
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (this._chars[this._charPos + i] != value[i])
				{
					this._charPos += i;
					return false;
				}
			}
			this._charPos += value.Length;
			return true;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00009CB4 File Offset: 0x00007EB4
		private bool MatchValueWithTrailingSeparator(string value)
		{
			return this.MatchValue(value) && (!this.EnsureChars(0, false) || this.IsSeparator(this._chars[this._charPos]) || this._chars[this._charPos] == '\0');
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00009CF4 File Offset: 0x00007EF4
		private bool IsSeparator(char c)
		{
			if (c <= ')')
			{
				switch (c)
				{
				case '\t':
				case '\n':
				case '\r':
					break;
				case '\v':
				case '\f':
					goto IL_8C;
				default:
					if (c != ' ')
					{
						if (c != ')')
						{
							goto IL_8C;
						}
						if (base.CurrentState == global::Newtonsoft.Json.JsonReader.State.Constructor || base.CurrentState == global::Newtonsoft.Json.JsonReader.State.ConstructorStart)
						{
							return true;
						}
						return false;
					}
					break;
				}
				return true;
			}
			if (c <= '/')
			{
				if (c != ',')
				{
					if (c != '/')
					{
						goto IL_8C;
					}
					if (!this.EnsureChars(1, false))
					{
						return false;
					}
					char c2 = this._chars[this._charPos + 1];
					return c2 == '*' || c2 == '/';
				}
			}
			else if (c != ']' && c != '}')
			{
				goto IL_8C;
			}
			return true;
			IL_8C:
			if (char.IsWhiteSpace(c))
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00009D98 File Offset: 0x00007F98
		private void ParseTrue()
		{
			if (this.MatchValueWithTrailingSeparator(global::Newtonsoft.Json.JsonConvert.True))
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.Boolean, true);
				return;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error parsing boolean value.");
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00009DC1 File Offset: 0x00007FC1
		private void ParseNull()
		{
			if (this.MatchValueWithTrailingSeparator(global::Newtonsoft.Json.JsonConvert.Null))
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.Null);
				return;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error parsing null value.");
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00009DE4 File Offset: 0x00007FE4
		private void ParseUndefined()
		{
			if (this.MatchValueWithTrailingSeparator(global::Newtonsoft.Json.JsonConvert.Undefined))
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.Undefined);
				return;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error parsing undefined value.");
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00009E07 File Offset: 0x00008007
		private void ParseFalse()
		{
			if (this.MatchValueWithTrailingSeparator(global::Newtonsoft.Json.JsonConvert.False))
			{
				base.SetToken(global::Newtonsoft.Json.JsonToken.Boolean, false);
				return;
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error parsing boolean value.");
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00009E30 File Offset: 0x00008030
		private object ParseNumberNegativeInfinity(global::Newtonsoft.Json.ReadType readType)
		{
			return this.ParseNumberNegativeInfinity(readType, this.MatchValueWithTrailingSeparator(global::Newtonsoft.Json.JsonConvert.NegativeInfinity));
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00009E44 File Offset: 0x00008044
		private object ParseNumberNegativeInfinity(global::Newtonsoft.Json.ReadType readType, bool matched)
		{
			if (matched)
			{
				if (readType != global::Newtonsoft.Json.ReadType.Read)
				{
					if (readType == global::Newtonsoft.Json.ReadType.ReadAsString)
					{
						base.SetToken(global::Newtonsoft.Json.JsonToken.String, global::Newtonsoft.Json.JsonConvert.NegativeInfinity);
						return global::Newtonsoft.Json.JsonConvert.NegativeInfinity;
					}
					if (readType != global::Newtonsoft.Json.ReadType.ReadAsDouble)
					{
						goto IL_4D;
					}
				}
				if (this._floatParseHandling == global::Newtonsoft.Json.FloatParseHandling.Double)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.Float, double.NegativeInfinity);
					return double.NegativeInfinity;
				}
				IL_4D:
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Cannot read -Infinity value.");
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error parsing -Infinity value.");
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00009EB5 File Offset: 0x000080B5
		private object ParseNumberPositiveInfinity(global::Newtonsoft.Json.ReadType readType)
		{
			return this.ParseNumberPositiveInfinity(readType, this.MatchValueWithTrailingSeparator(global::Newtonsoft.Json.JsonConvert.PositiveInfinity));
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009ECC File Offset: 0x000080CC
		private object ParseNumberPositiveInfinity(global::Newtonsoft.Json.ReadType readType, bool matched)
		{
			if (matched)
			{
				if (readType != global::Newtonsoft.Json.ReadType.Read)
				{
					if (readType == global::Newtonsoft.Json.ReadType.ReadAsString)
					{
						base.SetToken(global::Newtonsoft.Json.JsonToken.String, global::Newtonsoft.Json.JsonConvert.PositiveInfinity);
						return global::Newtonsoft.Json.JsonConvert.PositiveInfinity;
					}
					if (readType != global::Newtonsoft.Json.ReadType.ReadAsDouble)
					{
						goto IL_4D;
					}
				}
				if (this._floatParseHandling == global::Newtonsoft.Json.FloatParseHandling.Double)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.Float, double.PositiveInfinity);
					return double.PositiveInfinity;
				}
				IL_4D:
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Cannot read Infinity value.");
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error parsing Infinity value.");
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00009F3D File Offset: 0x0000813D
		private object ParseNumberNaN(global::Newtonsoft.Json.ReadType readType)
		{
			return this.ParseNumberNaN(readType, this.MatchValueWithTrailingSeparator(global::Newtonsoft.Json.JsonConvert.NaN));
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00009F54 File Offset: 0x00008154
		private object ParseNumberNaN(global::Newtonsoft.Json.ReadType readType, bool matched)
		{
			if (matched)
			{
				if (readType != global::Newtonsoft.Json.ReadType.Read)
				{
					if (readType == global::Newtonsoft.Json.ReadType.ReadAsString)
					{
						base.SetToken(global::Newtonsoft.Json.JsonToken.String, global::Newtonsoft.Json.JsonConvert.NaN);
						return global::Newtonsoft.Json.JsonConvert.NaN;
					}
					if (readType != global::Newtonsoft.Json.ReadType.ReadAsDouble)
					{
						goto IL_4D;
					}
				}
				if (this._floatParseHandling == global::Newtonsoft.Json.FloatParseHandling.Double)
				{
					base.SetToken(global::Newtonsoft.Json.JsonToken.Float, double.NaN);
					return double.NaN;
				}
				IL_4D:
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Cannot read NaN value.");
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error parsing NaN value.");
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009FC8 File Offset: 0x000081C8
		public override void Close()
		{
			base.Close();
			if (this._chars != null)
			{
				global::Newtonsoft.Json.Utilities.BufferUtils.ReturnBuffer(this._arrayPool, this._chars);
				this._chars = null;
			}
			if (base.CloseInput)
			{
				global::System.IO.TextReader reader = this._reader;
				if (reader != null)
				{
					reader.Close();
				}
			}
			this._stringBuffer.Clear(this._arrayPool);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000A025 File Offset: 0x00008225
		public bool HasLineInfo()
		{
			return true;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600025D RID: 605 RVA: 0x0000A028 File Offset: 0x00008228
		public int LineNumber
		{
			get
			{
				if (base.CurrentState == global::Newtonsoft.Json.JsonReader.State.Start && this.LinePosition == 0 && this.TokenType != global::Newtonsoft.Json.JsonToken.Comment)
				{
					return 0;
				}
				return this._lineNumber;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000A04B File Offset: 0x0000824B
		public int LinePosition
		{
			get
			{
				return this._charPos - this._lineStartPos;
			}
		}

		// Token: 0x040000C7 RID: 199
		private readonly bool _safeAsync;

		// Token: 0x040000C8 RID: 200
		private const char UnicodeReplacementChar = '�';

		// Token: 0x040000C9 RID: 201
		private const int MaximumJavascriptIntegerCharacterLength = 380;

		// Token: 0x040000CA RID: 202
		private const int LargeBufferLength = 1073741823;

		// Token: 0x040000CB RID: 203
		private readonly global::System.IO.TextReader _reader;

		// Token: 0x040000CC RID: 204
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private char[] _chars;

		// Token: 0x040000CD RID: 205
		private int _charsUsed;

		// Token: 0x040000CE RID: 206
		private int _charPos;

		// Token: 0x040000CF RID: 207
		private int _lineStartPos;

		// Token: 0x040000D0 RID: 208
		private int _lineNumber;

		// Token: 0x040000D1 RID: 209
		private bool _isEndOfFile;

		// Token: 0x040000D2 RID: 210
		private global::Newtonsoft.Json.Utilities.StringBuffer _stringBuffer;

		// Token: 0x040000D3 RID: 211
		private global::Newtonsoft.Json.Utilities.StringReference _stringReference;

		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.IArrayPool<char> _arrayPool;
	}
}
