using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200012E RID: 302
	internal class WrappedEntityKey
	{
		// Token: 0x060014A8 RID: 5288 RVA: 0x00035014 File Offset: 0x00033214
		public WrappedEntityKey(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, string entitySetName, object[] keyValues, string keyValuesParamName)
		{
			if (keyValues == null)
			{
				keyValues = new object[1];
			}
			global::System.Collections.Generic.List<string> list = (from m in entitySet.ElementType.KeyMembers
			select m.Name).ToList<string>();
			if (list.Count != keyValues.Length)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbSet_WrongNumberOfKeyValuesPassed, keyValuesParamName);
			}
			this._keyValuePairs = list.Zip(keyValues, (string name, object value) => new global::System.Collections.Generic.KeyValuePair<string, object>(name, value));
			if (keyValues.All((object v) => v != null))
			{
				this._key = new global::System.Data.Entity.Core.EntityKey(entitySetName, this.KeyValuePairs);
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x000350E4 File Offset: 0x000332E4
		public bool HasNullValues
		{
			get
			{
				return this._key == null;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x000350F2 File Offset: 0x000332F2
		public global::System.Data.Entity.Core.EntityKey EntityKey
		{
			get
			{
				return this._key;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x000350FA File Offset: 0x000332FA
		public global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> KeyValuePairs
		{
			get
			{
				return this._keyValuePairs;
			}
		}

		// Token: 0x040009B6 RID: 2486
		private readonly global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>> _keyValuePairs;

		// Token: 0x040009B7 RID: 2487
		private readonly global::System.Data.Entity.Core.EntityKey _key;
	}
}
