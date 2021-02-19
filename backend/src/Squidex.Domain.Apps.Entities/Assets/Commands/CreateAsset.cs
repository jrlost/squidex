﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.Infrastructure;

namespace Squidex.Domain.Apps.Entities.Assets.Commands
{
    public sealed class CreateAsset : UploadAssetCommand
    {
        public DomainId ParentId { get; set; }

        public bool Duplicate { get; set; }

        public CreateAsset()
        {
            AssetId = DomainId.NewGuid();
        }
    }
}
