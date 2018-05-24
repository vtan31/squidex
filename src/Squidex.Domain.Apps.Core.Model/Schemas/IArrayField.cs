﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using System.Collections.Generic;

namespace Squidex.Domain.Apps.Core.Schemas
{
    public interface IArrayField : IField<ArrayFieldProperties>
    {
        IReadOnlyList<INestedField> Fields { get; }

        IReadOnlyDictionary<long, INestedField> FieldsById { get; }

        IReadOnlyDictionary<string, INestedField> FieldsByName { get; }
    }
}
