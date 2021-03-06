﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kentor.AuthServices.Metadata
{
    /// <summary>
    /// Extended entitiesdescriptor for SAML2 metadata, adding more attributes.
    /// </summary>
    public class ExtendedEntitiesDescriptor : EntitiesDescriptor, ICachedMetadata
    {

        public ExtendedEntitiesDescriptor() : base() { }
        public ExtendedEntitiesDescriptor(Collection<EntityDescriptor> entityList)
            : base(entityList)
        {

        }

        /// <summary>
        /// Permitted cache duration for the metadata.
        /// </summary>
        public TimeSpan? CacheDuration { get; set; }

        /// <summary>
        /// Valid until
        /// </summary>
        public DateTime? ValidUntil { get; set; }
    }
}
