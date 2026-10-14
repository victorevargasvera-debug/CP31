using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x02000038 RID: 56
	[global::System.Serializable]
	public class SiteSelectableAlertListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060006D4 RID: 1748 RVA: 0x00002709 File Offset: 0x00000909
		public SiteSelectableAlertListRecset() : base(global::CommonResources.AppResources.ID_SITESELECTABLEALERTLIST, global::CommonResources.AppResources.ID_SSALIST)
		{
			this.SetValues();
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002721 File Offset: 0x00000921
		protected SiteSelectableAlertListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00065DF4 File Offset: 0x00063FF4
		public override int MaxPool
		{
			get
			{
				short num = (short)662831105;
				if (num != 0)
				{
				}
				num = (short)1734660861;
				short num2 = num;
				num = (short)609080061;
				switch (num2 == num)
				{
				}
				num = (short)973602816;
				short num3 = num;
				num = (short)672399360;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset._MaxPool;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00065EA0 File Offset: 0x000640A0
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00065F64 File Offset: 0x00064164
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1682178049;
					if (num != 0)
					{
					}
					num = (short)206283376;
					short num2 = num;
					num = (short)1190175344;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1319501824;
						if (num != 0)
						{
						}
						num = (short)670302208;
						short num3 = num;
						return global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)103569401;
				short num2 = num;
				num = (short)1491687417;
				switch (num2 == num)
				{
				}
				num = (short)53673985;
				if (num != 0)
				{
				}
				num = (short)2087845888;
				short num3 = num;
				num = (short)515112960;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00066018 File Offset: 0x00064218
		public bool HasDiffs
		{
			get
			{
				short num = (short)2491308;
				short num2 = num;
				num = (short)1517093804;
				switch (num2 == num)
				{
				}
				num = (short)53346305;
				if (num != 0)
				{
				}
				num = (short)88539136;
				short num3 = num;
				num = (short)1318125568;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x000660C8 File Offset: 0x000642C8
		public override int Min
		{
			get
			{
				short num = (short)654597686;
				short num2 = num;
				num = (short)1721851446;
				switch (num2 == num)
				{
				}
				num = (short)1358168065;
				if (num != 0)
				{
				}
				num = (short)174194688;
				short num3 = num;
				num = (short)1703739392;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset._Min;
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00066178 File Offset: 0x00064378
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1472638817;
			short num2 = num;
			num = (short)1152954209;
			switch (num2 == num)
			{
			}
			num = (short)2029649921;
			if (num != 0)
			{
			}
			num = (short)2139553792;
			short num3 = num;
			num = (short)845021184;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertList(this);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00066228 File Offset: 0x00064428
		internal void SetValues()
		{
			int a_ = 8;
			short num = (short)434145016;
			short num2 = num;
			num = (short)717981432;
			switch (num2 == num)
			{
			}
			num = (short)181469184;
			if (num != 0)
			{
			}
			num = (short)1607925760;
			short num3 = num;
			num = (short)1529020417;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 4145;
			base.SingleInstance = false;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aﶌ朗ﮖ\udf98ﺚﲜ풠톢삤풦銨슬슮솰\udcb2\udbb4튶ힸ쾺껀ꫂꛄꋆ裈ꗊꏌꃎꓐ뷒뛔닖듘뻚돜ꯞ鋠뿢뛤軦鷨軪췬볮铰鿲郴银跸髺鿼鏾搀⌂䐄欆氈礊礌⼎崐稒昔挖䔘䠚琜欞䐠瀢䀤䬦䰨䠪夬丮匰弲倴瘶唸帺似䬾ീ⩂㙄㍆ᵈ⥊⅌慎⥐㉒㡔㭖", a_);
			base.UIName = global::CommonResources.AppResources.ID_SITESELECTABLEALERTLIST;
			base.KeySeed = global::CommonResources.AppResources.ID_SSALIST;
			base.DataTransferOrder = 68;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00066328 File Offset: 0x00064528
		// Note: this type is marked as 'beforefieldinit'.
		static SiteSelectableAlertListRecset()
		{
			short num = (short)1756003440;
			short num2 = num;
			num = (short)1479965808;
			switch (num2 == num)
			{
			}
			num = (short)1841168385;
			if (num != 0)
			{
			}
			num = (short)444596224;
			short num3 = num;
			num = (short)1055588352;
			if (num != 0)
			{
			}
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset._Max = 5000;
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertListRecset._Min = 1;
		}

		// Token: 0x040002D0 RID: 720
		public static int _MaxPool;

		// Token: 0x040002D1 RID: 721
		public static int _Max;

		// Token: 0x040002D2 RID: 722
		public int _DynMax;

		// Token: 0x040002D3 RID: 723
		public static int _Min;
	}
}
