﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chess.Test.BoardTests
{
    [TestClass]
    public class Board_MovePiece_Given_Chessboard_With_EnPassantScenarios_Should
    {
        private Board Target { get; set; }

        [TestInitialize]
        public void BeforeEachTest()
        {
            Target = new Board();
            new PiecePositioner(Target).SetupStandardBoard();
            Target.MovePiece(2, 7, 2, 5);
            Target.MovePiece(2, 5, 2, 4);
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Set_BlackPawns_CanPerformEnPassant_For_WhitePiece_At_14()
        {
            Target.MovePiece(1, 2, 1, 4);

            var piece = Target.GetPiece(2, 4) as Pawn;
            
            Assert.IsTrue(piece.CanPerformEnPassantOn(BoardCoordinate.For(1, 4)));
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Not_Set_BlackPawns_CanPerformEnPassantOn_For_Square_At_34()
        {
            Target.MovePiece(1, 2, 1, 4);

            var piece = Target.GetPiece(2, 4) as Pawn;

            Assert.IsFalse(piece.CanPerformEnPassantOn(BoardCoordinate.For(3, 4)));
        }
    }
}
