using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x0200000A RID: 10
	public static class DBNode_Utility
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00004B6C File Offset: 0x00002D6C
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> SpliceForceLoadDBNodeIntoTopNode(global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode, bool NeedRemoveAfterFound = true)
		{
			short num = (short)1682243584;
			switch (num)
			{
			default:
			{
				num = (short)623640576;
				short num2 = num;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Record> list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Record>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = dbnode.ChildNodesList.GetEnumerator())
				{
					num = (short)1877868549;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_752;
						case 1:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
							list2.Add(dbnode2 as global::Motorola.CommonCPS.Server.EntityModel.Record);
							num = (short)250937348;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1211695110;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2 = enumerator.Current;
							goto IL_659;
						}
						case 3:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
							if (dbnode2 is global::Motorola.CommonCPS.Server.EntityModel.Record)
							{
								num = (short)441712641;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_64F;
							}
							continue;
						case 6:
						{
							num = (short)1057578685;
							short num4 = num;
							num = (short)1322999485;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_659;
							default:
								num = (short)1103822848;
								if (num != 0)
								{
								}
								num = (short)499646464;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_64F;
						IL_659:
						num = (short)1965686787;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_68D:
						num = (short)2094661634;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_64F:
						goto IL_68D;
					}
					IL_752:
					goto IL_5D6;
				}
				return list;
				for (;;)
				{
					IL_5D6:
					num = (short)1298268161;
					if (num != 0)
					{
					}
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Record>.Enumerator enumerator2 = list2.GetEnumerator())
					{
						num = (short)211484678;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> list3;
							switch (num3)
							{
							case 0:
								try
								{
									num = (short)1875247114;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator3;
										global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode4;
										switch (num3)
										{
										case 0:
											try
											{
												num = (short)1319305221;
												num3 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num3)
													{
													case 0:
														goto IL_3D6;
													case 1:
														num = (short)1536557056;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													case 2:
													{
														global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3;
														if (dbnode3 is global::Motorola.CommonCPS.Server.EntityModel.Record)
														{
															num = (short)318701574;
															num3 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
													}
													case 3:
													{
														if (!enumerator3.MoveNext())
														{
															num = (short)1224081409;
															num3 = (int)((global::System.IntPtr)num);
															continue;
														}
														global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3 = enumerator3.Current;
														num = (short)431226882;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													case 5:
														switch (0)
														{
														case 0:
															goto IL_31A;
														}
														continue;
													case 6:
													{
														global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3;
														dbnode4.ChildNodesList.Add(dbnode3);
														num = (short)1823670276;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													}
													IL_31C:
													num = (short)80019459;
													num3 = (int)((global::System.IntPtr)num);
													continue;
													IL_31A:
													goto IL_31C;
												}
												IL_3D6:
												break;
											}
											finally
											{
												((global::System.IDisposable)enumerator3).Dispose();
											}
											goto IL_3E9;
										case 1:
											num = (short)236519433;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_3E9;
										case 3:
											goto IL_537;
										case 4:
											if (a2.a is global::Motorola.CommonCPS.Server.EntityModel.RefSet)
											{
												num = (short)697892865;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 5:
											goto IL_492;
										case 6:
											if (dbnode4 == null)
											{
												num = (short)141492235;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_492;
										case 7:
											num = (short)1258684419;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 8:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)590807047;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.Server.EntityModel.DBNode a = enumerator.Current;
											num = (short)789643268;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 9:
											if ((a2.a as global::Motorola.CommonCPS.Server.EntityModel.RefSet).IsForceLoadSet)
											{
												num = (short)17301506;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 10:
											switch (0)
											{
											case 0:
												goto IL_24C;
											}
											continue;
										case 11:
											dbnode4 = new global::Motorola.CommonCPS.Server.EntityModel.RefSet();
											dbnode4.ChildNodesList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>();
											dbnode4.Name = a2.a.Name;
											list.Add(dbnode4);
											num = (short)693174277;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_296:
										num = (short)1390280712;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_24C:
										goto IL_296;
										IL_3E9:
										list3.Add(a2.a);
										dbnode4 = list.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(a2.b)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.DBNode>();
										num = (short)1536753670;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_492:
										enumerator3 = a2.a.ChildNodesList.GetEnumerator();
										num = (short)1133510656;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_537:
									goto IL_1BC;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_54A;
								IL_1BC:
								num = (short)510197762;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								try
								{
									num = (short)718733315;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 1:
											goto IL_16A;
										case 2:
											num = (short)648937473;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											switch (0)
											{
											case 0:
												goto IL_EA;
											}
											continue;
										case 4:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)846135298;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.CommonCPS.Server.EntityModel.DBNode item = enumerator.Current;
											global::Motorola.CommonCPS.Server.EntityModel.Record record;
											record.ChildNodesList.Remove(item);
											num = (short)1887174656;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_11B:
										num = (short)359596036;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_EA:
										goto IL_11B;
									}
									IL_16A:;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								break;
							case 2:
								if (NeedRemoveAfterFound)
								{
									num = (short)205651975;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								goto IL_5C3;
							case 4:
								num = (short)2066284547;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1398865924;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.Record record = enumerator2.Current;
								list3 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>();
								enumerator = record.ChildNodesList.GetEnumerator();
								num = (short)264437760;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_AA;
								}
								continue;
							case 7:
								goto IL_54A;
							}
							IL_17A:
							num = (short)1963393029;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_AA:
							goto IL_17A;
							IL_54A:
							enumerator = list3.GetEnumerator();
							num = (short)1959067649;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_5C3:
						break;
					}
				}
				return list;
			}
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000535C File Offset: 0x0000355C
		public static global::System.Collections.Generic.Dictionary<global::System.Guid, byte[]> GetTimeStamp_of_TopAndForceReferRecord(global::Motorola.CommonCPS.Server.EntityModel.DBNode topDbNode_FromServer)
		{
			short num = (short)2091384832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1241645057;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				global::System.Collections.Generic.Dictionary<global::System.Guid, byte[]> dictionary;
				for (;;)
				{
					IL_4F:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1098252294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> list;
						enumerator = (list[0] as global::Motorola.CommonCPS.Server.EntityModel.RefSet).ChildNodesList.GetEnumerator();
						num = (short)1779040258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)232521731;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1733230596;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = enumerator.Current;
									dictionary[global::System.Guid.Parse((dbnode as global::Motorola.CommonCPS.Server.EntityModel.Record).UUID)] = (dbnode as global::Motorola.CommonCPS.Server.EntityModel.Record).Timestamp;
									num = (short)356646914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_250;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1BA;
									}
									continue;
								case 4:
									num = (short)622329857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1BC:
								num = (short)1011023872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BA:
								goto IL_1BC;
							}
							IL_250:
							return dictionary;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_263;
					case 3:
					{
						try
						{
							num = (short)592904195;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_42A;
								case 2:
								{
									num = (short)26230644;
									short num3 = num;
									num = (short)799620980;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1759576064;
										if (num != 0)
										{
										}
										num = (short)314376193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_34C;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)647299074;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2 = enumerator.Current;
									dictionary[global::System.Guid.Parse((dbnode2 as global::Motorola.CommonCPS.Server.EntityModel.Record).UUID)] = (dbnode2 as global::Motorola.CommonCPS.Server.EntityModel.Record).Timestamp;
									num = (short)189267968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_38E:
								num = (short)2083127300;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34C:
								goto IL_38E;
							}
							IL_42A:
							goto IL_F6;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_43D;
						IL_F6:
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> list = global::Motorola.CommonCPS.Common.CommonUtility.DBNode_Utility.SpliceForceLoadDBNodeIntoTopNode(topDbNode_FromServer, false);
						num = (short)1592786952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> list;
						if (list.Count > 0)
						{
							num = (short)1393491969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					}
					case 5:
					{
						num = (short)225705984;
						short num4 = num;
						if (topDbNode_FromServer.ChildNodesList != null)
						{
							num = (short)589889536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					}
					case 6:
						if (topDbNode_FromServer.ChildNodesList.Count > 0)
						{
							num = (short)1476984843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 7:
						num = (short)374079492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode> list;
						if (list != null)
						{
							num = (short)1419706375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					}
					case 9:
						goto IL_263;
					case 10:
						if (topDbNode_FromServer != null)
						{
							num = (short)576323593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return dictionary;
					case 11:
						goto IL_43D;
					}
					goto IL_86;
					IL_263:
					num = (short)1489305605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43D:
					enumerator = topDbNode_FromServer.ChildNodesList.GetEnumerator();
					num = (short)2048655363;
					num2 = (int)((global::System.IntPtr)num);
				}
				return dictionary;
				IL_86:
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, byte[]>();
				num = (short)1631125514;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x0200000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000033 RID: 51 RVA: 0x00005818 File Offset: 0x00003A18
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0)
			{
				short num = (short)1530658816;
				short num2 = num;
				num = (short)1333178511;
				short num3 = num;
				num = (short)1254076559;
				switch (num3 == num)
				{
				}
				num = (short)1670840321;
				if (num != 0)
				{
				}
				num = (short)427753472;
				if (num != 0)
				{
				}
				return A_0.Name == this.a.Name;
			}

			// Token: 0x04000016 RID: 22
			public global::Motorola.CommonCPS.Server.EntityModel.DBNode a;
		}
	}
}
