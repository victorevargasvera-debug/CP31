using System;

namespace AcpModelTieringLib
{
	// Token: 0x0200000C RID: 12
	public class TreeStack
	{
		// Token: 0x0600004E RID: 78 RVA: 0x0000F720 File Offset: 0x0000D920
		internal bool a()
		{
			short num = (short)278134784;
			short num2 = num;
			if (this.b == 0)
			{
				num = (short)762689421;
				short num3 = num;
				num = (short)1888925581;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)838664192;
					if (num != 0)
					{
					}
					num = (short)880345089;
					if (num != 0)
					{
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000F7D4 File Offset: 0x0000D9D4
		internal TreeStack(int A_0)
		{
			this.a = new global::AcpModelTieringLib.ExpTreeNode[A_0];
			this.b = 0;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		internal void a(global::AcpModelTieringLib.ExpTreeNode A_0)
		{
			short num = (short)286720000;
			short num2 = num;
			num = (short)1085294586;
			short num3 = num;
			num = (short)1400653818;
			switch (num3 == num)
			{
			}
			num = (short)849739776;
			if (num != 0)
			{
			}
			num = (short)1921646593;
			if (num != 0)
			{
			}
			global::AcpModelTieringLib.ExpTreeNode[] array = this.a;
			int num4 = this.b;
			this.b = num4 + 1;
			array[num4] = A_0;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000F8BC File Offset: 0x0000DABC
		internal global::AcpModelTieringLib.ExpTreeNode b()
		{
			short num = (short)1726742528;
			short num2 = num;
			if (this.b > 0)
			{
				num = (short)417580800;
				short num3 = num;
				num = (short)73254656;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1013186561;
					if (num != 0)
					{
					}
					num = (short)1913847808;
					if (num != 0)
					{
					}
					global::AcpModelTieringLib.ExpTreeNode[] array = this.a;
					int num4 = this.b - 1;
					this.b = num4;
					return array[num4];
				}
				}
			}
			return null;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0000F990 File Offset: 0x0000DB90
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000FA58 File Offset: 0x0000DC58
		internal global::AcpModelTieringLib.ExpTreeNode Top
		{
			get
			{
				if (this.b > 0)
				{
					short num = (short)1498659935;
					short num2 = num;
					num = (short)1826339935;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1410662400;
						short num3 = num;
						num = (short)1550057472;
						if (num != 0)
						{
						}
						num = (short)1448476673;
						if (num != 0)
						{
						}
						return this.a[this.b - 1];
					}
					}
				}
				return null;
			}
			set
			{
				short num = (short)1751096400;
				short num2 = num;
				num = (short)576363600;
				switch (num2 == num)
				{
				}
				num = (short)825229312;
				if (num != 0)
				{
				}
				num = (short)474611712;
				short num3 = num;
				num = (short)1879572481;
				if (num != 0)
				{
				}
				this.a[this.b - 1] = value;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000FB14 File Offset: 0x0000DD14
		internal void d()
		{
			short num = (short)966262785;
			if (num != 0)
			{
			}
			num = (short)1055296500;
			short num2 = num;
			num = (short)436243444;
			switch (num2 == num)
			{
			}
			num = (short)24838144;
			short num3 = num;
			num = (short)449773568;
			if (num != 0)
			{
			}
			this.b = 0;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000FBC4 File Offset: 0x0000DDC4
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000FC74 File Offset: 0x0000DE74
		internal global::AcpModelTieringLib.ExpTreeNode[] Data
		{
			get
			{
				short num = (short)595989902;
				short num2 = num;
				num = (short)778507662;
				switch (num2 == num)
				{
				}
				num = (short)1395851265;
				if (num != 0)
				{
				}
				num = (short)1623916544;
				short num3 = num;
				num = (short)553385984;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1728890930;
				short num2 = num;
				num = (short)638240818;
				switch (num2 == num)
				{
				}
				num = (short)2070216705;
				if (num != 0)
				{
				}
				num = (short)1770258432;
				short num3 = num;
				num = (short)1715994624;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x04000032 RID: 50
		private global::AcpModelTieringLib.ExpTreeNode[] a;

		// Token: 0x04000033 RID: 51
		private int b;
	}
}
