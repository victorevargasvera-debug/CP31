using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x0200050A RID: 1290
	[global::System.Serializable]
	public class EIDBypassListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600AAA4 RID: 43684 RVA: 0x009F2E50 File Offset: 0x009F1050
		public EIDBypassListInnerRecset() : base(global::CommonResources.AcgResources.ID_BYPASSLIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x0600AAA5 RID: 43685 RVA: 0x009F2E74 File Offset: 0x009F1074
		public EIDBypassListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005566 RID: 21862
		// (get) Token: 0x0600AAA6 RID: 43686 RVA: 0x009F2EA0 File Offset: 0x009F10A0
		public override int MaxPool
		{
			get
			{
				short num = (short)2143354880;
				short num2 = num;
				num = (short)564895986;
				short num3 = num;
				num = (short)594387186;
				switch (num3 == num)
				{
				}
				num = (short)774832128;
				if (num != 0)
				{
				}
				num = (short)1654718465;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005567 RID: 21863
		// (get) Token: 0x0600AAA7 RID: 43687 RVA: 0x009F2F4C File Offset: 0x009F114C
		// (set) Token: 0x0600AAA8 RID: 43688 RVA: 0x009F3008 File Offset: 0x009F1208
		public override int Max
		{
			get
			{
				short num = (short)130482176;
				short num2 = num;
				num = (short)143245571;
				short num3 = num;
				num = (short)2127872259;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)780795904;
					if (num != 0)
					{
					}
					num = (short)1269104641;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset._Max;
					}
					break;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)639369216;
				short num2 = num;
				num = (short)1284944038;
				short num3 = num;
				num = (short)1442820262;
				switch (num3 == num)
				{
				}
				num = (short)1118175233;
				if (num != 0)
				{
				}
				num = (short)1163853824;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005568 RID: 21864
		// (get) Token: 0x0600AAA9 RID: 43689 RVA: 0x009F30B8 File Offset: 0x009F12B8
		public override int Min
		{
			get
			{
				short num = (short)1680998400;
				short num2 = num;
				num = (short)493785088;
				short num3 = num;
				num = (short)1384878080;
				switch (num3 == num)
				{
				}
				num = (short)1827536896;
				if (num != 0)
				{
				}
				num = (short)1357447169;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset._Min;
			}
		}

		// Token: 0x17005569 RID: 21865
		// (get) Token: 0x0600AAAA RID: 43690 RVA: 0x009F3164 File Offset: 0x009F1364
		// (set) Token: 0x0600AAAB RID: 43691 RVA: 0x009F3210 File Offset: 0x009F1410
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2032140288;
				short num2 = num;
				num = (short)270236002;
				short num3 = num;
				num = (short)1358330210;
				switch (num3 == num)
				{
				}
				num = (short)2060058625;
				if (num != 0)
				{
				}
				num = (short)1345257472;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)742326272;
				short num2 = num;
				num = (short)950197445;
				short num3 = num;
				num = (short)640933061;
				switch (num3 == num)
				{
				}
				num = (short)559546369;
				if (num != 0)
				{
				}
				num = (short)281411584;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700556A RID: 21866
		// (get) Token: 0x0600AAAC RID: 43692 RVA: 0x009F32BC File Offset: 0x009F14BC
		public bool HasDiffs
		{
			get
			{
				short num = (short)1354104832;
				short num2 = num;
				num = (short)220772589;
				short num3 = num;
				num = (short)825669869;
				switch (num3 == num)
				{
				}
				num = (short)1631125505;
				if (num != 0)
				{
				}
				num = (short)741343232;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600AAAD RID: 43693 RVA: 0x009F336C File Offset: 0x009F156C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1912799232;
			short num2 = num;
			num = (short)1973053780;
			short num3 = num;
			num = (short)1793681748;
			switch (num3 == num)
			{
			}
			num = (short)729743361;
			if (num != 0)
			{
			}
			num = (short)176357376;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInner(this);
		}

		// Token: 0x0600AAAE RID: 43694 RVA: 0x009F341C File Offset: 0x009F161C
		internal void SetValues()
		{
			short num = (short)1187315712;
			short num2 = num;
			num = (short)208247067;
			short num3 = num;
			num = (short)1868536091;
			switch (num3 == num)
			{
			}
			num = (short)533463041;
			if (num != 0)
			{
			}
			num = (short)537067520;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_BYPASSLIST;
			base.DataTransferOrder = 28;
		}

		// Token: 0x0600AAAF RID: 43695 RVA: 0x009F34EC File Offset: 0x009F16EC
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1702821888;
			short num2 = num;
			num = (short)70305029;
			short num3 = num;
			num = (short)918209797;
			switch (num3 == num)
			{
			}
			num = (short)778895360;
			if (num != 0)
			{
			}
			num = (short)1853620225;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.a();
		}

		// Token: 0x0600AAB0 RID: 43696 RVA: 0x009F35A4 File Offset: 0x009F17A4
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)136249344;
			short num2 = num;
			num = (short)1850147490;
			short num3 = num;
			num = (short)246678178;
			switch (num3 == num)
			{
			}
			num = (short)1820393472;
			if (num != 0)
			{
			}
			num = (short)2006908929;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.a();
		}

		// Token: 0x0600AAB1 RID: 43697 RVA: 0x009F365C File Offset: 0x009F185C
		private void a()
		{
			short num = (short)482082816;
			short num2 = num;
			num = (short)2087387136;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num3)
				{
				case 0:
				{
					num = (short)1919945405;
					short num4 = num;
					num = (short)437979837;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)572915712;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					}
					break;
				}
				case 1:
					num = (short)671940609;
					if (num != 0)
					{
					}
					try
					{
						num = (short)1395130368;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_102;
								}
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)2057109508;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInner)enumerator.Current)[10602] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection).DataProfEIDByPassListIPAddr_A36417.CalculateValidity();
								num = (short)572063746;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_18D;
							case 4:
								num = (short)1171914755;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_104:
							num = (short)959381505;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_102:
							goto IL_104;
						}
						IL_18D:
						return;
					}
					finally
					{
						num = (short)1412431872;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1C2;
								}
								continue;
							case 1:
								goto IL_1F5;
							case 2:
								enumerator.Dispose();
								num = (short)1856241665;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1C2:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2102132738;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1F5:;
					}
					goto IL_1F8;
				case 2:
					goto IL_1F8;
				}
				IL_A2:
				if (base.ParentSection != null)
				{
					num = (short)945487874;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1F8:
				enumerator = (base.ParentSection.Parent[10601].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset).GetEnumerator();
				num = (short)2067726337;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600AAB2 RID: 43698 RVA: 0x009F38DC File Offset: 0x009F1ADC
		// Note: this type is marked as 'beforefieldinit'.
		static EIDBypassListInnerRecset()
		{
			short num = (short)56426496;
			short num2 = num;
			num = (short)296292942;
			short num3 = num;
			num = (short)1040388686;
			switch (num3 == num)
			{
			}
			num = (short)1371865089;
			if (num != 0)
			{
			}
			num = (short)1358299136;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset._Min = 1;
		}

		// Token: 0x040053A4 RID: 21412
		public static int _MaxPool;

		// Token: 0x040053A5 RID: 21413
		public static int _Max;

		// Token: 0x040053A6 RID: 21414
		public int _DynMax;

		// Token: 0x040053A7 RID: 21415
		public static int _Min;

		// Token: 0x040053A8 RID: 21416
		public static int _DefaultRecordCount;
	}
}
