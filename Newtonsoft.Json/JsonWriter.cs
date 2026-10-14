using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000032 RID: 50
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public abstract class JsonWriter : global::System.IDisposable
	{
		// Token: 0x0600034E RID: 846 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
		internal global::System.Threading.Tasks.Task AutoCompleteAsync(global::Newtonsoft.Json.JsonToken tokenBeingWritten, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.State currentState = this._currentState;
			global::Newtonsoft.Json.JsonWriter.State state = global::Newtonsoft.Json.JsonWriter.StateArray[(int)tokenBeingWritten][(int)currentState];
			if (state == global::Newtonsoft.Json.JsonWriter.State.Error)
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Token {0} in state {1} would result in an invalid JSON object.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, tokenBeingWritten.ToString(), currentState.ToString()), null);
			}
			this._currentState = state;
			if (this._formatting == global::Newtonsoft.Json.Formatting.Indented)
			{
				switch (currentState)
				{
				case global::Newtonsoft.Json.JsonWriter.State.Start:
					goto IL_F3;
				case global::Newtonsoft.Json.JsonWriter.State.Property:
					return this.WriteIndentSpaceAsync(cancellationToken);
				case global::Newtonsoft.Json.JsonWriter.State.Object:
					if (tokenBeingWritten == global::Newtonsoft.Json.JsonToken.PropertyName)
					{
						return this.AutoCompleteAsync(cancellationToken);
					}
					if (tokenBeingWritten != global::Newtonsoft.Json.JsonToken.Comment)
					{
						return this.WriteValueDelimiterAsync(cancellationToken);
					}
					goto IL_F3;
				case global::Newtonsoft.Json.JsonWriter.State.ArrayStart:
				case global::Newtonsoft.Json.JsonWriter.State.ConstructorStart:
					return this.WriteIndentAsync(cancellationToken);
				case global::Newtonsoft.Json.JsonWriter.State.Array:
				case global::Newtonsoft.Json.JsonWriter.State.Constructor:
					if (tokenBeingWritten != global::Newtonsoft.Json.JsonToken.Comment)
					{
						return this.AutoCompleteAsync(cancellationToken);
					}
					return this.WriteIndentAsync(cancellationToken);
				}
				if (tokenBeingWritten == global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					return this.WriteIndentAsync(cancellationToken);
				}
			}
			else if (tokenBeingWritten != global::Newtonsoft.Json.JsonToken.Comment)
			{
				switch (currentState)
				{
				case global::Newtonsoft.Json.JsonWriter.State.Object:
				case global::Newtonsoft.Json.JsonWriter.State.Array:
				case global::Newtonsoft.Json.JsonWriter.State.Constructor:
					return this.WriteValueDelimiterAsync(cancellationToken);
				}
			}
			IL_F3:
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
		private global::System.Threading.Tasks.Task AutoCompleteAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<AutoCompleteAsync>d__1 <AutoCompleteAsync>d__;
			<AutoCompleteAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<AutoCompleteAsync>d__.<>4__this = this;
			<AutoCompleteAsync>d__.cancellationToken = cancellationToken;
			<AutoCompleteAsync>d__.<>1__state = -1;
			<AutoCompleteAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<AutoCompleteAsync>d__1>(ref <AutoCompleteAsync>d__);
			return <AutoCompleteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D813 File Offset: 0x0000BA13
		public virtual global::System.Threading.Tasks.Task CloseAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.Close();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000D830 File Offset: 0x0000BA30
		public virtual global::System.Threading.Tasks.Task FlushAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.Flush();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000D84D File Offset: 0x0000BA4D
		protected virtual global::System.Threading.Tasks.Task WriteEndAsync(global::Newtonsoft.Json.JsonToken token, global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteEnd(token);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000D86B File Offset: 0x0000BA6B
		protected virtual global::System.Threading.Tasks.Task WriteIndentAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteIndent();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000D888 File Offset: 0x0000BA88
		protected virtual global::System.Threading.Tasks.Task WriteValueDelimiterAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValueDelimiter();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000D8A5 File Offset: 0x0000BAA5
		protected virtual global::System.Threading.Tasks.Task WriteIndentSpaceAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteIndentSpace();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000D8C2 File Offset: 0x0000BAC2
		public virtual global::System.Threading.Tasks.Task WriteRawAsync([global::System.Runtime.CompilerServices.Nullable(2)] string json, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteRaw(json);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000D8E0 File Offset: 0x0000BAE0
		public virtual global::System.Threading.Tasks.Task WriteEndAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteEnd();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000D900 File Offset: 0x0000BB00
		internal global::System.Threading.Tasks.Task WriteEndInternalAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonContainerType jsonContainerType = this.Peek();
			switch (jsonContainerType)
			{
			case global::Newtonsoft.Json.JsonContainerType.Object:
				return this.WriteEndObjectAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonContainerType.Array:
				return this.WriteEndArrayAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonContainerType.Constructor:
				return this.WriteEndConstructorAsync(cancellationToken);
			default:
				if (cancellationToken.IsCancellationRequested)
				{
					return cancellationToken.FromCanceled();
				}
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Unexpected type when writing end: " + jsonContainerType.ToString(), null);
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000D970 File Offset: 0x0000BB70
		internal global::System.Threading.Tasks.Task InternalWriteEndAsync(global::Newtonsoft.Json.JsonContainerType type, global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			int levelsToComplete = this.CalculateLevelsToComplete(type);
			while (levelsToComplete-- > 0)
			{
				global::Newtonsoft.Json.JsonToken closeTokenForType = this.GetCloseTokenForType(this.Pop());
				global::System.Threading.Tasks.Task task;
				if (this._currentState == global::Newtonsoft.Json.JsonWriter.State.Property)
				{
					task = this.WriteNullAsync(cancellationToken);
					if (!task.IsCompletedSucessfully())
					{
						return this.<InternalWriteEndAsync>g__AwaitProperty|11_0(task, levelsToComplete, closeTokenForType, cancellationToken);
					}
				}
				if (this._formatting == global::Newtonsoft.Json.Formatting.Indented && this._currentState != global::Newtonsoft.Json.JsonWriter.State.ObjectStart && this._currentState != global::Newtonsoft.Json.JsonWriter.State.ArrayStart)
				{
					task = this.WriteIndentAsync(cancellationToken);
					if (!task.IsCompletedSucessfully())
					{
						return this.<InternalWriteEndAsync>g__AwaitIndent|11_1(task, levelsToComplete, closeTokenForType, cancellationToken);
					}
				}
				task = this.WriteEndAsync(closeTokenForType, cancellationToken);
				if (!task.IsCompletedSucessfully())
				{
					return this.<InternalWriteEndAsync>g__AwaitEnd|11_2(task, levelsToComplete, cancellationToken);
				}
				this.UpdateCurrentState();
			}
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000DA32 File Offset: 0x0000BC32
		public virtual global::System.Threading.Tasks.Task WriteEndArrayAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteEndArray();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000DA4F File Offset: 0x0000BC4F
		public virtual global::System.Threading.Tasks.Task WriteEndConstructorAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteEndConstructor();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		public virtual global::System.Threading.Tasks.Task WriteEndObjectAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteEndObject();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000DA89 File Offset: 0x0000BC89
		public virtual global::System.Threading.Tasks.Task WriteNullAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteNull();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000DAA6 File Offset: 0x0000BCA6
		public virtual global::System.Threading.Tasks.Task WritePropertyNameAsync(string name, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WritePropertyName(name);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
		public virtual global::System.Threading.Tasks.Task WritePropertyNameAsync(string name, bool escape, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WritePropertyName(name, escape);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000360 RID: 864 RVA: 0x0000DAE3 File Offset: 0x0000BCE3
		internal global::System.Threading.Tasks.Task InternalWritePropertyNameAsync(string name, global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this._currentPosition.PropertyName = name;
			return this.AutoCompleteAsync(global::Newtonsoft.Json.JsonToken.PropertyName, cancellationToken);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x0000DB09 File Offset: 0x0000BD09
		public virtual global::System.Threading.Tasks.Task WriteStartArrayAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteStartArray();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x0000DB28 File Offset: 0x0000BD28
		internal global::System.Threading.Tasks.Task InternalWriteStartAsync(global::Newtonsoft.Json.JsonToken token, global::Newtonsoft.Json.JsonContainerType container, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<InternalWriteStartAsync>d__20 <InternalWriteStartAsync>d__;
			<InternalWriteStartAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<InternalWriteStartAsync>d__.<>4__this = this;
			<InternalWriteStartAsync>d__.token = token;
			<InternalWriteStartAsync>d__.container = container;
			<InternalWriteStartAsync>d__.cancellationToken = cancellationToken;
			<InternalWriteStartAsync>d__.<>1__state = -1;
			<InternalWriteStartAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<InternalWriteStartAsync>d__20>(ref <InternalWriteStartAsync>d__);
			return <InternalWriteStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000DB83 File Offset: 0x0000BD83
		public virtual global::System.Threading.Tasks.Task WriteCommentAsync([global::System.Runtime.CompilerServices.Nullable(2)] string text, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteComment(text);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000DBA1 File Offset: 0x0000BDA1
		internal global::System.Threading.Tasks.Task InternalWriteCommentAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.AutoCompleteAsync(global::Newtonsoft.Json.JsonToken.Comment, cancellationToken);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000DBAB File Offset: 0x0000BDAB
		public virtual global::System.Threading.Tasks.Task WriteRawValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] string json, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteRawValue(json);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0000DBC9 File Offset: 0x0000BDC9
		public virtual global::System.Threading.Tasks.Task WriteStartConstructorAsync(string name, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteStartConstructor(name);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000DBE7 File Offset: 0x0000BDE7
		public virtual global::System.Threading.Tasks.Task WriteStartObjectAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteStartObject();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000DC04 File Offset: 0x0000BE04
		public global::System.Threading.Tasks.Task WriteTokenAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return this.WriteTokenAsync(reader, true, cancellationToken);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000DC0F File Offset: 0x0000BE0F
		public global::System.Threading.Tasks.Task WriteTokenAsync(global::Newtonsoft.Json.JsonReader reader, bool writeChildren, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(reader, "reader");
			return this.WriteTokenAsync(reader, writeChildren, true, true, cancellationToken);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000DC27 File Offset: 0x0000BE27
		public global::System.Threading.Tasks.Task WriteTokenAsync(global::Newtonsoft.Json.JsonToken token, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return this.WriteTokenAsync(token, null, cancellationToken);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public global::System.Threading.Tasks.Task WriteTokenAsync(global::Newtonsoft.Json.JsonToken token, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			switch (token)
			{
			case global::Newtonsoft.Json.JsonToken.None:
				return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
			case global::Newtonsoft.Json.JsonToken.StartObject:
				return this.WriteStartObjectAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonToken.StartArray:
				return this.WriteStartArrayAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonToken.StartConstructor:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				return this.WriteStartConstructorAsync(value.ToString(), cancellationToken);
			case global::Newtonsoft.Json.JsonToken.PropertyName:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				return this.WritePropertyNameAsync(value.ToString(), cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Comment:
				return this.WriteCommentAsync((value != null) ? value.ToString() : null, cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Raw:
				return this.WriteRawValueAsync((value != null) ? value.ToString() : null, cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Integer:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				if (value is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger bigInteger = (global::System.Numerics.BigInteger)value;
					return this.WriteValueAsync(bigInteger, cancellationToken);
				}
				return this.WriteValueAsync(global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Float:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				if (value is decimal)
				{
					decimal value2 = (decimal)value;
					return this.WriteValueAsync(value2, cancellationToken);
				}
				if (value is double)
				{
					double value3 = (double)value;
					return this.WriteValueAsync(value3, cancellationToken);
				}
				if (value is float)
				{
					float value4 = (float)value;
					return this.WriteValueAsync(value4, cancellationToken);
				}
				return this.WriteValueAsync(global::System.Convert.ToDouble(value, global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
			case global::Newtonsoft.Json.JsonToken.String:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				return this.WriteValueAsync(value.ToString(), cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Boolean:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				return this.WriteValueAsync(global::System.Convert.ToBoolean(value, global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Null:
				return this.WriteNullAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Undefined:
				return this.WriteUndefinedAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonToken.EndObject:
				return this.WriteEndObjectAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonToken.EndArray:
				return this.WriteEndArrayAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				return this.WriteEndConstructorAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Date:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				if (value is global::System.DateTimeOffset)
				{
					global::System.DateTimeOffset value5 = (global::System.DateTimeOffset)value;
					return this.WriteValueAsync(value5, cancellationToken);
				}
				return this.WriteValueAsync(global::System.Convert.ToDateTime(value, global::System.Globalization.CultureInfo.InvariantCulture), cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Bytes:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				if (value is global::System.Guid)
				{
					global::System.Guid value6 = (global::System.Guid)value;
					return this.WriteValueAsync(value6, cancellationToken);
				}
				return this.WriteValueAsync((byte[])value, cancellationToken);
			default:
				throw global::Newtonsoft.Json.Utilities.MiscellaneousUtils.CreateArgumentOutOfRangeException("token", token, "Unexpected token type.");
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000DE98 File Offset: 0x0000C098
		internal virtual global::System.Threading.Tasks.Task WriteTokenAsync(global::Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<WriteTokenAsync>d__30 <WriteTokenAsync>d__;
			<WriteTokenAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteTokenAsync>d__.<>4__this = this;
			<WriteTokenAsync>d__.reader = reader;
			<WriteTokenAsync>d__.writeChildren = writeChildren;
			<WriteTokenAsync>d__.writeDateConstructorAsDate = writeDateConstructorAsDate;
			<WriteTokenAsync>d__.writeComments = writeComments;
			<WriteTokenAsync>d__.cancellationToken = cancellationToken;
			<WriteTokenAsync>d__.<>1__state = -1;
			<WriteTokenAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<WriteTokenAsync>d__30>(ref <WriteTokenAsync>d__);
			return <WriteTokenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000DF08 File Offset: 0x0000C108
		internal global::System.Threading.Tasks.Task WriteTokenSyncReadingAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<WriteTokenSyncReadingAsync>d__31 <WriteTokenSyncReadingAsync>d__;
			<WriteTokenSyncReadingAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteTokenSyncReadingAsync>d__.<>4__this = this;
			<WriteTokenSyncReadingAsync>d__.reader = reader;
			<WriteTokenSyncReadingAsync>d__.cancellationToken = cancellationToken;
			<WriteTokenSyncReadingAsync>d__.<>1__state = -1;
			<WriteTokenSyncReadingAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<WriteTokenSyncReadingAsync>d__31>(ref <WriteTokenSyncReadingAsync>d__);
			return <WriteTokenSyncReadingAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000DF5C File Offset: 0x0000C15C
		private global::System.Threading.Tasks.Task WriteConstructorDateAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<WriteConstructorDateAsync>d__32 <WriteConstructorDateAsync>d__;
			<WriteConstructorDateAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<WriteConstructorDateAsync>d__.<>4__this = this;
			<WriteConstructorDateAsync>d__.reader = reader;
			<WriteConstructorDateAsync>d__.cancellationToken = cancellationToken;
			<WriteConstructorDateAsync>d__.<>1__state = -1;
			<WriteConstructorDateAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<WriteConstructorDateAsync>d__32>(ref <WriteConstructorDateAsync>d__);
			return <WriteConstructorDateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000DFAF File Offset: 0x0000C1AF
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(bool value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000DFCD File Offset: 0x0000C1CD
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(bool? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000DFEB File Offset: 0x0000C1EB
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(byte value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000E009 File Offset: 0x0000C209
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(byte? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000E027 File Offset: 0x0000C227
		public virtual global::System.Threading.Tasks.Task WriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] byte[] value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000E045 File Offset: 0x0000C245
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(char value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000E063 File Offset: 0x0000C263
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(char? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000E081 File Offset: 0x0000C281
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(global::System.DateTime value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000E09F File Offset: 0x0000C29F
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(global::System.DateTime? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000E0BD File Offset: 0x0000C2BD
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(global::System.DateTimeOffset value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000E0DB File Offset: 0x0000C2DB
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(global::System.DateTimeOffset? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0000E0F9 File Offset: 0x0000C2F9
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(decimal value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0000E117 File Offset: 0x0000C317
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(decimal? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0000E135 File Offset: 0x0000C335
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(double value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000E153 File Offset: 0x0000C353
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(double? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x0000E171 File Offset: 0x0000C371
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(float value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000E18F File Offset: 0x0000C38F
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(float? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000E1AD File Offset: 0x0000C3AD
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(global::System.Guid value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000E1CB File Offset: 0x0000C3CB
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(global::System.Guid? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000E1E9 File Offset: 0x0000C3E9
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(int value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000E207 File Offset: 0x0000C407
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(int? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000E225 File Offset: 0x0000C425
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(long value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000E243 File Offset: 0x0000C443
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(long? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000E261 File Offset: 0x0000C461
		public virtual global::System.Threading.Tasks.Task WriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] object value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000E27F File Offset: 0x0000C47F
		[global::System.CLSCompliant(false)]
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(sbyte value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000E29D File Offset: 0x0000C49D
		[global::System.CLSCompliant(false)]
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(sbyte? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000E2BB File Offset: 0x0000C4BB
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(short value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000E2D9 File Offset: 0x0000C4D9
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(short? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000E2F7 File Offset: 0x0000C4F7
		public virtual global::System.Threading.Tasks.Task WriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] string value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000E315 File Offset: 0x0000C515
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(global::System.TimeSpan value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000E333 File Offset: 0x0000C533
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(global::System.TimeSpan? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000E351 File Offset: 0x0000C551
		[global::System.CLSCompliant(false)]
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(uint value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000E36F File Offset: 0x0000C56F
		[global::System.CLSCompliant(false)]
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(uint? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000E38D File Offset: 0x0000C58D
		[global::System.CLSCompliant(false)]
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(ulong value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000E3AB File Offset: 0x0000C5AB
		[global::System.CLSCompliant(false)]
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(ulong? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000E3C9 File Offset: 0x0000C5C9
		public virtual global::System.Threading.Tasks.Task WriteValueAsync([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Uri value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000E3E7 File Offset: 0x0000C5E7
		[global::System.CLSCompliant(false)]
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(ushort value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000E405 File Offset: 0x0000C605
		[global::System.CLSCompliant(false)]
		public virtual global::System.Threading.Tasks.Task WriteValueAsync(ushort? value, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteValue(value);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000E423 File Offset: 0x0000C623
		public virtual global::System.Threading.Tasks.Task WriteUndefinedAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteUndefined();
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000E440 File Offset: 0x0000C640
		public virtual global::System.Threading.Tasks.Task WriteWhitespaceAsync(string ws, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.WriteWhitespace(ws);
			return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000E45E File Offset: 0x0000C65E
		internal global::System.Threading.Tasks.Task InternalWriteValueAsync(global::Newtonsoft.Json.JsonToken token, global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			this.UpdateScopeWithFinishedValue();
			return this.AutoCompleteAsync(token, cancellationToken);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000E480 File Offset: 0x0000C680
		protected global::System.Threading.Tasks.Task SetWriteStateAsync(global::Newtonsoft.Json.JsonToken token, object value, global::System.Threading.CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return cancellationToken.FromCanceled();
			}
			switch (token)
			{
			case global::Newtonsoft.Json.JsonToken.StartObject:
				return this.InternalWriteStartAsync(token, global::Newtonsoft.Json.JsonContainerType.Object, cancellationToken);
			case global::Newtonsoft.Json.JsonToken.StartArray:
				return this.InternalWriteStartAsync(token, global::Newtonsoft.Json.JsonContainerType.Array, cancellationToken);
			case global::Newtonsoft.Json.JsonToken.StartConstructor:
				return this.InternalWriteStartAsync(token, global::Newtonsoft.Json.JsonContainerType.Constructor, cancellationToken);
			case global::Newtonsoft.Json.JsonToken.PropertyName:
			{
				string text = value as string;
				if (text == null)
				{
					throw new global::System.ArgumentException("A name is required when setting property name state.", "value");
				}
				return this.InternalWritePropertyNameAsync(text, cancellationToken);
			}
			case global::Newtonsoft.Json.JsonToken.Comment:
				return this.InternalWriteCommentAsync(cancellationToken);
			case global::Newtonsoft.Json.JsonToken.Raw:
				return global::Newtonsoft.Json.Utilities.AsyncUtils.CompletedTask;
			case global::Newtonsoft.Json.JsonToken.Integer:
			case global::Newtonsoft.Json.JsonToken.Float:
			case global::Newtonsoft.Json.JsonToken.String:
			case global::Newtonsoft.Json.JsonToken.Boolean:
			case global::Newtonsoft.Json.JsonToken.Null:
			case global::Newtonsoft.Json.JsonToken.Undefined:
			case global::Newtonsoft.Json.JsonToken.Date:
			case global::Newtonsoft.Json.JsonToken.Bytes:
				return this.InternalWriteValueAsync(token, cancellationToken);
			case global::Newtonsoft.Json.JsonToken.EndObject:
				return this.InternalWriteEndAsync(global::Newtonsoft.Json.JsonContainerType.Object, cancellationToken);
			case global::Newtonsoft.Json.JsonToken.EndArray:
				return this.InternalWriteEndAsync(global::Newtonsoft.Json.JsonContainerType.Array, cancellationToken);
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				return this.InternalWriteEndAsync(global::Newtonsoft.Json.JsonContainerType.Constructor, cancellationToken);
			default:
				throw new global::System.ArgumentOutOfRangeException("token");
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000E568 File Offset: 0x0000C768
		internal static global::System.Threading.Tasks.Task WriteValueAsync(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, object value, global::System.Threading.CancellationToken cancellationToken)
		{
			for (;;)
			{
				switch (typeCode)
				{
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char:
					goto IL_AD;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.CharNullable:
					goto IL_BB;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean:
					goto IL_DC;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BooleanNullable:
					goto IL_EA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte:
					goto IL_10B;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByteNullable:
					goto IL_119;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16:
					goto IL_13A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16Nullable:
					goto IL_148;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16:
					goto IL_16A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16Nullable:
					goto IL_178;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32:
					goto IL_19A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32Nullable:
					goto IL_1A8;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte:
					goto IL_1CA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.ByteNullable:
					goto IL_1D8;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32:
					goto IL_1FA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32Nullable:
					goto IL_208;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64:
					goto IL_22A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64Nullable:
					goto IL_238;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64:
					goto IL_25A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64Nullable:
					goto IL_268;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single:
					goto IL_28A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SingleNullable:
					goto IL_298;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double:
					goto IL_2BA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DoubleNullable:
					goto IL_2C8;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime:
					goto IL_2EA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeNullable:
					goto IL_2F8;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset:
					goto IL_31A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffsetNullable:
					goto IL_328;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Decimal:
					goto IL_34A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DecimalNullable:
					goto IL_358;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Guid:
					goto IL_37A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.GuidNullable:
					goto IL_388;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpan:
					goto IL_3AA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpanNullable:
					goto IL_3B8;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigInteger:
					goto IL_3DA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigIntegerNullable:
					goto IL_3ED;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Uri:
					goto IL_414;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.String:
					goto IL_422;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Bytes:
					goto IL_430;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DBNull:
					goto IL_43E;
				default:
				{
					global::System.IConvertible convertible = value as global::System.IConvertible;
					if (convertible == null)
					{
						goto IL_45F;
					}
					global::Newtonsoft.Json.JsonWriter.ResolveConvertibleValue(convertible, out typeCode, out value);
					break;
				}
				}
			}
			IL_AD:
			return writer.WriteValueAsync((char)value, cancellationToken);
			IL_BB:
			return writer.WriteValueAsync((value == null) ? null : new char?((char)value), cancellationToken);
			IL_DC:
			return writer.WriteValueAsync((bool)value, cancellationToken);
			IL_EA:
			return writer.WriteValueAsync((value == null) ? null : new bool?((bool)value), cancellationToken);
			IL_10B:
			return writer.WriteValueAsync((sbyte)value, cancellationToken);
			IL_119:
			return writer.WriteValueAsync((value == null) ? null : new sbyte?((sbyte)value), cancellationToken);
			IL_13A:
			return writer.WriteValueAsync((short)value, cancellationToken);
			IL_148:
			return writer.WriteValueAsync((value == null) ? null : new short?((short)value), cancellationToken);
			IL_16A:
			return writer.WriteValueAsync((ushort)value, cancellationToken);
			IL_178:
			return writer.WriteValueAsync((value == null) ? null : new ushort?((ushort)value), cancellationToken);
			IL_19A:
			return writer.WriteValueAsync((int)value, cancellationToken);
			IL_1A8:
			return writer.WriteValueAsync((value == null) ? null : new int?((int)value), cancellationToken);
			IL_1CA:
			return writer.WriteValueAsync((byte)value, cancellationToken);
			IL_1D8:
			return writer.WriteValueAsync((value == null) ? null : new byte?((byte)value), cancellationToken);
			IL_1FA:
			return writer.WriteValueAsync((uint)value, cancellationToken);
			IL_208:
			return writer.WriteValueAsync((value == null) ? null : new uint?((uint)value), cancellationToken);
			IL_22A:
			return writer.WriteValueAsync((long)value, cancellationToken);
			IL_238:
			return writer.WriteValueAsync((value == null) ? null : new long?((long)value), cancellationToken);
			IL_25A:
			return writer.WriteValueAsync((ulong)value, cancellationToken);
			IL_268:
			return writer.WriteValueAsync((value == null) ? null : new ulong?((ulong)value), cancellationToken);
			IL_28A:
			return writer.WriteValueAsync((float)value, cancellationToken);
			IL_298:
			return writer.WriteValueAsync((value == null) ? null : new float?((float)value), cancellationToken);
			IL_2BA:
			return writer.WriteValueAsync((double)value, cancellationToken);
			IL_2C8:
			return writer.WriteValueAsync((value == null) ? null : new double?((double)value), cancellationToken);
			IL_2EA:
			return writer.WriteValueAsync((global::System.DateTime)value, cancellationToken);
			IL_2F8:
			return writer.WriteValueAsync((value == null) ? null : new global::System.DateTime?((global::System.DateTime)value), cancellationToken);
			IL_31A:
			return writer.WriteValueAsync((global::System.DateTimeOffset)value, cancellationToken);
			IL_328:
			return writer.WriteValueAsync((value == null) ? null : new global::System.DateTimeOffset?((global::System.DateTimeOffset)value), cancellationToken);
			IL_34A:
			return writer.WriteValueAsync((decimal)value, cancellationToken);
			IL_358:
			return writer.WriteValueAsync((value == null) ? null : new decimal?((decimal)value), cancellationToken);
			IL_37A:
			return writer.WriteValueAsync((global::System.Guid)value, cancellationToken);
			IL_388:
			return writer.WriteValueAsync((value == null) ? null : new global::System.Guid?((global::System.Guid)value), cancellationToken);
			IL_3AA:
			return writer.WriteValueAsync((global::System.TimeSpan)value, cancellationToken);
			IL_3B8:
			return writer.WriteValueAsync((value == null) ? null : new global::System.TimeSpan?((global::System.TimeSpan)value), cancellationToken);
			IL_3DA:
			return writer.WriteValueAsync((global::System.Numerics.BigInteger)value, cancellationToken);
			IL_3ED:
			return writer.WriteValueAsync((value == null) ? null : new global::System.Numerics.BigInteger?((global::System.Numerics.BigInteger)value), cancellationToken);
			IL_414:
			return writer.WriteValueAsync((global::System.Uri)value, cancellationToken);
			IL_422:
			return writer.WriteValueAsync((string)value, cancellationToken);
			IL_430:
			return writer.WriteValueAsync((byte[])value, cancellationToken);
			IL_43E:
			return writer.WriteNullAsync(cancellationToken);
			IL_45F:
			if (value == null)
			{
				return writer.WriteNullAsync(cancellationToken);
			}
			throw global::Newtonsoft.Json.JsonWriter.CreateUnsupportedTypeException(writer, value);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		internal static global::Newtonsoft.Json.JsonWriter.State[][] BuildStateArray()
		{
			global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonWriter.State[]> list = global::Newtonsoft.Json.JsonWriter.StateArrayTemplate.ToList<global::Newtonsoft.Json.JsonWriter.State[]>();
			global::Newtonsoft.Json.JsonWriter.State[] item = global::Newtonsoft.Json.JsonWriter.StateArrayTemplate[0];
			global::Newtonsoft.Json.JsonWriter.State[] item2 = global::Newtonsoft.Json.JsonWriter.StateArrayTemplate[7];
			foreach (ulong num in global::Newtonsoft.Json.Utilities.EnumUtils.GetEnumValuesAndNames(typeof(global::Newtonsoft.Json.JsonToken)).Values)
			{
				if (list.Count <= (int)num)
				{
					global::Newtonsoft.Json.JsonToken jsonToken = (global::Newtonsoft.Json.JsonToken)num;
					if (jsonToken - global::Newtonsoft.Json.JsonToken.Integer <= 5 || jsonToken - global::Newtonsoft.Json.JsonToken.Date <= 1)
					{
						list.Add(item2);
					}
					else
					{
						list.Add(item);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000EA74 File Offset: 0x0000CC74
		static JsonWriter()
		{
			global::Newtonsoft.Json.JsonWriter.StateArray = global::Newtonsoft.Json.JsonWriter.BuildStateArray();
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000EB3E File Offset: 0x0000CD3E
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000EB46 File Offset: 0x0000CD46
		public bool CloseOutput { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000EB4F File Offset: 0x0000CD4F
		// (set) Token: 0x0600039F RID: 927 RVA: 0x0000EB57 File Offset: 0x0000CD57
		public bool AutoCompleteOnClose { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000EB60 File Offset: 0x0000CD60
		protected internal int Top
		{
			get
			{
				global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition> stack = this._stack;
				int num = (stack != null) ? stack.Count : 0;
				if (this.Peek() != global::Newtonsoft.Json.JsonContainerType.None)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000EB90 File Offset: 0x0000CD90
		public global::Newtonsoft.Json.WriteState WriteState
		{
			get
			{
				switch (this._currentState)
				{
				case global::Newtonsoft.Json.JsonWriter.State.Start:
					return global::Newtonsoft.Json.WriteState.Start;
				case global::Newtonsoft.Json.JsonWriter.State.Property:
					return global::Newtonsoft.Json.WriteState.Property;
				case global::Newtonsoft.Json.JsonWriter.State.ObjectStart:
				case global::Newtonsoft.Json.JsonWriter.State.Object:
					return global::Newtonsoft.Json.WriteState.Object;
				case global::Newtonsoft.Json.JsonWriter.State.ArrayStart:
				case global::Newtonsoft.Json.JsonWriter.State.Array:
					return global::Newtonsoft.Json.WriteState.Array;
				case global::Newtonsoft.Json.JsonWriter.State.ConstructorStart:
				case global::Newtonsoft.Json.JsonWriter.State.Constructor:
					return global::Newtonsoft.Json.WriteState.Constructor;
				case global::Newtonsoft.Json.JsonWriter.State.Closed:
					return global::Newtonsoft.Json.WriteState.Closed;
				case global::Newtonsoft.Json.JsonWriter.State.Error:
					return global::Newtonsoft.Json.WriteState.Error;
				default:
					throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Invalid state: " + this._currentState.ToString(), null);
				}
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000EC04 File Offset: 0x0000CE04
		internal string ContainerPath
		{
			get
			{
				if (this._currentPosition.Type == global::Newtonsoft.Json.JsonContainerType.None || this._stack == null)
				{
					return string.Empty;
				}
				return global::Newtonsoft.Json.JsonPosition.BuildPath(this._stack, null);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000EC40 File Offset: 0x0000CE40
		public string Path
		{
			get
			{
				if (this._currentPosition.Type == global::Newtonsoft.Json.JsonContainerType.None)
				{
					return string.Empty;
				}
				global::Newtonsoft.Json.JsonPosition? currentPosition = (this._currentState != global::Newtonsoft.Json.JsonWriter.State.ArrayStart && this._currentState != global::Newtonsoft.Json.JsonWriter.State.ConstructorStart && this._currentState != global::Newtonsoft.Json.JsonWriter.State.ObjectStart) ? new global::Newtonsoft.Json.JsonPosition?(this._currentPosition) : null;
				return global::Newtonsoft.Json.JsonPosition.BuildPath(this._stack, currentPosition);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000ECA6 File Offset: 0x0000CEA6
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x0000ECAE File Offset: 0x0000CEAE
		public global::Newtonsoft.Json.Formatting Formatting
		{
			get
			{
				return this._formatting;
			}
			set
			{
				if (value < global::Newtonsoft.Json.Formatting.None || value > global::Newtonsoft.Json.Formatting.Indented)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._formatting = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000ECCA File Offset: 0x0000CECA
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x0000ECD2 File Offset: 0x0000CED2
		public global::Newtonsoft.Json.DateFormatHandling DateFormatHandling
		{
			get
			{
				return this._dateFormatHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat || value > global::Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._dateFormatHandling = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000ECEE File Offset: 0x0000CEEE
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x0000ECF6 File Offset: 0x0000CEF6
		public global::Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				return this._dateTimeZoneHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.DateTimeZoneHandling.Local || value > global::Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._dateTimeZoneHandling = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000ED12 File Offset: 0x0000CF12
		// (set) Token: 0x060003AB RID: 939 RVA: 0x0000ED1A File Offset: 0x0000CF1A
		public global::Newtonsoft.Json.StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return this._stringEscapeHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.StringEscapeHandling.Default || value > global::Newtonsoft.Json.StringEscapeHandling.EscapeHtml)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._stringEscapeHandling = value;
				this.OnStringEscapeHandlingChanged();
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000ED3C File Offset: 0x0000CF3C
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003AD RID: 941 RVA: 0x0000ED3E File Offset: 0x0000CF3E
		// (set) Token: 0x060003AE RID: 942 RVA: 0x0000ED46 File Offset: 0x0000CF46
		public global::Newtonsoft.Json.FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return this._floatFormatHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.FloatFormatHandling.String || value > global::Newtonsoft.Json.FloatFormatHandling.DefaultValue)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._floatFormatHandling = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003AF RID: 943 RVA: 0x0000ED62 File Offset: 0x0000CF62
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x0000ED6A File Offset: 0x0000CF6A
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public string DateFormatString
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this._dateFormatString;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				this._dateFormatString = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000ED73 File Offset: 0x0000CF73
		// (set) Token: 0x060003B2 RID: 946 RVA: 0x0000ED84 File Offset: 0x0000CF84
		public global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return this._culture ?? global::System.Globalization.CultureInfo.InvariantCulture;
			}
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x0000ED8D File Offset: 0x0000CF8D
		protected JsonWriter()
		{
			this._currentState = global::Newtonsoft.Json.JsonWriter.State.Start;
			this._formatting = global::Newtonsoft.Json.Formatting.None;
			this._dateTimeZoneHandling = global::Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
			this.CloseOutput = true;
			this.AutoCompleteOnClose = true;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000EDB8 File Offset: 0x0000CFB8
		internal void UpdateScopeWithFinishedValue()
		{
			if (this._currentPosition.HasIndex)
			{
				this._currentPosition.Position = this._currentPosition.Position + 1;
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000EDD7 File Offset: 0x0000CFD7
		private void Push(global::Newtonsoft.Json.JsonContainerType value)
		{
			if (this._currentPosition.Type != global::Newtonsoft.Json.JsonContainerType.None)
			{
				if (this._stack == null)
				{
					this._stack = new global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition>();
				}
				this._stack.Add(this._currentPosition);
			}
			this._currentPosition = new global::Newtonsoft.Json.JsonPosition(value);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000EE18 File Offset: 0x0000D018
		private global::Newtonsoft.Json.JsonContainerType Pop()
		{
			ref global::Newtonsoft.Json.JsonPosition currentPosition = this._currentPosition;
			if (this._stack != null && this._stack.Count > 0)
			{
				this._currentPosition = this._stack[this._stack.Count - 1];
				this._stack.RemoveAt(this._stack.Count - 1);
			}
			else
			{
				this._currentPosition = default(global::Newtonsoft.Json.JsonPosition);
			}
			return currentPosition.Type;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000EE8A File Offset: 0x0000D08A
		private global::Newtonsoft.Json.JsonContainerType Peek()
		{
			return this._currentPosition.Type;
		}

		// Token: 0x060003B8 RID: 952
		public abstract void Flush();

		// Token: 0x060003B9 RID: 953 RVA: 0x0000EE97 File Offset: 0x0000D097
		public virtual void Close()
		{
			if (this.AutoCompleteOnClose)
			{
				this.AutoCompleteAll();
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000EEA7 File Offset: 0x0000D0A7
		public virtual void WriteStartObject()
		{
			this.InternalWriteStart(global::Newtonsoft.Json.JsonToken.StartObject, global::Newtonsoft.Json.JsonContainerType.Object);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000EEB1 File Offset: 0x0000D0B1
		public virtual void WriteEndObject()
		{
			this.InternalWriteEnd(global::Newtonsoft.Json.JsonContainerType.Object);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000EEBA File Offset: 0x0000D0BA
		public virtual void WriteStartArray()
		{
			this.InternalWriteStart(global::Newtonsoft.Json.JsonToken.StartArray, global::Newtonsoft.Json.JsonContainerType.Array);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000EEC4 File Offset: 0x0000D0C4
		public virtual void WriteEndArray()
		{
			this.InternalWriteEnd(global::Newtonsoft.Json.JsonContainerType.Array);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000EECD File Offset: 0x0000D0CD
		public virtual void WriteStartConstructor(string name)
		{
			this.InternalWriteStart(global::Newtonsoft.Json.JsonToken.StartConstructor, global::Newtonsoft.Json.JsonContainerType.Constructor);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000EED7 File Offset: 0x0000D0D7
		public virtual void WriteEndConstructor()
		{
			this.InternalWriteEnd(global::Newtonsoft.Json.JsonContainerType.Constructor);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		public virtual void WritePropertyName(string name)
		{
			this.InternalWritePropertyName(name);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x0000EEE9 File Offset: 0x0000D0E9
		public virtual void WritePropertyName(string name, bool escape)
		{
			this.WritePropertyName(name);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000EEF2 File Offset: 0x0000D0F2
		public virtual void WriteEnd()
		{
			this.WriteEnd(this.Peek());
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000EF00 File Offset: 0x0000D100
		public void WriteToken(global::Newtonsoft.Json.JsonReader reader)
		{
			this.WriteToken(reader, true);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0000EF0A File Offset: 0x0000D10A
		public void WriteToken(global::Newtonsoft.Json.JsonReader reader, bool writeChildren)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(reader, "reader");
			this.WriteToken(reader, writeChildren, true, true);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000EF24 File Offset: 0x0000D124
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public void WriteToken(global::Newtonsoft.Json.JsonToken token, object value)
		{
			switch (token)
			{
			case global::Newtonsoft.Json.JsonToken.None:
				return;
			case global::Newtonsoft.Json.JsonToken.StartObject:
				this.WriteStartObject();
				return;
			case global::Newtonsoft.Json.JsonToken.StartArray:
				this.WriteStartArray();
				return;
			case global::Newtonsoft.Json.JsonToken.StartConstructor:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				this.WriteStartConstructor(value.ToString());
				return;
			case global::Newtonsoft.Json.JsonToken.PropertyName:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				this.WritePropertyName(value.ToString());
				return;
			case global::Newtonsoft.Json.JsonToken.Comment:
				this.WriteComment((value != null) ? value.ToString() : null);
				return;
			case global::Newtonsoft.Json.JsonToken.Raw:
				this.WriteRawValue((value != null) ? value.ToString() : null);
				return;
			case global::Newtonsoft.Json.JsonToken.Integer:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				if (value is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger bigInteger = (global::System.Numerics.BigInteger)value;
					this.WriteValue(bigInteger);
					return;
				}
				this.WriteValue(global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			case global::Newtonsoft.Json.JsonToken.Float:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				if (value is decimal)
				{
					decimal value2 = (decimal)value;
					this.WriteValue(value2);
					return;
				}
				if (value is double)
				{
					double value3 = (double)value;
					this.WriteValue(value3);
					return;
				}
				if (value is float)
				{
					float value4 = (float)value;
					this.WriteValue(value4);
					return;
				}
				this.WriteValue(global::System.Convert.ToDouble(value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			case global::Newtonsoft.Json.JsonToken.String:
				this.WriteValue((value != null) ? value.ToString() : null);
				return;
			case global::Newtonsoft.Json.JsonToken.Boolean:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				this.WriteValue(global::System.Convert.ToBoolean(value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			case global::Newtonsoft.Json.JsonToken.Null:
				this.WriteNull();
				return;
			case global::Newtonsoft.Json.JsonToken.Undefined:
				this.WriteUndefined();
				return;
			case global::Newtonsoft.Json.JsonToken.EndObject:
				this.WriteEndObject();
				return;
			case global::Newtonsoft.Json.JsonToken.EndArray:
				this.WriteEndArray();
				return;
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				this.WriteEndConstructor();
				return;
			case global::Newtonsoft.Json.JsonToken.Date:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				if (value is global::System.DateTimeOffset)
				{
					global::System.DateTimeOffset value5 = (global::System.DateTimeOffset)value;
					this.WriteValue(value5);
					return;
				}
				this.WriteValue(global::System.Convert.ToDateTime(value, global::System.Globalization.CultureInfo.InvariantCulture));
				return;
			case global::Newtonsoft.Json.JsonToken.Bytes:
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				if (value is global::System.Guid)
				{
					global::System.Guid value6 = (global::System.Guid)value;
					this.WriteValue(value6);
					return;
				}
				this.WriteValue((byte[])value);
				return;
			default:
				throw global::Newtonsoft.Json.Utilities.MiscellaneousUtils.CreateArgumentOutOfRangeException("token", token, "Unexpected token type.");
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0000F153 File Offset: 0x0000D353
		public void WriteToken(global::Newtonsoft.Json.JsonToken token)
		{
			this.WriteToken(token, null);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000F160 File Offset: 0x0000D360
		internal virtual void WriteToken(global::Newtonsoft.Json.JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
			int num = this.CalculateWriteTokenInitialDepth(reader);
			for (;;)
			{
				if (!writeDateConstructorAsDate || reader.TokenType != global::Newtonsoft.Json.JsonToken.StartConstructor)
				{
					goto IL_3C;
				}
				object value = reader.Value;
				if (!string.Equals((value != null) ? value.ToString() : null, "Date", global::System.StringComparison.Ordinal))
				{
					goto IL_3C;
				}
				this.WriteConstructorDate(reader);
				IL_5B:
				if (num - 1 >= reader.Depth - (global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsEndToken(reader.TokenType) ? 1 : 0) || !writeChildren || !reader.Read())
				{
					break;
				}
				continue;
				IL_3C:
				if (writeComments || reader.TokenType != global::Newtonsoft.Json.JsonToken.Comment)
				{
					this.WriteToken(reader.TokenType, reader.Value);
					goto IL_5B;
				}
				goto IL_5B;
			}
			if (this.IsWriteTokenIncomplete(reader, writeChildren, num))
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Unexpected end when reading token.", null);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000F20C File Offset: 0x0000D40C
		private bool IsWriteTokenIncomplete(global::Newtonsoft.Json.JsonReader reader, bool writeChildren, int initialDepth)
		{
			int num = this.CalculateWriteTokenFinalDepth(reader);
			return initialDepth < num || (writeChildren && initialDepth == num && global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsStartToken(reader.TokenType));
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000F23C File Offset: 0x0000D43C
		private int CalculateWriteTokenInitialDepth(global::Newtonsoft.Json.JsonReader reader)
		{
			global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
			if (tokenType == global::Newtonsoft.Json.JsonToken.None)
			{
				return -1;
			}
			if (!global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsStartToken(tokenType))
			{
				return reader.Depth + 1;
			}
			return reader.Depth;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000F26C File Offset: 0x0000D46C
		private int CalculateWriteTokenFinalDepth(global::Newtonsoft.Json.JsonReader reader)
		{
			global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
			if (tokenType == global::Newtonsoft.Json.JsonToken.None)
			{
				return -1;
			}
			if (!global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsEndToken(tokenType))
			{
				return reader.Depth;
			}
			return reader.Depth - 1;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000F29C File Offset: 0x0000D49C
		private void WriteConstructorDate(global::Newtonsoft.Json.JsonReader reader)
		{
			global::System.DateTime value;
			string message;
			if (!global::Newtonsoft.Json.Utilities.JavaScriptUtils.TryGetDateFromConstructorJson(reader, out value, out message))
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, message, null);
			}
			this.WriteValue(value);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000F2C8 File Offset: 0x0000D4C8
		private void WriteEnd(global::Newtonsoft.Json.JsonContainerType type)
		{
			switch (type)
			{
			case global::Newtonsoft.Json.JsonContainerType.Object:
				this.WriteEndObject();
				return;
			case global::Newtonsoft.Json.JsonContainerType.Array:
				this.WriteEndArray();
				return;
			case global::Newtonsoft.Json.JsonContainerType.Constructor:
				this.WriteEndConstructor();
				return;
			default:
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Unexpected type when writing end: " + type.ToString(), null);
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000F31E File Offset: 0x0000D51E
		private void AutoCompleteAll()
		{
			while (this.Top > 0)
			{
				this.WriteEnd();
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000F331 File Offset: 0x0000D531
		private global::Newtonsoft.Json.JsonToken GetCloseTokenForType(global::Newtonsoft.Json.JsonContainerType type)
		{
			switch (type)
			{
			case global::Newtonsoft.Json.JsonContainerType.Object:
				return global::Newtonsoft.Json.JsonToken.EndObject;
			case global::Newtonsoft.Json.JsonContainerType.Array:
				return global::Newtonsoft.Json.JsonToken.EndArray;
			case global::Newtonsoft.Json.JsonContainerType.Constructor:
				return global::Newtonsoft.Json.JsonToken.EndConstructor;
			default:
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "No close token for type: " + type.ToString(), null);
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000F370 File Offset: 0x0000D570
		private void AutoCompleteClose(global::Newtonsoft.Json.JsonContainerType type)
		{
			int num = this.CalculateLevelsToComplete(type);
			for (int i = 0; i < num; i++)
			{
				global::Newtonsoft.Json.JsonToken closeTokenForType = this.GetCloseTokenForType(this.Pop());
				if (this._currentState == global::Newtonsoft.Json.JsonWriter.State.Property)
				{
					this.WriteNull();
				}
				if (this._formatting == global::Newtonsoft.Json.Formatting.Indented && this._currentState != global::Newtonsoft.Json.JsonWriter.State.ObjectStart && this._currentState != global::Newtonsoft.Json.JsonWriter.State.ArrayStart)
				{
					this.WriteIndent();
				}
				this.WriteEnd(closeTokenForType);
				this.UpdateCurrentState();
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000F3DC File Offset: 0x0000D5DC
		private int CalculateLevelsToComplete(global::Newtonsoft.Json.JsonContainerType type)
		{
			int num = 0;
			if (this._currentPosition.Type == type)
			{
				num = 1;
			}
			else
			{
				int num2 = this.Top - 2;
				for (int i = num2; i >= 0; i--)
				{
					int index = num2 - i;
					if (this._stack[index].Type == type)
					{
						num = i + 2;
						break;
					}
				}
			}
			if (num == 0)
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "No token to close.", null);
			}
			return num;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0000F444 File Offset: 0x0000D644
		private void UpdateCurrentState()
		{
			global::Newtonsoft.Json.JsonContainerType jsonContainerType = this.Peek();
			switch (jsonContainerType)
			{
			case global::Newtonsoft.Json.JsonContainerType.None:
				this._currentState = global::Newtonsoft.Json.JsonWriter.State.Start;
				return;
			case global::Newtonsoft.Json.JsonContainerType.Object:
				this._currentState = global::Newtonsoft.Json.JsonWriter.State.Object;
				return;
			case global::Newtonsoft.Json.JsonContainerType.Array:
				this._currentState = global::Newtonsoft.Json.JsonWriter.State.Array;
				return;
			case global::Newtonsoft.Json.JsonContainerType.Constructor:
				this._currentState = global::Newtonsoft.Json.JsonWriter.State.Array;
				return;
			default:
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Unknown JsonType: " + jsonContainerType.ToString(), null);
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000F4AE File Offset: 0x0000D6AE
		protected virtual void WriteEnd(global::Newtonsoft.Json.JsonToken token)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000F4B0 File Offset: 0x0000D6B0
		protected virtual void WriteIndent()
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0000F4B2 File Offset: 0x0000D6B2
		protected virtual void WriteValueDelimiter()
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000F4B4 File Offset: 0x0000D6B4
		protected virtual void WriteIndentSpace()
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		internal void AutoComplete(global::Newtonsoft.Json.JsonToken tokenBeingWritten)
		{
			global::Newtonsoft.Json.JsonWriter.State state = global::Newtonsoft.Json.JsonWriter.StateArray[(int)tokenBeingWritten][(int)this._currentState];
			if (state == global::Newtonsoft.Json.JsonWriter.State.Error)
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Token {0} in state {1} would result in an invalid JSON object.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, tokenBeingWritten.ToString(), this._currentState.ToString()), null);
			}
			if ((this._currentState == global::Newtonsoft.Json.JsonWriter.State.Object || this._currentState == global::Newtonsoft.Json.JsonWriter.State.Array || this._currentState == global::Newtonsoft.Json.JsonWriter.State.Constructor) && tokenBeingWritten != global::Newtonsoft.Json.JsonToken.Comment)
			{
				this.WriteValueDelimiter();
			}
			if (this._formatting == global::Newtonsoft.Json.Formatting.Indented)
			{
				if (this._currentState == global::Newtonsoft.Json.JsonWriter.State.Property)
				{
					this.WriteIndentSpace();
				}
				if (this._currentState == global::Newtonsoft.Json.JsonWriter.State.Array || this._currentState == global::Newtonsoft.Json.JsonWriter.State.ArrayStart || this._currentState == global::Newtonsoft.Json.JsonWriter.State.Constructor || this._currentState == global::Newtonsoft.Json.JsonWriter.State.ConstructorStart || (tokenBeingWritten == global::Newtonsoft.Json.JsonToken.PropertyName && this._currentState != global::Newtonsoft.Json.JsonWriter.State.Start))
				{
					this.WriteIndent();
				}
			}
			this._currentState = state;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000F588 File Offset: 0x0000D788
		public virtual void WriteNull()
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Null);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000F592 File Offset: 0x0000D792
		public virtual void WriteUndefined()
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Undefined);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000F59C File Offset: 0x0000D79C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual void WriteRaw(string json)
		{
			this.InternalWriteRaw();
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual void WriteRawValue(string json)
		{
			this.UpdateScopeWithFinishedValue();
			this.AutoComplete(global::Newtonsoft.Json.JsonToken.Undefined);
			this.WriteRaw(json);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000F5BB File Offset: 0x0000D7BB
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual void WriteValue(string value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000F5C5 File Offset: 0x0000D7C5
		public virtual void WriteValue(int value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000F5CE File Offset: 0x0000D7CE
		[global::System.CLSCompliant(false)]
		public virtual void WriteValue(uint value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000F5D7 File Offset: 0x0000D7D7
		public virtual void WriteValue(long value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		[global::System.CLSCompliant(false)]
		public virtual void WriteValue(ulong value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000F5E9 File Offset: 0x0000D7E9
		public virtual void WriteValue(float value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Float);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000F5F2 File Offset: 0x0000D7F2
		public virtual void WriteValue(double value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Float);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000F5FB File Offset: 0x0000D7FB
		public virtual void WriteValue(bool value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Boolean);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000F605 File Offset: 0x0000D805
		public virtual void WriteValue(short value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000F60E File Offset: 0x0000D80E
		[global::System.CLSCompliant(false)]
		public virtual void WriteValue(ushort value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000F617 File Offset: 0x0000D817
		public virtual void WriteValue(char value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000F621 File Offset: 0x0000D821
		public virtual void WriteValue(byte value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000F62A File Offset: 0x0000D82A
		[global::System.CLSCompliant(false)]
		public virtual void WriteValue(sbyte value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Integer);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000F633 File Offset: 0x0000D833
		public virtual void WriteValue(decimal value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Float);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000F63C File Offset: 0x0000D83C
		public virtual void WriteValue(global::System.DateTime value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Date);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000F646 File Offset: 0x0000D846
		public virtual void WriteValue(global::System.DateTimeOffset value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Date);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000F650 File Offset: 0x0000D850
		public virtual void WriteValue(global::System.Guid value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000F65A File Offset: 0x0000D85A
		public virtual void WriteValue(global::System.TimeSpan value)
		{
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000F664 File Offset: 0x0000D864
		public virtual void WriteValue(int? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000F683 File Offset: 0x0000D883
		[global::System.CLSCompliant(false)]
		public virtual void WriteValue(uint? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000F6A2 File Offset: 0x0000D8A2
		public virtual void WriteValue(long? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000F6C1 File Offset: 0x0000D8C1
		[global::System.CLSCompliant(false)]
		public virtual void WriteValue(ulong? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0000F6E0 File Offset: 0x0000D8E0
		public virtual void WriteValue(float? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000F6FF File Offset: 0x0000D8FF
		public virtual void WriteValue(double? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000F71E File Offset: 0x0000D91E
		public virtual void WriteValue(bool? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000F73D File Offset: 0x0000D93D
		public virtual void WriteValue(short? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000F75C File Offset: 0x0000D95C
		[global::System.CLSCompliant(false)]
		public virtual void WriteValue(ushort? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000F77B File Offset: 0x0000D97B
		public virtual void WriteValue(char? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000F79A File Offset: 0x0000D99A
		public virtual void WriteValue(byte? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000F7B9 File Offset: 0x0000D9B9
		[global::System.CLSCompliant(false)]
		public virtual void WriteValue(sbyte? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		public virtual void WriteValue(decimal? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000F7F7 File Offset: 0x0000D9F7
		public virtual void WriteValue(global::System.DateTime? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000F816 File Offset: 0x0000DA16
		public virtual void WriteValue(global::System.DateTimeOffset? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000F835 File Offset: 0x0000DA35
		public virtual void WriteValue(global::System.Guid? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000F854 File Offset: 0x0000DA54
		public virtual void WriteValue(global::System.TimeSpan? value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.WriteValue(value.GetValueOrDefault());
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000F873 File Offset: 0x0000DA73
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual void WriteValue(byte[] value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.Bytes);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000F887 File Offset: 0x0000DA87
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual void WriteValue(global::System.Uri value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			this.InternalWriteValue(global::Newtonsoft.Json.JsonToken.String);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000F8A1 File Offset: 0x0000DAA1
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual void WriteValue(object value)
		{
			if (value == null)
			{
				this.WriteNull();
				return;
			}
			if (value is global::System.Numerics.BigInteger)
			{
				throw global::Newtonsoft.Json.JsonWriter.CreateUnsupportedTypeException(this, value);
			}
			global::Newtonsoft.Json.JsonWriter.WriteValue(this, global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(value.GetType()), value);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000F8CF File Offset: 0x0000DACF
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public virtual void WriteComment(string text)
		{
			this.InternalWriteComment();
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000F8D7 File Offset: 0x0000DAD7
		public virtual void WriteWhitespace(string ws)
		{
			this.InternalWriteWhitespace(ws);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		void global::System.IDisposable.Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0000F8EF File Offset: 0x0000DAEF
		protected virtual void Dispose(bool disposing)
		{
			if (this._currentState != global::Newtonsoft.Json.JsonWriter.State.Closed && disposing)
			{
				this.Close();
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000F908 File Offset: 0x0000DB08
		internal static void WriteValue(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, object value)
		{
			for (;;)
			{
				switch (typeCode)
				{
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char:
					goto IL_AD;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.CharNullable:
					goto IL_BA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean:
					goto IL_DA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BooleanNullable:
					goto IL_E7;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte:
					goto IL_107;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByteNullable:
					goto IL_114;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16:
					goto IL_134;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16Nullable:
					goto IL_141;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16:
					goto IL_162;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16Nullable:
					goto IL_16F;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32:
					goto IL_190;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32Nullable:
					goto IL_19D;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte:
					goto IL_1BE;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.ByteNullable:
					goto IL_1CB;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32:
					goto IL_1EC;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32Nullable:
					goto IL_1F9;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64:
					goto IL_21A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64Nullable:
					goto IL_227;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64:
					goto IL_248;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64Nullable:
					goto IL_255;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single:
					goto IL_276;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SingleNullable:
					goto IL_283;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double:
					goto IL_2A4;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DoubleNullable:
					goto IL_2B1;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime:
					goto IL_2D2;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeNullable:
					goto IL_2DF;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset:
					goto IL_300;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffsetNullable:
					goto IL_30D;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Decimal:
					goto IL_32E;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DecimalNullable:
					goto IL_33B;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Guid:
					goto IL_35C;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.GuidNullable:
					goto IL_369;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpan:
					goto IL_38A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpanNullable:
					goto IL_397;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigInteger:
					goto IL_3B8;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigIntegerNullable:
					goto IL_3CA;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Uri:
					goto IL_3F0;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.String:
					goto IL_3FD;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Bytes:
					goto IL_40A;
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DBNull:
					goto IL_417;
				default:
				{
					global::System.IConvertible convertible = value as global::System.IConvertible;
					if (convertible == null)
					{
						goto IL_437;
					}
					global::Newtonsoft.Json.JsonWriter.ResolveConvertibleValue(convertible, out typeCode, out value);
					break;
				}
				}
			}
			IL_AD:
			writer.WriteValue((char)value);
			return;
			IL_BA:
			writer.WriteValue((value == null) ? null : new char?((char)value));
			return;
			IL_DA:
			writer.WriteValue((bool)value);
			return;
			IL_E7:
			writer.WriteValue((value == null) ? null : new bool?((bool)value));
			return;
			IL_107:
			writer.WriteValue((sbyte)value);
			return;
			IL_114:
			writer.WriteValue((value == null) ? null : new sbyte?((sbyte)value));
			return;
			IL_134:
			writer.WriteValue((short)value);
			return;
			IL_141:
			writer.WriteValue((value == null) ? null : new short?((short)value));
			return;
			IL_162:
			writer.WriteValue((ushort)value);
			return;
			IL_16F:
			writer.WriteValue((value == null) ? null : new ushort?((ushort)value));
			return;
			IL_190:
			writer.WriteValue((int)value);
			return;
			IL_19D:
			writer.WriteValue((value == null) ? null : new int?((int)value));
			return;
			IL_1BE:
			writer.WriteValue((byte)value);
			return;
			IL_1CB:
			writer.WriteValue((value == null) ? null : new byte?((byte)value));
			return;
			IL_1EC:
			writer.WriteValue((uint)value);
			return;
			IL_1F9:
			writer.WriteValue((value == null) ? null : new uint?((uint)value));
			return;
			IL_21A:
			writer.WriteValue((long)value);
			return;
			IL_227:
			writer.WriteValue((value == null) ? null : new long?((long)value));
			return;
			IL_248:
			writer.WriteValue((ulong)value);
			return;
			IL_255:
			writer.WriteValue((value == null) ? null : new ulong?((ulong)value));
			return;
			IL_276:
			writer.WriteValue((float)value);
			return;
			IL_283:
			writer.WriteValue((value == null) ? null : new float?((float)value));
			return;
			IL_2A4:
			writer.WriteValue((double)value);
			return;
			IL_2B1:
			writer.WriteValue((value == null) ? null : new double?((double)value));
			return;
			IL_2D2:
			writer.WriteValue((global::System.DateTime)value);
			return;
			IL_2DF:
			writer.WriteValue((value == null) ? null : new global::System.DateTime?((global::System.DateTime)value));
			return;
			IL_300:
			writer.WriteValue((global::System.DateTimeOffset)value);
			return;
			IL_30D:
			writer.WriteValue((value == null) ? null : new global::System.DateTimeOffset?((global::System.DateTimeOffset)value));
			return;
			IL_32E:
			writer.WriteValue((decimal)value);
			return;
			IL_33B:
			writer.WriteValue((value == null) ? null : new decimal?((decimal)value));
			return;
			IL_35C:
			writer.WriteValue((global::System.Guid)value);
			return;
			IL_369:
			writer.WriteValue((value == null) ? null : new global::System.Guid?((global::System.Guid)value));
			return;
			IL_38A:
			writer.WriteValue((global::System.TimeSpan)value);
			return;
			IL_397:
			writer.WriteValue((value == null) ? null : new global::System.TimeSpan?((global::System.TimeSpan)value));
			return;
			IL_3B8:
			writer.WriteValue((global::System.Numerics.BigInteger)value);
			return;
			IL_3CA:
			writer.WriteValue((value == null) ? null : new global::System.Numerics.BigInteger?((global::System.Numerics.BigInteger)value));
			return;
			IL_3F0:
			writer.WriteValue((global::System.Uri)value);
			return;
			IL_3FD:
			writer.WriteValue((string)value);
			return;
			IL_40A:
			writer.WriteValue((byte[])value);
			return;
			IL_417:
			writer.WriteNull();
			return;
			IL_437:
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			throw global::Newtonsoft.Json.JsonWriter.CreateUnsupportedTypeException(writer, value);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000FD60 File Offset: 0x0000DF60
		private static void ResolveConvertibleValue(global::System.IConvertible convertible, out global::Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode, out object value)
		{
			global::Newtonsoft.Json.Utilities.TypeInformation typeInformation = global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeInformation(convertible);
			typeCode = ((typeInformation.TypeCode == global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Object) ? global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.String : typeInformation.TypeCode);
			global::System.Type conversionType = (typeInformation.TypeCode == global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Object) ? typeof(string) : typeInformation.Type;
			value = convertible.ToType(conversionType, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000FDB3 File Offset: 0x0000DFB3
		private static global::Newtonsoft.Json.JsonWriterException CreateUnsupportedTypeException(global::Newtonsoft.Json.JsonWriter writer, object value)
		{
			return global::Newtonsoft.Json.JsonWriterException.Create(writer, "Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType()), null);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000FDD4 File Offset: 0x0000DFD4
		protected void SetWriteState(global::Newtonsoft.Json.JsonToken token, object value)
		{
			switch (token)
			{
			case global::Newtonsoft.Json.JsonToken.StartObject:
				this.InternalWriteStart(token, global::Newtonsoft.Json.JsonContainerType.Object);
				return;
			case global::Newtonsoft.Json.JsonToken.StartArray:
				this.InternalWriteStart(token, global::Newtonsoft.Json.JsonContainerType.Array);
				return;
			case global::Newtonsoft.Json.JsonToken.StartConstructor:
				this.InternalWriteStart(token, global::Newtonsoft.Json.JsonContainerType.Constructor);
				return;
			case global::Newtonsoft.Json.JsonToken.PropertyName:
			{
				string text = value as string;
				if (text == null)
				{
					throw new global::System.ArgumentException("A name is required when setting property name state.", "value");
				}
				this.InternalWritePropertyName(text);
				return;
			}
			case global::Newtonsoft.Json.JsonToken.Comment:
				this.InternalWriteComment();
				return;
			case global::Newtonsoft.Json.JsonToken.Raw:
				this.InternalWriteRaw();
				return;
			case global::Newtonsoft.Json.JsonToken.Integer:
			case global::Newtonsoft.Json.JsonToken.Float:
			case global::Newtonsoft.Json.JsonToken.String:
			case global::Newtonsoft.Json.JsonToken.Boolean:
			case global::Newtonsoft.Json.JsonToken.Null:
			case global::Newtonsoft.Json.JsonToken.Undefined:
			case global::Newtonsoft.Json.JsonToken.Date:
			case global::Newtonsoft.Json.JsonToken.Bytes:
				this.InternalWriteValue(token);
				return;
			case global::Newtonsoft.Json.JsonToken.EndObject:
				this.InternalWriteEnd(global::Newtonsoft.Json.JsonContainerType.Object);
				return;
			case global::Newtonsoft.Json.JsonToken.EndArray:
				this.InternalWriteEnd(global::Newtonsoft.Json.JsonContainerType.Array);
				return;
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				this.InternalWriteEnd(global::Newtonsoft.Json.JsonContainerType.Constructor);
				return;
			default:
				throw new global::System.ArgumentOutOfRangeException("token");
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000FEA4 File Offset: 0x0000E0A4
		internal void InternalWriteEnd(global::Newtonsoft.Json.JsonContainerType container)
		{
			this.AutoCompleteClose(container);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000FEAD File Offset: 0x0000E0AD
		internal void InternalWritePropertyName(string name)
		{
			this._currentPosition.PropertyName = name;
			this.AutoComplete(global::Newtonsoft.Json.JsonToken.PropertyName);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000FEC2 File Offset: 0x0000E0C2
		internal void InternalWriteRaw()
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000FEC4 File Offset: 0x0000E0C4
		internal void InternalWriteStart(global::Newtonsoft.Json.JsonToken token, global::Newtonsoft.Json.JsonContainerType container)
		{
			this.UpdateScopeWithFinishedValue();
			this.AutoComplete(token);
			this.Push(container);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000FEDA File Offset: 0x0000E0DA
		internal void InternalWriteValue(global::Newtonsoft.Json.JsonToken token)
		{
			this.UpdateScopeWithFinishedValue();
			this.AutoComplete(token);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000FEE9 File Offset: 0x0000E0E9
		internal void InternalWriteWhitespace(string ws)
		{
			if (ws != null && !global::Newtonsoft.Json.Utilities.StringUtils.IsWhiteSpace(ws))
			{
				throw global::Newtonsoft.Json.JsonWriterException.Create(this, "Only white space characters should be used.", null);
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000FF03 File Offset: 0x0000E103
		internal void InternalWriteComment()
		{
			this.AutoComplete(global::Newtonsoft.Json.JsonToken.Comment);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000FF0C File Offset: 0x0000E10C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Threading.Tasks.Task <InternalWriteEndAsync>g__AwaitProperty|11_0(global::System.Threading.Tasks.Task task, int LevelsToComplete, global::Newtonsoft.Json.JsonToken token, global::System.Threading.CancellationToken CancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d <<InternalWriteEndAsync>g__AwaitProperty|11_0>d;
			<<InternalWriteEndAsync>g__AwaitProperty|11_0>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<<InternalWriteEndAsync>g__AwaitProperty|11_0>d.<>4__this = this;
			<<InternalWriteEndAsync>g__AwaitProperty|11_0>d.task = task;
			<<InternalWriteEndAsync>g__AwaitProperty|11_0>d.LevelsToComplete = LevelsToComplete;
			<<InternalWriteEndAsync>g__AwaitProperty|11_0>d.token = token;
			<<InternalWriteEndAsync>g__AwaitProperty|11_0>d.CancellationToken = CancellationToken;
			<<InternalWriteEndAsync>g__AwaitProperty|11_0>d.<>1__state = -1;
			<<InternalWriteEndAsync>g__AwaitProperty|11_0>d.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<<InternalWriteEndAsync>g__AwaitProperty|11_0>d>(ref <<InternalWriteEndAsync>g__AwaitProperty|11_0>d);
			return <<InternalWriteEndAsync>g__AwaitProperty|11_0>d.<>t__builder.Task;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000FF70 File Offset: 0x0000E170
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Threading.Tasks.Task <InternalWriteEndAsync>g__AwaitIndent|11_1(global::System.Threading.Tasks.Task task, int LevelsToComplete, global::Newtonsoft.Json.JsonToken token, global::System.Threading.CancellationToken CancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d <<InternalWriteEndAsync>g__AwaitIndent|11_1>d;
			<<InternalWriteEndAsync>g__AwaitIndent|11_1>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<<InternalWriteEndAsync>g__AwaitIndent|11_1>d.<>4__this = this;
			<<InternalWriteEndAsync>g__AwaitIndent|11_1>d.task = task;
			<<InternalWriteEndAsync>g__AwaitIndent|11_1>d.LevelsToComplete = LevelsToComplete;
			<<InternalWriteEndAsync>g__AwaitIndent|11_1>d.token = token;
			<<InternalWriteEndAsync>g__AwaitIndent|11_1>d.CancellationToken = CancellationToken;
			<<InternalWriteEndAsync>g__AwaitIndent|11_1>d.<>1__state = -1;
			<<InternalWriteEndAsync>g__AwaitIndent|11_1>d.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<<InternalWriteEndAsync>g__AwaitIndent|11_1>d>(ref <<InternalWriteEndAsync>g__AwaitIndent|11_1>d);
			return <<InternalWriteEndAsync>g__AwaitIndent|11_1>d.<>t__builder.Task;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000FFD4 File Offset: 0x0000E1D4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Threading.Tasks.Task <InternalWriteEndAsync>g__AwaitEnd|11_2(global::System.Threading.Tasks.Task task, int LevelsToComplete, global::System.Threading.CancellationToken CancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d <<InternalWriteEndAsync>g__AwaitEnd|11_2>d;
			<<InternalWriteEndAsync>g__AwaitEnd|11_2>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<<InternalWriteEndAsync>g__AwaitEnd|11_2>d.<>4__this = this;
			<<InternalWriteEndAsync>g__AwaitEnd|11_2>d.task = task;
			<<InternalWriteEndAsync>g__AwaitEnd|11_2>d.LevelsToComplete = LevelsToComplete;
			<<InternalWriteEndAsync>g__AwaitEnd|11_2>d.CancellationToken = CancellationToken;
			<<InternalWriteEndAsync>g__AwaitEnd|11_2>d.<>1__state = -1;
			<<InternalWriteEndAsync>g__AwaitEnd|11_2>d.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<<InternalWriteEndAsync>g__AwaitEnd|11_2>d>(ref <<InternalWriteEndAsync>g__AwaitEnd|11_2>d);
			return <<InternalWriteEndAsync>g__AwaitEnd|11_2>d.<>t__builder.Task;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00010030 File Offset: 0x0000E230
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Threading.Tasks.Task <InternalWriteEndAsync>g__AwaitRemaining|11_3(int LevelsToComplete, global::System.Threading.CancellationToken CancellationToken)
		{
			global::Newtonsoft.Json.JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d <<InternalWriteEndAsync>g__AwaitRemaining|11_3>d;
			<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d.<>4__this = this;
			<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d.LevelsToComplete = LevelsToComplete;
			<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d.CancellationToken = CancellationToken;
			<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d.<>1__state = -1;
			<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d.<>t__builder.Start<global::Newtonsoft.Json.JsonWriter.<<InternalWriteEndAsync>g__AwaitRemaining|11_3>d>(ref <<InternalWriteEndAsync>g__AwaitRemaining|11_3>d);
			return <<InternalWriteEndAsync>g__AwaitRemaining|11_3>d.<>t__builder.Task;
		}

		// Token: 0x04000107 RID: 263
		private static readonly global::Newtonsoft.Json.JsonWriter.State[][] StateArray;

		// Token: 0x04000108 RID: 264
		internal static readonly global::Newtonsoft.Json.JsonWriter.State[][] StateArrayTemplate = new global::Newtonsoft.Json.JsonWriter.State[][]
		{
			new global::Newtonsoft.Json.JsonWriter.State[]
			{
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error
			},
			new global::Newtonsoft.Json.JsonWriter.State[]
			{
				global::Newtonsoft.Json.JsonWriter.State.ObjectStart,
				global::Newtonsoft.Json.JsonWriter.State.ObjectStart,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.ObjectStart,
				global::Newtonsoft.Json.JsonWriter.State.ObjectStart,
				global::Newtonsoft.Json.JsonWriter.State.ObjectStart,
				global::Newtonsoft.Json.JsonWriter.State.ObjectStart,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error
			},
			new global::Newtonsoft.Json.JsonWriter.State[]
			{
				global::Newtonsoft.Json.JsonWriter.State.ArrayStart,
				global::Newtonsoft.Json.JsonWriter.State.ArrayStart,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.ArrayStart,
				global::Newtonsoft.Json.JsonWriter.State.ArrayStart,
				global::Newtonsoft.Json.JsonWriter.State.ArrayStart,
				global::Newtonsoft.Json.JsonWriter.State.ArrayStart,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error
			},
			new global::Newtonsoft.Json.JsonWriter.State[]
			{
				global::Newtonsoft.Json.JsonWriter.State.ConstructorStart,
				global::Newtonsoft.Json.JsonWriter.State.ConstructorStart,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.ConstructorStart,
				global::Newtonsoft.Json.JsonWriter.State.ConstructorStart,
				global::Newtonsoft.Json.JsonWriter.State.ConstructorStart,
				global::Newtonsoft.Json.JsonWriter.State.ConstructorStart,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error
			},
			new global::Newtonsoft.Json.JsonWriter.State[]
			{
				global::Newtonsoft.Json.JsonWriter.State.Property,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Property,
				global::Newtonsoft.Json.JsonWriter.State.Property,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error
			},
			new global::Newtonsoft.Json.JsonWriter.State[]
			{
				global::Newtonsoft.Json.JsonWriter.State.Start,
				global::Newtonsoft.Json.JsonWriter.State.Property,
				global::Newtonsoft.Json.JsonWriter.State.ObjectStart,
				global::Newtonsoft.Json.JsonWriter.State.Object,
				global::Newtonsoft.Json.JsonWriter.State.ArrayStart,
				global::Newtonsoft.Json.JsonWriter.State.Array,
				global::Newtonsoft.Json.JsonWriter.State.Constructor,
				global::Newtonsoft.Json.JsonWriter.State.Constructor,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error
			},
			new global::Newtonsoft.Json.JsonWriter.State[]
			{
				global::Newtonsoft.Json.JsonWriter.State.Start,
				global::Newtonsoft.Json.JsonWriter.State.Property,
				global::Newtonsoft.Json.JsonWriter.State.ObjectStart,
				global::Newtonsoft.Json.JsonWriter.State.Object,
				global::Newtonsoft.Json.JsonWriter.State.ArrayStart,
				global::Newtonsoft.Json.JsonWriter.State.Array,
				global::Newtonsoft.Json.JsonWriter.State.Constructor,
				global::Newtonsoft.Json.JsonWriter.State.Constructor,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error
			},
			new global::Newtonsoft.Json.JsonWriter.State[]
			{
				global::Newtonsoft.Json.JsonWriter.State.Start,
				global::Newtonsoft.Json.JsonWriter.State.Object,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Array,
				global::Newtonsoft.Json.JsonWriter.State.Array,
				global::Newtonsoft.Json.JsonWriter.State.Constructor,
				global::Newtonsoft.Json.JsonWriter.State.Constructor,
				global::Newtonsoft.Json.JsonWriter.State.Error,
				global::Newtonsoft.Json.JsonWriter.State.Error
			}
		};

		// Token: 0x04000109 RID: 265
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition> _stack;

		// Token: 0x0400010A RID: 266
		private global::Newtonsoft.Json.JsonPosition _currentPosition;

		// Token: 0x0400010B RID: 267
		private global::Newtonsoft.Json.JsonWriter.State _currentState;

		// Token: 0x0400010C RID: 268
		private global::Newtonsoft.Json.Formatting _formatting;

		// Token: 0x0400010F RID: 271
		private global::Newtonsoft.Json.DateFormatHandling _dateFormatHandling;

		// Token: 0x04000110 RID: 272
		private global::Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x04000111 RID: 273
		private global::Newtonsoft.Json.StringEscapeHandling _stringEscapeHandling;

		// Token: 0x04000112 RID: 274
		private global::Newtonsoft.Json.FloatFormatHandling _floatFormatHandling;

		// Token: 0x04000113 RID: 275
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private string _dateFormatString;

		// Token: 0x04000114 RID: 276
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::System.Globalization.CultureInfo _culture;

		// Token: 0x02000157 RID: 343
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		internal enum State
		{
			// Token: 0x0400061A RID: 1562
			Start,
			// Token: 0x0400061B RID: 1563
			Property,
			// Token: 0x0400061C RID: 1564
			ObjectStart,
			// Token: 0x0400061D RID: 1565
			Object,
			// Token: 0x0400061E RID: 1566
			ArrayStart,
			// Token: 0x0400061F RID: 1567
			Array,
			// Token: 0x04000620 RID: 1568
			ConstructorStart,
			// Token: 0x04000621 RID: 1569
			Constructor,
			// Token: 0x04000622 RID: 1570
			Closed,
			// Token: 0x04000623 RID: 1571
			Error
		}
	}
}
