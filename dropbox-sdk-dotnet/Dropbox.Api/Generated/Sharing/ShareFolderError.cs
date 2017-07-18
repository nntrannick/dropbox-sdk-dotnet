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
    /// <para>The share folder error object</para>
    /// </summary>
    public class ShareFolderError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ShareFolderError> Encoder = new ShareFolderErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ShareFolderError> Decoder = new ShareFolderErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ShareFolderError" />
        /// class.</para>
        /// </summary>
        public ShareFolderError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoPermission</para>
        /// </summary>
        public bool IsNoPermission
        {
            get
            {
                return this is NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoPermission, or <c>null</c>.</para>
        /// </summary>
        public NoPermission AsNoPermission
        {
            get
            {
                return this as NoPermission;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is EmailUnverified</para>
        /// </summary>
        public bool IsEmailUnverified
        {
            get
            {
                return this is EmailUnverified;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a EmailUnverified, or <c>null</c>.</para>
        /// </summary>
        public EmailUnverified AsEmailUnverified
        {
            get
            {
                return this as EmailUnverified;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is BadPath</para>
        /// </summary>
        public bool IsBadPath
        {
            get
            {
                return this is BadPath;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a BadPath, or <c>null</c>.</para>
        /// </summary>
        public BadPath AsBadPath
        {
            get
            {
                return this as BadPath;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// TeamPolicyDisallowsMemberPolicy</para>
        /// </summary>
        public bool IsTeamPolicyDisallowsMemberPolicy
        {
            get
            {
                return this is TeamPolicyDisallowsMemberPolicy;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a TeamPolicyDisallowsMemberPolicy, or
        /// <c>null</c>.</para>
        /// </summary>
        public TeamPolicyDisallowsMemberPolicy AsTeamPolicyDisallowsMemberPolicy
        {
            get
            {
                return this as TeamPolicyDisallowsMemberPolicy;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// DisallowedSharedLinkPolicy</para>
        /// </summary>
        public bool IsDisallowedSharedLinkPolicy
        {
            get
            {
                return this is DisallowedSharedLinkPolicy;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a DisallowedSharedLinkPolicy, or <c>null</c>.</para>
        /// </summary>
        public DisallowedSharedLinkPolicy AsDisallowedSharedLinkPolicy
        {
            get
            {
                return this as DisallowedSharedLinkPolicy;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ShareFolderError" />.</para>
        /// </summary>
        private class ShareFolderErrorEncoder : enc.StructEncoder<ShareFolderError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ShareFolderError value, enc.IJsonWriter writer)
            {
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
                    return;
                }
                if (value is EmailUnverified)
                {
                    WriteProperty(".tag", "email_unverified", writer, enc.StringEncoder.Instance);
                    EmailUnverified.Encoder.EncodeFields((EmailUnverified)value, writer);
                    return;
                }
                if (value is BadPath)
                {
                    WriteProperty(".tag", "bad_path", writer, enc.StringEncoder.Instance);
                    BadPath.Encoder.EncodeFields((BadPath)value, writer);
                    return;
                }
                if (value is TeamPolicyDisallowsMemberPolicy)
                {
                    WriteProperty(".tag", "team_policy_disallows_member_policy", writer, enc.StringEncoder.Instance);
                    TeamPolicyDisallowsMemberPolicy.Encoder.EncodeFields((TeamPolicyDisallowsMemberPolicy)value, writer);
                    return;
                }
                if (value is DisallowedSharedLinkPolicy)
                {
                    WriteProperty(".tag", "disallowed_shared_link_policy", writer, enc.StringEncoder.Instance);
                    DisallowedSharedLinkPolicy.Encoder.EncodeFields((DisallowedSharedLinkPolicy)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ShareFolderError" />.</para>
        /// </summary>
        private class ShareFolderErrorDecoder : enc.UnionDecoder<ShareFolderError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ShareFolderError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ShareFolderError Create()
            {
                return new ShareFolderError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ShareFolderError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    case "email_unverified":
                        return EmailUnverified.Decoder.DecodeFields(reader);
                    case "bad_path":
                        return BadPath.Decoder.DecodeFields(reader);
                    case "team_policy_disallows_member_policy":
                        return TeamPolicyDisallowsMemberPolicy.Decoder.DecodeFields(reader);
                    case "disallowed_shared_link_policy":
                        return DisallowedSharedLinkPolicy.Decoder.DecodeFields(reader);
                    case "other":
                        return Other.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The current user does not have permission to perform this action.</para>
        /// </summary>
        public sealed class NoPermission : ShareFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NoPermission> Encoder = new NoPermissionEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NoPermission> Decoder = new NoPermissionDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoPermission" />
            /// class.</para>
            /// </summary>
            private NoPermission()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoPermission</para>
            /// </summary>
            public static readonly NoPermission Instance = new NoPermission();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionEncoder : enc.StructEncoder<NoPermission>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NoPermission value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NoPermission" />.</para>
            /// </summary>
            private class NoPermissionDecoder : enc.StructDecoder<NoPermission>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NoPermission" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NoPermission Create()
                {
                    return NoPermission.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The current user's e-mail address is unverified.</para>
        /// </summary>
        public sealed class EmailUnverified : ShareFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<EmailUnverified> Encoder = new EmailUnverifiedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<EmailUnverified> Decoder = new EmailUnverifiedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="EmailUnverified" />
            /// class.</para>
            /// </summary>
            private EmailUnverified()
            {
            }

            /// <summary>
            /// <para>A singleton instance of EmailUnverified</para>
            /// </summary>
            public static readonly EmailUnverified Instance = new EmailUnverified();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="EmailUnverified" />.</para>
            /// </summary>
            private class EmailUnverifiedEncoder : enc.StructEncoder<EmailUnverified>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(EmailUnverified value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="EmailUnverified" />.</para>
            /// </summary>
            private class EmailUnverifiedDecoder : enc.StructDecoder<EmailUnverified>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="EmailUnverified" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override EmailUnverified Create()
                {
                    return EmailUnverified.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para><see cref="Dropbox.Api.Sharing.ShareFolderArg.Path" /> is invalid.</para>
        /// </summary>
        public sealed class BadPath : ShareFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<BadPath> Encoder = new BadPathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<BadPath> Decoder = new BadPathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="BadPath" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public BadPath(SharePathError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="BadPath" /> class.</para>
            /// </summary>
            private BadPath()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharePathError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="BadPath" />.</para>
            /// </summary>
            private class BadPathEncoder : enc.StructEncoder<BadPath>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(BadPath value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Sharing.SharePathError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="BadPath" />.</para>
            /// </summary>
            private class BadPathDecoder : enc.StructDecoder<BadPath>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="BadPath" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override BadPath Create()
                {
                    return new BadPath();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(BadPath value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "bad_path":
                            value.Value = global::Dropbox.Api.Sharing.SharePathError.Decoder.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Team policy is more restrictive than <see
        /// cref="Dropbox.Api.Sharing.ShareFolderArg.MemberPolicy" />.</para>
        /// </summary>
        public sealed class TeamPolicyDisallowsMemberPolicy : ShareFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<TeamPolicyDisallowsMemberPolicy> Encoder = new TeamPolicyDisallowsMemberPolicyEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<TeamPolicyDisallowsMemberPolicy> Decoder = new TeamPolicyDisallowsMemberPolicyDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see
            /// cref="TeamPolicyDisallowsMemberPolicy" /> class.</para>
            /// </summary>
            private TeamPolicyDisallowsMemberPolicy()
            {
            }

            /// <summary>
            /// <para>A singleton instance of TeamPolicyDisallowsMemberPolicy</para>
            /// </summary>
            public static readonly TeamPolicyDisallowsMemberPolicy Instance = new TeamPolicyDisallowsMemberPolicy();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="TeamPolicyDisallowsMemberPolicy" />.</para>
            /// </summary>
            private class TeamPolicyDisallowsMemberPolicyEncoder : enc.StructEncoder<TeamPolicyDisallowsMemberPolicy>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(TeamPolicyDisallowsMemberPolicy value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="TeamPolicyDisallowsMemberPolicy" />.</para>
            /// </summary>
            private class TeamPolicyDisallowsMemberPolicyDecoder : enc.StructDecoder<TeamPolicyDisallowsMemberPolicy>
            {
                /// <summary>
                /// <para>Create a new instance of type <see
                /// cref="TeamPolicyDisallowsMemberPolicy" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override TeamPolicyDisallowsMemberPolicy Create()
                {
                    return TeamPolicyDisallowsMemberPolicy.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The current user's account is not allowed to select the specified <see
        /// cref="Dropbox.Api.Sharing.ShareFolderArg.SharedLinkPolicy" />.</para>
        /// </summary>
        public sealed class DisallowedSharedLinkPolicy : ShareFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<DisallowedSharedLinkPolicy> Encoder = new DisallowedSharedLinkPolicyEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<DisallowedSharedLinkPolicy> Decoder = new DisallowedSharedLinkPolicyDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="DisallowedSharedLinkPolicy"
            /// /> class.</para>
            /// </summary>
            private DisallowedSharedLinkPolicy()
            {
            }

            /// <summary>
            /// <para>A singleton instance of DisallowedSharedLinkPolicy</para>
            /// </summary>
            public static readonly DisallowedSharedLinkPolicy Instance = new DisallowedSharedLinkPolicy();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="DisallowedSharedLinkPolicy" />.</para>
            /// </summary>
            private class DisallowedSharedLinkPolicyEncoder : enc.StructEncoder<DisallowedSharedLinkPolicy>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(DisallowedSharedLinkPolicy value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="DisallowedSharedLinkPolicy" />.</para>
            /// </summary>
            private class DisallowedSharedLinkPolicyDecoder : enc.StructDecoder<DisallowedSharedLinkPolicy>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="DisallowedSharedLinkPolicy"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override DisallowedSharedLinkPolicy Create()
                {
                    return DisallowedSharedLinkPolicy.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ShareFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
