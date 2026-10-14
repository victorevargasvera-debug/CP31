using System;
using System.Collections;
using System.Text;
using NPOI.HPSF.Wellknown;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x0200051B RID: 1307
	public class Section
	{
		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x00093EE2 File Offset: 0x000920E2
		public global::NPOI.Util.ClassID FormatID
		{
			get
			{
				return this.formatID;
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060030EE RID: 12526 RVA: 0x00093EEA File Offset: 0x000920EA
		public long OffSet
		{
			get
			{
				return this.offset;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060030EF RID: 12527 RVA: 0x00093EF2 File Offset: 0x000920F2
		public virtual int Size
		{
			get
			{
				return this.size;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060030F0 RID: 12528 RVA: 0x00093EFA File Offset: 0x000920FA
		public virtual int PropertyCount
		{
			get
			{
				return this.properties.Length;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060030F1 RID: 12529 RVA: 0x00093F04 File Offset: 0x00092104
		public virtual global::NPOI.HPSF.Property[] Properties
		{
			get
			{
				return this.properties;
			}
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0000253E File Offset: 0x0000073E
		protected Section()
		{
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x00093F0C File Offset: 0x0009210C
		public Section(byte[] src, int offset)
		{
			this.formatID = new global::NPOI.Util.ClassID(src, offset);
			int num = offset + 16;
			this.offset = global::NPOI.Util.LittleEndian.GetUInt(src, num);
			num = (int)this.offset;
			this.size = (int)global::NPOI.Util.LittleEndian.GetUInt(src, num);
			num += 4;
			int num2 = (int)global::NPOI.Util.LittleEndian.GetUInt(src, num);
			num += 4;
			this.properties = new global::NPOI.HPSF.Property[num2];
			int num3 = num;
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(num2);
			for (int i = 0; i < this.properties.Length; i++)
			{
				global::NPOI.HPSF.Section.PropertyListEntry propertyListEntry = new global::NPOI.HPSF.Section.PropertyListEntry();
				propertyListEntry.id = (int)global::NPOI.Util.LittleEndian.GetUInt(src, num3);
				num3 += 4;
				propertyListEntry.offset = (int)global::NPOI.Util.LittleEndian.GetUInt(src, num3);
				num3 += 4;
				arrayList.Add(propertyListEntry);
			}
			arrayList.Sort();
			for (int j = 0; j < num2 - 1; j++)
			{
				global::NPOI.HPSF.Section.PropertyListEntry propertyListEntry2 = (global::NPOI.HPSF.Section.PropertyListEntry)arrayList[j];
				global::NPOI.HPSF.Section.PropertyListEntry propertyListEntry3 = (global::NPOI.HPSF.Section.PropertyListEntry)arrayList[j + 1];
				propertyListEntry2.Length = propertyListEntry3.offset - propertyListEntry2.offset;
			}
			if (num2 > 0)
			{
				global::NPOI.HPSF.Section.PropertyListEntry propertyListEntry = (global::NPOI.HPSF.Section.PropertyListEntry)arrayList[num2 - 1];
				propertyListEntry.Length = this.size - propertyListEntry.offset;
			}
			int num4 = -1;
			global::System.Collections.IEnumerator enumerator = arrayList.GetEnumerator();
			while (num4 == -1 && enumerator.MoveNext())
			{
				global::NPOI.HPSF.Section.PropertyListEntry propertyListEntry = (global::NPOI.HPSF.Section.PropertyListEntry)enumerator.Current;
				if (propertyListEntry.id == 1)
				{
					int num5 = (int)(this.offset + (long)propertyListEntry.offset);
					long @uint = global::NPOI.Util.LittleEndian.GetUInt(src, num5);
					num5 += 4;
					if (@uint != 2L)
					{
						throw new global::NPOI.HPSF.HPSFRuntimeException("Value type of property ID 1 is not VT_I2 but " + @uint.ToString() + ".");
					}
					num4 = global::NPOI.Util.LittleEndian.GetUShort(src, num5);
				}
			}
			int num6 = 0;
			foreach (object obj in arrayList)
			{
				global::NPOI.HPSF.Section.PropertyListEntry propertyListEntry = (global::NPOI.HPSF.Section.PropertyListEntry)obj;
				global::NPOI.HPSF.Property property = new global::NPOI.HPSF.Property((long)propertyListEntry.id, src, this.offset + (long)propertyListEntry.offset, propertyListEntry.Length, num4);
				if (property.ID == 1L)
				{
					property = new global::NPOI.HPSF.Property(property.ID, property.Type, num4);
				}
				this.properties[num6++] = property;
			}
			this.dictionary = (global::System.Collections.IDictionary)this.GetProperty(0L);
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x00094158 File Offset: 0x00092358
		public virtual object GetProperty(long id)
		{
			this.wasNull = false;
			for (int i = 0; i < this.properties.Length; i++)
			{
				if (id == this.properties[i].ID)
				{
					return this.properties[i].Value;
				}
			}
			this.wasNull = true;
			return null;
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x000941A8 File Offset: 0x000923A8
		public virtual int GetPropertyIntValue(long id)
		{
			object property = this.GetProperty(id);
			if (property == null)
			{
				return 0;
			}
			if (!(property is long) && !(property is int))
			{
				throw new global::NPOI.HPSF.HPSFRuntimeException("This property is not an integer type, but " + property.GetType().Name + ".");
			}
			return (int)property;
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x000941F8 File Offset: 0x000923F8
		public virtual bool GetPropertyBooleanValue(int id)
		{
			return this.GetProperty((long)id) != null && (bool)this.GetProperty((long)id);
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060030F7 RID: 12535 RVA: 0x00094213 File Offset: 0x00092413
		public virtual bool WasNull
		{
			get
			{
				return this.wasNull;
			}
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x0009421C File Offset: 0x0009241C
		public string GetPIDString(long pid)
		{
			string text = null;
			if (this.dictionary != null)
			{
				text = (string)this.dictionary[pid];
			}
			if (text == null)
			{
				text = global::NPOI.HPSF.Wellknown.SectionIDMap.GetPIDString(this.FormatID.Bytes, pid);
			}
			return text;
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x00094260 File Offset: 0x00092460
		public override bool Equals(object o)
		{
			if (o == null || !(o is global::NPOI.HPSF.Section))
			{
				return false;
			}
			global::NPOI.HPSF.Section section = (global::NPOI.HPSF.Section)o;
			if (!section.FormatID.Equals(this.FormatID))
			{
				return false;
			}
			global::NPOI.HPSF.Property[] array = new global::NPOI.HPSF.Property[this.Properties.Length];
			global::NPOI.HPSF.Property[] array2 = new global::NPOI.HPSF.Property[section.Properties.Length];
			global::System.Array.Copy(this.Properties, 0, array, 0, array.Length);
			global::System.Array.Copy(section.Properties, 0, array2, 0, array2.Length);
			global::NPOI.HPSF.Property property = null;
			global::NPOI.HPSF.Property property2 = null;
			for (int i = 0; i < array.Length; i++)
			{
				long id = array[i].ID;
				if (id == 0L)
				{
					property = array[i];
					array = this.Remove(array, i);
					i--;
				}
				if (id == 1L)
				{
					array = this.Remove(array, i);
					i--;
				}
			}
			for (int j = 0; j < array2.Length; j++)
			{
				long id2 = array2[j].ID;
				if (id2 == 0L)
				{
					property2 = array2[j];
					array2 = this.Remove(array2, j);
					j--;
				}
				if (id2 == 1L)
				{
					array2 = this.Remove(array2, j);
					j--;
				}
			}
			if (array.Length != array2.Length)
			{
				return false;
			}
			bool flag = true;
			if (property != null && property2 != null)
			{
				global::System.Collections.Hashtable hashtable = (global::System.Collections.Hashtable)property.Value;
				global::System.Collections.Hashtable hashtable2 = (global::System.Collections.Hashtable)property2.Value;
				flag = (hashtable.Count == hashtable2.Count);
			}
			else if (property != null || property2 != null)
			{
				flag = false;
			}
			return flag && global::NPOI.HPSF.Util.AreEqual(array, array2);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x000943C0 File Offset: 0x000925C0
		private global::NPOI.HPSF.Property[] Remove(global::NPOI.HPSF.Property[] pa, int i)
		{
			global::NPOI.HPSF.Property[] array = new global::NPOI.HPSF.Property[pa.Length - 1];
			if (i > 0)
			{
				global::System.Array.Copy(pa, 0, array, 0, i);
			}
			global::System.Array.Copy(pa, i + 1, array, i, array.Length - i);
			return array;
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x000943F8 File Offset: 0x000925F8
		public override int GetHashCode()
		{
			long num = 0L;
			num += (long)this.FormatID.GetHashCode();
			global::NPOI.HPSF.Property[] array = this.Properties;
			for (int i = 0; i < array.Length; i++)
			{
				num += (long)array[i].GetHashCode();
			}
			return (int)(num & (long)((ulong)-1));
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x00094440 File Offset: 0x00092640
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::NPOI.HPSF.Property[] array = this.Properties;
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append('[');
			stringBuilder.Append("formatID: ");
			stringBuilder.Append(this.FormatID);
			stringBuilder.Append(", offset: ");
			stringBuilder.Append(this.OffSet);
			stringBuilder.Append(", propertyCount: ");
			stringBuilder.Append(this.PropertyCount);
			stringBuilder.Append(", size: ");
			stringBuilder.Append(this.Size);
			stringBuilder.Append(", properties: [\n");
			for (int i = 0; i < array.Length; i++)
			{
				stringBuilder.Append(array[i].ToString());
				stringBuilder.Append(",\n");
			}
			stringBuilder.Append(']');
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060030FD RID: 12541 RVA: 0x00094526 File Offset: 0x00092726
		// (set) Token: 0x060030FE RID: 12542 RVA: 0x00094541 File Offset: 0x00092741
		public virtual global::System.Collections.IDictionary Dictionary
		{
			get
			{
				if (this.dictionary == null)
				{
					this.dictionary = new global::System.Collections.Hashtable();
				}
				return this.dictionary;
			}
			set
			{
				this.dictionary = value;
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060030FF RID: 12543 RVA: 0x0009454A File Offset: 0x0009274A
		public int Codepage
		{
			get
			{
				if (this.GetProperty(1L) == null)
				{
					return -1;
				}
				return (int)this.GetProperty(1L);
			}
		}

		// Token: 0x04001599 RID: 5529
		protected global::System.Collections.IDictionary dictionary;

		// Token: 0x0400159A RID: 5530
		protected global::NPOI.Util.ClassID formatID;

		// Token: 0x0400159B RID: 5531
		protected long offset;

		// Token: 0x0400159C RID: 5532
		protected int size;

		// Token: 0x0400159D RID: 5533
		protected global::NPOI.HPSF.Property[] properties;

		// Token: 0x0400159E RID: 5534
		private bool wasNull;

		// Token: 0x0200062A RID: 1578
		private class PropertyListEntry : global::System.IComparable
		{
			// Token: 0x060036DF RID: 14047 RVA: 0x000A79B0 File Offset: 0x000A5BB0
			public int CompareTo(object o)
			{
				if (!(o is global::NPOI.HPSF.Section.PropertyListEntry))
				{
					throw new global::System.InvalidCastException(o.ToString());
				}
				int num = ((global::NPOI.HPSF.Section.PropertyListEntry)o).offset;
				if (this.offset < num)
				{
					return -1;
				}
				if (this.offset == num)
				{
					return 0;
				}
				return 1;
			}

			// Token: 0x060036E0 RID: 14048 RVA: 0x000A79F4 File Offset: 0x000A5BF4
			public override int GetHashCode()
			{
				int num = 31;
				int num2 = 1;
				num2 = num * num2 + this.id;
				num2 = num * num2 + this.Length;
				return num * num2 + this.offset;
			}

			// Token: 0x060036E1 RID: 14049 RVA: 0x000A7A28 File Offset: 0x000A5C28
			public override bool Equals(object obj)
			{
				if (this == obj)
				{
					return true;
				}
				if (obj == null)
				{
					return false;
				}
				if (base.GetType() != obj.GetType())
				{
					return false;
				}
				global::NPOI.HPSF.Section.PropertyListEntry propertyListEntry = (global::NPOI.HPSF.Section.PropertyListEntry)obj;
				return this.id == propertyListEntry.id && this.Length == propertyListEntry.Length && this.offset == propertyListEntry.offset;
			}

			// Token: 0x060036E2 RID: 14050 RVA: 0x000A7A90 File Offset: 0x000A5C90
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(base.GetType().Name);
				stringBuilder.Append("[id=");
				stringBuilder.Append(this.id);
				stringBuilder.Append(", offset=");
				stringBuilder.Append(this.offset);
				stringBuilder.Append(", Length=");
				stringBuilder.Append(this.Length);
				stringBuilder.Append(']');
				return stringBuilder.ToString();
			}

			// Token: 0x04001ABE RID: 6846
			public int id;

			// Token: 0x04001ABF RID: 6847
			public int offset;

			// Token: 0x04001AC0 RID: 6848
			public int Length;
		}
	}
}
