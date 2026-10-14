using System;
using System.Collections;

namespace DevAge.Configuration
{
	// Token: 0x0200028C RID: 652
	internal class PersistableItemDictionary : global::System.Collections.DictionaryBase
	{
		// Token: 0x17000AE6 RID: 2790
		public virtual global::DevAge.Configuration.PersistableItem this[string key]
		{
			get
			{
				return (global::DevAge.Configuration.PersistableItem)base.Dictionary[key];
			}
			set
			{
				base.Dictionary[key] = value;
			}
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x000771BC File Offset: 0x000753BC
		public virtual void Add(string key, global::DevAge.Configuration.PersistableItem value)
		{
			base.Dictionary.Add(key, value);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x000771CC File Offset: 0x000753CC
		public virtual bool Contains(string key)
		{
			return base.Dictionary.Contains(key);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x000771DC File Offset: 0x000753DC
		public virtual bool ContainsKey(string key)
		{
			return base.Dictionary.Contains(key);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000771EC File Offset: 0x000753EC
		public virtual bool ContainsValue(global::DevAge.Configuration.PersistableItem value)
		{
			foreach (object obj in base.Dictionary.Values)
			{
				global::DevAge.Configuration.PersistableItem persistableItem = (global::DevAge.Configuration.PersistableItem)obj;
				if (persistableItem == value)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x00077260 File Offset: 0x00075460
		public virtual void Remove(string key)
		{
			base.Dictionary.Remove(key);
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x00077270 File Offset: 0x00075470
		public virtual global::System.Collections.ICollection Keys
		{
			get
			{
				return base.Dictionary.Keys;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002178 RID: 8568 RVA: 0x00077280 File Offset: 0x00075480
		public virtual global::System.Collections.ICollection Values
		{
			get
			{
				return base.Dictionary.Values;
			}
		}
	}
}
