using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001DD RID: 477
	[global::System.Serializable]
	public class GlobalShepherdListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060053C8 RID: 21448 RVA: 0x004C0994 File Offset: 0x004BEB94
		public GlobalShepherdListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x004C09B0 File Offset: 0x004BEBB0
		protected GlobalShepherdListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x004C09C8 File Offset: 0x004BEBC8
		public override void Init()
		{
			int a_ = 2;
			short num = (short)878737465;
			short num2 = num;
			num = (short)545290297;
			switch (num2 == num)
			{
			}
			num = (short)1716256768;
			if (num != 0)
			{
			}
			num = (short)1811611648;
			short num3 = num;
			num = (short)498204673;
			if (num != 0)
			{
			}
			this.radErgoCfgSignalIndepBtnListID_A21171 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ鋐뗒닔蓖냘볚돜뻞跠ꫢ诤菦賨鯪꿬鯮鿰뿲鳴蓶跸닺맼ꃾ䀀㄂㐄㘆㸈㨊", a_), global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTBUTTONLISTID, 0, 65535, null, null, 0, 1);
			this.radErgoCfgSignalIndepBtnListID_A21171.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndepBtnListID_A21171.DataTransferOrder = -1;
			this.radErgoCfgSignalIndepBtnListID_A21171.ShowHexValue = false;
			this.radErgoCfgSignalIndepBtnListKey_A21276 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ鋐뗒닔蓖냘볚돜뻞跠ꫢ诤菦賨鯪꿬鯮鿰뿲鳴蓶跸냺飼蛾帀䈂㜄㘆㬈㰊㬌", a_), global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTBUTTONLISTKEY, 14);
			this.radErgoCfgSignalIndepBtnListKey_A21276.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndepBtnListKey_A21276.DataTransferOrder = -1;
			this.radErgoCfgSignalIndepBtnListType_A21172 = new global::AcpBusinessLayer.AcpSparseLOVField(1002, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndepBtnListType_A21172LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndepBtnListType_A21172LovStrs), this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ鋐뗒닔蓖냘볚돜뻞跠ꫢ诤菦賨鯪꿬鯮鿰뿲鳴蓶跸꿺蓼迾搀専䐄㔆㠈㨊㨌㴎", a_), global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTBUTTONLISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndepBtnListType_A21172LovStrs);
			this.radErgoCfgSignalIndepBtnListType_A21172.IgnoreOnCompare = true;
			this.radErgoCfgSignalIndepBtnListType_A21172.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSignalIndepBtnListType_A21172.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓂꧄꣆ꯈ꫊ꇌ苐믒냔Ꟗ뇘뻚꿜믞쇠꿢賤铦鷨", a_);
			base.Id = 10034;
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALSHEPHERDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x004C0B8C File Offset: 0x004BED8C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1648492554;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoCfgSignalIndepBtnListID_A21171 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚軜뛞蛠跢蓤详ꃨ藪觬諮臰뇲致駶뗸鋺軼课䠀䜂娄䘆㬈㨊㰌㠎‐", a_), global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTBUTTONLISTID, null, null, 0, 1);
					this.radErgoCfgSignalIndepBtnListID_A21171.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndepBtnListID_A21171.DataTransferOrder = -1;
					this.radErgoCfgSignalIndepBtnListID_A21171.ShowHexValue = false;
					num = (short)110166017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_D9;
				case 2:
				{
					num = (short)220790784;
					short num3 = num;
					if (producerFields != null)
					{
						num = (short)159449092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_374;
				}
				case 3:
					num = (short)1259798530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)992411659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.radErgoCfgSignalIndepBtnListKey_A21276 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚軜뛞蛠跢蓤详ꃨ藪觬諮臰뇲致駶뗸鋺軼课䨀昂簄堆䠈㤊㰌㴎☐┒", a_), global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTBUTTONLISTKEY, 14);
					this.radErgoCfgSignalIndepBtnListKey_A21276.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndepBtnListKey_A21276.DataTransferOrder = -1;
					num = (short)1750925318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_29C;
				case 7:
					num = (short)1618411521;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚軜뛞蛠跢蓤详ꃨ藪觬諮臰뇲致駶뗸鋺軼课唀稂甄戆嘈䨊㼌㸎‐␒✔", a_)))
					{
						num = (short)1771241484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_374;
				case 8:
					goto IL_235;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚軜뛞蛠跢蓤详ꃨ藪觬諮臰뇲致駶뗸鋺軼课䨀昂簄堆䠈㤊㰌㴎☐┒", a_)))
					{
						num = (short)755302405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_29C;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚軜뛞蛠跢蓤详ꃨ藪觬諮臰뇲致駶뗸鋺軼课䠀䜂娄䘆㬈㨊㰌㠎‐", a_)))
					{
						goto IL_1A5;
					}
					goto IL_D9;
				case 12:
					this.radErgoCfgSignalIndepBtnListType_A21172 = new global::AcpBusinessLayer.AcpSparseLOVField(1002, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgSignalIndepBtnListType_A21172LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgSignalIndepBtnListType_A21172LovStrs), this, global::AllFeatures.CodeplugGuid.b("鯈꫊꧌諎ꏐ듒뫔铖뿘볚軜뛞蛠跢蓤详ꃨ藪觬諮臰뇲致駶뗸鋺軼课唀稂甄戆嘈䨊㼌㸎‐␒✔", a_), global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTBUTTONLISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgSignalIndepBtnListType_A21172LovStrs);
					this.radErgoCfgSignalIndepBtnListType_A21172.IgnoreOnCompare = true;
					this.radErgoCfgSignalIndepBtnListType_A21172.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSignalIndepBtnListType_A21172.DataTransferOrder = -1;
					num = (short)293797896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1337786371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_D9:
				num = (short)1460972389;
				short num4 = num;
				num = (short)1383902053;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1A5:
					num = (short)958267392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1221132288;
					if (num != 0)
					{
					}
					num = (short)1157758985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_29C:
				num = (short)1399783431;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_235:
			IL_374:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈ꟊꋌ귎냐뿒蓖뇘뻚규럞蓠釢臤쟦ꗨ苪黬鯮", a_);
			base.Id = 10034;
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALSHEPHERDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x004C0F40 File Offset: 0x004BF140
		public override void PopulateReferences()
		{
			short num = (short)1298647448;
			short num2 = num;
			num = (short)356174232;
			switch (num2 == num)
			{
			}
			num = (short)329973761;
			if (num != 0)
			{
			}
			num = (short)1205338112;
			short num3 = num;
			num = (short)107020288;
			if (num != 0)
			{
			}
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x004C0FE8 File Offset: 0x004BF1E8
		public override void DropReferences()
		{
			short num = (short)1662489627;
			short num2 = num;
			num = (short)1145082907;
			switch (num2 == num)
			{
			}
			num = (short)933167105;
			if (num != 0)
			{
			}
			num = (short)1736966144;
			short num3 = num;
			num = (short)1682112512;
			if (num != 0)
			{
			}
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x004C1094 File Offset: 0x004BF294
		public override void SetConstraints()
		{
			short num = (short)858716544;
			short num2 = num;
			num = (short)966850944;
			switch (num2 == num)
			{
			}
			num = (short)1646002177;
			if (num != 0)
			{
			}
			num = (short)2057961472;
			short num3 = num;
			num = (short)1028194304;
			if (num != 0)
			{
			}
			this.radErgoCfgSignalIndepBtnListID_A21171.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x004C1158 File Offset: 0x004BF358
		public override void SetupDependencies()
		{
			short num = (short)1841191915;
			short num2 = num;
			num = (short)569727979;
			switch (num2 == num)
			{
			}
			num = (short)1510211585;
			if (num != 0)
			{
			}
			num = (short)464125952;
			short num3 = num;
			num = (short)612040704;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x060053D0 RID: 21456 RVA: 0x004C1204 File Offset: 0x004BF404
		public bool HasDiffs
		{
			get
			{
				short num = (short)1392661550;
				short num2 = num;
				num = (short)926635054;
				switch (num2 == num)
				{
				}
				num = (short)183435264;
				if (num != 0)
				{
				}
				num = (short)962396160;
				short num3 = num;
				num = (short)1328742401;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x060053D1 RID: 21457 RVA: 0x004C12B4 File Offset: 0x004BF4B4
		// (set) Token: 0x060053D2 RID: 21458 RVA: 0x004C1368 File Offset: 0x004BF568
		public int RadErgoCfgSignalIndepBtnListID_A21171Value
		{
			get
			{
				short num = (short)2034648337;
				short num2 = num;
				num = (short)1135166737;
				switch (num2 == num)
				{
				}
				num = (short)1021378561;
				if (num != 0)
				{
				}
				num = (short)775880704;
				short num3 = num;
				num = (short)1473511424;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.Value;
			}
			set
			{
				short num = (short)2089707795;
				short num2 = num;
				num = (short)1168075027;
				switch (num2 == num)
				{
				}
				num = (short)1803419649;
				if (num != 0)
				{
				}
				num = (short)1251082240;
				short num3 = num;
				num = (short)867172352;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.Value = value;
			}
		}

		// Token: 0x17002B5B RID: 11099
		// (get) Token: 0x060053D3 RID: 21459 RVA: 0x004C141C File Offset: 0x004BF61C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgSignalIndepBtnListID_A21171
		{
			get
			{
				short num = (short)1245360124;
				short num2 = num;
				num = (short)153333756;
				switch (num2 == num)
				{
				}
				num = (short)1242955777;
				if (num != 0)
				{
				}
				num = (short)1731198976;
				short num3 = num;
				num = (short)177274880;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171;
			}
		}

		// Token: 0x17002B5C RID: 11100
		// (get) Token: 0x060053D4 RID: 21460 RVA: 0x004C14D0 File Offset: 0x004BF6D0
		// (set) Token: 0x060053D5 RID: 21461 RVA: 0x004C1588 File Offset: 0x004BF788
		public string RadErgoCfgSignalIndepBtnListID_A21171_UIValue
		{
			get
			{
				short num = (short)9150483;
				short num2 = num;
				num = (short)1618976787;
				switch (num2 == num)
				{
				}
				num = (short)239992832;
				if (num != 0)
				{
				}
				num = (short)495517696;
				short num3 = num;
				num = (short)1973485569;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.UIValue;
			}
			set
			{
				short num = (short)2025846695;
				short num2 = num;
				num = (short)1599797159;
				switch (num2 == num)
				{
				}
				num = (short)212795393;
				if (num != 0)
				{
				}
				num = (short)961282048;
				short num3 = num;
				num = (short)547553280;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.UIValue = value;
			}
		}

		// Token: 0x17002B5D RID: 11101
		// (get) Token: 0x060053D6 RID: 21462 RVA: 0x004C1640 File Offset: 0x004BF840
		// (set) Token: 0x060053D7 RID: 21463 RVA: 0x004C16F4 File Offset: 0x004BF8F4
		internal int RadErgoCfgSignalIndepBtnListID_A21171Min
		{
			get
			{
				short num = (short)701835256;
				short num2 = num;
				num = (short)1551640568;
				switch (num2 == num)
				{
				}
				num = (short)1693581312;
				if (num != 0)
				{
				}
				num = (short)1899888640;
				short num3 = num;
				num = (short)718209025;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.Min;
			}
			set
			{
				short num = (short)1249023455;
				short num2 = num;
				num = (short)1922209247;
				switch (num2 == num)
				{
				}
				num = (short)320339968;
				if (num != 0)
				{
				}
				num = (short)2113929216;
				short num3 = num;
				num = (short)2079326209;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.Min = value;
			}
		}

		// Token: 0x17002B5E RID: 11102
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x004C17A8 File Offset: 0x004BF9A8
		// (set) Token: 0x060053D9 RID: 21465 RVA: 0x004C1860 File Offset: 0x004BFA60
		internal int RadErgoCfgSignalIndepBtnListID_A21171Max
		{
			get
			{
				short num = (short)540183196;
				short num2 = num;
				num = (short)536119964;
				switch (num2 == num)
				{
				}
				num = (short)75038721;
				if (num != 0)
				{
				}
				num = (short)370212864;
				short num3 = num;
				num = (short)1394999296;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.Max;
			}
			set
			{
				short num = (short)618305040;
				short num2 = num;
				num = (short)965514768;
				switch (num2 == num)
				{
				}
				num = (short)68747265;
				if (num != 0)
				{
				}
				num = (short)329449472;
				short num3 = num;
				num = (short)666501120;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.Max = value;
			}
		}

		// Token: 0x17002B5F RID: 11103
		// (get) Token: 0x060053DA RID: 21466 RVA: 0x004C1914 File Offset: 0x004BFB14
		// (set) Token: 0x060053DB RID: 21467 RVA: 0x004C19C8 File Offset: 0x004BFBC8
		internal int RadErgoCfgSignalIndepBtnListID_A21171Step
		{
			get
			{
				short num = (short)1682281107;
				short num2 = num;
				num = (short)1798083219;
				switch (num2 == num)
				{
				}
				num = (short)483852289;
				if (num != 0)
				{
				}
				num = (short)407306240;
				short num3 = num;
				num = (short)1566572544;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.StepSize;
			}
			set
			{
				short num = (short)1458644429;
				short num2 = num;
				num = (short)1359881677;
				switch (num2 == num)
				{
				}
				num = (short)1398341633;
				if (num != 0)
				{
				}
				num = (short)1507196928;
				short num3 = num;
				num = (short)1500577792;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.StepSize = value;
			}
		}

		// Token: 0x17002B60 RID: 11104
		// (get) Token: 0x060053DC RID: 21468 RVA: 0x004C1A80 File Offset: 0x004BFC80
		// (set) Token: 0x060053DD RID: 21469 RVA: 0x004C1B34 File Offset: 0x004BFD34
		public bool RadErgoCfgSignalIndepBtnListID_A21171_Applicable
		{
			get
			{
				short num = (short)130140408;
				short num2 = num;
				num = (short)583125240;
				switch (num2 == num)
				{
				}
				num = (short)1453654016;
				if (num != 0)
				{
				}
				num = (short)468582400;
				short num3 = num;
				num = (short)362938369;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.Applicable;
			}
			set
			{
				short num = (short)1740308481;
				if (num != 0)
				{
				}
				num = (short)1799689199;
				short num2 = num;
				num = (short)1244533743;
				switch (num2 == num)
				{
				}
				num = (short)102760448;
				short num3 = num;
				num = (short)955056128;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.Applicable = value;
			}
		}

		// Token: 0x17002B61 RID: 11105
		// (get) Token: 0x060053DE RID: 21470 RVA: 0x004C1BE8 File Offset: 0x004BFDE8
		// (set) Token: 0x060053DF RID: 21471 RVA: 0x004C1CA0 File Offset: 0x004BFEA0
		public bool RadErgoCfgSignalIndepBtnListID_A21171_Valid
		{
			get
			{
				short num = (short)1145749103;
				short num2 = num;
				num = (short)985382511;
				switch (num2 == num)
				{
				}
				num = (short)1885995009;
				if (num != 0)
				{
				}
				num = (short)1857552384;
				short num3 = num;
				num = (short)1949106176;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.Valid;
			}
			set
			{
				short num = (short)1055539868;
				short num2 = num;
				num = (short)142623388;
				switch (num2 == num)
				{
				}
				num = (short)153812993;
				if (num != 0)
				{
				}
				num = (short)498466816;
				short num3 = num;
				num = (short)1782185984;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.Valid = value;
			}
		}

		// Token: 0x17002B62 RID: 11106
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x004C1D54 File Offset: 0x004BFF54
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x004C1E0C File Offset: 0x004C000C
		public bool RadErgoCfgSignalIndepBtnListID_A21171_Visible
		{
			get
			{
				short num = (short)767361025;
				if (num != 0)
				{
				}
				num = (short)66561498;
				short num2 = num;
				num = (short)204187098;
				switch (num2 == num)
				{
				}
				num = (short)1544093696;
				short num3 = num;
				num = (short)2032140288;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.Visible;
			}
			set
			{
				short num = (short)981963585;
				short num2 = num;
				num = (short)1284019009;
				switch (num2 == num)
				{
				}
				num = (short)262078465;
				if (num != 0)
				{
				}
				num = (short)1133248512;
				short num3 = num;
				num = (short)1088094208;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.Visible = value;
			}
		}

		// Token: 0x17002B63 RID: 11107
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x004C1EC0 File Offset: 0x004C00C0
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x004C1F74 File Offset: 0x004C0174
		public bool RadErgoCfgSignalIndepBtnListID_A21171_Editable
		{
			get
			{
				short num = (short)820719723;
				short num2 = num;
				num = (short)385167467;
				switch (num2 == num)
				{
				}
				num = (short)1204617216;
				if (num != 0)
				{
				}
				num = (short)295763968;
				short num3 = num;
				num = (short)722468865;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.Editable;
			}
			set
			{
				short num = (short)264437510;
				short num2 = num;
				num = (short)918224646;
				switch (num2 == num)
				{
				}
				num = (short)1536819201;
				if (num != 0)
				{
				}
				num = (short)857276416;
				short num3 = num;
				num = (short)806420480;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.Editable = value;
			}
		}

		// Token: 0x17002B64 RID: 11108
		// (get) Token: 0x060053E4 RID: 21476 RVA: 0x004C202C File Offset: 0x004C022C
		internal string RadErgoCfgSignalIndepBtnListID_A21171_UILabel
		{
			get
			{
				short num = (short)2117599232;
				short num2 = num;
				num = (short)1008730113;
				if (num != 0)
				{
				}
				num = (short)1103111650;
				short num3 = num;
				num = (short)1892558306;
				switch (num3 == num)
				{
				}
				num = (short)1905065984;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.UIName;
			}
		}

		// Token: 0x17002B65 RID: 11109
		// (get) Token: 0x060053E5 RID: 21477 RVA: 0x004C20E0 File Offset: 0x004C02E0
		// (set) Token: 0x060053E6 RID: 21478 RVA: 0x004C2194 File Offset: 0x004C0394
		internal bool RadErgoCfgSignalIndepBtnListID_A21171_HiddenStatic
		{
			get
			{
				short num = (short)2074607616;
				short num2 = num;
				num = (short)1228504031;
				short num3 = num;
				num = (short)1610251231;
				switch (num3 == num)
				{
				}
				num = (short)2099183617;
				if (num != 0)
				{
				}
				num = (short)747569152;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.HiddenStatic;
			}
			set
			{
				short num = (short)102825984;
				short num2 = num;
				num = (short)342884353;
				if (num != 0)
				{
				}
				num = (short)592153310;
				short num3 = num;
				num = (short)1986235102;
				switch (num3 == num)
				{
				}
				num = (short)349569024;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.HiddenStatic = value;
			}
		}

		// Token: 0x17002B66 RID: 11110
		// (get) Token: 0x060053E7 RID: 21479 RVA: 0x004C2248 File Offset: 0x004C0448
		// (set) Token: 0x060053E8 RID: 21480 RVA: 0x004C22FC File Offset: 0x004C04FC
		internal bool RadErgoCfgSignalIndepBtnListID_A21171_HiddenDynamic
		{
			get
			{
				short num = (short)240451584;
				short num2 = num;
				num = (short)974842139;
				short num3 = num;
				num = (short)2077354267;
				switch (num3 == num)
				{
				}
				num = (short)839188481;
				if (num != 0)
				{
				}
				num = (short)2125922304;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171.HiddenDynamic;
			}
			set
			{
				short num = (short)1194852352;
				short num2 = num;
				num = (short)126241753;
				short num3 = num;
				num = (short)1454132185;
				switch (num3 == num)
				{
				}
				num = (short)1854013440;
				if (num != 0)
				{
				}
				num = (short)2091253761;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListID_A21171.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B67 RID: 11111
		// (get) Token: 0x060053E9 RID: 21481 RVA: 0x004C23B0 File Offset: 0x004C05B0
		public bool RadErgoCfgSignalIndepBtnListID_A21171_HasDiffs
		{
			get
			{
				short num = (short)294912000;
				short num2 = num;
				num = (short)1942683649;
				if (num != 0)
				{
				}
				num = (short)1879063907;
				short num3 = num;
				num = (short)1532247395;
				switch (num3 == num)
				{
				}
				num = (short)478478336;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListID_A21171._HasDiffs;
			}
		}

		// Token: 0x17002B68 RID: 11112
		// (get) Token: 0x060053EA RID: 21482 RVA: 0x004C2464 File Offset: 0x004C0664
		// (set) Token: 0x060053EB RID: 21483 RVA: 0x004C2518 File Offset: 0x004C0718
		public string RadErgoCfgSignalIndepBtnListKey_A21276Value
		{
			get
			{
				short num = (short)1282211840;
				short num2 = num;
				num = (short)1426436174;
				short num3 = num;
				num = (short)946909262;
				switch (num3 == num)
				{
				}
				num = (short)1252786176;
				if (num != 0)
				{
				}
				num = (short)1636106241;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.Value;
			}
			set
			{
				short num = (short)64356352;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1039532032;
					short num3 = num;
					num = (short)1861319102;
					short num4 = num;
					num = (short)1912568254;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1227292673;
						if (num != 0)
						{
						}
						num = (short)614793216;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_16;
						case 1:
							this.radErgoCfgSignalIndepBtnListKey_A21276.Value = value;
							num = (short)2080964610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						}
						goto IL_CD;
					}
					IL_16:
					switch (0)
					{
					case 0:
						IL_CD:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)506855425;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17002B69 RID: 11113
		// (get) Token: 0x060053EC RID: 21484 RVA: 0x004C2644 File Offset: 0x004C0844
		// (set) Token: 0x060053ED RID: 21485 RVA: 0x004C26F8 File Offset: 0x004C08F8
		public string RadErgoCfgSignalIndepBtnListKey_A21276_UIValue
		{
			get
			{
				short num = (short)1050607616;
				short num2 = num;
				num = (short)1326739815;
				short num3 = num;
				num = (short)1447588199;
				switch (num3 == num)
				{
				}
				num = (short)1465384960;
				if (num != 0)
				{
				}
				num = (short)8650753;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.Value;
			}
			set
			{
				short num = (short)1167917056;
				short num2 = num;
				num = (short)819448144;
				short num3 = num;
				num = (short)671861072;
				switch (num3 == num)
				{
				}
				num = (short)1211498496;
				if (num != 0)
				{
				}
				num = (short)1892941825;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListKey_A21276.Value = value;
			}
		}

		// Token: 0x17002B6A RID: 11114
		// (get) Token: 0x060053EE RID: 21486 RVA: 0x004C27AC File Offset: 0x004C09AC
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgSignalIndepBtnListKey_A21276
		{
			get
			{
				short num = (short)1874722816;
				short num2 = num;
				num = (short)554438862;
				short num3 = num;
				num = (short)1322782926;
				switch (num3 == num)
				{
				}
				num = (short)234225664;
				if (num != 0)
				{
				}
				num = (short)776601601;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276;
			}
		}

		// Token: 0x17002B6B RID: 11115
		// (get) Token: 0x060053EF RID: 21487 RVA: 0x004C285C File Offset: 0x004C0A5C
		// (set) Token: 0x060053F0 RID: 21488 RVA: 0x004C2914 File Offset: 0x004C0B14
		public bool RadErgoCfgSignalIndepBtnListKey_A21276_Applicable
		{
			get
			{
				short num = (short)1988427776;
				short num2 = num;
				num = (short)1079267188;
				short num3 = num;
				num = (short)539971444;
				switch (num3 == num)
				{
				}
				num = (short)1581907969;
				if (num != 0)
				{
				}
				num = (short)352256000;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.Applicable;
			}
			set
			{
				short num = (short)767819776;
				short num2 = num;
				num = (short)994126066;
				short num3 = num;
				num = (short)718416114;
				switch (num3 == num)
				{
				}
				num = (short)1095368704;
				if (num != 0)
				{
				}
				num = (short)1372323841;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListKey_A21276.Applicable = value;
			}
		}

		// Token: 0x17002B6C RID: 11116
		// (get) Token: 0x060053F1 RID: 21489 RVA: 0x004C29CC File Offset: 0x004C0BCC
		// (set) Token: 0x060053F2 RID: 21490 RVA: 0x004C2A80 File Offset: 0x004C0C80
		public bool RadErgoCfgSignalIndepBtnListKey_A21276_Valid
		{
			get
			{
				short num = (short)1598357504;
				short num2 = num;
				num = (short)1036063937;
				short num3 = num;
				num = (short)517084353;
				switch (num3 == num)
				{
				}
				num = (short)1396441089;
				if (num != 0)
				{
				}
				num = (short)392691712;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.Valid;
			}
			set
			{
				short num = (short)1797718016;
				short num2 = num;
				num = (short)900503849;
				short num3 = num;
				num = (short)1564711209;
				switch (num3 == num)
				{
				}
				num = (short)678625280;
				if (num != 0)
				{
				}
				num = (short)2001666049;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListKey_A21276.Valid = value;
			}
		}

		// Token: 0x17002B6D RID: 11117
		// (get) Token: 0x060053F3 RID: 21491 RVA: 0x004C2B34 File Offset: 0x004C0D34
		// (set) Token: 0x060053F4 RID: 21492 RVA: 0x004C2BE8 File Offset: 0x004C0DE8
		public bool RadErgoCfgSignalIndepBtnListKey_A21276_Visible
		{
			get
			{
				short num = (short)2058616832;
				short num2 = num;
				num = (short)1270510374;
				short num3 = num;
				num = (short)431977254;
				switch (num3 == num)
				{
				}
				num = (short)989855744;
				if (num != 0)
				{
				}
				num = (short)1740242945;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.Visible;
			}
			set
			{
				short num = (short)369098752;
				short num2 = num;
				num = (short)496815392;
				short num3 = num;
				num = (short)78892320;
				switch (num3 == num)
				{
				}
				num = (short)1703936001;
				if (num != 0)
				{
				}
				num = (short)1611137024;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListKey_A21276.Visible = value;
			}
		}

		// Token: 0x17002B6E RID: 11118
		// (get) Token: 0x060053F5 RID: 21493 RVA: 0x004C2C9C File Offset: 0x004C0E9C
		// (set) Token: 0x060053F6 RID: 21494 RVA: 0x004C2D50 File Offset: 0x004C0F50
		public bool RadErgoCfgSignalIndepBtnListKey_A21276_Editable
		{
			get
			{
				short num = (short)607715328;
				short num2 = num;
				num = (short)16842084;
				short num3 = num;
				num = (short)2056256868;
				switch (num3 == num)
				{
				}
				num = (short)1424883713;
				if (num != 0)
				{
				}
				num = (short)1242169344;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.Editable;
			}
			set
			{
				short num = (short)1315897344;
				short num2 = num;
				num = (short)1315434695;
				short num3 = num;
				num = (short)746647751;
				switch (num3 == num)
				{
				}
				num = (short)1429078016;
				if (num != 0)
				{
				}
				num = (short)872153089;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListKey_A21276.Editable = value;
			}
		}

		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x060053F7 RID: 21495 RVA: 0x004C2E08 File Offset: 0x004C1008
		internal string RadErgoCfgSignalIndepBtnListKey_A21276_UILabel
		{
			get
			{
				short num = (short)1477378048;
				short num2 = num;
				num = (short)678019908;
				short num3 = num;
				num = (short)286180164;
				switch (num3 == num)
				{
				}
				num = (short)136052737;
				if (num != 0)
				{
				}
				num = (short)501809152;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.UIName;
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x060053F8 RID: 21496 RVA: 0x004C2EBC File Offset: 0x004C10BC
		// (set) Token: 0x060053F9 RID: 21497 RVA: 0x004C2F70 File Offset: 0x004C1170
		internal bool RadErgoCfgSignalIndepBtnListKey_A21276_HiddenStatic
		{
			get
			{
				short num = (short)774504448;
				short num2 = num;
				num = (short)630784001;
				if (num != 0)
				{
				}
				num = (short)955114380;
				short num3 = num;
				num = (short)1994580876;
				switch (num3 == num)
				{
				}
				num = (short)1267204096;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.HiddenStatic;
			}
			set
			{
				short num = (short)1315897344;
				short num2 = num;
				num = (short)849608705;
				if (num != 0)
				{
				}
				num = (short)29541680;
				short num3 = num;
				num = (short)1207551280;
				switch (num3 == num)
				{
				}
				num = (short)2008547328;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListKey_A21276.HiddenStatic = value;
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x060053FA RID: 21498 RVA: 0x004C3028 File Offset: 0x004C1228
		// (set) Token: 0x060053FB RID: 21499 RVA: 0x004C30E0 File Offset: 0x004C12E0
		internal bool RadErgoCfgSignalIndepBtnListKey_A21276_HiddenDynamic
		{
			get
			{
				short num = (short)158728192;
				short num2 = num;
				num = (short)1088407503;
				short num3 = num;
				num = (short)566085583;
				switch (num3 == num)
				{
				}
				num = (short)1315176449;
				if (num != 0)
				{
				}
				num = (short)1748697088;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276.HiddenDynamic;
			}
			set
			{
				short num = (short)1280573440;
				short num2 = num;
				num = (short)717974862;
				short num3 = num;
				num = (short)288255310;
				switch (num3 == num)
				{
				}
				num = (short)1577844736;
				if (num != 0)
				{
				}
				num = (short)810024961;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListKey_A21276.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x060053FC RID: 21500 RVA: 0x004C3194 File Offset: 0x004C1394
		public bool RadErgoCfgSignalIndepBtnListKey_A21276_HasDiffs
		{
			get
			{
				short num = (short)1445068800;
				short num2 = num;
				num = (short)436755662;
				short num3 = num;
				num = (short)540761294;
				switch (num3 == num)
				{
				}
				num = (short)541982721;
				if (num != 0)
				{
				}
				num = (short)907345920;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListKey_A21276._HasDiffs;
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x060053FD RID: 21501 RVA: 0x004C3244 File Offset: 0x004C1444
		// (set) Token: 0x060053FE RID: 21502 RVA: 0x004C32FC File Offset: 0x004C14FC
		public int RadErgoCfgSignalIndepBtnListType_A21172Value
		{
			get
			{
				short num = (short)1664286720;
				short num2 = num;
				num = (short)413480346;
				short num3 = num;
				num = (short)81606042;
				switch (num3 == num)
				{
				}
				num = (short)1722810368;
				if (num != 0)
				{
				}
				num = (short)712376321;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.Value;
			}
			set
			{
				short num = (short)680919040;
				short num2 = num;
				num = (short)1371736242;
				short num3 = num;
				num = (short)1139017906;
				switch (num3 == num)
				{
				}
				num = (short)240648193;
				if (num != 0)
				{
				}
				num = (short)2048262144;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListType_A21172.Value = value;
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x060053FF RID: 21503 RVA: 0x004C33B4 File Offset: 0x004C15B4
		// (set) Token: 0x06005400 RID: 21504 RVA: 0x004C3468 File Offset: 0x004C1668
		public string RadErgoCfgSignalIndepBtnListType_A21172_UIValue
		{
			get
			{
				short num = (short)249888768;
				short num2 = num;
				num = (short)796852159;
				short num3 = num;
				num = (short)1983315903;
				switch (num3 == num)
				{
				}
				num = (short)819331073;
				if (num != 0)
				{
				}
				num = (short)1593966592;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.UIValue;
			}
			set
			{
				short num = (short)695205888;
				short num2 = num;
				num = (short)307216053;
				short num3 = num;
				num = (short)1824898741;
				switch (num3 == num)
				{
				}
				num = (short)1996292096;
				if (num != 0)
				{
				}
				num = (short)1066926081;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListType_A21172.UIValue = value;
			}
		}

		// Token: 0x17002B75 RID: 11125
		// (get) Token: 0x06005401 RID: 21505 RVA: 0x004C3520 File Offset: 0x004C1720
		public global::AcpBusinessLayer.AcpListField RadErgoCfgSignalIndepBtnListType_A21172
		{
			get
			{
				short num = (short)30212096;
				short num2 = num;
				num = (short)1769944476;
				short num3 = num;
				num = (short)826750364;
				switch (num3 == num)
				{
				}
				num = (short)2042626049;
				if (num != 0)
				{
				}
				num = (short)1653800960;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172;
			}
		}

		// Token: 0x17002B76 RID: 11126
		// (get) Token: 0x06005402 RID: 21506 RVA: 0x004C35D0 File Offset: 0x004C17D0
		// (set) Token: 0x06005403 RID: 21507 RVA: 0x004C3688 File Offset: 0x004C1888
		public bool RadErgoCfgSignalIndepBtnListType_A21172_Applicable
		{
			get
			{
				short num = (short)54591488;
				short num2 = num;
				num = (short)1105855882;
				short num3 = num;
				num = (short)34342282;
				switch (num3 == num)
				{
				}
				num = (short)776077312;
				if (num != 0)
				{
				}
				num = (short)1530789889;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.Applicable;
			}
			set
			{
				short num = (short)779878400;
				short num2 = num;
				num = (short)1162425943;
				short num3 = num;
				num = (short)826685015;
				switch (num3 == num)
				{
				}
				num = (short)1698430976;
				if (num != 0)
				{
				}
				num = (short)1141637121;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListType_A21172.Applicable = value;
			}
		}

		// Token: 0x17002B77 RID: 11127
		// (get) Token: 0x06005404 RID: 21508 RVA: 0x004C373C File Offset: 0x004C193C
		// (set) Token: 0x06005405 RID: 21509 RVA: 0x004C37F0 File Offset: 0x004C19F0
		public bool RadErgoCfgSignalIndepBtnListType_A21172_Valid
		{
			get
			{
				short num = (short)1990459392;
				short num2 = num;
				num = (short)433021872;
				short num3 = num;
				num = (short)502817712;
				switch (num3 == num)
				{
				}
				num = (short)439418880;
				if (num != 0)
				{
				}
				num = (short)99942401;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.Valid;
			}
			set
			{
				short num = (short)1201078272;
				short num2 = num;
				num = (short)2071853689;
				short num3 = num;
				num = (short)86309497;
				switch (num3 == num)
				{
				}
				num = (short)1044578304;
				if (num != 0)
				{
				}
				num = (short)359268353;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListType_A21172.Valid = value;
			}
		}

		// Token: 0x17002B78 RID: 11128
		// (get) Token: 0x06005406 RID: 21510 RVA: 0x004C38A8 File Offset: 0x004C1AA8
		// (set) Token: 0x06005407 RID: 21511 RVA: 0x004C395C File Offset: 0x004C1B5C
		public bool RadErgoCfgSignalIndepBtnListType_A21172_Visible
		{
			get
			{
				short num = (short)1873739776;
				short num2 = num;
				num = (short)1424635400;
				short num3 = num;
				num = (short)1995847176;
				switch (num3 == num)
				{
				}
				num = (short)1506017281;
				if (num != 0)
				{
				}
				num = (short)745406464;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.Visible;
			}
			set
			{
				short num = (short)980615168;
				short num2 = num;
				num = (short)1332074574;
				short num3 = num;
				num = (short)2051463246;
				switch (num3 == num)
				{
				}
				num = (short)1832648705;
				if (num != 0)
				{
				}
				num = (short)984678400;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListType_A21172.Visible = value;
			}
		}

		// Token: 0x17002B79 RID: 11129
		// (get) Token: 0x06005408 RID: 21512 RVA: 0x004C3A10 File Offset: 0x004C1C10
		// (set) Token: 0x06005409 RID: 21513 RVA: 0x004C3AC4 File Offset: 0x004C1CC4
		public bool RadErgoCfgSignalIndepBtnListType_A21172_Editable
		{
			get
			{
				short num = (short)2018508800;
				short num2 = num;
				num = (short)216316467;
				short num3 = num;
				num = (short)1909897779;
				switch (num3 == num)
				{
				}
				num = (short)591200257;
				if (num != 0)
				{
				}
				num = (short)1168244736;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.Editable;
			}
			set
			{
				short num = (short)2122121216;
				short num2 = num;
				num = (short)232914945;
				if (num != 0)
				{
				}
				num = (short)1444118520;
				short num3 = num;
				num = (short)1323139064;
				switch (num3 == num)
				{
				}
				num = (short)1531379712;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListType_A21172.Editable = value;
			}
		}

		// Token: 0x17002B7A RID: 11130
		// (get) Token: 0x0600540A RID: 21514 RVA: 0x004C3B7C File Offset: 0x004C1D7C
		internal string RadErgoCfgSignalIndepBtnListType_A21172_UILabel
		{
			get
			{
				short num = (short)1281228800;
				short num2 = num;
				num = (short)1632658467;
				short num3 = num;
				num = (short)375284771;
				switch (num3 == num)
				{
				}
				num = (short)17170433;
				if (num != 0)
				{
				}
				num = (short)639893504;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.UIName;
			}
		}

		// Token: 0x17002B7B RID: 11131
		// (get) Token: 0x0600540B RID: 21515 RVA: 0x004C3C30 File Offset: 0x004C1E30
		// (set) Token: 0x0600540C RID: 21516 RVA: 0x004C3CE8 File Offset: 0x004C1EE8
		internal bool RadErgoCfgSignalIndepBtnListType_A21172_HiddenStatic
		{
			get
			{
				short num = (short)179896320;
				short num2 = num;
				num = (short)1716675248;
				short num3 = num;
				num = (short)1820615344;
				switch (num3 == num)
				{
				}
				num = (short)806879233;
				if (num != 0)
				{
				}
				num = (short)2131558400;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.HiddenStatic;
			}
			set
			{
				short num = (short)1206583296;
				short num2 = num;
				num = (short)1377453913;
				short num3 = num;
				num = (short)423315289;
				switch (num3 == num)
				{
				}
				num = (short)697434113;
				if (num != 0)
				{
				}
				num = (short)747765760;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListType_A21172.HiddenStatic = value;
			}
		}

		// Token: 0x17002B7C RID: 11132
		// (get) Token: 0x0600540D RID: 21517 RVA: 0x004C3D9C File Offset: 0x004C1F9C
		// (set) Token: 0x0600540E RID: 21518 RVA: 0x004C3E50 File Offset: 0x004C2050
		internal bool RadErgoCfgSignalIndepBtnListType_A21172_HiddenDynamic
		{
			get
			{
				short num = (short)1346633728;
				short num2 = num;
				num = (short)788508217;
				short num3 = num;
				num = (short)1496952377;
				switch (num3 == num)
				{
				}
				num = (short)1075707905;
				if (num != 0)
				{
				}
				num = (short)1133051904;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172.HiddenDynamic;
			}
			set
			{
				short num = (short)1384710144;
				short num2 = num;
				num = (short)2128216065;
				if (num != 0)
				{
				}
				num = (short)1272652919;
				short num3 = num;
				num = (short)1890854007;
				switch (num3 == num)
				{
				}
				num = (short)635371520;
				if (num != 0)
				{
				}
				this.radErgoCfgSignalIndepBtnListType_A21172.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B7D RID: 11133
		// (get) Token: 0x0600540F RID: 21519 RVA: 0x004C3F04 File Offset: 0x004C2104
		public bool RadErgoCfgSignalIndepBtnListType_A21172_HasDiffs
		{
			get
			{
				short num = (short)2120941568;
				short num2 = num;
				num = (short)374391115;
				short num3 = num;
				num = (short)607830347;
				switch (num3 == num)
				{
				}
				num = (short)573374465;
				if (num != 0)
				{
				}
				num = (short)580124672;
				if (num != 0)
				{
				}
				return this.radErgoCfgSignalIndepBtnListType_A21172._HasDiffs;
			}
		}

		// Token: 0x06005410 RID: 21520 RVA: 0x004C3FBC File Offset: 0x004C21BC
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
					num2 = (short)1398669312;
					short num3 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)1637548034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					return result;
				case 2:
					num2 = (short)684130308;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)793019714;
					short num4 = num2;
					num2 = (short)300975426;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1995702272;
						if (num2 != 0)
						{
						}
						num2 = (short)1179123713;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)511180801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2116681731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1507131392;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040020A7 RID: 8359
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgSignalIndepBtnListID_A21171;

		// Token: 0x040020A8 RID: 8360
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgSignalIndepBtnListKey_A21276;

		// Token: 0x040020A9 RID: 8361
		private global::AcpBusinessLayer.AcpListField radErgoCfgSignalIndepBtnListType_A21172;
	}
}
