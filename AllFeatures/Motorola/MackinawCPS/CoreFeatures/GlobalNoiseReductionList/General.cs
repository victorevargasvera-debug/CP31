using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList
{
	// Token: 0x02000259 RID: 601
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006B27 RID: 27431 RVA: 0x005FB1EC File Offset: 0x005F93EC
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06006B28 RID: 27432 RVA: 0x005FB208 File Offset: 0x005F9408
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006B29 RID: 27433 RVA: 0x005FB220 File Offset: 0x005F9420
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1145274832;
			short num2 = num;
			num = (short)755794384;
			switch (num2 == num)
			{
			}
			num = (short)1449000961;
			if (num != 0)
			{
			}
			num = (short)1991770112;
			if (num != 0)
			{
			}
			num = (short)1209729024;
			short num3 = num;
			this.dINCHOTBEAMHYSTERESIS_A21559 = new global::AcpBusinessLayer.AcpSimpleRangeField(50, this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋蛍鿏蛑雓鏕駗韙铛蟝돟뛡ꇣ듥귧맩ꗫ뷭꿯돱웳쟵췷쿹엻", a_), global::CommonResources.AcgResources.ID_DINCHOTBEAMHYSTERESIS, 0, 65535, null, null, 0, 1);
			this.dINCHOTBEAMHYSTERESIS_A21559.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dINCHOTBEAMHYSTERESIS_A21559.DataTransferOrder = 32;
			this.dINCHOTBEAMHYSTERESIS_A21559.ShowHexValue = true;
			this.dINCBADMICHYSTERESIS_A21560 = new global::AcpBusinessLayer.AcpSimpleRangeField(300, this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋賍量雑駓鿕鯗鋙藛距듟꟡뛣ꏥ믧ꏩ뿫뇭뇯샱엳쏵컷쫹", a_), global::CommonResources.AcgResources.ID_DINCBADMICHYSTERESIS, 0, 65535, null, null, 0, 1);
			this.dINCBADMICHYSTERESIS_A21560.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dINCBADMICHYSTERESIS_A21560.DataTransferOrder = 33;
			this.dINCBADMICHYSTERESIS_A21560.ShowHexValue = true;
			this.dINCSPATIALEQ1VECTORCONT_A37716 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_FFA80038FFD30000, this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋鷍胏鏑胓鿕駗雙駛违퇟듡ꇣꗥ볧ꗩ뻫귭뿯볱ꃳ꧵맷짹쯻짽ㇿ㐁", a_), global::CommonResources.AcgResources.ID_DINCSPATIALEQ1VECTORCONT, 16);
			this.dINCSPATIALEQ1VECTORCONT_A37716.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dINCSPATIALEQ1VECTORCONT_A37716.DataTransferOrder = -1;
			this.dINCSPATIALEQ2VECTORCONT_A37717 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("胅軇﷋ﻍ郓郕黗鳙탟틡퓣", a_), this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋鷍胏鏑胓鿕駗雙駛违틟듡ꇣꗥ볧ꗩ뻫귭뿯볱ꃳ꧵맷짹쯻짽ㇿ㔁", a_), global::CommonResources.AcgResources.ID_DINCSPATIALEQ2VECTORCONT, 16);
			this.dINCSPATIALEQ2VECTORCONT_A37717.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dINCSPATIALEQ2VECTORCONT_A37717.DataTransferOrder = -1;
			this.dINCELKOVECTOR_A21561 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("軇賉請留雏铑鋓黗鳙髛ꛟꓡꋣ퇥껧곩ꫫ\ud9ed뛯등닳쇵뻷볹뫻짽䛿䐁䈃ㄅ万䰉䨋㤍嘏向刓ℕ帗尙娛⤝星搡戣ᄥ渧氩樫᤭瘯琱爳ĵ縷簹稻ऽؿсɃ", a_), this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋词鳏駑鯓胕鷗駙裛針닟뷡ꗣ퓥\ud9e7\udfe9\udaeb\udfed", a_), global::CommonResources.AcgResources.ID_DINCELKOVECTOR, 64);
			this.dINCELKOVECTOR_A21561.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dINCELKOVECTOR_A21561.DataTransferOrder = 31;
			this.dINCOUTPUTEQVECTOR_A21558 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("軇賉請鏑韓駙\ud9df탡꟣헥퇧\ud8e9꿫\udded짯샱럳싵죷죹쫻쫽㟿䐁䔃㌅㠇䤉㼋㬍儏⬑倓⌕夗⌙堛⠝ᔟ挡朣ᄥဧ温ᨫ᤭瘯琱爳ĵ縷簹稻ऽؿсɃ煅็౉ੋ祍ᙏᑑቓ慕ṗ᱙ᩛ楝♟②≣入⹧Ⱪ⩫奭㙯㑱㉳䅵㹷㱹㩻䥽왿쒁슃놅캇첉쪋릍횏풑튓ꆕ\ude97\udc99\uda9bꦝ醥馭膵ﺷﲹ請", a_), this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋臍藏蛑蓓菕賗鿙跛裝ꗟꇡ냣ꧥ뫧뗩귫\udced쇯쟱쇳컵", a_), global::CommonResources.AcgResources.ID_DINCOUTPUTEQVECTOR, 124);
			this.dINCOUTPUTEQVECTOR_A21558.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dINCOUTPUTEQVECTOR_A21558.DataTransferOrder = 30;
			this.dINCBFEQVECTOR_A21557 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("難﯉鏑韓駗飛탟ꇡퟣ틥\udfe7곩귫\udaed샯샱싳엵쇷죹뿻췽㋿䐁㄃㐅䰇㰉䴋㰍⠏┑唓␕Ⱇ⬙⼛Ⱍဟအጣᐥᠧᠩᬫᰭ/1̳е࠷࠹଻ఽ瀿灁獃瑅硇硉筋籍恏恑捓摕桗桙歛汝偟偡卣呥塧塩孫屭䁯䁱䍳䑵䡷䡹䭻䱽끿낁뎃뒅뢇뢉뮋벍ꂏꂑꎓ꒕ꢗꢙꮛ겝邟邡鎣钥颧颩鮫鲭肯肱莳蒵袷袹讻", a_), this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋賍雏韑藓胕鷗駙裛針닟뷡ꗣ퓥\ud9e7\udfe9\ud9eb\ud9ed", a_), global::CommonResources.AcgResources.ID_DINCBFEQVECTOR, 124);
			this.dINCBFEQVECTOR_A21557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dINCBFEQVECTOR_A21557.DataTransferOrder = -1;
			this.dINCSPATIALEQ1VECTOR_A21553 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("資觉跋词量鳙髝ퟟꛡ꟣탥껧곩ꧫ귭쓯냱뛳샵짷뻹뻻볽㏿䘁㐃㌅㬇伉㠋伍┏匑Ⱃ┕帗⨙⨛✝戟ሡ愣ᐥ欧欩渫ᜭܯ瘱سܵķ缹഻ܽ砿煁畃癅ే獉籋睍቏ፑ慓ၕṗ汙浛杝⑟呡嵣⁥屧彩啫⽭䉯䩱䁳㍵佷䩹㥻㽽띿뚁늃슅춇뾉뒋첍ꆏꆑ햓튕꺗궙ꖛ\udc9d馟隡鞣鮧莯膳袷边趻ﶽ胁臃藅跇柳軋跍雏铑鋓闕黙鷛髝퓟틡꟣ꗥ\udde7틩꿫ꫭ뛯쫱냳뗵췷쿹쯻믽㣿㌁㜃䔅䤇㤉㐋䠍⌏⌑∓唕帗弙⨛堝ጟ搡愣戥ᨧᬩᴫ栭د焱̳爵࠷ഹ࠻砽甿煁畃Յେࡉ穋ࡍᕏፑᙓᕕṗ᱙橛湝噟卡╣≥偧屩屫彭䅯㑱㉳㍵䁷㭹䑻乽쑿쒁뎃쎅춇몉즋뺍ꞏꆑ톓펕\ude97ꎙꖛ\ud89d颟鞡颩螯蚱足", a_), this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋鷍胏鏑胓鿕駗雙駛违퇟듡ꇣꗥ볧ꗩ뻫뇭뇯샱엳쏵췷짹", a_), global::CommonResources.AcgResources.ID_DINCSPATIALEQ1VECTOR, 248);
			this.dINCSPATIALEQ1VECTOR_A21553.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dINCSPATIALEQ1VECTOR_A21553.DataTransferOrder = -1;
			this.dINCSPATIALEQ2VECTOR_A21556 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("資觉跋词量鳙髝ퟟꛡ꟣탥껧곩ꧫ귭쓯냱뛳샵짷뻹뻻볽㏿䘁㐃㌅㬇伉㠋伍┏匑Ⱃ┕帗⨙⨛✝戟ሡ愣ᐥ欧欩渫ᜭܯ瘱سܵķ缹഻ܽ砿煁畃癅ే獉籋睍቏ፑ慓ၕṗ汙浛杝⑟呡嵣⁥屧彩啫⽭䉯䩱䁳㍵佷䩹㥻㽽띿뚁늃슅춇뾉뒋첍ꆏꆑ햓튕꺗궙ꖛ\udc9d馟隡鞣鮧莯膳袷边趻ﶽ胁臃藅跇柳軋跍雏铑鋓闕黙鷛髝퓟틡꟣ꗥ\udde7틩꿫ꫭ뛯쫱냳뗵췷쿹쯻믽㣿㌁㜃䔅䤇㤉㐋䠍⌏⌑∓唕帗弙⨛堝ጟ搡愣戥ᨧᬩᴫ栭د焱̳爵࠷ഹ࠻砽甿煁畃Յେࡉ穋ࡍᕏፑᙓᕕṗ᱙橛湝噟卡╣≥偧屩屫彭䅯㑱㉳㍵䁷㭹䑻乽쑿쒁뎃쎅춇몉즋뺍ꞏꆑ톓펕\ude97ꎙꖛ\ud89d颟鞡颩螯蚱足", a_), this, global::AllFeatures.CodeplugGuid.b("苅臇蓉迋鷍胏鏑胓鿕駗雙駛违틟듡ꇣꗥ볧ꗩ뻫뇭뇯샱엳쏵췷쳹", a_), global::CommonResources.AcgResources.ID_DINCSPATIALEQ2VECTOR, 248);
			this.dINCSPATIALEQ2VECTOR_A21556.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.dINCSPATIALEQ2VECTOR_A21556.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅귇꓉꧋볍뇏뻑", a_);
			base.Id = 10240;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006B2A RID: 27434 RVA: 0x005FB594 File Offset: 0x005F9794
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)777584644;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)302055424;
					short num3 = num;
					this.dINCELKOVECTOR_A21561 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("臆迈跊頻觎韐闒釖鿘鷚駞꟠ꗢ틤ꇦ꿨귪\udaecꧮ런뗲싴뇶뿸뷺쫼맾䜀䔂㈄䄆伈䴊㨌䤎圐唒∔儖弘崚⨜夞朠攢ሤ愦漨洪ᨬ椮眰甲ȴ然缸紺਼社݀Ղ", a_), this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊裌菎髐鳒菔鋖高迚鋜跞뻠ꋢퟤ훦\udce8\uddea\udcec", a_), global::CommonResources.AcgResources.ID_DINCELKOVECTOR, 64);
					this.dINCELKOVECTOR_A21561.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dINCELKOVECTOR_A21561.DataTransferOrder = 31;
					num = (short)1438253068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					this.dINCSPATIALEQ2VECTORCONT_A37717 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("菄臆響﷌ￎ韒鏔釖鿘퇠폢", a_), this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊黌鿎郐蟒鳔雖闘黚賜럠ꛢꛤ돦ꛨ맪껬ꃮ뿰ꟲꫴ뛶쫸쳺쫼컾㘀", a_), global::CommonResources.AcgResources.ID_DINCSPATIALEQ2VECTORCONT, 16);
					this.dINCSPATIALEQ2VECTORCONT_A37717.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dINCSPATIALEQ2VECTORCONT_A37717.DataTransferOrder = -1;
					num = (short)1350434833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.dINCSPATIALEQ1VECTORCONT_A37716 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_FFA80038FFD30000, this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊黌鿎郐蟒鳔雖闘黚賜럠ꛢꛤ돦ꛨ맪껬ꃮ뿰ꟲꫴ뛶쫸쳺쫼컾㜀", a_), global::CommonResources.AcgResources.ID_DINCSPATIALEQ1VECTORCONT, 16);
					this.dINCSPATIALEQ1VECTORCONT_A37716.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dINCSPATIALEQ1VECTORCONT_A37716.DataTransferOrder = -1;
					num = (short)116064279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)2138308624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊黌鿎郐蟒鳔雖闘黚賜럠ꛢꛤ돦ꛨ맪달껮쏰싲샴싶쫸", a_)))
					{
						num = (short)2082471956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_338;
				case 6:
					this.dINCBADMICHYSTERESIS_A21560 = new global::AcpBusinessLayer.AcpSimpleRangeField(300, this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊迌軎闐黒鳔铖釘苚軜诞ꓠ뇢ꃤ듦ꃨ룪달껮쏰싲샴쇶째", a_), global::CommonResources.AcgResources.ID_DINCBADMICHYSTERESIS, null, null, 0, 1);
					this.dINCBADMICHYSTERESIS_A21560.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dINCBADMICHYSTERESIS_A21560.DataTransferOrder = 33;
					this.dINCBADMICHYSTERESIS_A21560.ShowHexValue = true;
					num = (short)1624178717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)751042561;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊迌軎闐黒鳔铖釘苚軜诞ꓠ뇢ꃤ듦ꃨ룪달껮쏰싲샴쇶째", a_)))
					{
						num = (short)1906311174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_59B;
				case 8:
					this.dINCOUTPUTEQVECTOR_A21558 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("臆迈跊﯌龜郐郒高폠ꃢ훤\udee6\udbe8꣪\udeec훮쏰냲쇴쟶쯸췺짼죾䜀䈂〄㜆䨈㠊㠌与⠐園—嘖‘弚⬜⨞怠怢ሤἦ洨ᴪᨬ椮眰甲ȴ然缸紺਼社݀Ղ牄ņ཈ൊ穌ॎᝐᕒ扔ᅖ὘ᵚ橜ᥞ❠╢剤Ⅶ⽨⵪婬⥮㝰㕲䉴ㅶ㽸㵺䩼㥾잀얂늄솆쾈춊몌즎힐햒ꊔ톖\udf98\udd9aꪜ\ud99e銤骬芴ﾸﶺ", a_), this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊苌髎藐菒胔菖鳘諚诜髞ꋠ럢ꫤ뗦뛨ꫪ\udfec\udeee쓰웲췴", a_), global::CommonResources.AcgResources.ID_DINCOUTPUTEQVECTOR, 124);
					this.dINCOUTPUTEQVECTOR_A21558.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dINCOUTPUTEQVECTOR_A21558.DataTransferOrder = 30;
					num = (short)1625292827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊黌鿎郐蟒鳔雖闘黚賜럠ꛢꛤ돦ꛨ맪껬ꃮ뿰ꟲꫴ뛶쫸쳺쫼컾㘀", a_)))
					{
						num = (short)1211432961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_387;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊苌髎藐菒胔菖鳘諚诜髞ꋠ럢ꫤ뗦뛨ꫪ\udfec\udeee쓰웲췴", a_)))
					{
						num = (short)1698889736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 11:
					goto IL_E9;
				case 12:
					goto IL_732;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊藌胎藐釒郔雖铘鏚蓜賞뗠ꛢ럤ꋦ뫨ꋪ뻬냮냰쇲쓴싶쳸싺", a_)))
					{
						num = (short)81788943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AB;
				case 14:
					goto IL_1AB;
				case 15:
				{
					num = (short)2086538000;
					short num4 = num;
					num = (short)868616976;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E9;
					default:
						num = (short)580780032;
						if (num != 0)
						{
						}
						this.dINCHOTBEAMHYSTERESIS_A21559 = new global::AcpBusinessLayer.AcpSimpleRangeField(50, this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊藌胎藐釒郔雖铘鏚蓜賞뗠ꛢ럤ꋦ뫨ꋪ뻬냮냰쇲쓴싶쳸싺", a_), global::CommonResources.AcgResources.ID_DINCHOTBEAMHYSTERESIS, null, null, 0, 1);
						this.dINCHOTBEAMHYSTERESIS_A21559.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
						this.dINCHOTBEAMHYSTERESIS_A21559.DataTransferOrder = 32;
						this.dINCHOTBEAMHYSTERESIS_A21559.ShowHexValue = true;
						num = (short)1793982478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					if (producerFields != null)
					{
						num = (short)454688794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E3;
				case 17:
					goto IL_387;
				case 18:
					goto IL_338;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊黌鿎郐蟒鳔雖闘黚賜럠ꛢꛤ돦ꛨ맪껬ꃮ뿰ꟲꫴ뛶쫸쳺쫼컾㜀", a_)))
					{
						num = (short)1354366978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_680;
				case 20:
					this.dINCSPATIALEQ1VECTOR_A21553 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("菆諈諊裌軎鿘駜ꗠꃢ폤ꇦ꿨껪껬\udbee돰뇲쏴웶뷸맺뿼쳾䔀㌂〄㐆䰈㼊䰌㨎倐⬒☔儖⤘ⴚ␜崞ᄠ昢ᜤ搦栨椪ᐬᠮ田Ĳдึ簸਺мܾ牀牂畄͆灈筊瑌ൎၐ晒ፔᅖ潘橚摜᭞坠婢⍤卦屨剪ⱬ嵮䥰䝲ぴ䁶䥸㹺㱼䡾떀떂솄슆번뎊쾌뺎ꊐ튒톔ꆖ꺘ꊚ\udf9cꚞ閠邢钦鲮蚲螶貸誺ﺼ螾菀蛂蛄苆靖觊軌觎韐闒雔鷘髚駜퇠ꃢꛤ틦퇨꣪ꧬꧮ짰럲뛴싶쳸쳺룼쟾\u3000。䘄䘆㨈㌊䬌㰎‐┒嘔儖尘ⴚ嬜Ⱎ朠昢愤ᔦᠨᨪ欬᤮爰в焴ุܶ༺笼ਾ牀牂لцୈ絊ୌ੎ၐᅒᙔᅖ὘浚浜楞偠≢Ⅴ彦彨孪屬幮㝰㕲ぴ佶㡸䍺䵼㭾잀뒂삄슆릈캊붌뢎ꊐ횒킔톖ꂘꊚ\udb9cꞞ钠鮨颮薰課", a_), this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊黌鿎郐蟒鳔雖闘黚賜럠ꛢꛤ돦ꛨ맪달껮쏰싲샴싶쫸", a_), global::CommonResources.AcgResources.ID_DINCSPATIALEQ1VECTOR, 248);
					this.dINCSPATIALEQ1VECTOR_A21553.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dINCSPATIALEQ1VECTOR_A21553.DataTransferOrder = -1;
					num = (short)1810038802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					this.dINCBFEQVECTOR_A21557 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ￊ﯌龜郐郒雖鿚ꋠ탢퇤탦꿨ꫪ\ud9ec\udfee쏰엲웴컶쯸룺컼췾䜀㘂㜄䌆㼈䨊㼌㜎☐划✔⌖⠘⠚⼜⼞ጠᐢᜤᜦᬨᰪἬἮ̰вܴܶସ఺༼༾獀瑂睄睆筈籊罌罎捐摒杔杖歘汚潜潞占呢坤坦孨屪彬彮䍰䑲䝴䝶䭸䱺佼佾뎀뒂랄랆뮈벊뾌뾎ꎐ꒒ꞔꞖꮘ겚꾜꾞鎠钢鞤鞦鮨鲪龬龮莰蒲螴螶许貺", a_), this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊迌觎铐苒菔鋖高迚鋜跞뻠ꋢퟤ훦\udce8\udeea\udaec", a_), global::CommonResources.AcgResources.ID_DINCBFEQVECTOR, 124);
					this.dINCBFEQVECTOR_A21557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dINCBFEQVECTOR_A21557.DataTransferOrder = -1;
					num = (short)1184104476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					this.dINCSPATIALEQ2VECTOR_A21556 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("菆諈諊裌軎鿘駜ꗠꃢ폤ꇦ꿨껪껬\udbee돰뇲쏴웶뷸맺뿼쳾䔀㌂〄㐆䰈㼊䰌㨎倐⬒☔儖⤘ⴚ␜崞ᄠ昢ᜤ搦栨椪ᐬᠮ田Ĳдึ簸਺мܾ牀牂畄͆灈筊瑌ൎၐ晒ፔᅖ潘橚摜᭞坠婢⍤卦屨剪ⱬ嵮䥰䝲ぴ䁶䥸㹺㱼䡾떀떂솄슆번뎊쾌뺎ꊐ튒톔ꆖ꺘ꊚ\udf9cꚞ閠邢钦鲮蚲螶貸誺ﺼ螾菀蛂蛄苆靖觊軌觎韐闒雔鷘髚駜퇠ꃢꛤ틦퇨꣪ꧬꧮ짰럲뛴싶쳸쳺룼쟾\u3000。䘄䘆㨈㌊䬌㰎‐┒嘔儖尘ⴚ嬜Ⱎ朠昢愤ᔦᠨᨪ欬᤮爰в焴ุܶ༺笼ਾ牀牂لцୈ絊ୌ੎ၐᅒᙔᅖ὘浚浜楞偠≢Ⅴ彦彨孪屬幮㝰㕲ぴ佶㡸䍺䵼㭾잀뒂삄슆릈캊붌뢎ꊐ횒킔톖ꂘꊚ\udb9cꞞ钠鮨颮薰課", a_), this, global::AllFeatures.CodeplugGuid.b("臄軆蟈裊黌鿎郐蟒鳔雖闘黚賜럠ꛢꛤ돦ꛨ맪달껮쏰싲샴싶쿸", a_), global::CommonResources.AcgResources.ID_DINCSPATIALEQ2VECTOR, 248);
					this.dINCSPATIALEQ2VECTOR_A21556.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.dINCSPATIALEQ2VECTOR_A21556.DataTransferOrder = -1;
					num = (short)911736856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_680;
				case 24:
					goto IL_503;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊裌菎髐鳒菔鋖高迚鋜跞뻠ꋢퟤ훦\udce8\uddea\udcec", a_)))
					{
						num = (short)103743488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_732;
				case 26:
					num = (short)256966669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_D1;
				case 28:
					goto IL_21F;
				case 29:
					goto IL_59B;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊黌鿎郐蟒鳔雖闘黚賜럠ꛢꛤ돦ꛨ맪달껮쏰싲샴싶쿸", a_)))
					{
						num = (short)672595990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E3;
				}
				IL_AA:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)707067907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D1:
				num = (short)236781579;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E9:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臄軆蟈裊迌觎铐苒菔鋖高迚鋜跞뻠ꋢퟤ훦\udce8\udeea\udaec", a_)))
				{
					num = (short)2057502741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_21F;
				IL_1AB:
				num = (short)1456078855;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21F:
				num = (short)640155653;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_338:
				num = (short)513933342;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_387:
				num = (short)1695023129;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_59B:
				num = (short)243990547;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_680:
				num = (short)1079836681;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_732:
				num = (short)1692205066;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_503:
			IL_7E3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苄ꋆꟈ껊뿌껎뷐", a_);
			base.Id = 10240;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006B2B RID: 27435 RVA: 0x005FBDB8 File Offset: 0x005F9FB8
		public override void PopulateReferences()
		{
			short num = (short)370189753;
			short num2 = num;
			num = (short)1628284345;
			switch (num2 == num)
			{
			}
			num = (short)613154817;
			if (num != 0)
			{
			}
			num = (short)748027904;
			if (num != 0)
			{
			}
			num = (short)302252032;
			short num3 = num;
		}

		// Token: 0x06006B2C RID: 27436 RVA: 0x005FBE60 File Offset: 0x005FA060
		public override void DropReferences()
		{
			short num = (short)1282841680;
			short num2 = num;
			num = (short)1514445904;
			switch (num2 == num)
			{
			}
			num = (short)2066153473;
			if (num != 0)
			{
			}
			num = (short)2002780160;
			if (num != 0)
			{
			}
			num = (short)1273364480;
			short num3 = num;
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x005FBF10 File Offset: 0x005FA110
		public override void SetConstraints()
		{
			short num = (short)1596046723;
			short num2 = num;
			num = (short)1384889731;
			switch (num2 == num)
			{
			}
			num = (short)2105540609;
			if (num != 0)
			{
			}
			num = (short)1080885248;
			if (num != 0)
			{
			}
			num = (short)478478336;
			short num3 = num;
			this.dINCSPATIALEQ1VECTORCONT_A37716.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListConstraints.ConDincSpatialEq1VectorContLngIs16BCH);
			this.dINCSPATIALEQ2VECTORCONT_A37717.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListConstraints.ConDincSpatialEq2VectorContLngIs16BCH);
			this.dINCELKOVECTOR_A21561.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListConstraints.ConDincElkoVectorLengthEqualsTo64);
			this.dINCOUTPUTEQVECTOR_A21558.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListConstraints.ConDincOutputEqVectorLengthEqualsTo124);
			this.dINCBFEQVECTOR_A21557.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListConstraints.ConDincBfEqVectorLengthEqualsTo124);
			this.dINCSPATIALEQ1VECTOR_A21553.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListConstraints.ConDincSpatialEq1VectorLengthEqualsTo248);
			this.dINCSPATIALEQ2VECTOR_A21556.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.GlobalNoiseReductionListConstraints.ConDincSpatialEq2VectorLengthEqualsTo248);
		}

		// Token: 0x06006B2E RID: 27438 RVA: 0x005FC058 File Offset: 0x005FA258
		public override void SetupDependencies()
		{
			short num = (short)1895480928;
			short num2 = num;
			num = (short)2036121184;
			switch (num2 == num)
			{
			}
			num = (short)1018822657;
			if (num != 0)
			{
			}
			num = (short)547487744;
			if (num != 0)
			{
			}
			num = (short)1535967232;
			short num3 = num;
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x06006B2F RID: 27439 RVA: 0x005FC104 File Offset: 0x005FA304
		public bool HasDiffs
		{
			get
			{
				short num = (short)79025415;
				short num2 = num;
				num = (short)1663096071;
				switch (num2 == num)
				{
				}
				num = (short)585433089;
				if (num != 0)
				{
				}
				num = (short)725614592;
				if (num != 0)
				{
				}
				num = (short)1301610496;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x06006B30 RID: 27440 RVA: 0x005FC1B0 File Offset: 0x005FA3B0
		// (set) Token: 0x06006B31 RID: 27441 RVA: 0x005FC268 File Offset: 0x005FA468
		public int DINCHOTBEAMHYSTERESIS_A21559Value
		{
			get
			{
				short num = (short)641533653;
				short num2 = num;
				num = (short)2055603925;
				switch (num2 == num)
				{
				}
				num = (short)1217658881;
				if (num != 0)
				{
				}
				num = (short)207749120;
				if (num != 0)
				{
				}
				num = (short)1408106496;
				short num3 = num;
				return this.dINCHOTBEAMHYSTERESIS_A21559.Value;
			}
			set
			{
				short num = (short)536870912;
				short num2 = num;
				num = (short)765806249;
				short num3 = num;
				num = (short)1579959977;
				switch (num3 == num)
				{
				}
				num = (short)537133057;
				if (num != 0)
				{
				}
				num = (short)868089856;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.Value = value;
			}
		}

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x06006B32 RID: 27442 RVA: 0x005FC320 File Offset: 0x005FA520
		public global::AcpBusinessLayer.AcpSimpleRangeField DINCHOTBEAMHYSTERESIS_A21559
		{
			get
			{
				short num = (short)1418461184;
				short num2 = num;
				num = (short)1803131762;
				short num3 = num;
				num = (short)1669766002;
				switch (num3 == num)
				{
				}
				num = (short)3801088;
				if (num != 0)
				{
				}
				num = (short)1424162817;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559;
			}
		}

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x06006B33 RID: 27443 RVA: 0x005FC3D0 File Offset: 0x005FA5D0
		// (set) Token: 0x06006B34 RID: 27444 RVA: 0x005FC480 File Offset: 0x005FA680
		public string DINCHOTBEAMHYSTERESIS_A21559_UIValue
		{
			get
			{
				short num = (short)790822912;
				short num2 = num;
				num = (short)1059680998;
				short num3 = num;
				num = (short)653619942;
				switch (num3 == num)
				{
				}
				num = (short)708050944;
				if (num != 0)
				{
				}
				num = (short)83099649;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.UIValue;
			}
			set
			{
				short num = (short)1726021632;
				short num2 = num;
				num = (short)1548306621;
				short num3 = num;
				num = (short)2014726333;
				switch (num3 == num)
				{
				}
				num = (short)1601634305;
				if (num != 0)
				{
				}
				num = (short)196804608;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.UIValue = value;
			}
		}

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x06006B35 RID: 27445 RVA: 0x005FC538 File Offset: 0x005FA738
		// (set) Token: 0x06006B36 RID: 27446 RVA: 0x005FC5EC File Offset: 0x005FA7EC
		public string DINCHOTBEAMHYSTERESIS_A21559_HexUIValue
		{
			get
			{
				short num = (short)257425408;
				short num2 = num;
				num = (short)1658088727;
				short num3 = num;
				num = (short)701459735;
				switch (num3 == num)
				{
				}
				num = (short)1944518656;
				if (num != 0)
				{
				}
				num = (short)1505296385;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.HexUIValue;
			}
			set
			{
				short num = (short)1518993408;
				short num2 = num;
				num = (short)968029208;
				short num3 = num;
				num = (short)1181021208;
				switch (num3 == num)
				{
				}
				num = (short)38207488;
				if (num != 0)
				{
				}
				num = (short)1969422337;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.HexUIValue = value;
			}
		}

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x06006B37 RID: 27447 RVA: 0x005FC6A4 File Offset: 0x005FA8A4
		// (set) Token: 0x06006B38 RID: 27448 RVA: 0x005FC75C File Offset: 0x005FA95C
		internal int DINCHOTBEAMHYSTERESIS_A21559Min
		{
			get
			{
				short num = (short)2098003968;
				short num2 = num;
				num = (short)438865163;
				short num3 = num;
				num = (short)321096971;
				switch (num3 == num)
				{
				}
				num = (short)228786176;
				if (num != 0)
				{
				}
				num = (short)1092288513;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.Min;
			}
			set
			{
				short num = (short)468910080;
				short num2 = num;
				num = (short)1785672637;
				short num3 = num;
				num = (short)2034381757;
				switch (num3 == num)
				{
				}
				num = (short)943652865;
				if (num != 0)
				{
				}
				num = (short)1182334976;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.Min = value;
			}
		}

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x06006B39 RID: 27449 RVA: 0x005FC810 File Offset: 0x005FAA10
		// (set) Token: 0x06006B3A RID: 27450 RVA: 0x005FC8C4 File Offset: 0x005FAAC4
		internal int DINCHOTBEAMHYSTERESIS_A21559Max
		{
			get
			{
				short num = (short)1589968896;
				short num2 = num;
				num = (short)926836960;
				short num3 = num;
				num = (short)258107616;
				switch (num3 == num)
				{
				}
				num = (short)1640628225;
				if (num != 0)
				{
				}
				num = (short)356843520;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.Max;
			}
			set
			{
				short num = (short)1316618240;
				short num2 = num;
				num = (short)225981708;
				short num3 = num;
				num = (short)1041184012;
				switch (num3 == num)
				{
				}
				num = (short)1308884992;
				if (num != 0)
				{
				}
				num = (short)1900609537;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.Max = value;
			}
		}

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x06006B3B RID: 27451 RVA: 0x005FC978 File Offset: 0x005FAB78
		// (set) Token: 0x06006B3C RID: 27452 RVA: 0x005FCA30 File Offset: 0x005FAC30
		internal int DINCHOTBEAMHYSTERESIS_A21559Step
		{
			get
			{
				short num = (short)1419837440;
				short num2 = num;
				num = (short)1677468857;
				short num3 = num;
				num = (short)1523786937;
				switch (num3 == num)
				{
				}
				num = (short)1436549121;
				if (num != 0)
				{
				}
				num = (short)769392640;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.StepSize;
			}
			set
			{
				short num = (short)1624571904;
				short num2 = num;
				num = (short)1951813923;
				short num3 = num;
				num = (short)1408323875;
				switch (num3 == num)
				{
				}
				num = (short)2047279105;
				if (num != 0)
				{
				}
				num = (short)257359872;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.StepSize = value;
			}
		}

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x06006B3D RID: 27453 RVA: 0x005FCAE8 File Offset: 0x005FACE8
		// (set) Token: 0x06006B3E RID: 27454 RVA: 0x005FCB9C File Offset: 0x005FAD9C
		public bool DINCHOTBEAMHYSTERESIS_A21559_Applicable
		{
			get
			{
				short num = (short)2051276800;
				short num2 = num;
				num = (short)36831233;
				if (num != 0)
				{
				}
				num = (short)1317801333;
				short num3 = num;
				num = (short)61607285;
				switch (num3 == num)
				{
				}
				num = (short)1499725824;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.Applicable;
			}
			set
			{
				short num = (short)62849024;
				short num2 = num;
				num = (short)288058997;
				short num3 = num;
				num = (short)1466199669;
				switch (num3 == num)
				{
				}
				num = (short)497876993;
				if (num != 0)
				{
				}
				num = (short)2135883776;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.Applicable = value;
			}
		}

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x06006B3F RID: 27455 RVA: 0x005FCC50 File Offset: 0x005FAE50
		// (set) Token: 0x06006B40 RID: 27456 RVA: 0x005FCD04 File Offset: 0x005FAF04
		public bool DINCHOTBEAMHYSTERESIS_A21559_Valid
		{
			get
			{
				short num = (short)181862400;
				short num2 = num;
				num = (short)1401683969;
				if (num != 0)
				{
				}
				num = (short)576115342;
				short num3 = num;
				num = (short)1481560718;
				switch (num3 == num)
				{
				}
				num = (short)423428096;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.Valid;
			}
			set
			{
				short num = (short)1870921728;
				short num2 = num;
				num = (short)1716453377;
				if (num != 0)
				{
				}
				num = (short)131765033;
				short num3 = num;
				num = (short)597922601;
				switch (num3 == num)
				{
				}
				num = (short)1809055744;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.Valid = value;
			}
		}

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x06006B41 RID: 27457 RVA: 0x005FCDB8 File Offset: 0x005FAFB8
		// (set) Token: 0x06006B42 RID: 27458 RVA: 0x005FCE70 File Offset: 0x005FB070
		public bool DINCHOTBEAMHYSTERESIS_A21559_Visible
		{
			get
			{
				short num = (short)1222311936;
				short num2 = num;
				num = (short)1147284879;
				short num3 = num;
				num = (short)53226895;
				switch (num3 == num)
				{
				}
				num = (short)1609367553;
				if (num != 0)
				{
				}
				num = (short)528154624;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.Visible;
			}
			set
			{
				short num = (short)1769603072;
				short num2 = num;
				num = (short)2021100539;
				short num3 = num;
				num = (short)876841979;
				switch (num3 == num)
				{
				}
				num = (short)1980825600;
				if (num != 0)
				{
				}
				num = (short)1637023745;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.Visible = value;
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x06006B43 RID: 27459 RVA: 0x005FCF28 File Offset: 0x005FB128
		// (set) Token: 0x06006B44 RID: 27460 RVA: 0x005FCFE0 File Offset: 0x005FB1E0
		public bool DINCHOTBEAMHYSTERESIS_A21559_Editable
		{
			get
			{
				short num = (short)1956708352;
				short num2 = num;
				num = (short)490519392;
				short num3 = num;
				num = (short)1307294560;
				switch (num3 == num)
				{
				}
				num = (short)1119879169;
				if (num != 0)
				{
				}
				num = (short)963313664;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.Editable;
			}
			set
			{
				short num = (short)371916800;
				short num2 = num;
				num = (short)1837798651;
				short num3 = num;
				num = (short)740070651;
				switch (num3 == num)
				{
				}
				num = (short)258998273;
				if (num != 0)
				{
				}
				num = (short)1458503680;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.Editable = value;
			}
		}

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x06006B45 RID: 27461 RVA: 0x005FD094 File Offset: 0x005FB294
		internal string DINCHOTBEAMHYSTERESIS_A21559_UILabel
		{
			get
			{
				short num = (short)170721280;
				short num2 = num;
				num = (short)380519254;
				short num3 = num;
				num = (short)410993494;
				switch (num3 == num)
				{
				}
				num = (short)1615069184;
				if (num != 0)
				{
				}
				num = (short)1532952577;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.UIName;
			}
		}

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x06006B46 RID: 27462 RVA: 0x005FD14C File Offset: 0x005FB34C
		// (set) Token: 0x06006B47 RID: 27463 RVA: 0x005FD204 File Offset: 0x005FB404
		internal bool DINCHOTBEAMHYSTERESIS_A21559_HiddenStatic
		{
			get
			{
				short num = (short)1240727552;
				short num2 = num;
				num = (short)774044349;
				short num3 = num;
				num = (short)1833661;
				switch (num3 == num)
				{
				}
				num = (short)1248788481;
				if (num != 0)
				{
				}
				num = (short)441581568;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.HiddenStatic;
			}
			set
			{
				short num = (short)211812352;
				short num2 = num;
				num = (short)167995582;
				short num3 = num;
				num = (short)1070164158;
				switch (num3 == num)
				{
				}
				num = (short)80347137;
				if (num != 0)
				{
				}
				num = (short)1295646720;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.HiddenStatic = value;
			}
		}

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x06006B48 RID: 27464 RVA: 0x005FD2BC File Offset: 0x005FB4BC
		// (set) Token: 0x06006B49 RID: 27465 RVA: 0x005FD370 File Offset: 0x005FB570
		internal bool DINCHOTBEAMHYSTERESIS_A21559_HiddenDynamic
		{
			get
			{
				short num = (short)135462912;
				short num2 = num;
				num = (short)1810452365;
				short num3 = num;
				num = (short)756436877;
				switch (num3 == num)
				{
				}
				num = (short)3407872;
				if (num != 0)
				{
				}
				num = (short)1812463617;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559.HiddenDynamic;
			}
			set
			{
				short num = (short)1851129856;
				short num2 = num;
				num = (short)1153723015;
				short num3 = num;
				num = (short)1614178951;
				switch (num3 == num)
				{
				}
				num = (short)1946550273;
				if (num != 0)
				{
				}
				num = (short)871301120;
				if (num != 0)
				{
				}
				this.dINCHOTBEAMHYSTERESIS_A21559.HiddenDynamic = value;
			}
		}

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x06006B4A RID: 27466 RVA: 0x005FD424 File Offset: 0x005FB624
		public bool DINCHOTBEAMHYSTERESIS_A21559_HasDiffs
		{
			get
			{
				short num = (short)1742929920;
				short num2 = num;
				num = (short)1206294795;
				short num3 = num;
				num = (short)1993120011;
				switch (num3 == num)
				{
				}
				num = (short)699400193;
				if (num != 0)
				{
				}
				num = (short)1031208960;
				if (num != 0)
				{
				}
				return this.dINCHOTBEAMHYSTERESIS_A21559._HasDiffs;
			}
		}

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x06006B4B RID: 27467 RVA: 0x005FD4DC File Offset: 0x005FB6DC
		// (set) Token: 0x06006B4C RID: 27468 RVA: 0x005FD594 File Offset: 0x005FB794
		public int DINCBADMICHYSTERESIS_A21560Value
		{
			get
			{
				short num = (short)802816000;
				short num2 = num;
				num = (short)1102887970;
				short num3 = num;
				num = (short)1703918626;
				switch (num3 == num)
				{
				}
				num = (short)203358209;
				if (num != 0)
				{
				}
				num = (short)134610944;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.Value;
			}
			set
			{
				short num = (short)111935488;
				short num2 = num;
				num = (short)151341704;
				short num3 = num;
				num = (short)1448561288;
				switch (num3 == num)
				{
				}
				num = (short)1563295745;
				if (num != 0)
				{
				}
				num = (short)1747648512;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.Value = value;
			}
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x06006B4D RID: 27469 RVA: 0x005FD648 File Offset: 0x005FB848
		public global::AcpBusinessLayer.AcpSimpleRangeField DINCBADMICHYSTERESIS_A21560
		{
			get
			{
				short num = (short)59506688;
				short num2 = num;
				num = (short)1828180634;
				short num3 = num;
				num = (short)2135937690;
				switch (num3 == num)
				{
				}
				num = (short)180682752;
				if (num != 0)
				{
				}
				num = (short)1382612993;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560;
			}
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x005FD6F8 File Offset: 0x005FB8F8
		// (set) Token: 0x06006B4F RID: 27471 RVA: 0x005FD7AC File Offset: 0x005FB9AC
		public string DINCBADMICHYSTERESIS_A21560_UIValue
		{
			get
			{
				short num = (short)320143360;
				short num2 = num;
				num = (short)283473576;
				short num3 = num;
				num = (short)2003859112;
				switch (num3 == num)
				{
				}
				num = (short)2490369;
				if (num != 0)
				{
				}
				num = (short)893386752;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.UIValue;
			}
			set
			{
				short num = (short)824967168;
				short num2 = num;
				num = (short)122257702;
				short num3 = num;
				num = (short)1708294438;
				switch (num3 == num)
				{
				}
				num = (short)221904896;
				if (num != 0)
				{
				}
				num = (short)208863233;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.UIValue = value;
			}
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x06006B50 RID: 27472 RVA: 0x005FD864 File Offset: 0x005FBA64
		// (set) Token: 0x06006B51 RID: 27473 RVA: 0x005FD918 File Offset: 0x005FBB18
		public string DINCBADMICHYSTERESIS_A21560_HexUIValue
		{
			get
			{
				short num = (short)1942421504;
				short num2 = num;
				num = (short)1317516212;
				short num3 = num;
				num = (short)586658740;
				switch (num3 == num)
				{
				}
				num = (short)1197080577;
				if (num != 0)
				{
				}
				num = (short)1354498048;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.HexUIValue;
			}
			set
			{
				short num = (short)141557760;
				short num2 = num;
				num = (short)1556306877;
				short num3 = num;
				num = (short)1837259709;
				switch (num3 == num)
				{
				}
				num = (short)340656129;
				if (num != 0)
				{
				}
				num = (short)1671626752;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.HexUIValue = value;
			}
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x06006B52 RID: 27474 RVA: 0x005FD9D0 File Offset: 0x005FBBD0
		// (set) Token: 0x06006B53 RID: 27475 RVA: 0x005FDA84 File Offset: 0x005FBC84
		internal int DINCBADMICHYSTERESIS_A21560Min
		{
			get
			{
				short num = (short)1543897088;
				short num2 = num;
				num = (short)951713793;
				if (num != 0)
				{
				}
				num = (short)2036014286;
				short num3 = num;
				num = (short)588520654;
				switch (num3 == num)
				{
				}
				num = (short)1012531200;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.Min;
			}
			set
			{
				short num = (short)514392064;
				short num2 = num;
				num = (short)933122404;
				short num3 = num;
				num = (short)1332040036;
				switch (num3 == num)
				{
				}
				num = (short)1677918209;
				if (num != 0)
				{
				}
				num = (short)365101056;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.Min = value;
			}
		}

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x06006B54 RID: 27476 RVA: 0x005FDB3C File Offset: 0x005FBD3C
		// (set) Token: 0x06006B55 RID: 27477 RVA: 0x005FDBEC File Offset: 0x005FBDEC
		internal int DINCBADMICHYSTERESIS_A21560Max
		{
			get
			{
				short num = (short)1196883968;
				short num2 = num;
				num = (short)1359198573;
				short num3 = num;
				num = (short)1666890093;
				switch (num3 == num)
				{
				}
				num = (short)1246232576;
				if (num != 0)
				{
				}
				num = (short)727252993;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.Max;
			}
			set
			{
				short num = (short)2075852800;
				short num2 = num;
				num = (short)761075496;
				short num3 = num;
				num = (short)1899435816;
				switch (num3 == num)
				{
				}
				num = (short)330956801;
				if (num != 0)
				{
				}
				num = (short)926482432;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.Max = value;
			}
		}

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x06006B56 RID: 27478 RVA: 0x005FDCA4 File Offset: 0x005FBEA4
		// (set) Token: 0x06006B57 RID: 27479 RVA: 0x005FDD58 File Offset: 0x005FBF58
		internal int DINCBADMICHYSTERESIS_A21560Step
		{
			get
			{
				short num = (short)427360256;
				short num2 = num;
				num = (short)1307172939;
				short num3 = num;
				num = (short)1566629963;
				switch (num3 == num)
				{
				}
				num = (short)104202241;
				if (num != 0)
				{
				}
				num = (short)1931280384;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.StepSize;
			}
			set
			{
				short num = (short)1538785280;
				short num2 = num;
				num = (short)455369779;
				short num3 = num;
				num = (short)361784371;
				switch (num3 == num)
				{
				}
				num = (short)1824063489;
				if (num != 0)
				{
				}
				num = (short)1444151296;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.StepSize = value;
			}
		}

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x06006B58 RID: 27480 RVA: 0x005FDE10 File Offset: 0x005FC010
		// (set) Token: 0x06006B59 RID: 27481 RVA: 0x005FDEC8 File Offset: 0x005FC0C8
		public bool DINCBADMICHYSTERESIS_A21560_Applicable
		{
			get
			{
				short num = (short)444727296;
				short num2 = num;
				num = (short)1472388286;
				short num3 = num;
				num = (short)1951063230;
				switch (num3 == num)
				{
				}
				num = (short)655425537;
				if (num != 0)
				{
				}
				num = (short)490078208;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.Applicable;
			}
			set
			{
				short num = (short)1362034688;
				short num2 = num;
				num = (short)1719468033;
				if (num != 0)
				{
				}
				num = (short)448504154;
				short num3 = num;
				num = (short)1615634778;
				switch (num3 == num)
				{
				}
				num = (short)242548736;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.Applicable = value;
			}
		}

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x06006B5A RID: 27482 RVA: 0x005FDF80 File Offset: 0x005FC180
		// (set) Token: 0x06006B5B RID: 27483 RVA: 0x005FE034 File Offset: 0x005FC234
		public bool DINCBADMICHYSTERESIS_A21560_Valid
		{
			get
			{
				short num = (short)137822208;
				short num2 = num;
				num = (short)1182408290;
				short num3 = num;
				num = (short)2146704994;
				switch (num3 == num)
				{
				}
				num = (short)395444224;
				if (num != 0)
				{
				}
				num = (short)592838657;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.Valid;
			}
			set
			{
				short num = (short)1825308672;
				short num2 = num;
				num = (short)433707872;
				short num3 = num;
				num = (short)355130208;
				switch (num3 == num)
				{
				}
				num = (short)491454464;
				if (num != 0)
				{
				}
				num = (short)754057217;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.Valid = value;
			}
		}

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x06006B5C RID: 27484 RVA: 0x005FE0E8 File Offset: 0x005FC2E8
		// (set) Token: 0x06006B5D RID: 27485 RVA: 0x005FE19C File Offset: 0x005FC39C
		public bool DINCBADMICHYSTERESIS_A21560_Visible
		{
			get
			{
				short num = (short)1001652224;
				short num2 = num;
				num = (short)1488191489;
				if (num != 0)
				{
				}
				num = (short)1590196648;
				short num3 = num;
				num = (short)2039249320;
				switch (num3 == num)
				{
				}
				num = (short)180158464;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.Visible;
			}
			set
			{
				short num = (short)950730752;
				short num2 = num;
				num = (short)451049211;
				short num3 = num;
				num = (short)522942203;
				switch (num3 == num)
				{
				}
				num = (short)1838874625;
				if (num != 0)
				{
				}
				num = (short)736428032;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.Visible = value;
			}
		}

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x06006B5E RID: 27486 RVA: 0x005FE250 File Offset: 0x005FC450
		// (set) Token: 0x06006B5F RID: 27487 RVA: 0x005FE308 File Offset: 0x005FC508
		public bool DINCBADMICHYSTERESIS_A21560_Editable
		{
			get
			{
				short num = (short)574160896;
				short num2 = num;
				num = (short)1448802088;
				short num3 = num;
				num = (short)284358440;
				switch (num3 == num)
				{
				}
				num = (short)233504769;
				if (num != 0)
				{
				}
				num = (short)2014969856;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.Editable;
			}
			set
			{
				short num = (short)1353711616;
				short num2 = num;
				num = (short)1689502956;
				short num3 = num;
				num = (short)304334060;
				switch (num3 == num)
				{
				}
				num = (short)705429505;
				if (num != 0)
				{
				}
				num = (short)1089929216;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.Editable = value;
			}
		}

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x06006B60 RID: 27488 RVA: 0x005FE3BC File Offset: 0x005FC5BC
		internal string DINCBADMICHYSTERESIS_A21560_UILabel
		{
			get
			{
				short num = (short)692846592;
				short num2 = num;
				num = (short)1207571291;
				short num3 = num;
				num = (short)1963201371;
				switch (num3 == num)
				{
				}
				num = (short)382205952;
				if (num != 0)
				{
				}
				num = (short)558170113;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.UIName;
			}
		}

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x06006B61 RID: 27489 RVA: 0x005FE474 File Offset: 0x005FC674
		// (set) Token: 0x06006B62 RID: 27490 RVA: 0x005FE528 File Offset: 0x005FC728
		internal bool DINCBADMICHYSTERESIS_A21560_HiddenStatic
		{
			get
			{
				short num = (short)613941248;
				short num2 = num;
				num = (short)2128885889;
				short num3 = num;
				num = (short)1754151041;
				switch (num3 == num)
				{
				}
				num = (short)1341652993;
				if (num != 0)
				{
				}
				num = (short)1812398080;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.HiddenStatic;
			}
			set
			{
				short num = (short)1291911168;
				short num2 = num;
				num = (short)536613520;
				short num3 = num;
				num = (short)591991440;
				switch (num3 == num)
				{
				}
				num = (short)569376769;
				if (num != 0)
				{
				}
				num = (short)1517158400;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.HiddenStatic = value;
			}
		}

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x06006B63 RID: 27491 RVA: 0x005FE5E0 File Offset: 0x005FC7E0
		// (set) Token: 0x06006B64 RID: 27492 RVA: 0x005FE694 File Offset: 0x005FC894
		internal bool DINCBADMICHYSTERESIS_A21560_HiddenDynamic
		{
			get
			{
				short num = (short)1510539264;
				short num2 = num;
				num = (short)280456897;
				short num3 = num;
				num = (short)2052157121;
				switch (num3 == num)
				{
				}
				num = (short)768606208;
				if (num != 0)
				{
				}
				num = (short)425132033;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560.HiddenDynamic;
			}
			set
			{
				short num = (short)1349910528;
				short num2 = num;
				num = (short)1707880839;
				short num3 = num;
				num = (short)375337351;
				switch (num3 == num)
				{
				}
				num = (short)1862402049;
				if (num != 0)
				{
				}
				num = (short)792985600;
				if (num != 0)
				{
				}
				this.dINCBADMICHYSTERESIS_A21560.HiddenDynamic = value;
			}
		}

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x06006B65 RID: 27493 RVA: 0x005FE74C File Offset: 0x005FC94C
		public bool DINCBADMICHYSTERESIS_A21560_HasDiffs
		{
			get
			{
				short num = (short)754974720;
				short num2 = num;
				num = (short)1447494399;
				short num3 = num;
				num = (short)1216611071;
				switch (num3 == num)
				{
				}
				num = (short)306511872;
				if (num != 0)
				{
				}
				num = (short)1402077185;
				if (num != 0)
				{
				}
				return this.dINCBADMICHYSTERESIS_A21560._HasDiffs;
			}
		}

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x06006B66 RID: 27494 RVA: 0x005FE800 File Offset: 0x005FCA00
		// (set) Token: 0x06006B67 RID: 27495 RVA: 0x005FE8B4 File Offset: 0x005FCAB4
		public string DINCSPATIALEQ1VECTORCONT_A37716Value
		{
			get
			{
				short num = (short)1675427840;
				short num2 = num;
				num = (short)1834237964;
				short num3 = num;
				num = (short)677003276;
				switch (num3 == num)
				{
				}
				num = (short)1338638336;
				if (num != 0)
				{
				}
				num = (short)1031733249;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.Value;
			}
			set
			{
				short num = (short)935198720;
				short num2 = num;
				num = (short)1671086974;
				short num3 = num;
				num = (short)1849869182;
				switch (num3 == num)
				{
				}
				num = (short)467992576;
				if (num != 0)
				{
				}
				num = (short)1650524161;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTORCONT_A37716.Value = value;
			}
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x06006B68 RID: 27496 RVA: 0x005FE96C File Offset: 0x005FCB6C
		public global::AcpBusinessLayer.AcpField<string> DINCSPATIALEQ1VECTORCONT_A37716
		{
			get
			{
				short num = (short)1683947520;
				short num2 = num;
				num = (short)1709965313;
				if (num != 0)
				{
				}
				num = (short)1404718059;
				short num3 = num;
				num = (short)1063013355;
				switch (num3 == num)
				{
				}
				num = (short)2023882752;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716;
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x06006B69 RID: 27497 RVA: 0x005FEA1C File Offset: 0x005FCC1C
		// (set) Token: 0x06006B6A RID: 27498 RVA: 0x005FEAD4 File Offset: 0x005FCCD4
		public string DINCSPATIALEQ1VECTORCONT_A37716_UIValue
		{
			get
			{
				short num = (short)2132475904;
				short num2 = num;
				num = (short)1145778868;
				short num3 = num;
				num = (short)1085223604;
				switch (num3 == num)
				{
				}
				num = (short)1245184001;
				if (num != 0)
				{
				}
				num = (short)1328611328;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.Value;
			}
			set
			{
				short num = (short)1018363904;
				short num2 = num;
				num = (short)2068521817;
				short num3 = num;
				num = (short)65151833;
				switch (num3 == num)
				{
				}
				num = (short)466026496;
				if (num != 0)
				{
				}
				num = (short)256311297;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTORCONT_A37716.Value = value;
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x06006B6B RID: 27499 RVA: 0x005FEB88 File Offset: 0x005FCD88
		// (set) Token: 0x06006B6C RID: 27500 RVA: 0x005FEC3C File Offset: 0x005FCE3C
		public bool DINCSPATIALEQ1VECTORCONT_A37716_Applicable
		{
			get
			{
				short num = (short)1616773120;
				short num2 = num;
				num = (short)190373429;
				short num3 = num;
				num = (short)1574297141;
				switch (num3 == num)
				{
				}
				num = (short)53346304;
				if (num != 0)
				{
				}
				num = (short)291241985;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.Applicable;
			}
			set
			{
				short num = (short)2003304448;
				short num2 = num;
				num = (short)828167179;
				short num3 = num;
				num = (short)4248587;
				switch (num3 == num)
				{
				}
				num = (short)425787393;
				if (num != 0)
				{
				}
				num = (short)1371930624;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTORCONT_A37716.Applicable = value;
			}
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x005FECF4 File Offset: 0x005FCEF4
		// (set) Token: 0x06006B6E RID: 27502 RVA: 0x005FEDAC File Offset: 0x005FCFAC
		public bool DINCSPATIALEQ1VECTORCONT_A37716_Valid
		{
			get
			{
				short num = (short)1635057664;
				short num2 = num;
				num = (short)66715649;
				if (num != 0)
				{
				}
				num = (short)1159018486;
				short num3 = num;
				num = (short)956381174;
				switch (num3 == num)
				{
				}
				num = (short)1771634688;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.Valid;
			}
			set
			{
				short num = (short)611254272;
				short num2 = num;
				num = (short)1771848323;
				short num3 = num;
				num = (short)795820675;
				switch (num3 == num)
				{
				}
				num = (short)1186529281;
				if (num != 0)
				{
				}
				num = (short)826540032;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTORCONT_A37716.Valid = value;
			}
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x06006B6F RID: 27503 RVA: 0x005FEE60 File Offset: 0x005FD060
		// (set) Token: 0x06006B70 RID: 27504 RVA: 0x005FEF18 File Offset: 0x005FD118
		public bool DINCSPATIALEQ1VECTORCONT_A37716_Visible
		{
			get
			{
				short num = (short)1941962752;
				short num2 = num;
				num = (short)1564041506;
				short num3 = num;
				num = (short)703291682;
				switch (num3 == num)
				{
				}
				num = (short)1053360129;
				if (num != 0)
				{
				}
				num = (short)845348864;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.Visible;
			}
			set
			{
				short num = (short)542113792;
				short num2 = num;
				num = (short)449245751;
				short num3 = num;
				num = (short)813232695;
				switch (num3 == num)
				{
				}
				num = (short)538968064;
				if (num != 0)
				{
				}
				num = (short)1937047553;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTORCONT_A37716.Visible = value;
			}
		}

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x06006B71 RID: 27505 RVA: 0x005FEFD0 File Offset: 0x005FD1D0
		// (set) Token: 0x06006B72 RID: 27506 RVA: 0x005FF084 File Offset: 0x005FD284
		public bool DINCSPATIALEQ1VECTORCONT_A37716_Editable
		{
			get
			{
				short num = (short)97189888;
				short num2 = num;
				num = (short)234927077;
				short num3 = num;
				num = (short)1705030629;
				switch (num3 == num)
				{
				}
				num = (short)2024734720;
				if (num != 0)
				{
				}
				num = (short)1208942593;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.Editable;
			}
			set
			{
				short num = (short)936509440;
				short num2 = num;
				num = (short)2106618117;
				short num3 = num;
				num = (short)1319727365;
				switch (num3 == num)
				{
				}
				num = (short)247922688;
				if (num != 0)
				{
				}
				num = (short)110362625;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTORCONT_A37716.Editable = value;
			}
		}

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x06006B73 RID: 27507 RVA: 0x005FF138 File Offset: 0x005FD338
		internal string DINCSPATIALEQ1VECTORCONT_A37716_UILabel
		{
			get
			{
				short num = (short)148832256;
				short num2 = num;
				num = (short)1351021925;
				short num3 = num;
				num = (short)716436837;
				switch (num3 == num)
				{
				}
				num = (short)2032140289;
				if (num != 0)
				{
				}
				num = (short)1300299776;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.UIName;
			}
		}

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x06006B74 RID: 27508 RVA: 0x005FF1EC File Offset: 0x005FD3EC
		// (set) Token: 0x06006B75 RID: 27509 RVA: 0x005FF2A0 File Offset: 0x005FD4A0
		internal bool DINCSPATIALEQ1VECTORCONT_A37716_HiddenStatic
		{
			get
			{
				short num = (short)1439367168;
				short num2 = num;
				num = (short)554303489;
				if (num != 0)
				{
				}
				num = (short)93122726;
				short num3 = num;
				num = (short)1178726566;
				switch (num3 == num)
				{
				}
				num = (short)1048379392;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.HiddenStatic;
			}
			set
			{
				short num = (short)1331363840;
				short num2 = num;
				num = (short)1654128641;
				if (num != 0)
				{
				}
				num = (short)1634868496;
				short num3 = num;
				num = (short)1695554832;
				switch (num3 == num)
				{
				}
				num = (short)1044578304;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTORCONT_A37716.HiddenStatic = value;
			}
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x06006B76 RID: 27510 RVA: 0x005FF354 File Offset: 0x005FD554
		// (set) Token: 0x06006B77 RID: 27511 RVA: 0x005FF408 File Offset: 0x005FD608
		internal bool DINCSPATIALEQ1VECTORCONT_A37716_HiddenDynamic
		{
			get
			{
				short num = (short)1781202944;
				short num2 = num;
				num = (short)1868890113;
				if (num != 0)
				{
				}
				num = (short)1000020256;
				short num3 = num;
				num = (short)519117088;
				switch (num3 == num)
				{
				}
				num = (short)2044592128;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTORCONT_A37716.HiddenDynamic;
			}
			set
			{
				short num = (short)33751040;
				short num2 = num;
				num = (short)1855159297;
				short num3 = num;
				num = (short)778402817;
				switch (num3 == num)
				{
				}
				num = (short)690290688;
				if (num != 0)
				{
				}
				num = (short)1006501889;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTORCONT_A37716.HiddenDynamic = value;
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x06006B78 RID: 27512 RVA: 0x005FF4BC File Offset: 0x005FD6BC
		public bool DINCSPATIALEQ1VECTORCONT_A37716_HasDiffs
		{
			get
			{
				short num = (short)515919171;
				short num2 = num;
				num = (short)686705987;
				switch (num2 == num)
				{
				}
				num = (short)1849229312;
				if (num != 0)
				{
				}
				num = (short)1537409025;
				if (num != 0)
				{
				}
				num = (short)712572928;
				short num3 = num;
				return this.dINCSPATIALEQ1VECTORCONT_A37716._HasDiffs;
			}
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x06006B79 RID: 27513 RVA: 0x005FF570 File Offset: 0x005FD770
		// (set) Token: 0x06006B7A RID: 27514 RVA: 0x005FF624 File Offset: 0x005FD824
		public string DINCSPATIALEQ2VECTORCONT_A37717Value
		{
			get
			{
				short num = (short)1716856775;
				short num2 = num;
				num = (short)1465591751;
				switch (num2 == num)
				{
				}
				num = (short)778567681;
				if (num != 0)
				{
				}
				num = (short)1649475584;
				if (num != 0)
				{
				}
				num = (short)302055424;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.Value;
			}
			set
			{
				short num = (short)1547894785;
				if (num != 0)
				{
				}
				num = (short)472243873;
				short num2 = num;
				num = (short)467787425;
				switch (num2 == num)
				{
				}
				num = (short)331022336;
				if (num != 0)
				{
				}
				num = (short)458555392;
				short num3 = num;
				this.dINCSPATIALEQ2VECTORCONT_A37717.Value = value;
			}
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x06006B7B RID: 27515 RVA: 0x005FF6D8 File Offset: 0x005FD8D8
		public global::AcpBusinessLayer.AcpField<string> DINCSPATIALEQ2VECTORCONT_A37717
		{
			get
			{
				short num = (short)1642787745;
				short num2 = num;
				num = (short)793768865;
				switch (num2 == num)
				{
				}
				num = (short)1769537537;
				if (num != 0)
				{
				}
				num = (short)1659437056;
				if (num != 0)
				{
				}
				num = (short)218693632;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717;
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x06006B7C RID: 27516 RVA: 0x005FF788 File Offset: 0x005FD988
		// (set) Token: 0x06006B7D RID: 27517 RVA: 0x005FF83C File Offset: 0x005FDA3C
		public string DINCSPATIALEQ2VECTORCONT_A37717_UIValue
		{
			get
			{
				short num = (short)992617716;
				short num2 = num;
				num = (short)899163380;
				switch (num2 == num)
				{
				}
				num = (short)1333133312;
				if (num != 0)
				{
				}
				num = (short)605487105;
				if (num != 0)
				{
				}
				num = (short)1490878464;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.Value;
			}
			set
			{
				short num = (short)827006813;
				short num2 = num;
				num = (short)2109415261;
				switch (num2 == num)
				{
				}
				num = (short)1027997697;
				if (num != 0)
				{
				}
				num = (short)434569216;
				if (num != 0)
				{
				}
				num = (short)335216640;
				short num3 = num;
				this.dINCSPATIALEQ2VECTORCONT_A37717.Value = value;
			}
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x06006B7E RID: 27518 RVA: 0x005FF8F0 File Offset: 0x005FDAF0
		// (set) Token: 0x06006B7F RID: 27519 RVA: 0x005FF9A4 File Offset: 0x005FDBA4
		public bool DINCSPATIALEQ2VECTORCONT_A37717_Applicable
		{
			get
			{
				short num = (short)1793847062;
				short num2 = num;
				num = (short)453898006;
				switch (num2 == num)
				{
				}
				num = (short)1011482625;
				if (num != 0)
				{
				}
				num = (short)2107637760;
				if (num != 0)
				{
				}
				num = (short)1702690816;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.Applicable;
			}
			set
			{
				short num = (short)166713490;
				short num2 = num;
				num = (short)1951717522;
				switch (num2 == num)
				{
				}
				num = (short)434896897;
				if (num != 0)
				{
				}
				num = (short)569180160;
				if (num != 0)
				{
				}
				num = (short)1710489600;
				short num3 = num;
				this.dINCSPATIALEQ2VECTORCONT_A37717.Applicable = value;
			}
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x06006B80 RID: 27520 RVA: 0x005FFA5C File Offset: 0x005FDC5C
		// (set) Token: 0x06006B81 RID: 27521 RVA: 0x005FFB14 File Offset: 0x005FDD14
		public bool DINCSPATIALEQ2VECTORCONT_A37717_Valid
		{
			get
			{
				short num = (short)984904543;
				short num2 = num;
				num = (short)178615135;
				switch (num2 == num)
				{
				}
				num = (short)1834942465;
				if (num != 0)
				{
				}
				num = (short)1557987328;
				if (num != 0)
				{
				}
				num = (short)1779302400;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.Valid;
			}
			set
			{
				short num = (short)696701983;
				short num2 = num;
				num = (short)1684395039;
				switch (num2 == num)
				{
				}
				num = (short)2129264640;
				if (num != 0)
				{
				}
				num = (short)1548222465;
				if (num != 0)
				{
				}
				num = (short)2141519872;
				short num3 = num;
				this.dINCSPATIALEQ2VECTORCONT_A37717.Valid = value;
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x06006B82 RID: 27522 RVA: 0x005FFBC8 File Offset: 0x005FDDC8
		// (set) Token: 0x06006B83 RID: 27523 RVA: 0x005FFC80 File Offset: 0x005FDE80
		public bool DINCSPATIALEQ2VECTORCONT_A37717_Visible
		{
			get
			{
				short num = (short)2012391622;
				short num2 = num;
				num = (short)1958979782;
				switch (num2 == num)
				{
				}
				num = (short)1945370624;
				if (num != 0)
				{
				}
				num = (short)892207105;
				if (num != 0)
				{
				}
				num = (short)1135607808;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.Visible;
			}
			set
			{
				short num = (short)302191111;
				short num2 = num;
				num = (short)905318919;
				switch (num2 == num)
				{
				}
				num = (short)624164865;
				if (num != 0)
				{
				}
				num = (short)353501184;
				if (num != 0)
				{
				}
				num = (short)1834418176;
				short num3 = num;
				this.dINCSPATIALEQ2VECTORCONT_A37717.Visible = value;
			}
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x06006B84 RID: 27524 RVA: 0x005FFD38 File Offset: 0x005FDF38
		// (set) Token: 0x06006B85 RID: 27525 RVA: 0x005FFDEC File Offset: 0x005FDFEC
		public bool DINCSPATIALEQ2VECTORCONT_A37717_Editable
		{
			get
			{
				short num = (short)1726791690;
				short num2 = num;
				num = (short)33406986;
				switch (num2 == num)
				{
				}
				num = (short)692453377;
				if (num != 0)
				{
				}
				num = (short)941359104;
				if (num != 0)
				{
				}
				num = (short)1622343680;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.Editable;
			}
			set
			{
				short num = (short)1028524007;
				short num2 = num;
				num = (short)446892007;
				switch (num2 == num)
				{
				}
				num = (short)1626210305;
				if (num != 0)
				{
				}
				num = (short)749928448;
				if (num != 0)
				{
				}
				num = (short)319225856;
				short num3 = num;
				this.dINCSPATIALEQ2VECTORCONT_A37717.Editable = value;
			}
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x06006B86 RID: 27526 RVA: 0x005FFEA8 File Offset: 0x005FE0A8
		internal string DINCSPATIALEQ2VECTORCONT_A37717_UILabel
		{
			get
			{
				short num = (short)475090846;
				short num2 = num;
				num = (short)867323806;
				switch (num2 == num)
				{
				}
				num = (short)1380974593;
				if (num != 0)
				{
				}
				num = (short)689176576;
				if (num != 0)
				{
				}
				num = (short)1813839872;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.UIName;
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x06006B87 RID: 27527 RVA: 0x005FFF5C File Offset: 0x005FE15C
		// (set) Token: 0x06006B88 RID: 27528 RVA: 0x00600010 File Offset: 0x005FE210
		internal bool DINCSPATIALEQ2VECTORCONT_A37717_HiddenStatic
		{
			get
			{
				short num = (short)336244916;
				short num2 = num;
				num = (short)245936308;
				switch (num2 == num)
				{
				}
				num = (short)409337857;
				if (num != 0)
				{
				}
				num = (short)1393557504;
				if (num != 0)
				{
				}
				num = (short)1504837632;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.HiddenStatic;
			}
			set
			{
				short num = (short)1030233009;
				short num2 = num;
				num = (short)1897470897;
				switch (num2 == num)
				{
				}
				num = (short)375324672;
				if (num != 0)
				{
				}
				num = (short)71237633;
				if (num != 0)
				{
				}
				num = (short)822542336;
				short num3 = num;
				this.dINCSPATIALEQ2VECTORCONT_A37717.HiddenStatic = value;
			}
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x06006B89 RID: 27529 RVA: 0x006000C4 File Offset: 0x005FE2C4
		// (set) Token: 0x06006B8A RID: 27530 RVA: 0x00600178 File Offset: 0x005FE378
		internal bool DINCSPATIALEQ2VECTORCONT_A37717_HiddenDynamic
		{
			get
			{
				short num = (short)347822416;
				short num2 = num;
				num = (short)1755666768;
				switch (num2 == num)
				{
				}
				num = (short)468320257;
				if (num != 0)
				{
				}
				num = (short)54919168;
				if (num != 0)
				{
				}
				num = (short)1785266176;
				short num3 = num;
				return this.dINCSPATIALEQ2VECTORCONT_A37717.HiddenDynamic;
			}
			set
			{
				short num = (short)460521472;
				short num2 = num;
				num = (short)270402937;
				short num3 = num;
				num = (short)1093207417;
				switch (num3 == num)
				{
				}
				num = (short)2101805057;
				if (num != 0)
				{
				}
				num = (short)487915520;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTORCONT_A37717.HiddenDynamic = value;
			}
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x06006B8B RID: 27531 RVA: 0x0060022C File Offset: 0x005FE42C
		public bool DINCSPATIALEQ2VECTORCONT_A37717_HasDiffs
		{
			get
			{
				short num = (short)261488640;
				short num2 = num;
				num = (short)2089649849;
				short num3 = num;
				num = (short)1624999609;
				switch (num3 == num)
				{
				}
				num = (short)406585345;
				if (num != 0)
				{
				}
				num = (short)1713897472;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTORCONT_A37717._HasDiffs;
			}
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x06006B8C RID: 27532 RVA: 0x006002E0 File Offset: 0x005FE4E0
		// (set) Token: 0x06006B8D RID: 27533 RVA: 0x00600394 File Offset: 0x005FE594
		public string DINCELKOVECTOR_A21561Value
		{
			get
			{
				short num = (short)472449024;
				short num2 = num;
				num = (short)1861940175;
				short num3 = num;
				num = (short)1387590607;
				switch (num3 == num)
				{
				}
				num = (short)18612225;
				if (num != 0)
				{
				}
				num = (short)722272256;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.Value;
			}
			set
			{
				short num = (short)1807613952;
				short num2 = num;
				num = (short)1455227413;
				short num3 = num;
				num = (short)2106196501;
				switch (num3 == num)
				{
				}
				num = (short)2015887361;
				if (num != 0)
				{
				}
				num = (short)1328283648;
				if (num != 0)
				{
				}
				this.dINCELKOVECTOR_A21561.Value = value;
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x06006B8E RID: 27534 RVA: 0x0060044C File Offset: 0x005FE64C
		public global::AcpBusinessLayer.AcpField<string> DINCELKOVECTOR_A21561
		{
			get
			{
				short num = (short)175439872;
				short num2 = num;
				num = (short)880971816;
				short num3 = num;
				num = (short)1133875240;
				switch (num3 == num)
				{
				}
				num = (short)782761985;
				if (num != 0)
				{
				}
				num = (short)855179264;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561;
			}
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x06006B8F RID: 27535 RVA: 0x006004FC File Offset: 0x005FE6FC
		// (set) Token: 0x06006B90 RID: 27536 RVA: 0x006005B0 File Offset: 0x005FE7B0
		public string DINCELKOVECTOR_A21561_UIValue
		{
			get
			{
				short num = (short)2004025344;
				short num2 = num;
				num = (short)916628680;
				short num3 = num;
				num = (short)346399944;
				switch (num3 == num)
				{
				}
				num = (short)1267269633;
				if (num != 0)
				{
				}
				num = (short)1321795584;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.Value;
			}
			set
			{
				short num = (short)564133888;
				short num2 = num;
				num = (short)253320919;
				short num3 = num;
				num = (short)15621847;
				switch (num3 == num)
				{
				}
				num = (short)483131393;
				if (num != 0)
				{
				}
				num = (short)1074528256;
				if (num != 0)
				{
				}
				this.dINCELKOVECTOR_A21561.Value = value;
			}
		}

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x06006B91 RID: 27537 RVA: 0x00600668 File Offset: 0x005FE868
		// (set) Token: 0x06006B92 RID: 27538 RVA: 0x0060071C File Offset: 0x005FE91C
		public bool DINCELKOVECTOR_A21561_Applicable
		{
			get
			{
				short num = (short)304807936;
				short num2 = num;
				num = (short)1120779583;
				short num3 = num;
				num = (short)459259199;
				switch (num3 == num)
				{
				}
				num = (short)230162433;
				if (num != 0)
				{
				}
				num = (short)1692401664;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.Applicable;
			}
			set
			{
				short num = (short)2075525120;
				short num2 = num;
				num = (short)1898965289;
				short num3 = num;
				num = (short)1545267497;
				switch (num3 == num)
				{
				}
				num = (short)2111307776;
				if (num != 0)
				{
				}
				num = (short)891944961;
				if (num != 0)
				{
				}
				this.dINCELKOVECTOR_A21561.Applicable = value;
			}
		}

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x06006B93 RID: 27539 RVA: 0x006007D4 File Offset: 0x005FE9D4
		// (set) Token: 0x06006B94 RID: 27540 RVA: 0x00600888 File Offset: 0x005FEA88
		public bool DINCELKOVECTOR_A21561_Valid
		{
			get
			{
				short num = (short)1435828224;
				short num2 = num;
				num = (short)808437186;
				short num3 = num;
				num = (short)965264834;
				switch (num3 == num)
				{
				}
				num = (short)451215361;
				if (num != 0)
				{
				}
				num = (short)511246336;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.Valid;
			}
			set
			{
				short num = (short)1604517888;
				short num2 = num;
				num = (short)2091255286;
				short num3 = num;
				num = (short)237307382;
				switch (num3 == num)
				{
				}
				num = (short)562233345;
				if (num != 0)
				{
				}
				num = (short)122486784;
				if (num != 0)
				{
				}
				this.dINCELKOVECTOR_A21561.Valid = value;
			}
		}

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x06006B95 RID: 27541 RVA: 0x0060093C File Offset: 0x005FEB3C
		// (set) Token: 0x06006B96 RID: 27542 RVA: 0x006009F4 File Offset: 0x005FEBF4
		public bool DINCELKOVECTOR_A21561_Visible
		{
			get
			{
				short num = (short)1990983680;
				short num2 = num;
				num = (short)2065695171;
				short num3 = num;
				num = (short)2141258179;
				switch (num3 == num)
				{
				}
				num = (short)1326317568;
				if (num != 0)
				{
				}
				num = (short)1972371457;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.Visible;
			}
			set
			{
				short num = (short)1872232448;
				short num2 = num;
				num = (short)193778757;
				short num3 = num;
				num = (short)868013125;
				switch (num3 == num)
				{
				}
				num = (short)1731002369;
				if (num != 0)
				{
				}
				num = (short)1586954240;
				if (num != 0)
				{
				}
				this.dINCELKOVECTOR_A21561.Visible = value;
			}
		}

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x06006B97 RID: 27543 RVA: 0x00600AAC File Offset: 0x005FECAC
		// (set) Token: 0x06006B98 RID: 27544 RVA: 0x00600B60 File Offset: 0x005FED60
		public bool DINCELKOVECTOR_A21561_Editable
		{
			get
			{
				short num = (short)1882587136;
				short num2 = num;
				num = (short)972682826;
				short num3 = num;
				num = (short)1410332234;
				switch (num3 == num)
				{
				}
				num = (short)1697972224;
				if (num != 0)
				{
				}
				num = (short)1607335937;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.Editable;
			}
			set
			{
				short num = (short)851378176;
				short num2 = num;
				num = (short)154664961;
				if (num != 0)
				{
				}
				num = (short)1121263456;
				short num3 = num;
				num = (short)1733566304;
				switch (num3 == num)
				{
				}
				num = (short)152698880;
				if (num != 0)
				{
				}
				this.dINCELKOVECTOR_A21561.Editable = value;
			}
		}

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x06006B99 RID: 27545 RVA: 0x00600C14 File Offset: 0x005FEE14
		internal string DINCELKOVECTOR_A21561_UILabel
		{
			get
			{
				short num = (short)635699200;
				short num2 = num;
				num = (short)1952093839;
				short num3 = num;
				num = (short)1459721871;
				switch (num3 == num)
				{
				}
				num = (short)635895809;
				if (num != 0)
				{
				}
				num = (short)315621376;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.UIName;
			}
		}

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x06006B9A RID: 27546 RVA: 0x00600CCC File Offset: 0x005FEECC
		// (set) Token: 0x06006B9B RID: 27547 RVA: 0x00600D80 File Offset: 0x005FEF80
		internal bool DINCELKOVECTOR_A21561_HiddenStatic
		{
			get
			{
				short num = (short)704970752;
				short num2 = num;
				num = (short)1114832897;
				if (num != 0)
				{
				}
				num = (short)1868374397;
				short num3 = num;
				num = (short)77799805;
				switch (num3 == num)
				{
				}
				num = (short)561709056;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.HiddenStatic;
			}
			set
			{
				short num = (short)912326656;
				short num2 = num;
				num = (short)174721472;
				short num3 = num;
				num = (short)2091846080;
				switch (num3 == num)
				{
				}
				num = (short)75825153;
				if (num != 0)
				{
				}
				num = (short)1245511680;
				if (num != 0)
				{
				}
				this.dINCELKOVECTOR_A21561.HiddenStatic = value;
			}
		}

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x06006B9C RID: 27548 RVA: 0x00600E38 File Offset: 0x005FF038
		// (set) Token: 0x06006B9D RID: 27549 RVA: 0x00600EEC File Offset: 0x005FF0EC
		internal bool DINCELKOVECTOR_A21561_HiddenDynamic
		{
			get
			{
				short num = (short)947191808;
				short num2 = num;
				num = (short)73475165;
				short num3 = num;
				num = (short)194716765;
				switch (num3 == num)
				{
				}
				num = (short)1714880513;
				if (num != 0)
				{
				}
				num = (short)1027014656;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561.HiddenDynamic;
			}
			set
			{
				short num = (short)1244659712;
				short num2 = num;
				num = (short)904396801;
				if (num != 0)
				{
				}
				num = (short)1856064619;
				short num3 = num;
				num = (short)1071860843;
				switch (num3 == num)
				{
				}
				num = (short)588054528;
				if (num != 0)
				{
				}
				this.dINCELKOVECTOR_A21561.HiddenDynamic = value;
			}
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x06006B9E RID: 27550 RVA: 0x00600FA0 File Offset: 0x005FF1A0
		public bool DINCELKOVECTOR_A21561_HasDiffs
		{
			get
			{
				short num = (short)1949237248;
				short num2 = num;
				num = (short)958963337;
				short num3 = num;
				num = (short)464166537;
				switch (num3 == num)
				{
				}
				num = (short)1375469568;
				if (num != 0)
				{
				}
				num = (short)1474560001;
				if (num != 0)
				{
				}
				return this.dINCELKOVECTOR_A21561._HasDiffs;
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x06006B9F RID: 27551 RVA: 0x00601054 File Offset: 0x005FF254
		// (set) Token: 0x06006BA0 RID: 27552 RVA: 0x00601108 File Offset: 0x005FF308
		public string DINCOUTPUTEQVECTOR_A21558Value
		{
			get
			{
				short num = (short)430637056;
				short num2 = num;
				num = (short)1366633613;
				short num3 = num;
				num = (short)623914125;
				switch (num3 == num)
				{
				}
				num = (short)343277569;
				if (num != 0)
				{
				}
				num = (short)2075721728;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.Value;
			}
			set
			{
				short num = (short)1562050560;
				short num2 = num;
				num = (short)118309789;
				short num3 = num;
				num = (short)1219707805;
				switch (num3 == num)
				{
				}
				num = (short)625868801;
				if (num != 0)
				{
				}
				num = (short)642777088;
				if (num != 0)
				{
				}
				this.dINCOUTPUTEQVECTOR_A21558.Value = value;
			}
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x06006BA1 RID: 27553 RVA: 0x006011BC File Offset: 0x005FF3BC
		public global::AcpBusinessLayer.AcpField<string> DINCOUTPUTEQVECTOR_A21558
		{
			get
			{
				short num = (short)1808334848;
				short num2 = num;
				num = (short)195906246;
				short num3 = num;
				num = (short)697780934;
				switch (num3 == num)
				{
				}
				num = (short)630521857;
				if (num != 0)
				{
				}
				num = (short)2040659968;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558;
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x06006BA2 RID: 27554 RVA: 0x0060126C File Offset: 0x005FF46C
		// (set) Token: 0x06006BA3 RID: 27555 RVA: 0x00601320 File Offset: 0x005FF520
		public string DINCOUTPUTEQVECTOR_A21558_UIValue
		{
			get
			{
				short num = (short)886636544;
				short num2 = num;
				num = (short)200305366;
				short num3 = num;
				num = (short)2142857942;
				switch (num3 == num)
				{
				}
				num = (short)725352449;
				if (num != 0)
				{
				}
				num = (short)1079050240;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.Value;
			}
			set
			{
				short num = (short)856424448;
				short num2 = num;
				num = (short)1282670572;
				short num3 = num;
				num = (short)915472364;
				switch (num3 == num)
				{
				}
				num = (short)1446313985;
				if (num != 0)
				{
				}
				num = (short)2015887360;
				if (num != 0)
				{
				}
				this.dINCOUTPUTEQVECTOR_A21558.Value = value;
			}
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x06006BA4 RID: 27556 RVA: 0x006013D8 File Offset: 0x005FF5D8
		// (set) Token: 0x06006BA5 RID: 27557 RVA: 0x0060148C File Offset: 0x005FF68C
		public bool DINCOUTPUTEQVECTOR_A21558_Applicable
		{
			get
			{
				short num = (short)1181024256;
				short num2 = num;
				num = (short)724340527;
				short num3 = num;
				num = (short)1594265391;
				switch (num3 == num)
				{
				}
				num = (short)557711361;
				if (num != 0)
				{
				}
				num = (short)345047040;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.Applicable;
			}
			set
			{
				short num = (short)335020032;
				short num2 = num;
				num = (short)1439707259;
				short num3 = num;
				num = (short)661926011;
				switch (num3 == num)
				{
				}
				num = (short)1472856065;
				if (num != 0)
				{
				}
				num = (short)1467744256;
				if (num != 0)
				{
				}
				this.dINCOUTPUTEQVECTOR_A21558.Applicable = value;
			}
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x06006BA6 RID: 27558 RVA: 0x00601540 File Offset: 0x005FF740
		// (set) Token: 0x06006BA7 RID: 27559 RVA: 0x006015F4 File Offset: 0x005FF7F4
		public bool DINCOUTPUTEQVECTOR_A21558_Valid
		{
			get
			{
				short num = (short)1094647808;
				short num2 = num;
				num = (short)838008833;
				if (num != 0)
				{
				}
				num = (short)547791128;
				short num3 = num;
				num = (short)761372952;
				switch (num3 == num)
				{
				}
				num = (short)1913257984;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.Valid;
			}
			set
			{
				short num = (short)1548746752;
				short num2 = num;
				num = (short)882698831;
				short num3 = num;
				num = (short)643361359;
				switch (num3 == num)
				{
				}
				num = (short)1546977281;
				if (num != 0)
				{
				}
				num = (short)1998323712;
				if (num != 0)
				{
				}
				this.dINCOUTPUTEQVECTOR_A21558.Valid = value;
			}
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x06006BA8 RID: 27560 RVA: 0x006016A8 File Offset: 0x005FF8A8
		// (set) Token: 0x06006BA9 RID: 27561 RVA: 0x0060175C File Offset: 0x005FF95C
		public bool DINCOUTPUTEQVECTOR_A21558_Visible
		{
			get
			{
				short num = (short)1022099456;
				short num2 = num;
				num = (short)2132042823;
				short num3 = num;
				num = (short)1716872263;
				switch (num3 == num)
				{
				}
				num = (short)1497235457;
				if (num != 0)
				{
				}
				num = (short)482607104;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.Visible;
			}
			set
			{
				short num = (short)958595072;
				short num2 = num;
				num = (short)1341309008;
				short num3 = num;
				num = (short)1163575376;
				switch (num3 == num)
				{
				}
				num = (short)1116602369;
				if (num != 0)
				{
				}
				num = (short)179503104;
				if (num != 0)
				{
				}
				this.dINCOUTPUTEQVECTOR_A21558.Visible = value;
			}
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x06006BAA RID: 27562 RVA: 0x00601814 File Offset: 0x005FFA14
		// (set) Token: 0x06006BAB RID: 27563 RVA: 0x006018CC File Offset: 0x005FFACC
		public bool DINCOUTPUTEQVECTOR_A21558_Editable
		{
			get
			{
				short num = (short)172425216;
				short num2 = num;
				num = (short)2004474292;
				short num3 = num;
				num = (short)602397108;
				switch (num3 == num)
				{
				}
				num = (short)1849819136;
				if (num != 0)
				{
				}
				num = (short)1655767041;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.Editable;
			}
			set
			{
				short num = (short)1638334464;
				short num2 = num;
				num = (short)1549571926;
				short num3 = num;
				num = (short)330930006;
				switch (num3 == num)
				{
				}
				num = (short)1754136576;
				if (num != 0)
				{
				}
				num = (short)7405569;
				if (num != 0)
				{
				}
				this.dINCOUTPUTEQVECTOR_A21558.Editable = value;
			}
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x06006BAC RID: 27564 RVA: 0x00601984 File Offset: 0x005FFB84
		internal string DINCOUTPUTEQVECTOR_A21558_UILabel
		{
			get
			{
				short num = (short)2003828736;
				short num2 = num;
				num = (short)197859223;
				short num3 = num;
				num = (short)2029262743;
				switch (num3 == num)
				{
				}
				num = (short)356581377;
				if (num != 0)
				{
				}
				num = (short)501743616;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.UIName;
			}
		}

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x06006BAD RID: 27565 RVA: 0x00601A34 File Offset: 0x005FFC34
		// (set) Token: 0x06006BAE RID: 27566 RVA: 0x00601AEC File Offset: 0x005FFCEC
		internal bool DINCOUTPUTEQVECTOR_A21558_HiddenStatic
		{
			get
			{
				short num = (short)824311808;
				short num2 = num;
				num = (short)130585191;
				short num3 = num;
				num = (short)1909559911;
				switch (num3 == num)
				{
				}
				num = (short)340459521;
				if (num != 0)
				{
				}
				num = (short)2042626048;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.HiddenStatic;
			}
			set
			{
				short num = (short)196214784;
				short num2 = num;
				num = (short)1893435441;
				short num3 = num;
				num = (short)1871349809;
				switch (num3 == num)
				{
				}
				num = (short)1770455041;
				if (num != 0)
				{
				}
				num = (short)491126784;
				if (num != 0)
				{
				}
				this.dINCOUTPUTEQVECTOR_A21558.HiddenStatic = value;
			}
		}

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x06006BAF RID: 27567 RVA: 0x00601BA0 File Offset: 0x005FFDA0
		// (set) Token: 0x06006BB0 RID: 27568 RVA: 0x00601C58 File Offset: 0x005FFE58
		internal bool DINCOUTPUTEQVECTOR_A21558_HiddenDynamic
		{
			get
			{
				short num = (short)1684865024;
				short num2 = num;
				num = (short)1412254510;
				short num3 = num;
				num = (short)1424509742;
				switch (num3 == num)
				{
				}
				num = (short)1458765825;
				if (num != 0)
				{
				}
				num = (short)1489174528;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558.HiddenDynamic;
			}
			set
			{
				short num = (short)120324096;
				short num2 = num;
				num = (short)137926558;
				short num3 = num;
				num = (short)113481630;
				switch (num3 == num)
				{
				}
				num = (short)1814429696;
				if (num != 0)
				{
				}
				num = (short)1388511233;
				if (num != 0)
				{
				}
				this.dINCOUTPUTEQVECTOR_A21558.HiddenDynamic = value;
			}
		}

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x00601D10 File Offset: 0x005FFF10
		public bool DINCOUTPUTEQVECTOR_A21558_HasDiffs
		{
			get
			{
				short num = (short)1235419136;
				short num2 = num;
				num = (short)1948924377;
				short num3 = num;
				num = (short)1694513625;
				switch (num3 == num)
				{
				}
				num = (short)1101004801;
				if (num != 0)
				{
				}
				num = (short)1625030656;
				if (num != 0)
				{
				}
				return this.dINCOUTPUTEQVECTOR_A21558._HasDiffs;
			}
		}

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x06006BB2 RID: 27570 RVA: 0x00601DC4 File Offset: 0x005FFFC4
		// (set) Token: 0x06006BB3 RID: 27571 RVA: 0x00601E7C File Offset: 0x0060007C
		public string DINCBFEQVECTOR_A21557Value
		{
			get
			{
				short num = (short)150536192;
				short num2 = num;
				num = (short)1443364865;
				if (num != 0)
				{
				}
				num = (short)1693291722;
				short num3 = num;
				num = (short)11637962;
				switch (num3 == num)
				{
				}
				num = (short)1341521920;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.Value;
			}
			set
			{
				short num = (short)1813184512;
				short num2 = num;
				num = (short)1652254645;
				short num3 = num;
				num = (short)1096181685;
				switch (num3 == num)
				{
				}
				num = (short)1728970752;
				if (num != 0)
				{
				}
				num = (short)1514864641;
				if (num != 0)
				{
				}
				this.dINCBFEQVECTOR_A21557.Value = value;
			}
		}

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x06006BB4 RID: 27572 RVA: 0x00601F34 File Offset: 0x00600134
		public global::AcpBusinessLayer.AcpField<string> DINCBFEQVECTOR_A21557
		{
			get
			{
				short num = (short)1425539072;
				short num2 = num;
				num = (short)584463924;
				short num3 = num;
				num = (short)28194356;
				switch (num3 == num)
				{
				}
				num = (short)2040791041;
				if (num != 0)
				{
				}
				num = (short)2112946176;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557;
			}
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x00601FE4 File Offset: 0x006001E4
		// (set) Token: 0x06006BB6 RID: 27574 RVA: 0x006020A0 File Offset: 0x006002A0
		public string DINCBFEQVECTOR_A21557_UIValue
		{
			get
			{
				short num = (short)1044512768;
				short num2 = num;
				num = (short)38404097;
				if (num != 0)
				{
				}
				num = (short)1097869652;
				short num3 = num;
				num = (short)1420437844;
				switch (num3 == num)
				{
				}
				num = (short)946274304;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.Value;
			}
			set
			{
				short num = (short)1208352768;
				short num2 = num;
				num = (short)1446957724;
				short num3 = num;
				num = (short)1635635868;
				switch (num3 == num)
				{
				}
				num = (short)44105729;
				if (num != 0)
				{
				}
				num = (short)1812463616;
				if (num != 0)
				{
				}
				this.dINCBFEQVECTOR_A21557.Value = value;
			}
		}

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x06006BB7 RID: 27575 RVA: 0x00602158 File Offset: 0x00600358
		// (set) Token: 0x06006BB8 RID: 27576 RVA: 0x0060220C File Offset: 0x0060040C
		public bool DINCBFEQVECTOR_A21557_Applicable
		{
			get
			{
				short num = (short)1516371968;
				short num2 = num;
				num = (short)2004382107;
				short num3 = num;
				num = (short)410022299;
				switch (num3 == num)
				{
				}
				num = (short)390397953;
				if (num != 0)
				{
				}
				num = (short)672333824;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.Applicable;
			}
			set
			{
				short num = (short)1796145152;
				short num2 = num;
				num = (short)457768922;
				short num3 = num;
				num = (short)1608908762;
				switch (num3 == num)
				{
				}
				num = (short)1568473089;
				if (num != 0)
				{
				}
				num = (short)1872822272;
				if (num != 0)
				{
				}
				this.dINCBFEQVECTOR_A21557.Applicable = value;
			}
		}

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x006022C0 File Offset: 0x006004C0
		// (set) Token: 0x06006BBA RID: 27578 RVA: 0x00602378 File Offset: 0x00600578
		public bool DINCBFEQVECTOR_A21557_Valid
		{
			get
			{
				short num = (short)189005824;
				short num2 = num;
				num = (short)1762263041;
				if (num != 0)
				{
				}
				num = (short)1188344443;
				short num3 = num;
				num = (short)488944251;
				switch (num3 == num)
				{
				}
				num = (short)1364066304;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.Valid;
			}
			set
			{
				short num = (short)2109014016;
				short num2 = num;
				num = (short)203423745;
				if (num != 0)
				{
				}
				num = (short)1038676646;
				short num3 = num;
				num = (short)165802662;
				switch (num3 == num)
				{
				}
				num = (short)903217152;
				if (num != 0)
				{
				}
				this.dINCBFEQVECTOR_A21557.Valid = value;
			}
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x06006BBB RID: 27579 RVA: 0x00602430 File Offset: 0x00600630
		// (set) Token: 0x06006BBC RID: 27580 RVA: 0x006024E4 File Offset: 0x006006E4
		public bool DINCBFEQVECTOR_A21557_Visible
		{
			get
			{
				short num = (short)1579493755;
				short num2 = num;
				num = (short)1724197243;
				switch (num2 == num)
				{
				}
				num = (short)1917517824;
				short num3 = num;
				num = (short)1204551681;
				if (num != 0)
				{
				}
				num = (short)667877376;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.Visible;
			}
			set
			{
				short num = (short)1200940650;
				short num2 = num;
				num = (short)1515710058;
				switch (num2 == num)
				{
				}
				num = (short)1312423936;
				short num3 = num;
				num = (short)1300824065;
				if (num != 0)
				{
				}
				num = (short)388431872;
				if (num != 0)
				{
				}
				this.dINCBFEQVECTOR_A21557.Visible = value;
			}
		}

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x06006BBD RID: 27581 RVA: 0x00602598 File Offset: 0x00600798
		// (set) Token: 0x06006BBE RID: 27582 RVA: 0x0060264C File Offset: 0x0060084C
		public bool DINCBFEQVECTOR_A21557_Editable
		{
			get
			{
				short num = (short)2075411933;
				short num2 = num;
				num = (short)1217283549;
				switch (num2 == num)
				{
				}
				num = (short)360841216;
				short num3 = num;
				num = (short)546963456;
				if (num != 0)
				{
				}
				num = (short)1056440321;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.Editable;
			}
			set
			{
				short num = (short)668109910;
				short num2 = num;
				num = (short)1030458454;
				switch (num2 == num)
				{
				}
				num = (short)266600448;
				short num3 = num;
				num = (short)160890880;
				if (num != 0)
				{
				}
				num = (short)345833473;
				if (num != 0)
				{
				}
				this.dINCBFEQVECTOR_A21557.Editable = value;
			}
		}

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x06006BBF RID: 27583 RVA: 0x00602700 File Offset: 0x00600900
		internal string DINCBFEQVECTOR_A21557_UILabel
		{
			get
			{
				short num = (short)2049298246;
				short num2 = num;
				num = (short)805621574;
				switch (num2 == num)
				{
				}
				num = (short)1630863360;
				short num3 = num;
				num = (short)447873025;
				if (num != 0)
				{
				}
				num = (short)1114112;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.UIName;
			}
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x06006BC0 RID: 27584 RVA: 0x006027B8 File Offset: 0x006009B8
		// (set) Token: 0x06006BC1 RID: 27585 RVA: 0x0060286C File Offset: 0x00600A6C
		internal bool DINCBFEQVECTOR_A21557_HiddenStatic
		{
			get
			{
				short num = (short)1366342342;
				short num2 = num;
				num = (short)930396870;
				switch (num2 == num)
				{
				}
				num = (short)745013248;
				short num3 = num;
				num = (short)1681260545;
				if (num != 0)
				{
				}
				num = (short)631111680;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.HiddenStatic;
			}
			set
			{
				short num = (short)2111363307;
				short num2 = num;
				num = (short)2015615211;
				switch (num2 == num)
				{
				}
				num = (short)213581824;
				short num3 = num;
				num = (short)177602561;
				if (num != 0)
				{
				}
				num = (short)1373896704;
				if (num != 0)
				{
				}
				this.dINCBFEQVECTOR_A21557.HiddenStatic = value;
			}
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x06006BC2 RID: 27586 RVA: 0x00602924 File Offset: 0x00600B24
		// (set) Token: 0x06006BC3 RID: 27587 RVA: 0x006029DC File Offset: 0x00600BDC
		internal bool DINCBFEQVECTOR_A21557_HiddenDynamic
		{
			get
			{
				short num = (short)1422410523;
				short num2 = num;
				num = (short)539509531;
				switch (num2 == num)
				{
				}
				num = (short)776339456;
				short num3 = num;
				num = (short)824377345;
				if (num != 0)
				{
				}
				num = (short)1834483712;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557.HiddenDynamic;
			}
			set
			{
				short num = (short)290695432;
				short num2 = num;
				num = (short)1474144520;
				switch (num2 == num)
				{
				}
				num = (short)703725568;
				short num3 = num;
				num = (short)374079488;
				if (num != 0)
				{
				}
				num = (short)454426625;
				if (num != 0)
				{
				}
				this.dINCBFEQVECTOR_A21557.HiddenDynamic = value;
			}
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x06006BC4 RID: 27588 RVA: 0x00602A90 File Offset: 0x00600C90
		public bool DINCBFEQVECTOR_A21557_HasDiffs
		{
			get
			{
				short num = (short)1332740097;
				if (num != 0)
				{
				}
				num = (short)1802671934;
				short num2 = num;
				num = (short)1176934206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)419692544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)204996608;
				if (num != 0)
				{
				}
				return this.dINCBFEQVECTOR_A21557._HasDiffs;
			}
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x06006BC5 RID: 27589 RVA: 0x00602B44 File Offset: 0x00600D44
		// (set) Token: 0x06006BC6 RID: 27590 RVA: 0x00602BFC File Offset: 0x00600DFC
		public string DINCSPATIALEQ1VECTOR_A21553Value
		{
			get
			{
				short num = (short)1996525627;
				short num2 = num;
				num = (short)1601146939;
				switch (num2 == num)
				{
				}
				num = (short)775553024;
				short num3 = num;
				num = (short)1421737985;
				if (num != 0)
				{
				}
				num = (short)1500839936;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.Value;
			}
			set
			{
				short num = (short)822220185;
				short num2 = num;
				num = (short)1001330073;
				switch (num2 == num)
				{
				}
				num = (short)350224384;
				short num3 = num;
				num = (short)286916609;
				if (num != 0)
				{
				}
				num = (short)2102853632;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTOR_A21553.Value = value;
			}
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x06006BC7 RID: 27591 RVA: 0x00602CB0 File Offset: 0x00600EB0
		public global::AcpBusinessLayer.AcpField<string> DINCSPATIALEQ1VECTOR_A21553
		{
			get
			{
				short num = (short)1135095387;
				short num2 = num;
				num = (short)494874203;
				switch (num2 == num)
				{
				}
				num = (short)354615296;
				short num3 = num;
				num = (short)1768751105;
				if (num != 0)
				{
				}
				num = (short)452067328;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553;
			}
		}

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x06006BC8 RID: 27592 RVA: 0x00602D5C File Offset: 0x00600F5C
		// (set) Token: 0x06006BC9 RID: 27593 RVA: 0x00602E10 File Offset: 0x00601010
		public string DINCSPATIALEQ1VECTOR_A21553_UIValue
		{
			get
			{
				short num = (short)421986305;
				if (num != 0)
				{
				}
				num = (short)1938234406;
				short num2 = num;
				num = (short)2102402086;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1036845056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1176043520;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.Value;
			}
			set
			{
				short num = (short)314572505;
				short num2 = num;
				num = (short)1279459033;
				switch (num2 == num)
				{
				}
				num = (short)1959395328;
				short num3 = num;
				num = (short)1668022273;
				if (num != 0)
				{
				}
				num = (short)1279655936;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTOR_A21553.Value = value;
			}
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x06006BCA RID: 27594 RVA: 0x00602EC8 File Offset: 0x006010C8
		// (set) Token: 0x06006BCB RID: 27595 RVA: 0x00602F7C File Offset: 0x0060117C
		public bool DINCSPATIALEQ1VECTOR_A21553_Applicable
		{
			get
			{
				short num = (short)550396282;
				short num2 = num;
				num = (short)1484808570;
				switch (num2 == num)
				{
				}
				num = (short)738131968;
				short num3 = num;
				num = (short)269680641;
				if (num != 0)
				{
				}
				num = (short)149487616;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.Applicable;
			}
			set
			{
				short num = (short)981860353;
				if (num != 0)
				{
				}
				num = (short)1457407397;
				short num2 = num;
				num = (short)1505248677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97910784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)383254528;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTOR_A21553.Applicable = value;
			}
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x06006BCC RID: 27596 RVA: 0x00603030 File Offset: 0x00601230
		// (set) Token: 0x06006BCD RID: 27597 RVA: 0x006030E8 File Offset: 0x006012E8
		public bool DINCSPATIALEQ1VECTOR_A21553_Valid
		{
			get
			{
				short num = (short)157296654;
				short num2 = num;
				num = (short)451946510;
				switch (num2 == num)
				{
				}
				num = (short)1649213440;
				short num3 = num;
				num = (short)1503264768;
				if (num != 0)
				{
				}
				num = (short)1729757185;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.Valid;
			}
			set
			{
				short num = (short)1405500654;
				short num2 = num;
				num = (short)696728814;
				switch (num2 == num)
				{
				}
				num = (short)162201600;
				short num3 = num;
				num = (short)508821504;
				if (num != 0)
				{
				}
				num = (short)34471937;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTOR_A21553.Valid = value;
			}
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x06006BCE RID: 27598 RVA: 0x0060319C File Offset: 0x0060139C
		// (set) Token: 0x06006BCF RID: 27599 RVA: 0x00603250 File Offset: 0x00601450
		public bool DINCSPATIALEQ1VECTOR_A21553_Visible
		{
			get
			{
				short num = (short)1735384755;
				short num2 = num;
				num = (short)520806067;
				switch (num2 == num)
				{
				}
				num = (short)7340032;
				short num3 = num;
				num = (short)1271857153;
				if (num != 0)
				{
				}
				num = (short)139067392;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.Visible;
			}
			set
			{
				short num = (short)1168477432;
				short num2 = num;
				num = (short)697666808;
				switch (num2 == num)
				{
				}
				num = (short)1479081984;
				short num3 = num;
				num = (short)48431105;
				if (num != 0)
				{
				}
				num = (short)1005584384;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTOR_A21553.Visible = value;
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x06006BD0 RID: 27600 RVA: 0x00603304 File Offset: 0x00601504
		// (set) Token: 0x06006BD1 RID: 27601 RVA: 0x006033B8 File Offset: 0x006015B8
		public bool DINCSPATIALEQ1VECTOR_A21553_Editable
		{
			get
			{
				short num = (short)1069354589;
				short num2 = num;
				num = (short)1100025437;
				switch (num2 == num)
				{
				}
				num = (short)788725760;
				short num3 = num;
				num = (short)185663488;
				if (num != 0)
				{
				}
				num = (short)900595713;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.Editable;
			}
			set
			{
				short num = (short)1717950031;
				short num2 = num;
				num = (short)583915087;
				switch (num2 == num)
				{
				}
				num = (short)490668032;
				short num3 = num;
				num = (short)292421632;
				if (num != 0)
				{
				}
				num = (short)1427308545;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTOR_A21553.Editable = value;
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x06006BD2 RID: 27602 RVA: 0x00603470 File Offset: 0x00601670
		internal string DINCSPATIALEQ1VECTOR_A21553_UILabel
		{
			get
			{
				short num = (short)128021025;
				short num2 = num;
				num = (short)1312191009;
				switch (num2 == num)
				{
				}
				num = (short)2133721088;
				short num3 = num;
				num = (short)53542913;
				if (num != 0)
				{
				}
				num = (short)406454272;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.UIName;
			}
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x06006BD3 RID: 27603 RVA: 0x00603524 File Offset: 0x00601724
		// (set) Token: 0x06006BD4 RID: 27604 RVA: 0x006035D8 File Offset: 0x006017D8
		internal bool DINCSPATIALEQ1VECTOR_A21553_HiddenStatic
		{
			get
			{
				short num = (short)2097872897;
				if (num != 0)
				{
				}
				num = (short)130607748;
				short num2 = num;
				num = (short)1156180612;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117061120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351483392;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.HiddenStatic;
			}
			set
			{
				short num = (short)410714113;
				if (num != 0)
				{
				}
				num = (short)2057353120;
				short num2 = num;
				num = (short)1282586528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)887947264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2019164160;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTOR_A21553.HiddenStatic = value;
			}
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x06006BD5 RID: 27605 RVA: 0x00603690 File Offset: 0x00601890
		// (set) Token: 0x06006BD6 RID: 27606 RVA: 0x00603744 File Offset: 0x00601944
		internal bool DINCSPATIALEQ1VECTOR_A21553_HiddenDynamic
		{
			get
			{
				short num = (short)259850241;
				if (num != 0)
				{
				}
				num = (short)1939879636;
				short num2 = num;
				num = (short)1419458260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1390280704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1148518400;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553.HiddenDynamic;
			}
			set
			{
				short num = (short)1346369113;
				short num2 = num;
				num = (short)2080634457;
				switch (num2 == num)
				{
				}
				num = (short)1680998400;
				short num3 = num;
				num = (short)272367617;
				if (num != 0)
				{
				}
				num = (short)1890189312;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ1VECTOR_A21553.HiddenDynamic = value;
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x06006BD7 RID: 27607 RVA: 0x006037F8 File Offset: 0x006019F8
		public bool DINCSPATIALEQ1VECTOR_A21553_HasDiffs
		{
			get
			{
				short num = (short)18612225;
				if (num != 0)
				{
				}
				num = (short)1881872969;
				short num2 = num;
				num = (short)1927551561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1447886848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)816971776;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ1VECTOR_A21553._HasDiffs;
			}
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x06006BD8 RID: 27608 RVA: 0x006038AC File Offset: 0x00601AAC
		// (set) Token: 0x06006BD9 RID: 27609 RVA: 0x00603964 File Offset: 0x00601B64
		public string DINCSPATIALEQ2VECTOR_A21556Value
		{
			get
			{
				short num = (short)2143844394;
				short num2 = num;
				num = (short)1136556074;
				switch (num2 == num)
				{
				}
				num = (short)1319960576;
				short num3 = num;
				num = (short)270467073;
				if (num != 0)
				{
				}
				num = (short)1253310464;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.Value;
			}
			set
			{
				short num = (short)1701837114;
				short num2 = num;
				num = (short)707524922;
				switch (num2 == num)
				{
				}
				num = (short)986447872;
				short num3 = num;
				num = (short)2139750401;
				if (num != 0)
				{
				}
				num = (short)1395589120;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTOR_A21556.Value = value;
			}
		}

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x06006BDA RID: 27610 RVA: 0x00603A1C File Offset: 0x00601C1C
		public global::AcpBusinessLayer.AcpField<string> DINCSPATIALEQ2VECTOR_A21556
		{
			get
			{
				short num = (short)1362296850;
				short num2 = num;
				num = (short)397738002;
				switch (num2 == num)
				{
				}
				num = (short)117243904;
				short num3 = num;
				num = (short)603127809;
				if (num != 0)
				{
				}
				num = (short)1306460160;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556;
			}
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x06006BDB RID: 27611 RVA: 0x00603ACC File Offset: 0x00601CCC
		// (set) Token: 0x06006BDC RID: 27612 RVA: 0x00603B88 File Offset: 0x00601D88
		public string DINCSPATIALEQ2VECTOR_A21556_UIValue
		{
			get
			{
				short num = (short)980475059;
				short num2 = num;
				num = (short)2048515251;
				switch (num2 == num)
				{
				}
				num = (short)306315264;
				short num3 = num;
				num = (short)59179009;
				if (num != 0)
				{
				}
				num = (short)437452800;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.Value;
			}
			set
			{
				short num = (short)673856980;
				short num2 = num;
				num = (short)1933589972;
				switch (num2 == num)
				{
				}
				num = (short)382730240;
				short num3 = num;
				num = (short)1322647553;
				if (num != 0)
				{
				}
				num = (short)1096941568;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTOR_A21556.Value = value;
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x06006BDD RID: 27613 RVA: 0x00603C40 File Offset: 0x00601E40
		// (set) Token: 0x06006BDE RID: 27614 RVA: 0x00603CF4 File Offset: 0x00601EF4
		public bool DINCSPATIALEQ2VECTOR_A21556_Applicable
		{
			get
			{
				short num = (short)1654486941;
				short num2 = num;
				num = (short)2122610589;
				switch (num2 == num)
				{
				}
				num = (short)996605952;
				short num3 = num;
				num = (short)2119958528;
				if (num != 0)
				{
				}
				num = (short)1803288577;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.Applicable;
			}
			set
			{
				short num = (short)1628505061;
				short num2 = num;
				num = (short)730334181;
				switch (num2 == num)
				{
				}
				num = (short)1678770176;
				short num3 = num;
				num = (short)209780736;
				if (num != 0)
				{
				}
				num = (short)1620377601;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTOR_A21556.Applicable = value;
			}
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x06006BDF RID: 27615 RVA: 0x00603DA8 File Offset: 0x00601FA8
		// (set) Token: 0x06006BE0 RID: 27616 RVA: 0x00603E60 File Offset: 0x00602060
		public bool DINCSPATIALEQ2VECTOR_A21556_Valid
		{
			get
			{
				short num = (short)556408425;
				short num2 = num;
				num = (short)1702239849;
				switch (num2 == num)
				{
				}
				num = (short)343736320;
				short num3 = num;
				num = (short)1306984449;
				if (num != 0)
				{
				}
				num = (short)737345536;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.Valid;
			}
			set
			{
				short num = (short)1648702458;
				short num2 = num;
				num = (short)1130050554;
				switch (num2 == num)
				{
				}
				num = (short)919535616;
				short num3 = num;
				num = (short)1398996993;
				if (num != 0)
				{
				}
				num = (short)452526080;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTOR_A21556.Valid = value;
			}
		}

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x06006BE1 RID: 27617 RVA: 0x00603F18 File Offset: 0x00602118
		// (set) Token: 0x06006BE2 RID: 27618 RVA: 0x00603FD0 File Offset: 0x006021D0
		public bool DINCSPATIALEQ2VECTOR_A21556_Visible
		{
			get
			{
				short num = (short)333774849;
				if (num != 0)
				{
				}
				num = (short)1307118190;
				short num2 = num;
				num = (short)1272711790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2071658496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)735051776;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.Visible;
			}
			set
			{
				short num = (short)653450384;
				short num2 = num;
				num = (short)825810064;
				switch (num2 == num)
				{
				}
				num = (short)119537664;
				short num3 = num;
				num = (short)105316353;
				if (num != 0)
				{
				}
				num = (short)1733951488;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTOR_A21556.Visible = value;
			}
		}

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x06006BE3 RID: 27619 RVA: 0x00604088 File Offset: 0x00602288
		// (set) Token: 0x06006BE4 RID: 27620 RVA: 0x0060413C File Offset: 0x0060233C
		public bool DINCSPATIALEQ2VECTOR_A21556_Editable
		{
			get
			{
				short num = (short)708853419;
				short num2 = num;
				num = (short)207765163;
				switch (num2 == num)
				{
				}
				num = (short)2035744768;
				short num3 = num;
				num = (short)1589706753;
				if (num != 0)
				{
				}
				num = (short)1651179520;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.Editable;
			}
			set
			{
				short num = (short)1098796876;
				short num2 = num;
				num = (short)1137463116;
				switch (num2 == num)
				{
				}
				num = (short)881262592;
				short num3 = num;
				num = (short)36438017;
				if (num != 0)
				{
				}
				num = (short)1644625920;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTOR_A21556.Editable = value;
			}
		}

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x06006BE5 RID: 27621 RVA: 0x006041F0 File Offset: 0x006023F0
		internal string DINCSPATIALEQ2VECTOR_A21556_UILabel
		{
			get
			{
				short num = (short)572120873;
				short num2 = num;
				num = (short)183951145;
				switch (num2 == num)
				{
				}
				num = (short)1249312768;
				short num3 = num;
				num = (short)1581187073;
				if (num != 0)
				{
				}
				num = (short)418054144;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.UIName;
			}
		}

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x06006BE6 RID: 27622 RVA: 0x006042A8 File Offset: 0x006024A8
		// (set) Token: 0x06006BE7 RID: 27623 RVA: 0x00604358 File Offset: 0x00602558
		internal bool DINCSPATIALEQ2VECTOR_A21556_HiddenStatic
		{
			get
			{
				short num = (short)2017702895;
				short num2 = num;
				num = (short)881374191;
				switch (num2 == num)
				{
				}
				num = (short)410714112;
				short num3 = num;
				num = (short)566296577;
				if (num != 0)
				{
				}
				num = (short)267190272;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.HiddenStatic;
			}
			set
			{
				short num = (short)1999898467;
				short num2 = num;
				num = (short)650250083;
				switch (num2 == num)
				{
				}
				num = (short)321323008;
				short num3 = num;
				num = (short)2128019457;
				if (num != 0)
				{
				}
				num = (short)1808334848;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTOR_A21556.HiddenStatic = value;
			}
		}

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x06006BE8 RID: 27624 RVA: 0x0060440C File Offset: 0x0060260C
		// (set) Token: 0x06006BE9 RID: 27625 RVA: 0x006044C0 File Offset: 0x006026C0
		internal bool DINCSPATIALEQ2VECTOR_A21556_HiddenDynamic
		{
			get
			{
				short num = (short)709174335;
				short num2 = num;
				num = (short)2100372543;
				switch (num2 == num)
				{
				}
				num = (short)954728448;
				short num3 = num;
				num = (short)294912001;
				if (num != 0)
				{
				}
				num = (short)1476722688;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556.HiddenDynamic;
			}
			set
			{
				short num = (short)979396206;
				short num2 = num;
				num = (short)220948078;
				switch (num2 == num)
				{
				}
				num = (short)110624768;
				short num3 = num;
				num = (short)863698944;
				if (num != 0)
				{
				}
				num = (short)802422785;
				if (num != 0)
				{
				}
				this.dINCSPATIALEQ2VECTOR_A21556.HiddenDynamic = value;
			}
		}

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x06006BEA RID: 27626 RVA: 0x00604574 File Offset: 0x00602774
		public bool DINCSPATIALEQ2VECTOR_A21556_HasDiffs
		{
			get
			{
				short num = (short)155274126;
				short num2 = num;
				num = (short)1623739278;
				switch (num2 == num)
				{
				}
				num = (short)2043740160;
				short num3 = num;
				num = (short)90832897;
				if (num != 0)
				{
				}
				num = (short)578355200;
				if (num != 0)
				{
				}
				return this.dINCSPATIALEQ2VECTOR_A21556._HasDiffs;
			}
		}

		// Token: 0x06006BEB RID: 27627 RVA: 0x0060462C File Offset: 0x0060282C
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
					num2 = (short)409745243;
					short num3 = num2;
					num2 = (short)389429083;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_148;
					default:
						goto IL_10D;
					}
					break;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_148;
					}
					return result;
				case 2:
					num2 = (short)1555169281;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)2009595904;
					short num4 = num2;
					num2 = (short)27590656;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1554644994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_148:
				num2 = (short)588906499;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10D:
			num2 = (short)2043674624;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			num2 = (short)316342273;
			if (num2 != 0)
			{
			}
			result = null;
			num2 = (short)878903300;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040029F6 RID: 10742
		private global::AcpBusinessLayer.AcpSimpleRangeField dINCHOTBEAMHYSTERESIS_A21559;

		// Token: 0x040029F7 RID: 10743
		private global::AcpBusinessLayer.AcpSimpleRangeField dINCBADMICHYSTERESIS_A21560;

		// Token: 0x040029F8 RID: 10744
		private global::AcpBusinessLayer.AcpField<string> dINCSPATIALEQ1VECTORCONT_A37716;

		// Token: 0x040029F9 RID: 10745
		private global::AcpBusinessLayer.AcpField<string> dINCSPATIALEQ2VECTORCONT_A37717;

		// Token: 0x040029FA RID: 10746
		private global::AcpBusinessLayer.AcpField<string> dINCELKOVECTOR_A21561;

		// Token: 0x040029FB RID: 10747
		private global::AcpBusinessLayer.AcpField<string> dINCOUTPUTEQVECTOR_A21558;

		// Token: 0x040029FC RID: 10748
		private global::AcpBusinessLayer.AcpField<string> dINCBFEQVECTOR_A21557;

		// Token: 0x040029FD RID: 10749
		private global::AcpBusinessLayer.AcpField<string> dINCSPATIALEQ1VECTOR_A21553;

		// Token: 0x040029FE RID: 10750
		private global::AcpBusinessLayer.AcpField<string> dINCSPATIALEQ2VECTOR_A21556;
	}
}
