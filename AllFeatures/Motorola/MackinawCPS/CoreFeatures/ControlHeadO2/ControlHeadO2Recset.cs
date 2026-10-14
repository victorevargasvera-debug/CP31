using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003D4 RID: 980
	[global::System.Serializable]
	public class ControlHeadO2Recset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008B76 RID: 35702 RVA: 0x00829298 File Offset: 0x00827498
		public ControlHeadO2Recset()
		{
			int a_ = 17;
			base..ctor(global::AllFeatures.CodeplugGuid.b("金믓룕곗꣙돛닝샟ꫡ臣蟥賧쫩쇫컭뿯샱", a_));
			this.SetValues();
		}

		// Token: 0x06008B77 RID: 35703 RVA: 0x008292C8 File Offset: 0x008274C8
		public ControlHeadO2Recset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06008B78 RID: 35704 RVA: 0x008292F4 File Offset: 0x008274F4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)66798695;
			short num2 = num;
			num = (short)886850663;
			switch (num2 == num)
			{
			}
			num = (short)998768640;
			short num3 = num;
			num = (short)861536257;
			if (num != 0)
			{
			}
			num = (short)1743519744;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2(this);
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x008293A4 File Offset: 0x008275A4
		internal void SetValues()
		{
			int a_ = 19;
			short num = (short)1615069740;
			short num2 = num;
			num = (short)166920748;
			switch (num2 == num)
			{
			}
			num = (short)75300864;
			short num3 = num;
			num = (short)1661599745;
			if (num != 0)
			{
			}
			num = (short)291110912;
			if (num != 0)
			{
			}
			base.Id = 4115;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总紽⼿ⱁぃ㑅❇♉㽋ቍፏ㵑㩓≕⩗㕙せ繝⡟ݡգɥ䡧䝩䱫Ⅽ䉯⹱㝳᥵ᙷ๹๻ᅽ쪁얉뺋ꂍ煉歹", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO2;
			base.DataTransferOrder = 60;
		}
	}
}
