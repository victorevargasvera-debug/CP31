using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x020003A3 RID: 931
	[global::System.Serializable]
	public class O7MultiFunctionKnob : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008805 RID: 34821 RVA: 0x007E9C74 File Offset: 0x007E7E74
		public O7MultiFunctionKnob(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008806 RID: 34822 RVA: 0x007E9CB4 File Offset: 0x007E7EB4
		protected O7MultiFunctionKnob(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008807 RID: 34823 RVA: 0x007E9CCC File Offset: 0x007E7ECC
		public override void Init()
		{
			int a_ = 2;
			short num = (short)2104360960;
			short num2 = num;
			num = (short)680783544;
			short num3 = num;
			num = (short)1568337592;
			switch (num3 == num)
			{
			}
			num = (short)396361729;
			if (num != 0)
			{
			}
			num = (short)1536098304;
			if (num != 0)
			{
			}
			this.radErgoControlO7MFKButtonPress_A42218 = new global::AcpBusinessLayer.AcpSparseLOVField(215, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgoControlO7MFKButtonPress_A42218LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgoControlO7MFKButtonPress_A42218LovStrs), this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ鋐볒믔ꏖꯘ듚뇜郞훠껢ꏤ곦ꯨ黪駬鯮黰鷲ꗴ藶鳸裺軼ꃾ䀀㜂㜄㔆㠈㌊", a_), global::CommonResources.AcgResources.ID_MFKPRESSBEHAVIOR, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgoControlO7MFKButtonPress_A42218LovStrs);
			this.radErgoControlO7MFKButtonPress_A42218.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.radErgoControlO7MFKButtonPress_A42218.DataTransferOrder = 18;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軂냄ꯆ뷈ꋊ觎ꓐ뷒뛔ꏖ냘듚돜￞ꫠ跢諤藦", a_);
			base.Id = 10718;
			base.UIName = global::CommonResources.AcgResources.ID_MULTIFUNCTIONKNOB;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06008808 RID: 34824 RVA: 0x007E9E04 File Offset: 0x007E8004
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)568655874;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)266141699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1494876164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ诣裥鳧飩菫苭뿯엱맳냵돷룹觻諽瓿洁樃嘅稇漉缋納伏匑–␕⨗⬙␛", a_)))
					{
						num = (short)466223110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F5;
				case 4:
				{
					num = (short)623837184;
					short num3 = num;
					if (producerFields != null)
					{
						num = (short)1192165376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F5;
				}
				case 5:
					goto IL_147;
				case 6:
				{
					this.radErgoControlO7MFKButtonPress_A42218 = new global::AcpBusinessLayer.AcpSparseLOVField(215, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.indexRadErgoControlO7MFKButtonPress_A42218LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.idRadErgoControlO7MFKButtonPress_A42218LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ诣裥鳧飩菫苭뿯엱맳냵돷룹觻諽瓿洁樃嘅稇漉缋納伏匑–␕⨗⬙␛", a_), global::CommonResources.AcgResources.ID_MFKPRESSBEHAVIOR, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.LOVs.RadErgoControlO7MFKButtonPress_A42218LovStrs);
					this.radErgoControlO7MFKButtonPress_A42218.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.radErgoControlO7MFKButtonPress_A42218.DataTransferOrder = 18;
					num = (short)574151776;
					short num4 = num;
					num = (short)1924979808;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1679425536;
						if (num != 0)
						{
						}
						num = (short)877068293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_49:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)1707737089;
				if (num != 0)
				{
				}
				num = (short)275382273;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_147:
			IL_1F5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駓ꏕ듗껙뗛ꛟ韡諣藥鳧菩菫胭탯맱髳駵髷", a_);
			base.Id = 10718;
			base.UIName = global::CommonResources.AcgResources.ID_MULTIFUNCTIONKNOB;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06008809 RID: 34825 RVA: 0x007EA038 File Offset: 0x007E8238
		public override void PopulateReferences()
		{
			short num = (short)621412352;
			short num2 = num;
			num = (short)1713504257;
			if (num != 0)
			{
			}
			num = (short)2134759209;
			short num3 = num;
			num = (short)592434985;
			switch (num3 == num)
			{
			}
			num = (short)267583488;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600880A RID: 34826 RVA: 0x007EA0E0 File Offset: 0x007E82E0
		public override void DropReferences()
		{
			short num = (short)1388445696;
			short num2 = num;
			num = (short)508307693;
			short num3 = num;
			num = (short)1846487277;
			switch (num3 == num)
			{
			}
			num = (short)467795968;
			if (num != 0)
			{
			}
			num = (short)1124859905;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600880B RID: 34827 RVA: 0x007EA18C File Offset: 0x007E838C
		public override void SetConstraints()
		{
			short num = (short)1686503424;
			short num2 = num;
			num = (short)519638426;
			short num3 = num;
			num = (short)845680026;
			switch (num3 == num)
			{
			}
			num = (short)1154088960;
			if (num != 0)
			{
			}
			num = (short)1264582657;
			if (num != 0)
			{
			}
			this.radErgoControlO7MFKButtonPress_A42218.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.ConMFKButtonBehaviorToShepherds);
		}

		// Token: 0x0600880C RID: 34828 RVA: 0x007EA24C File Offset: 0x007E844C
		public override void SetupDependencies()
		{
			short num = (short)2072772608;
			short num2 = num;
			num = (short)639948779;
			short num3 = num;
			num = (short)827381739;
			switch (num3 == num)
			{
			}
			num = (short)981860353;
			if (num != 0)
			{
			}
			num = (short)1197932544;
			if (num != 0)
			{
			}
			this.RefControlHeadO2.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.AddDependentObject(this.radErgoControlO7MFKButtonPress_A42218);
			this.RefRadioWide.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.AddDependentObject(this.radErgoControlO7MFKButtonPress_A42218);
		}

		// Token: 0x1700452B RID: 17707
		// (get) Token: 0x0600880D RID: 34829 RVA: 0x007EA32C File Offset: 0x007E852C
		public bool HasDiffs
		{
			get
			{
				short num = (short)622067712;
				short num2 = num;
				num = (short)1022233525;
				short num3 = num;
				num = (short)1662782389;
				switch (num3 == num)
				{
				}
				num = (short)1063124993;
				if (num != 0)
				{
				}
				num = (short)1784479744;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700452C RID: 17708
		// (get) Token: 0x0600880E RID: 34830 RVA: 0x007EA3DC File Offset: 0x007E85DC
		// (set) Token: 0x0600880F RID: 34831 RVA: 0x007EA490 File Offset: 0x007E8690
		public int RadErgoControlO7MFKButtonPress_A42218Value
		{
			get
			{
				short num = (short)1385562112;
				short num2 = num;
				num = (short)492859919;
				short num3 = num;
				num = (short)95187471;
				switch (num3 == num)
				{
				}
				num = (short)1833435136;
				if (num != 0)
				{
				}
				num = (short)1715994625;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.Value;
			}
			set
			{
				short num = (short)493355008;
				short num2 = num;
				num = (short)2083907774;
				short num3 = num;
				num = (short)300673214;
				switch (num3 == num)
				{
				}
				num = (short)196870145;
				if (num != 0)
				{
				}
				num = (short)195559424;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKButtonPress_A42218.Value = value;
			}
		}

		// Token: 0x1700452D RID: 17709
		// (get) Token: 0x06008810 RID: 34832 RVA: 0x007EA544 File Offset: 0x007E8744
		// (set) Token: 0x06008811 RID: 34833 RVA: 0x007EA5F8 File Offset: 0x007E87F8
		public string RadErgoControlO7MFKButtonPress_A42218_UIValue
		{
			get
			{
				short num = (short)932315136;
				short num2 = num;
				num = (short)475501068;
				short num3 = num;
				num = (short)1141019148;
				switch (num3 == num)
				{
				}
				num = (short)452001792;
				if (num != 0)
				{
				}
				num = (short)1527513089;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.UIValue;
			}
			set
			{
				short num = (short)1855913984;
				short num2 = num;
				num = (short)834558728;
				short num3 = num;
				num = (short)1056791304;
				switch (num3 == num)
				{
				}
				num = (short)1807024129;
				if (num != 0)
				{
				}
				num = (short)193134592;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKButtonPress_A42218.UIValue = value;
			}
		}

		// Token: 0x1700452E RID: 17710
		// (get) Token: 0x06008812 RID: 34834 RVA: 0x007EA6B0 File Offset: 0x007E88B0
		public global::AcpBusinessLayer.AcpListField RadErgoControlO7MFKButtonPress_A42218
		{
			get
			{
				short num = (short)1988100096;
				short num2 = num;
				num = (short)118344645;
				short num3 = num;
				num = (short)1001180101;
				switch (num3 == num)
				{
				}
				num = (short)839385088;
				if (num != 0)
				{
				}
				num = (short)325189633;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218;
			}
		}

		// Token: 0x1700452F RID: 17711
		// (get) Token: 0x06008813 RID: 34835 RVA: 0x007EA764 File Offset: 0x007E8964
		// (set) Token: 0x06008814 RID: 34836 RVA: 0x007EA818 File Offset: 0x007E8A18
		public bool RadErgoControlO7MFKButtonPress_A42218_Applicable
		{
			get
			{
				short num = (short)1665531904;
				short num2 = num;
				num = (short)1787105270;
				short num3 = num;
				num = (short)950145014;
				switch (num3 == num)
				{
				}
				num = (short)1032323072;
				if (num != 0)
				{
				}
				num = (short)23330817;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.Applicable;
			}
			set
			{
				short num = (short)1267466240;
				short num2 = num;
				num = (short)687977914;
				short num3 = num;
				num = (short)341554618;
				switch (num3 == num)
				{
				}
				num = (short)1146552320;
				if (num != 0)
				{
				}
				num = (short)1633157121;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKButtonPress_A42218.Applicable = value;
			}
		}

		// Token: 0x17004530 RID: 17712
		// (get) Token: 0x06008815 RID: 34837 RVA: 0x007EA8CC File Offset: 0x007E8ACC
		// (set) Token: 0x06008816 RID: 34838 RVA: 0x007EA984 File Offset: 0x007E8B84
		public bool RadErgoControlO7MFKButtonPress_A42218_Valid
		{
			get
			{
				short num = (short)1092681728;
				short num2 = num;
				num = (short)1404960769;
				if (num != 0)
				{
				}
				num = (short)272551905;
				short num3 = num;
				num = (short)149540833;
				switch (num3 == num)
				{
				}
				num = (short)1094975488;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.Valid;
			}
			set
			{
				short num = (short)619118592;
				short num2 = num;
				num = (short)1659502593;
				if (num != 0)
				{
				}
				num = (short)1511312947;
				short num3 = num;
				num = (short)624610867;
				switch (num3 == num)
				{
				}
				num = (short)1160249344;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKButtonPress_A42218.Valid = value;
			}
		}

		// Token: 0x17004531 RID: 17713
		// (get) Token: 0x06008817 RID: 34839 RVA: 0x007EAA3C File Offset: 0x007E8C3C
		// (set) Token: 0x06008818 RID: 34840 RVA: 0x007EAAF0 File Offset: 0x007E8CF0
		public bool RadErgoControlO7MFKButtonPress_A42218_Visible
		{
			get
			{
				short num = (short)59899904;
				short num2 = num;
				num = (short)1511915521;
				if (num != 0)
				{
				}
				num = (short)868381347;
				short num3 = num;
				num = (short)412250787;
				switch (num3 == num)
				{
				}
				num = (short)549060608;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.Visible;
			}
			set
			{
				short num = (short)967770112;
				short num2 = num;
				num = (short)91367499;
				short num3 = num;
				num = (short)1006446667;
				switch (num3 == num)
				{
				}
				num = (short)2036203520;
				if (num != 0)
				{
				}
				num = (short)1849491457;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKButtonPress_A42218.Visible = value;
			}
		}

		// Token: 0x17004532 RID: 17714
		// (get) Token: 0x06008819 RID: 34841 RVA: 0x007EABA4 File Offset: 0x007E8DA4
		// (set) Token: 0x0600881A RID: 34842 RVA: 0x007EAC58 File Offset: 0x007E8E58
		public bool RadErgoControlO7MFKButtonPress_A42218_Editable
		{
			get
			{
				short num = (short)1957494784;
				short num2 = num;
				num = (short)1456615093;
				short num3 = num;
				num = (short)746532533;
				switch (num3 == num)
				{
				}
				num = (short)1948254209;
				if (num != 0)
				{
				}
				num = (short)45744128;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.Editable;
			}
			set
			{
				short num = (short)1536294912;
				short num2 = num;
				num = (short)1613311453;
				short num3 = num;
				num = (short)1736846813;
				switch (num3 == num)
				{
				}
				num = (short)589168640;
				if (num != 0)
				{
				}
				num = (short)254214145;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKButtonPress_A42218.Editable = value;
			}
		}

		// Token: 0x17004533 RID: 17715
		// (get) Token: 0x0600881B RID: 34843 RVA: 0x007EAD10 File Offset: 0x007E8F10
		internal string RadErgoControlO7MFKButtonPress_A42218_UILabel
		{
			get
			{
				short num = (short)1254227968;
				short num2 = num;
				num = (short)1692285709;
				short num3 = num;
				num = (short)108935949;
				switch (num3 == num)
				{
				}
				num = (short)1966276609;
				if (num != 0)
				{
				}
				num = (short)2095710208;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.UIName;
			}
		}

		// Token: 0x17004534 RID: 17716
		// (get) Token: 0x0600881C RID: 34844 RVA: 0x007EADC4 File Offset: 0x007E8FC4
		// (set) Token: 0x0600881D RID: 34845 RVA: 0x007EAE78 File Offset: 0x007E9078
		internal bool RadErgoControlO7MFKButtonPress_A42218_HiddenStatic
		{
			get
			{
				short num = (short)966262784;
				short num2 = num;
				num = (short)770958642;
				short num3 = num;
				num = (short)1032643890;
				switch (num3 == num)
				{
				}
				num = (short)1537015809;
				if (num != 0)
				{
				}
				num = (short)239927296;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.HiddenStatic;
			}
			set
			{
				short num = (short)12648448;
				short num2 = num;
				num = (short)852652974;
				short num3 = num;
				num = (short)838562734;
				switch (num3 == num)
				{
				}
				num = (short)1665859585;
				if (num != 0)
				{
				}
				num = (short)749600768;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKButtonPress_A42218.HiddenStatic = value;
			}
		}

		// Token: 0x17004535 RID: 17717
		// (get) Token: 0x0600881E RID: 34846 RVA: 0x007EAF2C File Offset: 0x007E912C
		// (set) Token: 0x0600881F RID: 34847 RVA: 0x007EAFE0 File Offset: 0x007E91E0
		internal bool RadErgoControlO7MFKButtonPress_A42218_HiddenDynamic
		{
			get
			{
				short num = (short)953876480;
				short num2 = num;
				num = (short)766673475;
				short num3 = num;
				num = (short)160531011;
				switch (num3 == num)
				{
				}
				num = (short)1380909056;
				if (num != 0)
				{
				}
				num = (short)180355073;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218.HiddenDynamic;
			}
			set
			{
				short num = (short)1734934528;
				short num2 = num;
				num = (short)1323357507;
				short num3 = num;
				num = (short)721016131;
				switch (num3 == num)
				{
				}
				num = (short)537591808;
				if (num != 0)
				{
				}
				num = (short)1289748481;
				if (num != 0)
				{
				}
				this.radErgoControlO7MFKButtonPress_A42218.HiddenDynamic = value;
			}
		}

		// Token: 0x17004536 RID: 17718
		// (get) Token: 0x06008820 RID: 34848 RVA: 0x007EB098 File Offset: 0x007E9298
		public bool RadErgoControlO7MFKButtonPress_A42218_HasDiffs
		{
			get
			{
				short num = (short)2038366208;
				short num2 = num;
				num = (short)24045315;
				short num3 = num;
				num = (short)327935747;
				switch (num3 == num)
				{
				}
				num = (short)1155399681;
				if (num != 0)
				{
				}
				num = (short)1620180992;
				if (num != 0)
				{
				}
				return this.radErgoControlO7MFKButtonPress_A42218._HasDiffs;
			}
		}

		// Token: 0x17004537 RID: 17719
		// (get) Token: 0x06008821 RID: 34849 RVA: 0x007EB14C File Offset: 0x007E934C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2 RefControlHeadO2
		{
			get
			{
				short num = (short)1795883008;
				short num2 = num;
				num = (short)963727398;
				short num3 = num;
				num = (short)1058689062;
				switch (num3 == num)
				{
				}
				num = (short)254345217;
				if (num != 0)
				{
				}
				num = (short)335609856;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4115)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2;
			}
		}

		// Token: 0x17004538 RID: 17720
		// (get) Token: 0x06008822 RID: 34850 RVA: 0x007EB20C File Offset: 0x007E940C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1807482880;
				short num2 = num;
				num = (short)1438162953;
				short num3 = num;
				num = (short)1562419209;
				switch (num3 == num)
				{
				}
				num = (short)851378176;
				if (num != 0)
				{
				}
				num = (short)756940801;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06008823 RID: 34851 RVA: 0x007EB2CC File Offset: 0x007E94CC
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
					if (base.ParentRecset != null)
					{
						num2 = (short)2092367875;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					goto IL_F9;
				case 2:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1322056881;
					short num3 = num2;
					num2 = (short)2019818673;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)957415424;
						if (num2 != 0)
						{
						}
						num2 = (short)1724579841;
						if (num2 != 0)
						{
						}
						num2 = (short)738131969;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)1663762436;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)925564930;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			IL_F9:
			num2 = (short)1153564672;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1251278848;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003FFE RID: 16382
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset innerRecset;

		// Token: 0x04003FFF RID: 16383
		private global::AcpBusinessLayer.AcpListField radErgoControlO7MFKButtonPress_A42218;
	}
}
