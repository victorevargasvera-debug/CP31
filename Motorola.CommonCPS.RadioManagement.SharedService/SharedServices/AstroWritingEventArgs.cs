using System;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000086 RID: 134
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroWritingEventArgs : global::System.EventArgs
	{
		// Token: 0x06000833 RID: 2099 RVA: 0x00061BBC File Offset: 0x0005FDBC
		public AstroWritingEventArgs(global::Motorola.CommonCPS.Server.EntityModel.APXRadio dv, bool writeProtectFlag, int transportPreference, bool isBatch, bool isRestoreJob, ref global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached)
		{
			this.entity = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.Clone<global::Motorola.CommonCPS.Server.EntityModel.APXRadio>(dv);
			this.IsUpdated = false;
			this.IsWritingProtect = writeProtectFlag;
			this.TransportPreference = transportPreference;
			this.IsBatch = isBatch;
			this.IsRestoreJob = isRestoreJob;
			this.AttachedASKs = attachedASKs;
			this.IsSpecialKeyAttached = isSpecialKeyAttached;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00061C18 File Offset: 0x0005FE18
		public global::Motorola.CommonCPS.Server.EntityModel.APXRadio Device
		{
			get
			{
				short num = (short)1044122196;
				short num2 = num;
				num = (short)1428621908;
				switch (num2 == num)
				{
				}
				num = (short)965017600;
				short num3 = num;
				num = (short)809828352;
				if (num != 0)
				{
				}
				num = (short)170852353;
				if (num != 0)
				{
				}
				return this.entity;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x00061CCC File Offset: 0x0005FECC
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x00061D80 File Offset: 0x0005FF80
		[global::System.Runtime.Serialization.DataMember]
		public bool IsUpdated
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1725235201;
				if (num != 0)
				{
				}
				num = (short)595556387;
				short num2 = num;
				num = (short)871594019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1533739008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2044723200;
				if (num != 0)
				{
				}
				return this.<IsUpdated>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)220969167;
				short num2 = num;
				num = (short)929151183;
				switch (num2 == num)
				{
				}
				num = (short)1059258368;
				short num3 = num;
				num = (short)1201209344;
				if (num != 0)
				{
				}
				num = (short)904724481;
				if (num != 0)
				{
				}
				this.<IsUpdated>k__BackingField = value;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00061E34 File Offset: 0x00060034
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00061EE4 File Offset: 0x000600E4
		[global::System.Runtime.Serialization.DataMember]
		public bool IsWritingProtect
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1288256009;
				short num2 = num;
				num = (short)1415068169;
				switch (num2 == num)
				{
				}
				num = (short)150798336;
				short num3 = num;
				num = (short)1822818305;
				if (num != 0)
				{
				}
				num = (short)906493952;
				if (num != 0)
				{
				}
				return this.<IsWritingProtect>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)506493992;
				short num2 = num;
				num = (short)1806203944;
				switch (num2 == num)
				{
				}
				num = (short)572129280;
				short num3 = num;
				num = (short)623116289;
				if (num != 0)
				{
				}
				num = (short)1838678016;
				if (num != 0)
				{
				}
				this.<IsWritingProtect>k__BackingField = value;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x00061F98 File Offset: 0x00060198
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00062044 File Offset: 0x00060244
		[global::System.Runtime.Serialization.DataMember]
		public int TransportPreference
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)984581382;
				short num2 = num;
				num = (short)917406982;
				switch (num2 == num)
				{
				}
				num = (short)1787625472;
				short num3 = num;
				num = (short)130088961;
				if (num != 0)
				{
				}
				num = (short)1249574912;
				if (num != 0)
				{
				}
				return this.<TransportPreference>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1115996673;
				short num2 = num;
				num = (short)1530708481;
				switch (num2 == num)
				{
				}
				num = (short)416350208;
				short num3 = num;
				num = (short)2083192832;
				if (num != 0)
				{
				}
				num = (short)294912001;
				if (num != 0)
				{
				}
				this.<TransportPreference>k__BackingField = value;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x000620F4 File Offset: 0x000602F4
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x000621A4 File Offset: 0x000603A4
		[global::System.Runtime.Serialization.DataMember]
		public bool IsBatch
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)10975052;
				short num2 = num;
				num = (short)1239119692;
				switch (num2 == num)
				{
				}
				num = (short)1656422400;
				short num3 = num;
				num = (short)2067267584;
				if (num != 0)
				{
				}
				num = (short)2038300673;
				if (num != 0)
				{
				}
				return this.<IsBatch>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)737920928;
				short num2 = num;
				num = (short)2146355104;
				switch (num2 == num)
				{
				}
				num = (short)1425211392;
				short num3 = num;
				num = (short)557973504;
				if (num != 0)
				{
				}
				num = (short)2090139649;
				if (num != 0)
				{
				}
				this.<IsBatch>k__BackingField = value;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00062258 File Offset: 0x00060458
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00062308 File Offset: 0x00060508
		[global::System.Runtime.Serialization.DataMember]
		public bool IsRestoreJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)685136826;
				short num2 = num;
				num = (short)1221745594;
				switch (num2 == num)
				{
				}
				num = (short)1020526592;
				short num3 = num;
				num = (short)1152319488;
				if (num != 0)
				{
				}
				num = (short)379191297;
				if (num != 0)
				{
				}
				return this.<IsRestoreJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1710973497;
				short num2 = num;
				num = (short)943546937;
				switch (num2 == num)
				{
				}
				num = (short)297533440;
				short num3 = num;
				num = (short)2040266753;
				if (num != 0)
				{
				}
				num = (short)417792000;
				if (num != 0)
				{
				}
				this.<IsRestoreJob>k__BackingField = value;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x000623B8 File Offset: 0x000605B8
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x00062468 File Offset: 0x00060668
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> AttachedASKs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1652759617;
				short num2 = num;
				num = (short)716840001;
				switch (num2 == num)
				{
				}
				num = (short)1612513280;
				short num3 = num;
				num = (short)160759809;
				if (num != 0)
				{
				}
				num = (short)402915328;
				if (num != 0)
				{
				}
				return this.<AttachedASKs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1550325710;
				short num2 = num;
				num = (short)86906830;
				switch (num2 == num)
				{
				}
				num = (short)908460032;
				short num3 = num;
				num = (short)2111700992;
				if (num != 0)
				{
				}
				num = (short)1098645505;
				if (num != 0)
				{
				}
				this.<AttachedASKs>k__BackingField = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0006251C File Offset: 0x0006071C
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x000625CC File Offset: 0x000607CC
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsSpecialKeyAttached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)63249880;
				short num2 = num;
				num = (short)142810584;
				switch (num2 == num)
				{
				}
				num = (short)921501696;
				short num3 = num;
				num = (short)1242234881;
				if (num != 0)
				{
				}
				num = (short)786563072;
				if (num != 0)
				{
				}
				return this.<IsSpecialKeyAttached>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1236224486;
				short num2 = num;
				num = (short)1966098918;
				switch (num2 == num)
				{
				}
				num = (short)1925906432;
				short num3 = num;
				num = (short)1499660289;
				if (num != 0)
				{
				}
				num = (short)401276928;
				if (num != 0)
				{
				}
				this.<IsSpecialKeyAttached>k__BackingField = value;
			}
		}

		// Token: 0x040000D6 RID: 214
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.APXRadio entity;
	}
}
