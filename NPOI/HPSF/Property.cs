using System;
using System.Collections;
using System.Text;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000517 RID: 1303
	public class Property
	{
		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x00093233 File Offset: 0x00091433
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x0009323B File Offset: 0x0009143B
		public virtual long ID
		{
			get
			{
				return this.id;
			}
			set
			{
				this.id = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x00093244 File Offset: 0x00091444
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x0009324C File Offset: 0x0009144C
		public virtual long Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x00093255 File Offset: 0x00091455
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x0009325D File Offset: 0x0009145D
		public virtual object Value
		{
			get
			{
				return this.value;
			}
			set
			{
				this.value = value;
			}
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x00093266 File Offset: 0x00091466
		public Property(long id, long type, object value)
		{
			this.id = id;
			this.type = type;
			this.value = value;
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00093284 File Offset: 0x00091484
		public Property(long id, byte[] src, long offset, int Length, int codepage)
		{
			this.id = id;
			if (id == 0L)
			{
				this.value = this.ReadDictionary(src, offset, Length, codepage);
				return;
			}
			int num = (int)offset;
			this.type = global::NPOI.Util.LittleEndian.GetUInt(src, num);
			num += 4;
			try
			{
				this.value = global::NPOI.HPSF.VariantSupport.Read(src, num, Length, (long)((int)this.type), codepage);
			}
			catch (global::NPOI.HPSF.UnsupportedVariantTypeException ex)
			{
				global::NPOI.HPSF.VariantSupport.WriteUnsupportedTypeMessage(ex);
				this.value = ex.Value;
			}
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x0000253E File Offset: 0x0000073E
		protected Property()
		{
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x00093308 File Offset: 0x00091508
		protected global::System.Collections.IDictionary ReadDictionary(byte[] src, long offset, int Length, int codepage)
		{
			if (offset < 0L || offset > (long)src.Length)
			{
				throw new global::NPOI.HPSF.HPSFRuntimeException(string.Concat(new string[]
				{
					"Illegal offset ",
					offset.ToString(),
					" while HPSF stream Contains ",
					Length.ToString(),
					" bytes."
				}));
			}
			int num = (int)offset;
			long @uint = global::NPOI.Util.LittleEndian.GetUInt(src, num);
			num += 4;
			global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable((int)@uint, 1f);
			try
			{
				int num2 = 0;
				while ((long)num2 < @uint)
				{
					long uint2 = global::NPOI.Util.LittleEndian.GetUInt(src, num);
					num += 4;
					long num3 = global::NPOI.Util.LittleEndian.GetUInt(src, num);
					num += 4;
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					if (codepage != -1)
					{
						if (codepage != 1200)
						{
							stringBuilder.Append(global::System.Text.Encoding.GetEncoding(codepage).GetString(src, num, (int)num3));
						}
						else
						{
							int num4 = (int)(num3 * 2L);
							byte[] array = new byte[num4];
							for (int i = 0; i < num4; i++)
							{
								array[i] = src[num + i];
							}
							stringBuilder.Append(global::System.Text.Encoding.GetEncoding(codepage).GetString(array, 0, num4 - 2));
						}
					}
					else
					{
						stringBuilder.Append(global::System.Text.Encoding.UTF8.GetString(src, num, (int)num3));
					}
					while (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] == '\0')
					{
						stringBuilder.Length--;
					}
					if (codepage == 1200)
					{
						if (num3 % 2L == 1L)
						{
							num3 += 1L;
						}
						num += (int)(num3 + num3);
					}
					else
					{
						num += (int)num3;
					}
					hashtable[uint2] = stringBuilder.ToString();
					num2++;
				}
			}
			catch (global::System.Exception exception)
			{
				global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HPSF.Property)).Log(5, "The property Set's dictionary Contains bogus data. All dictionary entries starting with the one with ID " + this.id.ToString() + " will be ignored.", exception);
			}
			return hashtable;
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000934FC File Offset: 0x000916FC
		public int Count
		{
			get
			{
				int num = global::NPOI.HPSF.Variant.GetVariantLength(this.type);
				if (num >= 0)
				{
					return num;
				}
				if (num == -2)
				{
					throw new global::NPOI.HPSF.WritingNotSupportedException(this.type, null);
				}
				int num2 = 4;
				int num3 = (int)this.type;
				if (num3 != 0)
				{
					if (num3 != 30)
					{
						throw new global::NPOI.HPSF.WritingNotSupportedException(this.type, this.value);
					}
					int num4 = ((string)this.value).Length + 1;
					int num5 = num4 % num2;
					if (num5 > 0)
					{
						num4 += num2 - num5;
					}
					num += num4;
				}
				return num;
			}
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x0009357C File Offset: 0x0009177C
		public override bool Equals(object o)
		{
			if (!(o is global::NPOI.HPSF.Property))
			{
				return false;
			}
			global::NPOI.HPSF.Property property = (global::NPOI.HPSF.Property)o;
			object obj = property.Value;
			long num = property.ID;
			if (this.id != num || (this.id != 0L && !this.TypesAreEqual(this.type, property.Type)))
			{
				return false;
			}
			if (this.value == null && obj == null)
			{
				return true;
			}
			if (this.value == null || obj == null)
			{
				return false;
			}
			global::System.Type type = this.value.GetType();
			global::System.Type type2 = obj.GetType();
			if (!type.IsAssignableFrom(type2) && !type2.IsAssignableFrom(type))
			{
				return false;
			}
			if (this.value is byte[])
			{
				return global::NPOI.Util.Arrays.Equals((byte[])this.value, (byte[])obj);
			}
			return this.value.Equals(obj);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x00093643 File Offset: 0x00091843
		private bool TypesAreEqual(long t1, long t2)
		{
			return t1 == t2 || (t1 == 30L && t2 == 31L) || (t2 == 30L && t1 == 31L);
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x00093664 File Offset: 0x00091864
		public override int GetHashCode()
		{
			long num = 0L;
			num += this.id;
			num += this.type;
			if (this.value != null)
			{
				num += (long)this.value.GetHashCode();
			}
			return (int)(num & (long)((ulong)-1));
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000936A4 File Offset: 0x000918A4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append('[');
			stringBuilder.Append("id: ");
			stringBuilder.Append(this.ID);
			stringBuilder.Append(", type: ");
			stringBuilder.Append(base.GetType());
			object obj = this.Value;
			stringBuilder.Append(", value: ");
			if (obj is string)
			{
				stringBuilder.Append(obj.ToString());
				string text = obj.ToString();
				int length = text.Length;
				byte[] array = new byte[length * 2];
				for (int i = 0; i < length; i++)
				{
					char c = text[i];
					byte b = (byte)((c & '＀') >> 8);
					byte b2 = (byte)(c & 'ÿ');
					array[i * 2] = b;
					array[i * 2 + 1] = b2;
				}
				stringBuilder.Append(" [");
				if (array.Length != 0)
				{
					string text2 = global::NPOI.Util.HexDump.Dump(array, 0L, 0);
					stringBuilder.Append(text2);
				}
				stringBuilder.Append("]");
			}
			else if (obj is byte[])
			{
				byte[] array2 = (byte[])obj;
				if (array2.Length != 0)
				{
					string text3 = global::NPOI.Util.HexDump.Dump(array2, 0L, 0);
					stringBuilder.Append(text3);
				}
			}
			else
			{
				stringBuilder.Append(obj.ToString());
			}
			stringBuilder.Append(']');
			return stringBuilder.ToString();
		}

		// Token: 0x0400158C RID: 5516
		protected long id;

		// Token: 0x0400158D RID: 5517
		protected long type;

		// Token: 0x0400158E RID: 5518
		protected object value;
	}
}
