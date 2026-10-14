using System;
using System.Collections;
using System.Text;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000508 RID: 1288
	public class CustomProperties : global::System.Collections.Hashtable
	{
		// Token: 0x06003002 RID: 12290 RVA: 0x0009184C File Offset: 0x0008FA4C
		public global::NPOI.HPSF.CustomProperty Put(string name, global::NPOI.HPSF.CustomProperty cp)
		{
			if (string.IsNullOrEmpty(name))
			{
				this.isPure = false;
				return null;
			}
			if (name == null)
			{
				throw new global::System.ArgumentException("The name of a custom property must be a String, but it is a " + name.GetType().Name);
			}
			if (!name.Equals(cp.Name))
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Parameter \"name\" (",
					name,
					") and custom property's name (",
					cp.Name,
					") do not match."
				}));
			}
			long id = cp.ID;
			object obj = this.dictionaryNameToID[name];
			if (obj != null)
			{
				this.dictionaryIDToName.Remove(obj);
			}
			this.dictionaryNameToID[name] = id;
			this.dictionaryIDToName[id] = name;
			if (obj != null)
			{
				base.Remove(obj);
			}
			base[id] = cp;
			return cp;
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x0009192B File Offset: 0x0008FB2B
		public global::System.Collections.ICollection KeySet()
		{
			return this.dictionaryNameToID.Keys;
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x0009192B File Offset: 0x0008FB2B
		public global::System.Collections.ICollection NameSet()
		{
			return this.dictionaryNameToID.Keys;
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x0009192B File Offset: 0x0008FB2B
		public global::System.Collections.ICollection IdSet()
		{
			return this.dictionaryNameToID.Keys;
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x00091938 File Offset: 0x0008FB38
		private object Put(global::NPOI.HPSF.CustomProperty customProperty)
		{
			string name = customProperty.Name;
			object obj = this.dictionaryNameToID[name];
			if (obj != null)
			{
				customProperty.ID = (long)obj;
			}
			else
			{
				long num = 1L;
				foreach (object obj2 in this.dictionaryIDToName.Keys)
				{
					long num2 = (long)obj2;
					if (num2 > num)
					{
						num = num2;
					}
				}
				customProperty.ID = num + 1L;
			}
			return this.Put(name, customProperty);
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x000919B0 File Offset: 0x0008FBB0
		public object Remove(string name)
		{
			if (this.dictionaryNameToID[name] == null)
			{
				return null;
			}
			long num = (long)this.dictionaryNameToID[name];
			this.dictionaryIDToName.Remove(num);
			this.dictionaryNameToID.Remove(name);
			object result = (global::NPOI.HPSF.CustomProperty)this[num];
			this.Remove(num);
			return result;
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x00091A1C File Offset: 0x0008FC1C
		public object Put(string name, string value)
		{
			global::NPOI.HPSF.CustomProperty customProperty = new global::NPOI.HPSF.CustomProperty(new global::NPOI.HPSF.MutableProperty
			{
				ID = -1L,
				Type = 31L,
				Value = value
			}, name);
			return this.Put(customProperty);
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x00091A54 File Offset: 0x0008FC54
		public object Put(string name, long value)
		{
			global::NPOI.HPSF.CustomProperty customProperty = new global::NPOI.HPSF.CustomProperty(new global::NPOI.HPSF.MutableProperty
			{
				ID = -1L,
				Type = 20L,
				Value = value
			}, name);
			return this.Put(customProperty);
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x00091A94 File Offset: 0x0008FC94
		public object Put(string name, double value)
		{
			global::NPOI.HPSF.CustomProperty customProperty = new global::NPOI.HPSF.CustomProperty(new global::NPOI.HPSF.MutableProperty
			{
				ID = -1L,
				Type = 5L,
				Value = value
			}, name);
			return this.Put(customProperty);
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x00091AD0 File Offset: 0x0008FCD0
		public object Put(string name, int value)
		{
			global::NPOI.HPSF.CustomProperty customProperty = new global::NPOI.HPSF.CustomProperty(new global::NPOI.HPSF.MutableProperty
			{
				ID = -1L,
				Type = 3L,
				Value = value
			}, name);
			return this.Put(customProperty);
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x00091B0C File Offset: 0x0008FD0C
		public object Put(string name, bool value)
		{
			global::NPOI.HPSF.CustomProperty customProperty = new global::NPOI.HPSF.CustomProperty(new global::NPOI.HPSF.MutableProperty
			{
				ID = -1L,
				Type = 11L,
				Value = value
			}, name);
			return this.Put(customProperty);
		}

		// Token: 0x0600300D RID: 12301 RVA: 0x00091B4C File Offset: 0x0008FD4C
		public object Put(string name, global::System.DateTime value)
		{
			global::NPOI.HPSF.CustomProperty customProperty = new global::NPOI.HPSF.CustomProperty(new global::NPOI.HPSF.MutableProperty
			{
				ID = -1L,
				Type = 64L,
				Value = value
			}, name);
			return this.Put(customProperty);
		}

		// Token: 0x17000C88 RID: 3208
		public object this[string name]
		{
			get
			{
				object obj = this.dictionaryNameToID[name];
				if (obj == null)
				{
					foreach (object obj2 in this.dictionaryNameToID)
					{
						string s = ((global::System.Collections.DictionaryEntry)obj2).Key as string;
						int num = this.Codepage;
						if (num < 0)
						{
							num = 1200;
						}
						object bytes = global::System.Text.Encoding.GetEncoding(num).GetBytes(s);
						byte[] bytes2 = global::System.Text.Encoding.UTF8.GetBytes(name);
						if (global::NPOI.Util.Arrays.Equals(bytes, bytes2))
						{
							global::System.Collections.IEnumerator enumerator;
							global::System.Collections.DictionaryEntry dictionaryEntry = (global::System.Collections.DictionaryEntry)enumerator.Current;
							obj = dictionaryEntry.Value;
						}
					}
					if (obj == null)
					{
						return null;
					}
				}
				long num2 = (long)obj;
				global::NPOI.HPSF.CustomProperty customProperty = (global::NPOI.HPSF.CustomProperty)base[num2];
				if (customProperty == null)
				{
					return null;
				}
				return customProperty.Value;
			}
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x00091C54 File Offset: 0x0008FE54
		public override bool ContainsKey(object key)
		{
			if (key is long)
			{
				return base.ContainsKey((long)key);
			}
			return key is string && base.ContainsKey((long)this.dictionaryNameToID[key]);
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x00091CA4 File Offset: 0x0008FEA4
		public override bool ContainsValue(object value)
		{
			if (value is global::NPOI.HPSF.CustomProperty)
			{
				return base.ContainsValue(value);
			}
			using (global::System.Collections.IEnumerator enumerator = base.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if ((enumerator.Current as global::NPOI.HPSF.CustomProperty).Value == value)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06003011 RID: 12305 RVA: 0x00091D14 File Offset: 0x0008FF14
		public global::System.Collections.IDictionary Dictionary
		{
			get
			{
				return this.dictionaryIDToName;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06003012 RID: 12306 RVA: 0x00091D1C File Offset: 0x0008FF1C
		// (set) Token: 0x06003013 RID: 12307 RVA: 0x00091D68 File Offset: 0x0008FF68
		public int Codepage
		{
			get
			{
				int num = -1;
				global::System.Collections.IEnumerator enumerator = this.Values.GetEnumerator();
				while (num == -1 && enumerator.MoveNext())
				{
					global::NPOI.HPSF.CustomProperty customProperty = (global::NPOI.HPSF.CustomProperty)enumerator.Current;
					if (customProperty.ID == 1L)
					{
						num = (int)customProperty.Value;
					}
				}
				return num;
			}
			set
			{
				this.Put(new global::NPOI.HPSF.CustomProperty(new global::NPOI.HPSF.MutableProperty
				{
					ID = 1L,
					Type = 2L,
					Value = value
				}));
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06003014 RID: 12308 RVA: 0x00091DA4 File Offset: 0x0008FFA4
		// (set) Token: 0x06003015 RID: 12309 RVA: 0x00091DAC File Offset: 0x0008FFAC
		public bool IsPure
		{
			get
			{
				return this.isPure;
			}
			set
			{
				this.isPure = value;
			}
		}

		// Token: 0x04001583 RID: 5507
		private global::System.Collections.Hashtable dictionaryIDToName = new global::System.Collections.Hashtable();

		// Token: 0x04001584 RID: 5508
		private global::System.Collections.Hashtable dictionaryNameToID = new global::System.Collections.Hashtable();

		// Token: 0x04001585 RID: 5509
		private bool isPure = true;
	}
}
