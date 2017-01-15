﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebMVC.COMMON
{
    /// <summary>
    /// Đối tượng dùng để khởi tạo một Instance cho các đối tượng khác
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Singleton<T> where T : new()
    {
        private static T t = new T();
        /// <summary>
        /// Khởi tạo một Instance
        /// </summary>
        public static T Inst
        {
            get { return t; }
        }

        /// <summary>
        /// New
        /// </summary>
        public static T New
        {
            get { return new T(); }
        }
    }
}
