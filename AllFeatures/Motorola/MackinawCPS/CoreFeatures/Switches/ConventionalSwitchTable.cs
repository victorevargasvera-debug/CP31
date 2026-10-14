using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x02000295 RID: 661
	[global::System.Serializable]
	public class ConventionalSwitchTable : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007433 RID: 29747 RVA: 0x0068BC28 File Offset: 0x00689E28
		public ConventionalSwitchTable(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007434 RID: 29748 RVA: 0x0068BC68 File Offset: 0x00689E68
		protected ConventionalSwitchTable(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007435 RID: 29749 RVA: 0x0068BC80 File Offset: 0x00689E80
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1564673001;
			short num2 = num;
			num = (short)1084294121;
			switch (num2 == num)
			{
			}
			num = (short)1279066113;
			if (num != 0)
			{
			}
			num = (short)816840704;
			short num3 = num;
			num = (short)226951168;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛄꣆ꟈ뷊꣌ꇎꗐ뫒뫔맖룘럚﷜賞雠諢釤蓦臨쯪맬軮鏰鿲郴", a_);
			base.Id = 10085;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHTABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x0068BD68 File Offset: 0x00689F68
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1702882958;
			short num2 = num;
			num = (short)1760226958;
			switch (num2 == num)
			{
			}
			num = (short)197918721;
			if (num != 0)
			{
			}
			num = (short)241827840;
			short num3 = num;
			num = (short)1787297792;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跍뿏병ꋓ돕뛗껙뗛뇝軟菡裣웥믧鷩藫髭鏯髱퓳ꋵ駷飹郻鯽", a_);
			base.Id = 10085;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHTABLE;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x0068BE4C File Offset: 0x0068A04C
		public override void PopulateReferences()
		{
			short num = (short)342780448;
			short num2 = num;
			num = (short)990669344;
			switch (num2 == num)
			{
			}
			num = (short)1177485312;
			if (num != 0)
			{
			}
			num = (short)1381433344;
			short num3 = num;
			num = (short)615186433;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x0068BEF8 File Offset: 0x0068A0F8
		public override void DropReferences()
		{
			short num = (short)1358996869;
			short num2 = num;
			num = (short)1427613061;
			switch (num2 == num)
			{
			}
			num = (short)1251016705;
			if (num != 0)
			{
			}
			num = (short)1220870144;
			short num3 = num;
			num = (short)373686272;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007439 RID: 29753 RVA: 0x0068BFA0 File Offset: 0x0068A1A0
		public override void SetConstraints()
		{
			short num = (short)1253385229;
			short num2 = num;
			num = (short)1168974861;
			switch (num2 == num)
			{
			}
			num = (short)1419771905;
			if (num != 0)
			{
			}
			num = (short)802947072;
			short num3 = num;
			num = (short)356777984;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600743A RID: 29754 RVA: 0x0068C04C File Offset: 0x0068A24C
		public override void SetupDependencies()
		{
			short num = (short)856358913;
			if (num != 0)
			{
			}
			num = (short)1660115964;
			short num2 = num;
			num = (short)1541233660;
			switch (num2 == num)
			{
			}
			num = (short)625803264;
			short num3 = num;
			num = (short)678559744;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003BE9 RID: 15337
		// (get) Token: 0x0600743B RID: 29755 RVA: 0x0068C0F8 File Offset: 0x0068A2F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)333942279;
				short num2 = num;
				num = (short)209161735;
				switch (num2 == num)
				{
				}
				num = (short)373358593;
				if (num != 0)
				{
				}
				num = (short)409272320;
				short num3 = num;
				num = (short)166920192;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x0068C1A8 File Offset: 0x0068A3A8
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)495386627;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
				{
					num2 = (short)239811899;
					short num3 = num2;
					num2 = (short)1175600443;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_126;
					default:
						goto IL_10E;
					}
					break;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1773338624;
						short num4 = num2;
						num2 = (short)796065796;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)2055274497;
					if (num2 != 0)
					{
					}
					num2 = (short)1951137793;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_126;
				}
				goto IL_24;
				IL_126:
				num2 = (short)1138032640;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10E:
			num2 = (short)305332224;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)893255682;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04002D10 RID: 11536
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset innerRecset;
	}
}
