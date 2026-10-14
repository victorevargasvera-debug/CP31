using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200000B RID: 11
	public class CellRangeFillerBindingCollection : global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000031 RID: 49 RVA: 0x000041BC File Offset: 0x000023BC
		public CellRangeFillerBindingCollection()
		{
			this.a = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>>();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000041DC File Offset: 0x000023DC
		public void Add(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding item)
		{
			int a_ = 5;
			short num = (short)2135556102;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1352151702;
					short num3 = num;
					num = (short)81474198;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
						goto IL_17D;
					}
					break;
				}
				case 1:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>();
					num = (short)1595932673;
					if (num != 0)
					{
					}
					num = (short)2104950786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_95;
				case 3:
					if (list.Contains(item))
					{
						num = (short)1149829128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)700776457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!this.a.TryGetValue(item.ColumnName, out list))
					{
						num = (short)2138898433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_95;
				case 5:
					this.a.Add(item.ColumnName, list);
					num = (short)913047552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 7:
					goto IL_6E;
				case 8:
					goto IL_D1;
				case 9:
					if (list.Count == 0)
					{
						num = (short)694353925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25C;
				}
				IL_56:
				if (item == null)
				{
					num = (short)802881543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_D3;
				IL_95:
				num = (short)1948385283;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D3:
				num = (short)453902340;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6E:
			num = (short)115015680;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꗋ뫍뗏뿑", a_));
			IL_D1:
			throw new global::System.ArgumentException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("裋믍ꃏ뻑뷓뗕맗껙맛ﻝ觟雡臣该", a_), global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("ꗋ뫍뗏뿑", a_));
			IL_17D:
			num = (short)496893952;
			if (num != 0)
			{
			}
			IL_25C:
			list.Add(item);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000444C File Offset: 0x0000264C
		public void Clear()
		{
			short num = (short)80541528;
			short num2 = num;
			num = (short)1622079320;
			switch (num2 == num)
			{
			}
			num = (short)1487011841;
			if (num != 0)
			{
			}
			num = (short)160432128;
			if (num != 0)
			{
			}
			num = (short)819855360;
			short num3 = num;
			this.a.Clear();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004504 File Offset: 0x00002704
		public bool Contains(string item)
		{
			while (item != null)
			{
				short num = (short)1341635684;
				short num2 = num;
				num = (short)197508196;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)848625664;
					short num3 = num;
					break;
				}
				}
				num = (short)964100096;
				if (num != 0)
				{
				}
				num = (short)733478913;
				if (num != 0)
				{
				}
				return this.a.ContainsKey(item);
			}
			return false;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000045C0 File Offset: 0x000027C0
		public bool Contains(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding item)
		{
			short num = (short)179634177;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					goto IL_14;
				case 2:
					return false;
				case 3:
				{
					num = (short)1300434863;
					short num3 = num;
					num = (short)1457328047;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1364721665;
						if (num != 0)
						{
						}
						num = (short)1058013184;
						if (num != 0)
						{
						}
						if (!this.a.TryGetValue(item.ColumnName, out list))
						{
							num = (short)202964992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					}
					break;
				}
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
					IL_34:
					if (item == null)
					{
						num = (short)824639488;
						short num4 = num;
						num = (short)1384841218;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)839254019;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			return false;
			IL_135:
			return list.Contains(item);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000470C File Offset: 0x0000290C
		public void CopyTo(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding[] array, int arrayIndex)
		{
			int a_ = 10;
			short num = (short)195493891;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (arrayIndex >= 0)
					{
						num = (short)1176567810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10A;
				case 1:
					goto IL_26C;
				case 2:
					goto IL_22E;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 4:
					goto IL_64;
				case 5:
					try
					{
						num = (short)851247106;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_21E;
							case 1:
								num = (short)1900740608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1A2;
								}
								continue;
							case 3:
							{
								global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>>.ValueCollection.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)2112421889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding> list = enumerator.Current;
								int num3;
								list.CopyTo(array, num3);
								num3 += list.Count;
								num = (short)41091076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_1A4:
							num = (short)820183043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1A2:
							goto IL_1A4;
						}
						IL_21E:
						return;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>>.ValueCollection.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_22E;
				case 6:
					if (this.Count <= array.Length - arrayIndex)
					{
						num = (short)1168377168;
						short num4 = num;
						num = (short)692585808;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)471007232;
							if (num != 0)
							{
							}
							int num3 = arrayIndex;
							global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>>.ValueCollection.Enumerator enumerator = this.a.Values.GetEnumerator();
							num = (short)460783621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
					}
					num = (short)1710358529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4A:
				if (array == null)
				{
					num = (short)2051932164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1011941376;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_22E:
				num = (short)1168506886;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_64:
			num = (short)1713569793;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("냐ꇒ꟔뛖ꃘ", a_));
			IL_10A:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("냐ꇒ꟔뛖ꃘ鋚돜믞蓠鯢", a_));
			IL_26C:
			num = (short)2079064064;
			short num5 = num;
			goto IL_10A;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000037 RID: 55 RVA: 0x000049C8 File Offset: 0x00002BC8
		public int Count
		{
			get
			{
				short num = (short)308643289;
				short num2 = num;
				num = (short)377390553;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)713752576;
					short num3 = num;
					num = (short)1740570624;
					if (num != 0)
					{
					}
					num4 = 0;
					using (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>>.ValueCollection.Enumerator enumerator = this.a.Values.GetEnumerator())
					{
						num = (short)1584332802;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num5)
							{
							case 0:
								goto IL_135;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)544342020;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding> list = enumerator.Current;
								num4 += list.Count;
								num = (short)1558052867;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_C0;
								}
								continue;
							case 4:
								num = (short)817758208;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_E9:
							num = (short)217776129;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_C0:
							goto IL_E9;
						}
						IL_135:;
					}
					break;
				}
				}
				num = (short)1921384449;
				if (num != 0)
				{
				}
				return num4;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00004B54 File Offset: 0x00002D54
		public bool IsReadOnly
		{
			get
			{
				short num = (short)618620368;
				short num2 = num;
				num = (short)1888314832;
				switch (num2 == num)
				{
				}
				num = (short)1451229185;
				if (num != 0)
				{
				}
				num = (short)1398931456;
				if (num != 0)
				{
				}
				num = (short)1182531584;
				short num3 = num;
				return false;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004C04 File Offset: 0x00002E04
		public bool Remove(global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding item)
		{
			short num = (short)689963009;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					goto IL_15;
				case 2:
					return false;
				case 3:
				{
					num = (short)1146043732;
					short num3 = num;
					num = (short)170212692;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)64618497;
						if (num != 0)
						{
						}
						num = (short)1218117632;
						if (num != 0)
						{
						}
						if (!this.a.TryGetValue(item.ColumnName, out list))
						{
							num = (short)902561792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134;
					}
					break;
				}
				}
				goto IL_35;
				IL_15:
				switch (0)
				{
				case 0:
					IL_35:
					if (item == null)
					{
						num = (short)1687814144;
						short num4 = num;
						num = (short)1035337730;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)435224579;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			return false;
			IL_134:
			return list.Remove(item);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004D4C File Offset: 0x00002F4C
		public global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding> GetEnumerator()
		{
			short num = (short)750004548;
			short num2 = num;
			num = (short)808134980;
			switch (num2 == num)
			{
			}
			num = (short)1634795521;
			if (num != 0)
			{
			}
			num = (short)559349760;
			if (num != 0)
			{
			}
			num = (short)109051904;
			short num3 = num;
			global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBindingCollection.a a = new global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBindingCollection.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004E00 File Offset: 0x00003000
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)660994119;
			short num2 = num;
			num = (short)660469831;
			switch (num2 == num)
			{
			}
			num = (short)1789132801;
			if (num != 0)
			{
			}
			num = (short)967311360;
			if (num != 0)
			{
			}
			num = (short)917962752;
			short num3 = num;
			return this.GetEnumerator();
		}

		// Token: 0x04000019 RID: 25
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFillerBinding>> a;
	}
}
