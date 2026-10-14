using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;
using DevComponents.WpfEditors.Themes;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000019 RID: 25
	public static class EditColors
	{
		// Token: 0x060001BF RID: 447 RVA: 0x00022738 File Offset: 0x00020938
		public static void ChangeColorScheme(global::DevComponents.WpfEditors.eEditorsVisualStyle colorTable)
		{
			short num = (short)1621295104;
			short num2 = num;
			num = (short)1535377409;
			if (num != 0)
			{
			}
			num = (short)1591696882;
			short num3 = num;
			num = (short)1541823986;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)78970880;
				if (num != 0)
				{
				}
				if (global::System.Windows.Application.Current == null)
				{
					return;
				}
				break;
			}
			global::DevComponents.WpfEditors.EditColors.ChangeColorScheme(colorTable, global::System.Windows.Application.Current.Resources);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000227FC File Offset: 0x000209FC
		public static void ChangeColorScheme(global::DevComponents.WpfEditors.eEditorsVisualStyle colorTable, global::System.Windows.ResourceDictionary parentDictionary)
		{
			short num = (short)1938660479;
			short num2 = num;
			num = (short)1566809215;
			switch (num2 == num)
			{
			}
			num = (short)992215041;
			if (num != 0)
			{
			}
			num = (short)1658650624;
			if (num != 0)
			{
			}
			num = (short)1140391936;
			short num3 = num;
			global::DevComponents.WpfEditors.EditColors.a(global::DevComponents.WpfEditors.EditColors.a(colorTable), parentDictionary);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x000228B0 File Offset: 0x00020AB0
		public static void ChangeColorScheme(global::DevComponents.WpfEditors.eEditorsVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			short num = (short)299499520;
			short num2 = num;
			num = (short)1796261868;
			short num3 = num;
			num = (short)1290979308;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1305477120;
				if (num != 0)
				{
				}
				num = (short)1458962433;
				if (num != 0)
				{
				}
				if (global::System.Windows.Application.Current == null)
				{
					return;
				}
				break;
			}
			global::DevComponents.WpfEditors.EditColors.ChangeColorScheme(baseColorTable, baseColor, global::System.Windows.Application.Current.Resources);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00022974 File Offset: 0x00020B74
		public static void ChangeColorScheme(global::DevComponents.WpfEditors.eEditorsVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor, global::System.Windows.ResourceDictionary parent)
		{
			short num = (short)1970864129;
			if (num != 0)
			{
			}
			num = (short)1498601532;
			short num2 = num;
			num = (short)1278466108;
			switch (num2 == num)
			{
			}
			num = (short)496893952;
			if (num != 0)
			{
			}
			num = (short)26476544;
			short num3 = num;
			global::DevComponents.WpfEditors.EditColors.a(global::DevComponents.WpfEditors.EditColors.CreateColorScheme(baseColorTable, baseColor), parent);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00022A2C File Offset: 0x00020C2C
		public static global::System.Windows.ResourceDictionary CreateColorScheme(global::DevComponents.WpfEditors.eEditorsVisualStyle baseColorTable, global::System.Windows.Media.Color baseColor)
		{
			short num = (short)66027473;
			short num2 = num;
			num = (short)385056721;
			switch (num2 == num)
			{
			}
			num = (short)847052800;
			if (num != 0)
			{
			}
			num = (short)261816321;
			if (num != 0)
			{
			}
			num = (short)247398400;
			short num3 = num;
			return global::DevComponents.WpfEditors.EditColors.a(global::DevComponents.WpfEditors.EditColors.a(baseColorTable), baseColor);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00022AE4 File Offset: 0x00020CE4
		private static void a(global::System.Windows.ResourceDictionary A_0, global::System.Windows.ResourceDictionary A_1)
		{
			global::System.Collections.Generic.IEnumerator<global::System.Windows.ResourceDictionary> enumerator = A_1.MergedDictionaries.GetEnumerator();
			short num;
			try
			{
				num = (short)1421869062;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.ResourceDictionary resourceDictionary;
					switch (num2)
					{
					case 0:
						if (!(resourceDictionary is global::DevComponents.WpfEditors.Themes.Office2007BlueSkin))
						{
							num = (short)660537351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 1:
						if (!(resourceDictionary is global::DevComponents.WpfEditors.Themes.Office2007PoliceSkin))
						{
							num = (short)113311752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 2:
						if (!(resourceDictionary is global::DevComponents.WpfEditors.Themes.Office2007SilverSkin))
						{
							num = (short)363200522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 3:
						num = (short)820248591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_E5;
					case 5:
						if (!(resourceDictionary is global::DevComponents.WpfEditors.Themes.Office2007BlackSkin))
						{
							num = (short)1241317394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					case 7:
						num = (short)660930561;
						if (num != 0)
						{
						}
						num = (short)1423441922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1576599566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_109;
					case 10:
						num = (short)1162280961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)738394129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!enumerator.MoveNext())
						{
							num = (short)1791819779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						resourceDictionary = enumerator.Current;
						num = (short)1531183109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (resourceDictionary is global::DevComponents.WpfEditors.Themes.Office2007FullColorSkin)
						{
							num = (short)1396768772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 14:
						if (!(resourceDictionary is global::DevComponents.WpfEditors.Themes.Office2007FiremanSkin))
						{
							num = (short)345047051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 15:
						goto IL_2DA;
					case 16:
						num = (short)1052573709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (!(resourceDictionary is global::DevComponents.WpfEditors.Themes.Office2007MilitarySkin))
						{
							num = (short)819134480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5;
					case 18:
						num = (short)697892864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F;
					IL_E5:
					A_1.MergedDictionaries.Remove(resourceDictionary);
					num = (short)132055049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D:
					num = (short)1576534028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F:
					goto IL_18D;
				}
				IL_109:
				IL_2DA:;
			}
			finally
			{
				num = (short)944765446;
				short num3 = num;
				num = (short)1589115398;
				int num2;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_33D:
					switch (0)
					{
					case 0:
						goto IL_359;
					}
					break;
				default:
					num = (short)257622016;
					if (num != 0)
					{
					}
					num = (short)1858797570;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					IL_347:
					switch (num2)
					{
					case 0:
						goto IL_38D;
					case 1:
						enumerator.Dispose();
						num = (short)725155840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_33D;
					}
					goto IL_359;
				}
				IL_38D:
				goto IL_38F;
				IL_359:
				if (enumerator != null)
				{
					num = (short)703070209;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_347;
				}
				IL_38F:;
			}
			num = (short)1765867520;
			short num4 = num;
			A_1.MergedDictionaries.Add(A_0);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00022ED4 File Offset: 0x000210D4
		private static global::System.Windows.ResourceDictionary a(global::DevComponents.WpfEditors.eEditorsVisualStyle A_0)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			int num;
			global::System.Windows.ResourceDictionary result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					result = new global::DevComponents.WpfEditors.Themes.Office2007FullColorSkin();
					num2 = (short)718798856;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_110;
				case 2:
					return result;
				case 3:
					num2 = (short)1899495425;
					if (num2 != 0)
					{
					}
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2007Blue)
					{
						num2 = (short)2063663113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1096482845;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2010Silver)
					{
						num2 = (short)1715863572;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1379270683;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_EE;
				case 6:
					result = new global::DevComponents.WpfEditors.Themes.Office2010BlueSkin();
					num2 = (short)1295450113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2010Black)
					{
						num2 = (short)1094320141;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)938016772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_263;
				case 9:
					result = new global::DevComponents.WpfEditors.Themes.Office2007BlueSkin();
					num2 = (short)913309706;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_206;
				case 11:
					goto IL_2C0;
				case 12:
					result = new global::DevComponents.WpfEditors.Themes.Office2007SilverSkin();
					num2 = (short)763559947;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					result = new global::DevComponents.WpfEditors.Themes.Office2010BlackSkin();
					num2 = (short)311296025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					result = new global::DevComponents.WpfEditors.Themes.Office2007PoliceSkin();
					num2 = (short)355991576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					result = new global::DevComponents.WpfEditors.Themes.Office2007BlackSkin();
					num2 = (short)586874882;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					return result;
				case 17:
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2007Police)
					{
						num2 = (short)117571598;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)197263383;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2007Black)
					{
						num2 = (short)1646395407;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1033371651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2007Fireman)
					{
						num2 = (short)1600061462;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)65536026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					result = new global::DevComponents.WpfEditors.Themes.Office2010SilverSkin();
					num2 = (short)1750007824;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					result = new global::DevComponents.WpfEditors.Themes.Office2007MilitarySkin();
					num2 = (short)531431429;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
				{
					num2 = (short)862825584;
					short num3 = num2;
					num2 = (short)1685630064;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_375;
					default:
						num2 = (short)751108096;
						if (num2 != 0)
						{
						}
						result = new global::DevComponents.WpfEditors.Themes.Office2007FiremanSkin();
						num2 = (short)368508956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 23:
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2007Military)
					{
						num2 = (short)2039808021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1946550291;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					return result;
				case 25:
					return result;
				case 26:
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2007FullColor)
					{
						num2 = (short)1553268736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_301;
				case 27:
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2010Blue)
					{
						num2 = (short)1621557254;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2007498769;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					goto IL_1E4;
				case 29:
				{
					num2 = (short)1751187456;
					short num4 = num2;
					if (A_0 == global::DevComponents.WpfEditors.eEditorsVisualStyle.Office2007Silver)
					{
						num2 = (short)1670709260;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_375;
				}
				}
				goto IL_91;
				IL_375:
				num2 = (short)688193543;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EE:
			IL_110:
			IL_1E4:
			IL_206:
			IL_263:
			IL_2C0:
			return result;
			IL_301:
			throw new global::System.ComponentModel.InvalidEnumArgumentException(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛ﻝ铟菡蛣諥跧쫩苫臭蓯틱髳駵賷\udaf9軻鯽揿洁挃栅愇瀉椋樍", a_));
			IL_91:
			result = null;
			num2 = (short)184352786;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000233C8 File Offset: 0x000215C8
		private static global::System.Windows.ResourceDictionary a(global::System.Windows.ResourceDictionary A_0, global::System.Windows.Media.Color A_1)
		{
			short num = (short)995753985;
			if (num != 0)
			{
			}
			num = (short)401539072;
			short num2 = num;
			num = (short)2133524480;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::DevComponents.WpfEditors.a a = global::DevComponents.WpfEditors.EditColors.a(A_1);
				global::System.Collections.IEnumerator enumerator = A_0.Keys.GetEnumerator();
				try
				{
					num = (short)223084545;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_49A;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DE;
							}
							continue;
						case 2:
							goto IL_363;
							try
							{
								for (;;)
								{
									IL_363:
									num = (short)1194917892;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											num = (short)303038467;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
										{
											global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)762839040;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Windows.Media.GradientStop gradientStop = enumerator2.Current;
											gradientStop.Color = a.d(gradientStop.Color);
											num = (short)457179138;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											goto IL_425;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_39D;
											}
											continue;
										}
										IL_3D3:
										num = (short)596705281;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_39D:
										goto IL_3D3;
									}
									IL_425:
									num = (short)745488016;
									short num4 = num;
									num = (short)609894032;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_459;
									}
								}
								IL_459:
								num = (short)1433075712;
								if (num != 0)
								{
								}
								break;
							}
							finally
							{
								global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_481;
						case 3:
						{
							object obj;
							global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2 = (obj as global::System.Windows.Media.RadialGradientBrush).GradientStops.GetEnumerator();
							num = (short)1583153162;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_481;
						case 6:
						{
							object obj;
							global::System.Windows.Media.SolidColorBrush solidColorBrush = obj as global::System.Windows.Media.SolidColorBrush;
							solidColorBrush.Color = a.d(solidColorBrush.Color);
							num = (short)678756357;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							object obj;
							if (obj is global::System.Windows.Media.RadialGradientBrush)
							{
								num = (short)892272643;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							object obj;
							if (obj is global::System.Windows.Media.SolidColorBrush)
							{
								num = (short)347602950;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1362362380;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)865599492;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj2 = enumerator.Current;
							object obj = null;
							global::System.Windows.ComponentResourceKey componentResourceKey = obj2 as global::System.Windows.ComponentResourceKey;
							obj = A_0[obj2];
							num = (short)1033699336;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							try
							{
								num = (short)877854724;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)1287585795;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1836253184;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Windows.Media.GradientStop gradientStop2 = enumerator2.Current;
										gradientStop2.Color = a.d(gradientStop2.Color);
										num = (short)1918304258;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_2B7;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_230;
										}
										continue;
									}
									IL_266:
									num = (short)1691746305;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_230:
									goto IL_266;
								}
								IL_2B7:
								break;
							}
							finally
							{
								global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2;
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_2CA;
						case 11:
						{
							object obj;
							global::System.Windows.Media.GradientStopCollection.Enumerator enumerator2 = (obj as global::System.Windows.Media.LinearGradientBrush).GradientStops.GetEnumerator();
							num = (short)1735065602;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							object obj;
							if (obj is global::System.Windows.Media.LinearGradientBrush)
							{
								num = (short)1810497547;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CA;
						}
						}
						IL_184:
						num = (short)1866792969;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_DE:
						goto IL_184;
						IL_2CA:
						num = (short)211222535;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_481:
						num = (short)1856438272;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_49A:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_4B9;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_4A6:
						switch (num3)
						{
						case 0:
							disposable.Dispose();
							num = (short)1566900225;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_50E;
						case 2:
							if (disposable != null)
							{
								num = (short)1884422144;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_510;
						}
						goto IL_4B9;
					}
					IL_50E:
					IL_510:
					goto EndFinally_16;
					IL_4B9:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)2124808194;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_4A6;
					EndFinally_16:;
				}
				return A_0;
			}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00023934 File Offset: 0x00021B34
		private static global::DevComponents.WpfEditors.a a(global::System.Windows.Media.Color A_0)
		{
			short num = (short)1076297729;
			if (num != 0)
			{
			}
			num = (short)870446190;
			short num2 = num;
			num = (short)600044654;
			switch (num2 == num)
			{
			}
			num = (short)1558970368;
			short num3 = num;
			num = (short)806551552;
			if (num != 0)
			{
			}
			return new global::DevComponents.WpfEditors.b(A_0);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000239E4 File Offset: 0x00021BE4
		// Note: this type is marked as 'beforefieldinit'.
		static EditColors()
		{
			int a_ = 7;
			short num = (short)404861998;
			short num2 = num;
			num = (short)33862702;
			switch (num2 == num)
			{
			}
			num = (short)1866465280;
			if (num != 0)
			{
			}
			num = (short)452067328;
			short num3 = num;
			num = (short)133365761;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.EditColors.ButtonClass = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("雓ꏕ곗껙돛냝", a_);
			global::DevComponents.WpfEditors.EditColors.CheckBoxClass = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓뻕뷗맙럛鳝迟髡", a_);
			global::DevComponents.WpfEditors.EditColors.MonthCalendarClass = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓맕뛗껙듛鷝臟軡臣裥賧诩黫", a_);
			global::DevComponents.WpfEditors.EditColors.TabNavigationClass = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗铙뷛꣝觟藡藣鋥臧藩苫", a_);
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗駙냛뇝鏟蟡ꛣ鏥鳧黩菫胭", a_);
			global::DevComponents.WpfEditors.EditColors.EditBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("釓닕뇗껙黛뇝鋟蛡臣铥", a_);
			global::DevComponents.WpfEditors.EditColors.RibbonEditBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛓뿕뫗룙돛냝ꗟ蛡跣鋥ꫧ藩黫諭闯胱", a_);
			global::DevComponents.WpfEditors.EditColors.RibbonEditBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛓뿕뫗룙돛냝ꗟ蛡跣鋥ꫧ诩迫藭韯胱鯳菵雷黹", a_);
			global::DevComponents.WpfEditors.EditColors.ButtonNormalBackground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Normal + global::DevComponents.WpfEditors.ButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.ButtonNormalForeground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Normal + global::DevComponents.WpfEditors.ButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.ButtonNormalBorder = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Normal + global::DevComponents.WpfEditors.ButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.ButtonNormalBorderInner = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Normal + global::DevComponents.WpfEditors.ButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.ButtonDisabledBackground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Disabled + global::DevComponents.WpfEditors.ButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.ButtonDisabledForeground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Disabled + global::DevComponents.WpfEditors.ButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.ButtonDisabledBorder = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Disabled + global::DevComponents.WpfEditors.ButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.ButtonDisabledBorderInner = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Disabled + global::DevComponents.WpfEditors.ButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.ButtonHoverBackground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Hover + global::DevComponents.WpfEditors.ButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.ButtonHoverForeground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Hover + global::DevComponents.WpfEditors.ButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.ButtonHoverBorder = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Hover + global::DevComponents.WpfEditors.ButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.ButtonHoverBorderInner = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Hover + global::DevComponents.WpfEditors.ButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.ButtonPressedBackground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Pressed + global::DevComponents.WpfEditors.ButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.ButtonPressedForeground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Pressed + global::DevComponents.WpfEditors.ButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.ButtonPressedBorder = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Pressed + global::DevComponents.WpfEditors.ButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.ButtonPressedBorderInner = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Pressed + global::DevComponents.WpfEditors.ButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.ButtonCheckedBackground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Checked + global::DevComponents.WpfEditors.ButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.ButtonCheckedForeground = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Checked + global::DevComponents.WpfEditors.ButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.ButtonCheckedBorder = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Checked + global::DevComponents.WpfEditors.ButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.ButtonCheckedBorderInner = global::DevComponents.WpfEditors.EditColors.ButtonClass + global::DevComponents.WpfEditors.ButtonStateKeys.Checked + global::DevComponents.WpfEditors.ButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxNormalBackground = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Normal + global::DevComponents.WpfEditors.CheckBoxPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.CheckBoxNormalBackgroundInner = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Normal + global::DevComponents.WpfEditors.CheckBoxPartKeys.BackgroundInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxNormalForeground = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Normal + global::DevComponents.WpfEditors.CheckBoxPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.CheckBoxNormalBorder = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Normal + global::DevComponents.WpfEditors.CheckBoxPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.CheckBoxNormalBorderInner = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Normal + global::DevComponents.WpfEditors.CheckBoxPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxNormalCheckMark = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Normal + global::DevComponents.WpfEditors.CheckBoxPartKeys.CheckMark;
			global::DevComponents.WpfEditors.EditColors.CheckBoxHoverBackground = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Hover + global::DevComponents.WpfEditors.CheckBoxPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.CheckBoxHoverBackgroundInner = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Hover + global::DevComponents.WpfEditors.CheckBoxPartKeys.BackgroundInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxHoverForeground = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Hover + global::DevComponents.WpfEditors.CheckBoxPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.CheckBoxHoverBorder = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Hover + global::DevComponents.WpfEditors.CheckBoxPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.CheckBoxHoverBorderInner = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Hover + global::DevComponents.WpfEditors.CheckBoxPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxHoverCheckMark = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Hover + global::DevComponents.WpfEditors.CheckBoxPartKeys.CheckMark;
			global::DevComponents.WpfEditors.EditColors.CheckBoxDisabledBackground = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Disabled + global::DevComponents.WpfEditors.CheckBoxPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.CheckBoxDisabledBackgroundInner = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Disabled + global::DevComponents.WpfEditors.CheckBoxPartKeys.BackgroundInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxDisabledForeground = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Disabled + global::DevComponents.WpfEditors.CheckBoxPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.CheckBoxDisabledBorder = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Disabled + global::DevComponents.WpfEditors.CheckBoxPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.CheckBoxDisabledBorderInner = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Disabled + global::DevComponents.WpfEditors.CheckBoxPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxDisabledCheckMark = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Disabled + global::DevComponents.WpfEditors.CheckBoxPartKeys.CheckMark;
			global::DevComponents.WpfEditors.EditColors.CheckBoxPressedBackground = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Pressed + global::DevComponents.WpfEditors.CheckBoxPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.CheckBoxPressedBackgroundInner = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Pressed + global::DevComponents.WpfEditors.CheckBoxPartKeys.BackgroundInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxPressedForeground = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Pressed + global::DevComponents.WpfEditors.CheckBoxPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.CheckBoxPressedBorder = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Pressed + global::DevComponents.WpfEditors.CheckBoxPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.CheckBoxPressedBorderInner = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Pressed + global::DevComponents.WpfEditors.CheckBoxPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.CheckBoxPressedCheckMark = global::DevComponents.WpfEditors.EditColors.CheckBoxClass + global::DevComponents.WpfEditors.CheckBoxStateKeys.Pressed + global::DevComponents.WpfEditors.CheckBoxPartKeys.CheckMark;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarBackground = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarForeground = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarBorder = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarTodayDateBorder = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.TodayDateBorder;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarTrailingDayForeground = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.TrailingDayForeground;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarDayNameBorder = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.DayNameBorder;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarDayDisabledForeground = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.DayDisabledForeground;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarNavigationBackground = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.NavigationBackground;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarNavigationForeground = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.NavigationForeground;
			global::DevComponents.WpfEditors.EditColors.MonthCalendarWeekBackground = global::DevComponents.WpfEditors.EditColors.MonthCalendarClass + global::DevComponents.WpfEditors.MonthCalendarPartKeys.WeekBackground;
			global::DevComponents.WpfEditors.EditColors.TabNavigationBackground = global::DevComponents.WpfEditors.EditColors.TabNavigationClass + global::DevComponents.WpfEditors.TabNavigationPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.TabNavigationForeground = global::DevComponents.WpfEditors.EditColors.TabNavigationClass + global::DevComponents.WpfEditors.TabNavigationPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.TabNavigationBorder = global::DevComponents.WpfEditors.EditColors.TabNavigationClass + global::DevComponents.WpfEditors.TabNavigationPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.TabNavigationTitleBackground = global::DevComponents.WpfEditors.EditColors.TabNavigationClass + global::DevComponents.WpfEditors.TabNavigationPartKeys.TitleBackground;
			global::DevComponents.WpfEditors.EditColors.TabNavigationTitleForeground = global::DevComponents.WpfEditors.EditColors.TabNavigationClass + global::DevComponents.WpfEditors.TabNavigationPartKeys.TitleForeground;
			global::DevComponents.WpfEditors.EditColors.TabHeaderPanelBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難뛥觧蓩觫苭닯鏱音鷵鿷裹鏻诽滿昁", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderControlForeground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難ꗥ蟧蓩飫鳭鿯黱닳駵諷鿹鯻賽濿省樃戅", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderControlBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難ꗥ蟧蓩飫鳭鿯黱뛳駵諷黹駻賽", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderControlBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難ꗥ蟧蓩飫鳭鿯黱뛳韵鯷釹鯻賽濿省樃戅", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderItemBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難꿥鳧迩臫곭鿯胱郳鏵諷", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderItemBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難꿥鳧迩臫곭釯釱鿳釵諷闹觻都擿", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderItemSelectedBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難꿥鳧迩臫뷭闯黱釳闵賷鿹飻볽懿愁漃愅稇攉礋怍琏", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderItemSelectedMouseOverBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難꿥鳧迩臫뷭闯黱釳闵賷鿹飻돽濿省眃挅䜇簉椋簍刏猑眓紕缗栙猛欝丟䘡", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderItemMouseOverBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難꿥鳧迩臫ꏭ鿯蟱蟳鏵럷賹駻賽䋿持會洅漇砉挋笍縏瘑", a_);
			global::DevComponents.WpfEditors.EditColors.TabHeaderItemForeground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胓럕뫗鋙맛뿝蓟蟡難꿥鳧迩臫꣭鿯胱釳釵諷闹觻都擿", a_);
			global::DevComponents.WpfEditors.EditColors.ColorSwatchBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛距韟菡郣藥胧꣩菫鳭铯韱蛳", a_);
			global::DevComponents.WpfEditors.EditColors.ColorSwatchBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛距韟菡郣藥胧꣩跫跭鯯闱蛳駵跷铹飻", a_);
			global::DevComponents.WpfEditors.EditColors.ColorItemNormalBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛韝铟蟡解꣥蟧飩臫迭鳯냱鯳蓵鳷鿹軻", a_);
			global::DevComponents.WpfEditors.EditColors.ColorItemHoverBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛韝铟蟡解껥蟧鳩觫鳭닯鷱蛳鋵鷷裹", a_);
			global::DevComponents.WpfEditors.EditColors.ColorItemHoverInnerBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛韝铟蟡解껥蟧鳩觫鳭맯鳱髳鏵諷룹鏻賽擿朁瘃", a_);
			global::DevComponents.WpfEditors.EditColors.ColorItemMenuBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛韝铟蟡解뛥蟧髩駫黭닯鷱蛳鋵鷷裹", a_);
			global::DevComponents.WpfEditors.EditColors.ColorItemMenuBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛韝铟蟡解뛥蟧髩駫黭닯鏱音鷵鿷裹鏻诽滿昁", a_);
			global::DevComponents.WpfEditors.EditColors.ColorItemMenuSideBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛韝铟蟡解ꯥ跧蓩駫뷭駯雱釳듵駷駹韻駽狿洁焃栅氇", a_);
			global::DevComponents.WpfEditors.EditColors.ColorItemMenuSideLineDark = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛韝铟蟡解ꯥ跧蓩駫뷭駯雱釳뫵釷铹駻뫽懿瀁漃", a_);
			global::DevComponents.WpfEditors.EditColors.ColorItemMenuSideLineLight = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韓맕듗뗙껛韝铟蟡解ꯥ跧蓩駫뷭駯雱釳뫵釷铹駻닽槿攁氃爅", a_);
			global::DevComponents.WpfEditors.EditColors.MenuHeaderLabelBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙铛믝臟蛡臣铥ꓧ诩軫语鳯냱闳闵鏷鷹軻釽痿氁怃", a_);
			global::DevComponents.WpfEditors.EditColors.MenuHeaderLabelForeground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙铛믝臟蛡臣铥ꓧ诩軫语鳯등鯳蓵鷷鷹軻釽痿氁怃", a_);
			global::DevComponents.WpfEditors.EditColors.MenuHeaderLabelBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙铛믝臟蛡臣铥ꓧ诩軫语鳯냱鯳蓵鳷鿹軻", a_);
			global::DevComponents.WpfEditors.EditColors.MenuSeparatorBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙进믝郟菡難蟥鳧藩黫곭鿯胱郳鏵諷", a_);
			global::DevComponents.WpfEditors.EditColors.MenuSeparatorBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙进믝郟菡難蟥鳧藩黫곭釯釱鿳釵諷闹觻都擿", a_);
			global::DevComponents.WpfEditors.EditColors.MenuItemHoverBackground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙闛ꫝ藟迡곣觥黧迩黫곭釯釱鿳釵諷闹觻都擿", a_);
			global::DevComponents.WpfEditors.EditColors.MenuItemHoverBorder = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙闛ꫝ藟迡곣觥黧迩黫곭鿯胱郳鏵諷", a_);
			global::DevComponents.WpfEditors.EditColors.MenuItemHoverBorderInner = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙闛ꫝ藟迡곣觥黧迩黫곭鿯胱郳鏵諷돹鋻都旿瀁", a_);
			global::DevComponents.WpfEditors.EditColors.MenuItemForeground = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("駓돕뛗꿙闛ꫝ藟迡ꋣ觥髧迩诫鳭鿯蟱髳鋵", a_);
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonActiveBackground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Active + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonActiveBorder = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Active + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonActiveBorderInner = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Active + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonActiveForeground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Active + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonInactiveBackground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Inactive + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonInactiveBorder = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Inactive + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonInactiveBorderInner = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Inactive + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonInactiveForeground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Inactive + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonHoverBackground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Hover + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonHoverBorder = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Hover + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonHoverBorderInner = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Hover + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonHoverForeground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Hover + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonPressedBackground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Pressed + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonPressedBorder = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Pressed + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonPressedBorderInner = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Pressed + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonPressedForeground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Pressed + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Foreground;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonDisabledBackground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Disabled + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Background;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonDisabledBorder = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Disabled + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Border;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonDisabledBorderInner = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Disabled + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.BorderInner;
			global::DevComponents.WpfEditors.EditColors.TabCloseButtonDisabledForeground = global::DevComponents.WpfEditors.EditColors.TabCloseButtonClass + global::DevComponents.WpfEditors.TabCloseButtonStateKeys.Disabled + global::DevComponents.WpfEditors.TabCloseButtonPartKeys.Foreground;
		}

		// Token: 0x04000089 RID: 137
		public static string ButtonClass;

		// Token: 0x0400008A RID: 138
		public static string CheckBoxClass;

		// Token: 0x0400008B RID: 139
		public static string MonthCalendarClass;

		// Token: 0x0400008C RID: 140
		public static string TabNavigationClass;

		// Token: 0x0400008D RID: 141
		public static string TabCloseButtonClass;

		// Token: 0x0400008E RID: 142
		public static string EditBorder;

		// Token: 0x0400008F RID: 143
		public static string RibbonEditBorder;

		// Token: 0x04000090 RID: 144
		public static string RibbonEditBackground;

		// Token: 0x04000091 RID: 145
		public static string ButtonNormalBackground;

		// Token: 0x04000092 RID: 146
		public static string ButtonNormalForeground;

		// Token: 0x04000093 RID: 147
		public static string ButtonNormalBorder;

		// Token: 0x04000094 RID: 148
		public static string ButtonNormalBorderInner;

		// Token: 0x04000095 RID: 149
		public static string ButtonDisabledBackground;

		// Token: 0x04000096 RID: 150
		public static string ButtonDisabledForeground;

		// Token: 0x04000097 RID: 151
		public static string ButtonDisabledBorder;

		// Token: 0x04000098 RID: 152
		public static string ButtonDisabledBorderInner;

		// Token: 0x04000099 RID: 153
		public static string ButtonHoverBackground;

		// Token: 0x0400009A RID: 154
		public static string ButtonHoverForeground;

		// Token: 0x0400009B RID: 155
		public static string ButtonHoverBorder;

		// Token: 0x0400009C RID: 156
		public static string ButtonHoverBorderInner;

		// Token: 0x0400009D RID: 157
		public static string ButtonPressedBackground;

		// Token: 0x0400009E RID: 158
		public static string ButtonPressedForeground;

		// Token: 0x0400009F RID: 159
		public static string ButtonPressedBorder;

		// Token: 0x040000A0 RID: 160
		public static string ButtonPressedBorderInner;

		// Token: 0x040000A1 RID: 161
		public static string ButtonCheckedBackground;

		// Token: 0x040000A2 RID: 162
		public static string ButtonCheckedForeground;

		// Token: 0x040000A3 RID: 163
		public static string ButtonCheckedBorder;

		// Token: 0x040000A4 RID: 164
		public static string ButtonCheckedBorderInner;

		// Token: 0x040000A5 RID: 165
		public static string CheckBoxNormalBackground;

		// Token: 0x040000A6 RID: 166
		public static string CheckBoxNormalBackgroundInner;

		// Token: 0x040000A7 RID: 167
		public static string CheckBoxNormalForeground;

		// Token: 0x040000A8 RID: 168
		public static string CheckBoxNormalBorder;

		// Token: 0x040000A9 RID: 169
		public static string CheckBoxNormalBorderInner;

		// Token: 0x040000AA RID: 170
		public static string CheckBoxNormalCheckMark;

		// Token: 0x040000AB RID: 171
		public static string CheckBoxHoverBackground;

		// Token: 0x040000AC RID: 172
		public static string CheckBoxHoverBackgroundInner;

		// Token: 0x040000AD RID: 173
		public static string CheckBoxHoverForeground;

		// Token: 0x040000AE RID: 174
		public static string CheckBoxHoverBorder;

		// Token: 0x040000AF RID: 175
		public static string CheckBoxHoverBorderInner;

		// Token: 0x040000B0 RID: 176
		public static string CheckBoxHoverCheckMark;

		// Token: 0x040000B1 RID: 177
		public static string CheckBoxDisabledBackground;

		// Token: 0x040000B2 RID: 178
		public static string CheckBoxDisabledBackgroundInner;

		// Token: 0x040000B3 RID: 179
		public static string CheckBoxDisabledForeground;

		// Token: 0x040000B4 RID: 180
		public static string CheckBoxDisabledBorder;

		// Token: 0x040000B5 RID: 181
		public static string CheckBoxDisabledBorderInner;

		// Token: 0x040000B6 RID: 182
		public static string CheckBoxDisabledCheckMark;

		// Token: 0x040000B7 RID: 183
		public static string CheckBoxPressedBackground;

		// Token: 0x040000B8 RID: 184
		public static string CheckBoxPressedBackgroundInner;

		// Token: 0x040000B9 RID: 185
		public static string CheckBoxPressedForeground;

		// Token: 0x040000BA RID: 186
		public static string CheckBoxPressedBorder;

		// Token: 0x040000BB RID: 187
		public static string CheckBoxPressedBorderInner;

		// Token: 0x040000BC RID: 188
		public static string CheckBoxPressedCheckMark;

		// Token: 0x040000BD RID: 189
		public static string MonthCalendarBackground;

		// Token: 0x040000BE RID: 190
		public static string MonthCalendarForeground;

		// Token: 0x040000BF RID: 191
		public static string MonthCalendarBorder;

		// Token: 0x040000C0 RID: 192
		public static string MonthCalendarTodayDateBorder;

		// Token: 0x040000C1 RID: 193
		public static string MonthCalendarTrailingDayForeground;

		// Token: 0x040000C2 RID: 194
		public static string MonthCalendarDayNameBorder;

		// Token: 0x040000C3 RID: 195
		public static string MonthCalendarDayDisabledForeground;

		// Token: 0x040000C4 RID: 196
		public static string MonthCalendarNavigationBackground;

		// Token: 0x040000C5 RID: 197
		public static string MonthCalendarNavigationForeground;

		// Token: 0x040000C6 RID: 198
		public static string MonthCalendarWeekBackground;

		// Token: 0x040000C7 RID: 199
		public static string TabNavigationBackground;

		// Token: 0x040000C8 RID: 200
		public static string TabNavigationForeground;

		// Token: 0x040000C9 RID: 201
		public static string TabNavigationBorder;

		// Token: 0x040000CA RID: 202
		public static string TabNavigationTitleBackground;

		// Token: 0x040000CB RID: 203
		public static string TabNavigationTitleForeground;

		// Token: 0x040000CC RID: 204
		public static string TabHeaderPanelBackground;

		// Token: 0x040000CD RID: 205
		public static string TabHeaderControlForeground;

		// Token: 0x040000CE RID: 206
		public static string TabHeaderControlBorder;

		// Token: 0x040000CF RID: 207
		public static string TabHeaderControlBackground;

		// Token: 0x040000D0 RID: 208
		public static string TabHeaderItemBorder;

		// Token: 0x040000D1 RID: 209
		public static string TabHeaderItemBackground;

		// Token: 0x040000D2 RID: 210
		public static string TabHeaderItemSelectedBackground;

		// Token: 0x040000D3 RID: 211
		public static string TabHeaderItemSelectedMouseOverBackground;

		// Token: 0x040000D4 RID: 212
		public static string TabHeaderItemMouseOverBackground;

		// Token: 0x040000D5 RID: 213
		public static string TabHeaderItemForeground;

		// Token: 0x040000D6 RID: 214
		public static string ColorSwatchBorder;

		// Token: 0x040000D7 RID: 215
		public static string ColorSwatchBackground;

		// Token: 0x040000D8 RID: 216
		public static string ColorItemNormalBorder;

		// Token: 0x040000D9 RID: 217
		public static string ColorItemHoverBorder;

		// Token: 0x040000DA RID: 218
		public static string ColorItemHoverInnerBorder;

		// Token: 0x040000DB RID: 219
		public static string ColorItemMenuBorder;

		// Token: 0x040000DC RID: 220
		public static string ColorItemMenuBackground;

		// Token: 0x040000DD RID: 221
		public static string ColorItemMenuSideBackground;

		// Token: 0x040000DE RID: 222
		public static string ColorItemMenuSideLineDark;

		// Token: 0x040000DF RID: 223
		public static string ColorItemMenuSideLineLight;

		// Token: 0x040000E0 RID: 224
		public static string MenuHeaderLabelBackground;

		// Token: 0x040000E1 RID: 225
		public static string MenuHeaderLabelForeground;

		// Token: 0x040000E2 RID: 226
		public static string MenuHeaderLabelBorder;

		// Token: 0x040000E3 RID: 227
		public static string MenuSeparatorBorder;

		// Token: 0x040000E4 RID: 228
		public static string MenuSeparatorBackground;

		// Token: 0x040000E5 RID: 229
		public static string MenuItemHoverBackground;

		// Token: 0x040000E6 RID: 230
		public static string MenuItemHoverBorder;

		// Token: 0x040000E7 RID: 231
		public static string MenuItemHoverBorderInner;

		// Token: 0x040000E8 RID: 232
		public static string MenuItemForeground;

		// Token: 0x040000E9 RID: 233
		public static string TabCloseButtonActiveBackground;

		// Token: 0x040000EA RID: 234
		public static string TabCloseButtonActiveBorder;

		// Token: 0x040000EB RID: 235
		public static string TabCloseButtonActiveBorderInner;

		// Token: 0x040000EC RID: 236
		public static string TabCloseButtonActiveForeground;

		// Token: 0x040000ED RID: 237
		public static string TabCloseButtonInactiveBackground;

		// Token: 0x040000EE RID: 238
		public static string TabCloseButtonInactiveBorder;

		// Token: 0x040000EF RID: 239
		public static string TabCloseButtonInactiveBorderInner;

		// Token: 0x040000F0 RID: 240
		public static string TabCloseButtonInactiveForeground;

		// Token: 0x040000F1 RID: 241
		public static string TabCloseButtonHoverBackground;

		// Token: 0x040000F2 RID: 242
		public static string TabCloseButtonHoverBorder;

		// Token: 0x040000F3 RID: 243
		public static string TabCloseButtonHoverBorderInner;

		// Token: 0x040000F4 RID: 244
		public static string TabCloseButtonHoverForeground;

		// Token: 0x040000F5 RID: 245
		public static string TabCloseButtonPressedBackground;

		// Token: 0x040000F6 RID: 246
		public static string TabCloseButtonPressedBorder;

		// Token: 0x040000F7 RID: 247
		public static string TabCloseButtonPressedBorderInner;

		// Token: 0x040000F8 RID: 248
		public static string TabCloseButtonPressedForeground;

		// Token: 0x040000F9 RID: 249
		public static string TabCloseButtonDisabledBackground;

		// Token: 0x040000FA RID: 250
		public static string TabCloseButtonDisabledBorder;

		// Token: 0x040000FB RID: 251
		public static string TabCloseButtonDisabledBorderInner;

		// Token: 0x040000FC RID: 252
		public static string TabCloseButtonDisabledForeground;
	}
}
