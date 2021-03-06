// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;

namespace Xenko.Core.Serialization.Serializers
{
    [Flags]
    public enum ComplexTypeSerializerFlags
    {
        SerializePublicFields = 1,
        SerializeNonPublicFields = 2,
        SerializeFields = SerializePublicFields | SerializeNonPublicFields,
        SerializePublicProperties = 4,
    }
}
