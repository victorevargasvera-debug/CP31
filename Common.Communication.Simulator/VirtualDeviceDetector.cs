using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;
using Motorola.Common.Communication.Pba;

namespace Common.Communication.Simulator
{
	// Token: 0x02000003 RID: 3
	public class VirtualDeviceDetector : global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Common.Communication.Simulator.VirtualDeviceDetector>, global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				short num = (short)1814233088;
				short num2 = num;
				num = (short)612067457;
				short num3 = num;
				num = (short)1814390913;
				switch (num3 == num)
				{
				}
				num = (short)1071841281;
				if (num != 0)
				{
				}
				num = (short)668925952;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.VirtualDeviceDetector;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		private string d()
		{
			int a_ = 16;
			short num = (short)1270153216;
			short num2 = num;
			num = (short)1013133328;
			short num3 = num;
			num = (short)272183312;
			string result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)578551809;
				if (num != 0)
				{
				}
				num = (short)1250426880;
				if (num != 0)
				{
				}
				result = string.Empty;
				try
				{
					result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Common.Communication.Simulator.VirtualLEDevices.b("ࡎ㑐❒畔⅖じ⥚⥜⩞`ར䕤Ŧ٨ݪ६੮Ͱ卲፴ᙶၸ᝺᡼᭾궀ꎂﮈﾌ꾎ﲐﲚꖞ", a_), new object[]
					{
						ex
					});
					result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::Common.Communication.Simulator.VirtualLEDevices.b("ፎݐ㩒❔⍖ⱘ㩚ㅜ൞`ݢ౤ࡦᩨ", a_);
				}
				break;
			}
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022EC File Offset: 0x000004EC
		public bool Start()
		{
			int a_ = 15;
			short num2;
			bool result;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				int num;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						if (!global::System.IO.Directory.Exists(this.c))
						{
							num2 = (short)222363649;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.c();
						global::System.Threading.Tasks.Task.Run<global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>>(new global::System.Func<global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>>(this.b));
						num2 = (short)332988419;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Common.Communication.Simulator.VirtualLEDevices.b("M㽏♑瑓さ㝗⽙㉛㩝䁟㑡㙣䙥ᡧ୩ᡫ٭", a_), global::System.Array.Empty<object>());
						result = true;
						num2 = (short)2090336258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_C9;
					case 3:
						goto IL_FD;
					}
					goto IL_29;
				}
				IL_C9:
				return result;
				IL_FD:
				goto IL_124;
				IL_29:
				this.c = this.d();
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Common.Communication.Simulator.VirtualLEDevices.b("ᡍ㥏⁑⁓⍕㥗㙙籛ⱝş١ൣ॥䡧ᩩ൫ᩭᡯ䡱味൵䡷ݹ", a_), new object[]
				{
					this.c
				});
				num2 = (short)1935147008;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Common.Communication.Simulator.VirtualLEDevices.b("്ㅏ♑㝓㹕硗㽙⹛ⱝཟၡ䑣॥٧䩩㩫㱭偯űs᝵੷๹ᕻၽ꺁ꒃ黎ﾋ뒓ꢗ", a_), new object[]
				{
					ex
				});
			}
			IL_124:
			num2 = (short)2102394880;
			short num3 = num2;
			num2 = (short)2072261888;
			short num4 = num2;
			num2 = (short)431502592;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
				num2 = (short)1422196737;
				if (num2 != 0)
				{
				}
				num2 = (short)568328192;
				if (num2 != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000024CC File Offset: 0x000006CC
		public void Stop()
		{
			short num = (short)1575747584;
			short num2 = num;
			num = (short)1409496095;
			short num3 = num;
			num = (short)780940319;
			switch (num3 == num)
			{
			}
			num = (short)819200000;
			if (num != 0)
			{
			}
			num = (short)683016193;
			if (num != 0)
			{
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000008 RID: 8 RVA: 0x00002578 File Offset: 0x00000778
		// (remove) Token: 0x06000009 RID: 9 RVA: 0x000026AC File Offset: 0x000008AC
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)849930654;
				short num2 = num;
				num = (short)775023006;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_108:
					if (deviceEventHandler != deviceEventHandler2)
					{
						goto IL_D3;
					}
					num = (short)1555169282;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1608581120;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8F;
					}
					break;
				}
				IL_54:
				num = (short)582483968;
				short num4 = num;
				switch (num3)
				{
				case 0:
					break;
				case 1:
					goto IL_108;
				case 2:
					return;
				default:
					IL_8F:
					num = (short)1364459521;
					if (num != 0)
					{
					}
					deviceEventHandler = this.d;
					num = (short)805306368;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_54;
				}
				IL_D3:
				deviceEventHandler2 = deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
				deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.d, value2, deviceEventHandler2);
				num = (short)1481375745;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1715932548;
				short num2 = num;
				num = (short)2119830916;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_104:
					if (deviceEventHandler != deviceEventHandler2)
					{
						goto IL_D3;
					}
					num = (short)405340162;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)608698368;
					if (num != 0)
					{
					}
					num = (short)1514209281;
					if (num != 0)
					{
					}
					num = (short)2102657024;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_B6;
					}
					break;
				}
				}
				IL_A4:
				switch (num3)
				{
				case 0:
					break;
				case 1:
					goto IL_104;
				case 2:
					return;
				default:
					IL_B6:
					deviceEventHandler = this.d;
					num = (short)1156775936;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_A4;
				}
				IL_D3:
				deviceEventHandler2 = deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
				deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.d, value2, deviceEventHandler2);
				num = (short)155189249;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_A4;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600000A RID: 10 RVA: 0x000027D8 File Offset: 0x000009D8
		// (remove) Token: 0x0600000B RID: 11 RVA: 0x0000290C File Offset: 0x00000B0C
		public event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)192607844;
				short num2 = num;
				num = (short)1822094948;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_E0:
					if (deviceEventHandler != deviceEventHandler2)
					{
						goto IL_AB;
					}
					num = (short)1914765314;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1987248128;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8E;
					}
					break;
				}
				IL_54:
				num = (short)462487552;
				short num4 = num;
				switch (num3)
				{
				case 0:
					break;
				case 1:
					goto IL_E0;
				case 2:
					num = (short)744685569;
					if (num != 0)
					{
					}
					return;
				default:
					IL_8E:
					deviceEventHandler = this.e;
					num = (short)999292928;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_54;
				}
				IL_AB:
				deviceEventHandler2 = deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Combine(deviceEventHandler2, value);
				deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.e, value2, deviceEventHandler2);
				num = (short)179109889;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_54;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)458146032;
				short num2 = num;
				num = (short)1127858416;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceEventHandler2;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_10C:
					if (deviceEventHandler != deviceEventHandler2)
					{
						goto IL_D7;
					}
					num = (short)1161494530;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1995243520;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B9;
					}
					break;
				}
				IL_55:
				num = (short)911409152;
				short num4 = num;
				num = (short)699072513;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					break;
				case 1:
					goto IL_10C;
				case 2:
					return;
				default:
					IL_B9:
					deviceEventHandler = this.e;
					num = (short)637927424;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_55;
				}
				IL_D7:
				deviceEventHandler2 = deviceEventHandler;
				global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler value2 = (global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler)global::System.Delegate.Remove(deviceEventHandler2, value);
				deviceEventHandler = global::System.Threading.Interlocked.CompareExchange<global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler>(ref this.e, value2, deviceEventHandler2);
				num = (short)1378484225;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002A44 File Offset: 0x00000C44
		public bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			short num = (short)1166606336;
			short num2 = num;
			num = (short)548436456;
			short num3 = num;
			num = (short)633698792;
			switch (num3 == num)
			{
			}
			num = (short)1397161984;
			if (num != 0)
			{
			}
			num = (short)439025665;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002AEC File Offset: 0x00000CEC
		private void c()
		{
			short num = (short)1807024128;
			short num2 = num;
			num = (short)1041425233;
			short num3 = num;
			num = (short)425255761;
			switch (num3 == num)
			{
			}
			num = (short)331677697;
			if (num != 0)
			{
			}
			num = (short)2073886720;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002B94 File Offset: 0x00000D94
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ScanVirtualDevices()
		{
			int a_ = 18;
			short num = (short)636813312;
			short num2 = num;
			num = (short)1538785280;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				IL_5A:
				global::System.Collections.Generic.IEnumerator<string> enumerator;
				switch (num3)
				{
				case 0:
					break;
				case 1:
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
					return list;
				}
				case 2:
					try
					{
						num = (short)1742929920;
						num3 = (int)((global::System.IntPtr)num);
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_16B;
								}
								continue;
							case 1:
							{
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>? keyValuePair;
								this.AttachDevice(keyValuePair.Value, false, false);
								list.Add(keyValuePair.Value.Key);
								num = (short)154796036;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>? keyValuePair;
								if (keyValuePair != null)
								{
									num = (short)1225654273;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2141519877;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								string path = enumerator.Current;
								global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>? keyValuePair = this.a(path);
								num = (short)811335682;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)802553862;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_247;
							}
							IL_1B4:
							num = (short)895680515;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_16B:
							goto IL_1B4;
						}
						IL_247:
						return list;
					}
					finally
					{
						num = (short)1396178944;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_27F;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)589627394;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_2B5;
							}
							IL_27F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)926089217;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2B5:;
					}
					goto IL_2B8;
				default:
				{
					IL_6D:
					num = (short)2139903023;
					short num4 = num;
					num = (short)423121967;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1628831745;
						if (num != 0)
						{
						}
						num = (short)1159266304;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
						num = (short)1553137664;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_5A;
					}
					}
					break;
				}
				}
				if (!global::System.IO.Directory.Exists(this.c))
				{
					num = (short)859242497;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_5A;
				}
				IL_2B8:
				enumerator = global::System.IO.Directory.EnumerateFiles(this.c, global::Common.Communication.Simulator.VirtualLEDevices.b("筐絒ⵔ❖㭘㩚", a_)).GetEnumerator();
				num = (short)1687093250;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5A;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002EB4 File Offset: 0x000010B4
		private global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>? a(string path)
		{
			short num = (short)173230557;
			short num2 = num;
			num = (short)2076527069;
			byte[] array;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_173:
				if (!global::Motorola.Common.CommonLib.CombineTool.IsPbaPlus_enhanced(array))
				{
					goto IL_1CF;
				}
				num = (short)1839464452;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)47448064;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_C2:
				switch (num3)
				{
				case 0:
					if (array != null)
					{
						num = (short)358285313;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CF;
				case 1:
					num = (short)1648230403;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_173;
				case 3:
					if (array.Length != 0)
					{
						num = (short)1448017925;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CF;
				case 4:
					goto IL_193;
				case 5:
				{
					byte[] destinationArray = new byte[4];
					global::System.Array.Copy(array, destinationArray, 4);
					num = (short)732299266;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_E1;
			}
			IL_193:
			global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(array);
			return new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>?(new global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>((global::Motorola.Common.Communication.CommonUtil.DeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list[1]), global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list[0], false)));
			IL_5E:
			num = (short)1507328000;
			if (num != 0)
			{
			}
			num = (short)1047134208;
			num3 = (int)num;
			switch (num3)
			{
			default:
				num = (short)2112815105;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_E1;
				}
				goto IL_C2;
			}
			IL_E1:
			array = global::System.IO.File.ReadAllBytes(path);
			num = (short)1318518784;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_C2;
			IL_1CF:
			return null;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000309C File Offset: 0x0000129C
		public bool AttachDevice(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject> device, bool forceAttach, bool keepRadioID = false)
		{
			int a_ = 18;
			short num = (short)773455872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AC;
				}
				global::Motorola.Common.Communication.CommonUtil.DeviceInfo key;
				for (;;)
				{
					IL_31:
					global::Motorola.Common.Communication.IRadioProfile radioProfile;
					global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs;
					switch (num2)
					{
					case 0:
						num = (short)667222017;
						if (num != 0)
						{
						}
						goto IL_24E;
					case 1:
						if (key is global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo)
						{
							num = (short)1520500754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1399914512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						radioProfile.PID = global::Common.Communication.Simulator.VirtualLEDevices.b("桐橒汔湖慘", a_);
						radioProfile.RadioType = global::Motorola.Common.Communication.RadioType.PCR;
						num = (short)75890712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = key;
						string str = this.b;
						int num3 = this.a;
						this.a = num3 + 1;
						deviceInfo.RadioID = str + global::System.Convert.ToString(num3);
						num = (short)660537369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_5D8;
					case 5:
						this.d(this, deviceMsgEventArgs);
						num = (short)2101149710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!global::Motorola.Common.Communication.CommonUtil.BasicFunctions.IsOtapDevice(device.Key))
						{
							num = (short)1085538316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						if (!keepRadioID)
						{
							num = (short)410583043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 8:
					{
						if (key.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.VRC)
						{
							((global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)key).DeviceWorkMode = global::Motorola.Common.Communication.CommonUtil.RRPWorkMode.NonDMR3;
							num = (short)488046603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1104033264;
						short num4 = num;
						num = (short)340407792;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_532;
						default:
							num = (short)511967232;
							if (num != 0)
							{
							}
							num = (short)1550123012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						if (key.ConnectionInfo == null)
						{
							num = (short)212402186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E;
					case 10:
						key.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
						num = (short)672464896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_59A;
					case 12:
						num = (short)1053818901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)1460994048;
						short num5 = num;
						goto IL_59A;
					}
					case 14:
						return false;
					case 15:
						goto IL_2BF;
					case 16:
						goto IL_532;
					case 17:
						num = (short)723976200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						radioProfile.PID = global::Common.Communication.Simulator.VirtualLEDevices.b("๐͒᝔ᕖ٘൚㑜ⵞᕠᙢѤ୦⵨๪᭬ٮተᙲ", a_);
						radioProfile.RadioType = global::Motorola.Common.Communication.RadioType.PBB;
						num = (short)768540685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (this.d != null)
						{
							num = (short)872349701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 20:
						num = (short)444596230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!global::Motorola.Common.Communication.CommonUtil.BasicFunctions.IsRRPDevice(device.Key))
						{
							num = (short)972750863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						if (!forceAttach)
						{
							num = (short)1785397268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BF;
					case 23:
						radioProfile.PID = global::Common.Communication.Simulator.VirtualLEDevices.b("桐橒汔湖恘", a_);
						radioProfile.RadioType = global::Motorola.Common.Communication.RadioType.ASTRO;
						num = (short)1056440347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (key.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.MNIS)
						{
							num = (short)1359282193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D8;
					case 25:
						goto IL_1A4;
					case 26:
						if (key is global::Motorola.Common.Communication.CommonUtil.PCRDeviceInfo)
						{
							num = (short)1087635458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF;
					case 27:
						goto IL_59A;
					case 28:
						goto IL_59A;
					}
					goto IL_AC;
					IL_1A4:
					global::Common.Communication.Simulator.VirtualDeviceManager.Instance.CorrectAndBufferDevice(device);
					global::Common.Communication.Simulator.a a = new global::Common.Communication.Simulator.a();
					a.a(device);
					a.a(key.RadioID);
					radioProfile = a;
					num = (short)172818433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E:
					key.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter;
					num = (short)735772679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BF:
					deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
					deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
					deviceMsgEventArgs.RadioInfoSet.Add(radioProfile);
					num = (short)966000659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_532:
					if (key is global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)
					{
						num = (short)1698168855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1253703706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59A:
					num = (short)1720254486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D8:
					key.RadioID = key.SerialNumber;
					(radioProfile as global::Common.Communication.Simulator.a).a(key.SerialNumber);
					key.ConnectionInfo.ConnectionType = global::Motorola.Common.Communication.CommonUtil.ConnectionType.Provisioning;
					num = (short)1147404316;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FF:
				throw new global::System.Exception(global::Common.Communication.Simulator.VirtualLEDevices.b("ѐ㵒♔≖⥘⭚㉜ⵞᕠ٢Ť䝦൨๪᭬ٮተᙲ啴Ͷx୺᡼幾ꂀ", a_));
				IL_AC:
				key = device.Key;
				global::Motorola.Common.Communication.Pba.PbaObject value = device.Value;
				num = (short)1160511497;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000036CC File Offset: 0x000018CC
		public void AttachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string serialNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.DeviceInfo, global::Motorola.Common.Communication.Pba.PbaObject>> bufferedDevices;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.AttachDevice(bufferedDevices[0], true, false);
					goto IL_E2;
				case 1:
					goto IL_F9;
				case 2:
				{
					num2 = (short)1682626971;
					short num3 = num2;
					num2 = (short)1539824027;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						num2 = (short)1324285952;
						if (num2 != 0)
						{
						}
						if (bufferedDevices.Count > 0)
						{
							num2 = (short)1950220288;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_FB;
					}
					break;
				}
				}
				goto IL_1C;
				IL_E2:
				num2 = (short)1096613889;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F9:
			IL_FB:
			num2 = (short)1059717120;
			short num4 = num2;
			return;
			IL_1C:
			num2 = (short)1283522561;
			if (num2 != 0)
			{
			}
			bufferedDevices = global::Common.Communication.Simulator.VirtualDeviceManager.Instance.GetBufferedDevices(connType, serialNumber);
			num2 = (short)1816920066;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000037FC File Offset: 0x000019FC
		public void DetachDevice(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string serialNumber)
		{
			short num = (short)534221926;
			short num2 = num;
			num = (short)852857958;
			switch (num2 == num)
			{
			}
			num = (short)1626800129;
			if (num != 0)
			{
			}
			num = (short)827654144;
			short num3 = num;
			num = (short)1200947200;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000038A4 File Offset: 0x00001AA4
		public bool DetachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs deviceMsgEventArgs;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					this.e(this, deviceMsgEventArgs);
					goto IL_EC;
				case 1:
					goto IL_104;
				case 2:
				{
					num2 = (short)686742011;
					short num3 = num2;
					num2 = (short)828103163;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EC;
					default:
						num2 = (short)1881931777;
						if (num2 != 0)
						{
						}
						num2 = (short)1040384000;
						if (num2 != 0)
						{
						}
						if (this.e != null)
						{
							num2 = (short)375193600;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_106;
					}
					break;
				}
				}
				goto IL_1C;
				IL_EC:
				num2 = (short)95354881;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_104:
			IL_106:
			num2 = (short)2138898432;
			short num4 = num2;
			return true;
			IL_1C:
			deviceMsgEventArgs = new global::Motorola.Common.Communication.DeviceDiscovery.DeviceMsgEventArgs();
			deviceMsgEventArgs.PnPAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
			deviceMsgEventArgs.RadioInfoSet.Add(radioProf);
			num2 = (short)1386938370;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000039E4 File Offset: 0x00001BE4
		public VirtualDeviceDetector()
		{
			int a_ = 2;
			this.b = global::Common.Communication.Simulator.VirtualLEDevices.b("ᝀᅂᩄ", a_);
			this.c = string.Empty;
			base..ctor();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003A20 File Offset: 0x00001C20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> b()
		{
			short num = (short)830061955;
			short num2 = num;
			num = (short)631291267;
			switch (num2 == num)
			{
			}
			num = (short)162922497;
			if (num != 0)
			{
			}
			num = (short)1827995648;
			short num3 = num;
			num = (short)109314048;
			if (num != 0)
			{
			}
			return this.ScanVirtualDevices();
		}

		// Token: 0x04000003 RID: 3
		private int a;

		// Token: 0x04000004 RID: 4
		private string b;

		// Token: 0x04000005 RID: 5
		private string c;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler d;

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler e;
	}
}
