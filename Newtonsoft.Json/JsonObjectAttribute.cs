using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x02000023 RID: 35
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonObjectAttribute : global::Newtonsoft.Json.JsonContainerAttribute
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003020 File Offset: 0x00001220
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00003028 File Offset: 0x00001228
		public global::Newtonsoft.Json.MemberSerialization MemberSerialization
		{
			get
			{
				return this._memberSerialization;
			}
			set
			{
				this._memberSerialization = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003031 File Offset: 0x00001231
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000303E File Offset: 0x0000123E
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

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000304C File Offset: 0x0000124C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00003059 File Offset: 0x00001259
		public global::Newtonsoft.Json.NullValueHandling ItemNullValueHandling
		{
			get
			{
				return this._itemNullValueHandling.GetValueOrDefault();
			}
			set
			{
				this._itemNullValueHandling = new global::Newtonsoft.Json.NullValueHandling?(value);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00003067 File Offset: 0x00001267
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00003074 File Offset: 0x00001274
		public global::Newtonsoft.Json.Required ItemRequired
		{
			get
			{
				return this._itemRequired.GetValueOrDefault();
			}
			set
			{
				this._itemRequired = new global::Newtonsoft.Json.Required?(value);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003082 File Offset: 0x00001282
		public JsonObjectAttribute()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000308A File Offset: 0x0000128A
		public JsonObjectAttribute(global::Newtonsoft.Json.MemberSerialization memberSerialization)
		{
			this.MemberSerialization = memberSerialization;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003099 File Offset: 0x00001299
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public JsonObjectAttribute(string id) : base(id)
		{
		}

		// Token: 0x04000040 RID: 64
		private global::Newtonsoft.Json.MemberSerialization _memberSerialization;

		// Token: 0x04000041 RID: 65
		internal global::Newtonsoft.Json.MissingMemberHandling? _missingMemberHandling;

		// Token: 0x04000042 RID: 66
		internal global::Newtonsoft.Json.Required? _itemRequired;

		// Token: 0x04000043 RID: 67
		internal global::Newtonsoft.Json.NullValueHandling? _itemNullValueHandling;
	}
}
