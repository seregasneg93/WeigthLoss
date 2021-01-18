using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace WeigthLoss.Models
{
   public static class TexBocks
    {
        public static void TBDef(TextBox[] tb)
        {
            foreach (Control x in tb)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }
        }
    }
}
