using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x0200000A RID: 10
	public class AcpChildToolbarCollection : global::System.Collections.ObjectModel.Collection<global::AcpUI.AcpChildRecNavToolbar>
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000F18C File Offset: 0x0000D38C
		internal AcpChildToolbarCollection(global::AcpUI.AcpParentRecNavToolbar A_0)
		{
			this.a(A_0);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000F1A8 File Offset: 0x0000D3A8
		internal AcpChildToolbarCollection(global::AcpUI.AcpParentRecNavToolbar A_0, global::System.Collections.Generic.IList<global::AcpUI.AcpChildRecNavToolbar> A_1) : base(A_1)
		{
			this.a(A_0);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		internal global::AcpUI.AcpParentRecNavToolbar ParentToolbar
		{
			get
			{
				short num = (short)1473079592;
				short num2 = num;
				num = (short)529230120;
				switch (num2 == num)
				{
				}
				num = (short)105250816;
				if (num != 0)
				{
				}
				num = (short)2116288513;
				if (num != 0)
				{
				}
				num = (short)441188352;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000F274 File Offset: 0x0000D474
		private void a(global::AcpUI.AcpParentRecNavToolbar A_0)
		{
			int a_ = 10;
			while (A_0 == null)
			{
				short num = (short)1703215105;
				if (num != 0)
				{
				}
				num = (short)1516405194;
				short num2 = num;
				num = (short)1401192906;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1403977728;
					if (num != 0)
					{
					}
					num = (short)926482432;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::AcpUI.Common.Utility.c("킟쎡횣쎥욧\udea9", a_));
				}
				}
			}
			this.a = A_0;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000F348 File Offset: 0x0000D548
		protected override void InsertItem(int index, global::AcpUI.AcpChildRecNavToolbar child)
		{
			int a_ = 19;
			short num = (short)2068512769;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (child.ParentToolbar != null)
					{
						num = (short)1565196290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13C;
				case 1:
					goto IL_1D;
				case 2:
					return;
				case 3:
				{
					num = (short)1178076187;
					short num3 = num;
					num = (short)617022491;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						goto IL_C3;
					}
					break;
				}
				}
				goto IL_3D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_3D:
					if (child == null)
					{
						num = (short)1315438595;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)171245568;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			return;
			IL_C3:
			num = (short)1679294465;
			if (num != 0)
			{
			}
			num = (short)784138240;
			short num4 = num;
			num = (short)1670184960;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::AcpUI.Common.Utility.c("쪨쎪쒬쎮햰", a_));
			IL_13C:
			child.ParentToolbar = this.a;
			base.InsertItem(index, child);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
		protected override void SetItem(int index, global::AcpUI.AcpChildRecNavToolbar child)
		{
			int a_ = 6;
			while (child == null)
			{
				short num = (short)1107886081;
				if (num != 0)
				{
				}
				num = (short)95483028;
				short num2 = num;
				num = (short)761787540;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)331874304;
					if (num != 0)
					{
					}
					num = (short)1423835136;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::AcpUI.Common.Utility.c("ﾛ즟캡삣", a_));
				}
				}
			}
			child.ParentToolbar = this.a;
			base.SetItem(index, child);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000F588 File Offset: 0x0000D788
		protected override void RemoveItem(int index)
		{
			short num = (short)1978716965;
			short num2 = num;
			num = (short)1002230565;
			switch (num2 == num)
			{
			}
			num = (short)1487011841;
			if (num != 0)
			{
			}
			num = (short)416546816;
			if (num != 0)
			{
			}
			num = (short)2064056320;
			short num3 = num;
			base[index].ParentToolbar = null;
			base.RemoveItem(index);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000F644 File Offset: 0x0000D844
		protected override void ClearItems()
		{
			short num;
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpUI.AcpChildRecNavToolbar> enumerator = base.Items.GetEnumerator();
				try
				{
					num = (short)1291386882;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_B6;
						case 1:
							num = (short)1914241024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_46;
							}
							continue;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)1807548417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.ParentToolbar = null;
							num = (short)1621753860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_6B:
						num = (short)1855586307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_46:
						goto IL_6B;
					}
					IL_B6:;
				}
				finally
				{
					num = (short)857341952;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_ED;
							}
							continue;
						case 1:
							goto IL_122;
						case 2:
							enumerator.Dispose();
							num = (short)354877441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_ED:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1096155138;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_122:
					num = (short)590020609;
					if (num != 0)
					{
					}
				}
				num = (short)943871214;
				short num3 = num;
				num = (short)431838446;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_182;
				}
			}
			IL_182:
			num = (short)2034302976;
			if (num != 0)
			{
			}
			num = (short)1027276800;
			short num4 = num;
			base.ClearItems();
		}

		// Token: 0x04000043 RID: 67
		private global::AcpUI.AcpParentRecNavToolbar a;
	}
}
