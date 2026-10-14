using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000549 RID: 1353
	public class EscherSimpleProperty : global::NPOI.DDF.EscherProperty
	{
		// Token: 0x0600330E RID: 13070 RVA: 0x0009F6F9 File Offset: 0x0009D8F9
		public EscherSimpleProperty(short id, int propertyValue) : base(id)
		{
			this.propertyValue = propertyValue;
		}

		// Token: 0x0600330F RID: 13071 RVA: 0x0009F709 File Offset: 0x0009D909
		public EscherSimpleProperty(short propertyNumber, bool isComplex, bool isBlipId, int propertyValue) : base(propertyNumber, isComplex, isBlipId)
		{
			this.propertyValue = propertyValue;
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x0009F71C File Offset: 0x0009D91C
		public override int SerializeSimplePart(byte[] data, int offset)
		{
			global::NPOI.Util.LittleEndian.PutShort(data, offset, this.Id);
			global::NPOI.Util.LittleEndian.PutInt(data, offset + 2, this.propertyValue);
			return 6;
		}

		// Token: 0x06003311 RID: 13073 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override int SerializeComplexPart(byte[] data, int pos)
		{
			return 0;
		}

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06003312 RID: 13074 RVA: 0x0009F60F File Offset: 0x0009D80F
		// (set) Token: 0x06003313 RID: 13075 RVA: 0x0009F73B File Offset: 0x0009D93B
		public int PropertyValue
		{
			get
			{
				return this.propertyValue;
			}
			internal set
			{
				this.propertyValue = value;
			}
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x0009F744 File Offset: 0x0009D944
		public override bool Equals(object o)
		{
			if (this == o)
			{
				return true;
			}
			if (!(o is global::NPOI.DDF.EscherSimpleProperty))
			{
				return false;
			}
			global::NPOI.DDF.EscherSimpleProperty escherSimpleProperty = (global::NPOI.DDF.EscherSimpleProperty)o;
			return this.propertyValue == escherSimpleProperty.propertyValue && this.Id == escherSimpleProperty.Id;
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x0009F60F File Offset: 0x0009D80F
		public override int GetHashCode()
		{
			return this.propertyValue;
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x0009F78C File Offset: 0x0009D98C
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				"propNum: ",
				this.PropertyNumber.ToString(),
				", RAW: 0x",
				global::NPOI.Util.HexDump.ToHex(this.Id),
				", propName: ",
				global::NPOI.DDF.EscherProperties.GetPropertyName(this.PropertyNumber),
				", complex: ",
				this.IsComplex.ToString(),
				", blipId: ",
				this.IsBlipId.ToString(),
				", value: ",
				this.propertyValue.ToString(),
				" (0x",
				global::NPOI.Util.HexDump.ToHex(this.propertyValue),
				")"
			});
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x0009F858 File Offset: 0x0009DA58
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append("<").Append(base.GetType().Name).Append(" id=\"0x").Append(global::NPOI.Util.HexDump.ToHex(this.Id)).Append("\" name=\"").Append(this.Name).Append("\" blipId=\"").Append(this.IsBlipId).Append("\" complex=\"").Append(this.IsComplex).Append("\" value=\"").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.propertyValue)).Append("\"/>\n");
			return stringBuilder.ToString();
		}

		// Token: 0x040017F7 RID: 6135
		protected int propertyValue;
	}
}
