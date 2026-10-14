using System;
using System.Collections;
using System.Collections.Generic;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x0200002C RID: 44
	public sealed class CellValueConstraintContainer : global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint, global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>, global::System.Collections.IEnumerable
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0000EB08 File Offset: 0x0000CD08
		public CellValueConstraintContainer()
		{
			this.a = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000EB28 File Offset: 0x0000CD28
		public bool IsValid(global::Infragistics.Windows.DataPresenter.Cell cell, out string message)
		{
			int a_ = 13;
			short num = (short)1368981505;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1687207661;
				short num3 = num;
				num = (short)740933357;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1719926785;
					if (num != 0)
					{
					}
					num = (short)1958281216;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_23B;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 2:
						goto IL_C9;
					}
					IL_AB:
					if (cell == null)
					{
						num = (short)1767112706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>.Enumerator enumerator = this.a.GetEnumerator();
					break;
				}
				}
				num = (short)147324928;
				short num4 = num;
				num = (short)1008336896;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C9:
			IL_1D0:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("럓돕듗뛙", a_));
			IL_23B:
			try
			{
				num = (short)1168769029;
				num2 = (int)((global::System.IntPtr)num);
				bool result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1C0;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)419495938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2141847558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)867565568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_15C;
					case 4:
						result = false;
						num = (short)1233518595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_10F;
						}
						continue;
					case 6:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>.Enumerator enumerator;
						if (!enumerator.Current.IsValid(cell.Value, out message))
						{
							num = (short)327684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_111:
					num = (short)48758785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10F:
					goto IL_111;
				}
				IL_15C:
				return result;
				IL_1C0:
				goto IL_1E4;
			}
			finally
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			goto IL_1D0;
			IL_1E4:
			message = string.Empty;
			return true;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000ED88 File Offset: 0x0000CF88
		public bool IsValid(object value, out string message)
		{
			short num;
			bool result;
			for (;;)
			{
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint>.Enumerator enumerator = this.a.GetEnumerator())
				{
					num = (short)1947205637;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_100;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)327548930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)123469827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)1324351488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!enumerator.Current.IsValid(value, out message))
							{
								num = (short)335740934;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							goto IL_E5;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_57;
							}
							continue;
						case 6:
							result = false;
							num = (short)1575878660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_59:
						num = (short)1879506945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_57:
						goto IL_59;
					}
					IL_E5:
					goto IL_113;
					IL_100:
					break;
				}
				IL_113:
				num = (short)1746403329;
				if (num != 0)
				{
				}
				num = (short)942177474;
				short num3 = num;
				num = (short)1219198146;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_16F;
				}
			}
			message = string.Empty;
			return true;
			IL_16F:
			num = (short)170655744;
			if (num != 0)
			{
			}
			num = (short)1147142144;
			short num4 = num;
			return result;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000EF58 File Offset: 0x0000D158
		public void Add(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint)
		{
			int a_ = 16;
			short num;
			if (constraint == null)
			{
				num = (short)1413067882;
				short num2 = num;
				num = (short)724415594;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)451608577;
					if (num != 0)
					{
					}
					num = (short)679804928;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("듖뛘뗚껜ꯞ鏠苢賤触鷨", a_));
				}
			}
			num = (short)501088256;
			short num3 = num;
			this.a.Add(constraint);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000F030 File Offset: 0x0000D230
		public bool Remove(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint)
		{
			int a_ = 18;
			short num;
			if (constraint == null)
			{
				num = (short)1099783441;
				short num2 = num;
				num = (short)128146705;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)610926592;
					if (num != 0)
					{
					}
					num = (short)1866661889;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("뫘듚돜곞闠釢蓤軦蟨鿪", a_));
				}
			}
			num = (short)292028416;
			short num3 = num;
			return this.a.Remove(constraint);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000F108 File Offset: 0x0000D308
		public int Count
		{
			get
			{
				short num = (short)257097729;
				if (num != 0)
				{
				}
				num = (short)900742030;
				short num2 = num;
				num = (short)1440627598;
				switch (num2 == num)
				{
				default:
				{
					num = (short)17039360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1932722176;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000F1BC File Offset: 0x0000D3BC
		public void Clear()
		{
			short num = (short)1922233085;
			short num2 = num;
			num = (short)2123821821;
			switch (num2 == num)
			{
			}
			num = (short)164495360;
			short num3 = num;
			num = (short)321585153;
			if (num != 0)
			{
			}
			num = (short)286982144;
			if (num != 0)
			{
			}
			this.a.Clear();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000F274 File Offset: 0x0000D474
		public bool Contains(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint item)
		{
			short num = (short)82478091;
			short num2 = num;
			num = (short)1113424907;
			switch (num2 == num)
			{
			}
			num = (short)1868824576;
			short num3 = num;
			num = (short)1144389633;
			if (num != 0)
			{
			}
			num = (short)1636827136;
			if (num != 0)
			{
			}
			return this.a.Contains(item);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000F32C File Offset: 0x0000D52C
		public void CopyTo(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint[] array, int arrayIndex)
		{
			short num = (short)984497012;
			short num2 = num;
			num = (short)1401764724;
			switch (num2 == num)
			{
			}
			num = (short)1822949376;
			short num3 = num;
			num = (short)552075264;
			if (num != 0)
			{
			}
			num = (short)1463943169;
			if (num != 0)
			{
			}
			this.a.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000105 RID: 261 RVA: 0x0000F3E4 File Offset: 0x0000D5E4
		public bool IsReadOnly
		{
			get
			{
				short num = (short)262235642;
				short num2 = num;
				num = (short)900883962;
				switch (num2 == num)
				{
				}
				num = (short)1653211136;
				short num3 = num;
				num = (short)1220411393;
				if (num != 0)
				{
				}
				num = (short)220725248;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000F490 File Offset: 0x0000D690
		public global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint> GetEnumerator()
		{
			short num = (short)795234710;
			short num2 = num;
			num = (short)262951318;
			switch (num2 == num)
			{
			}
			num = (short)1604452352;
			short num3 = num;
			num = (short)1611792384;
			if (num != 0)
			{
			}
			num = (short)1097662465;
			if (num != 0)
			{
			}
			return this.a.GetEnumerator();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000F54C File Offset: 0x0000D74C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1395463723;
			short num2 = num;
			num = (short)892540459;
			switch (num2 == num)
			{
			}
			num = (short)880738304;
			short num3 = num;
			num = (short)1102839809;
			if (num != 0)
			{
			}
			num = (short)1722613760;
			if (num != 0)
			{
			}
			return this.a.GetEnumerator();
		}

		// Token: 0x04000059 RID: 89
		private readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint> a;
	}
}
