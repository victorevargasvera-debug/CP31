using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002B9 RID: 697
	[global::System.Serializable]
	public class MultiFunctionKnob : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007532 RID: 30002 RVA: 0x0069B698 File Offset: 0x00699898
		public MultiFunctionKnob(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x0069B6D8 File Offset: 0x006998D8
		protected MultiFunctionKnob(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x0069B6F0 File Offset: 0x006998F0
		public override void Init()
		{
			int a_ = 2;
			short num = (short)330881708;
			short num2 = num;
			num = (short)539024044;
			switch (num2 == num)
			{
			}
			num = (short)89260032;
			short num3 = num;
			num = (short)1135476737;
			if (num != 0)
			{
			}
			num = (short)629407744;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軂냄ꯆ뷈ꋊ觎ꓐ뷒뛔ꏖ냘듚돜￞ꫠ跢諤藦", a_);
			base.Id = 10637;
			base.UIName = global::CommonResources.AcgResources.ID_MULTIFUNCTIONKNOB;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x0069B7D4 File Offset: 0x006999D4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)105420299;
			short num2 = num;
			num = (short)737056267;
			switch (num2 == num)
			{
			}
			num = (short)541261824;
			short num3 = num;
			num = (short)1660157953;
			if (num != 0)
			{
			}
			num = (short)1619722240;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诅뷇ꛉ룋ꟍ﷏铑ꇓ룕믗껙뗛뇝軟싡꿣裥蟧裩", a_);
			base.Id = 10637;
			base.UIName = global::CommonResources.AcgResources.ID_MULTIFUNCTIONKNOB;
			base.DataTransferOrder = 6;
		}

		// Token: 0x06007536 RID: 30006 RVA: 0x0069B8B4 File Offset: 0x00699AB4
		public override void PopulateReferences()
		{
			short num = (short)286692034;
			short num2 = num;
			num = (short)596415170;
			switch (num2 == num)
			{
			}
			num = (short)372244480;
			short num3 = num;
			num = (short)90963969;
			if (num != 0)
			{
			}
			num = (short)1652031488;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x0069B95C File Offset: 0x00699B5C
		public override void DropReferences()
		{
			short num = (short)486549472;
			short num2 = num;
			num = (short)334047200;
			switch (num2 == num)
			{
			}
			num = (short)377552896;
			short num3 = num;
			num = (short)1128202241;
			if (num != 0)
			{
			}
			num = (short)1735065600;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x0069BA04 File Offset: 0x00699C04
		public override void SetConstraints()
		{
			short num = (short)320922597;
			short num2 = num;
			num = (short)404480997;
			switch (num2 == num)
			{
			}
			num = (short)1285816320;
			short num3 = num;
			num = (short)513081345;
			if (num != 0)
			{
			}
			num = (short)188940288;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x0069BAAC File Offset: 0x00699CAC
		public override void SetupDependencies()
		{
			short num = (short)895992334;
			short num2 = num;
			num = (short)1998111246;
			switch (num2 == num)
			{
			}
			num = (short)24641536;
			short num3 = num;
			num = (short)1816920065;
			if (num != 0)
			{
			}
			num = (short)782368768;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003C63 RID: 15459
		// (get) Token: 0x0600753A RID: 30010 RVA: 0x0069BB58 File Offset: 0x00699D58
		public bool HasDiffs
		{
			get
			{
				short num = (short)1052987146;
				short num2 = num;
				num = (short)1007701770;
				switch (num2 == num)
				{
				}
				num = (short)1215954944;
				short num3 = num;
				num = (short)612237313;
				if (num != 0)
				{
				}
				num = (short)1188364288;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x0069BC04 File Offset: 0x00699E04
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)21733094;
					short num2 = num;
					num = (short)303406822;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)486146048;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							return result;
						case 1:
							if (base.ParentRecset != null)
							{
								num = (short)197001220;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 2:
							if (base.ParentRecset.ContainerDoc != null)
							{
								num = (short)688193539;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 3:
						{
							num = (short)1200160768;
							short num4 = num;
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num = (short)2079326208;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1332609026;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E;
					}
				}
				IL_6E:
				num = (short)471007233;
				if (num != 0)
				{
				}
				result = null;
				num = (short)174850049;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x04002F7F RID: 12159
		private global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset innerRecset;
	}
}
