using System;
using System.IO;

namespace NPOI.HPSF
{
	// Token: 0x02000511 RID: 1297
	public class MutableProperty : global::NPOI.HPSF.Property
	{
		// Token: 0x06003080 RID: 12416 RVA: 0x00092610 File Offset: 0x00090810
		public MutableProperty()
		{
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x00092618 File Offset: 0x00090818
		public MutableProperty(global::NPOI.HPSF.Property p)
		{
			this.ID = p.ID;
			this.Type = p.Type;
			this.Value = p.Value;
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00092644 File Offset: 0x00090844
		public int Write(global::System.IO.Stream out1, int codepage)
		{
			int num = 0;
			long num2 = this.Type;
			if (codepage == 1200 && num2 == 30L)
			{
				num2 = 31L;
			}
			return num + global::NPOI.HPSF.TypeWriter.WriteUIntToStream(out1, (uint)num2) + global::NPOI.HPSF.VariantSupport.Write(out1, num2, this.Value, codepage);
		}
	}
}
