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
    /// <para>Added an exception for one or more team members to bypass space limits imposed by
    /// policy.</para>
    /// </summary>
    public class MemberSpaceLimitsAddExceptionDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberSpaceLimitsAddExceptionDetails> Encoder = new MemberSpaceLimitsAddExceptionDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberSpaceLimitsAddExceptionDetails> Decoder = new MemberSpaceLimitsAddExceptionDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberSpaceLimitsAddExceptionDetails" /> class.</para>
        /// </summary>
        public MemberSpaceLimitsAddExceptionDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberSpaceLimitsAddExceptionDetails" />.</para>
        /// </summary>
        private class MemberSpaceLimitsAddExceptionDetailsEncoder : enc.StructEncoder<MemberSpaceLimitsAddExceptionDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberSpaceLimitsAddExceptionDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberSpaceLimitsAddExceptionDetails" />.</para>
        /// </summary>
        private class MemberSpaceLimitsAddExceptionDetailsDecoder : enc.StructDecoder<MemberSpaceLimitsAddExceptionDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="MemberSpaceLimitsAddExceptionDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberSpaceLimitsAddExceptionDetails Create()
            {
                return new MemberSpaceLimitsAddExceptionDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberSpaceLimitsAddExceptionDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
