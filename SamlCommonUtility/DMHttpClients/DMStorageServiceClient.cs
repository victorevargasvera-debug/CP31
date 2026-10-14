using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x02000030 RID: 48
	public class DMStorageServiceClient : global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMClientBase, global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMStorageServiceClient
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0000AC0C File Offset: 0x00008E0C
		public DMStorageServiceClient(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IHttpHandler httpHandler) : base(httpHandler)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000AC20 File Offset: 0x00008E20
		public bool UploadCodeplug(global::System.Uri requestUri, string codeplugFilePath)
		{
			int a_ = 2;
			short num = (short)1764032516;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Threading.Tasks.Task task;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1E3;
				case 1:
					if (task.IsFaulted)
					{
						num = (short)625934336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					if (task.Exception.InnerException is global::System.Net.Http.HttpRequestException)
					{
						num = (short)1914109955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_131;
				case 3:
					return false;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				num = (short)593498450;
				short num3 = num;
				num = (short)1156321618;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1E3:
					num = (short)816906242;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1520697345;
					if (num != 0)
					{
					}
					num = (short)1041825792;
					if (num != 0)
					{
					}
					global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient.a a = new global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient.a();
					a.a = codeplugFilePath;
					a.b = this;
					a.c = requestUri;
					if (a.c == null)
					{
						goto Block_1;
					}
					if (a.a == null)
					{
						goto Block_3;
					}
					task = global::System.Threading.Tasks.Task.Run(new global::System.Func<global::System.Threading.Tasks.Task>(a.d));
					task.Wait();
					num = (short)646774785;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			Block_1:
			throw new global::System.ArgumentNullException(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\ud9aa좬\udeae쒰횲운쎶즺풼", a_));
			Block_3:
			throw new global::System.ArgumentNullException(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("좪슬쮮풰쎲\ud9b4슶\udeb8ﶺ풼펾꓀鏂꓄돆ꇈ", a_));
			IL_131:
			num = (short)108396544;
			short num4 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, task.Exception.InnerException);
		}

		// Token: 0x02000032 RID: 50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600008F RID: 143 RVA: 0x0000AE2C File Offset: 0x0000902C
			internal global::System.Threading.Tasks.Task d()
			{
				short num = (short)219587955;
				short num2 = num;
				num = (short)1494656371;
				switch (num2 == num)
				{
				}
				num = (short)1279459328;
				if (num != 0)
				{
				}
				num = (short)1044840449;
				if (num != 0)
				{
				}
				num = (short)1804926976;
				short num3 = num;
				global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient.a.a a;
				a.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
				a.c = this;
				a.a = -1;
				a.b.Start<global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient.a.a>(ref a);
				return a.b.Task;
			}

			// Token: 0x040000D7 RID: 215
			public string a;

			// Token: 0x040000D8 RID: 216
			public global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient b;

			// Token: 0x040000D9 RID: 217
			public global::System.Uri c;

			// Token: 0x02000033 RID: 51
			[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Auto)]
			private struct a : global::System.Runtime.CompilerServices.IAsyncStateMachine
			{
				// Token: 0x06000090 RID: 144 RVA: 0x0000AF0C File Offset: 0x0000910C
				void global::System.Runtime.CompilerServices.IAsyncStateMachine.d()
				{
					short num = (short)49610752;
					switch (num)
					{
					default:
					{
						int num2 = this.a;
						global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient.a a = this.c;
						try
						{
							num = (short)1399848964;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_4D3;
								case 1:
									try
									{
										num = (short)312606724;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												goto IL_3DE;
											case 1:
												try
												{
													num = (short)1821179905;
													num3 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Runtime.CompilerServices.TaskAwaiter awaiter;
														switch (num3)
														{
														case 0:
															num2 = (this.a = 0);
															this.f = awaiter;
															this.b.AwaitUnsafeOnCompleted<global::System.Runtime.CompilerServices.TaskAwaiter, global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient.a.a>(ref awaiter, ref this);
															num = (short)780337156;
															num3 = (int)((global::System.IntPtr)num);
															continue;
														case 1:
															switch (0)
															{
															case 0:
																goto IL_169;
															}
															continue;
														case 2:
															goto IL_275;
														case 3:
															goto IL_255;
														case 4:
															goto IL_1BA;
														case 5:
															if (!awaiter.IsCompleted)
															{
																num = (short)2053701632;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_255;
														case 6:
															awaiter = a.b.handler.PutResourceAsync(a.c, this.e).GetAwaiter();
															num = (short)798425093;
															num3 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_169:
														if (num2 != 0)
														{
															num = (short)1582235654;
															num3 = (int)((global::System.IntPtr)num);
															continue;
														}
														awaiter = this.f;
														this.f = default(global::System.Runtime.CompilerServices.TaskAwaiter);
														num2 = (this.a = -1);
														num = (short)136380419;
														num3 = (int)((global::System.IntPtr)num);
														continue;
														IL_255:
														awaiter.GetResult();
														num = (short)1431371778;
														num3 = (int)((global::System.IntPtr)num);
													}
													IL_1BA:
													goto IL_4EF;
													IL_275:
													goto IL_3BF;
												}
												finally
												{
													num = (short)1490092036;
													num3 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num3)
														{
														case 0:
															goto IL_373;
														case 1:
															((global::System.IDisposable)this.e).Dispose();
															num = (short)1234305024;
															num3 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															num = (short)580583427;
															num3 = (int)((global::System.IntPtr)num);
															continue;
														case 3:
															goto IL_331;
														case 4:
														{
															num = (short)982419645;
															short num4 = num;
															num = (short)886474941;
															switch ((num4 == num) ? 1 : 0)
															{
															case 0:
															case 2:
																goto IL_331;
															default:
																num = (short)1854013440;
																if (num != 0)
																{
																}
																switch (0)
																{
																case 0:
																	goto IL_2FF;
																}
																continue;
															}
															break;
														}
														}
														IL_2FF:
														if (num2 < 0)
														{
															num = (short)1965096962;
															num3 = (int)((global::System.IntPtr)num);
															continue;
														}
														break;
														IL_331:
														if (this.e == null)
														{
															break;
														}
														num = (short)700317697;
														num3 = (int)((global::System.IntPtr)num);
													}
													IL_373:;
												}
												goto IL_376;
												IL_3BF:
												this.e = null;
												num = (short)2092236800;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_376;
											case 3:
												goto IL_3A1;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_106;
												}
												continue;
											}
											IL_106:
											if (num2 != 0)
											{
												num = (short)2052980738;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_3A1;
											IL_376:
											this.e = new global::System.Net.Http.StreamContent(this.d);
											num = (short)1523253251;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_3A1:
											num = (short)202047489;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_3DE:
										goto IL_4B3;
									}
									finally
									{
										num = (short)1221591044;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
												((global::System.IDisposable)this.d).Dispose();
												num = (short)647233539;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												if (this.d != null)
												{
													num = (short)250937344;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_494;
											case 2:
												num = (short)827785217;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												goto IL_45B;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_41E;
												}
												continue;
											}
											IL_41E:
											if (num2 >= 0)
											{
												break;
											}
											num = (short)1585512450;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_45B:
										IL_494:;
									}
									goto IL_495;
									IL_4B3:
									this.d = null;
									num = (short)964755456;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									this.d = new global::System.IO.FileStream(a.a, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
									num = (short)1898643459;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_495;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_80;
									}
									continue;
								}
								IL_80:
								if (num2 != 0)
								{
									num = (short)1386479618;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_495:
								num = (short)1209073665;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_4D3:
							goto IL_2E;
						}
						catch (global::System.Exception exception)
						{
							this.a = -2;
							this.b.SetException(exception);
						}
						goto IL_4EF;
						IL_2E:
						this.a = -2;
						this.b.SetResult();
						IL_4EF:
						num = (short)1247870977;
						if (num != 0)
						{
						}
						num = (short)1042022400;
						short num5 = num;
						return;
					}
					}
				}

				// Token: 0x06000091 RID: 145 RVA: 0x0000B4A8 File Offset: 0x000096A8
				[global::System.Diagnostics.DebuggerHidden]
				void global::System.Runtime.CompilerServices.IAsyncStateMachine.d(global::System.Runtime.CompilerServices.IAsyncStateMachine A_0)
				{
					short num = (short)669320843;
					short num2 = num;
					num = (short)1457849995;
					switch (num2 == num)
					{
					}
					num = (short)1515126784;
					if (num != 0)
					{
					}
					num = (short)1146093569;
					if (num != 0)
					{
					}
					num = (short)1932001280;
					short num3 = num;
					this.b.SetStateMachine(A_0);
				}

				// Token: 0x040000DA RID: 218
				public int a;

				// Token: 0x040000DB RID: 219
				public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder b;

				// Token: 0x040000DC RID: 220
				public global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMStorageServiceClient.a c;

				// Token: 0x040000DD RID: 221
				private global::System.IO.FileStream d;

				// Token: 0x040000DE RID: 222
				private global::System.Net.Http.StreamContent e;

				// Token: 0x040000DF RID: 223
				private global::System.Runtime.CompilerServices.TaskAwaiter f;
			}
		}
	}
}
