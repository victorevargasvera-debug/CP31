using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x0200003B RID: 59
	[global::System.Serializable]
	public class SiteSelectableAlertTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060006EB RID: 1771 RVA: 0x00002741 File Offset: 0x00000941
		public SiteSelectableAlertTableInnerRecset() : base(global::CommonResources.AppResources.ID_SITESELECTABLEALERTTABLE, global::CommonResources.AppResources.ID_SSATABLE)
		{
			this.SetValues();
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002759 File Offset: 0x00000959
		protected SiteSelectableAlertTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x000670B4 File Offset: 0x000652B4
		public override int MaxPool
		{
			get
			{
				short num = (short)2113413297;
				short num2 = num;
				num = (short)1047863473;
				switch (num2 == num)
				{
				}
				num = (short)1746468865;
				if (num != 0)
				{
				}
				num = (short)542834688;
				short num3 = num;
				num = (short)671875072;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00067160 File Offset: 0x00065360
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00067220 File Offset: 0x00065420
		public override int Max
		{
			get
			{
				short num = (short)321721094;
				short num2 = num;
				num = (short)1511658246;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)813236225;
					if (num != 0)
					{
					}
					num = (short)205979648;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				num = (short)1825439744;
				short num3 = num;
				return global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset._Max;
			}
			set
			{
				short num = (short)1252786176;
				short num2 = num;
				num = (short)1223678425;
				short num3 = num;
				num = (short)1705040345;
				switch (num3 == num)
				{
				}
				num = (short)1640562689;
				if (num != 0)
				{
				}
				num = (short)1860763648;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000672D0 File Offset: 0x000654D0
		public override int Min
		{
			get
			{
				short num = (short)227999744;
				short num2 = num;
				num = (short)432487029;
				short num3 = num;
				num = (short)812464757;
				switch (num3 == num)
				{
				}
				num = (short)134217729;
				if (num != 0)
				{
				}
				num = (short)1856634880;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset._Min;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00067380 File Offset: 0x00065580
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x0006742C File Offset: 0x0006562C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1160577024;
				short num2 = num;
				num = (short)1166475265;
				if (num != 0)
				{
				}
				num = (short)1617523315;
				short num3 = num;
				num = (short)1908699763;
				switch (num3 == num)
				{
				}
				num = (short)1829765120;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)2105147392;
				short num2 = num;
				num = (short)566349890;
				short num3 = num;
				num = (short)1688850498;
				switch (num3 == num)
				{
				}
				num = (short)1411121153;
				if (num != 0)
				{
				}
				num = (short)1459748864;
				if (num != 0)
				{
				}
				global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x000674DC File Offset: 0x000656DC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1884618752;
				short num2 = num;
				num = (short)1933556175;
				short num3 = num;
				num = (short)1001961935;
				switch (num3 == num)
				{
				}
				num = (short)1251803137;
				if (num != 0)
				{
				}
				num = (short)570621952;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0006758C File Offset: 0x0006578C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)968097792;
			short num2 = num;
			num = (short)200151439;
			short num3 = num;
			num = (short)1700139407;
			switch (num3 == num)
			{
			}
			num = (short)806486017;
			if (num != 0)
			{
			}
			num = (short)479592448;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner(this);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00067640 File Offset: 0x00065840
		internal void SetValues()
		{
			short num = (short)728367104;
			short num2 = num;
			num = (short)32101195;
			short num3 = num;
			num = (short)2091307851;
			switch (num3 == num)
			{
			}
			num = (short)425197568;
			if (num != 0)
			{
			}
			num = (short)1636696065;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AppResources.ID_SITESELECTABLEALERTTABLE;
			base.KeySeed = global::CommonResources.AppResources.ID_SSATABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00067714 File Offset: 0x00065914
		// Note: this type is marked as 'beforefieldinit'.
		static SiteSelectableAlertTableInnerRecset()
		{
			short num = (short)138084352;
			short num2 = num;
			num = (short)383358180;
			short num3 = num;
			num = (short)25597156;
			switch (num3 == num)
			{
			}
			num = (short)811466753;
			if (num != 0)
			{
			}
			num = (short)76152832;
			if (num != 0)
			{
			}
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset._Max = 5000;
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerRecset._Min = 1;
		}

		// Token: 0x040002D9 RID: 729
		public static int _MaxPool;

		// Token: 0x040002DA RID: 730
		public static int _Max;

		// Token: 0x040002DB RID: 731
		public int _DynMax;

		// Token: 0x040002DC RID: 732
		public static int _Min;

		// Token: 0x040002DD RID: 733
		public static int _DefaultRecordCount;
	}
}
