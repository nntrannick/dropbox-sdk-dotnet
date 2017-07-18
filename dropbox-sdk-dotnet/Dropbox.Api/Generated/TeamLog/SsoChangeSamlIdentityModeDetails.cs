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
    /// <para>Changed the SAML identity mode for SSO.</para>
    /// </summary>
    public class SsoChangeSamlIdentityModeDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SsoChangeSamlIdentityModeDetails> Encoder = new SsoChangeSamlIdentityModeDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SsoChangeSamlIdentityModeDetails> Decoder = new SsoChangeSamlIdentityModeDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SsoChangeSamlIdentityModeDetails" /> class.</para>
        /// </summary>
        /// <param name="previousSamlIdentityMode">Previous single sign-on identity
        /// mode.</param>
        /// <param name="newSamlIdentityMode">New single sign-on identity mode.</param>
        public SsoChangeSamlIdentityModeDetails(long previousSamlIdentityMode,
                                                long newSamlIdentityMode)
        {
            this.PreviousSamlIdentityMode = previousSamlIdentityMode;
            this.NewSamlIdentityMode = newSamlIdentityMode;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SsoChangeSamlIdentityModeDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SsoChangeSamlIdentityModeDetails()
        {
        }

        /// <summary>
        /// <para>Previous single sign-on identity mode.</para>
        /// </summary>
        public long PreviousSamlIdentityMode { get; protected set; }

        /// <summary>
        /// <para>New single sign-on identity mode.</para>
        /// </summary>
        public long NewSamlIdentityMode { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SsoChangeSamlIdentityModeDetails" />.</para>
        /// </summary>
        private class SsoChangeSamlIdentityModeDetailsEncoder : enc.StructEncoder<SsoChangeSamlIdentityModeDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SsoChangeSamlIdentityModeDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("previous_saml_identity_mode", value.PreviousSamlIdentityMode, writer, enc.Int64Encoder.Instance);
                WriteProperty("new_saml_identity_mode", value.NewSamlIdentityMode, writer, enc.Int64Encoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SsoChangeSamlIdentityModeDetails" />.</para>
        /// </summary>
        private class SsoChangeSamlIdentityModeDetailsDecoder : enc.StructDecoder<SsoChangeSamlIdentityModeDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SsoChangeSamlIdentityModeDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SsoChangeSamlIdentityModeDetails Create()
            {
                return new SsoChangeSamlIdentityModeDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SsoChangeSamlIdentityModeDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_saml_identity_mode":
                        value.PreviousSamlIdentityMode = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "new_saml_identity_mode":
                        value.NewSamlIdentityMode = enc.Int64Decoder.Instance.Decode(reader);
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
