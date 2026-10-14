using System;
using System.Collections;
using System.Collections.Generic;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x02000033 RID: 51
	public class MultiCellValueConstraint : global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint, global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600011D RID: 285 RVA: 0x000100E8 File Offset: 0x0000E2E8
		public MultiCellValueConstraint()
		{
			this.a = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>();
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00010108 File Offset: 0x0000E308
		public bool IsValid(global::Infragistics.Windows.DataPresenter.Cell cell, out string message)
		{
			int a_ = 0;
			short num;
			if (cell == null)
			{
				num = (short)340061438;
				short num2 = num;
				num = (short)913566974;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1602355200;
					if (num != 0)
					{
					}
					num = (short)844169217;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("꓆곈ꟊꇌ", a_));
				}
			}
			num = (short)60882944;
			short num3 = num;
			return this.IsValid(cell.Value, out message);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000101E4 File Offset: 0x0000E3E4
		public bool IsValid(object value, out string message)
		{
			short num;
			bool result;
			for (;;)
			{
				message = null;
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>.Enumerator enumerator = this.a.GetEnumerator())
				{
					num = (short)1203044357;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_FB;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)440729602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1957298179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)110362624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (enumerator.Current.IsValid(value, out message))
							{
								num = (short)1246101510;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							goto IL_E2;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_53;
							}
							continue;
						case 6:
							result = true;
							num = (short)1971650564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_55:
						num = (short)61014017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_53:
						goto IL_55;
					}
					IL_E2:
					goto IL_10E;
					IL_FB:
					break;
				}
				IL_10E:
				num = (short)37105944;
				short num3 = num;
				num = (short)362426648;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_142;
				}
			}
			return false;
			IL_142:
			num = (short)684261377;
			if (num != 0)
			{
			}
			num = (short)1530068992;
			if (num != 0)
			{
			}
			num = (short)296681472;
			short num4 = num;
			return result;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000103AC File Offset: 0x0000E5AC
		public void Add(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint item)
		{
			int a_ = 7;
			short num;
			if (item == null)
			{
				num = (short)1945770381;
				short num2 = num;
				num = (short)1823873421;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)512229377;
					if (num != 0)
					{
					}
					num = (short)129433600;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꟍ꓏럑맓", a_));
				}
			}
			num = (short)1428488192;
			short num3 = num;
			this.a.Add(item);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00010488 File Offset: 0x0000E688
		public void Clear()
		{
			short num = (short)1284768115;
			short num2 = num;
			num = (short)2032861555;
			switch (num2 == num)
			{
			}
			num = (short)2081292288;
			if (num != 0)
			{
			}
			num = (short)1758134273;
			if (num != 0)
			{
			}
			num = (short)75104256;
			short num3 = num;
			this.a.Clear();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00010540 File Offset: 0x0000E740
		public bool Contains(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint item)
		{
			short num = (short)789761417;
			short num2 = num;
			num = (short)382782857;
			switch (num2 == num)
			{
			}
			num = (short)1263665153;
			if (num != 0)
			{
			}
			num = (short)1366556672;
			if (num != 0)
			{
			}
			num = (short)1665007616;
			short num3 = num;
			return this.a.Contains(item);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000105F8 File Offset: 0x0000E7F8
		public void CopyTo(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint[] array, int arrayIndex)
		{
			short num = (short)12796082;
			short num2 = num;
			num = (short)154222770;
			switch (num2 == num)
			{
			}
			num = (short)790036481;
			if (num != 0)
			{
			}
			num = (short)1686437888;
			if (num != 0)
			{
			}
			num = (short)935723008;
			short num3 = num;
			this.a.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000106B0 File Offset: 0x0000E8B0
		public int Count
		{
			get
			{
				short num = (short)1140989335;
				short num2 = num;
				num = (short)1410014615;
				switch (num2 == num)
				{
				}
				num = (short)109248512;
				if (num != 0)
				{
				}
				num = (short)1313538049;
				if (num != 0)
				{
				}
				num = (short)416284672;
				short num3 = num;
				return this.a.Count;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000125 RID: 293 RVA: 0x00010764 File Offset: 0x0000E964
		public bool IsReadOnly
		{
			get
			{
				short num = (short)1631738372;
				short num2 = num;
				num = (short)2015779332;
				switch (num2 == num)
				{
				}
				num = (short)661127168;
				if (num != 0)
				{
				}
				num = (short)1184628737;
				if (num != 0)
				{
				}
				num = (short)318832640;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001080C File Offset: 0x0000EA0C
		public bool Remove(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint item)
		{
			short num = (short)858194210;
			short num2 = num;
			num = (short)1274609954;
			switch (num2 == num)
			{
			}
			num = (short)1375010817;
			if (num != 0)
			{
			}
			num = (short)381222912;
			if (num != 0)
			{
			}
			num = (short)1534853120;
			short num3 = num;
			return this.a.Remove(item);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000108C4 File Offset: 0x0000EAC4
		public global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint> GetEnumerator()
		{
			short num = (short)407830529;
			if (num != 0)
			{
			}
			num = (short)286429817;
			short num2 = num;
			num = (short)1019515513;
			switch (num2 == num)
			{
			}
			num = (short)869269504;
			if (num != 0)
			{
			}
			num = (short)534839296;
			short num3 = num;
			return this.a.GetEnumerator();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0001097C File Offset: 0x0000EB7C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1030750209;
			if (num != 0)
			{
			}
			num = (short)2008954673;
			short num2 = num;
			num = (short)1345992497;
			switch (num2 == num)
			{
			}
			num = (short)1890320384;
			if (num != 0)
			{
			}
			num = (short)1817051136;
			short num3 = num;
			return this.a.GetEnumerator();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00010A34 File Offset: 0x0000EC34
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(2116350484 + A_1) + (global::System.IntPtr)5 + (global::System.IntPtr)10 + (global::System.IntPtr)91 + (global::System.IntPtr)72);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x0400005E RID: 94
		private readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint> a;
	}
}
