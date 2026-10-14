using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000005 RID: 5
	public class ContentSyncer<T>
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00005C54 File Offset: 0x00003E54
		public ContentSyncer(global::Motorola.Common.Communication.IshHandler.IContentHelper<T> helper)
		{
			if (helper == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			this.a = helper;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005C7C File Offset: 0x00003E7C
		public void Excute(global::System.Collections.Generic.IList<T> sourceContent, global::Motorola.Common.Communication.IProgressIndicator progressIndicator)
		{
			short num = (short)1662844928;
			switch (num)
			{
			default:
			{
				num = (short)1109983234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_6B;
					case 1:
						try
						{
							num = (short)152895503;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IList<T> list;
								double num3;
								global::System.Collections.Generic.IEnumerator<T> enumerator;
								double num4;
								double num5;
								global::System.Collections.Generic.IList<T> list2;
								double num6;
								switch (num2)
								{
								case 0:
									if (progressIndicator != null)
									{
										num = (short)203161604;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_19D;
								case 1:
									num = (short)1176764436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num3 = 0.1 / (double)list.Count;
									goto IL_4B4;
								case 3:
									try
									{
										num = (short)1702821889;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_5C7;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_53D;
												}
												continue;
											case 3:
												num = (short)28049408;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1505099779;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												T content = enumerator.Current;
												this.a.Write(content, new global::Motorola.Common.Communication.IteratedProgressIndicator(progressIndicator, num4));
												num = (short)821690370;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_575:
											num = (short)309395460;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_53D:
											goto IL_575;
										}
										IL_5C7:
										return;
									}
									finally
									{
										num = (short)853999616;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_5FE;
												}
												continue;
											case 1:
												goto IL_636;
											case 2:
												enumerator.Dispose();
												num = (short)154730497;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_5FE:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1524105218;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_636:;
									}
									goto IL_639;
								case 4:
									goto IL_685;
								case 5:
									num = (short)942604289;
									if (num != 0)
									{
									}
									try
									{
										num = (short)780730374;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1082720258;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												T content2 = enumerator.Current;
												this.a.Delete(content2);
												num = (short)954335236;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												num = (short)570425349;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												progressIndicator.IncreaseProcess(num4);
												num5 -= num4;
												num = (short)1908801537;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												if (progressIndicator != null)
												{
													num = (short)1151008771;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 5:
												goto IL_3CB;
											case 6:
												switch (0)
												{
												case 0:
													goto IL_308;
												}
												continue;
											}
											IL_351:
											num = (short)2110062592;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_308:
											goto IL_351;
										}
										IL_3CB:
										goto IL_6DE;
									}
									finally
									{
										num = (short)1000079360;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_403;
												}
												continue;
											case 1:
												goto IL_43B;
											case 2:
												enumerator.Dispose();
												num = (short)1552220161;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_403:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1905786882;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_43B:;
									}
									goto IL_43E;
									IL_6DE:
									num = (short)338362377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (list.Count == 0)
									{
										num = (short)556007438;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_23F;
								case 7:
									num6 = num5 / (double)list2.Count;
									goto IL_48F;
								case 8:
									num = (short)1549729799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (list2.Count != 0)
									{
										num = (short)1275265032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)564461586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (list.Count != 0)
									{
										num = (short)847511565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1782644753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									if (list2.Count == 0)
									{
										num = (short)668598273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_23F;
								case 12:
									goto IL_19D;
								case 13:
									num = (short)455344130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)1175322635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									switch (0)
									{
									case 0:
										goto IL_114;
									}
									continue;
								case 16:
									goto IL_639;
								case 17:
									num3 = 0.1;
									goto IL_4B4;
								case 18:
									num6 = num5;
									goto IL_48F;
								case 19:
								{
									num = (short)885783003;
									short num7 = num;
									num = (short)1665006043;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_685;
									default:
										num = (short)1486618624;
										if (num != 0)
										{
										}
										goto IL_43E;
									}
									break;
								}
								case 20:
									goto IL_198;
								}
								IL_114:
								if (progressIndicator != null)
								{
									num = (short)2094268435;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_639;
								IL_19D:
								global::System.Collections.Generic.IList<T> a_;
								this.a(sourceContent, a_, out list, out list2);
								num = (short)44892166;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_23F:
								this.a.PreSync();
								num = (short)1724383242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_43E:
								progressIndicator.UpdateProgress(0.0);
								num = (short)491061264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_48F:
								num4 = num6;
								enumerator = list2.GetEnumerator();
								num = (short)679804931;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4B4:
								num4 = num3;
								enumerator = list.GetEnumerator();
								num = (short)59637765;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_639:
								a_ = this.a.ListCurrent();
								num5 = 1.0;
								num = (short)140574720;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_685:
								progressIndicator.IncreaseProcess(0.1);
								num5 -= 0.1;
								num = (short)1055588364;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_198:
							return;
						}
						finally
						{
							num = (short)1618542592;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_74F;
									}
									continue;
								case 1:
									goto IL_78D;
								case 2:
									progressIndicator.UpdateProgress(1.0);
									num = (short)1030356993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_74F:
								if (progressIndicator == null)
								{
									break;
								}
								num = (short)78053378;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_78D:;
						}
						goto IL_790;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_4F;
						}
						continue;
					}
					IL_4F:
					if (sourceContent == null)
					{
						num = (short)95289344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_790:
					num = (short)213712897;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6B:
				num = (short)1854210048;
				short num8 = num;
				return;
			}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00006484 File Offset: 0x00004684
		private void a(global::System.Collections.Generic.IList<T> A_0, global::System.Collections.Generic.IList<T> A_1, out global::System.Collections.Generic.IList<T> A_2, out global::System.Collections.Generic.IList<T> A_3)
		{
			short num = (short)132055044;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D6;
				case 1:
				{
					if (this.a.DeleteComparer == null)
					{
						num = (short)1582563335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_2 = A_1.Except(A_0, this.a.DeleteComparer).ToList<T>();
					num = (short)58916864;
					short num3 = num;
					num = (short)1919287296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_D4;
				case 3:
					if (this.a.WriteComparer == null)
					{
						num = (short)1291386885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FA;
				case 4:
					num = (short)924188673;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 5:
					goto IL_115;
				case 6:
					goto IL_D6;
				case 7:
					A_2 = A_1.Except(A_0).ToList<T>();
					num = (short)1584463878;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6D:
				if (A_1 == null)
				{
					num = (short)639266238;
					short num4 = num;
					num = (short)390950334;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)951451648;
						if (num != 0)
						{
						}
						num = (short)332660738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
				}
				num = (short)101974017;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D6:
				num = (short)1286406147;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D4:
			A_2 = new global::System.Collections.Generic.List<T>();
			A_3 = A_0;
			return;
			IL_115:
			A_3 = A_0.Except(A_1).ToList<T>();
			return;
			IL_1FA:
			A_3 = A_0.Except(A_1, this.a.WriteComparer).ToList<T>();
		}

		// Token: 0x04000006 RID: 6
		private global::Motorola.Common.Communication.IshHandler.IContentHelper<T> a;
	}
}
