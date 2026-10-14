using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E0 RID: 480
	[global::System.Serializable]
	public class SignalIndependentProductIndependentNonProgrammableButton : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005428 RID: 21544 RVA: 0x004C8714 File Offset: 0x004C6914
		public SignalIndependentProductIndependentNonProgrammableButton(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06005429 RID: 21545 RVA: 0x004C8754 File Offset: 0x004C6954
		protected SignalIndependentProductIndependentNonProgrammableButton(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600542A RID: 21546 RVA: 0x004C876C File Offset: 0x004C696C
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1197473792;
			short num2 = num;
			num = (short)275972097;
			if (num != 0)
			{
			}
			num = (short)1635834487;
			short num3 = num;
			num = (short)863820407;
			switch (num3 == num)
			{
			}
			num = (short)1360265216;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鋀ꫂꋄ꧆꣈ꟊ蛎뿐럒냔Ꟗ볘뗚맜뫞迠韢엤럦鯨蓪觬髮鋰蟲헴뻶韸鿺飼迾搀洂愄戆月缊ⴌ䄎縐紒㠔䜖欘琚稜洞䀠丢䠤䘦䬨䜪䠬༮猰䘲䄴䌶嘸唺", a_);
			base.Id = 10031;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTNONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600542B RID: 21547 RVA: 0x004C8850 File Offset: 0x004C6A50
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)76480512;
			short num2 = num;
			num = (short)794487747;
			short num3 = num;
			num = (short)1776544707;
			switch (num3 == num)
			{
			}
			num = (short)682360833;
			if (num != 0)
			{
			}
			num = (short)844824576;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釁귃ꇅꛇꯉꃋ駏병냓돕꣗뿙닛뫝藟賡郣웥룧飩菫諭藯釱胳훵뇷铹飻鯽烿朁樃戅洇搉砋⸍帏紑稓㬕䠗栙猛礝刟䌡䤣䬥䤧䠩䀫䬭ု瀱䄳䈵䰷唹刻", a_);
			base.Id = 10031;
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTNONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 7;
		}

		// Token: 0x0600542C RID: 21548 RVA: 0x004C8934 File Offset: 0x004C6B34
		public override void PopulateReferences()
		{
			short num = (short)1452736512;
			short num2 = num;
			num = (short)1863396985;
			short num3 = num;
			num = (short)1883909753;
			switch (num3 == num)
			{
			}
			num = (short)684785664;
			if (num != 0)
			{
			}
			num = (short)462553089;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600542D RID: 21549 RVA: 0x004C89E0 File Offset: 0x004C6BE0
		public override void DropReferences()
		{
			short num = (short)95420416;
			short num2 = num;
			num = (short)1432673977;
			short num3 = num;
			num = (short)1749212857;
			switch (num3 == num)
			{
			}
			num = (short)747175937;
			if (num != 0)
			{
			}
			num = (short)996278272;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600542E RID: 21550 RVA: 0x004C8A8C File Offset: 0x004C6C8C
		public override void SetConstraints()
		{
			short num = (short)986185728;
			short num2 = num;
			num = (short)1428799706;
			short num3 = num;
			num = (short)172671194;
			switch (num3 == num)
			{
			}
			num = (short)1909850113;
			if (num != 0)
			{
			}
			num = (short)803143680;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600542F RID: 21551 RVA: 0x004C8B34 File Offset: 0x004C6D34
		public override void SetupDependencies()
		{
			short num = (short)1778515968;
			short num2 = num;
			num = (short)226539762;
			short num3 = num;
			num = (short)31504626;
			switch (num3 == num)
			{
			}
			num = (short)1157431297;
			if (num != 0)
			{
			}
			num = (short)1121910784;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002B7E RID: 11134
		// (get) Token: 0x06005430 RID: 21552 RVA: 0x004C8BDC File Offset: 0x004C6DDC
		public bool HasDiffs
		{
			get
			{
				short num = (short)879951872;
				short num2 = num;
				num = (short)738676007;
				short num3 = num;
				num = (short)707874087;
				switch (num3 == num)
				{
				}
				num = (short)384434177;
				if (num != 0)
				{
				}
				num = (short)289210368;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06005431 RID: 21553 RVA: 0x004C8C8C File Offset: 0x004C6E8C
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
					num2 = (short)863109121;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset != null)
					{
						num2 = (short)844955648;
						short num3 = num2;
						num2 = (short)1844117507;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					return result;
				case 2:
					goto IL_164;
				case 3:
				{
					num2 = (short)135502145;
					short num4 = num2;
					num2 = (short)133208385;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_164;
					default:
						num2 = (short)1054670848;
						if (num2 != 0)
						{
						}
						num2 = (short)711131140;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)169279490;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_164:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1065746433;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)617873408;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400215D RID: 8541
		private global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset innerRecset;
	}
}
