/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * https://github.com/piranhacms/piranha.core
 *
 */

using System;

namespace Piranha.Models
{
    /// <summary>
    /// Base class for archive pages.
    /// </summary>
    [Serializable]
    [NoCoverage]
    [Obsolete("ArchivePage is obsolete. Please use a regular Page with IsArchive = true")]
    public class ArchivePage<T> : ArchivePage<T, DynamicPost> where T : ArchivePage<T> { }

    /// <summary>
    /// Base class for archive pages.
    /// </summary>
    [Serializable]
    [NoCoverage]
    [Obsolete("ArchivePage is obsolete. Please use a regular Page with IsArchive = true")]
    public class ArchivePage<T, TPost> : GenericPage<T>, IArchivePage
        where T : ArchivePage<T, TPost>
        where TPost : PostBase
    {
        /// <summary>
        /// Gets/sets the post archive.
        /// </summary>
        public PostArchive<TPost> Archive { get; set; }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ArchivePage()
        {
            Archive = new PostArchive<TPost>();
        }
    }

    /// <summary>
    /// Interface for registering the basic archive page
    /// content type.
    /// </summary>
    public interface IArchivePage { }
}