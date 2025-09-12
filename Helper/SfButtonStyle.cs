using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulse.Helper
{
    public class SfButtonStyle
    {
        private SfButton activeButton;
        public void ApplyNavButtonStyle(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Check if the control is an SfButton
                if (control is SfButton button)
                {
                    // Apply your style here
                    button.Style.BackColor = Color.White;
                    button.Style.ForeColor = Color.FromArgb(147, 150, 159);
                    button.Style.ImageForeColor = Color.FromArgb(147, 150, 159);
                    button.Style.Border = null;
                    button.Style.HoverBackColor = Color.FromArgb(243, 245, 247);
                    button.Style.HoverForeColor = Color.FromArgb(107, 114, 128);
                    button.Style.HoverImageForeColor = Color.FromArgb(107, 114, 128);
                    button.Style.HoverBorder = null;
                    button.Style.PressedBackColor = Color.FromArgb(241, 245, 249);
                    button.Style.PressedForeColor = Color.FromArgb(107, 114, 128);
                    button.Style.PressedImageForeColor = Color.FromArgb(107, 114, 128);
                    button.Style.PressedBorder = null;
                    button.Style.FocusedBackColor = Color.FromArgb(227, 254, 240);
                    button.Style.FocusedForeColor = Color.FromArgb(34, 181, 115);
                    button.Style.FocusedImageForeColor = Color.FromArgb(34, 181, 115);
                    button.Style.FocusedBorder = null;

                }

                // Recursively check child controls
                if (control.HasChildren)
                {
                    ApplyNavButtonStyle(control);
                }
            }
        }

        public void GreenButton(SfButton button)
        {
            button.Style.BackColor = Color.FromArgb(0, 213, 99);
            button.Style.ForeColor = Color.White;
            button.Style.ImageForeColor = Color.White;
            button.Style.Border = null;
            button.Style.HoverBackColor = Color.FromArgb(26, 217, 115);
            button.Style.HoverForeColor = Color.White;
            button.Style.HoverImageForeColor = Color.White;
            button.Style.HoverBorder = null;
            button.Style.PressedBackColor = Color.FromArgb(26, 217, 115);
            button.Style.PressedForeColor = Color.White;
            button.Style.PressedImageForeColor = Color.White;
            button.Style.PressedBorder = null;
            button.Style.FocusedBackColor = Color.FromArgb(0, 213, 99);
            button.Style.FocusedForeColor = Color.White;
            button.Style.FocusedImageForeColor = Color.White;
            button.Style.FocusedBorder = null;
        }


    }
}
