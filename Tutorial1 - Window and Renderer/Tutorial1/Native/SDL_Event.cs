#region License
/*
 * The following code is a modification of SDL2-C# made by Ethan Lee
 * /
/* SDL2# - C# Wrapper for SDL2
*
* Copyright (c) 2013-2014 Ethan Lee.
*
* This software is provided 'as-is', without any express or implied warranty.
* In no event will the authors be held liable for any damages arising from
* the use of this software.
*
* Permission is granted to anyone to use this software for any purpose,
* including commercial applications, and to alter it and redistribute it
* freely, subject to the following restrictions:
*
* 1. The origin of this software must not be misrepresented; you must not
* claim that you wrote the original software. If you use this software in a
* product, an acknowledgment in the product documentation would be
* appreciated but is not required.
*
* 2. Altered source versions must be plainly marked as such, and must not be
* misrepresented as being the original software.
*
* 3. This notice may not be removed or altered from any source distribution.
*
* Ethan "flibitijibibo" Lee <flibitijibibo@flibitijibibo.com>
*
*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1.Native
{
    internal class SDL_EventConstants
    {
        internal const int SDLK_SCANCODE_MASK = (1 << 30);
        internal const int SDL_TEXTEDITINGEVENT_TEXT_SIZE = 32;
        internal const int SDL_TEXTINPUTEVENT_TEXT_SIZE = 32;
    }

    internal enum SDL_Scancode
    {
        SDL_SCANCODE_UNKNOWN = 0,
        SDL_SCANCODE_A = 4,
        SDL_SCANCODE_B = 5,
        SDL_SCANCODE_C = 6,
        SDL_SCANCODE_D = 7,
        SDL_SCANCODE_E = 8,
        SDL_SCANCODE_F = 9,
        SDL_SCANCODE_G = 10,
        SDL_SCANCODE_H = 11,
        SDL_SCANCODE_I = 12,
        SDL_SCANCODE_J = 13,
        SDL_SCANCODE_K = 14,
        SDL_SCANCODE_L = 15,
        SDL_SCANCODE_M = 16,
        SDL_SCANCODE_N = 17,
        SDL_SCANCODE_O = 18,
        SDL_SCANCODE_P = 19,
        SDL_SCANCODE_Q = 20,
        SDL_SCANCODE_R = 21,
        SDL_SCANCODE_S = 22,
        SDL_SCANCODE_T = 23,
        SDL_SCANCODE_U = 24,
        SDL_SCANCODE_V = 25,
        SDL_SCANCODE_W = 26,
        SDL_SCANCODE_X = 27,
        SDL_SCANCODE_Y = 28,
        SDL_SCANCODE_Z = 29,
        SDL_SCANCODE_1 = 30,
        SDL_SCANCODE_2 = 31,
        SDL_SCANCODE_3 = 32,
        SDL_SCANCODE_4 = 33,
        SDL_SCANCODE_5 = 34,
        SDL_SCANCODE_6 = 35,
        SDL_SCANCODE_7 = 36,
        SDL_SCANCODE_8 = 37,
        SDL_SCANCODE_9 = 38,
        SDL_SCANCODE_0 = 39,
        SDL_SCANCODE_RETURN = 40,
        SDL_SCANCODE_ESCAPE = 41,
        SDL_SCANCODE_BACKSPACE = 42,
        SDL_SCANCODE_TAB = 43,
        SDL_SCANCODE_SPACE = 44,
        SDL_SCANCODE_MINUS = 45,
        SDL_SCANCODE_EQUALS = 46,
        SDL_SCANCODE_LEFTBRACKET = 47,
        SDL_SCANCODE_RIGHTBRACKET = 48,
        SDL_SCANCODE_BACKSLASH = 49,
        SDL_SCANCODE_NONUSHASH = 50,
        SDL_SCANCODE_SEMICOLON = 51,
        SDL_SCANCODE_APOSTROPHE = 52,
        SDL_SCANCODE_GRAVE = 53,
        SDL_SCANCODE_COMMA = 54,
        SDL_SCANCODE_PERIOD = 55,
        SDL_SCANCODE_SLASH = 56,
        SDL_SCANCODE_CAPSLOCK = 57,
        SDL_SCANCODE_F1 = 58,
        SDL_SCANCODE_F2 = 59,
        SDL_SCANCODE_F3 = 60,
        SDL_SCANCODE_F4 = 61,
        SDL_SCANCODE_F5 = 62,
        SDL_SCANCODE_F6 = 63,
        SDL_SCANCODE_F7 = 64,
        SDL_SCANCODE_F8 = 65,
        SDL_SCANCODE_F9 = 66,
        SDL_SCANCODE_F10 = 67,
        SDL_SCANCODE_F11 = 68,
        SDL_SCANCODE_F12 = 69,
        SDL_SCANCODE_PRINTSCREEN = 70,
        SDL_SCANCODE_SCROLLLOCK = 71,
        SDL_SCANCODE_PAUSE = 72,
        SDL_SCANCODE_INSERT = 73,
        SDL_SCANCODE_HOME = 74,
        SDL_SCANCODE_PAGEUP = 75,
        SDL_SCANCODE_DELETE = 76,
        SDL_SCANCODE_END = 77,
        SDL_SCANCODE_PAGEDOWN = 78,
        SDL_SCANCODE_RIGHT = 79,
        SDL_SCANCODE_LEFT = 80,
        SDL_SCANCODE_DOWN = 81,
        SDL_SCANCODE_UP = 82,
        SDL_SCANCODE_NUMLOCKCLEAR = 83,
        SDL_SCANCODE_KP_DIVIDE = 84,
        SDL_SCANCODE_KP_MULTIPLY = 85,
        SDL_SCANCODE_KP_MINUS = 86,
        SDL_SCANCODE_KP_PLUS = 87,
        SDL_SCANCODE_KP_ENTER = 88,
        SDL_SCANCODE_KP_1 = 89,
        SDL_SCANCODE_KP_2 = 90,
        SDL_SCANCODE_KP_3 = 91,
        SDL_SCANCODE_KP_4 = 92,
        SDL_SCANCODE_KP_5 = 93,
        SDL_SCANCODE_KP_6 = 94,
        SDL_SCANCODE_KP_7 = 95,
        SDL_SCANCODE_KP_8 = 96,
        SDL_SCANCODE_KP_9 = 97,
        SDL_SCANCODE_KP_0 = 98,
        SDL_SCANCODE_KP_PERIOD = 99,
        SDL_SCANCODE_NONUSBACKSLASH = 100,
        SDL_SCANCODE_APPLICATION = 101,
        SDL_SCANCODE_POWER = 102,
        SDL_SCANCODE_KP_EQUALS = 103,
        SDL_SCANCODE_F13 = 104,
        SDL_SCANCODE_F14 = 105,
        SDL_SCANCODE_F15 = 106,
        SDL_SCANCODE_F16 = 107,
        SDL_SCANCODE_F17 = 108,
        SDL_SCANCODE_F18 = 109,
        SDL_SCANCODE_F19 = 110,
        SDL_SCANCODE_F20 = 111,
        SDL_SCANCODE_F21 = 112,
        SDL_SCANCODE_F22 = 113,
        SDL_SCANCODE_F23 = 114,
        SDL_SCANCODE_F24 = 115,
        SDL_SCANCODE_EXECUTE = 116,
        SDL_SCANCODE_HELP = 117,
        SDL_SCANCODE_MENU = 118,
        SDL_SCANCODE_SELECT = 119,
        SDL_SCANCODE_STOP = 120,
        SDL_SCANCODE_AGAIN = 121,
        SDL_SCANCODE_UNDO = 122,
        SDL_SCANCODE_CUT = 123,
        SDL_SCANCODE_COPY = 124,
        SDL_SCANCODE_PASTE = 125,
        SDL_SCANCODE_FIND = 126,
        SDL_SCANCODE_MUTE = 127,
        SDL_SCANCODE_VOLUMEUP = 128,
        SDL_SCANCODE_VOLUMEDOWN = 129,
        /* not sure whether there's a reason to enable these */
        /* SDL_SCANCODE_LOCKINGCAPSLOCK = 130, */
        /* SDL_SCANCODE_LOCKINGNUMLOCK = 131, */
        /* SDL_SCANCODE_LOCKINGSCROLLLOCK = 132, */
        SDL_SCANCODE_KP_COMMA = 133,
        SDL_SCANCODE_KP_EQUALSAS400 = 134,
        SDL_SCANCODE_INTERNATIONAL1 = 135,
        SDL_SCANCODE_INTERNATIONAL2 = 136,
        SDL_SCANCODE_INTERNATIONAL3 = 137,
        SDL_SCANCODE_INTERNATIONAL4 = 138,
        SDL_SCANCODE_INTERNATIONAL5 = 139,
        SDL_SCANCODE_INTERNATIONAL6 = 140,
        SDL_SCANCODE_INTERNATIONAL7 = 141,
        SDL_SCANCODE_INTERNATIONAL8 = 142,
        SDL_SCANCODE_INTERNATIONAL9 = 143,
        SDL_SCANCODE_LANG1 = 144,
        SDL_SCANCODE_LANG2 = 145,
        SDL_SCANCODE_LANG3 = 146,
        SDL_SCANCODE_LANG4 = 147,
        SDL_SCANCODE_LANG5 = 148,
        SDL_SCANCODE_LANG6 = 149,
        SDL_SCANCODE_LANG7 = 150,
        SDL_SCANCODE_LANG8 = 151,
        SDL_SCANCODE_LANG9 = 152,
        SDL_SCANCODE_ALTERASE = 153,
        SDL_SCANCODE_SYSREQ = 154,
        SDL_SCANCODE_CANCEL = 155,
        SDL_SCANCODE_CLEAR = 156,
        SDL_SCANCODE_PRIOR = 157,
        SDL_SCANCODE_RETURN2 = 158,
        SDL_SCANCODE_SEPARATOR = 159,
        SDL_SCANCODE_OUT = 160,
        SDL_SCANCODE_OPER = 161,
        SDL_SCANCODE_CLEARAGAIN = 162,
        SDL_SCANCODE_CRSEL = 163,
        SDL_SCANCODE_EXSEL = 164,
        SDL_SCANCODE_KP_00 = 176,
        SDL_SCANCODE_KP_000 = 177,
        SDL_SCANCODE_THOUSANDSSEPARATOR = 178,
        SDL_SCANCODE_DECIMALSEPARATOR = 179,
        SDL_SCANCODE_CURRENCYUNIT = 180,
        SDL_SCANCODE_CURRENCYSUBUNIT = 181,
        SDL_SCANCODE_KP_LEFTPAREN = 182,
        SDL_SCANCODE_KP_RIGHTPAREN = 183,
        SDL_SCANCODE_KP_LEFTBRACE = 184,
        SDL_SCANCODE_KP_RIGHTBRACE = 185,
        SDL_SCANCODE_KP_TAB = 186,
        SDL_SCANCODE_KP_BACKSPACE = 187,
        SDL_SCANCODE_KP_A = 188,
        SDL_SCANCODE_KP_B = 189,
        SDL_SCANCODE_KP_C = 190,
        SDL_SCANCODE_KP_D = 191,
        SDL_SCANCODE_KP_E = 192,
        SDL_SCANCODE_KP_F = 193,
        SDL_SCANCODE_KP_XOR = 194,
        SDL_SCANCODE_KP_POWER = 195,
        SDL_SCANCODE_KP_PERCENT = 196,
        SDL_SCANCODE_KP_LESS = 197,
        SDL_SCANCODE_KP_GREATER = 198,
        SDL_SCANCODE_KP_AMPERSAND = 199,
        SDL_SCANCODE_KP_DBLAMPERSAND = 200,
        SDL_SCANCODE_KP_VERTICALBAR = 201,
        SDL_SCANCODE_KP_DBLVERTICALBAR = 202,
        SDL_SCANCODE_KP_COLON = 203,
        SDL_SCANCODE_KP_HASH = 204,
        SDL_SCANCODE_KP_SPACE = 205,
        SDL_SCANCODE_KP_AT = 206,
        SDL_SCANCODE_KP_EXCLAM = 207,
        SDL_SCANCODE_KP_MEMSTORE = 208,
        SDL_SCANCODE_KP_MEMRECALL = 209,
        SDL_SCANCODE_KP_MEMCLEAR = 210,
        SDL_SCANCODE_KP_MEMADD = 211,
        SDL_SCANCODE_KP_MEMSUBTRACT = 212,
        SDL_SCANCODE_KP_MEMMULTIPLY = 213,
        SDL_SCANCODE_KP_MEMDIVIDE = 214,
        SDL_SCANCODE_KP_PLUSMINUS = 215,
        SDL_SCANCODE_KP_CLEAR = 216,
        SDL_SCANCODE_KP_CLEARENTRY = 217,
        SDL_SCANCODE_KP_BINARY = 218,
        SDL_SCANCODE_KP_OCTAL = 219,
        SDL_SCANCODE_KP_DECIMAL = 220,
        SDL_SCANCODE_KP_HEXADECIMAL = 221,
        SDL_SCANCODE_LCTRL = 224,
        SDL_SCANCODE_LSHIFT = 225,
        SDL_SCANCODE_LALT = 226,
        SDL_SCANCODE_LGUI = 227,
        SDL_SCANCODE_RCTRL = 228,
        SDL_SCANCODE_RSHIFT = 229,
        SDL_SCANCODE_RALT = 230,
        SDL_SCANCODE_RGUI = 231,
        SDL_SCANCODE_MODE = 257,
        /* These come from the USB consumer page (0x0C) */
        SDL_SCANCODE_AUDIONEXT = 258,
        SDL_SCANCODE_AUDIOPREV = 259,
        SDL_SCANCODE_AUDIOSTOP = 260,
        SDL_SCANCODE_AUDIOPLAY = 261,
        SDL_SCANCODE_AUDIOMUTE = 262,
        SDL_SCANCODE_MEDIASELECT = 263,
        SDL_SCANCODE_WWW = 264,
        SDL_SCANCODE_MAIL = 265,
        SDL_SCANCODE_CALCULATOR = 266,
        SDL_SCANCODE_COMPUTER = 267,
        SDL_SCANCODE_AC_SEARCH = 268,
        SDL_SCANCODE_AC_HOME = 269,
        SDL_SCANCODE_AC_BACK = 270,
        SDL_SCANCODE_AC_FORWARD = 271,
        SDL_SCANCODE_AC_STOP = 272,
        SDL_SCANCODE_AC_REFRESH = 273,
        SDL_SCANCODE_AC_BOOKMARKS = 274,
        /* These come from other sources, and are mostly mac related */
        SDL_SCANCODE_BRIGHTNESSDOWN = 275,
        SDL_SCANCODE_BRIGHTNESSUP = 276,
        SDL_SCANCODE_DISPLAYSWITCH = 277,
        SDL_SCANCODE_KBDILLUMTOGGLE = 278,
        SDL_SCANCODE_KBDILLUMDOWN = 279,
        SDL_SCANCODE_KBDILLUMUP = 280,
        SDL_SCANCODE_EJECT = 281,
        SDL_SCANCODE_SLEEP = 282,
        SDL_SCANCODE_APP1 = 283,
        SDL_SCANCODE_APP2 = 284,
        /* This is not a key, simply marks the number of scancodes
        * so that you know how big to make your arrays. */
        SDL_NUM_SCANCODES = 512
    }

    /* So, in the C headers, SDL_Keycode is a typedef of Sint32
    * and all of the names are in an anonymous enum. Yeah...
    * that's not going to cut it for C#. We'll just put them in an
    * enum for now? */
    internal enum SDL_Keycode
    {
        SDLK_UNKNOWN = 0,
        SDLK_RETURN = '\r',
        SDLK_ESCAPE = 27, // '\033'
        SDLK_BACKSPACE = '\b',
        SDLK_TAB = '\t',
        SDLK_SPACE = ' ',
        SDLK_EXCLAIM = '!',
        SDLK_QUOTEDBL = '"',
        SDLK_HASH = '#',
        SDLK_PERCENT = '%',
        SDLK_DOLLAR = '$',
        SDLK_AMPERSAND = '&',
        SDLK_QUOTE = '\'',
        SDLK_LEFTPAREN = '(',
        SDLK_RIGHTPAREN = ')',
        SDLK_ASTERISK = '*',
        SDLK_PLUS = '+',
        SDLK_COMMA = ',',
        SDLK_MINUS = '-',
        SDLK_PERIOD = '.',
        SDLK_SLASH = '/',
        SDLK_0 = '0',
        SDLK_1 = '1',
        SDLK_2 = '2',
        SDLK_3 = '3',
        SDLK_4 = '4',
        SDLK_5 = '5',
        SDLK_6 = '6',
        SDLK_7 = '7',
        SDLK_8 = '8',
        SDLK_9 = '9',
        SDLK_COLON = ':',
        SDLK_SEMICOLON = ';',
        SDLK_LESS = '<',
        SDLK_EQUALS = '=',
        SDLK_GREATER = '>',
        SDLK_QUESTION = '?',
        SDLK_AT = '@',
        /*
        Skip uppercase letters
        */
        SDLK_LEFTBRACKET = '[',
        SDLK_BACKSLASH = '\\',
        SDLK_RIGHTBRACKET = ']',
        SDLK_CARET = '^',
        SDLK_UNDERSCORE = '_',
        SDLK_BACKQUOTE = '`',
        SDLK_a = 'a',
        SDLK_b = 'b',
        SDLK_c = 'c',
        SDLK_d = 'd',
        SDLK_e = 'e',
        SDLK_f = 'f',
        SDLK_g = 'g',
        SDLK_h = 'h',
        SDLK_i = 'i',
        SDLK_j = 'j',
        SDLK_k = 'k',
        SDLK_l = 'l',
        SDLK_m = 'm',
        SDLK_n = 'n',
        SDLK_o = 'o',
        SDLK_p = 'p',
        SDLK_q = 'q',
        SDLK_r = 'r',
        SDLK_s = 's',
        SDLK_t = 't',
        SDLK_u = 'u',
        SDLK_v = 'v',
        SDLK_w = 'w',
        SDLK_x = 'x',
        SDLK_y = 'y',
        SDLK_z = 'z',
        SDLK_CAPSLOCK = (int)SDL_Scancode.SDL_SCANCODE_CAPSLOCK | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F1 = (int)SDL_Scancode.SDL_SCANCODE_F1 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F2 = (int)SDL_Scancode.SDL_SCANCODE_F2 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F3 = (int)SDL_Scancode.SDL_SCANCODE_F3 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F4 = (int)SDL_Scancode.SDL_SCANCODE_F4 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F5 = (int)SDL_Scancode.SDL_SCANCODE_F5 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F6 = (int)SDL_Scancode.SDL_SCANCODE_F6 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F7 = (int)SDL_Scancode.SDL_SCANCODE_F7 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F8 = (int)SDL_Scancode.SDL_SCANCODE_F8 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F9 = (int)SDL_Scancode.SDL_SCANCODE_F9 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F10 = (int)SDL_Scancode.SDL_SCANCODE_F10 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F11 = (int)SDL_Scancode.SDL_SCANCODE_F11 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F12 = (int)SDL_Scancode.SDL_SCANCODE_F12 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_PRINTSCREEN = (int)SDL_Scancode.SDL_SCANCODE_PRINTSCREEN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_SCROLLLOCK = (int)SDL_Scancode.SDL_SCANCODE_SCROLLLOCK | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_PAUSE = (int)SDL_Scancode.SDL_SCANCODE_PAUSE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_INSERT = (int)SDL_Scancode.SDL_SCANCODE_INSERT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_HOME = (int)SDL_Scancode.SDL_SCANCODE_HOME | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_PAGEUP = (int)SDL_Scancode.SDL_SCANCODE_PAGEUP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_DELETE = 177,
        SDLK_END = (int)SDL_Scancode.SDL_SCANCODE_END | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_PAGEDOWN = (int)SDL_Scancode.SDL_SCANCODE_PAGEDOWN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_RIGHT = (int)SDL_Scancode.SDL_SCANCODE_RIGHT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_LEFT = (int)SDL_Scancode.SDL_SCANCODE_LEFT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_DOWN = (int)SDL_Scancode.SDL_SCANCODE_DOWN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_UP = (int)SDL_Scancode.SDL_SCANCODE_UP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_NUMLOCKCLEAR = (int)SDL_Scancode.SDL_SCANCODE_NUMLOCKCLEAR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_DIVIDE = (int)SDL_Scancode.SDL_SCANCODE_KP_DIVIDE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MULTIPLY = (int)SDL_Scancode.SDL_SCANCODE_KP_MULTIPLY | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MINUS = (int)SDL_Scancode.SDL_SCANCODE_KP_MINUS | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_PLUS = (int)SDL_Scancode.SDL_SCANCODE_KP_PLUS | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_ENTER = (int)SDL_Scancode.SDL_SCANCODE_KP_ENTER | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_1 = (int)SDL_Scancode.SDL_SCANCODE_KP_1 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_2 = (int)SDL_Scancode.SDL_SCANCODE_KP_2 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_3 = (int)SDL_Scancode.SDL_SCANCODE_KP_3 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_4 = (int)SDL_Scancode.SDL_SCANCODE_KP_4 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_5 = (int)SDL_Scancode.SDL_SCANCODE_KP_5 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_6 = (int)SDL_Scancode.SDL_SCANCODE_KP_6 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_7 = (int)SDL_Scancode.SDL_SCANCODE_KP_7 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_8 = (int)SDL_Scancode.SDL_SCANCODE_KP_8 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_9 = (int)SDL_Scancode.SDL_SCANCODE_KP_9 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_0 = (int)SDL_Scancode.SDL_SCANCODE_KP_0 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_PERIOD = (int)SDL_Scancode.SDL_SCANCODE_KP_PERIOD | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_APPLICATION = (int)SDL_Scancode.SDL_SCANCODE_APPLICATION | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_POWER = (int)SDL_Scancode.SDL_SCANCODE_POWER | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_EQUALS = (int)SDL_Scancode.SDL_SCANCODE_KP_EQUALS | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F13 = (int)SDL_Scancode.SDL_SCANCODE_F13 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F14 = (int)SDL_Scancode.SDL_SCANCODE_F14 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F15 = (int)SDL_Scancode.SDL_SCANCODE_F15 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F16 = (int)SDL_Scancode.SDL_SCANCODE_F16 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F17 = (int)SDL_Scancode.SDL_SCANCODE_F17 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F18 = (int)SDL_Scancode.SDL_SCANCODE_F18 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F19 = (int)SDL_Scancode.SDL_SCANCODE_F19 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F20 = (int)SDL_Scancode.SDL_SCANCODE_F20 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F21 = (int)SDL_Scancode.SDL_SCANCODE_F21 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F22 = (int)SDL_Scancode.SDL_SCANCODE_F22 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F23 = (int)SDL_Scancode.SDL_SCANCODE_F23 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_F24 = (int)SDL_Scancode.SDL_SCANCODE_F24 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_EXECUTE = (int)SDL_Scancode.SDL_SCANCODE_EXECUTE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_HELP = (int)SDL_Scancode.SDL_SCANCODE_HELP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_MENU = (int)SDL_Scancode.SDL_SCANCODE_MENU | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_SELECT = (int)SDL_Scancode.SDL_SCANCODE_SELECT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_STOP = (int)SDL_Scancode.SDL_SCANCODE_STOP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AGAIN = (int)SDL_Scancode.SDL_SCANCODE_AGAIN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_UNDO = (int)SDL_Scancode.SDL_SCANCODE_UNDO | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_CUT = (int)SDL_Scancode.SDL_SCANCODE_CUT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_COPY = (int)SDL_Scancode.SDL_SCANCODE_COPY | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_PASTE = (int)SDL_Scancode.SDL_SCANCODE_PASTE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_FIND = (int)SDL_Scancode.SDL_SCANCODE_FIND | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_MUTE = (int)SDL_Scancode.SDL_SCANCODE_MUTE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_VOLUMEUP = (int)SDL_Scancode.SDL_SCANCODE_VOLUMEUP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_VOLUMEDOWN = (int)SDL_Scancode.SDL_SCANCODE_VOLUMEDOWN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_COMMA = (int)SDL_Scancode.SDL_SCANCODE_KP_COMMA | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_EQUALSAS400 =
        (int)SDL_Scancode.SDL_SCANCODE_KP_EQUALSAS400 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_ALTERASE = (int)SDL_Scancode.SDL_SCANCODE_ALTERASE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_SYSREQ = (int)SDL_Scancode.SDL_SCANCODE_SYSREQ | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_CANCEL = (int)SDL_Scancode.SDL_SCANCODE_CANCEL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_CLEAR = (int)SDL_Scancode.SDL_SCANCODE_CLEAR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_PRIOR = (int)SDL_Scancode.SDL_SCANCODE_PRIOR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_RETURN2 = (int)SDL_Scancode.SDL_SCANCODE_RETURN2 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_SEPARATOR = (int)SDL_Scancode.SDL_SCANCODE_SEPARATOR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_OUT = (int)SDL_Scancode.SDL_SCANCODE_OUT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_OPER = (int)SDL_Scancode.SDL_SCANCODE_OPER | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_CLEARAGAIN = (int)SDL_Scancode.SDL_SCANCODE_CLEARAGAIN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_CRSEL = (int)SDL_Scancode.SDL_SCANCODE_CRSEL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_EXSEL = (int)SDL_Scancode.SDL_SCANCODE_EXSEL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_00 = (int)SDL_Scancode.SDL_SCANCODE_KP_00 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_000 = (int)SDL_Scancode.SDL_SCANCODE_KP_000 | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_THOUSANDSSEPARATOR =
        (int)SDL_Scancode.SDL_SCANCODE_THOUSANDSSEPARATOR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_DECIMALSEPARATOR =
        (int)SDL_Scancode.SDL_SCANCODE_DECIMALSEPARATOR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_CURRENCYUNIT = (int)SDL_Scancode.SDL_SCANCODE_CURRENCYUNIT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_CURRENCYSUBUNIT =
        (int)SDL_Scancode.SDL_SCANCODE_CURRENCYSUBUNIT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_LEFTPAREN = (int)SDL_Scancode.SDL_SCANCODE_KP_LEFTPAREN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_RIGHTPAREN = (int)SDL_Scancode.SDL_SCANCODE_KP_RIGHTPAREN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_LEFTBRACE = (int)SDL_Scancode.SDL_SCANCODE_KP_LEFTBRACE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_RIGHTBRACE = (int)SDL_Scancode.SDL_SCANCODE_KP_RIGHTBRACE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_TAB = (int)SDL_Scancode.SDL_SCANCODE_KP_TAB | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_BACKSPACE = (int)SDL_Scancode.SDL_SCANCODE_KP_BACKSPACE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_A = (int)SDL_Scancode.SDL_SCANCODE_KP_A | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_B = (int)SDL_Scancode.SDL_SCANCODE_KP_B | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_C = (int)SDL_Scancode.SDL_SCANCODE_KP_C | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_D = (int)SDL_Scancode.SDL_SCANCODE_KP_D | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_E = (int)SDL_Scancode.SDL_SCANCODE_KP_E | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_F = (int)SDL_Scancode.SDL_SCANCODE_KP_F | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_XOR = (int)SDL_Scancode.SDL_SCANCODE_KP_XOR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_POWER = (int)SDL_Scancode.SDL_SCANCODE_KP_POWER | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_PERCENT = (int)SDL_Scancode.SDL_SCANCODE_KP_PERCENT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_LESS = (int)SDL_Scancode.SDL_SCANCODE_KP_LESS | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_GREATER = (int)SDL_Scancode.SDL_SCANCODE_KP_GREATER | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_AMPERSAND = (int)SDL_Scancode.SDL_SCANCODE_KP_AMPERSAND | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_DBLAMPERSAND =
        (int)SDL_Scancode.SDL_SCANCODE_KP_DBLAMPERSAND | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_VERTICALBAR =
        (int)SDL_Scancode.SDL_SCANCODE_KP_VERTICALBAR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_DBLVERTICALBAR =
        (int)SDL_Scancode.SDL_SCANCODE_KP_DBLVERTICALBAR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_COLON = (int)SDL_Scancode.SDL_SCANCODE_KP_COLON | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_HASH = (int)SDL_Scancode.SDL_SCANCODE_KP_HASH | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_SPACE = (int)SDL_Scancode.SDL_SCANCODE_KP_SPACE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_AT = (int)SDL_Scancode.SDL_SCANCODE_KP_AT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_EXCLAM = (int)SDL_Scancode.SDL_SCANCODE_KP_EXCLAM | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMSTORE = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMSTORE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMRECALL = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMRECALL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMCLEAR = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMCLEAR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMADD = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMADD | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMSUBTRACT =
        (int)SDL_Scancode.SDL_SCANCODE_KP_MEMSUBTRACT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMMULTIPLY =
        (int)SDL_Scancode.SDL_SCANCODE_KP_MEMMULTIPLY | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_MEMDIVIDE = (int)SDL_Scancode.SDL_SCANCODE_KP_MEMDIVIDE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_PLUSMINUS = (int)SDL_Scancode.SDL_SCANCODE_KP_PLUSMINUS | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_CLEAR = (int)SDL_Scancode.SDL_SCANCODE_KP_CLEAR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_CLEARENTRY = (int)SDL_Scancode.SDL_SCANCODE_KP_CLEARENTRY | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_BINARY = (int)SDL_Scancode.SDL_SCANCODE_KP_BINARY | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_OCTAL = (int)SDL_Scancode.SDL_SCANCODE_KP_OCTAL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_DECIMAL = (int)SDL_Scancode.SDL_SCANCODE_KP_DECIMAL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KP_HEXADECIMAL =
        (int)SDL_Scancode.SDL_SCANCODE_KP_HEXADECIMAL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_LCTRL = (int)SDL_Scancode.SDL_SCANCODE_LCTRL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_LSHIFT = (int)SDL_Scancode.SDL_SCANCODE_LSHIFT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_LALT = (int)SDL_Scancode.SDL_SCANCODE_LALT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_LGUI = (int)SDL_Scancode.SDL_SCANCODE_LGUI | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_RCTRL = (int)SDL_Scancode.SDL_SCANCODE_RCTRL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_RSHIFT = (int)SDL_Scancode.SDL_SCANCODE_RSHIFT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_RALT = (int)SDL_Scancode.SDL_SCANCODE_RALT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_RGUI = (int)SDL_Scancode.SDL_SCANCODE_RGUI | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_MODE = (int)SDL_Scancode.SDL_SCANCODE_MODE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AUDIONEXT = (int)SDL_Scancode.SDL_SCANCODE_AUDIONEXT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AUDIOPREV = (int)SDL_Scancode.SDL_SCANCODE_AUDIOPREV | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AUDIOSTOP = (int)SDL_Scancode.SDL_SCANCODE_AUDIOSTOP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AUDIOPLAY = (int)SDL_Scancode.SDL_SCANCODE_AUDIOPLAY | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AUDIOMUTE = (int)SDL_Scancode.SDL_SCANCODE_AUDIOMUTE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_MEDIASELECT = (int)SDL_Scancode.SDL_SCANCODE_MEDIASELECT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_WWW = (int)SDL_Scancode.SDL_SCANCODE_WWW | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_MAIL = (int)SDL_Scancode.SDL_SCANCODE_MAIL | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_CALCULATOR = (int)SDL_Scancode.SDL_SCANCODE_CALCULATOR | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_COMPUTER = (int)SDL_Scancode.SDL_SCANCODE_COMPUTER | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AC_SEARCH = (int)SDL_Scancode.SDL_SCANCODE_AC_SEARCH | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AC_HOME = (int)SDL_Scancode.SDL_SCANCODE_AC_HOME | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AC_BACK = (int)SDL_Scancode.SDL_SCANCODE_AC_BACK | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AC_FORWARD = (int)SDL_Scancode.SDL_SCANCODE_AC_FORWARD | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AC_STOP = (int)SDL_Scancode.SDL_SCANCODE_AC_STOP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AC_REFRESH = (int)SDL_Scancode.SDL_SCANCODE_AC_REFRESH | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_AC_BOOKMARKS = (int)SDL_Scancode.SDL_SCANCODE_AC_BOOKMARKS | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_BRIGHTNESSDOWN =
        (int)SDL_Scancode.SDL_SCANCODE_BRIGHTNESSDOWN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_BRIGHTNESSUP = (int)SDL_Scancode.SDL_SCANCODE_BRIGHTNESSUP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_DISPLAYSWITCH = (int)SDL_Scancode.SDL_SCANCODE_DISPLAYSWITCH | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KBDILLUMTOGGLE =
        (int)SDL_Scancode.SDL_SCANCODE_KBDILLUMTOGGLE | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KBDILLUMDOWN = (int)SDL_Scancode.SDL_SCANCODE_KBDILLUMDOWN | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_KBDILLUMUP = (int)SDL_Scancode.SDL_SCANCODE_KBDILLUMUP | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_EJECT = (int)SDL_Scancode.SDL_SCANCODE_EJECT | SDL_EventConstants.SDLK_SCANCODE_MASK,
        SDLK_SLEEP = (int)SDL_Scancode.SDL_SCANCODE_SLEEP | SDL_EventConstants.SDLK_SCANCODE_MASK
    }
    /* Key modifiers (bitfield) */
    [Flags]
    internal enum SDL_Keymod : ushort
    {
        KMOD_NONE = 0x0000,
        KMOD_LSHIFT = 0x0001,
        KMOD_RSHIFT = 0x0002,
        KMOD_LCTRL = 0x0040,
        KMOD_RCTRL = 0x0080,
        KMOD_LALT = 0x0100,
        KMOD_RALT = 0x0200,
        KMOD_LGUI = 0x0400,
        KMOD_RGUI = 0x0800,
        KMOD_NUM = 0x1000,
        KMOD_CAPS = 0x2000,
        KMOD_MODE = 0x4000,
        KMOD_RESERVED = 0x8000,
        /* These are defines in the SDL headers */
        KMOD_CTRL = (KMOD_LCTRL | KMOD_RCTRL),
        KMOD_SHIFT = (KMOD_LSHIFT | KMOD_RSHIFT),
        KMOD_ALT = (KMOD_LALT | KMOD_RALT),
        KMOD_GUI = (KMOD_LGUI | KMOD_RGUI)
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_Keysym
    {
        internal SDL_Scancode scancode;
        internal SDL_Keycode sym;
        internal SDL_Keymod mod; /* UInt16 */
        internal UInt32 unicode; /* Deprecated */
    }


    /* The types of events that can be delivered. */
    internal enum SDL_EventType : uint
    {
        SDL_FIRSTEVENT = 0,
        /* Application events */
        SDL_QUIT = 0x100,
        /* Window events */
        SDL_WINDOWEVENT = 0x200,
        SDL_SYSWMEVENT,
        /* Keyboard events */
        SDL_KEYDOWN = 0x300,
        SDL_KEYUP,
        SDL_TEXTEDITING,
        SDL_TEXTINPUT,
        /* Mouse events */
        SDL_MOUSEMOTION = 0x400,
        SDL_MOUSEBUTTONDOWN,
        SDL_MOUSEBUTTONUP,
        SDL_MOUSEWHEEL,
        /* Joystick events */
        SDL_JOYAXISMOTION = 0x600,
        SDL_JOYBALLMOTION,
        SDL_JOYHATMOTION,
        SDL_JOYBUTTONDOWN,
        SDL_JOYBUTTONUP,
        SDL_JOYDEVICEADDED,
        SDL_JOYDEVICEREMOVED,
        /* Game controller events */
        SDL_CONTROLLERAXISMOTION = 0x650,
        SDL_CONTROLLERBUTTONDOWN,
        SDL_CONTROLLERBUTTONUP,
        SDL_CONTROLLERDEVICEADDED,
        SDL_CONTROLLERDEVICEREMOVED,
        SDL_CONTROLLERDEVICEREMAPPED,
        /* Touch events */
        SDL_FINGERDOWN = 0x700,
        SDL_FINGERUP,
        SDL_FINGERMOTION,
        /* Gesture events */
        SDL_DOLLARGESTURE = 0x800,
        SDL_DOLLARRECORD,
        SDL_MULTIGESTURE,
        /* Clipboard events */
        SDL_CLIPBOARDUPDATE = 0x900,
        /* Drag and drop events */
        SDL_DROPFILE = 0x1000,
        /* Render events */
        /* Only available in SDL 2.0.2 or higher */
        SDL_RENDER_TARGETS_RESET = 0x2000,
        /* Events SDL_USEREVENT through SDL_LASTEVENT are for
        * your use, and should be allocated with
        * SDL_RegisterEvents()
        */
        SDL_USEREVENT = 0x8000,
        /* The last event, used for bouding arrays. */
        SDL_LASTEVENT = 0xFFFF
    }
    /// <summary>
    /// An enumeration of window events.
    /// </summary>
    internal enum SDL_WindowEventID : byte
    {
        SDL_WINDOWEVENT_NONE,
        SDL_WINDOWEVENT_SHOWN,
        SDL_WINDOWEVENT_HIDDEN,
        SDL_WINDOWEVENT_EXPOSED,
        SDL_WINDOWEVENT_MOVED,
        SDL_WINDOWEVENT_RESIZED,
        SDL_WINDOWEVENT_SIZE_CHANGED,
        SDL_WINDOWEVENT_MINIMIZED,
        SDL_WINDOWEVENT_MAXIMIZED,
        SDL_WINDOWEVENT_RESTORED,
        SDL_WINDOWEVENT_ENTER,
        SDL_WINDOWEVENT_LEAVE,
        SDL_WINDOWEVENT_FOCUS_GAINED,
        SDL_WINDOWEVENT_FOCUS_LOST,
        SDL_WINDOWEVENT_CLOSE,
    }
    /* Fields shared by every event */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_GenericEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
    }
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Window state change event data (event.window.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_WindowEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal UInt32 windowID;
        internal SDL_WindowEventID windowEvent; // event, lolC#
        private byte padding1;
        private byte padding2;
        private byte padding3;
        internal Int32 data1;
        internal Int32 data2;
    }
#pragma warning restore 0169
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Keyboard button event structure (event.key.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_KeyboardEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal UInt32 windowID;
        internal byte state;
        internal byte repeat; /* non-zero if this is a repeat */
        private byte padding2;
        private byte padding3;
        internal SDL_Keysym keysym;
    }
#pragma warning restore 0169
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct SDL_TextEditingEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal UInt32 windowID;
        internal fixed byte text[SDL_EventConstants.SDL_TEXTEDITINGEVENT_TEXT_SIZE];
        internal Int32 start;
        internal Int32 length;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct SDL_TextInputEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal UInt32 windowID;
        internal fixed byte text[SDL_EventConstants.SDL_TEXTINPUTEVENT_TEXT_SIZE];
    }
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Mouse motion event structure (event.motion.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_MouseMotionEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal UInt32 windowID;
        internal UInt32 which;
        internal byte state; /* bitmask of buttons */
        private byte padding1;
        private byte padding2;
        private byte padding3;
        internal Int32 x;
        internal Int32 y;
        internal Int32 xrel;
        internal Int32 yrel;
    }
#pragma warning restore 0169
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Mouse button event structure (event.button.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_MouseButtonEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal UInt32 windowID;
        internal UInt32 which;
        internal byte button; /* button id */
        internal byte state; /* SDL_PRESSED or SDL_RELEASED */
        internal byte clicks; /* 1 for single-click, 2 for double-click, etc. */
        private byte padding1;
        internal Int32 x;
        internal Int32 y;
    }
#pragma warning restore 0169
    /* Mouse wheel event structure (event.wheel.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_MouseWheelEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal UInt32 windowID;
        internal UInt32 which;
        internal Int32 x; /* amount scrolled horizontally */
        internal Int32 y; /* amount scrolled vertically */
    }
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Joystick axis motion event structure (event.jaxis.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyAxisEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal Int32 which; /* SDL_JoystickID */
        internal byte axis;
        private byte padding1;
        private byte padding2;
        private byte padding3;
        internal Int16 axisValue; /* value, lolC# */
        internal UInt16 padding4;
    }
#pragma warning restore 0169
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Joystick trackball motion event structure (event.jball.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyBallEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal Int32 which; /* SDL_JoystickID */
        internal byte ball;
        private byte padding1;
        private byte padding2;
        private byte padding3;
        internal Int16 xrel;
        internal Int16 yrel;
    }
#pragma warning restore 0169
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Joystick hat position change event struct (event.jhat.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyHatEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal Int32 which; /* SDL_JoystickID */
        internal byte hat; /* index of the hat */
        internal byte hatValue; /* value, lolC# */
        private byte padding1;
        private byte padding2;
    }
#pragma warning restore 0169
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Joystick button event structure (event.jbutton.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyButtonEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal Int32 which; /* SDL_JoystickID */
        internal byte button;
        internal byte state; /* SDL_PRESSED or SDL_RELEASED */
        private byte padding1;
        private byte padding2;
    }
#pragma warning restore 0169
    /* Joystick device event structure (event.jdevice.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_JoyDeviceEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal Int32 which; /* SDL_JoystickID */
    }
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Game controller axis motion event (event.caxis.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_ControllerAxisEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal Int32 which; /* SDL_JoystickID */
        internal byte axis;
        private byte padding1;
        private byte padding2;
        private byte padding3;
        internal Int16 axisValue; /* value, lolC# */
        private UInt16 padding4;
    }
#pragma warning restore 0169
    // Ignore private members used for padding in this struct
#pragma warning disable 0169
    /* Game controller button event (event.cbutton.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_ControllerButtonEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal Int32 which; /* SDL_JoystickID */
        internal byte button;
        internal byte state;
        private byte padding1;
        private byte padding2;
    }
#pragma warning restore 0169
    /* Game controller device event (event.cdevice.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_ControllerDeviceEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal Int32 which; /* joystick id for ADDED, else
instance id */
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_TouchFingerEvent
    {
        internal UInt32 type;
        internal UInt32 timestamp;
        internal Int64 touchId; // SDL_TouchID
        internal Int64 fingerId; // SDL_GestureID
        internal float x;
        internal float y;
        internal float dx;
        internal float dy;
        internal float pressure;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_MultiGestureEvent
    {
        internal UInt32 type;
        internal UInt32 timestamp;
        internal Int64 touchId; // SDL_TouchID
        internal float dTheta;
        internal float dDist;
        internal float x;
        internal float y;
        internal UInt16 numFingers;
        internal UInt16 padding;
    }
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_DollarGestureEvent
    {
        internal UInt32 type;
        internal UInt32 timestamp;
        internal Int64 touchId; // SDL_TouchID
        internal Int64 gestureId; // SDL_GestureID
        internal UInt32 numFingers;
        internal float error;
        internal float x;
        internal float y;
    }
    /* File open request by system (event.drop.*), disabled by
    * default
    */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_DropEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal IntPtr file; /* char* filename, to be freed */
    }
    /* The "quit requested" event */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_QuitEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
    }
    /* A user defined event (event.user.*) */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_UserEvent
    {
        internal UInt32 type;
        internal UInt32 timestamp;
        internal UInt32 windowID;
        internal Int32 code;
        internal IntPtr data1; /* user-defined */
        internal IntPtr data2; /* user-defined */
    }
    /* A video driver dependent event (event.syswm.*), disabled */
    [StructLayout(LayoutKind.Sequential)]
    internal struct SDL_SysWMEvent
    {
        internal SDL_EventType type;
        internal UInt32 timestamp;
        internal IntPtr msg; /* SDL_SysWMmsg*, system-dependent*/
    }
    /* General event structure */
    // C# doesn't do unions, so we do this ugly thing. */
    [StructLayout(LayoutKind.Explicit)]
    internal struct SDL_Event
    {
        [FieldOffset(0)]
        internal SDL_EventType type;
        [FieldOffset(0)]
        internal SDL_WindowEvent window;
        [FieldOffset(0)]
        internal SDL_KeyboardEvent key;
        [FieldOffset(0)]
        internal SDL_TextEditingEvent edit;
        [FieldOffset(0)]
        internal SDL_TextInputEvent text;
        [FieldOffset(0)]
        internal SDL_MouseMotionEvent motion;
        [FieldOffset(0)]
        internal SDL_MouseButtonEvent button;
        [FieldOffset(0)]
        internal SDL_MouseWheelEvent wheel;
        [FieldOffset(0)]
        internal SDL_JoyAxisEvent jaxis;
        [FieldOffset(0)]
        internal SDL_JoyBallEvent jball;
        [FieldOffset(0)]
        internal SDL_JoyHatEvent jhat;
        [FieldOffset(0)]
        internal SDL_JoyButtonEvent jbutton;
        [FieldOffset(0)]
        internal SDL_JoyDeviceEvent jdevice;
        [FieldOffset(0)]
        internal SDL_ControllerAxisEvent caxis;
        [FieldOffset(0)]
        internal SDL_ControllerButtonEvent cbutton;
        [FieldOffset(0)]
        internal SDL_ControllerDeviceEvent cdevice;
        [FieldOffset(0)]
        internal SDL_QuitEvent quit;
        [FieldOffset(0)]
        internal SDL_UserEvent user;
        [FieldOffset(0)]
        internal SDL_SysWMEvent syswm;
        [FieldOffset(0)]
        internal SDL_TouchFingerEvent tfinger;
        [FieldOffset(0)]
        internal SDL_MultiGestureEvent mgesture;
        [FieldOffset(0)]
        internal SDL_DollarGestureEvent dgesture;
        [FieldOffset(0)]
        internal SDL_DropEvent drop;
    }
}
