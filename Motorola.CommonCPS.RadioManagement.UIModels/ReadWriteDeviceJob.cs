using System;
using System.Linq.Expressions;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000B2 RID: 178
	public class ReadWriteDeviceJob : global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase
	{
		// Token: 0x060006B9 RID: 1721 RVA: 0x00061524 File Offset: 0x0005F724
		public ReadWriteDeviceJob(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobViewSummary emJobSum) : base(emJobSum)
		{
			this.a = emJobSum;
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x00061540 File Offset: 0x0005F740
		public string ConfigurationName
		{
			get
			{
				short num = (short)399572992;
				short num2 = num;
				num = (short)1830617089;
				if (num != 0)
				{
				}
				num = (short)819231123;
				short num3 = num;
				num = (short)2066774419;
				switch (num3 == num)
				{
				}
				num = (short)123797504;
				if (num != 0)
				{
				}
				return this.a.ConfigurationName;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x000615F4 File Offset: 0x0005F7F4
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x000616A4 File Offset: 0x0005F8A4
		public string JobContainerInfoString
		{
			get
			{
				short num = (short)1101529088;
				short num2 = num;
				num = (short)1048772609;
				if (num != 0)
				{
				}
				num = (short)1080691785;
				short num3 = num;
				num = (short)1881934921;
				switch (num3 == num)
				{
				}
				num = (short)177012736;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				while (!(value == this.b))
				{
					short num = (short)149618689;
					if (num != 0)
					{
					}
					num = (short)645201920;
					short num2 = num;
					num = (short)2025006307;
					short num3 = num;
					num = (short)936387811;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1209466880;
						if (num != 0)
						{
						}
						this.b = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ReadWriteDeviceJob.get_JobContainerInfoString())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
				}
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00061798 File Offset: 0x0005F998
		public string ModelNumber
		{
			get
			{
				short num = (short)1861877760;
				short num2 = num;
				num = (short)70728480;
				short num3 = num;
				num = (short)634993440;
				switch (num3 == num)
				{
				}
				num = (short)979107841;
				if (num != 0)
				{
				}
				num = (short)1297678336;
				if (num != 0)
				{
				}
				return this.a.ModelNumber;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0006184C File Offset: 0x0005FA4C
		public string ProductIdentifier
		{
			get
			{
				short num = (short)515768320;
				short num2 = num;
				num = (short)150616210;
				short num3 = num;
				num = (short)1251358866;
				switch (num3 == num)
				{
				}
				num = (short)225771521;
				if (num != 0)
				{
				}
				num = (short)1407057920;
				if (num != 0)
				{
				}
				return this.a.ProductIdentifier;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00061900 File Offset: 0x0005FB00
		public string SerialNumber
		{
			get
			{
				short num = (short)625868800;
				short num2 = num;
				num = (short)1934774792;
				short num3 = num;
				num = (short)970609160;
				switch (num3 == num)
				{
				}
				num = (short)291569665;
				if (num != 0)
				{
				}
				num = (short)1749286912;
				if (num != 0)
				{
				}
				return this.a.SerialNumber;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x000619B8 File Offset: 0x0005FBB8
		public string DeviceID
		{
			get
			{
				short num = (short)627703808;
				short num2 = num;
				num = (short)1332097234;
				short num3 = num;
				num = (short)1273835730;
				switch (num3 == num)
				{
				}
				num = (short)910819329;
				if (num != 0)
				{
				}
				num = (short)1905655808;
				if (num != 0)
				{
				}
				return this.a.DeviceID;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x00061A6C File Offset: 0x0005FC6C
		public string TemplateName
		{
			get
			{
				short num = (short)1094254592;
				short num2 = num;
				num = (short)253244298;
				short num3 = num;
				num = (short)767308682;
				switch (num3 == num)
				{
				}
				num = (short)1521811457;
				if (num != 0)
				{
				}
				num = (short)1077018624;
				if (num != 0)
				{
				}
				return this.a.TemplateName;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00061B24 File Offset: 0x0005FD24
		public string RadioAlias
		{
			get
			{
				short num = (short)335937536;
				short num2 = num;
				num = (short)1942348381;
				short num3 = num;
				num = (short)505340509;
				switch (num3 == num)
				{
				}
				num = (short)858587137;
				if (num != 0)
				{
				}
				num = (short)1710620672;
				if (num != 0)
				{
				}
				return this.a.RadioAlias;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00061BD8 File Offset: 0x0005FDD8
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			get
			{
				short num = (short)882049024;
				short num2 = num;
				num = (short)1739194369;
				if (num != 0)
				{
				}
				num = (short)1595396140;
				short num3 = num;
				num = (short)15323180;
				switch (num3 == num)
				{
				}
				num = (short)1367736320;
				if (num != 0)
				{
				}
				return this.a.WorkMode;
			}
		}

		// Token: 0x040002D1 RID: 721
		private global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobViewSummary a;

		// Token: 0x040002D2 RID: 722
		private string b;
	}
}
