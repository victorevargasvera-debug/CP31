using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000083 RID: 131
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroPop25EnabledEventArgs : global::System.EventArgs
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00061278 File Offset: 0x0005F478
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x00061328 File Offset: 0x0005F528
		[global::System.Runtime.Serialization.DataMember]
		public bool Pop25Enabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)475008185;
				short num2 = num;
				num = (short)1674054841;
				switch (num2 == num)
				{
				}
				num = (short)745603072;
				short num3 = num;
				num = (short)268238849;
				if (num != 0)
				{
				}
				num = (short)772341760;
				if (num != 0)
				{
				}
				return this.<Pop25Enabled>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1693226763;
				short num2 = num;
				num = (short)689084171;
				switch (num2 == num)
				{
				}
				num = (short)1243873280;
				short num3 = num;
				num = (short)1237843968;
				if (num != 0)
				{
				}
				num = (short)1354629121;
				if (num != 0)
				{
				}
				this.<Pop25Enabled>k__BackingField = value;
			}
		}
	}
}
