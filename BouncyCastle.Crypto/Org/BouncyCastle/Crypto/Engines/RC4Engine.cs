using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines
{
	// Token: 0x020004A8 RID: 1192
	public class RC4Engine : global::Org.BouncyCastle.Crypto.IStreamCipher
	{
		// Token: 0x06002DFA RID: 11770 RVA: 0x000CFCBE File Offset: 0x000CDEBE
		public virtual void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)
			{
				this.workingKey = ((global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)parameters).GetKey();
				this.SetKey(this.workingKey);
				return;
			}
			throw new global::System.ArgumentException("invalid parameter passed to RC4 init - " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(parameters));
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x000CFCFB File Offset: 0x000CDEFB
		public virtual string AlgorithmName
		{
			get
			{
				return "RC4";
			}
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x000CFD04 File Offset: 0x000CDF04
		public virtual byte ReturnByte(byte input)
		{
			this.x = (this.x + 1 & 255);
			this.y = ((int)this.engineState[this.x] + this.y & 255);
			byte tmp = this.engineState[this.x];
			this.engineState[this.x] = this.engineState[this.y];
			this.engineState[this.y] = tmp;
			return input ^ this.engineState[(int)(this.engineState[this.x] + this.engineState[this.y] & byte.MaxValue)];
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x000CFDA8 File Offset: 0x000CDFA8
		public virtual void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			global::Org.BouncyCastle.Crypto.Check.DataLength(input, inOff, length, "input buffer too short");
			global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, length, "output buffer too short");
			for (int i = 0; i < length; i++)
			{
				this.x = (this.x + 1 & 255);
				this.y = ((int)this.engineState[this.x] + this.y & 255);
				byte tmp = this.engineState[this.x];
				this.engineState[this.x] = this.engineState[this.y];
				this.engineState[this.y] = tmp;
				output[i + outOff] = (input[i + inOff] ^ this.engineState[(int)(this.engineState[this.x] + this.engineState[this.y] & byte.MaxValue)]);
			}
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x000CFE83 File Offset: 0x000CE083
		public virtual void Reset()
		{
			this.SetKey(this.workingKey);
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000CFE94 File Offset: 0x000CE094
		private void SetKey(byte[] keyBytes)
		{
			this.workingKey = keyBytes;
			this.x = 0;
			this.y = 0;
			if (this.engineState == null)
			{
				this.engineState = new byte[global::Org.BouncyCastle.Crypto.Engines.RC4Engine.STATE_LENGTH];
			}
			for (int i = 0; i < global::Org.BouncyCastle.Crypto.Engines.RC4Engine.STATE_LENGTH; i++)
			{
				this.engineState[i] = (byte)i;
			}
			int i2 = 0;
			int i3 = 0;
			for (int j = 0; j < global::Org.BouncyCastle.Crypto.Engines.RC4Engine.STATE_LENGTH; j++)
			{
				i3 = ((int)((keyBytes[i2] & byte.MaxValue) + this.engineState[j]) + i3 & 255);
				byte tmp = this.engineState[j];
				this.engineState[j] = this.engineState[i3];
				this.engineState[i3] = tmp;
				i2 = (i2 + 1) % keyBytes.Length;
			}
		}

		// Token: 0x04001378 RID: 4984
		private static readonly int STATE_LENGTH = 256;

		// Token: 0x04001379 RID: 4985
		private byte[] engineState;

		// Token: 0x0400137A RID: 4986
		private int x;

		// Token: 0x0400137B RID: 4987
		private int y;

		// Token: 0x0400137C RID: 4988
		private byte[] workingKey;
	}
}
