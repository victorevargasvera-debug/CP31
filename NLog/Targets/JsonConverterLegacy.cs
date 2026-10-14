using System;
using System.Text;

namespace NLog.Targets
{
	// Token: 0x0200003E RID: 62
	internal class JsonConverterLegacy : global::NLog.IJsonConverter, global::NLog.Targets.IJsonSerializer
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x0000EE9D File Offset: 0x0000D09D
		public JsonConverterLegacy(global::NLog.Targets.IJsonSerializer jsonSerializer)
		{
			this._jsonSerializer = jsonSerializer;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000EEAC File Offset: 0x0000D0AC
		public bool SerializeObject(object value, global::System.Text.StringBuilder builder)
		{
			string text = this._jsonSerializer.SerializeObject(value);
			if (text == null)
			{
				return false;
			}
			builder.Append(text);
			return true;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000EED4 File Offset: 0x0000D0D4
		string global::NLog.Targets.IJsonSerializer.SerializeObject(object value)
		{
			return this._jsonSerializer.SerializeObject(value);
		}

		// Token: 0x04000105 RID: 261
		private readonly global::NLog.Targets.IJsonSerializer _jsonSerializer;
	}
}
