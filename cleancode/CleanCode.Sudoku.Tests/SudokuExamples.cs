using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Sudoku.Tests
{
    public class SudokuExamples {
        public const string EASY_PROBLEM =          "342005010" +
											        "000020000" +
											        "806900040" +
											        "000001009" +
											        "407200008" +
											        "000009006" +
											        "905400080" +
											        "000060000" +
											        "238007050";

		public const string EASY_SOLUTION =         "342685917" +
													"159724863" +
													"876913245" +
													"623841579" +
													"497256138" +
													"581379426" +
													"965432781" +
													"714568392" +
													"238197654";
                
        public const string HARD_PROBLEM =          "412500000" +
											        "300000700" +
											        "000080240" +
											        "000050000" +
											        "500007400" +
											        "603400009" +
											        "800900002" +
											        "000000004" +
											        "007240013";
        
        public const string HARD_SOLUTION =         "412579368" +
											        "368124795" +
											        "795683241" +
											        "249856137" +
											        "581397426" +
											        "673412859" +
											        "834961572" +
											        "126735984" +
											        "957248613";

        public const string NOT_SOLVABLE_PROBLEM =          "412500000" +
													        "300000700" +
													        "000008240" +
													        "000050000" +
													        "500007400" +
													        "603400009" +
													        "800900002" +
													        "000000004" +
													        "007240013";
}
}
