﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2025 Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/Senparc/Senparc.CO2NET/blob/master/LICENSE

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.CO2NET.Cache
{
    /// <summary>
    /// Cache strategy interface where all keys are of type string and values are of type object
    /// </summary>
    public interface IBaseObjectCacheStrategy : IBaseCacheStrategy<string, object>, IBaseCacheStrategy
    {
        //IContainerCacheStrategy ContainerCacheStrategy { get; }

        /// <summary>
        /// Registered extension cache strategies
        /// </summary>
        //Dictionary<IExtensionCacheStrategy, IBaseObjectCacheStrategy> ExtensionCacheStratety { get; set; }
    }
}
