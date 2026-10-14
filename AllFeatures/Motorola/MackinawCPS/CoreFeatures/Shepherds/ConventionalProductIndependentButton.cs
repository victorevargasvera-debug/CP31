using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001C8 RID: 456
	[global::System.Serializable]
	public class ConventionalProductIndependentButton : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005309 RID: 21257 RVA: 0x004B6988 File Offset: 0x004B4B88
		public ConventionalProductIndependentButton(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x004B69C8 File Offset: 0x004B4BC8
		protected ConventionalProductIndependentButton(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x004B69E0 File Offset: 0x004B4BE0
		public override void Init()
		{
			int a_ = 18;
			short num = (short)210698240;
			short num2 = num;
			num = (short)160258330;
			short num3 = num;
			num = (short)552098074;
			switch (num3 == num)
			{
			}
			num = (short)1145503744;
			if (num != 0)
			{
			}
			num = (short)1557921793;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郒뫔맖꿘뻚돜ꯞ裠賢诤蛦藨쯪뷬鷮黰韲胴银跸\udbfa듼釾攀昂甄戆月漊栌愎攐㌒圔或洘漚爜焞", a_);
			base.Id = 10025;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTON;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x004B6AC4 File Offset: 0x004B4CC4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)369819648;
			short num2 = num;
			num = (short)1677248908;
			short num3 = num;
			num = (short)2116667788;
			switch (num3 == num)
			{
			}
			num = (short)707198977;
			if (num != 0)
			{
			}
			num = (short)1157365760;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軌ꃎ뿐ꗒ냔맖귘닚닜뇞胠迢엤럦鯨蓪觬髮鋰蟲헴뻶韸鿺飼迾搀洂愄戆月缊ⴌ䴎搐朒愔砖眘", a_);
			base.Id = 10025;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTON;
			base.DataTransferOrder = 5;
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x004B6BAC File Offset: 0x004B4DAC
		public override void PopulateReferences()
		{
			short num = (short)2077753344;
			short num2 = num;
			num = (short)386618657;
			short num3 = num;
			num = (short)1646744865;
			switch (num3 == num)
			{
			}
			num = (short)1787494400;
			if (num != 0)
			{
			}
			num = (short)75038721;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x004B6C58 File Offset: 0x004B4E58
		public override void DropReferences()
		{
			short num = (short)1711996928;
			short num2 = num;
			num = (short)896712555;
			short num3 = num;
			num = (short)573947755;
			switch (num3 == num)
			{
			}
			num = (short)1379074049;
			if (num != 0)
			{
			}
			num = (short)794689536;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600530F RID: 21263 RVA: 0x004B6D00 File Offset: 0x004B4F00
		public override void SetConstraints()
		{
			short num = (short)1001652224;
			short num2 = num;
			num = (short)494095991;
			short num3 = num;
			num = (short)1331908215;
			switch (num3 == num)
			{
			}
			num = (short)1210056704;
			if (num != 0)
			{
			}
			num = (short)1817640961;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005310 RID: 21264 RVA: 0x004B6DAC File Offset: 0x004B4FAC
		public override void SetupDependencies()
		{
			short num = (short)462749696;
			short num2 = num;
			num = (short)452984833;
			if (num != 0)
			{
			}
			num = (short)1075552722;
			short num3 = num;
			num = (short)856531410;
			switch (num3 == num)
			{
			}
			num = (short)2134114304;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x06005311 RID: 21265 RVA: 0x004B6E58 File Offset: 0x004B5058
		public bool HasDiffs
		{
			get
			{
				short num = (short)1619918848;
				short num2 = num;
				num = (short)655542435;
				short num3 = num;
				num = (short)1045285027;
				switch (num3 == num)
				{
				}
				num = (short)143589377;
				if (num != 0)
				{
				}
				num = (short)19202048;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06005312 RID: 21266 RVA: 0x004B6F08 File Offset: 0x004B5108
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
						num2 = (short)646184961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					num2 = (short)369950723;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1443692548;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)1434461941;
					short num3 = num2;
					num2 = (short)467281653;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)2009595904;
						short num4 = num2;
						num2 = (short)200802305;
						if (num2 != 0)
						{
						}
						num2 = (short)1877016576;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1441529858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1407057920;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001FA7 RID: 8103
		private global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerRecset innerRecset;
	}
}
