using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000027 RID: 39
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public abstract class JsonReader : global::System.IDisposable
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x000034EB File Offset: 0x000016EB
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public virtual global::System.Threading.Tasks.Task<bool> ReadAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return cancellationToken.CancelIfRequestedAsync<bool>() ?? this.Read().ToAsync();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003504 File Offset: 0x00001704
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public global::System.Threading.Tasks.Task SkipAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.JsonReader.<SkipAsync>d__1 <SkipAsync>d__;
			<SkipAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<SkipAsync>d__.<>4__this = this;
			<SkipAsync>d__.cancellationToken = cancellationToken;
			<SkipAsync>d__.<>1__state = -1;
			<SkipAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonReader.<SkipAsync>d__1>(ref <SkipAsync>d__);
			return <SkipAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003550 File Offset: 0x00001750
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal global::System.Threading.Tasks.Task ReaderReadAndAssertAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonReader.<ReaderReadAndAssertAsync>d__2 <ReaderReadAndAssertAsync>d__;
			<ReaderReadAndAssertAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			<ReaderReadAndAssertAsync>d__.<>4__this = this;
			<ReaderReadAndAssertAsync>d__.cancellationToken = cancellationToken;
			<ReaderReadAndAssertAsync>d__.<>1__state = -1;
			<ReaderReadAndAssertAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonReader.<ReaderReadAndAssertAsync>d__2>(ref <ReaderReadAndAssertAsync>d__);
			return <ReaderReadAndAssertAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000359B File Offset: 0x0000179B
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public virtual global::System.Threading.Tasks.Task<bool?> ReadAsBooleanAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return cancellationToken.CancelIfRequestedAsync<bool?>() ?? global::System.Threading.Tasks.Task.FromResult<bool?>(this.ReadAsBoolean());
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000035B2 File Offset: 0x000017B2
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public virtual global::System.Threading.Tasks.Task<byte[]> ReadAsBytesAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return cancellationToken.CancelIfRequestedAsync<byte[]>() ?? global::System.Threading.Tasks.Task.FromResult<byte[]>(this.ReadAsBytes());
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000035CC File Offset: 0x000017CC
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		internal global::System.Threading.Tasks.Task<byte[]> ReadArrayIntoByteArrayAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonReader.<ReadArrayIntoByteArrayAsync>d__5 <ReadArrayIntoByteArrayAsync>d__;
			<ReadArrayIntoByteArrayAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<byte[]>.Create();
			<ReadArrayIntoByteArrayAsync>d__.<>4__this = this;
			<ReadArrayIntoByteArrayAsync>d__.cancellationToken = cancellationToken;
			<ReadArrayIntoByteArrayAsync>d__.<>1__state = -1;
			<ReadArrayIntoByteArrayAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonReader.<ReadArrayIntoByteArrayAsync>d__5>(ref <ReadArrayIntoByteArrayAsync>d__);
			return <ReadArrayIntoByteArrayAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003617 File Offset: 0x00001817
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public virtual global::System.Threading.Tasks.Task<global::System.DateTime?> ReadAsDateTimeAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return cancellationToken.CancelIfRequestedAsync<global::System.DateTime?>() ?? global::System.Threading.Tasks.Task.FromResult<global::System.DateTime?>(this.ReadAsDateTime());
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000362E File Offset: 0x0000182E
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public virtual global::System.Threading.Tasks.Task<global::System.DateTimeOffset?> ReadAsDateTimeOffsetAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return cancellationToken.CancelIfRequestedAsync<global::System.DateTimeOffset?>() ?? global::System.Threading.Tasks.Task.FromResult<global::System.DateTimeOffset?>(this.ReadAsDateTimeOffset());
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003645 File Offset: 0x00001845
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public virtual global::System.Threading.Tasks.Task<decimal?> ReadAsDecimalAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return cancellationToken.CancelIfRequestedAsync<decimal?>() ?? global::System.Threading.Tasks.Task.FromResult<decimal?>(this.ReadAsDecimal());
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000365C File Offset: 0x0000185C
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public virtual global::System.Threading.Tasks.Task<double?> ReadAsDoubleAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return global::System.Threading.Tasks.Task.FromResult<double?>(this.ReadAsDouble());
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003669 File Offset: 0x00001869
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public virtual global::System.Threading.Tasks.Task<int?> ReadAsInt32Async(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return cancellationToken.CancelIfRequestedAsync<int?>() ?? global::System.Threading.Tasks.Task.FromResult<int?>(this.ReadAsInt32());
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003680 File Offset: 0x00001880
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			2
		})]
		public virtual global::System.Threading.Tasks.Task<string> ReadAsStringAsync(global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			return cancellationToken.CancelIfRequestedAsync<string>() ?? global::System.Threading.Tasks.Task.FromResult<string>(this.ReadAsString());
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003698 File Offset: 0x00001898
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal global::System.Threading.Tasks.Task<bool> ReadAndMoveToContentAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonReader.<ReadAndMoveToContentAsync>d__12 <ReadAndMoveToContentAsync>d__;
			<ReadAndMoveToContentAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<ReadAndMoveToContentAsync>d__.<>4__this = this;
			<ReadAndMoveToContentAsync>d__.cancellationToken = cancellationToken;
			<ReadAndMoveToContentAsync>d__.<>1__state = -1;
			<ReadAndMoveToContentAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonReader.<ReadAndMoveToContentAsync>d__12>(ref <ReadAndMoveToContentAsync>d__);
			return <ReadAndMoveToContentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000036E4 File Offset: 0x000018E4
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal global::System.Threading.Tasks.Task<bool> MoveToContentAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonToken tokenType = this.TokenType;
			if (tokenType == global::Newtonsoft.Json.JsonToken.None || tokenType == global::Newtonsoft.Json.JsonToken.Comment)
			{
				return this.MoveToContentFromNonContentAsync(cancellationToken);
			}
			return global::Newtonsoft.Json.Utilities.AsyncUtils.True;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000370C File Offset: 0x0000190C
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		private global::System.Threading.Tasks.Task<bool> MoveToContentFromNonContentAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::Newtonsoft.Json.JsonReader.<MoveToContentFromNonContentAsync>d__14 <MoveToContentFromNonContentAsync>d__;
			<MoveToContentFromNonContentAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<bool>.Create();
			<MoveToContentFromNonContentAsync>d__.<>4__this = this;
			<MoveToContentFromNonContentAsync>d__.cancellationToken = cancellationToken;
			<MoveToContentFromNonContentAsync>d__.<>1__state = -1;
			<MoveToContentFromNonContentAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.JsonReader.<MoveToContentFromNonContentAsync>d__14>(ref <MoveToContentFromNonContentAsync>d__);
			return <MoveToContentFromNonContentAsync>d__.<>t__builder.Task;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00003757 File Offset: 0x00001957
		protected global::Newtonsoft.Json.JsonReader.State CurrentState
		{
			get
			{
				return this._currentState;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000375F File Offset: 0x0000195F
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00003767 File Offset: 0x00001967
		public bool CloseInput { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00003770 File Offset: 0x00001970
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00003778 File Offset: 0x00001978
		public bool SupportMultipleContent { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00003781 File Offset: 0x00001981
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00003789 File Offset: 0x00001989
		public virtual char QuoteChar
		{
			get
			{
				return this._quoteChar;
			}
			protected internal set
			{
				this._quoteChar = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00003792 File Offset: 0x00001992
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000379A File Offset: 0x0000199A
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000037B6 File Offset: 0x000019B6
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000037BE File Offset: 0x000019BE
		public global::Newtonsoft.Json.DateParseHandling DateParseHandling
		{
			get
			{
				return this._dateParseHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.DateParseHandling.None || value > global::Newtonsoft.Json.DateParseHandling.DateTimeOffset)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._dateParseHandling = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000037DA File Offset: 0x000019DA
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000037E2 File Offset: 0x000019E2
		public global::Newtonsoft.Json.FloatParseHandling FloatParseHandling
		{
			get
			{
				return this._floatParseHandling;
			}
			set
			{
				if (value < global::Newtonsoft.Json.FloatParseHandling.Double || value > global::Newtonsoft.Json.FloatParseHandling.Decimal)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this._floatParseHandling = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000037FE File Offset: 0x000019FE
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00003806 File Offset: 0x00001A06
		public string DateFormatString
		{
			get
			{
				return this._dateFormatString;
			}
			set
			{
				this._dateFormatString = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000380F File Offset: 0x00001A0F
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00003818 File Offset: 0x00001A18
		public int? MaxDepth
		{
			get
			{
				return this._maxDepth;
			}
			set
			{
				int? num = value;
				int num2 = 0;
				if (num.GetValueOrDefault() <= num2 & num != null)
				{
					throw new global::System.ArgumentException("Value must be positive.", "value");
				}
				this._maxDepth = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00003857 File Offset: 0x00001A57
		public virtual global::Newtonsoft.Json.JsonToken TokenType
		{
			get
			{
				return this._tokenType;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000385F File Offset: 0x00001A5F
		public virtual object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00003867 File Offset: 0x00001A67
		public virtual global::System.Type ValueType
		{
			get
			{
				object value = this._value;
				if (value == null)
				{
					return null;
				}
				return value.GetType();
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000387C File Offset: 0x00001A7C
		public virtual int Depth
		{
			get
			{
				global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition> stack = this._stack;
				int num = (stack != null) ? stack.Count : 0;
				if (global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsStartToken(this.TokenType) || this._currentPosition.Type == global::Newtonsoft.Json.JsonContainerType.None)
				{
					return num;
				}
				return num + 1;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000038BC File Offset: 0x00001ABC
		[global::System.Runtime.CompilerServices.Nullable(1)]
		public virtual string Path
		{
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				if (this._currentPosition.Type == global::Newtonsoft.Json.JsonContainerType.None)
				{
					return string.Empty;
				}
				global::Newtonsoft.Json.JsonPosition? currentPosition = (this._currentState != global::Newtonsoft.Json.JsonReader.State.ArrayStart && this._currentState != global::Newtonsoft.Json.JsonReader.State.ConstructorStart && this._currentState != global::Newtonsoft.Json.JsonReader.State.ObjectStart) ? new global::Newtonsoft.Json.JsonPosition?(this._currentPosition) : null;
				return global::Newtonsoft.Json.JsonPosition.BuildPath(this._stack, currentPosition);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00003923 File Offset: 0x00001B23
		// (set) Token: 0x060000FB RID: 251 RVA: 0x00003934 File Offset: 0x00001B34
		[global::System.Runtime.CompilerServices.Nullable(1)]
		public global::System.Globalization.CultureInfo Culture
		{
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				return this._culture ?? global::System.Globalization.CultureInfo.InvariantCulture;
			}
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000393D File Offset: 0x00001B3D
		internal global::Newtonsoft.Json.JsonPosition GetPosition(int depth)
		{
			if (this._stack != null && depth < this._stack.Count)
			{
				return this._stack[depth];
			}
			return this._currentPosition;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003968 File Offset: 0x00001B68
		protected JsonReader()
		{
			this._currentState = global::Newtonsoft.Json.JsonReader.State.Start;
			this._dateTimeZoneHandling = global::Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
			this._dateParseHandling = global::Newtonsoft.Json.DateParseHandling.DateTime;
			this._floatParseHandling = global::Newtonsoft.Json.FloatParseHandling.Double;
			this._maxDepth = new int?(64);
			this.CloseInput = true;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000039A0 File Offset: 0x00001BA0
		private void Push(global::Newtonsoft.Json.JsonContainerType value)
		{
			this.UpdateScopeWithFinishedValue();
			if (this._currentPosition.Type == global::Newtonsoft.Json.JsonContainerType.None)
			{
				this._currentPosition = new global::Newtonsoft.Json.JsonPosition(value);
				return;
			}
			if (this._stack == null)
			{
				this._stack = new global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition>();
			}
			this._stack.Add(this._currentPosition);
			this._currentPosition = new global::Newtonsoft.Json.JsonPosition(value);
			if (this._maxDepth != null)
			{
				int num = this.Depth + 1;
				int? maxDepth = this._maxDepth;
				if ((num > maxDepth.GetValueOrDefault() & maxDepth != null) && !this._hasExceededMaxDepth)
				{
					this._hasExceededMaxDepth = true;
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "The reader's MaxDepth of {0} has been exceeded.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._maxDepth));
				}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003A5C File Offset: 0x00001C5C
		private global::Newtonsoft.Json.JsonContainerType Pop()
		{
			global::Newtonsoft.Json.JsonPosition currentPosition;
			if (this._stack != null && this._stack.Count > 0)
			{
				currentPosition = this._currentPosition;
				this._currentPosition = this._stack[this._stack.Count - 1];
				this._stack.RemoveAt(this._stack.Count - 1);
			}
			else
			{
				currentPosition = this._currentPosition;
				this._currentPosition = default(global::Newtonsoft.Json.JsonPosition);
			}
			if (this._maxDepth != null)
			{
				int depth = this.Depth;
				int? maxDepth = this._maxDepth;
				if (depth <= maxDepth.GetValueOrDefault() & maxDepth != null)
				{
					this._hasExceededMaxDepth = false;
				}
			}
			return currentPosition.Type;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003B0E File Offset: 0x00001D0E
		private global::Newtonsoft.Json.JsonContainerType Peek()
		{
			return this._currentPosition.Type;
		}

		// Token: 0x06000101 RID: 257
		public abstract bool Read();

		// Token: 0x06000102 RID: 258 RVA: 0x00003B1C File Offset: 0x00001D1C
		public virtual int? ReadAsInt32()
		{
			global::Newtonsoft.Json.JsonToken contentToken = this.GetContentToken();
			if (contentToken != global::Newtonsoft.Json.JsonToken.None)
			{
				switch (contentToken)
				{
				case global::Newtonsoft.Json.JsonToken.Integer:
				case global::Newtonsoft.Json.JsonToken.Float:
				{
					object value = this.Value;
					int num;
					if (value is int)
					{
						num = (int)value;
						return new int?(num);
					}
					if (value is global::System.Numerics.BigInteger)
					{
						global::System.Numerics.BigInteger value2 = (global::System.Numerics.BigInteger)value;
						num = (int)value2;
					}
					else
					{
						try
						{
							num = global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
						}
						catch (global::System.Exception ex)
						{
							throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Could not convert to integer: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value), ex);
						}
					}
					this.SetToken(global::Newtonsoft.Json.JsonToken.Integer, num, false);
					return new int?(num);
				}
				case global::Newtonsoft.Json.JsonToken.String:
				{
					string s = (string)this.Value;
					return this.ReadInt32String(s);
				}
				case global::Newtonsoft.Json.JsonToken.Null:
				case global::Newtonsoft.Json.JsonToken.EndArray:
					goto IL_37;
				}
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading integer. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contentToken));
			}
			IL_37:
			return null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003C20 File Offset: 0x00001E20
		internal int? ReadInt32String(string s)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Null, null, false);
				return null;
			}
			int num;
			if (int.TryParse(s, global::System.Globalization.NumberStyles.Integer, this.Culture, out num))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Integer, num, false);
				return new int?(num);
			}
			this.SetToken(global::Newtonsoft.Json.JsonToken.String, s, false);
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Could not convert string to integer: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, s));
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003C90 File Offset: 0x00001E90
		public virtual string ReadAsString()
		{
			global::Newtonsoft.Json.JsonToken contentToken = this.GetContentToken();
			if (contentToken <= global::Newtonsoft.Json.JsonToken.String)
			{
				if (contentToken != global::Newtonsoft.Json.JsonToken.None)
				{
					if (contentToken != global::Newtonsoft.Json.JsonToken.String)
					{
						goto IL_2E;
					}
					return (string)this.Value;
				}
			}
			else if (contentToken != global::Newtonsoft.Json.JsonToken.Null && contentToken != global::Newtonsoft.Json.JsonToken.EndArray)
			{
				goto IL_2E;
			}
			return null;
			IL_2E:
			if (global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsPrimitiveToken(contentToken))
			{
				object value = this.Value;
				if (value != null)
				{
					global::System.IFormattable formattable = value as global::System.IFormattable;
					string text;
					if (formattable != null)
					{
						text = formattable.ToString(null, this.Culture);
					}
					else
					{
						global::System.Uri uri = value as global::System.Uri;
						text = ((uri != null) ? uri.OriginalString : value.ToString());
					}
					this.SetToken(global::Newtonsoft.Json.JsonToken.String, text, false);
					return text;
				}
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading string. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contentToken));
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003D3C File Offset: 0x00001F3C
		public virtual byte[] ReadAsBytes()
		{
			global::Newtonsoft.Json.JsonToken contentToken = this.GetContentToken();
			if (contentToken <= global::Newtonsoft.Json.JsonToken.String)
			{
				switch (contentToken)
				{
				case global::Newtonsoft.Json.JsonToken.None:
					break;
				case global::Newtonsoft.Json.JsonToken.StartObject:
				{
					this.ReadIntoWrappedTypeObject();
					byte[] array = this.ReadAsBytes();
					this.ReaderReadAndAssert();
					if (this.TokenType != global::Newtonsoft.Json.JsonToken.EndObject)
					{
						throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading bytes. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this.TokenType));
					}
					this.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, array, false);
					return array;
				}
				case global::Newtonsoft.Json.JsonToken.StartArray:
					return this.ReadArrayIntoByteArray();
				default:
				{
					if (contentToken != global::Newtonsoft.Json.JsonToken.String)
					{
						goto IL_11C;
					}
					string text = (string)this.Value;
					byte[] array2;
					global::System.Guid guid;
					if (text.Length == 0)
					{
						array2 = global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<byte>();
					}
					else if (global::Newtonsoft.Json.Utilities.ConvertUtils.TryConvertGuid(text, out guid))
					{
						array2 = guid.ToByteArray();
					}
					else
					{
						array2 = global::System.Convert.FromBase64String(text);
					}
					this.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, array2, false);
					return array2;
				}
				}
			}
			else if (contentToken != global::Newtonsoft.Json.JsonToken.Null && contentToken != global::Newtonsoft.Json.JsonToken.EndArray)
			{
				if (contentToken != global::Newtonsoft.Json.JsonToken.Bytes)
				{
					goto IL_11C;
				}
				object value = this.Value;
				if (value is global::System.Guid)
				{
					byte[] array3 = ((global::System.Guid)value).ToByteArray();
					this.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, array3, false);
					return array3;
				}
				return (byte[])this.Value;
			}
			return null;
			IL_11C:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading bytes. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contentToken));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003E80 File Offset: 0x00002080
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal byte[] ReadArrayIntoByteArray()
		{
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			do
			{
				if (!this.Read())
				{
					this.SetToken(global::Newtonsoft.Json.JsonToken.None);
				}
			}
			while (!this.ReadArrayElementIntoByteArrayReportDone(list));
			byte[] array = list.ToArray();
			this.SetToken(global::Newtonsoft.Json.JsonToken.Bytes, array, false);
			return array;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003EC0 File Offset: 0x000020C0
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		private bool ReadArrayElementIntoByteArrayReportDone(global::System.Collections.Generic.List<byte> buffer)
		{
			global::Newtonsoft.Json.JsonToken tokenType = this.TokenType;
			if (tokenType <= global::Newtonsoft.Json.JsonToken.Comment)
			{
				if (tokenType == global::Newtonsoft.Json.JsonToken.None)
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected end when reading bytes.");
				}
				if (tokenType == global::Newtonsoft.Json.JsonToken.Comment)
				{
					return false;
				}
			}
			else
			{
				if (tokenType == global::Newtonsoft.Json.JsonToken.Integer)
				{
					buffer.Add(global::System.Convert.ToByte(this.Value, global::System.Globalization.CultureInfo.InvariantCulture));
					return false;
				}
				if (tokenType == global::Newtonsoft.Json.JsonToken.EndArray)
				{
					return true;
				}
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected token when reading bytes: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this.TokenType));
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003F34 File Offset: 0x00002134
		public virtual double? ReadAsDouble()
		{
			global::Newtonsoft.Json.JsonToken contentToken = this.GetContentToken();
			if (contentToken != global::Newtonsoft.Json.JsonToken.None)
			{
				switch (contentToken)
				{
				case global::Newtonsoft.Json.JsonToken.Integer:
				case global::Newtonsoft.Json.JsonToken.Float:
				{
					object value = this.Value;
					double num;
					if (value is double)
					{
						num = (double)value;
						return new double?(num);
					}
					if (value is global::System.Numerics.BigInteger)
					{
						global::System.Numerics.BigInteger value2 = (global::System.Numerics.BigInteger)value;
						num = (double)value2;
					}
					else
					{
						num = global::System.Convert.ToDouble(value, global::System.Globalization.CultureInfo.InvariantCulture);
					}
					this.SetToken(global::Newtonsoft.Json.JsonToken.Float, num, false);
					return new double?(num);
				}
				case global::Newtonsoft.Json.JsonToken.String:
					return this.ReadDoubleString((string)this.Value);
				case global::Newtonsoft.Json.JsonToken.Null:
				case global::Newtonsoft.Json.JsonToken.EndArray:
					goto IL_34;
				}
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading double. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contentToken));
			}
			IL_34:
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00004008 File Offset: 0x00002208
		internal double? ReadDoubleString(string s)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Null, null, false);
				return null;
			}
			double num;
			if (double.TryParse(s, global::System.Globalization.NumberStyles.AllowLeadingWhite | global::System.Globalization.NumberStyles.AllowTrailingWhite | global::System.Globalization.NumberStyles.AllowLeadingSign | global::System.Globalization.NumberStyles.AllowDecimalPoint | global::System.Globalization.NumberStyles.AllowThousands | global::System.Globalization.NumberStyles.AllowExponent, this.Culture, out num))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Float, num, false);
				return new double?(num);
			}
			this.SetToken(global::Newtonsoft.Json.JsonToken.String, s, false);
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Could not convert string to double: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, s));
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000407C File Offset: 0x0000227C
		public virtual bool? ReadAsBoolean()
		{
			global::Newtonsoft.Json.JsonToken contentToken = this.GetContentToken();
			if (contentToken != global::Newtonsoft.Json.JsonToken.None)
			{
				switch (contentToken)
				{
				case global::Newtonsoft.Json.JsonToken.Integer:
				case global::Newtonsoft.Json.JsonToken.Float:
				{
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
					this.SetToken(global::Newtonsoft.Json.JsonToken.Boolean, flag, false);
					return new bool?(flag);
				}
				case global::Newtonsoft.Json.JsonToken.String:
					return this.ReadBooleanString((string)this.Value);
				case global::Newtonsoft.Json.JsonToken.Boolean:
					return new bool?((bool)this.Value);
				case global::Newtonsoft.Json.JsonToken.Null:
				case global::Newtonsoft.Json.JsonToken.EndArray:
					goto IL_34;
				}
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading boolean. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contentToken));
			}
			IL_34:
			return null;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00004150 File Offset: 0x00002350
		internal bool? ReadBooleanString(string s)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Null, null, false);
				return null;
			}
			bool flag;
			if (bool.TryParse(s, out flag))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Boolean, flag, false);
				return new bool?(flag);
			}
			this.SetToken(global::Newtonsoft.Json.JsonToken.String, s, false);
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Could not convert string to boolean: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, s));
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000041BC File Offset: 0x000023BC
		public virtual decimal? ReadAsDecimal()
		{
			global::Newtonsoft.Json.JsonToken contentToken = this.GetContentToken();
			if (contentToken != global::Newtonsoft.Json.JsonToken.None)
			{
				switch (contentToken)
				{
				case global::Newtonsoft.Json.JsonToken.Integer:
				case global::Newtonsoft.Json.JsonToken.Float:
				{
					object value = this.Value;
					decimal num;
					if (value is decimal)
					{
						num = (decimal)value;
						return new decimal?(num);
					}
					if (value is global::System.Numerics.BigInteger)
					{
						global::System.Numerics.BigInteger value2 = (global::System.Numerics.BigInteger)value;
						num = (decimal)value2;
					}
					else
					{
						try
						{
							num = global::System.Convert.ToDecimal(value, global::System.Globalization.CultureInfo.InvariantCulture);
						}
						catch (global::System.Exception ex)
						{
							throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Could not convert to decimal: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value), ex);
						}
					}
					this.SetToken(global::Newtonsoft.Json.JsonToken.Float, num, false);
					return new decimal?(num);
				}
				case global::Newtonsoft.Json.JsonToken.String:
					return this.ReadDecimalString((string)this.Value);
				case global::Newtonsoft.Json.JsonToken.Null:
				case global::Newtonsoft.Json.JsonToken.EndArray:
					goto IL_37;
				}
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading decimal. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contentToken));
			}
			IL_37:
			return null;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000042BC File Offset: 0x000024BC
		internal decimal? ReadDecimalString(string s)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Null, null, false);
				return null;
			}
			decimal num;
			if (decimal.TryParse(s, global::System.Globalization.NumberStyles.Number, this.Culture, out num))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Float, num, false);
				return new decimal?(num);
			}
			if (global::Newtonsoft.Json.Utilities.ConvertUtils.DecimalTryParse(s.ToCharArray(), 0, s.Length, out num) == global::Newtonsoft.Json.Utilities.ParseResult.Success)
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Float, num, false);
				return new decimal?(num);
			}
			this.SetToken(global::Newtonsoft.Json.JsonToken.String, s, false);
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Could not convert string to decimal: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, s));
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00004358 File Offset: 0x00002558
		public virtual global::System.DateTime? ReadAsDateTime()
		{
			global::Newtonsoft.Json.JsonToken contentToken = this.GetContentToken();
			if (contentToken <= global::Newtonsoft.Json.JsonToken.String)
			{
				if (contentToken != global::Newtonsoft.Json.JsonToken.None)
				{
					if (contentToken != global::Newtonsoft.Json.JsonToken.String)
					{
						goto IL_7F;
					}
					return this.ReadDateTimeString((string)this.Value);
				}
			}
			else if (contentToken != global::Newtonsoft.Json.JsonToken.Null && contentToken != global::Newtonsoft.Json.JsonToken.EndArray)
			{
				if (contentToken != global::Newtonsoft.Json.JsonToken.Date)
				{
					goto IL_7F;
				}
				object value = this.Value;
				if (value is global::System.DateTimeOffset)
				{
					this.SetToken(global::Newtonsoft.Json.JsonToken.Date, ((global::System.DateTimeOffset)value).DateTime, false);
				}
				return new global::System.DateTime?((global::System.DateTime)this.Value);
			}
			return null;
			IL_7F:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading date. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this.TokenType));
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004404 File Offset: 0x00002604
		internal global::System.DateTime? ReadDateTimeString(string s)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Null, null, false);
				return null;
			}
			global::System.DateTime dateTime;
			if (global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTime(s, this.DateTimeZoneHandling, this._dateFormatString, this.Culture, out dateTime))
			{
				dateTime = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(dateTime, this.DateTimeZoneHandling);
				this.SetToken(global::Newtonsoft.Json.JsonToken.Date, dateTime, false);
				return new global::System.DateTime?(dateTime);
			}
			if (global::System.DateTime.TryParse(s, this.Culture, global::System.Globalization.DateTimeStyles.RoundtripKind, out dateTime))
			{
				dateTime = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(dateTime, this.DateTimeZoneHandling);
				this.SetToken(global::Newtonsoft.Json.JsonToken.Date, dateTime, false);
				return new global::System.DateTime?(dateTime);
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Could not convert string to DateTime: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, s));
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000044BC File Offset: 0x000026BC
		public virtual global::System.DateTimeOffset? ReadAsDateTimeOffset()
		{
			global::Newtonsoft.Json.JsonToken contentToken = this.GetContentToken();
			if (contentToken <= global::Newtonsoft.Json.JsonToken.String)
			{
				if (contentToken != global::Newtonsoft.Json.JsonToken.None)
				{
					if (contentToken != global::Newtonsoft.Json.JsonToken.String)
					{
						goto IL_83;
					}
					string s = (string)this.Value;
					return this.ReadDateTimeOffsetString(s);
				}
			}
			else if (contentToken != global::Newtonsoft.Json.JsonToken.Null && contentToken != global::Newtonsoft.Json.JsonToken.EndArray)
			{
				if (contentToken != global::Newtonsoft.Json.JsonToken.Date)
				{
					goto IL_83;
				}
				object value = this.Value;
				if (value is global::System.DateTime)
				{
					global::System.DateTime dateTime = (global::System.DateTime)value;
					this.SetToken(global::Newtonsoft.Json.JsonToken.Date, new global::System.DateTimeOffset(dateTime), false);
				}
				return new global::System.DateTimeOffset?((global::System.DateTimeOffset)this.Value);
			}
			return null;
			IL_83:
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading date. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contentToken));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00004568 File Offset: 0x00002768
		internal global::System.DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Null, null, false);
				return null;
			}
			global::System.DateTimeOffset dateTimeOffset;
			if (global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffset(s, this._dateFormatString, this.Culture, out dateTimeOffset))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Date, dateTimeOffset, false);
				return new global::System.DateTimeOffset?(dateTimeOffset);
			}
			if (global::System.DateTimeOffset.TryParse(s, this.Culture, global::System.Globalization.DateTimeStyles.RoundtripKind, out dateTimeOffset))
			{
				this.SetToken(global::Newtonsoft.Json.JsonToken.Date, dateTimeOffset, false);
				return new global::System.DateTimeOffset?(dateTimeOffset);
			}
			this.SetToken(global::Newtonsoft.Json.JsonToken.String, s, false);
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Could not convert string to DateTimeOffset: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, s));
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00004608 File Offset: 0x00002808
		internal void ReaderReadAndAssert()
		{
			if (!this.Read())
			{
				throw this.CreateUnexpectedEndException();
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00004619 File Offset: 0x00002819
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		internal global::Newtonsoft.Json.JsonReaderException CreateUnexpectedEndException()
		{
			return global::Newtonsoft.Json.JsonReaderException.Create(this, "Unexpected end when reading JSON.");
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004628 File Offset: 0x00002828
		internal void ReadIntoWrappedTypeObject()
		{
			this.ReaderReadAndAssert();
			if (this.Value != null && this.Value.ToString() == "$type")
			{
				this.ReaderReadAndAssert();
				if (this.Value != null && this.Value.ToString().StartsWith("System.Byte[]", global::System.StringComparison.Ordinal))
				{
					this.ReaderReadAndAssert();
					if (this.Value.ToString() == "$value")
					{
						return;
					}
				}
			}
			throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Error reading bytes. Unexpected token: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.JsonToken.StartObject));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000046BC File Offset: 0x000028BC
		public void Skip()
		{
			if (this.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
			{
				this.Read();
			}
			if (global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsStartToken(this.TokenType))
			{
				int depth = this.Depth;
				while (this.Read() && depth < this.Depth)
				{
				}
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000046FE File Offset: 0x000028FE
		protected void SetToken(global::Newtonsoft.Json.JsonToken newToken)
		{
			this.SetToken(newToken, null, true);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00004709 File Offset: 0x00002909
		protected void SetToken(global::Newtonsoft.Json.JsonToken newToken, object value)
		{
			this.SetToken(newToken, value, true);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004714 File Offset: 0x00002914
		protected void SetToken(global::Newtonsoft.Json.JsonToken newToken, object value, bool updateIndex)
		{
			this._tokenType = newToken;
			this._value = value;
			switch (newToken)
			{
			case global::Newtonsoft.Json.JsonToken.StartObject:
				this._currentState = global::Newtonsoft.Json.JsonReader.State.ObjectStart;
				this.Push(global::Newtonsoft.Json.JsonContainerType.Object);
				return;
			case global::Newtonsoft.Json.JsonToken.StartArray:
				this._currentState = global::Newtonsoft.Json.JsonReader.State.ArrayStart;
				this.Push(global::Newtonsoft.Json.JsonContainerType.Array);
				return;
			case global::Newtonsoft.Json.JsonToken.StartConstructor:
				this._currentState = global::Newtonsoft.Json.JsonReader.State.ConstructorStart;
				this.Push(global::Newtonsoft.Json.JsonContainerType.Constructor);
				return;
			case global::Newtonsoft.Json.JsonToken.PropertyName:
				this._currentState = global::Newtonsoft.Json.JsonReader.State.Property;
				this._currentPosition.PropertyName = (string)value;
				return;
			case global::Newtonsoft.Json.JsonToken.Comment:
				break;
			case global::Newtonsoft.Json.JsonToken.Raw:
			case global::Newtonsoft.Json.JsonToken.Integer:
			case global::Newtonsoft.Json.JsonToken.Float:
			case global::Newtonsoft.Json.JsonToken.String:
			case global::Newtonsoft.Json.JsonToken.Boolean:
			case global::Newtonsoft.Json.JsonToken.Null:
			case global::Newtonsoft.Json.JsonToken.Undefined:
			case global::Newtonsoft.Json.JsonToken.Date:
			case global::Newtonsoft.Json.JsonToken.Bytes:
				this.SetPostValueState(updateIndex);
				break;
			case global::Newtonsoft.Json.JsonToken.EndObject:
				this.ValidateEnd(global::Newtonsoft.Json.JsonToken.EndObject);
				return;
			case global::Newtonsoft.Json.JsonToken.EndArray:
				this.ValidateEnd(global::Newtonsoft.Json.JsonToken.EndArray);
				return;
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				this.ValidateEnd(global::Newtonsoft.Json.JsonToken.EndConstructor);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000047E5 File Offset: 0x000029E5
		internal void SetPostValueState(bool updateIndex)
		{
			if (this.Peek() != global::Newtonsoft.Json.JsonContainerType.None || this.SupportMultipleContent)
			{
				this._currentState = global::Newtonsoft.Json.JsonReader.State.PostValue;
			}
			else
			{
				this.SetFinished();
			}
			if (updateIndex)
			{
				this.UpdateScopeWithFinishedValue();
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000480F File Offset: 0x00002A0F
		private void UpdateScopeWithFinishedValue()
		{
			if (this._currentPosition.HasIndex)
			{
				this._currentPosition.Position = this._currentPosition.Position + 1;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004830 File Offset: 0x00002A30
		private void ValidateEnd(global::Newtonsoft.Json.JsonToken endToken)
		{
			global::Newtonsoft.Json.JsonContainerType jsonContainerType = this.Pop();
			if (this.GetTypeForCloseToken(endToken) != jsonContainerType)
			{
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "JsonToken {0} is not valid for closing JsonType {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, endToken, jsonContainerType));
			}
			if (this.Peek() != global::Newtonsoft.Json.JsonContainerType.None || this.SupportMultipleContent)
			{
				this._currentState = global::Newtonsoft.Json.JsonReader.State.PostValue;
				return;
			}
			this.SetFinished();
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00004890 File Offset: 0x00002A90
		protected void SetStateBasedOnCurrent()
		{
			global::Newtonsoft.Json.JsonContainerType jsonContainerType = this.Peek();
			switch (jsonContainerType)
			{
			case global::Newtonsoft.Json.JsonContainerType.None:
				this.SetFinished();
				return;
			case global::Newtonsoft.Json.JsonContainerType.Object:
				this._currentState = global::Newtonsoft.Json.JsonReader.State.Object;
				return;
			case global::Newtonsoft.Json.JsonContainerType.Array:
				this._currentState = global::Newtonsoft.Json.JsonReader.State.Array;
				return;
			case global::Newtonsoft.Json.JsonContainerType.Constructor:
				this._currentState = global::Newtonsoft.Json.JsonReader.State.Constructor;
				return;
			default:
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "While setting the reader state back to current object an unexpected JsonType was encountered: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jsonContainerType));
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000048F7 File Offset: 0x00002AF7
		private void SetFinished()
		{
			this._currentState = (this.SupportMultipleContent ? global::Newtonsoft.Json.JsonReader.State.Start : global::Newtonsoft.Json.JsonReader.State.Finished);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000490C File Offset: 0x00002B0C
		private global::Newtonsoft.Json.JsonContainerType GetTypeForCloseToken(global::Newtonsoft.Json.JsonToken token)
		{
			switch (token)
			{
			case global::Newtonsoft.Json.JsonToken.EndObject:
				return global::Newtonsoft.Json.JsonContainerType.Object;
			case global::Newtonsoft.Json.JsonToken.EndArray:
				return global::Newtonsoft.Json.JsonContainerType.Array;
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				return global::Newtonsoft.Json.JsonContainerType.Constructor;
			default:
				throw global::Newtonsoft.Json.JsonReaderException.Create(this, "Not a valid close JsonToken: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token));
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004946 File Offset: 0x00002B46
		void global::System.IDisposable.Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004955 File Offset: 0x00002B55
		protected virtual void Dispose(bool disposing)
		{
			if (this._currentState != global::Newtonsoft.Json.JsonReader.State.Closed && disposing)
			{
				this.Close();
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000496D File Offset: 0x00002B6D
		public virtual void Close()
		{
			this._currentState = global::Newtonsoft.Json.JsonReader.State.Closed;
			this._tokenType = global::Newtonsoft.Json.JsonToken.None;
			this._value = null;
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00004984 File Offset: 0x00002B84
		internal void ReadAndAssert()
		{
			if (!this.Read())
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(this, "Unexpected end when reading JSON.");
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000499A File Offset: 0x00002B9A
		internal void ReadForTypeAndAssert(global::Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter)
		{
			if (!this.ReadForType(contract, hasConverter))
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(this, "Unexpected end when reading JSON.");
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000049B4 File Offset: 0x00002BB4
		internal bool ReadForType(global::Newtonsoft.Json.Serialization.JsonContract contract, bool hasConverter)
		{
			if (hasConverter)
			{
				return this.Read();
			}
			switch ((contract != null) ? contract.InternalReadType : global::Newtonsoft.Json.ReadType.Read)
			{
			case global::Newtonsoft.Json.ReadType.Read:
				return this.ReadAndMoveToContent();
			case global::Newtonsoft.Json.ReadType.ReadAsInt32:
				this.ReadAsInt32();
				break;
			case global::Newtonsoft.Json.ReadType.ReadAsInt64:
			{
				bool result = this.ReadAndMoveToContent();
				if (this.TokenType == global::Newtonsoft.Json.JsonToken.Undefined)
				{
					throw global::Newtonsoft.Json.JsonReaderException.Create(this, "An undefined token is not a valid {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, ((contract != null) ? contract.UnderlyingType : null) ?? typeof(long)));
				}
				return result;
			}
			case global::Newtonsoft.Json.ReadType.ReadAsBytes:
				this.ReadAsBytes();
				break;
			case global::Newtonsoft.Json.ReadType.ReadAsString:
				this.ReadAsString();
				break;
			case global::Newtonsoft.Json.ReadType.ReadAsDecimal:
				this.ReadAsDecimal();
				break;
			case global::Newtonsoft.Json.ReadType.ReadAsDateTime:
				this.ReadAsDateTime();
				break;
			case global::Newtonsoft.Json.ReadType.ReadAsDateTimeOffset:
				this.ReadAsDateTimeOffset();
				break;
			case global::Newtonsoft.Json.ReadType.ReadAsDouble:
				this.ReadAsDouble();
				break;
			case global::Newtonsoft.Json.ReadType.ReadAsBoolean:
				this.ReadAsBoolean();
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
			return this.TokenType > global::Newtonsoft.Json.JsonToken.None;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00004AAD File Offset: 0x00002CAD
		internal bool ReadAndMoveToContent()
		{
			return this.Read() && this.MoveToContent();
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00004AC0 File Offset: 0x00002CC0
		internal bool MoveToContent()
		{
			global::Newtonsoft.Json.JsonToken tokenType = this.TokenType;
			while (tokenType == global::Newtonsoft.Json.JsonToken.None || tokenType == global::Newtonsoft.Json.JsonToken.Comment)
			{
				if (!this.Read())
				{
					return false;
				}
				tokenType = this.TokenType;
			}
			return true;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00004AF0 File Offset: 0x00002CF0
		private global::Newtonsoft.Json.JsonToken GetContentToken()
		{
			while (this.Read())
			{
				global::Newtonsoft.Json.JsonToken tokenType = this.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
				{
					return tokenType;
				}
			}
			this.SetToken(global::Newtonsoft.Json.JsonToken.None);
			return global::Newtonsoft.Json.JsonToken.None;
		}

		// Token: 0x0400005E RID: 94
		private global::Newtonsoft.Json.JsonToken _tokenType;

		// Token: 0x0400005F RID: 95
		private object _value;

		// Token: 0x04000060 RID: 96
		internal char _quoteChar;

		// Token: 0x04000061 RID: 97
		internal global::Newtonsoft.Json.JsonReader.State _currentState;

		// Token: 0x04000062 RID: 98
		private global::Newtonsoft.Json.JsonPosition _currentPosition;

		// Token: 0x04000063 RID: 99
		private global::System.Globalization.CultureInfo _culture;

		// Token: 0x04000064 RID: 100
		private global::Newtonsoft.Json.DateTimeZoneHandling _dateTimeZoneHandling;

		// Token: 0x04000065 RID: 101
		private int? _maxDepth;

		// Token: 0x04000066 RID: 102
		private bool _hasExceededMaxDepth;

		// Token: 0x04000067 RID: 103
		internal global::Newtonsoft.Json.DateParseHandling _dateParseHandling;

		// Token: 0x04000068 RID: 104
		internal global::Newtonsoft.Json.FloatParseHandling _floatParseHandling;

		// Token: 0x04000069 RID: 105
		private string _dateFormatString;

		// Token: 0x0400006A RID: 106
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonPosition> _stack;

		// Token: 0x02000115 RID: 277
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		protected internal enum State
		{
			// Token: 0x04000461 RID: 1121
			Start,
			// Token: 0x04000462 RID: 1122
			Complete,
			// Token: 0x04000463 RID: 1123
			Property,
			// Token: 0x04000464 RID: 1124
			ObjectStart,
			// Token: 0x04000465 RID: 1125
			Object,
			// Token: 0x04000466 RID: 1126
			ArrayStart,
			// Token: 0x04000467 RID: 1127
			Array,
			// Token: 0x04000468 RID: 1128
			Closed,
			// Token: 0x04000469 RID: 1129
			PostValue,
			// Token: 0x0400046A RID: 1130
			ConstructorStart,
			// Token: 0x0400046B RID: 1131
			Constructor,
			// Token: 0x0400046C RID: 1132
			Error,
			// Token: 0x0400046D RID: 1133
			Finished
		}
	}
}
