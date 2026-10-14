using System;
using System.Collections;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests
{
	// Token: 0x020004E6 RID: 1254
	public class SkeinEngine : global::Org.BouncyCastle.Utilities.IMemoable
	{
		// Token: 0x06003148 RID: 12616 RVA: 0x000EC570 File Offset: 0x000EA770
		static SkeinEngine()
		{
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(256, 128, new ulong[]
			{
				16217771249220022880UL,
				9817190399063458076UL,
				1155188648486244218UL,
				14769517481627992514UL
			});
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(256, 160, new ulong[]
			{
				1450197650740764312UL,
				3081844928540042640UL,
				15310647011875280446UL,
				3301952811952417661UL
			});
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(256, 224, new ulong[]
			{
				14270089230798940683UL,
				9758551101254474012UL,
				11082101768697755780UL,
				4056579644589979102UL
			});
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(256, 256, new ulong[]
			{
				18202890402666165321UL,
				3443677322885453875UL,
				12915131351309911055UL,
				7662005193972177513UL
			});
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(512, 128, new ulong[]
			{
				12158729379475595090UL,
				2204638249859346602UL,
				3502419045458743507UL,
				13617680570268287068UL,
				983504137758028059UL,
				1880512238245786339UL,
				11730851291495443074UL,
				7602827311880509485UL
			});
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(512, 160, new ulong[]
			{
				2934123928682216849UL,
				14047033351726823311UL,
				1684584802963255058UL,
				5744138295201861711UL,
				2444857010922934358UL,
				15638910433986703544UL,
				13325156239043941114UL,
				118355523173251694UL
			});
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(512, 224, new ulong[]
			{
				14758403053642543652UL,
				14674518637417806319UL,
				10145881904771976036UL,
				4146387520469897396UL,
				1106145742801415120UL,
				7455425944880474941UL,
				11095680972475339753UL,
				11397762726744039159UL
			});
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(512, 384, new ulong[]
			{
				11814849197074935647UL,
				12753905853581818532UL,
				11346781217370868990UL,
				15535391162178797018UL,
				2000907093792408677UL,
				9140007292425499655UL,
				6093301768906360022UL,
				2769176472213098488UL
			});
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.InitialState(512, 512, new ulong[]
			{
				5261240102383538638UL,
				978932832955457283UL,
				10363226125605772238UL,
				11107378794354519217UL,
				6752626034097301424UL,
				16915020251879818228UL,
				11029617608758768931UL,
				12544957130904423475UL
			});
		}

		// Token: 0x06003149 RID: 12617 RVA: 0x000EC6A7 File Offset: 0x000EA8A7
		private static void InitialState(int blockSize, int outputSize, ulong[] state)
		{
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.INITIAL_STATES.Add(global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.VariantIdentifier(blockSize / 8, outputSize / 8), state);
		}

		// Token: 0x0600314A RID: 12618 RVA: 0x000EC6C4 File Offset: 0x000EA8C4
		private static int VariantIdentifier(int blockSizeBytes, int outputSizeBytes)
		{
			return outputSizeBytes << 16 | blockSizeBytes;
		}

		// Token: 0x0600314B RID: 12619 RVA: 0x000EC6CC File Offset: 0x000EA8CC
		public SkeinEngine(int blockSizeBits, int outputSizeBits)
		{
			if (outputSizeBits % 8 != 0)
			{
				throw new global::System.ArgumentException("Output size must be a multiple of 8 bits. :" + outputSizeBits.ToString());
			}
			this.outputSizeBytes = outputSizeBits / 8;
			this.threefish = new global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine(blockSizeBits);
			this.ubi = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.UBI(this, this.threefish.GetBlockSize());
		}

		// Token: 0x0600314C RID: 12620 RVA: 0x000EC733 File Offset: 0x000EA933
		public SkeinEngine(global::Org.BouncyCastle.Crypto.Digests.SkeinEngine engine) : this(engine.BlockSize * 8, engine.OutputSize * 8)
		{
			this.CopyIn(engine);
		}

		// Token: 0x0600314D RID: 12621 RVA: 0x000EC754 File Offset: 0x000EA954
		private void CopyIn(global::Org.BouncyCastle.Crypto.Digests.SkeinEngine engine)
		{
			this.ubi.Reset(engine.ubi);
			this.chain = global::Org.BouncyCastle.Utilities.Arrays.Clone(engine.chain, this.chain);
			this.initialState = global::Org.BouncyCastle.Utilities.Arrays.Clone(engine.initialState, this.initialState);
			this.key = global::Org.BouncyCastle.Utilities.Arrays.Clone(engine.key, this.key);
			this.preMessageParameters = global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Clone(engine.preMessageParameters, this.preMessageParameters);
			this.postMessageParameters = global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Clone(engine.postMessageParameters, this.postMessageParameters);
		}

		// Token: 0x0600314E RID: 12622 RVA: 0x000EC7E5 File Offset: 0x000EA9E5
		private static global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter[] Clone(global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter[] data, global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter[] existing)
		{
			if (data == null)
			{
				return null;
			}
			if (existing == null || existing.Length != data.Length)
			{
				existing = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter[data.Length];
			}
			global::System.Array.Copy(data, 0, existing, 0, existing.Length);
			return existing;
		}

		// Token: 0x0600314F RID: 12623 RVA: 0x000EC80E File Offset: 0x000EAA0E
		public global::Org.BouncyCastle.Utilities.IMemoable Copy()
		{
			return new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine(this);
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x000EC818 File Offset: 0x000EAA18
		public void Reset(global::Org.BouncyCastle.Utilities.IMemoable other)
		{
			global::Org.BouncyCastle.Crypto.Digests.SkeinEngine s = (global::Org.BouncyCastle.Crypto.Digests.SkeinEngine)other;
			if (this.BlockSize != s.BlockSize || this.outputSizeBytes != s.outputSizeBytes)
			{
				throw new global::Org.BouncyCastle.Utilities.MemoableResetException("Incompatible parameters in provided SkeinEngine.");
			}
			this.CopyIn(s);
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06003151 RID: 12625 RVA: 0x000EC85A File Offset: 0x000EAA5A
		public int OutputSize
		{
			get
			{
				return this.outputSizeBytes;
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x000EC862 File Offset: 0x000EAA62
		public int BlockSize
		{
			get
			{
				return this.threefish.GetBlockSize();
			}
		}

		// Token: 0x06003153 RID: 12627 RVA: 0x000EC870 File Offset: 0x000EAA70
		public void Init(global::Org.BouncyCastle.Crypto.Parameters.SkeinParameters parameters)
		{
			this.chain = null;
			this.key = null;
			this.preMessageParameters = null;
			this.postMessageParameters = null;
			if (parameters != null)
			{
				if (parameters.GetKey().Length < 16)
				{
					throw new global::System.ArgumentException("Skein key must be at least 128 bits.");
				}
				this.InitParams(parameters.GetParameters());
			}
			this.CreateInitialState();
			this.UbiInit(48);
		}

		// Token: 0x06003154 RID: 12628 RVA: 0x000EC8D0 File Offset: 0x000EAAD0
		private void InitParams(global::System.Collections.IDictionary parameters)
		{
			global::System.Collections.IEnumerator keys = parameters.Keys.GetEnumerator();
			global::System.Collections.IList pre = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			global::System.Collections.IList post = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			while (keys.MoveNext())
			{
				object obj = keys.Current;
				int type = (int)obj;
				byte[] value = (byte[])parameters[type];
				if (type == 0)
				{
					this.key = value;
				}
				else if (type < 48)
				{
					pre.Add(new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter(type, value));
				}
				else
				{
					post.Add(new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter(type, value));
				}
			}
			this.preMessageParameters = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter[pre.Count];
			pre.CopyTo(this.preMessageParameters, 0);
			global::System.Array.Sort<global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter>(this.preMessageParameters);
			this.postMessageParameters = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter[post.Count];
			post.CopyTo(this.postMessageParameters, 0);
			global::System.Array.Sort<global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter>(this.postMessageParameters);
		}

		// Token: 0x06003155 RID: 12629 RVA: 0x000EC9A4 File Offset: 0x000EABA4
		private void CreateInitialState()
		{
			ulong[] precalc = (ulong[])global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.INITIAL_STATES[global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.VariantIdentifier(this.BlockSize, this.OutputSize)];
			if (this.key == null && precalc != null)
			{
				this.chain = global::Org.BouncyCastle.Utilities.Arrays.Clone(precalc);
			}
			else
			{
				this.chain = new ulong[this.BlockSize / 8];
				if (this.key != null)
				{
					this.UbiComplete(0, this.key);
				}
				this.UbiComplete(4, new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Configuration((long)(this.outputSizeBytes * 8)).Bytes);
			}
			if (this.preMessageParameters != null)
			{
				for (int i = 0; i < this.preMessageParameters.Length; i++)
				{
					global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter param = this.preMessageParameters[i];
					this.UbiComplete(param.Type, param.Value);
				}
			}
			this.initialState = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.chain);
		}

		// Token: 0x06003156 RID: 12630 RVA: 0x000ECA79 File Offset: 0x000EAC79
		public void Reset()
		{
			global::System.Array.Copy(this.initialState, 0, this.chain, 0, this.chain.Length);
			this.UbiInit(48);
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x000ECA9E File Offset: 0x000EAC9E
		private void UbiComplete(int type, byte[] value)
		{
			this.UbiInit(type);
			this.ubi.Update(value, 0, value.Length, this.chain);
			this.UbiFinal();
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x000ECAC3 File Offset: 0x000EACC3
		private void UbiInit(int type)
		{
			this.ubi.Reset(type);
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x000ECAD1 File Offset: 0x000EACD1
		private void UbiFinal()
		{
			this.ubi.DoFinal(this.chain);
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x000ECAE4 File Offset: 0x000EACE4
		private void CheckInitialised()
		{
			if (this.ubi == null)
			{
				throw new global::System.ArgumentException("Skein engine is not initialised.");
			}
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x000ECAF9 File Offset: 0x000EACF9
		public void Update(byte inByte)
		{
			this.singleByte[0] = inByte;
			this.Update(this.singleByte, 0, 1);
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x000ECB12 File Offset: 0x000EAD12
		public void Update(byte[] inBytes, int inOff, int len)
		{
			this.CheckInitialised();
			this.ubi.Update(inBytes, inOff, len, this.chain);
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x000ECB30 File Offset: 0x000EAD30
		public int DoFinal(byte[] outBytes, int outOff)
		{
			this.CheckInitialised();
			if (outBytes.Length < outOff + this.outputSizeBytes)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("Output buffer is too short to hold output");
			}
			this.UbiFinal();
			if (this.postMessageParameters != null)
			{
				for (int i = 0; i < this.postMessageParameters.Length; i++)
				{
					global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter param = this.postMessageParameters[i];
					this.UbiComplete(param.Type, param.Value);
				}
			}
			int blockSize = this.BlockSize;
			int blocksRequired = (this.outputSizeBytes + blockSize - 1) / blockSize;
			for (int j = 0; j < blocksRequired; j++)
			{
				int toWrite = global::System.Math.Min(blockSize, this.outputSizeBytes - j * blockSize);
				this.Output((ulong)((long)j), outBytes, outOff + j * blockSize, toWrite);
			}
			this.Reset();
			return this.outputSizeBytes;
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x000ECBEC File Offset: 0x000EADEC
		private void Output(ulong outputSequence, byte[] outBytes, int outOff, int outputBytes)
		{
			byte[] currentBytes = new byte[8];
			global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.WordToBytes(outputSequence, currentBytes, 0);
			ulong[] outputWords = new ulong[this.chain.Length];
			this.UbiInit(63);
			this.ubi.Update(currentBytes, 0, currentBytes.Length, outputWords);
			this.ubi.DoFinal(outputWords);
			int wordsRequired = (outputBytes + 8 - 1) / 8;
			for (int i = 0; i < wordsRequired; i++)
			{
				int toWrite = global::System.Math.Min(8, outputBytes - i * 8);
				if (toWrite == 8)
				{
					global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.WordToBytes(outputWords[i], outBytes, outOff + i * 8);
				}
				else
				{
					global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.WordToBytes(outputWords[i], currentBytes, 0);
					global::System.Array.Copy(currentBytes, 0, outBytes, outOff + i * 8, toWrite);
				}
			}
		}

		// Token: 0x0400156F RID: 5487
		public const int SKEIN_256 = 256;

		// Token: 0x04001570 RID: 5488
		public const int SKEIN_512 = 512;

		// Token: 0x04001571 RID: 5489
		public const int SKEIN_1024 = 1024;

		// Token: 0x04001572 RID: 5490
		private const int PARAM_TYPE_KEY = 0;

		// Token: 0x04001573 RID: 5491
		private const int PARAM_TYPE_CONFIG = 4;

		// Token: 0x04001574 RID: 5492
		private const int PARAM_TYPE_MESSAGE = 48;

		// Token: 0x04001575 RID: 5493
		private const int PARAM_TYPE_OUTPUT = 63;

		// Token: 0x04001576 RID: 5494
		private static readonly global::System.Collections.IDictionary INITIAL_STATES = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001577 RID: 5495
		private readonly global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine threefish;

		// Token: 0x04001578 RID: 5496
		private readonly int outputSizeBytes;

		// Token: 0x04001579 RID: 5497
		private ulong[] chain;

		// Token: 0x0400157A RID: 5498
		private ulong[] initialState;

		// Token: 0x0400157B RID: 5499
		private byte[] key;

		// Token: 0x0400157C RID: 5500
		private global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter[] preMessageParameters;

		// Token: 0x0400157D RID: 5501
		private global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.Parameter[] postMessageParameters;

		// Token: 0x0400157E RID: 5502
		private readonly global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.UBI ubi;

		// Token: 0x0400157F RID: 5503
		private readonly byte[] singleByte = new byte[1];

		// Token: 0x02000834 RID: 2100
		private class Configuration
		{
			// Token: 0x060046EF RID: 18159 RVA: 0x00139A28 File Offset: 0x00137C28
			public Configuration(long outputSizeBits)
			{
				this.bytes[0] = 83;
				this.bytes[1] = 72;
				this.bytes[2] = 65;
				this.bytes[3] = 51;
				this.bytes[4] = 1;
				this.bytes[5] = 0;
				global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.WordToBytes((ulong)outputSizeBits, this.bytes, 8);
			}

			// Token: 0x17000AAB RID: 2731
			// (get) Token: 0x060046F0 RID: 18160 RVA: 0x00139A8F File Offset: 0x00137C8F
			public byte[] Bytes
			{
				get
				{
					return this.bytes;
				}
			}

			// Token: 0x0400256E RID: 9582
			private byte[] bytes = new byte[32];
		}

		// Token: 0x02000835 RID: 2101
		public class Parameter
		{
			// Token: 0x060046F1 RID: 18161 RVA: 0x00139A97 File Offset: 0x00137C97
			public Parameter(int type, byte[] value)
			{
				this.type = type;
				this.value = value;
			}

			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x060046F2 RID: 18162 RVA: 0x00139AAD File Offset: 0x00137CAD
			public int Type
			{
				get
				{
					return this.type;
				}
			}

			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x060046F3 RID: 18163 RVA: 0x00139AB5 File Offset: 0x00137CB5
			public byte[] Value
			{
				get
				{
					return this.value;
				}
			}

			// Token: 0x0400256F RID: 9583
			private int type;

			// Token: 0x04002570 RID: 9584
			private byte[] value;
		}

		// Token: 0x02000836 RID: 2102
		private class UbiTweak
		{
			// Token: 0x060046F4 RID: 18164 RVA: 0x00139ABD File Offset: 0x00137CBD
			public UbiTweak()
			{
				this.Reset();
			}

			// Token: 0x060046F5 RID: 18165 RVA: 0x00139AD7 File Offset: 0x00137CD7
			public void Reset(global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.UbiTweak tweak)
			{
				this.tweak = global::Org.BouncyCastle.Utilities.Arrays.Clone(tweak.tweak, this.tweak);
				this.extendedPosition = tweak.extendedPosition;
			}

			// Token: 0x060046F6 RID: 18166 RVA: 0x00139AFC File Offset: 0x00137CFC
			public void Reset()
			{
				this.tweak[0] = 0UL;
				this.tweak[1] = 0UL;
				this.extendedPosition = false;
				this.First = true;
			}

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x060046F7 RID: 18167 RVA: 0x00139B20 File Offset: 0x00137D20
			// (set) Token: 0x060046F8 RID: 18168 RVA: 0x00139B32 File Offset: 0x00137D32
			public uint Type
			{
				get
				{
					return (uint)(this.tweak[1] >> 56 & 63UL);
				}
				set
				{
					this.tweak[1] = ((this.tweak[1] & 18446743798831644672UL) | ((ulong)value & 63UL) << 56);
				}
			}

			// Token: 0x17000AAF RID: 2735
			// (get) Token: 0x060046F9 RID: 18169 RVA: 0x00139B58 File Offset: 0x00137D58
			// (set) Token: 0x060046FA RID: 18170 RVA: 0x00139B70 File Offset: 0x00137D70
			public bool First
			{
				get
				{
					return (this.tweak[1] & 4611686018427387904UL) > 0UL;
				}
				set
				{
					if (value)
					{
						this.tweak[1] |= 4611686018427387904UL;
						return;
					}
					this.tweak[1] &= 13835058055282163711UL;
				}
			}

			// Token: 0x17000AB0 RID: 2736
			// (get) Token: 0x060046FB RID: 18171 RVA: 0x00139BA8 File Offset: 0x00137DA8
			// (set) Token: 0x060046FC RID: 18172 RVA: 0x00139BC0 File Offset: 0x00137DC0
			public bool Final
			{
				get
				{
					return (this.tweak[1] & 9223372036854775808UL) > 0UL;
				}
				set
				{
					if (value)
					{
						this.tweak[1] |= 9223372036854775808UL;
						return;
					}
					this.tweak[1] &= 9223372036854775807UL;
				}
			}

			// Token: 0x060046FD RID: 18173 RVA: 0x00139BF8 File Offset: 0x00137DF8
			public void AdvancePosition(int advance)
			{
				if (this.extendedPosition)
				{
					ulong[] parts = new ulong[]
					{
						this.tweak[0] & (ulong)-1,
						this.tweak[0] >> 32 & (ulong)-1,
						this.tweak[1] & (ulong)-1
					};
					ulong carry = (ulong)((long)advance);
					for (int i = 0; i < parts.Length; i++)
					{
						carry += parts[i];
						parts[i] = carry;
						carry >>= 32;
					}
					this.tweak[0] = ((parts[1] & (ulong)-1) << 32 | (parts[0] & (ulong)-1));
					this.tweak[1] = ((this.tweak[1] & 18446744069414584320UL) | (parts[2] & (ulong)-1));
					return;
				}
				ulong position = this.tweak[0];
				position += (ulong)advance;
				this.tweak[0] = position;
				if (position > 18446744069414584320UL)
				{
					this.extendedPosition = true;
				}
			}

			// Token: 0x060046FE RID: 18174 RVA: 0x00139CC8 File Offset: 0x00137EC8
			public ulong[] GetWords()
			{
				return this.tweak;
			}

			// Token: 0x060046FF RID: 18175 RVA: 0x00139CD0 File Offset: 0x00137ED0
			public override string ToString()
			{
				return string.Concat(new string[]
				{
					this.Type.ToString(),
					" first: ",
					this.First.ToString(),
					", final: ",
					this.Final.ToString()
				});
			}

			// Token: 0x04002571 RID: 9585
			private const ulong LOW_RANGE = 18446744069414584320UL;

			// Token: 0x04002572 RID: 9586
			private const ulong T1_FINAL = 9223372036854775808UL;

			// Token: 0x04002573 RID: 9587
			private const ulong T1_FIRST = 4611686018427387904UL;

			// Token: 0x04002574 RID: 9588
			private ulong[] tweak = new ulong[2];

			// Token: 0x04002575 RID: 9589
			private bool extendedPosition;
		}

		// Token: 0x02000837 RID: 2103
		private class UBI
		{
			// Token: 0x06004700 RID: 18176 RVA: 0x00139D2B File Offset: 0x00137F2B
			public UBI(global::Org.BouncyCastle.Crypto.Digests.SkeinEngine engine, int blockSize)
			{
				this.engine = engine;
				this.currentBlock = new byte[blockSize];
				this.message = new ulong[this.currentBlock.Length / 8];
			}

			// Token: 0x06004701 RID: 18177 RVA: 0x00139D68 File Offset: 0x00137F68
			public void Reset(global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.UBI ubi)
			{
				this.currentBlock = global::Org.BouncyCastle.Utilities.Arrays.Clone(ubi.currentBlock, this.currentBlock);
				this.currentOffset = ubi.currentOffset;
				this.message = global::Org.BouncyCastle.Utilities.Arrays.Clone(ubi.message, this.message);
				this.tweak.Reset(ubi.tweak);
			}

			// Token: 0x06004702 RID: 18178 RVA: 0x00139DC0 File Offset: 0x00137FC0
			public void Reset(int type)
			{
				this.tweak.Reset();
				this.tweak.Type = (uint)type;
				this.currentOffset = 0;
			}

			// Token: 0x06004703 RID: 18179 RVA: 0x00139DE0 File Offset: 0x00137FE0
			public void Update(byte[] value, int offset, int len, ulong[] output)
			{
				int copied = 0;
				while (len > copied)
				{
					if (this.currentOffset == this.currentBlock.Length)
					{
						this.ProcessBlock(output);
						this.tweak.First = false;
						this.currentOffset = 0;
					}
					int toCopy = global::System.Math.Min(len - copied, this.currentBlock.Length - this.currentOffset);
					global::System.Array.Copy(value, offset + copied, this.currentBlock, this.currentOffset, toCopy);
					copied += toCopy;
					this.currentOffset += toCopy;
					this.tweak.AdvancePosition(toCopy);
				}
			}

			// Token: 0x06004704 RID: 18180 RVA: 0x00139E6C File Offset: 0x0013806C
			private void ProcessBlock(ulong[] output)
			{
				this.engine.threefish.Init(true, this.engine.chain, this.tweak.GetWords());
				for (int i = 0; i < this.message.Length; i++)
				{
					this.message[i] = global::Org.BouncyCastle.Crypto.Engines.ThreefishEngine.BytesToWord(this.currentBlock, i * 8);
				}
				this.engine.threefish.ProcessBlock(this.message, output);
				for (int j = 0; j < output.Length; j++)
				{
					output[j] ^= this.message[j];
				}
			}

			// Token: 0x06004705 RID: 18181 RVA: 0x00139F04 File Offset: 0x00138104
			public void DoFinal(ulong[] output)
			{
				for (int i = this.currentOffset; i < this.currentBlock.Length; i++)
				{
					this.currentBlock[i] = 0;
				}
				this.tweak.Final = true;
				this.ProcessBlock(output);
			}

			// Token: 0x04002576 RID: 9590
			private readonly global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.UbiTweak tweak = new global::Org.BouncyCastle.Crypto.Digests.SkeinEngine.UbiTweak();

			// Token: 0x04002577 RID: 9591
			private readonly global::Org.BouncyCastle.Crypto.Digests.SkeinEngine engine;

			// Token: 0x04002578 RID: 9592
			private byte[] currentBlock;

			// Token: 0x04002579 RID: 9593
			private int currentOffset;

			// Token: 0x0400257A RID: 9594
			private ulong[] message;
		}
	}
}
