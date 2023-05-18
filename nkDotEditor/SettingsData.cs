using System;
using System.ComponentModel;
using System.Drawing;

namespace PublicDomain
{
    /// <summary>
    /// Nk dot properties.
    /// </summary>
    [DefaultPropertyAttribute("DotColor")]
    public class SettingsData
    {
        /// <summary>
        /// Gets or sets the color of the dot.
        /// </summary>
        /// <value>The color of the dot.</value>
        [CategoryAttribute("Dot"), DisplayName("Dot color"), DescriptionAttribute("Color of the painted dot.")]
        public Color DotColor { get; set; } = Color.Red;

        /// <summary>
        /// Gets or sets the size of the dot.
        /// </summary>
        /// <value>The size of the dot.</value>
        [CategoryAttribute("Dot"), DisplayName("Dot size"), DescriptionAttribute("Size of the painted dot.")]
        public int DotSize { get; set; } = 100;

        /// <summary>
        /// Gets or sets the redraw interval.
        /// </summary>
        /// <value>The redraw interval.</value>
        [CategoryAttribute("Dot"), DisplayName("Redraw interval"), DescriptionAttribute("Interval to paint a new dot.")]
        public int RedrawInterval { get; set; } = 250;

        /// <summary>
        /// Gets or sets the color of the background.
        /// </summary>
        /// <value>The color of the background.</value>
        [CategoryAttribute("Window"), DisplayName("Background color"), DescriptionAttribute("Color of the program window's background.")]
        public Color BackgroundColor { get; set; } = Color.White;

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        [CategoryAttribute("Window"), DisplayName("Location"), DescriptionAttribute("Location of the program window.")]
        public Point Location { get; set; } = new Point(0, 0);

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>The size.</value>
        [CategoryAttribute("Window"), DisplayName("Size"), DescriptionAttribute("Size of the program window.")]
        public Size Size { get; set; } = new Size(640, 480);

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:nkDotEditor.Customer"/> always on top.
        /// </summary>
        /// <value><c>true</c> if always on top; otherwise, <c>false</c>.</value>
        [CategoryAttribute("Window"), DisplayName("Always on top"), DescriptionAttribute("Makes the program window topmost.")]
        public bool AlwaysOnTop { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:nkDotEditor.NkDotProperties"/> is maximized.
        /// </summary>
        /// <value><c>true</c> if maximized; otherwise, <c>false</c>.</value>
        [CategoryAttribute("Window"), DisplayName("Maximized"), DescriptionAttribute("Maximized program window.")]
        public bool Maximized { get; set; } = false;

        /// <summary>
        /// Gets or sets the running time.
        /// </summary>
        /// <value>The running time.</value>
        [CategoryAttribute("Program"), DisplayName("Running time"), DescriptionAttribute("Time (in millisenconds) for the program to exit.")]
        public int RunningTime { get; set; } = 180000;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:nkDotEditor.Customer"/> class.
        /// </summary>
        public SettingsData() { }
    }
}