using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000547 RID: 1351
	[global::System.Serializable]
	public class ConventionalWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600B52C RID: 46380 RVA: 0x00A7F150 File Offset: 0x00A7D350
		public ConventionalWideRecset()
		{
			int a_ = 18;
			base..ctor(global::AllFeatures.CodeplugGuid.b("郒뫔맖꿘뻚돜ꯞ裠賢诤蛦藨쯪뫬蛮闰雲", a_));
			this.SetValues();
		}

		// Token: 0x0600B52D RID: 46381 RVA: 0x00A7F180 File Offset: 0x00A7D380
		public ConventionalWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x0600B52E RID: 46382 RVA: 0x00A7F1AC File Offset: 0x00A7D3AC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)519307264;
			short num2 = num;
			num = (short)898708369;
			short num3 = num;
			num = (short)1651913617;
			switch (num3 == num)
			{
			}
			num = (short)1712259072;
			if (num != 0)
			{
			}
			num = (short)51576833;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide(this);
		}

		// Token: 0x0600B52F RID: 46383 RVA: 0x00A7F25C File Offset: 0x00A7D45C
		internal void SetValues()
		{
			int a_ = 15;
			short num = (short)1209794560;
			short num2 = num;
			num = (short)1314304392;
			short num3 = num;
			num = (short)1131917704;
			switch (num3 == num)
			{
			}
			num = (short)1854406657;
			if (num != 0)
			{
			}
			num = (short)1643184128;
			if (num != 0)
			{
			}
			base.Id = 2024;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹뿻釽滿琁愃栅簇按挋怍焏縑㐓唕眗琙稛眝䜟圡嘣䜥尧䌩䌫䀭氯焱嬳堵丷弹刻䨽⤿ⵁ⩃❅⑇橉ᭋ❍㑏㝑ࡓᕕ㝗㑙⩛㭝๟ᙡൣ॥٧୩k㥭᥯ᙱᅳ塵w᭹ᅻች", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALWIDE;
			base.DataTransferOrder = 9;
		}
	}
}
