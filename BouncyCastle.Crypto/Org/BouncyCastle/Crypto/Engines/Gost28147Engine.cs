using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x0200049D RID: 1181
	public class Gost28147Engine : global::Org.BouncyCastle.Crypto.IBlockCipher
	{
		// Token: 0x06002D7A RID: 11642 RVA: 0x000CC4EC File Offset: 0x000CA6EC
		static Gost28147Engine()
		{
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox("Default", global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.Sbox_Default);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox("E-TEST", global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_Test);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox("E-A", global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_A);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox("E-B", global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_B);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox("E-C", global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_C);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox("E-D", global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.ESbox_D);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox("D-TEST", global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.DSbox_Test);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.AddSBox("D-A", global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.DSbox_A);
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x000CC64B File Offset: 0x000CA84B
		private static void AddSBox(string sBoxName, byte[] sBox)
		{
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.sBoxes.Add(global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(sBoxName), sBox);
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x000CC674 File Offset: 0x000CA874
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox param = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox)parameters;
				byte[] sBox = param.GetSBox();
				if (sBox.Length != global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.Sbox_Default.Length)
				{
					throw new global::System.ArgumentException("invalid S-box passed to GOST28147 init");
				}
				this.S = global::Org.BouncyCastle.Utilities.Arrays.Clone(sBox);
				if (param.Parameters != null)
				{
					this.workingKey = this.generateWorkingKey(forEncryption, ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)param.Parameters).GetKey());
					return;
				}
			}
			else
			{
				if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
				{
					this.workingKey = this.generateWorkingKey(forEncryption, ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey());
					return;
				}
				if (parameters != null)
				{
					throw new global::System.ArgumentException("invalid parameter passed to Gost28147 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
				}
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x000CC71A File Offset: 0x000CA91A
		public virtual string AlgorithmName
		{
			get
			{
				return "Gost28147";
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002D7F RID: 11647 RVA: 0x000CC721 File Offset: 0x000CA921
		public virtual bool IsPartialBlockOkay
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000CC724 File Offset: 0x000CA924
		public virtual int GetBlockSize()
		{
			return 8;
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x000CC728 File Offset: 0x000CA928
		public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
		{
			if (this.workingKey == null)
			{
				throw new global::System.InvalidOperationException("Gost28147 engine not initialised");
			}
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, 8, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, 8, "output buffer too short");
			this.Gost28147Func(this.workingKey, input, inOff, output, outOff);
			return 8;
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x000CC775 File Offset: 0x000CA975
		public virtual void Reset()
		{
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x000CC778 File Offset: 0x000CA978
		private int[] generateWorkingKey(bool forEncryption, byte[] userKey)
		{
			this.forEncryption = forEncryption;
			if (userKey.Length != 32)
			{
				throw new global::System.ArgumentException("Key length invalid. Key needs to be 32 byte - 256 bit!!!");
			}
			int[] key = new int[8];
			for (int i = 0; i != 8; i++)
			{
				key[i] = global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.bytesToint(userKey, i * 4);
			}
			return key;
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x000CC7C0 File Offset: 0x000CA9C0
		private int Gost28147_mainStep(int n1, int key)
		{
			int cm = key + n1;
			int num = (int)this.S[cm & 15] + ((int)this.S[16 + (cm >> 4 & 15)] << 4) + ((int)this.S[32 + (cm >> 8 & 15)] << 8) + ((int)this.S[48 + (cm >> 12 & 15)] << 12) + ((int)this.S[64 + (cm >> 16 & 15)] << 16) + ((int)this.S[80 + (cm >> 20 & 15)] << 20) + ((int)this.S[96 + (cm >> 24 & 15)] << 24) + ((int)this.S[112 + (cm >> 28 & 15)] << 28);
			int omLeft = num << 11;
			int omRight = (int)((uint)num >> 21);
			return omLeft | omRight;
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x000CC878 File Offset: 0x000CAA78
		private void Gost28147Func(int[] workingKey, byte[] inBytes, int inOff, byte[] outBytes, int outOff)
		{
			int N = global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.bytesToint(inBytes, inOff);
			int N2 = global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.bytesToint(inBytes, inOff + 4);
			if (this.forEncryption)
			{
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 8; j++)
					{
						int num = N;
						int step = this.Gost28147_mainStep(N, workingKey[j]);
						N = (N2 ^ step);
						N2 = num;
					}
				}
				for (int k = 7; k > 0; k--)
				{
					int num2 = N;
					N = (N2 ^ this.Gost28147_mainStep(N, workingKey[k]));
					N2 = num2;
				}
			}
			else
			{
				for (int l = 0; l < 8; l++)
				{
					int num3 = N;
					N = (N2 ^ this.Gost28147_mainStep(N, workingKey[l]));
					N2 = num3;
				}
				for (int m = 0; m < 3; m++)
				{
					int n = 7;
					while (n >= 0 && (m != 2 || n != 0))
					{
						int num4 = N;
						N = (N2 ^ this.Gost28147_mainStep(N, workingKey[n]));
						N2 = num4;
						n--;
					}
				}
			}
			N2 ^= this.Gost28147_mainStep(N, workingKey[0]);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.intTobytes(N, outBytes, outOff);
			global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.intTobytes(N2, outBytes, outOff + 4);
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x000CC968 File Offset: 0x000CAB68
		private static int bytesToint(byte[] inBytes, int inOff)
		{
			return (int)((long)((long)inBytes[inOff + 3] << 24) & (long)((ulong)-16777216)) + ((int)inBytes[inOff + 2] << 16 & 16711680) + ((int)inBytes[inOff + 1] << 8 & 65280) + (int)(inBytes[inOff] & byte.MaxValue);
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000CC9A2 File Offset: 0x000CABA2
		private static void intTobytes(int num, byte[] outBytes, int outOff)
		{
			outBytes[outOff + 3] = (byte)(num >> 24);
			outBytes[outOff + 2] = (byte)(num >> 16);
			outBytes[outOff + 1] = (byte)(num >> 8);
			outBytes[outOff] = (byte)num;
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x000CC9C6 File Offset: 0x000CABC6
		public static byte[] GetSBox(string sBoxName)
		{
			byte[] array = (byte[])global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.sBoxes[global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(sBoxName)];
			if (array == null)
			{
				throw new global::System.ArgumentException("Unknown S-Box - possible types: \"Default\", \"E-Test\", \"E-A\", \"E-B\", \"E-C\", \"E-D\", \"D-Test\", \"D-A\".");
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(array);
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000CC9F0 File Offset: 0x000CABF0
		public static string GetSBoxName(byte[] sBox)
		{
			foreach (object obj in global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.sBoxes.Keys)
			{
				string name = (string)obj;
				if (global::Org.BouncyCastle.Utilities.Arrays.AreEqual((byte[])global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.sBoxes[name], sBox))
				{
					return name;
				}
			}
			throw new global::System.ArgumentException("SBOX provided did not map to a known one");
		}

		// Token: 0x0400132C RID: 4908
		private const int BlockSize = 8;

		// Token: 0x0400132D RID: 4909
		private int[] workingKey;

		// Token: 0x0400132E RID: 4910
		private bool forEncryption;

		// Token: 0x0400132F RID: 4911
		private byte[] S = global::Org.BouncyCastle.Crypto.Engines.Gost28147Engine.Sbox_Default;

		// Token: 0x04001330 RID: 4912
		private static readonly byte[] Sbox_Default = new byte[]
		{
			4,
			10,
			9,
			2,
			13,
			8,
			0,
			14,
			6,
			11,
			1,
			12,
			7,
			15,
			5,
			3,
			14,
			11,
			4,
			12,
			6,
			13,
			15,
			10,
			2,
			3,
			8,
			1,
			0,
			7,
			5,
			9,
			5,
			8,
			1,
			13,
			10,
			3,
			4,
			2,
			14,
			15,
			12,
			7,
			6,
			0,
			9,
			11,
			7,
			13,
			10,
			1,
			0,
			8,
			9,
			15,
			14,
			4,
			6,
			12,
			11,
			2,
			5,
			3,
			6,
			12,
			7,
			1,
			5,
			15,
			13,
			8,
			4,
			10,
			9,
			14,
			0,
			3,
			11,
			2,
			4,
			11,
			10,
			0,
			7,
			2,
			1,
			13,
			3,
			6,
			8,
			5,
			9,
			12,
			15,
			14,
			13,
			11,
			4,
			1,
			3,
			15,
			5,
			9,
			0,
			10,
			14,
			7,
			6,
			8,
			2,
			12,
			1,
			15,
			13,
			0,
			5,
			7,
			10,
			4,
			9,
			2,
			3,
			14,
			6,
			11,
			8,
			12
		};

		// Token: 0x04001331 RID: 4913
		private static readonly byte[] ESbox_Test = new byte[]
		{
			4,
			2,
			15,
			5,
			9,
			1,
			0,
			8,
			14,
			3,
			11,
			12,
			13,
			7,
			10,
			6,
			12,
			9,
			15,
			14,
			8,
			1,
			3,
			10,
			2,
			7,
			4,
			13,
			6,
			0,
			11,
			5,
			13,
			8,
			14,
			12,
			7,
			3,
			9,
			10,
			1,
			5,
			2,
			4,
			6,
			15,
			0,
			11,
			14,
			9,
			11,
			2,
			5,
			15,
			7,
			1,
			0,
			13,
			12,
			6,
			10,
			4,
			3,
			8,
			3,
			14,
			5,
			9,
			6,
			8,
			0,
			13,
			10,
			11,
			7,
			12,
			2,
			1,
			15,
			4,
			8,
			15,
			6,
			11,
			1,
			9,
			12,
			5,
			13,
			3,
			7,
			10,
			0,
			14,
			2,
			4,
			9,
			11,
			12,
			0,
			3,
			6,
			7,
			5,
			4,
			8,
			14,
			15,
			1,
			10,
			2,
			13,
			12,
			6,
			5,
			2,
			11,
			0,
			9,
			13,
			3,
			14,
			7,
			10,
			15,
			4,
			1,
			8
		};

		// Token: 0x04001332 RID: 4914
		private static readonly byte[] ESbox_A = new byte[]
		{
			9,
			6,
			3,
			2,
			8,
			11,
			1,
			7,
			10,
			4,
			14,
			15,
			12,
			0,
			13,
			5,
			3,
			7,
			14,
			9,
			8,
			10,
			15,
			0,
			5,
			2,
			6,
			12,
			11,
			4,
			13,
			1,
			14,
			4,
			6,
			2,
			11,
			3,
			13,
			8,
			12,
			15,
			5,
			10,
			0,
			7,
			1,
			9,
			14,
			7,
			10,
			12,
			13,
			1,
			3,
			9,
			0,
			2,
			11,
			4,
			15,
			8,
			5,
			6,
			11,
			5,
			1,
			9,
			8,
			13,
			15,
			0,
			14,
			4,
			2,
			3,
			12,
			7,
			10,
			6,
			3,
			10,
			13,
			12,
			1,
			2,
			0,
			11,
			7,
			5,
			9,
			4,
			8,
			15,
			14,
			6,
			1,
			13,
			2,
			9,
			7,
			10,
			6,
			0,
			8,
			12,
			4,
			5,
			15,
			3,
			11,
			14,
			11,
			10,
			15,
			5,
			0,
			12,
			14,
			8,
			6,
			2,
			3,
			9,
			1,
			7,
			13,
			4
		};

		// Token: 0x04001333 RID: 4915
		private static readonly byte[] ESbox_B = new byte[]
		{
			8,
			4,
			11,
			1,
			3,
			5,
			0,
			9,
			2,
			14,
			10,
			12,
			13,
			6,
			7,
			15,
			0,
			1,
			2,
			10,
			4,
			13,
			5,
			12,
			9,
			7,
			3,
			15,
			11,
			8,
			6,
			14,
			14,
			12,
			0,
			10,
			9,
			2,
			13,
			11,
			7,
			5,
			8,
			15,
			3,
			6,
			1,
			4,
			7,
			5,
			0,
			13,
			11,
			6,
			1,
			2,
			3,
			10,
			12,
			15,
			4,
			14,
			9,
			8,
			2,
			7,
			12,
			15,
			9,
			5,
			10,
			11,
			1,
			4,
			0,
			13,
			6,
			8,
			14,
			3,
			8,
			3,
			2,
			6,
			4,
			13,
			14,
			11,
			12,
			1,
			7,
			15,
			10,
			0,
			9,
			5,
			5,
			2,
			10,
			11,
			9,
			1,
			12,
			3,
			7,
			4,
			13,
			0,
			6,
			15,
			8,
			14,
			0,
			4,
			11,
			14,
			8,
			3,
			7,
			1,
			10,
			2,
			9,
			6,
			15,
			13,
			5,
			12
		};

		// Token: 0x04001334 RID: 4916
		private static readonly byte[] ESbox_C = new byte[]
		{
			1,
			11,
			12,
			2,
			9,
			13,
			0,
			15,
			4,
			5,
			8,
			14,
			10,
			7,
			6,
			3,
			0,
			1,
			7,
			13,
			11,
			4,
			5,
			2,
			8,
			14,
			15,
			12,
			9,
			10,
			6,
			3,
			8,
			2,
			5,
			0,
			4,
			9,
			15,
			10,
			3,
			7,
			12,
			13,
			6,
			14,
			1,
			11,
			3,
			6,
			0,
			1,
			5,
			13,
			10,
			8,
			11,
			2,
			9,
			7,
			14,
			15,
			12,
			4,
			8,
			13,
			11,
			0,
			4,
			5,
			1,
			2,
			9,
			3,
			12,
			14,
			6,
			15,
			10,
			7,
			12,
			9,
			11,
			1,
			8,
			14,
			2,
			4,
			7,
			3,
			6,
			5,
			10,
			0,
			15,
			13,
			10,
			9,
			6,
			8,
			13,
			14,
			2,
			0,
			15,
			3,
			5,
			11,
			4,
			1,
			12,
			7,
			7,
			4,
			0,
			5,
			10,
			2,
			15,
			14,
			12,
			6,
			1,
			11,
			13,
			9,
			3,
			8
		};

		// Token: 0x04001335 RID: 4917
		private static readonly byte[] ESbox_D = new byte[]
		{
			15,
			12,
			2,
			10,
			6,
			4,
			5,
			0,
			7,
			9,
			14,
			13,
			1,
			11,
			8,
			3,
			11,
			6,
			3,
			4,
			12,
			15,
			14,
			2,
			7,
			13,
			8,
			0,
			5,
			10,
			9,
			1,
			1,
			12,
			11,
			0,
			15,
			14,
			6,
			5,
			10,
			13,
			4,
			8,
			9,
			3,
			7,
			2,
			1,
			5,
			14,
			12,
			10,
			7,
			0,
			13,
			6,
			2,
			11,
			4,
			9,
			3,
			15,
			8,
			0,
			12,
			8,
			9,
			13,
			2,
			10,
			11,
			7,
			3,
			6,
			5,
			4,
			14,
			15,
			1,
			8,
			0,
			15,
			3,
			2,
			5,
			14,
			11,
			1,
			10,
			4,
			7,
			12,
			9,
			13,
			6,
			3,
			0,
			6,
			15,
			1,
			14,
			9,
			2,
			13,
			8,
			12,
			4,
			11,
			10,
			5,
			7,
			1,
			10,
			6,
			8,
			15,
			11,
			0,
			4,
			12,
			3,
			5,
			9,
			7,
			13,
			2,
			14
		};

		// Token: 0x04001336 RID: 4918
		private static readonly byte[] DSbox_Test = new byte[]
		{
			4,
			10,
			9,
			2,
			13,
			8,
			0,
			14,
			6,
			11,
			1,
			12,
			7,
			15,
			5,
			3,
			14,
			11,
			4,
			12,
			6,
			13,
			15,
			10,
			2,
			3,
			8,
			1,
			0,
			7,
			5,
			9,
			5,
			8,
			1,
			13,
			10,
			3,
			4,
			2,
			14,
			15,
			12,
			7,
			6,
			0,
			9,
			11,
			7,
			13,
			10,
			1,
			0,
			8,
			9,
			15,
			14,
			4,
			6,
			12,
			11,
			2,
			5,
			3,
			6,
			12,
			7,
			1,
			5,
			15,
			13,
			8,
			4,
			10,
			9,
			14,
			0,
			3,
			11,
			2,
			4,
			11,
			10,
			0,
			7,
			2,
			1,
			13,
			3,
			6,
			8,
			5,
			9,
			12,
			15,
			14,
			13,
			11,
			4,
			1,
			3,
			15,
			5,
			9,
			0,
			10,
			14,
			7,
			6,
			8,
			2,
			12,
			1,
			15,
			13,
			0,
			5,
			7,
			10,
			4,
			9,
			2,
			3,
			14,
			6,
			11,
			8,
			12
		};

		// Token: 0x04001337 RID: 4919
		private static readonly byte[] DSbox_A = new byte[]
		{
			10,
			4,
			5,
			6,
			8,
			1,
			3,
			7,
			13,
			12,
			14,
			0,
			9,
			2,
			11,
			15,
			5,
			15,
			4,
			0,
			2,
			13,
			11,
			9,
			1,
			7,
			6,
			3,
			12,
			14,
			10,
			8,
			7,
			15,
			12,
			14,
			9,
			4,
			1,
			0,
			3,
			11,
			5,
			2,
			6,
			10,
			8,
			13,
			4,
			10,
			7,
			12,
			0,
			15,
			2,
			8,
			14,
			1,
			6,
			5,
			13,
			11,
			9,
			3,
			7,
			6,
			4,
			11,
			9,
			12,
			2,
			10,
			1,
			8,
			0,
			14,
			15,
			13,
			3,
			5,
			7,
			6,
			2,
			4,
			13,
			9,
			15,
			0,
			10,
			1,
			5,
			11,
			8,
			14,
			12,
			3,
			13,
			14,
			4,
			1,
			7,
			0,
			5,
			10,
			3,
			12,
			8,
			15,
			6,
			2,
			9,
			11,
			1,
			3,
			10,
			9,
			5,
			11,
			4,
			15,
			8,
			6,
			7,
			14,
			13,
			0,
			2,
			12
		};

		// Token: 0x04001338 RID: 4920
		private static readonly global::System.Collections.IDictionary sBoxes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
