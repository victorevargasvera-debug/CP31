using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000045 RID: 69
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class GdgJobRadioStatus
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0001CF98 File Offset: 0x0001B198
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0001D04C File Offset: 0x0001B24C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.GdgJobRadioState RadioJobState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)809697280;
				short num2 = num;
				num = (short)874239245;
				short num3 = num;
				num = (short)1307235597;
				switch (num3 == num)
				{
				}
				num = (short)280231936;
				if (num != 0)
				{
				}
				num = (short)554696705;
				if (num != 0)
				{
				}
				return this.<RadioJobState>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)712966144;
				short num2 = num;
				num = (short)385973233;
				short num3 = num;
				num = (short)1263500273;
				switch (num3 == num)
				{
				}
				num = (short)1797128192;
				if (num != 0)
				{
				}
				num = (short)1668481025;
				if (num != 0)
				{
				}
				this.<RadioJobState>k__BackingField = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001D0FC File Offset: 0x0001B2FC
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0001D1B0 File Offset: 0x0001B3B0
		[global::System.Runtime.Serialization.DataMember]
		public int GdgJobRadioProgress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2082603008;
				short num2 = num;
				num = (short)1784676353;
				if (num != 0)
				{
				}
				num = (short)326323191;
				short num3 = num;
				num = (short)98585591;
				switch (num3 == num)
				{
				}
				num = (short)1159397376;
				if (num != 0)
				{
				}
				return this.<GdgJobRadioProgress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1719140352;
				short num2 = num;
				num = (short)2061709247;
				short num3 = num;
				num = (short)464990143;
				switch (num3 == num)
				{
				}
				num = (short)1530331137;
				if (num != 0)
				{
				}
				num = (short)344064000;
				if (num != 0)
				{
				}
				this.<GdgJobRadioProgress>k__BackingField = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000170 RID: 368 RVA: 0x0001D260 File Offset: 0x0001B460
		// (set) Token: 0x06000171 RID: 369 RVA: 0x0001D310 File Offset: 0x0001B510
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? GdgJobRadioLastUpdateTime
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)506321129;
				short num2 = num;
				num = (short)2058934505;
				switch (num2 == num)
				{
				}
				num = (short)1956118529;
				if (num != 0)
				{
				}
				num = (short)522518528;
				short num3 = num;
				num = (short)1084555264;
				if (num != 0)
				{
				}
				return this.<GdgJobRadioLastUpdateTime>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)285823283;
				short num2 = num;
				num = (short)1711952179;
				switch (num2 == num)
				{
				}
				num = (short)794558464;
				if (num != 0)
				{
				}
				num = (short)808452096;
				short num3 = num;
				num = (short)2079195137;
				if (num != 0)
				{
				}
				this.<GdgJobRadioLastUpdateTime>k__BackingField = value;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0001D3C0 File Offset: 0x0001B5C0
		// (set) Token: 0x06000173 RID: 371 RVA: 0x0001D470 File Offset: 0x0001B670
		[global::System.Runtime.Serialization.DataMember]
		public string ServerJobGuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)327238556;
				short num2 = num;
				num = (short)618742684;
				switch (num2 == num)
				{
				}
				num = (short)977076225;
				if (num != 0)
				{
				}
				num = (short)632225792;
				short num3 = num;
				num = (short)1951465472;
				if (num != 0)
				{
				}
				return this.<ServerJobGuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2024404591;
				short num2 = num;
				num = (short)541390447;
				switch (num2 == num)
				{
				}
				num = (short)1639710721;
				if (num != 0)
				{
				}
				num = (short)1215299584;
				short num3 = num;
				num = (short)1665925120;
				if (num != 0)
				{
				}
				this.<ServerJobGuid>k__BackingField = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0001D520 File Offset: 0x0001B720
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0001D5CC File Offset: 0x0001B7CC
		[global::System.Runtime.Serialization.DataMember]
		public byte[] ServerJobTimeStamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)695205889;
				if (num != 0)
				{
				}
				num = (short)1163643412;
				short num2 = num;
				num = (short)1664731668;
				switch (num2 == num)
				{
				}
				num = (short)1612185600;
				short num3 = num;
				num = (short)928514048;
				if (num != 0)
				{
				}
				return this.<ServerJobTimeStamp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2001089316;
				short num2 = num;
				num = (short)678507300;
				switch (num2 == num)
				{
				}
				num = (short)1330577408;
				if (num != 0)
				{
				}
				num = (short)543948800;
				short num3 = num;
				num = (short)487391233;
				if (num != 0)
				{
				}
				this.<ServerJobTimeStamp>k__BackingField = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000176 RID: 374 RVA: 0x0001D67C File Offset: 0x0001B87C
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0001D72C File Offset: 0x0001B92C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsCodeplugUpdated
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1576402945;
				if (num != 0)
				{
				}
				num = (short)1982070894;
				short num2 = num;
				num = (short)1288372334;
				switch (num2 == num)
				{
				}
				num = (short)353107968;
				short num3 = num;
				num = (short)1730478080;
				if (num != 0)
				{
				}
				return this.<IsCodeplugUpdated>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)618272887;
				short num2 = num;
				num = (short)808261751;
				switch (num2 == num)
				{
				}
				num = (short)231931905;
				if (num != 0)
				{
				}
				num = (short)1916076032;
				short num3 = num;
				num = (short)1302724608;
				if (num != 0)
				{
				}
				this.<IsCodeplugUpdated>k__BackingField = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000178 RID: 376 RVA: 0x0001D7E0 File Offset: 0x0001B9E0
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0001D894 File Offset: 0x0001BA94
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFwdlRestartJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1486684161;
				if (num != 0)
				{
				}
				num = (short)1732594154;
				short num2 = num;
				num = (short)113920490;
				switch (num2 == num)
				{
				}
				num = (short)288882688;
				short num3 = num;
				num = (short)1386151936;
				if (num != 0)
				{
				}
				return this.<IsFwdlRestartJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1882287600;
				short num2 = num;
				num = (short)1225027056;
				switch (num2 == num)
				{
				}
				num = (short)1992818689;
				if (num != 0)
				{
				}
				num = (short)2077687808;
				short num3 = num;
				num = (short)1873543168;
				if (num != 0)
				{
				}
				this.<IsFwdlRestartJob>k__BackingField = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001D944 File Offset: 0x0001BB44
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
		[global::System.Runtime.Serialization.DataMember]
		public bool IsXcmpTalkGroupCompleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)465979927;
				short num2 = num;
				num = (short)73419287;
				switch (num2 == num)
				{
				}
				num = (short)1607401473;
				if (num != 0)
				{
				}
				num = (short)461897728;
				short num3 = num;
				num = (short)1607729152;
				if (num != 0)
				{
				}
				return this.<IsXcmpTalkGroupCompleted>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1318639317;
				short num2 = num;
				num = (short)569956053;
				switch (num2 == num)
				{
				}
				num = (short)631963649;
				if (num != 0)
				{
				}
				num = (short)1093402624;
				short num3 = num;
				num = (short)1929641984;
				if (num != 0)
				{
				}
				this.<IsXcmpTalkGroupCompleted>k__BackingField = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017C RID: 380 RVA: 0x0001DAA4 File Offset: 0x0001BCA4
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0001DB54 File Offset: 0x0001BD54
		[global::System.Runtime.Serialization.DataMember]
		public int FirmwareFlavorType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)678821889;
				if (num != 0)
				{
				}
				num = (short)1218545206;
				short num2 = num;
				num = (short)1911457334;
				switch (num2 == num)
				{
				}
				num = (short)1453981696;
				short num3 = num;
				num = (short)1385562112;
				if (num != 0)
				{
				}
				return this.<FirmwareFlavorType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1712390145;
				if (num != 0)
				{
				}
				num = (short)1981492740;
				short num2 = num;
				num = (short)643575300;
				switch (num2 == num)
				{
				}
				num = (short)1417084928;
				short num3 = num;
				num = (short)1616314368;
				if (num != 0)
				{
				}
				this.<FirmwareFlavorType>k__BackingField = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0001DC04 File Offset: 0x0001BE04
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
		[global::System.Runtime.Serialization.DataMember]
		public int FwdLanguagePack
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)133977234;
				short num2 = num;
				num = (short)530011282;
				switch (num2 == num)
				{
				}
				num = (short)624885761;
				if (num != 0)
				{
				}
				num = (short)581632000;
				short num3 = num;
				num = (short)1165099008;
				if (num != 0)
				{
				}
				return this.<FwdLanguagePack>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)14571977;
				short num2 = num;
				num = (short)1524324809;
				switch (num2 == num)
				{
				}
				num = (short)1238695936;
				if (num != 0)
				{
				}
				num = (short)1464270848;
				short num3 = num;
				num = (short)773586945;
				if (num != 0)
				{
				}
				this.<FwdLanguagePack>k__BackingField = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0001DD64 File Offset: 0x0001BF64
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0001DE14 File Offset: 0x0001C014
		[global::System.Runtime.Serialization.DataMember]
		public string FwdLanguagePackVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1196695718;
				short num2 = num;
				num = (short)475996326;
				switch (num2 == num)
				{
				}
				num = (short)1409024000;
				if (num != 0)
				{
				}
				num = (short)540999680;
				short num3 = num;
				num = (short)499253249;
				if (num != 0)
				{
				}
				return this.<FwdLanguagePackVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)781981669;
				short num2 = num;
				num = (short)1344804837;
				switch (num2 == num)
				{
				}
				num = (short)1242169345;
				if (num != 0)
				{
				}
				num = (short)1234763776;
				short num3 = num;
				num = (short)1273364480;
				if (num != 0)
				{
				}
				this.<FwdLanguagePackVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0001DEC4 File Offset: 0x0001C0C4
		// (set) Token: 0x06000183 RID: 387 RVA: 0x0001DF74 File Offset: 0x0001C174
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.CustomException.CommonErrorCode FailureErrorCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)866058241;
				if (num != 0)
				{
				}
				num = (short)335460047;
				short num2 = num;
				num = (short)1619506895;
				switch (num2 == num)
				{
				}
				num = (short)332070912;
				short num3 = num;
				num = (short)249233408;
				if (num != 0)
				{
				}
				return this.<FailureErrorCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)385855597;
				short num2 = num;
				num = (short)522629229;
				switch (num2 == num)
				{
				}
				num = (short)1037631489;
				if (num != 0)
				{
				}
				num = (short)815267840;
				short num3 = num;
				num = (short)1116602368;
				if (num != 0)
				{
				}
				this.<FailureErrorCode>k__BackingField = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000184 RID: 388 RVA: 0x0001E024 File Offset: 0x0001C224
		// (set) Token: 0x06000185 RID: 389 RVA: 0x0001E0D8 File Offset: 0x0001C2D8
		[global::System.Runtime.Serialization.DataMember]
		public int FwdlGroupDataJobId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1939953260;
				short num2 = num;
				num = (short)1697535596;
				switch (num2 == num)
				{
				}
				num = (short)445382657;
				if (num != 0)
				{
				}
				num = (short)587726848;
				short num3 = num;
				num = (short)572391424;
				if (num != 0)
				{
				}
				return this.<FwdlGroupDataJobId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1029441233;
				short num2 = num;
				num = (short)176424657;
				switch (num2 == num)
				{
				}
				num = (short)1394343937;
				if (num != 0)
				{
				}
				num = (short)839188480;
				short num3 = num;
				num = (short)2120744960;
				if (num != 0)
				{
				}
				this.<FwdlGroupDataJobId>k__BackingField = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000186 RID: 390 RVA: 0x0001E188 File Offset: 0x0001C388
		// (set) Token: 0x06000187 RID: 391 RVA: 0x0001E238 File Offset: 0x0001C438
		[global::System.Runtime.Serialization.DataMember]
		public int DataGroupRadioAssignmentID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2019012203;
				short num2 = num;
				num = (short)985509483;
				switch (num2 == num)
				{
				}
				num = (short)841547777;
				if (num != 0)
				{
				}
				num = (short)1646592000;
				short num3 = num;
				num = (short)2076114944;
				if (num != 0)
				{
				}
				return this.<DataGroupRadioAssignmentID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)131051139;
				short num2 = num;
				num = (short)1653255811;
				switch (num2 == num)
				{
				}
				num = (short)1046937600;
				if (num != 0)
				{
				}
				num = (short)529727488;
				short num3 = num;
				num = (short)2136932353;
				if (num != 0)
				{
				}
				this.<DataGroupRadioAssignmentID>k__BackingField = value;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0001E2F0 File Offset: 0x0001C4F0
		public GdgJobRadioStatus()
		{
			this.RadioJobState = global::Motorola.Common.Communication.CommonUtil.GdgJobRadioState.TransferNotStarted;
			this.GdgJobRadioProgress = 0;
			this.GdgJobRadioLastUpdateTime = new global::System.DateTime?(global::System.DateTime.Now);
			this.IsCodeplugUpdated = false;
			this.FailureErrorCode = global::Motorola.Common.CustomException.CommonErrorCode.None;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0001E330 File Offset: 0x0001C530
		public GdgJobRadioStatus(global::Motorola.Common.Communication.CommonUtil.GdgJobRadioState radioState, int jobProgress, global::System.DateTime? timeStamp)
		{
			this.RadioJobState = radioState;
			this.GdgJobRadioProgress = jobProgress;
			this.GdgJobRadioLastUpdateTime = timeStamp;
			this.IsCodeplugUpdated = false;
		}
	}
}
