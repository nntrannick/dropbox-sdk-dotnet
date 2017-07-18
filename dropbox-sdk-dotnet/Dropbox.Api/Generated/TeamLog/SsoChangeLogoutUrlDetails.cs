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
    /// <para>Changed the sign-out URL for SSO.</para>
    /// </summary>
    public class SsoChangeLogoutUrlDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SsoChangeLogoutUrlDetails> Encoder = new SsoChangeLogoutUrlDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SsoChangeLogoutUrlDetails> Decoder = new SsoChangeLogoutUrlDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoChangeLogoutUrlDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="previousSsoLogoutUrl">Previous single sign-on logout URL.</param>
        /// <param name="newSsoLogoutUrl">New single sign-on logout URL. Might be missing due
        /// to historical data gap.</param>
        public SsoChangeLogoutUrlDetails(string previousSsoLogoutUrl,
                                         string newSsoLogoutUrl = null)
        {
            if (previousSsoLogoutUrl == null)
            {
                throw new sys.ArgumentNullException("previousSsoLogoutUrl");
            }

            this.PreviousSsoLogoutUrl = previousSsoLogoutUrl;
            this.NewSsoLogoutUrl = newSsoLogoutUrl;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoChangeLogoutUrlDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SsoChangeLogoutUrlDetails()
        {
        }

        /// <summary>
        /// <para>Previous single sign-on logout URL.</para>
        /// </summary>
        public string PreviousSsoLogoutUrl { get; protected set; }

        /// <summary>
        /// <para>New single sign-on logout URL. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public string NewSsoLogoutUrl { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SsoChangeLogoutUrlDetails" />.</para>
        /// </summary>
        private class SsoChangeLogoutUrlDetailsEncoder : enc.StructEncoder<SsoChangeLogoutUrlDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SsoChangeLogoutUrlDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("previous_sso_logout_url", value.PreviousSsoLogoutUrl, writer, enc.StringEncoder.Instance);
                if (value.NewSsoLogoutUrl != null)
                {
                    WriteProperty("new_sso_logout_url", value.NewSsoLogoutUrl, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SsoChangeLogoutUrlDetails" />.</para>
        /// </summary>
        private class SsoChangeLogoutUrlDetailsDecoder : enc.StructDecoder<SsoChangeLogoutUrlDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SsoChangeLogoutUrlDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SsoChangeLogoutUrlDetails Create()
            {
                return new SsoChangeLogoutUrlDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SsoChangeLogoutUrlDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_sso_logout_url":
                        value.PreviousSsoLogoutUrl = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "new_sso_logout_url":
                        value.NewSsoLogoutUrl = enc.StringDecoder.Instance.Decode(reader);
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
