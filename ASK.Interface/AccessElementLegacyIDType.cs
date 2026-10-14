using System;

namespace ASK.Interface
{
	/// <summary>
	/// Defines AccessElementLegacyIDType enumeration.
	/// </summary>
	// Token: 0x02000005 RID: 5
	public enum AccessElementLegacyIDType
	{
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000057 RID: 87
		UNDEFINED,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000058 RID: 88
		TRK_SYS_GEN_TYPE_II_SYS_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000059 RID: 89
		TRK_SYS_GEN_TYPE_II_CNCT_TONE_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400005A RID: 90
		TRK_SYS_GEN_ASTRO_25_HOME_SYS_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400005B RID: 91
		TRK_SYS_GEN_ASTRO_25_HOME_WACN_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400005C RID: 92
		TRK_SYS_GEN_ASTRO_25_UNIT_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400005D RID: 93
		TRK_SYS_GEN_HPD_HOME_SYS_ID_ELEMENT = 85,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400005E RID: 94
		TRK_SYS_GEN_HPD_HOME_WACN_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400005F RID: 95
		TRK_SYS_GEN_HPD_UNIT_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000060 RID: 96
		TRK_SYS_GEN_COV_TYPE_ELEMENT = 6,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000061 RID: 97
		TRK_SYS_GEN_SITE_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000062 RID: 98
		TRK_SYS_ADV_SPLINTER_CHAN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000063 RID: 99
		TRK_SYS_ASTRO_25_SITE_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000064 RID: 100
		TRK_SYS_ASTRO_25_CID_DIS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000065 RID: 101
		TRK_SYS_ASTRO_25_CID_BW_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000066 RID: 102
		TRK_SYS_ASTRO_25_CID_TX_OFFSET_SIGN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000067 RID: 103
		TRK_SYS_ASTRO_25_CID_BASE_FX_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000068 RID: 104
		TRK_SYS_ASTRO_25_CID_CHAN_SPACING_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000069 RID: 105
		TRK_SYS_ASTRO_25_CID_TX_OFFSET_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400006A RID: 106
		TRK_SYS_ASTRO_25_CC_800_CHAN_ID_NUM_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400006B RID: 107
		TRK_SYS_ASTRO_25_CC_800_RX_FREQ_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400006C RID: 108
		TRK_SYS_ASTRO_25_CC_OBT_RX_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400006D RID: 109
		TRK_SYS_ASTRO_25_CC_OBT_TX_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400006E RID: 110
		TRK_SYS_ASTRO_25_CC_OBT_CHAN_BW_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400006F RID: 111
		TRK_SYS_ASTRO_25_OMNI_RFSS_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000070 RID: 112
		TRK_SYS_TYPE_II_CC_800_RX_FREQ_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000071 RID: 113
		TRK_SYS_TYPE_II_CC_OBT_RX_FREQ_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000072 RID: 114
		TRK_SYS_TYPE_II_CC_OBT_TX_FREQ_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000073 RID: 115
		TRK_SYS_TYPE_II_IND_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000074 RID: 116
		TRK_SYS_BAND_PLAN_CID_ELEMENT = 88,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000075 RID: 117
		TRK_SYS_BAND_PLAN_BW_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000076 RID: 118
		TRK_SYS_BAND_PLAN_TX_OFFSET_SIGN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000077 RID: 119
		TRK_SYS_BAND_PLAN_TX_OFFSET_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000078 RID: 120
		TRK_SYS_BAND_PLAN_CHAN_SPACING_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000079 RID: 121
		TRK_SYS_BAND_PLAN_BASE_FX_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400007A RID: 122
		TRK_SYS_STAC_CHAN_TX_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400007B RID: 123
		TRK_SYS_STAC_CHAN_RX_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400007C RID: 124
		TRK_SYS_STAC_CHAN_BW_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400007D RID: 125
		TRK_PER_GEN_AG_ELEMENT = 26,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400007E RID: 126
		TRK_PER_GEN_SZ_CODE_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400007F RID: 127
		TRK_PER_GEN_PFI_FLT_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000080 RID: 128
		TRK_PER_EM_REVERT_INDV_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000081 RID: 129
		TRK_PER_ER_DEF_EMER_SZ_CODE_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000082 RID: 130
		TRK_PER_ER_FLT_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000083 RID: 131
		TRK_PER_ER_TYPE_II_DEF_AG_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000084 RID: 132
		TRK_PER_ER_TYPE_II_DEF_TG_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000085 RID: 133
		TRK_PER_ER_SF_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000086 RID: 134
		TRK_PER_FS_800_AG_CHAN_EN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000087 RID: 135
		TRK_PER_FS_800_FLT_WIDE_CHAN_EN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000088 RID: 136
		TRK_PER_FS_800_AG_TYPE_II_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000089 RID: 137
		TRK_PER_FS_800_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400008A RID: 138
		TRK_PER_FS_800_FLT_WIDE_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400008B RID: 139
		TRK_PER_FS_800_FS_TYPE_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400008C RID: 140
		TRK_PER_FS_800_AG_ASTRO_25_FS_CHAN_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400008D RID: 141
		TRK_PER_FS_800_AG_ASTRO_25_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400008E RID: 142
		TRK_PER_FS_OBT_AG_CHAN_EN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400008F RID: 143
		TRK_PER_FS_OBT_AG_RX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000090 RID: 144
		TRK_PER_FS_OBT_AG_TX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000091 RID: 145
		TRK_PER_FS_OBT_RX_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000092 RID: 146
		TRK_PER_FS_OBT_TX_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000093 RID: 147
		TRK_PER_FS_OBT_RX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000094 RID: 148
		TRK_PER_FS_OBT_TX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000095 RID: 149
		TRK_PER_FS_OBT_BW_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000096 RID: 150
		TRK_PER_FS_OBT_TYPE_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000097 RID: 151
		TRK_PER_SF_FS_CHAN_EN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000098 RID: 152
		TRK_PER_SF_FS_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x04000099 RID: 153
		TRK_PER_SF_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400009A RID: 154
		TRK_PER_TG_OBT_ASTRO_25_FS_EN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400009B RID: 155
		TRK_PER_TG_OBT_TYPE_II_FS_EN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400009C RID: 156
		TRK_PER_TG_FS_CHAN_EN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400009D RID: 157
		TRK_PER_TG_OBT_FS_RX_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400009E RID: 158
		TRK_PER_TG_OBT_FS_TX_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x0400009F RID: 159
		TRK_PER_TG_800_FS_TYPE_II_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A0 RID: 160
		TRK_PER_TG_FS_RX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A1 RID: 161
		TRK_PER_TG_FS_TX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A2 RID: 162
		TRK_PER_TG_ASTRO_25_FS_CHAN_ID_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A3 RID: 163
		TRK_PER_TG_FS_BW_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A4 RID: 164
		TRK_PER_TG_STRAP_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A5 RID: 165
		TRK_PER_TG_ASTRO_25_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A6 RID: 166
		TRK_PER_TG_TYPE_II_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A7 RID: 167
		TRK_PER_TG_ASTRO_25_FS_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A8 RID: 168
		TRK_PER_TG_ASTRO_25_FS_TX_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000A9 RID: 169
		TRK_PER_TG_KEY_SEL_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000AA RID: 170
		TRK_PER_WAC_AMSS_STS_EN_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000AB RID: 171
		TRK_PER_WAC_AMSS_FS_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000AC RID: 172
		TRK_PER_WAC_AMSS_OBT_FS_RX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000AD RID: 173
		TRK_PER_WAC_AMSS_OBT_FS_TX_OSW_CHAN_INCR_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000AE RID: 174
		HOLDER_FOR_TRK_PER_CALL_PAGE_ASTRO_ALERTING_TONE_TABLE_ELEMENT = 99,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000AF RID: 175
		TRK_SYS_FUNCTIONS_ELEMENT = 75,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B0 RID: 176
		TRK_SYS_CTRL_CHAN_OBT_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B1 RID: 177
		TRK_SYS_CHAN_800MHZ_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B2 RID: 178
		TRK_SYS_APCO_CHAN_800MHZ_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B3 RID: 179
		TRK_SYS_APCO_CTRL_CHAN_OBT_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B4 RID: 180
		TRK_PER_FUNCTIONS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B5 RID: 181
		TRK_PER_TG_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B6 RID: 182
		TRK_PER_SF_TBL_FUNCTIONS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B7 RID: 183
		CLONING_FUNCTIONS_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B8 RID: 184
		WRITE_PROTECT_RADIO_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000B9 RID: 185
		HOLDER_FOR_TRK_PER_GEN_TX_MODE_ELEMENT = 97,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000BA RID: 186
		HOLDER_FOR_TRK_SYS_GEN_GEOFENCE_MODE_ELEMENT,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000BB RID: 187
		HOLDER_FOR_TRK_PER_GEN_TIME_OUT_TIMER_ELEMENT = 100,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000BC RID: 188
		LAST_FIELD_ELEMENT = 100,
		/// <summary>
		///
		/// </summary>
		// Token: 0x040000BD RID: 189
		OTAP_ELEMENT = 193
	}
}
