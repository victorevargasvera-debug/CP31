using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x02000108 RID: 264
	internal class BsonObject : global::Newtonsoft.Json.Bson.BsonToken, global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Bson.BsonProperty>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x000367D8 File Offset: 0x000349D8
		public void Add(string name, global::Newtonsoft.Json.Bson.BsonToken token)
		{
			this._children.Add(new global::Newtonsoft.Json.Bson.BsonProperty
			{
				Name = new global::Newtonsoft.Json.Bson.BsonString(name, false),
				Value = token
			});
			token.Parent = this;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000D8B RID: 3467 RVA: 0x00036805 File Offset: 0x00034A05
		public override global::Newtonsoft.Json.Bson.BsonType Type
		{
			get
			{
				return global::Newtonsoft.Json.Bson.BsonType.Object;
			}
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00036808 File Offset: 0x00034A08
		public global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Bson.BsonProperty> GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x0003681A File Offset: 0x00034A1A
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400041E RID: 1054
		private readonly global::System.Collections.Generic.List<global::Newtonsoft.Json.Bson.BsonProperty> _children = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Bson.BsonProperty>();
	}
}
