using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000C1 RID: 193
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JRaw : global::Newtonsoft.Json.Linq.JValue
	{
		// Token: 0x06000AAA RID: 2730 RVA: 0x0002AAB8 File Offset: 0x00028CB8
		public static global::System.Threading.Tasks.Task<global::Newtonsoft.Json.Linq.JRaw> CreateAsync(global::Newtonsoft.Json.JsonReader reader, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			global::Newtonsoft.Json.Linq.JRaw.<CreateAsync>d__0 <CreateAsync>d__;
			<CreateAsync>d__.<>t__builder = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::Newtonsoft.Json.Linq.JRaw>.Create();
			<CreateAsync>d__.reader = reader;
			<CreateAsync>d__.cancellationToken = cancellationToken;
			<CreateAsync>d__.<>1__state = -1;
			<CreateAsync>d__.<>t__builder.Start<global::Newtonsoft.Json.Linq.JRaw.<CreateAsync>d__0>(ref <CreateAsync>d__);
			return <CreateAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0002AB03 File Offset: 0x00028D03
		public JRaw(global::Newtonsoft.Json.Linq.JRaw other) : base(other)
		{
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0002AB0C File Offset: 0x00028D0C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public JRaw(object rawJson) : base(rawJson, global::Newtonsoft.Json.Linq.JTokenType.Raw)
		{
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0002AB18 File Offset: 0x00028D18
		public static global::Newtonsoft.Json.Linq.JRaw Create(global::Newtonsoft.Json.JsonReader reader)
		{
			global::Newtonsoft.Json.Linq.JRaw result;
			using (global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture))
			{
				using (global::Newtonsoft.Json.JsonTextWriter jsonTextWriter = new global::Newtonsoft.Json.JsonTextWriter(stringWriter))
				{
					jsonTextWriter.WriteToken(reader);
					result = new global::Newtonsoft.Json.Linq.JRaw(stringWriter.ToString());
				}
			}
			return result;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0002AB80 File Offset: 0x00028D80
		internal override global::Newtonsoft.Json.Linq.JToken CloneToken()
		{
			return new global::Newtonsoft.Json.Linq.JRaw(this);
		}
	}
}
