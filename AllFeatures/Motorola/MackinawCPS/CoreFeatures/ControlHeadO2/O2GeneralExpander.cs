using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003DC RID: 988
	[global::System.Serializable]
	public class O2GeneralExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008B81 RID: 35713 RVA: 0x0082A950 File Offset: 0x00828B50
		public O2GeneralExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x0082A990 File Offset: 0x00828B90
		protected O2GeneralExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x0082A9A8 File Offset: 0x00828BA8
		public override void Init()
		{
			int a_ = 11;
			short num = (short)1261712415;
			short num2 = num;
			num = (short)1036989471;
			switch (num2 == num)
			{
			}
			num = (short)626851840;
			short num3 = num;
			num = (short)1006108673;
			if (num != 0)
			{
			}
			num = (short)580452352;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诋ꯍ뻏럑ꛓ럕듗", a_);
			base.Id = 10723;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x0082AA8C File Offset: 0x00828C8C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)27169216;
			short num2 = num;
			num = (short)622170560;
			switch (num2 == num)
			{
			}
			num = (short)1003945984;
			short num3 = num;
			num = (short)1546190849;
			if (num != 0)
			{
			}
			num = (short)77660160;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觍뗏병뇓ꓕ맗뛙", a_);
			base.Id = 10723;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x0082AB70 File Offset: 0x00828D70
		public override void PopulateReferences()
		{
			short num = (short)703855538;
			short num2 = num;
			num = (short)2109602738;
			switch (num2 == num)
			{
			}
			num = (short)1472659456;
			if (num != 0)
			{
			}
			num = (short)1184759809;
			if (num != 0)
			{
			}
			num = (short)115605504;
			short num3 = num;
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x0082AC18 File Offset: 0x00828E18
		public override void DropReferences()
		{
			short num = (short)853321694;
			short num2 = num;
			num = (short)1906747358;
			switch (num2 == num)
			{
			}
			num = (short)61997056;
			if (num != 0)
			{
			}
			num = (short)256638977;
			if (num != 0)
			{
			}
			num = (short)528941056;
			short num3 = num;
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x0082ACC0 File Offset: 0x00828EC0
		public override void SetConstraints()
		{
			short num = (short)1897335002;
			short num2 = num;
			num = (short)553126106;
			switch (num2 == num)
			{
			}
			num = (short)924778497;
			if (num != 0)
			{
			}
			num = (short)1035927552;
			if (num != 0)
			{
			}
			num = (short)1552744448;
			short num3 = num;
		}

		// Token: 0x06008B88 RID: 35720 RVA: 0x0082AD6C File Offset: 0x00828F6C
		public override void SetupDependencies()
		{
			short num = (short)308217758;
			short num2 = num;
			num = (short)988940190;
			switch (num2 == num)
			{
			}
			num = (short)983433217;
			if (num != 0)
			{
			}
			num = (short)1449918464;
			if (num != 0)
			{
			}
			num = (short)1268121600;
			short num3 = num;
		}

		// Token: 0x170046AE RID: 18094
		// (get) Token: 0x06008B89 RID: 35721 RVA: 0x0082AE14 File Offset: 0x00829014
		public bool HasDiffs
		{
			get
			{
				short num = (short)7855141;
				short num2 = num;
				num = (short)563534885;
				switch (num2 == num)
				{
				}
				num = (short)1550974977;
				if (num != 0)
				{
				}
				num = (short)1595277312;
				if (num != 0)
				{
				}
				num = (short)1116012544;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x0082AEC4 File Offset: 0x008290C4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1833613729;
				short num2 = num;
				num = (short)1264433569;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)437518336;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)546308097;
						if (num != 0)
						{
						}
						num = (short)1301086208;
						short num4 = num;
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						goto IL_B9;
					}
					case 1:
						if (base.ParentRecset != null)
						{
							num = (short)1338900482;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)1364983811;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1776091136;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						return result;
					}
					goto IL_6D;
				}
				IL_B9:
				num = (short)243728388;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_6D:
			result = null;
			num = (short)1934163969;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x040043DB RID: 17371
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset innerRecset;
	}
}
