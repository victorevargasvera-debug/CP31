using System;
using NPOI.Util;

namespace NPOI.HPSF
{
	// Token: 0x02000502 RID: 1282
	public class TypedPropertyValue
	{
		// Token: 0x06002FEA RID: 12266 RVA: 0x0000253E File Offset: 0x0000073E
		public TypedPropertyValue()
		{
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00091050 File Offset: 0x0008F250
		public TypedPropertyValue(byte[] data, int startOffset)
		{
			this.Read(data, startOffset);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00091061 File Offset: 0x0008F261
		public TypedPropertyValue(int type, object value)
		{
			this._type = type;
			this._value = value;
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x00091077 File Offset: 0x0008F277
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00091080 File Offset: 0x0008F280
		public int Read(byte[] data, int startOffset)
		{
			this._type = (int)global::NPOI.Util.LittleEndian.GetShort(data, startOffset);
			int num = startOffset + 2;
			short @short = global::NPOI.Util.LittleEndian.GetShort(data, num);
			num += 2;
			if (@short != 0)
			{
				global::NPOI.HPSF.TypedPropertyValue.logger.Log(5, "TypedPropertyValue padding at offset " + num.ToString() + " MUST be 0, but it's value is " + @short.ToString());
			}
			num += this.ReadValue(data, num);
			return num - startOffset;
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x000910E8 File Offset: 0x0008F2E8
		public int ReadValue(byte[] data, int offset)
		{
			int type = this._type;
			if (type <= 4127)
			{
				switch (type)
				{
				case 0:
				case 1:
					this._value = null;
					return 0;
				case 2:
					this._value = global::NPOI.Util.LittleEndian.GetShort(data, offset);
					return 4;
				case 3:
					this._value = global::NPOI.Util.LittleEndian.GetInt(data, offset);
					return 4;
				case 4:
					this._value = global::NPOI.Util.LittleEndian.GetShort(data, offset);
					return 4;
				case 5:
					this._value = global::NPOI.Util.LittleEndian.GetDouble(data, offset);
					return 8;
				case 6:
					this._value = new global::NPOI.HPSF.Currency(data, offset);
					return 8;
				case 7:
					this._value = new global::NPOI.HPSF.Date(data, offset);
					return 8;
				case 8:
					this._value = new global::NPOI.HPSF.CodePageString(data, offset);
					return ((global::NPOI.HPSF.CodePageString)this._value).Size;
				case 9:
				case 12:
				case 13:
				case 15:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
					goto IL_46D;
				case 10:
					this._value = global::NPOI.Util.LittleEndian.GetUInt(data, offset);
					return 4;
				case 11:
					this._value = new global::NPOI.HPSF.VariantBool(data, offset);
					return 2;
				case 14:
					this._value = new global::NPOI.HPSF.Decimal(data, offset);
					return 16;
				case 16:
					this._value = data[offset];
					return 1;
				case 17:
					this._value = global::NPOI.Util.LittleEndian.GetUByte(data, offset);
					return 2;
				case 18:
					this._value = global::NPOI.Util.LittleEndian.GetUShort(data, offset);
					return 4;
				case 19:
					this._value = global::NPOI.Util.LittleEndian.GetUInt(data, offset);
					return 4;
				case 20:
					this._value = global::NPOI.Util.LittleEndian.GetLong(data, offset);
					return 8;
				case 21:
					this._value = global::NPOI.Util.LittleEndian.GetByteArray(data, offset, 8);
					return 8;
				case 22:
					this._value = global::NPOI.Util.LittleEndian.GetInt(data, offset);
					return 4;
				case 23:
					this._value = global::NPOI.Util.LittleEndian.GetUInt(data, offset);
					return 4;
				case 30:
					this._value = new global::NPOI.HPSF.CodePageString(data, offset);
					return ((global::NPOI.HPSF.CodePageString)this._value).Size;
				case 31:
					this._value = new global::NPOI.HPSF.UnicodeString(data, offset);
					return ((global::NPOI.HPSF.UnicodeString)this._value).Size;
				default:
					switch (type)
					{
					case 64:
						this._value = new global::NPOI.HPSF.Filetime(data, offset);
						return 8;
					case 65:
						this._value = new global::NPOI.HPSF.Blob(data, offset);
						return ((global::NPOI.HPSF.Blob)this._value).Size;
					case 66:
					case 67:
					case 68:
					case 69:
						this._value = new global::NPOI.HPSF.IndirectPropertyName(data, offset);
						return ((global::NPOI.HPSF.IndirectPropertyName)this._value).Size;
					case 70:
						this._value = new global::NPOI.HPSF.Blob(data, offset);
						return ((global::NPOI.HPSF.Blob)this._value).Size;
					case 71:
						this._value = new global::NPOI.HPSF.ClipboardData(data, offset);
						return ((global::NPOI.HPSF.ClipboardData)this._value).Size;
					case 72:
						this._value = new global::NPOI.HPSF.GUID(data, offset);
						return 16;
					case 73:
						this._value = new global::NPOI.HPSF.VersionedStream(data, offset);
						return ((global::NPOI.HPSF.VersionedStream)this._value).Size;
					default:
						switch (type)
						{
						case 4098:
						case 4099:
						case 4100:
						case 4101:
						case 4102:
						case 4103:
						case 4104:
						case 4106:
						case 4107:
						case 4108:
						case 4112:
						case 4113:
						case 4114:
						case 4115:
						case 4116:
						case 4117:
						case 4126:
						case 4127:
							break;
						case 4105:
						case 4109:
						case 4110:
						case 4111:
						case 4118:
						case 4119:
						case 4120:
						case 4121:
						case 4122:
						case 4123:
						case 4124:
						case 4125:
							goto IL_46D;
						default:
							goto IL_46D;
						}
						break;
					}
					break;
				}
			}
			else if (type != 4160 && type - 4167 > 1)
			{
				switch (type)
				{
				case 8194:
				case 8195:
				case 8196:
				case 8197:
				case 8198:
				case 8199:
				case 8200:
				case 8202:
				case 8203:
				case 8204:
				case 8206:
				case 8208:
				case 8209:
				case 8210:
				case 8211:
				case 8214:
				case 8215:
					this._value = new global::NPOI.HPSF.Array();
					return ((global::NPOI.HPSF.Array)this._value).Read(data, offset);
				case 8201:
				case 8205:
				case 8207:
				case 8212:
				case 8213:
					goto IL_46D;
				default:
					goto IL_46D;
				}
			}
			this._value = new global::NPOI.HPSF.Vector((short)(this._type & 4095));
			return ((global::NPOI.HPSF.Vector)this._value).Read(data, offset);
			IL_46D:
			throw new global::System.InvalidOperationException("Unknown (possibly, incorrect) TypedPropertyValue type: " + this._type.ToString());
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x0009157C File Offset: 0x0008F77C
		internal int ReadValuePadded(byte[] data, int offset)
		{
			int num = this.ReadValue(data, offset);
			if ((num & 3) != 0)
			{
				return num + (4 - (num & 3));
			}
			return num;
		}

		// Token: 0x04001579 RID: 5497
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.HPSF.TypedPropertyValue));

		// Token: 0x0400157A RID: 5498
		private int _type;

		// Token: 0x0400157B RID: 5499
		private object _value;
	}
}
