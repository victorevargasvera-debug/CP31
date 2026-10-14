using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E0 RID: 480
	[global::System.Serializable]
	public class UclPhoneCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600173A RID: 5946 RVA: 0x001FBD48 File Offset: 0x001F9F48
		internal UclPhoneCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8e戀ﲒﮔ릘펚膠첤풦\udda8", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾胂꓄ꯆꗈ臌ꛎꋐ꟒铖뛘뗚믜뛞蛠離韤蛦鷨苪苬臮\udef0믲髴菶뗸鋺軼课⸀嘂昄欆夈挊戌愎琐倒琔笖甘匚爜欞洠䨢嘤匦礨䨪䨬䨮ἰ䬲吴娶唸", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotListHotListSection(this));
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x001FBDA4 File Offset: 0x001F9FA4
		public global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotListHotListSection PhoneCallHotList
		{
			get
			{
				short num = (short)1918192341;
				short num2 = num;
				num = (short)1403472597;
				switch (num2 == num)
				{
				}
				num = (short)1157496832;
				short num3 = num;
				num = (short)30801921;
				if (num != 0)
				{
				}
				num = (short)107347968;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.UclPhoneCallHotListHotListSection)base[10427];
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x001FBE60 File Offset: 0x001FA060
		protected UclPhoneCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud988뎒\udd94뮚톜튠힢", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﮊ璉톖ﲘ漢펠욢횤鲦쒪사\udfae\udeb0\uddb2킴\ud9b6춸钺ﺼ\udebe귀꿂识ꃈ룊만鋐볒믔뇖냘볚꣜귞胠韢賤裦蟨쓪ꗬ胮藰뿲鳴蓶跸퓺꣼鳾洀匂洄栆月渊丌渎紐缒崔砖洘圚琜氞唠猢䐤䀦䰨Ԫ唬丮尰弲", a_);
		}
	}
}
