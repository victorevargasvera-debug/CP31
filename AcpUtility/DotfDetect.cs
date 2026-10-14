using System;
using System.Windows.Forms;

namespace AcpUtility
{
	// Token: 0x02000005 RID: 5
	public class DotfDetect
	{
		// Token: 0x06000008 RID: 8 RVA: 0x000029B8 File Offset: 0x00000BB8
		public static void handle(bool isTampered)
		{
			int a_ = 6;
			short num = (short)1279852546;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1836843008;
				short num3 = num;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						for (;;)
						{
							IL_8A:
							switch (num2)
							{
							case 0:
							{
								num = (short)474277536;
								short num4 = num;
								num = (short)1252714144;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_164;
								default:
									num = (short)1034616832;
									if (num != 0)
									{
									}
									global::System.Windows.Forms.Application.Exit();
									num = (short)1222180865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_164;
							case 2:
								goto IL_17B;
							case 3:
								if (global::System.Windows.Forms.Application.MessageLoop)
								{
									num = (short)1412300800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_164;
							}
							goto IL_A0;
							IL_164:
							num = (short)97189890;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_17B:
						return;
						IL_A0:
						global::System.Windows.Forms.MessageBox.Show(global::AcpUtility.StreamExtensions.b("ぢ੤੦౨䭪୬ٮᵰᙲٴ坶ᡸॺ᡼彾ﲈﮊ歷붒떔잖ﺚﲜ쒠莢키즦蒨슪쎬\udcae얰튲\ud9b4\udbb6馸\udaba펼\udbbe뇂ꃄꃈꗊ뻌믎냐뿒맔귘돚룜￞胠鏢闤详胨裪賬鯮飰鳲鯴\ud9f6", a_), global::AcpUtility.StreamExtensions.b("⁢㕤㑦", a_), global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
						num = (short)1876885507;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_8A;
					}
					finally
					{
						num = (short)1127874561;
						if (num != 0)
						{
						}
						global::System.Environment.Exit(1);
					}
					goto IL_1AB;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				}
				IL_61:
				if (!isTampered)
				{
					num = (short)928514048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1AB:
				num = (short)2117795841;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
