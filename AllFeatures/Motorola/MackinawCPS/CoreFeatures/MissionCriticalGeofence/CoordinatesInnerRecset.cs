using System;
using System.Device.Location;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x02000268 RID: 616
	[global::System.Serializable]
	public class CoordinatesInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006E14 RID: 28180 RVA: 0x0062212C File Offset: 0x0062032C
		public CoordinatesInnerRecset() : base(global::CommonResources.AcgResources.ID_COORDINATES, true, false, true)
		{
			this.SetValues();
		}

		// Token: 0x06006E15 RID: 28181 RVA: 0x00622150 File Offset: 0x00620350
		public CoordinatesInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170038F0 RID: 14576
		// (get) Token: 0x06006E16 RID: 28182 RVA: 0x0062217C File Offset: 0x0062037C
		public override int MaxPool
		{
			get
			{
				short num = (short)2057659765;
				short num2 = num;
				num = (short)412771701;
				switch (num2 == num)
				{
				}
				num = (short)2058223617;
				if (num != 0)
				{
				}
				num = (short)1095761920;
				if (num != 0)
				{
				}
				num = (short)92602368;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset._MaxPool;
			}
		}

		// Token: 0x170038F1 RID: 14577
		// (get) Token: 0x06006E17 RID: 28183 RVA: 0x00622230 File Offset: 0x00620430
		// (set) Token: 0x06006E18 RID: 28184 RVA: 0x006222F4 File Offset: 0x006204F4
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)2063663104;
					short num2 = num;
					num = (short)450872985;
					short num3 = num;
					num = (short)767280793;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1723400193;
						if (num != 0)
						{
						}
						num = (short)87490560;
						if (num != 0)
						{
						}
						return global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset._Max;
					}
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)811449107;
				short num2 = num;
				num = (short)1872739091;
				switch (num2 == num)
				{
				}
				num = (short)2032074753;
				if (num != 0)
				{
				}
				num = (short)754974720;
				if (num != 0)
				{
				}
				num = (short)1379729408;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170038F2 RID: 14578
		// (get) Token: 0x06006E19 RID: 28185 RVA: 0x006223A4 File Offset: 0x006205A4
		public override int Min
		{
			get
			{
				short num = (short)1528344660;
				short num2 = num;
				num = (short)236433492;
				switch (num2 == num)
				{
				}
				num = (short)727449601;
				if (num != 0)
				{
				}
				num = (short)1978073088;
				if (num != 0)
				{
				}
				num = (short)305528832;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset._Min;
			}
		}

		// Token: 0x170038F3 RID: 14579
		// (get) Token: 0x06006E1A RID: 28186 RVA: 0x00622454 File Offset: 0x00620654
		// (set) Token: 0x06006E1B RID: 28187 RVA: 0x00622500 File Offset: 0x00620700
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1936834415;
				short num2 = num;
				num = (short)2059779951;
				switch (num2 == num)
				{
				}
				num = (short)850198528;
				if (num != 0)
				{
				}
				num = (short)352256001;
				if (num != 0)
				{
				}
				num = (short)969146368;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)709207474;
				short num2 = num;
				num = (short)1915528626;
				switch (num2 == num)
				{
				}
				num = (short)108068865;
				if (num != 0)
				{
				}
				num = (short)269418496;
				if (num != 0)
				{
				}
				num = (short)1629356032;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x06006E1C RID: 28188 RVA: 0x006225B0 File Offset: 0x006207B0
		public bool HasDiffs
		{
			get
			{
				short num = (short)428571535;
				short num2 = num;
				num = (short)1517517711;
				switch (num2 == num)
				{
				}
				num = (short)968818689;
				if (num != 0)
				{
				}
				num = (short)112394240;
				if (num != 0)
				{
				}
				num = (short)1116405760;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x0062265C File Offset: 0x0062085C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)58713492;
			short num2 = num;
			num = (short)1709630868;
			switch (num2 == num)
			{
			}
			num = (short)1583022081;
			if (num != 0)
			{
			}
			num = (short)2139947008;
			if (num != 0)
			{
			}
			num = (short)2053308416;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner(this);
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x0062270C File Offset: 0x0062090C
		internal void SetValues()
		{
			short num = (short)824342380;
			short num2 = num;
			num = (short)73103212;
			switch (num2 == num)
			{
			}
			num = (short)1887895553;
			if (num != 0)
			{
			}
			num = (short)1496186880;
			if (num != 0)
			{
			}
			num = (short)947585024;
			short num3 = num;
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_COORDINATES;
			base.DataTransferOrder = 325;
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x006227D8 File Offset: 0x006209D8
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1528485681;
			short num2 = num;
			num = (short)83613489;
			switch (num2 == num)
			{
			}
			num = (short)1851457537;
			if (num != 0)
			{
			}
			num = (short)1806893056;
			if (num != 0)
			{
			}
			num = (short)1755447296;
			short num3 = num;
			base.OnFinishedAddRecord();
			this.c(record);
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x00622894 File Offset: 0x00620A94
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)638635367;
			short num2 = num;
			num = (short)1571147111;
			switch (num2 == num)
			{
			}
			num = (short)1206845441;
			if (num != 0)
			{
			}
			num = (short)515702784;
			if (num != 0)
			{
			}
			num = (short)1474691072;
			short num3 = num;
			base.OnFinishedRemoveRecord();
			this.b(record);
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x0062294C File Offset: 0x00620B4C
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1776632211;
			short num2 = num;
			num = (short)550125971;
			switch (num2 == num)
			{
			}
			num = (short)2025979904;
			if (num != 0)
			{
			}
			num = (short)1612447745;
			if (num != 0)
			{
			}
			num = (short)1278083072;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x006229FC File Offset: 0x00620BFC
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1692541534;
			short num2 = num;
			num = (short)337650270;
			switch (num2 == num)
			{
			}
			num = (short)1883832320;
			if (num != 0)
			{
			}
			num = (short)138805249;
			if (num != 0)
			{
			}
			num = (short)895418368;
			short num3 = num;
			this.a(A_0);
		}

		// Token: 0x06006E23 RID: 28195 RVA: 0x00622AB0 File Offset: 0x00620CB0
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)227868672;
			switch (num)
			{
			default:
				for (;;)
				{
					IL_1D:
					num = (short)504823834;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
						double num3;
						global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
						double num7;
						switch (num2)
						{
						case 0:
							goto IL_3A2;
						case 1:
							missionCriticalGeofence = (base.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence);
							num = (short)1119223853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							missionCriticalGeofence.General.McGeofenceRadiusInMeters_42890.Value = 0;
							num = (short)365625344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)787939356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (num3 <= 90.0)
							{
								num = (short)58589199;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122;
						case 5:
						{
							double num4;
							if (num4 <= 180.0)
							{
								num = (short)267780109;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B7;
						}
						case 6:
							coordinatesInnerRecset = (missionCriticalGeofence.General.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset);
							num = (short)1744240659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)666173441;
							if (num != 0)
							{
							}
							if (coordinatesInnerRecset.Count == 0)
							{
								num = (short)897646622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A2;
						case 8:
							if (!global::AcpCommonLib.ConstraintManager.Suspended)
							{
								num = (short)567476255;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 9:
						{
							num = (short)2099183616;
							short num5 = num;
							global::System.Device.Location.GeoCoordinate geoCoordinate;
							if (geoCoordinate != null)
							{
								num = (short)102301708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A2;
						}
						case 10:
							goto IL_122;
						case 11:
						{
							double num4;
							double num6;
							global::System.Device.Location.GeoCoordinate geoCoordinate = new global::System.Device.Location.GeoCoordinate(num6, num4);
							num = (short)749862926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1381171238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)339476521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_2B7;
						case 15:
						{
							global::System.Device.Location.GeoCoordinate geoCoordinate2 = new global::System.Device.Location.GeoCoordinate(num3, num7);
							num = (short)1717436426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							goto IL_3EA;
						case 17:
						{
							double num4;
							if (num4 >= -180.0)
							{
								num = (short)1941700632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B7;
						}
						case 18:
							goto IL_755;
						case 19:
							if (coordinatesInnerRecset != null)
							{
								num = (short)36306966;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A2;
						case 20:
							num = (short)104792068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							global::System.Device.Location.GeoCoordinate geoCoordinate = null;
							global::System.Device.Location.GeoCoordinate geoCoordinate2 = null;
							num = (short)1664614436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
							num = (short)1947140125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							if (num7 <= 180.0)
							{
								num = (short)452395050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122;
						case 24:
							num = (short)615251973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
							{
								num = (short)111149074;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)995950635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							switch (0)
							{
							case 0:
								goto IL_FB;
							}
							continue;
						case 27:
							if (num3 >= -90.0)
							{
								num = (short)1226965012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122;
						case 28:
						{
							double num6;
							if (num6 <= 90.0)
							{
								num = (short)929759243;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B7;
						}
						case 29:
							if (!global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
							{
								num = (short)276168725;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A2;
						case 30:
							missionCriticalGeofence.General.McGeofenceRadiusInMeters_42890.Value = 10;
							num = (short)2043150370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							num = (short)933822489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							goto IL_3A2;
						case 33:
							num = (short)729874455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							goto IL_3A2;
						case 35:
							num = (short)950272008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							if (coordinatesInnerRecset.Count == 2)
							{
								num = (short)624492581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1187512360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
						{
							global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner = coordinatesInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner;
							double num4 = global::System.Convert.ToDouble(coordinatesInner.CoordinatesInnerSection.McGeofenceLongitude_42893.UIValue);
							double num6 = global::System.Convert.ToDouble(coordinatesInner.CoordinatesInnerSection.McGeofenceLatitude_42894.UIValue);
							num = (short)800325649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 38:
						{
							global::System.Device.Location.GeoCoordinate geoCoordinate2;
							if (geoCoordinate2 != null)
							{
								num = (short)2112946215;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A2;
						}
						case 39:
						{
							global::System.Device.Location.GeoCoordinate geoCoordinate;
							global::System.Device.Location.GeoCoordinate geoCoordinate2;
							double distanceTo = geoCoordinate.GetDistanceTo(geoCoordinate2);
							missionCriticalGeofence.General.McGeofenceRadiusInMeters_42890.Value = global::System.Convert.ToInt32(distanceTo);
							num = (short)1072300064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 40:
						{
							if (coordinatesInnerRecset.Count > 2)
							{
								num = (short)877002754;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1233701667;
							short num8 = num;
							num = (short)1668336419;
							switch ((num8 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)1352400896;
								if (num != 0)
								{
								}
								num = (short)712048647;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 41:
						{
							double num6;
							if (num6 >= -90.0)
							{
								num = (short)1232994307;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B7;
						}
						case 42:
							num = (short)784793627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 43:
							if (base.ParentSection != null)
							{
								num = (short)2061369345;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 44:
							if (num7 >= -180.0)
							{
								num = (short)979566625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_122;
						case 45:
							if (missionCriticalGeofence != null)
							{
								num = (short)1327431686;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						IL_FB:
						if (!global::AcpCommonLib.AppInfoManager.UnpackOperation)
						{
							num = (short)445186083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
						IL_122:
						num = (short)1338966025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B7:
						global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner2 = coordinatesInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner;
						num7 = global::System.Convert.ToDouble(coordinatesInner2.CoordinatesInnerSection.McGeofenceLongitude_42893.UIValue);
						num3 = global::System.Convert.ToDouble(coordinatesInner2.CoordinatesInnerSection.McGeofenceLatitude_42894.UIValue);
						num = (short)1958281260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A2:
						missionCriticalGeofence.General.McGeofenceRadiusInMeters_42890.CalculateApplicability();
						missionCriticalGeofence.General.McGeofenceRadiusInMeters_42890.CalculateValidity();
						missionCriticalGeofence.General.McGeofenceRadiusInMeters_42890.CalculateEditability();
						num = (short)177143824;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return;
				IL_3EA:
				return;
				IL_755:
				return;
			}
		}

		// Token: 0x06006E24 RID: 28196 RVA: 0x00623334 File Offset: 0x00621534
		// Note: this type is marked as 'beforefieldinit'.
		static CoordinatesInnerRecset()
		{
			short num = (short)472687729;
			short num2 = num;
			num = (short)169583729;
			switch (num2 == num)
			{
			}
			num = (short)1342898176;
			if (num != 0)
			{
			}
			num = (short)1417609217;
			if (num != 0)
			{
			}
			num = (short)777650176;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset._Min = 1;
		}

		// Token: 0x04002AE4 RID: 10980
		public static int _MaxPool;

		// Token: 0x04002AE5 RID: 10981
		public static int _Max;

		// Token: 0x04002AE6 RID: 10982
		public int _DynMax;

		// Token: 0x04002AE7 RID: 10983
		public static int _Min;

		// Token: 0x04002AE8 RID: 10984
		public static int _DefaultRecordCount;
	}
}
