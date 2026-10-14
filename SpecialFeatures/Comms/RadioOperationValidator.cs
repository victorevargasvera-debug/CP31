using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Clone_Configuration.Common;
using SpecialFeatures.Flashport.FlashRadio;
using SpecialFeatures.RadioFeatureSet;
using SpecialFeatures.Security;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000177 RID: 375
	public static class RadioOperationValidator
	{
		// Token: 0x060012A8 RID: 4776 RVA: 0x0019F908 File Offset: 0x0019DB08
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> PopulateWriteValidationFields(global::Motorola.Common.Communication.Pba.PbaObject xpbaCodeplug)
		{
			short num = (short)300417024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1578934863;
				short num3 = num;
				num = (short)1638310479;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_184:
					num = (short)158728200;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)500563968;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B7;
					}
					break;
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
				global::SpecialFeatures.Security.ProtectionOption protectionOption;
				byte[] array;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> list;
				for (;;)
				{
					IL_70:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						if (codeplugInIshItemCollection.ContainsHeader(ishHeader))
						{
							num = (short)458424326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C2;
					case 1:
						protectionOption = global::SpecialFeatures.Security.ProtectionOption.LEGACY_SW;
						num = (short)286392322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)138739713;
						if (num != 0)
						{
						}
						num = (short)120651776;
						short num4 = num;
						goto IL_194E;
					}
					case 3:
					{
						bool flag = false;
						int num5 = 6;
						int num6 = 3;
						byte b = array[num5];
						int num7 = (int)(b & 8);
						num7 >>= num6;
						flag = (1 == num7);
						bool flag2 = false;
						num6 = 2;
						num7 = (int)(b & 4);
						num7 >>= num6;
						flag2 = (1 == num7);
						num = (short)722993167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)70320137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_194E;
					case 6:
						goto IL_191E;
					case 7:
						if (array != null)
						{
							num = (short)556728323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194E;
					case 8:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)906100740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194E;
					}
					case 9:
					{
						bool flag;
						if (!flag)
						{
							num = (short)640155649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194E;
					}
					case 10:
						num = (short)355532812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						protectionOption = global::SpecialFeatures.Security.ProtectionOption.HARDWARE;
						num = (short)1892810757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						bool flag2;
						if (!flag2)
						{
							num = (short)1791295499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					}
					case 13:
						goto IL_1C2;
					case 14:
						try
						{
							num = (short)1711210496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_243;
									}
									continue;
								case 1:
									try
									{
										num = (short)1205075985;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
											int num9;
											global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
											global::Motorola.Common.Communication.Pba.ValidationField validationField8;
											global::Motorola.Common.Communication.Pba.ValidationField validationField14;
											global::Motorola.Common.Communication.Pba.ValidationField validationField17;
											switch (num2)
											{
											case 0:
											{
												int num8;
												if (1 != num8 >> 6)
												{
													num = (short)1470234679;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_BB0;
											}
											case 1:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField;
												validationField.Content = new byte[(ulong)(validationField.LengthInBits / 8U) + (ulong)((validationField.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField.Content, 0, validationField.Content.Length);
												list.Add(validationField);
												byte b2 = validationField.Content[0];
												int num8 = (int)(b2 & 64);
												num = (short)109183029;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField2;
												validationField2.Content = new byte[(ulong)(validationField2.LengthInBits / 8U) + (ulong)((validationField2.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField2.Content, 0, validationField2.Content.Length);
												list.Add(validationField2);
												global::Motorola.Common.Communication.Pba.ValidationField validationField3 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField3.BlockType = dataBlock.BlockType;
												validationField3.BlockID = dataBlock.BlockID;
												validationField3.LengthInBits = 7U;
												validationField3.PartitionID = dataPartition.PartitionID;
												num9 = 161;
												validationField3.OffsetInBits = (uint)(num9 * 8);
												num = (short)1449852940;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												if (protectionOption == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
												{
													num = (short)1488781378;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_A92;
											case 6:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField4 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField4.BlockType = dataBlock.BlockType;
												validationField4.BlockID = dataBlock.BlockID;
												validationField4.LengthInBits = 528U;
												validationField4.PartitionID = dataPartition.PartitionID;
												num9 = 2;
												validationField4.OffsetInBits = (uint)(num9 * 8);
												num = (short)435748918;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField5;
												validationField5.Content = new byte[(ulong)(validationField5.LengthInBits / 8U) + (ulong)((validationField5.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField5.Content, 0, validationField5.Content.Length);
												list.Add(validationField5);
												byte b2 = validationField5.Content[0];
												int num10 = (int)b2;
												global::Motorola.Common.Communication.Pba.ValidationField validationField6 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField6.BlockType = dataBlock.BlockType;
												validationField6.BlockID = dataBlock.BlockID;
												validationField6.LengthInBits = 16U;
												validationField6.PartitionID = dataPartition.PartitionID;
												num9 = 106;
												validationField6.OffsetInBits = (uint)(num9 * 8);
												num = (short)1469186094;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
												goto IL_1812;
											case 9:
											{
												ushort blockType;
												if (blockType != 3852)
												{
													num = (short)598278187;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Common.Communication.Pba.ValidationField validationField7 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField7.BlockType = dataBlock.BlockType;
												validationField7.BlockID = dataBlock.BlockID;
												validationField7.LengthInBits = 16U;
												validationField7.PartitionID = dataPartition.PartitionID;
												num9 = 59;
												validationField7.OffsetInBits = (uint)(num9 * 8);
												num = (short)2062024755;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 11:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField5 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField5.BlockType = dataBlock.BlockType;
												validationField5.BlockID = dataBlock.BlockID;
												validationField5.LengthInBits = 8U;
												validationField5.PartitionID = dataPartition.PartitionID;
												num9 = 124;
												validationField5.OffsetInBits = (uint)(num9 * 8);
												num = (short)1938948103;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 12:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField3;
												validationField3.Content = new byte[(ulong)(validationField3.LengthInBits / 8U) + (ulong)((validationField3.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField3.Content, 0, validationField3.Content.Length);
												list.Add(validationField3);
												num = (short)949551128;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 13:
											{
												ushort blockType;
												if (blockType != 1029)
												{
													num = (short)1570897946;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Common.Communication.Pba.ValidationField validationField = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField.BlockType = dataBlock.BlockType;
												validationField.BlockID = dataBlock.BlockID;
												validationField.LengthInBits = 1U;
												validationField.PartitionID = dataPartition.PartitionID;
												num9 = 1;
												validationField.OffsetInBits = (uint)(num9 * 8 + 1);
												num = (short)871890945;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 14:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField6;
												list.Add(validationField6);
												num = (short)646840360;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 16:
												num = (short)1389297679;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 17:
												switch (0)
												{
												case 0:
													goto IL_3AE;
												}
												continue;
											case 18:
												validationField8.Content = new byte[(ulong)(validationField8.LengthInBits / 8U) + (ulong)((validationField8.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField8.Content, 0, validationField8.Content.Length);
												num = (short)1140850720;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 19:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField7;
												int num11;
												if (num11 >= validationField7.Content.Length)
												{
													num = (short)505872447;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												byte b2 = validationField7.Content[num11];
												int num12;
												num12 |= (int)b2 << 8 * (validationField7.Content.Length - num11 - 1);
												num11++;
												num = (short)2017787945;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 20:
												if (dataBlock.LegthInBits - 24 > 8)
												{
													num = (short)2093744155;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 21:
												num = (short)1835335716;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 22:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField9;
												validationField9.Content = new byte[(ulong)(validationField9.LengthInBits / 8U) + (ulong)((validationField9.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField9.Content, 0, validationField9.Content.Length);
												global::Motorola.Common.Communication.Pba.ValidationField validationField7;
												list.Add(validationField7);
												list.Add(validationField9);
												global::Motorola.Common.Communication.Pba.ValidationField field = validationField9;
												global::SpecialFeatures.Security.TrkSysBandPlan trkSysBandPlan = null;
												num = (short)1409482787;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 23:
											{
												ushort blockType;
												if (blockType != 1026)
												{
													num = (short)1313931280;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.Common.Communication.Pba.ValidationField validationField10 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField10.BlockType = dataBlock.BlockType;
												validationField10.BlockID = dataBlock.BlockID;
												validationField10.LengthInBits = 1U;
												validationField10.PartitionID = dataPartition.PartitionID;
												num9 = 21;
												validationField10.OffsetInBits = (uint)(num9 * 8 + 3);
												num = (short)1468530718;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 26:
												num = (short)1585250313;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 27:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField11 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField11.BlockType = dataBlock.BlockType;
												validationField11.BlockID = dataBlock.BlockID;
												validationField11.LengthInBits = (uint)(dataBlock.LegthInBits - 24 - 8);
												validationField11.PartitionID = dataPartition.PartitionID;
												num9 = 2;
												validationField11.OffsetInBits = (uint)(num9 * 8);
												num = (short)359006246;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 28:
												num = (short)601096256;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 29:
												if (protectionOption == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
												{
													num = (short)859439125;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_849;
											case 30:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField10;
												validationField10.Content = new byte[(ulong)(validationField10.LengthInBits / 8U) + (ulong)((validationField10.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField10.Content, 0, validationField10.Content.Length);
												list.Add(validationField10);
												int num8 = 0;
												num = (short)448921644;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 31:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField12;
												validationField12.Content = new byte[(ulong)(validationField12.LengthInBits / 8U) + (ulong)((validationField12.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField12.Content, 0, validationField12.Content.Length);
												list.Add(validationField12);
												global::Motorola.Common.Communication.Pba.ValidationField validationField2 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField2.BlockType = dataBlock.BlockType;
												validationField2.BlockID = dataBlock.BlockID;
												validationField2.LengthInBits = 272U;
												validationField2.PartitionID = dataPartition.PartitionID;
												num9 = 23;
												validationField2.OffsetInBits = (uint)(num9 * 8);
												num = (short)1048578;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 32:
												if (protectionOption == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
												{
													num = (short)703528997;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_98B;
											case 33:
												goto IL_A92;
											case 34:
												goto IL_98B;
											case 35:
											{
												int num12;
												global::Motorola.Common.Communication.Pba.ValidationField validationField9;
												global::SpecialFeatures.Security.TrkSysBandPlan trkSysBandPlan;
												if (global::SpecialFeatures.Comms.RadioOperationValidator.a(num12, (int)validationField9.Content[0], out trkSysBandPlan))
												{
													num = (short)1267728443;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 36:
											{
												int num10;
												if (num10 == 0)
												{
													num = (short)1504837646;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_849;
											}
											case 37:
												num = (short)1256587303;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 38:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField11;
												validationField11.Content = new byte[(ulong)(validationField11.LengthInBits / 8U) + (ulong)((validationField11.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField11.Content, 0, validationField11.Content.Length);
												validationField11.AutoFill = true;
												list.Add(validationField11);
												num = (short)391053315;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 39:
											{
												int num10;
												if (num10 == 1)
												{
													num = (short)180551728;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_98B;
											}
											case 40:
												goto IL_849;
											case 41:
												goto IL_1245;
											case 42:
												goto IL_1245;
											case 43:
												num = (short)1395195914;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 44:
												if (protectionOption == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
												{
													num = (short)35323915;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_A92;
											case 45:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField13;
												validationField13.Content = new byte[(ulong)(validationField13.LengthInBits / 8U) + (ulong)((validationField13.LengthInBits % 8U == 0U) ? 0L : 1L)];
												validationField13.Content[0] = global::System.Convert.ToByte(0);
												validationField13.BypassMissing = true;
												list.Add(validationField13);
												num = (short)708706309;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 46:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField6;
												validationField6.Content = new byte[(ulong)(validationField6.LengthInBits / 8U) + (ulong)((validationField6.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField6.Content, 0, validationField6.Content.Length);
												num = (short)667418653;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 47:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField11;
												validationField11.Content = new byte[(ulong)(validationField11.LengthInBits / 8U) + (ulong)((validationField11.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField11.Content, 0, validationField11.Content.Length);
												validationField11.AutoFill = true;
												list.Add(validationField11);
												num = (short)988217364;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 48:
												list.Add(validationField8);
												num = (short)891617314;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 49:
											{
												validationField14.Content = new byte[(ulong)(validationField14.LengthInBits / 8U) + (ulong)((validationField14.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField14.Content, 0, validationField14.Content.Length);
												byte b2 = validationField14.Content[0];
												int num8 = (int)(b2 & 64);
												num = (short)399376384;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 50:
											{
												ushort blockType;
												if (blockType <= 1026)
												{
													num = (short)140378140;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)762642445;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 51:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField7;
												validationField7.Content = new byte[(ulong)(validationField7.LengthInBits / 8U) + (ulong)((validationField7.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField7.Content, 0, validationField7.Content.Length);
												int num12 = 0;
												int num11 = 0;
												num = (short)358678570;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 52:
												num = (short)1435172887;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 53:
											{
												int num8;
												bool flag3 = 1 == num8 >> 6;
												global::Motorola.Common.Communication.Pba.ValidationField validationField15 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField15.BlockType = dataBlock.BlockType;
												validationField15.BlockID = dataBlock.BlockID;
												validationField15.LengthInBits = 1U;
												validationField15.PartitionID = dataPartition.PartitionID;
												num9 = 1;
												validationField15.OffsetInBits = (uint)(num9 * 8);
												validationField15.Content = new byte[(ulong)(validationField15.LengthInBits / 8U) + (ulong)((validationField15.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField15.Content, 0, validationField15.Content.Length);
												list.Add(validationField15);
												byte b2 = validationField15.Content[0];
												num8 = (int)(b2 & 128);
												bool flag4 = 1 == num8 >> 7;
												global::Motorola.Common.Communication.Pba.ValidationField validationField16 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField16.BlockType = dataBlock.BlockType;
												validationField16.BlockID = dataBlock.BlockID;
												validationField16.LengthInBits = 1U;
												validationField16.PartitionID = dataPartition.PartitionID;
												num9 = 1;
												validationField16.OffsetInBits = (uint)(num9 * 8 + 2);
												validationField16.Content = new byte[(ulong)(validationField16.LengthInBits / 8U) + (ulong)((validationField16.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField16.Content, 0, validationField16.Content.Length);
												list.Add(validationField16);
												b2 = validationField16.Content[0];
												num8 = (int)(b2 & 32);
												bool flag5 = 1 == num8 >> 5;
												if (flag3 || flag4 || flag5)
												{
													num = (short)841678854;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 54:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField4;
												validationField4.Content = new byte[(ulong)(validationField4.LengthInBits / 8U) + (ulong)((validationField4.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField4.Content, 0, validationField4.Content.Length);
												list.Add(validationField4);
												num = (short)2124677145;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 55:
												list.Add(validationField14);
												num = (short)830865468;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 58:
												validationField17.Content = new byte[(ulong)(validationField17.LengthInBits / 8U) + (ulong)((validationField17.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField17.Content, 0, validationField17.Content.Length);
												num = (short)1973616644;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 59:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField13 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField13.BlockType = dataBlock.BlockType;
												validationField13.BlockID = dataBlock.BlockID;
												validationField13.LengthInBits = 1U;
												validationField13.PartitionID = dataPartition.PartitionID;
												num9 = 70;
												validationField13.OffsetInBits = (uint)(num9 * 8 + 5);
												num = (short)1640955949;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 60:
												goto IL_BB0;
											case 61:
												num = (short)167837704;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 62:
											{
												global::Motorola.Common.Communication.Pba.ValidationField validationField18;
												validationField18.Content = new byte[(ulong)(validationField18.LengthInBits / 8U) + (ulong)((validationField18.LengthInBits % 8U == 0U) ? 0L : 1L)];
												global::System.Array.Copy(dataBlock.PacketValue, num9, validationField18.Content, 0, validationField18.Content.Length);
												list.Add(validationField18);
												num = (short)716505145;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 63:
											{
												int num13 = (int)(dataBlock.BlockID + 1);
												global::Motorola.Common.Communication.Pba.ValidationField validationField9 = new global::Motorola.Common.Communication.Pba.ValidationField();
												validationField9.BlockType = dataBlock.BlockType;
												validationField9.BlockID = dataBlock.BlockID;
												validationField9.LengthInBits = 8U;
												validationField9.PartitionID = dataPartition.PartitionID;
												num9 = 1;
												validationField9.OffsetInBits = (uint)(num9 * 8);
												num = (short)611713046;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 64:
											{
												ushort blockType;
												switch (blockType)
												{
												case 900:
												{
													global::Motorola.Common.Communication.Pba.ValidationField validationField12 = new global::Motorola.Common.Communication.Pba.ValidationField();
													validationField12.BlockType = dataBlock.BlockType;
													validationField12.BlockID = dataBlock.BlockID;
													validationField12.LengthInBits = 176U;
													validationField12.PartitionID = dataPartition.PartitionID;
													num9 = 1;
													validationField12.OffsetInBits = (uint)(num9 * 8);
													num = (short)1344995359;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 901:
												{
													global::Motorola.Common.Communication.Pba.ValidationField validationField18 = new global::Motorola.Common.Communication.Pba.ValidationField();
													validationField18.BlockType = dataBlock.BlockType;
													validationField18.BlockID = dataBlock.BlockID;
													validationField18.LengthInBits = 104U;
													validationField18.PartitionID = dataPartition.PartitionID;
													num9 = 1;
													validationField18.OffsetInBits = (uint)(num9 * 8);
													num = (short)944242750;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 902:
													break;
												case 903:
												{
													global::Motorola.Common.Communication.Pba.ValidationField validationField11 = new global::Motorola.Common.Communication.Pba.ValidationField();
													validationField11.BlockType = dataBlock.BlockType;
													validationField11.BlockID = dataBlock.BlockID;
													validationField11.LengthInBits = 7U;
													validationField11.PartitionID = dataPartition.PartitionID;
													num9 = 1;
													validationField11.OffsetInBits = (uint)(num9 * 8);
													num = (short)1596719151;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												default:
													num = (short)467992628;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 65:
											{
												global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1883897917;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												dataBlock = enumerator.Current;
												num9 = 0;
												ushort blockType = dataBlock.BlockType;
												num = (short)160497714;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 66:
												list.Add(validationField17);
												num = (short)385089569;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_3AE;
											IL_849:
											validationField8 = new global::Motorola.Common.Communication.Pba.ValidationField();
											validationField8.BlockType = dataBlock.BlockType;
											validationField8.BlockID = dataBlock.BlockID;
											validationField8.LengthInBits = 24U;
											validationField8.PartitionID = dataPartition.PartitionID;
											num9 = 121;
											validationField8.OffsetInBits = (uint)(num9 * 8);
											num = (short)1277362194;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_98B:
											validationField17 = new global::Motorola.Common.Communication.Pba.ValidationField();
											validationField17.BlockType = dataBlock.BlockType;
											validationField17.BlockID = dataBlock.BlockID;
											validationField17.LengthInBits = 1U;
											validationField17.PartitionID = dataPartition.PartitionID;
											num9 = 97;
											validationField17.OffsetInBits = (uint)(num9 * 8 + 4);
											num = (short)1030029370;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_A92:
											validationField14 = new global::Motorola.Common.Communication.Pba.ValidationField();
											validationField14.BlockType = dataBlock.BlockType;
											validationField14.BlockID = dataBlock.BlockID;
											validationField14.LengthInBits = 1U;
											validationField14.PartitionID = dataPartition.PartitionID;
											num9 = 19;
											validationField14.OffsetInBits = (uint)(num9 * 8 + 1);
											num = (short)1013121073;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_BB0:
											global::Motorola.Common.Communication.Pba.ValidationField validationField19 = new global::Motorola.Common.Communication.Pba.ValidationField();
											validationField19.BlockType = dataBlock.BlockType;
											validationField19.BlockID = dataBlock.BlockID;
											validationField19.LengthInBits = 1U;
											validationField19.PartitionID = dataPartition.PartitionID;
											num9 = 19;
											validationField19.OffsetInBits = (uint)(num9 * 8 + 6);
											validationField19.Content = new byte[1];
											validationField19.Content[0] = 0;
											list.Add(validationField19);
											num = (short)967835704;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1245:
											num = (short)770637843;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_17BA:
											num = (short)2036465729;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_3AE:
											goto IL_17BA;
										}
										IL_1812:;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
										((global::System.IDisposable)enumerator).Dispose();
									}
									num = (short)1023934466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									int num13;
									if (num13 > 0)
									{
										num = (short)2034892805;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)598933508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_190B;
								case 5:
								{
									global::Motorola.Common.Communication.Pba.ValidationField field;
									global::Motorola.Common.Communication.Pba.ValidationField validationField20 = new global::Motorola.Common.Communication.Pba.ValidationField(field);
									int num13;
									validationField20.BlockID = (ushort)num13;
									validationField20.Content = new byte[1];
									validationField20.Content[0] = global::System.Convert.ToByte(0);
									validationField20.BypassMissing = true;
									list.Add(validationField20);
									num = (short)2029518854;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)281411587;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.DataPartition dataPartition = enumerator2.Current;
									int num13 = 0;
									global::Motorola.Common.Communication.Pba.ValidationField field = null;
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator = dataPartition.DataBlocks.GetEnumerator();
									num = (short)499974145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_18B3:
								num = (short)831717383;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_243:
								goto IL_18B3;
							}
							IL_190B:
							return list;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_191E;
					case 15:
					{
						bool flag;
						if (flag)
						{
							num = (short)597753866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184;
					}
					}
					goto IL_B7;
					IL_1C2:
					num = (short)617938951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_191E:
					array = codeplugInIshItemCollection[ishHeader].Data;
					num = (short)475398157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_194E:
					list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
					enumerator2 = xpbaCodeplug.CodeplugData.DataPartitions.GetEnumerator();
					num = (short)1294401550;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_B7:
				array = null;
				protectionOption = global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED;
				codeplugInIshItemCollection = xpbaCodeplug.GetCodeplugInIshItemCollection();
				ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 901, 0);
				num = (short)1496055808;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_70;
			}
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x001A13E4 File Offset: 0x0019F5E4
		private static bool a(int A_0, int A_1, out global::SpecialFeatures.Security.TrkSysBandPlan A_2)
		{
			short num = (short)1921411589;
			short num2 = num;
			num = (short)694577669;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)650051584;
				short num3 = num;
				num = (short)692387841;
				if (num != 0)
				{
				}
				num = (short)1417543680;
				if (num != 0)
				{
				}
				A_2 = null;
				result = false;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
				try
				{
					num = (short)109379591;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1171783683;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
							num = (short)1054801926;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1364131851;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == A_1)
							{
								num = (short)659357706;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							num = (short)385417225;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							A_2 = new global::SpecialFeatures.Security.TrkSysBandPlan(trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value, trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value, trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128.Value);
							result = true;
							num = (short)12713992;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)46071810;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value == A_0)
							{
								num = (short)2019033093;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_112;
							}
							continue;
						case 8:
							goto IL_23B;
						case 9:
							goto IL_301;
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							trunkingSystem.TypeIIChannelSetup.SetConstraints();
							num = (short)226885644;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (!trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128)
							{
								num = (short)951320580;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
							if (trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128.IsVisible(trunkingSystem.TypeIIChannelSetup))
							{
								num = (short)448790529;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_157:
						num = (short)298844160;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_112:
						goto IL_157;
					}
					IL_23B:
					IL_301:;
				}
				finally
				{
					num = (short)502071296;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_335;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1277755394;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_36A;
						}
						IL_335:
						if (enumerator == null)
						{
							break;
						}
						num = (short)464388097;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_36A:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x001A177C File Offset: 0x0019F97C
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> PopulateUpgradeValidationFields(global::Motorola.Common.Communication.Pba.PbaObject xpbaCodeplug)
		{
			short num = (short)531693568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)41234820;
				short num3 = num;
				num = (short)1677865348;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_DE:
					if (!codeplugInIshItemCollection.ContainsHeader(ishHeader))
					{
						goto IL_899;
					}
					num = (short)477102080;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)937426945;
					if (num != 0)
					{
					}
					num = (short)571015168;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B0;
					}
					break;
				}
				for (;;)
				{
					IL_99:
					switch (num2)
					{
					case 0:
					{
						num = (short)818675712;
						short num4 = num;
						byte[] data = codeplugInIshItemCollection[ishHeader].Data;
						num = (short)235995139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_DE;
					case 2:
						goto IL_8C9;
					case 3:
						goto IL_8F7;
					}
					goto IL_B0;
				}
				IL_8C9:
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> list;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator2;
				try
				{
					num = (short)1092550658;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)809435150;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1226309635;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::Motorola.Common.Communication.Pba.ValidationField validationField;
										validationField.Content = new byte[(ulong)(validationField.LengthInBits / 8U) + (ulong)((validationField.LengthInBits % 8U == 0U) ? 0L : 1L)];
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										int num5;
										global::System.Array.Copy(dataBlock.PacketValue, num5, validationField.Content, 0, validationField.Content.Length);
										validationField.BypassMissing = true;
										list.Add(validationField);
										num = (short)2099904531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::Motorola.Common.Communication.Pba.ValidationField validationField2;
										validationField2.Content = new byte[(ulong)(validationField2.LengthInBits / 8U) + (ulong)((validationField2.LengthInBits % 8U == 0U) ? 0L : 1L)];
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										int num5;
										global::System.Array.Copy(dataBlock.PacketValue, num5, validationField2.Content, 0, validationField2.Content.Length);
										list.Add(validationField2);
										num = (short)557776901;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										ushort blockType;
										if (blockType == 1026)
										{
											num = (short)709820433;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::Motorola.Common.Communication.Pba.ValidationField validationField3;
										validationField3.Content = new byte[(ulong)(validationField3.LengthInBits / 8U) + (ulong)((validationField3.LengthInBits % 8U == 0U) ? 0L : 1L)];
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										int num5;
										global::System.Array.Copy(dataBlock.PacketValue, num5, validationField3.Content, 0, validationField3.Content.Length);
										list.Add(validationField3);
										global::Motorola.Common.Communication.Pba.ValidationField validationField4 = new global::Motorola.Common.Communication.Pba.ValidationField();
										validationField4.BlockType = dataBlock.BlockType;
										validationField4.BlockID = dataBlock.BlockID;
										validationField4.LengthInBits = 272U;
										global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
										validationField4.PartitionID = dataPartition.PartitionID;
										num5 = 23;
										validationField4.OffsetInBits = (uint)(num5 * 8);
										num = (short)1415643149;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::Motorola.Common.Communication.Pba.ValidationField validationField = new global::Motorola.Common.Communication.Pba.ValidationField();
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										validationField.BlockType = dataBlock.BlockType;
										validationField.BlockID = dataBlock.BlockID;
										validationField.LengthInBits = (uint)(dataBlock.LegthInBits - 24 - 8);
										global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
										validationField.PartitionID = dataPartition.PartitionID;
										int num5 = 2;
										validationField.OffsetInBits = (uint)(num5 * 8);
										num = (short)871497729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										ushort blockType;
										switch (blockType)
										{
										case 900:
										{
											global::Motorola.Common.Communication.Pba.ValidationField validationField3 = new global::Motorola.Common.Communication.Pba.ValidationField();
											global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
											validationField3.BlockType = dataBlock.BlockType;
											validationField3.BlockID = dataBlock.BlockID;
											validationField3.LengthInBits = 176U;
											global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
											validationField3.PartitionID = dataPartition.PartitionID;
											int num5 = 1;
											validationField3.OffsetInBits = (uint)(num5 * 8);
											num = (short)1111162884;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 901:
										{
											global::Motorola.Common.Communication.Pba.ValidationField validationField2 = new global::Motorola.Common.Communication.Pba.ValidationField();
											global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
											validationField2.BlockType = dataBlock.BlockType;
											validationField2.BlockID = dataBlock.BlockID;
											validationField2.LengthInBits = 104U;
											global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
											validationField2.PartitionID = dataPartition.PartitionID;
											int num5 = 1;
											validationField2.OffsetInBits = (uint)(num5 * 8);
											num = (short)662306818;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 902:
											break;
										case 903:
										{
											global::Motorola.Common.Communication.Pba.ValidationField validationField = new global::Motorola.Common.Communication.Pba.ValidationField();
											global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
											validationField.BlockType = dataBlock.BlockType;
											validationField.BlockID = dataBlock.BlockID;
											validationField.LengthInBits = 7U;
											global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
											validationField.PartitionID = dataPartition.PartitionID;
											int num5 = 1;
											validationField.OffsetInBits = (uint)(num5 * 8);
											num = (short)611975186;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										default:
											num = (short)1178861568;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
										goto IL_85E;
									case 11:
									{
										global::Motorola.Common.Communication.Pba.ValidationField validationField5;
										validationField5.Content = new byte[(ulong)(validationField5.LengthInBits / 8U) + (ulong)((validationField5.LengthInBits % 8U == 0U) ? 0L : 1L)];
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										int num5;
										global::System.Array.Copy(dataBlock.PacketValue, num5, validationField5.Content, 0, validationField5.Content.Length);
										list.Add(validationField5);
										num = (short)848232458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										num = (short)1945239561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
									{
										global::Motorola.Common.Communication.Pba.ValidationField validationField4;
										validationField4.Content = new byte[(ulong)(validationField4.LengthInBits / 8U) + (ulong)((validationField4.LengthInBits % 8U == 0U) ? 0L : 1L)];
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										int num5;
										global::System.Array.Copy(dataBlock.PacketValue, num5, validationField4.Content, 0, validationField4.Content.Length);
										list.Add(validationField4);
										num = (short)156499975;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
										switch (0)
										{
										case 0:
											goto IL_250;
										}
										continue;
									case 15:
									{
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										if (dataBlock.LegthInBits - 24 > 8)
										{
											num = (short)1347289094;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 16:
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1390215180;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator.Current;
										int num5 = 0;
										ushort blockType = dataBlock.BlockType;
										num = (short)1219821576;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
									{
										global::Motorola.Common.Communication.Pba.ValidationField validationField5 = new global::Motorola.Common.Communication.Pba.ValidationField();
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										validationField5.BlockType = dataBlock.BlockType;
										validationField5.BlockID = dataBlock.BlockID;
										validationField5.LengthInBits = 1U;
										global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
										validationField5.PartitionID = dataPartition.PartitionID;
										int num5 = 21;
										validationField5.OffsetInBits = (uint)(num5 * 8 + 3);
										num = (short)154861579;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 18:
									{
										global::Motorola.Common.Communication.Pba.ValidationField validationField;
										validationField.Content = new byte[(ulong)(validationField.LengthInBits / 8U) + (ulong)((validationField.LengthInBits % 8U == 0U) ? 0L : 1L)];
										global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
										int num5;
										global::System.Array.Copy(dataBlock.PacketValue, num5, validationField.Content, 0, validationField.Content.Length);
										validationField.BypassMissing = true;
										list.Add(validationField);
										num = (short)466026511;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_806:
									num = (short)703922192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_250:
									goto IL_806;
								}
								IL_85E:
								break;
							}
							finally
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_871;
						case 1:
							goto IL_871;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_169;
							}
							continue;
						case 3:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)68878337;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.Pba.DataPartition dataPartition = enumerator2.Current;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator = dataPartition.DataBlocks.GetEnumerator();
							num = (short)1823473664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_889;
						}
						IL_19C:
						num = (short)914817027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_169:
						goto IL_19C;
						IL_871:
						num = (short)248446980;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_889:
					return list;
				}
				finally
				{
					((global::System.IDisposable)enumerator2).Dispose();
				}
				IL_8F7:
				goto IL_899;
				IL_B0:
				codeplugInIshItemCollection = xpbaCodeplug.GetCodeplugInIshItemCollection();
				ishHeader = new global::Motorola.Common.Communication.CommonUtil.IshHeader(212, 901, 0);
				num = (short)902365185;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_99;
				IL_899:
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField>();
				enumerator2 = xpbaCodeplug.CodeplugData.DataPartitions.GetEnumerator();
				num = (short)2067922946;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_99;
			}
			}
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x001A20B8 File Offset: 0x001A02B8
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo> PopulateUpgradeValidationInfos(global::Motorola.Common.Communication.Pba.PbaObject xpbaCodeplug, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug currentcp, bool bRefresh)
		{
			int a_ = 4;
			short num = (short)1834811393;
			if (num != 0)
			{
			}
			num = (short)630658456;
			short num2 = num;
			num = (short)182064536;
			switch (num2 == num)
			{
			}
			num = (short)1927872512;
			if (num != 0)
			{
			}
			num = (short)92930048;
			short num3 = num;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo>();
			global::Motorola.Common.Communication.Pba.ValidationMethod validationMethod = global::Motorola.Common.Communication.Pba.ValidationMethod.Greater;
			if (bRefresh)
			{
				if (!bRefresh || (currentcp.ExtendedFlags & 1) != 0)
				{
					goto IL_C4;
				}
			}
			validationMethod = global::Motorola.Common.Communication.Pba.ValidationMethod.NotLess;
			IL_C4:
			list.Add(new global::Motorola.Common.Communication.Pba.ValidationInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풆歷솖ﲘ캠춢", a_), currentcp.FirmwareVersion, validationMethod));
			return list;
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x001A21AC File Offset: 0x001A03AC
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo> PopulateLPValidationInfos(global::Motorola.Common.Communication.Pba.PbaObject xpbaCodeplug, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug currentcp)
		{
			int a_ = 18;
			short num = (short)1732816213;
			short num2 = num;
			num = (short)1471262037;
			switch (num2 == num)
			{
			}
			num = (short)1894449153;
			if (num != 0)
			{
			}
			num = (short)1110310912;
			if (num != 0)
			{
			}
			num = (short)904658944;
			short num3 = num;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo>();
			global::Motorola.Common.Communication.Pba.ValidationMethod validationMethod = global::Motorola.Common.Communication.Pba.ValidationMethod.NotGreater;
			list.Add(new global::Motorola.Common.Communication.Pba.ValidationInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요ﾘﺞ펠욢슦\udba8\ud8aa쒬삮\udfb0", a_), currentcp.FirmwareVersion, validationMethod));
			return list;
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x001A2284 File Offset: 0x001A0484
		public static global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo> PopulateValidationInfosForRegularWrite(global::Motorola.Common.Communication.Pba.PbaObject xpbaCodeplug, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug currentcp)
		{
			int a_ = 10;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationInfo>();
			short num;
			if (new global::System.Text.RegularExpressions.Regex(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖌ펎뢒즔릖얘ﾚ뚜쎞辠ﾢ솤貦肨", a_)).Match(currentcp.FirmwareVersion).Success)
			{
				num = (short)878630830;
				short num2 = num;
				num = (short)878106542;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2004811776;
					if (num != 0)
					{
					}
					num = (short)1514668032;
					short num3 = num;
					global::Motorola.Common.Communication.Pba.ValidationMethod validationMethod = global::Motorola.Common.Communication.Pba.ValidationMethod.Equal;
					list.Add(new global::Motorola.Common.Communication.Pba.ValidationInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8cﺚ쮜爵펠킢첤좦잨", a_), currentcp.FirmwareVersion, validationMethod));
					return list;
				}
				}
			}
			num = (short)417726465;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Pba.ValidationMethod validationMethod2 = global::Motorola.Common.Communication.Pba.ValidationMethod.Greater;
			list.Add(new global::Motorola.Common.Communication.Pba.ValidationInfo(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8cﺚ쮜爵펠킢첤좦잨", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8c뾎ꦐ붒ꖔꞖ래ꮚ궜놞醠鎢", a_), validationMethod2));
			return list;
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x001A23B4 File Offset: 0x001A05B4
		public static global::Motorola.Common.Communication.Pba.ValidationField PopulateLanguageSettingValidationField(global::Motorola.Common.Communication.Pba.PbaObject xpbaCodeplug)
		{
			short num = (short)565248000;
			switch (num)
			{
			default:
			{
				num = (short)365363201;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Pba.ValidationField result;
				using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataPartition>.Enumerator enumerator = xpbaCodeplug.CodeplugData.DataPartitions.GetEnumerator())
				{
					num = (short)1065615364;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_33A;
						case 1:
							goto IL_322;
						case 2:
						{
							num = (short)615898836;
							short num3 = num;
							num = (short)793108180;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1314324480;
								if (num != 0)
								{
								}
								try
								{
									num = (short)604962819;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											num = (short)821755905;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_30F;
										case 2:
										{
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1636827136;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Common.Communication.Pba.DataBlock dataBlock = enumerator2.Current;
											int num4 = 0;
											num = (short)1299578886;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											switch (0)
											{
											case 0:
												goto IL_196;
											}
											continue;
										case 4:
										{
											global::Motorola.Common.Communication.Pba.ValidationField validationField = new global::Motorola.Common.Communication.Pba.ValidationField();
											global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
											validationField.BlockType = dataBlock.BlockType;
											validationField.BlockID = dataBlock.BlockID;
											validationField.LengthInBits = 8U;
											global::Motorola.Common.Communication.Pba.DataPartition dataPartition;
											validationField.PartitionID = dataPartition.PartitionID;
											int num4 = 56;
											validationField.OffsetInBits = (uint)(num4 * 8);
											num = (short)1684602887;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											goto IL_2F1;
										case 6:
										{
											global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
											if (dataBlock.BlockType == 1026)
											{
												num = (short)1828847620;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 7:
										{
											global::Motorola.Common.Communication.Pba.ValidationField validationField;
											validationField.Content = new byte[(ulong)(validationField.LengthInBits / 8U) + (ulong)((validationField.LengthInBits % 8U == 0U) ? 0L : 1L)];
											global::Motorola.Common.Communication.Pba.DataBlock dataBlock;
											int num4;
											global::System.Array.Copy(dataBlock.PacketValue, num4, validationField.Content, 0, validationField.Content.Length);
											result = validationField;
											num = (short)1481637893;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_26A:
										num = (short)989331458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_196:
										goto IL_26A;
									}
									IL_2F1:
									goto IL_34D;
									IL_30F:
									break;
								}
								finally
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2;
									((global::System.IDisposable)enumerator2).Dispose();
								}
								goto IL_322;
							}
							break;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1368129537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.Pba.DataPartition dataPartition = enumerator.Current;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlock>.Enumerator enumerator2 = dataPartition.DataBlocks.GetEnumerator();
							num = (short)1975517186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_96;
							}
							continue;
						}
						IL_9B:
						num = (short)1130561539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_96:
						goto IL_9B;
						IL_322:
						num = (short)803405824;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_33A:
					goto IL_59;
				}
				goto IL_34D;
				IL_59:
				return null;
				IL_34D:
				num = (short)806813696;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x001A2770 File Offset: 0x001A0970
		internal static void CheckAndReviseBlockList(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader> blockList)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader;
				switch (num)
				{
				case 0:
				{
					int index = num2;
					byte partitionNumber = 212;
					ishHeader = blockList[num2];
					ushort ishType = ishHeader.IshType;
					ishHeader = blockList[num2];
					blockList[index] = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partitionNumber, ishType, ishHeader.IshID);
					num3 = (short)1015939074;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
					ishHeader = blockList[num2];
					num3 = (short)403177485;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_246;
				case 3:
					if (num2 >= blockList.Count)
					{
						num3 = (short)552140810;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					ishHeader = blockList[num2];
					num3 = (short)768540678;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					if (ishHeader.IshType >= 900)
					{
						num3 = (short)230621185;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_246;
				case 5:
					goto IL_246;
				case 6:
					if (ishHeader.IshType >= 1000)
					{
						num3 = (short)568131592;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_266;
				case 7:
					goto IL_1BB;
				case 8:
					ishHeader = blockList[num2];
					num3 = (short)521142284;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					goto IL_1BB;
				case 10:
					return;
				case 11:
				{
					int index2 = num2;
					byte partitionNumber2 = 208;
					ishHeader = blockList[num2];
					ushort ishType2 = ishHeader.IshType;
					ishHeader = blockList[num2];
					blockList[index2] = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partitionNumber2, ishType2, ishHeader.IshID);
					goto IL_305;
				}
				case 12:
				{
					num3 = (short)1604124672;
					short num4 = num3;
					if (ishHeader.IshType <= 3999)
					{
						num3 = (short)899285003;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_266;
				}
				case 13:
				{
					num3 = (short)22180418;
					short num5 = num3;
					num3 = (short)1975218754;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_305;
					default:
						num3 = (short)1139998720;
						if (num3 != 0)
						{
						}
						if (ishHeader.IshType <= 999)
						{
							num3 = (short)754253824;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_246;
					}
					break;
				}
				}
				goto IL_48;
				IL_1BB:
				num3 = (short)482869251;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_246:
				num2++;
				num3 = (short)1927544839;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_266:
				num3 = (short)1257504769;
				if (num3 != 0)
				{
				}
				ishHeader = blockList[num2];
				num3 = (short)1834876932;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_305:
				num3 = (short)1881604101;
				num = (int)((global::System.IntPtr)num3);
			}
			return;
			IL_48:
			num2 = 0;
			num3 = (short)285016073;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x001A2AA0 File Offset: 0x001A0CA0
		internal static void CompareRadioParams(global::SpecialFeatures.Comms.RadioParams codeplug, global::SpecialFeatures.Comms.RadioParams radio, global::SpecialFeatures.Comms.COMMS_OP writeType)
		{
			short num = (short)292880402;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)785973264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_3F8;
				case 2:
					if (string.IsNullOrEmpty(radio.ModelNumber))
					{
						num = (short)613154831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)5963781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1769734151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_3B7;
				case 5:
					num = (short)848560129;
					if (num != 0)
					{
					}
					if (!string.Equals(codeplug.ModelNumber, radio.ModelNumber))
					{
						num = (short)680787981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3BC;
				case 6:
				{
					num = (short)652147956;
					short num3 = num;
					num = (short)1787821300;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25E;
					default:
						num = (short)527106048;
						if (num != 0)
						{
						}
						if (writeType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
						{
							num = (short)96010250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_263;
					}
					break;
				}
				case 7:
					if (writeType != global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_CLONE)
					{
						num = (short)1416495112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					goto IL_25E;
				case 9:
					goto IL_43D;
				case 10:
					num = (short)1959460881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (string.IsNullOrEmpty(radio.SerialNumber))
					{
						num = (short)1981087753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)287637526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (string.IsNullOrEmpty(codeplug.SerialNumber))
					{
						num = (short)1234632705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)446103563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1070661638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)798097431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_1AF;
				case 16:
					if (writeType == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_READ_WRITE)
					{
						num = (short)306708484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3BC;
				case 17:
					if (writeType != global::SpecialFeatures.Comms.COMMS_OP.USB_READ_WRITE)
					{
						num = (short)1248919552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_263;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 19:
					goto IL_AB;
				case 20:
					if (writeType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_CLONE)
					{
						num = (short)737935374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
					num = (short)969670676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (!string.Equals(codeplug.SerialNumber, radio.SerialNumber))
					{
						num = (short)1870856213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 23:
					if (writeType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
					{
						num = (short)1496121347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_84:
				if (string.IsNullOrEmpty(codeplug.ModelNumber))
				{
					num = (short)363069459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1677328386;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BC:
				num = (short)1338441740;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			throw new global::System.Exception(global::CommonResources.AppResources.The_Model_Number_of_codeplug_is_NullOrEmpty);
			IL_1AF:
			num = (short)1158283264;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::CommonResources.AppResources.The_Model_Number_of_radio_is_NullOrEmpty);
			IL_25E:
			throw new global::System.Exception(global::CommonResources.AppResources.Invalid_radio_serial_number);
			IL_263:
			throw new global::System.Exception(global::CommonResources.AppResources.Invalid_radio_model_number);
			IL_3B7:
			goto IL_263;
			IL_3F8:
			throw new global::System.ArgumentNullException(global::CommonResources.AppResources.The_Serial_Number_of_codeplug_is_NullOrEmpty);
			IL_43D:
			throw new global::System.ArgumentNullException(global::CommonResources.AppResources.The_Serial_Number_of_radio_is_NullOrEmpty);
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x001A2EF0 File Offset: 0x001A10F0
		internal static bool FlashCodeMatch(string radioFlashInfo, string codeplgFlashInfo)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = true;
					goto IL_BD;
				case 1:
					goto IL_D8;
				case 2:
				{
					num2 = (short)67174400;
					short num3 = num2;
					num2 = (short)282263553;
					if (num2 != 0)
					{
					}
					if (global::SpecialFeatures.Comms.RadioOperationValidator.a(radioFlashInfo) == global::System.Text.Encoding.ASCII.GetString(global::System.Convert.FromBase64String(codeplgFlashInfo)))
					{
						num2 = (short)208994304;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D8;
				}
				}
				goto IL_1C;
				IL_BD:
				num2 = (short)1773928449;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D8:
				num2 = (short)230319590;
				short num4 = num2;
				num2 = (short)1754686950;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_BD;
				default:
					goto IL_10E;
				}
			}
			IL_10E:
			num2 = (short)1511260160;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			result = false;
			num2 = (short)1561264130;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x001A3024 File Offset: 0x001A1224
		private static string a(string A_0)
		{
			short num = (short)39256064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				byte[] array;
				int sourceIndex;
				byte[] array2;
				int num4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_1C0;
					case 1:
						num = (short)254541830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1C2;
					case 3:
						goto IL_1C2;
					case 4:
					{
						num = (short)737738752;
						short num3 = num;
						global::System.Array.Copy(array, sourceIndex, array2, 0, 12);
						num = (short)790560775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (num4 >= 24)
						{
							goto IL_1E3;
						}
						array2[num4] = 0;
						num4++;
						num = (short)868745218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (array.Length == 16)
						{
							num = (short)1607794692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Array.Copy(array, sourceIndex, array2, 0, 24);
						num = (short)524603635;
						short num5 = num;
						num = (short)1600835827;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E3;
						default:
							num = (short)412549120;
							if (num != 0)
							{
							}
							num = (short)1438187520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_C6;
					}
					goto IL_4E;
					IL_1C2:
					num = (short)28704773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E3:
					num = (short)591986689;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C6:
				IL_1C0:
				return global::SpecialFeatures.Flashport.FlashRadio.FlashcodeFormatter.FormatFlashcodeString(array2, array2.Length);
				IL_4E:
				num = (short)451608577;
				if (num != 0)
				{
				}
				array = global::System.Convert.FromBase64String(A_0);
				sourceIndex = 2;
				array2 = new byte[24];
				num4 = 0;
				num = (short)781844483;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x001A323C File Offset: 0x001A143C
		internal static void RadioFlashCodeCheck(global::Motorola.Common.Communication.Pba.PbaObject xpbaCodeplug, global::SpecialFeatures.Comms.COMMS_OP WriteType)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			string radioFlashInfo;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1231159297;
					if (num2 != 0)
					{
					}
					goto IL_12F;
				case 1:
					if (!global::SpecialFeatures.Comms.RadioOperationValidator.FlashCodeMatch(radioFlashInfo, global::SpecialFeatures.Comms.ParseDataHelper.getCodeplugFlashCode()))
					{
						num2 = (short)1155006472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_READ_WRITE)
					{
						num2 = (short)754974723;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12F;
				case 3:
					goto IL_19D;
				case 4:
					num2 = (short)422313985;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.OTAP_READ_WRITE)
					{
						num2 = (short)559742985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12F;
				case 6:
					if (WriteType != global::SpecialFeatures.Comms.COMMS_OP.USB_CLONE)
					{
						num2 = (short)1076625412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					if (WriteType == global::SpecialFeatures.Comms.COMMS_OP.BLUETOOTH_READ_WRITE)
					{
						num2 = (short)2119761920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
				{
					num2 = (short)2137868753;
					short num3 = num2;
					num2 = (short)851266001;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19D;
					default:
						goto IL_117;
					}
					break;
				}
				case 9:
					num2 = (short)805240834;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_12F:
				num2 = (short)1759444998;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_19D:
				num2 = (short)353107975;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_117:
			num2 = (short)5570560;
			if (num2 != 0)
			{
			}
			throw new global::System.Exception(global::CommonResources.AppResources.FlashCode_mismatch_cannot_write_to_radio);
			IL_38:
			radioFlashInfo = global::System.Convert.ToBase64String(global::SpecialFeatures.Comms.ParseDataHelper.GetFDB(xpbaCodeplug));
			num2 = (short)2025586688;
			short num4 = num2;
			num2 = (short)484704261;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x001A3454 File Offset: 0x001A1654
		internal static bool PerformCompatibilityChecks(global::Motorola.Common.Communication.Pba.PbaObject pba, string cpgModelNumber, string radioModelNumber, ref string stsErrMsg)
		{
			short num = (short)1704011531;
			short num2 = num;
			num = (short)1626613515;
			switch (num2 == num)
			{
			}
			num = (short)473169920;
			if (num != 0)
			{
			}
			num = (short)1618280449;
			if (num != 0)
			{
			}
			num = (short)3080192;
			short num3 = num;
			string radioFlashcodeFromFBD = global::SpecialFeatures.Comms.ParseDataHelper.GetRadioFlashcodeFromFBD(global::SpecialFeatures.Comms.ParseDataHelper.GetFDB(pba));
			string radInfoFLASHportFLASHcode_A8132Value = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
			return new global::SpecialFeatures.Clone_Configuration.Common.CompatibilityChecks(global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.getUsedFcodeValue(), radInfoFLASHportFLASHcode_A8132Value, radioFlashcodeFromFBD, cpgModelNumber, radioModelNumber).PerfomChecks(ref stsErrMsg);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x001A353C File Offset: 0x001A173C
		internal static bool Is800MHzBandEnabledInRadio(global::SpecialFeatures.Comms.RadioParams curRadioParms, global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			short num = (short)989629685;
			short num2 = num;
			num = (short)105745653;
			switch (num2 == num)
			{
			}
			num = (short)306577408;
			if (num != 0)
			{
			}
			num = (short)1204027393;
			if (num != 0)
			{
			}
			num = (short)1675886592;
			short num3 = num;
			string radioFlashcodeFromFBD = global::SpecialFeatures.Comms.ParseDataHelper.GetRadioFlashcodeFromFBD(global::SpecialFeatures.Comms.ParseDataHelper.GetFDB(pba));
			return global::SpecialFeatures.Security.RadioAccessValidator.Is800MHzBandEnabled(curRadioParms.ModelNumber, radioFlashcodeFromFBD);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x001A35FC File Offset: 0x001A17FC
		public static bool IsRadioConvOnly(string modelNumber, string flashCode, bool fromCodeplug)
		{
			short num = (short)1994844579;
			short num2 = num;
			num = (short)1892870563;
			switch (num2 == num)
			{
			}
			num = (short)1138950145;
			if (num != 0)
			{
			}
			num = (short)663814144;
			if (num != 0)
			{
			}
			num = (short)1553268736;
			short num3 = num;
			return global::SpecialFeatures.Security.RadioAccessValidator.IsConvOnly(modelNumber, flashCode, fromCodeplug);
		}
	}
}
