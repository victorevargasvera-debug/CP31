using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x0200001C RID: 28
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Enum | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Interface | global::System.AttributeTargets.Parameter, AllowMultiple = false)]
	public sealed class JsonConverterAttribute : global::System.Attribute
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002F45 File Offset: 0x00001145
		public global::System.Type ConverterType
		{
			get
			{
				return this._converterType;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00002F4D File Offset: 0x0000114D
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] ConverterParameters { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] get; }

		// Token: 0x0600008F RID: 143 RVA: 0x00002F55 File Offset: 0x00001155
		public JsonConverterAttribute(global::System.Type converterType)
		{
			if (converterType == null)
			{
				throw new global::System.ArgumentNullException("converterType");
			}
			this._converterType = converterType;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002F78 File Offset: 0x00001178
		public JsonConverterAttribute(global::System.Type converterType, params object[] converterParameters) : this(converterType)
		{
			this.ConverterParameters = converterParameters;
		}

		// Token: 0x0400003C RID: 60
		private readonly global::System.Type _converterType;
	}
}
