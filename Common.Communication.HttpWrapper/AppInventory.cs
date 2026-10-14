using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002D RID: 45
	[global::System.Runtime.Serialization.DataContract]
	public class AppInventory
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00009B60 File Offset: 0x00007D60
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00009C0C File Offset: 0x00007E0C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.App> appInventory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1937068211;
				short num2 = num;
				num = (short)226906291;
				switch (num2 == num)
				{
				}
				num = (short)487784448;
				if (num != 0)
				{
				}
				num = (short)1009188865;
				if (num != 0)
				{
				}
				num = (short)59179008;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1618506055;
				short num2 = num;
				num = (short)1908830535;
				switch (num2 == num)
				{
				}
				num = (short)299958273;
				if (num != 0)
				{
				}
				num = (short)332267520;
				if (num != 0)
				{
				}
				num = (short)1450377216;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00009CBC File Offset: 0x00007EBC
		public AppInventory()
		{
			this.appInventory = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.App>();
		}

		// Token: 0x04000062 RID: 98
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.App> a;
	}
}
