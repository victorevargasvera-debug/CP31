using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x02000131 RID: 305
	[global::System.Serializable]
	public sealed class DVRSFileListRecSet : global::AcpBusinessLayer.Recordset, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x00003531 File Offset: 0x00001731
		public DVRSFileListRecSet() : base(global::CommonResources.AppResources.DVRS_File_List_ID)
		{
			this.SetValues();
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00166558 File Offset: 0x00164758
		public new void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)905499055;
			short num2 = num;
			num = (short)1157222831;
			switch (num2 == num)
			{
			}
			num = (short)1433141248;
			short num3 = num;
			num = (short)760676353;
			if (num != 0)
			{
			}
			num = (short)330760192;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00166608 File Offset: 0x00164808
		internal DVRSFileListRecSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲒ", a_));
			}
			this.SetValues();
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00166648 File Offset: 0x00164848
		public override int MaxPool
		{
			get
			{
				short num = (short)897668846;
				short num2 = num;
				num = (short)101603054;
				switch (num2 == num)
				{
				}
				num = (short)1332609024;
				short num3 = num;
				num = (short)1244463105;
				if (num != 0)
				{
				}
				num = (short)1659109376;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet._MaxPool;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x001666F8 File Offset: 0x001648F8
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x001667B8 File Offset: 0x001649B8
		public override int Max
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)355598337;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						break;
					}
					num = (short)949974202;
					short num2 = num;
					num = (short)1034319034;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6C;
					}
				}
				return global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet._Max;
				IL_6C:
				num = (short)1836449792;
				short num3 = num;
				num = (short)937558016;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1255195871;
				short num2 = num;
				num = (short)1267844319;
				switch (num2 == num)
				{
				}
				num = (short)89784320;
				short num3 = num;
				num = (short)2133917697;
				if (num != 0)
				{
				}
				num = (short)710082560;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x00166868 File Offset: 0x00164A68
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x00166918 File Offset: 0x00164B18
		public override int Min
		{
			get
			{
				short num = (short)1313734657;
				if (num != 0)
				{
				}
				num = (short)1034883827;
				short num2 = num;
				num = (short)12784371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1719861248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1596653568;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet._Min;
			}
			set
			{
				short num = (short)449590567;
				short num2 = num;
				num = (short)878392615;
				switch (num2 == num)
				{
				}
				num = (short)701956096;
				short num3 = num;
				num = (short)286392320;
				if (num != 0)
				{
				}
				num = (short)1524301825;
				if (num != 0)
				{
				}
				global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet._Min = value;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001015 RID: 4117 RVA: 0x001669CC File Offset: 0x00164BCC
		public override int CounterToMax
		{
			get
			{
				short num = (short)1923153921;
				if (num != 0)
				{
				}
				num = (short)1602779197;
				short num2 = num;
				num = (short)633829437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)457572352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1317797888;
				if (num != 0)
				{
				}
				return this.Max - base.Count;
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x00166A80 File Offset: 0x00164C80
		public bool HasDiffs
		{
			get
			{
				short num = (short)1107234660;
				short num2 = num;
				num = (short)735711076;
				switch (num2 == num)
				{
				}
				num = (short)263127040;
				short num3 = num;
				num = (short)1919483904;
				if (num != 0)
				{
				}
				num = (short)1385168897;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00166B30 File Offset: 0x00164D30
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1943449810;
			short num2 = num;
			num = (short)1335800018;
			switch (num2 == num)
			{
			}
			num = (short)741539840;
			short num3 = num;
			num = (short)731971585;
			if (num != 0)
			{
			}
			num = (short)1401356288;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.DVRSFiles.List.DVRSFileList(this);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00166BE0 File Offset: 0x00164DE0
		internal void SetValues()
		{
			int a_ = 18;
			short num = (short)1776112372;
			short num2 = num;
			num = (short)789533428;
			switch (num2 == num)
			{
			}
			num = (short)954466304;
			short num3 = num;
			num = (short)1286733825;
			if (num != 0)
			{
			}
			num = (short)794624000;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 4234;
			base.SingleInstance = false;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요ﲘﺞ춠삤욦\udda8\udeaa\udfac쪮슰袲\ud8b6풸쮺튼톾꓀귂뇄鯆跈鷊鿌鳎韐뫒맔닖꫘蟚駜觞돠냢ꏤ軦藨軪ꇬ蛮苰蟲꧴돶꿸ꧺ껼맾栀漂怄䬆怈砊礌ℎ椐爒研笖", a_);
			base.UIName = global::CommonResources.AppResources.DVRS_File_List_ID;
			base.DataTransferOrder = 71;
			base.HideRecordsFromTree = true;
			this.b();
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00166CE0 File Offset: 0x00164EE0
		private void b()
		{
			short num = (short)94263935;
			short num2 = num;
			num = (short)1557617279;
			switch (num2 == num)
			{
			}
			num = (short)528875520;
			short num3 = num;
			num = (short)138805248;
			if (num != 0)
			{
			}
			num = (short)540999681;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00166D90 File Offset: 0x00164F90
		private void a()
		{
			short num;
			while (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.LABTOOL)
			{
				num = (short)1556462380;
				short num2 = num;
				num = (short)769899308;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1357512704;
					short num3 = num;
					num = (short)1306066944;
					if (num != 0)
					{
					}
					base.HiddenStatic = true;
					return;
				}
				}
			}
			num = (short)499974145;
			if (num != 0)
			{
			}
			base.HiddenStatic = false;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x00166E54 File Offset: 0x00165054
		// Note: this type is marked as 'beforefieldinit'.
		static DVRSFileListRecSet()
		{
			short num = (short)1955487190;
			short num2 = num;
			num = (short)225533398;
			switch (num2 == num)
			{
			}
			num = (short)620494848;
			short num3 = num;
			num = (short)1042153472;
			if (num != 0)
			{
			}
			num = (short)884670465;
			if (num != 0)
			{
			}
			global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet._MaxPool = int.MaxValue;
			global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet._Max = 5000;
			global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet._Min = 1;
		}

		// Token: 0x04000841 RID: 2113
		public static int _MaxPool;

		// Token: 0x04000842 RID: 2114
		public static int _Max;

		// Token: 0x04000843 RID: 2115
		internal int _DynMax;

		// Token: 0x04000844 RID: 2116
		public static int _Min;
	}
}
