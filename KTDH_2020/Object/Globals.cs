﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KTDH_2020.Variables;

namespace KTDH_2020.Variables
{
    /// <summary>
    /// Nơi lưu toàn bộ biến toàn cục
    /// </summary>
    public static class Globals
    {
        /// <summary>
        /// Mạc định là chế độ làm việc là 2D
        /// </summary>
        public static Constants.Mode _Mode_current = Constants.Mode._2D;

        /// <summary>
        /// Chế độ hiển thị các button trong pnl_Mode kèm theo text hay không. Mạc định là có
        /// </summary>
        public static bool _btn_isShowDetails = true;

        public static int i = 0;

        /// <summary>
        /// Kích thước mỗi điểm trong hệ tòa dộ người dùng.
        /// </summary>
        public static System.Drawing.Size sizePerPoint = new System.Drawing.Size(5, 5);

        /// <summary>
        /// Size của hệ tòa độ người dùng khi chuyển từ tọa độ máy sang. Hệ tòa độ 2D.
        /// </summary>
        public static System.Drawing.Size sizeOfNewCoor_2D;
        /// <summary>
        /// Size của hệ tòa độ người dùng khi chuyển từ tọa độ máy sang. Hệ tòa độ 3D.
        /// </summary>
        public static System.Drawing.Size sizeOfNewCoor_3D;

        /// <summary>
        /// Chua toan bo hinh tren man hinh lap viec 2D.
        /// </summary>
        //public static Stack<Object> sObject_2D = new Stack<object>();


    }
}
