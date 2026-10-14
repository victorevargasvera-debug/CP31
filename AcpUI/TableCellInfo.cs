using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Windows.DataPresenter;

namespace AcpUI
{
	// Token: 0x02000048 RID: 72
	internal class TableCellInfo
	{
		// Token: 0x06000403 RID: 1027 RVA: 0x00044C04 File Offset: 0x00042E04
		internal TableCellInfo(string A_0, int A_1)
		{
			this.a = A_0;
			this.b = A_1;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00044C28 File Offset: 0x00042E28
		internal string ColumnName
		{
			get
			{
				short num = (short)197335942;
				short num2 = num;
				num = (short)700652422;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1421737984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1471676417;
				if (num != 0)
				{
				}
				num = (short)434962432;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00044CD4 File Offset: 0x00042ED4
		internal int Index
		{
			get
			{
				short num = (short)1787691009;
				if (num != 0)
				{
				}
				num = (short)1958543360;
				short num2 = num;
				num = (short)1848626443;
				short num3 = num;
				num = (short)941870347;
				switch (num3 == num)
				{
				}
				num = (short)90046464;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00044D84 File Offset: 0x00042F84
		internal static global::System.Windows.UIElement a(global::Infragistics.Windows.DataPresenter.Cell A_0)
		{
			short num = (short)1160708096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)277217281;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
				global::System.Windows.UIElement result;
				for (;;)
				{
					IL_4F:
					switch (num2)
					{
					case 0:
						goto IL_B3;
					case 1:
						goto IL_99;
					case 2:
						if (cellValuePresenter != null)
						{
							num = (short)1489633281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = null;
						num = (short)1007943680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62;
				}
				IL_99:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_E9;
					}
					global::System.Windows.Controls.Panel panel;
					for (;;)
					{
						IL_C2:
						switch (num2)
						{
						case 0:
						{
							global::System.Windows.Controls.ContentPresenter contentPresenter;
							if (contentPresenter != null)
							{
								num = (short)1160511489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_389;
						}
						case 1:
						{
							global::System.Windows.Controls.ContentPresenter contentPresenter;
							result = (global::System.Windows.Media.VisualTreeHelper.GetChild(contentPresenter, 0) as global::System.Windows.UIElement);
							num = (short)1527316484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_3A2;
						case 3:
							goto IL_389;
						case 4:
							goto IL_389;
						case 5:
						{
							global::System.Windows.Controls.ContentPresenter contentPresenter = null;
							global::System.Collections.IEnumerator enumerator = panel.Children.GetEnumerator();
							num = (short)1638006790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							try
							{
								num = (short)1267662853;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_30D;
									case 2:
									{
										global::System.Windows.Controls.ContentPresenter contentPresenter;
										if (contentPresenter != null)
										{
											goto IL_2F5;
										}
										num = (short)187088151;
										short num3 = num;
										num = (short)2055453975;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_30D;
										default:
											num = (short)1537802240;
											if (num != 0)
											{
											}
											num = (short)406650881;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1748369412;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Controls.ContentPresenter contentPresenter = ((global::System.Windows.UIElement)enumerator.Current) as global::System.Windows.Controls.ContentPresenter;
										num = (short)2061172738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_2F5;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_222;
										}
										continue;
									}
									IL_224:
									num = (short)2124087299;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_222:
									goto IL_224;
									IL_2F5:
									num = (short)1626472448;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_30D:
								goto IL_17D;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_32F;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_31C:
									switch (num2)
									{
									case 0:
										goto IL_386;
									case 1:
										disposable.Dispose();
										num = (short)146407424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										if (disposable != null)
										{
											num = (short)1281884161;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_388;
									}
									goto IL_32F;
								}
								IL_386:
								IL_388:
								goto EndFinally_11;
								IL_32F:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1882587138;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_31C;
								EndFinally_11:;
							}
							goto IL_389;
							IL_17D:
							num = (short)794296320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (panel != null)
							{
								num = (short)1069350917;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = (global::System.Windows.Media.VisualTreeHelper.GetChild(cellValuePresenter, 0) as global::System.Windows.UIElement);
							num = (short)1136787459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E9;
						IL_389:
						num = (short)243269634;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3A2:
					goto IL_3A9;
					IL_E9:
					panel = (global::System.Windows.Media.VisualTreeHelper.GetChild(cellValuePresenter, 0) as global::System.Windows.Controls.Panel);
					num = (short)1655308295;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_C2;
				}
				catch
				{
					result = null;
				}
				IL_B3:
				IL_3A9:
				num = (short)1180631040;
				short num4 = num;
				return result;
				IL_62:
				result = null;
				cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(A_0);
				num = (short)1091698690;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x0400024D RID: 589
		private string a;

		// Token: 0x0400024E RID: 590
		private int b;
	}
}
