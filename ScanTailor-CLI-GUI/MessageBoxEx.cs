﻿using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ScanTailor_CLI_GUI
{
    public class MessageBoxEx
    {
        #region DLLImport
        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, ref Rectangle lpRect);
        [DllImport("user32.dll")]
        private static extern int MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);
        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        [DllImport("user32.dll")]
        public static extern int UnhookWindowsHookEx(IntPtr idHook);
        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("kernel32.dll")]
        private static extern int GetCurrentThreadId();
        #endregion
        #region Struc_Enum
        public enum CbtHookAction
        {
            HCBT_MOVESIZE = 0,
            HCBT_MINMAX = 1,
            HCBT_QS = 2,
            HCBT_CREATEWND = 3,
            HCBT_DESTROYWND = 4,
            HCBT_ACTIVATE = 5,
            HCBT_CLICKSKIPPED = 6,
            HCBT_KEYSKIPPED = 7,
            HCBT_SYSCOMMAND = 8,
            HCBT_SETFOCUS = 9
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CWPRETSTRUCT
        {
            public IntPtr lResult;
            public IntPtr lParam;
            public IntPtr wParam;
            public uint message;
            public IntPtr hwnd;
        };
        #endregion
        public delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        public delegate void TimerProc(IntPtr hWnd, uint uMsg, UIntPtr nIDEvent, uint dwTime);

        public const int WH_CALLWNDPROCRET = 12;
        private static IWin32Window _owner;
        private static HookProc _hookProc;
        private static IntPtr _hHook;
        #region SHOW
        public static DialogResult Show(IWin32Window owner, string text)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text);
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption);
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption, buttons);
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons,MessageBoxIcon icon)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption, buttons, icon);
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons,MessageBoxIcon icon, MessageBoxDefaultButton defButton)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption, buttons, icon, defButton);
        }
        public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons,MessageBoxIcon icon, MessageBoxDefaultButton defButton, MessageBoxOptions options)
        {
            _owner = owner;
            Initialize();
            return MessageBox.Show(owner, text, caption, buttons, icon,defButton, options);
        }
        #endregion
        static MessageBoxEx()
        {
            _hookProc = MessageBoxHookProc;
            _hHook = IntPtr.Zero;
        }
        private static void Initialize()
        {
            if (_hHook != IntPtr.Zero)
            {
                throw new NotSupportedException("multiple calls are not supported");
            }
            if (_owner != null)
            {
                _hHook = SetWindowsHookEx(WH_CALLWNDPROCRET, _hookProc, IntPtr.Zero, GetCurrentThreadId());
            }
        }
        private static IntPtr MessageBoxHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode < 0)
            {
                return CallNextHookEx(_hHook, nCode, wParam, lParam);
            }
            var msg = (CWPRETSTRUCT)Marshal.PtrToStructure(lParam, typeof(CWPRETSTRUCT));
            var hook = _hHook;
            if (msg.message == (int)CbtHookAction.HCBT_ACTIVATE)
            {
                try
                {
                    CenterWindow(msg.hwnd);
                }
                finally
                {
                    UnhookWindowsHookEx(_hHook);
                    _hHook = IntPtr.Zero;
                }
            }
            return CallNextHookEx(hook, nCode, wParam, lParam);
        }
        private static void CenterWindow(IntPtr hChildWnd)
        {
            Rectangle recChild = new Rectangle(0, 0, 0, 0);
            if (GetWindowRect(hChildWnd, ref recChild))
            {
                int width = recChild.Width - recChild.X;
                int height = recChild.Height - recChild.Y;
                Rectangle recParent = new Rectangle(0, 0, 0, 0);
                if (GetWindowRect(_owner.Handle, ref recParent))
                {
                    Point ptCenter = new Point(0, 0);
                    ptCenter.X = recParent.X + ((recParent.Width - recParent.X) / 2);
                    ptCenter.Y = recParent.Y + ((recParent.Height - recParent.Y) / 2);
                    Point ptStart = new Point(0, 0);
                    ptStart.X = (ptCenter.X - (width / 2));
                    ptStart.Y = (ptCenter.Y - (height / 2));
                    ptStart.X = (ptStart.X < 0) ? 0 : ptStart.X;
                    ptStart.Y = (ptStart.Y < 0) ? 0 : ptStart.Y;
                    MoveWindow(hChildWnd, ptStart.X, ptStart.Y, width, height, false);
                }
            }
        }
    }
}