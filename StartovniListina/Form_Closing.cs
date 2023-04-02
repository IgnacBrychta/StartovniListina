using System.Runtime.InteropServices;

namespace StartovniListina
{
    public partial class Form_Closing : Form
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);
        volatile int window_x;
        volatile int window_y;
        const int multiplier = 7;
        bool allowClosing = false;
        const int flags = 0x40 | 0x1 | 0x200;
        const int xOffset = 300;
        const int yOffset = 300;
        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }
        public Form_Closing()
        {
            InitializeComponent();

            Rect velikostOkna = new Rect();
            window_x = velikostOkna.Left;
            window_y = velikostOkna.Top;
            GetWindowRect(Handle, ref velikostOkna);
            _ = StartMovingWindow();
        }
        private async Task StartMovingWindow()
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    Invoke(new Action(() =>
                    {
                        if (Math.Abs(Cursor.Position.X - (window_x + xOffset)) < xOffset / 3)
                        {
                            window_x += window_x + xOffset - Cursor.Position.X < 0 ? 1 : -1;
                            //this.Text = $"{Cursor.Position.X};{Cursor.Position.Y};{window_x};{window_y}";
                        }
                        else if (Cursor.Position.X != window_x + xOffset)
                        {
                            window_x += window_x + xOffset - Cursor.Position.X < 0 ? multiplier : -multiplier;
                        }
                        if (Math.Abs(Cursor.Position.Y - (window_y + yOffset)) < yOffset / 3)
                        {
                            window_y += window_y + yOffset - Cursor.Position.Y < 0 ? 1 : -1;
                        }
                        else if (Cursor.Position.Y != window_y + yOffset)
                        {
                            window_y += window_y + yOffset - Cursor.Position.Y < 0 ? multiplier : -multiplier;
                        }
                        
                        //SetWindowPos(Handle, 0, window_x, window_y, 0, 0, 69);
                        SetWindowPos(Handle, -1, window_x, window_y, 0, 0, flags);
                    }));
                    await Task.Delay(2);
                }
            });
        }
        private void Form_Closing_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !allowClosing;
        }
        private void CloseButtonClick(object sender, EventArgs e)
        {
            allowClosing = true;
        }
        private void DontCloseButtonClick(object sender, EventArgs e)
        {
            allowClosing = true;
        }
    }
}
