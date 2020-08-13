using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CorsairRGB.NET
{
    #region Enums
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum CorsairLedId
    {
        CLI_Invalid = 0,
        K_Escape = 1,
        K_F1 = 2,
        K_F2 = 3,
        K_F3 = 4,
        K_F4 = 5,
        K_F5 = 6,
        K_F6 = 7,
        K_F7 = 8,
        K_F8 = 9,
        K_F9 = 10,
        K_F10 = 11,
        K_F11 = 12,
        K_GraveAccentAndTilde = 13,
        K_1 = 14,
        K_2 = 15,
        K_3 = 16,
        K_4 = 17,
        K_5 = 18,
        K_6 = 19,
        K_7 = 20,
        K_8 = 21,
        K_9 = 22,
        K_0 = 23,
        K_MinusAndUnderscore = 24,
        K_Tab = 25,
        K_Q = 26,
        K_W = 27,
        K_E = 28,
        K_R = 29,
        K_T = 30,
        K_Y = 31,
        K_U = 32,
        K_I = 33,
        K_O = 34,
        K_P = 35,
        K_BracketLeft = 36,
        K_CapsLock = 37,
        K_A = 38,
        K_S = 39,
        K_D = 40,
        K_F = 41,
        K_G = 42,
        K_H = 43,
        K_J = 44,
        K_K = 45,
        K_L = 46,
        K_SemicolonAndColon = 47,
        K_ApostropheAndDoubleQuote = 48,
        K_LeftShift = 49,
        K_NonUsBackslash = 50,
        K_Z = 51,
        K_X = 52,
        K_C = 53,
        K_V = 54,
        K_B = 55,
        K_N = 56,
        K_M = 57,
        K_CommaAndLessThan = 58,
        K_PeriodAndBiggerThan = 59,
        K_SlashAndQuestionMark = 60,
        K_LeftCtrl = 61,
        K_LeftGui = 62,
        K_LeftAlt = 63,
        K_Lang2 = 64,
        K_Space = 65,
        K_Lang1 = 66,
        K_International2 = 67,
        K_RightAlt = 68,
        K_RightGui = 69,
        K_Application = 70,
        K_LedProgramming = 71,
        K_Brightness = 72,
        K_F12 = 73,
        K_PrintScreen = 74,
        K_ScrollLock = 75,
        K_PauseBreak = 76,
        K_Insert = 77,
        K_Home = 78,
        K_PageUp = 79,
        K_BracketRight = 80,
        K_Backslash = 81,
        K_NonUsTilde = 82,
        K_Enter = 83,
        K_International1 = 84,
        K_EqualsAndPlus = 85,
        K_International3 = 86,
        K_Backspace = 87,
        K_Delete = 88,
        K_End = 89,
        K_PageDown = 90,
        K_RightShift = 91,
        K_RightCtrl = 92,
        K_UpArrow = 93,
        K_LeftArrow = 94,
        K_DownArrow = 95,
        K_RightArrow = 96,
        K_WinLock = 97,
        K_Mute = 98,
        K_Stop = 99,
        K_ScanPreviousTrack = 100,
        K_PlayPause = 101,
        K_ScanNextTrack = 102,
        K_NumLock = 103,
        K_KeypadSlash = 104,
        K_KeypadAsterisk = 105,
        K_KeypadMinus = 106,
        K_KeypadPlus = 107,
        K_KeypadEnter = 108,
        K_Keypad7 = 109,
        K_Keypad8 = 110,
        K_Keypad9 = 111,
        K_KeypadComma = 112,
        K_Keypad4 = 113,
        K_Keypad5 = 114,
        K_Keypad6 = 115,
        K_Keypad1 = 116,
        K_Keypad2 = 117,
        K_Keypad3 = 118,
        K_Keypad0 = 119,
        K_KeypadPeriodAndDelete = 120,
        K_G1 = 121,
        K_G2 = 122,
        K_G3 = 123,
        K_G4 = 124,
        K_G5 = 125,
        K_G6 = 126,
        K_G7 = 127,
        K_G8 = 128,
        K_G9 = 129,
        K_G10 = 130,
        K_VolumeUp = 131,
        K_VolumeDown = 132,
        K_MR = 133,
        K_M1 = 134,
        K_M2 = 135,
        K_M3 = 136,
        K_G11 = 137,
        K_G12 = 138,
        K_G13 = 139,
        K_G14 = 140,
        K_G15 = 141,
        K_G16 = 142,
        K_G17 = 143,
        K_G18 = 144,
        K_International5 = 145,
        K_International4 = 146,
        K_Fn = 147,

        M_1 = 148,
        M_2 = 149,
        M_3 = 150,
        M_4 = 151,

        H_LeftLogo = 152,
        H_RightLogo = 153,

        K_Logo = 154,

        MM_Zone1 = 155,
        MM_Zone2 = 156,
        MM_Zone3 = 157,
        MM_Zone4 = 158,
        MM_Zone5 = 159,
        MM_Zone6 = 160,
        MM_Zone7 = 161,
        MM_Zone8 = 162,
        MM_Zone9 = 163,
        MM_Zone10 = 164,
        MM_Zone11 = 165,
        MM_Zone12 = 166,
        MM_Zone13 = 167,
        MM_Zone14 = 168,
        MM_Zone15 = 169,

        KLP_Zone1 = 170,
        KLP_Zone2 = 171,
        KLP_Zone3 = 172,
        KLP_Zone4 = 173,
        KLP_Zone5 = 174,
        KLP_Zone6 = 175,
        KLP_Zone7 = 176,
        KLP_Zone8 = 177,
        KLP_Zone9 = 178,
        KLP_Zone10 = 179,
        KLP_Zone11 = 180,
        KLP_Zone12 = 181,
        KLP_Zone13 = 182,
        KLP_Zone14 = 183,
        KLP_Zone15 = 184,
        KLP_Zone16 = 185,
        KLP_Zone17 = 186,
        KLP_Zone18 = 187,
        KLP_Zone19 = 188,

        M_5 = 189,
        M_6 = 190,

        HSS_Zone1 = 191,
        HSS_Zone2 = 192,
        HSS_Zone3 = 193,
        HSS_Zone4 = 194,
        HSS_Zone5 = 195,
        HSS_Zone6 = 196,
        HSS_Zone7 = 197,
        HSS_Zone8 = 198,
        HSS_Zone9 = 199,

        D_C1_1 = 200,
        D_C1_2 = 201,
        D_C1_3 = 202,
        D_C1_4 = 203,
        D_C1_5 = 204,
        D_C1_6 = 205,
        D_C1_7 = 206,
        D_C1_8 = 207,
        D_C1_9 = 208,
        D_C1_10 = 209,
        D_C1_11 = 210,
        D_C1_12 = 211,
        D_C1_13 = 212,
        D_C1_14 = 213,
        D_C1_15 = 214,
        D_C1_16 = 215,
        D_C1_17 = 216,
        D_C1_18 = 217,
        D_C1_19 = 218,
        D_C1_20 = 219,
        D_C1_21 = 220,
        D_C1_22 = 221,
        D_C1_23 = 222,
        D_C1_24 = 223,
        D_C1_25 = 224,
        D_C1_26 = 225,
        D_C1_27 = 226,
        D_C1_28 = 227,
        D_C1_29 = 228,
        D_C1_30 = 229,
        D_C1_31 = 230,
        D_C1_32 = 231,
        D_C1_33 = 232,
        D_C1_34 = 233,
        D_C1_35 = 234,
        D_C1_36 = 235,
        D_C1_37 = 236,
        D_C1_38 = 237,
        D_C1_39 = 238,
        D_C1_40 = 239,
        D_C1_41 = 240,
        D_C1_42 = 241,
        D_C1_43 = 242,
        D_C1_44 = 243,
        D_C1_45 = 244,
        D_C1_46 = 245,
        D_C1_47 = 246,
        D_C1_48 = 247,
        D_C1_49 = 248,
        D_C1_50 = 249,
        D_C1_51 = 250,
        D_C1_52 = 251,
        D_C1_53 = 252,
        D_C1_54 = 253,
        D_C1_55 = 254,
        D_C1_56 = 255,
        D_C1_57 = 256,
        D_C1_58 = 257,
        D_C1_59 = 258,
        D_C1_60 = 259,
        D_C1_61 = 260,
        D_C1_62 = 261,
        D_C1_63 = 262,
        D_C1_64 = 263,
        D_C1_65 = 264,
        D_C1_66 = 265,
        D_C1_67 = 266,
        D_C1_68 = 267,
        D_C1_69 = 268,
        D_C1_70 = 269,
        D_C1_71 = 270,
        D_C1_72 = 271,
        D_C1_73 = 272,
        D_C1_74 = 273,
        D_C1_75 = 274,
        D_C1_76 = 275,
        D_C1_77 = 276,
        D_C1_78 = 277,
        D_C1_79 = 278,
        D_C1_80 = 279,
        D_C1_81 = 280,
        D_C1_82 = 281,
        D_C1_83 = 282,
        D_C1_84 = 283,
        D_C1_85 = 284,
        D_C1_86 = 285,
        D_C1_87 = 286,
        D_C1_88 = 287,
        D_C1_89 = 288,
        D_C1_90 = 289,
        D_C1_91 = 290,
        D_C1_92 = 291,
        D_C1_93 = 292,
        D_C1_94 = 293,
        D_C1_95 = 294,
        D_C1_96 = 295,
        D_C1_97 = 296,
        D_C1_98 = 297,
        D_C1_99 = 298,
        D_C1_100 = 299,
        D_C1_101 = 300,
        D_C1_102 = 301,
        D_C1_103 = 302,
        D_C1_104 = 303,
        D_C1_105 = 304,
        D_C1_106 = 305,
        D_C1_107 = 306,
        D_C1_108 = 307,
        D_C1_109 = 308,
        D_C1_110 = 309,
        D_C1_111 = 310,
        D_C1_112 = 311,
        D_C1_113 = 312,
        D_C1_114 = 313,
        D_C1_115 = 314,
        D_C1_116 = 315,
        D_C1_117 = 316,
        D_C1_118 = 317,
        D_C1_119 = 318,
        D_C1_120 = 319,
        D_C1_121 = 320,
        D_C1_122 = 321,
        D_C1_123 = 322,
        D_C1_124 = 323,
        D_C1_125 = 324,
        D_C1_126 = 325,
        D_C1_127 = 326,
        D_C1_128 = 327,
        D_C1_129 = 328,
        D_C1_130 = 329,
        D_C1_131 = 330,
        D_C1_132 = 331,
        D_C1_133 = 332,
        D_C1_134 = 333,
        D_C1_135 = 334,
        D_C1_136 = 335,
        D_C1_137 = 336,
        D_C1_138 = 337,
        D_C1_139 = 338,
        D_C1_140 = 339,
        D_C1_141 = 340,
        D_C1_142 = 341,
        D_C1_143 = 342,
        D_C1_144 = 343,
        D_C1_145 = 344,
        D_C1_146 = 345,
        D_C1_147 = 346,
        D_C1_148 = 347,
        D_C1_149 = 348,
        D_C1_150 = 349,

        D_C2_1 = 350,
        D_C2_2 = 351,
        D_C2_3 = 352,
        D_C2_4 = 353,
        D_C2_5 = 354,
        D_C2_6 = 355,
        D_C2_7 = 356,
        D_C2_8 = 357,
        D_C2_9 = 358,
        D_C2_10 = 359,
        D_C2_11 = 360,
        D_C2_12 = 361,
        D_C2_13 = 362,
        D_C2_14 = 363,
        D_C2_15 = 364,
        D_C2_16 = 365,
        D_C2_17 = 366,
        D_C2_18 = 367,
        D_C2_19 = 368,
        D_C2_20 = 369,
        D_C2_21 = 370,
        D_C2_22 = 371,
        D_C2_23 = 372,
        D_C2_24 = 373,
        D_C2_25 = 374,
        D_C2_26 = 375,
        D_C2_27 = 376,
        D_C2_28 = 377,
        D_C2_29 = 378,
        D_C2_30 = 379,
        D_C2_31 = 380,
        D_C2_32 = 381,
        D_C2_33 = 382,
        D_C2_34 = 383,
        D_C2_35 = 384,
        D_C2_36 = 385,
        D_C2_37 = 386,
        D_C2_38 = 387,
        D_C2_39 = 388,
        D_C2_40 = 389,
        D_C2_41 = 390,
        D_C2_42 = 391,
        D_C2_43 = 392,
        D_C2_44 = 393,
        D_C2_45 = 394,
        D_C2_46 = 395,
        D_C2_47 = 396,
        D_C2_48 = 397,
        D_C2_49 = 398,
        D_C2_50 = 399,
        D_C2_51 = 400,
        D_C2_52 = 401,
        D_C2_53 = 402,
        D_C2_54 = 403,
        D_C2_55 = 404,
        D_C2_56 = 405,
        D_C2_57 = 406,
        D_C2_58 = 407,
        D_C2_59 = 408,
        D_C2_60 = 409,
        D_C2_61 = 410,
        D_C2_62 = 411,
        D_C2_63 = 412,
        D_C2_64 = 413,
        D_C2_65 = 414,
        D_C2_66 = 415,
        D_C2_67 = 416,
        D_C2_68 = 417,
        D_C2_69 = 418,
        D_C2_70 = 419,
        D_C2_71 = 420,
        D_C2_72 = 421,
        D_C2_73 = 422,
        D_C2_74 = 423,
        D_C2_75 = 424,
        D_C2_76 = 425,
        D_C2_77 = 426,
        D_C2_78 = 427,
        D_C2_79 = 428,
        D_C2_80 = 429,
        D_C2_81 = 430,
        D_C2_82 = 431,
        D_C2_83 = 432,
        D_C2_84 = 433,
        D_C2_85 = 434,
        D_C2_86 = 435,
        D_C2_87 = 436,
        D_C2_88 = 437,
        D_C2_89 = 438,
        D_C2_90 = 439,
        D_C2_91 = 440,
        D_C2_92 = 441,
        D_C2_93 = 442,
        D_C2_94 = 443,
        D_C2_95 = 444,
        D_C2_96 = 445,
        D_C2_97 = 446,
        D_C2_98 = 447,
        D_C2_99 = 448,
        D_C2_100 = 449,
        D_C2_101 = 450,
        D_C2_102 = 451,
        D_C2_103 = 452,
        D_C2_104 = 453,
        D_C2_105 = 454,
        D_C2_106 = 455,
        D_C2_107 = 456,
        D_C2_108 = 457,
        D_C2_109 = 458,
        D_C2_110 = 459,
        D_C2_111 = 460,
        D_C2_112 = 461,
        D_C2_113 = 462,
        D_C2_114 = 463,
        D_C2_115 = 464,
        D_C2_116 = 465,
        D_C2_117 = 466,
        D_C2_118 = 467,
        D_C2_119 = 468,
        D_C2_120 = 469,
        D_C2_121 = 470,
        D_C2_122 = 471,
        D_C2_123 = 472,
        D_C2_124 = 473,
        D_C2_125 = 474,
        D_C2_126 = 475,
        D_C2_127 = 476,
        D_C2_128 = 477,
        D_C2_129 = 478,
        D_C2_130 = 479,
        D_C2_131 = 480,
        D_C2_132 = 481,
        D_C2_133 = 482,
        D_C2_134 = 483,
        D_C2_135 = 484,
        D_C2_136 = 485,
        D_C2_137 = 486,
        D_C2_138 = 487,
        D_C2_139 = 488,
        D_C2_140 = 489,
        D_C2_141 = 490,
        D_C2_142 = 491,
        D_C2_143 = 492,
        D_C2_144 = 493,
        D_C2_145 = 494,
        D_C2_146 = 495,
        D_C2_147 = 496,
        D_C2_148 = 497,
        D_C2_149 = 498,
        D_C2_150 = 499,

        I_Oem1 = 500,
        I_Oem2 = 501,
        I_Oem3 = 502,
        I_Oem4 = 503,
        I_Oem5 = 504,
        I_Oem6 = 505,
        I_Oem7 = 506,
        I_Oem8 = 507,
        I_Oem9 = 508,
        I_Oem10 = 509,
        I_Oem11 = 510,
        I_Oem12 = 511,
        I_Oem13 = 512,
        I_Oem14 = 513,
        I_Oem15 = 514,
        I_Oem16 = 515,
        I_Oem17 = 516,
        I_Oem18 = 517,
        I_Oem19 = 518,
        I_Oem20 = 519,
        I_Oem21 = 520,
        I_Oem22 = 521,
        I_Oem23 = 522,
        I_Oem24 = 523,
        I_Oem25 = 524,
        I_Oem26 = 525,
        I_Oem27 = 526,
        I_Oem28 = 527,
        I_Oem29 = 528,
        I_Oem30 = 529,
        I_Oem31 = 530,
        I_Oem32 = 531,
        I_Oem33 = 532,
        I_Oem34 = 533,
        I_Oem35 = 534,
        I_Oem36 = 535,
        I_Oem37 = 536,
        I_Oem38 = 537,
        I_Oem39 = 538,
        I_Oem40 = 539,
        I_Oem41 = 540,
        I_Oem42 = 541,
        I_Oem43 = 542,
        I_Oem44 = 543,
        I_Oem45 = 544,
        I_Oem46 = 545,
        I_Oem47 = 546,
        I_Oem48 = 547,
        I_Oem49 = 548,
        I_Oem50 = 549,
        I_Oem51 = 550,
        I_Oem52 = 551,
        I_Oem53 = 552,
        I_Oem54 = 553,
        I_Oem55 = 554,
        I_Oem56 = 555,
        I_Oem57 = 556,
        I_Oem58 = 557,
        I_Oem59 = 558,
        I_Oem60 = 559,
        I_Oem61 = 560,
        I_Oem62 = 561,
        I_Oem63 = 562,
        I_Oem64 = 563,
        I_Oem65 = 564,
        I_Oem66 = 565,
        I_Oem67 = 566,
        I_Oem68 = 567,
        I_Oem69 = 568,
        I_Oem70 = 569,
        I_Oem71 = 570,
        I_Oem72 = 571,
        I_Oem73 = 572,
        I_Oem74 = 573,
        I_Oem75 = 574,
        I_Oem76 = 575,
        I_Oem77 = 576,
        I_Oem78 = 577,
        I_Oem79 = 578,
        I_Oem80 = 579,
        I_Oem81 = 580,
        I_Oem82 = 581,
        I_Oem83 = 582,
        I_Oem84 = 583,
        I_Oem85 = 584,
        I_Oem86 = 585,
        I_Oem87 = 586,
        I_Oem88 = 587,
        I_Oem89 = 588,
        I_Oem90 = 589,
        I_Oem91 = 590,
        I_Oem92 = 591,
        I_Oem93 = 592,
        I_Oem94 = 593,
        I_Oem95 = 594,
        I_Oem96 = 595,
        I_Oem97 = 596,
        I_Oem98 = 597,
        I_Oem99 = 598,
        I_Oem100 = 599,

        DRAM_1 = 600,
        DRAM_2 = 601,
        DRAM_3 = 602,
        DRAM_4 = 603,
        DRAM_5 = 604,
        DRAM_6 = 605,
        DRAM_7 = 606,
        DRAM_8 = 607,
        DRAM_9 = 608,
        DRAM_10 = 609,
        DRAM_11 = 610,
        DRAM_12 = 611,

        D_C3_1 = 612,
        D_C3_2 = 613,
        D_C3_3 = 614,
        D_C3_4 = 615,
        D_C3_5 = 616,
        D_C3_6 = 617,
        D_C3_7 = 618,
        D_C3_8 = 619,
        D_C3_9 = 620,
        D_C3_10 = 621,
        D_C3_11 = 622,
        D_C3_12 = 623,
        D_C3_13 = 624,
        D_C3_14 = 625,
        D_C3_15 = 626,
        D_C3_16 = 627,
        D_C3_17 = 628,
        D_C3_18 = 629,
        D_C3_19 = 630,
        D_C3_20 = 631,
        D_C3_21 = 632,
        D_C3_22 = 633,
        D_C3_23 = 634,
        D_C3_24 = 635,
        D_C3_25 = 636,
        D_C3_26 = 637,
        D_C3_27 = 638,
        D_C3_28 = 639,
        D_C3_29 = 640,
        D_C3_30 = 641,
        D_C3_31 = 642,
        D_C3_32 = 643,
        D_C3_33 = 644,
        D_C3_34 = 645,
        D_C3_35 = 646,
        D_C3_36 = 647,
        D_C3_37 = 648,
        D_C3_38 = 649,
        D_C3_39 = 650,
        D_C3_40 = 651,
        D_C3_41 = 652,
        D_C3_42 = 653,
        D_C3_43 = 654,
        D_C3_44 = 655,
        D_C3_45 = 656,
        D_C3_46 = 657,
        D_C3_47 = 658,
        D_C3_48 = 659,
        D_C3_49 = 660,
        D_C3_50 = 661,
        D_C3_51 = 662,
        D_C3_52 = 663,
        D_C3_53 = 664,
        D_C3_54 = 665,
        D_C3_55 = 666,
        D_C3_56 = 667,
        D_C3_57 = 668,
        D_C3_58 = 669,
        D_C3_59 = 670,
        D_C3_60 = 671,
        D_C3_61 = 672,
        D_C3_62 = 673,
        D_C3_63 = 674,
        D_C3_64 = 675,
        D_C3_65 = 676,
        D_C3_66 = 677,
        D_C3_67 = 678,
        D_C3_68 = 679,
        D_C3_69 = 680,
        D_C3_70 = 681,
        D_C3_71 = 682,
        D_C3_72 = 683,
        D_C3_73 = 684,
        D_C3_74 = 685,
        D_C3_75 = 686,
        D_C3_76 = 687,
        D_C3_77 = 688,
        D_C3_78 = 689,
        D_C3_79 = 690,
        D_C3_80 = 691,
        D_C3_81 = 692,
        D_C3_82 = 693,
        D_C3_83 = 694,
        D_C3_84 = 695,
        D_C3_85 = 696,
        D_C3_86 = 697,
        D_C3_87 = 698,
        D_C3_88 = 699,
        D_C3_89 = 700,
        D_C3_90 = 701,
        D_C3_91 = 702,
        D_C3_92 = 703,
        D_C3_93 = 704,
        D_C3_94 = 705,
        D_C3_95 = 706,
        D_C3_96 = 707,
        D_C3_97 = 708,
        D_C3_98 = 709,
        D_C3_99 = 710,
        D_C3_100 = 711,
        D_C3_101 = 712,
        D_C3_102 = 713,
        D_C3_103 = 714,
        D_C3_104 = 715,
        D_C3_105 = 716,
        D_C3_106 = 717,
        D_C3_107 = 718,
        D_C3_108 = 719,
        D_C3_109 = 720,
        D_C3_110 = 721,
        D_C3_111 = 722,
        D_C3_112 = 723,
        D_C3_113 = 724,
        D_C3_114 = 725,
        D_C3_115 = 726,
        D_C3_116 = 727,
        D_C3_117 = 728,
        D_C3_118 = 729,
        D_C3_119 = 730,
        D_C3_120 = 731,
        D_C3_121 = 732,
        D_C3_122 = 733,
        D_C3_123 = 734,
        D_C3_124 = 735,
        D_C3_125 = 736,
        D_C3_126 = 737,
        D_C3_127 = 738,
        D_C3_128 = 739,
        D_C3_129 = 740,
        D_C3_130 = 741,
        D_C3_131 = 742,
        D_C3_132 = 743,
        D_C3_133 = 744,
        D_C3_134 = 745,
        D_C3_135 = 746,
        D_C3_136 = 747,
        D_C3_137 = 748,
        D_C3_138 = 749,
        D_C3_139 = 750,
        D_C3_140 = 751,
        D_C3_141 = 752,
        D_C3_142 = 753,
        D_C3_143 = 754,
        D_C3_144 = 755,
        D_C3_145 = 756,
        D_C3_146 = 757,
        D_C3_147 = 758,
        D_C3_148 = 759,
        D_C3_149 = 760,
        D_C3_150 = 761,

        LC_C1_1 = 762,
        LC_C1_2 = 763,
        LC_C1_3 = 764,
        LC_C1_4 = 765,
        LC_C1_5 = 766,
        LC_C1_6 = 767,
        LC_C1_7 = 768,
        LC_C1_8 = 769,
        LC_C1_9 = 770,
        LC_C1_10 = 771,
        LC_C1_11 = 772,
        LC_C1_12 = 773,
        LC_C1_13 = 774,
        LC_C1_14 = 775,
        LC_C1_15 = 776,
        LC_C1_16 = 777,
        LC_C1_17 = 778,
        LC_C1_18 = 779,
        LC_C1_19 = 780,
        LC_C1_20 = 781,
        LC_C1_21 = 782,
        LC_C1_22 = 783,
        LC_C1_23 = 784,
        LC_C1_24 = 785,
        LC_C1_25 = 786,
        LC_C1_26 = 787,
        LC_C1_27 = 788,
        LC_C1_28 = 789,
        LC_C1_29 = 790,
        LC_C1_30 = 791,
        LC_C1_31 = 792,
        LC_C1_32 = 793,
        LC_C1_33 = 794,
        LC_C1_34 = 795,
        LC_C1_35 = 796,
        LC_C1_36 = 797,
        LC_C1_37 = 798,
        LC_C1_38 = 799,
        LC_C1_39 = 800,
        LC_C1_40 = 801,
        LC_C1_41 = 802,
        LC_C1_42 = 803,
        LC_C1_43 = 804,
        LC_C1_44 = 805,
        LC_C1_45 = 806,
        LC_C1_46 = 807,
        LC_C1_47 = 808,
        LC_C1_48 = 809,
        LC_C1_49 = 810,
        LC_C1_50 = 811,
        LC_C1_51 = 812,
        LC_C1_52 = 813,
        LC_C1_53 = 814,
        LC_C1_54 = 815,
        LC_C1_55 = 816,
        LC_C1_56 = 817,
        LC_C1_57 = 818,
        LC_C1_58 = 819,
        LC_C1_59 = 820,
        LC_C1_60 = 821,
        LC_C1_61 = 822,
        LC_C1_62 = 823,
        LC_C1_63 = 824,
        LC_C1_64 = 825,
        LC_C1_65 = 826,
        LC_C1_66 = 827,
        LC_C1_67 = 828,
        LC_C1_68 = 829,
        LC_C1_69 = 830,
        LC_C1_70 = 831,
        LC_C1_71 = 832,
        LC_C1_72 = 833,
        LC_C1_73 = 834,
        LC_C1_74 = 835,
        LC_C1_75 = 836,
        LC_C1_76 = 837,
        LC_C1_77 = 838,
        LC_C1_78 = 839,
        LC_C1_79 = 840,
        LC_C1_80 = 841,
        LC_C1_81 = 842,
        LC_C1_82 = 843,
        LC_C1_83 = 844,
        LC_C1_84 = 845,
        LC_C1_85 = 846,
        LC_C1_86 = 847,
        LC_C1_87 = 848,
        LC_C1_88 = 849,
        LC_C1_89 = 850,
        LC_C1_90 = 851,
        LC_C1_91 = 852,
        LC_C1_92 = 853,
        LC_C1_93 = 854,
        LC_C1_94 = 855,
        LC_C1_95 = 856,
        LC_C1_96 = 857,
        LC_C1_97 = 858,
        LC_C1_98 = 859,
        LC_C1_99 = 860,
        LC_C1_100 = 861,
        LC_C1_101 = 862,
        LC_C1_102 = 863,
        LC_C1_103 = 864,
        LC_C1_104 = 865,
        LC_C1_105 = 866,
        LC_C1_106 = 867,
        LC_C1_107 = 868,
        LC_C1_108 = 869,
        LC_C1_109 = 870,
        LC_C1_110 = 871,
        LC_C1_111 = 872,
        LC_C1_112 = 873,
        LC_C1_113 = 874,
        LC_C1_114 = 875,
        LC_C1_115 = 876,
        LC_C1_116 = 877,
        LC_C1_117 = 878,
        LC_C1_118 = 879,
        LC_C1_119 = 880,
        LC_C1_120 = 881,
        LC_C1_121 = 882,
        LC_C1_122 = 883,
        LC_C1_123 = 884,
        LC_C1_124 = 885,
        LC_C1_125 = 886,
        LC_C1_126 = 887,
        LC_C1_127 = 888,
        LC_C1_128 = 889,
        LC_C1_129 = 890,
        LC_C1_130 = 891,
        LC_C1_131 = 892,
        LC_C1_132 = 893,
        LC_C1_133 = 894,
        LC_C1_134 = 895,
        LC_C1_135 = 896,
        LC_C1_136 = 897,
        LC_C1_137 = 898,
        LC_C1_138 = 899,
        LC_C1_139 = 900,
        LC_C1_140 = 901,
        LC_C1_141 = 902,
        LC_C1_142 = 903,
        LC_C1_143 = 904,
        LC_C1_144 = 905,
        LC_C1_145 = 906,
        LC_C1_146 = 907,
        LC_C1_147 = 908,
        LC_C1_148 = 909,
        LC_C1_149 = 910,
        LC_C1_150 = 911,

        I_Last = LC_C1_150
    };

    /// <summary>
    /// Contains list of available device types
    /// </summary>
    public enum CorsairDeviceType
    {
        Unknown = 0,
        Mouse = 1,
        Keyboard = 2,
        Headset = 3,
        MouseMat = 4,
        HeadsetStand = 5,
        CommanderPro = 6,
        LightingNodePro = 7,
        MemoryModule = 8,
        Cooler = 9
    };

    /// <summary>
    /// Contains list of available physical layouts for keyboards
    /// </summary>
    public enum CorsairPhysicalLayout
    {
        Invalid = 0,        // dummy value.

        US = 1,
        UK = 2,
        BR = 3,
        JP = 4,
        KR = 5,             // valid values for keyboard.

        Zones1 = 6,
        Zones2 = 7,
        Zones3 = 8,
        Zones4 = 9          // valid values for mouse.
    };

    /// <summary>
    /// Contains list of available logical layouts for keyboards
    /// </summary>
    public enum CorsairLogicalLayout
    {
        Invalid = 0,        // dummy value.
        US_Int = 1,
        NA = 2,
        EU = 3,
        UK = 4,
        BE = 5,
        BR = 6,
        CH = 7,
        CN = 8,
        DE = 9,
        ES = 10,
        FR = 11,
        IT = 12,
        ND = 13,
        RU = 14,
        JP = 15,
        KR = 16,
        TW = 17,
        MEX = 18
    };

    /// <summary>
    /// Contains list of device capabilities
    /// </summary>
    public enum CorsairDeviceCaps
    {
        None = 0x0000, // for devices that do not support any SDK functions.
        Lighting = 0x0001, // for devices that has controlled lighting.
        PropertyLookup = 0x0002  // for devices that provide current state through set of properties.
    };

    /// <summary>
    /// contains list of available SDK access modes
    /// </summary>
    public enum CorsairAccessMode
    {
        ExclusiveLightingControl = 0
    };

    /// <summary>
    /// Contains shared list of all errors which could happen during calling of Corsair* functions.
    /// </summary>
    public enum CorsairError
    {
        Success,                     // if previously called function completed successfully.
        ServerNotFound,              // CUE is not running or was shut down or third-party control is disabled in CUE settings(runtime error).
        NoControl,                   // if some other client has or took over exclusive control (runtime error).
        ProtocolHandshakeMissing,    // if developer did not perform protocol handshake(developer error).
        IncompatibleProtocol,        // if developer is calling the function that is not supported by the server(either because protocol has broken by server or client or because the function is new and server is too old. Check CorsairProtocolDetails for details) (developer error).
        InvalidArguments,            // if developer supplied invalid arguments to the function(for specifics look at function descriptions). (developer error).
    };

    /// <summary>
    /// Contains list of the LED-devices which can be connected to the DIY-device.
    /// </summary>
    public enum CorsairChannelDeviceType
    {
        Invalid = 0,
        HD_Fan = 1,
        SP_Fan = 2,
        LL_Fan = 3,
        ML_Fan = 4,
        Strip = 5,
        DAP = 6,
        Pump = 7
    };
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    #endregion

    /// <summary>
    /// Contains information about led and its color
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairLedColor
    {
        /// <summary>
        /// identifier of LED to set.
        /// </summary>
        public CorsairLedId LedId;

        /// <summary>
        /// Red Value [0..255]
        /// </summary>
        public int R;

        /// <summary>
        /// Green Value [0..255]
        /// </summary>
        public int G;

        /// <summary>
        /// Blue Value [0..255]
        /// </summary>
        public int B;
    };

    /// <summary>
    /// Contains information about separate LED-device connected to the channel controlled by the DIY-device.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct CorsairChannelDeviceInfo
    {
        /// <summary>
        /// Type of the LED Device.
        /// </summary>
        public CorsairChannelDeviceType Type;

        /// <summary>
        /// Number of LEDs controlled by LED-device.
        /// </summary>
        public int DeviceLedCount;
    };

#pragma warning disable IDE1006 // Naming Styles
    #region CorsairProtocolDetails

    /// <summary>
    /// contains information about SDK and CUE versions.
    /// </summary>
    public struct CorsairProtocolDetails
    {
        /// <summary>
        /// Version of SDK(like “1.0.0.1”). Always contains valid value even if there was no CUE found.
        /// </summary>
        public string SdkVersion;

        /// <summary>
        /// Version of CUE(like “1.0.0.1”) or NULL if CUE was not found.
        /// </summary>
        public string ServerVersion;

        /// <summary>
        /// integer number that specifies version of protocol that is implemented by current SDK.
        /// Numbering starts from 1. Always contains valid value even if there was no CUE found.
        /// </summary>
        public int SdkProtocolVersion;

        /// <summary>
        /// integer number that specifies version of protocol that is implemented by CUE. 
        /// Numbering starts from 1. If CUE was not found then this value will be 0.
        /// </summary>
        public int ServerProtocolVersion;

        /// <summary>
        /// Boolean value that specifies if there were breaking changes between version of protocol implemented by server and client.
        /// </summary>
        public bool BreakingChanges;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _CorsairProtocolDetails
#pragma warning restore IDE1006 // Naming Styles
    {
        internal IntPtr sdkVersion;
        internal IntPtr serverVersion;
        internal int sdkProtocolVersion;
        internal int serverProtocolVersion;
        internal byte breakingChanges;
    }
    #endregion

    #region CorsairDeviceInfo
    /// <summary>
    /// Contains information about device.
    /// </summary>
    public struct CorsairDeviceInfo
    {
        /// <summary>
        /// Enum describing device type.
        /// </summary>
        public CorsairDeviceType Type;

        /// <summary>
        /// Device model(like “K95RGB”).
        /// </summary>
        public string Model;

        /// <summary>
        /// Enum describing physical layout of the keyboard or mouse.
        /// </summary>
        public CorsairPhysicalLayout PhysicalLayout;

        /// <summary>
        /// enum describing logical layout of the keyboard as set in CUE settings.
        /// </summary>
        public CorsairLogicalLayout LogicalLayout;

        /// <summary>
        /// Mask that describes device capabilities, formed as logical “or” of CorsairDeviceCaps enum values.
        /// </summary>
        public CorsairDeviceCaps CapsMask;

        /// <summary>
        /// Number of controllable LEDs on the device.
        /// </summary>
        public int LedsCount;

        /// <summary>
        /// Structure that describes channels of the DIY-devices.
        /// </summary>
        public CorsairChannelsInfo Channels;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _CorsairDeviceInfo
    {
        internal int type;
        internal IntPtr model;
        internal int physicalLayout;
        internal int logicalLayout;
        internal int capsMask;
        internal int ledsCount;
        internal _CorsairChannelsInfo channels;
    }
    #endregion

    #region CorsairChannelsInfo
    /// <summary>
    /// contains information about channels of the DIY-devices.
    /// </summary>
    public struct CorsairChannelsInfo
    {
        /// <summary>
        /// number of channels controlled by the device.
        /// </summary>
        public int ChannelsCount;

        /// <summary>
        /// array containing information about each separate channel of the DIY-device. 
        /// Index of the channel in the array is same as index of the channel on the DIY-device.
        /// </summary>
        public CorsairChannelInfo[] Channels;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _CorsairChannelsInfo
    {
        internal int channelsCount;
        internal IntPtr channels;
    }
    #endregion

    #region CorsairChannelInfo
    /// <summary>
    /// Contains information about separate channel of the DIY-device.
    /// </summary>
    public struct CorsairChannelInfo
    {
        /// <summary>
        /// Total number of LEDs connected to the channel.
        /// </summary>
        public int TotalLedsCount;

        /// <summary>
        /// Number of LED-devices (fans, strips, etc.) connected to the channel which is controlled by the DIY device.
        /// </summary>
        public int DevicesCount;

        /// <summary>
        /// Array containing information about each separate LED-device connected to the channel controlled by the DIY device.
        /// Index of the LED-device in array is same as the index of the LED-device connected to the DIY-device.
        /// </summary>
        public CorsairChannelDeviceInfo[] Devices;
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct _CorsairChannelInfo
    {
        internal int totalLedsCount;
        internal int devicesCount;
        internal IntPtr devices;
    }
    #endregion
}