using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000A1 RID: 161
	public abstract class CipherSuite
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x0001ADC5 File Offset: 0x00018FC5
		public static bool IsScsv(int cipherSuite)
		{
			return cipherSuite == 255 || cipherSuite == 22016;
		}

		// Token: 0x04000359 RID: 857
		public const int TLS_NULL_WITH_NULL_NULL = 0;

		// Token: 0x0400035A RID: 858
		public const int TLS_RSA_WITH_NULL_MD5 = 1;

		// Token: 0x0400035B RID: 859
		public const int TLS_RSA_WITH_NULL_SHA = 2;

		// Token: 0x0400035C RID: 860
		public const int TLS_RSA_EXPORT_WITH_RC4_40_MD5 = 3;

		// Token: 0x0400035D RID: 861
		public const int TLS_RSA_WITH_RC4_128_MD5 = 4;

		// Token: 0x0400035E RID: 862
		public const int TLS_RSA_WITH_RC4_128_SHA = 5;

		// Token: 0x0400035F RID: 863
		public const int TLS_RSA_EXPORT_WITH_RC2_CBC_40_MD5 = 6;

		// Token: 0x04000360 RID: 864
		public const int TLS_RSA_WITH_IDEA_CBC_SHA = 7;

		// Token: 0x04000361 RID: 865
		public const int TLS_RSA_EXPORT_WITH_DES40_CBC_SHA = 8;

		// Token: 0x04000362 RID: 866
		public const int TLS_RSA_WITH_DES_CBC_SHA = 9;

		// Token: 0x04000363 RID: 867
		public const int TLS_RSA_WITH_3DES_EDE_CBC_SHA = 10;

		// Token: 0x04000364 RID: 868
		public const int TLS_DH_DSS_EXPORT_WITH_DES40_CBC_SHA = 11;

		// Token: 0x04000365 RID: 869
		public const int TLS_DH_DSS_WITH_DES_CBC_SHA = 12;

		// Token: 0x04000366 RID: 870
		public const int TLS_DH_DSS_WITH_3DES_EDE_CBC_SHA = 13;

		// Token: 0x04000367 RID: 871
		public const int TLS_DH_RSA_EXPORT_WITH_DES40_CBC_SHA = 14;

		// Token: 0x04000368 RID: 872
		public const int TLS_DH_RSA_WITH_DES_CBC_SHA = 15;

		// Token: 0x04000369 RID: 873
		public const int TLS_DH_RSA_WITH_3DES_EDE_CBC_SHA = 16;

		// Token: 0x0400036A RID: 874
		public const int TLS_DHE_DSS_EXPORT_WITH_DES40_CBC_SHA = 17;

		// Token: 0x0400036B RID: 875
		public const int TLS_DHE_DSS_WITH_DES_CBC_SHA = 18;

		// Token: 0x0400036C RID: 876
		public const int TLS_DHE_DSS_WITH_3DES_EDE_CBC_SHA = 19;

		// Token: 0x0400036D RID: 877
		public const int TLS_DHE_RSA_EXPORT_WITH_DES40_CBC_SHA = 20;

		// Token: 0x0400036E RID: 878
		public const int TLS_DHE_RSA_WITH_DES_CBC_SHA = 21;

		// Token: 0x0400036F RID: 879
		public const int TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 22;

		// Token: 0x04000370 RID: 880
		public const int TLS_DH_anon_EXPORT_WITH_RC4_40_MD5 = 23;

		// Token: 0x04000371 RID: 881
		public const int TLS_DH_anon_WITH_RC4_128_MD5 = 24;

		// Token: 0x04000372 RID: 882
		public const int TLS_DH_anon_EXPORT_WITH_DES40_CBC_SHA = 25;

		// Token: 0x04000373 RID: 883
		public const int TLS_DH_anon_WITH_DES_CBC_SHA = 26;

		// Token: 0x04000374 RID: 884
		public const int TLS_DH_anon_WITH_3DES_EDE_CBC_SHA = 27;

		// Token: 0x04000375 RID: 885
		public const int TLS_RSA_WITH_AES_128_CBC_SHA = 47;

		// Token: 0x04000376 RID: 886
		public const int TLS_DH_DSS_WITH_AES_128_CBC_SHA = 48;

		// Token: 0x04000377 RID: 887
		public const int TLS_DH_RSA_WITH_AES_128_CBC_SHA = 49;

		// Token: 0x04000378 RID: 888
		public const int TLS_DHE_DSS_WITH_AES_128_CBC_SHA = 50;

		// Token: 0x04000379 RID: 889
		public const int TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 51;

		// Token: 0x0400037A RID: 890
		public const int TLS_DH_anon_WITH_AES_128_CBC_SHA = 52;

		// Token: 0x0400037B RID: 891
		public const int TLS_RSA_WITH_AES_256_CBC_SHA = 53;

		// Token: 0x0400037C RID: 892
		public const int TLS_DH_DSS_WITH_AES_256_CBC_SHA = 54;

		// Token: 0x0400037D RID: 893
		public const int TLS_DH_RSA_WITH_AES_256_CBC_SHA = 55;

		// Token: 0x0400037E RID: 894
		public const int TLS_DHE_DSS_WITH_AES_256_CBC_SHA = 56;

		// Token: 0x0400037F RID: 895
		public const int TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 57;

		// Token: 0x04000380 RID: 896
		public const int TLS_DH_anon_WITH_AES_256_CBC_SHA = 58;

		// Token: 0x04000381 RID: 897
		public const int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 65;

		// Token: 0x04000382 RID: 898
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA = 66;

		// Token: 0x04000383 RID: 899
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA = 67;

		// Token: 0x04000384 RID: 900
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA = 68;

		// Token: 0x04000385 RID: 901
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 69;

		// Token: 0x04000386 RID: 902
		public const int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA = 70;

		// Token: 0x04000387 RID: 903
		public const int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 132;

		// Token: 0x04000388 RID: 904
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA = 133;

		// Token: 0x04000389 RID: 905
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA = 134;

		// Token: 0x0400038A RID: 906
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA = 135;

		// Token: 0x0400038B RID: 907
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 136;

		// Token: 0x0400038C RID: 908
		public const int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA = 137;

		// Token: 0x0400038D RID: 909
		public const int TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 186;

		// Token: 0x0400038E RID: 910
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 187;

		// Token: 0x0400038F RID: 911
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 188;

		// Token: 0x04000390 RID: 912
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_CBC_SHA256 = 189;

		// Token: 0x04000391 RID: 913
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 190;

		// Token: 0x04000392 RID: 914
		public const int TLS_DH_anon_WITH_CAMELLIA_128_CBC_SHA256 = 191;

		// Token: 0x04000393 RID: 915
		public const int TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 192;

		// Token: 0x04000394 RID: 916
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 193;

		// Token: 0x04000395 RID: 917
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 194;

		// Token: 0x04000396 RID: 918
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_CBC_SHA256 = 195;

		// Token: 0x04000397 RID: 919
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 196;

		// Token: 0x04000398 RID: 920
		public const int TLS_DH_anon_WITH_CAMELLIA_256_CBC_SHA256 = 197;

		// Token: 0x04000399 RID: 921
		public const int TLS_RSA_WITH_SEED_CBC_SHA = 150;

		// Token: 0x0400039A RID: 922
		public const int TLS_DH_DSS_WITH_SEED_CBC_SHA = 151;

		// Token: 0x0400039B RID: 923
		public const int TLS_DH_RSA_WITH_SEED_CBC_SHA = 152;

		// Token: 0x0400039C RID: 924
		public const int TLS_DHE_DSS_WITH_SEED_CBC_SHA = 153;

		// Token: 0x0400039D RID: 925
		public const int TLS_DHE_RSA_WITH_SEED_CBC_SHA = 154;

		// Token: 0x0400039E RID: 926
		public const int TLS_DH_anon_WITH_SEED_CBC_SHA = 155;

		// Token: 0x0400039F RID: 927
		public const int TLS_PSK_WITH_RC4_128_SHA = 138;

		// Token: 0x040003A0 RID: 928
		public const int TLS_PSK_WITH_3DES_EDE_CBC_SHA = 139;

		// Token: 0x040003A1 RID: 929
		public const int TLS_PSK_WITH_AES_128_CBC_SHA = 140;

		// Token: 0x040003A2 RID: 930
		public const int TLS_PSK_WITH_AES_256_CBC_SHA = 141;

		// Token: 0x040003A3 RID: 931
		public const int TLS_DHE_PSK_WITH_RC4_128_SHA = 142;

		// Token: 0x040003A4 RID: 932
		public const int TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 143;

		// Token: 0x040003A5 RID: 933
		public const int TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 144;

		// Token: 0x040003A6 RID: 934
		public const int TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 145;

		// Token: 0x040003A7 RID: 935
		public const int TLS_RSA_PSK_WITH_RC4_128_SHA = 146;

		// Token: 0x040003A8 RID: 936
		public const int TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 147;

		// Token: 0x040003A9 RID: 937
		public const int TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 148;

		// Token: 0x040003AA RID: 938
		public const int TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 149;

		// Token: 0x040003AB RID: 939
		public const int TLS_ECDH_ECDSA_WITH_NULL_SHA = 49153;

		// Token: 0x040003AC RID: 940
		public const int TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 49154;

		// Token: 0x040003AD RID: 941
		public const int TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 49155;

		// Token: 0x040003AE RID: 942
		public const int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 49156;

		// Token: 0x040003AF RID: 943
		public const int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 49157;

		// Token: 0x040003B0 RID: 944
		public const int TLS_ECDHE_ECDSA_WITH_NULL_SHA = 49158;

		// Token: 0x040003B1 RID: 945
		public const int TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 49159;

		// Token: 0x040003B2 RID: 946
		public const int TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 49160;

		// Token: 0x040003B3 RID: 947
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 49161;

		// Token: 0x040003B4 RID: 948
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 49162;

		// Token: 0x040003B5 RID: 949
		public const int TLS_ECDH_RSA_WITH_NULL_SHA = 49163;

		// Token: 0x040003B6 RID: 950
		public const int TLS_ECDH_RSA_WITH_RC4_128_SHA = 49164;

		// Token: 0x040003B7 RID: 951
		public const int TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 49165;

		// Token: 0x040003B8 RID: 952
		public const int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 49166;

		// Token: 0x040003B9 RID: 953
		public const int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 49167;

		// Token: 0x040003BA RID: 954
		public const int TLS_ECDHE_RSA_WITH_NULL_SHA = 49168;

		// Token: 0x040003BB RID: 955
		public const int TLS_ECDHE_RSA_WITH_RC4_128_SHA = 49169;

		// Token: 0x040003BC RID: 956
		public const int TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 49170;

		// Token: 0x040003BD RID: 957
		public const int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 49171;

		// Token: 0x040003BE RID: 958
		public const int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 49172;

		// Token: 0x040003BF RID: 959
		public const int TLS_ECDH_anon_WITH_NULL_SHA = 49173;

		// Token: 0x040003C0 RID: 960
		public const int TLS_ECDH_anon_WITH_RC4_128_SHA = 49174;

		// Token: 0x040003C1 RID: 961
		public const int TLS_ECDH_anon_WITH_3DES_EDE_CBC_SHA = 49175;

		// Token: 0x040003C2 RID: 962
		public const int TLS_ECDH_anon_WITH_AES_128_CBC_SHA = 49176;

		// Token: 0x040003C3 RID: 963
		public const int TLS_ECDH_anon_WITH_AES_256_CBC_SHA = 49177;

		// Token: 0x040003C4 RID: 964
		public const int TLS_PSK_WITH_NULL_SHA = 44;

		// Token: 0x040003C5 RID: 965
		public const int TLS_DHE_PSK_WITH_NULL_SHA = 45;

		// Token: 0x040003C6 RID: 966
		public const int TLS_RSA_PSK_WITH_NULL_SHA = 46;

		// Token: 0x040003C7 RID: 967
		public const int TLS_SRP_SHA_WITH_3DES_EDE_CBC_SHA = 49178;

		// Token: 0x040003C8 RID: 968
		public const int TLS_SRP_SHA_RSA_WITH_3DES_EDE_CBC_SHA = 49179;

		// Token: 0x040003C9 RID: 969
		public const int TLS_SRP_SHA_DSS_WITH_3DES_EDE_CBC_SHA = 49180;

		// Token: 0x040003CA RID: 970
		public const int TLS_SRP_SHA_WITH_AES_128_CBC_SHA = 49181;

		// Token: 0x040003CB RID: 971
		public const int TLS_SRP_SHA_RSA_WITH_AES_128_CBC_SHA = 49182;

		// Token: 0x040003CC RID: 972
		public const int TLS_SRP_SHA_DSS_WITH_AES_128_CBC_SHA = 49183;

		// Token: 0x040003CD RID: 973
		public const int TLS_SRP_SHA_WITH_AES_256_CBC_SHA = 49184;

		// Token: 0x040003CE RID: 974
		public const int TLS_SRP_SHA_RSA_WITH_AES_256_CBC_SHA = 49185;

		// Token: 0x040003CF RID: 975
		public const int TLS_SRP_SHA_DSS_WITH_AES_256_CBC_SHA = 49186;

		// Token: 0x040003D0 RID: 976
		public const int TLS_RSA_WITH_NULL_SHA256 = 59;

		// Token: 0x040003D1 RID: 977
		public const int TLS_RSA_WITH_AES_128_CBC_SHA256 = 60;

		// Token: 0x040003D2 RID: 978
		public const int TLS_RSA_WITH_AES_256_CBC_SHA256 = 61;

		// Token: 0x040003D3 RID: 979
		public const int TLS_DH_DSS_WITH_AES_128_CBC_SHA256 = 62;

		// Token: 0x040003D4 RID: 980
		public const int TLS_DH_RSA_WITH_AES_128_CBC_SHA256 = 63;

		// Token: 0x040003D5 RID: 981
		public const int TLS_DHE_DSS_WITH_AES_128_CBC_SHA256 = 64;

		// Token: 0x040003D6 RID: 982
		public const int TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 103;

		// Token: 0x040003D7 RID: 983
		public const int TLS_DH_DSS_WITH_AES_256_CBC_SHA256 = 104;

		// Token: 0x040003D8 RID: 984
		public const int TLS_DH_RSA_WITH_AES_256_CBC_SHA256 = 105;

		// Token: 0x040003D9 RID: 985
		public const int TLS_DHE_DSS_WITH_AES_256_CBC_SHA256 = 106;

		// Token: 0x040003DA RID: 986
		public const int TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 107;

		// Token: 0x040003DB RID: 987
		public const int TLS_DH_anon_WITH_AES_128_CBC_SHA256 = 108;

		// Token: 0x040003DC RID: 988
		public const int TLS_DH_anon_WITH_AES_256_CBC_SHA256 = 109;

		// Token: 0x040003DD RID: 989
		public const int TLS_RSA_WITH_AES_128_GCM_SHA256 = 156;

		// Token: 0x040003DE RID: 990
		public const int TLS_RSA_WITH_AES_256_GCM_SHA384 = 157;

		// Token: 0x040003DF RID: 991
		public const int TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 158;

		// Token: 0x040003E0 RID: 992
		public const int TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 159;

		// Token: 0x040003E1 RID: 993
		public const int TLS_DH_RSA_WITH_AES_128_GCM_SHA256 = 160;

		// Token: 0x040003E2 RID: 994
		public const int TLS_DH_RSA_WITH_AES_256_GCM_SHA384 = 161;

		// Token: 0x040003E3 RID: 995
		public const int TLS_DHE_DSS_WITH_AES_128_GCM_SHA256 = 162;

		// Token: 0x040003E4 RID: 996
		public const int TLS_DHE_DSS_WITH_AES_256_GCM_SHA384 = 163;

		// Token: 0x040003E5 RID: 997
		public const int TLS_DH_DSS_WITH_AES_128_GCM_SHA256 = 164;

		// Token: 0x040003E6 RID: 998
		public const int TLS_DH_DSS_WITH_AES_256_GCM_SHA384 = 165;

		// Token: 0x040003E7 RID: 999
		public const int TLS_DH_anon_WITH_AES_128_GCM_SHA256 = 166;

		// Token: 0x040003E8 RID: 1000
		public const int TLS_DH_anon_WITH_AES_256_GCM_SHA384 = 167;

		// Token: 0x040003E9 RID: 1001
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 49187;

		// Token: 0x040003EA RID: 1002
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 49188;

		// Token: 0x040003EB RID: 1003
		public const int TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 49189;

		// Token: 0x040003EC RID: 1004
		public const int TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 49190;

		// Token: 0x040003ED RID: 1005
		public const int TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 49191;

		// Token: 0x040003EE RID: 1006
		public const int TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 49192;

		// Token: 0x040003EF RID: 1007
		public const int TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 49193;

		// Token: 0x040003F0 RID: 1008
		public const int TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 49194;

		// Token: 0x040003F1 RID: 1009
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 49195;

		// Token: 0x040003F2 RID: 1010
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 49196;

		// Token: 0x040003F3 RID: 1011
		public const int TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 49197;

		// Token: 0x040003F4 RID: 1012
		public const int TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 49198;

		// Token: 0x040003F5 RID: 1013
		public const int TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 49199;

		// Token: 0x040003F6 RID: 1014
		public const int TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 49200;

		// Token: 0x040003F7 RID: 1015
		public const int TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 49201;

		// Token: 0x040003F8 RID: 1016
		public const int TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 49202;

		// Token: 0x040003F9 RID: 1017
		public const int TLS_PSK_WITH_AES_128_GCM_SHA256 = 168;

		// Token: 0x040003FA RID: 1018
		public const int TLS_PSK_WITH_AES_256_GCM_SHA384 = 169;

		// Token: 0x040003FB RID: 1019
		public const int TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 170;

		// Token: 0x040003FC RID: 1020
		public const int TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 171;

		// Token: 0x040003FD RID: 1021
		public const int TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 172;

		// Token: 0x040003FE RID: 1022
		public const int TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 173;

		// Token: 0x040003FF RID: 1023
		public const int TLS_PSK_WITH_AES_128_CBC_SHA256 = 174;

		// Token: 0x04000400 RID: 1024
		public const int TLS_PSK_WITH_AES_256_CBC_SHA384 = 175;

		// Token: 0x04000401 RID: 1025
		public const int TLS_PSK_WITH_NULL_SHA256 = 176;

		// Token: 0x04000402 RID: 1026
		public const int TLS_PSK_WITH_NULL_SHA384 = 177;

		// Token: 0x04000403 RID: 1027
		public const int TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 178;

		// Token: 0x04000404 RID: 1028
		public const int TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 179;

		// Token: 0x04000405 RID: 1029
		public const int TLS_DHE_PSK_WITH_NULL_SHA256 = 180;

		// Token: 0x04000406 RID: 1030
		public const int TLS_DHE_PSK_WITH_NULL_SHA384 = 181;

		// Token: 0x04000407 RID: 1031
		public const int TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 182;

		// Token: 0x04000408 RID: 1032
		public const int TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 183;

		// Token: 0x04000409 RID: 1033
		public const int TLS_RSA_PSK_WITH_NULL_SHA256 = 184;

		// Token: 0x0400040A RID: 1034
		public const int TLS_RSA_PSK_WITH_NULL_SHA384 = 185;

		// Token: 0x0400040B RID: 1035
		public const int TLS_ECDHE_PSK_WITH_RC4_128_SHA = 49203;

		// Token: 0x0400040C RID: 1036
		public const int TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 49204;

		// Token: 0x0400040D RID: 1037
		public const int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 49205;

		// Token: 0x0400040E RID: 1038
		public const int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 49206;

		// Token: 0x0400040F RID: 1039
		public const int TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 49207;

		// Token: 0x04000410 RID: 1040
		public const int TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 49208;

		// Token: 0x04000411 RID: 1041
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA = 49209;

		// Token: 0x04000412 RID: 1042
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA256 = 49210;

		// Token: 0x04000413 RID: 1043
		public const int TLS_ECDHE_PSK_WITH_NULL_SHA384 = 49211;

		// Token: 0x04000414 RID: 1044
		public const int TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 255;

		// Token: 0x04000415 RID: 1045
		public const int TLS_RSA_WITH_ARIA_128_CBC_SHA256 = 49212;

		// Token: 0x04000416 RID: 1046
		public const int TLS_RSA_WITH_ARIA_256_CBC_SHA384 = 49213;

		// Token: 0x04000417 RID: 1047
		public const int TLS_DH_DSS_WITH_ARIA_128_CBC_SHA256 = 49214;

		// Token: 0x04000418 RID: 1048
		public const int TLS_DH_DSS_WITH_ARIA_256_CBC_SHA384 = 49215;

		// Token: 0x04000419 RID: 1049
		public const int TLS_DH_RSA_WITH_ARIA_128_CBC_SHA256 = 49216;

		// Token: 0x0400041A RID: 1050
		public const int TLS_DH_RSA_WITH_ARIA_256_CBC_SHA384 = 49217;

		// Token: 0x0400041B RID: 1051
		public const int TLS_DHE_DSS_WITH_ARIA_128_CBC_SHA256 = 49218;

		// Token: 0x0400041C RID: 1052
		public const int TLS_DHE_DSS_WITH_ARIA_256_CBC_SHA384 = 49219;

		// Token: 0x0400041D RID: 1053
		public const int TLS_DHE_RSA_WITH_ARIA_128_CBC_SHA256 = 49220;

		// Token: 0x0400041E RID: 1054
		public const int TLS_DHE_RSA_WITH_ARIA_256_CBC_SHA384 = 49221;

		// Token: 0x0400041F RID: 1055
		public const int TLS_DH_anon_WITH_ARIA_128_CBC_SHA256 = 49222;

		// Token: 0x04000420 RID: 1056
		public const int TLS_DH_anon_WITH_ARIA_256_CBC_SHA384 = 49223;

		// Token: 0x04000421 RID: 1057
		public const int TLS_ECDHE_ECDSA_WITH_ARIA_128_CBC_SHA256 = 49224;

		// Token: 0x04000422 RID: 1058
		public const int TLS_ECDHE_ECDSA_WITH_ARIA_256_CBC_SHA384 = 49225;

		// Token: 0x04000423 RID: 1059
		public const int TLS_ECDH_ECDSA_WITH_ARIA_128_CBC_SHA256 = 49226;

		// Token: 0x04000424 RID: 1060
		public const int TLS_ECDH_ECDSA_WITH_ARIA_256_CBC_SHA384 = 49227;

		// Token: 0x04000425 RID: 1061
		public const int TLS_ECDHE_RSA_WITH_ARIA_128_CBC_SHA256 = 49228;

		// Token: 0x04000426 RID: 1062
		public const int TLS_ECDHE_RSA_WITH_ARIA_256_CBC_SHA384 = 49229;

		// Token: 0x04000427 RID: 1063
		public const int TLS_ECDH_RSA_WITH_ARIA_128_CBC_SHA256 = 49230;

		// Token: 0x04000428 RID: 1064
		public const int TLS_ECDH_RSA_WITH_ARIA_256_CBC_SHA384 = 49231;

		// Token: 0x04000429 RID: 1065
		public const int TLS_RSA_WITH_ARIA_128_GCM_SHA256 = 49232;

		// Token: 0x0400042A RID: 1066
		public const int TLS_RSA_WITH_ARIA_256_GCM_SHA384 = 49233;

		// Token: 0x0400042B RID: 1067
		public const int TLS_DHE_RSA_WITH_ARIA_128_GCM_SHA256 = 49234;

		// Token: 0x0400042C RID: 1068
		public const int TLS_DHE_RSA_WITH_ARIA_256_GCM_SHA384 = 49235;

		// Token: 0x0400042D RID: 1069
		public const int TLS_DH_RSA_WITH_ARIA_128_GCM_SHA256 = 49236;

		// Token: 0x0400042E RID: 1070
		public const int TLS_DH_RSA_WITH_ARIA_256_GCM_SHA384 = 49237;

		// Token: 0x0400042F RID: 1071
		public const int TLS_DHE_DSS_WITH_ARIA_128_GCM_SHA256 = 49238;

		// Token: 0x04000430 RID: 1072
		public const int TLS_DHE_DSS_WITH_ARIA_256_GCM_SHA384 = 49239;

		// Token: 0x04000431 RID: 1073
		public const int TLS_DH_DSS_WITH_ARIA_128_GCM_SHA256 = 49240;

		// Token: 0x04000432 RID: 1074
		public const int TLS_DH_DSS_WITH_ARIA_256_GCM_SHA384 = 49241;

		// Token: 0x04000433 RID: 1075
		public const int TLS_DH_anon_WITH_ARIA_128_GCM_SHA256 = 49242;

		// Token: 0x04000434 RID: 1076
		public const int TLS_DH_anon_WITH_ARIA_256_GCM_SHA384 = 49243;

		// Token: 0x04000435 RID: 1077
		public const int TLS_ECDHE_ECDSA_WITH_ARIA_128_GCM_SHA256 = 49244;

		// Token: 0x04000436 RID: 1078
		public const int TLS_ECDHE_ECDSA_WITH_ARIA_256_GCM_SHA384 = 49245;

		// Token: 0x04000437 RID: 1079
		public const int TLS_ECDH_ECDSA_WITH_ARIA_128_GCM_SHA256 = 49246;

		// Token: 0x04000438 RID: 1080
		public const int TLS_ECDH_ECDSA_WITH_ARIA_256_GCM_SHA384 = 49247;

		// Token: 0x04000439 RID: 1081
		public const int TLS_ECDHE_RSA_WITH_ARIA_128_GCM_SHA256 = 49248;

		// Token: 0x0400043A RID: 1082
		public const int TLS_ECDHE_RSA_WITH_ARIA_256_GCM_SHA384 = 49249;

		// Token: 0x0400043B RID: 1083
		public const int TLS_ECDH_RSA_WITH_ARIA_128_GCM_SHA256 = 49250;

		// Token: 0x0400043C RID: 1084
		public const int TLS_ECDH_RSA_WITH_ARIA_256_GCM_SHA384 = 49251;

		// Token: 0x0400043D RID: 1085
		public const int TLS_PSK_WITH_ARIA_128_CBC_SHA256 = 49252;

		// Token: 0x0400043E RID: 1086
		public const int TLS_PSK_WITH_ARIA_256_CBC_SHA384 = 49253;

		// Token: 0x0400043F RID: 1087
		public const int TLS_DHE_PSK_WITH_ARIA_128_CBC_SHA256 = 49254;

		// Token: 0x04000440 RID: 1088
		public const int TLS_DHE_PSK_WITH_ARIA_256_CBC_SHA384 = 49255;

		// Token: 0x04000441 RID: 1089
		public const int TLS_RSA_PSK_WITH_ARIA_128_CBC_SHA256 = 49256;

		// Token: 0x04000442 RID: 1090
		public const int TLS_RSA_PSK_WITH_ARIA_256_CBC_SHA384 = 49257;

		// Token: 0x04000443 RID: 1091
		public const int TLS_PSK_WITH_ARIA_128_GCM_SHA256 = 49258;

		// Token: 0x04000444 RID: 1092
		public const int TLS_PSK_WITH_ARIA_256_GCM_SHA384 = 49259;

		// Token: 0x04000445 RID: 1093
		public const int TLS_DHE_PSK_WITH_ARIA_128_GCM_SHA256 = 49260;

		// Token: 0x04000446 RID: 1094
		public const int TLS_DHE_PSK_WITH_ARIA_256_GCM_SHA384 = 49261;

		// Token: 0x04000447 RID: 1095
		public const int TLS_RSA_PSK_WITH_ARIA_128_GCM_SHA256 = 49262;

		// Token: 0x04000448 RID: 1096
		public const int TLS_RSA_PSK_WITH_ARIA_256_GCM_SHA384 = 49263;

		// Token: 0x04000449 RID: 1097
		public const int TLS_ECDHE_PSK_WITH_ARIA_128_CBC_SHA256 = 49264;

		// Token: 0x0400044A RID: 1098
		public const int TLS_ECDHE_PSK_WITH_ARIA_256_CBC_SHA384 = 49265;

		// Token: 0x0400044B RID: 1099
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49266;

		// Token: 0x0400044C RID: 1100
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49267;

		// Token: 0x0400044D RID: 1101
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 49268;

		// Token: 0x0400044E RID: 1102
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 49269;

		// Token: 0x0400044F RID: 1103
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49270;

		// Token: 0x04000450 RID: 1104
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49271;

		// Token: 0x04000451 RID: 1105
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 49272;

		// Token: 0x04000452 RID: 1106
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 49273;

		// Token: 0x04000453 RID: 1107
		public const int TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49274;

		// Token: 0x04000454 RID: 1108
		public const int TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49275;

		// Token: 0x04000455 RID: 1109
		public const int TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49276;

		// Token: 0x04000456 RID: 1110
		public const int TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49277;

		// Token: 0x04000457 RID: 1111
		public const int TLS_DH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49278;

		// Token: 0x04000458 RID: 1112
		public const int TLS_DH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49279;

		// Token: 0x04000459 RID: 1113
		public const int TLS_DHE_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49280;

		// Token: 0x0400045A RID: 1114
		public const int TLS_DHE_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49281;

		// Token: 0x0400045B RID: 1115
		public const int TLS_DH_DSS_WITH_CAMELLIA_128_GCM_SHA256 = 49282;

		// Token: 0x0400045C RID: 1116
		public const int TLS_DH_DSS_WITH_CAMELLIA_256_GCM_SHA384 = 49283;

		// Token: 0x0400045D RID: 1117
		public const int TLS_DH_anon_WITH_CAMELLIA_128_GCM_SHA256 = 49284;

		// Token: 0x0400045E RID: 1118
		public const int TLS_DH_anon_WITH_CAMELLIA_256_GCM_SHA384 = 49285;

		// Token: 0x0400045F RID: 1119
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49286;

		// Token: 0x04000460 RID: 1120
		public const int TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49287;

		// Token: 0x04000461 RID: 1121
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 49288;

		// Token: 0x04000462 RID: 1122
		public const int TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 49289;

		// Token: 0x04000463 RID: 1123
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49290;

		// Token: 0x04000464 RID: 1124
		public const int TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49291;

		// Token: 0x04000465 RID: 1125
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 49292;

		// Token: 0x04000466 RID: 1126
		public const int TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 49293;

		// Token: 0x04000467 RID: 1127
		public const int TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49294;

		// Token: 0x04000468 RID: 1128
		public const int TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49295;

		// Token: 0x04000469 RID: 1129
		public const int TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49296;

		// Token: 0x0400046A RID: 1130
		public const int TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49297;

		// Token: 0x0400046B RID: 1131
		public const int TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 49298;

		// Token: 0x0400046C RID: 1132
		public const int TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 49299;

		// Token: 0x0400046D RID: 1133
		public const int TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49300;

		// Token: 0x0400046E RID: 1134
		public const int TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49301;

		// Token: 0x0400046F RID: 1135
		public const int TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49302;

		// Token: 0x04000470 RID: 1136
		public const int TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49303;

		// Token: 0x04000471 RID: 1137
		public const int TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49304;

		// Token: 0x04000472 RID: 1138
		public const int TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49305;

		// Token: 0x04000473 RID: 1139
		public const int TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 49306;

		// Token: 0x04000474 RID: 1140
		public const int TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 49307;

		// Token: 0x04000475 RID: 1141
		public const int TLS_RSA_WITH_AES_128_CCM = 49308;

		// Token: 0x04000476 RID: 1142
		public const int TLS_RSA_WITH_AES_256_CCM = 49309;

		// Token: 0x04000477 RID: 1143
		public const int TLS_DHE_RSA_WITH_AES_128_CCM = 49310;

		// Token: 0x04000478 RID: 1144
		public const int TLS_DHE_RSA_WITH_AES_256_CCM = 49311;

		// Token: 0x04000479 RID: 1145
		public const int TLS_RSA_WITH_AES_128_CCM_8 = 49312;

		// Token: 0x0400047A RID: 1146
		public const int TLS_RSA_WITH_AES_256_CCM_8 = 49313;

		// Token: 0x0400047B RID: 1147
		public const int TLS_DHE_RSA_WITH_AES_128_CCM_8 = 49314;

		// Token: 0x0400047C RID: 1148
		public const int TLS_DHE_RSA_WITH_AES_256_CCM_8 = 49315;

		// Token: 0x0400047D RID: 1149
		public const int TLS_PSK_WITH_AES_128_CCM = 49316;

		// Token: 0x0400047E RID: 1150
		public const int TLS_PSK_WITH_AES_256_CCM = 49317;

		// Token: 0x0400047F RID: 1151
		public const int TLS_DHE_PSK_WITH_AES_128_CCM = 49318;

		// Token: 0x04000480 RID: 1152
		public const int TLS_DHE_PSK_WITH_AES_256_CCM = 49319;

		// Token: 0x04000481 RID: 1153
		public const int TLS_PSK_WITH_AES_128_CCM_8 = 49320;

		// Token: 0x04000482 RID: 1154
		public const int TLS_PSK_WITH_AES_256_CCM_8 = 49321;

		// Token: 0x04000483 RID: 1155
		public const int TLS_PSK_DHE_WITH_AES_128_CCM_8 = 49322;

		// Token: 0x04000484 RID: 1156
		public const int TLS_PSK_DHE_WITH_AES_256_CCM_8 = 49323;

		// Token: 0x04000485 RID: 1157
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CCM = 49324;

		// Token: 0x04000486 RID: 1158
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CCM = 49325;

		// Token: 0x04000487 RID: 1159
		public const int TLS_ECDHE_ECDSA_WITH_AES_128_CCM_8 = 49326;

		// Token: 0x04000488 RID: 1160
		public const int TLS_ECDHE_ECDSA_WITH_AES_256_CCM_8 = 49327;

		// Token: 0x04000489 RID: 1161
		public const int TLS_FALLBACK_SCSV = 22016;

		// Token: 0x0400048A RID: 1162
		public const int TLS_ECDHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52392;

		// Token: 0x0400048B RID: 1163
		public const int TLS_ECDHE_ECDSA_WITH_CHACHA20_POLY1305_SHA256 = 52393;

		// Token: 0x0400048C RID: 1164
		public const int TLS_DHE_RSA_WITH_CHACHA20_POLY1305_SHA256 = 52394;

		// Token: 0x0400048D RID: 1165
		public const int TLS_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52395;

		// Token: 0x0400048E RID: 1166
		public const int TLS_ECDHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52396;

		// Token: 0x0400048F RID: 1167
		public const int TLS_DHE_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52397;

		// Token: 0x04000490 RID: 1168
		public const int TLS_RSA_PSK_WITH_CHACHA20_POLY1305_SHA256 = 52398;

		// Token: 0x04000491 RID: 1169
		public const int TLS_ECDHE_PSK_WITH_AES_128_GCM_SHA256 = 53249;

		// Token: 0x04000492 RID: 1170
		public const int TLS_ECDHE_PSK_WITH_AES_256_GCM_SHA384 = 53250;

		// Token: 0x04000493 RID: 1171
		public const int TLS_ECDHE_PSK_WITH_AES_128_CCM_8_SHA256 = 53251;

		// Token: 0x04000494 RID: 1172
		public const int TLS_ECDHE_PSK_WITH_AES_128_CCM_SHA256 = 53253;

		// Token: 0x04000495 RID: 1173
		public const int TLS_AES_128_GCM_SHA256 = 4865;

		// Token: 0x04000496 RID: 1174
		public const int TLS_AES_256_GCM_SHA384 = 4866;

		// Token: 0x04000497 RID: 1175
		public const int TLS_CHACHA20_POLY1305_SHA256 = 4867;

		// Token: 0x04000498 RID: 1176
		public const int TLS_AES_128_CCM_SHA256 = 4868;

		// Token: 0x04000499 RID: 1177
		public const int TLS_AES_128_CCM_8_SHA256 = 4869;

		// Token: 0x0400049A RID: 1178
		public const int TLS_SM4_GCM_SM3 = 198;

		// Token: 0x0400049B RID: 1179
		public const int TLS_SM4_CCM_SM3 = 199;

		// Token: 0x0400049C RID: 1180
		public const int TLS_GOSTR341112_256_WITH_KUZNYECHIK_CTR_OMAC = 49408;

		// Token: 0x0400049D RID: 1181
		public const int TLS_GOSTR341112_256_WITH_MAGMA_CTR_OMAC = 49409;

		// Token: 0x0400049E RID: 1182
		public const int TLS_GOSTR341112_256_WITH_28147_CNT_IMIT = 49410;
	}
}
