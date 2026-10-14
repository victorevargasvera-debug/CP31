using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001EE RID: 494
	[global::System.Serializable]
	public class UclTrunkingT2CallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public UclTrunkingT2CallHotListRecset() : base(global::CommonResources.AppResources.Type_II_Trunking_Hot_List, global::CommonResources.AppResources.List)
		{
			this.a();
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0020316C File Offset: 0x0020136C
		protected UclTrunkingT2CallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮑ望", a_));
			}
			this.a();
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x002031AC File Offset: 0x002013AC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1178206208;
			short num2 = num;
			num = (short)1141720449;
			short num3 = num;
			num = (short)1968391553;
			switch (num3 == num)
			{
			}
			num = (short)1502937089;
			if (num != 0)
			{
			}
			num = (short)1791950848;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotList(this);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00203260 File Offset: 0x00201460
		private void a()
		{
			int a_ = 6;
			short num = (short)1488191488;
			short num2 = num;
			num = (short)1313144833;
			if (num != 0)
			{
			}
			num = (short)1512341439;
			short num3 = num;
			num = (short)1370914751;
			switch (num3 == num)
			{
			}
			num = (short)1150681088;
			if (num != 0)
			{
			}
			base.Id = 2214;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﮊ璉톖ﲘ漢펠욢횤鲦쒪사\udfae\udeb0\uddb2킴\ud9b6춸钺ﺼ\udebe귀꿂识ꃈ룊만鋐볒믔뇖냘볚꣜귞胠韢賤裦蟨쓪ꗬ胮藰뿲鳴蓶跸퓺꣼鳾洀圂眄爆月怊搌愎瘐䜒✔吖砘眚焜圞丠圢椤並娨弪礬䴮崰攲尴制丸ᔺ䔼帾ⱀ⽂", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_Hot_List;
			base.DataTransferOrder = 102;
			base.KeySeed = global::CommonResources.AppResources.List;
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00203350 File Offset: 0x00201550
		public override int MaxPool
		{
			get
			{
				short num = (short)1538129920;
				short num2 = num;
				num = (short)570304633;
				short num3 = num;
				num = (short)1295394937;
				switch (num3 == num)
				{
				}
				num = (short)1821442049;
				if (num != 0)
				{
				}
				num = (short)1601634304;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListRecset._MaxPool;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00203400 File Offset: 0x00201600
		public override int Max
		{
			get
			{
				short num = (short)1613103104;
				short num2 = num;
				num = (short)1960837121;
				if (num != 0)
				{
				}
				num = (short)794426258;
				short num3 = num;
				num = (short)1056373650;
				switch (num3 == num)
				{
				}
				num = (short)996737024;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListRecset._Max;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x002034B0 File Offset: 0x002016B0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1933836288;
				short num2 = num;
				num = (short)1516044289;
				if (num != 0)
				{
				}
				num = (short)349174310;
				short num3 = num;
				num = (short)597162534;
				switch (num3 == num)
				{
				}
				num = (short)231538688;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x00203560 File Offset: 0x00201760
		// Note: this type is marked as 'beforefieldinit'.
		static UclTrunkingT2CallHotListRecset()
		{
			short num = (short)188612608;
			short num2 = num;
			num = (short)180357646;
			short num3 = num;
			num = (short)1147275790;
			switch (num3 == num)
			{
			}
			num = (short)1499594753;
			if (num != 0)
			{
			}
			num = (short)197066752;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListRecset._Max = 5000;
		}

		// Token: 0x04000C52 RID: 3154
		public static int _MaxPool;

		// Token: 0x04000C53 RID: 3155
		public static int _Max;
	}
}
