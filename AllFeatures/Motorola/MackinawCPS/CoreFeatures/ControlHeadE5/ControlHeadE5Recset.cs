using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003EA RID: 1002
	[global::System.Serializable]
	public class ControlHeadE5Recset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008CA4 RID: 36004 RVA: 0x0083EA20 File Offset: 0x0083CC20
		public ControlHeadE5Recset()
		{
			int a_ = 6;
			base..ctor(global::AllFeatures.CodeplugGuid.b("蓆ꛈꗊ만뷎뻐뿒鿖볘뫚맜￞쳠쏢ꃤ틦", a_));
			this.SetValues();
		}

		// Token: 0x06008CA5 RID: 36005 RVA: 0x0083EA50 File Offset: 0x0083CC50
		public ControlHeadE5Recset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06008CA6 RID: 36006 RVA: 0x0083EA7C File Offset: 0x0083CC7C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2053373952;
			short num2 = num;
			num = (short)812017353;
			short num3 = num;
			num = (short)666134217;
			switch (num3 == num)
			{
			}
			num = (short)987037696;
			if (num != 0)
			{
			}
			num = (short)1552809985;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5(this);
		}

		// Token: 0x06008CA7 RID: 36007 RVA: 0x0083EB28 File Offset: 0x0083CD28
		internal void SetValues()
		{
			int a_ = 9;
			short num = (short)1461256192;
			short num2 = num;
			num = (short)2090623803;
			short num3 = num;
			num = (short)2035508027;
			switch (num3 == num)
			{
			}
			num = (short)1667039233;
			if (num != 0)
			{
			}
			num = (short)981729280;
			if (num != 0)
			{
			}
			base.Id = 4236;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdfꇡ诣该飧藩苫语黯蛱ꣳꓵ駷黹闻釽⃿䜁瘃愅朇搉挋挍礏焑朓㘕嬗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯渱眳夵嘷丹主儽ⰿㅁᡃՅ❇⑉㡋㱍㽏㹑瑓ṕ㵗㭙㡛繝䵟䉡Ⅳ卥㑧⥩ͫmѯq᭳᩵ぷόᵻ᩽앿랁ꪃﺅ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADE5;
			base.DataTransferOrder = 150;
		}
	}
}
