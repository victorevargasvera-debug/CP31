using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000242 RID: 578
	[global::System.Serializable]
	public class RadioErgonomicsWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006806 RID: 26630 RVA: 0x005D29C0 File Offset: 0x005D0BC0
		public RadioErgonomicsWideRecset()
		{
			int a_ = 10;
			base..ctor(global::AllFeatures.CodeplugGuid.b("駊곌ꯎ룐볒鋖ꯘ볚닜뇞軠転賤蓦髨쯪뫬蛮闰雲", a_));
			this.SetValues();
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x005D29F0 File Offset: 0x005D0BF0
		public RadioErgonomicsWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x005D2A1C File Offset: 0x005D0C1C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1350435973;
			short num2 = num;
			num = (short)72877189;
			switch (num2 == num)
			{
			}
			num = (short)316538881;
			if (num != 0)
			{
			}
			num = (short)786694144;
			if (num != 0)
			{
			}
			num = (short)599719936;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide(this);
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x005D2ACC File Offset: 0x005D0CCC
		internal void SetValues()
		{
			int a_ = 19;
			short num = (short)603389953;
			if (num != 0)
			{
			}
			num = (short)1789302133;
			short num2 = num;
			num = (short)2130875765;
			switch (num2 == num)
			{
			}
			num = (short)306315264;
			if (num != 0)
			{
			}
			num = (short)1848639488;
			short num3 = num;
			base.Id = 2033;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总氽ℿ♁ⵃ⥅桇ཉ㹋⥍㽏㱑㭓㭕ㅗ㥙⽛繝㝟ୡcͥ㑧㡩൫੭᥯ᵱㅳѵίᕹቻᅽ\udf87뺏ﮕ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOERGONOMICSWIDE;
			base.DataTransferOrder = 3;
		}
	}
}
