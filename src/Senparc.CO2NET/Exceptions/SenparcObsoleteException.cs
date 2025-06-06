﻿#region Apache License Version 2.0
/*----------------------------------------------------------------

Copyright 2020 Jeffrey Su & Suzhou Senparc Network Technology Co.,Ltd.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
except in compliance with the License. You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the
License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
either express or implied. See the License for the specific language governing permissions
and limitations under the License.

Detail: https://github.com/JeffreySu/WeiXinMPSDK/blob/master/license.md

----------------------------------------------------------------*/
#endregion Apache License Version 2.0

/*----------------------------------------------------------------
    Copyright (C) 2025 Senparc
    
    FileName：SenparcObsoleteException.cs
    File Function Description：v1.3.107 Interface or method obsolete exception
    
    
    Creation Identifier：Senparc - 20200506
    
----------------------------------------------------------------*/

using Senparc.CO2NET.Exceptions;
using System;

namespace Senparc.CO2NET.Exceptions
{
    /// <summary>
    /// Interface or method obsolete exception
    /// </summary>
    public class SenparcObsoleteException : BaseException
    {
        public SenparcObsoleteException(string message, bool logged = false) : base(message, logged)
        {
        }

        public SenparcObsoleteException(string message, Exception inner, bool logged = false) : base(message, inner, logged)
        {
        }
    }
}