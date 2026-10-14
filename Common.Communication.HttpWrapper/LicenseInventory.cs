using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000034 RID: 52
	[global::System.Runtime.Serialization.DataContract]
	public class LicenseInventory
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000BF30 File Offset: 0x0000A130
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000BFE0 File Offset: 0x0000A1E0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.License> licenseInventory
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2023909904;
				short num2 = num;
				num = (short)1251502608;
				switch (num2 == num)
				{
				}
				num = (short)1096351745;
				if (num != 0)
				{
				}
				num = (short)999882752;
				if (num != 0)
				{
				}
				num = (short)438501376;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)232301859;
				short num2 = num;
				num = (short)562144547;
				switch (num2 == num)
				{
				}
				num = (short)784465920;
				if (num != 0)
				{
				}
				num = (short)1393295361;
				if (num != 0)
				{
				}
				num = (short)412090368;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000C08C File Offset: 0x0000A28C
		public LicenseInventory()
		{
			this.licenseInventory = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.License>();
		}

		// Token: 0x0400007B RID: 123
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.License> a;
	}
}
