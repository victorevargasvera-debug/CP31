using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200006D RID: 109
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBCodeplug : global::Motorola.CommonCPS.Server.EntityModel.Codeplug, global::Motorola.CommonCPS.Server.EntityModel.IPBBCodeplug
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x0005B258 File Offset: 0x00059458
		public PBBCodeplug()
		{
			this.IsForceWriteHomeSet = new bool?(false);
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0005B278 File Offset: 0x00059478
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x0005B328 File Offset: 0x00059528
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? PBBFirmwareUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)921974929;
				short num2 = num;
				num = (short)1063729297;
				switch (num2 == num)
				{
				}
				num = (short)1665335296;
				if (num != 0)
				{
				}
				num = (short)1042153473;
				if (num != 0)
				{
				}
				num = (short)61014016;
				short num3 = num;
				return this.<PBBFirmwareUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)645348754;
				short num2 = num;
				num = (short)1521171858;
				switch (num2 == num)
				{
				}
				num = (short)458162177;
				if (num != 0)
				{
				}
				num = (short)1286340608;
				if (num != 0)
				{
				}
				num = (short)660865024;
				short num3 = num;
				this.<PBBFirmwareUuid>k__BackingField = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0005B3D8 File Offset: 0x000595D8
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x0005B484 File Offset: 0x00059684
		[global::System.Runtime.Serialization.DataMember]
		public string ProvisioningPackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2112929076;
				short num2 = num;
				num = (short)424983860;
				switch (num2 == num)
				{
				}
				num = (short)173015041;
				if (num != 0)
				{
				}
				num = (short)1183711232;
				if (num != 0)
				{
				}
				num = (short)205586432;
				short num3 = num;
				return this.<ProvisioningPackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1866055143;
				short num2 = num;
				num = (short)79412711;
				switch (num2 == num)
				{
				}
				num = (short)199098368;
				if (num != 0)
				{
				}
				num = (short)1350762497;
				if (num != 0)
				{
				}
				num = (short)927006720;
				short num3 = num;
				this.<ProvisioningPackageName>k__BackingField = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0005B534 File Offset: 0x00059734
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x0005B5E4 File Offset: 0x000597E4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? PBBProvisioningUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)907989398;
				short num2 = num;
				num = (short)1733808534;
				switch (num2 == num)
				{
				}
				num = (short)2119237632;
				if (num != 0)
				{
				}
				num = (short)371654657;
				if (num != 0)
				{
				}
				num = (short)1460731904;
				short num3 = num;
				return this.<PBBProvisioningUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2144101380;
				short num2 = num;
				num = (short)1657955332;
				switch (num2 == num)
				{
				}
				num = (short)364642305;
				if (num != 0)
				{
				}
				num = (short)708640768;
				if (num != 0)
				{
				}
				num = (short)680329216;
				short num3 = num;
				this.<PBBProvisioningUuid>k__BackingField = value;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0005B690 File Offset: 0x00059890
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0005B740 File Offset: 0x00059940
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? PBBHomeSetUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)9568257;
				if (num != 0)
				{
				}
				num = (short)1279628813;
				short num2 = num;
				num = (short)1542362637;
				switch (num2 == num)
				{
				}
				num = (short)888668160;
				if (num != 0)
				{
				}
				num = (short)2128412672;
				short num3 = num;
				return this.<PBBHomeSetUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)938953354;
				short num2 = num;
				num = (short)1697794698;
				switch (num2 == num)
				{
				}
				num = (short)1110245377;
				if (num != 0)
				{
				}
				num = (short)1378811904;
				if (num != 0)
				{
				}
				num = (short)1476132864;
				short num3 = num;
				this.<PBBHomeSetUuid>k__BackingField = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0005B7F0 File Offset: 0x000599F0
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x0005B8A0 File Offset: 0x00059AA0
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsStaged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)471531521;
				if (num != 0)
				{
				}
				num = (short)2001517758;
				short num2 = num;
				num = (short)107527358;
				switch (num2 == num)
				{
				}
				num = (short)734199808;
				if (num != 0)
				{
				}
				num = (short)1609826304;
				short num3 = num;
				return this.<IsStaged>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)241596505;
				short num2 = num;
				num = (short)1855420505;
				switch (num2 == num)
				{
				}
				num = (short)1702625280;
				if (num != 0)
				{
				}
				num = (short)1100283905;
				if (num != 0)
				{
				}
				num = (short)1232338944;
				short num3 = num;
				this.<IsStaged>k__BackingField = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0005B954 File Offset: 0x00059B54
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x0005BA04 File Offset: 0x00059C04
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsFactoryReset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)469539990;
				short num2 = num;
				num = (short)190356630;
				switch (num2 == num)
				{
				}
				num = (short)637272065;
				if (num != 0)
				{
				}
				num = (short)423493632;
				if (num != 0)
				{
				}
				num = (short)54722560;
				short num3 = num;
				return this.<IsFactoryReset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1269817547;
				short num2 = num;
				num = (short)1837293771;
				switch (num2 == num)
				{
				}
				num = (short)1903624193;
				if (num != 0)
				{
				}
				num = (short)538640384;
				if (num != 0)
				{
				}
				num = (short)265945088;
				short num3 = num;
				this.<IsFactoryReset>k__BackingField = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0005BAB4 File Offset: 0x00059CB4
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x0005BB64 File Offset: 0x00059D64
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsForceWriteHomeSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)367442311;
				short num2 = num;
				num = (short)17611143;
				switch (num2 == num)
				{
				}
				num = (short)1693188097;
				if (num != 0)
				{
				}
				num = (short)1377173504;
				if (num != 0)
				{
				}
				num = (short)2012938240;
				short num3 = num;
				return this.<IsForceWriteHomeSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)165509096;
				short num2 = num;
				num = (short)1628534760;
				switch (num2 == num)
				{
				}
				num = (short)1719599104;
				if (num != 0)
				{
				}
				num = (short)1016463361;
				if (num != 0)
				{
				}
				num = (short)291241984;
				short num3 = num;
				this.<IsForceWriteHomeSet>k__BackingField = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0005BC14 File Offset: 0x00059E14
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x0005BCC4 File Offset: 0x00059EC4
		[global::System.Runtime.Serialization.DataMember]
		public string AppCFS
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)861187662;
				short num2 = num;
				num = (short)1009364558;
				switch (num2 == num)
				{
				}
				num = (short)172818433;
				if (num != 0)
				{
				}
				num = (short)609222656;
				if (num != 0)
				{
				}
				num = (short)2084569088;
				short num3 = num;
				return this.<AppCFS>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1044390462;
				short num2 = num;
				num = (short)621224510;
				switch (num2 == num)
				{
				}
				num = (short)1589837824;
				if (num != 0)
				{
				}
				num = (short)1223491585;
				if (num != 0)
				{
				}
				num = (short)623116288;
				short num3 = num;
				this.<AppCFS>k__BackingField = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0005BD74 File Offset: 0x00059F74
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0005BE28 File Offset: 0x0005A028
		[global::System.Runtime.Serialization.DataMember]
		public string AppCFSEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1709178881;
				if (num != 0)
				{
				}
				num = (short)88302202;
				short num2 = num;
				num = (short)1511023226;
				switch (num2 == num)
				{
				}
				num = (short)390922240;
				if (num != 0)
				{
				}
				num = (short)1082589184;
				short num3 = num;
				return this.<AppCFSEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1771284644;
				short num2 = num;
				num = (short)839755940;
				switch (num2 == num)
				{
				}
				num = (short)1990328321;
				if (num != 0)
				{
				}
				num = (short)1358299136;
				if (num != 0)
				{
				}
				num = (short)1809580032;
				short num3 = num;
				this.<AppCFSEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0005BED8 File Offset: 0x0005A0D8
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x0005BF88 File Offset: 0x0005A188
		[global::System.Runtime.Serialization.DataMember]
		public string PBBFirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1293873329;
				short num2 = num;
				num = (short)421261489;
				switch (num2 == num)
				{
				}
				num = (short)795213824;
				if (num != 0)
				{
				}
				num = (short)2055405569;
				if (num != 0)
				{
				}
				num = (short)1774321664;
				short num3 = num;
				return this.<PBBFirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1916806928;
				short num2 = num;
				num = (short)1217865488;
				switch (num2 == num)
				{
				}
				num = (short)1192624129;
				if (num != 0)
				{
				}
				num = (short)2005729280;
				if (num != 0)
				{
				}
				num = (short)1482293248;
				short num3 = num;
				this.<PBBFirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0005C03C File Offset: 0x0005A23C
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x0005C0EC File Offset: 0x0005A2EC
		[global::System.Runtime.Serialization.DataMember]
		public byte[] UEFileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)812593620;
				short num2 = num;
				num = (short)1868575188;
				switch (num2 == num)
				{
				}
				num = (short)585498625;
				if (num != 0)
				{
				}
				num = (short)1603731456;
				if (num != 0)
				{
				}
				num = (short)1576599552;
				short num3 = num;
				return this.<UEFileContent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)949948601;
				short num2 = num;
				num = (short)359993529;
				switch (num2 == num)
				{
				}
				num = (short)1106837504;
				if (num != 0)
				{
				}
				num = (short)1087700993;
				if (num != 0)
				{
				}
				num = (short)597950464;
				short num3 = num;
				this.<UEFileContent>k__BackingField = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0005C19C File Offset: 0x0005A39C
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x0005C24C File Offset: 0x0005A44C
		[global::System.Runtime.Serialization.DataMember]
		public string RetrievedLogFileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)768014341;
				short num2 = num;
				num = (short)708311045;
				switch (num2 == num)
				{
				}
				num = (short)2082668544;
				if (num != 0)
				{
				}
				num = (short)1476591617;
				if (num != 0)
				{
				}
				num = (short)1288372224;
				short num3 = num;
				return this.<RetrievedLogFileName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1374748673;
				if (num != 0)
				{
				}
				num = (short)1203251778;
				short num2 = num;
				num = (short)1391864386;
				switch (num2 == num)
				{
				}
				num = (short)636026880;
				if (num != 0)
				{
				}
				num = (short)1577779200;
				short num3 = num;
				this.<RetrievedLogFileName>k__BackingField = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0005C2FC File Offset: 0x0005A4FC
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x0005C3AC File Offset: 0x0005A5AC
		[global::System.Runtime.Serialization.DataMember]
		public bool IsUserCertUninstallAll
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)765263873;
				if (num != 0)
				{
				}
				num = (short)1086775538;
				short num2 = num;
				num = (short)1026482418;
				switch (num2 == num)
				{
				}
				num = (short)1135804416;
				if (num != 0)
				{
				}
				num = (short)1858207744;
				short num3 = num;
				return this.<IsUserCertUninstallAll>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2116419585;
				if (num != 0)
				{
				}
				num = (short)1793182535;
				short num2 = num;
				num = (short)956418887;
				switch (num2 == num)
				{
				}
				num = (short)802095104;
				if (num != 0)
				{
				}
				num = (short)137363456;
				short num3 = num;
				this.<IsUserCertUninstallAll>k__BackingField = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0005C458 File Offset: 0x0005A658
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x0005C508 File Offset: 0x0005A708
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSysCertEnableAll
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1073003788;
				short num2 = num;
				num = (short)1892072716;
				switch (num2 == num)
				{
				}
				num = (short)831651841;
				if (num != 0)
				{
				}
				num = (short)535756800;
				if (num != 0)
				{
				}
				num = (short)1388904448;
				short num3 = num;
				return this.<IsSysCertEnableAll>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)484591651;
				short num2 = num;
				num = (short)1845512227;
				switch (num2 == num)
				{
				}
				num = (short)599261184;
				if (num != 0)
				{
				}
				num = (short)860356609;
				if (num != 0)
				{
				}
				num = (short)1379926016;
				short num3 = num;
				this.<IsSysCertEnableAll>k__BackingField = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0005C5B8 File Offset: 0x0005A7B8
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x0005C668 File Offset: 0x0005A868
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSysCertDisableAll
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)987013519;
				short num2 = num;
				num = (short)556704143;
				switch (num2 == num)
				{
				}
				num = (short)360251392;
				if (num != 0)
				{
				}
				num = (short)63504385;
				if (num != 0)
				{
				}
				num = (short)256049152;
				short num3 = num;
				return this.<IsSysCertDisableAll>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1124105719;
				short num2 = num;
				num = (short)1018854903;
				switch (num2 == num)
				{
				}
				num = (short)261619713;
				if (num != 0)
				{
				}
				num = (short)1141637120;
				if (num != 0)
				{
				}
				num = (short)1443102720;
				short num3 = num;
				this.<IsSysCertDisableAll>k__BackingField = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0005C718 File Offset: 0x0005A918
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x0005C7C8 File Offset: 0x0005A9C8
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PBBFirmware PBBFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1306701142;
				short num2 = num;
				num = (short)1352248662;
				switch (num2 == num)
				{
				}
				num = (short)309395457;
				if (num != 0)
				{
				}
				num = (short)441712640;
				if (num != 0)
				{
				}
				num = (short)42729472;
				short num3 = num;
				return this.<PBBFirmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1731587550;
				short num2 = num;
				num = (short)886894046;
				switch (num2 == num)
				{
				}
				num = (short)787087361;
				if (num != 0)
				{
				}
				num = (short)2076311552;
				if (num != 0)
				{
				}
				num = (short)1072168960;
				short num3 = num;
				this.<PBBFirmware>k__BackingField = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x0005C878 File Offset: 0x0005AA78
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x0005C928 File Offset: 0x0005AB28
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PBBProvisioning PBBProvisioning
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)198617576;
				short num2 = num;
				num = (short)1891150312;
				switch (num2 == num)
				{
				}
				num = (short)126812161;
				if (num != 0)
				{
				}
				num = (short)1851260928;
				if (num != 0)
				{
				}
				num = (short)1967783936;
				short num3 = num;
				return this.<PBBProvisioning>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1699359089;
				short num2 = num;
				num = (short)1202334065;
				switch (num2 == num)
				{
				}
				num = (short)1315897345;
				if (num != 0)
				{
				}
				num = (short)2058878976;
				if (num != 0)
				{
				}
				num = (short)2102460416;
				short num3 = num;
				this.<PBBProvisioning>k__BackingField = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0005C9DC File Offset: 0x0005ABDC
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x0005CA8C File Offset: 0x0005AC8C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PBBHomeSet PBBHomeSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)26804539;
				short num2 = num;
				num = (short)1793589563;
				switch (num2 == num)
				{
				}
				num = (short)786432000;
				if (num != 0)
				{
				}
				num = (short)889520129;
				if (num != 0)
				{
				}
				num = (short)1434779648;
				short num3 = num;
				return this.<PBBHomeSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1734374753;
				short num2 = num;
				num = (short)355824993;
				switch (num2 == num)
				{
				}
				num = (short)1642332161;
				if (num != 0)
				{
				}
				num = (short)1224671232;
				if (num != 0)
				{
				}
				num = (short)1059323904;
				short num3 = num;
				this.<PBBHomeSet>k__BackingField = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0005CB40 File Offset: 0x0005AD40
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x0005CBF0 File Offset: 0x0005ADF0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBApplication> PBBApplications
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1861398572;
				short num2 = num;
				num = (short)1183821868;
				switch (num2 == num)
				{
				}
				num = (short)1639907329;
				if (num != 0)
				{
				}
				num = (short)2080899072;
				if (num != 0)
				{
				}
				num = (short)1797062656;
				short num3 = num;
				return this.<PBBApplications>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)264940469;
				short num2 = num;
				num = (short)972598197;
				switch (num2 == num)
				{
				}
				num = (short)1212088321;
				if (num != 0)
				{
				}
				num = (short)1881735168;
				if (num != 0)
				{
				}
				num = (short)631242752;
				short num3 = num;
				this.<PBBApplications>k__BackingField = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x0005CCA4 File Offset: 0x0005AEA4
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x0005CD54 File Offset: 0x0005AF54
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBCertificate> PBBCertificates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2010447873;
				if (num != 0)
				{
				}
				num = (short)1443455894;
				short num2 = num;
				num = (short)985949078;
				switch (num2 == num)
				{
				}
				num = (short)597622784;
				if (num != 0)
				{
				}
				num = (short)363724800;
				short num3 = num;
				return this.<PBBCertificates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)229507072;
				short num2 = num;
				num = (short)481081210;
				short num3 = num;
				num = (short)1984804730;
				switch (num3 == num)
				{
				}
				num = (short)612106240;
				if (num != 0)
				{
				}
				num = (short)1202323457;
				if (num != 0)
				{
				}
				this.<PBBCertificates>k__BackingField = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x0005CE04 File Offset: 0x0005B004
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x0005CEB4 File Offset: 0x0005B0B4
		[global::System.Runtime.Serialization.DataMember]
		public string AppSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)89391104;
				short num2 = num;
				num = (short)1207304193;
				if (num != 0)
				{
				}
				num = (short)514655844;
				short num3 = num;
				num = (short)1695155812;
				switch (num3 == num)
				{
				}
				num = (short)471203840;
				if (num != 0)
				{
				}
				return this.<AppSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)561774592;
				short num2 = num;
				num = (short)731774977;
				if (num != 0)
				{
				}
				num = (short)2050846447;
				short num3 = num;
				num = (short)169766639;
				switch (num3 == num)
				{
				}
				num = (short)2110128128;
				if (num != 0)
				{
				}
				this.<AppSetting>k__BackingField = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x0005CF64 File Offset: 0x0005B164
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x0005D018 File Offset: 0x0005B218
		[global::System.Runtime.Serialization.DataMember]
		public string CertificateSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1725169664;
				short num2 = num;
				num = (short)1268069002;
				short num3 = num;
				num = (short)121057930;
				switch (num3 == num)
				{
				}
				num = (short)540672000;
				if (num != 0)
				{
				}
				num = (short)298385409;
				if (num != 0)
				{
				}
				return this.<CertificateSetting>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)453115904;
				short num2 = num;
				num = (short)853481487;
				short num3 = num;
				num = (short)1055594511;
				switch (num3 == num)
				{
				}
				num = (short)161611776;
				if (num != 0)
				{
				}
				num = (short)1010892801;
				if (num != 0)
				{
				}
				this.<CertificateSetting>k__BackingField = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0005D0C8 File Offset: 0x0005B2C8
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x0005D174 File Offset: 0x0005B374
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBApplicationShortcut> PBBApplicationShortcuts
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)89063424;
				short num2 = num;
				num = (short)1587858397;
				short num3 = num;
				num = (short)2066729949;
				switch (num3 == num)
				{
				}
				num = (short)94961665;
				if (num != 0)
				{
				}
				num = (short)63963136;
				if (num != 0)
				{
				}
				return this.<PBBApplicationShortcuts>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1894252544;
				short num2 = num;
				num = (short)1250557953;
				if (num != 0)
				{
				}
				num = (short)650630784;
				short num3 = num;
				num = (short)1148900992;
				switch (num3 == num)
				{
				}
				num = (short)969211904;
				if (num != 0)
				{
				}
				this.<PBBApplicationShortcuts>k__BackingField = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0005D228 File Offset: 0x0005B428
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x0005D2D8 File Offset: 0x0005B4D8
		[global::System.Runtime.Serialization.DataMember]
		public string MCIFProfileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)800456704;
				short num2 = num;
				num = (short)1848435144;
				short num3 = num;
				num = (short)805691848;
				switch (num3 == num)
				{
				}
				num = (short)1506017280;
				if (num != 0)
				{
				}
				num = (short)1316618241;
				if (num != 0)
				{
				}
				return this.<MCIFProfileName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)715325440;
				short num2 = num;
				num = (short)1892646525;
				short num3 = num;
				num = (short)1965981309;
				switch (num3 == num)
				{
				}
				num = (short)597950464;
				if (num != 0)
				{
				}
				num = (short)736886785;
				if (num != 0)
				{
				}
				this.<MCIFProfileName>k__BackingField = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x0005D388 File Offset: 0x0005B588
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x0005D438 File Offset: 0x0005B638
		[global::System.Runtime.Serialization.DataMember]
		public string MCIFVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1379860480;
				short num2 = num;
				num = (short)1138556929;
				if (num != 0)
				{
				}
				num = (short)843589113;
				short num3 = num;
				num = (short)1917330937;
				switch (num3 == num)
				{
				}
				num = (short)1909981184;
				if (num != 0)
				{
				}
				return this.<MCIFVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1041760256;
				short num2 = num;
				num = (short)1670504865;
				short num3 = num;
				num = (short)1652744609;
				switch (num3 == num)
				{
				}
				num = (short)18481153;
				if (num != 0)
				{
				}
				num = (short)412942336;
				if (num != 0)
				{
				}
				this.<MCIFVersion>k__BackingField = value;
			}
		}
	}
}
