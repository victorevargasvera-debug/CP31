using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ConfusabilityBridge
{
	// Token: 0x02000006 RID: 6
	public class ConfusabilityFunctions
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00003498 File Offset: 0x00001698
		static ConfusabilityFunctions()
		{
			short num = (short)889269674;
			short num2 = num;
			num = (short)656420266;
			switch (num2 == num)
			{
			}
			num = (short)262144;
			short num3 = num;
			num = (short)544538625;
			if (num != 0)
			{
			}
			num = (short)1407123456;
			if (num != 0)
			{
			}
			global::ConfusabilityBridge.ConfusabilityFunctions.c = new object();
			global::ConfusabilityBridge.ConfusabilityFunctions.a(new string[]
			{
				global::ConfusabilityBridge.ConfusabilityFunctions.a()
			});
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003560 File Offset: 0x00001760
		private static string a()
		{
			int a_ = 15;
			short num = (short)1727725570;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_13B;
				case 1:
					goto IL_114;
				case 2:
				{
					num = (short)2065694720;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					continue;
				}
				case 3:
					goto IL_FA;
				}
				IL_67:
				if (global::System.Environment.Is64BitProcess)
				{
					num = (short)1283391489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1700397057;
				if (num != 0)
				{
				}
				num = (short)626388334;
				short num4 = num;
				num = (short)64548206;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1261371392;
					if (num != 0)
					{
					}
					num = (short)1047265283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_FA:
				num = (short)568721408;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_114:
			string text = global::<Module>.b("焈㴊㤌", a_);
			goto IL_14B;
			IL_13B:
			text = global::<Module>.b("焈㌊㬌", a_);
			IL_14B:
			string str = text;
			global::ConfusabilityBridge.ConfusabilityFunctions.b = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
			return global::System.IO.Path.Combine(global::ConfusabilityBridge.ConfusabilityFunctions.b, global::<Module>.b("樈搊挌椎搐怒琔甖瀘眚琜欞堠缢", a_) + str + global::<Module>.b("唈", a_));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000036FC File Offset: 0x000018FC
		private static void a(params string[] A_0)
		{
			int a_ = 12;
			short num = (short)853606401;
			if (num != 0)
			{
			}
			num = (short)2088880779;
			short num2 = num;
			num = (short)946260619;
			switch (num2 == num)
			{
			default:
			{
				num = (short)639696896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1570308096;
			if (num != 0)
			{
			}
			string[] second = new string[]
			{
				global::System.Environment.GetEnvironmentVariable(global::<Module>.b("嘅䤇帉䐋", a_)) ?? string.Empty
			};
			string value = string.Join(global::System.IO.Path.PathSeparator.ToString(), A_0.Concat(second).Distinct<string>());
			global::System.Environment.SetEnvironmentVariable(global::<Module>.b("嘅䤇帉䐋", a_), value);
		}

		// Token: 0x06000016 RID: 22
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "setup")]
		private static extern global::System.IntPtr c(string A_0);

		// Token: 0x06000017 RID: 23
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", EntryPoint = "setup")]
		private static extern global::System.IntPtr b(string A_0);

		// Token: 0x06000018 RID: 24 RVA: 0x0000380C File Offset: 0x00001A0C
		public static global::System.IntPtr setup(string languageCode = "enu")
		{
			short num = (short)271122432;
			switch (num)
			{
			default:
			{
				object obj = global::ConfusabilityBridge.ConfusabilityFunctions.c;
				bool flag = false;
				global::System.IntPtr result;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					string currentDirectory = global::System.IO.Directory.GetCurrentDirectory();
					bool flag2 = global::ConfusabilityBridge.ConfusabilityFunctions.a(currentDirectory);
					try
					{
						num = (short)536150021;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_DA;
							case 1:
								if (global::System.IntPtr.Size == 8)
								{
									num = (short)1421213698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = global::ConfusabilityBridge.ConfusabilityFunctions.c(languageCode);
								num = (short)162791427;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								result = global::ConfusabilityBridge.ConfusabilityFunctions.b(languageCode);
								num = (short)2134048768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_13A;
							case 4:
								global::System.IO.Directory.SetCurrentDirectory(global::ConfusabilityBridge.ConfusabilityFunctions.b);
								num = (short)870907910;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_81;
								}
								continue;
							case 6:
								goto IL_DF;
							}
							IL_81:
							if (flag2)
							{
								num = (short)1873805316;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_DF:
							num = (short)1190920193;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_DA:
						IL_13A:;
					}
					finally
					{
						num = (short)1149894658;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								global::System.IO.Directory.SetCurrentDirectory(currentDirectory);
								num = (short)1859518465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1A9;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_172;
								}
								continue;
							}
							IL_172:
							if (!flag2)
							{
								break;
							}
							num = (short)1007157248;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A9:;
					}
				}
				finally
				{
					num = (short)1650655234;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_243;
						case 1:
							goto IL_264;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1DE;
							}
							continue;
						}
						IL_1DE:
						if (!flag)
						{
							break;
						}
						num = (short)1964994354;
						short num3 = num;
						num = (short)2143514418;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)258998272;
							if (num != 0)
							{
							}
							num = (short)2032599040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_243:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)305332225;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_264:;
				}
				num = (short)1007550465;
				if (num != 0)
				{
				}
				num = (short)216858624;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06000019 RID: 25
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "computeConfusability")]
		private static extern int b(global::System.IntPtr A_0, string A_1, string A_2, out ulong A_3);

		// Token: 0x0600001A RID: 26
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", EntryPoint = "computeConfusability")]
		private static extern int a(global::System.IntPtr A_0, string A_1, string A_2, out ulong A_3);

		// Token: 0x0600001B RID: 27 RVA: 0x00003B08 File Offset: 0x00001D08
		public static int computeConfusability(global::System.IntPtr component, string confuseA, string confuseB, out ulong confusability)
		{
			short num = (short)208142336;
			switch (num)
			{
			default:
			{
				num = (short)2017722368;
				short num2 = num;
				object obj = global::ConfusabilityBridge.ConfusabilityFunctions.c;
				bool flag = false;
				int result;
				try
				{
					num = (short)1318780929;
					if (num != 0)
					{
					}
					global::System.Threading.Monitor.Enter(obj, ref flag);
					string currentDirectory = global::System.IO.Directory.GetCurrentDirectory();
					bool flag2 = global::ConfusabilityBridge.ConfusabilityFunctions.a(currentDirectory);
					try
					{
						num = (short)1052639237;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_137;
							case 1:
								if (global::System.IntPtr.Size == 8)
								{
									num = (short)692781058;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = global::ConfusabilityBridge.ConfusabilityFunctions.b(component, confuseA, confuseB, out confusability);
								num = (short)1197801475;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								result = global::ConfusabilityBridge.ConfusabilityFunctions.a(component, confuseA, confuseB, out confusability);
								num = (short)575864832;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_19C;
							case 4:
								global::System.IO.Directory.SetCurrentDirectory(global::ConfusabilityBridge.ConfusabilityFunctions.b);
								num = (short)1630339078;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_D5;
								}
								continue;
							case 6:
								goto IL_13C;
							}
							IL_D5:
							if (flag2)
							{
								num = (short)1995571204;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_13C:
							num = (short)1820327937;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_137:
						IL_19C:;
					}
					finally
					{
						num = (short)1087504386;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								global::System.IO.Directory.SetCurrentDirectory(currentDirectory);
								num = (short)1921318913;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_209;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1D3;
								}
								continue;
							}
							IL_1D3:
							if (!flag2)
							{
								break;
							}
							num = (short)444006400;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_209:;
					}
				}
				finally
				{
					num = (short)1551630338;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_2A6;
						case 1:
							goto IL_2C8;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_240;
							}
							continue;
						}
						IL_240:
						if (!flag)
						{
							break;
						}
						num = (short)2008728555;
						short num4 = num;
						num = (short)1244185579;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)370868224;
							if (num != 0)
							{
							}
							num = (short)197722112;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2A6:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1920729089;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2C8:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600001C RID: 28
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "getTranscription")]
		private static extern int a(global::System.IntPtr A_0, global::System.IntPtr A_1, out global::System.IntPtr A_2, out uint A_3);

		// Token: 0x0600001D RID: 29
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", EntryPoint = "getTranscription")]
		private static extern int a(global::System.IntPtr A_0, global::System.IntPtr A_1, out global::System.IntPtr A_2, out ulong A_3);

		// Token: 0x0600001E RID: 30 RVA: 0x00003E18 File Offset: 0x00002018
		public static int getTranscription(global::System.IntPtr comp, string transcribe, out global::System.IntPtr transcriptions, out ulong transCount)
		{
			short num = (short)973996032;
			switch (num)
			{
			default:
			{
				num = (short)1448542208;
				short num2 = num;
				object obj = global::ConfusabilityBridge.ConfusabilityFunctions.c;
				bool flag = false;
				int result;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					string currentDirectory = global::System.IO.Directory.GetCurrentDirectory();
					bool flag2 = global::ConfusabilityBridge.ConfusabilityFunctions.a(currentDirectory);
					try
					{
						num = (short)1932460034;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::ConfusabilityBridge.ConfusabilityFunctions.a a;
							switch (num3)
							{
							case 0:
								try
								{
									num = (short)358940674;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											goto IL_207;
										case 1:
											goto IL_1D3;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_13C;
											}
											continue;
										case 3:
										{
											num = (short)1805087273;
											short num4 = num;
											num = (short)1565487657;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_1D3;
											default:
												num = (short)1995833344;
												if (num != 0)
												{
												}
												result = global::ConfusabilityBridge.ConfusabilityFunctions.a(comp, a.c(), out transcriptions, out transCount);
												num = (short)600834049;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_13C:
										if (global::System.IntPtr.Size == 8)
										{
											num = (short)1559691267;
											num3 = (int)((global::System.IntPtr)num);
										}
										else
										{
											uint num6;
											int num5 = global::ConfusabilityBridge.ConfusabilityFunctions.a(comp, a.c(), out transcriptions, out num6);
											transCount = (ulong)num6;
											result = num5;
											num = (short)813432832;
											num3 = (int)((global::System.IntPtr)num);
										}
									}
									IL_1D3:
									IL_207:
									return result;
								}
								finally
								{
									num = (short)1487863810;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)a).Dispose();
											num = (short)277938177;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_276;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_23F;
											}
											continue;
										}
										IL_23F:
										if (a == null)
										{
											break;
										}
										num = (short)849608704;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_276:;
								}
								goto IL_279;
							case 1:
								goto IL_279;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_9D;
								}
								continue;
							case 3:
								global::System.IO.Directory.SetCurrentDirectory(global::ConfusabilityBridge.ConfusabilityFunctions.b);
								num = (short)1485963265;
								if (num != 0)
								{
								}
								num = (short)335347713;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_9D:
							if (flag2)
							{
								num = (short)674234371;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_279:
							a = new global::ConfusabilityBridge.ConfusabilityFunctions.a(transcribe);
							num = (short)859832320;
							num3 = (int)((global::System.IntPtr)num);
						}
					}
					finally
					{
						num = (short)1119420418;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								global::System.IO.Directory.SetCurrentDirectory(currentDirectory);
								num = (short)613744641;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_308;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2D1;
								}
								continue;
							}
							IL_2D1:
							if (!flag2)
							{
								break;
							}
							num = (short)1805975552;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_308:;
					}
				}
				finally
				{
					num = (short)13893634;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1589903361;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_375;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_33D;
							}
							continue;
						}
						IL_33D:
						if (!flag)
						{
							break;
						}
						num = (short)422707200;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_375:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600001F RID: 31
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "getConfusability")]
		private static extern int a(global::System.IntPtr A_0, global::System.IntPtr A_1, uint A_2, global::System.IntPtr A_3, uint A_4, out ulong A_5);

		// Token: 0x06000020 RID: 32
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", EntryPoint = "getConfusability")]
		private static extern int a(global::System.IntPtr A_0, global::System.IntPtr A_1, ulong A_2, global::System.IntPtr A_3, ulong A_4, out ulong A_5);

		// Token: 0x06000021 RID: 33 RVA: 0x000041EC File Offset: 0x000023EC
		public static int getConfusability(global::System.IntPtr comp, global::System.IntPtr transA, ulong transACount, global::System.IntPtr transB, ulong transBCount, out ulong confusability)
		{
			short num = (short)718929920;
			switch (num)
			{
			default:
			{
				num = (short)2065301504;
				short num2 = num;
				object obj = global::ConfusabilityBridge.ConfusabilityFunctions.c;
				bool flag = false;
				int result;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					string currentDirectory = global::System.IO.Directory.GetCurrentDirectory();
					bool flag2 = global::ConfusabilityBridge.ConfusabilityFunctions.a(currentDirectory);
					try
					{
						num = (short)1245511685;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_110;
							case 1:
								if (global::System.IntPtr.Size == 8)
								{
									num = (short)1020002306;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = global::ConfusabilityBridge.ConfusabilityFunctions.a(comp, transA, (uint)transACount, transB, (uint)transBCount, out confusability);
								num = (short)1531183107;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								result = global::ConfusabilityBridge.ConfusabilityFunctions.a(comp, transA, transACount, transB, transBCount, out confusability);
								num = (short)1007288320;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_17A;
							case 4:
								global::System.IO.Directory.SetCurrentDirectory(global::ConfusabilityBridge.ConfusabilityFunctions.b);
								num = (short)1223950342;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_AC;
								}
								continue;
							case 6:
								goto IL_115;
							}
							IL_AC:
							if (flag2)
							{
								num = (short)1670250500;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_115:
							num = (short)1525547009;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_110:
						IL_17A:;
					}
					finally
					{
						num = (short)1775960066;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								global::System.IO.Directory.SetCurrentDirectory(currentDirectory);
								num = (short)829751297;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1E8;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1B1;
								}
								continue;
							}
							IL_1B1:
							if (!flag2)
							{
								break;
							}
							num = (short)849018880;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1E8:;
					}
				}
				finally
				{
					num = (short)1026359298;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1650589697;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_2AF;
						case 1:
							goto IL_2D0;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_246;
							}
							continue;
						}
						IL_246:
						if (!flag)
						{
							break;
						}
						num = (short)1025363330;
						short num4 = num;
						num = (short)636603778;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1525350400;
							if (num != 0)
							{
							}
							num = (short)1318977536;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2AF:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)599326721;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2D0:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000022 RID: 34
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "returnTranscription")]
		private static extern int b(global::System.IntPtr A_0, global::System.IntPtr A_1);

		// Token: 0x06000023 RID: 35
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", EntryPoint = "returnTranscription")]
		private static extern int a(global::System.IntPtr A_0, global::System.IntPtr A_1);

		// Token: 0x06000024 RID: 36 RVA: 0x00004504 File Offset: 0x00002704
		public static int returnTranscription(global::System.IntPtr comp, global::System.IntPtr transcriptions)
		{
			short num = (short)16515072;
			switch (num)
			{
			default:
			{
				num = (short)460849152;
				short num2 = num;
				num = (short)342753281;
				if (num != 0)
				{
				}
				object obj = global::ConfusabilityBridge.ConfusabilityFunctions.c;
				bool flag = false;
				int result;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					string currentDirectory = global::System.IO.Directory.GetCurrentDirectory();
					bool flag2 = global::ConfusabilityBridge.ConfusabilityFunctions.a(currentDirectory);
					try
					{
						num = (short)1578893314;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								result = global::ConfusabilityBridge.ConfusabilityFunctions.a(comp, transcriptions);
								num = (short)1169293315;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								global::System.IO.Directory.SetCurrentDirectory(global::ConfusabilityBridge.ConfusabilityFunctions.b);
								num = (short)325582852;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_D2;
								}
								continue;
							case 3:
								goto IL_12C;
							case 4:
								goto IL_131;
							case 5:
								goto IL_18D;
							case 6:
								if (global::System.IntPtr.Size == 8)
								{
									num = (short)474349568;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = global::ConfusabilityBridge.ConfusabilityFunctions.b(comp, transcriptions);
								num = (short)1831927813;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_D2:
							if (flag2)
							{
								num = (short)797900801;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_131:
							num = (short)663355398;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_12C:
						return result;
						IL_18D:
						num = (short)1409354442;
						short num4 = num;
						num = (short)749472458;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)204210176;
							if (num != 0)
							{
							}
							break;
						}
					}
					finally
					{
						num = (short)540737536;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_211;
								}
								continue;
							case 1:
								goto IL_248;
							case 2:
								global::System.IO.Directory.SetCurrentDirectory(currentDirectory);
								num = (short)1296564225;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_211:
							if (!flag2)
							{
								break;
							}
							num = (short)992083970;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_248:;
					}
				}
				finally
				{
					num = (short)1357119488;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_27E;
							}
							continue;
						case 1:
							goto IL_2B5;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)247070721;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_27E:
						if (!flag)
						{
							break;
						}
						num = (short)29949954;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2B5:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000025 RID: 37
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "cleanup")]
		private static extern int b(global::System.IntPtr A_0);

		// Token: 0x06000026 RID: 38
		[global::System.Runtime.InteropServices.DllImport("Confusability.dll", EntryPoint = "cleanup")]
		private static extern int a(global::System.IntPtr A_0);

		// Token: 0x06000027 RID: 39 RVA: 0x00004800 File Offset: 0x00002A00
		public static int cleanup(global::System.IntPtr component)
		{
			short num = (short)1075773440;
			switch (num)
			{
			default:
			{
				num = (short)96075776;
				short num2 = num;
				object obj = global::ConfusabilityBridge.ConfusabilityFunctions.c;
				bool flag = false;
				int result;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					string currentDirectory = global::System.IO.Directory.GetCurrentDirectory();
					bool flag2 = global::ConfusabilityBridge.ConfusabilityFunctions.a(currentDirectory);
					try
					{
						num = (short)1406140418;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								result = global::ConfusabilityBridge.ConfusabilityFunctions.a(component);
								num = (short)1410400259;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								global::System.IO.Directory.SetCurrentDirectory(global::ConfusabilityBridge.ConfusabilityFunctions.b);
								num = (short)599588868;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A9;
								}
								continue;
							case 3:
								goto IL_102;
							case 4:
								goto IL_107;
							case 5:
								goto IL_162;
							case 6:
								if (global::System.IntPtr.Size == 8)
								{
									num = (short)1981480960;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = global::ConfusabilityBridge.ConfusabilityFunctions.b(component);
								num = (short)1989279749;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_A9:
							if (flag2)
							{
								num = (short)1758593025;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_107:
							num = (short)1535705094;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_102:
						goto IL_285;
						IL_162:
						num = (short)800084263;
						short num4 = num;
						num = (short)1762152743;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)239206400;
							if (num != 0)
							{
							}
							break;
						}
					}
					finally
					{
						num = (short)694550528;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1E3;
								}
								continue;
							case 1:
								goto IL_218;
							case 2:
								global::System.IO.Directory.SetCurrentDirectory(currentDirectory);
								num = (short)723517441;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1E3:
							if (!flag2)
							{
								break;
							}
							num = (short)1616773122;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_218:;
					}
				}
				finally
				{
					num = (short)730529792;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_24D;
							}
							continue;
						case 1:
							goto IL_282;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1002110977;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_24D:
						if (!flag)
						{
							break;
						}
						num = (short)714211330;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_282:;
				}
				IL_285:
				num = (short)1139474433;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004AF4 File Offset: 0x00002CF4
		private static bool a(string A_0)
		{
			short num = (short)957218816;
			short num2 = num;
			num = (short)226392422;
			short num3 = num;
			num = (short)451967334;
			switch (num3 == num)
			{
			}
			num = (short)2067791873;
			if (num != 0)
			{
			}
			num = (short)2141650944;
			if (num != 0)
			{
			}
			return A_0 != global::ConfusabilityBridge.ConfusabilityFunctions.b;
		}

		// Token: 0x0400000B RID: 11
		private const string a = "PATH";

		// Token: 0x0400000C RID: 12
		private static string b;

		// Token: 0x0400000D RID: 13
		private static readonly object c;

		// Token: 0x02000007 RID: 7
		internal class a : global::System.IDisposable
		{
			// Token: 0x0600002A RID: 42 RVA: 0x00004BBC File Offset: 0x00002DBC
			public global::System.IntPtr c()
			{
				short num = (short)924581888;
				short num2 = num;
				num = (short)1825137407;
				short num3 = num;
				num = (short)1406952191;
				switch (num3 == num)
				{
				}
				num = (short)1754398721;
				if (num != 0)
				{
				}
				num = (short)461373440;
				if (num != 0)
				{
				}
				return this.a;
			}

			// Token: 0x0600002B RID: 43 RVA: 0x00004C6C File Offset: 0x00002E6C
			public int d()
			{
				short num = (short)319356928;
				short num2 = num;
				num = (short)996147201;
				if (num != 0)
				{
				}
				num = (short)144826383;
				short num3 = num;
				num = (short)682745871;
				switch (num3 == num)
				{
				}
				num = (short)1506213888;
				if (num != 0)
				{
				}
				return this.b;
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00004D1C File Offset: 0x00002F1C
			public a(string A_0)
			{
				if (A_0 == null)
				{
					this.a = global::System.IntPtr.Zero;
					return;
				}
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(A_0);
				this.a = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(bytes.Length + 1);
				global::System.Runtime.InteropServices.Marshal.Copy(bytes, 0, this.a, bytes.Length);
				global::System.Runtime.InteropServices.Marshal.WriteByte(this.a, bytes.Length, 0);
				this.b = bytes.Length + 1;
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00004D88 File Offset: 0x00002F88
			public void Dispose()
			{
				short num = (short)1261174784;
				short num2 = num;
				num = (short)1344254230;
				short num3 = num;
				num = (short)345026838;
				switch (num3 == num)
				{
				}
				num = (short)722731009;
				if (num != 0)
				{
				}
				num = (short)1794244608;
				if (num != 0)
				{
				}
				this.c(true);
				global::System.GC.SuppressFinalize(this);
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00004E3C File Offset: 0x0000303C
			protected virtual void c(bool A_0)
			{
				short num = (short)211746816;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)383778817;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 1:
						return;
					case 2:
						num = (short)67108868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1773744188;
						short num3 = num;
						num = (short)1907109948;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1869217792;
							if (num != 0)
							{
							}
							num = (short)50069504;
							short num4 = num;
							global::System.Runtime.InteropServices.Marshal.FreeHGlobal(this.a);
							this.a = global::System.IntPtr.Zero;
							num = (short)1953955841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						if (this.a != global::System.IntPtr.Zero)
						{
							num = (short)2025127939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_5F:
					if (global::System.Threading.Interlocked.Increment(ref this.c) != 1)
					{
						break;
					}
					num = (short)445906946;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00004FBC File Offset: 0x000031BC
			protected override void Finalize()
			{
				short num;
				try
				{
					num = (short)1075645937;
					short num2 = num;
					num = (short)1408437745;
					switch (num2 == num)
					{
					}
					num = (short)344653824;
					if (num != 0)
					{
					}
					this.c(false);
				}
				finally
				{
					base.Finalize();
				}
				num = (short)1452015616;
				short num3 = num;
				num = (short)596836353;
				if (num != 0)
				{
				}
			}

			// Token: 0x0400000E RID: 14
			private global::System.IntPtr a;

			// Token: 0x0400000F RID: 15
			private int b;

			// Token: 0x04000010 RID: 16
			private int c;
		}
	}
}
