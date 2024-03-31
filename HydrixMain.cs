using SVGAIITerminal;
using GrapeGL;
using GrapeGL.Graphics;
using System.Runtime.CompilerServices;
namespace HydrixLIB
{
    /// <summary>
    /// Base Hydrix Terminal Class
    /// </summary>
    public class HTerminal
    {
        /// <summary>
        /// This is the default return color for the terminal when resetting the color (Foreground)
        /// </summary>
        public Color DefaultForegroundReturnColor = Color.White;
        /// <summary>
        /// This is the default return color for the terminal when resetting the color (Background)
        /// </summary>
        public Color DefaultBackgroundReturnColor = Color.Black;
        SVGAIITerminal.SVGAIITerminal terminal;
        /// <summary>
        /// Creates a new instance of the HTerminal class
        /// </summary>
        /// <param name="_SVGAIITerminal">The current SVGAIITerminal</param>
        public HTerminal(SVGAIITerminal.SVGAIITerminal _SVGAIITerminal)
        {
            this.terminal = _SVGAIITerminal;
        }
        /// <summary>
        /// Creates a new instance of the HTerminal class with default colors
        /// </summary>
        /// <param name="_SVGAIITerminal">The current SVGAIITerminal</param>
        /// <param name="DefaultForegroundReturnColor">The default foreground color to return to</param>
        /// <param name="DefaultBackgroundReturnColor">The default background color to return to</param>
        public HTerminal(SVGAIITerminal.SVGAIITerminal _SVGAIITerminal, Color DefaultForegroundReturnColor, Color DefaultBackgroundReturnColor)
        {
            this.terminal = _SVGAIITerminal;
            this.DefaultForegroundReturnColor = DefaultForegroundReturnColor;
            this.DefaultBackgroundReturnColor = DefaultBackgroundReturnColor;
        }
        /// <summary>
        /// Writes a line to the terminal with a specified color (SVGAIITerminal)
        /// </summary>
        /// <param name="text">The text to output</param>
        /// <param name="ForegroundColor">The Foreground color to draw</param>
        /// <param name="PersistantColor">Setting 'true' will keep the color after the change</param>
        public void ColoredWriteLine(string text, Color ForegroundColor, bool PersistantColor = false)
        {
            Color oldfg = terminal.ForegroundColor;
            terminal.ForegroundColor = ForegroundColor;
            terminal.WriteLine(text);
            if (!PersistantColor) terminal.ForegroundColor = oldfg;
        }
        /// <summary>
        /// Writes a line to the terminal with a specified color (SVGAIITerminal)
        /// </summary>
        /// <param name="text">The text to output</param>
        /// <param name="ForegroundColor">The Foreground color to draw</param>
        /// <param name="BackgroundColor">The Background color to draw</param>
        /// <param name="PersistantForegroundColor">Setting 'true' will keep the foreground color after the change</param>
        /// <param name="PersistantBackgroundColor">Setting 'true' will keep the background color after the change</param>
        public void ColoredWriteLine(string text, Color ForegroundColor, Color BackgroundColor, bool PersistantForegroundColor = false, bool PersistantBackgroundColor = false)
        {
            Color oldfg = terminal.ForegroundColor;
            Color oldbg = terminal.BackgroundColor;
            terminal.ForegroundColor = ForegroundColor;
            terminal.BackgroundColor = BackgroundColor;
            terminal.WriteLine(text);
            if (!PersistantForegroundColor) terminal.ForegroundColor = oldfg;
            if (!PersistantBackgroundColor) terminal.BackgroundColor = oldbg;
        }
        /// <summary>
        /// Writes to the terminal with a specified color (SVGAIITerminal)
        /// </summary>
        /// <param name="text">The text to output</param>
        /// <param name="ForegroundColor">The Foreground color to draw</param>
        /// <param name="PersistantColor">Setting 'true' will keep the color after the change</param>
        public void ColoredWrite(string text, Color ForegroundColor, bool PersistantColor = false)
        {
            Color oldfg = terminal.ForegroundColor;
            terminal.ForegroundColor = ForegroundColor;
            terminal.Write(text);
            if (!PersistantColor) terminal.ForegroundColor = oldfg;
        }
        /// <summary>
        /// Writes to the terminal with a specified color (SVGAIITerminal)
        /// </summary>
        /// <param name="text">The text to output</param>
        /// <param name="ForegroundColor">The Foreground color to draw</param>
        /// <param name="BackgroundColor">The Background color to draw</param>
        /// <param name="PersistantForegroundColor">Setting 'true' will keep the foreground color after the change</param>
        /// <param name="PersistantBackgroundColor">Setting 'true' will keep the background color after the change</param>
        public void ColoredWrite(string text, Color ForegroundColor, Color BackgroundColor, bool PersistantForegroundColor = false, bool PersistantBackgroundColor = false)
        {
            Color oldfg = terminal.ForegroundColor;
            Color oldbg = terminal.BackgroundColor;
            terminal.ForegroundColor = ForegroundColor;
            terminal.BackgroundColor = BackgroundColor;
            terminal.Write(text);
            if (!PersistantForegroundColor) terminal.ForegroundColor = oldfg;
            if (!PersistantBackgroundColor) terminal.BackgroundColor = oldbg;
        }
        /// <summary>
        /// Clears the terminal with a specified color (SVGAIITerminal)
        /// </summary>
        /// <param name="FillColor">The color to fill the terminal with</param>
        public void ClearScreenWithColor(Color FillColor)
        {
            terminal.Contents.Clear(FillColor);
        }
        /// <summary>
        /// Resets the terminal color to the default color
        /// </summary>
        public void ResetColor()
        {
            terminal.ForegroundColor = DefaultForegroundReturnColor;
            terminal.BackgroundColor = DefaultBackgroundReturnColor;
        }
        public string GetHydrixLibVersion()
        {
            return "0.0.3/23104 BETA";
        }

        public void DrawFilledBox(int x, int y, ushort width, ushort height, Color color)
        {
            terminal.Contents.DrawFilledRectangle(X: x, Y: y, Width: width, Height: height, Color: color, Radius: 0);
        }
        public void DrawFilledBox(int x, int y, ushort width, ushort height, Color color, ushort radius)
        {
            terminal.Contents.DrawFilledRectangle(X: x, Y: y, Width: width, Height: height, Color: color, Radius: radius);
        }
        public void DrawBox(int x, int y, ushort width, ushort height, Color color)
        {
            terminal.Contents.DrawRectangle(X: x, Y: y, Width: width, Height: height, Color: color, Radius: 0);
        }
        public void DrawBox(int x, int y, ushort width, ushort height, Color color, ushort radius)
        {
            terminal.Contents.DrawRectangle(X: x, Y: y, Width: width, Height: height, Color: color, Radius: radius);
        }
        public void DrawLine(int x1, int y1, int x2, int y2, Color color)
        {
            terminal.Contents.DrawLine(x1, y1, x2, y2, color);
        }
        public void DrawCircle(int x, int y, ushort radius, Color color)
        {
            terminal.Contents.DrawCircle(x, y, radius, color);
        }
        public void DrawFilledCircle(int x, int y, ushort radius, Color color)
        {
            terminal.Contents.DrawFilledCircle(x, y, radius, color);
        }
    }
}