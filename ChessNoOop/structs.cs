using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    // Цвета шахматных фигур
    enum FigureColor { Black, White };

    // Стурктура для описания хода игрока:
    // координаты клетки, откуда игрок ходит, и координаты - куда
    struct Move
    {
        int colFrom;
        int rowFrom;
        int colTo;
        int rowTo;
    }
}
