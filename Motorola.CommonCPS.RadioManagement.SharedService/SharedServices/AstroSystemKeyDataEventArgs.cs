using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ASK.Interface;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000028 RID: 40
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroSystemKeyDataEventArgs : global::System.EventArgs
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00031A80 File Offset: 0x0002FC80
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00031B34 File Offset: 0x0002FD34
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> LoadedSysKeys
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1350944577;
				short num2 = num;
				num = (short)294504257;
				switch (num2 == num)
				{
				}
				num = (short)637861888;
				if (num != 0)
				{
				}
				num = (short)1430585345;
				if (num != 0)
				{
				}
				num = (short)1148190720;
				short num3 = num;
				return this.<LoadedSysKeys>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1335362145;
				short num2 = num;
				num = (short)1993540193;
				switch (num2 == num)
				{
				}
				num = (short)376700929;
				if (num != 0)
				{
				}
				num = (short)533397504;
				if (num != 0)
				{
				}
				num = (short)454230016;
				short num3 = num;
				this.<LoadedSysKeys>k__BackingField = value;
			}
		}

		// Token: 0x0400003D RID: 61
		[global::System.Runtime.Serialization.DataMember]
		public bool IsAttached;
	}
}
