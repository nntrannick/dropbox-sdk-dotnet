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
    /// <para>The mount folder error object</para>
    /// </summary>
    public class MountFolderError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MountFolderError> Encoder = new MountFolderErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MountFolderError> Decoder = new MountFolderErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MountFolderError" />
        /// class.</para>
        /// </summary>
        public MountFolderError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AccessError</para>
        /// </summary>
        public bool IsAccessError
        {
            get
            {
                return this is AccessError;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AccessError, or <c>null</c>.</para>
        /// </summary>
        public AccessError AsAccessError
        {
            get
            {
                return this as AccessError;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InsideSharedFolder</para>
        /// </summary>
        public bool IsInsideSharedFolder
        {
            get
            {
                return this is InsideSharedFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InsideSharedFolder, or <c>null</c>.</para>
        /// </summary>
        public InsideSharedFolder AsInsideSharedFolder
        {
            get
            {
                return this as InsideSharedFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InsufficientQuota</para>
        /// </summary>
        public bool IsInsufficientQuota
        {
            get
            {
                return this is InsufficientQuota;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InsufficientQuota, or <c>null</c>.</para>
        /// </summary>
        public InsufficientQuota AsInsufficientQuota
        {
            get
            {
                return this as InsufficientQuota;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is AlreadyMounted</para>
        /// </summary>
        public bool IsAlreadyMounted
        {
            get
            {
                return this is AlreadyMounted;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a AlreadyMounted, or <c>null</c>.</para>
        /// </summary>
        public AlreadyMounted AsAlreadyMounted
        {
            get
            {
                return this as AlreadyMounted;
            }
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
        /// <para>Gets a value indicating whether this instance is NotMountable</para>
        /// </summary>
        public bool IsNotMountable
        {
            get
            {
                return this is NotMountable;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotMountable, or <c>null</c>.</para>
        /// </summary>
        public NotMountable AsNotMountable
        {
            get
            {
                return this as NotMountable;
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
        /// <para>Encoder for  <see cref="MountFolderError" />.</para>
        /// </summary>
        private class MountFolderErrorEncoder : enc.StructEncoder<MountFolderError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MountFolderError value, enc.IJsonWriter writer)
            {
                if (value is AccessError)
                {
                    WriteProperty(".tag", "access_error", writer, enc.StringEncoder.Instance);
                    AccessError.Encoder.EncodeFields((AccessError)value, writer);
                    return;
                }
                if (value is InsideSharedFolder)
                {
                    WriteProperty(".tag", "inside_shared_folder", writer, enc.StringEncoder.Instance);
                    InsideSharedFolder.Encoder.EncodeFields((InsideSharedFolder)value, writer);
                    return;
                }
                if (value is InsufficientQuota)
                {
                    WriteProperty(".tag", "insufficient_quota", writer, enc.StringEncoder.Instance);
                    InsufficientQuota.Encoder.EncodeFields((InsufficientQuota)value, writer);
                    return;
                }
                if (value is AlreadyMounted)
                {
                    WriteProperty(".tag", "already_mounted", writer, enc.StringEncoder.Instance);
                    AlreadyMounted.Encoder.EncodeFields((AlreadyMounted)value, writer);
                    return;
                }
                if (value is NoPermission)
                {
                    WriteProperty(".tag", "no_permission", writer, enc.StringEncoder.Instance);
                    NoPermission.Encoder.EncodeFields((NoPermission)value, writer);
                    return;
                }
                if (value is NotMountable)
                {
                    WriteProperty(".tag", "not_mountable", writer, enc.StringEncoder.Instance);
                    NotMountable.Encoder.EncodeFields((NotMountable)value, writer);
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
        /// <para>Decoder for  <see cref="MountFolderError" />.</para>
        /// </summary>
        private class MountFolderErrorDecoder : enc.UnionDecoder<MountFolderError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MountFolderError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MountFolderError Create()
            {
                return new MountFolderError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override MountFolderError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "access_error":
                        return AccessError.Decoder.DecodeFields(reader);
                    case "inside_shared_folder":
                        return InsideSharedFolder.Decoder.DecodeFields(reader);
                    case "insufficient_quota":
                        return InsufficientQuota.Decoder.DecodeFields(reader);
                    case "already_mounted":
                        return AlreadyMounted.Decoder.DecodeFields(reader);
                    case "no_permission":
                        return NoPermission.Decoder.DecodeFields(reader);
                    case "not_mountable":
                        return NotMountable.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The access error object</para>
        /// </summary>
        public sealed class AccessError : MountFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AccessError> Encoder = new AccessErrorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AccessError> Decoder = new AccessErrorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public AccessError(SharedFolderAccessError value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AccessError" />
            /// class.</para>
            /// </summary>
            private AccessError()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public SharedFolderAccessError Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorEncoder : enc.StructEncoder<AccessError>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AccessError value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Sharing.SharedFolderAccessError.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AccessError" />.</para>
            /// </summary>
            private class AccessErrorDecoder : enc.StructDecoder<AccessError>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AccessError" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AccessError Create()
                {
                    return new AccessError();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(AccessError value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "access_error":
                            value.Value = global::Dropbox.Api.Sharing.SharedFolderAccessError.Decoder.Decode(reader);
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
        /// <para>Mounting would cause a shared folder to be inside another, which is
        /// disallowed.</para>
        /// </summary>
        public sealed class InsideSharedFolder : MountFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InsideSharedFolder> Encoder = new InsideSharedFolderEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InsideSharedFolder> Decoder = new InsideSharedFolderDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsideSharedFolder" />
            /// class.</para>
            /// </summary>
            private InsideSharedFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InsideSharedFolder</para>
            /// </summary>
            public static readonly InsideSharedFolder Instance = new InsideSharedFolder();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InsideSharedFolder" />.</para>
            /// </summary>
            private class InsideSharedFolderEncoder : enc.StructEncoder<InsideSharedFolder>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InsideSharedFolder value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InsideSharedFolder" />.</para>
            /// </summary>
            private class InsideSharedFolderDecoder : enc.StructDecoder<InsideSharedFolder>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InsideSharedFolder"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InsideSharedFolder Create()
                {
                    return InsideSharedFolder.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The current user does not have enough space to mount the shared
        /// folder.</para>
        /// </summary>
        public sealed class InsufficientQuota : MountFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<InsufficientQuota> Encoder = new InsufficientQuotaEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<InsufficientQuota> Decoder = new InsufficientQuotaDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsufficientQuota" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public InsufficientQuota(InsufficientQuotaAmounts value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InsufficientQuota" />
            /// class.</para>
            /// </summary>
            private InsufficientQuota()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public InsufficientQuotaAmounts Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="InsufficientQuota" />.</para>
            /// </summary>
            private class InsufficientQuotaEncoder : enc.StructEncoder<InsufficientQuota>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(InsufficientQuota value, enc.IJsonWriter writer)
                {
                    global::Dropbox.Api.Sharing.InsufficientQuotaAmounts.Encoder.EncodeFields(value.Value, writer);
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="InsufficientQuota" />.</para>
            /// </summary>
            private class InsufficientQuotaDecoder : enc.StructDecoder<InsufficientQuota>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="InsufficientQuota"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override InsufficientQuota Create()
                {
                    return new InsufficientQuota();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override InsufficientQuota DecodeFields(enc.IJsonReader reader)
                {
                    return new InsufficientQuota(global::Dropbox.Api.Sharing.InsufficientQuotaAmounts.Decoder.DecodeFields(reader));
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>The shared folder is already mounted.</para>
        /// </summary>
        public sealed class AlreadyMounted : MountFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<AlreadyMounted> Encoder = new AlreadyMountedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<AlreadyMounted> Decoder = new AlreadyMountedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="AlreadyMounted" />
            /// class.</para>
            /// </summary>
            private AlreadyMounted()
            {
            }

            /// <summary>
            /// <para>A singleton instance of AlreadyMounted</para>
            /// </summary>
            public static readonly AlreadyMounted Instance = new AlreadyMounted();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="AlreadyMounted" />.</para>
            /// </summary>
            private class AlreadyMountedEncoder : enc.StructEncoder<AlreadyMounted>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(AlreadyMounted value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="AlreadyMounted" />.</para>
            /// </summary>
            private class AlreadyMountedDecoder : enc.StructDecoder<AlreadyMounted>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="AlreadyMounted" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override AlreadyMounted Create()
                {
                    return AlreadyMounted.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The current user does not have permission to perform this action.</para>
        /// </summary>
        public sealed class NoPermission : MountFolderError
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
        /// <para>The shared folder is not mountable. One example where this can occur is when
        /// the shared folder belongs within a team folder in the user's Dropbox.</para>
        /// </summary>
        public sealed class NotMountable : MountFolderError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotMountable> Encoder = new NotMountableEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotMountable> Decoder = new NotMountableDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotMountable" />
            /// class.</para>
            /// </summary>
            private NotMountable()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotMountable</para>
            /// </summary>
            public static readonly NotMountable Instance = new NotMountable();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotMountable" />.</para>
            /// </summary>
            private class NotMountableEncoder : enc.StructEncoder<NotMountable>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotMountable value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotMountable" />.</para>
            /// </summary>
            private class NotMountableDecoder : enc.StructDecoder<NotMountable>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotMountable" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotMountable Create()
                {
                    return NotMountable.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : MountFolderError
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
