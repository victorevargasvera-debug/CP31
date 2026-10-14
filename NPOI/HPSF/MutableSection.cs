using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000513 RID: 1299
	public class MutableSection : global::NPOI.HPSF.Section
	{
		// Token: 0x06003092 RID: 12434 RVA: 0x000929F4 File Offset: 0x00090BF4
		public MutableSection()
		{
			this.dirty = true;
			this.formatID = null;
			this.offset = -1L;
			this.preprops = new global::System.Collections.ArrayList();
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x00092A24 File Offset: 0x00090C24
		public MutableSection(global::NPOI.HPSF.Section s)
		{
			this.SetFormatID(s.FormatID);
			global::NPOI.HPSF.Property[] properties = s.Properties;
			global::NPOI.HPSF.MutableProperty[] array = new global::NPOI.HPSF.MutableProperty[properties.Length];
			for (int i = 0; i < properties.Length; i++)
			{
				array[i] = new global::NPOI.HPSF.MutableProperty(properties[i]);
			}
			global::NPOI.HPSF.Property[] properties2 = array;
			this.SetProperties(properties2);
			this.Dictionary = s.Dictionary;
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x00092A88 File Offset: 0x00090C88
		public void SetFormatID(global::NPOI.Util.ClassID formatID)
		{
			this.formatID = formatID;
		}

		// Token: 0x06003095 RID: 12437 RVA: 0x00092A94 File Offset: 0x00090C94
		public void SetFormatID(byte[] formatID)
		{
			global::NPOI.Util.ClassID classID = base.FormatID;
			if (classID == null)
			{
				classID = new global::NPOI.Util.ClassID();
				this.SetFormatID(classID);
			}
			classID.Bytes = formatID;
		}

		// Token: 0x06003096 RID: 12438 RVA: 0x00092AC0 File Offset: 0x00090CC0
		public void SetProperties(global::NPOI.HPSF.Property[] properties)
		{
			this.properties = properties;
			this.preprops = new global::System.Collections.ArrayList();
			for (int i = 0; i < properties.Length; i++)
			{
				this.preprops.Add(properties[i]);
			}
			this.dirty = true;
		}

		// Token: 0x06003097 RID: 12439 RVA: 0x00092B03 File Offset: 0x00090D03
		public void SetProperty(int id, string value)
		{
			this.SetProperty(id, 31L, value);
			this.dirty = true;
		}

		// Token: 0x06003098 RID: 12440 RVA: 0x00092B17 File Offset: 0x00090D17
		public void SetProperty(int id, int value)
		{
			this.SetProperty(id, 3L, value);
			this.dirty = true;
		}

		// Token: 0x06003099 RID: 12441 RVA: 0x00092B2F File Offset: 0x00090D2F
		public void SetProperty(int id, long value)
		{
			this.SetProperty(id, 20L, value);
			this.dirty = true;
		}

		// Token: 0x0600309A RID: 12442 RVA: 0x00092B48 File Offset: 0x00090D48
		public void SetProperty(int id, bool value)
		{
			this.SetProperty(id, 11L, value);
			this.dirty = true;
		}

		// Token: 0x0600309B RID: 12443 RVA: 0x00092B64 File Offset: 0x00090D64
		public void SetProperty(int id, long variantType, object value)
		{
			this.SetProperty(new global::NPOI.HPSF.MutableProperty
			{
				ID = (long)id,
				Type = variantType,
				Value = value
			});
			this.dirty = true;
		}

		// Token: 0x0600309C RID: 12444 RVA: 0x00092B9C File Offset: 0x00090D9C
		public void SetProperty(global::NPOI.HPSF.Property p)
		{
			long id = p.ID;
			this.RemoveProperty(id);
			this.preprops.Add(p);
			this.dirty = true;
		}

		// Token: 0x0600309D RID: 12445 RVA: 0x00092BCC File Offset: 0x00090DCC
		public void RemoveProperty(long id)
		{
			global::System.Collections.IEnumerator enumerator = this.preprops.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (((global::NPOI.HPSF.Property)enumerator.Current).ID == id)
				{
					this.preprops.Remove(enumerator.Current);
					break;
				}
			}
			this.dirty = true;
		}

		// Token: 0x0600309E RID: 12446 RVA: 0x00092C1C File Offset: 0x00090E1C
		protected void SetPropertyBooleanValue(int id, bool value)
		{
			this.SetProperty(id, 11L, value);
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x00092C30 File Offset: 0x00090E30
		public override int Size
		{
			get
			{
				if (this.dirty)
				{
					try
					{
						this.size = this.CalcSize();
						this.dirty = false;
					}
					catch (global::System.Exception)
					{
						throw;
					}
				}
				return this.size;
			}
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x00092C74 File Offset: 0x00090E74
		private int CalcSize()
		{
			int result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				this.Write(memoryStream);
				this.sectionBytes = global::NPOI.HPSF.Util.Pad4(memoryStream.ToArray());
				result = this.sectionBytes.Length;
			}
			return result;
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x00092CC8 File Offset: 0x00090EC8
		public int Write(global::System.IO.Stream out1)
		{
			if (!this.dirty && this.sectionBytes != null)
			{
				out1.Write(this.sectionBytes, 0, this.sectionBytes.Length);
				return this.sectionBytes.Length;
			}
			int result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream())
				{
					int num = 0;
					num += 8 + this.PropertyCount * 2 * 4;
					int num2 = -1;
					if (this.GetProperty(0L) != null)
					{
						object property = this.GetProperty(1L);
						if (property != null)
						{
							if (!(property is int))
							{
								throw new global::NPOI.HPSF.IllegalPropertySetDataException("The codepage property (ID = 1) must be an Integer object.");
							}
						}
						else
						{
							this.SetProperty(1, 2L, 1200);
						}
						num2 = this.Codepage;
					}
					this.preprops.Sort(new global::NPOI.HPSF.MutableSection.PropertyComparer());
					for (int i = 0; i < this.preprops.Count; i++)
					{
						global::NPOI.HPSF.MutableProperty mutableProperty = (global::NPOI.HPSF.MutableProperty)this.preprops[i];
						bool id = mutableProperty.ID != 0L;
						global::NPOI.HPSF.TypeWriter.WriteUIntToStream(memoryStream2, (uint)mutableProperty.ID);
						global::NPOI.HPSF.TypeWriter.WriteUIntToStream(memoryStream2, (uint)num);
						if (id)
						{
							num += mutableProperty.Write(memoryStream, this.Codepage);
						}
						else
						{
							if (num2 == -1)
							{
								throw new global::NPOI.HPSF.IllegalPropertySetDataException("Codepage (property 1) is undefined.");
							}
							num += global::NPOI.HPSF.MutableSection.WriteDictionary(memoryStream, this.dictionary, num2);
						}
					}
					memoryStream.Flush();
					memoryStream2.Flush();
					byte[] array = memoryStream2.ToArray();
					byte[] array2 = memoryStream.ToArray();
					global::NPOI.HPSF.TypeWriter.WriteToStream(out1, 8 + array.Length + array2.Length);
					global::NPOI.HPSF.TypeWriter.WriteToStream(out1, this.PropertyCount);
					out1.Write(array, 0, array.Length);
					out1.Write(array2, 0, array2.Length);
					result = 8 + array.Length + array2.Length;
				}
			}
			return result;
		}

		// Token: 0x060030A2 RID: 12450 RVA: 0x00092EA8 File Offset: 0x000910A8
		private static int WriteDictionary(global::System.IO.Stream out1, global::System.Collections.IDictionary dictionary, int codepage)
		{
			int num = global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)dictionary.Count);
			foreach (object value in dictionary.Keys)
			{
				long num2 = global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.InvariantCulture);
				string text = (string)dictionary[num2];
				if (text == null)
				{
					text = (string)dictionary[(int)num2];
				}
				if (codepage == 1200)
				{
					int i = text.Length + 1;
					if ((i & 1) == 1)
					{
						i++;
					}
					num += global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)num2);
					num += global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)i);
					byte[] bytes = global::System.Text.Encoding.GetEncoding(codepage).GetBytes(text);
					for (int j = 0; j < bytes.Length; j++)
					{
						out1.WriteByte(bytes[j]);
						num++;
					}
					for (i -= text.Length; i > 0; i--)
					{
						out1.WriteByte(0);
						out1.WriteByte(0);
						num += 2;
					}
				}
				else
				{
					num += global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)num2);
					num += global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)(text.Length + 1));
					try
					{
						byte[] bytes2 = global::System.Text.Encoding.GetEncoding(codepage).GetBytes(text);
						for (int k = 0; k < bytes2.Length; k++)
						{
							out1.WriteByte(bytes2[k]);
							num++;
						}
					}
					catch (global::System.Exception reason)
					{
						throw new global::NPOI.HPSF.IllegalPropertySetDataException(reason);
					}
					out1.WriteByte(0);
					num++;
				}
			}
			return num;
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x060030A3 RID: 12451 RVA: 0x0009301C File Offset: 0x0009121C
		public override int PropertyCount
		{
			get
			{
				return this.preprops.Count;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x00093029 File Offset: 0x00091229
		public override global::NPOI.HPSF.Property[] Properties
		{
			get
			{
				this.EnsureProperties();
				return this.properties;
			}
		}

		// Token: 0x060030A5 RID: 12453 RVA: 0x00093037 File Offset: 0x00091237
		public void EnsureProperties()
		{
			this.properties = (global::NPOI.HPSF.Property[])this.preprops.ToArray(typeof(global::NPOI.HPSF.Property));
		}

		// Token: 0x060030A6 RID: 12454 RVA: 0x00093059 File Offset: 0x00091259
		public override object GetProperty(long id)
		{
			this.EnsureProperties();
			return base.GetProperty(id);
		}

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x060030A7 RID: 12455 RVA: 0x00093068 File Offset: 0x00091268
		// (set) Token: 0x060030A8 RID: 12456 RVA: 0x00093070 File Offset: 0x00091270
		public override global::System.Collections.IDictionary Dictionary
		{
			get
			{
				return this.dictionary;
			}
			set
			{
				if (value != null)
				{
					global::System.Collections.IEnumerator enumerator = value.Keys.GetEnumerator();
					while (enumerator.MoveNext())
					{
						if (!(enumerator.Current is long) && !(enumerator.Current is int))
						{
							string[] array = new string[5];
							array[0] = "Dictionary keys must be of type long. but it's ";
							int num = 1;
							object obj = enumerator.Current;
							array[num] = ((obj != null) ? obj.ToString() : null);
							array[2] = ",";
							array[3] = enumerator.Current.GetType().Name;
							array[4] = " now";
							throw new global::NPOI.HPSF.IllegalPropertySetDataException(string.Concat(array));
						}
					}
					this.dictionary = value;
					this.SetProperty(0, -1L, value);
					if (this.GetProperty(1L) == null)
					{
						this.SetProperty(1, 2L, 1200);
						return;
					}
				}
				else
				{
					this.RemoveProperty(0L);
				}
			}
		}

		// Token: 0x060030A9 RID: 12457 RVA: 0x0009313C File Offset: 0x0009133C
		public void SetProperty(int id, object value)
		{
			if (value is string)
			{
				this.SetProperty(id, (string)value);
				return;
			}
			if (value is long)
			{
				this.SetProperty(id, (long)value);
				return;
			}
			if (value is int)
			{
				this.SetProperty(id, value);
				return;
			}
			if (value is short)
			{
				this.SetProperty(id, (int)((short)value));
				return;
			}
			if (value is bool)
			{
				this.SetProperty(id, (bool)value);
				return;
			}
			if (value is global::System.DateTime)
			{
				this.SetProperty(id, 64L, value);
				return;
			}
			throw new global::NPOI.HPSF.HPSFRuntimeException("HPSF does not support properties of type " + value.GetType().Name + ".");
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x000931E8 File Offset: 0x000913E8
		public void Clear()
		{
			foreach (global::NPOI.HPSF.Property property in this.Properties)
			{
				this.RemoveProperty(property.ID);
			}
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x060030AB RID: 12459 RVA: 0x0009321A File Offset: 0x0009141A
		// (set) Token: 0x060030AC RID: 12460 RVA: 0x00093222 File Offset: 0x00091422
		public new int Codepage
		{
			get
			{
				return base.Codepage;
			}
			set
			{
				this.SetProperty(1, 2L, value);
			}
		}

		// Token: 0x04001589 RID: 5513
		private bool dirty = true;

		// Token: 0x0400158A RID: 5514
		private global::System.Collections.ArrayList preprops;

		// Token: 0x0400158B RID: 5515
		private byte[] sectionBytes;

		// Token: 0x02000629 RID: 1577
		private class PropertyComparer : global::System.Collections.IComparer
		{
			// Token: 0x060036DD RID: 14045 RVA: 0x000A7974 File Offset: 0x000A5B74
			int global::System.Collections.IComparer.Compare(object o1, object o2)
			{
				global::NPOI.HPSF.Property property = (global::NPOI.HPSF.Property)o1;
				global::NPOI.HPSF.Property property2 = (global::NPOI.HPSF.Property)o2;
				if (property.ID < property2.ID)
				{
					return -1;
				}
				if (property.ID == property2.ID)
				{
					return 0;
				}
				return 1;
			}
		}
	}
}
