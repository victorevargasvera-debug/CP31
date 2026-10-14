using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x0200043A RID: 1082
	[global::System.Serializable]
	public class DTMFCodesInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009228 RID: 37416 RVA: 0x0089C5A8 File Offset: 0x0089A7A8
		public DTMFCodesInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009229 RID: 37417 RVA: 0x0089C5C4 File Offset: 0x0089A7C4
		protected DTMFCodesInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600922A RID: 37418 RVA: 0x0089C5DC File Offset: 0x0089A7DC
		public override void Init()
		{
			int a_ = 2;
			short num = (short)1996685312;
			short num2 = num;
			num = (short)165452313;
			short num3 = num;
			num = (short)1052875289;
			switch (num3 == num)
			{
			}
			num = (short)349044736;
			if (num != 0)
			{
			}
			num = (short)2126905345;
			if (num != 0)
			{
			}
			this.phnWideDTMFCodesAccess_A7381 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("苂蓆诈", a_), new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PackAndunpackPhoneDigitString(), this, global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠ꋢ蛤蓦賨飪黬냮냰쓲웴쿶죸", a_), global::CommonResources.AcgResources.ID_ACCESS);
			this.phnWideDTMFCodesAccess_A7381.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDTMFCodesAccess_A7381.DataTransferOrder = 1;
			this.phnWideDTMFCodesDeaccess_A7803 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("苂蓆诈", a_), new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PackAndunpackPhoneDigitString(), this, global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠꟢胤蛦諨裪裬鳮苰곲듴샶쇸쯺컼", a_), global::CommonResources.AcgResources.ID_DEACCESS);
			this.phnWideDTMFCodesDeaccess_A7803.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDTMFCodesDeaccess_A7803.DataTransferOrder = 3;
			this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠꣢胤黦蛨跪ꧬ믮볰뗲뛴飶鷸黺軼꯾怀愂椄戆嘈䨊㰌㴎⤐⌒└", a_), global::CommonResources.AcgResources.ID_DTMFCODES, 14);
			this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.DataTransferOrder = 12;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟂釄諆迈軌ꃎ뗐뛒ꛔ", a_);
			base.Id = 10001;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFCODES;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600922B RID: 37419 RVA: 0x0089C790 File Offset: 0x0089A990
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)1576730631;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.phnWideDTMFCodesDeaccess_A7803 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("苂蓆诈", a_), new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PackAndunpackPhoneDigitString(), this, global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠꟢胤蛦諨裪裬鳮苰곲듴샶쇸쯺컼", a_), global::CommonResources.AcgResources.ID_DEACCESS);
					this.phnWideDTMFCodesDeaccess_A7803.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDTMFCodesDeaccess_A7803.DataTransferOrder = 3;
					num = (short)1999437827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠꣢胤黦蛨跪ꧬ믮볰뗲뛴飶鷸黺軼꯾怀愂椄戆嘈䨊㰌㴎⤐⌒└", a_)))
					{
						num = (short)1264189446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36A;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠꟢胤蛦諨裪裬鳮苰곲듴샶쇸쯺컼", a_)))
					{
						goto IL_146;
					}
					goto IL_2B6;
				case 3:
					num = (short)1734279169;
					if (num != 0)
					{
					}
					goto IL_2B6;
				case 4:
					this.phnWideDTMFCodesAccess_A7381 = new global::AcpBusinessLayer.AcpFieldX<string, string>(global::AllFeatures.CodeplugGuid.b("苂蓆诈", a_), new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PackAndunpackPhoneDigitString(), this, global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠ꋢ蛤蓦賨飪黬냮냰쓲웴쿶죸", a_), global::CommonResources.AcgResources.ID_ACCESS);
					this.phnWideDTMFCodesAccess_A7381.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDTMFCodesAccess_A7381.DataTransferOrder = 1;
					num = (short)2128936968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)999555082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠꣢胤黦蛨跪ꧬ믮볰뗲뛴飶鷸黺軼꯾怀愂椄戆嘈䨊㰌㴎⤐⌒└", a_), global::CommonResources.AcgResources.ID_DTMFCODES, 14);
					this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.DataTransferOrder = 12;
					num = (short)1290797065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 8:
					goto IL_115;
				case 9:
					goto IL_277;
				case 10:
					if (producerFields != null)
					{
						num = (short)1762918411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36A;
				case 11:
					num = (short)138543116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)1543467294;
					short num3 = num;
					num = (short)1084584222;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
					{
						num = (short)1939079168;
						if (num != 0)
						{
						}
						num = (short)300417024;
						short num4 = num;
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏂귄꧆黈ꋊ꧌꫎闐蟒飔釖高듚맜뫞鋠ꋢ蛤蓦賨飪黬냮냰쓲웴쿶죸", a_)))
						{
							num = (short)2084306948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_115;
					}
					}
					break;
				}
				}
				IL_63:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)945553413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_115:
				num = (short)15728642;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_146:
				num = (short)1092091904;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B6:
				num = (short)431554561;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_277:
			IL_36A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟂釄諆迈軌ꃎ뗐뛒ꛔ", a_);
			base.Id = 10001;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFCODES;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x0089CB38 File Offset: 0x0089AD38
		public override void PopulateReferences()
		{
			short num = (short)1289158656;
			short num2 = num;
			num = (short)218698037;
			short num3 = num;
			num = (short)12849461;
			switch (num3 == num)
			{
			}
			num = (short)40435713;
			if (num != 0)
			{
			}
			num = (short)1781268480;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600922D RID: 37421 RVA: 0x0089CBE0 File Offset: 0x0089ADE0
		public override void DropReferences()
		{
			short num = (short)710606848;
			short num2 = num;
			num = (short)1623305920;
			short num3 = num;
			num = (short)365145792;
			switch (num3 == num)
			{
			}
			num = (short)1789067265;
			if (num != 0)
			{
			}
			num = (short)2008547328;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600922E RID: 37422 RVA: 0x0089CC88 File Offset: 0x0089AE88
		public override void SetConstraints()
		{
			short num = (short)1457913856;
			short num2 = num;
			num = (short)715083444;
			short num3 = num;
			num = (short)341397172;
			switch (num3 == num)
			{
			}
			num = (short)1780154369;
			if (num != 0)
			{
			}
			num = (short)607453184;
			if (num != 0)
			{
			}
			this.phnWideDTMFCodesDeaccess_A7803.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PhoneWideConstraints.ConVerifyDtmfCodesLengthForPhnDeaccessGui);
		}

		// Token: 0x0600922F RID: 37423 RVA: 0x0089CD44 File Offset: 0x0089AF44
		public override void SetupDependencies()
		{
			short num = (short)251592704;
			short num2 = num;
			num = (short)1610481665;
			if (num != 0)
			{
			}
			num = (short)1006978611;
			short num3 = num;
			num = (short)1035617843;
			switch (num3 == num)
			{
			}
			num = (short)1434976256;
			if (num != 0)
			{
			}
		}

		// Token: 0x170049BA RID: 18874
		// (get) Token: 0x06009230 RID: 37424 RVA: 0x0089CDEC File Offset: 0x0089AFEC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1377697792;
				short num2 = num;
				num = (short)985680825;
				short num3 = num;
				num = (short)1424444345;
				switch (num3 == num)
				{
				}
				num = (short)42598401;
				if (num != 0)
				{
				}
				num = (short)2139881472;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170049BB RID: 18875
		// (get) Token: 0x06009231 RID: 37425 RVA: 0x0089CE9C File Offset: 0x0089B09C
		// (set) Token: 0x06009232 RID: 37426 RVA: 0x0089CF50 File Offset: 0x0089B150
		public string PhnWideDTMFCodesAccess_A7381Value
		{
			get
			{
				short num = (short)364773376;
				short num2 = num;
				num = (short)641003607;
				short num3 = num;
				num = (short)1510404183;
				switch (num3 == num)
				{
				}
				num = (short)1977417729;
				if (num != 0)
				{
				}
				num = (short)692125696;
				if (num != 0)
				{
				}
				return this.phnWideDTMFCodesAccess_A7381.Value;
			}
			set
			{
				short num = (short)1123942400;
				short num2 = num;
				num = (short)1917065753;
				short num3 = num;
				num = (short)1924536857;
				switch (num3 == num)
				{
				}
				num = (short)149422081;
				if (num != 0)
				{
				}
				num = (short)691666944;
				if (num != 0)
				{
				}
				this.phnWideDTMFCodesAccess_A7381.Value = value;
			}
		}

		// Token: 0x170049BC RID: 18876
		// (get) Token: 0x06009233 RID: 37427 RVA: 0x0089D004 File Offset: 0x0089B204
		public global::AcpBusinessLayer.AcpFieldX<string, string> PhnWideDTMFCodesAccess_A7381
		{
			get
			{
				short num = (short)2138636288;
				short num2 = num;
				num = (short)325434045;
				short num3 = num;
				num = (short)1942665917;
				switch (num3 == num)
				{
				}
				num = (short)1343815680;
				if (num != 0)
				{
				}
				num = (short)1744502785;
				if (num != 0)
				{
				}
				return this.phnWideDTMFCodesAccess_A7381;
			}
		}

		// Token: 0x170049BD RID: 18877
		// (get) Token: 0x06009234 RID: 37428 RVA: 0x0089D0B0 File Offset: 0x0089B2B0
		// (set) Token: 0x06009235 RID: 37429 RVA: 0x0089D164 File Offset: 0x0089B364
		public string PhnWideDTMFCodesAccess_A7381_UIValue
		{
			get
			{
				short num = (short)1520697344;
				short num2 = num;
				num = (short)958350897;
				short num3 = num;
				num = (short)1283147313;
				switch (num3 == num)
				{
				}
				num = (short)810942465;
				if (num != 0)
				{
				}
				num = (short)1459159040;
				if (num != 0)
				{
				}
				return this.phnWideDTMFCodesAccess_A7381.UIValue;
			}
			set
			{
				short num = (short)914817024;
				short num2 = num;
				num = (short)1540141073;
				short num3 = num;
				num = (short)2094641169;
				switch (num3 == num)
				{
				}
				num = (short)443940864;
				if (num != 0)
				{
				}
				num = (short)1771831297;
				if (num != 0)
				{
				}
				this.phnWideDTMFCodesAccess_A7381.UIValue = value;
			}
		}

		// Token: 0x170049BE RID: 18878
		// (get) Token: 0x06009236 RID: 37430 RVA: 0x0089D218 File Offset: 0x0089B418
		// (set) Token: 0x06009237 RID: 37431 RVA: 0x0089D2CC File Offset: 0x0089B4CC
		public bool PhnWideDTMFCodesAccess_A7381_Applicable
		{
			get
			{
				short num = (short)1519058944;
				short num2 = num;
				num = (short)544942537;
				short num3 = num;
				num = (short)1192110537;
				switch (num3 == num)
				{
				}
				num = (short)992215041;
				if (num != 0)
				{
				}
				num = (short)185597952;
				if (num != 0)
				{
				}
				return this.phnWideDTMFCodesAccess_A7381.Applicable;
			}
			set
			{
				short num = (short)1522789754;
				short num2 = num;
				num = (short)237432186;
				switch (num2 == num)
				{
				}
				num = (short)1098907648;
				if (num != 0)
				{
				}
				num = (short)367984641;
				if (num != 0)
				{
				}
				num = (short)455737344;
				short num3 = num;
				this.phnWideDTMFCodesAccess_A7381.Applicable = value;
			}
		}

		// Token: 0x170049BF RID: 18879
		// (get) Token: 0x06009238 RID: 37432 RVA: 0x0089D384 File Offset: 0x0089B584
		// (set) Token: 0x06009239 RID: 37433 RVA: 0x0089D438 File Offset: 0x0089B638
		public bool PhnWideDTMFCodesAccess_A7381_Valid
		{
			get
			{
				short num = (short)986723395;
				short num2 = num;
				num = (short)278541379;
				switch (num2 == num)
				{
				}
				num = (short)946470912;
				if (num != 0)
				{
				}
				num = (short)830341121;
				if (num != 0)
				{
				}
				num = (short)427294720;
				short num3 = num;
				return this.phnWideDTMFCodesAccess_A7381.Valid;
			}
			set
			{
				short num = (short)1230036567;
				short num2 = num;
				num = (short)87416407;
				switch (num2 == num)
				{
				}
				num = (short)1219231744;
				if (num != 0)
				{
				}
				num = (short)253558785;
				if (num != 0)
				{
				}
				num = (short)1820065792;
				short num3 = num;
				this.phnWideDTMFCodesAccess_A7381.Valid = value;
			}
		}

		// Token: 0x170049C0 RID: 18880
		// (get) Token: 0x0600923A RID: 37434 RVA: 0x0089D4F0 File Offset: 0x0089B6F0
		// (set) Token: 0x0600923B RID: 37435 RVA: 0x0089D5A4 File Offset: 0x0089B7A4
		public bool PhnWideDTMFCodesAccess_A7381_Visible
		{
			get
			{
				short num = (short)911558326;
				short num2 = num;
				num = (short)1168918198;
				switch (num2 == num)
				{
				}
				num = (short)1647312896;
				if (num != 0)
				{
				}
				num = (short)73793537;
				if (num != 0)
				{
				}
				num = (short)2019753984;
				short num3 = num;
				return this.phnWideDTMFCodesAccess_A7381.Visible;
			}
			set
			{
				short num = (short)418432969;
				short num2 = num;
				num = (short)1510524873;
				switch (num2 == num)
				{
				}
				num = (short)1133314048;
				if (num != 0)
				{
				}
				num = (short)551354369;
				if (num != 0)
				{
				}
				num = (short)1303773184;
				short num3 = num;
				this.phnWideDTMFCodesAccess_A7381.Visible = value;
			}
		}

		// Token: 0x170049C1 RID: 18881
		// (get) Token: 0x0600923C RID: 37436 RVA: 0x0089D65C File Offset: 0x0089B85C
		// (set) Token: 0x0600923D RID: 37437 RVA: 0x0089D710 File Offset: 0x0089B910
		public bool PhnWideDTMFCodesAccess_A7381_Editable
		{
			get
			{
				short num = (short)118474220;
				short num2 = num;
				num = (short)195610092;
				switch (num2 == num)
				{
				}
				num = (short)985989120;
				if (num != 0)
				{
				}
				num = (short)1149108225;
				if (num != 0)
				{
				}
				num = (short)1569193984;
				short num3 = num;
				return this.phnWideDTMFCodesAccess_A7381.Editable;
			}
			set
			{
				short num = (short)1608777729;
				if (num != 0)
				{
				}
				num = (short)906542781;
				short num2 = num;
				num = (short)1520549565;
				switch (num2 == num)
				{
				}
				num = (short)1719271424;
				if (num != 0)
				{
				}
				num = (short)1795358720;
				short num3 = num;
				this.phnWideDTMFCodesAccess_A7381.Editable = value;
			}
		}

		// Token: 0x170049C2 RID: 18882
		// (get) Token: 0x0600923E RID: 37438 RVA: 0x0089D7C4 File Offset: 0x0089B9C4
		internal string PhnWideDTMFCodesAccess_A7381_UILabel
		{
			get
			{
				short num = (short)1697411462;
				short num2 = num;
				num = (short)585920902;
				switch (num2 == num)
				{
				}
				num = (short)848953344;
				if (num != 0)
				{
				}
				num = (short)785383425;
				if (num != 0)
				{
				}
				num = (short)1792933888;
				short num3 = num;
				return this.phnWideDTMFCodesAccess_A7381.UIName;
			}
		}

		// Token: 0x170049C3 RID: 18883
		// (get) Token: 0x0600923F RID: 37439 RVA: 0x0089D878 File Offset: 0x0089BA78
		// (set) Token: 0x06009240 RID: 37440 RVA: 0x0089D92C File Offset: 0x0089BB2C
		internal bool PhnWideDTMFCodesAccess_A7381_HiddenStatic
		{
			get
			{
				short num = (short)42429702;
				short num2 = num;
				num = (short)1635872006;
				switch (num2 == num)
				{
				}
				num = (short)904200192;
				if (num != 0)
				{
				}
				num = (short)1570242561;
				if (num != 0)
				{
				}
				num = (short)435421184;
				short num3 = num;
				return this.phnWideDTMFCodesAccess_A7381.HiddenStatic;
			}
			set
			{
				short num = (short)1224778429;
				short num2 = num;
				num = (short)1075290813;
				switch (num2 == num)
				{
				}
				num = (short)2122186752;
				if (num != 0)
				{
				}
				num = (short)1521483777;
				if (num != 0)
				{
				}
				num = (short)339804160;
				short num3 = num;
				this.phnWideDTMFCodesAccess_A7381.HiddenStatic = value;
			}
		}

		// Token: 0x170049C4 RID: 18884
		// (get) Token: 0x06009241 RID: 37441 RVA: 0x0089D9E0 File Offset: 0x0089BBE0
		// (set) Token: 0x06009242 RID: 37442 RVA: 0x0089DA94 File Offset: 0x0089BC94
		internal bool PhnWideDTMFCodesAccess_A7381_HiddenDynamic
		{
			get
			{
				short num = (short)781293030;
				short num2 = num;
				num = (short)1831507430;
				switch (num2 == num)
				{
				}
				num = (short)1030356993;
				if (num != 0)
				{
				}
				num = (short)1907687424;
				if (num != 0)
				{
				}
				num = (short)74186752;
				short num3 = num;
				return this.phnWideDTMFCodesAccess_A7381.HiddenDynamic;
			}
			set
			{
				short num = (short)424542209;
				if (num != 0)
				{
				}
				num = (short)2122864541;
				short num2 = num;
				num = (short)691885981;
				switch (num2 == num)
				{
				}
				num = (short)1843134464;
				if (num != 0)
				{
				}
				num = (short)186646528;
				short num3 = num;
				this.phnWideDTMFCodesAccess_A7381.HiddenDynamic = value;
			}
		}

		// Token: 0x170049C5 RID: 18885
		// (get) Token: 0x06009243 RID: 37443 RVA: 0x0089DB4C File Offset: 0x0089BD4C
		public bool PhnWideDTMFCodesAccess_A7381_HasDiffs
		{
			get
			{
				short num = (short)552298026;
				short num2 = num;
				num = (short)961177130;
				switch (num2 == num)
				{
				}
				num = (short)249430016;
				if (num != 0)
				{
				}
				num = (short)1633943553;
				if (num != 0)
				{
				}
				num = (short)139264000;
				short num3 = num;
				return this.phnWideDTMFCodesAccess_A7381._HasDiffs;
			}
		}

		// Token: 0x170049C6 RID: 18886
		// (get) Token: 0x06009244 RID: 37444 RVA: 0x0089DC00 File Offset: 0x0089BE00
		// (set) Token: 0x06009245 RID: 37445 RVA: 0x0089DCB4 File Offset: 0x0089BEB4
		public string PhnWideDTMFCodesDeaccess_A7803Value
		{
			get
			{
				short num = (short)1719286561;
				short num2 = num;
				num = (short)1077164833;
				switch (num2 == num)
				{
				}
				num = (short)380305409;
				if (num != 0)
				{
				}
				num = (short)1773535232;
				if (num != 0)
				{
				}
				num = (short)340393984;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.Value;
			}
			set
			{
				short num = (short)1758027404;
				short num2 = num;
				num = (short)145383052;
				switch (num2 == num)
				{
				}
				num = (short)1994981377;
				if (num != 0)
				{
				}
				num = (short)454033408;
				if (num != 0)
				{
				}
				num = (short)2135556096;
				short num3 = num;
				this.phnWideDTMFCodesDeaccess_A7803.Value = value;
			}
		}

		// Token: 0x170049C7 RID: 18887
		// (get) Token: 0x06009246 RID: 37446 RVA: 0x0089DD68 File Offset: 0x0089BF68
		public global::AcpBusinessLayer.AcpFieldX<string, string> PhnWideDTMFCodesDeaccess_A7803
		{
			get
			{
				short num = (short)757557834;
				short num2 = num;
				num = (short)1670539850;
				switch (num2 == num)
				{
				}
				num = (short)1210318849;
				if (num != 0)
				{
				}
				num = (short)1297219584;
				if (num != 0)
				{
				}
				num = (short)645005312;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803;
			}
		}

		// Token: 0x170049C8 RID: 18888
		// (get) Token: 0x06009247 RID: 37447 RVA: 0x0089DE18 File Offset: 0x0089C018
		// (set) Token: 0x06009248 RID: 37448 RVA: 0x0089DECC File Offset: 0x0089C0CC
		public string PhnWideDTMFCodesDeaccess_A7803_UIValue
		{
			get
			{
				short num = (short)882522323;
				short num2 = num;
				num = (short)1710635219;
				switch (num2 == num)
				{
				}
				num = (short)1139212289;
				if (num != 0)
				{
				}
				num = (short)1206386688;
				if (num != 0)
				{
				}
				num = (short)209780736;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.UIValue;
			}
			set
			{
				short num = (short)1541818132;
				short num2 = num;
				num = (short)2104772372;
				switch (num2 == num)
				{
				}
				num = (short)1166868481;
				if (num != 0)
				{
				}
				num = (short)313982976;
				if (num != 0)
				{
				}
				num = (short)510132224;
				short num3 = num;
				this.phnWideDTMFCodesDeaccess_A7803.UIValue = value;
			}
		}

		// Token: 0x170049C9 RID: 18889
		// (get) Token: 0x06009249 RID: 37449 RVA: 0x0089DF84 File Offset: 0x0089C184
		// (set) Token: 0x0600924A RID: 37450 RVA: 0x0089E038 File Offset: 0x0089C238
		public bool PhnWideDTMFCodesDeaccess_A7803_Applicable
		{
			get
			{
				short num = (short)1465118742;
				short num2 = num;
				num = (short)1116467222;
				switch (num2 == num)
				{
				}
				num = (short)792526849;
				if (num != 0)
				{
				}
				num = (short)1926299648;
				if (num != 0)
				{
				}
				num = (short)1835466752;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.Applicable;
			}
			set
			{
				short num = (short)1754195406;
				short num2 = num;
				num = (short)1631315406;
				switch (num2 == num)
				{
				}
				num = (short)1707540481;
				if (num != 0)
				{
				}
				num = (short)414973952;
				if (num != 0)
				{
				}
				num = (short)1540882432;
				short num3 = num;
				this.phnWideDTMFCodesDeaccess_A7803.Applicable = value;
			}
		}

		// Token: 0x170049CA RID: 18890
		// (get) Token: 0x0600924B RID: 37451 RVA: 0x0089E0F0 File Offset: 0x0089C2F0
		// (set) Token: 0x0600924C RID: 37452 RVA: 0x0089E1A4 File Offset: 0x0089C3A4
		public bool PhnWideDTMFCodesDeaccess_A7803_Valid
		{
			get
			{
				short num = (short)1002122024;
				short num2 = num;
				num = (short)946285352;
				switch (num2 == num)
				{
				}
				num = (short)1203896320;
				if (num != 0)
				{
				}
				num = (short)2009661441;
				if (num != 0)
				{
				}
				num = (short)1734803456;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.Valid;
			}
			set
			{
				short num = (short)1347263468;
				short num2 = num;
				num = (short)388078572;
				switch (num2 == num)
				{
				}
				num = (short)736886785;
				if (num != 0)
				{
				}
				num = (short)364314624;
				if (num != 0)
				{
				}
				num = (short)1966931968;
				short num3 = num;
				this.phnWideDTMFCodesDeaccess_A7803.Valid = value;
			}
		}

		// Token: 0x170049CB RID: 18891
		// (get) Token: 0x0600924D RID: 37453 RVA: 0x0089E258 File Offset: 0x0089C458
		// (set) Token: 0x0600924E RID: 37454 RVA: 0x0089E30C File Offset: 0x0089C50C
		public bool PhnWideDTMFCodesDeaccess_A7803_Visible
		{
			get
			{
				short num = (short)1256187442;
				short num2 = num;
				num = (short)1960371762;
				switch (num2 == num)
				{
				}
				num = (short)1003094017;
				if (num != 0)
				{
				}
				num = (short)1933246464;
				if (num != 0)
				{
				}
				num = (short)1852833792;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.Visible;
			}
			set
			{
				short num = (short)2029354685;
				short num2 = num;
				num = (short)1574141629;
				switch (num2 == num)
				{
				}
				num = (short)1568735232;
				if (num != 0)
				{
				}
				num = (short)858718209;
				if (num != 0)
				{
				}
				num = (short)342097920;
				short num3 = num;
				this.phnWideDTMFCodesDeaccess_A7803.Visible = value;
			}
		}

		// Token: 0x170049CC RID: 18892
		// (get) Token: 0x0600924F RID: 37455 RVA: 0x0089E3C4 File Offset: 0x0089C5C4
		// (set) Token: 0x06009250 RID: 37456 RVA: 0x0089E478 File Offset: 0x0089C678
		public bool PhnWideDTMFCodesDeaccess_A7803_Editable
		{
			get
			{
				short num = (short)457630254;
				short num2 = num;
				num = (short)449307182;
				switch (num2 == num)
				{
				}
				num = (short)1134886912;
				if (num != 0)
				{
				}
				num = (short)1183449089;
				if (num != 0)
				{
				}
				num = (short)1602486272;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.Editable;
			}
			set
			{
				short num = (short)1893608318;
				short num2 = num;
				num = (short)805907326;
				switch (num2 == num)
				{
				}
				num = (short)1538260993;
				if (num != 0)
				{
				}
				num = (short)1225261056;
				if (num != 0)
				{
				}
				num = (short)739377152;
				short num3 = num;
				this.phnWideDTMFCodesDeaccess_A7803.Editable = value;
			}
		}

		// Token: 0x170049CD RID: 18893
		// (get) Token: 0x06009251 RID: 37457 RVA: 0x0089E530 File Offset: 0x0089C730
		internal string PhnWideDTMFCodesDeaccess_A7803_UILabel
		{
			get
			{
				short num = (short)2099396279;
				short num2 = num;
				num = (short)626146999;
				switch (num2 == num)
				{
				}
				num = (short)1334771712;
				if (num != 0)
				{
				}
				num = (short)25886721;
				if (num != 0)
				{
				}
				num = (short)252051456;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.UIName;
			}
		}

		// Token: 0x170049CE RID: 18894
		// (get) Token: 0x06009252 RID: 37458 RVA: 0x0089E5E8 File Offset: 0x0089C7E8
		// (set) Token: 0x06009253 RID: 37459 RVA: 0x0089E6A0 File Offset: 0x0089C8A0
		internal bool PhnWideDTMFCodesDeaccess_A7803_HiddenStatic
		{
			get
			{
				short num = (short)302655709;
				short num2 = num;
				num = (short)1635330269;
				switch (num2 == num)
				{
				}
				num = (short)362610688;
				if (num != 0)
				{
				}
				num = (short)655361;
				if (num != 0)
				{
				}
				num = (short)1377632256;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.HiddenStatic;
			}
			set
			{
				short num = (short)614109294;
				short num2 = num;
				num = (short)606507118;
				switch (num2 == num)
				{
				}
				num = (short)1968701441;
				if (num != 0)
				{
				}
				num = (short)628097024;
				if (num != 0)
				{
				}
				num = (short)623968256;
				short num3 = num;
				this.phnWideDTMFCodesDeaccess_A7803.HiddenStatic = value;
			}
		}

		// Token: 0x170049CF RID: 18895
		// (get) Token: 0x06009254 RID: 37460 RVA: 0x0089E754 File Offset: 0x0089C954
		// (set) Token: 0x06009255 RID: 37461 RVA: 0x0089E808 File Offset: 0x0089CA08
		internal bool PhnWideDTMFCodesDeaccess_A7803_HiddenDynamic
		{
			get
			{
				short num = (short)1885191497;
				short num2 = num;
				num = (short)857521481;
				switch (num2 == num)
				{
				}
				num = (short)407502848;
				if (num != 0)
				{
				}
				num = (short)2118451201;
				if (num != 0)
				{
				}
				num = (short)186318848;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803.HiddenDynamic;
			}
			set
			{
				short num = (short)815809709;
				short num2 = num;
				num = (short)2026194093;
				switch (num2 == num)
				{
				}
				num = (short)1892155393;
				if (num != 0)
				{
				}
				num = (short)1143930880;
				if (num != 0)
				{
				}
				num = (short)721420288;
				short num3 = num;
				this.phnWideDTMFCodesDeaccess_A7803.HiddenDynamic = value;
			}
		}

		// Token: 0x170049D0 RID: 18896
		// (get) Token: 0x06009256 RID: 37462 RVA: 0x0089E8C0 File Offset: 0x0089CAC0
		public bool PhnWideDTMFCodesDeaccess_A7803_HasDiffs
		{
			get
			{
				short num = (short)1530246402;
				short num2 = num;
				num = (short)1078048002;
				switch (num2 == num)
				{
				}
				num = (short)928972801;
				if (num != 0)
				{
				}
				num = (short)1723531264;
				if (num != 0)
				{
				}
				num = (short)1768882176;
				short num3 = num;
				return this.phnWideDTMFCodesDeaccess_A7803._HasDiffs;
			}
		}

		// Token: 0x170049D1 RID: 18897
		// (get) Token: 0x06009257 RID: 37463 RVA: 0x0089E974 File Offset: 0x0089CB74
		// (set) Token: 0x06009258 RID: 37464 RVA: 0x0089EA28 File Offset: 0x0089CC28
		public string PhnWideDTMFCodesKeyofDTMFCodesTable_A12800Value
		{
			get
			{
				short num = (short)1965378986;
				short num2 = num;
				num = (short)2101366186;
				switch (num2 == num)
				{
				}
				num = (short)321388545;
				if (num != 0)
				{
				}
				num = (short)1456340992;
				if (num != 0)
				{
				}
				num = (short)162725888;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Value;
			}
			set
			{
				short num = (short)476643329;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)767819777;
						if (num != 0)
						{
						}
						num = (short)162201600;
						short num3 = num;
						num = (short)2031233371;
						short num4 = num;
						num = (short)1720658267;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)777191424;
							if (num != 0)
							{
							}
							this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Value = value;
							num = (short)733544450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						return;
					}
					IL_31:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)750845952;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170049D2 RID: 18898
		// (get) Token: 0x06009259 RID: 37465 RVA: 0x0089EB4C File Offset: 0x0089CD4C
		// (set) Token: 0x0600925A RID: 37466 RVA: 0x0089EC04 File Offset: 0x0089CE04
		public string PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_UIValue
		{
			get
			{
				short num = (short)1878361972;
				short num2 = num;
				num = (short)483034996;
				switch (num2 == num)
				{
				}
				num = (short)1491861505;
				if (num != 0)
				{
				}
				num = (short)1101398016;
				if (num != 0)
				{
				}
				num = (short)1066270720;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Value;
			}
			set
			{
				short num = (short)151642734;
				short num2 = num;
				num = (short)957801070;
				switch (num2 == num)
				{
				}
				num = (short)621281281;
				if (num != 0)
				{
				}
				num = (short)735903744;
				if (num != 0)
				{
				}
				num = (short)410451968;
				short num3 = num;
				this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Value = value;
			}
		}

		// Token: 0x170049D3 RID: 18899
		// (get) Token: 0x0600925B RID: 37467 RVA: 0x0089ECBC File Offset: 0x0089CEBC
		public global::AcpBusinessLayer.AcpKeyField PhnWideDTMFCodesKeyofDTMFCodesTable_A12800
		{
			get
			{
				short num = (short)1116066490;
				short num2 = num;
				num = (short)566088378;
				switch (num2 == num)
				{
				}
				num = (short)807927809;
				if (num != 0)
				{
				}
				num = (short)1480982528;
				if (num != 0)
				{
				}
				num = (short)670171136;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800;
			}
		}

		// Token: 0x170049D4 RID: 18900
		// (get) Token: 0x0600925C RID: 37468 RVA: 0x0089ED6C File Offset: 0x0089CF6C
		// (set) Token: 0x0600925D RID: 37469 RVA: 0x0089EE20 File Offset: 0x0089D020
		public bool PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_Applicable
		{
			get
			{
				short num = (short)764560618;
				short num2 = num;
				num = (short)1658143978;
				switch (num2 == num)
				{
				}
				num = (short)235339777;
				if (num != 0)
				{
				}
				num = (short)270598144;
				if (num != 0)
				{
				}
				num = (short)1344143360;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Applicable;
			}
			set
			{
				short num = (short)691477708;
				short num2 = num;
				num = (short)1341988044;
				switch (num2 == num)
				{
				}
				num = (short)1310654465;
				if (num != 0)
				{
				}
				num = (short)333971456;
				if (num != 0)
				{
				}
				num = (short)2057240576;
				short num3 = num;
				this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Applicable = value;
			}
		}

		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x0600925E RID: 37470 RVA: 0x0089EED4 File Offset: 0x0089D0D4
		// (set) Token: 0x0600925F RID: 37471 RVA: 0x0089EF8C File Offset: 0x0089D18C
		public bool PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_Valid
		{
			get
			{
				short num = (short)228316460;
				short num2 = num;
				num = (short)161010988;
				switch (num2 == num)
				{
				}
				num = (short)1429733377;
				if (num != 0)
				{
				}
				num = (short)1832386560;
				if (num != 0)
				{
				}
				num = (short)1521156096;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Valid;
			}
			set
			{
				short num = (short)1950230727;
				short num2 = num;
				num = (short)1816602823;
				switch (num2 == num)
				{
				}
				num = (short)1253441537;
				if (num != 0)
				{
				}
				num = (short)545849344;
				if (num != 0)
				{
				}
				num = (short)416350208;
				short num3 = num;
				this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Valid = value;
			}
		}

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x06009260 RID: 37472 RVA: 0x0089F044 File Offset: 0x0089D244
		// (set) Token: 0x06009261 RID: 37473 RVA: 0x0089F0FC File Offset: 0x0089D2FC
		public bool PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_Visible
		{
			get
			{
				short num = (short)1707202437;
				short num2 = num;
				num = (short)545380229;
				switch (num2 == num)
				{
				}
				num = (short)1228931073;
				if (num != 0)
				{
				}
				num = (short)1809776640;
				if (num != 0)
				{
				}
				num = (short)740098048;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Visible;
			}
			set
			{
				short num = (short)1957691393;
				if (num != 0)
				{
				}
				num = (short)853290258;
				short num2 = num;
				num = (short)1182674194;
				switch (num2 == num)
				{
				}
				num = (short)1961099264;
				if (num != 0)
				{
				}
				num = (short)9699328;
				short num3 = num;
				this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Visible = value;
			}
		}

		// Token: 0x170049D7 RID: 18903
		// (get) Token: 0x06009262 RID: 37474 RVA: 0x0089F1B0 File Offset: 0x0089D3B0
		// (set) Token: 0x06009263 RID: 37475 RVA: 0x0089F264 File Offset: 0x0089D464
		public bool PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_Editable
		{
			get
			{
				short num = (short)472305248;
				short num2 = num;
				num = (short)1093652064;
				switch (num2 == num)
				{
				}
				num = (short)2138767361;
				if (num != 0)
				{
				}
				num = (short)1217593344;
				if (num != 0)
				{
				}
				num = (short)508231680;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Editable;
			}
			set
			{
				short num = (short)150240079;
				short num2 = num;
				num = (short)1600289615;
				switch (num2 == num)
				{
				}
				num = (short)774766593;
				if (num != 0)
				{
				}
				num = (short)214302720;
				if (num != 0)
				{
				}
				num = (short)203948032;
				short num3 = num;
				this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.Editable = value;
			}
		}

		// Token: 0x170049D8 RID: 18904
		// (get) Token: 0x06009264 RID: 37476 RVA: 0x0089F31C File Offset: 0x0089D51C
		internal string PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_UILabel
		{
			get
			{
				short num = (short)2015909666;
				short num2 = num;
				num = (short)1102141218;
				switch (num2 == num)
				{
				}
				num = (short)1679622145;
				if (num != 0)
				{
				}
				num = (short)324534272;
				if (num != 0)
				{
				}
				num = (short)641204224;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.UIName;
			}
		}

		// Token: 0x170049D9 RID: 18905
		// (get) Token: 0x06009265 RID: 37477 RVA: 0x0089F3D0 File Offset: 0x0089D5D0
		// (set) Token: 0x06009266 RID: 37478 RVA: 0x0089F488 File Offset: 0x0089D688
		internal bool PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_HiddenStatic
		{
			get
			{
				short num = (short)1705830538;
				short num2 = num;
				num = (short)1894574218;
				switch (num2 == num)
				{
				}
				num = (short)1063911424;
				if (num != 0)
				{
				}
				num = (short)908591105;
				if (num != 0)
				{
				}
				num = (short)1636630528;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.HiddenStatic;
			}
			set
			{
				short num = (short)401148689;
				short num2 = num;
				num = (short)943590161;
				switch (num2 == num)
				{
				}
				num = (short)1591476224;
				if (num != 0)
				{
				}
				num = (short)1928331265;
				if (num != 0)
				{
				}
				num = (short)1512177664;
				short num3 = num;
				this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.HiddenStatic = value;
			}
		}

		// Token: 0x170049DA RID: 18906
		// (get) Token: 0x06009267 RID: 37479 RVA: 0x0089F540 File Offset: 0x0089D740
		// (set) Token: 0x06009268 RID: 37480 RVA: 0x0089F5F4 File Offset: 0x0089D7F4
		internal bool PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_HiddenDynamic
		{
			get
			{
				short num = (short)68087085;
				short num2 = num;
				num = (short)706342189;
				switch (num2 == num)
				{
				}
				num = (short)370343937;
				if (num != 0)
				{
				}
				num = (short)316997632;
				if (num != 0)
				{
				}
				num = (short)154861568;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.HiddenDynamic;
			}
			set
			{
				short num = (short)624592396;
				short num2 = num;
				num = (short)505972236;
				switch (num2 == num)
				{
				}
				num = (short)1621032960;
				if (num != 0)
				{
				}
				num = (short)1740374017;
				if (num != 0)
				{
				}
				num = (short)165281792;
				short num3 = num;
				this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800.HiddenDynamic = value;
			}
		}

		// Token: 0x170049DB RID: 18907
		// (get) Token: 0x06009269 RID: 37481 RVA: 0x0089F6A8 File Offset: 0x0089D8A8
		public bool PhnWideDTMFCodesKeyofDTMFCodesTable_A12800_HasDiffs
		{
			get
			{
				short num = (short)1569972550;
				short num2 = num;
				num = (short)1363403078;
				switch (num2 == num)
				{
				}
				num = (short)1128071169;
				if (num != 0)
				{
				}
				num = (short)1041235968;
				if (num != 0)
				{
				}
				num = (short)1562050560;
				short num3 = num;
				return this.phnWideDTMFCodesKeyofDTMFCodesTable_A12800._HasDiffs;
			}
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x0089F75C File Offset: 0x0089D95C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1130787752;
					short num3 = num2;
					num2 = (short)2059367336;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1955004417;
						if (num2 != 0)
						{
						}
						num2 = (short)802684928;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						break;
					}
					num2 = (short)403701762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)719388675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_141;
				case 2:
					goto IL_FD;
				case 3:
					num2 = (short)574160900;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1834876928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_141;
				}
				goto IL_24;
			}
			IL_FD:
			IL_141:
			num2 = (short)876740608;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)2134966273;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400489F RID: 18591
		private global::AcpBusinessLayer.AcpFieldX<string, string> phnWideDTMFCodesAccess_A7381;

		// Token: 0x040048A0 RID: 18592
		private global::AcpBusinessLayer.AcpFieldX<string, string> phnWideDTMFCodesDeaccess_A7803;

		// Token: 0x040048A1 RID: 18593
		private global::AcpBusinessLayer.AcpKeyField phnWideDTMFCodesKeyofDTMFCodesTable_A12800;
	}
}
