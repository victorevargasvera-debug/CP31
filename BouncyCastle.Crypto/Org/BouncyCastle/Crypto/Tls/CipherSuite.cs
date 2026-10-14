using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200030D RID: 781
	public abstract class CipherSuite
	{
		// Token: 0x06002126 RID: 8486 RVA: 0x00092F60 File Offset: 0x00091160
		public static bool IsScsv(int cipherSuite)
		{
			return cipherSuite == 255 || cipherSuite == 22016;
		}

		// Token: 0x04000BAD RID: 2989
		public const int TLS_NULL_WITH_NULL_NULL = 0;

		// Token: 0x04000BAE RID: 2990
		public const int TLS_RSA_WITH_NULL_MD5 = 1;

		// Token: 0x04000BAF RID: 2991
		public const int TLS_RSA_WITH_NULL_SHA = 2;

		// Token: 0x04000BB0 RID: 2992
		public const int TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;

		// Token: 0x04000BB1 RID: 2993
		public const int TLS_RSA_WITH_RC4_128_MD5 = 4;

		// Token: 0x04000BB2 RID: 2994
		public const int TLS_RSA_WITH_RC4_128_SHA = 5;

		// Token: 0x04000BB3 RID: 2995
		public const int TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;

		// Token: 0x04000BB4 RID: 2996
		public const int TLS_RSA_WITH_IDEA_CBC_SHA = 7;

		// Token: 0x04000BB5 RID: 2997
		public const int TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;

		// Token: 0x04000BB6 RID: 2998
		public const int TLS_RSA_WITH_DES_CBC_SHA = 9;

		// Token: 0x04000BB7 RID: 2999
		public const int TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;

		// Token: 0x04000BB8 RID: 3000
		public const int TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;

		// Token: 0x04000BB9 RID: 3001
		public const int TLS_DH_DSS_WITH_DES_CBC_SHA = 12;

		// Token: 0x04000BBA RID: 3002
		public const int TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;

		// Token: 0x04000BBB RID: 3003
		public const int TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;

		// Token: 0x04000BBC RID: 3004
		public const int TLS_DH_RSA_WITH_DES_CBC_SHA = 15;

		// Token: 0x04000BBD RID: 3005
		public const int TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;

		// Token: 0x04000BBE RID: 3006
		public const int TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;

		// Token: 0x04000BBF RID: 3007
		public const int TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;

		// Token: 0x04000BC0 RID: 3008
		public const int TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;

		// Token: 0x04000BC1 RID: 3009
		public const int TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;

		// Token: 0x04000BC2 RID: 3010
		public const int TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;

		// Token: 0x04000BC3 RID: 3011
		public const int TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;

		// Token: 0x04000BC4 RID: 3012
		public const int TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;

		// Token: 0x04000BC5 RID: 3013
		public const int TLS_DH_anon_WITH_RC4_128_MD5 = 24;

		// Token: 0x04000BC6 RID: 3014
		public const int TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;

		// Token: 0x04000BC7 RID: 3015
		public const int TLS_DH_anon_WITH_DES_CBC_SHA = 26;

		// Token: 0x04000BC8 RID: 3016
		public const int TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;

		// Token: 0x04000BC9 RID: 3017
		public const int TLS_RSA_WITH_AES_128_CBC_SHA = 47;

		// Token: 0x04000BCA RID: 3018
		public const int TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;

		// Token: 0x04000BCB RID: 3019
		public const int TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;

		// Token: 0x04000BCC RID: 3020
		public const int TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;

		// Token: 0x04000BCD RID: 3021
		public const int TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;

		// Token: 0x04000BCE RID: 3022
		public const int TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;

		// Token: 0x04000BCF RID: 3023
		public const int TLS_RSA_WITH_AES_256_CBC_SHA = 53;

		// Token: 0x04000BD0 RID: 3024
		public const int TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;

		// Token: 0x04000BD1 RID: 3025
		public const int TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;

		// Token: 0x04000BD2 RID: 3026
		public const int TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;

		// Token: 0x04000BD3 RID: 3027
		public const int TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;

		// Token: 0x04000BD4 RID: 3028
		public const int TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;

		// Token: 0x04000BD5 RID: 3029
		public const int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;

		// Token: 0x04000BD6 RID: 3030
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;

		// Token: 0x04000BD7 RID: 3031
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;

		// Token: 0x04000BD8 RID: 3032
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;

		// Token: 0x04000BD9 RID: 3033
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;

		// Token: 0x04000BDA RID: 3034
		public const int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;

		// Token: 0x04000BDB RID: 3035
		public const int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;

		// Token: 0x04000BDC RID: 3036
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;

		// Token: 0x04000BDD RID: 3037
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;

		// Token: 0x04000BDE RID: 3038
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;

		// Token: 0x04000BDF RID: 3039
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;

		// Token: 0x04000BE0 RID: 3040
		public const int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;

		// Token: 0x04000BE1 RID: 3041
		public const int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;

		// Token: 0x04000BE2 RID: 3042
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;

		// Token: 0x04000BE3 RID: 3043
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;

		// Token: 0x04000BE4 RID: 3044
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;

		// Token: 0x04000BE5 RID: 3045
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;

		// Token: 0x04000BE6 RID: 3046
		public const int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;

		// Token: 0x04000BE7 RID: 3047
		public const int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;

		// Token: 0x04000BE8 RID: 3048
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;

		// Token: 0x04000BE9 RID: 3049
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;

		// Token: 0x04000BEA RID: 3050
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;

		// Token: 0x04000BEB RID: 3051
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;

		// Token: 0x04000BEC RID: 3052
		public const int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;

		// Token: 0x04000BED RID: 3053
		public const int TLS_RSA_WITH_SEED_CBC_SHA = 150;

		// Token: 0x04000BEE RID: 3054
		public const int TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;

		// Token: 0x04000BEF RID: 3055
		public const int TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;

		// Token: 0x04000BF0 RID: 3056
		public const int TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;

		// Token: 0x04000BF1 RID: 3057
		public const int TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;

		// Token: 0x04000BF2 RID: 3058
		public const int TLS_DH_anon_WITH_SEED_CBC_SHA = 155;

		// Token: 0x04000BF3 RID: 3059
		public const int TLS_PSK_WITH_RC4_128_SHA = 138;

		// Token: 0x04000BF4 RID: 3060
		public const int TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;

		// Token: 0x04000BF5 RID: 3061
		public const int TLS_PSK_WITH_AES_128_CBC_SHA = 140;

		// Token: 0x04000BF6 RID: 3062
		public const int TLS_PSK_WITH_AES_256_CBC_SHA = 141;

		// Token: 0x04000BF7 RID: 3063
		public const int TLS_DHE_PSK_WITH_RC4_128_SHA = 142;

		// Token: 0x04000BF8 RID: 3064
		public const int TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;

		// Token: 0x04000BF9 RID: 3065
		public const int TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;

		// Token: 0x04000BFA RID: 3066
		public const int TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;

		// Token: 0x04000BFB RID: 3067
		public const int TLS_RSA_PSK_WITH_RC4_128_SHA = 146;

		// Token: 0x04000BFC RID: 3068
		public const int TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;

		// Token: 0x04000BFD RID: 3069
		public const int TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;

		// Token: 0x04000BFE RID: 3070
		public const int TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;

		// Token: 0x04000BFF RID: 3071
		public const int TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;

		// Token: 0x04000C00 RID: 3072
		public const int TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;

		// Token: 0x04000C01 RID: 3073
		public const int TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;

		// Token: 0x04000C02 RID: 3074
		public const int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;

		// Token: 0x04000C03 RID: 3075
		public const int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;

		// Token: 0x04000C04 RID: 3076
		public const int TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;

		// Token: 0x04000C05 RID: 3077
		public const int TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;

		// Token: 0x04000C06 RID: 3078
		public const int TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;

		// Token: 0x04000C07 RID: 3079
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;

		// Token: 0x04000C08 RID: 3080
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;

		// Token: 0x04000C09 RID: 3081
		public const int TLS_ECDH_RSA_WITH_NULL_SHA = 49163;

		// Token: 0x04000C0A RID: 3082
		public const int TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;

		// Token: 0x04000C0B RID: 3083
		public const int TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;

		// Token: 0x04000C0C RID: 3084
		public const int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;

		// Token: 0x04000C0D RID: 3085
		public const int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;

		// Token: 0x04000C0E RID: 3086
		public const int TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;

		// Token: 0x04000C0F RID: 3087
		public const int TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;

		// Token: 0x04000C10 RID: 3088
		public const int TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;

		// Token: 0x04000C11 RID: 3089
		public const int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;

		// Token: 0x04000C12 RID: 3090
		public const int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;

		// Token: 0x04000C13 RID: 3091
		public const int TLS_ECDH_anon_WITH_NULL_SHA = 49173;

		// Token: 0x04000C14 RID: 3092
		public const int TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;

		// Token: 0x04000C15 RID: 3093
		public const int TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;

		// Token: 0x04000C16 RID: 3094
		public const int TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;

		// Token: 0x04000C17 RID: 3095
		public const int TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;

		// Token: 0x04000C18 RID: 3096
		public const int TLS_PSK_WITH_NULL_SHA = 44;

		// Token: 0x04000C19 RID: 3097
		public const int TLS_DHE_PSK_WITH_NULL_SHA = 45;

		// Token: 0x04000C1A RID: 3098
		public const int TLS_RSA_PSK_WITH_NULL_SHA = 46;

		// Token: 0x04000C1B RID: 3099
		public const int TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;

		// Token: 0x04000C1C RID: 3100
		public const int TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;

		// Token: 0x04000C1D RID: 3101
		public const int TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;

		// Token: 0x04000C1E RID: 3102
		public const int TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;

		// Token: 0x04000C1F RID: 3103
		public const int TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;

		// Token: 0x04000C20 RID: 3104
		public const int TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;

		// Token: 0x04000C21 RID: 3105
		public const int TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;

		// Token: 0x04000C22 RID: 3106
		public const int TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;

		// Token: 0x04000C23 RID: 3107
		public const int TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;

		// Token: 0x04000C24 RID: 3108
		public const int TLS_RSA_WITH_NULL_SHA256 = 59;

		// Token: 0x04000C25 RID: 3109
		public const int TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;

		// Token: 0x04000C26 RID: 3110
		public const int TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;

		// Token: 0x04000C27 RID: 3111
		public const int TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;

		// Token: 0x04000C28 RID: 3112
		public const int TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;

		// Token: 0x04000C29 RID: 3113
		public const int TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;

		// Token: 0x04000C2A RID: 3114
		public const int TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;

		// Token: 0x04000C2B RID: 3115
		public const int TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;

		// Token: 0x04000C2C RID: 3116
		public const int TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;

		// Token: 0x04000C2D RID: 3117
		public const int TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;

		// Token: 0x04000C2E RID: 3118
		public const int TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;

		// Token: 0x04000C2F RID: 3119
		public const int TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;

		// Token: 0x04000C30 RID: 3120
		public const int TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;

		// Token: 0x04000C31 RID: 3121
		public const int TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;

		// Token: 0x04000C32 RID: 3122
		public const int TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;

		// Token: 0x04000C33 RID: 3123
		public const int TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;

		// Token: 0x04000C34 RID: 3124
		public const int TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;

		// Token: 0x04000C35 RID: 3125
		public const int TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;

		// Token: 0x04000C36 RID: 3126
		public const int TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;

		// Token: 0x04000C37 RID: 3127
		public const int TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;

		// Token: 0x04000C38 RID: 3128
		public const int TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;

		// Token: 0x04000C39 RID: 3129
		public const int TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;

		// Token: 0x04000C3A RID: 3130
		public const int TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;

		// Token: 0x04000C3B RID: 3131
		public const int TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;

		// Token: 0x04000C3C RID: 3132
		public const int TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;

		// Token: 0x04000C3D RID: 3133
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;

		// Token: 0x04000C3E RID: 3134
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;

		// Token: 0x04000C3F RID: 3135
		public const int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;

		// Token: 0x04000C40 RID: 3136
		public const int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;

		// Token: 0x04000C41 RID: 3137
		public const int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;

		// Token: 0x04000C42 RID: 3138
		public const int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;

		// Token: 0x04000C43 RID: 3139
		public const int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;

		// Token: 0x04000C44 RID: 3140
		public const int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;

		// Token: 0x04000C45 RID: 3141
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;

		// Token: 0x04000C46 RID: 3142
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;

		// Token: 0x04000C47 RID: 3143
		public const int TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;

		// Token: 0x04000C48 RID: 3144
		public const int TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;

		// Token: 0x04000C49 RID: 3145
		public const int TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;

		// Token: 0x04000C4A RID: 3146
		public const int TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;

		// Token: 0x04000C4B RID: 3147
		public const int TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;

		// Token: 0x04000C4C RID: 3148
		public const int TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;

		// Token: 0x04000C4D RID: 3149
		public const int TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;

		// Token: 0x04000C4E RID: 3150
		public const int TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;

		// Token: 0x04000C4F RID: 3151
		public const int TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;

		// Token: 0x04000C50 RID: 3152
		public const int TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;

		// Token: 0x04000C51 RID: 3153
		public const int TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;

		// Token: 0x04000C52 RID: 3154
		public const int TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;

		// Token: 0x04000C53 RID: 3155
		public const int TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;

		// Token: 0x04000C54 RID: 3156
		public const int TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;

		// Token: 0x04000C55 RID: 3157
		public const int TLS_PSK_WITH_NULL_SHA256 = 176;

		// Token: 0x04000C56 RID: 3158
		public const int TLS_PSK_WITH_NULL_SHA384 = 177;

		// Token: 0x04000C57 RID: 3159
		public const int TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;

		// Token: 0x04000C58 RID: 3160
		public const int TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;

		// Token: 0x04000C59 RID: 3161
		public const int TLS_DHE_PSK_WITH_NULL_SHA256 = 180;

		// Token: 0x04000C5A RID: 3162
		public const int TLS_DHE_PSK_WITH_NULL_SHA384 = 181;

		// Token: 0x04000C5B RID: 3163
		public const int TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;

		// Token: 0x04000C5C RID: 3164
		public const int TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;

		// Token: 0x04000C5D RID: 3165
		public const int TLS_RSA_PSK_WITH_NULL_SHA256 = 184;

		// Token: 0x04000C5E RID: 3166
		public const int TLS_RSA_PSK_WITH_NULL_SHA384 = 185;

		// Token: 0x04000C5F RID: 3167
		public const int TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;

		// Token: 0x04000C60 RID: 3168
		public const int TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;

		// Token: 0x04000C61 RID: 3169
		public const int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;

		// Token: 0x04000C62 RID: 3170
		public const int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;

		// Token: 0x04000C63 RID: 3171
		public const int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;

		// Token: 0x04000C64 RID: 3172
		public const int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;

		// Token: 0x04000C65 RID: 3173
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;

		// Token: 0x04000C66 RID: 3174
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;

		// Token: 0x04000C67 RID: 3175
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;

		// Token: 0x04000C68 RID: 3176
		public const int TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;

		// Token: 0x04000C69 RID: 3177
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;

		// Token: 0x04000C6A RID: 3178
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;

		// Token: 0x04000C6B RID: 3179
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;

		// Token: 0x04000C6C RID: 3180
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;

		// Token: 0x04000C6D RID: 3181
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;

		// Token: 0x04000C6E RID: 3182
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;

		// Token: 0x04000C6F RID: 3183
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;

		// Token: 0x04000C70 RID: 3184
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;

		// Token: 0x04000C71 RID: 3185
		public const int TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;

		// Token: 0x04000C72 RID: 3186
		public const int TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;

		// Token: 0x04000C73 RID: 3187
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;

		// Token: 0x04000C74 RID: 3188
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;

		// Token: 0x04000C75 RID: 3189
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;

		// Token: 0x04000C76 RID: 3190
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;

		// Token: 0x04000C77 RID: 3191
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;

		// Token: 0x04000C78 RID: 3192
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;

		// Token: 0x04000C79 RID: 3193
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;

		// Token: 0x04000C7A RID: 3194
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;

		// Token: 0x04000C7B RID: 3195
		public const int TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;

		// Token: 0x04000C7C RID: 3196
		public const int TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;

		// Token: 0x04000C7D RID: 3197
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;

		// Token: 0x04000C7E RID: 3198
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;

		// Token: 0x04000C7F RID: 3199
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;

		// Token: 0x04000C80 RID: 3200
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;

		// Token: 0x04000C81 RID: 3201
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;

		// Token: 0x04000C82 RID: 3202
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;

		// Token: 0x04000C83 RID: 3203
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;

		// Token: 0x04000C84 RID: 3204
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;

		// Token: 0x04000C85 RID: 3205
		public const int TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;

		// Token: 0x04000C86 RID: 3206
		public const int TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;

		// Token: 0x04000C87 RID: 3207
		public const int TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;

		// Token: 0x04000C88 RID: 3208
		public const int TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;

		// Token: 0x04000C89 RID: 3209
		public const int TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;

		// Token: 0x04000C8A RID: 3210
		public const int TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;

		// Token: 0x04000C8B RID: 3211
		public const int TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;

		// Token: 0x04000C8C RID: 3212
		public const int TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;

		// Token: 0x04000C8D RID: 3213
		public const int TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;

		// Token: 0x04000C8E RID: 3214
		public const int TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;

		// Token: 0x04000C8F RID: 3215
		public const int TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;

		// Token: 0x04000C90 RID: 3216
		public const int TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;

		// Token: 0x04000C91 RID: 3217
		public const int TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;

		// Token: 0x04000C92 RID: 3218
		public const int TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;

		// Token: 0x04000C93 RID: 3219
		public const int TLS_RSA_WITH_AES_128_CCM = 49308;

		// Token: 0x04000C94 RID: 3220
		public const int TLS_RSA_WITH_AES_256_CCM = 49309;

		// Token: 0x04000C95 RID: 3221
		public const int TLS_DHE_RSA_WITH_AES_128_CCM = 49310;

		// Token: 0x04000C96 RID: 3222
		public const int TLS_DHE_RSA_WITH_AES_256_CCM = 49311;

		// Token: 0x04000C97 RID: 3223
		public const int TLS_RSA_WITH_AES_128_CCM_8 = 49312;

		// Token: 0x04000C98 RID: 3224
		public const int TLS_RSA_WITH_AES_256_CCM_8 = 49313;

		// Token: 0x04000C99 RID: 3225
		public const int TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;

		// Token: 0x04000C9A RID: 3226
		public const int TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;

		// Token: 0x04000C9B RID: 3227
		public const int TLS_PSK_WITH_AES_128_CCM = 49316;

		// Token: 0x04000C9C RID: 3228
		public const int TLS_PSK_WITH_AES_256_CCM = 49317;

		// Token: 0x04000C9D RID: 3229
		public const int TLS_DHE_PSK_WITH_AES_128_CCM = 49318;

		// Token: 0x04000C9E RID: 3230
		public const int TLS_DHE_PSK_WITH_AES_256_CCM = 49319;

		// Token: 0x04000C9F RID: 3231
		public const int TLS_PSK_WITH_AES_128_CCM_8 = 49320;

		// Token: 0x04000CA0 RID: 3232
		public const int TLS_PSK_WITH_AES_256_CCM_8 = 49321;

		// Token: 0x04000CA1 RID: 3233
		public const int TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;

		// Token: 0x04000CA2 RID: 3234
		public const int TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;

		// Token: 0x04000CA3 RID: 3235
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CCM = 49324;

		// Token: 0x04000CA4 RID: 3236
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CCM = 49325;

		// Token: 0x04000CA5 RID: 3237
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CCM_8 = 49326;

		// Token: 0x04000CA6 RID: 3238
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CCM_8 = 49327;

		// Token: 0x04000CA7 RID: 3239
		public const int TLS_FALLBACK_SCSV = 22016;

		// Token: 0x04000CA8 RID: 3240
		public const int DRAFT_TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52392;

		// Token: 0x04000CA9 RID: 3241
		public const int DRAFT_TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52393;

		// Token: 0x04000CAA RID: 3242
		public const int DRAFT_TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52394;

		// Token: 0x04000CAB RID: 3243
		public const int DRAFT_TLS_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52395;

		// Token: 0x04000CAC RID: 3244
		public const int DRAFT_TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52396;

		// Token: 0x04000CAD RID: 3245
		public const int DRAFT_TLS_DHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52397;

		// Token: 0x04000CAE RID: 3246
		public const int DRAFT_TLS_RSA_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52398;
	}
}
