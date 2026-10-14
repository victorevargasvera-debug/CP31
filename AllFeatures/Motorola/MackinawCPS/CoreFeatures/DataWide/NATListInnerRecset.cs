using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E7 RID: 1255
	[global::System.Serializable]
	public class NATListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600A83D RID: 43069 RVA: 0x009C585C File Offset: 0x009C3A5C
		public NATListInnerRecset() : base(global::CommonResources.AcgResources.ID_NATLIST, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x0600A83E RID: 43070 RVA: 0x009C5880 File Offset: 0x009C3A80
		public NATListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700547F RID: 21631
		// (get) Token: 0x0600A83F RID: 43071 RVA: 0x009C58AC File Offset: 0x009C3AAC
		public override int MaxPool
		{
			get
			{
				short num = (short)1220673537;
				if (num != 0)
				{
				}
				num = (short)2091124417;
				short num2 = num;
				num = (short)700843713;
				switch (num2 == num)
				{
				}
				num = (short)1567752192;
				short num3 = num;
				num = (short)583729152;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005480 RID: 21632
		// (get) Token: 0x0600A840 RID: 43072 RVA: 0x009C5958 File Offset: 0x009C3B58
		// (set) Token: 0x0600A841 RID: 43073 RVA: 0x009C5A1C File Offset: 0x009C3C1C
		public override int Max
		{
			get
			{
				while (this._DynMax == -1)
				{
					short num = (short)10398611;
					short num2 = num;
					num = (short)604613523;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1171587072;
						short num3 = num;
						num = (short)1811218432;
						if (num != 0)
						{
						}
						num = (short)470024193;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset._Max;
					}
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)942319108;
				short num2 = num;
				num = (short)718972420;
				switch (num2 == num)
				{
				}
				num = (short)111935489;
				if (num != 0)
				{
				}
				num = (short)2081488896;
				short num3 = num;
				num = (short)1741619200;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005481 RID: 21633
		// (get) Token: 0x0600A842 RID: 43074 RVA: 0x009C5ACC File Offset: 0x009C3CCC
		public override int Min
		{
			get
			{
				short num = (short)1221491071;
				short num2 = num;
				num = (short)337213823;
				switch (num2 == num)
				{
				}
				num = (short)1343094785;
				if (num != 0)
				{
				}
				num = (short)1648885760;
				short num3 = num;
				num = (short)1383071744;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset._Min;
			}
		}

		// Token: 0x17005482 RID: 21634
		// (get) Token: 0x0600A843 RID: 43075 RVA: 0x009C5B7C File Offset: 0x009C3D7C
		// (set) Token: 0x0600A844 RID: 43076 RVA: 0x009C5C28 File Offset: 0x009C3E28
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)817130960;
				short num2 = num;
				num = (short)1888513488;
				switch (num2 == num)
				{
				}
				num = (short)467271681;
				if (num != 0)
				{
				}
				num = (short)2001993728;
				short num3 = num;
				num = (short)1532035072;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1366556673;
				if (num != 0)
				{
				}
				num = (short)854364237;
				short num2 = num;
				num = (short)1738575949;
				switch (num2 == num)
				{
				}
				num = (short)1994522624;
				short num3 = num;
				num = (short)618921984;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17005483 RID: 21635
		// (get) Token: 0x0600A845 RID: 43077 RVA: 0x009C5CD8 File Offset: 0x009C3ED8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1468989441;
				if (num != 0)
				{
				}
				num = (short)780224012;
				short num2 = num;
				num = (short)309675532;
				switch (num2 == num)
				{
				}
				num = (short)1881538560;
				short num3 = num;
				num = (short)1020657664;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600A846 RID: 43078 RVA: 0x009C5D8C File Offset: 0x009C3F8C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1729841208;
			short num2 = num;
			num = (short)979126328;
			switch (num2 == num)
			{
			}
			num = (short)491520001;
			if (num != 0)
			{
			}
			num = (short)1217658880;
			short num3 = num;
			num = (short)1419247616;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner(this);
		}

		// Token: 0x0600A847 RID: 43079 RVA: 0x009C5E38 File Offset: 0x009C4038
		internal void SetValues()
		{
			short num = (short)244731716;
			short num2 = num;
			num = (short)1829457732;
			switch (num2 == num)
			{
			}
			num = (short)1203175425;
			if (num != 0)
			{
			}
			num = (short)1936457728;
			short num3 = num;
			num = (short)370343936;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_NATLIST;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600A848 RID: 43080 RVA: 0x009C5F04 File Offset: 0x009C4104
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)71103350;
			short num2 = num;
			num = (short)100725622;
			switch (num2 == num)
			{
			}
			num = (short)506789888;
			if (num != 0)
			{
			}
			num = (short)385155072;
			short num3 = num;
			num = (short)2043346945;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.b(record);
		}

		// Token: 0x0600A849 RID: 43081 RVA: 0x009C5FBC File Offset: 0x009C41BC
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1138726289;
			short num2 = num;
			num = (short)1368757649;
			switch (num2 == num)
			{
			}
			num = (short)668532736;
			if (num != 0)
			{
			}
			num = (short)702611456;
			short num3 = num;
			num = (short)1331822593;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.a(record);
		}

		// Token: 0x0600A84A RID: 43082 RVA: 0x009C6074 File Offset: 0x009C4274
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1994961434;
			short num2 = num;
			num = (short)1253945882;
			switch (num2 == num)
			{
			}
			num = (short)394002433;
			if (num != 0)
			{
			}
			num = (short)1288503296;
			short num3 = num;
			num = (short)360775680;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600A84B RID: 43083 RVA: 0x009C6124 File Offset: 0x009C4324
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1138166735;
			short num2 = num;
			num = (short)109710287;
			switch (num2 == num)
			{
			}
			num = (short)1124401152;
			if (num != 0)
			{
			}
			num = (short)240713728;
			short num3 = num;
			num = (short)549519361;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x009C61D0 File Offset: 0x009C43D0
		private void a()
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset dataWideRecset;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)215090419;
						short num3 = num2;
						num2 = (short)2061698291;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)669122560;
							if (num2 != 0)
							{
							}
							if (dataWideRecset.Count > 0)
							{
								num2 = (short)519962628;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
						return;
					case 2:
						if (dataWideRecset != null)
						{
							num2 = (short)1943732224;
							short num4 = num2;
							num2 = (short)1639317507;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 3:
						num2 = (short)133103616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateApplicability();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateApplicability();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateValidity();
						num2 = (short)52166657;
						if (num2 != 0)
						{
						}
						num2 = (short)307494913;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_24:
				dataWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset);
				num2 = (short)693239810;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600A84D RID: 43085 RVA: 0x009C6404 File Offset: 0x009C4604
		// Note: this type is marked as 'beforefieldinit'.
		static NATListInnerRecset()
		{
			short num = (short)1119199568;
			short num2 = num;
			num = (short)741843280;
			switch (num2 == num)
			{
			}
			num = (short)586612736;
			if (num != 0)
			{
			}
			num = (short)1969029120;
			short num3 = num;
			num = (short)572981249;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset._Min = 1;
		}

		// Token: 0x04005134 RID: 20788
		public static int _MaxPool;

		// Token: 0x04005135 RID: 20789
		public static int _Max;

		// Token: 0x04005136 RID: 20790
		public int _DynMax;

		// Token: 0x04005137 RID: 20791
		public static int _Min;

		// Token: 0x04005138 RID: 20792
		public static int _DefaultRecordCount;
	}
}
