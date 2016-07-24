﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Antnf.KeyboardRemote.Tools
{
    /// <summary>
	/// 终端状态。
	/// </summary>
	public enum PeerState
    {
        /// <summary>处于离线状态。</summary>
        Offline,
        /// <summary>处于在线状态。</summary>
        Online
    }

    public enum KeyActionType
    {
        KeyDown,
        KeyUp
    }

    /// <summary>
	/// Standard Keyboard Shortcuts used by most applications
	/// </summary>
	public enum StandardShortcut
    {
        Copy,
        Cut,
        Paste,
        SelectAll,
        Save,
        Open,
        New,
        Close,
        Print
    }
}
