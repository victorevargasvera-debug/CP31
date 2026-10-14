using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001D2 RID: 466
	[global::System.Serializable]
	public class UclAstroCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001699 RID: 5785 RVA: 0x000039FE File Offset: 0x00001BFE
		public UclAstroCallHotListRecset() : base(global::CommonResources.AppResources.ASTRO_Conventional_Hot_List, global::CommonResources.AppResources.List)
		{
			this.a();
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x001F2798 File Offset: 0x001F0998
		protected UclAstroCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			this.a();
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x001F27D8 File Offset: 0x001F09D8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1421519734;
			short num2 = num;
			num = (short)33401718;
			switch (num2 == num)
			{
			}
			num = (short)788922368;
			short num3 = num;
			num = (short)1457913857;
			if (num != 0)
			{
			}
			num = (short)368508928;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.UclAstroCallHotList(this);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x001F2888 File Offset: 0x001F0A88
		private void a()
		{
			int a_ = 6;
			short num = (short)297804966;
			short num2 = num;
			num = (short)1193419942;
			switch (num2 == num)
			{
			}
			num = (short)1879310336;
			short num3 = num;
			num = (short)1486290944;
			if (num != 0)
			{
			}
			num = (short)737280001;
			if (num != 0)
			{
			}
			base.Id = 2210;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﮊ璉톖ﲘ漢펠욢횤鲦쒪사\udfae\udeb0\uddb2킴\ud9b6춸钺ﺼ\udebe귀꿂识ꃈ룊만鋐볒믔뇖냘볚꣜귞胠韢賤裦蟨쓪ꗬ胮藰뿲鳴蓶跸퓺꣼鳾洀䈂瘄猆笈搊丌渎紐缒崔砖洘圚琜氞唠眢䜤䬦缨䈪䠬堮ἰ䬲吴娶唸", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
			base.DataTransferOrder = 103;
			base.KeySeed = global::CommonResources.AppResources.List;
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x001F2978 File Offset: 0x001F0B78
		public override int MaxPool
		{
			get
			{
				short num = (short)1275941865;
				short num2 = num;
				num = (short)2118633;
				switch (num2 == num)
				{
				}
				num = (short)1346568192;
				short num3 = num;
				num = (short)351338496;
				if (num != 0)
				{
				}
				num = (short)1902837761;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListRecset._MaxPool;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x001F2A28 File Offset: 0x001F0C28
		public override int Max
		{
			get
			{
				short num = (short)272591699;
				short num2 = num;
				num = (short)584084307;
				switch (num2 == num)
				{
				}
				num = (short)611319808;
				short num3 = num;
				num = (short)1272774657;
				if (num != 0)
				{
				}
				num = (short)841678848;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListRecset._Max;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x001F2AD4 File Offset: 0x001F0CD4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1510715743;
				short num2 = num;
				num = (short)215920991;
				switch (num2 == num)
				{
				}
				num = (short)1467547648;
				short num3 = num;
				num = (short)414318593;
				if (num != 0)
				{
				}
				num = (short)372834304;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x001F2B84 File Offset: 0x001F0D84
		// Note: this type is marked as 'beforefieldinit'.
		static UclAstroCallHotListRecset()
		{
			short num = (short)1981090909;
			short num2 = num;
			num = (short)1133513821;
			switch (num2 == num)
			{
			}
			num = (short)2071855104;
			short num3 = num;
			num = (short)1211039745;
			if (num != 0)
			{
			}
			num = (short)1902706688;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListRecset._Max = 5000;
		}

		// Token: 0x04000B97 RID: 2967
		public static int _MaxPool;

		// Token: 0x04000B98 RID: 2968
		public static int _Max;
	}
}
