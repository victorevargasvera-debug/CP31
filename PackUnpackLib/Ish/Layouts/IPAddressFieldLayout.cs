using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000065 RID: 101
	public class IPAddressFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout
	{
		// Token: 0x06000344 RID: 836 RVA: 0x00043D98 File Offset: 0x00041F98
		public IPAddressFieldLayout(string name, int byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressType addressType)
		{
			int a_ = 9;
			base..ctor(name, global::System.TypeCode.Object, byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Right);
			if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressType), addressType))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("솟욡삣풥춧\ud9a9\udfab節즯슱톳", a_));
			}
			this.a = addressType;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000345 RID: 837 RVA: 0x00043DEC File Offset: 0x00041FEC
		public override int Size
		{
			get
			{
				short num = (short)323553753;
				short num2 = num;
				num = (short)1383467481;
				switch (num2 == num)
				{
				}
				num = (short)1859715072;
				if (num != 0)
				{
				}
				num = (short)1510539265;
				if (num != 0)
				{
				}
				num = (short)1404043264;
				short num3 = num;
				return 16;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000346 RID: 838 RVA: 0x00043E98 File Offset: 0x00042098
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressType AddressType
		{
			get
			{
				short num = (short)1373532058;
				short num2 = num;
				num = (short)2029285274;
				switch (num2 == num)
				{
				}
				num = (short)658243585;
				if (num != 0)
				{
				}
				num = (short)1684078592;
				if (num != 0)
				{
				}
				num = (short)1286078464;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x0400013B RID: 315
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressType a;
	}
}
