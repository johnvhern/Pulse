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

        public void ApplyNavButtonStyle(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Check if the control is an SfButton
                if (control is SfButton button)
                {
                    // Apply your style here
                    button.Style.BackColor = Color.White;
                    button.Style.Border = null;
                    button.Style.HoverBackColor = Color.FromArgb(241, 249, 241);
                    button.Style.HoverForeColor = Color.FromArgb(76, 175, 80);
                    button.Style.HoverImageForeColor = Color.FromArgb(76, 175, 80);
                    button.Style.HoverBorder = null;
                    button.Style.PressedBackColor = Color.FromArgb(244, 244, 245);
                    button.Style.PressedForeColor = Color.FromArgb(51, 51, 51);
                    button.Style.PressedImageForeColor = Color.FromArgb(51, 51, 51);
                    button.Style.PressedBorder = null;
                    button.Style.FocusedBackColor = Color.FromArgb(76, 175, 80);
                    button.Style.FocusedForeColor = Color.White;
                    button.Style.FocusedImageForeColor = Color.White;
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
            button.Style.BackColor = Color.White;
            button.Style.Border = null;
            button.Style.HoverBackColor = Color.FromArgb(241, 249, 241);
            button.Style.HoverForeColor = Color.FromArgb(76, 175, 80);
            button.Style.HoverImageForeColor = Color.FromArgb(76, 175, 80);
            button.Style.HoverBorder = null;
            button.Style.PressedBackColor = Color.FromArgb(244, 244, 245);
            button.Style.PressedForeColor = Color.FromArgb(51, 51, 51);
            button.Style.PressedImageForeColor = Color.FromArgb(51, 51, 51);
            button.Style.PressedBorder = null;
            button.Style.FocusedBackColor = Color.FromArgb(76, 175, 80);
            button.Style.FocusedForeColor = Color.White;
            button.Style.FocusedImageForeColor = Color.White;
            button.Style.FocusedBorder = null;
        }
    }
}
