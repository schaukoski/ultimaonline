using Server.Gumps;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server;

public class ZuluGump : Gump
{
    public Dictionary<int, int> col1 { get; set; }
    public Dictionary<int, int> col2 { get; set; }
    public Dictionary<int, int> col3 { get; set; }
    public Dictionary<int, int> col4 { get; set; }

    public ZuluGump(int x, int y) : base(x, y)
    {

    }

    public enum ZuluInputs
    {
        Clean = 2501,
        Scroll = 40135
    }

    public enum ZuluGumpButtons
    {
        ApplyYellow = 238,
        CancelRed = 241,
        DefaultBlue = 244,
        OkayGreen = 247,
        BlueBullet = 1209,
        BlueArrowBullet = 1625,
        CloseX = 1604,
        CloseMenus = 1623,
        CloseLeather = 2093,
        BulletLeather = 2094,
        BlueBulletMini = 2103,
        AutoYellow = 2111,
        ManualPurple = 2114,
        BlueBullet2 = 2117,
        BlueLeftBullet = 2223,
        BlueRightBullet = 2224,
        BlueUpBullet = 5841,
        RedTriangle = 2472,
        GreenArrowRight = 5540,
        RedArrowLeft = 5537,
        SilverArrowUP = 9900,
        SilverArrowRight = 9903,
        SilverArrowDown = 9906,
        SilverArrowLeft = 9909
            
    }

    public enum ZuluGumpImages
    {
        RedBar = 2053,
        BlueBar = 2054,
        GreenBar = 2056,
        YellowBar = 2057,
        RedBigBar = 2061,
        BlueBigBar = 2062,
        Lupa = 9011,
        GoldBullet = 10006,
    }

    public enum ZuluGumpChecks
    {
        BlueCheck = 2151,
        Blue2Check = 2152,
        GreenCheck = 5827,
        RedCheck = 5833,
        PurpleCheck = 5843,
        SilverCheck = 9721,
        SilverRock = 9026,

    }

    public enum ZuluGumpDivisors
    {
        Silver = 9101,
        Gold = 9151,
        Silver2 = 10000
    }

    public enum ZuluBanner
    {
        Small,
        Big
    }


    protected void AddCheck(int x, int y, ZuluGumpChecks checkid, bool initialState, int switchId)
    {
        int buttonId = (int)checkid;
        int checkedbuttonid = buttonId;
        switch (checkid)
        {
            case ZuluGumpChecks.BlueCheck:
                break;
            case ZuluGumpChecks.Blue2Check:
                break;
            case ZuluGumpChecks.SilverRock: checkedbuttonid++; break;

            default: checkedbuttonid = checkedbuttonid + 2; break;
        }
        if (checkid == ZuluGumpChecks.SilverRock)
            AddCheck(x, y, buttonId, buttonId+1, initialState, switchId);
        else
            AddCheck(x, y, buttonId, checkedbuttonid, initialState, switchId);
    }

    protected void AddRadio(int x, int y, ZuluGumpChecks checkid, bool initialState, int switchId)
    {
        int buttonId = (int)checkid;
        int pressedButtonId = buttonId;

        switch (checkid)
        {
            case ZuluGumpChecks.BlueCheck:
                break;
            case ZuluGumpChecks.Blue2Check:
                break;
            case ZuluGumpChecks.GreenCheck:
                break;
            case ZuluGumpChecks.RedCheck:
                break;
            case ZuluGumpChecks.PurpleCheck:
                break;
            case ZuluGumpChecks.SilverCheck:
                break;
            case ZuluGumpChecks.SilverRock:
                pressedButtonId++;
                break;
            default:
                pressedButtonId = pressedButtonId + 2;
                break;
        }

        AddRadio(x, y, buttonId, pressedButtonId, initialState, switchId);
    }


    protected void AddBanner(int x, int y, ZuluBanner size, int hue)
    {
        switch (size)
        {
            case ZuluBanner.Small:
                AddImage(x, y, 10503, hue);
                AddImage(x, y+15, 10504, hue);
                AddImage(x, y+20, 10505, hue);
                break;
            case ZuluBanner.Big:
                AddImage(x, y, 10553, hue);
                AddImage(x, y + 28, 10554, hue);
                AddImage(x, y + 31, 10555, hue);
                break;
            default:
                break;
        }

        

    }

    protected void AddButton(int x, int y, ZuluGumpButtons buttonType, GumpButtonType type = GumpButtonType.Reply, int param = 0)
    {
        int buttonid = (int)buttonType;

       
        switch (buttonType)
        {
            case ZuluGumpButtons.ApplyYellow:
            case ZuluGumpButtons.CancelRed:
            case ZuluGumpButtons.DefaultBlue:
            case ZuluGumpButtons.OkayGreen:
            case ZuluGumpButtons.AutoYellow:
            case ZuluGumpButtons.ManualPurple:
            case ZuluGumpButtons.RedTriangle:
            case ZuluGumpButtons.RedArrowLeft:
            case ZuluGumpButtons.GreenArrowRight:
            case ZuluGumpButtons.SilverArrowLeft:
            case ZuluGumpButtons.SilverArrowUP:
            case ZuluGumpButtons.SilverArrowDown:
            case ZuluGumpButtons.SilverArrowRight:
                AddButton(x, y, buttonid, buttonid + 1, buttonid + 2, type, param);
                break;
            case ZuluGumpButtons.BlueBullet:
            case ZuluGumpButtons.BlueBullet2:
            case ZuluGumpButtons.BlueArrowBullet:
            case ZuluGumpButtons.BulletLeather:
            case ZuluGumpButtons.BlueBulletMini:
            case ZuluGumpButtons.BlueUpBullet:
                AddButton(x, y, buttonid, buttonid + 1, buttonid + 1, type, param);
                break;
            case ZuluGumpButtons.CloseX:
            case ZuluGumpButtons.CloseLeather:
            case ZuluGumpButtons.BlueLeftBullet:
            case ZuluGumpButtons.BlueRightBullet:
                AddButton(x, y, buttonid, buttonid ,buttonid, type, param);
                break;
            default:
                break;
        }


    }

    protected void AddImage(int x, int y)
    {

    }


    //protected void AddBackgroundByUnits(
    //int x,
    //int y,
    //int widthUnits,
    //int heightUnits,
    //GumpLayout layout)
    //{
    //    if (widthUnits < 1 || heightUnits < 1)
    //        throw new ArgumentException("widthUnits e heightUnits devem ser >= 1");

    //    int c = layout.CornerSize;
    //    int cw = layout.CenterWidth;
    //    int ch = layout.CenterHeight;

    //    int widthPx = c * 2 + (cw * widthUnits);
    //    int heightPx = c * 2 + (ch * heightUnits);

    //    int centerStartX = x + c;
    //    int centerStartY = y + c;

    //    int bottomY = centerStartY + (ch * heightUnits);
    //    int rightX = centerStartX + (cw * widthUnits);

    //    // ───── Cantos ─────
    //    AddImage(x, y, layout.CornerTL);
    //    AddImage(rightX, y, layout.CornerTR);
    //    AddImage(x, bottomY, layout.CornerBL);
    //    AddImage(rightX, bottomY, layout.CornerBR);

    //    // ───── Top / Bottom ─────
    //    for (int i = 0; i < widthUnits; i++)
    //    {
    //        int px = centerStartX + (i * cw);

    //        AddImage(px, y, layout.EdgeTop);
    //        AddImage(px, bottomY, layout.EdgeBottom);
    //    }

    //    // ───── Left / Right ─────
    //    for (int i = 0; i < heightUnits; i++)
    //    {
    //        int py = centerStartY + (i * ch);

    //        AddImage(x, py, layout.EdgeLeft);
    //        AddImage(rightX, py, layout.EdgeRight);
    //    }

    //    // ───── Centro ─────
    //    for (int iy = 0; iy < heightUnits; iy++)
    //    {
    //        for (int ix = 0; ix < widthUnits; ix++)
    //        {
    //            AddImage(
    //                centerStartX + (ix * cw),
    //                centerStartY + (iy * ch),
    //                layout.Center
    //            );
    //        }
    //    }
    //}

    protected void AddBackgroundByUnits(
    int x,
    int y,
    int widthUnits,
    int heightUnits,
    GumpLayout layout)
    {
        if (widthUnits < 1 || heightUnits < 1)
            throw new ArgumentException("widthUnits e heightUnits devem ser >= 1");

        int c = layout.CornerSize;
        int cw = layout.CenterWidth;
        int ch = layout.CenterHeight;

        int eh = c;
        int ew = c;

        int centerStartX = x + c;
        int centerStartY = y + c;

        int centerEndX = centerStartX + (cw * widthUnits);
        int centerEndY = centerStartY + (ch * heightUnits);

        // ───── Cantos ─────
        AddImage(x, y, layout.CornerTL);
        AddImage(centerEndX, y, layout.CornerTR);
        AddImage(x, centerEndY, layout.CornerBL);
        AddImage(centerEndX, centerEndY, layout.CornerBR);

        // ───── Top / Bottom ─────
        for (int ix = 0; ix < widthUnits; ix++)
        {
            int px = centerStartX + (ix * cw);

            AddImage(px, y, layout.EdgeTop);
            AddImage(px, centerEndY, layout.EdgeBottom);
        }

        // ───── Left / Right ─────
        for (int iy = 0; iy < heightUnits; iy++)
        {
            int py = centerStartY + (iy * ch);

            AddImage(x, py, layout.EdgeLeft);
            AddImage(centerEndX, py, layout.EdgeRight);
        }

        // ───── Centro ─────
        for (int iy = 0; iy < heightUnits; iy++)
        {
            for (int ix = 0; ix < widthUnits; ix++)
            {
                AddImage(
                    centerStartX + (ix * cw),
                    centerStartY + (iy * ch),
                    layout.Center
                );
            }
        }
    }

    public static class ZuluGumpStyles
    {
        public static readonly GumpLayout White = new(
            cornerSize: 26,
            centerWidth: 240,
            centerHeight: 240,
            cornerTL: 3500,
            edgeTop: 3501,
            cornerTR: 3502,
            edgeLeft: 3503,
            center: 3504,

            edgeRight: 3505,
            cornerBL: 3506,
            edgeBottom: 3507,
            cornerBR: 3508


        );

        public static readonly GumpLayout Black = new(
        cornerSize: 18,
        centerWidth: 270,
        centerHeight: 206,

        cornerTL: 1755,
        edgeTop: 1756,
        cornerTR: 1757,
        edgeLeft: 1758,

        center: 1759,

        edgeRight: 1760,
        cornerBL: 1761,
        edgeBottom: 1762,
        cornerBR: 1763


    );


        public static readonly GumpLayout Black2 = new(
        cornerSize: 18,
        centerWidth: 266,
        centerHeight: 266,

        cornerTL: 2620,
        edgeTop: 2621,
        cornerTR: 2622,
        edgeLeft: 2623,

        center: 2624,

        edgeRight: 2625,
        cornerBL: 2626,
        edgeBottom: 2627,
        cornerBR: 2628


    );

        public static readonly GumpLayout Rock = new(
    cornerSize: 14,
    centerWidth: 128,
    centerHeight: 128,

    cornerTL: 3600,
    edgeTop: 3601,
    cornerTR: 3602,
    edgeLeft: 3603,

    center: 3604,

    edgeRight: 3605,
    cornerBL: 3606,
    edgeBottom: 3607,
    cornerBR: 3608


    );


        public static readonly GumpLayout Rock2 = new(
    cornerSize: 7,
    centerWidth: 128,
    centerHeight: 128,

    cornerTL: 9200,
    edgeTop: 9201,
    cornerTR: 9202,
    edgeLeft: 9203,

    center: 9204,

    edgeRight: 9205,
    cornerBL: 9206,
    edgeBottom: 9207,
    cornerBR: 9208


    );

        public static readonly GumpLayout Rock3 = new(
    cornerSize: 17,
    centerWidth: 128,
    centerHeight: 128,

    cornerTL: 9250,
    edgeTop: 9251,
    cornerTR: 9252,
    edgeLeft: 9253,

    center: 9254,

    edgeRight: 9255,
    cornerBL: 9256,
    edgeBottom: 9257,
    cornerBR: 9258


    );


        public static readonly GumpLayout Rock4 = new(
    cornerSize: 17,
    centerWidth: 128,
    centerHeight: 128,

    cornerTL: 9260,
    edgeTop: 9261,
    cornerTR: 9262,
    edgeLeft: 9263,

    center: 9264,

    edgeRight: 9265,
    cornerBL: 9266,
    edgeBottom: 9267,
    cornerBR: 9268


    );

        public static readonly GumpLayout Rock5 = new(
    cornerSize: 10,
    centerWidth: 128,
    centerHeight: 128,

    cornerTL: 9270,
    edgeTop: 9271,
    cornerTR: 9272,
    edgeLeft: 9273,

    center: 9274,

    edgeRight: 9275,
    cornerBL: 9276,
    edgeBottom: 9277,
    cornerBR: 9278


    );


        public static readonly GumpLayout Store = new(
    cornerSize: 35,
    centerWidth: 35,
    centerHeight: 35,

    cornerTL: 40000,
    edgeTop: 40001,
    cornerTR: 40002,
    edgeLeft: 40003,

    center: 40004,

    edgeRight: 40005,
    cornerBL: 40006,
    edgeBottom: 40007,
    cornerBR: 40008


    );


    }

    public readonly struct GumpLayout
    {
        public readonly int CornerTL;
        public readonly int CornerTR;
        public readonly int CornerBL;
        public readonly int CornerBR;

        public readonly int EdgeTop;
        public readonly int EdgeBottom;
        public readonly int EdgeLeft;
        public readonly int EdgeRight;

        public readonly int Center;
        public readonly int CenterWidth;
        public readonly int CenterHeight;

        public readonly int CornerSize;

        public GumpLayout(
            int cornerSize, int centerWidth, int centerHeight,
            int cornerTL, int cornerTR, int cornerBL, int cornerBR,
            int edgeTop, int edgeBottom, int edgeLeft, int edgeRight,
            int center)
        {
            CornerSize = cornerSize;
            CenterWidth = centerWidth;
            CenterHeight = centerHeight;

            CornerTL = cornerTL;
            CornerTR = cornerTR;
            CornerBL = cornerBL;
            CornerBR = cornerBR;

            EdgeTop = edgeTop;
            EdgeBottom = edgeBottom;
            EdgeLeft = edgeLeft;
            EdgeRight = edgeRight;

            Center = center;
        }
    }
}
