﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_PAV.Utils
{
    public class FormUtils
    {
        public static void CargarCombo(ref ComboBox cb, BindingSource conector, string displayMember, string valueMember)
        {
            if (conector is null)
            {
                throw new ArgumentNullException(nameof(conector));
            }
            cb.DataSource = conector;
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
        }
    }
}
