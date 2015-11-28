﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Test.BoardTests
{
    [TestClass]
    public class Board_AddPiece_Given_EmptyBoard_Should
    {
        private Pawn Piece { get; set; }

        private Board Target { get; set; }

        [TestInitialize]
        public void BeforeEachTest()
        {
            Piece = new Pawn();
            Target = new Board();
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Not_Throw_Exception_When_Adding_A_Piece_To_An_Unoccupied_Square()
        {
            Target.AddPiece(new Pawn(), 2, 1);
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Throw_Exception_When_BoardCoordinate_Has_Larger_X_Value_Than_Board_Size()
        {
            ExtendedAssert.Throws<ArgumentException>(() => Target.AddPiece(new Pawn(), 9, 1));
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Throw_Exception_When_BoardCoordinate_Has_Larger_Y_Value_Than_Board_Size()
        {
            ExtendedAssert.Throws<ArgumentException>(() => Target.AddPiece(new Pawn(), 1, 9));
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Throw_Exception_When_BoardCoordinate_Has_Zero_X_Value()
        {
            ExtendedAssert.Throws<ArgumentException>(() => Target.AddPiece(new Pawn(), 0, 3));
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Accept_Rook_As_Argument_For_Piece()
        {
            Target.AddPiece(new Rook(), 1, 2);
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Throw_Exception_On_Null_Arguments()
        {
            ExtendedAssert.Throws<ArgumentNullException>(() => Target.AddPiece(null, 2, 3));
        }

        [TestMethod, Owner("ebd"), TestCategory("Proven"), TestCategory("Unit")]
        public void Result_In_Valid_Piece_At_9_9_When_BoardSize_Is_9()
        {
            Target = new Board(9);

            Target.AddPiece(new Rook(), 9, 9);
        }
    }
}
