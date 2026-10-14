using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using SpecialFeatures.AcpReportManagerLib;
using SSLMangrComp;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000166 RID: 358
	public class FileProxy : global::SpecialFeatures.Comms.IDeviceProxy, global::System.IDisposable
	{
		// Token: 0x06001208 RID: 4616 RVA: 0x00187C80 File Offset: 0x00185E80
		internal FileProxy(string deviceFile, global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo info)
		{
			int a_ = 13;
			base..ctor();
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮏풑ﶓ歹ﶗ쪙\ud89f\udba1念ﶥ쒩쪫솭슯\udfb1햳습톷햹튻鮿胁ꇃꇅꇇ꓉釋闍雏믑룓돕裗꣙돛ꛝ駟쫡蟣鋥蟧飩엫돭", a_));
			this.a = deviceFile;
			this.c = info;
			this.b = this.a(this.a);
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮏풑ﶓ歹ﶗ쪙\ud89f\udba1念ﶥ쒩쪫솭슯\udfb1햳습톷햹튻鮿蟁꫃ꋅ闇釉請ꟍ볏럑蓓ꓕ럗ꋙꗛ菟雡诣铥쇧럩", a_));
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x00187CE4 File Offset: 0x00185EE4
		public global::Motorola.Common.Communication.Pba.PbaObject Read(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator)
		{
			int a_ = 5;
			short num = (short)211519239;
			short num2 = num;
			num = (short)1770686215;
			switch (num2 == num)
			{
			}
			num = (short)1088094208;
			if (num != 0)
			{
			}
			num = (short)1595998209;
			if (num != 0)
			{
			}
			num = (short)1909981184;
			short num3 = num;
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펇첉슑秊솛얝첡슣즥\udaa7잩춫\udaad\ud9af\uddb1\udab3\ud9bb\ud9bdꦿ곁駃鷅髇꿉귋꫍跏", a_));
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펇첉슑秊솛얝첡슣즥\udaa7잩춫\udaad\ud9af\uddb1\udab3ﾹ튻\udabd鶿駁雃ꏅ꧇껉釋", a_));
			return this.b;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x00187DC4 File Offset: 0x00185FC4
		public bool Write(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			int a_ = 9;
			short num = (short)1168630711;
			short num2 = num;
			num = (short)1789322167;
			switch (num2 == num)
			{
			}
			num = (short)1249705985;
			if (num != 0)
			{
			}
			num = (short)568524800;
			if (num != 0)
			{
			}
			num = (short)1810890752;
			short num3 = num;
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힋좍憐ﺑ욕ﶟ說좥캧얩\udeab쎭톯욱\uddb3\ud9b5횷ﲽꖿꗁ귃ꣅ闇釉鯋볍맏ꛑ뇓试", a_));
			this.b = targetPba;
			bool result = this.a(this.b, this.a);
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힋좍憐ﺑ욕ﶟ說좥캧얩\udeab쎭톯욱\uddb3\ud9b5횷﮽꺿ꛁ駃鷅鿇룉ꗋ뫍뗏近", a_));
			return result;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00187EB4 File Offset: 0x001860B4
		public global::SpecialFeatures.Comms.RadioParams ReadExtendedDeviceInfo()
		{
			int a_ = 17;
			short num = (short)1205967559;
			short num2 = num;
			num = (short)592550599;
			switch (num2 == num)
			{
			}
			num = (short)1306329088;
			if (num != 0)
			{
			}
			num = (short)1521811457;
			if (num != 0)
			{
			}
			num = (short)1894449152;
			short num3 = num;
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾓킕鍊캝튟춡\udca3\udfa5삭횯\uddb1욳\udbb5\ud9b7캹햻톽꺿鿁鿃蓅귇귉ꗋꃍ跏觑蛓돕맗뻙駛ꛝ铟蟡諣若跧軩꣫语蛯鯱音鏵뇷铹髻釽巿", a_));
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾓킕鍊캝튟춡\udca3\udfa5삭횯\uddb1욳\udbb5\ud9b7캹햻톽꺿鿁鿃菅ꛇ껉釋闍苏럑뗓닕鷗ꋙ꣛믝軟蛡臣若곧迩髫蟭鏯韱뷳飵黷闹ꇻ", a_));
			return this.c.WrapperRadioParams();
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00187F98 File Offset: 0x00186198
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlock(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> blockList, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			int a_ = 11;
			short num;
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
			for (;;)
			{
				num = (short)150994944;
				switch (num)
				{
				default:
				{
					global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햍횏ﮑ좗\ud99fﾡﾣ욧첩쎫\udcad\uddaf펱삳\udfb5ힷ풹芿ꟁꏃ꿅ꛇ韉韋鳍뗏돑냓铕듗뗙뿛뗝뷟", a_));
					pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
					global::Motorola.Common.Communication.Pba.PbaObject result;
					try
					{
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>.Enumerator enumerator = blockList.GetEnumerator())
						{
							num = (short)2074673152;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator2;
								global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_13A;
									}
									continue;
								case 1:
									try
									{
										num = (short)23658500;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator3;
											global::Motorola.Common.Communication.Pba.DataPartition dataPartition2;
											switch (num2)
											{
											case 0:
												if (!enumerator2.MoveNext())
												{
													num = (short)1384906754;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												dataPartition = enumerator2.Current;
												num = (short)557121548;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_467;
											case 2:
												goto IL_72A;
											case 3:
												try
												{
													num = (short)624295938;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
														switch (num2)
														{
														case 0:
															num = (short)1042350086;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															num = (short)443547651;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_51D;
															}
															continue;
														case 3:
															if (65535 == ishHeader.IshID)
															{
																num = (short)1183055881;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														case 4:
															if (!enumerator3.MoveNext())
															{
																num = (short)215613448;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															dataBlock = enumerator3.Current;
															num = (short)134086666;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 5:
															if (ishHeader.IshID == 65535)
															{
																num = (short)422313991;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_6FF;
														case 6:
															if (dataBlock.BlockID != ishHeader.IshID)
															{
																num = (short)1061879809;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_63E;
														case 8:
															goto IL_6FF;
														case 9:
															goto IL_63E;
														case 10:
															if (dataBlock.BlockType == ishHeader.IshType)
															{
																num = (short)1902837760;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														case 11:
															goto IL_717;
														}
														IL_5FD:
														num = (short)996540420;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_51D:
														goto IL_5FD;
														IL_63E:
														global::Motorola.Common.Communication.Pba.DataBlock dataBlock2 = new global::Motorola.Common.Communication.Pba.DataBlock();
														dataBlock2.BlockType = dataBlock.BlockType;
														dataBlock2.BlockID = dataBlock.BlockID;
														dataBlock2.PacketValue = new byte[dataBlock.PacketValue.Length];
														global::System.Array.Copy(dataBlock.PacketValue, dataBlock2.PacketValue, dataBlock.PacketValue.Length);
														dataBlock2.LegthInBits = dataBlock.LegthInBits;
														dataBlock2.Offset = dataBlock.Offset;
														dataPartition2.DataBlocks.Add(dataBlock2);
														num = (short)1075445765;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_6FF:
														num = (short)779026443;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_717:
													goto IL_42A;
												}
												finally
												{
													((global::System.IDisposable)enumerator3).Dispose();
												}
												goto IL_72A;
												IL_42A:
												num = (short)104464391;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_1DB;
												}
												continue;
											case 5:
												if (dataPartition2 == null)
												{
													num = (short)1474494475;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_467;
											case 6:
											{
												bool flag = true;
												dataPartition2 = null;
												global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator4 = pbaObject.CodeplugData.DataPartitions.GetEnumerator();
												num = (short)1822883849;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												bool flag;
												if (flag)
												{
													num = (short)1277100042;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_72A;
											}
											case 8:
												goto IL_72A;
											case 9:
												try
												{
													num = (short)1803550721;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator4;
															if (!enumerator4.MoveNext())
															{
																num = (short)414711811;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::Motorola.Common.Communication.Pba.DataPartition dataPartition3 = enumerator4.Current;
															num = (short)675086338;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 1:
															switch (0)
															{
															case 0:
																goto IL_323;
															}
															continue;
														case 2:
														{
															global::Motorola.Common.Communication.Pba.DataPartition dataPartition3;
															if (dataPartition3.PartitionID == ishHeader.PartitionNumber)
															{
																num = (short)204406788;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 3:
															goto IL_3CE;
														case 4:
														{
															bool flag = false;
															global::Motorola.Common.Communication.Pba.DataPartition dataPartition3;
															dataPartition2 = dataPartition3;
															num = (short)1212350469;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 5:
															goto IL_3CE;
														case 6:
															goto IL_3E7;
														}
														IL_38E:
														num = (short)157745152;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_323:
														goto IL_38E;
														IL_3CE:
														num = (short)424935430;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_3E7:
													goto IL_251;
												}
												finally
												{
													global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator4;
													((global::System.IDisposable)enumerator4).Dispose();
												}
												goto IL_3FA;
												IL_251:
												num = (short)1331691525;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
												pbaObject.CodeplugData.DataPartitions.Add(dataPartition2);
												num = (short)1030291464;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
												goto IL_3FA;
											case 12:
												if (dataPartition.PartitionID == ishHeader.PartitionNumber)
												{
													num = (short)416940038;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 13:
												goto IL_743;
											}
											IL_20E:
											num = (short)1772224512;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1DB:
											goto IL_20E;
											IL_3FA:
											dataPartition2 = new global::Motorola.Common.Communication.Pba.DataPartition();
											dataPartition2.PartitionID = ishHeader.PartitionNumber;
											num = (short)1777991681;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_467:
											enumerator3 = dataPartition.DataBlocks.GetEnumerator();
											num = (short)1378222083;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_72A:
											num = (short)2045575181;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_743:
										break;
									}
									finally
									{
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_756;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)987824131;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_756;
								case 3:
									num = (short)848232452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_7AA;
								}
								IL_13F:
								num = (short)1560412162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13A:
								goto IL_13F;
								IL_756:
								ishHeader = enumerator.Current;
								enumerator2 = this.b.CodeplugData.DataPartitions.GetEnumerator();
								num = (short)1395916801;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7AA:;
						}
						global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햍횏ﮑ좗\ud99fﾡﾣ\udda7즩쾫쮭쎯솱\udfb9\uddbb\udabd芿껁ꯃꗅꏇ韉菏ꟑ럓뗕뷗꧙꿛", a_));
						goto IL_44;
					}
					catch (global::System.Exception ex)
					{
						global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햍횏ﮑ좗\ud99fﾡﾣ킧즩즫\udead쒯\udbb1\udbb3\ud8b5\udbbdꆿꛁ蛃꫅Ꟈ꧉Ɤ鏍", a_) + ex.Message);
						result = null;
					}
					return result;
					IL_44:
					num = (short)49400377;
					short num3 = num;
					num = (short)1442499129;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_79;
					}
					break;
				}
				}
			}
			IL_79:
			num = (short)1561526272;
			if (num != 0)
			{
			}
			num = (short)591134721;
			if (num != 0)
			{
			}
			num = (short)1862139904;
			short num4 = num;
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햍횏ﮑ좗\ud99fﾡﾣ욧첩쎫\udcad\uddaf펱삳\udfb5ힷ풹薿곁ꃃ鯅鏇飉꧋꿍듏郑룓맕믗뇙臛", a_));
			return pbaObject;
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0018881C File Offset: 0x00186A1C
		private global::Motorola.Common.Communication.Pba.PbaObject a(string A_0)
		{
			int a_ = 10;
			short num = (short)1252684302;
			short num2 = num;
			num = (short)1105687054;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1573715969;
				if (num != 0)
				{
				}
				num = (short)1116143616;
				if (num != 0)
				{
				}
				num = (short)982384640;
				short num3 = num;
				global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회즎ﾒ잖ﲠ즦쾨쒪\udfac슮킰잲\udcb4\ud8b6ힸﶾ꓀꓂계꧆铈郊臌ꃎ냐럒鏔뻖뗘뻚胜", a_));
				result = new global::Motorola.Common.Communication.Pba.PbaObject();
				global::Motorola.Common.Communication.Pba.PbaObject result2;
				try
				{
					result = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFrom(A_0);
					global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회즎ﾒ잖ﲠ튦쪨좪좬\udcae슰﮶횸\udaba\ud9bc料ꣀ꿂ꃄ髆", a_) + A_0);
					break;
				}
				catch (global::System.Exception ex)
				{
					global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회즎ﾒ잖ﲠ\udfa6쪨캪\uddac\udbae\ud8b0\udcb2\udbb4튼\udebeꗀ藂계ꯆ곈雊", a_) + ex.Message);
					result2 = null;
				}
				return result2;
			}
			}
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회즎ﾒ잖ﲠ즦쾨쒪\udfac슮킰잲\udcb4\ud8b6ힸ諭꿀Ꟃ飄鳆藈꓊곌ꯎ韐뫒맔닖蓘", a_));
			return result;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x00188954 File Offset: 0x00186B54
		private bool a(global::Motorola.Common.Communication.Pba.PbaObject A_0, string A_1)
		{
			int a_ = 3;
			short num = (short)1935547637;
			short num2 = num;
			num = (short)2056199413;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1070333952;
				if (num != 0)
				{
				}
				num = (short)307953665;
				if (num != 0)
				{
				}
				num = (short)787873792;
				short num3 = num;
				global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85캇삏ﮓ잙잛힝캟쒡쮣풥얧쮩\ud8ab잭\udfaf\udcb1覆\udfb9\udbbbힽ꺿鿁鿃釅뫇ꏉ룋ꯍ雏믑룓돕藗", a_));
				bool result;
				try
				{
					A_0.Serialize(A_1);
					global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85캇삏ﮓ잙잛춝햟송잣쎥\udba7\ud9a9삱\uddb3습\uddb7ﲹ햻튽ꖿ鿁ﻃ", a_) + A_1);
					break;
				}
				catch (global::System.Exception ex)
				{
					global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85캇삏ﮓ잙잛\udb9d\ud89f송솣횥\udca7쎩쎫삭쒵톷캹\ud9bbꦿ껁ꇃ鯅", a_) + ex.Message);
					result = false;
				}
				return result;
			}
			}
			global::System.Diagnostics.Trace.WriteLine(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd85캇삏ﮓ잙잛힝캟쒡쮣풥얧쮩\ud8ab잭\udfaf\udcb1ﶷ풹\ud8bb鮿闁뛃꿅볇꿉請ꟍ볏럑觓", a_));
			return true;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x00188A88 File Offset: 0x00186C88
		public void UpdateDevice(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num = (short)683212800;
			short num2 = num;
			num = (short)1231584750;
			short num3 = num;
			num = (short)663256558;
			switch (num3 == num)
			{
			}
			num = (short)1339883521;
			if (num != 0)
			{
			}
			num = (short)1168179200;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x00188B38 File Offset: 0x00186D38
		public void WriteLanguagePack(global::SpecialFeatures.Comms.RadioParams radioParam, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num = (short)1643315200;
			short num2 = num;
			num = (short)1476691227;
			short num3 = num;
			num = (short)2104722715;
			switch (num3 == num)
			{
			}
			num = (short)915341312;
			if (num != 0)
			{
			}
			num = (short)2004025345;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00188BE4 File Offset: 0x00186DE4
		public void ValidateUpdate(global::SpecialFeatures.Comms.RadioParams radioPara, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num = (short)705363968;
			short num2 = num;
			num = (short)1192531743;
			short num3 = num;
			num = (short)376084255;
			switch (num3 == num)
			{
			}
			num = (short)2115436545;
			if (num != 0)
			{
			}
			num = (short)184221696;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00188C94 File Offset: 0x00186E94
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1567739188;
				short num2 = num;
				num = (short)658033972;
				switch (num2 == num)
				{
				}
				num = (short)289079296;
				if (num != 0)
				{
				}
				this.a(false);
			}
			finally
			{
				base.Finalize();
			}
			num = (short)785317888;
			short num3 = num;
			num = (short)1252720641;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00188D60 File Offset: 0x00186F60
		public void Dispose()
		{
			short num = (short)237502464;
			short num2 = num;
			num = (short)1029926501;
			short num3 = num;
			num = (short)1865969253;
			switch (num3 == num)
			{
			}
			num = (short)991821825;
			if (num != 0)
			{
			}
			num = (short)231800832;
			if (num != 0)
			{
			}
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00188E14 File Offset: 0x00187014
		private void a(bool A_0)
		{
			short num = (short)755367936;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)350339786;
				short num3 = num;
				num = (short)1572127434;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FD;
				default:
					num = (short)1671561217;
					if (num != 0)
					{
					}
					num = (short)1514930176;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 1:
						if (A_0)
						{
							num = (short)360775684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_162;
					case 2:
						num = (short)1910112257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_FD;
					case 4:
						this.a = null;
						this.c = null;
						this.b = null;
						num = (short)679936003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AC:
					if (this.d)
					{
						goto IL_162;
					}
					num = (short)156368898;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_FD:
			num = (short)729939968;
			short num4 = num;
			IL_162:
			this.d = true;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00188F8C File Offset: 0x0018718C
		public global::SSLMangrComp.PresenceNotification RetrievePresenceInfo(global::SSLMangrComp.PNConnectionInfo connectionConfig)
		{
			short num = (short)892338176;
			short num2 = num;
			num = (short)1647616839;
			short num3 = num;
			num = (short)1127523143;
			switch (num3 == num)
			{
			}
			num = (short)432996353;
			if (num != 0)
			{
			}
			num = (short)1815937024;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0018903C File Offset: 0x0018723C
		public bool CBIProgram(global::SpecialFeatures.Comms.RadioParams radioPara)
		{
			short num = (short)582226761;
			short num2 = num;
			num = (short)1021973321;
			switch (num2 == num)
			{
			default:
			{
				num = (short)725876736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1750925313;
			if (num != 0)
			{
			}
			num = (short)52559872;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x001890EC File Offset: 0x001872EC
		public bool ForceWrite(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.Pba.PbaObject targetPba, global::System.ComponentModel.ProgressChangedEventHandler prgressIndicator = null)
		{
			short num = (short)615415300;
			short num2 = num;
			num = (short)1317568004;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1045102592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2006515713;
			if (num != 0)
			{
			}
			num = (short)704839680;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0018919C File Offset: 0x0018739C
		public bool UpdateSN(global::SpecialFeatures.Comms.RadioParams radioPara, string serialNumber)
		{
			short num = (short)1639854598;
			short num2 = num;
			num = (short)1893282310;
			switch (num2 == num)
			{
			default:
			{
				num = (short)432078848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)318177281;
			if (num != 0)
			{
			}
			num = (short)1447886848;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x00189250 File Offset: 0x00187450
		public bool LoadTxmCertificate(global::SpecialFeatures.Comms.RadioParams radioParam, string path)
		{
			short num = (short)1035759172;
			short num2 = num;
			num = (short)1075670596;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1644101632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)591724544;
			if (num != 0)
			{
			}
			num = (short)591331329;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x00189300 File Offset: 0x00187500
		public string QueryTxmCertificate(global::SpecialFeatures.Comms.RadioParams radioParam, string path)
		{
			short num = (short)1229136713;
			short num2 = num;
			num = (short)64168777;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1358299136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1232142337;
			if (num != 0)
			{
			}
			num = (short)1160314880;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x001893B0 File Offset: 0x001875B0
		public bool ResetPassword(byte[] passwordResetFileContent)
		{
			short num = (short)208708465;
			short num2 = num;
			num = (short)1886364529;
			switch (num2 == num)
			{
			default:
			{
				num = (short)363921408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1418395649;
			if (num != 0)
			{
			}
			num = (short)1230307328;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00189460 File Offset: 0x00187660
		public bool CurrentRadioIsConnected
		{
			get
			{
				short num = (short)851574785;
				if (num != 0)
				{
				}
				num = (short)475070464;
				short num2 = num;
				num = (short)1896670197;
				short num3 = num;
				num = (short)909173749;
				switch (num3 == num)
				{
				}
				num = (short)1977810944;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x040009D1 RID: 2513
		private string a;

		// Token: 0x040009D2 RID: 2514
		private global::Motorola.Common.Communication.Pba.PbaObject b;

		// Token: 0x040009D3 RID: 2515
		private global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo c;

		// Token: 0x040009D4 RID: 2516
		private bool d;
	}
}
