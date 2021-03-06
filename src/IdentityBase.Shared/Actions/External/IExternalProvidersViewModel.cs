// Copyright (c) Russlan Akiev. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace IdentityBase.Actions.External
{
    using System.Collections.Generic;
    using IdentityBase.Models;

    public interface IExternalProvidersViewModel
    {
        string ReturnUrl { get; set; }

        IEnumerable<ExternalProvider> ExternalProviders { get; set; }

        IEnumerable<string> ExternalProviderHints { get; set; }
    }
}