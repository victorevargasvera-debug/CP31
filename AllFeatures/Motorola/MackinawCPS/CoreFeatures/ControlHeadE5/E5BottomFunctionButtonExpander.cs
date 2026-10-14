using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F1 RID: 1009
	[global::System.Serializable]
	public class E5BottomFunctionButtonExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008CA9 RID: 36009 RVA: 0x008409F4 File Offset: 0x0083EBF4
		public E5BottomFunctionButtonExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008CAA RID: 36010 RVA: 0x00840A34 File Offset: 0x0083EC34
		protected E5BottomFunctionButtonExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008CAB RID: 36011 RVA: 0x00840A4C File Offset: 0x0083EC4C
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1587019776;
			short num2 = num;
			num = (short)919325355;
			short num3 = num;
			num = (short)759483051;
			switch (num3 == num)
			{
			}
			num = (short)1235615745;
			if (num != 0)
			{
			}
			num = (short)61276160;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藆ꛈ뿊만ꃎ볐鏔ꋖ럘룚꧜뛞軠跢엤럦鯨蓪諬鷮郰黲飴零鯸韺飼\udffe䌀瘂焄猆昈攊", a_);
			base.Id = 10903;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06008CAC RID: 36012 RVA: 0x00840B30 File Offset: 0x0083ED30
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)632750080;
			short num2 = num;
			num = (short)1648418021;
			short num3 = num;
			num = (short)1778244837;
			switch (num3 == num)
			{
			}
			num = (short)1899626497;
			if (num != 0)
			{
			}
			num = (short)146866176;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胁ꯃ닅볇ꗉꇋ雏ꟑ뫓뗕곗동돛냝샟닡難觥迧飩跫菭鷯鏱雳髵鷷\udaf9뻻诽瓿瘁欃栅", a_);
			base.Id = 10903;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06008CAD RID: 36013 RVA: 0x00840C14 File Offset: 0x0083EE14
		public override void PopulateReferences()
		{
			short num = (short)623575040;
			short num2 = num;
			num = (short)295370753;
			if (num != 0)
			{
			}
			num = (short)905200564;
			short num3 = num;
			num = (short)342967220;
			switch (num3 == num)
			{
			}
			num = (short)1417019392;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008CAE RID: 36014 RVA: 0x00840CBC File Offset: 0x0083EEBC
		public override void DropReferences()
		{
			short num = (short)1669529600;
			short num2 = num;
			num = (short)1910980263;
			short num3 = num;
			num = (short)647184039;
			switch (num3 == num)
			{
			}
			num = (short)1783234560;
			if (num != 0)
			{
			}
			num = (short)44302337;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008CAF RID: 36015 RVA: 0x00840D68 File Offset: 0x0083EF68
		public override void SetConstraints()
		{
			short num = (short)1034551296;
			short num2 = num;
			num = (short)1928848930;
			short num3 = num;
			num = (short)2075911714;
			switch (num3 == num)
			{
			}
			num = (short)1600782337;
			if (num != 0)
			{
			}
			num = (short)786825216;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008CB0 RID: 36016 RVA: 0x00840E10 File Offset: 0x0083F010
		public override void SetupDependencies()
		{
			short num = (short)1141964800;
			short num2 = num;
			num = (short)1984676914;
			short num3 = num;
			num = (short)1120977970;
			switch (num3 == num)
			{
			}
			num = (short)370999297;
			if (num != 0)
			{
			}
			num = (short)673710080;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004724 RID: 18212
		// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x00840EBC File Offset: 0x0083F0BC
		public bool HasDiffs
		{
			get
			{
				short num = (short)2145255424;
				short num2 = num;
				num = (short)505014786;
				short num3 = num;
				num = (short)1169287682;
				switch (num3 == num)
				{
				}
				num = (short)288161792;
				if (num != 0)
				{
				}
				num = (short)1070596097;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04004574 RID: 17780
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset innerRecset;
	}
}
