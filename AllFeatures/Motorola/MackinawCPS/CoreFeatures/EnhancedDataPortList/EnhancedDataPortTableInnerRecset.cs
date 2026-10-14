using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DataWide;

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004C0 RID: 1216
	[global::System.Serializable]
	public class EnhancedDataPortTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009FE7 RID: 40935 RVA: 0x00952DBC File Offset: 0x00950FBC
		public EnhancedDataPortTableInnerRecset() : base(global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTTABLE, global::CommonResources.AcgResources.ID_PORT)
		{
			this.SetValues();
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x00952DE0 File Offset: 0x00950FE0
		public EnhancedDataPortTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700503F RID: 20543
		// (get) Token: 0x06009FE9 RID: 40937 RVA: 0x00952E0C File Offset: 0x0095100C
		public override int MaxPool
		{
			get
			{
				short num = (short)279830251;
				short num2 = num;
				num = (short)397205227;
				switch (num2 == num)
				{
				}
				num = (short)1233518592;
				short num3 = num;
				num = (short)1559298048;
				if (num != 0)
				{
				}
				num = (short)1360199681;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005040 RID: 20544
		// (get) Token: 0x06009FEA RID: 40938 RVA: 0x00952EB8 File Offset: 0x009510B8
		// (set) Token: 0x06009FEB RID: 40939 RVA: 0x00952F78 File Offset: 0x00951178
		public override int Max
		{
			get
			{
				short num;
				while (this._DynMax == -1)
				{
					num = (short)584120929;
					short num2 = num;
					num = (short)1706031713;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2055405568;
						if (num != 0)
						{
						}
						num = (short)937558016;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset._Max;
					}
					}
				}
				num = (short)1643446273;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1879533640;
				short num2 = num;
				num = (short)1125869640;
				switch (num2 == num)
				{
				}
				num = (short)723451904;
				short num3 = num;
				num = (short)52428801;
				if (num != 0)
				{
				}
				num = (short)1352269824;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005041 RID: 20545
		// (get) Token: 0x06009FEC RID: 40940 RVA: 0x00953028 File Offset: 0x00951228
		public override int Min
		{
			get
			{
				short num = (short)2134091479;
				short num2 = num;
				num = (short)1595713239;
				switch (num2 == num)
				{
				}
				num = (short)1620377600;
				short num3 = num;
				num = (short)1483210753;
				if (num != 0)
				{
				}
				num = (short)2135228416;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset._Min;
			}
		}

		// Token: 0x17005042 RID: 20546
		// (get) Token: 0x06009FED RID: 40941 RVA: 0x009530D8 File Offset: 0x009512D8
		// (set) Token: 0x06009FEE RID: 40942 RVA: 0x00953184 File Offset: 0x00951384
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1662976001;
				if (num != 0)
				{
				}
				num = (short)101413948;
				short num2 = num;
				num = (short)650867772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1489174528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1106182144;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1899245881;
				short num2 = num;
				num = (short)5517625;
				switch (num2 == num)
				{
				}
				num = (short)2090795008;
				short num3 = num;
				num = (short)1955332096;
				if (num != 0)
				{
				}
				num = (short)1985150977;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17005043 RID: 20547
		// (get) Token: 0x06009FEF RID: 40943 RVA: 0x00953234 File Offset: 0x00951434
		public bool HasDiffs
		{
			get
			{
				short num = (short)1280789897;
				short num2 = num;
				num = (short)69160329;
				switch (num2 == num)
				{
				}
				num = (short)574685184;
				short num3 = num;
				num = (short)990642177;
				if (num != 0)
				{
				}
				num = (short)1066729472;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x009532E4 File Offset: 0x009514E4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1337503226;
			short num2 = num;
			num = (short)1257025018;
			switch (num2 == num)
			{
			}
			num = (short)142147584;
			short num3 = num;
			num = (short)1288241152;
			if (num != 0)
			{
			}
			num = (short)517341185;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner(this);
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x00953394 File Offset: 0x00951594
		internal void SetValues()
		{
			short num = (short)1597473656;
			short num2 = num;
			num = (short)660964216;
			switch (num2 == num)
			{
			}
			num = (short)268369920;
			short num3 = num;
			num = (short)1340473345;
			if (num != 0)
			{
			}
			num = (short)1970405376;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTTABLE;
			base.KeySeed = global::CommonResources.AcgResources.ID_PORT;
			base.DataTransferOrder = 69;
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x0095346C File Offset: 0x0095166C
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)38003349;
			short num2 = num;
			num = (short)1031529109;
			switch (num2 == num)
			{
			}
			num = (short)226754560;
			short num3 = num;
			num = (short)658505729;
			if (num != 0)
			{
			}
			num = (short)673906688;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord();
			this.c(record);
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x00953520 File Offset: 0x00951720
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1451023356;
			short num2 = num;
			num = (short)1105386492;
			switch (num2 == num)
			{
			}
			num = (short)1166934016;
			short num3 = num;
			num = (short)476905472;
			if (num != 0)
			{
			}
			num = (short)241958913;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord();
			this.b(record);
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x009535D8 File Offset: 0x009517D8
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)363434714;
			short num2 = num;
			num = (short)1005687514;
			switch (num2 == num)
			{
			}
			num = (short)1252392960;
			short num3 = num;
			num = (short)128385025;
			if (num != 0)
			{
			}
			num = (short)752746496;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x00953688 File Offset: 0x00951888
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1686215995;
			short num2 = num;
			num = (short)755932475;
			switch (num2 == num)
			{
			}
			num = (short)1501429760;
			short num3 = num;
			num = (short)767557633;
			if (num != 0)
			{
			}
			num = (short)865665024;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x00953738 File Offset: 0x00951938
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1239678976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset dataWideRecset;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (dataWideRecset != null)
						{
							num = (short)2115895302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (this != null)
						{
							num = (short)1811742725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_420;
					case 3:
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateApplicability();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateValidity();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateApplicability();
						(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateValidity();
						num = (short)1447297024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1729691653;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)2034696202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
									if (enhancedDataPortTableInner != null)
									{
										num = (short)279117830;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
									enhancedDataPortTableInner.EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008.CalculateValidity();
									num = (short)227016711;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)647495689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
									if (enhancedDataPortTableInner.EnhancedDataPortTableInnerSection != null)
									{
										num = (short)348651520;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_218;
									}
									continue;
								case 6:
									num = (short)1486159876;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)272433155;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner = (global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner)enumerator.Current;
									num = (short)858062849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_35F;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
									if (enhancedDataPortTableInner.EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008 != null)
									{
										num = (short)39714818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_21A:
								num = (short)1004011528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_218:
								goto IL_21A;
							}
							IL_35F:;
						}
						finally
						{
							num = (short)1313603585;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_41D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_396;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)1420828533;
									short num3 = num;
									num = (short)1396514677;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_41D;
									default:
										num = (short)1586102272;
										if (num != 0)
										{
										}
										num = (short)743243776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_396:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1588854786;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_41D:;
						}
						goto IL_420;
					case 5:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = this.GetEnumerator();
						num = (short)79626244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1216872455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (dataWideRecset.Count > 0)
						{
							num = (short)679739395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_4E;
					IL_420:
					num = (short)668532737;
					if (num != 0)
					{
					}
					dataWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset);
					num = (short)330301440;
					short num4 = num;
					num = (short)1750794241;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4E:
				num = (short)334495746;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x00953C20 File Offset: 0x00951E20
		// Note: this type is marked as 'beforefieldinit'.
		static EnhancedDataPortTableInnerRecset()
		{
			short num = (short)326388669;
			short num2 = num;
			num = (short)1021397949;
			switch (num2 == num)
			{
			}
			num = (short)134414336;
			short num3 = num;
			num = (short)811597825;
			if (num != 0)
			{
			}
			num = (short)65208320;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset._Min = 1;
		}

		// Token: 0x04004DF1 RID: 19953
		public static int _MaxPool;

		// Token: 0x04004DF2 RID: 19954
		public static int _Max;

		// Token: 0x04004DF3 RID: 19955
		public int _DynMax;

		// Token: 0x04004DF4 RID: 19956
		public static int _Min;

		// Token: 0x04004DF5 RID: 19957
		public static int _DefaultRecordCount;
	}
}
