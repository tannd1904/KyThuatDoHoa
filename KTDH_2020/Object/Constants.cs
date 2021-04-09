using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTDH_2020.Variables
{
    /// <summary>
    /// Nơi lưu toàn bộ hằng hoặc các kiểu định nghĩa 
    /// </summary>
    public class Constants
    {
        /// <summary>
        /// Chế độ thao làm việc
        /// </summary>
        public enum Mode { _3D, _2D };

        /// <summary>
        /// Background color button whent focusing
        /// </summary>
        private static readonly Color background_Btn_Focus = Color.White;

        /// <summary>
        /// Get setting color for button focusing
        /// </summary>
        public static Color Background_Btn_Focus { get => background_Btn_Focus; }

    }
}
