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
    /// <para>The account capture policy object</para>
    /// </summary>
    public class AccountCapturePolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<AccountCapturePolicy> Encoder = new AccountCapturePolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<AccountCapturePolicy> Decoder = new AccountCapturePolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="AccountCapturePolicy" />
        /// class.</para>
        /// </summary>
        public AccountCapturePolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Disabled</para>
        /// </summary>
        public bool IsDisabled
        {
            get
            {
                return this is Disabled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Disabled, or <c>null</c>.</para>
        /// </summary>
        public Disabled AsDisabled
        {
            get
            {
                return this as Disabled;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InvitedUsers</para>
        /// </summary>
        public bool IsInvitedUsers
        {
            get
            {
                return this is InvitedUsers;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InvitedUsers, or <c>null</c>.</para>
        /// </summary>
        public InvitedUsers AsInvitedUsers
        {
            get
            {
                return this as InvitedUsers;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AllUsers</para>
        /// </summary>
        public bool IsAllUsers
        {
            get
            {
                return this is AllUsers;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AllUsers, or <c>null</c>.</para>
        /// </summary>
        public AllUsers AsAllUsers
        {
            get
            {
                return this as AllUsers;
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
        /// <para>Encoder for  <see cref="AccountCapturePolicy" />.</para>
        /// </summary>
        private class AccountCapturePolicyEncoder : enc.StructEncoder<AccountCapturePolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(AccountCapturePolicy value, enc.IJsonWriter writer)
            {
                if (value is Disabled)
                {
                    WriteProperty(".tag", "disabled", writer, enc.StringEncoder.Instance);
                    Disabled.Encoder.EncodeFields((Disabled)value, writer);
                    return;
                }
                if (value is InvitedUsers)
                {
                    WriteProperty(".tag", "invited_users", writer, enc.StringEncoder.Instance);
                    InvitedUsers.Encoder.EncodeFields((InvitedUsers)value, writer);
                    return;
                }
                if (value is AllUsers)
                {
                    WriteProperty(".tag", "all_users", writer, enc.StringEncoder.Instance);
                    AllUsers.Encoder.EncodeFields((AllUsers)value, writer);
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
        /// <para>Decoder for  <see cref="AccountCapturePolicy" />.</para>
        /// </summary>
        private class AccountCapturePolicyDecoder : enc.UnionDecoder<AccountCapturePolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="AccountCapturePolicy" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override AccountCapturePolicy Create()
            {
                return new AccountCapturePolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override AccountCapturePolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "disabled":
                        return Disabled.Decoder.DecodeFields(reader);
                    case "invited_users":
                        return InvitedUsers.Decoder.DecodeFields(reader);
                    case "all_users":
                        return AllUsers.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The disabled object</para>
        /// </summary>
        public sealed class Disabled : AccountCapturePolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Disabled> Encoder = new DisabledEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Disabled> Decoder = new DisabledDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Disabled" /> class.</para>
            /// </summary>
            private Disabled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Disabled</para>
            /// </summary>
            public static readonly Disabled Instance = new Disabled();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Disabled" />.</para>
            /// </summary>
            private class DisabledEncoder : enc.StructEncoder<Disabled>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Disabled value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Disabled" />.</para>
            /// </summary>
            private class DisabledDecoder : enc.StructDecoder<Disabled>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Disabled" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Disabled Create()
                {
                    return Disabled.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The invited users object</para>
        /// </summary>
        public sealed class InvitedUsers : AccountCapturePolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InvitedUsers> Encoder = new InvitedUsersEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InvitedUsers> Decoder = new InvitedUsersDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InvitedUsers" />
            /// class.</para>
            /// </summary>
            private InvitedUsers()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InvitedUsers</para>
            /// </summary>
            public static readonly InvitedUsers Instance = new InvitedUsers();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InvitedUsers" />.</para>
            /// </summary>
            private class InvitedUsersEncoder : enc.StructEncoder<InvitedUsers>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InvitedUsers value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InvitedUsers" />.</para>
            /// </summary>
            private class InvitedUsersDecoder : enc.StructDecoder<InvitedUsers>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InvitedUsers" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InvitedUsers Create()
                {
                    return InvitedUsers.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The all users object</para>
        /// </summary>
        public sealed class AllUsers : AccountCapturePolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AllUsers> Encoder = new AllUsersEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AllUsers> Decoder = new AllUsersDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AllUsers" /> class.</para>
            /// </summary>
            private AllUsers()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AllUsers</para>
            /// </summary>
            public static readonly AllUsers Instance = new AllUsers();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AllUsers" />.</para>
            /// </summary>
            private class AllUsersEncoder : enc.StructEncoder<AllUsers>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AllUsers value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AllUsers" />.</para>
            /// </summary>
            private class AllUsersDecoder : enc.StructDecoder<AllUsers>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AllUsers" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AllUsers Create()
                {
                    return AllUsers.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : AccountCapturePolicy
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
