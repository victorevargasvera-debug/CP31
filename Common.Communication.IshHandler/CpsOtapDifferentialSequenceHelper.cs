using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonFile;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.IshHandler
{
	// Token: 0x02000008 RID: 8
	public class CpsOtapDifferentialSequenceHelper : global::Motorola.Common.Communication.ICpsSequenceManagerHelper
	{
		// Token: 0x0600002E RID: 46 RVA: 0x0000734C File Offset: 0x0000554C
		public CpsOtapDifferentialSequenceHelper(global::Motorola.Common.Communication.IshHandler.IRadioCommand radioCommand, global::Motorola.Common.Communication.IshHandler.ICpsOtapDifferentialSequenceHelperCallback callback, ushort[] readPartitions, ushort[] writePartitions)
		{
			if (radioCommand != null && callback != null && readPartitions != null && readPartitions.Length != 0 && writePartitions != null)
			{
				if (writePartitions.Length != 0)
				{
					this.a = radioCommand;
					this.b = callback;
					this.c = readPartitions;
					this.d = writePartitions;
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000073A8 File Offset: 0x000055A8
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			short num = (short)818216960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				double num4;
				for (;;)
				{
					IL_28:
					num = (short)288817152;
					short num3 = num;
					global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
					global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
					switch (num2)
					{
					case 0:
						num = (short)2112552980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return pbaObject;
					case 2:
					{
						global::Motorola.Common.Communication.IProgressIndicator progress = this.b.Progress;
						if (progress == null)
						{
							num = (short)398458884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						progress.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						num = (short)542769155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1C2;
					case 4:
						goto IL_1C2;
					case 5:
					{
						ushort previousSessionID;
						bool flag = this.a.StartOtapSession(sessionID, previousSessionID, true);
						global::Motorola.Common.Communication.IProgressIndicator progress2 = this.b.Progress;
						if (progress2 != null)
						{
							progress2.UpdateProgress(0.05, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
						}
						num4 -= 0.05;
						if (flag)
						{
							num = (short)433848326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						pbaObject = this.b(referencePba, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.b.Progress, num4));
						num = (short)1676214290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						pbaObject = this.a(referencePba, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.b.Progress, num4));
						num = (short)1743716363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (this.b.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
						{
							num = (short)222756879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134;
					case 8:
					{
						global::Motorola.Common.Communication.IProgressIndicator progress3 = this.b.Progress;
						if (progress3 != null)
						{
							progress3.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
							num = (short)1963524097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)912285684;
						short num5 = num;
						num = (short)1333288948;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DA;
						default:
							num = (short)661323776;
							if (num != 0)
							{
							}
							num = (short)161808398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						num = (short)88866817;
						if (num != 0)
						{
						}
						if (referencePba.CodeplugData != null)
						{
							num = (short)1184628736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134;
					case 10:
						goto IL_1DA;
					case 11:
						goto IL_E8;
					case 12:
					{
						ushort previousSessionID = referencePba.CodeplugData.ArchiveSessionID;
						num = (short)1949106193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)985858057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return pbaObject;
					case 15:
						num = (short)2035941392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (referencePba != null)
						{
							num = (short)2037645325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134;
					case 17:
						goto IL_134;
					case 18:
						goto IL_E8;
					case 19:
						goto IL_1FF;
					case 20:
						if (string.Equals(deviceInfo.CodeplugVersion, referencePba.CodeplugData.CPVersion, global::System.StringComparison.OrdinalIgnoreCase))
						{
							num = (short)1936982028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134;
					}
					goto IL_AF;
					IL_E8:
					pbaObject.CodeplugData.CPVersion = deviceInfo.CodeplugVersion;
					pbaObject.CodeplugData.ArchiveSessionID = sessionID;
					num = (short)237043720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_134:
					num = (short)1343160325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C2:
					num = (short)1783234570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DA:
					if (this.b.IsLowBattery())
					{
						num = (short)1658716179;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						deviceInfo = this.b.GetDeviceInfo();
						pbaObject = null;
						ushort previousSessionID = 0;
						num = (short)331415559;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_1FF:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
				IL_AF:
				num4 = 1.0;
				num = (short)1415053314;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00007878 File Offset: 0x00005A78
		private global::Motorola.Common.Communication.Pba.PbaObject b(global::Motorola.Common.Communication.Pba.PbaObject A_0, global::Motorola.Common.Communication.IProgressIndicator A_1)
		{
			int a_ = 17;
			short num = (short)1535639553;
			if (num != 0)
			{
			}
			if (!this.c(A_0))
			{
				num = (short)44365873;
				short num2 = num;
				num = (short)12449841;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)778371072;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("ﺹ햻\ud8bdꚿꟁ뛃ꏅꛇ뻉ꗋ꿍볏鯓苕駗諙ﳛ곝藟菡胣웥軧鿩胫苭탯釱鯳鋵鷷駹鏻髽旿爁栃猅漇⨉渋眍』我甓搕気猙栛眝伟䰡圣ࠥ", a_), global::System.Array.Empty<object>());
					return this.a.ReadCodeplugItemsInPartitions(this.c, A_1);
				}
			}
			num = (short)1718550528;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("ﺹ햻\ud8bdꚿꟁ뛃ꏅꛇ뻉ꗋ꿍볏鯓苕駗諙ﳛ곝藟菡胣웥軧鿩胫苭탯釱鯳鋵鷷駹鏻髽旿爁栃猅漇⨉渋眍』昑洓昕紗椙㈛", a_), global::System.Array.Empty<object>());
			return this.a.ReadCodeplugItemsByTypes(A_0.InterestTypes.Distinct<ushort>(), A_1);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000799C File Offset: 0x00005B9C
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.Communication.Pba.PbaObject A_0, global::Motorola.Common.Communication.IProgressIndicator A_1)
		{
			int a_ = 2;
			short num = (short)1385234432;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplugInIshItemCollection;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_35D;
					case 1:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("쒬즮ힰ횲잴튶ힸ쾺풼\udebe귀諄鏆裈鯊뷎듐닒뇔뷘닚믜맞쇠胢諤菦賨裪苬诮铰菲駴苶黸\udbfa鿼蛾℀眂簄眆氈砊⌌", a_), global::System.Array.Empty<object>());
						ishItemCollection = this.a.ReadDifferetialCodeplugByIshTypes(A_0.InterestTypes.Distinct<ushort>(), A_1);
						num = (short)354156544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_35D;
					case 3:
						try
						{
							num = (short)403570698;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									codeplugInIshItemCollection.RemoveAll(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>, bool>(a2.b));
									num = (short)670826502;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.Common.Communication.CommonUtil.IshItem value;
									if (value.ItemSize == 0)
									{
										num = (short)2037121031;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									codeplugInIshItemCollection.Update(a2.a.Key, a2.a.Value);
									num = (short)559218689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_29F;
								case 4:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key;
									if (key.IshID == 65535)
									{
										num = (short)1674117120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									codeplugInIshItemCollection.Remove(a2.a.Key);
									num = (short)724041737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1105985539;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.Common.Communication.CommonUtil.IshHeader key = a2.a.Key;
									num = (short)848232452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1790115845;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> a = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.IshItem value = a.Value;
									num = (short)2112815106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									switch (0)
									{
									case 0:
										goto IL_102;
									}
									continue;
								}
								IL_13A:
								num = (short)1427439624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_102:
								goto IL_13A;
							}
							IL_29F:
							goto IL_452;
						}
						finally
						{
							num = (short)1729363970;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)302099113;
									short num3 = num;
									num = (short)686205609;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										goto IL_345;
									}
									break;
								}
								case 1:
									enumerator.Dispose();
									num = (short)475660288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2D6;
									}
									continue;
								}
								IL_2D6:
								if (enumerator == null)
								{
									goto IL_35C;
								}
								num = (short)372703233;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_345:
							num = (short)1728053248;
							if (num != 0)
							{
							}
							IL_35C:;
						}
						goto IL_35D;
					case 4:
						if (this.c(A_0))
						{
							num = (short)1444937729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.IshHandler.Validator.b("쒬즮ힰ횲잴튶ힸ쾺풼\udebe귀諄鏆裈鯊뷎듐닒뇔뷘닚믜맞쇠胢諤菦賨裪苬诮铰菲駴苶黸\udbfa鿼蛾℀猂搄甆紈戊礌明縐紒昔㤖", a_), global::System.Array.Empty<object>());
						ishItemCollection = this.a.ReadDifferetialCodeplugInPartitions(this.c, A_1);
						num = (short)1679491074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B;
					IL_35D:
					num = (short)17170432;
					short num4 = num;
					codeplugInIshItemCollection = A_0.GetCodeplugInIshItemCollection();
					enumerator = ishItemCollection.GetEnumerator();
					num = (short)1703149571;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_452:
				A_0.SetCodeplug(codeplugInIshItemCollection);
				return A_0;
				IL_4B:
				ishItemCollection = null;
				num = (short)389677057;
				if (num != 0)
				{
				}
				num = (short)865009668;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00007E20 File Offset: 0x00006020
		private bool c(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)1623261193;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1F6;
				case 1:
				{
					if (A_0.CodeplugData != null)
					{
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.b.GetDeviceInfo();
						num = (short)1470169096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1239678044;
					short num3 = num;
					num = (short)1890384988;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F6;
					default:
						num = (short)1376649216;
						if (num != 0)
						{
						}
						num = (short)1707802628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_21E;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
				{
					num = (short)2133065728;
					short num4 = num;
					if (A_0.InterestTypes != null)
					{
						num = (short)845021190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 6:
					num = (short)592117760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return false;
				case 8:
				{
					num = (short)1872953345;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
					if (A_0.CodeplugData.CPVersion != deviceInfo.CodeplugVersion)
					{
						num = (short)865730563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 9:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				}
				IL_4D:
				if (A_0 == null)
				{
					num = (short)776863751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2111438853;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F6:
				if (A_0.InterestTypes.Count == 0)
				{
					num = (short)606666754;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1159725057;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_21E:
			return false;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00008050 File Offset: 0x00006250
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			short num2;
			double num4;
			for (;;)
			{
				IL_0A:
				int num;
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_217;
				case 1:
					goto IL_390;
				case 2:
					goto IL_390;
				case 3:
					num2 = (short)2077097985;
					if (num2 != 0)
					{
					}
					num2 = (short)1403387913;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)19267592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					global::Motorola.Common.Communication.IProgressIndicator progress = this.b.Progress;
					if (progress == null)
					{
						num2 = (short)206962688;
						short num3 = num2;
						num2 = (short)845676559;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					progress.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
					num2 = (short)1102315527;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (this.b.IsLowBattery())
					{
						num2 = (short)245432336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1261568012;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					return pbaObject;
				case 8:
				{
					if (pbaObject.DifferetialCodeplugData == null)
					{
						num2 = (short)1284571153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection = new global::Motorola.Common.Communication.Pba.PbaObject
					{
						CodeplugData = pbaObject.DifferetialCodeplugData
					}.GetCodeplugInIshItemCollection();
					ishItemCollection = new global::Motorola.Common.Communication.IshHandler.IshItemsWriteFilter(this.d, null).GetCollectionToWrite(ishItemCollection);
					string text;
					this.a(ishItemCollection, sessionID, text, true, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.b.Progress, num4));
					num2 = (short)833355777;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					flag = (null != null);
					goto IL_1FD;
				case 10:
					goto IL_11E;
				case 11:
					goto IL_11E;
				case 12:
					if (pbaObject == null)
					{
						num2 = (short)56819715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)143261709;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					flag = (pbaObject.CodeplugData != null);
					goto IL_1FD;
				case 14:
				{
					bool flag2 = this.a.StartOtapSession(sessionID, pbaObject.CodeplugData.ArchiveSessionID, false);
					string text = this.b(pbaObject);
					if (string.IsNullOrEmpty(text))
					{
						text = this.a(pbaObject);
					}
					global::Motorola.Common.Communication.IProgressIndicator progress2 = this.b.Progress;
					if (progress2 != null)
					{
						progress2.UpdateProgress(0.05);
					}
					num4 -= 0.05;
					if (flag2)
					{
						num2 = (short)1029701636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a(pbaObject, sessionID, text, new global::Motorola.Common.Communication.IteratedProgressIndicator(this.b.Progress, num4));
					num2 = (short)326762498;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 15:
					return pbaObject;
				case 16:
					goto IL_15A;
				case 17:
					goto IL_2EF;
				case 18:
				{
					global::Motorola.Common.Communication.IProgressIndicator progress3 = this.b.Progress;
					if (progress3 == null)
					{
						goto IL_DC;
					}
					progress3.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WritingCP);
					num2 = (short)1273167882;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_5C;
				IL_11E:
				num2 = (short)1243938822;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FD:
				if (!flag)
				{
					num2 = (short)1501233152;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)1507852302;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_390:
				pbaObject.CodeplugData.ArchiveSessionID = sessionID;
				num2 = (short)269221893;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_15A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_BatteryLevelLow);
			IL_217:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_2EF:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Pcr_DiffWriteNoChange);
			IL_5C:
			num4 = 1.0;
			num2 = (short)931753943;
			short num5 = num2;
			num2 = (short)1899524055;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DC:
				num2 = (short)55181323;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1862336512;
				if (num2 != 0)
				{
				}
				num2 = (short)403701778;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00008494 File Offset: 0x00006694
		private void a(global::Motorola.Common.Communication.Pba.PbaObject A_0, ushort A_1, string A_2, global::Motorola.Common.Communication.IProgressIndicator A_3)
		{
			short num = (short)1847525376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType> list;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1826947073;
						if (num != 0)
						{
						}
						try
						{
							ishItemCollection = new global::Motorola.Common.Communication.IshHandler.IshItemsWriteFilter(this.d, A_0.InterestTypes).GetCollectionToWrite(ishItemCollection);
							this.a(ishItemCollection, A_1, A_2, false, A_3);
							return;
						}
						finally
						{
							num = (short)389677057;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1A5;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_164;
									}
									continue;
								case 2:
									A_3.UpdateProgress(1.0);
									num = (short)1825439744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_164:
								if (A_3 == null)
								{
									break;
								}
								num = (short)1421475842;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A5:;
						}
						goto IL_1A8;
					case 1:
						if (A_3 != null)
						{
							num = (short)64356355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A8;
					case 2:
						if (A_0.IDDeletableTypes != null)
						{
							num = (short)522321933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43B;
					case 3:
						A_3.UpdateProgress(0.0);
						num = (short)247529482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_43B;
					case 5:
						list.AddRange(A_0.DeletableTypes);
						num = (short)425721867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (A_0.DeletableTypes != null)
						{
							num = (short)722141189;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A8;
					case 7:
						if (list.Count > 0)
						{
							num = (short)377094153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E8;
					case 8:
						goto IL_1E8;
					case 9:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.Pba.DataBlockType> enumerable = list.Distinct<global::Motorola.Common.Communication.Pba.DataBlockType>();
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>>();
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.DataBlockType> enumerator = enumerable.GetEnumerator();
						num = (short)1979973644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_4A8;
					case 11:
						goto IL_1A8;
					case 12:
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> list2;
						try
						{
							num = (short)1686765571;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.DataBlockType> enumerator;
								global::Motorola.Common.Communication.IshHandler.CpsOtapDifferentialSequenceHelper.b b;
								switch (num2)
								{
								case 1:
									if (!ishItemCollection.Headers.Where(new global::System.Func<global::Motorola.Common.Communication.CommonUtil.IshHeader, bool>(b.b)).Any<global::Motorola.Common.Communication.CommonUtil.IshHeader>())
									{
										num = (short)1166475270;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)765526020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_26E;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_269;
									}
									continue;
								case 4:
									num = (short)424673285;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_3C9;
								case 6:
								{
									num = (short)1617536749;
									short num3 = num;
									num = (short)2019403501;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_26E;
									default:
										num = (short)792461312;
										if (num != 0)
										{
										}
										list2.Add(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>(new global::Motorola.Common.Communication.CommonUtil.IshHeader(b.a.PartitionID, b.a.TypeID, ushort.MaxValue), new global::Motorola.Common.Communication.CommonUtil.IshItem(0, null, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Undefined)));
										num = (short)1847328768;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_269;
								IL_26E:
								b = new global::Motorola.Common.Communication.IshHandler.CpsOtapDifferentialSequenceHelper.b();
								b.a = enumerator.Current;
								num = (short)2034827265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_372:
								num = (short)781058050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_269:
								goto IL_372;
							}
							IL_3C9:
							goto IL_4EE;
						}
						finally
						{
							num = (short)867827713;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.DataBlockType> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_438;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_401;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1379663872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_401:
								if (enumerator == null)
								{
									break;
								}
								num = (short)752484354;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_438:;
						}
						goto IL_43B;
						IL_4EE:
						ishItemCollection.UpdateRange(list2);
						num = (short)1831075848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						list.AddRange(A_0.IDDeletableTypes);
						num = (short)826867716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66;
					IL_1A8:
					num = (short)689111042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E8:
					num = (short)196345857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43B:
					num = (short)2077818880;
					short num4 = num;
					num = (short)992542727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A8:
					num = (short)626851840;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_66:
				ishItemCollection = A_0.GetCodeplugInIshItemCollection();
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.DataBlockType>();
				num = (short)347537414;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00008A44 File Offset: 0x00006C44
		private void a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0, ushort A_1, string A_2, bool A_3, global::Motorola.Common.Communication.IProgressIndicator A_4)
		{
			int a_ = 16;
			short num = (short)812777472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
				pbaObject.SetCodeplug(A_0);
				global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader codeplugCommFileHeader = new global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader();
				codeplugCommFileHeader.HeaderVer = 16;
				global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug fullDelta;
				if (!A_3)
				{
					fullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Full;
					goto IL_26D;
				}
				IL_267:
				fullDelta = global::Motorola.Common.Communication.CommonFile.FullDeltaCodeplug.Delta;
				IL_26D:
				codeplugCommFileHeader.FullDelta = fullDelta;
				codeplugCommFileHeader.Level = global::Motorola.Common.Communication.CommonFile.InfoLevel.CodeplugData;
				global::Motorola.Common.Communication.CommonFile.CodeplugCommFileHeader fileHeader = codeplugCommFileHeader;
				byte[] array = new global::Motorola.Common.Communication.CommonFile.PartitionCommonFile(this.a.IsCommonFileCrcBigEndian).Serialize(fileHeader, pbaObject);
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					string text2;
					for (;;)
					{
						IL_57:
						string text;
						switch (num2)
						{
						case 0:
							text = text2;
							goto IL_145;
						case 1:
							if (!string.IsNullOrEmpty(A_2))
							{
								num = (short)1143013380;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2141978624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							text = A_2 + global::Motorola.Common.Communication.IshHandler.Validator.b("隸", a_) + text2;
							goto IL_145;
						case 3:
							goto IL_1A5;
						case 4:
							num = (short)395640834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72;
						IL_145:
						string fileName = text;
						this.a.FileWrite(0, fileName, memoryStream, new global::Motorola.Common.Communication.IteratedProgressIndicator(A_4, 0.99), false);
						num = (short)1910571009;
						if (num != 0)
						{
						}
						num = (short)1498546179;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1A5:
					goto IL_29D;
					IL_72:
					memoryStream.Write(array, 0, array.Length);
					text2 = 1U.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.IshHandler.Validator.b("", a_) + 2.ToString(global::System.Globalization.CultureInfo.InvariantCulture) + global::Motorola.Common.Communication.IshHandler.Validator.b("誺鎼\udcbe곀돂", a_);
					num = (short)1615200257;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				finally
				{
					num = (short)139657217;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_264;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1DC;
							}
							continue;
						case 2:
						{
							num = (short)1263577636;
							short num3 = num;
							num = (short)1546299940;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E2;
							default:
								num = (short)205717504;
								if (num != 0)
								{
								}
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)880607232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_1DC;
						IL_1E2:
						num = (short)805109762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1DC:
						if (memoryStream != null)
						{
							goto IL_1E2;
						}
						break;
					}
					IL_264:;
				}
				goto IL_267;
				IL_29D:
				num = (short)2060255232;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00008D34 File Offset: 0x00006F34
		private string b(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)875692032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
				string result;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> validateItemsToRead;
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)1559953415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (A_0.ValidationSpecialFields.Count > 0)
						{
							num = (short)206372866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CD;
					case 2:
					{
						num = (short)1612913044;
						short num3 = num;
						num = (short)571087252;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_329;
						default:
							num = (short)1945763840;
							if (num != 0)
							{
							}
							this.a(A_0.ValidationSpecialFields, deviceInfo);
							num = (short)887160849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						global::Motorola.Common.Communication.IshHandler.Validator.ValidateInfos(A_0.ValidationInfos, deviceInfo, null);
						num = (short)1752825861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!string.Equals(deviceInfo.CodeplugVersion, A_0.CodeplugData.CPVersion, global::System.StringComparison.OrdinalIgnoreCase))
						{
							num = (short)1850605578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)371261449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_29A;
					case 6:
						validateItemsToRead = global::Motorola.Common.Communication.IshHandler.Validator.GetValidateItemsToRead(A_0.ValidationFields);
						num = (short)1197998088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)667484161;
						if (num != 0)
						{
						}
						if (A_0.ValidationInfos.Count > 0)
						{
							num = (short)1909194755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					case 8:
						goto IL_329;
					case 9:
						if (A_0.ValidationSpecialFields != null)
						{
							num = (short)1497301006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CD;
					case 10:
						goto IL_CB;
					case 11:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationField> validationFields = A_0.ValidationFields;
						if (validationFields == null)
						{
							num = (short)1230372877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = validationFields.Any<global::Motorola.Common.Communication.Pba.ValidationField>();
						goto IL_2E4;
					}
					case 12:
					{
						num = (short)981467136;
						short num4 = num;
						global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishInRadio = this.a.ReadItemsByIshHeaders(validateItemsToRead, out result, null);
						global::Motorola.Common.Communication.IshHandler.Validator.ValidateFields(A_0.ValidationFields, ishInRadio);
						num = (short)1188954127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						flag = false;
						goto IL_2E4;
					case 14:
						num = (short)2001403905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_3A3;
					case 16:
						if (A_0.ValidationInfos != null)
						{
							num = (short)679280640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					case 17:
						goto IL_1CD;
					}
					goto IL_77;
					IL_1CD:
					num = (short)1847984144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29A:
					result = null;
					num = (short)1605107723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E4:
					if (flag)
					{
						num = (short)368967686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
					IL_329:
					if (validateItemsToRead == null)
					{
						goto IL_3A5;
					}
					num = (short)1422524428;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
				IL_3A3:
				return result;
				IL_3A5:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_77:
				deviceInfo = this.b.GetDeviceInfo();
				num = (short)1881538564;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000090F0 File Offset: 0x000072F0
		private void a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.ValidationSpecialField> A_0, global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_1)
		{
			short num = (short)1939800066;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Communication.Pba.ValidationSpecialField> enumerator;
				global::System.Func<global::Motorola.Common.Communication.Pba.ValidationSpecialField, bool> predicate;
				switch (num2)
				{
				case 0:
					goto IL_3C0;
				case 1:
					if (!A_0.Any<global::Motorola.Common.Communication.Pba.ValidationSpecialField>())
					{
						num = (short)1943142400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)589365253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
				{
					num = (short)99352576;
					short num3 = num;
					num = (short)383582209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)425721857;
					if (num != 0)
					{
					}
					try
					{
						num = (short)1056571397;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
							{
								global::Motorola.Common.Communication.Pba.ValidationSpecialField validationSpecialField;
								global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.Communication_Astro_CruncherPasswordValidationFailsRadioLocked);
								num = (short)568000516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								if (((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)A_1).PasswordStatus.RemainingAttempts <= 3)
								{
									num = (short)1114701830;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Pba.ValidationSpecialField validationSpecialField;
								global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.Communication_Astro_CruncherPasswordValidationFails);
								num = (short)695730176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)603521033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_103;
								}
								continue;
							case 6:
							{
								global::Motorola.Common.Communication.Pba.ValidationSpecialField validationSpecialField;
								global::Motorola.Common.Communication.IshHandler.Validator.ThrowException(validationSpecialField.ErrorToThrow, global::Motorola.Common.CustomException.CommonErrorCode.Communication_Astro_CruncherPasswordValidationFailsRemainingAttempt);
								num = (short)529596423;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								global::Motorola.Common.Communication.Pba.ValidationSpecialField validationSpecialField;
								if (!this.a(validationSpecialField.Value, A_1))
								{
									num = (short)1925447683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								if (((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)A_1).PasswordStatus.RemainingAttempts <= 0)
								{
									num = (short)672858113;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)2079129602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_2AD;
							case 11:
								num = (short)787480586;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)565575691;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.Common.Communication.Pba.ValidationSpecialField validationSpecialField = enumerator.Current;
								num = (short)187564040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_16C:
							num = (short)1447165964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_103:
							goto IL_16C;
						}
						IL_2AD:
						return;
					}
					finally
					{
						num = (short)1769865217;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_36A;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2E3;
								}
								continue;
							case 2:
							{
								num = (short)1697195615;
								short num4 = num;
								num = (short)1122248287;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2E9;
								default:
									num = (short)156434432;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)929038336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							goto IL_2E3;
							IL_2E9:
							num = (short)575602690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2E3:
							if (enumerator != null)
							{
								goto IL_2E9;
							}
							break;
						}
						IL_36A:;
					}
					goto IL_36D;
				case 5:
					if ((predicate = global::Motorola.Common.Communication.IshHandler.CpsOtapDifferentialSequenceHelper.<>c.<>9__13_0) == null)
					{
						goto IL_36D;
					}
					goto IL_3C5;
				}
				IL_3D:
				if (A_0 != null)
				{
					num = (short)600047619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_3C5:
				enumerator = A_0.Where(predicate).GetEnumerator();
				num = (short)1559429124;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36D:
				predicate = (global::Motorola.Common.Communication.IshHandler.CpsOtapDifferentialSequenceHelper.<>c.<>9__13_0 = new global::System.Func<global::Motorola.Common.Communication.Pba.ValidationSpecialField, bool>(global::Motorola.Common.Communication.IshHandler.CpsOtapDifferentialSequenceHelper.<>c.<>9.a));
				goto IL_3C5;
			}
			return;
			IL_3C0:;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00009530 File Offset: 0x00007730
		private bool a(string A_0, global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_1)
		{
			short num = (short)852426752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				bool result;
				global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo pcrdeviceInfo;
				string password;
				global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return true;
					case 1:
					{
						global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus;
						if (passwordStatus.Policy == global::Motorola.Common.Communication.CommonUtil.PasswordPolicy.Enhanced)
						{
							num = (short)1101266950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)277086212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus;
						if (passwordStatus.RemainingAttempts > 0)
						{
							num = (short)147980295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 3:
					{
						if (pcrdeviceInfo == null)
						{
							num = (short)953483264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus = pcrdeviceInfo.PasswordStatus;
						num = (short)108527617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return result;
					case 5:
						num = (short)301793282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1877868545;
						if (num != 0)
						{
						}
						num = (short)793509897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus;
						password = global::Motorola.Common.Communication.IshHandler.a.a(A_0, passwordStatus.Salt, passwordStatus.AlgorithmID);
						passwordStatus2 = this.a.ValidateLocalPassword(password);
						num = (short)1864826880;
						short num3 = num;
						num = (short)1210974219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.Common.Communication.CommonUtil.PasswordStatus passwordStatus;
						passwordStatus.RemainingAttempts = passwordStatus2.RemainingAttempts;
						result = passwordStatus2.IsPasswordValidationSuccess;
						num = (short)107806730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (!string.IsNullOrEmpty(A_0))
						{
							goto IL_296;
						}
						return result;
					case 10:
						return result;
					case 11:
					{
						if (passwordStatus2 == null)
						{
							return result;
						}
						num = (short)1514418434;
						short num4 = num;
						num = (short)1348546818;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_296;
						default:
							num = (short)1336737792;
							if (num != 0)
							{
							}
							num = (short)455999496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_5E;
					IL_296:
					num = (short)561512453;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_5E:
				result = false;
				password = string.Empty;
				passwordStatus2 = null;
				pcrdeviceInfo = (A_1 as global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo);
				num = (short)351404035;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000097F4 File Offset: 0x000079F4
		private string a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			short num = (short)839188481;
			if (num != 0)
			{
			}
			num = (short)699406142;
			short num2 = num;
			num = (short)962139966;
			switch (num2 == num)
			{
			}
			num = (short)958070784;
			if (num != 0)
			{
			}
			num = (short)1385562112;
			short num3 = num;
			global::Motorola.Common.Communication.CommonUtil.IshHeader item = A_0.GetCodeplugInIshItemCollection().Headers.First(new global::System.Func<global::Motorola.Common.Communication.CommonUtil.IshHeader, bool>(global::Motorola.Common.Communication.IshHandler.CpsOtapDifferentialSequenceHelper.<>c.<>9.a));
			global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommonUtil.IshHeader> ishHeaders = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.IshHeader>
			{
				item
			};
			string result;
			this.a.ReadItemsByIshHeaders(ishHeaders, out result, null);
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000098F0 File Offset: 0x00007AF0
		public void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)412053109;
			short num2 = num;
			num = (short)936996469;
			switch (num2 == num)
			{
			}
			num = (short)1820721153;
			if (num != 0)
			{
			}
			num = (short)1801977856;
			if (num != 0)
			{
			}
			num = (short)1835073536;
			short num3 = num;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00009998 File Offset: 0x00007B98
		public void CloseSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)1201995776;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 1:
					this.a.CloseOtapSession(sessionID, false);
					num = (short)1669660675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (!pendingDeploy)
					{
						return;
					}
					num = (short)1197951136;
					short num3 = num;
					num = (short)1775257760;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_148;
					default:
						num = (short)1951203328;
						if (num != 0)
						{
						}
						num = (short)339214337;
						if (num != 0)
						{
						}
						num = (short)535232513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return;
				case 4:
					goto IL_148;
				case 5:
				{
					num = (short)6029312;
					short num4 = num;
					num = (short)181927938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_5C;
				}
				IL_40:
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read)
				{
					num = (short)1803616262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1554644996;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_148:
				if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program)
				{
					return;
				}
				num = (short)478478341;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5C:
			this.a.CloseOtapSession(sessionID, !pendingDeploy);
		}

		// Token: 0x04000008 RID: 8
		private global::Motorola.Common.Communication.IshHandler.IRadioCommand a;

		// Token: 0x04000009 RID: 9
		private global::Motorola.Common.Communication.IshHandler.ICpsOtapDifferentialSequenceHelperCallback b;

		// Token: 0x0400000A RID: 10
		private ushort[] c;

		// Token: 0x0400000B RID: 11
		private ushort[] d;

		// Token: 0x02000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600003D RID: 61 RVA: 0x00009B5C File Offset: 0x00007D5C
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> A_0)
			{
				if (A_0.Key.PartitionNumber != this.a.Key.PartitionNumber)
				{
					short num = (short)2086813445;
					short num2 = num;
					num = (short)912473861;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)223084545;
						if (num != 0)
						{
						}
						num = (short)849215488;
						if (num != 0)
						{
						}
						num = (short)212467712;
						short num3 = num;
						return false;
					}
					}
				}
				return A_0.Key.IshType == this.a.Key.IshType;
			}

			// Token: 0x0400000C RID: 12
			public global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> a;
		}

		// Token: 0x0200000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x0600003F RID: 63 RVA: 0x00009C64 File Offset: 0x00007E64
			internal bool b(global::Motorola.Common.Communication.CommonUtil.IshHeader A_0)
			{
				global::Motorola.Common.Communication.CommonUtil.IshHeader ishHeader = A_0;
				if (ishHeader.IshType != this.a.TypeID)
				{
					short num = (short)1715404801;
					if (num != 0)
					{
					}
					num = (short)2083489433;
					short num2 = num;
					num = (short)1604617881;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1368588288;
						if (num != 0)
						{
						}
						num = (short)406781952;
						short num3 = num;
						return false;
					}
					}
				}
				ishHeader = A_0;
				return ishHeader.PartitionNumber == this.a.PartitionID;
			}

			// Token: 0x0400000D RID: 13
			public global::Motorola.Common.Communication.Pba.DataBlockType a;
		}
	}
}
