using System;
using System.Security.Claims;
using System.Xml;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000037 RID: 55
	public abstract class SecurityTokenHandler : global::Microsoft.IdentityModel.Tokens.ISecurityTokenValidator
	{
		// Token: 0x06000161 RID: 353 RVA: 0x00006C3D File Offset: 0x00004E3D
		public virtual global::Microsoft.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateSecurityTokenReference(global::Microsoft.IdentityModel.Tokens.SecurityToken token, bool attached)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00006C44 File Offset: 0x00004E44
		public virtual global::Microsoft.IdentityModel.Tokens.SecurityToken CreateToken(global::Microsoft.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00006C4B File Offset: 0x00004E4B
		public virtual bool CanValidateToken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00006C4E File Offset: 0x00004E4E
		public virtual bool CanWriteToken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000165 RID: 357
		public abstract global::System.Type TokenType { get; }

		// Token: 0x06000166 RID: 358 RVA: 0x00006C51 File Offset: 0x00004E51
		public virtual bool CanReadToken(string tokenString)
		{
			return false;
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00006C54 File Offset: 0x00004E54
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00006C5C File Offset: 0x00004E5C
		public virtual int MaximumTokenSizeInBytes
		{
			get
			{
				return this._maximumTokenSizeInBytes;
			}
			set
			{
				if (value < 1)
				{
					throw global::Microsoft.IdentityModel.Logging.LogHelper.LogExceptionMessage(new global::System.ArgumentOutOfRangeException("value", global::Microsoft.IdentityModel.Logging.LogHelper.FormatInvariant("IDX10101: MaximumTokenSizeInBytes must be greater than zero. value: '{0}'", new object[]
					{
						value
					})));
				}
				this._maximumTokenSizeInBytes = value;
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00006C92 File Offset: 0x00004E92
		public virtual global::Microsoft.IdentityModel.Tokens.SecurityToken ReadToken(string tokenString)
		{
			return null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00006C95 File Offset: 0x00004E95
		public virtual global::Microsoft.IdentityModel.Tokens.SecurityToken ReadToken(global::System.Xml.XmlReader reader)
		{
			return null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00006C98 File Offset: 0x00004E98
		public virtual string WriteToken(global::Microsoft.IdentityModel.Tokens.SecurityToken token)
		{
			return null;
		}

		// Token: 0x0600016C RID: 364
		public abstract void WriteToken(global::System.Xml.XmlWriter writer, global::Microsoft.IdentityModel.Tokens.SecurityToken token);

		// Token: 0x0600016D RID: 365
		public abstract global::Microsoft.IdentityModel.Tokens.SecurityToken ReadToken(global::System.Xml.XmlReader reader, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters);

		// Token: 0x0600016E RID: 366 RVA: 0x00006C9B File Offset: 0x00004E9B
		public virtual global::System.Security.Claims.ClaimsPrincipal ValidateToken(string securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters, out global::Microsoft.IdentityModel.Tokens.SecurityToken validatedToken)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000158 RID: 344
		private int _maximumTokenSizeInBytes = 2097152;
	}
}
