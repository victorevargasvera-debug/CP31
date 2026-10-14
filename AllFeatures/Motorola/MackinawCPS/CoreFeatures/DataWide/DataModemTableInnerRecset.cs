using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004CB RID: 1227
	[global::System.Serializable]
	public class DataModemTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600A0F6 RID: 41206 RVA: 0x00967410 File Offset: 0x00965610
		public DataModemTableInnerRecset() : base(global::CommonResources.AcgResources.ID_DATAMODEMTABLE)
		{
			this.SetValues();
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x00967430 File Offset: 0x00965630
		public DataModemTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005097 RID: 20631
		// (get) Token: 0x0600A0F8 RID: 41208 RVA: 0x0096745C File Offset: 0x0096565C
		public override int MaxPool
		{
			get
			{
				short num = (short)2081693965;
				short num2 = num;
				num = (short)315367693;
				switch (num2 == num)
				{
				}
				num = (short)373293056;
				short num3 = num;
				num = (short)1218248705;
				if (num != 0)
				{
				}
				num = (short)1138294784;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005098 RID: 20632
		// (get) Token: 0x0600A0F9 RID: 41209 RVA: 0x00967508 File Offset: 0x00965708
		// (set) Token: 0x0600A0FA RID: 41210 RVA: 0x009675C8 File Offset: 0x009657C8
		public override int Max
		{
			get
			{
				short num = (short)772997121;
				if (num != 0)
				{
				}
				if (this._DynMax == -1)
				{
					num = (short)249561088;
					short num2 = num;
					num = (short)228789076;
					short num3 = num;
					num = (short)362679124;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)50135040;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)546642618;
				short num2 = num;
				num = (short)1802181306;
				switch (num2 == num)
				{
				}
				num = (short)821297152;
				short num3 = num;
				num = (short)111607809;
				if (num != 0)
				{
				}
				num = (short)514195456;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005099 RID: 20633
		// (get) Token: 0x0600A0FB RID: 41211 RVA: 0x0096767C File Offset: 0x0096587C
		public override int Min
		{
			get
			{
				short num = (short)602802842;
				short num2 = num;
				num = (short)1592068762;
				switch (num2 == num)
				{
				}
				num = (short)1871577088;
				short num3 = num;
				num = (short)13565952;
				if (num != 0)
				{
				}
				num = (short)434503681;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset._Min;
			}
		}

		// Token: 0x1700509A RID: 20634
		// (get) Token: 0x0600A0FC RID: 41212 RVA: 0x0096772C File Offset: 0x0096592C
		// (set) Token: 0x0600A0FD RID: 41213 RVA: 0x009677DC File Offset: 0x009659DC
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1311152191;
				short num2 = num;
				num = (short)1246140479;
				switch (num2 == num)
				{
				}
				num = (short)2057437184;
				short num3 = num;
				num = (short)1551040512;
				if (num != 0)
				{
				}
				num = (short)2112880641;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)434930381;
				short num2 = num;
				num = (short)925008589;
				switch (num2 == num)
				{
				}
				num = (short)1411907584;
				short num3 = num;
				num = (short)1832976385;
				if (num != 0)
				{
				}
				num = (short)664272896;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x1700509B RID: 20635
		// (get) Token: 0x0600A0FE RID: 41214 RVA: 0x0096788C File Offset: 0x00965A8C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1193415402;
				short num2 = num;
				num = (short)1859195626;
				switch (num2 == num)
				{
				}
				num = (short)279117824;
				short num3 = num;
				num = (short)2097283073;
				if (num != 0)
				{
				}
				num = (short)1551761408;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x0096793C File Offset: 0x00965B3C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1328552407;
			short num2 = num;
			num = (short)251861463;
			switch (num2 == num)
			{
			}
			num = (short)360054784;
			short num3 = num;
			num = (short)387710976;
			if (num != 0)
			{
			}
			num = (short)810352641;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner(this);
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x009679EC File Offset: 0x00965BEC
		internal void SetValues()
		{
			short num = (short)719338324;
			short num2 = num;
			num = (short)1301101396;
			switch (num2 == num)
			{
			}
			num = (short)1540489216;
			short num3 = num;
			num = (short)2097807361;
			if (num != 0)
			{
			}
			num = (short)1534066688;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_DATAMODEMTABLE;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600A101 RID: 41217 RVA: 0x00967AB4 File Offset: 0x00965CB4
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)514719745;
			if (num != 0)
			{
			}
			num = (short)1981013641;
			short num2 = num;
			num = (short)81780361;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1564803072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)675938304;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.c(record);
		}

		// Token: 0x0600A102 RID: 41218 RVA: 0x00967B68 File Offset: 0x00965D68
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1588431906;
			short num2 = num;
			num = (short)350784546;
			switch (num2 == num)
			{
			}
			num = (short)576782336;
			short num3 = num;
			num = (short)989396993;
			if (num != 0)
			{
			}
			num = (short)1740832768;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.b(record);
		}

		// Token: 0x0600A103 RID: 41219 RVA: 0x00967C1C File Offset: 0x00965E1C
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)917720889;
			short num2 = num;
			num = (short)1441877817;
			switch (num2 == num)
			{
			}
			num = (short)241762304;
			short num3 = num;
			num = (short)64356353;
			if (num != 0)
			{
			}
			num = (short)423624704;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600A104 RID: 41220 RVA: 0x00967CCC File Offset: 0x00965ECC
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)464095482;
			short num2 = num;
			num = (short)1852410106;
			switch (num2 == num)
			{
			}
			num = (short)1507524608;
			short num3 = num;
			num = (short)1515323393;
			if (num != 0)
			{
			}
			num = (short)1277296640;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600A105 RID: 41221 RVA: 0x00967D7C File Offset: 0x00965F7C
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)499122180;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2B2;
				case 1:
					goto IL_2DF;
				case 2:
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						num = (short)438501376;
						short num3 = num;
						num = (short)292028419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)1012596742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 5:
					num = (short)2126577666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num = (short)1413152768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (A_0.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset).GetEnumerator();
					num = (short)1556742145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_41:
				if (global::AcpCommonLib.AppInfoManager.UnpackOperation)
				{
					break;
				}
				num = (short)2085486597;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_2B2:
			return;
			IL_2DF:
			num = (short)515112961;
			if (num != 0)
			{
			}
			try
			{
				num = (short)984285188;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
						dataModemTableInner.DataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.CalculateValidity();
						num = (short)959250435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1AE;
					case 2:
					{
						num = (short)1939894938;
						short num4 = num;
						num = (short)845443738;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_79;
						default:
							num = (short)1872035840;
							if (num != 0)
							{
							}
							num = (short)384499713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_79;
					case 5:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1738997762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner;
						num = (short)1500971014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
						if (dataModemTableInner != null)
						{
							num = (short)2112618496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_A5;
					IL_79:
					switch (0)
					{
					case 0:
						IL_A5:
						goto IL_A7;
					}
					continue;
					IL_A7:
					num = (short)95813637;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1AE:
				return;
			}
			finally
			{
				num = (short)1244856321;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1432616962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1E3;
						}
						continue;
					case 2:
						goto IL_217;
					}
					IL_1E3:
					if (enumerator == null)
					{
						break;
					}
					num = (short)362938368;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_217:;
			}
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x009680B0 File Offset: 0x009662B0
		// Note: this type is marked as 'beforefieldinit'.
		static DataModemTableInnerRecset()
		{
			short num = (short)550850306;
			short num2 = num;
			num = (short)671895298;
			switch (num2 == num)
			{
			}
			num = (short)1033633792;
			short num3 = num;
			num = (short)1453916161;
			if (num != 0)
			{
			}
			num = (short)371720192;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset._Min = 1;
		}

		// Token: 0x04004E01 RID: 19969
		public static int _MaxPool;

		// Token: 0x04004E02 RID: 19970
		public static int _Max;

		// Token: 0x04004E03 RID: 19971
		public int _DynMax;

		// Token: 0x04004E04 RID: 19972
		public static int _Min;

		// Token: 0x04004E05 RID: 19973
		public static int _DefaultRecordCount;
	}
}
