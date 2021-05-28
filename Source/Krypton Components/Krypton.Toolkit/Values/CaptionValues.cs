﻿#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 *  Modified: Monday 12th April, 2021 @ 18:00 GMT
 *
 */
#endregion

using System.Drawing;
using System.ComponentModel;

namespace Krypton.Toolkit
{
    /// <summary>
    /// Storage for the group box caption values.
    /// </summary>
    public class CaptionValues : HeaderValuesBase
    {
        #region Static Fields
        private const string _defaultText = "Caption";
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the CaptionValues class.
        /// </summary>
        /// <param name="needPaint">Delegate for notifying paint requests.</param>
        public CaptionValues(NeedPaintHandler needPaint)
            : base(needPaint)
        {
        }
        #endregion

        #region Default Values
        /// <summary>
        /// Gets the default image value.
        /// </summary>
        /// <returns>Image reference.</returns>
        protected override Image GetImageDefault()
        {
            return null;
        }

        /// <summary>
        /// Gets the default heading value.
        /// </summary>
        /// <returns>String reference.</returns>
        protected override string GetHeadingDefault()
        {
            return _defaultText;
        }

        /// <summary>
        /// Gets the default description value.
        /// </summary>
        /// <returns>String reference.</returns>
        protected override string GetDescriptionDefault()
        {
            return string.Empty;
        }
        #endregion

        #region Description
        /// <summary>
        /// Gets and sets the header description text.
        /// </summary>
        [DefaultValue("")]
        public override string Description
        {
            get => base.Description;
            set => base.Description = value;
        }
        #endregion
    }
}
