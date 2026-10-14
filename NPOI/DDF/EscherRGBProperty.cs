using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000546 RID: 1350
	public class EscherRGBProperty : global::NPOI.DDF.EscherSimpleProperty
	{
		// Token: 0x06003305 RID: 13061 RVA: 0x00097886 File Offset: 0x00095A86
		public EscherRGBProperty(short propertyNumber, int rgbColor) : base(propertyNumber, rgbColor)
		{
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06003306 RID: 13062 RVA: 0x0009F60F File Offset: 0x0009D80F
		public int RgbColor
		{
			get
			{
				return this.propertyValue;
			}
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x0009F617 File Offset: 0x0009D817
		public byte Red
		{
			get
			{
				return (byte)(this.propertyValue & 255);
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06003308 RID: 13064 RVA: 0x0009F626 File Offset: 0x0009D826
		public byte Green
		{
			get
			{
				return (byte)(this.propertyValue >> 8 & 255);
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06003309 RID: 13065 RVA: 0x0009F637 File Offset: 0x0009D837
		public byte Blue
		{
			get
			{
				return (byte)(this.propertyValue >> 16 & 255);
			}
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x0009F64C File Offset: 0x0009D84C
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append("<").Append(base.GetType().Name).Append(" id=\"0x").Append(global::NPOI.Util.HexDump.ToHex(this.Id)).Append("\" name=\"").Append(this.Name).Append("\" blipId=\"").Append(this.IsBlipId).Append("\" value=\"0x").Append(global::NPOI.Util.HexDump.ToHex(this.propertyValue)).Append("\"/>\n");
			return stringBuilder.ToString();
		}
	}
}
