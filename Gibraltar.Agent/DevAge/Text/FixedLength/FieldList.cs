using System;
using System.Collections;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000274 RID: 628
	internal class FieldList : global::System.Collections.DictionaryBase
	{
		// Token: 0x17000AA9 RID: 2729
		public virtual global::DevAge.Text.FixedLength.IField this[string key]
		{
			get
			{
				return (global::DevAge.Text.FixedLength.IField)base.Dictionary[key];
			}
			set
			{
				base.Dictionary[key] = value;
			}
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x00073E44 File Offset: 0x00072044
		public virtual void Add(global::DevAge.Text.FixedLength.IField value)
		{
			base.Dictionary.Add(value.Name, value);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x00073E58 File Offset: 0x00072058
		public virtual bool Contains(string fieldName)
		{
			return base.Dictionary.Contains(fieldName);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x00073E68 File Offset: 0x00072068
		public virtual bool ContainsKey(string fieldName)
		{
			return base.Dictionary.Contains(fieldName);
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00073E78 File Offset: 0x00072078
		public virtual bool ContainsValue(global::DevAge.Text.FixedLength.IField value)
		{
			foreach (object obj in base.Dictionary.Values)
			{
				global::DevAge.Text.FixedLength.IField field = (global::DevAge.Text.FixedLength.IField)obj;
				if (field == value)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x00073EEC File Offset: 0x000720EC
		public virtual void Remove(string fieldName)
		{
			base.Dictionary.Remove(fieldName);
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x00073EFC File Offset: 0x000720FC
		public virtual global::System.Collections.ICollection Keys
		{
			get
			{
				return base.Dictionary.Keys;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x00073F0C File Offset: 0x0007210C
		public virtual global::System.Collections.ICollection Values
		{
			get
			{
				return base.Dictionary.Values;
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x00073F1C File Offset: 0x0007211C
		public global::DevAge.Text.FixedLength.IField[] GetSortedList()
		{
			global::DevAge.Text.FixedLength.IField[] array = new global::DevAge.Text.FixedLength.IField[base.Count];
			for (int i = 0; i < array.Length; i++)
			{
				foreach (object obj in this.Values)
				{
					global::DevAge.Text.FixedLength.IField field = (global::DevAge.Text.FixedLength.IField)obj;
					if (field.Index == i)
					{
						array[i] = field;
						break;
					}
				}
				if (array[i] == null)
				{
					throw new global::DevAge.Text.FixedLength.FieldNotDefinedException(i);
				}
			}
			return array;
		}
	}
}
