using System;
using NUnit.Framework;

namespace CleanCode.Sudoku.Tests
{
    [TestFixture]
    public class AcceptanceTest
    {  
        [Test]
	public void easyProblem() {
		check(SudokuExamples.EASY_PROBLEM, SudokuExamples.EASY_SOLUTION);
	}

	[Test]
	public void hardProblem() {
		check(SudokuExamples.HARD_PROBLEM, SudokuExamples.HARD_SOLUTION);
	}

    [Test]
	public void impossible() {
		int[,] problemGrid = Sudoku.parseProblem(SudokuExamples.NOT_SOLVABLE_PROBLEM);
		int[,] actualSolution = Sudoku.solve(problemGrid);
		Assert.That(actualSolution, Is.Null);
	}

	private void check(String problem, String solution) {
		int[,] solutionGrid = Sudoku.parseProblem(solution);
		int[,] problemGrid = Sudoku.parseProblem(problem);
		int[,] actualSolution = Sudoku.solve(problemGrid);
		Assert.That(Sudoku.prettyPrint(actualSolution) , Is.EqualTo( Sudoku.prettyPrint(solutionGrid) ));
	}
    }
}
