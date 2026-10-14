using System;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Fields
{
	// Token: 0x02000079 RID: 121
	public class IPAddressField : global::Motorola.Acp.PackUnpack.Ish.Fields.Field, global::Motorola.Acp.PackUnpack.Ish.Fields.IFieldValue<byte[]>
	{
		// Token: 0x06000382 RID: 898 RVA: 0x00045F44 File Offset: 0x00044144
		internal IPAddressField(global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressFieldLayout layout) : this(layout, new byte[16])
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00045F60 File Offset: 0x00044160
		internal IPAddressField(global::Motorola.Acp.PackUnpack.Ish.Layouts.IPAddressFieldLayout layout, byte[] value) : base(layout)
		{
			this.Value = value;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00045F7C File Offset: 0x0004417C
		internal override global::System.TypeCode TypeCode
		{
			get
			{
				short num = (short)370719384;
				short num2 = num;
				num = (short)1733081752;
				switch (num2 == num)
				{
				}
				num = (short)70713345;
				if (num != 0)
				{
				}
				num = (short)1783431168;
				short num3 = num;
				num = (short)704249856;
				if (num != 0)
				{
				}
				return global::System.TypeCode.Object;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00046028 File Offset: 0x00044228
		// (set) Token: 0x06000386 RID: 902 RVA: 0x000460D8 File Offset: 0x000442D8
		public byte[] Value
		{
			get
			{
				short num = (short)764930781;
				short num2 = num;
				num = (short)74902237;
				switch (num2 == num)
				{
				}
				num = (short)597753857;
				if (num != 0)
				{
				}
				num = (short)327155712;
				short num3 = num;
				num = (short)862453760;
				if (num != 0)
				{
				}
				return this.value;
			}
			set
			{
				int a_ = 14;
				short num = (short)690814979;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)542179329;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (value.Length != 16)
						{
							goto IL_12A;
						}
						goto IL_146;
					case 1:
						goto IL_141;
					case 2:
					{
						num = (short)1407647744;
						short num3 = num;
						num = (short)106251201;
						short num4 = num;
						num = (short)955859905;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12A;
						default:
							num = (short)779223040;
							if (num != 0)
							{
							}
							num = (short)1503657984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_67;
						}
						continue;
					}
					IL_67:
					if (value != null)
					{
						num = (short)514064386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_146;
					IL_12A:
					num = (short)1174667265;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_141:
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("펤욦얨\udeaa좬", a_));
				IL_146:
				this.value = value;
			}
		}

		// Token: 0x0400015C RID: 348
		private byte[] value;
	}
}
