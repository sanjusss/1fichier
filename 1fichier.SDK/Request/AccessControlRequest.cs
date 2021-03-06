﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1fichier.SDK.Request
{
    /// <summary>
    /// 修改文件访问控制属性的请求。当某个属性值为null时，表示不修改该属性。
    /// </summary>
    public struct AccessControlRequest
    {
        /// <summary>
        /// 允许访问的ip范围，用IP或CIDR表示。
        /// </summary>
        public IReadOnlyCollection<string> ip;
        /// <summary>
        /// 允许访问的国家代码。
        /// </summary>
        public IReadOnlyCollection<string> country;
        /// <summary>
        /// 允许访问的用户的邮箱。
        /// </summary>
        public IReadOnlyCollection<string> email;
        /// <summary>
        /// 是否只允许premium或access用户。
        /// </summary>
        public bool? premium;
    }
}
