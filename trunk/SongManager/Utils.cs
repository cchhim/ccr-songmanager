using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SongManager.Core.Model;

namespace SongManager
{
    public static class Utils
    {
        /// <summary>
        /// Set Data to ComboBox
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="list"></param>
        public static void SetDataToComboBox(ComboBox comboBox, IList<ComboBoxModel> list)
        {
            if (comboBox.Items.Count > 0)
            {
                comboBox.Items.Clear();
            }
            foreach (var item in list)
            {
                comboBox.Items.Add(item);
            }
            comboBox.DisplayMember = "DataField";
        }
    }
}
