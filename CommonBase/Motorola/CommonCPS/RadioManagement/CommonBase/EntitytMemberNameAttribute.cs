using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.CommonBase
{
	// Token: 0x02000006 RID: 6
	[global::System.AttributeUsage(global::System.AttributeTargets.Property, AllowMultiple = true)]
	public class EntitytMemberNameAttribute : global::System.Attribute
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000048A4 File Offset: 0x00002AA4
		public EntitytMemberNameAttribute(string entiytMemberName)
		{
			this.EntiytMemberName = entiytMemberName;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000048C0 File Offset: 0x00002AC0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00004970 File Offset: 0x00002B70
		public string EntiytMemberName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1562021312;
				short num2 = num;
				num = (short)2009370048;
				switch (num2 == num)
				{
				}
				num = (short)1454964736;
				short num3 = num;
				num = (short)109838336;
				if (num != 0)
				{
				}
				num = (short)1397948417;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1867304328;
				short num2 = num;
				num = (short)1135529352;
				switch (num2 == num)
				{
				}
				num = (short)491061248;
				short num3 = num;
				num = (short)1554644993;
				if (num != 0)
				{
				}
				num = (short)2020737024;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x04000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
