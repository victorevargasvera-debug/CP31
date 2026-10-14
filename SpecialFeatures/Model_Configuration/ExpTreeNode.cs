using System;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Model_Configuration
{
	// Token: 0x020000B8 RID: 184
	public class ExpTreeNode
	{
		// Token: 0x06000C0F RID: 3087 RVA: 0x00002DF7 File Offset: 0x00000FF7
		public ExpTreeNode()
		{
			this._value = null;
			this._symbol = null;
			this._ndType = global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.InValid;
			this._left = null;
			this._right = null;
		}

		// Token: 0x17000450 RID: 1104
		internal bool this[string sym]
		{
			set
			{
				short num = (short)1204224000;
				short num2 = num;
				num = (short)173348494;
				short num3 = num;
				num = (short)336795278;
				switch (num3 == num)
				{
				}
				num = (short)12582913;
				if (num != 0)
				{
				}
				num = (short)1425211392;
				if (num != 0)
				{
				}
				this.a(sym, value);
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000F6A94 File Offset: 0x000F4C94
		private void a(string A_0, bool A_1)
		{
			short num = (short)1430454275;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this._right != null)
					{
						num = (short)1121910788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					num = (short)1718026250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this._value = A_1;
					num = (short)1481768969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 4:
					this._right.a(A_0, A_1);
					num = (short)743636998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_C1;
				case 6:
					return;
				case 7:
					if (this._left != null)
					{
						num = (short)1566244864;
						short num3 = num;
						num = (short)857276424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C1;
				case 8:
					this._left.a(A_0, A_1);
					num = (short)2036858881;
					if (num != 0)
					{
					}
					num = (short)51249157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_1F1;
				case 10:
					if (A_0 == this._symbol)
					{
						num = (short)793772034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF;
				}
				IL_50:
				num = (short)1059321189;
				short num4 = num;
				num = (short)958854501;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1F1:
					goto IL_FF;
				default:
					num = (short)2053111808;
					if (num != 0)
					{
					}
					if (this._ndType == global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Symbol)
					{
						num = (short)981467137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FF;
				}
				IL_C1:
				num = (short)893714432;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FF:
				num = (short)1542979591;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000F6CE8 File Offset: 0x000F4EE8
		internal bool ValidateExpTree()
		{
			int a_ = 19;
			short num = (short)1579941888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				bool flag;
				bool flag2;
				global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType ndType;
				bool flag3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_315;
					case 1:
						goto IL_315;
					case 2:
						num = (short)558104577;
						if (num != 0)
						{
						}
						if (this._value == null)
						{
							num = (short)1701576709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)1375862785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this._value == null)
						{
							num = (short)1963458564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)665976848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_407;
					case 5:
						goto IL_227;
					case 6:
						if (this._left != null)
						{
							num = (short)857800718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22C;
					case 7:
					{
						num = (short)2083782656;
						short num3 = num;
						num = (short)1744044045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (this._left != null)
						{
							num = (short)1377763346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_260;
					case 9:
						flag2 = this._right.ValidateExpTree();
						num = (short)1823866897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_517;
					case 11:
						if (this._right != null)
						{
							num = (short)747110409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51C;
					case 12:
						goto IL_260;
					case 13:
						goto IL_315;
					case 14:
						num = (short)673251347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						switch (ndType)
						{
						case global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Literal:
							num = (short)1196818434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Symbol:
							num = (short)639041556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Operator:
							num = (short)1346568198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.Function:
							goto IL_315;
						case global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType.InValid:
							goto IL_4A7;
						default:
							num = (short)91619335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 16:
						goto IL_315;
					case 17:
						goto IL_3C6;
					case 18:
						flag3 = this._left.ValidateExpTree();
						num = (short)585760780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (this._right == null)
						{
							num = (short)924057610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)229965824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (this._symbol.ToLower().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
						{
							num = (short)2101411862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CB;
					case 21:
						goto IL_3CB;
					case 22:
						this._value = false;
						num = (short)1442775061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93;
					IL_260:
					num = (short)960561163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_315:
					num = (short)317756534;
					short num4 = num;
					num = (short)577148022;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3C6;
					default:
						num = (short)144769024;
						if (num != 0)
						{
						}
						num = (short)961085448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3CB:
					num = (short)875757571;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_227:
				global::SpecialFeatures.Model_Configuration.ErrorException ex = new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda95鍊솟캡蒣", a_) + this._value.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚕벛ﾝ풟芡춣좥\udea7쮩삫잭풯銱쒳\udab5\ud9b7\ud9b9\ud9bb", a_));
				flag = false;
				throw ex;
				IL_22C:
				global::SpecialFeatures.Model_Configuration.ErrorException ex2 = new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud995ﾙﾝ풟춡횣蚥", a_) + this._value.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚕뺝솟횡蒣횥\udaa7얩\udcab쮭슯銱\udab5\ud9b7\ud9b9\ud9bb", a_));
				flag = false;
				throw ex2;
				IL_3C6:
				goto IL_51C;
				IL_407:
				global::SpecialFeatures.Model_Configuration.ErrorException ex3 = new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쎕힟첡蒣톧잩캫솭\udcaf銱", a_) + this._symbol);
				flag = false;
				throw ex3;
				IL_4A7:
				global::SpecialFeatures.Model_Configuration.ErrorException ex4 = new global::SpecialFeatures.Model_Configuration.ErrorException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud995ﾙﾝ풟춡횣蚥", a_) + this._value.ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚕뺝솟횡蒣횥\udaa7얩\udcab쮭슯銱\udab5\ud9b7\ud9b9\ud9bb", a_));
				flag = false;
				throw ex4;
				IL_517:
				goto IL_22C;
				IL_51C:
				return flag3 && flag2 && flag;
				IL_93:
				flag = false;
				flag3 = false;
				flag2 = false;
				ndType = this._ndType;
				num = (short)151977999;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x040005BA RID: 1466
		public const object INVALID = null;

		// Token: 0x040005BB RID: 1467
		internal object _value;

		// Token: 0x040005BC RID: 1468
		internal string _symbol;

		// Token: 0x040005BD RID: 1469
		internal global::SpecialFeatures.Model_Configuration.ExpTreeNode.NodeType _ndType;

		// Token: 0x040005BE RID: 1470
		internal global::SpecialFeatures.Model_Configuration.ExpTreeNode _left;

		// Token: 0x040005BF RID: 1471
		internal global::SpecialFeatures.Model_Configuration.ExpTreeNode _right;

		// Token: 0x020000B9 RID: 185
		public enum NodeType
		{
			// Token: 0x040005C1 RID: 1473
			Literal,
			// Token: 0x040005C2 RID: 1474
			Symbol,
			// Token: 0x040005C3 RID: 1475
			Operator,
			// Token: 0x040005C4 RID: 1476
			Function,
			// Token: 0x040005C5 RID: 1477
			InValid
		}
	}
}
