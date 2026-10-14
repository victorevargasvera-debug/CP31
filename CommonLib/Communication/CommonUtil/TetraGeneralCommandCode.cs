using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000083 RID: 131
	[global::System.Runtime.Serialization.DataContract]
	public enum TetraGeneralCommandCode
	{
		// Token: 0x04000397 RID: 919
		[global::System.Runtime.Serialization.EnumMember]
		Undefined,
		// Token: 0x04000398 RID: 920
		[global::System.Runtime.Serialization.EnumMember]
		RP_GET_INDICATION,
		// Token: 0x04000399 RID: 921
		[global::System.Runtime.Serialization.EnumMember]
		RP_SEND_VERSION_REPLY,
		// Token: 0x0400039A RID: 922
		[global::System.Runtime.Serialization.EnumMember]
		RP_GET_TERMINAL_ID,
		// Token: 0x0400039B RID: 923
		[global::System.Runtime.Serialization.EnumMember]
		RP_GET_VERSION_INFO,
		// Token: 0x0400039C RID: 924
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_ERASE_KEYS,
		// Token: 0x0400039D RID: 925
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_BEGIN_UPDATE_FDT,
		// Token: 0x0400039E RID: 926
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_END_UPDATE_FDT,
		// Token: 0x0400039F RID: 927
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_RESTORE_PDV2_RADIO,
		// Token: 0x040003A0 RID: 928
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_MIGRATE_FDT,
		// Token: 0x040003A1 RID: 929
		[global::System.Runtime.Serialization.EnumMember]
		SWITCH_MODE_NO_WAIT,
		// Token: 0x040003A2 RID: 930
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_WRITE_KEYS,
		// Token: 0x040003A3 RID: 931
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_READ_KEYS,
		// Token: 0x040003A4 RID: 932
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_CLEAN_DAMAGE_FLAG,
		// Token: 0x040003A5 RID: 933
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_TEST_FDT,
		// Token: 0x040003A6 RID: 934
		[global::System.Runtime.Serialization.EnumMember]
		OPEN_COMMUNICATION_PIPE,
		// Token: 0x040003A7 RID: 935
		[global::System.Runtime.Serialization.EnumMember]
		AT_CUSTOM_MESSAGE,
		// Token: 0x040003A8 RID: 936
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_BATTERY_STATUS,
		// Token: 0x040003A9 RID: 937
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_DEVICE_MODE,
		// Token: 0x040003AA RID: 938
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_EMERGENCY_STATUS,
		// Token: 0x040003AB RID: 939
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_RADIO_INFO,
		// Token: 0x040003AC RID: 940
		[global::System.Runtime.Serialization.EnumMember]
		AT_RESET_TO_PROGMODE,
		// Token: 0x040003AD RID: 941
		[global::System.Runtime.Serialization.EnumMember]
		AT_SET_RP_STATE,
		// Token: 0x040003AE RID: 942
		[global::System.Runtime.Serialization.EnumMember]
		CLOSE_COMMUNICATION_PIPE,
		// Token: 0x040003AF RID: 943
		[global::System.Runtime.Serialization.EnumMember]
		GET_CEMSTONE_RADIO_FP_INFO,
		// Token: 0x040003B0 RID: 944
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_GET_PLATFORM_INFO,
		// Token: 0x040003B1 RID: 945
		[global::System.Runtime.Serialization.EnumMember]
		VERIFY_RADIO_LANGUAGE_PACK,
		// Token: 0x040003B2 RID: 946
		[global::System.Runtime.Serialization.EnumMember]
		REMOVE_RS232_RADIO_FROM_SYSTEM,
		// Token: 0x040003B3 RID: 947
		[global::System.Runtime.Serialization.EnumMember]
		AT_GET_DMS,
		// Token: 0x040003B4 RID: 948
		[global::System.Runtime.Serialization.EnumMember]
		AT_ERASE_DMS,
		// Token: 0x040003B5 RID: 949
		[global::System.Runtime.Serialization.EnumMember]
		AT_CHANGE_DMS_CODE,
		// Token: 0x040003B6 RID: 950
		[global::System.Runtime.Serialization.EnumMember]
		MS_COLLECT_PICTURES,
		// Token: 0x040003B7 RID: 951
		[global::System.Runtime.Serialization.EnumMember]
		MS_PUSH_PICTURES,
		// Token: 0x040003B8 RID: 952
		[global::System.Runtime.Serialization.EnumMember]
		CPA_AUTHENTICATE_RADIO,
		// Token: 0x040003B9 RID: 953
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_FLASH_REGION_OPERATION,
		// Token: 0x040003BA RID: 954
		[global::System.Runtime.Serialization.EnumMember]
		CPA_UNAUTHENTICATE_RADIO,
		// Token: 0x040003BB RID: 955
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_GET_STATUS,
		// Token: 0x040003BC RID: 956
		[global::System.Runtime.Serialization.EnumMember]
		SBEP_SET_DAMAGE_FLAG
	}
}
