using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200038C RID: 908
	[global::System.Serializable]
	public class ControlHeadO7Recset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060086B1 RID: 34481 RVA: 0x007D9054 File Offset: 0x007D7254
		public ControlHeadO7Recset()
		{
			int a_ = 3;
			base..ctor(global::AllFeatures.CodeplugGuid.b("蟃꧅ꛇ뻉뻋ꇍ볏鳓돕맗뻙ﳛ샟귡폣", a_));
			this.SetValues();
		}

		// Token: 0x060086B2 RID: 34482 RVA: 0x007D9084 File Offset: 0x007D7284
		public ControlHeadO7Recset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060086B3 RID: 34483 RVA: 0x007D90B0 File Offset: 0x007D72B0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)86275402;
			short num2 = num;
			num = (short)361854282;
			switch (num2 == num)
			{
			}
			num = (short)705757184;
			if (num != 0)
			{
			}
			num = (short)742850561;
			if (num != 0)
			{
			}
			num = (short)1279066112;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7(this);
		}

		// Token: 0x060086B4 RID: 34484 RVA: 0x007D9160 File Offset: 0x007D7360
		internal void SetValues()
		{
			int a_ = 18;
			short num = (short)2020928601;
			short num2 = num;
			num = (short)1790372953;
			switch (num2 == num)
			{
			}
			num = (short)908591104;
			if (num != 0)
			{
			}
			num = (short)120127489;
			if (num != 0)
			{
			}
			num = (short)529793024;
			short num3 = num;
			base.Id = 4114;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨꣪苬苮臰鳲鯴鋶韸迺ꇼ귾怀朂氄栆⤈上缌栎縐紒稔稖瀘砚渜㼞戠䰢䬤䄦䀨䰪堬崮倰䜲尴堶圸机縼倾⽀㝂㝄⡆╈㡊ᅌ౎㹐㵒⅔╖㙘㝚絜᝞ѠɢŤ䝦䑨䭪≬塮⵰ひᩴ᥶൸ॺቼ፾즀욈벊ꎌﺒ璉", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO7;
			base.DataTransferOrder = 65;
		}
	}
}
