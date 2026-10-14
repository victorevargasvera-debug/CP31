using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000338 RID: 824
	[global::System.Serializable]
	public class DirectMessageListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007F11 RID: 32529 RVA: 0x007500E8 File Offset: 0x0074E2E8
		public DirectMessageListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x00750104 File Offset: 0x0074E304
		protected DirectMessageListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007F13 RID: 32531 RVA: 0x0075011C File Offset: 0x0074E31C
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1882988312;
			short num2 = num;
			num = (short)1068113688;
			switch (num2 == num)
			{
			}
			num = (short)753270784;
			short num3 = num;
			num = (short)2055929857;
			if (num != 0)
			{
			}
			num = (short)530710528;
			if (num != 0)
			{
			}
			this.dEKDirectMessageBCOKey_A21292 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("諍闏駑郓뿕꫗뿙뿛ꫝ귟蟡韣闥觧跩觫곭돯뷱뿳鏵臷ꗹ뷻쳽ㇿ、㴃㐅", a_), global::CommonResources.AcgResources.ID_DIRECTMESSAGEBCOKEY);
			this.dEKDirectMessageBCOKey_A21292.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKDirectMessageBCO_A8506 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKDirectMessageBCO_A8506LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKDirectMessageBCO_A8506LovStrs), this, global::AllFeatures.CodeplugGuid.b("諍闏駑郓뿕꫗뿙뿛ꫝ귟蟡韣闥觧跩觫곭돯뷱꯳럵샷쿹쳻죽", a_), global::CommonResources.AcgResources.ID_DIRECTMESSAGEBCO, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKDirectMessageBCO_A8506LovStrs);
			this.dEKDirectMessageBCO_A8506.IgnoreOnCompare = true;
			this.dEKDirectMessageBCO_A8506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKDirectMessageBCO_A8506.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("諍맏ꃑ뇓뗕곗龎釛믝鏟釡藣臥跧쫩ꃫ蟭華蛱", a_);
			base.Id = 10236;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMESSAGELIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007F14 RID: 32532 RVA: 0x00750288 File Offset: 0x0074E488
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)404946953;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1473938368;
					short num3 = num;
					num = (short)658080704;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D2;
					default:
						num = (short)193462272;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)1240268801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29F;
					}
					break;
				}
				case 1:
					num = (short)1825570824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_229;
				case 3:
					num = (short)509804544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.dEKDirectMessageBCO_A8506 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKDirectMessageBCO_A8506LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKDirectMessageBCO_A8506LovStrs), this, global::AllFeatures.CodeplugGuid.b("資迉蟋諍맏ꃑ뇓뗕곗韙맛귝鏟菡菣菥ꫧꧩꏫ뇭뇯쫱쇳웵컷", a_), global::CommonResources.AcgResources.ID_DIRECTMESSAGEBCO, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKDirectMessageBCO_A8506LovStrs);
					this.dEKDirectMessageBCO_A8506.IgnoreOnCompare = true;
					this.dEKDirectMessageBCO_A8506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKDirectMessageBCO_A8506.DataTransferOrder = -1;
					num = (short)1333854210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1295253504;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資迉蟋諍맏ꃑ뇓뗕곗韙맛귝鏟菡菣菥ꫧꧩꏫ뇭뇯쫱쇳웵컷", a_)))
					{
						goto IL_D2;
					}
					goto IL_29F;
				}
				case 6:
					this.dEKDirectMessageBCOKey_A21292 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("資迉蟋諍맏ꃑ뇓뗕곗韙맛귝鏟菡菣菥ꫧꧩꏫꗭ闯诱꯳럵쫷쯹컻쟽㋿", a_), global::CommonResources.AcgResources.ID_DIRECTMESSAGEBCOKEY);
					this.dEKDirectMessageBCOKey_A21292.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					num = (short)1744961543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_7B;
				case 8:
					num = (short)2080309249;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("資迉蟋諍맏ꃑ뇓뗕곗韙맛귝鏟菡菣菥ꫧꧩꏫꗭ闯诱꯳럵쫷쯹컻쟽㋿", a_)))
					{
						num = (short)1866661894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)57278467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7B:
				num = (short)1315241989;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D2:
				num = (short)1976238084;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_229:
			IL_29F:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("資ꏉ뻋ꯍ돏ꛑ鯕뷗꧙꿛뿝蟟蟡쓣ꫥ臧駩飫", a_);
			base.Id = 10236;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMESSAGELIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x00750568 File Offset: 0x0074E768
		public override void PopulateReferences()
		{
			short num = (short)599414673;
			short num2 = num;
			num = (short)608720785;
			switch (num2 == num)
			{
			}
			num = (short)1216544768;
			short num3 = num;
			num = (short)40697857;
			if (num != 0)
			{
			}
			num = (short)1891500032;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007F16 RID: 32534 RVA: 0x00750614 File Offset: 0x0074E814
		public override void DropReferences()
		{
			short num = (short)810166991;
			short num2 = num;
			num = (short)641870543;
			switch (num2 == num)
			{
			}
			num = (short)1246953472;
			short num3 = num;
			num = (short)1258356737;
			if (num != 0)
			{
			}
			num = (short)930545664;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007F17 RID: 32535 RVA: 0x007506BC File Offset: 0x0074E8BC
		public override void SetConstraints()
		{
			short num = (short)1709374613;
			short num2 = num;
			num = (short)348978325;
			switch (num2 == num)
			{
			}
			num = (short)1542586368;
			short num3 = num;
			num = (short)1410793472;
			if (num != 0)
			{
			}
			num = (short)95223809;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007F18 RID: 32536 RVA: 0x00750768 File Offset: 0x0074E968
		public override void SetupDependencies()
		{
			short num = (short)235083515;
			short num2 = num;
			num = (short)1613043451;
			switch (num2 == num)
			{
			}
			num = (short)1697382400;
			short num3 = num;
			num = (short)1064370177;
			if (num != 0)
			{
			}
			num = (short)591659008;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004108 RID: 16648
		// (get) Token: 0x06007F19 RID: 32537 RVA: 0x00750814 File Offset: 0x0074EA14
		public bool HasDiffs
		{
			get
			{
				short num = (short)1499513101;
				short num2 = num;
				num = (short)1745797389;
				switch (num2 == num)
				{
				}
				num = (short)198311936;
				short num3 = num;
				num = (short)937820161;
				if (num != 0)
				{
				}
				num = (short)417988608;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004109 RID: 16649
		// (get) Token: 0x06007F1A RID: 32538 RVA: 0x007508C4 File Offset: 0x0074EAC4
		// (set) Token: 0x06007F1B RID: 32539 RVA: 0x00750978 File Offset: 0x0074EB78
		public string DEKDirectMessageBCOKey_A21292Value
		{
			get
			{
				short num = (short)1683450906;
				short num2 = num;
				num = (short)1293380634;
				switch (num2 == num)
				{
				}
				num = (short)1021902848;
				short num3 = num;
				num = (short)1642528769;
				if (num != 0)
				{
				}
				num = (short)1362755584;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.Value;
			}
			set
			{
				short num = (short)1435435010;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)2053142541;
						short num3 = num;
						num = (short)84113421;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)985661440;
							short num4 = num;
							num = (short)1972371456;
							if (num != 0)
							{
							}
							break;
						}
						}
						this.dEKDirectMessageBCOKey_A21292.Value = value;
						num = (short)1067253760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)841351169;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1462173697;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700410A RID: 16650
		// (get) Token: 0x06007F1C RID: 32540 RVA: 0x00750A9C File Offset: 0x0074EC9C
		// (set) Token: 0x06007F1D RID: 32541 RVA: 0x00750B50 File Offset: 0x0074ED50
		public string DEKDirectMessageBCOKey_A21292_UIValue
		{
			get
			{
				short num = (short)1627404777;
				short num2 = num;
				num = (short)293878249;
				switch (num2 == num)
				{
				}
				num = (short)1009975296;
				short num3 = num;
				num = (short)1586823168;
				if (num != 0)
				{
				}
				num = (short)995819521;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.Value;
			}
			set
			{
				short num = (short)2123793306;
				short num2 = num;
				num = (short)890995610;
				switch (num2 == num)
				{
				}
				num = (short)1462239232;
				short num3 = num;
				num = (short)1781071872;
				if (num != 0)
				{
				}
				num = (short)1222508545;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCOKey_A21292.Value = value;
			}
		}

		// Token: 0x1700410B RID: 16651
		// (get) Token: 0x06007F1E RID: 32542 RVA: 0x00750C04 File Offset: 0x0074EE04
		public global::AcpBusinessLayer.AcpKeyField DEKDirectMessageBCOKey_A21292
		{
			get
			{
				short num = (short)953745409;
				if (num != 0)
				{
				}
				num = (short)1545482607;
				short num2 = num;
				num = (short)1410412911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1713176576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625278976;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292;
			}
		}

		// Token: 0x1700410C RID: 16652
		// (get) Token: 0x06007F1F RID: 32543 RVA: 0x00750CB8 File Offset: 0x0074EEB8
		// (set) Token: 0x06007F20 RID: 32544 RVA: 0x00750D70 File Offset: 0x0074EF70
		public bool DEKDirectMessageBCOKey_A21292_Applicable
		{
			get
			{
				short num = (short)46692310;
				short num2 = num;
				num = (short)288847830;
				switch (num2 == num)
				{
				}
				num = (short)2049703936;
				short num3 = num;
				num = (short)1839529985;
				if (num != 0)
				{
				}
				num = (short)711983104;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.Applicable;
			}
			set
			{
				short num = (short)182386689;
				if (num != 0)
				{
				}
				num = (short)349492870;
				short num2 = num;
				num = (short)703059590;
				switch (num2 == num)
				{
				default:
				{
					num = (short)867237888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1296695296;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCOKey_A21292.Applicable = value;
			}
		}

		// Token: 0x1700410D RID: 16653
		// (get) Token: 0x06007F21 RID: 32545 RVA: 0x00750E24 File Offset: 0x0074F024
		// (set) Token: 0x06007F22 RID: 32546 RVA: 0x00750ED8 File Offset: 0x0074F0D8
		public bool DEKDirectMessageBCOKey_A21292_Valid
		{
			get
			{
				short num = (short)1578053511;
				short num2 = num;
				num = (short)493105031;
				switch (num2 == num)
				{
				}
				num = (short)755302400;
				short num3 = num;
				num = (short)1453195264;
				if (num != 0)
				{
				}
				num = (short)616169473;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.Valid;
			}
			set
			{
				short num = (short)343296544;
				short num2 = num;
				num = (short)1511016992;
				switch (num2 == num)
				{
				}
				num = (short)593756160;
				short num3 = num;
				num = (short)219807745;
				if (num != 0)
				{
				}
				num = (short)334692352;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCOKey_A21292.Valid = value;
			}
		}

		// Token: 0x1700410E RID: 16654
		// (get) Token: 0x06007F23 RID: 32547 RVA: 0x00750F8C File Offset: 0x0074F18C
		// (set) Token: 0x06007F24 RID: 32548 RVA: 0x00751040 File Offset: 0x0074F240
		public bool DEKDirectMessageBCOKey_A21292_Visible
		{
			get
			{
				short num = (short)419734947;
				short num2 = num;
				num = (short)761701795;
				switch (num2 == num)
				{
				}
				num = (short)1829175296;
				short num3 = num;
				num = (short)470745089;
				if (num != 0)
				{
				}
				num = (short)275251200;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.Visible;
			}
			set
			{
				short num = (short)1664771011;
				short num2 = num;
				num = (short)639722435;
				switch (num2 == num)
				{
				}
				num = (short)1974730752;
				short num3 = num;
				num = (short)1248657409;
				if (num != 0)
				{
				}
				num = (short)1658912768;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCOKey_A21292.Visible = value;
			}
		}

		// Token: 0x1700410F RID: 16655
		// (get) Token: 0x06007F25 RID: 32549 RVA: 0x007510F4 File Offset: 0x0074F2F4
		// (set) Token: 0x06007F26 RID: 32550 RVA: 0x007511A8 File Offset: 0x0074F3A8
		public bool DEKDirectMessageBCOKey_A21292_Editable
		{
			get
			{
				short num = (short)1764099244;
				short num2 = num;
				num = (short)1600455852;
				switch (num2 == num)
				{
				}
				num = (short)452722688;
				short num3 = num;
				num = (short)1308819457;
				if (num != 0)
				{
				}
				num = (short)1562705920;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.Editable;
			}
			set
			{
				short num = (short)63483871;
				short num2 = num;
				num = (short)2122428383;
				switch (num2 == num)
				{
				}
				num = (short)149880832;
				short num3 = num;
				num = (short)700121089;
				if (num != 0)
				{
				}
				num = (short)2023358464;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCOKey_A21292.Editable = value;
			}
		}

		// Token: 0x17004110 RID: 16656
		// (get) Token: 0x06007F27 RID: 32551 RVA: 0x0075125C File Offset: 0x0074F45C
		internal string DEKDirectMessageBCOKey_A21292_UILabel
		{
			get
			{
				short num = (short)1070326669;
				short num2 = num;
				num = (short)468706189;
				switch (num2 == num)
				{
				}
				num = (short)1813839872;
				short num3 = num;
				num = (short)515506177;
				if (num != 0)
				{
				}
				num = (short)1672478720;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.UIName;
			}
		}

		// Token: 0x17004111 RID: 16657
		// (get) Token: 0x06007F28 RID: 32552 RVA: 0x00751310 File Offset: 0x0074F510
		// (set) Token: 0x06007F29 RID: 32553 RVA: 0x007513C4 File Offset: 0x0074F5C4
		internal bool DEKDirectMessageBCOKey_A21292_HiddenStatic
		{
			get
			{
				short num = (short)1212414147;
				short num2 = num;
				num = (short)1315698883;
				switch (num2 == num)
				{
				}
				num = (short)1864892416;
				if (num != 0)
				{
				}
				num = (short)2114781184;
				short num3 = num;
				num = (short)442302465;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.HiddenStatic;
			}
			set
			{
				short num = (short)325189633;
				if (num != 0)
				{
				}
				num = (short)369216459;
				short num2 = num;
				num = (short)1995623371;
				switch (num2 == num)
				{
				}
				num = (short)975634432;
				short num3 = num;
				num = (short)1403322368;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCOKey_A21292.HiddenStatic = value;
			}
		}

		// Token: 0x17004112 RID: 16658
		// (get) Token: 0x06007F2A RID: 32554 RVA: 0x0075147C File Offset: 0x0074F67C
		// (set) Token: 0x06007F2B RID: 32555 RVA: 0x00751530 File Offset: 0x0074F730
		internal bool DEKDirectMessageBCOKey_A21292_HiddenDynamic
		{
			get
			{
				short num = (short)1775891484;
				short num2 = num;
				num = (short)430830620;
				switch (num2 == num)
				{
				}
				num = (short)312147969;
				if (num != 0)
				{
				}
				num = (short)1588658176;
				short num3 = num;
				num = (short)431489024;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292.HiddenDynamic;
			}
			set
			{
				short num = (short)33337600;
				short num2 = num;
				num = (short)147960064;
				switch (num2 == num)
				{
				}
				num = (short)773324801;
				if (num != 0)
				{
				}
				num = (short)703070208;
				short num3 = num;
				num = (short)1952514048;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCOKey_A21292.HiddenDynamic = value;
			}
		}

		// Token: 0x17004113 RID: 16659
		// (get) Token: 0x06007F2C RID: 32556 RVA: 0x007515E8 File Offset: 0x0074F7E8
		public bool DEKDirectMessageBCOKey_A21292_HasDiffs
		{
			get
			{
				short num = (short)680509593;
				short num2 = num;
				num = (short)174178457;
				switch (num2 == num)
				{
				}
				num = (short)1078853633;
				if (num != 0)
				{
				}
				num = (short)924450816;
				short num3 = num;
				num = (short)809566208;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCOKey_A21292._HasDiffs;
			}
		}

		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x06007F2D RID: 32557 RVA: 0x007516A0 File Offset: 0x0074F8A0
		// (set) Token: 0x06007F2E RID: 32558 RVA: 0x00751754 File Offset: 0x0074F954
		public int DEKDirectMessageBCO_A8506Value
		{
			get
			{
				short num = (short)1246652495;
				short num2 = num;
				num = (short)889022543;
				switch (num2 == num)
				{
				}
				num = (short)928317440;
				if (num != 0)
				{
				}
				num = (short)1235222528;
				short num3 = num;
				num = (short)1417478145;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.Value;
			}
			set
			{
				short num = (short)1256914945;
				if (num != 0)
				{
				}
				num = (short)893780054;
				short num2 = num;
				num = (short)405798998;
				switch (num2 == num)
				{
				}
				num = (short)1103233024;
				short num3 = num;
				num = (short)240648192;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCO_A8506.Value = value;
			}
		}

		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x06007F2F RID: 32559 RVA: 0x0075180C File Offset: 0x0074FA0C
		// (set) Token: 0x06007F30 RID: 32560 RVA: 0x007518C0 File Offset: 0x0074FAC0
		public string DEKDirectMessageBCO_A8506_UIValue
		{
			get
			{
				short num = (short)1515512665;
				short num2 = num;
				num = (short)75424601;
				switch (num2 == num)
				{
				}
				num = (short)467140609;
				if (num != 0)
				{
				}
				num = (short)521535488;
				short num3 = num;
				num = (short)328794112;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.UIValue;
			}
			set
			{
				short num = (short)279510512;
				short num2 = num;
				num = (short)34209264;
				switch (num2 == num)
				{
				}
				num = (short)630325249;
				if (num != 0)
				{
				}
				num = (short)1824587776;
				short num3 = num;
				num = (short)1547239424;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCO_A8506.UIValue = value;
			}
		}

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x06007F31 RID: 32561 RVA: 0x00751974 File Offset: 0x0074FB74
		public global::AcpBusinessLayer.AcpListField DEKDirectMessageBCO_A8506
		{
			get
			{
				short num = (short)1495176139;
				short num2 = num;
				num = (short)1463456715;
				switch (num2 == num)
				{
				}
				num = (short)878247937;
				if (num != 0)
				{
				}
				num = (short)324337664;
				short num3 = num;
				num = (short)755826688;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506;
			}
		}

		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x06007F32 RID: 32562 RVA: 0x00751A24 File Offset: 0x0074FC24
		// (set) Token: 0x06007F33 RID: 32563 RVA: 0x00751AD8 File Offset: 0x0074FCD8
		public bool DEKDirectMessageBCO_A8506_Applicable
		{
			get
			{
				short num = (short)1724403077;
				short num2 = num;
				num = (short)170085765;
				switch (num2 == num)
				{
				}
				num = (short)676528128;
				if (num != 0)
				{
				}
				num = (short)2036793344;
				short num3 = num;
				num = (short)1442119681;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.Applicable;
			}
			set
			{
				short num = (short)1862194776;
				short num2 = num;
				num = (short)1524225624;
				switch (num2 == num)
				{
				}
				num = (short)29032449;
				if (num != 0)
				{
				}
				num = (short)179568640;
				short num3 = num;
				num = (short)1542455296;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCO_A8506.Applicable = value;
			}
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x06007F34 RID: 32564 RVA: 0x00751B90 File Offset: 0x0074FD90
		// (set) Token: 0x06007F35 RID: 32565 RVA: 0x00751C48 File Offset: 0x0074FE48
		public bool DEKDirectMessageBCO_A8506_Valid
		{
			get
			{
				short num = (short)919621123;
				short num2 = num;
				num = (short)83643907;
				switch (num2 == num)
				{
				}
				num = (short)958726144;
				if (num != 0)
				{
				}
				num = (short)1134231552;
				short num3 = num;
				num = (short)809828353;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.Valid;
			}
			set
			{
				short num = (short)1032912897;
				if (num != 0)
				{
				}
				num = (short)1940929492;
				short num2 = num;
				num = (short)472136660;
				switch (num2 == num)
				{
				}
				num = (short)1271070720;
				short num3 = num;
				num = (short)428933120;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCO_A8506.Valid = value;
			}
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x06007F36 RID: 32566 RVA: 0x00751CFC File Offset: 0x0074FEFC
		// (set) Token: 0x06007F37 RID: 32567 RVA: 0x00751DB0 File Offset: 0x0074FFB0
		public bool DEKDirectMessageBCO_A8506_Visible
		{
			get
			{
				short num = (short)144532945;
				short num2 = num;
				num = (short)813655505;
				switch (num2 == num)
				{
				}
				num = (short)663224321;
				if (num != 0)
				{
				}
				num = (short)817823744;
				short num3 = num;
				num = (short)1325989888;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.Visible;
			}
			set
			{
				short num = (short)1455947777;
				if (num != 0)
				{
				}
				num = (short)130196831;
				short num2 = num;
				num = (short)661038431;
				switch (num2 == num)
				{
				}
				num = (short)359464960;
				short num3 = num;
				num = (short)613220352;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCO_A8506.Visible = value;
			}
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x06007F38 RID: 32568 RVA: 0x00751E68 File Offset: 0x00750068
		// (set) Token: 0x06007F39 RID: 32569 RVA: 0x00751F1C File Offset: 0x0075011C
		public bool DEKDirectMessageBCO_A8506_Editable
		{
			get
			{
				short num = (short)1988820993;
				if (num != 0)
				{
				}
				num = (short)1169408674;
				short num2 = num;
				num = (short)1514193570;
				switch (num2 == num)
				{
				}
				num = (short)166920192;
				short num3 = num;
				num = (short)1341128704;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.Editable;
			}
			set
			{
				short num = (short)486687133;
				short num2 = num;
				num = (short)2050245021;
				switch (num2 == num)
				{
				}
				num = (short)1369440256;
				if (num != 0)
				{
				}
				num = (short)1914306560;
				short num3 = num;
				num = (short)1502281729;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCO_A8506.Editable = value;
			}
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x06007F3A RID: 32570 RVA: 0x00751FD0 File Offset: 0x007501D0
		internal string DEKDirectMessageBCO_A8506_UILabel
		{
			get
			{
				short num = (short)1840613535;
				short num2 = num;
				num = (short)2101315743;
				switch (num2 == num)
				{
				}
				num = (short)26804225;
				if (num != 0)
				{
				}
				num = (short)662896640;
				short num3 = num;
				num = (short)1386807296;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.UIName;
			}
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x06007F3B RID: 32571 RVA: 0x00752084 File Offset: 0x00750284
		// (set) Token: 0x06007F3C RID: 32572 RVA: 0x00752138 File Offset: 0x00750338
		internal bool DEKDirectMessageBCO_A8506_HiddenStatic
		{
			get
			{
				short num = (short)1168101255;
				short num2 = num;
				num = (short)2145636231;
				switch (num2 == num)
				{
				}
				num = (short)6946817;
				if (num != 0)
				{
				}
				num = (short)520290304;
				short num3 = num;
				num = (short)740032512;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.HiddenStatic;
			}
			set
			{
				short num = (short)812028659;
				short num2 = num;
				num = (short)1010340595;
				switch (num2 == num)
				{
				}
				num = (short)538116096;
				if (num != 0)
				{
				}
				num = (short)916717568;
				short num3 = num;
				num = (short)796852225;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCO_A8506.HiddenStatic = value;
			}
		}

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x06007F3D RID: 32573 RVA: 0x007521EC File Offset: 0x007503EC
		// (set) Token: 0x06007F3E RID: 32574 RVA: 0x007522A0 File Offset: 0x007504A0
		internal bool DEKDirectMessageBCO_A8506_HiddenDynamic
		{
			get
			{
				short num = (short)1751318529;
				if (num != 0)
				{
				}
				num = (short)1448615317;
				short num2 = num;
				num = (short)1027480981;
				switch (num2 == num)
				{
				}
				num = (short)1099366400;
				short num3 = num;
				num = (short)755105792;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506.HiddenDynamic;
			}
			set
			{
				short num = (short)1244266497;
				if (num != 0)
				{
				}
				num = (short)221327570;
				short num2 = num;
				num = (short)762982610;
				switch (num2 == num)
				{
				}
				num = (short)1806434304;
				short num3 = num;
				num = (short)590282752;
				if (num != 0)
				{
				}
				this.dEKDirectMessageBCO_A8506.HiddenDynamic = value;
			}
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x06007F3F RID: 32575 RVA: 0x00752354 File Offset: 0x00750554
		public bool DEKDirectMessageBCO_A8506_HasDiffs
		{
			get
			{
				short num = (short)981092346;
				short num2 = num;
				num = (short)157501434;
				switch (num2 == num)
				{
				}
				num = (short)1299316736;
				if (num != 0)
				{
				}
				num = (short)1006239744;
				short num3 = num;
				num = (short)1946550273;
				if (num != 0)
				{
				}
				return this.dEKDirectMessageBCO_A8506._HasDiffs;
			}
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x00752408 File Offset: 0x00750608
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
					while (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)870326173;
						short num3 = num2;
						num2 = (short)951656349;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num2 = (short)22216704;
							if (num2 != 0)
							{
							}
							num2 = (short)15728640;
							short num4 = num2;
							num2 = (short)1375141892;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
						}
					}
					return result;
				case 1:
					return result;
				case 2:
					num2 = (short)373030913;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)264241155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)134807552;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)403374081;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)2040135682;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040039A5 RID: 14757
		private global::AcpBusinessLayer.AcpKeyField dEKDirectMessageBCOKey_A21292;

		// Token: 0x040039A6 RID: 14758
		private global::AcpBusinessLayer.AcpListField dEKDirectMessageBCO_A8506;
	}
}
