using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003D0 RID: 976
	[global::System.Serializable]
	public class O3NavigationControlsTableInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008B1D RID: 35613 RVA: 0x008203E4 File Offset: 0x0081E5E4
		public O3NavigationControlsTableInnerRecset() : base(global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS)
		{
			this.SetValues();
		}

		// Token: 0x06008B1E RID: 35614 RVA: 0x00820404 File Offset: 0x0081E604
		public O3NavigationControlsTableInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700468E RID: 18062
		// (get) Token: 0x06008B1F RID: 35615 RVA: 0x00820430 File Offset: 0x0081E630
		public override int MaxPool
		{
			get
			{
				short num = (short)1266787920;
				short num2 = num;
				num = (short)883205712;
				switch (num2 == num)
				{
				}
				num = (short)209321984;
				short num3 = num;
				num = (short)539099136;
				if (num != 0)
				{
				}
				num = (short)1776549889;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset._MaxPool;
			}
		}

		// Token: 0x1700468F RID: 18063
		// (get) Token: 0x06008B20 RID: 35616 RVA: 0x008204E0 File Offset: 0x0081E6E0
		// (set) Token: 0x06008B21 RID: 35617 RVA: 0x008205A8 File Offset: 0x0081E7A8
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num = (short)1570504705;
					if (num != 0)
					{
					}
					num = (short)1767195823;
					short num2 = num;
					num = (short)1323320495;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)128909312;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)1408761856;
					short num3 = num;
					return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)70802430;
				short num2 = num;
				num = (short)1469209598;
				switch (num2 == num)
				{
				}
				num = (short)1579089920;
				short num3 = num;
				num = (short)87293953;
				if (num != 0)
				{
				}
				num = (short)1303511040;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x06008B22 RID: 35618 RVA: 0x00820658 File Offset: 0x0081E858
		public override int Min
		{
			get
			{
				short num = (short)253322143;
				short num2 = num;
				num = (short)793600927;
				switch (num2 == num)
				{
				}
				num = (short)1852506112;
				short num3 = num;
				num = (short)547946497;
				if (num != 0)
				{
				}
				num = (short)814153728;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset._Min;
			}
		}

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x06008B23 RID: 35619 RVA: 0x00820704 File Offset: 0x0081E904
		// (set) Token: 0x06008B24 RID: 35620 RVA: 0x008207B0 File Offset: 0x0081E9B0
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)281884313;
				short num2 = num;
				num = (short)910833305;
				switch (num2 == num)
				{
				}
				num = (short)1124401152;
				short num3 = num;
				num = (short)1886322689;
				if (num != 0)
				{
				}
				num = (short)713359360;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1423873477;
				short num2 = num;
				num = (short)1367578053;
				switch (num2 == num)
				{
				}
				num = (short)1621950464;
				short num3 = num;
				num = (short)589103105;
				if (num != 0)
				{
				}
				num = (short)790036480;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x06008B25 RID: 35621 RVA: 0x00820860 File Offset: 0x0081EA60
		public bool HasDiffs
		{
			get
			{
				short num = (short)1760908813;
				short num2 = num;
				num = (short)2086819341;
				switch (num2 == num)
				{
				}
				num = (short)716439552;
				short num3 = num;
				num = (short)764149760;
				if (num != 0)
				{
				}
				num = (short)502202369;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008B26 RID: 35622 RVA: 0x00820910 File Offset: 0x0081EB10
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1220859104;
			short num2 = num;
			num = (short)1544344800;
			switch (num2 == num)
			{
			}
			num = (short)1956708352;
			short num3 = num;
			num = (short)1742471169;
			if (num != 0)
			{
			}
			num = (short)1466433536;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner(this);
		}

		// Token: 0x06008B27 RID: 35623 RVA: 0x008209C0 File Offset: 0x0081EBC0
		internal void SetValues()
		{
			short num = (short)202624106;
			short num2 = num;
			num = (short)1507314794;
			switch (num2 == num)
			{
			}
			num = (short)358088704;
			short num3 = num;
			num = (short)1298202624;
			if (num != 0)
			{
			}
			num = (short)626917377;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			base.DataTransferOrder = 17;
		}

		// Token: 0x06008B28 RID: 35624 RVA: 0x00820A8C File Offset: 0x0081EC8C
		// Note: this type is marked as 'beforefieldinit'.
		static O3NavigationControlsTableInnerRecset()
		{
			short num = (short)1610855351;
			short num2 = num;
			num = (short)1521726391;
			switch (num2 == num)
			{
			}
			num = (short)692191232;
			short num3 = num;
			num = (short)1768554496;
			if (num != 0)
			{
			}
			num = (short)122552321;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset._Min = 1;
		}

		// Token: 0x040042DD RID: 17117
		public static int _MaxPool;

		// Token: 0x040042DE RID: 17118
		public static int _Max;

		// Token: 0x040042DF RID: 17119
		public int _DynMax;

		// Token: 0x040042E0 RID: 17120
		public static int _Min;

		// Token: 0x040042E1 RID: 17121
		public static int _DefaultRecordCount;
	}
}
