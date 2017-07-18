// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Verified a domain belonging to the team.</para>
    /// </summary>
    public class DomainVerificationAddDomainSuccessDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<DomainVerificationAddDomainSuccessDetails> Encoder = new DomainVerificationAddDomainSuccessDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<DomainVerificationAddDomainSuccessDetails> Decoder = new DomainVerificationAddDomainSuccessDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DomainVerificationAddDomainSuccessDetails" /> class.</para>
        /// </summary>
        /// <param name="domainNames">Domain names.</param>
        /// <param name="verificationMethod">Domain name verification method.</param>
        public DomainVerificationAddDomainSuccessDetails(col.IEnumerable<string> domainNames,
                                                         string verificationMethod = null)
        {
            var domainNamesList = enc.Util.ToList(domainNames);

            if (domainNames == null)
            {
                throw new sys.ArgumentNullException("domainNames");
            }

            this.DomainNames = domainNamesList;
            this.VerificationMethod = verificationMethod;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="DomainVerificationAddDomainSuccessDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public DomainVerificationAddDomainSuccessDetails()
        {
        }

        /// <summary>
        /// <para>Domain names.</para>
        /// </summary>
        public col.IList<string> DomainNames { get; protected set; }

        /// <summary>
        /// <para>Domain name verification method.</para>
        /// </summary>
        public string VerificationMethod { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="DomainVerificationAddDomainSuccessDetails" />.</para>
        /// </summary>
        private class DomainVerificationAddDomainSuccessDetailsEncoder : enc.StructEncoder<DomainVerificationAddDomainSuccessDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(DomainVerificationAddDomainSuccessDetails value, enc.IJsonWriter writer)
            {
                WriteListProperty("domain_names", value.DomainNames, writer, enc.StringEncoder.Instance);
                if (value.VerificationMethod != null)
                {
                    WriteProperty("verification_method", value.VerificationMethod, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="DomainVerificationAddDomainSuccessDetails" />.</para>
        /// </summary>
        private class DomainVerificationAddDomainSuccessDetailsDecoder : enc.StructDecoder<DomainVerificationAddDomainSuccessDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="DomainVerificationAddDomainSuccessDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override DomainVerificationAddDomainSuccessDetails Create()
            {
                return new DomainVerificationAddDomainSuccessDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(DomainVerificationAddDomainSuccessDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "domain_names":
                        value.DomainNames = ReadList<string>(reader, enc.StringDecoder.Instance);
                        break;
                    case "verification_method":
                        value.VerificationMethod = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
