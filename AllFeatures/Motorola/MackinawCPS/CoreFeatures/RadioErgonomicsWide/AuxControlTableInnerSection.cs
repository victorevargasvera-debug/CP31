using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200021C RID: 540
	[global::System.Serializable]
	public class AuxControlTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006360 RID: 25440 RVA: 0x0058F1E4 File Offset: 0x0058D3E4
		public AuxControlTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06006361 RID: 25441 RVA: 0x0058F200 File Offset: 0x0058D400
		protected AuxControlTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006362 RID: 25442 RVA: 0x0058F218 File Offset: 0x0058D418
		public override void Init()
		{
			int a_ = 14;
			short num = (short)392537682;
			short num2 = num;
			num = (short)579970642;
			switch (num2 == num)
			{
			}
			num = (short)1998782465;
			if (num != 0)
			{
			}
			num = (short)531562496;
			short num3 = num;
			num = (short)208994304;
			if (num != 0)
			{
			}
			this.radErgoWideAuxControlActiveDuration_A37249 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚諜뛞藠蛢ꓤ鋦釨꣪苬臮藰臲髴鯶룸飺觼雾眀昂䄄爆笈樊礌明縐紒䨔嘖⨘Ⱊ⼜⬞ᠠ", a_), global::CommonResources.AcgResources.ID_ACTIVEDURATIONMS, 0, 100, global::CommonResources.AcgResources.ID_MOMENTARY, null, 0, 100);
			this.radErgoWideAuxControlActiveDuration_A37249.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAuxControlActiveDuration_A37249.DataTransferOrder = 61;
			this.radErgoWideAuxControlActiveDuration_A37249.AddCustomValue(65535, global::CommonResources.AcgResources.ID_TOGGLE);
			this.radErgoWideAuxControlActiveDuration_A37249.ShowHexValue = false;
			this.radErgoWideAuxControlAuxOnAlias_A37250 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_CONTROL1ON, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚諜뛞藠蛢ꓤ鋦釨꣪苬臮藰臲髴鯶룸軺藼냾漀䈂椄渆栈砊刌与∐␒✔∖⤘", a_), global::CommonResources.AcgResources.ID_AUXONALIAS, 14);
			this.radErgoWideAuxControlAuxOnAlias_A37250.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAuxControlAuxOnAlias_A37250.DataTransferOrder = 63;
			this.radErgoWideAuxControlAuxOffAlias_A37252 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_CONTROL1OFF, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚諜뛞藠蛢ꓤ鋦釨꣪苬臮藰臲髴鯶룸軺藼냾最攂䐄欆怈樊縌倎倐‒∔┖Ⱈ⤚", a_), global::CommonResources.AcgResources.ID_AUXOFFALIAS, 14);
			this.radErgoWideAuxControlAuxOffAlias_A37252.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAuxControlAuxOffAlias_A37252.DataTransferOrder = 64;
			this.radErgoWideAuxControlAbbrAuxOnAlias_A37612 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_AUX1, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚諜뛞藠蛢ꓤ鋦釨꣪苬臮藰臲髴鯶룸駺鿼跾䀀瘂約䠆月䨊愌明瀐怒䨔嘖⨘Ⱊ⬜⸞ጠ", a_), global::CommonResources.AcgResources.ID_ABBREVIATEDAUXONALIAS, 4);
			this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.DataTransferOrder = 62;
			this.radErgoWideAuxControlAuxCtrlName_A37714 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚諜뛞藠蛢ꓤ鋦釨꣪苬臮藰臲髴鯶룸軺藼볾甀焂椄䤆栈昊栌倎倐‒∔‖⠘⼚", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoWideAuxControlAuxCtrlName_A37714.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoWideAuxControlAuxCtrlName_A37714.DataTransferOrder = 65;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軎ꓐꯒ铖뛘뗚꧜귞軠迢엤돦裨觪臬諮", a_);
			base.Id = 10634;
			base.UIName = global::CommonResources.AcgResources.ID_AUXCONTROLTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006363 RID: 25443 RVA: 0x0058F458 File Offset: 0x0058D658
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)99155985;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoWideAuxControlAuxCtrlName_A37714 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫鯭裯뇱胳蓵铷듹鷻鏽旿崁䔃㔅㼇㴉㴋㨍", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgoWideAuxControlAuxCtrlName_A37714.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAuxControlAuxCtrlName_A37714.DataTransferOrder = 65;
					num = (short)1382219788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.radErgoWideAuxControlAuxOnAlias_A37250 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_CONTROL1ON, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫鯭裯뷱髳럵铷鏹鷻跽忿䌁㜃ㄅ㨇㼉㰋", a_), global::CommonResources.AcgResources.ID_AUXONALIAS, 14);
					this.radErgoWideAuxControlAuxOnAlias_A37250.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAuxControlAuxOnAlias_A37250.DataTransferOrder = 63;
					num = (short)536018953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1757741066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫賭鋯胱뗳菵胷뗹鋻뿽泿欁攃甅圇䬉㼋㤍☏⌑☓", a_)))
					{
						goto IL_CD;
					}
					goto IL_1AA;
				case 4:
					this.radErgoWideAuxControlAbbrAuxOnAlias_A37612 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_AUX1, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫賭鋯胱뗳菵胷뗹鋻뿽泿欁攃甅圇䬉㼋㤍☏⌑☓", a_), global::CommonResources.AcgResources.ID_ABBREVIATEDAUXONALIAS, 4);
					this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.DataTransferOrder = 62;
					num = (short)1093271567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_9D;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫鯭裯뷱髳럵铷鏹鷻跽忿䌁㜃ㄅ㨇㼉㰋", a_)))
					{
						num = (short)1889730561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_110;
				case 7:
					num = (short)454492176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_461;
				case 9:
					goto IL_110;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫跭蓯鯱苳鏵볷迹軻鿽瓿欁欃栅圇䬉㼋㤍∏☑ⴓ", a_)))
					{
						num = (short)235208717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_461;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫鯭裯뇱胳蓵铷듹鷻鏽旿崁䔃㔅㼇㴉㴋㨍", a_)))
					{
						num = (short)1273233408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AD;
				case 12:
					goto IL_2DF;
				case 13:
				{
					this.radErgoWideAuxControlActiveDuration_A37249 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫跭蓯鯱苳鏵볷迹軻鿽瓿欁欃栅圇䬉㼋㤍∏☑ⴓ", a_), global::CommonResources.AcgResources.ID_ACTIVEDURATIONMS, global::CommonResources.AcgResources.ID_MOMENTARY, null, 0, 100);
					this.radErgoWideAuxControlActiveDuration_A37249.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAuxControlActiveDuration_A37249.DataTransferOrder = 61;
					this.radErgoWideAuxControlActiveDuration_A37249.AddCustomValue(65535, global::CommonResources.AcgResources.ID_TOGGLE);
					this.radErgoWideAuxControlActiveDuration_A37249.ShowHexValue = false;
					num = (short)602780370;
					short num3 = num;
					num = (short)1116320466;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD;
					default:
						num = (short)950075392;
						if (num != 0)
						{
						}
						num = (short)1476329480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					this.radErgoWideAuxControlAuxOffAlias_A37252 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_CONTROL1OFF, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫鯭裯뷱鋳郵맷雹闻鿽珿崁䔃㔅㼇㠉㤋㰍", a_), global::CommonResources.AcgResources.ID_AUXOFFALIAS, 14);
					this.radErgoWideAuxControlAuxOffAlias_A37252.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoWideAuxControlAuxOffAlias_A37252.DataTransferOrder = 64;
					num = (short)1643184133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_1AA;
				case 16:
					if (producerFields != null)
					{
						num = (short)252051458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AD;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ蟏믑냓돕駗꿙ꓛ鷝迟賡郣铥蟧蛩귫鯭裯뷱鋳郵맷雹闻鿽珿崁䔃㔅㼇㠉㤋㰍", a_)))
					{
						num = (short)2026766350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D;
				}
				IL_7A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1245191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9D:
				num = (short)2032533507;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD:
				num = (short)1056964609;
				if (num != 0)
				{
				}
				num = (short)519307268;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_110:
				num = (short)2121138194;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AA:
				num = (short)551616523;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_461:
				num = (short)2123497478;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2DF:
			IL_4AD:
			num = (short)877920256;
			short num4 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菁뇃뻅觉ꏋꃍ꓏ꃑ믓뫕軙뷛볝賟蟡", a_);
			base.Id = 10634;
			base.UIName = global::CommonResources.AcgResources.ID_AUXCONTROLTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006364 RID: 25444 RVA: 0x0058F96C File Offset: 0x0058DB6C
		public override void PopulateReferences()
		{
			short num = (short)509697230;
			short num2 = num;
			num = (short)45374670;
			switch (num2 == num)
			{
			}
			num = (short)1544617985;
			if (num != 0)
			{
			}
			num = (short)2090205184;
			short num3 = num;
			num = (short)1783627776;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006365 RID: 25445 RVA: 0x0058FA14 File Offset: 0x0058DC14
		public override void DropReferences()
		{
			short num = (short)902226131;
			short num2 = num;
			num = (short)342089939;
			switch (num2 == num)
			{
			}
			num = (short)1318977537;
			if (num != 0)
			{
			}
			num = (short)2111176704;
			short num3 = num;
			num = (short)731512832;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006366 RID: 25446 RVA: 0x0058FABC File Offset: 0x0058DCBC
		public override void SetConstraints()
		{
			short num = (short)1464606931;
			short num2 = num;
			num = (short)2097488083;
			switch (num2 == num)
			{
			}
			num = (short)835715073;
			if (num != 0)
			{
			}
			num = (short)1420558336;
			short num3 = num;
			num = (short)1021378560;
			if (num != 0)
			{
			}
			this.radErgoWideAuxControlActiveDuration_A37249.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConDualRadioSystemIsNOTSecondaryApp);
			this.radErgoWideAuxControlAuxOnAlias_A37250.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConAuxOnAliasNotEmpty);
			this.radErgoWideAuxControlAuxOffAlias_A37252.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.conActiveDurationIsNotMomentary);
			this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConAbbreviatedAuxOnAliasNotEmpty);
			this.radErgoWideAuxControlAuxCtrlName_A37714.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06006367 RID: 25447 RVA: 0x0058FBDC File Offset: 0x0058DDDC
		public override void SetupDependencies()
		{
			short num = (short)1292424391;
			short num2 = num;
			num = (short)899667143;
			switch (num2 == num)
			{
			}
			num = (short)578879488;
			if (num != 0)
			{
			}
			num = (short)481361920;
			short num3 = num;
			num = (short)2041446401;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideAuxControlActiveDuration_A37249);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideAuxControlAuxOnAlias_A37250);
			this.radErgoWideAuxControlActiveDuration_A37249.AddDependentObject(this.radErgoWideAuxControlAuxOffAlias_A37252);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideAuxControlAuxOffAlias_A37252);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoWideAuxControlAbbrAuxOnAlias_A37612);
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x06006368 RID: 25448 RVA: 0x0058FD0C File Offset: 0x0058DF0C
		public bool HasDiffs
		{
			get
			{
				short num = (short)593302962;
				short num2 = num;
				num = (short)914953650;
				switch (num2 == num)
				{
				}
				num = (short)1811087361;
				if (num != 0)
				{
				}
				num = (short)1582301184;
				short num3 = num;
				num = (short)589627392;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x06006369 RID: 25449 RVA: 0x0058FDC0 File Offset: 0x0058DFC0
		// (set) Token: 0x0600636A RID: 25450 RVA: 0x0058FE70 File Offset: 0x0058E070
		public int RadErgoWideAuxControlActiveDuration_A37249Value
		{
			get
			{
				short num = (short)534315009;
				if (num != 0)
				{
				}
				num = (short)2033449899;
				short num2 = num;
				num = (short)1035860907;
				switch (num2 == num)
				{
				}
				num = (short)1321861120;
				short num3 = num;
				num = (short)443940864;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.Value;
			}
			set
			{
				short num = (short)837802934;
				short num2 = num;
				num = (short)1988942774;
				switch (num2 == num)
				{
				}
				num = (short)1516044288;
				if (num != 0)
				{
				}
				num = (short)1048969216;
				short num3 = num;
				num = (short)325976065;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.Value = value;
			}
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600636B RID: 25451 RVA: 0x0058FF24 File Offset: 0x0058E124
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoWideAuxControlActiveDuration_A37249
		{
			get
			{
				short num = (short)1477598187;
				short num2 = num;
				num = (short)1849777131;
				switch (num2 == num)
				{
				}
				num = (short)1438253056;
				if (num != 0)
				{
				}
				num = (short)1309016064;
				short num3 = num;
				num = (short)1185808385;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249;
			}
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600636C RID: 25452 RVA: 0x0058FFD4 File Offset: 0x0058E1D4
		// (set) Token: 0x0600636D RID: 25453 RVA: 0x00590088 File Offset: 0x0058E288
		public string RadErgoWideAuxControlActiveDuration_A37249_UIValue
		{
			get
			{
				short num = (short)896204801;
				if (num != 0)
				{
				}
				num = (short)1632119642;
				short num2 = num;
				num = (short)1593846618;
				switch (num2 == num)
				{
				}
				num = (short)945094656;
				short num3 = num;
				num = (short)695533568;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.UIValue;
			}
			set
			{
				short num = (short)688769776;
				short num2 = num;
				num = (short)149670640;
				switch (num2 == num)
				{
				}
				num = (short)93388800;
				if (num != 0)
				{
				}
				num = (short)1275592704;
				short num3 = num;
				num = (short)2123563009;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.UIValue = value;
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600636E RID: 25454 RVA: 0x00590140 File Offset: 0x0058E340
		// (set) Token: 0x0600636F RID: 25455 RVA: 0x005901F4 File Offset: 0x0058E3F4
		internal int RadErgoWideAuxControlActiveDuration_A37249Min
		{
			get
			{
				short num = (short)1902483354;
				short num2 = num;
				num = (short)739547034;
				switch (num2 == num)
				{
				}
				num = (short)211353601;
				if (num != 0)
				{
				}
				num = (short)1866137600;
				short num3 = num;
				num = (short)923140096;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.Min;
			}
			set
			{
				short num = (short)1891690580;
				short num2 = num;
				num = (short)2129389652;
				switch (num2 == num)
				{
				}
				num = (short)519962625;
				if (num != 0)
				{
				}
				num = (short)747896832;
				short num3 = num;
				num = (short)2091974656;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.Min = value;
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x06006370 RID: 25456 RVA: 0x005902AC File Offset: 0x0058E4AC
		// (set) Token: 0x06006371 RID: 25457 RVA: 0x00590360 File Offset: 0x0058E560
		internal int RadErgoWideAuxControlActiveDuration_A37249Max
		{
			get
			{
				short num = (short)182004981;
				short num2 = num;
				num = (short)1533357301;
				switch (num2 == num)
				{
				}
				num = (short)992280577;
				if (num != 0)
				{
				}
				num = (short)1411252224;
				short num3 = num;
				num = (short)72417280;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.Max;
			}
			set
			{
				short num = (short)2046622105;
				short num2 = num;
				num = (short)30734745;
				switch (num2 == num)
				{
				}
				num = (short)2024931329;
				if (num != 0)
				{
				}
				num = (short)1237450752;
				short num3 = num;
				num = (short)1289814016;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.Max = value;
			}
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x06006372 RID: 25458 RVA: 0x00590418 File Offset: 0x0058E618
		// (set) Token: 0x06006373 RID: 25459 RVA: 0x005904CC File Offset: 0x0058E6CC
		internal int RadErgoWideAuxControlActiveDuration_A37249Step
		{
			get
			{
				short num = (short)118456307;
				short num2 = num;
				num = (short)188907507;
				switch (num2 == num)
				{
				}
				num = (short)1179649;
				if (num != 0)
				{
				}
				num = (short)6815744;
				short num3 = num;
				num = (short)1246887936;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.StepSize;
			}
			set
			{
				short num = (short)1847180159;
				short num2 = num;
				num = (short)674478975;
				switch (num2 == num)
				{
				}
				num = (short)838467584;
				if (num != 0)
				{
				}
				num = (short)905641984;
				short num3 = num;
				num = (short)1139015681;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.StepSize = value;
			}
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x06006374 RID: 25460 RVA: 0x00590584 File Offset: 0x0058E784
		// (set) Token: 0x06006375 RID: 25461 RVA: 0x00590638 File Offset: 0x0058E838
		public bool RadErgoWideAuxControlActiveDuration_A37249_Applicable
		{
			get
			{
				short num = (short)1078239751;
				short num2 = num;
				num = (short)1442619911;
				switch (num2 == num)
				{
				}
				num = (short)775749632;
				if (num != 0)
				{
				}
				num = (short)1760952320;
				short num3 = num;
				num = (short)341770241;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.Applicable;
			}
			set
			{
				short num = (short)332593438;
				short num2 = num;
				num = (short)1499396382;
				switch (num2 == num)
				{
				}
				num = (short)993853441;
				if (num != 0)
				{
				}
				num = (short)1626800128;
				short num3 = num;
				num = (short)1453588480;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.Applicable = value;
			}
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x06006376 RID: 25462 RVA: 0x005906EC File Offset: 0x0058E8EC
		// (set) Token: 0x06006377 RID: 25463 RVA: 0x005907A0 File Offset: 0x0058E9A0
		public bool RadErgoWideAuxControlActiveDuration_A37249_Valid
		{
			get
			{
				short num = (short)673251329;
				if (num != 0)
				{
				}
				num = (short)1423334795;
				short num2 = num;
				num = (short)634805643;
				switch (num2 == num)
				{
				}
				num = (short)971571200;
				short num3 = num;
				num = (short)2022113280;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.Valid;
			}
			set
			{
				short num = (short)630141782;
				short num2 = num;
				num = (short)1809593174;
				switch (num2 == num)
				{
				}
				num = (short)1869348865;
				if (num != 0)
				{
				}
				num = (short)204144640;
				short num3 = num;
				num = (short)1137573888;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.Valid = value;
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x06006378 RID: 25464 RVA: 0x00590854 File Offset: 0x0058EA54
		// (set) Token: 0x06006379 RID: 25465 RVA: 0x00590908 File Offset: 0x0058EB08
		public bool RadErgoWideAuxControlActiveDuration_A37249_Visible
		{
			get
			{
				short num = (short)408704471;
				short num2 = num;
				num = (short)1632916951;
				switch (num2 == num)
				{
				}
				num = (short)408616960;
				if (num != 0)
				{
				}
				num = (short)1117847552;
				short num3 = num;
				num = (short)306511873;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.Visible;
			}
			set
			{
				short num = (short)267924573;
				short num2 = num;
				num = (short)753415261;
				switch (num2 == num)
				{
				}
				num = (short)876478465;
				if (num != 0)
				{
				}
				num = (short)647954432;
				short num3 = num;
				num = (short)2883584;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.Visible = value;
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600637A RID: 25466 RVA: 0x005909C0 File Offset: 0x0058EBC0
		// (set) Token: 0x0600637B RID: 25467 RVA: 0x00590A74 File Offset: 0x0058EC74
		public bool RadErgoWideAuxControlActiveDuration_A37249_Editable
		{
			get
			{
				short num = (short)1243438453;
				short num2 = num;
				num = (short)1959353717;
				switch (num2 == num)
				{
				}
				num = (short)789250049;
				if (num != 0)
				{
				}
				num = (short)787939328;
				short num3 = num;
				num = (short)2007564288;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.Editable;
			}
			set
			{
				short num = (short)1565458433;
				if (num != 0)
				{
				}
				num = (short)572583716;
				short num2 = num;
				num = (short)406187812;
				switch (num2 == num)
				{
				}
				num = (short)1685389312;
				short num3 = num;
				num = (short)162136064;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.Editable = value;
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600637C RID: 25468 RVA: 0x00590B2C File Offset: 0x0058ED2C
		internal string RadErgoWideAuxControlActiveDuration_A37249_UILabel
		{
			get
			{
				short num = (short)628696047;
				short num2 = num;
				num = (short)1094329327;
				switch (num2 == num)
				{
				}
				num = (short)1399455745;
				if (num != 0)
				{
				}
				num = (short)951451648;
				short num3 = num;
				num = (short)1119617024;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.UIName;
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600637D RID: 25469 RVA: 0x00590BE0 File Offset: 0x0058EDE0
		// (set) Token: 0x0600637E RID: 25470 RVA: 0x00590C94 File Offset: 0x0058EE94
		internal bool RadErgoWideAuxControlActiveDuration_A37249_HiddenStatic
		{
			get
			{
				short num = (short)786217899;
				short num2 = num;
				num = (short)1642904491;
				switch (num2 == num)
				{
				}
				num = (short)1147731969;
				if (num != 0)
				{
				}
				num = (short)457048064;
				short num3 = num;
				num = (short)26411008;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.HiddenStatic;
			}
			set
			{
				short num = (short)1967662660;
				short num2 = num;
				num = (short)1091184196;
				switch (num2 == num)
				{
				}
				num = (short)153747456;
				if (num != 0)
				{
				}
				num = (short)674168832;
				short num3 = num;
				num = (short)1455947777;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.HiddenStatic = value;
			}
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600637F RID: 25471 RVA: 0x00590D4C File Offset: 0x0058EF4C
		// (set) Token: 0x06006380 RID: 25472 RVA: 0x00590E00 File Offset: 0x0058F000
		internal bool RadErgoWideAuxControlActiveDuration_A37249_HiddenDynamic
		{
			get
			{
				short num = (short)966846733;
				short num2 = num;
				num = (short)1267656973;
				switch (num2 == num)
				{
				}
				num = (short)1767702529;
				if (num != 0)
				{
				}
				num = (short)1960771584;
				short num3 = num;
				num = (short)1587806208;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249.HiddenDynamic;
			}
			set
			{
				short num = (short)1899368136;
				short num2 = num;
				num = (short)1525681864;
				switch (num2 == num)
				{
				}
				num = (short)306511873;
				if (num != 0)
				{
				}
				num = (short)116195328;
				short num3 = num;
				num = (short)177733632;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlActiveDuration_A37249.HiddenDynamic = value;
			}
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x06006381 RID: 25473 RVA: 0x00590EB4 File Offset: 0x0058F0B4
		public bool RadErgoWideAuxControlActiveDuration_A37249_HasDiffs
		{
			get
			{
				short num = (short)1595933185;
				short num2 = num;
				num = (short)1293222401;
				switch (num2 == num)
				{
				}
				num = (short)1262944257;
				if (num != 0)
				{
				}
				num = (short)507052032;
				short num3 = num;
				num = (short)742719488;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlActiveDuration_A37249._HasDiffs;
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x06006382 RID: 25474 RVA: 0x00590F6C File Offset: 0x0058F16C
		// (set) Token: 0x06006383 RID: 25475 RVA: 0x00591024 File Offset: 0x0058F224
		public string RadErgoWideAuxControlAuxOnAlias_A37250Value
		{
			get
			{
				short num = (short)501415937;
				if (num != 0)
				{
				}
				num = (short)179088715;
				short num2 = num;
				num = (short)1565306187;
				switch (num2 == num)
				{
				}
				num = (short)668139520;
				short num3 = num;
				num = (short)1286209536;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.Value;
			}
			set
			{
				short num = (short)761569580;
				short num2 = num;
				num = (short)1892327724;
				switch (num2 == num)
				{
				}
				num = (short)271908864;
				if (num != 0)
				{
				}
				num = (short)927989760;
				short num3 = num;
				num = (short)442826753;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOnAlias_A37250.Value = value;
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x06006384 RID: 25476 RVA: 0x005910DC File Offset: 0x0058F2DC
		public global::AcpBusinessLayer.AcpField<string> RadErgoWideAuxControlAuxOnAlias_A37250
		{
			get
			{
				short num = (short)754695626;
				short num2 = num;
				num = (short)1606073802;
				switch (num2 == num)
				{
				}
				num = (short)469172225;
				if (num != 0)
				{
				}
				num = (short)873267200;
				short num3 = num;
				num = (short)2017329152;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250;
			}
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x06006385 RID: 25477 RVA: 0x00591190 File Offset: 0x0058F390
		// (set) Token: 0x06006386 RID: 25478 RVA: 0x00591244 File Offset: 0x0058F444
		public string RadErgoWideAuxControlAuxOnAlias_A37250_UIValue
		{
			get
			{
				short num = (short)742291882;
				short num2 = num;
				num = (short)1946778026;
				switch (num2 == num)
				{
				}
				num = (short)13434881;
				if (num != 0)
				{
				}
				num = (short)1074987008;
				short num3 = num;
				num = (short)369623040;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.Value;
			}
			set
			{
				short num = (short)961729831;
				short num2 = num;
				num = (short)1959712039;
				switch (num2 == num)
				{
				}
				num = (short)1065287681;
				if (num != 0)
				{
				}
				num = (short)579600384;
				short num3 = num;
				num = (short)1170866176;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOnAlias_A37250.Value = value;
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x06006387 RID: 25479 RVA: 0x005912F8 File Offset: 0x0058F4F8
		// (set) Token: 0x06006388 RID: 25480 RVA: 0x005913B0 File Offset: 0x0058F5B0
		public bool RadErgoWideAuxControlAuxOnAlias_A37250_Applicable
		{
			get
			{
				short num = (short)617596517;
				short num2 = num;
				num = (short)920962661;
				switch (num2 == num)
				{
				}
				num = (short)382205953;
				if (num != 0)
				{
				}
				num = (short)1100087296;
				short num3 = num;
				num = (short)1046282240;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.Applicable;
			}
			set
			{
				short num = (short)188023549;
				short num2 = num;
				num = (short)560792317;
				switch (num2 == num)
				{
				}
				num = (short)886177792;
				if (num != 0)
				{
				}
				num = (short)138477568;
				short num3 = num;
				num = (short)1658716161;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOnAlias_A37250.Applicable = value;
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x06006389 RID: 25481 RVA: 0x00591468 File Offset: 0x0058F668
		// (set) Token: 0x0600638A RID: 25482 RVA: 0x0059151C File Offset: 0x0058F71C
		public bool RadErgoWideAuxControlAuxOnAlias_A37250_Valid
		{
			get
			{
				short num = (short)1022427137;
				if (num != 0)
				{
				}
				num = (short)2015604268;
				short num2 = num;
				num = (short)347319852;
				switch (num2 == num)
				{
				}
				num = (short)1824063488;
				short num3 = num;
				num = (short)1970798592;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.Valid;
			}
			set
			{
				short num = (short)1524156866;
				short num2 = num;
				num = (short)349424066;
				switch (num2 == num)
				{
				}
				num = (short)1343422464;
				if (num != 0)
				{
				}
				num = (short)8978432;
				short num3 = num;
				num = (short)1517813761;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOnAlias_A37250.Valid = value;
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x005915D4 File Offset: 0x0058F7D4
		// (set) Token: 0x0600638C RID: 25484 RVA: 0x00591688 File Offset: 0x0058F888
		public bool RadErgoWideAuxControlAuxOnAlias_A37250_Visible
		{
			get
			{
				short num = (short)750512349;
				short num2 = num;
				num = (short)389015773;
				switch (num2 == num)
				{
				}
				num = (short)405209088;
				if (num != 0)
				{
				}
				num = (short)1489633280;
				short num3 = num;
				num = (short)1436549121;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.Visible;
			}
			set
			{
				short num = (short)755487293;
				short num2 = num;
				num = (short)915460669;
				switch (num2 == num)
				{
				}
				num = (short)1930559489;
				if (num != 0)
				{
				}
				num = (short)932839424;
				short num3 = num;
				num = (short)51118080;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOnAlias_A37250.Visible = value;
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600638D RID: 25485 RVA: 0x00591740 File Offset: 0x0058F940
		// (set) Token: 0x0600638E RID: 25486 RVA: 0x005917F4 File Offset: 0x0058F9F4
		public bool RadErgoWideAuxControlAuxOnAlias_A37250_Editable
		{
			get
			{
				short num = (short)819960904;
				short num2 = num;
				num = (short)1436982344;
				switch (num2 == num)
				{
				}
				num = (short)1305739265;
				if (num != 0)
				{
				}
				num = (short)138936320;
				short num3 = num;
				num = (short)424214528;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.Editable;
			}
			set
			{
				short num = (short)821886977;
				if (num != 0)
				{
				}
				num = (short)364147324;
				short num2 = num;
				num = (short)1324184188;
				switch (num2 == num)
				{
				}
				num = (short)271908864;
				short num3 = num;
				num = (short)1632698368;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOnAlias_A37250.Editable = value;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600638F RID: 25487 RVA: 0x005918AC File Offset: 0x0058FAAC
		internal string RadErgoWideAuxControlAuxOnAlias_A37250_UILabel
		{
			get
			{
				short num = (short)1343029249;
				if (num != 0)
				{
				}
				num = (short)1286034064;
				short num2 = num;
				num = (short)552424080;
				switch (num2 == num)
				{
				}
				num = (short)932052992;
				short num3 = num;
				num = (short)1479671808;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.UIName;
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x06006390 RID: 25488 RVA: 0x00591964 File Offset: 0x0058FB64
		// (set) Token: 0x06006391 RID: 25489 RVA: 0x00591A1C File Offset: 0x0058FC1C
		internal bool RadErgoWideAuxControlAuxOnAlias_A37250_HiddenStatic
		{
			get
			{
				short num = (short)2020453069;
				short num2 = num;
				num = (short)1975298765;
				switch (num2 == num)
				{
				}
				num = (short)1091305472;
				if (num != 0)
				{
				}
				num = (short)1857159168;
				short num3 = num;
				num = (short)939720705;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.HiddenStatic;
			}
			set
			{
				short num = (short)1918697755;
				short num2 = num;
				num = (short)2089550107;
				switch (num2 == num)
				{
				}
				num = (short)1703870465;
				if (num != 0)
				{
				}
				num = (short)234356736;
				short num3 = num;
				num = (short)268632064;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOnAlias_A37250.HiddenStatic = value;
			}
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x06006392 RID: 25490 RVA: 0x00591AD0 File Offset: 0x0058FCD0
		// (set) Token: 0x06006393 RID: 25491 RVA: 0x00591B88 File Offset: 0x0058FD88
		internal bool RadErgoWideAuxControlAuxOnAlias_A37250_HiddenDynamic
		{
			get
			{
				short num = (short)1366995830;
				short num2 = num;
				num = (short)1211609974;
				switch (num2 == num)
				{
				}
				num = (short)1171587073;
				if (num != 0)
				{
				}
				num = (short)1862467584;
				short num3 = num;
				num = (short)622985216;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250.HiddenDynamic;
			}
			set
			{
				short num = (short)145957167;
				short num2 = num;
				num = (short)1774068015;
				switch (num2 == num)
				{
				}
				num = (short)1179648000;
				if (num != 0)
				{
				}
				num = (short)788332544;
				short num3 = num;
				num = (short)252641281;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOnAlias_A37250.HiddenDynamic = value;
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x06006394 RID: 25492 RVA: 0x00591C3C File Offset: 0x0058FE3C
		public bool RadErgoWideAuxControlAuxOnAlias_A37250_HasDiffs
		{
			get
			{
				short num = (short)835520417;
				short num2 = num;
				num = (short)1295583137;
				switch (num2 == num)
				{
				}
				num = (short)948895745;
				if (num != 0)
				{
				}
				num = (short)439812096;
				short num3 = num;
				num = (short)993984512;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOnAlias_A37250._HasDiffs;
			}
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x06006395 RID: 25493 RVA: 0x00591CF4 File Offset: 0x0058FEF4
		// (set) Token: 0x06006396 RID: 25494 RVA: 0x00591DA8 File Offset: 0x0058FFA8
		public string RadErgoWideAuxControlAuxOffAlias_A37252Value
		{
			get
			{
				short num = (short)2135097972;
				short num2 = num;
				num = (short)701694580;
				switch (num2 == num)
				{
				}
				num = (short)345374721;
				if (num != 0)
				{
				}
				num = (short)771555328;
				short num3 = num;
				num = (short)484376576;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.Value;
			}
			set
			{
				short num = (short)583416975;
				short num2 = num;
				num = (short)2071018639;
				switch (num2 == num)
				{
				}
				num = (short)926023680;
				if (num != 0)
				{
				}
				num = (short)1111883776;
				short num3 = num;
				num = (short)1891565569;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOffAlias_A37252.Value = value;
			}
		}

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x06006397 RID: 25495 RVA: 0x00591E5C File Offset: 0x0059005C
		public global::AcpBusinessLayer.AcpField<string> RadErgoWideAuxControlAuxOffAlias_A37252
		{
			get
			{
				short num = (short)174200203;
				short num2 = num;
				num = (short)1053496715;
				switch (num2 == num)
				{
				}
				num = (short)499318784;
				if (num != 0)
				{
				}
				num = (short)842858496;
				short num3 = num;
				num = (short)1670447105;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252;
			}
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x06006398 RID: 25496 RVA: 0x00591F0C File Offset: 0x0059010C
		// (set) Token: 0x06006399 RID: 25497 RVA: 0x00591FC0 File Offset: 0x005901C0
		public string RadErgoWideAuxControlAuxOffAlias_A37252_UIValue
		{
			get
			{
				short num = (short)957882563;
				short num2 = num;
				num = (short)504504515;
				switch (num2 == num)
				{
				}
				num = (short)393740289;
				if (num != 0)
				{
				}
				num = (short)987103232;
				short num3 = num;
				num = (short)1575944192;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.Value;
			}
			set
			{
				short num = (short)1694331644;
				short num2 = num;
				num = (short)184775420;
				switch (num2 == num)
				{
				}
				num = (short)2091253760;
				if (num != 0)
				{
				}
				num = (short)1979645952;
				short num3 = num;
				num = (short)1635581953;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOffAlias_A37252.Value = value;
			}
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600639A RID: 25498 RVA: 0x00592074 File Offset: 0x00590274
		// (set) Token: 0x0600639B RID: 25499 RVA: 0x0059212C File Offset: 0x0059032C
		public bool RadErgoWideAuxControlAuxOffAlias_A37252_Applicable
		{
			get
			{
				short num = (short)1338334458;
				short num2 = num;
				num = (short)426335482;
				switch (num2 == num)
				{
				}
				num = (short)1223163905;
				if (num != 0)
				{
				}
				num = (short)143982592;
				short num3 = num;
				num = (short)1852440576;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.Applicable;
			}
			set
			{
				short num = (short)1103374448;
				short num2 = num;
				num = (short)862267504;
				switch (num2 == num)
				{
				}
				num = (short)640745472;
				if (num != 0)
				{
				}
				num = (short)1870200832;
				short num3 = num;
				num = (short)972685313;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOffAlias_A37252.Applicable = value;
			}
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600639C RID: 25500 RVA: 0x005921E0 File Offset: 0x005903E0
		// (set) Token: 0x0600639D RID: 25501 RVA: 0x00592294 File Offset: 0x00590494
		public bool RadErgoWideAuxControlAuxOffAlias_A37252_Valid
		{
			get
			{
				short num = (short)1062568798;
				short num2 = num;
				num = (short)742425438;
				switch (num2 == num)
				{
				}
				num = (short)1171062784;
				if (num != 0)
				{
				}
				num = (short)999161856;
				short num3 = num;
				num = (short)270991361;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.Valid;
			}
			set
			{
				short num = (short)59781551;
				short num2 = num;
				num = (short)799814063;
				switch (num2 == num)
				{
				}
				num = (short)984154113;
				if (num != 0)
				{
				}
				num = (short)1391919104;
				short num3 = num;
				num = (short)368967680;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOffAlias_A37252.Valid = value;
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600639E RID: 25502 RVA: 0x00592348 File Offset: 0x00590548
		// (set) Token: 0x0600639F RID: 25503 RVA: 0x005923FC File Offset: 0x005905FC
		public bool RadErgoWideAuxControlAuxOffAlias_A37252_Visible
		{
			get
			{
				short num = (short)558084311;
				short num2 = num;
				num = (short)739422423;
				switch (num2 == num)
				{
				}
				num = (short)668729345;
				if (num != 0)
				{
				}
				num = (short)1783234560;
				short num3 = num;
				num = (short)1109917696;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.Visible;
			}
			set
			{
				short num = (short)1508727302;
				short num2 = num;
				num = (short)283138566;
				switch (num2 == num)
				{
				}
				num = (short)740163584;
				if (num != 0)
				{
				}
				num = (short)1113980928;
				short num3 = num;
				num = (short)2049835009;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOffAlias_A37252.Visible = value;
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x060063A0 RID: 25504 RVA: 0x005924B4 File Offset: 0x005906B4
		// (set) Token: 0x060063A1 RID: 25505 RVA: 0x0059256C File Offset: 0x0059076C
		public bool RadErgoWideAuxControlAuxOffAlias_A37252_Editable
		{
			get
			{
				short num = (short)1894110567;
				short num2 = num;
				num = (short)33871207;
				switch (num2 == num)
				{
				}
				num = (short)560005121;
				if (num != 0)
				{
				}
				num = (short)1784283136;
				short num3 = num;
				num = (short)903282688;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.Editable;
			}
			set
			{
				short num = (short)185529000;
				short num2 = num;
				num = (short)19395240;
				switch (num2 == num)
				{
				}
				num = (short)1935540225;
				if (num != 0)
				{
				}
				num = (short)2136014848;
				short num3 = num;
				num = (short)1961295872;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOffAlias_A37252.Editable = value;
			}
		}

		// Token: 0x170033BE RID: 13246
		// (get) Token: 0x060063A2 RID: 25506 RVA: 0x00592628 File Offset: 0x00590828
		internal string RadErgoWideAuxControlAuxOffAlias_A37252_UILabel
		{
			get
			{
				short num = (short)1441792001;
				if (num != 0)
				{
				}
				num = (short)738217250;
				short num2 = num;
				num = (short)1918192930;
				switch (num2 == num)
				{
				}
				num = (short)1082982400;
				short num3 = num;
				num = (short)1415053312;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.UIName;
			}
		}

		// Token: 0x170033BF RID: 13247
		// (get) Token: 0x060063A3 RID: 25507 RVA: 0x005926DC File Offset: 0x005908DC
		// (set) Token: 0x060063A4 RID: 25508 RVA: 0x00592790 File Offset: 0x00590990
		internal bool RadErgoWideAuxControlAuxOffAlias_A37252_HiddenStatic
		{
			get
			{
				short num = (short)1170549081;
				short num2 = num;
				num = (short)227486041;
				switch (num2 == num)
				{
				}
				num = (short)1719205889;
				if (num != 0)
				{
				}
				num = (short)1020329984;
				short num3 = num;
				num = (short)914751488;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.HiddenStatic;
			}
			set
			{
				short num = (short)1277631908;
				short num2 = num;
				num = (short)622534052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1848901632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1360527360;
				if (num != 0)
				{
				}
				num = (short)361496577;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOffAlias_A37252.HiddenStatic = value;
			}
		}

		// Token: 0x170033C0 RID: 13248
		// (get) Token: 0x060063A5 RID: 25509 RVA: 0x00592848 File Offset: 0x00590A48
		// (set) Token: 0x060063A6 RID: 25510 RVA: 0x005928FC File Offset: 0x00590AFC
		internal bool RadErgoWideAuxControlAuxOffAlias_A37252_HiddenDynamic
		{
			get
			{
				short num = (short)1519646317;
				short num2 = num;
				num = (short)1021245037;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100007936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)55115777;
				if (num != 0)
				{
				}
				num = (short)307232768;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252.HiddenDynamic;
			}
			set
			{
				short num = (short)84617866;
				short num2 = num;
				num = (short)1444948618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1924857856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)696254464;
				if (num != 0)
				{
				}
				num = (short)1288699905;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxOffAlias_A37252.HiddenDynamic = value;
			}
		}

		// Token: 0x170033C1 RID: 13249
		// (get) Token: 0x060063A7 RID: 25511 RVA: 0x005929B4 File Offset: 0x00590BB4
		public bool RadErgoWideAuxControlAuxOffAlias_A37252_HasDiffs
		{
			get
			{
				short num = (short)1623261185;
				if (num != 0)
				{
				}
				num = (short)1896153088;
				short num2 = num;
				num = (short)294761291;
				short num3 = num;
				num = (short)695120715;
				switch (num3 == num)
				{
				}
				num = (short)927858688;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxOffAlias_A37252._HasDiffs;
			}
		}

		// Token: 0x170033C2 RID: 13250
		// (get) Token: 0x060063A8 RID: 25512 RVA: 0x00592A6C File Offset: 0x00590C6C
		// (set) Token: 0x060063A9 RID: 25513 RVA: 0x00592B20 File Offset: 0x00590D20
		public string RadErgoWideAuxControlAbbrAuxOnAlias_A37612Value
		{
			get
			{
				short num = (short)861667329;
				if (num != 0)
				{
				}
				num = (short)1850277888;
				short num2 = num;
				num = (short)1076438130;
				short num3 = num;
				num = (short)1782260850;
				switch (num3 == num)
				{
				}
				num = (short)278396928;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Value;
			}
			set
			{
				short num = (short)918141326;
				short num2 = num;
				num = (short)632011150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)261226496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402077185;
				if (num != 0)
				{
				}
				num = (short)785973248;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Value = value;
			}
		}

		// Token: 0x170033C3 RID: 13251
		// (get) Token: 0x060063AA RID: 25514 RVA: 0x00592BD8 File Offset: 0x00590DD8
		public global::AcpBusinessLayer.AcpField<string> RadErgoWideAuxControlAbbrAuxOnAlias_A37612
		{
			get
			{
				short num = (short)1215084674;
				short num2 = num;
				num = (short)1249818754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)594345984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1093795840;
				if (num != 0)
				{
				}
				num = (short)727711745;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612;
			}
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x060063AB RID: 25515 RVA: 0x00592C88 File Offset: 0x00590E88
		// (set) Token: 0x060063AC RID: 25516 RVA: 0x00592D3C File Offset: 0x00590F3C
		public string RadErgoWideAuxControlAbbrAuxOnAlias_A37612_UIValue
		{
			get
			{
				short num = (short)1035989979;
				short num2 = num;
				num = (short)1806758875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2092826624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)498728960;
				if (num != 0)
				{
				}
				num = (short)1648099329;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Value;
			}
			set
			{
				short num = (short)462237531;
				short num2 = num;
				num = (short)296169307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)194379776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1172504577;
				if (num != 0)
				{
				}
				num = (short)774897664;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Value = value;
			}
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x060063AD RID: 25517 RVA: 0x00592DF4 File Offset: 0x00590FF4
		// (set) Token: 0x060063AE RID: 25518 RVA: 0x00592EAC File Offset: 0x005910AC
		public bool RadErgoWideAuxControlAbbrAuxOnAlias_A37612_Applicable
		{
			get
			{
				short num = (short)998405294;
				short num2 = num;
				num = (short)15234222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)756285440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1359020033;
				if (num != 0)
				{
				}
				num = (short)1842544640;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Applicable;
			}
			set
			{
				short num = (short)706175256;
				short num2 = num;
				num = (short)929849624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1486356480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1543897088;
				if (num != 0)
				{
				}
				num = (short)759562241;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Applicable = value;
			}
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x060063AF RID: 25519 RVA: 0x00592F64 File Offset: 0x00591164
		// (set) Token: 0x060063B0 RID: 25520 RVA: 0x00593018 File Offset: 0x00591218
		public bool RadErgoWideAuxControlAbbrAuxOnAlias_A37612_Valid
		{
			get
			{
				short num = (short)1400420751;
				short num2 = num;
				num = (short)609663375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)616235008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1101201409;
				if (num != 0)
				{
				}
				num = (short)579600384;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Valid;
			}
			set
			{
				short num = (short)332972513;
				short num2 = num;
				num = (short)694600161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1179844608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)317980673;
				if (num != 0)
				{
				}
				num = (short)2088763392;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Valid = value;
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x060063B1 RID: 25521 RVA: 0x005930CC File Offset: 0x005912CC
		// (set) Token: 0x060063B2 RID: 25522 RVA: 0x00593180 File Offset: 0x00591380
		public bool RadErgoWideAuxControlAbbrAuxOnAlias_A37612_Visible
		{
			get
			{
				short num = (short)1063127780;
				short num2 = num;
				num = (short)1715342052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1883570176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)170917889;
				if (num != 0)
				{
				}
				num = (short)2017591296;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Visible;
			}
			set
			{
				short num = (short)918963286;
				short num2 = num;
				num = (short)66077782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584660480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1968766977;
				if (num != 0)
				{
				}
				num = (short)540147712;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Visible = value;
			}
		}

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x060063B3 RID: 25523 RVA: 0x00593234 File Offset: 0x00591434
		// (set) Token: 0x060063B4 RID: 25524 RVA: 0x005932E8 File Offset: 0x005914E8
		public bool RadErgoWideAuxControlAbbrAuxOnAlias_A37612_Editable
		{
			get
			{
				short num = (short)652157652;
				short num2 = num;
				num = (short)559030996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)886702080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1490812929;
				if (num != 0)
				{
				}
				num = (short)1676476416;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Editable;
			}
			set
			{
				short num = (short)788398081;
				if (num != 0)
				{
				}
				num = (short)1427963904;
				short num2 = num;
				num = (short)1532758068;
				short num3 = num;
				num = (short)76482612;
				switch (num3 == num)
				{
				}
				num = (short)1399586816;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.Editable = value;
			}
		}

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x060063B5 RID: 25525 RVA: 0x005933A0 File Offset: 0x005915A0
		internal string RadErgoWideAuxControlAbbrAuxOnAlias_A37612_UILabel
		{
			get
			{
				short num = (short)879363348;
				short num2 = num;
				num = (short)1955136788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)208994304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1505951745;
				if (num != 0)
				{
				}
				num = (short)1431764992;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.UIName;
			}
		}

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x060063B6 RID: 25526 RVA: 0x00593458 File Offset: 0x00591658
		// (set) Token: 0x060063B7 RID: 25527 RVA: 0x0059350C File Offset: 0x0059170C
		internal bool RadErgoWideAuxControlAbbrAuxOnAlias_A37612_HiddenStatic
		{
			get
			{
				short num = (short)713744747;
				short num2 = num;
				num = (short)373678443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1829240832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2090795009;
				if (num != 0)
				{
				}
				num = (short)1942749184;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.HiddenStatic;
			}
			set
			{
				short num = (short)2112094209;
				if (num != 0)
				{
				}
				num = (short)2067922944;
				short num2 = num;
				num = (short)323619924;
				short num3 = num;
				num = (short)126815316;
				switch (num3 == num)
				{
				}
				num = (short)1723858944;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.HiddenStatic = value;
			}
		}

		// Token: 0x170033CB RID: 13259
		// (get) Token: 0x060063B8 RID: 25528 RVA: 0x005935C4 File Offset: 0x005917C4
		// (set) Token: 0x060063B9 RID: 25529 RVA: 0x0059367C File Offset: 0x0059187C
		internal bool RadErgoWideAuxControlAbbrAuxOnAlias_A37612_HiddenDynamic
		{
			get
			{
				short num = (short)561300850;
				short num2 = num;
				num = (short)1049544050;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2101542912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1602027521;
				if (num != 0)
				{
				}
				num = (short)1303838720;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.HiddenDynamic;
			}
			set
			{
				short num = (short)656146433;
				if (num != 0)
				{
				}
				num = (short)1031929856;
				short num2 = num;
				num = (short)1542952896;
				short num3 = num;
				num = (short)334534592;
				switch (num3 == num)
				{
				}
				num = (short)587595776;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAbbrAuxOnAlias_A37612.HiddenDynamic = value;
			}
		}

		// Token: 0x170033CC RID: 13260
		// (get) Token: 0x060063BA RID: 25530 RVA: 0x00593730 File Offset: 0x00591930
		public bool RadErgoWideAuxControlAbbrAuxOnAlias_A37612_HasDiffs
		{
			get
			{
				short num = (short)776372328;
				short num2 = num;
				num = (short)465469544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945160192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1540947969;
				if (num != 0)
				{
				}
				num = (short)1072693248;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAbbrAuxOnAlias_A37612._HasDiffs;
			}
		}

		// Token: 0x170033CD RID: 13261
		// (get) Token: 0x060063BB RID: 25531 RVA: 0x005937E8 File Offset: 0x005919E8
		// (set) Token: 0x060063BC RID: 25532 RVA: 0x0059389C File Offset: 0x00591A9C
		public string RadErgoWideAuxControlAuxCtrlName_A37714Value
		{
			get
			{
				short num = (short)1130842829;
				short num2 = num;
				num = (short)1834437325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1563099136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)993591297;
				if (num != 0)
				{
				}
				num = (short)2108358656;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.Value;
			}
			set
			{
				short num = (short)552140801;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)92798977;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
						this.radErgoWideAuxControlAuxCtrlName_A37714.Value = value;
						num = (short)1436418048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_58:
					num = (short)567876783;
					short num3 = num;
					num = (short)516562095;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num = (short)1929904128;
						if (num != 0)
						{
						}
						num = (short)1890779136;
						short num4 = num;
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)232980482;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x170033CE RID: 13262
		// (get) Token: 0x060063BD RID: 25533 RVA: 0x005939C4 File Offset: 0x00591BC4
		// (set) Token: 0x060063BE RID: 25534 RVA: 0x00593A7C File Offset: 0x00591C7C
		public string RadErgoWideAuxControlAuxCtrlName_A37714_UIValue
		{
			get
			{
				short num = (short)1684909239;
				short num2 = num;
				num = (short)700427447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075118080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1983447041;
				if (num != 0)
				{
				}
				num = (short)908394496;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.Value;
			}
			set
			{
				short num = (short)1067008775;
				short num2 = num;
				num = (short)318063367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1042219008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)635830273;
				if (num != 0)
				{
				}
				num = (short)834994176;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxCtrlName_A37714.Value = value;
			}
		}

		// Token: 0x170033CF RID: 13263
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x00593B30 File Offset: 0x00591D30
		public global::AcpBusinessLayer.AcpKeyField RadErgoWideAuxControlAuxCtrlName_A37714
		{
			get
			{
				short num = (short)1738264909;
				short num2 = num;
				num = (short)2055459149;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1532428288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)181862401;
				if (num != 0)
				{
				}
				num = (short)702021632;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714;
			}
		}

		// Token: 0x170033D0 RID: 13264
		// (get) Token: 0x060063C0 RID: 25536 RVA: 0x00593BE0 File Offset: 0x00591DE0
		// (set) Token: 0x060063C1 RID: 25537 RVA: 0x00593C94 File Offset: 0x00591E94
		public bool RadErgoWideAuxControlAuxCtrlName_A37714_Applicable
		{
			get
			{
				short num = (short)909638996;
				short num2 = num;
				num = (short)1073282388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298661376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1001062401;
				if (num != 0)
				{
				}
				num = (short)601817088;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.Applicable;
			}
			set
			{
				short num = (short)724697089;
				if (num != 0)
				{
				}
				num = (short)1304625152;
				short num2 = num;
				num = (short)1454862267;
				short num3 = num;
				num = (short)767979451;
				switch (num3 == num)
				{
				}
				num = (short)957349888;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxCtrlName_A37714.Applicable = value;
			}
		}

		// Token: 0x170033D1 RID: 13265
		// (get) Token: 0x060063C2 RID: 25538 RVA: 0x00593D4C File Offset: 0x00591F4C
		// (set) Token: 0x060063C3 RID: 25539 RVA: 0x00593E04 File Offset: 0x00592004
		public bool RadErgoWideAuxControlAuxCtrlName_A37714_Valid
		{
			get
			{
				short num = (short)2026247029;
				short num2 = num;
				num = (short)1553142645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1537474560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)197853185;
				if (num != 0)
				{
				}
				num = (short)1372061696;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.Valid;
			}
			set
			{
				short num = (short)1414324116;
				short num2 = num;
				num = (short)112189332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1100480512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)144637953;
				if (num != 0)
				{
				}
				num = (short)104923136;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxCtrlName_A37714.Valid = value;
			}
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x060063C4 RID: 25540 RVA: 0x00593EBC File Offset: 0x005920BC
		// (set) Token: 0x060063C5 RID: 25541 RVA: 0x00593F70 File Offset: 0x00592170
		public bool RadErgoWideAuxControlAuxCtrlName_A37714_Visible
		{
			get
			{
				short num = (short)23613221;
				short num2 = num;
				num = (short)1061375781;
				switch (num2 == num)
				{
				default:
				{
					num = (short)182779904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)217776129;
				if (num != 0)
				{
				}
				num = (short)740360192;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.Visible;
			}
			set
			{
				short num = (short)428165411;
				short num2 = num;
				num = (short)1751140643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1901395968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1078984705;
				if (num != 0)
				{
				}
				num = (short)1911422976;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxCtrlName_A37714.Visible = value;
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x060063C6 RID: 25542 RVA: 0x00594024 File Offset: 0x00592224
		// (set) Token: 0x060063C7 RID: 25543 RVA: 0x005940D8 File Offset: 0x005922D8
		public bool RadErgoWideAuxControlAuxCtrlName_A37714_Editable
		{
			get
			{
				short num = (short)1371288812;
				short num2 = num;
				num = (short)115291372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1606025216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1729298433;
				if (num != 0)
				{
				}
				num = (short)1187643392;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.Editable;
			}
			set
			{
				short num = (short)1152365664;
				short num2 = num;
				num = (short)1273082976;
				switch (num2 == num)
				{
				default:
				{
					num = (short)76414976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622409217;
				if (num != 0)
				{
				}
				num = (short)579076096;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxCtrlName_A37714.Editable = value;
			}
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x060063C8 RID: 25544 RVA: 0x00594188 File Offset: 0x00592388
		internal string RadErgoWideAuxControlAuxCtrlName_A37714_UILabel
		{
			get
			{
				short num = (short)1331418769;
				short num2 = num;
				num = (short)683267729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1365377024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)496631809;
				if (num != 0)
				{
				}
				num = (short)2063007744;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.UIName;
			}
		}

		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x060063C9 RID: 25545 RVA: 0x0059423C File Offset: 0x0059243C
		// (set) Token: 0x060063CA RID: 25546 RVA: 0x005942F0 File Offset: 0x005924F0
		internal bool RadErgoWideAuxControlAuxCtrlName_A37714_HiddenStatic
		{
			get
			{
				short num = (short)512884779;
				short num2 = num;
				num = (short)1107034155;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1925578752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422065665;
				if (num != 0)
				{
				}
				num = (short)1620901888;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.HiddenStatic;
			}
			set
			{
				short num = (short)976878781;
				short num2 = num;
				num = (short)1281686717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)85655552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1664679937;
				if (num != 0)
				{
				}
				num = (short)856883200;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxCtrlName_A37714.HiddenStatic = value;
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x060063CB RID: 25547 RVA: 0x005943A8 File Offset: 0x005925A8
		// (set) Token: 0x060063CC RID: 25548 RVA: 0x00594458 File Offset: 0x00592658
		internal bool RadErgoWideAuxControlAuxCtrlName_A37714_HiddenDynamic
		{
			get
			{
				short num = (short)1817071123;
				short num2 = num;
				num = (short)579030547;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1893466112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)684851200;
				if (num != 0)
				{
				}
				num = (short)399966209;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714.HiddenDynamic;
			}
			set
			{
				short num = (short)2042055153;
				short num2 = num;
				num = (short)258558449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1800667136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618542593;
				if (num != 0)
				{
				}
				num = (short)1648951296;
				if (num != 0)
				{
				}
				this.radErgoWideAuxControlAuxCtrlName_A37714.HiddenDynamic = value;
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x060063CD RID: 25549 RVA: 0x0059450C File Offset: 0x0059270C
		public bool RadErgoWideAuxControlAuxCtrlName_A37714_HasDiffs
		{
			get
			{
				short num = (short)544753843;
				short num2 = num;
				num = (short)1734494387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249036800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)167837696;
				if (num != 0)
				{
				}
				num = (short)371523585;
				if (num != 0)
				{
				}
				return this.radErgoWideAuxControlAuxCtrlName_A37714._HasDiffs;
			}
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x060063CE RID: 25550 RVA: 0x005945C0 File Offset: 0x005927C0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)2097145391;
				short num2 = num;
				num = (short)1480648239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)440860672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1234173953;
				if (num != 0)
				{
				}
				num = (short)1813381120;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x00594680 File Offset: 0x00592880
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				short num = (short)1878261760;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				for (;;)
				{
					IL_34:
					int num3;
					switch (num3)
					{
					case 0:
						num = (short)579534850;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)339607556;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)420151297;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						num = (short)1018232833;
						if (num != 0)
						{
						}
						if (base.ParentRecset != null)
						{
							num = (short)1687748608;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						return result;
					}
					break;
				}
				IL_4E:
				num = (short)760720405;
				short num4 = num;
				num = (short)865512469;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1096351744;
					if (num != 0)
					{
					}
					result = null;
					num = (short)870907907;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_34;
				}
				}
			}
			return result;
		}

		// Token: 0x0400262D RID: 9773
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAuxControlActiveDuration_A37249;

		// Token: 0x0400262E RID: 9774
		private global::AcpBusinessLayer.AcpField<string> radErgoWideAuxControlAuxOnAlias_A37250;

		// Token: 0x0400262F RID: 9775
		private global::AcpBusinessLayer.AcpField<string> radErgoWideAuxControlAuxOffAlias_A37252;

		// Token: 0x04002630 RID: 9776
		private global::AcpBusinessLayer.AcpField<string> radErgoWideAuxControlAbbrAuxOnAlias_A37612;

		// Token: 0x04002631 RID: 9777
		private global::AcpBusinessLayer.AcpKeyField radErgoWideAuxControlAuxCtrlName_A37714;
	}
}
