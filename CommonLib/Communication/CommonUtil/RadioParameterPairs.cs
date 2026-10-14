using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200006C RID: 108
	public class RadioParameterPairs
	{
		// Token: 0x060002EC RID: 748 RVA: 0x000358D0 File Offset: 0x00033AD0
		public RadioParameterPairs()
		{
			this.RadioParameters = new global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.RadioParameterType, object>();
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000358F0 File Offset: 0x00033AF0
		public void AddRadioParams(global::Motorola.Common.Communication.CommonUtil.RadioParameterType type)
		{
			short num = (short)916911866;
			short num2 = num;
			num = (short)5699322;
			switch (num2 == num)
			{
			}
			num = (short)1343684608;
			if (num != 0)
			{
			}
			num = (short)883097601;
			if (num != 0)
			{
			}
			num = (short)1892614144;
			short num3 = num;
			this.RadioParameters[type] = null;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000359A8 File Offset: 0x00033BA8
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00035A58 File Offset: 0x00033C58
		public global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.RadioParameterType, object> RadioParameters
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1802194302;
				short num2 = num;
				num = (short)2008698238;
				switch (num2 == num)
				{
				}
				num = (short)1099825153;
				if (num != 0)
				{
				}
				num = (short)1808465920;
				if (num != 0)
				{
				}
				num = (short)995622912;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)962854689;
				short num2 = num;
				num = (short)1750990625;
				switch (num2 == num)
				{
				}
				num = (short)305201153;
				if (num != 0)
				{
				}
				num = (short)1300496384;
				if (num != 0)
				{
				}
				num = (short)747307008;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x040002E5 RID: 741
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommonUtil.RadioParameterType, object> a;
	}
}
