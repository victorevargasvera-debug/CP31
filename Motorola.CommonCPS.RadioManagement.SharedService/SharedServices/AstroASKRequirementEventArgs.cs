using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000076 RID: 118
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroASKRequirementEventArgs : global::System.EventArgs
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x0005E314 File Offset: 0x0005C514
		public AstroASKRequirementEventArgs(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cpObj, string targetModelNumber)
		{
			this.cpObj = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.Clone<global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug>(cpObj);
			this.TargetModelNumber = targetModelNumber;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x0005E33C File Offset: 0x0005C53C
		public global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug Codeplug
		{
			get
			{
				short num = (short)415891456;
				short num2 = num;
				num = (short)957201058;
				short num3 = num;
				num = (short)1787083426;
				switch (num3 == num)
				{
				}
				num = (short)965148673;
				if (num != 0)
				{
				}
				num = (short)197984256;
				if (num != 0)
				{
				}
				return this.cpObj;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0005E3F0 File Offset: 0x0005C5F0
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0005E4A0 File Offset: 0x0005C6A0
		[global::System.Runtime.Serialization.DataMember]
		public string TargetModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1686896640;
				short num2 = num;
				num = (short)1275304760;
				short num3 = num;
				num = (short)1822202680;
				switch (num3 == num)
				{
				}
				num = (short)2123694081;
				if (num != 0)
				{
				}
				num = (short)1605828608;
				if (num != 0)
				{
				}
				return this.<TargetModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1168310272;
				short num2 = num;
				num = (short)118178628;
				short num3 = num;
				num = (short)1941914436;
				switch (num3 == num)
				{
				}
				num = (short)929955840;
				if (num != 0)
				{
				}
				num = (short)178192385;
				if (num != 0)
				{
				}
				this.<TargetModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x040000AA RID: 170
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cpObj;
	}
}
