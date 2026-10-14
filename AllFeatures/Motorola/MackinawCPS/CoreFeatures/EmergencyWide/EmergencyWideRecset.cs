using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.EmergencyWide
{
	// Token: 0x0200048F RID: 1167
	[global::System.Serializable]
	public class EmergencyWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600994A RID: 39242 RVA: 0x008FBF20 File Offset: 0x008FA120
		public EmergencyWideRecset()
		{
			int a_ = 0;
			base..ctor(global::AllFeatures.CodeplugGuid.b("蓀껂ꃄ뗆껈껊ꏌ곎꣐苔뻖뷘뻚", a_));
			this.SetValues();
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x008FBF50 File Offset: 0x008FA150
		public EmergencyWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x008FBF7C File Offset: 0x008FA17C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1080432126;
			short num2 = num;
			num = (short)985142782;
			switch (num2 == num)
			{
			}
			num = (short)1716256769;
			if (num != 0)
			{
			}
			num = (short)1800929280;
			short num3 = num;
			num = (short)775553024;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide(this);
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x008FC02C File Offset: 0x008FA22C
		internal void SetValues()
		{
			int a_ = 2;
			short num = (short)1865151166;
			short num2 = num;
			num = (short)934933182;
			switch (num2 == num)
			{
			}
			num = (short)1921908737;
			if (num != 0)
			{
			}
			num = (short)876544000;
			short num3 = num;
			num = (short)1817575424;
			if (num != 0)
			{
			}
			base.Id = 2032;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("苂꧄ꯆ迈껊곌믎ꓐꇒ냔ꓖ飚닜닞釠賢诤苦蟨鿪뇬ꫮ鳰雲蟴郶鳸闺黼蛾℀䀂樄椆漈戊樌税挐爒愔縖瘘甚䄜娞䰠䘢圤䀦䰨䔪丬嘮ᄰ搲尴匶尸机砼刾⑀ㅂ≄≆❈⡊㑌ᡎ㡐㝒ご祖⅘㩚ぜ㍞", a_);
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYWIDE;
			base.DataTransferOrder = 8;
		}
	}
}
