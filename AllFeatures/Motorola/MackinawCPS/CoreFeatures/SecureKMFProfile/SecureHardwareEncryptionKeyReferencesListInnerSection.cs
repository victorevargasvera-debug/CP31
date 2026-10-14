using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x02000102 RID: 258
	[global::System.Serializable]
	public class SecureHardwareEncryptionKeyReferencesListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060025EC RID: 9708 RVA: 0x0024F6E0 File Offset: 0x0024D8E0
		public SecureHardwareEncryptionKeyReferencesListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x0024F6FC File Offset: 0x0024D8FC
		protected SecureHardwareEncryptionKeyReferencesListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x0024F714 File Offset: 0x0024D914
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1961176210;
			short num2 = num;
			num = (short)725232786;
			switch (num2 == num)
			{
			}
			num = (short)160759808;
			if (num != 0)
			{
			}
			num = (short)1774190593;
			if (num != 0)
			{
			}
			num = (short)480837632;
			short num3 = num;
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑鿓믕뻗諙껛뇝蛟뇡臣藥鷧飩觫ꛭ釯胱郳臵駷裹駻믽滿愁瘃缅砇縉攋愍縏夑焓漕䨗缙稛笝刟䜡䨣䔥䴧天怫䜭䌯䘱眳紵樷琹䤻匽∿❁㙃᥅े絉穋硍杏", a_), global::CommonResources.AcgResources.ID_CKRNUMBER, global::AllFeatures.CodeplugGuid.b("ￍ", a_));
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.DataTransferOrder = -1;
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑鿓믕뻗諙껛뇝蛟뇡臣藥鷧飩觫ꛭ釯胱郳臵駷裹駻믽滿愁瘃缅砇縉攋愍縏夑焓漕䨗缙稛笝刟䜡䨣䔥䴧天怫䜭䌯䘱簳圵䨷帹䬻弽㈿❁གྷ⍅ㅇᡉ⥋⡍㕏⁑ㅓ㡕㭗㽙͛Ὕ塟卡嵣剥", a_), global::CommonResources.AcgResources.ID_ENCRYPTIONKEYREFERENCE, null, null, true, false, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LegacyTitles.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194LegacyTitles);
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.DataTransferOrder = 1;
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷍뗏뇑ꇓꓕ뷗龎铛뿝鋟蛡鏣蟥髧迩쳫꯭黯釱蛳迵裷軹闻釽滿∁伃挅焇⨉帋欍瘏眑易猕瘗礙礛洝\u001f渡䴣唥尧", a_);
			base.Id = 10127;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONKEYREFERENCESLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x0024F884 File Offset: 0x0024DA84
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)730136577;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷍뗏뇑鿓믕뻗諙껛뇝蛟뇡臣藥鷧飩觫ꛭ釯胱郳臵駷裹駻믽滿愁瘃缅砇縉攋愍縏夑焓漕䨗缙稛笝刟䜡䨣䔥䴧天怫䜭䌯䘱眳紵樷琹䤻匽∿❁㙃᥅े絉穋硍杏", a_)))
					{
						num = (short)985137156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷍뗏뇑鿓믕뻗諙껛뇝蛟뇡臣藥鷧飩觫ꛭ釯胱郳臵駷裹駻믽滿愁瘃缅砇縉攋愍縏夑焓漕䨗缙稛笝刟䜡䨣䔥䴧天怫䜭䌯䘱簳圵䨷帹䬻弽㈿❁གྷ⍅ㅇᡉ⥋⡍㕏⁑ㅓ㡕㭗㽙͛Ὕ塟卡嵣剥", a_)))
					{
						num = (short)364838918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B0;
				case 3:
					goto IL_261;
				case 4:
					goto IL_C5;
				case 5:
					goto IL_7A;
				case 6:
				{
					this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑鿓믕뻗諙껛뇝蛟뇡臣藥鷧飩觫ꛭ釯胱郳臵駷裹駻믽滿愁瘃缅砇縉攋愍縏夑焓漕䨗缙稛笝刟䜡䨣䔥䴧天怫䜭䌯䘱簳圵䨷帹䬻弽㈿❁གྷ⍅ㅇᡉ⥋⡍㕏⁑ㅓ㡕㭗㽙͛Ὕ塟卡嵣剥", a_), global::CommonResources.AcgResources.ID_ENCRYPTIONKEYREFERENCE, null, null, true, false, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.LegacyTitles.SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194LegacyTitles);
					this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.DataTransferOrder = 1;
					this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.ValidateAcrossRecset = true;
					num = (short)822140798;
					short num3 = num;
					num = (short)1730600830;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C5;
					case 1:
						break;
					default:
					{
						num = (short)1474363392;
						short num4 = num;
						break;
					}
					}
					num = (short)1342242816;
					if (num != 0)
					{
					}
					num = (short)715325443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (producerFields != null)
					{
						num = (short)106889225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B0;
				case 8:
					num = (short)574357511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)737411073;
					if (num != 0)
					{
					}
					num = (short)884998144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1314783240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)614465538;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C5:
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667 = new global::AcpBusinessLayer.AcpPointerField<int>(0, this, global::AllFeatures.CodeplugGuid.b("鷍뗏뇑鿓믕뻗諙껛뇝蛟뇡臣藥鷧飩觫ꛭ釯胱郳臵駷裹駻믽滿愁瘃缅砇縉攋愍縏夑焓漕䨗缙稛笝刟䜡䨣䔥䴧天怫䜭䌯䘱眳紵樷琹䤻匽∿❁㙃᥅े絉穋硍杏", a_), global::CommonResources.AcgResources.ID_CKRNUMBER, global::AllFeatures.CodeplugGuid.b("ￍ", a_));
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.DataTransferOrder = -1;
				num = (short)1478033413;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_261:
			IL_2B0:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷍뗏뇑ꇓꓕ뷗龎铛뿝鋟蛡鏣蟥髧迩쳫꯭黯釱蛳迵裷軹闻釽滿∁伃挅焇⨉帋欍瘏眑易猕瘗礙礛洝\u001f渡䴣唥尧", a_);
			base.Id = 10127;
			base.UIName = global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONKEYREFERENCESLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x0024FB74 File Offset: 0x0024DD74
		public override void PopulateReferences()
		{
			short num = (short)1830621238;
			short num2 = num;
			num = (short)783093814;
			switch (num2 == num)
			{
			}
			num = (short)1049690113;
			if (num != 0)
			{
			}
			num = (short)1311571968;
			if (num != 0)
			{
			}
			num = (short)1420296192;
			short num3 = num;
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.SetRecset(this.a(2021)[0][10040].EmbeddedRecset);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x0024FC4C File Offset: 0x0024DE4C
		public override void DropReferences()
		{
			short num = (short)1764690304;
			short num2 = num;
			num = (short)1383860608;
			switch (num2 == num)
			{
			}
			num = (short)983891968;
			if (num != 0)
			{
			}
			num = (short)969801729;
			if (num != 0)
			{
			}
			num = (short)1510998016;
			short num3 = num;
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0024FCF8 File Offset: 0x0024DEF8
		public override void SetConstraints()
		{
			short num = (short)1148162347;
			short num2 = num;
			num = (short)2080477483;
			switch (num2 == num)
			{
			}
			num = (short)700252161;
			if (num != 0)
			{
			}
			num = (short)1212416000;
			if (num != 0)
			{
			}
			num = (short)1382678528;
			short num3 = num;
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecItemIsVisible);
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecItemIsVisible);
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.ValidateAcrossRecset = true;
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConIsHardwareKeyRefApp);
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.ConHwSecItemIsVisible);
			this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileConstraints.conHwKeyReferencedNotDuplicated);
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0024FE38 File Offset: 0x0024E038
		public override void SetupDependencies()
		{
			short num = (short)1116306182;
			short num2 = num;
			num = (short)2022472454;
			switch (num2 == num)
			{
			}
			num = (short)2141323264;
			if (num != 0)
			{
			}
			num = (short)677249025;
			if (num != 0)
			{
			}
			num = (short)1865809920;
			short num3 = num;
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194);
			this.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.AddDependentObject(this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194);
			this.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.AddDependentObject(this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194);
			this.RefRadioInformation.Labtool.RadInfoLabtoolQ806IMBE_A8191.AddDependentObject(this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194);
			this.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194);
		}

		// Token: 0x1700130F RID: 4879
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x0024FF70 File Offset: 0x0024E170
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForSecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194
		{
			get
			{
				short num = (short)446496769;
				if (num != 0)
				{
				}
				num = (short)1635927342;
				short num2 = num;
				num = (short)571426094;
				switch (num2 == num)
				{
				}
				num = (short)213188608;
				if (num != 0)
				{
				}
				num = (short)2111111168;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x17001310 RID: 4880
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x0025002C File Offset: 0x0024E22C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1232562134;
				short num2 = num;
				num = (short)2016045014;
				switch (num2 == num)
				{
				}
				num = (short)1211301888;
				if (num != 0)
				{
				}
				num = (short)154861569;
				if (num != 0)
				{
				}
				num = (short)1896808448;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17001311 RID: 4881
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x002500DC File Offset: 0x0024E2DC
		// (set) Token: 0x060025F7 RID: 9719 RVA: 0x00250190 File Offset: 0x0024E390
		public int SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667Value
		{
			get
			{
				short num = (short)710803457;
				if (num != 0)
				{
				}
				num = (short)1086851095;
				short num2 = num;
				num = (short)793774103;
				switch (num2 == num)
				{
				}
				num = (short)1885995008;
				if (num != 0)
				{
				}
				num = (short)1790050304;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Value;
			}
			set
			{
				short num = (short)1083859826;
				short num2 = num;
				num = (short)1633772402;
				switch (num2 == num)
				{
				}
				num = (short)1954152449;
				if (num != 0)
				{
				}
				num = (short)232062976;
				if (num != 0)
				{
				}
				num = (short)2104492032;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Value = value;
			}
		}

		// Token: 0x17001312 RID: 4882
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x00250248 File Offset: 0x0024E448
		public global::AcpBusinessLayer.AcpPointerField<int> SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667
		{
			get
			{
				short num = (short)546469652;
				short num2 = num;
				num = (short)600930068;
				switch (num2 == num)
				{
				}
				num = (short)625672193;
				if (num != 0)
				{
				}
				num = (short)371064832;
				if (num != 0)
				{
				}
				num = (short)1865220096;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667;
			}
		}

		// Token: 0x17001313 RID: 4883
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x002502FC File Offset: 0x0024E4FC
		// (set) Token: 0x060025FA RID: 9722 RVA: 0x002503B0 File Offset: 0x0024E5B0
		public string SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_UIValue
		{
			get
			{
				short num = (short)1854441128;
				short num2 = num;
				num = (short)821200552;
				switch (num2 == num)
				{
				}
				num = (short)2144075777;
				if (num != 0)
				{
				}
				num = (short)1817640960;
				if (num != 0)
				{
				}
				num = (short)220004352;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.UIValue;
			}
			set
			{
				short num = (short)680975884;
				short num2 = num;
				num = (short)30727692;
				switch (num2 == num)
				{
				}
				num = (short)650772481;
				if (num != 0)
				{
				}
				num = (short)984940544;
				if (num != 0)
				{
				}
				num = (short)226164736;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.UIValue = value;
			}
		}

		// Token: 0x17001314 RID: 4884
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x0025046C File Offset: 0x0024E66C
		// (set) Token: 0x060025FC RID: 9724 RVA: 0x0025051C File Offset: 0x0024E71C
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_Applicable
		{
			get
			{
				short num = (short)1497066219;
				short num2 = num;
				num = (short)1809148651;
				switch (num2 == num)
				{
				}
				num = (short)864288769;
				if (num != 0)
				{
				}
				num = (short)521601024;
				if (num != 0)
				{
				}
				num = (short)241303552;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Applicable;
			}
			set
			{
				short num = (short)916059521;
				short num2 = num;
				num = (short)1968436609;
				switch (num2 == num)
				{
				}
				num = (short)987037696;
				if (num != 0)
				{
				}
				num = (short)1789460481;
				if (num != 0)
				{
				}
				num = (short)657391616;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Applicable = value;
			}
		}

		// Token: 0x17001315 RID: 4885
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x002505D4 File Offset: 0x0024E7D4
		// (set) Token: 0x060025FE RID: 9726 RVA: 0x00250688 File Offset: 0x0024E888
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_Valid
		{
			get
			{
				short num = (short)1683953568;
				short num2 = num;
				num = (short)2055608224;
				switch (num2 == num)
				{
				}
				num = (short)1872756736;
				if (num != 0)
				{
				}
				num = (short)166330369;
				if (num != 0)
				{
				}
				num = (short)2042822656;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Valid;
			}
			set
			{
				short num = (short)1611367990;
				short num2 = num;
				num = (short)409241142;
				switch (num2 == num)
				{
				}
				num = (short)1760886785;
				if (num != 0)
				{
				}
				num = (short)59113472;
				if (num != 0)
				{
				}
				num = (short)2073493504;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Valid = value;
			}
		}

		// Token: 0x17001316 RID: 4886
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x0025073C File Offset: 0x0024E93C
		// (set) Token: 0x06002600 RID: 9728 RVA: 0x002507F0 File Offset: 0x0024E9F0
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_Visible
		{
			get
			{
				short num = (short)1381186077;
				short num2 = num;
				num = (short)737557021;
				switch (num2 == num)
				{
				}
				num = (short)347734016;
				if (num != 0)
				{
				}
				num = (short)688914433;
				if (num != 0)
				{
				}
				num = (short)1169096704;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Visible;
			}
			set
			{
				short num = (short)112404035;
				short num2 = num;
				num = (short)1094133315;
				switch (num2 == num)
				{
				}
				num = (short)905248768;
				if (num != 0)
				{
				}
				num = (short)514326529;
				if (num != 0)
				{
				}
				num = (short)1826684928;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Visible = value;
			}
		}

		// Token: 0x17001317 RID: 4887
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x002508A4 File Offset: 0x0024EAA4
		// (set) Token: 0x06002602 RID: 9730 RVA: 0x00250958 File Offset: 0x0024EB58
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_Editable
		{
			get
			{
				short num = (short)1764410364;
				short num2 = num;
				num = (short)2058077180;
				switch (num2 == num)
				{
				}
				num = (short)1980497921;
				if (num != 0)
				{
				}
				num = (short)922615808;
				if (num != 0)
				{
				}
				num = (short)535625728;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Editable;
			}
			set
			{
				short num = (short)2067538936;
				short num2 = num;
				num = (short)1087841272;
				switch (num2 == num)
				{
				}
				num = (short)1042481152;
				if (num != 0)
				{
				}
				num = (short)259260417;
				if (num != 0)
				{
				}
				num = (short)1480327168;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.Editable = value;
			}
		}

		// Token: 0x17001318 RID: 4888
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x00250A10 File Offset: 0x0024EC10
		internal string SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_UILabel
		{
			get
			{
				short num = (short)1608843265;
				if (num != 0)
				{
				}
				num = (short)1125263782;
				short num2 = num;
				num = (short)1902651814;
				switch (num2 == num)
				{
				}
				num = (short)1119682560;
				if (num != 0)
				{
				}
				num = (short)154206208;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.UIName;
			}
		}

		// Token: 0x17001319 RID: 4889
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x00250AC4 File Offset: 0x0024ECC4
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x00250B78 File Offset: 0x0024ED78
		internal bool SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_HiddenStatic
		{
			get
			{
				short num = (short)858562583;
				short num2 = num;
				num = (short)1587060759;
				switch (num2 == num)
				{
				}
				num = (short)785842177;
				if (num != 0)
				{
				}
				num = (short)1369047040;
				if (num != 0)
				{
				}
				num = (short)1846280192;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.HiddenStatic;
			}
			set
			{
				short num = (short)1941223490;
				short num2 = num;
				num = (short)192919618;
				switch (num2 == num)
				{
				}
				num = (short)88604673;
				if (num != 0)
				{
				}
				num = (short)383516672;
				if (num != 0)
				{
				}
				num = (short)177405952;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.HiddenStatic = value;
			}
		}

		// Token: 0x1700131A RID: 4890
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x00250C30 File Offset: 0x0024EE30
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x00250CE8 File Offset: 0x0024EEE8
		internal bool SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_HiddenDynamic
		{
			get
			{
				short num = (short)941110308;
				short num2 = num;
				num = (short)218313764;
				switch (num2 == num)
				{
				}
				num = (short)299106305;
				if (num != 0)
				{
				}
				num = (short)445841408;
				if (num != 0)
				{
				}
				num = (short)824639488;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.HiddenDynamic;
			}
			set
			{
				short num = (short)439291306;
				short num2 = num;
				num = (short)1651379626;
				switch (num2 == num)
				{
				}
				num = (short)1319108609;
				if (num != 0)
				{
				}
				num = (short)1918304256;
				if (num != 0)
				{
				}
				num = (short)1961230336;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667.HiddenDynamic = value;
			}
		}

		// Token: 0x1700131B RID: 4891
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x00250D9C File Offset: 0x0024EF9C
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667_HasDiffs
		{
			get
			{
				short num = (short)407719885;
				short num2 = num;
				num = (short)819089357;
				switch (num2 == num)
				{
				}
				num = (short)698220545;
				if (num != 0)
				{
				}
				num = (short)239206400;
				if (num != 0)
				{
				}
				num = (short)256835584;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667._HasDiffs;
			}
		}

		// Token: 0x1700131C RID: 4892
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x00250E50 File Offset: 0x0024F050
		// (set) Token: 0x0600260A RID: 9738 RVA: 0x00250F04 File Offset: 0x0024F104
		public int SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194Value
		{
			get
			{
				short num = (short)1662186084;
				short num2 = num;
				num = (short)900461156;
				switch (num2 == num)
				{
				}
				num = (short)790298624;
				if (num != 0)
				{
				}
				num = (short)44564481;
				if (num != 0)
				{
				}
				num = (short)858390528;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Value;
			}
			set
			{
				short num = (short)1243386913;
				short num2 = num;
				num = (short)1243714593;
				switch (num2 == num)
				{
				}
				num = (short)1761738753;
				if (num != 0)
				{
				}
				num = (short)1173749760;
				if (num != 0)
				{
				}
				num = (short)1248133120;
				short num3 = num;
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Value = value;
			}
		}

		// Token: 0x1700131D RID: 4893
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00250FB8 File Offset: 0x0024F1B8
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x00251070 File Offset: 0x0024F270
		public string SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_UIValue
		{
			get
			{
				short num = (short)1607658707;
				short num2 = num;
				num = (short)1103883475;
				switch (num2 == num)
				{
				}
				num = (short)1290338305;
				if (num != 0)
				{
				}
				num = (short)950206464;
				if (num != 0)
				{
				}
				num = (short)1682833408;
				short num3 = num;
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.UIValue;
			}
			set
			{
				short num = (short)1241907200;
				short num2 = num;
				num = (short)2076180481;
				if (num != 0)
				{
				}
				num = (short)1401880819;
				short num3 = num;
				num = (short)1753219315;
				switch (num3 == num)
				{
				}
				num = (short)1020067840;
				if (num != 0)
				{
				}
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.UIValue = value;
			}
		}

		// Token: 0x1700131E RID: 4894
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x00251128 File Offset: 0x0024F328
		public global::AcpBusinessLayer.AcpRecRefField SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194
		{
			get
			{
				short num = (short)2060124160;
				short num2 = num;
				num = (short)1215889409;
				if (num != 0)
				{
				}
				num = (short)1121173009;
				short num3 = num;
				num = (short)1441381905;
				switch (num3 == num)
				{
				}
				num = (short)757727232;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;
			}
		}

		// Token: 0x1700131F RID: 4895
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x002511D8 File Offset: 0x0024F3D8
		// (set) Token: 0x0600260F RID: 9743 RVA: 0x0025128C File Offset: 0x0024F48C
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_Applicable
		{
			get
			{
				short num = (short)1670840320;
				short num2 = num;
				num = (short)710019892;
				short num3 = num;
				num = (short)479267636;
				switch (num3 == num)
				{
				}
				num = (short)18350080;
				if (num != 0)
				{
				}
				num = (short)311623681;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Applicable;
			}
			set
			{
				short num = (short)1817772032;
				short num2 = num;
				num = (short)104701144;
				short num3 = num;
				num = (short)1512086744;
				switch (num3 == num)
				{
				}
				num = (short)1360986112;
				if (num != 0)
				{
				}
				num = (short)912785409;
				if (num != 0)
				{
				}
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Applicable = value;
			}
		}

		// Token: 0x17001320 RID: 4896
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x00251344 File Offset: 0x0024F544
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x002513F8 File Offset: 0x0024F5F8
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_Valid
		{
			get
			{
				short num = (short)970457088;
				short num2 = num;
				num = (short)1334589847;
				short num3 = num;
				num = (short)410532247;
				switch (num3 == num)
				{
				}
				num = (short)1259667456;
				if (num != 0)
				{
				}
				num = (short)2094465025;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Valid;
			}
			set
			{
				short num = (short)1202257920;
				short num2 = num;
				num = (short)1940713388;
				short num3 = num;
				num = (short)590278572;
				switch (num3 == num)
				{
				}
				num = (short)167247873;
				if (num != 0)
				{
				}
				num = (short)739377152;
				if (num != 0)
				{
				}
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Valid = value;
			}
		}

		// Token: 0x17001321 RID: 4897
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x002514AC File Offset: 0x0024F6AC
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x00251560 File Offset: 0x0024F760
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_Visible
		{
			get
			{
				short num = (short)719126528;
				short num2 = num;
				num = (short)517196549;
				short num3 = num;
				num = (short)672713477;
				switch (num3 == num)
				{
				}
				num = (short)54460417;
				if (num != 0)
				{
				}
				num = (short)563150848;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Visible;
			}
			set
			{
				short num = (short)1660747776;
				short num2 = num;
				num = (short)26902166;
				short num3 = num;
				num = (short)666599062;
				switch (num3 == num)
				{
				}
				num = (short)1002635264;
				if (num != 0)
				{
				}
				num = (short)255131649;
				if (num != 0)
				{
				}
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Visible = value;
			}
		}

		// Token: 0x17001322 RID: 4898
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x00251614 File Offset: 0x0024F814
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x002516C8 File Offset: 0x0024F8C8
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_Editable
		{
			get
			{
				short num = (short)1149501440;
				short num2 = num;
				num = (short)641680681;
				short num3 = num;
				num = (short)2130855209;
				switch (num3 == num)
				{
				}
				num = (short)1814233088;
				if (num != 0)
				{
				}
				num = (short)756809729;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Editable;
			}
			set
			{
				short num = (short)571736064;
				short num2 = num;
				num = (short)377165224;
				short num3 = num;
				num = (short)1189418408;
				switch (num3 == num)
				{
				}
				num = (short)2015559681;
				if (num != 0)
				{
				}
				num = (short)1064894464;
				if (num != 0)
				{
				}
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.Editable = value;
			}
		}

		// Token: 0x17001323 RID: 4899
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x0025177C File Offset: 0x0024F97C
		internal string SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_UILabel
		{
			get
			{
				short num = (short)1761804288;
				short num2 = num;
				num = (short)1693712385;
				if (num != 0)
				{
				}
				num = (short)1214557925;
				short num3 = num;
				num = (short)1492889317;
				switch (num3 == num)
				{
				}
				num = (short)1104740352;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.UIName;
			}
		}

		// Token: 0x17001324 RID: 4900
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x00251834 File Offset: 0x0024FA34
		// (set) Token: 0x06002618 RID: 9752 RVA: 0x002518EC File Offset: 0x0024FAEC
		internal bool SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_HiddenStatic
		{
			get
			{
				short num = (short)2016083968;
				short num2 = num;
				num = (short)1008365281;
				short num3 = num;
				num = (short)720793313;
				switch (num3 == num)
				{
				}
				num = (short)181469185;
				if (num != 0)
				{
				}
				num = (short)466288640;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.HiddenStatic;
			}
			set
			{
				short num = (short)1911816192;
				short num2 = num;
				num = (short)639377542;
				short num3 = num;
				num = (short)1537220742;
				switch (num3 == num)
				{
				}
				num = (short)709820417;
				if (num != 0)
				{
				}
				num = (short)316407808;
				if (num != 0)
				{
				}
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.HiddenStatic = value;
			}
		}

		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x002519A4 File Offset: 0x0024FBA4
		// (set) Token: 0x0600261A RID: 9754 RVA: 0x00251A58 File Offset: 0x0024FC58
		internal bool SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_HiddenDynamic
		{
			get
			{
				short num = (short)813826048;
				short num2 = num;
				num = (short)107675649;
				if (num != 0)
				{
				}
				num = (short)391093704;
				short num3 = num;
				num = (short)1984798152;
				switch (num3 == num)
				{
				}
				num = (short)852819968;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.HiddenDynamic;
			}
			set
			{
				short num = (short)1751187456;
				short num2 = num;
				num = (short)1213358945;
				short num3 = num;
				num = (short)1598186337;
				switch (num3 == num)
				{
				}
				num = (short)1608122368;
				if (num != 0)
				{
				}
				num = (short)1662779393;
				if (num != 0)
				{
				}
				this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.HiddenDynamic = value;
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x00251B10 File Offset: 0x0024FD10
		public bool SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194_HasDiffs
		{
			get
			{
				short num = (short)1479999488;
				short num2 = num;
				num = (short)2004754553;
				short num3 = num;
				num = (short)869081209;
				switch (num3 == num)
				{
				}
				num = (short)708313088;
				if (num != 0)
				{
				}
				num = (short)1121648641;
				if (num != 0)
				{
				}
				return this.secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194._HasDiffs;
			}
		}

		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x00251BC4 File Offset: 0x0024FDC4
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)141033472;
				short num2 = num;
				num = (short)679466847;
				short num3 = num;
				num = (short)846845791;
				switch (num3 == num)
				{
				}
				num = (short)960167937;
				if (num != 0)
				{
				}
				num = (short)1467416576;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x0600261D RID: 9757 RVA: 0x00251C80 File Offset: 0x0024FE80
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation RefRadioInformation
		{
			get
			{
				short num = (short)2144600064;
				short num2 = num;
				num = (short)2070740993;
				if (num != 0)
				{
				}
				num = (short)138500415;
				short num3 = num;
				num = (short)1842501951;
				switch (num3 == num)
				{
				}
				num = (short)806617088;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			}
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00251D3C File Offset: 0x0024FF3C
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
					goto IL_65;
				case 1:
				{
					num2 = (short)1986421178;
					short num3 = num2;
					num2 = (short)1092837818;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
						num2 = (short)1338638336;
						if (num2 != 0)
						{
						}
						num2 = (short)1224015875;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return result;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)162660356;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1307639809;
					if (num2 != 0)
					{
					}
					num2 = (short)901447682;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_65:
				if (base.ParentRecset == null)
				{
					break;
				}
				num2 = (short)1955725313;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			num2 = (short)233570304;
			short num4 = num2;
			result = null;
			num2 = (short)1337458688;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000D73 RID: 3443
		private global::AcpBusinessLayer.AcpPointerField<int> secKmfProfSecureHardwareEncryptionKeyReferencesListCKRNumber_A7667;

		// Token: 0x04000D74 RID: 3444
		private global::AcpBusinessLayer.AcpRecRefField secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;
	}
}
