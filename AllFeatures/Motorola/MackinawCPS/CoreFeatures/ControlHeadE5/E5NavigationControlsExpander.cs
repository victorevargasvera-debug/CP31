using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F9 RID: 1017
	[global::System.Serializable]
	public class E5NavigationControlsExpander : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008D76 RID: 36214 RVA: 0x0084A064 File Offset: 0x00848264
		public E5NavigationControlsExpander(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008D77 RID: 36215 RVA: 0x0084A0A4 File Offset: 0x008482A4
		protected E5NavigationControlsExpander(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008D78 RID: 36216 RVA: 0x0084A0BC File Offset: 0x008482BC
		public override void Init()
		{
			int a_ = 5;
			short num = (short)1362064823;
			short num2 = num;
			num = (short)479557047;
			switch (num2 == num)
			{
			}
			num = (short)1163788288;
			short num3 = num;
			num = (short)1761738752;
			if (num != 0)
			{
			}
			num = (short)1859977217;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("装꧇볉ꗋ꧍뇏ꛑ뷓맕뛗龎鿛뇝軟雡難觥蓧駩", a_);
			base.Id = 10896;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 27;
		}

		// Token: 0x06008D79 RID: 36217 RVA: 0x0084A1A0 File Offset: 0x008483A0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1231316901;
			short num2 = num;
			num = (short)1967417253;
			switch (num2 == num)
			{
			}
			num = (short)258146304;
			short num3 = num;
			num = (short)1550778369;
			if (num != 0)
			{
			}
			num = (short)389218304;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("装꧇볉ꗋ꧍뇏ꛑ뷓맕뛗龎鿛뇝軟雡難觥蓧駩", a_);
			base.Id = 10896;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 27;
		}

		// Token: 0x06008D7A RID: 36218 RVA: 0x0084A284 File Offset: 0x00848484
		public override void PopulateReferences()
		{
			short num = (short)1112081445;
			short num2 = num;
			num = (short)494076965;
			switch (num2 == num)
			{
			}
			num = (short)1832321024;
			short num3 = num;
			num = (short)215547905;
			if (num != 0)
			{
			}
			num = (short)151519232;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008D7B RID: 36219 RVA: 0x0084A32C File Offset: 0x0084852C
		public override void DropReferences()
		{
			short num = (short)1254827926;
			short num2 = num;
			num = (short)923477910;
			switch (num2 == num)
			{
			}
			num = (short)1754202112;
			short num3 = num;
			num = (short)925958144;
			if (num != 0)
			{
			}
			num = (short)507052033;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008D7C RID: 36220 RVA: 0x0084A3D4 File Offset: 0x008485D4
		public override void SetConstraints()
		{
			short num = (short)1717658722;
			short num2 = num;
			num = (short)1654940770;
			switch (num2 == num)
			{
			}
			num = (short)1968963584;
			short num3 = num;
			num = (short)1039007744;
			if (num != 0)
			{
			}
			num = (short)1304887297;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008D7D RID: 36221 RVA: 0x0084A47C File Offset: 0x0084867C
		public override void SetupDependencies()
		{
			short num = (short)716697291;
			short num2 = num;
			num = (short)553053899;
			switch (num2 == num)
			{
			}
			num = (short)510197760;
			short num3 = num;
			num = (short)1445003265;
			if (num != 0)
			{
			}
			num = (short)1584332800;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004785 RID: 18309
		// (get) Token: 0x06008D7E RID: 36222 RVA: 0x0084A528 File Offset: 0x00848728
		public bool HasDiffs
		{
			get
			{
				short num = (short)866851456;
				short num2 = num;
				num = (short)1649744512;
				switch (num2 == num)
				{
				}
				num = (short)1924857856;
				short num3 = num;
				num = (short)1562705921;
				if (num != 0)
				{
				}
				num = (short)1775960064;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04004587 RID: 17799
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset innerRecset;
	}
}
