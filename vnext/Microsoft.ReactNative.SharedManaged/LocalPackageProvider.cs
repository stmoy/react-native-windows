// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.ReactNative.Bridge;

namespace Microsoft.ReactNative.Managed
{
  class LocalPackageProvider : IReactPackageProvider
  {
    public void CreatePackage(IReactPackageBuilder packageBuilder)
    {
      packageBuilder.AddAttributedModules();
    }
  }
}
