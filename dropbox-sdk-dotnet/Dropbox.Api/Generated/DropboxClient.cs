// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api
{
    using sys = System;

    using Dropbox.Api.Stone;
    using Dropbox.Api.Auth.Routes;
    using Dropbox.Api.Files.Routes;
    using Dropbox.Api.Paper.Routes;
    using Dropbox.Api.Sharing.Routes;
    using Dropbox.Api.Users.Routes;

    public sealed partial class DropboxClient
    {
        /// <summary>
        /// <para>Gets the Auth routes.</para>
        /// </summary>
        public AuthUserRoutes Auth { get; private set; }

        /// <summary>
        /// <para>Gets the Files routes.</para>
        /// </summary>
        public FilesUserRoutes Files { get; private set; }

        /// <summary>
        /// <para>Gets the Paper routes.</para>
        /// </summary>
        public PaperUserRoutes Paper { get; private set; }

        /// <summary>
        /// <para>Gets the Sharing routes.</para>
        /// </summary>
        public SharingUserRoutes Sharing { get; private set; }

        /// <summary>
        /// <para>Gets the Users routes.</para>
        /// </summary>
        public UsersUserRoutes Users { get; private set; }

        /// <summary>
        /// <para>Initializes the routes.</para>
        /// </summary>
        /// <returns>The transport.</returns>
        internal override void InitializeRoutes(ITransport transport)
        {
            this.Auth = new AuthUserRoutes(transport);
            this.Files = new FilesUserRoutes(transport);
            this.Paper = new PaperUserRoutes(transport);
            this.Sharing = new SharingUserRoutes(transport);
            this.Users = new UsersUserRoutes(transport);
        }
    }
}
