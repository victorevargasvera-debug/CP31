using System;
using System.Text;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000533 RID: 1331
	public class EscherBoolProperty : global::NPOI.DDF.EscherSimpleProperty
	{
		// Token: 0x060031F5 RID: 12789 RVA: 0x00097886 File Offset: 0x00095A86
		public EscherBoolProperty(short propertyNumber, int value) : base(propertyNumber, value)
		{
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060031F6 RID: 12790 RVA: 0x00097890 File Offset: 0x00095A90
		public bool IsTrue
		{
			get
			{
				return this.propertyValue != 0;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060031F7 RID: 12791 RVA: 0x0009789B File Offset: 0x00095A9B
		public bool IsFalse
		{
			get
			{
				return this.propertyValue == 0;
			}
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x000978A8 File Offset: 0x00095AA8
		public override string ToXml(string tab)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(tab).Append("<").Append(base.GetType().Name).Append(" id=\"0x").Append(global::NPOI.Util.HexDump.ToHex(this.Id)).Append("\" name=\"").Append(this.Name).Append("\" simpleValue=\"").Append(base.PropertyValue).Append("\" blipId=\"").Append(this.IsBlipId).Append("\" value=\"").Append(this.IsTrue).Append("\"").Append("/>\n");
			return stringBuilder.ToString();
		}
	}
}
