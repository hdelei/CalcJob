using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcJob.Util
{
    public class LabelCustomColors
    {                
        public void MouseEnter(MetroLabel label)
        {           
            label.ForeColor = SystemColors.ButtonHighlight;            
        }

        public void MouseLeave(MetroLabel label)
        {            
            //label.ForeColor = SystemColors.Highlight;
            label.ForeColor = Color.DodgerBlue;

        }

    }
}
