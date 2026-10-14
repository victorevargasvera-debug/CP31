using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000188 RID: 392
	[global::System.Serializable]
	public class TransmitPowerLevels : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003F94 RID: 16276 RVA: 0x003BC2A8 File Offset: 0x003BA4A8
		public TransmitPowerLevels(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06003F95 RID: 16277 RVA: 0x003BC2E8 File Offset: 0x003BA4E8
		protected TransmitPowerLevels(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003F96 RID: 16278 RVA: 0x003BC300 File Offset: 0x003BA500
		public override void Init()
		{
			int a_ = 15;
			short num = (short)334017517;
			short num2 = num;
			num = (short)393262061;
			switch (num2 == num)
			{
			}
			num = (short)730988544;
			short num3 = num;
			num = (short)733937664;
			if (num != 0)
			{
			}
			num = (short)57671681;
			if (num != 0)
			{
			}
			this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛諝鋟菡諣闥藧菩飫뻭鿯藱釳蓵듷鿹諻鯽泿焁倃縅堇攉笋欍戏帑焓怕紗瘙弛焝丟䐡䴣䄥簧匩尫䬭漯猱3ܵषഹԻ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELCONFIGURATIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179LovStrs);
			this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.DataTransferOrder = -1;
			this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛諝食닡诣釥跧飩ꃫ语蛯韱飳藵뛷鿹读볽懿氁怃嘅搇欉戋㤍⠏弑尓氕娗笙爛稝猟䜡䠣䌥䬧帩䔫䄭帯洱申ȵषȹऻ༽", a_), global::CommonResources.AcgResources.ID_BANDPLANSELECTION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851LovStrs);
			this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.DataTransferOrder = 50;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓏ꃑ뗓룕ꯗ럙뗛ꫝ샟닡诣釥跧飩쳫ꋭ闯蓱釳髵请", a_);
			base.Id = 10103;
			base.UIName = global::CommonResources.AcgResources.ID_TRANSMITPOWERLEVELS;
			base.DataTransferOrder = 25;
		}

		// Token: 0x06003F97 RID: 16279 RVA: 0x003BC460 File Offset: 0x003BA660
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)802619400;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8E;
				case 1:
					num = (short)1883832326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1587675143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_7A;
				case 4:
				{
					num = (short)1082654720;
					short num3 = num;
					num = (short)1099890689;
					if (num != 0)
					{
					}
					this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛ꛝ냟跡鏣菥髧ꛩ觫飭闯黱蟳룵鷷跹뻻鿽滿昁吃樅椇搉㬋㘍崏娑渓吕礗琙砛䴝䔟両䄣䔥尧䌩䌫䀭漯猱3ܵ7഻༹", a_), global::CommonResources.AcgResources.ID_BANDPLANSELECTION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851LovStrs);
					this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.DataTransferOrder = 50;
					num = (short)75563013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_1FB;
				case 6:
					if (producerFields != null)
					{
						num = (short)800129026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_299;
				case 7:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗夙猛瀝䘟䬡䌣爥儧娩䤫焭焯رԳ༷̹ܵ", a_)))
					{
						goto IL_7A;
					}
					num = (short)922166409;
					short num4 = num;
					num = (short)1386816649;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8E;
					default:
						num = (short)976093184;
						if (num != 0)
						{
						}
						num = (short)1385234441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 9:
					this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛곝臟賡韣该臧黩볫臭蟯韱蛳뫵鷷賹駻鋽珿嘁簃嘅朇紉椋簍小眑戓猕琗夙猛瀝䘟䬡䌣爥儧娩䤫焭焯رԳ༷̹ܵ", a_), global::CommonResources.AcgResources.ID_TXPOWERLEVELCONFIGURATIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179LovStrs);
					this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.DataTransferOrder = -1;
					num = (short)2090205187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_57:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2008743937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)1024589824;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8E:
				if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛ꛝ냟跡鏣菥髧ꛩ觫飭闯黱蟳룵鷷跹뻻鿽滿昁吃樅椇搉㬋㘍崏娑渓吕礗琙砛䴝䔟両䄣䔥尧䌩䌫䀭漯猱3ܵ7഻༹", a_)))
				{
					break;
				}
				num = (short)1013776388;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1FB:
			IL_299:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髍ꋏ돑뫓ꗕ뗗동꣛ﻝ냟跡鏣菥髧쫩ꃫ语蛯韱飳藵", a_);
			base.Id = 10103;
			base.UIName = global::CommonResources.AcgResources.ID_TRANSMITPOWERLEVELS;
			base.DataTransferOrder = 25;
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x003BC738 File Offset: 0x003BA938
		public override void PopulateReferences()
		{
			short num = (short)695224886;
			short num2 = num;
			num = (short)471157302;
			switch (num2 == num)
			{
			}
			num = (short)827392000;
			short num3 = num;
			num = (short)737935360;
			if (num != 0)
			{
			}
			num = (short)607584257;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x003BC7E0 File Offset: 0x003BA9E0
		public override void DropReferences()
		{
			short num = (short)127211539;
			short num2 = num;
			num = (short)1441404947;
			switch (num2 == num)
			{
			}
			num = (short)1338245120;
			short num3 = num;
			num = (short)2036400129;
			if (num != 0)
			{
			}
			num = (short)164495360;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x003BC88C File Offset: 0x003BAA8C
		public override void SetConstraints()
		{
			short num = (short)1593819332;
			short num2 = num;
			num = (short)1547354308;
			switch (num2 == num)
			{
			}
			num = (short)1367932928;
			short num3 = num;
			num = (short)749338625;
			if (num != 0)
			{
			}
			num = (short)427098112;
			if (num != 0)
			{
			}
			this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIs7800BandVisibility);
			this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConIs7800BandEditable);
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x003BC964 File Offset: 0x003BAB64
		public override void SetupDependencies()
		{
			short num = (short)1317825681;
			short num2 = num;
			num = (short)1981574289;
			switch (num2 == num)
			{
			}
			num = (short)1283391488;
			short num3 = num;
			num = (short)1856700417;
			if (num != 0)
			{
			}
			num = (short)847446016;
			if (num != 0)
			{
			}
			this.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.AddDependentObject(this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851);
			this.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.AddDependentObject(this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851);
			this.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.AddDependentObject(this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.AddDependentObject(this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.AddDependentObject(this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851);
			this.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.AddDependentObject(this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851);
		}

		// Token: 0x17002092 RID: 8338
		// (get) Token: 0x06003F9C RID: 16284 RVA: 0x003BCAB4 File Offset: 0x003BACB4
		public bool HasDiffs
		{
			get
			{
				short num = (short)449598885;
				short num2 = num;
				num = (short)936596901;
				switch (num2 == num)
				{
				}
				num = (short)660602880;
				short num3 = num;
				num = (short)1796669441;
				if (num != 0)
				{
				}
				num = (short)860880896;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002093 RID: 8339
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x003BCB64 File Offset: 0x003BAD64
		// (set) Token: 0x06003F9E RID: 16286 RVA: 0x003BCC18 File Offset: 0x003BAE18
		public int RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179Value
		{
			get
			{
				short num = (short)1425154464;
				short num2 = num;
				num = (short)1801593248;
				switch (num2 == num)
				{
				}
				num = (short)767688704;
				short num3 = num;
				num = (short)974520320;
				if (num != 0)
				{
				}
				num = (short)2023030785;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Value;
			}
			set
			{
				short num = (short)1191886999;
				short num2 = num;
				num = (short)1431093399;
				switch (num2 == num)
				{
				}
				num = (short)1120927744;
				short num3 = num;
				num = (short)2061565953;
				if (num != 0)
				{
				}
				num = (short)943128576;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Value = value;
			}
		}

		// Token: 0x17002094 RID: 8340
		// (get) Token: 0x06003F9F RID: 16287 RVA: 0x003BCCD0 File Offset: 0x003BAED0
		// (set) Token: 0x06003FA0 RID: 16288 RVA: 0x003BCD84 File Offset: 0x003BAF84
		public string RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_UIValue
		{
			get
			{
				short num = (short)78602945;
				short num2 = num;
				num = (short)1883857601;
				switch (num2 == num)
				{
				}
				num = (short)127336448;
				short num3 = num;
				num = (short)906362881;
				if (num != 0)
				{
				}
				num = (short)1924530176;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.UIValue;
			}
			set
			{
				short num = (short)866959418;
				short num2 = num;
				num = (short)2028060730;
				switch (num2 == num)
				{
				}
				num = (short)1890451456;
				short num3 = num;
				num = (short)949682176;
				if (num != 0)
				{
				}
				num = (short)1657012225;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.UIValue = value;
			}
		}

		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06003FA1 RID: 16289 RVA: 0x003BCE38 File Offset: 0x003BB038
		public global::AcpBusinessLayer.AcpListField RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179
		{
			get
			{
				short num = (short)710213089;
				short num2 = num;
				num = (short)757661153;
				switch (num2 == num)
				{
				}
				num = (short)1592983552;
				short num3 = num;
				num = (short)882507776;
				if (num != 0)
				{
				}
				num = (short)126812161;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;
			}
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06003FA2 RID: 16290 RVA: 0x003BCEE8 File Offset: 0x003BB0E8
		// (set) Token: 0x06003FA3 RID: 16291 RVA: 0x003BCFA0 File Offset: 0x003BB1A0
		public bool RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_Applicable
		{
			get
			{
				short num = (short)2135487472;
				short num2 = num;
				num = (short)1894249456;
				switch (num2 == num)
				{
				}
				num = (short)1506279424;
				short num3 = num;
				num = (short)556793857;
				if (num != 0)
				{
				}
				num = (short)364183552;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Applicable;
			}
			set
			{
				short num = (short)586357826;
				short num2 = num;
				num = (short)1901403202;
				switch (num2 == num)
				{
				}
				num = (short)561643520;
				short num3 = num;
				num = (short)664076289;
				if (num != 0)
				{
				}
				num = (short)2146435072;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Applicable = value;
			}
		}

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06003FA4 RID: 16292 RVA: 0x003BD054 File Offset: 0x003BB254
		// (set) Token: 0x06003FA5 RID: 16293 RVA: 0x003BD108 File Offset: 0x003BB308
		public bool RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_Valid
		{
			get
			{
				short num = (short)247652335;
				short num2 = num;
				num = (short)337633263;
				switch (num2 == num)
				{
				}
				num = (short)418775040;
				short num3 = num;
				num = (short)73859073;
				if (num != 0)
				{
				}
				num = (short)835649536;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Valid;
			}
			set
			{
				short num = (short)462674649;
				short num2 = num;
				num = (short)222550745;
				switch (num2 == num)
				{
				}
				num = (short)1164443648;
				short num3 = num;
				num = (short)1892679681;
				if (num != 0)
				{
				}
				num = (short)1708589056;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Valid = value;
			}
		}

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06003FA6 RID: 16294 RVA: 0x003BD1BC File Offset: 0x003BB3BC
		// (set) Token: 0x06003FA7 RID: 16295 RVA: 0x003BD274 File Offset: 0x003BB474
		public bool RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_Visible
		{
			get
			{
				short num = (short)2047100623;
				short num2 = num;
				num = (short)1192576719;
				switch (num2 == num)
				{
				}
				num = (short)1101398016;
				short num3 = num;
				num = (short)27459584;
				if (num != 0)
				{
				}
				num = (short)1090125825;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Visible;
			}
			set
			{
				short num = (short)2100603572;
				short num2 = num;
				num = (short)1181395636;
				switch (num2 == num)
				{
				}
				num = (short)1029177344;
				short num3 = num;
				num = (short)1385234433;
				if (num != 0)
				{
				}
				num = (short)52297728;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Visible = value;
			}
		}

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06003FA8 RID: 16296 RVA: 0x003BD328 File Offset: 0x003BB528
		// (set) Token: 0x06003FA9 RID: 16297 RVA: 0x003BD3DC File Offset: 0x003BB5DC
		public bool RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_Editable
		{
			get
			{
				short num = (short)1979192190;
				short num2 = num;
				num = (short)1108022142;
				switch (num2 == num)
				{
				}
				num = (short)1139081216;
				short num3 = num;
				num = (short)109838337;
				if (num != 0)
				{
				}
				num = (short)11010048;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Editable;
			}
			set
			{
				short num = (short)46159433;
				short num2 = num;
				num = (short)213997129;
				switch (num2 == num)
				{
				}
				num = (short)1001521152;
				short num3 = num;
				num = (short)530120705;
				if (num != 0)
				{
				}
				num = (short)905052160;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.Editable = value;
			}
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06003FAA RID: 16298 RVA: 0x003BD494 File Offset: 0x003BB694
		internal string RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_UILabel
		{
			get
			{
				short num = (short)908823877;
				short num2 = num;
				num = (short)381324613;
				switch (num2 == num)
				{
				}
				num = (short)195231744;
				short num3 = num;
				num = (short)1300365313;
				if (num != 0)
				{
				}
				num = (short)1979514880;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.UIName;
			}
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06003FAB RID: 16299 RVA: 0x003BD548 File Offset: 0x003BB748
		// (set) Token: 0x06003FAC RID: 16300 RVA: 0x003BD600 File Offset: 0x003BB800
		internal bool RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_HiddenStatic
		{
			get
			{
				short num = (short)292552705;
				if (num != 0)
				{
				}
				num = (short)447966732;
				short num2 = num;
				num = (short)1756589580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1186463744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376649216;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.HiddenStatic;
			}
			set
			{
				short num = (short)1027723386;
				short num2 = num;
				num = (short)1806749818;
				switch (num2 == num)
				{
				}
				num = (short)373358592;
				short num3 = num;
				num = (short)25296897;
				if (num != 0)
				{
				}
				num = (short)260767744;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.HiddenStatic = value;
			}
		}

		// Token: 0x1700209C RID: 8348
		// (get) Token: 0x06003FAD RID: 16301 RVA: 0x003BD6B8 File Offset: 0x003BB8B8
		// (set) Token: 0x06003FAE RID: 16302 RVA: 0x003BD76C File Offset: 0x003BB96C
		internal bool RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_HiddenDynamic
		{
			get
			{
				short num = (short)483116420;
				short num2 = num;
				num = (short)1650574724;
				switch (num2 == num)
				{
				}
				num = (short)1965752320;
				short num3 = num;
				num = (short)444727297;
				if (num != 0)
				{
				}
				num = (short)2035875840;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.HiddenDynamic;
			}
			set
			{
				short num = (short)2108875229;
				short num2 = num;
				num = (short)429253085;
				switch (num2 == num)
				{
				}
				num = (short)1716846592;
				short num3 = num;
				num = (short)2076835840;
				if (num != 0)
				{
				}
				num = (short)1601634305;
				if (num != 0)
				{
				}
				this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.HiddenDynamic = value;
			}
		}

		// Token: 0x1700209D RID: 8349
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x003BD820 File Offset: 0x003BBA20
		public bool RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179_HasDiffs
		{
			get
			{
				short num = (short)413535960;
				short num2 = num;
				num = (short)1779568344;
				switch (num2 == num)
				{
				}
				num = (short)1713045504;
				short num3 = num;
				num = (short)1498677249;
				if (num != 0)
				{
				}
				num = (short)1453391872;
				if (num != 0)
				{
				}
				return this.radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179._HasDiffs;
			}
		}

		// Token: 0x1700209E RID: 8350
		// (get) Token: 0x06003FB0 RID: 16304 RVA: 0x003BD8D8 File Offset: 0x003BBAD8
		// (set) Token: 0x06003FB1 RID: 16305 RVA: 0x003BD98C File Offset: 0x003BBB8C
		public int RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851Value
		{
			get
			{
				short num = (short)1541988275;
				short num2 = num;
				num = (short)1991434163;
				switch (num2 == num)
				{
				}
				num = (short)1386217472;
				short num3 = num;
				num = (short)1287323649;
				if (num != 0)
				{
				}
				num = (short)1017315328;
				if (num != 0)
				{
				}
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Value;
			}
			set
			{
				short num = (short)1263426103;
				short num2 = num;
				num = (short)584014391;
				switch (num2 == num)
				{
				}
				num = (short)38862849;
				if (num != 0)
				{
				}
				num = (short)1006174208;
				if (num != 0)
				{
				}
				num = (short)1622671360;
				short num3 = num;
				this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Value = value;
			}
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06003FB2 RID: 16306 RVA: 0x003BDA40 File Offset: 0x003BBC40
		// (set) Token: 0x06003FB3 RID: 16307 RVA: 0x003BDAF8 File Offset: 0x003BBCF8
		public string RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_UIValue
		{
			get
			{
				short num = (short)2027885385;
				short num2 = num;
				num = (short)912528201;
				switch (num2 == num)
				{
				}
				num = (short)1565720577;
				if (num != 0)
				{
				}
				num = (short)1974075392;
				if (num != 0)
				{
				}
				num = (short)1353056256;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.UIValue;
			}
			set
			{
				short num = (short)1322743586;
				short num2 = num;
				num = (short)2098493218;
				switch (num2 == num)
				{
				}
				num = (short)1851260929;
				if (num != 0)
				{
				}
				num = (short)1893662720;
				if (num != 0)
				{
				}
				num = (short)1179975680;
				short num3 = num;
				this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.UIValue = value;
			}
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06003FB4 RID: 16308 RVA: 0x003BDBAC File Offset: 0x003BBDAC
		public global::AcpBusinessLayer.AcpListField RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851
		{
			get
			{
				short num = (short)11607938;
				short num2 = num;
				num = (short)480911234;
				switch (num2 == num)
				{
				}
				num = (short)1951662081;
				if (num != 0)
				{
				}
				num = (short)1095892992;
				if (num != 0)
				{
				}
				num = (short)564068352;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;
			}
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06003FB5 RID: 16309 RVA: 0x003BDC5C File Offset: 0x003BBE5C
		// (set) Token: 0x06003FB6 RID: 16310 RVA: 0x003BDD14 File Offset: 0x003BBF14
		public bool RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_Applicable
		{
			get
			{
				short num = (short)2082886329;
				short num2 = num;
				num = (short)671437497;
				switch (num2 == num)
				{
				}
				num = (short)1501036545;
				if (num != 0)
				{
				}
				num = (short)339935232;
				if (num != 0)
				{
				}
				num = (short)1405878272;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Applicable;
			}
			set
			{
				short num = (short)590561658;
				short num2 = num;
				num = (short)783827322;
				switch (num2 == num)
				{
				}
				num = (short)1586626560;
				if (num != 0)
				{
				}
				num = (short)1742077953;
				if (num != 0)
				{
				}
				num = (short)2075525120;
				short num3 = num;
				this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Applicable = value;
			}
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06003FB7 RID: 16311 RVA: 0x003BDDCC File Offset: 0x003BBFCC
		// (set) Token: 0x06003FB8 RID: 16312 RVA: 0x003BDE7C File Offset: 0x003BC07C
		public bool RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_Valid
		{
			get
			{
				short num = (short)1214344666;
				short num2 = num;
				num = (short)1043754458;
				switch (num2 == num)
				{
				}
				num = (short)1542586369;
				if (num != 0)
				{
				}
				num = (short)1705705472;
				if (num != 0)
				{
				}
				num = (short)169082880;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Valid;
			}
			set
			{
				short num = (short)1521907442;
				short num2 = num;
				num = (short)1196127986;
				switch (num2 == num)
				{
				}
				num = (short)832897025;
				if (num != 0)
				{
				}
				num = (short)296091648;
				if (num != 0)
				{
				}
				num = (short)1644560384;
				short num3 = num;
				this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Valid = value;
			}
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x003BDF34 File Offset: 0x003BC134
		// (set) Token: 0x06003FBA RID: 16314 RVA: 0x003BDFE8 File Offset: 0x003BC1E8
		public bool RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_Visible
		{
			get
			{
				short num = (short)199229441;
				if (num != 0)
				{
				}
				num = (short)2013526251;
				short num2 = num;
				num = (short)649328875;
				switch (num2 == num)
				{
				}
				num = (short)314638336;
				if (num != 0)
				{
				}
				num = (short)857210880;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Visible;
			}
			set
			{
				short num = (short)653852673;
				if (num != 0)
				{
				}
				num = (short)256828380;
				short num2 = num;
				num = (short)1226892252;
				switch (num2 == num)
				{
				}
				num = (short)2011955200;
				if (num != 0)
				{
				}
				num = (short)555810816;
				short num3 = num;
				this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Visible = value;
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06003FBB RID: 16315 RVA: 0x003BE0A0 File Offset: 0x003BC2A0
		// (set) Token: 0x06003FBC RID: 16316 RVA: 0x003BE158 File Offset: 0x003BC358
		public bool RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_Editable
		{
			get
			{
				short num = (short)1220394109;
				short num2 = num;
				num = (short)1016904829;
				switch (num2 == num)
				{
				}
				num = (short)263061504;
				if (num != 0)
				{
				}
				num = (short)731316225;
				if (num != 0)
				{
				}
				num = (short)1919287296;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Editable;
			}
			set
			{
				short num = (short)1264377255;
				short num2 = num;
				num = (short)1889263015;
				switch (num2 == num)
				{
				}
				num = (short)96075776;
				if (num != 0)
				{
				}
				num = (short)268566529;
				if (num != 0)
				{
				}
				num = (short)1052114944;
				short num3 = num;
				this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Editable = value;
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06003FBD RID: 16317 RVA: 0x003BE210 File Offset: 0x003BC410
		internal string RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_UILabel
		{
			get
			{
				short num = (short)769551223;
				short num2 = num;
				num = (short)1228434295;
				switch (num2 == num)
				{
				}
				num = (short)938541057;
				if (num != 0)
				{
				}
				num = (short)1290141696;
				if (num != 0)
				{
				}
				num = (short)337248256;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.UIName;
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06003FBE RID: 16318 RVA: 0x003BE2C4 File Offset: 0x003BC4C4
		// (set) Token: 0x06003FBF RID: 16319 RVA: 0x003BE37C File Offset: 0x003BC57C
		internal bool RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_HiddenStatic
		{
			get
			{
				short num = (short)1229538506;
				short num2 = num;
				num = (short)522011850;
				switch (num2 == num)
				{
				}
				num = (short)636420096;
				if (num != 0)
				{
				}
				num = (short)594345985;
				if (num != 0)
				{
				}
				num = (short)1813708800;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.HiddenStatic;
			}
			set
			{
				short num = (short)1157758977;
				if (num != 0)
				{
				}
				num = (short)1443637731;
				short num2 = num;
				num = (short)563358179;
				switch (num2 == num)
				{
				}
				num = (short)232587264;
				if (num != 0)
				{
				}
				num = (short)518586368;
				short num3 = num;
				this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.HiddenStatic = value;
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06003FC0 RID: 16320 RVA: 0x003BE430 File Offset: 0x003BC630
		// (set) Token: 0x06003FC1 RID: 16321 RVA: 0x003BE4E4 File Offset: 0x003BC6E4
		internal bool RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_HiddenDynamic
		{
			get
			{
				short num = (short)1798704706;
				short num2 = num;
				num = (short)1524436546;
				switch (num2 == num)
				{
				}
				num = (short)1408499713;
				if (num != 0)
				{
				}
				num = (short)1003028480;
				if (num != 0)
				{
				}
				num = (short)213975040;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.HiddenDynamic;
			}
			set
			{
				short num = (short)1212060611;
				short num2 = num;
				num = (short)412062659;
				switch (num2 == num)
				{
				}
				num = (short)1818492929;
				if (num != 0)
				{
				}
				num = (short)295698432;
				if (num != 0)
				{
				}
				num = (short)156172288;
				short num3 = num;
				this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.HiddenDynamic = value;
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06003FC2 RID: 16322 RVA: 0x003BE598 File Offset: 0x003BC798
		public bool RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851_HasDiffs
		{
			get
			{
				short num = (short)419401894;
				short num2 = num;
				num = (short)590581926;
				switch (num2 == num)
				{
				}
				num = (short)1795293185;
				if (num != 0)
				{
				}
				num = (short)133693440;
				if (num != 0)
				{
				}
				num = (short)798556160;
				short num3 = num;
				return this.radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851._HasDiffs;
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x003BE64C File Offset: 0x003BC84C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)1888155762;
				short num2 = num;
				num = (short)369490034;
				switch (num2 == num)
				{
				}
				num = (short)624230400;
				if (num != 0)
				{
				}
				num = (short)1871642625;
				if (num != 0)
				{
				}
				num = (short)1544880128;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x003BE708 File Offset: 0x003BC908
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)829554688;
						short num3 = num2;
						num2 = (short)121634819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1782644736;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F4;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)320012292;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F4;
					case 3:
						goto IL_B0;
					case 4:
						num2 = (short)174653441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24;
				}
				IL_F4:
				num2 = (short)131697367;
				short num4 = num2;
				num2 = (short)962300631;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_128;
				}
				IL_B0:
				goto IL_F4;
				IL_24:
				result = null;
				num2 = (short)1464598530;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_128:
			num2 = (short)1412694016;
			if (num2 != 0)
			{
			}
			num2 = (short)1496514561;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x040019F5 RID: 6645
		private global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerRecset innerRecset;

		// Token: 0x040019F6 RID: 6646
		private global::AcpBusinessLayer.AcpListField radWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;

		// Token: 0x040019F7 RID: 6647
		private global::AcpBusinessLayer.AcpListField radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;
	}
}
