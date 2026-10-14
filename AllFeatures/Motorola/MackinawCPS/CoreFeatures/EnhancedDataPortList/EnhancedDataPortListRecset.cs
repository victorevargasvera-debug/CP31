using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DataWide;

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004BD RID: 1213
	[global::System.Serializable]
	public class EnhancedDataPortListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009FC8 RID: 40904 RVA: 0x009513B8 File Offset: 0x0094F5B8
		public EnhancedDataPortListRecset() : base(global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTLIST, global::CommonResources.AcgResources.ID_PORTLIST)
		{
			this.SetValues();
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x009513DC File Offset: 0x0094F5DC
		public EnhancedDataPortListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700503A RID: 20538
		// (get) Token: 0x06009FCA RID: 40906 RVA: 0x00951408 File Offset: 0x0094F608
		public override int MaxPool
		{
			get
			{
				short num = (short)733872128;
				short num2 = num;
				num = (short)1928905041;
				short num3 = num;
				num = (short)996852049;
				switch (num3 == num)
				{
				}
				num = (short)1747517441;
				if (num != 0)
				{
				}
				num = (short)399507456;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset._MaxPool;
			}
		}

		// Token: 0x1700503B RID: 20539
		// (get) Token: 0x06009FCB RID: 40907 RVA: 0x009514B8 File Offset: 0x0094F6B8
		// (set) Token: 0x06009FCC RID: 40908 RVA: 0x00951578 File Offset: 0x0094F778
		public override int Max
		{
			get
			{
				short num = (short)1349022869;
				short num2 = num;
				num = (short)2037544085;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)318898177;
					if (num != 0)
					{
					}
					num = (short)1265565696;
					if (num != 0)
					{
					}
					if (this._DynMax != -1)
					{
						return this._DynMax;
					}
					break;
				}
				num = (short)1283129344;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset._Max;
			}
			set
			{
				short num = (short)182124544;
				short num2 = num;
				num = (short)27000833;
				if (num != 0)
				{
				}
				num = (short)406688593;
				short num3 = num;
				num = (short)958960465;
				switch (num3 == num)
				{
				}
				num = (short)1068367872;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x1700503C RID: 20540
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x00951628 File Offset: 0x0094F828
		public bool HasDiffs
		{
			get
			{
				short num = (short)811401216;
				short num2 = num;
				num = (short)2031670009;
				short num3 = num;
				num = (short)2028196601;
				switch (num3 == num)
				{
				}
				num = (short)295895041;
				if (num != 0)
				{
				}
				num = (short)1900675072;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700503D RID: 20541
		// (get) Token: 0x06009FCE RID: 40910 RVA: 0x009516D8 File Offset: 0x0094F8D8
		// (set) Token: 0x06009FCF RID: 40911 RVA: 0x00951784 File Offset: 0x0094F984
		public override int Min
		{
			get
			{
				short num = (short)1724121088;
				short num2 = num;
				num = (short)1892856252;
				short num3 = num;
				num = (short)1361293756;
				switch (num3 == num)
				{
				}
				num = (short)955056129;
				if (num != 0)
				{
				}
				num = (short)1651507200;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset._Min;
			}
			set
			{
				short num = (short)146931712;
				short num2 = num;
				num = (short)1882410674;
				short num3 = num;
				num = (short)1425559218;
				switch (num3 == num)
				{
				}
				num = (short)2030370817;
				if (num != 0)
				{
				}
				num = (short)178388992;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset._Min = value;
			}
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x00951834 File Offset: 0x0094FA34
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)890634240;
			short num2 = num;
			num = (short)728353021;
			short num3 = num;
			num = (short)778356989;
			switch (num3 == num)
			{
			}
			num = (short)1083310081;
			if (num != 0)
			{
			}
			num = (short)613548032;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList(this);
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x009518E8 File Offset: 0x0094FAE8
		internal void SetValues()
		{
			int a_ = 13;
			short num = (short)1019674624;
			short num2 = num;
			num = (short)1388792140;
			short num3 = num;
			num = (short)1994475852;
			switch (num3 == num)
			{
			}
			num = (short)62783489;
			if (num != 0)
			{
			}
			num = (short)1215234048;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 4148;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("迍볏뻑鋓돕맗껙꧛곝藟釡\udfe3ꗥ蟧蟩鳫臭黯韱髳苵ꓷ뻹鷻諽懿∁䜃椅昇氉攋植攏怑甓戕焗甙爛䈝攟䰡䰣䜥䘧䤩䤫䨭ု瘱唳䈵夷ᨹ氻儽㈿㙁摃੅ⅇ㥉㡋ቍᕏ㱑㱓㝕㙗㥙㥛㩝⑟͡ၣݥ㡧թṫᩭ㱯᭱ݳɵⱷ᡹ၻ偽", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_PORTLIST;
			base.DataTransferOrder = 69;
		}

		// Token: 0x06009FD2 RID: 40914 RVA: 0x009519E4 File Offset: 0x0094FBE4
		protected override void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1007943680;
			short num2 = num;
			num = (short)307344078;
			short num3 = num;
			num = (short)1506652878;
			switch (num3 == num)
			{
			}
			num = (short)546701313;
			if (num != 0)
			{
			}
			num = (short)74776576;
			if (num != 0)
			{
			}
			base.OnFinishedAddRecord(record);
			this.b(record);
			this.c(record);
		}

		// Token: 0x06009FD3 RID: 40915 RVA: 0x00951AA0 File Offset: 0x0094FCA0
		protected override void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)935460864;
			short num2 = num;
			num = (short)1348745744;
			short num3 = num;
			num = (short)930429456;
			switch (num3 == num)
			{
			}
			num = (short)450953217;
			if (num != 0)
			{
			}
			num = (short)2142109696;
			if (num != 0)
			{
			}
			base.OnFinishedRemoveRecord(record);
			this.a(record);
			this.c(record);
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x00951B60 File Offset: 0x0094FD60
		private void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1601372160;
			short num2 = num;
			num = (short)983793403;
			short num3 = num;
			num = (short)774274811;
			switch (num3 == num)
			{
			}
			num = (short)1980170241;
			if (num != 0)
			{
			}
			num = (short)776077312;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x00951C08 File Offset: 0x0094FE08
		private void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)809107456;
			short num2 = num;
			num = (short)123011073;
			if (num != 0)
			{
			}
			num = (short)734686492;
			short num3 = num;
			num = (short)992570652;
			switch (num3 == num)
			{
			}
			num = (short)262275072;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x00951CB8 File Offset: 0x0094FEB8
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1444413440;
			short num2 = num;
			num = (short)419182125;
			short num3 = num;
			num = (short)2083730989;
			switch (num3 == num)
			{
			}
			num = (short)1925185537;
			if (num != 0)
			{
			}
			num = (short)1227620352;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x00951D6C File Offset: 0x0094FF6C
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_4A;
			}
			short num;
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset dataWideRecset;
			for (;;)
			{
				IL_0A:
				num = (short)845348865;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (dataWideRecset != null)
					{
						num = (short)1711144961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)1058865152;
					short num3 = num;
					num = (short)1665714339;
					short num4 = num;
					num = (short)829999267;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1617166336;
						if (num != 0)
						{
						}
						num = (short)20119555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413.CalculateValidity();
					(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideWIFIOTAPTCPPort_42627.CalculateValidity();
					(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateApplicability();
					(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).SensorMeasurementReportingUDPPort_A43022.CalculateValidity();
					(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateApplicability();
					(dataWideRecset[0][10632] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideKVLKeyloadingUDPPort_43205.CalculateValidity();
					num = (short)1908670468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (dataWideRecset.Count > 0)
					{
						num = (short)807141378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					return;
				}
				goto IL_4A;
			}
			return;
			IL_4A:
			dataWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2028) as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideRecset);
			num = (short)653328384;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x00951F98 File Offset: 0x00950198
		// Note: this type is marked as 'beforefieldinit'.
		static EnhancedDataPortListRecset()
		{
			short num = (short)1011023872;
			short num2 = num;
			num = (short)1770010154;
			short num3 = num;
			num = (short)587216426;
			switch (num3 == num)
			{
			}
			num = (short)1988362241;
			if (num != 0)
			{
			}
			num = (short)1179320320;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset._Min = 1;
		}

		// Token: 0x04004DE8 RID: 19944
		public static int _MaxPool;

		// Token: 0x04004DE9 RID: 19945
		public static int _Max;

		// Token: 0x04004DEA RID: 19946
		public int _DynMax;

		// Token: 0x04004DEB RID: 19947
		public static int _Min;
	}
}
