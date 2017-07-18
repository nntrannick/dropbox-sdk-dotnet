// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Arguments for <see
    /// cref="Dropbox.Api.Sharing.Routes.SharingUserRoutes.RemoveFileMember2Async" />.</para>
    /// </summary>
    public class RemoveFileMemberArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<RemoveFileMemberArg> Encoder = new RemoveFileMemberArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<RemoveFileMemberArg> Decoder = new RemoveFileMemberArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemoveFileMemberArg" />
        /// class.</para>
        /// </summary>
        /// <param name="file">File from which to remove members.</param>
        /// <param name="member">Member to remove from this file. Note that even if an email is
        /// specified, it may result in the removal of a user (not an invitee) if the user's
        /// main account corresponds to that email address.</param>
        public RemoveFileMemberArg(string file,
                                   MemberSelector member)
        {
            if (file == null)
            {
                throw new sys.ArgumentNullException("file");
            }
            if (file.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("file", "Length should be at least 1");
            }
            if (!re.Regex.IsMatch(file, @"\A(?:((/|id:).*|nspath:[0-9]+:.*)|ns:[0-9]+(/.*)?)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("file", @"Value should match pattern '\A(?:((/|id:).*|nspath:[0-9]+:.*)|ns:[0-9]+(/.*)?)\z'");
            }

            if (member == null)
            {
                throw new sys.ArgumentNullException("member");
            }

            this.File = file;
            this.Member = member;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="RemoveFileMemberArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public RemoveFileMemberArg()
        {
        }

        /// <summary>
        /// <para>File from which to remove members.</para>
        /// </summary>
        public string File { get; protected set; }

        /// <summary>
        /// <para>Member to remove from this file. Note that even if an email is specified, it
        /// may result in the removal of a user (not an invitee) if the user's main account
        /// corresponds to that email address.</para>
        /// </summary>
        public MemberSelector Member { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="RemoveFileMemberArg" />.</para>
        /// </summary>
        private class RemoveFileMemberArgEncoder : enc.StructEncoder<RemoveFileMemberArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(RemoveFileMemberArg value, enc.IJsonWriter writer)
            {
                WriteProperty("file", value.File, writer, enc.StringEncoder.Instance);
                WriteProperty("member", value.Member, writer, global::Dropbox.Api.Sharing.MemberSelector.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="RemoveFileMemberArg" />.</para>
        /// </summary>
        private class RemoveFileMemberArgDecoder : enc.StructDecoder<RemoveFileMemberArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="RemoveFileMemberArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override RemoveFileMemberArg Create()
            {
                return new RemoveFileMemberArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(RemoveFileMemberArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file":
                        value.File = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "member":
                        value.Member = global::Dropbox.Api.Sharing.MemberSelector.Decoder.Decode(reader);
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
