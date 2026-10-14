using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x0200051E RID: 1310
	[global::System.Serializable]
	public class RepeaterIDListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B16B RID: 45419 RVA: 0x00A47C38 File Offset: 0x00A45E38
		public RepeaterIDListRecset()
		{
			int a_ = 3;
			base..ctor(global::AllFeatures.CodeplugGuid.b("雃ꏅ룇꿉귋뫍뗏ꃑ鿕鳗龎郛럝鏟雡", a_));
			this.SetValues();
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x00A47C68 File Offset: 0x00A45E68
		public RepeaterIDListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x0600B16D RID: 45421 RVA: 0x00A47C94 File Offset: 0x00A45E94
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1481031578;
			short num2 = num;
			num = (short)646954906;
			switch (num2 == num)
			{
			}
			num = (short)672661504;
			if (num != 0)
			{
			}
			num = (short)850919425;
			if (num != 0)
			{
			}
			num = (short)1573126144;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.RepeaterIDList(this);
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x00A47D44 File Offset: 0x00A45F44
		internal void SetValues()
		{
			int a_ = 19;
			short num = (short)1135459701;
			short num2 = num;
			num = (short)542489973;
			switch (num2 == num)
			{
			}
			num = (short)587792385;
			if (num != 0)
			{
			}
			num = (short)856621056;
			if (num != 0)
			{
			}
			num = (short)1921122304;
			short num3 = num;
			base.Id = 2034;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ䏿洁樃瀅洇搉砋服缏簑甓稕㠗夙猛瀝䘟䬡䌣匥娧䬩堫䜭弯就栳搵崷䨹夻弽㐿❁㙃晅Ň้汋ɍ㥏⅑⁓੕੗㽙ⱛ㭝şᙡţᑥⅧ⹩⁫ݭͯٱ婳๵᥷᝹ၻ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_REPEATERIDLIST;
			base.DataTransferOrder = 33;
		}
	}
}
