using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000097 RID: 151
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class GetTTSInstallationPathEventArgs : global::System.EventArgs
	{
		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x00065830 File Offset: 0x00063A30
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x000658DC File Offset: 0x00063ADC
		[global::System.Runtime.Serialization.DataMember]
		public string ttsPath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)592850838;
				short num2 = num;
				num = (short)421605270;
				switch (num2 == num)
				{
				}
				num = (short)1894383617;
				if (num != 0)
				{
				}
				num = (short)1923284992;
				short num3 = num;
				num = (short)61276160;
				if (num != 0)
				{
				}
				return this.<ttsPath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1539282913;
				short num2 = num;
				num = (short)476026849;
				switch (num2 == num)
				{
				}
				num = (short)1244725248;
				if (num != 0)
				{
				}
				num = (short)1552744448;
				short num3 = num;
				num = (short)1650524161;
				if (num != 0)
				{
				}
				this.<ttsPath>k__BackingField = value;
			}
		}
	}
}
