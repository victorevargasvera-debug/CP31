using System;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x0200010A RID: 266
	internal class BsonEmpty : global::Newtonsoft.Json.Bson.BsonToken
	{
		// Token: 0x06000D94 RID: 3476 RVA: 0x0003687A File Offset: 0x00034A7A
		private BsonEmpty(global::Newtonsoft.Json.Bson.BsonType type)
		{
			this.Type = type;
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000D95 RID: 3477 RVA: 0x00036889 File Offset: 0x00034A89
		public override global::Newtonsoft.Json.Bson.BsonType Type { get; }

		// Token: 0x04000420 RID: 1056
		public static readonly global::Newtonsoft.Json.Bson.BsonToken Null = new global::Newtonsoft.Json.Bson.BsonEmpty(global::Newtonsoft.Json.Bson.BsonType.Null);

		// Token: 0x04000421 RID: 1057
		public static readonly global::Newtonsoft.Json.Bson.BsonToken Undefined = new global::Newtonsoft.Json.Bson.BsonEmpty(global::Newtonsoft.Json.Bson.BsonType.Undefined);
	}
}
