using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Motorola.Common.Communication.AmpRequest.Models
{
	// Token: 0x02000046 RID: 70
	public class JobContent
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00010070 File Offset: 0x0000E270
		public int UserDefersAllowed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)737948163;
				short num2 = num;
				num = (short)1384002051;
				switch (num2 == num)
				{
				}
				num = (short)1145962497;
				if (num != 0)
				{
				}
				num = (short)1305280512;
				short num3 = num;
				num = (short)125239296;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)767037223;
				short num2 = num;
				num = (short)1507659559;
				switch (num2 == num)
				{
				}
				num = (short)196935680;
				if (num != 0)
				{
				}
				num = (short)982515712;
				short num3 = num;
				num = (short)225378305;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00010120 File Offset: 0x0000E320
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000101D0 File Offset: 0x0000E3D0
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.FileDescription> Files
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)430174339;
				short num2 = num;
				num = (short)387117187;
				switch (num2 == num)
				{
				}
				num = (short)607584257;
				if (num != 0)
				{
				}
				num = (short)1876492288;
				short num3 = num;
				num = (short)763101184;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2045304209;
				short num2 = num;
				num = (short)1009114513;
				switch (num2 == num)
				{
				}
				num = (short)264503297;
				if (num != 0)
				{
				}
				num = (short)742391808;
				short num3 = num;
				num = (short)1466826752;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x040000A2 RID: 162
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;

		// Token: 0x040000A3 RID: 163
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.FileDescription> b;
	}
}
