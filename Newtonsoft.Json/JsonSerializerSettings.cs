using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x0200002C RID: 44
	[global::System.Runtime.CompilerServices.NullableContext(2)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JsonSerializerSettings
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00005D2D File Offset: 0x00003F2D
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00005D3A File Offset: 0x00003F3A
		public global::Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling
		{
			get
			{
				return this._referenceLoopHandling.GetValueOrDefault();
			}
			set
			{
				this._referenceLoopHandling = new global::Newtonsoft.Json.ReferenceLoopHandling?(value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00005D48 File Offset: 0x00003F48
		// (set) Token: 0x0600019A RID: 410 RVA: 0x00005D55 File Offset: 0x00003F55
		public global::Newtonsoft.Json.MissingMemberHandling MissingMemberHandling
		{
			get
			{
				return this._missingMemberHandling.GetValueOrDefault();
			}
			set
			{
				this._missingMemberHandling = new global::Newtonsoft.Json.MissingMemberHandling?(value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600019B RID: 411 RVA: 0x00005D63 File Offset: 0x00003F63
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00005D70 File Offset: 0x00003F70
		public global::Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling
		{
			get
			{
				return this._objectCreationHandling.GetValueOrDefault();
			}
			set
			{
				this._objectCreationHandling = new global::Newtonsoft.Json.ObjectCreationHandling?(value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00005D7E File Offset: 0x00003F7E
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00005D8B File Offset: 0x00003F8B
		public global::Newtonsoft.Json.NullValueHandling NullValueHandling
		{
			get
			{
				return this._nullValueHandling.GetValueOrDefault();
			}
			set
			{
				this._nullValueHandling = new global::Newtonsoft.Json.NullValueHandling?(value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00005D99 File Offset: 0x00003F99
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00005DA6 File Offset: 0x00003FA6
		public global::Newtonsoft.Json.DefaultValueHandling DefaultValueHandling
		{
			get
			{
				return this._defaultValueHandling.GetValueOrDefault();
			}
			set
			{
				this._defaultValueHandling = new global::Newtonsoft.Json.DefaultValueHandling?(value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00005DB4 File Offset: 0x00003FB4
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x00005DBC File Offset: 0x00003FBC
		[global::System.Runtime.CompilerServices.Nullable(1)]
		public global::System.Collections.Generic.IList<global::Newtonsoft.Json.JsonConverter> Converters { [global::System.Runtime.CompilerServices.NullableContext(1)] get; [global::System.Runtime.CompilerServices.NullableContext(1)] set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00005DC5 File Offset: 0x00003FC5
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00005DD2 File Offset: 0x00003FD2
		public global::Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling
		{
			get
			{
				return this._preserveReferencesHandling.GetValueOrDefault();
			}
			set
			{
				this._preserveReferencesHandling = new global::Newtonsoft.Json.PreserveReferencesHandling?(value);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00005DE0 File Offset: 0x00003FE0
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x00005DED File Offset: 0x00003FED
		public global::Newtonsoft.Json.TypeNameHandling TypeNameHandling
		{
			get
			{
				return this._typeNameHandling.GetValueOrDefault();
			}
			set
			{
				this._typeNameHandling = new global::Newtonsoft.Json.TypeNameHandling?(value);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00005DFB File Offset: 0x00003FFB
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00005E08 File Offset: 0x00004008
		public global::Newtonsoft.Json.MetadataPropertyHandling MetadataPropertyHandling
		{
			get
			{
				return this._metadataPropertyHandling.GetValueOrDefault();
			}
			set
			{
				this._metadataPropertyHandling = new global::Newtonsoft.Json.MetadataPropertyHandling?(value);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00005E16 File Offset: 0x00004016
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00005E1E File Offset: 0x0000401E
		[global::System.Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
		public global::System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TypeNameAssemblyFormat
		{
			get
			{
				return (global::System.Runtime.Serialization.Formatters.FormatterAssemblyStyle)this.TypeNameAssemblyFormatHandling;
			}
			set
			{
				this.TypeNameAssemblyFormatHandling = (global::Newtonsoft.Json.TypeNameAssemblyFormatHandling)value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00005E27 File Offset: 0x00004027
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00005E34 File Offset: 0x00004034
		public global::Newtonsoft.Json.TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling
		{
			get
			{
				return this._typeNameAssemblyFormatHandling.GetValueOrDefault();
			}
			set
			{
				this._typeNameAssemblyFormatHandling = new global::Newtonsoft.Json.TypeNameAssemblyFormatHandling?(value);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00005E42 File Offset: 0x00004042
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00005E4F File Offset: 0x0000404F
		public global::Newtonsoft.Json.ConstructorHandling ConstructorHandling
		{
			get
			{
				return this._constructorHandling.GetValueOrDefault();
			}
			set
			{
				this._constructorHandling = new global::Newtonsoft.Json.ConstructorHandling?(value);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00005E5D File Offset: 0x0000405D
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00005E65 File Offset: 0x00004065
		public global::Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00005E6E File Offset: 0x0000406E
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00005E76 File Offset: 0x00004076
		public global::System.Collections.IEqualityComparer EqualityComparer { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00005E7F File Offset: 0x0000407F
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00005E94 File Offset: 0x00004094
		[global::System.Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
		public global::Newtonsoft.Json.Serialization.IReferenceResolver ReferenceResolver
		{
			get
			{
				global::System.Func<global::Newtonsoft.Json.Serialization.IReferenceResolver> referenceResolverProvider = this.ReferenceResolverProvider;
				if (referenceResolverProvider == null)
				{
					return null;
				}
				return referenceResolverProvider();
			}
			set
			{
				this.ReferenceResolverProvider = ((value != null) ? (() => value) : null);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00005ECB File Offset: 0x000040CB
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x00005ED3 File Offset: 0x000040D3
		public global::System.Func<global::Newtonsoft.Json.Serialization.IReferenceResolver> ReferenceResolverProvider { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00005EDC File Offset: 0x000040DC
		// (set) Token: 0x060001B8 RID: 440 RVA: 0x00005EE4 File Offset: 0x000040E4
		public global::Newtonsoft.Json.Serialization.ITraceWriter TraceWriter { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00005EF0 File Offset: 0x000040F0
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00005F27 File Offset: 0x00004127
		[global::System.Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
		public global::System.Runtime.Serialization.SerializationBinder Binder
		{
			get
			{
				if (this.SerializationBinder == null)
				{
					return null;
				}
				global::Newtonsoft.Json.Serialization.SerializationBinderAdapter serializationBinderAdapter = this.SerializationBinder as global::Newtonsoft.Json.Serialization.SerializationBinderAdapter;
				if (serializationBinderAdapter != null)
				{
					return serializationBinderAdapter.SerializationBinder;
				}
				throw new global::System.InvalidOperationException("Cannot get SerializationBinder because an ISerializationBinder was previously set.");
			}
			set
			{
				this.SerializationBinder = ((value == null) ? null : new global::Newtonsoft.Json.Serialization.SerializationBinderAdapter(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00005F3B File Offset: 0x0000413B
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00005F43 File Offset: 0x00004143
		public global::Newtonsoft.Json.Serialization.ISerializationBinder SerializationBinder { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00005F4C File Offset: 0x0000414C
		// (set) Token: 0x060001BE RID: 446 RVA: 0x00005F54 File Offset: 0x00004154
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		public global::System.EventHandler<global::Newtonsoft.Json.Serialization.ErrorEventArgs> Error { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00005F60 File Offset: 0x00004160
		// (set) Token: 0x060001C0 RID: 448 RVA: 0x00005F8A File Offset: 0x0000418A
		public global::System.Runtime.Serialization.StreamingContext Context
		{
			get
			{
				global::System.Runtime.Serialization.StreamingContext? context = this._context;
				if (context == null)
				{
					return global::Newtonsoft.Json.JsonSerializerSettings.DefaultContext;
				}
				return context.GetValueOrDefault();
			}
			set
			{
				this._context = new global::System.Runtime.Serialization.StreamingContext?(value);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00005F98 File Offset: 0x00004198
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00005FA9 File Offset: 0x000041A9
		[global::System.Runtime.CompilerServices.Nullable(1)]
		public string DateFormatString
		{
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				return this._dateFormatString ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
			}
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			set
			{
				this._dateFormatString = value;
				this._dateFormatStringSet = true;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00005FB9 File Offset: 0x000041B9
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00005FD4 File Offset: 0x000041D4
		public int? MaxDepth
		{
			get
			{
				if (!this._maxDepthSet)
				{
					return new int?(64);
				}
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
				this._maxDepthSet = true;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000601A File Offset: 0x0000421A
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00006027 File Offset: 0x00004227
		public global::Newtonsoft.Json.Formatting Formatting
		{
			get
			{
				return this._formatting.GetValueOrDefault();
			}
			set
			{
				this._formatting = new global::Newtonsoft.Json.Formatting?(value);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00006035 File Offset: 0x00004235
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00006042 File Offset: 0x00004242
		public global::Newtonsoft.Json.DateFormatHandling DateFormatHandling
		{
			get
			{
				return this._dateFormatHandling.GetValueOrDefault();
			}
			set
			{
				this._dateFormatHandling = new global::Newtonsoft.Json.DateFormatHandling?(value);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00006050 File Offset: 0x00004250
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00006076 File Offset: 0x00004276
		public global::Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling
		{
			get
			{
				global::Newtonsoft.Json.DateTimeZoneHandling? dateTimeZoneHandling = this._dateTimeZoneHandling;
				if (dateTimeZoneHandling == null)
				{
					return global::Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;
				}
				return dateTimeZoneHandling.GetValueOrDefault();
			}
			set
			{
				this._dateTimeZoneHandling = new global::Newtonsoft.Json.DateTimeZoneHandling?(value);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00006084 File Offset: 0x00004284
		// (set) Token: 0x060001CC RID: 460 RVA: 0x000060AA File Offset: 0x000042AA
		public global::Newtonsoft.Json.DateParseHandling DateParseHandling
		{
			get
			{
				global::Newtonsoft.Json.DateParseHandling? dateParseHandling = this._dateParseHandling;
				if (dateParseHandling == null)
				{
					return global::Newtonsoft.Json.DateParseHandling.DateTime;
				}
				return dateParseHandling.GetValueOrDefault();
			}
			set
			{
				this._dateParseHandling = new global::Newtonsoft.Json.DateParseHandling?(value);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000060B8 File Offset: 0x000042B8
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000060C5 File Offset: 0x000042C5
		public global::Newtonsoft.Json.FloatFormatHandling FloatFormatHandling
		{
			get
			{
				return this._floatFormatHandling.GetValueOrDefault();
			}
			set
			{
				this._floatFormatHandling = new global::Newtonsoft.Json.FloatFormatHandling?(value);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000060D3 File Offset: 0x000042D3
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000060E0 File Offset: 0x000042E0
		public global::Newtonsoft.Json.FloatParseHandling FloatParseHandling
		{
			get
			{
				return this._floatParseHandling.GetValueOrDefault();
			}
			set
			{
				this._floatParseHandling = new global::Newtonsoft.Json.FloatParseHandling?(value);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000060EE File Offset: 0x000042EE
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000060FB File Offset: 0x000042FB
		public global::Newtonsoft.Json.StringEscapeHandling StringEscapeHandling
		{
			get
			{
				return this._stringEscapeHandling.GetValueOrDefault();
			}
			set
			{
				this._stringEscapeHandling = new global::Newtonsoft.Json.StringEscapeHandling?(value);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00006109 File Offset: 0x00004309
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000611A File Offset: 0x0000431A
		[global::System.Runtime.CompilerServices.Nullable(1)]
		public global::System.Globalization.CultureInfo Culture
		{
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			get
			{
				return this._culture ?? global::Newtonsoft.Json.JsonSerializerSettings.DefaultCulture;
			}
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00006123 File Offset: 0x00004323
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00006130 File Offset: 0x00004330
		public bool CheckAdditionalContent
		{
			get
			{
				return this._checkAdditionalContent.GetValueOrDefault();
			}
			set
			{
				this._checkAdditionalContent = new bool?(value);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00006155 File Offset: 0x00004355
		[global::System.Diagnostics.DebuggerStepThrough]
		public JsonSerializerSettings()
		{
			this.Converters = new global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonConverter>();
		}

		// Token: 0x04000092 RID: 146
		internal const global::Newtonsoft.Json.ReferenceLoopHandling DefaultReferenceLoopHandling = global::Newtonsoft.Json.ReferenceLoopHandling.Error;

		// Token: 0x04000093 RID: 147
		internal const global::Newtonsoft.Json.MissingMemberHandling DefaultMissingMemberHandling = global::Newtonsoft.Json.MissingMemberHandling.Ignore;

		// Token: 0x04000094 RID: 148
		internal const global::Newtonsoft.Json.NullValueHandling DefaultNullValueHandling = global::Newtonsoft.Json.NullValueHandling.Include;

		// Token: 0x04000095 RID: 149
		internal const global::Newtonsoft.Json.DefaultValueHandling DefaultDefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Include;

		// Token: 0x04000096 RID: 150
		internal const global::Newtonsoft.Json.ObjectCreationHandling DefaultObjectCreationHandling = global::Newtonsoft.Json.ObjectCreationHandling.Auto;

		// Token: 0x04000097 RID: 151
		internal const global::Newtonsoft.Json.PreserveReferencesHandling DefaultPreserveReferencesHandling = global::Newtonsoft.Json.PreserveReferencesHandling.None;

		// Token: 0x04000098 RID: 152
		internal const global::Newtonsoft.Json.ConstructorHandling DefaultConstructorHandling = global::Newtonsoft.Json.ConstructorHandling.Default;

		// Token: 0x04000099 RID: 153
		internal const global::Newtonsoft.Json.TypeNameHandling DefaultTypeNameHandling = global::Newtonsoft.Json.TypeNameHandling.None;

		// Token: 0x0400009A RID: 154
		internal const global::Newtonsoft.Json.MetadataPropertyHandling DefaultMetadataPropertyHandling = global::Newtonsoft.Json.MetadataPropertyHandling.Default;

		// Token: 0x0400009B RID: 155
		internal static readonly global::System.Runtime.Serialization.StreamingContext DefaultContext = default(global::System.Runtime.Serialization.StreamingContext);

		// Token: 0x0400009C RID: 156
		internal const global::Newtonsoft.Json.Formatting DefaultFormatting = global::Newtonsoft.Json.Formatting.None;

		// Token: 0x0400009D RID: 157
		internal const global::Newtonsoft.Json.DateFormatHandling DefaultDateFormatHandling = global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat;

		// Token: 0x0400009E RID: 158
		internal const global::Newtonsoft.Json.DateTimeZoneHandling DefaultDateTimeZoneHandling = global::Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind;

		// Token: 0x0400009F RID: 159
		internal const global::Newtonsoft.Json.DateParseHandling DefaultDateParseHandling = global::Newtonsoft.Json.DateParseHandling.DateTime;

		// Token: 0x040000A0 RID: 160
		internal const global::Newtonsoft.Json.FloatParseHandling DefaultFloatParseHandling = global::Newtonsoft.Json.FloatParseHandling.Double;

		// Token: 0x040000A1 RID: 161
		internal const global::Newtonsoft.Json.FloatFormatHandling DefaultFloatFormatHandling = global::Newtonsoft.Json.FloatFormatHandling.String;

		// Token: 0x040000A2 RID: 162
		internal const global::Newtonsoft.Json.StringEscapeHandling DefaultStringEscapeHandling = global::Newtonsoft.Json.StringEscapeHandling.Default;

		// Token: 0x040000A3 RID: 163
		internal const global::Newtonsoft.Json.TypeNameAssemblyFormatHandling DefaultTypeNameAssemblyFormatHandling = global::Newtonsoft.Json.TypeNameAssemblyFormatHandling.Simple;

		// Token: 0x040000A4 RID: 164
		[global::System.Runtime.CompilerServices.Nullable(1)]
		internal static readonly global::System.Globalization.CultureInfo DefaultCulture = global::System.Globalization.CultureInfo.InvariantCulture;

		// Token: 0x040000A5 RID: 165
		internal const bool DefaultCheckAdditionalContent = false;

		// Token: 0x040000A6 RID: 166
		[global::System.Runtime.CompilerServices.Nullable(1)]
		internal const string DefaultDateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x040000A7 RID: 167
		internal const int DefaultMaxDepth = 64;

		// Token: 0x040000A8 RID: 168
		internal global::Newtonsoft.Json.Formatting? _formatting;

		// Token: 0x040000A9 RID: 169
		internal global::Newtonsoft.Json.DateFormatHandling? _dateFormatHandling;

		// Token: 0x040000AA RID: 170
		internal global::Newtonsoft.Json.DateTimeZoneHandling? _dateTimeZoneHandling;

		// Token: 0x040000AB RID: 171
		internal global::Newtonsoft.Json.DateParseHandling? _dateParseHandling;

		// Token: 0x040000AC RID: 172
		internal global::Newtonsoft.Json.FloatFormatHandling? _floatFormatHandling;

		// Token: 0x040000AD RID: 173
		internal global::Newtonsoft.Json.FloatParseHandling? _floatParseHandling;

		// Token: 0x040000AE RID: 174
		internal global::Newtonsoft.Json.StringEscapeHandling? _stringEscapeHandling;

		// Token: 0x040000AF RID: 175
		internal global::System.Globalization.CultureInfo _culture;

		// Token: 0x040000B0 RID: 176
		internal bool? _checkAdditionalContent;

		// Token: 0x040000B1 RID: 177
		internal int? _maxDepth;

		// Token: 0x040000B2 RID: 178
		internal bool _maxDepthSet;

		// Token: 0x040000B3 RID: 179
		internal string _dateFormatString;

		// Token: 0x040000B4 RID: 180
		internal bool _dateFormatStringSet;

		// Token: 0x040000B5 RID: 181
		internal global::Newtonsoft.Json.TypeNameAssemblyFormatHandling? _typeNameAssemblyFormatHandling;

		// Token: 0x040000B6 RID: 182
		internal global::Newtonsoft.Json.DefaultValueHandling? _defaultValueHandling;

		// Token: 0x040000B7 RID: 183
		internal global::Newtonsoft.Json.PreserveReferencesHandling? _preserveReferencesHandling;

		// Token: 0x040000B8 RID: 184
		internal global::Newtonsoft.Json.NullValueHandling? _nullValueHandling;

		// Token: 0x040000B9 RID: 185
		internal global::Newtonsoft.Json.ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x040000BA RID: 186
		internal global::Newtonsoft.Json.MissingMemberHandling? _missingMemberHandling;

		// Token: 0x040000BB RID: 187
		internal global::Newtonsoft.Json.ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x040000BC RID: 188
		internal global::System.Runtime.Serialization.StreamingContext? _context;

		// Token: 0x040000BD RID: 189
		internal global::Newtonsoft.Json.ConstructorHandling? _constructorHandling;

		// Token: 0x040000BE RID: 190
		internal global::Newtonsoft.Json.TypeNameHandling? _typeNameHandling;

		// Token: 0x040000BF RID: 191
		internal global::Newtonsoft.Json.MetadataPropertyHandling? _metadataPropertyHandling;
	}
}
