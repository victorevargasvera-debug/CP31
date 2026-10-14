using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000346 RID: 838
	[global::System.Serializable]
	public class BottomFunctionProgrammableButton : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008095 RID: 32917 RVA: 0x00761F38 File Offset: 0x00760138
		public BottomFunctionProgrammableButton(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x00761F78 File Offset: 0x00760178
		protected BottomFunctionProgrammableButton(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x00761F90 File Offset: 0x00760190
		public override void Init()
		{
			int a_ = 0;
			short num = (short)169017344;
			short num2 = num;
			num = (short)1526301663;
			short num3 = num;
			num = (short)464749535;
			switch (num3 == num)
			{
			}
			num = (short)624558081;
			if (num != 0)
			{
			}
			num = (short)2051211264;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菀곂뇄돆ꛈꛊ觎ꓐ뷒뛔ꏖ냘듚돜￞뇠釢諤胦鯨諪胬苮郰釲駴鋶\ud9f8맺裼课甀氂欄", a_);
			base.Id = 10618;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x00762078 File Offset: 0x00760278
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)757989376;
			short num2 = num;
			num = (short)2019381870;
			short num3 = num;
			num = (short)461656686;
			switch (num3 == num)
			{
			}
			num = (short)760414209;
			if (num != 0)
			{
			}
			num = (short)574029824;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迌ꃎꗐ꟒뫔뫖律鷚꣜뇞苠韢賤裦蟨쯪뷬鷮黰铲蟴零铸雺鳼鷾洀昂┄䔆簈缊礌怎缐", a_);
			base.Id = 10618;
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x0076215C File Offset: 0x0076035C
		public override void PopulateReferences()
		{
			short num = (short)982319104;
			short num2 = num;
			num = (short)2144207617;
			short num3 = num;
			num = (short)1930035969;
			switch (num3 == num)
			{
			}
			num = (short)854130689;
			if (num != 0)
			{
			}
			num = (short)154009600;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x00762204 File Offset: 0x00760404
		public override void DropReferences()
		{
			short num = (short)881983488;
			short num2 = num;
			num = (short)2034822840;
			short num3 = num;
			num = (short)1375203000;
			switch (num3 == num)
			{
			}
			num = (short)719192064;
			if (num != 0)
			{
			}
			num = (short)187236353;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x007622B0 File Offset: 0x007604B0
		public override void SetConstraints()
		{
			short num = (short)606994432;
			short num2 = num;
			num = (short)484131596;
			short num3 = num;
			num = (short)787694348;
			switch (num3 == num)
			{
			}
			num = (short)1838743553;
			if (num != 0)
			{
			}
			num = (short)1964179456;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x00762358 File Offset: 0x00760558
		public override void SetupDependencies()
		{
			short num = (short)835321856;
			short num2 = num;
			num = (short)1245332665;
			short num3 = num;
			num = (short)118113465;
			switch (num3 == num)
			{
			}
			num = (short)847904769;
			if (num != 0)
			{
			}
			num = (short)1661403136;
			if (num != 0)
			{
			}
		}

		// Token: 0x170041BD RID: 16829
		// (get) Token: 0x0600809D RID: 32925 RVA: 0x00762400 File Offset: 0x00760600
		public bool HasDiffs
		{
			get
			{
				short num = (short)557383680;
				short num2 = num;
				num = (short)1074588652;
				short num3 = num;
				num = (short)44559340;
				switch (num3 == num)
				{
				}
				num = (short)569835521;
				if (num != 0)
				{
				}
				num = (short)746520576;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x007624B0 File Offset: 0x007606B0
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
						num2 = (short)1357053956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1336803331;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)2023161857;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
				{
					num2 = (short)565914549;
					short num3 = num2;
					num2 = (short)1851337653;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)68091904;
						short num4 = num2;
						num2 = (short)1665728513;
						if (num2 != 0)
						{
						}
						num2 = (short)1909194752;
						if (num2 != 0)
						{
						}
						num2 = (short)96993282;
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
			num2 = (short)1559887872;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040039C4 RID: 14788
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset innerRecset;
	}
}
