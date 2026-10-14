using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;
using Newtonsoft.Json;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000027 RID: 39
	[global::Newtonsoft.Json.JsonObject]
	public class JsonWebKey : global::Microsoft.IdentityModel.Tokens.SecurityKey
	{
		// Token: 0x060000DF RID: 223 RVA: 0x00005493 File Offset: 0x00003693
		public static global::Microsoft.IdentityModel.Tokens.JsonWebKey Create(string json)
		{
			if (string.IsNullOrEmpty(json))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("json");
			}
			return new global::Microsoft.IdentityModel.Tokens.JsonWebKey(json);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000054AE File Offset: 0x000036AE
		public JsonWebKey()
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000054D8 File Offset: 0x000036D8
		public JsonWebKey(string json)
		{
			if (string.IsNullOrEmpty(json))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("json");
			}
			try
			{
				global::Microsoft.IdentityModel.Logging.LogHelper.LogVerbose("IDX10806: Deserializing json: '{0}' into '{1}'.", new object[]
				{
					json,
					this
				});
				global::Newtonsoft.Json.JsonConvert.PopulateObject(json, this);
			}
			catch (global::System.Exception innerException)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10805: Error deserializing json: '{0}' into '{1}'.", new object[]
				{
					json,
					base.GetType()
				}), innerException));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000557C File Offset: 0x0000377C
		[global::Newtonsoft.Json.JsonExtensionData]
		public virtual global::System.Collections.Generic.IDictionary<string, object> AdditionalData { get; } = new global::System.Collections.Generic.Dictionary<string, object>();

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005584 File Offset: 0x00003784
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000558C File Offset: 0x0000378C
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "alg", Required = global::Newtonsoft.Json.Required.Default)]
		public string Alg { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00005595 File Offset: 0x00003795
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000559D File Offset: 0x0000379D
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "crv", Required = global::Newtonsoft.Json.Required.Default)]
		public string Crv { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000055A6 File Offset: 0x000037A6
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000055AE File Offset: 0x000037AE
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "d", Required = global::Newtonsoft.Json.Required.Default)]
		public string D { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000055B7 File Offset: 0x000037B7
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000055BF File Offset: 0x000037BF
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "dp", Required = global::Newtonsoft.Json.Required.Default)]
		public string DP { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000055C8 File Offset: 0x000037C8
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000055D0 File Offset: 0x000037D0
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "dq", Required = global::Newtonsoft.Json.Required.Default)]
		public string DQ { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000ED RID: 237 RVA: 0x000055D9 File Offset: 0x000037D9
		// (set) Token: 0x060000EE RID: 238 RVA: 0x000055E1 File Offset: 0x000037E1
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "e", Required = global::Newtonsoft.Json.Required.Default)]
		public string E { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000055EA File Offset: 0x000037EA
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x000055F2 File Offset: 0x000037F2
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "k", Required = global::Newtonsoft.Json.Required.Default)]
		public string K { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x000055FB File Offset: 0x000037FB
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00005603 File Offset: 0x00003803
		[global::Newtonsoft.Json.JsonIgnore]
		public override string KeyId
		{
			get
			{
				return this._kid;
			}
			set
			{
				this._kid = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000560C File Offset: 0x0000380C
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00005614 File Offset: 0x00003814
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "key_ops", Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.IList<string> KeyOps { get; private set; } = new global::System.Collections.Generic.List<string>();

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000561D File Offset: 0x0000381D
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00005625 File Offset: 0x00003825
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "kid", Required = global::Newtonsoft.Json.Required.Default)]
		public string Kid
		{
			get
			{
				return this._kid;
			}
			set
			{
				this._kid = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000562E File Offset: 0x0000382E
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00005636 File Offset: 0x00003836
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "kty", Required = global::Newtonsoft.Json.Required.Default)]
		public string Kty { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000563F File Offset: 0x0000383F
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00005647 File Offset: 0x00003847
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "n", Required = global::Newtonsoft.Json.Required.Default)]
		public string N { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00005650 File Offset: 0x00003850
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00005658 File Offset: 0x00003858
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "oth", Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.IList<string> Oth { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005661 File Offset: 0x00003861
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00005669 File Offset: 0x00003869
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "p", Required = global::Newtonsoft.Json.Required.Default)]
		public string P { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00005672 File Offset: 0x00003872
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000567A File Offset: 0x0000387A
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "q", Required = global::Newtonsoft.Json.Required.Default)]
		public string Q { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00005683 File Offset: 0x00003883
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000568B File Offset: 0x0000388B
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "qi", Required = global::Newtonsoft.Json.Required.Default)]
		public string QI { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00005694 File Offset: 0x00003894
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000569C File Offset: 0x0000389C
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "use", Required = global::Newtonsoft.Json.Required.Default)]
		public string Use { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000056A5 File Offset: 0x000038A5
		// (set) Token: 0x06000106 RID: 262 RVA: 0x000056AD File Offset: 0x000038AD
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x", Required = global::Newtonsoft.Json.Required.Default)]
		public string X { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000056B6 File Offset: 0x000038B6
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000056BE File Offset: 0x000038BE
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x5c", Required = global::Newtonsoft.Json.Required.Default)]
		public global::System.Collections.Generic.IList<string> X5c { get; private set; } = new global::System.Collections.Generic.List<string>();

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000056C7 File Offset: 0x000038C7
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000056CF File Offset: 0x000038CF
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x5t", Required = global::Newtonsoft.Json.Required.Default)]
		public string X5t { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000056D8 File Offset: 0x000038D8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000056E0 File Offset: 0x000038E0
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x5t#S256", Required = global::Newtonsoft.Json.Required.Default)]
		public string X5tS256 { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000056E9 File Offset: 0x000038E9
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000056F1 File Offset: 0x000038F1
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "x5u", Required = global::Newtonsoft.Json.Required.Default)]
		public string X5u { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000056FA File Offset: 0x000038FA
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00005702 File Offset: 0x00003902
		[global::Newtonsoft.Json.JsonProperty(DefaultValueHandling = global::Newtonsoft.Json.DefaultValueHandling.Ignore, NullValueHandling = global::Newtonsoft.Json.NullValueHandling.Ignore, PropertyName = "y", Required = global::Newtonsoft.Json.Required.Default)]
		public string Y { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000570C File Offset: 0x0000390C
		[global::Newtonsoft.Json.JsonIgnore]
		public override int KeySize
		{
			get
			{
				if (this.Kty == "RSA" && !string.IsNullOrEmpty(this.N))
				{
					return global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.N).Length * 8;
				}
				if (this.Kty == "EC" && !string.IsNullOrEmpty(this.X))
				{
					return global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.X).Length * 8;
				}
				if (this.Kty == "oct" && !string.IsNullOrEmpty(this.K))
				{
					return global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.K).Length * 8;
				}
				return 0;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000057A8 File Offset: 0x000039A8
		[global::Newtonsoft.Json.JsonIgnore]
		public bool HasPrivateKey
		{
			get
			{
				if (this.Kty == "RSA")
				{
					return this.D != null && this.DP != null && this.DQ != null && this.P != null && this.Q != null && this.QI != null;
				}
				return this.Kty == "EC" && this.D != null;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005818 File Offset: 0x00003A18
		public bool ShouldSerializeKeyOps()
		{
			return this.KeyOps.Count > 0;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005828 File Offset: 0x00003A28
		public bool ShouldSerializeX5c()
		{
			return this.X5c.Count > 0;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00005838 File Offset: 0x00003A38
		internal global::System.Security.Cryptography.ECDsa CreateECDsa(string algorithm, bool usePrivateKey)
		{
			if (this.Crv == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("Crv");
			}
			if (this.X == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("X");
			}
			if (this.Y == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("Y");
			}
			int keySize = this.GetKeySize(this.Crv);
			if (!global::Microsoft.IdentityModel.Tokens.Utility.ValidateECDSAKeySize(keySize, algorithm))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("keySize", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10675: The value of '{0}' must be '{1}' bits, but was {2}.", new object[]
				{
					"keySize",
					global::Microsoft.IdentityModel.Tokens.ECDsaAlgorithm.DefaultECDsaKeySizeInBitsMap[algorithm],
					keySize
				})));
			}
			global::System.Runtime.InteropServices.GCHandle gchandle = default(global::System.Runtime.InteropServices.GCHandle);
			global::System.Security.Cryptography.ECDsa result;
			try
			{
				uint magicValue = this.GetMagicValue(this.Crv, usePrivateKey);
				uint keyByteCount = this.GetKeyByteCount(this.Crv);
				byte[] array;
				if (usePrivateKey)
				{
					array = new byte[(ulong)(3U * keyByteCount) + (ulong)((long)(2 * global::System.Runtime.InteropServices.Marshal.SizeOf<uint>()))];
				}
				else
				{
					array = new byte[(ulong)(2U * keyByteCount) + (ulong)((long)(2 * global::System.Runtime.InteropServices.Marshal.SizeOf<uint>()))];
				}
				gchandle = global::System.Runtime.InteropServices.GCHandle.Alloc(array, global::System.Runtime.InteropServices.GCHandleType.Pinned);
				global::System.IntPtr intPtr = gchandle.AddrOfPinnedObject();
				byte[] array2 = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.X);
				if ((long)array2.Length > (long)((ulong)keyByteCount))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("x.Length", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10675: The value of '{0}' must be '{1}' bits, but was {2}.", new object[]
					{
						"x",
						keyByteCount,
						array2.Length
					})));
				}
				byte[] array3 = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.Y);
				if ((long)array3.Length > (long)((ulong)keyByteCount))
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("y.Length", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10675: The value of '{0}' must be '{1}' bits, but was {2}.", new object[]
					{
						"y",
						keyByteCount,
						array3.Length
					})));
				}
				global::System.Runtime.InteropServices.Marshal.WriteInt64(intPtr, 0, (long)((ulong)magicValue));
				global::System.Runtime.InteropServices.Marshal.WriteInt64(intPtr, 4, (long)((ulong)keyByteCount));
				int num = 8;
				foreach (byte val in array2)
				{
					global::System.Runtime.InteropServices.Marshal.WriteByte(intPtr, num++, val);
				}
				foreach (byte val2 in array3)
				{
					global::System.Runtime.InteropServices.Marshal.WriteByte(intPtr, num++, val2);
				}
				if (usePrivateKey)
				{
					if (this.D == null)
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("D");
					}
					byte[] array5 = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.D);
					if ((long)array5.Length > (long)((ulong)keyByteCount))
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("d.Length", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10675: The value of '{0}' must be '{1}' bits, but was {2}.", new object[]
						{
							"d",
							keyByteCount,
							array5.Length
						})));
					}
					foreach (byte val3 in array5)
					{
						global::System.Runtime.InteropServices.Marshal.WriteByte(intPtr, num++, val3);
					}
					global::System.Runtime.InteropServices.Marshal.Copy(intPtr, array, 0, array.Length);
					using (global::System.Security.Cryptography.CngKey cngKey = global::System.Security.Cryptography.CngKey.Import(array, global::System.Security.Cryptography.CngKeyBlobFormat.EccPrivateBlob))
					{
						return new global::System.Security.Cryptography.ECDsaCng(cngKey);
					}
				}
				global::System.Runtime.InteropServices.Marshal.Copy(intPtr, array, 0, array.Length);
				using (global::System.Security.Cryptography.CngKey cngKey2 = global::System.Security.Cryptography.CngKey.Import(array, global::System.Security.Cryptography.CngKeyBlobFormat.EccPublicBlob))
				{
					result = new global::System.Security.Cryptography.ECDsaCng(cngKey2);
				}
			}
			finally
			{
				gchandle.Free();
			}
			return result;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005BAC File Offset: 0x00003DAC
		internal global::System.Security.Cryptography.RSAParameters CreateRsaParameters()
		{
			if (this.N == null || this.E == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10700: Invalid RsaParameters: '{0}'. Both modulus and exponent should be present", new object[]
				{
					this
				})));
			}
			global::System.Security.Cryptography.RSAParameters result = default(global::System.Security.Cryptography.RSAParameters);
			if (this.D != null)
			{
				result.D = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.D);
			}
			if (this.DP != null)
			{
				result.DP = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.DP);
			}
			if (this.DQ != null)
			{
				result.DQ = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.DQ);
			}
			if (this.QI != null)
			{
				result.InverseQ = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.QI);
			}
			if (this.P != null)
			{
				result.P = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.P);
			}
			if (this.Q != null)
			{
				result.Q = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.Q);
			}
			result.Exponent = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.E);
			result.Modulus = global::Microsoft.IdentityModel.Tokens.Base64UrlEncoder.DecodeBytes(this.N);
			return result;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005CB4 File Offset: 0x00003EB4
		private uint GetKeyByteCount(string curveId)
		{
			if (string.IsNullOrEmpty(curveId))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("curveId");
			}
			uint result;
			if (!(curveId == "P-256"))
			{
				if (!(curveId == "P-384"))
				{
					if (!(curveId == "P-512") && !(curveId == "P-521"))
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10645: Elliptical Curve not supported for curveId: '{0}'", new object[]
						{
							curveId
						})));
					}
					result = 66U;
				}
				else
				{
					result = 48U;
				}
			}
			else
			{
				result = 32U;
			}
			return result;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005D3C File Offset: 0x00003F3C
		private int GetKeySize(string curveId)
		{
			if (string.IsNullOrEmpty(curveId))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("curveId");
			}
			int result;
			if (!(curveId == "P-256"))
			{
				if (!(curveId == "P-384"))
				{
					if (!(curveId == "P-512") && !(curveId == "P-521"))
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10645: Elliptical Curve not supported for curveId: '{0}'", new object[]
						{
							curveId
						})));
					}
					result = 521;
				}
				else
				{
					result = 384;
				}
			}
			else
			{
				result = 256;
			}
			return result;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005DCC File Offset: 0x00003FCC
		private uint GetMagicValue(string curveId, bool willCreateSignatures)
		{
			if (string.IsNullOrEmpty(curveId))
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("curveId");
			}
			global::Microsoft.IdentityModel.Tokens.JsonWebKey.KeyBlobMagicNumber result;
			if (!(curveId == "P-256"))
			{
				if (!(curveId == "P-384"))
				{
					if (!(curveId == "P-512") && !(curveId == "P-521"))
					{
						throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentException(global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10645: Elliptical Curve not supported for curveId: '{0}'", new object[]
						{
							curveId
						})));
					}
					if (willCreateSignatures)
					{
						result = global::Microsoft.IdentityModel.Tokens.JsonWebKey.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P521_MAGIC;
					}
					else
					{
						result = global::Microsoft.IdentityModel.Tokens.JsonWebKey.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P521_MAGIC;
					}
				}
				else if (willCreateSignatures)
				{
					result = global::Microsoft.IdentityModel.Tokens.JsonWebKey.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P384_MAGIC;
				}
				else
				{
					result = global::Microsoft.IdentityModel.Tokens.JsonWebKey.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P384_MAGIC;
				}
			}
			else if (willCreateSignatures)
			{
				result = global::Microsoft.IdentityModel.Tokens.JsonWebKey.KeyBlobMagicNumber.BCRYPT_ECDSA_PRIVATE_P256_MAGIC;
			}
			else
			{
				result = global::Microsoft.IdentityModel.Tokens.JsonWebKey.KeyBlobMagicNumber.BCRYPT_ECDSA_PUBLIC_P256_MAGIC;
			}
			return (uint)result;
		}

		// Token: 0x0400004D RID: 77
		private string _kid;

		// Token: 0x0200004F RID: 79
		internal enum KeyBlobMagicNumber : uint
		{
			// Token: 0x040001A9 RID: 425
			BCRYPT_ECDSA_PUBLIC_P256_MAGIC = 827540293U,
			// Token: 0x040001AA RID: 426
			BCRYPT_ECDSA_PUBLIC_P384_MAGIC = 861094725U,
			// Token: 0x040001AB RID: 427
			BCRYPT_ECDSA_PUBLIC_P521_MAGIC = 894649157U,
			// Token: 0x040001AC RID: 428
			BCRYPT_ECDSA_PRIVATE_P256_MAGIC = 844317509U,
			// Token: 0x040001AD RID: 429
			BCRYPT_ECDSA_PRIVATE_P384_MAGIC = 877871941U,
			// Token: 0x040001AE RID: 430
			BCRYPT_ECDSA_PRIVATE_P521_MAGIC = 911426373U
		}
	}
}
