using System;

namespace ASK.Interface
{
	/// <summary>
	/// Defines AccessElementIDType enumeration.
	/// </summary> 
	// Token: 0x02000004 RID: 4
	public enum AccessElementIDType
	{
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000004 RID: 4
		UNDEFINED,
		/// <summary>
		///             System ID
		/// </summary>
		// Token: 0x04000005 RID: 5
		TRK_SYS_GEN_SYS_ID_ELEMENT,
		/// <summary>
		///             Trunking System Connect Tone
		/// </summary>
		// Token: 0x04000006 RID: 6
		TRK_SYS_GEN_TYPE_II_CNCT_TONE_ELEMENT,
		/// <summary>
		///             Home WACN ID
		/// </summary>
		// Token: 0x04000007 RID: 7
		TRK_SYS_GEN_ASTRO_25_HOME_WACN_ID_ELEMENT,
		/// <summary>
		///             Unit ID
		/// </summary>
		// Token: 0x04000008 RID: 8
		TRK_SYS_GEN_UNIT_ID_ELEMENT,
		/// <summary>
		///             Coverage Type
		/// </summary>
		// Token: 0x04000009 RID: 9
		TRK_SYS_GEN_COV_TYPE_ELEMENT,
		/// <summary>
		///             Site ID
		/// </summary>
		// Token: 0x0400000A RID: 10
		TRK_SYS_GEN_SITE_ID_ELEMENT,
		/// <summary>
		///             RFSS  ID
		/// </summary>
		// Token: 0x0400000B RID: 11
		TRK_SYS_ASTRO_25_OMNI_RFSS_ID_ELEMENT,
		/// <summary>
		///             GEOFENCE MODE
		/// </summary>
		// Token: 0x0400000C RID: 12
		TRK_SYS_ASTRO_25_GEOFENCE_MODE_ID_ELEMENT = 78,
		/// <summary>
		///             Splinter Channel
		/// </summary>
		// Token: 0x0400000D RID: 13
		TRK_SYS_II_SPLINTER_CHAN_ELEMENT = 8,
		/// <summary>
		///             Identifier Enable
		/// </summary>
		// Token: 0x0400000E RID: 14
		TRK_SYS_ASTRO_25_CID_DIS_ELEMENT,
		/// <summary>
		///             Channel Bandwidth (kHz) ***Not in Mackinaw ***
		/// </summary>
		// Token: 0x0400000F RID: 15
		TRK_SYS_ASTRO_25_CID_BW_ELEMENT,
		/// <summary>
		///             Transmit Offset Sign
		/// </summary>
		// Token: 0x04000010 RID: 16
		TRK_SYS_ASTRO_25_CID_TX_OFFSET_SIGN_ELEMENT,
		/// <summary>
		///             Base Frequency (MHz)
		/// </summary>
		// Token: 0x04000011 RID: 17
		TRK_SYS_ASTRO_25_CID_BASE_FX_ELEMENT,
		/// <summary>
		///             Channel Spacing (kHz)
		/// </summary>
		// Token: 0x04000012 RID: 18
		TRK_SYS_ASTRO_25_CID_CHAN_SPACING_ELEMENT,
		/// <summary>
		///             Transmit Offset (MHz)
		/// </summary>
		// Token: 0x04000013 RID: 19
		TRK_SYS_ASTRO_25_CID_TX_OFFSET_ELEMENT,
		/// <summary>
		///             Channel Type ***New in Mackinaw ***
		/// </summary>
		// Token: 0x04000014 RID: 20
		TRK_SYS_ASTRO_25_CID_CHAN_TYPE_ELEMENT,
		/// <summary>
		///             Channel ID Number
		/// </summary>
		// Token: 0x04000015 RID: 21
		TRK_SYS_ASTRO_25_CC_800_CHAN_ID_NUM_ELEMENT,
		/// <summary>
		///             Chan Bandwidth (kHz)
		/// </summary>
		// Token: 0x04000016 RID: 22
		TRK_SYS_ASTRO_25_CC_OBT_CHAN_BW_ELEMENT,
		/// <summary>
		///             Rx Frequency
		/// </summary>
		// Token: 0x04000017 RID: 23
		TRK_SYS_CC_RX_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Tx Frequency
		/// </summary>
		// Token: 0x04000018 RID: 24
		TRK_SYS_CC_TX_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Band Plan Channel Identifier 
		/// </summary>
		// Token: 0x04000019 RID: 25
		TRK_SYS_BAND_PLAN_CID_ELEMENT,
		/// <summary>
		///             Band Plan Channel Bandwidth (KHz)
		/// </summary>
		// Token: 0x0400001A RID: 26
		TRK_SYS_BAND_PLAN_BW_ELEMENT,
		/// <summary>
		///             MSU Transmit Offset Sign
		/// </summary>
		// Token: 0x0400001B RID: 27
		TRK_SYS_BAND_PLAN_TX_OFFSET_SIGN_ELEMENT,
		/// <summary>
		///             MSU Transmit Offset (MHz)
		/// </summary>
		// Token: 0x0400001C RID: 28
		TRK_SYS_BAND_PLAN_TX_OFFSET_ELEMENT,
		/// <summary>
		///             Channel Spacing (kHz)
		/// </summary>
		// Token: 0x0400001D RID: 29
		TRK_SYS_BAND_PLAN_CHAN_SPACING_ELEMENT,
		/// <summary>
		///             Base Frequency
		/// </summary>
		// Token: 0x0400001E RID: 30
		TRK_SYS_BAND_PLAN_BASE_FX_ELEMENT,
		/// <summary>
		///             Failsoft Type
		/// </summary>
		// Token: 0x0400001F RID: 31
		TRK_PER_GEN_FS_TYPE_ELEMENT,
		/// <summary>
		///             Failsoft Rx Frequency (MHz)
		/// </summary>
		// Token: 0x04000020 RID: 32
		TRK_PER_GEN_FS_RX_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Failsoft Tx Frequency (MHz)
		/// </summary>
		// Token: 0x04000021 RID: 33
		TRK_PER_GEN_FS_TX_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Transmit Mode
		/// </summary>
		// Token: 0x04000022 RID: 34
		TRK_PER_GEN_TX_MODE_ELEMENT = 77,
		/// <summary>
		///             Time Out Timer
		/// </summary>
		// Token: 0x04000023 RID: 35
		TRK_PER_GEN_TIME_OUT_TIMER_ELEMENT = 80,
		/// <summary>
		///             Announcement Group
		/// </summary>
		// Token: 0x04000024 RID: 36
		TRK_PER_AG_AG_ELEMENT = 29,
		/// <summary>
		///             Announcement Group Failsoft
		/// </summary>
		// Token: 0x04000025 RID: 37
		TRK_PER_AG_AG_FS_ELEMENT,
		/// <summary>
		///             Channel ID Number
		/// </summary>
		// Token: 0x04000026 RID: 38
		TRK_PER_FS_800_AG_ASTRO_25_FS_CHAN_ID_ELEMENT,
		/// <summary>
		///             Chan Bandwidth (kHz)
		/// </summary>
		// Token: 0x04000027 RID: 39
		TRK_PER_FS_OBT_BW_ELEMENT,
		/// <summary>
		///             AG Failsoft Rx Frequency (MHz)
		/// </summary>
		// Token: 0x04000028 RID: 40
		TRK_PER_AG_FS_RX_CHAN_INCR_ELEMENT,
		/// <summary>
		///             AG Failsoft Tx Frequency (MHz)
		/// </summary>
		// Token: 0x04000029 RID: 41
		TRK_PER_AG_FS_TX_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Talkgroup Failsoft
		/// </summary>
		// Token: 0x0400002A RID: 42
		TRK_PER_TG_FS_EN_ELEMENT,
		/// <summary>
		///             Channel ID Number
		/// </summary>
		// Token: 0x0400002B RID: 43
		TRK_PER_TG_ASTRO_25_FS_CHAN_ID_ELEMENT,
		/// <summary>
		///             Chan Bandwidth (kHz)
		/// </summary>
		// Token: 0x0400002C RID: 44
		TRK_PER_TG_FS_BW_ELEMENT,
		/// <summary>
		///             Failsoft Rx Frequency
		/// </summary>
		// Token: 0x0400002D RID: 45
		TRK_PER_TG_FS_RX_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Failsoft Tx Frequency
		/// </summary>
		// Token: 0x0400002E RID: 46
		TRK_PER_TG_FS_TX_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Secure/Clear Strapping
		/// </summary>
		// Token: 0x0400002F RID: 47
		TRK_PER_TG_STRAP_ELEMENT,
		/// <summary>
		///             Talkgroup
		/// </summary>
		// Token: 0x04000030 RID: 48
		TRK_PER_TG_TG_ELEMENT,
		/// <summary>
		///             Key Select
		/// </summary>
		// Token: 0x04000031 RID: 49
		TRK_PER_TG_KEY_SEL_ELEMENT,
		/// <summary>
		///             Status
		/// </summary>
		// Token: 0x04000032 RID: 50
		TRK_PER_WAC_AMSS_STS_EN_ELEMENT,
		/// <summary>
		///             Frequency
		/// </summary>
		// Token: 0x04000033 RID: 51
		TRK_PER_WAC_AMSS_FS_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Rx Freq
		/// </summary>
		// Token: 0x04000034 RID: 52
		TRK_PER_WAC_AMSS_OBT_FS_RX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Tx Freq
		/// </summary>
		// Token: 0x04000035 RID: 53
		TRK_PER_WAC_AMSS_OBT_FS_TX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Astro alerting tone table
		/// </summary>
		// Token: 0x04000036 RID: 54
		TRK_PER_CALL_PAGE_ASTRO_ALERTING_TONE_TABLE_ELEMENT = 79,
		/// <summary>
		///             HPD Home System ID
		/// </summary>
		// Token: 0x04000037 RID: 55
		TRK_SYS_GEN_HPD_HOME_SYS_ID_ELEMENT = 47,
		/// <summary>
		///             HPD Home WACN ID
		/// </summary>
		// Token: 0x04000038 RID: 56
		TRK_SYS_GEN_HPD_HOME_WACN_ID_ELEMENT,
		/// <summary>
		///             HPD Unit ID
		/// </summary>
		// Token: 0x04000039 RID: 57
		TRK_SYS_GEN_HPD_UNIT_ID_ELEMENT,
		/// <summary>
		///             TX Channel Frequency
		/// </summary>
		// Token: 0x0400003A RID: 58
		TRK_SYS_STAC_CHAN_TX_ELEMENT,
		/// <summary>
		///             RX Channel Frequency
		/// </summary>
		// Token: 0x0400003B RID: 59
		TRK_SYS_STAC_CHAN_RX_ELEMENT,
		/// <summary>
		///             Static Channel Bandwidth (KHz)
		/// </summary>
		// Token: 0x0400003C RID: 60
		TRK_SYS_STAC_CHAN_BW_ELEMENT,
		/// <summary>
		///             Enable
		/// </summary>
		// Token: 0x0400003D RID: 61
		OTAP_ELEMENT,
		/// <summary>
		///             Talkgroup
		/// </summary>
		// Token: 0x0400003E RID: 62
		TRK_PER_ER_TYPE_II_DEF_TG_ELEMENT,
		/// <summary>
		///             Revert Individual ID
		/// </summary>
		// Token: 0x0400003F RID: 63
		TRK_PER_EM_REVERT_INDV_ID_ELEMENT,
		/// <summary>
		///             Revert Announcement group for Type II
		/// </summary>
		// Token: 0x04000040 RID: 64
		TRK_PER_ER_TYPE_II_DEF_AG_ELEMENT,
		/// <summary>
		///             Size Code
		/// </summary>
		// Token: 0x04000041 RID: 65
		TRK_PER_GEN_SZ_CODE_ELEMENT,
		/// <summary>
		///             Fleet Id
		/// </summary>
		// Token: 0x04000042 RID: 66
		TRK_PER_GEN_PFI_FLT_ID_ELEMENT,
		/// <summary>
		///             Fleet Wide Failsoft
		/// </summary>
		// Token: 0x04000043 RID: 67
		TRK_PER_FS_800_FLT_WIDE_CHAN_EN_ELEMENT,
		/// <summary>
		///             Fleet Wide Failsoft Frequency
		/// </summary>
		// Token: 0x04000044 RID: 68
		TRK_PER_FS_800_FLT_WIDE_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Failsoft
		/// </summary>
		// Token: 0x04000045 RID: 69
		TRK_PER_SF_FS_CHAN_EN_ELEMENT,
		/// <summary>
		/// F/S Frequency
		/// </summary>
		// Token: 0x04000046 RID: 70
		TRK_PER_SF_FS_CHAN_INCR_ELEMENT,
		/// <summary>
		///             Subfleet
		/// </summary>
		// Token: 0x04000047 RID: 71
		TRK_PER_SF_ELEMENT,
		/// <summary>
		///             Emergency Revert Size Code for Type Iii
		/// </summary>
		// Token: 0x04000048 RID: 72
		TRK_PER_ER_DEF_EMER_SZ_CODE_ELEMENT,
		/// <summary>
		///             Fleet ID
		/// </summary>
		// Token: 0x04000049 RID: 73
		TRK_PER_ER_FLT_ID_ELEMENT,
		/// <summary>
		///             Revert Subfleet
		/// </summary>
		// Token: 0x0400004A RID: 74
		TRK_PER_ER_SF_ELEMENT,
		/// <summary>
		/// IDS_PS_TRK_SYS
		/// </summary>
		// Token: 0x0400004B RID: 75
		TRK_SYS_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_PATH_TRK_SYS_CTRL_CHAN_OBT_TBL
		/// </summary>
		// Token: 0x0400004C RID: 76
		TRK_SYS_CTRL_CHAN_OBT_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_PATH_TRK_SYS_CHAN_800MHZ_TBL
		/// </summary>
		// Token: 0x0400004D RID: 77
		TRK_SYS_CHAN_800MHZ_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_PATH_TRK_SYS_APCO_CHAN_800MHZ_TBL
		/// </summary>
		// Token: 0x0400004E RID: 78
		TRK_SYS_APCO_CHAN_800MHZ_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_PATH_TRK_SYS_APCO_CTRL_CHAN_OBT_TBL
		/// </summary>
		// Token: 0x0400004F RID: 79
		TRK_SYS_APCO_CTRL_CHAN_OBT_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_PS_TRK_PER
		/// </summary>
		// Token: 0x04000050 RID: 80
		TRK_PER_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_PG_TRK_PER_TG_TBL
		/// </summary>
		// Token: 0x04000051 RID: 81
		TRK_PER_TG_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_PG_TRK_PER_SUBFL_TBL
		/// </summary>
		// Token: 0x04000052 RID: 82
		TRK_PER_SF_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_BOOL_SYSTEM_KEY_IN_LIST   cloning is based on this field
		/// </summary>
		// Token: 0x04000053 RID: 83
		CLONING_FUNCTIONS_ELEMENT,
		/// <summary>
		/// IDS_BOOL_WRITE_PROTECT_RADIO
		/// </summary>
		// Token: 0x04000054 RID: 84
		WRITE_PROTECT_RADIO_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000055 RID: 85
		LAST_FIELD_ELEMENT = 80
	}
}
