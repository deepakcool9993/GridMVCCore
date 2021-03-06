using System;

namespace GridMvc.DataAnnotations
{
    /// <summary>
    ///     Marks property as hidden Grid.Mvc column
    /// </summary>
    public class GridHiddenColumnAttribute : Attribute
    {
        public GridHiddenColumnAttribute()
        {
            EncodeEnabled = true;
            SanitizeEnabled = true;
        }

        /// <summary>
        ///     Specify that content of this column need to be encoded
        /// </summary>
        public bool EncodeEnabled { get; set; }

        /// <summary>
        ///     Specify that content of this column need to be sanitized
        /// </summary>
        public bool SanitizeEnabled { get; set; }

        /// <summary>
        ///     Specify the format of column data
        /// </summary>
        public string Format { get; set; }
    }
}