using System;
using System.Collections.Generic;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000F5 RID: 245
	internal class DbContextTypesInitializersPair : global::System.Tuple<global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<string>>, global::System.Action<global::System.Data.Entity.DbContext>>
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x0002E27E File Offset: 0x0002C47E
		public DbContextTypesInitializersPair(global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<string>> entityTypeToPropertyNameMap, global::System.Action<global::System.Data.Entity.DbContext> setsInitializer) : base(entityTypeToPropertyNameMap, setsInitializer)
		{
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x0002E288 File Offset: 0x0002C488
		public global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.List<string>> EntityTypeToPropertyNameMap
		{
			get
			{
				return base.Item1;
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0002E290 File Offset: 0x0002C490
		public global::System.Action<global::System.Data.Entity.DbContext> SetsInitializer
		{
			get
			{
				return base.Item2;
			}
		}
	}
}
